using System;
using System.Data.Common;
using System.Data;
using MySql.Data.MySqlClient;

namespace DataBaseAccess.UNA.Conexion
{
    public class MySql : DbAccess
    {
        public override void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        //public override void BeginTransaction()
        //{
        //    Connection = new MySqlConnection(ConnectionString);
        //    Connection.Open();
        //    MySqlCommand command = Connection.CreateCommand();

        //    Transaction = Connection.BeginTransaction();
        //    command.Connection = Connection;
        //    command.Transaction = Transaction;


        //}

        public override void CloseConnection()
        {
        if(Connection != null)
            {
                Connection.Close();
            }
        }

        public override void CommitTransaction()
        {
            if(Transaction != null)
            {
                Transaction.Commit();
            }
        }

        public override int EjectSQL(string sql)
        {
            
            MySqlCommand command = new MySqlCommand(sql, (MySqlConnection)Connection);
            return command.ExecuteNonQuery();
            
        }

        public override bool IsTransaction()
        {
            if(Transaction != null)
            {
                return true;
            }
            return false;
        }

        public override void OpenConnection()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }

        public override DataTable QuerySQL(string Qsql)
        {
            throw new NotImplementedException();
        }

        //public override DataTable QuerySQL(string Qsql)
        //{

        //}

        public override void RollBackTransaction()
        {
            if (Transaction != null)
            {
                Transaction.Rollback();
            }

        }
    }
}
