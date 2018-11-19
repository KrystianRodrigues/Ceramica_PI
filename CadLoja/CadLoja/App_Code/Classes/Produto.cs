using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSiteExemplo.Classes;
using WebSiteExemplo.Persistencia;


namespace WebSiteExemplo.Classes
{
    /// <summary>
    /// Summary description for Produto
    /// </summary>
    public class Produto
    {
        //propriedades
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public String Quantidade { get; set; }
        public double Valor { get; set; }
        public double Venda { get; set; }
        //construtor
        public Produto()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}
