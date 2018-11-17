using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteExemplo.Classes
{
    /// <summary>
    /// Summary description for Cliente
    /// </summary>
    public class Cliente
    {
        //propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public String Cpf { get; set; }
        public String Telefone { get; set; }
        public String Cep { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String Email { get; set; }

        //construtor
        public Cliente()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}