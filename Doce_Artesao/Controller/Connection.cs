﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doce_Artesao.Controller
{
  
        internal class Connection
        {
            private SqlConnection con;
            private string DataBase = "PR2CJ3021955BDDOCEARTESAO";
            private string Server = "sqlexpress";
            private string Username = "aluno";
            private string Password = "aluno";

            public Connection()
            {
                string stringConnection = @"Data Source = " + Server
                    + "; Initial Catalog = " + DataBase
                    + "; User Id =" + Username
                    + "; Password =" + Password
                    + "; Encrypt = false";

                con = new SqlConnection(stringConnection);
                con.Open();

            }
            public void CloseConnect()
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
            public SqlConnection ReturnConnect()
            {
                return con;
            }

        internal void CloseConnection()
        {
            throw new NotImplementedException();
        }

        internal SqlConnection ReturnConnection()
        {
            throw new NotImplementedException();
        }
    }
}
