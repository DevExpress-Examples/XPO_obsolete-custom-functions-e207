using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using DevExpress.Xpo.DB;
using DevExpress.Data.Filtering;

namespace CustomCommand {
    public class MyMsSqlConnectionProvider : MSSqlConnectionProvider {
        public MyMsSqlConnectionProvider(IDbConnection connection, AutoCreateOption autoCreateOption)
            : base(connection, autoCreateOption) {
        }
        public override string FormatFunction(DevExpress.Data.Filtering.FunctionOperatorType operatorType, params string[] operands) {
            if(operatorType == FunctionOperatorType.Custom && operands[0] == "GetMonth") {
                // SQL implementation of the custom function (GetMonth)
                return string.Format("DATEPART(month, {0})", operands[1]); 
            }
            return base.FormatFunction(operatorType, operands);
        }
    }
}
