using DataBase.UNA.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConnectionForm
{
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void ConectarDataBaseBtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Database=mydb;Uid=root;Pwd=sebas1995;";

            MySql mySql = new MySql();
            mySql.ConnectionString = connectionString;
            mySql.OpenConnection();
            mySql.BeginTransaction();

         dataGridView1.DataSource =   mySql.QuerySQL("Select * from Clientes");
            mySql.CommitTransaction();
            mySql.CloseConnection();
            MessageBox.Show("Conexión realizada");



            //connetionString = @"";
            //connection = new MySqlConnection(connetionString);
            //connection.Open();
            //
            //connection.Close();
        }
    }
}
    

