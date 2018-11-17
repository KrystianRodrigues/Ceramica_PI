using FATEC; //para acesso a classe Mapped
using System;
using System.Web;
using WebSiteExemplo.Classes; //para acesso a classe Produto
using System.Data; //para uso de DataSet
using System.Data.SqlTypes;

namespace WebSiteExemplo.Persistencia
{
    /// <summary>
    /// Summary description for ProdutoBD
    /// </summary>
    public class ProdutoBD
    {
        //métodos
        //insert
        public bool Insert(Produto produto)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_produto(pro_nome, pro_quantidade, pro_valor, pro_venda) VALUES (?nome, ?quantidade, ?valor, ?venda)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?nome", produto.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", produto.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?valor", produto.Valor));
            objCommand.Parameters.Add(Mapped.Parameter("?venda", produto.Venda));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //selectall
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_produto", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //select
        public Produto Select(int id)
        {
            Produto obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_produto WHERE pro_codigo = ?codigo", objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Produto();
                obj.Codigo = Convert.ToInt32(objDataReader["pro_codigo"]);
                obj.Nome = Convert.ToString(objDataReader["pro_nome"]);
                obj.Quantidade = Convert.ToString(objDataReader["pro_quantidade"]);
                obj.Valor = Convert.ToDouble(objDataReader["pro_valor"]);
                obj.Venda = Convert.ToDouble(objDataReader["pro_venda"]);

            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        //update
        public bool Update(Produto produto)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "UPDATE tbl_produto SET pro_nome=?nome, pro_quantidade=?quantidade, pro_valor=?valor, pro_venda=?venda WHERE pro_codigo=?codigo";
 objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", produto.Codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?nome", produto.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", produto.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?valor", produto.Valor));
            objCommand.Parameters.Add(Mapped.Parameter("?venda", produto.Venda));
            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //delete
        public bool Delete(int id)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "DELETE FROM tbl_produto WHERE pro_codigo=?codigo";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return true;
        }
        //construtor
        public ProdutoBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}