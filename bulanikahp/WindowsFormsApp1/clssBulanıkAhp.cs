using System;
using System.Collections.Generic;
using System.Data
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class clssBulanıkAhp
    {
        SqlConnection connection = new SqlConnection("Data Source=SEYFI\SQLEXPRESS;Initial Catalog=Bulanik_Ahp;Integrated Security=True");
        DataTable table;
        public void ekle_sil_güncelle_sirala(SqlCommand command,string query)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void verileriGoster (string veriler)
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter(veriler, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridview1.DataSource = ds.Tables[0];
            connection.Close();
        }


    }
}
