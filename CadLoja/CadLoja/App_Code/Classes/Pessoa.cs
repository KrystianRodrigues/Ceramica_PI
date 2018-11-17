using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadLoja.App_Code.Classes
{
    /// <summary>
    /// Summary description for Pessoa
    /// </summary>
    public class Pessoa
    {
        public int Codigo { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int Tipo { get; set; }
        public Pessoa()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}