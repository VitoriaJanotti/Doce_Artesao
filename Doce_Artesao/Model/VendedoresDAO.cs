using Doce_Artesao.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Doce_Artesao.Model
{
    internal class VendedoresDAO
    {
        private object CodVendedor;
        private object NomeVendedor;

        private Connection Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public object SenhaVendedor { get; private set; }
        public string V1 { get; }
        public string V2 { get; }
        public string V3 { get; }
        public string V4 { get; }
        public string V5 { get; }
        public string V6 { get; }

        public VendedoresDAO(int v)
        {
            Con = new Connection();
            Cmd = new SqlCommand();
        }

        public VendedoresDAO(int v, string v1, string v2, string v3, string v4, string v5, string v6) : this(v)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            V4 = v4;
            V5 = v5;
            V6 = v6;
        }

        public void Insert(VendedoresDAO vendedores)
        {
            Cmd.Connection = Con.ReturnConnect();
            Cmd.CommandText = @"INSERT INTO Candys VALUES (@CodVendedor,@NomeVendedor, @SenhaVendedor)";

            Cmd.Parameters.AddWithValue("@CodVendedor", vendedores.CodVendedor);
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
            public void Update(VendedoresDAO vendedores)
            {
                Cmd.Connection = Con.ReturnConnection();
                Cmd.CommandText = @"UPDATE Vendedores SET CodVendedor = @CodVendedor, NomeVendedor = @NomeVendedor,
                SenhaVendedor = @SenhaVendedor WHERE Id = @id";

                 Cmd.Parameters.AddWithValue("@CodVendedor", vendedores.CodVendedor);
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

            public void Delete(int CodVendedor)
            {
                Cmd.Connection = Con.ReturnConnection();
                Cmd.CommandText = @"DELETE FROM Vendedores WHERE CodVendedores = @CodVendedores";
                Cmd.Parameters.AddWithValue("@CodVendedor", CodVendedor);
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
            public List<VendedoresDAO> ListAllVendedores()
            {

                Cmd.Connection = Con.ReturnConnection();
                Cmd.CommandText = "SELECT * FROM Vendedores";

                List<VendedoresDAO> vendedores = new List<VendedoresDAO>(); //Instancio a list com o tamanho padrão.
                try
                {
                    SqlDataReader rd = Cmd.ExecuteReader();

                    //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                    while (rd.Read())
                    {
                        VendedoresDAO vendedores = new VendedoresDAO(
                            (int)rd["CodVendedor"],
                            (string)rd["Nomevendedor"],
                            (string)rd["Email"],
                            "000");
                        listaDeUsuarios.Add(usuario);
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

                return listaDeUsuarios;
            }
        
    }
}
