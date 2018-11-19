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
        public Pessoa Autentica(string email, string senha)
        {
            Pessoa obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_funcionarios WHERE fun_email=?email and fun_senha=?senha", objConexao);
           
            objCommand.Parameters.Add(Mapped.Parameter("?email", email));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", senha));
            objDataReader = objCommand.ExecuteReader();
           
        while (objDataReader.Read())
            {
                obj = new Pessoa();
                obj.Cpf = Convert.ToInt32(objDataReader["fun_cpf"]);
                obj.Senha = Convert.ToString(objDataReader["fun_senha"]);
                obj.Nome = Convert.ToString(objDataReader["fun_nome"]);
                obj.Email = Convert.ToString(objDataReader["fun_email"]);
                obj.Tipo = Convert.ToInt32(objDataReader["fun_tipo"]);
            }
            objDataReader.Close();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();
            return obj;
        }
        public Pessoa Select(int cpf)
        {
            Pessoa obj = null;
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command("SELECT * FROM tbl_funcionarios WHERE fun_cpf=?cpf",objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?cpf", cpf));
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                obj = new Pessoa();
                obj.Cpf = Convert.ToInt32(objDataReader["fun_cpf"]);
                obj.Senha = Convert.ToString(objDataReader["fun_senha"]);
                obj.Nome = Convert.ToString(objDataReader["fun_nome"]);
                obj.Email = Convert.ToString(objDataReader["fun_email"]);
                obj.Tipo = Convert.ToInt32(objDataReader["fun_tipo"]);
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