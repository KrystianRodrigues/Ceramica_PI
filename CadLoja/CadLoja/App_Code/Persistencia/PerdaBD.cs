using FATEC; //para acesso a classe Mapped
using System;
using System.Web;
using WebSiteExemplo.Classes; //para acesso a classe Perda
using System.Data; //para uso de DataSet
namespace WebSiteExemplo.Persistencia
{
    /// <summary>
    /// Summary description for PerdaBD
    /// </summary>
    public class PerdaBD
    {
        //métodos
        //insert
        public bool Insert(Perda perda)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_perda(per_tipo, per_quantidade, per_medida) VALUES (?tipo, ?quantidade, ?medida)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?tipo", perda.Tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?quantidade", perda.Quantidade));
            objCommand.Parameters.Add(Mapped.Parameter("?medida", perda.Medida));
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
            objCommand = Mapped.Command("SELECT * FROM tbl_perda", objConexao);
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
        public PerdaBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}