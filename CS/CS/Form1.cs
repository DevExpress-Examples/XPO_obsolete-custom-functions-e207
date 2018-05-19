using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using System.Data.SqlClient;
using DevExpress.Data.Filtering;

namespace CustomCommand {
    public partial class Form1 : Form {
        public Form1() {
            InitDAL();

            InitializeComponent();
        }

        private void InitDAL() {
            string connStr = "Data Source=(local);Initial Catalog=Northwind;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connStr);
            MyMsSqlConnectionProvider provider = new MyMsSqlConnectionProvider(connection, DevExpress.Xpo.DB.AutoCreateOption.SchemaAlreadyExists);
            XpoDefault.DataLayer = new SimpleDataLayer(provider);
        }

        private void Form1_Load(object sender, EventArgs e) {
            xpCollection1.Criteria = new OperandProperty("OrderMonth") == new OperandValue(2);
        }
    }
}