# CashCrusaders Windows Forms Assessment
Completed: 25 January 2023, 15.30 CAT +02.00  
Started: 24 January 2023 17.15 CAT +02.00  
Type: .NET Core Windows Forms App  
Using EntityFrameworkCore  
Using Dependency Injection  
Language: C# 6.0  
Database: SQL Server 2022 Express Edition  
Database Schema: CashCrusaders.Data project under Database folder  
Step-by-steb Guide -> https://drive.google.com/file/d/1EycqLzbd2x9e31WoNy984QX0Fyzyo97a/view?usp=share_link  
Dependency Injection: See topics below  
# Requirements
.NET Core 6.0  
C# 6.0  
SQL Server 2019 or latest  
Visual Studio 2019 or latest  
# Project Structure
CashCrusaders.App -> Windows Forms Application  
CashCrusaders.Domain -> Models, Interfaces and Services  
CashCrusaders.Data -> Repositories, Storage  
# Connection String
Connection String can be found in the CashCrusadersResource.resx file => CashCrusaders.App project  
# Database Schema
Please see CashCrusaders.Data project under Database folder => Simply Import Data-Tier Application or Restore using SQL Server Databases folder  
# Database Logic (DML)
Please see CashCrusaders.Data project => Storage.cs & Respective Repository implementation
# Dependency Injection (Services)
Please see Program.cs & Main.cs file => CashCrusaders.App project  
# Screenshots (Incremental)
Image 1: Loading Suppliers from DB into a Dropdown -> https://github.com/mtyide/CashCrusaders_2023/blob/master/CashCrusadersAssessment.png  
Image 2: Displaying Products for a specific Supplier in a ListView -> https://github.com/mtyide/CashCrusaders_2023/blob/master/CashCrusadersAssessment_1.png  
Image 3: Create Order for specific product(s) -> https://github.com/mtyide/CashCrusaders_2023/blob/master/createOrders.png  
For more screenshots, please see Step-by-step Guide  
# Status
Purchase Order Application -> Target: 26/27 January 2023 => 100% completed. See Step-by-step guide documentation (top)  
Testing & Debugging Orders, Suppliers and Products creation => 0% remaining  
Refactor/Review Problem 2 Logic => 100% completed
# Copyright
Author: Yandisa Mtyide. 2023 VS Projects
