<%@ Page Language="vb" AutoEventWireup="false" Codebehind="gantt_chart.aspx.vb" Inherits="srx.gantt_chart" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="System.Web.Script.Serialization" %>
<%@ Import Namespace="System.Configuration" %>
<%@ Import Namespace="System.Data" %>

<script runat="server">
Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

	Dim objConnection As New SqlConnection(ConfigurationManager.AppSettings("appConn"))
	Dim objCommand As New SqlCommand("Inv_ProjectTasks_Get", objConnection)
	objCommand.CommandType = CommandType.StoredProcedure

	objCommand.Parameters.Add("@id", Request("id"))		

	objConnection.Open()

	Dim objReader As SqlDataReader = objCommand.ExecuteReader
	Dim tasks As New List(Of Object)()

	While objReader.Read()
		Dim task = New With {
		.id = objReader("id"),
		.text = objReader("task_desc"),
		.start_date = Convert.ToDateTime(objReader("start_date")).ToString("yyyy-MM-dd"),
		.end_date = Convert.ToDateTime(objReader("end_date")).ToString("yyyy-MM-dd")
		}

		tasks.Add(task)
	End While

	Dim serializer As New JavaScriptSerializer()
    Dim jsonData As String = serializer.Serialize(tasks)

	Response.ContentType = "application/json"
	Response.Write(jsonData)

	objConnection.Close()
End Sub
</script>

<!DOCTYPE html>
<html>
<head>
  <title>Gantt Chart Example</title>
  <script src="https://d3js.org/d3.v6.min.js"></script>
    <style>
        #chart {
            width: 800px;
            height: 400px;
        }
    </style>
</head>
<body>
  <div id="gantt-container"></div>

  <script>
	var margin = { top: 20, right: 30, bottom: 20, left: 150 };
	var width = 800 - margin.left - margin.right;
	var height = 400 - margin.top - margin.bottom;

	var svg = d3.select("#gantt-container")
		.append("svg")
		.attr("width", width + margin.left + margin.right)
		.attr("height", height + margin.top + margin.bottom)
		.append("g")
		.attr("transform", "translate(" + margin.left + "," + margin.top + ")");

	d3.json("gantt_chart.aspx", function (error, data) {
		if (error) {
			console.log("Error retrieving Gantt chart data.");
			return;
		}

		data.forEach(function (d) {
			d.start_date = new Date(d.start_date);
			d.end_date = new Date(d.end_date);
		});

		var x = d3.scaleTime()
			.domain([d3.min(data, function (d) { return d.start_date; }), d3.max(data, function (d) { return d.end_date; })])
			.range([0, width]);

		var y = d3.scaleBand()
			.domain(data.map(function (d) { return d.text; }))
			.range([0, height])
			.padding(0.1);

		svg.append("g")
			.attr("class", "x-axis")
			.attr("transform", "translate(0," + height + ")")
			.call(d3.axisBottom(x));

		svg.append("g")
			.attr("class", "y-axis")
			.call(d3.axisLeft(y));

		svg.selectAll(".bar")
			.data(data)
			.enter().append("rect")
			.attr("class", "bar")
			.attr("x", function (d) { return x(d.start_date); })
			.attr("y", function (d) { return y(d.text); })
			.attr("width", function (d) { return x(d.end_date) - x(d.start_date); })
			.attr("height", y.bandwidth());
	});
</script>
</body>
</html>

