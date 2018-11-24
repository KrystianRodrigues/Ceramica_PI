using System;
using System.Web;

namespace CadLoja.Classes
{
    /// <summary>     
    ///  Summary description for Fornecedor 
    ///  </summary>     
    public class Fornecedor
    {
        //propriedades         
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Empresa { get; set; }
        public int Cnpj { get; set; }
        public int Cell { get; set; }
        public int Telefone { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Cep { get; set; }
        public string Email { get; set; }

        //construtor
        public Fornecedor()
        {
            //
            // TODO: Add constructor logic here
            //         
        }
    }
}