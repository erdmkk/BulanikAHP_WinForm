using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class clssBulanikAhp
    {
        SqlConnection connection = new SqlConnection("Data Source=SEYFI;Initial Catalog=Bulanik_Ahp;Integrated Security=True");
        DataTable table;
        public void ekle_sil_güncelle(SqlCommand command,string query)
        {            
            connection.Open();
            command.Connection = connection;
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
