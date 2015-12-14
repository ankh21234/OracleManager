﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace OracleManager
{
    public static class OracleHelper
    {
        //public static string constr = @"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=150.150.2.2)(PORT=1521))(CONNECT_DATA=(SID=USERDB)));User ID=SHAREP;Password=spuser15ad";

        public static string __constr = @"";//user id=apps;password=p@ssw0rd;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)))";

        public static string constr
        {
            get { return __constr; }
            set
            {
                __constr = value;
                if (__constr.NotEmpty()) ControlMod.SetRegistryValue(ControlMod.cntConStr, __constr);
            }
        }

        public static string owners = @"SELECT DISTINCT OWNER    FROM DBA_OBJECTS ORDER BY OWNER";
        public static string tables = @"SELECT DISTINCT object_name     FROM DBA_OBJECTS WHERE OBJECT_TYPE = 'TABLE' AND OWNER='?'";

        public static System.Data.DataTable GetDT(string s)
        {
            var dt = new DataTable();
            dt.Columns.Add("c1", typeof(string));
            dt.Columns.Add("c2", typeof(decimal));
            dt.Columns.Add("c3", typeof(string));

            var row0 = dt.NewRow();
            row0["c1"] = "C" + s;
            row0["c2"] = (decimal)-1;
            row0["c3"] = "Welcome tester";
            dt.Rows.Add(row0);

            for (int i = 0; i < 5; i++)
            {
                var row = dt.NewRow();
                row["c1"] = "C" + i;
                row["c2"] = (decimal)i;
                dt.Rows.Add(row);
            }

            return dt;
        }

        public static DataTable GetDatatable(string sQuery)
        {
            try
            {
                using (var connection = new OracleConnection(constr))
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = sQuery;
                    var oAdapter = new OracleDataAdapter(command);
                    var dt = new DataTable();
                    oAdapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ex.PromptMsg();
            }
            return null;
        }

    }
}