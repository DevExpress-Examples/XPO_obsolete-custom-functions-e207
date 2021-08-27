<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E207)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [MyMsSqlConnectionProvider.cs](./CS/MyMsSqlConnectionProvider.cs) (VB: [MyMsSqlConnectionProvider.vb](./VB/MyMsSqlConnectionProvider.vb))
* [Northwind.cs](./CS/Northwind.cs) (VB: [Northwind.vb](./VB/Northwind.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# OBSOLETE - Custom Functions


<p><strong>This solution is obsolete. Refer to the</strong> <a href="https://documentation.devexpress.com/CoreLibraries/CustomDocument5206.aspx">How to: Implement a Custom Criteria Language Operator</a> <strong>article for a recommended solution.</strong><br><br>Database engines provide specific functions that aren't implemented in XPO. XPO still allows you to call such a function by creating a custom ConnectionProvider class and overriding its FormatFunction method. This example shows how to use the T-SQL DATEPART function in your XPO projects. Please pay attention to the Northwind.Order.OrderMonth property in the Northwind module and to the CustomCommand.MyMsSqlConnectionProvider.FormatFunction method in MyMsSqlConnectionProvider.</p>
<p>This sample requires MS SQL Server or SQL Express with a Northwind demo database.</p>
<p><strong>See Also: </strong><a href="https://www.devexpress.com/Support/Center/p/E2491">How to implement the ICustomFunctionOperatorFormattable interface</a></p>

<br/>


