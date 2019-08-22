using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class Acesso
    {
        public static SqlConnection Conection
        {
            get
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = @"data source = .\sqlexpress; initial catalog=dbCursoCsharp; Persist Security Info=true; User ID=sa; Password= Bianca08* ";
                conexao.Open();
                return conexao;
            }
        }

    }
}
