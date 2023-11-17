using Models;
using System.Data.SqlClient;
using System.Data;


namespace DAL
{
    public class FuncionarioDAL
    {
        public void Inserir(Funcionario _funcionario, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Funcionario(Nome, Cpf, Telefone, Email, Endereco) VALUES(@Nome, @Cpf, @Telefone, @Email, @Endereco)"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Nome", _funcionario.Nome);
                        cmd.Parameters.AddWithValue("@Preco", _funcionario.Cpf);
                        cmd.Parameters.AddWithValue("@Marca", _funcionario.Telefone);
                        cmd.Parameters.AddWithValue("@QuantidadeEstoque", _funcionario.Email);
                        cmd.Parameters.AddWithValue("@CodigoDeBarras", _funcionario.Endereco);

                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction.Connection != null && transaction.Connection.State == ConnectionState.Open)
                            transaction.Rollback();

                        throw new Exception("Ocorreu um erro ao tentar inserir o funcionário no banco de dados.", ex);
                    }
                }
            }
        }
        public void Alerar(Funcionario _funcionario, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Funcionario SET Nome = @Nome, Cpf = @Cpf, Telefone = @Telefone, Email = @Email, Endereco = @Endereco WHERE Id = @Id"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Nome", _funcionario.Nome);
                        cmd.Parameters.AddWithValue("@Preco", _funcionario.Cpf);
                        cmd.Parameters.AddWithValue("@Marca", _funcionario.Telefone);
                        cmd.Parameters.AddWithValue("@QuantidadeEstoque", _funcionario.Email);
                        cmd.Parameters.AddWithValue("@CodigoDeBarras", _funcionario.Endereco);

                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction.Connection != null && transaction.Connection.State == ConnectionState.Open)
                            transaction.Rollback();

                        throw new Exception("Ocorreu um erro ao tentar atualizar o funcionário no banco de dados.", ex);
                    }
                }
            }
        }
        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Funcionario WHERE Id = @Id"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Id", _id);

                        if (_transaction == null)
                        {
                            cn.Open();
                            transaction = cn.BeginTransaction();
                        }

                        cmd.Transaction = transaction;
                        cmd.Connection = transaction.Connection;

                        cmd.ExecuteNonQuery();

                        if (_transaction == null)
                            transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (transaction.Connection != null && transaction.Connection.State == ConnectionState.Open)
                            transaction.Rollback();

                        throw new Exception("Ocorreu um erro ao tentar deletar o funcionario no banco de dados.", ex);
                    }
                }
            }
        }
        public List<Funcionario> BuscarTodos()
        {
            List<Funcionario> funcionarioList = new List<Funcionario>();
            Funcionario funcionario;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Nome, Cpf, Telefone, Email, Endereco FROM Funcionario";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        funcionario= new Funcionario();
                        funcionario.Id = (int)rd["Id"];
                        funcionario.Nome = rd["Nome"].ToString();
                        funcionario.Cpf = rd["Cpf"].ToString();
                        funcionario.Telefone = rd["Telefone"].ToString();
                        funcionario.Email = rd["Email"].ToString();
                        funcionario.Endereco = rd["Endereco"].ToString();
                        funcionarioList.Add(funcionario);
                    }
                }
                return funcionarioList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o produto no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
