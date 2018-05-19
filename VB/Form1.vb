Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports System.Data.SqlClient
Imports DevExpress.Data.Filtering

Namespace CustomCommand
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitDAL()

			InitializeComponent()
		End Sub

		Private Sub InitDAL()
			Dim connStr As String = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=True;"
			Dim connection As SqlConnection = New SqlConnection(connStr)
			Dim provider As MyMsSqlConnectionProvider = New MyMsSqlConnectionProvider(connection, DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists)
			XpoDefault.DataLayer = New SimpleDataLayer(provider)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			xpCollection1.Criteria = New OperandProperty("OrderMonth") = New OperandValue(2)
		End Sub
	End Class
End Namespace