using Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Business
{
    public class MontadoraBLL
    {

        public void Salvar (MontadoraModel model)
        {
            if (model.Id ==0)
            {
                Adicionar(model);
                return;
            }
            Alterar(model);
        }
        
        private void Adicionar(MontadoraModel model)
        {
            
            SqlCommand comando = new SqlCommand();
            comando.Connection = Acesso.Conection;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = $@"insert into Montadora (nome, logo)
                                        values('{model.Nome}','{model.Logo}')";
            comando.ExecuteNonQuery();
            Acesso.Conection.Close();
        }

        private void Alterar(MontadoraModel model)
        {

        }
        public DataSet Buscar()
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = Acesso.Conection;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "select ID, Nome, Logo from Montadora";

            SqlDataAdapter da = new SqlDataAdapter(comando);

            DataSet ds = new DataSet();
            da.Fill(ds);

            Acesso.Conection.Close();
            return ds;
        }
    }
}
