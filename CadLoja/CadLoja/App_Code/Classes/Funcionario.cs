using System;
using System.Web;

namespace WebSiteExemplo.Classes
{
    /// <summary>
    /// Summary description for Funcionario
    /// </summary>
    public class Funcionario
    {
        //propriedades
        public int Cpf { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cell { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public int Tipo { get; set; }
        public int Senha { get; set; }
        public string Email { get; set; }    
        public string Contrato { get; set; }
    
//construtor
public Funcionario()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}