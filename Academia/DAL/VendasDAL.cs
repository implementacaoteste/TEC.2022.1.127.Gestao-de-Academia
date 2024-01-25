﻿using Models;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace DAL
{
    public class VendasDAL
    {
        public void Inserir(Venda _venda, SqlTransaction _transaction = null)
        {
            SqlTransaction transaction = _transaction;

            using (SqlConnection cn = new SqlConnection(Conexao.StringDeConexao))
            {
                using (SqlCommand cmd = new SqlCommand(@"INSERT INTO Venda (FuncionarioId, ClienteId, DataVenda, TotalVenda, FormaPagamentoId)
                                 VALUES (@FuncionarioId, @ClienteId, @DataVenda, @TotalVenda, @FormaPagamentoId);
                                 SELECT SCOPE_IDENTITY();"))
                {
                    try
                    {
                        cmd.CommandType = System.Data.CommandType.Text;

                        cmd.Parameters.AddWithValue("@FuncionarioId", _venda.FuncionarioId);
                        cmd.Parameters.AddWithValue("@ClienteId", _venda.ClienteId);
                        cmd.Parameters.Add("@DataVenda", SqlDbType.DateTime).Value = _venda.DataVenda;
                        cmd.Parameters.Add("@TotalVenda", SqlDbType.Decimal).Value = _venda.TotalVenda;
                        cmd.Parameters.AddWithValue("@FormaPagamentoId",_venda.FormaPagamentoId);
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

                        throw new Exception("Ocorreu um erro ao tentar inserir as informações na venda.", ex);
                    }
                }
            }
        }

        public object BuscarPorCPFCliente(string cPF)
        {
            throw new NotImplementedException();
        }
        public void BuscarPorCodigoVenda()
        {
            throw new NotImplementedException();
        }
        public List<Venda> BuscarPorDataVenda()
        {
            throw new NotImplementedException();
        }

        public List<Venda> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public List<Venda> BuscarPorNomeFuncionario(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Venda> BuscarPorNomeCliente(string _nomeCliente)
        {
            throw new NotImplementedException();
        }

        public Venda BuscarPorCodigoVenda(int _id)
        {
            throw new NotImplementedException();
        }
    }
}
