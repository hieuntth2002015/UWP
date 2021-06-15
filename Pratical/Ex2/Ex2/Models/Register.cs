using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex2.Adapters;
using Ex2.Models;
using SQLitePCL;

namespace Ex2.Models
{
    class Register
    {
        private const string V = "insert into User (id, username, password) values(?,?,?)";

        public bool Regist(Users users)
        {
            SQLiteHelper qLiteHelper = SQLiteHelper.GetInstance();
            SQLiteConnection sQLiteConnection = qLiteHelper.sQLiteConnection;
            string sql_txt = V;
            var statement = sQLiteConnection.Prepare(sql_txt);
            
            statement.Bind(2, users.Username);
            statement.Bind(3, users.Password);
            var rs = statement.Step();
            return rs == SQLiteResult.OK;
        }

    }
}
