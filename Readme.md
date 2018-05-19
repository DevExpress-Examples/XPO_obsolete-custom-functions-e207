# OBSOLETE - Custom Functions


<p><strong>This solution is obsolete. Refer to the</strong> <a href="https://documentation.devexpress.com/CoreLibraries/CustomDocument5206.aspx">How to: Implement a Custom Criteria Language Operator</a> <strong>article for a recommended solution.</strong><br><br>Database engines provide specific functions that aren't implemented in XPO. XPO still allows you to call such a function by creating a custom ConnectionProvider class and overriding its FormatFunction method. This example shows how to use the T-SQL DATEPART function in your XPO projects. Please pay attention to the Northwind.Order.OrderMonth property in the Northwind module and to the CustomCommand.MyMsSqlConnectionProvider.FormatFunction method in MyMsSqlConnectionProvider.</p>
<p>This sample requires MS SQL Server or SQL Express with a Northwind demo database.</p>
<p><strong>See Also: </strong><a href="https://www.devexpress.com/Support/Center/p/E2491">How to implement the ICustomFunctionOperatorFormattable interface</a></p>

<br/>


