using Doce_Artesao.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doce_Artesao.Model
{
    internal class CandysDAO
    {
        private Connection Con { get; set; }
        private SqlCommand Cmd { get; set; }

        public CandysDAO()
        {
            Con = new Connection ();
            Cmd = new SqlCommand();
        }
        public void Insert(Candys candys)
        {
            Cmd.Connection = Con.ReturnConnect();
            Cmd.CommandText = @"INSERT INTO Candys VALUES (@CodDoces,@NomeDoce, @Preco)";

            Cmd.Parameters.AddWithValue("@CodDoces", candys.CodDoces);
            Cmd.Parameters.AddWithValue("@NomeDoce", candys.NomeDoce);
            Cmd.Parameters.AddWithValue("@Preco", candys.Preco);
          

            try
            {
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir Produto.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnect();
            }
        }
    }
}
