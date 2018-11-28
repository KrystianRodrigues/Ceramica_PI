using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FATEC;
using System.Data;
using CadLoja.App_Code.Classes;

namespace CadLoja.App_Code.Persistencia
{
    public class VendaBD
    {
        //metodos

        //insert
        public bool Insert(Venda venda)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_vendas(ven_data, ven_tipo, cli_cpf, ped_codigo) VALUES (?dataVenda, ?tipoVenda, 1, 0)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?dataVenda", venda.DataVenda));
            objCommand.Parameters.Add(Mapped.Parameter("?tipoVenda", venda.TipoVenda));
            //objCommand.Parameters.Add(Mapped.Parameter("?cpfCliente", venda.CpfCliente));
            //objCommand.Parameters.Add(Mapped.Parameter("?codigoPedido", venda.CodigoPedido));
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
            objCommand = Mapped.Command("select year(ven_data) as ano, month(ven_data) as mes, group_concat(pl_tipo order by pl_tipo separator ', ') as produtos, count(i.ven_codigo) as vendidos, sum(p.pl_preco) as total from tbl_vendas v inner join tbl_itensvenda i using (ven_codigo) inner join tbl_produtoloja p using (pl_codigo) group by year(ven_data), month(ven_data) order by ano desc, mes desc", objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);

            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();

            return ds;
        }
    }
}