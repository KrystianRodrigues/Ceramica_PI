using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CadLoja.App_Code.Classes
{
    public class Venda
    {
        public int Codigo { get; set; }
        public DateTime DataVenda { get; set; }
        public string TipoVenda { get; set; }
        public int CpfCliente { get; set; }
        public int CodigoPedido { get; set; }
    }
}