using System;
using System.Data.Common;
using MySql.Data.MySqlClient;
using System.Data;


namespace DataBase.UNA.Conexion
{
    public abstract class DbAccess
    {
        public string ConnectionString { get; set; }

        public DbConnection Connection { get; set; }

        public DbTransaction Transaction { get; set; }

        public abstract void OpenConnection();
        
        public abstract void CloseConnection();

        public abstract int EjectSQL(string Esql);

        public abstract  DataTable QuerySQL(string Qsql);

        public abstract bool IsTransaction();

        public abstract void CommitTransaction();

        public abstract void RollBackTransaction();

        public abstract void BeginTransaction();
     }
}

