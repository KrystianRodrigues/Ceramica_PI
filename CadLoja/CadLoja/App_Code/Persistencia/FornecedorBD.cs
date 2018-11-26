using FATEC; //para acesso a classe Mapped 
using System;
using System.Web;
using CadLoja.App_Code.Classes;
using System.Data; //para uso de DataSet 
using CadLoja.Classes;

namespace CadLoja.Persistencia
{
    /// <summary>
    /// Summary description for FornecedorBD    
    /// </summary>     
    public class FornecedorBD
    {
        //métodos
        //insert
        public bool Insert(Fornecedor fornecedor)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_fornecedor(for_nome, for_empresa, for_cpnj, for_cell, for_telefone, for_endereco, for_cidade, for_estado, for_cep, for_email) VALUES (?nome, ?empresa, ?cpnj, ?cell, ?telefone, ?endereco, ?cidade, ?estado, ?cep, ?email)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?nome", fornecedor.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?empresa", fornecedor.Empresa));
            objCommand.Parameters.Add(Mapped.Parameter("?cnpj", fornecedor.Cnpj));
            objCommand.Parameters.Add(Mapped.Parameter("?cell", fornecedor.Cell));
            objCommand.Parameters.Add(Mapped.Parameter("?telefone", fornecedor.Telefone));
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", fornecedor.Endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?cidade", fornecedor.Cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?estado", fornecedor.Estado));
            objCommand.Parameters.Add(Mapped.Parameter("?cep", fornecedor.Cep));
            objCommand.Parameters.Add(Mapped.Parameter("?email", fornecedor.Email));

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
            objCommand = Mapped.Command("SELECT * FROM tbl_fornecedor", objConexao);
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
        public FornecedorBD()
        {
            //
            // TODO: Add constructor logic here             
            //
        }
    }
}