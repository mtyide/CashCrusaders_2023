# CashCrusaders Windows Form Assessment
Type: .NET Core Windows Forms App  
Using EntityFrameworkCore  
Using Dependency Injection  
Language: C# 6.0  
Database: SQL Server 2022 Express Edition  
Database Schema: CashCrusaders.Data project under Database folder
# Requirements
.NET Core 6.0
SQL Server 20**  
Visual Studio 20**  
# Project Structure
CashCrusaders.App -> Windows Forms Application  
CashCrusaders.Domain -> Models, Interfaces and Services  
CashCrusaders.Data -> Repositories, Storage  
# Connection String
Connection String can be found on the CashCrusadersResource.resx file => CashCrusaders.App project  
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
Image 4: View Orders & Lines in a ListView -> https://github.com/mtyide/CashCrusaders_2023/blob/master/viewOrders.png 
# Status
Assessment In Progress -> Target: 26/27 January 2023 => 96% completed  
Testing & Debugging Orders, Suppliers and Products creation => 2% remaining  
Refactor Problem 2 Logic => 2% remaining
# Copyright
Author: Yandisa Mtyide 2023 VS Projects
