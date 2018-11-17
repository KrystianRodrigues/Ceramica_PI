using CadLoja.App_Code.Classes;
using FATEC;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;

namespace CadLoja.App_Code.Persistencia
{
    /// <summary>
    /// Summary description for PessoaBD
    /// </summary>
    public class PessoaBD
    {
        public Pessoa Autentica(string cpf, string senha)
        {
            Pessoa obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_pessoa WHERE pes_cpf=?cpf and pes_senha=?senha", objConexao);
           
            objCommand.Parameters.Add(Mapped.Parameter("?cpf", cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", senha));
            objDataReader = objCommand.ExecuteReader();
           
        while (objDataReader.Read())
            {
                obj = new Pessoa();
                obj.Codigo = Convert.ToInt32(objDataReader["pes_codigo"]);
                obj.Nome = Convert.ToString(objDataReader["pes_nome"]);
                obj.Cpf = Convert.ToString(objDataReader["pes_cpf"]);
                obj.Tipo = Convert.ToInt32(objDataReader["pes_tipo"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        public Pessoa Select(int id)
        {
            Pessoa obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_pessoa WHERE pes_codigo=?codigo",
           objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?codigo", id));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Pessoa();
                obj.Codigo = Convert.ToInt32(objDataReader["pes_codigo"]);
                obj.Nome = Convert.ToString(objDataReader["pes_nome"]);
                obj.Cpf = Convert.ToString(objDataReader["pes_cpf"]);
                obj.Tipo = Convert.ToInt32(objDataReader["pes_tipo"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        public PessoaBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}