# SSO

Pre-requisition:
1. Visual studio 2017
2. Microsoft .Net Core 2.0 or later
3. MSSQL server 2008 or later

Configuration Steps:
1. Run UserIdentity.sql in Microsoft SQL Server Management Studio
2. Open SSO.OAuth.sln
3. Go to \..\SSO.OAuth\appsettings.json
4. Modify "W10G601NF2\\SQLEXPRESS" to your MSSQL Server Name (plus instance if applicable) under "DefaultConnection".
5. Build Solution.
6. Run Solution in Debug mode.

User Login:
1. UserName:User@yahoo.com Password:User1234
2. UserName:Test@yahoo.com Password:Test1234
