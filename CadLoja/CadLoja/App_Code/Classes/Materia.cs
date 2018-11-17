using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSiteExemplo.Classes
{
    /// <summary>
    /// Summary description for Materia
    /// </summary>
    public class Materia
    {
        //propriedades
        public int Codigo { get; set; }
        public string Tipo { get; set; }
        public string Quantidade { get; set; }
        public string Medidas { get; set; }
        public string Fornecedor { get; set; }
        //construtor
        public Materia()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}