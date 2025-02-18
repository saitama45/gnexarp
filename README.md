# rasa - Integrated Billing and Collection Management System
ICMS is a management system for your accounts receivable processes that sought to address the problem of the billings (invoicing for the clients) and recording of collection activities & transactions. 

# Basic Features
~ <b>Efficient:</b> with the aid of user friendly screen, you can process your billings and collection quickly and efficiently.<br>
~ <b>Easy To Learn:</b> no need extensive training for users. It's easy as it is.<br>
~ <b>Secure:</b> handles the visibility of billings and collections based on the roles assigned to users plus with audit trail to see the history of the transactions.<br>
~ <b>Versatile:</b> prints billings and collections on the go and with Microsoft Excel export function.

# Core Benefits
1. It offers a unique solutions and combination of performance and usability.
2. It makes the billing and collection reports preparation easier.
3. It makes the billing and collection maintenance automated.
4. It contributes to a more accurate status of billing and collection.
5. It enables provision of billing and collection report in real-time.
6. It is innovative and reliable collection processing solutions.

# How to Extract Tables from another Database in Microsoft SQL Server 2017  
1. Right click the Table (Source)
2. Select Script Table as
3. Select Create To
4. Select New Query Editor Window
5. Copy the extracted query
6. Paste it to the database destination
7. Run the Query

# How to Query the records from one table to another in Microsoft SQL Server 2017
1. Right click the Table (Source)
2. Select Script Table as
3. Select Select To
4. Select New Query Editor Window
5. Copy the Columns only
6. Using this query, paste the columns on the insert and select query statement

SET IDENTITY_INSERT icms.dbo.LSC ON;

INSERT INTO icms.dbo.LSC (destination table)
(
	[id]
	,[name]
	,[lsc_code]
	,[remarks]
	,[last_update]
)
SELECT 
	[id]
	,[name]
	,[lsc_code] 
	,[remarks]
	,[last_update]
FROM bcms_2.dbo.LSC; (source table)

SET IDENTITY_INSERT icms.dbo.LSC OFF;