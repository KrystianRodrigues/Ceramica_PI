using FATEC; //para acesso a classe Mapped
using System;
using System.Web;
using WebSiteExemplo.Classes; //para acesso a classe Funcionario
using System.Data; //para uso de DataSet


namespace WebSiteExemplo.Persistencia
{
    /// <summary>
    /// Summary description for FuncionarioBD
    /// </summary>
    public class FuncionarioBD
    {
        //métodos
        //insert
        public bool Insert(Funcionario funcionario)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_funcionarios(fun_cpf, fun_nome, fun_telefone, fun_cell, fun_endereco, fun_cidade, fun_estado, fun_cep, fun_tipo, fun_senha, fun_email, fun_contrato) VALUES (?cpf, ?nome, ?telefone, ?cell, ?endereco, ?cidade, ?estado, ?cep, ?tipo, ?senha, ?email, ?contrato )";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?cpf", funcionario.Cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?nome", funcionario.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?telefone", funcionario.Telefone));
            objCommand.Parameters.Add(Mapped.Parameter("?cell", funcionario.Cell));
            objCommand.Parameters.Add(Mapped.Parameter("?endereco", funcionario.Endereco));
            objCommand.Parameters.Add(Mapped.Parameter("?cidade", funcionario.Cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?estado", funcionario.Estado));
            objCommand.Parameters.Add(Mapped.Parameter("?cep", funcionario.Cep));
            objCommand.Parameters.Add(Mapped.Parameter("?tipo", funcionario.Tipo));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", funcionario.Senha));
            objCommand.Parameters.Add(Mapped.Parameter("?email", funcionario.Email));
            objCommand.Parameters.Add(Mapped.Parameter("?contrato", funcionario.Contrato));
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
            objCommand = Mapped.Command("SELECT * FROM tbl_funcionarios", objConexao);
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
        public FuncionarioBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}