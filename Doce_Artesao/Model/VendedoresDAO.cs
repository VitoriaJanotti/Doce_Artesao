using Doce_Artesao.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Doce_Artesao.Model
{
    internal class VendedoresDAO
    {

        private Connection Con { get; set; }
        private SqlCommand Cmd { get; set; }
        
        
        

        public VendedoresDAO()
        {
            Con = new Connection();
            Cmd = new SqlCommand();
        }


        public void Insert(Vendedores vendedores)
        {
            Cmd.Connection = Con.ReturnConnect();
            Cmd.CommandText = @"INSERT INTO Vendedor VALUES (@NomeVendedor, @SenhaVendedor)";


            Cmd.Parameters.AddWithValue("@NomeVendedor", vendedores.NomeVendedor);
            Cmd.Parameters.AddWithValue("@SenhaVendedor", vendedores.SenhaVendedor);


            try
            {
                //EXECUTA QUERY DEFINIDA ACIMA 
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir doce.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnect();
            }
        }
            public void Update(Vendedores vendedores)
            {
                Cmd.Connection = Con.ReturnConnection();
                Cmd.CommandText = @"UPDATE Vendedor SET NomeVendedor = @NomeVendedor,
                SenhaVendedor = @SenhaVendedor WHERE Id = @id";

                 Cmd.Parameters.AddWithValue("@id", vendedores.Id);
                 Cmd.Parameters.AddWithValue("@NomeVendedor", vendedores.NomeVendedor);
                 Cmd.Parameters.AddWithValue("@SenhaVendedor", vendedores.SenhaVendedor);
            try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    throw new Exception("Erro: Problemas ao realizar atualização de vendedores.\n" + err.Message);
                }
                finally
                {
                    Con.CloseConnection();
                }
            }

            public void Delete(int codVendedor)
            {
                Cmd.Connection = Con.ReturnConnection();
                Cmd.CommandText = @"DELETE FROM Vendedor WHERE Id = @id";
                Cmd.Parameters.AddWithValue("@id", codVendedor);
                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    throw new Exception("Erro: Problemas ao excluir vendedor.\n" + err.Message);
                }
                finally
                {
                    Con.CloseConnection();
                }
            }
            public List<Vendedores> ListAllVendedores()
            {

                Cmd.Connection = Con.ReturnConnection();
                Cmd.CommandText = "SELECT * FROM Vendedor";

                List<Vendedores> vendedores = new List<Vendedores>(); //Instancio a list com o tamanho padrão.
                try
                {
                    SqlDataReader rd = Cmd.ExecuteReader();

                    //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                    while (rd.Read())
                    {
                        Vendedores vendedor = new Vendedores(
                            (int)rd["Id"],
                            (string)rd["NomeVendedor"],
                            (string)rd["SenhaVendedor"]);
                        vendedores.Add(vendedor);
                    }
                    rd.Close();
                }
                catch (Exception err)
                {
                    throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
                }
                finally
                {
                    Con.CloseConnection();
                }

                return vendedores;
            }
        
    }
}
