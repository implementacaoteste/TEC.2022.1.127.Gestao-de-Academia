﻿using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProdutoDAL
    {
        public void Inserir(Produto _produto, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO Produto(Nome, Marca, Preco, Quantidade, CodigoDeBarras) VALUES(@Nome, @Marca, @Preco, @Quantidade, @CodigoDebarras)"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Nome", _produto.Nome);
                        cmd.Parameters.AddWithValue("@Preco", _produto.Preco);
                        cmd.Parameters.AddWithValue("@Marca", _produto.Marca);
                        cmd.Parameters.AddWithValue("@Estoque", _produto.Quantidade);
                        cmd.Parameters.AddWithValue("@CodigoDeBarras", _produto.CodigoDeBarras);

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

                        throw new Exception("Ocorreu um erro ao tentar inserir o produto no banco de dados.", ex);
                    }
                }
            }
        }
        public void Alterar(Produto _produto, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("UPDATE Produto SET Nome = @Nome, Marca = @Marca, Preco = @Preco, Quantidade = @Quantidade, CodigoDeBarras = @CodigoDeBarras WHERE Id = @Id"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@Id", _produto.Id);
                        cmd.Parameters.AddWithValue("@Nome", _produto.Nome);
                        cmd.Parameters.AddWithValue("@Marca", _produto.Marca);
                        cmd.Parameters.AddWithValue("@Preco", _produto.Preco);
                        cmd.Parameters.AddWithValue("@Estoque", _produto.Quantidade);
                        cmd.Parameters.AddWithValue("@CodigoDeBarras", _produto.CodigoDeBarras);

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

                        throw new Exception("Ocorreu um erro ao tentar atualizar o produto no banco de dados.", ex);
                    }
                }
            }
        }
        public void Excluir(int _id, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM Produto WHERE Id = @Id"))
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

                        throw new Exception("Ocorreu um erro ao tentar deletar o produto no banco de dados.", ex);
                    }
                }
            }
        }
        public List<Produto> BuscarTodos()
        {
            List<Produto> produtoList = new List<Produto>();
            Produto produto;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Nome, Marca, Preco, Quantidade, CodigoDeBarras FROM Produto";

                cmd.CommandType = System.Data.CommandType.Text;

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        produto = new Produto();
                        produto.Id = (int)rd["Id"];
                        produto.Nome = rd["Nome"].ToString();
                        produto.Marca = rd["Marca"].ToString();
                        produto.Preco = (double)rd["Preco"];
                        produto.Quantidade = (int)rd["Quantidade"];
                        produto.CodigoDeBarras = rd["CodigoDeBarras"].ToString();
                        produtoList.Add(produto);
                    }
                }
                return produtoList;

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
        public Produto BuscarPorId(int _id)
        {
            Produto produto;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Nome, Marca, Preco, Estoque, CodigoDeBarras FROM Produto WHERE Id  = @Id";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Id", _id);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    produto = new Produto();
                    if (rd.Read())
                    {
                        produto.Id = (int)rd["Id"];
                        produto.Nome = rd["Nome"].ToString();
                        produto.Marca = rd["Marca"].ToString();
                        produto.Preco = (double)rd["Preco"];
                        produto.Quantidade = (int)rd["Estoque"];
                        produto.CodigoDeBarras = rd["CodigoDeBarras"].ToString();
                    }
                }
                return produto;
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
        public List<Produto> BuscarPorNome(string _nome)
        {
            List<Produto> produtoList = new List<Produto>();
            Produto produto;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = " SELECT Id, Nome, Marca Preco, Quantidade, CodigoDeBarras FROM Produto WHERE Nome LIKE @Nome";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@Nome", "%" + _nome + "%");

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        produto = new Produto();
                        produto.Id = (int)rd["Id"];
                        produto.Nome = rd["Nome"].ToString();
                        produto.Marca = rd["Marca"].ToString();
                        produto.Preco = (double)rd["Preco"];
                        produto.Quantidade = (int)rd["Quantidade"];
                        produto.CodigoDeBarras = rd["CodigoDeBarras"].ToString();
                        produtoList.Add(produto);
                    }
                }
                return produtoList;

            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o produto por nome no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
        public Produto BuscarPorCodigoDeBarras(string _codigoDeBarras)
        {
            Produto produto;

            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);

            try
            {
                SqlCommand cmd = cn.CreateCommand();

                cmd.CommandText = "SELECT Id, Nome, Marca, Preco, Quantidade, CodigoDeBarras FROM Produto WHERE CodigoDeBarras  = @CodigoDeBarras";

                cmd.CommandType = System.Data.CommandType.Text;

                cmd.Parameters.AddWithValue("@CodigoDeBarras", _codigoDeBarras);

                cn.Open();

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    produto = new Produto();
                    if (rd.Read())
                    {
                        produto = new Produto();
                        produto.Id = (int)rd["Id"];
                        produto.Nome = rd["Nome"].ToString();
                        produto.Marca = rd["Marca"].ToString();
                        produto.Preco = (double)rd["Preco"];
                        produto.Quantidade = (int)rd["Quantidade"];
                        produto.CodigoDeBarras = rd["CodigoDeBarras"].ToString();
                    }
                }
                return produto;
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro ao tentar buscar o produto por código de barras no banco de dados.", ex);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
