Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Data
Imports DevExpress.Xpo.DB
Imports DevExpress.Data.Filtering

Namespace CustomCommand
	Public Class MyMsSqlConnectionProvider
		Inherits MSSqlConnectionProvider
		Public Sub New(ByVal connection As IDbConnection, ByVal autoCreateOption As AutoCreateOption)
			MyBase.New(connection, autoCreateOption)
		End Sub
		Public Overrides Function FormatFunction(ByVal operatorType As DevExpress.Data.Filtering.FunctionOperatorType, ParamArray ByVal operands As String()) As String
			If operatorType = FunctionOperatorType.Custom AndAlso operands(0) = "GetMonth" Then
				' SQL implementation of the custom function (GetMonth)
				Return String.Format("DATEPART(month, {0})", operands(1))
			End If
			Return MyBase.FormatFunction(operatorType, operands)
		End Function
	End Class
End Namespace
