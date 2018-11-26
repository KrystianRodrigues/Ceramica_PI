using FATEC; //para acesso a classe Mapped
using System;
using System.Web;
using CadLoja.App_Code.Classes; //para acesso a classe Materia
using System.Data; //para uso de DataSet
using WebSiteExemplo.Classes;

namespace WebSiteExemplo.Persistencia
{
    /// <summary>
    /// Summary description for MateriaBD
    /// </summary>
    public class MateriaBD
    {
        //métodos
        //insert
        public bool Insert(Materia materia)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_materia(mat_tipo, mat_quantidade, mat_medidas, mat_fornecedor) VALUES (?tipo, ?quantidade, ?medidas, ?fornecedor)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?tipo", materia.Tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", materia.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?medidas", materia.Medidas));
            objCommand.Parameters.Add(Mapped.Parameter("?fornecedor", materia.Fornecedor));
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
            objCommand = Mapped.Command("SELECT * FROM tbl_materia", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            return ds;
        }
        //select
        //update
        //delete
        //construtor
        public MateriaBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}