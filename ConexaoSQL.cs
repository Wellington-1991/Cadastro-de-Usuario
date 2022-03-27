using System;
using System.Data;
using System.Data.SqlClient;

namespace LoginSenha
{
    public class ConexaoSQL 
    {
        SqlConnection conn = new SqlConnection();   
        public ConexaoSQL()
        {
            conn.ConnectionString = @"Data Source=DESKTOP-15CIMC2\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        public SqlConnection Conectar()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }

            return conn;
        }
        public SqlConnection DesConectar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }

            return conn;
        }
        //public static void Conectar(string log, string sen)
        //{
        //    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-15CIMC2\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //    SqlDataAdapter data = new SqlDataAdapter("Select * from Cadastro",conn);
        //    string sql = "Select * from Cadastro where NomeUsuario="+log+" and Senha="+sen+"";
        //    SqlDataAdapter dataAd = new SqlDataAdapter(sql,conn);
        //    DataTable dataTab =new DataTable();
        //    data.Fill(dataTab);

        //    if(dataTab.Rows.Count == 1)
        //    {
        //        Console.WriteLine(dataTab.ToString());
        //    }


        //}
    }
}