using BLL.Service;
using DTO.Models;
using ProjetoFinal.Extension;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinal.Views
{
    public partial class ConfirmarEntrega : Form
    {
        #region [ Construtor ]


        public delegate void DoEvent(List<ItemEntregaModel> lista);
        public event DoEvent RefreshDgv;
        public ConfirmarEntrega()
        {
            InitializeComponent();
        }

        #endregion

        #region [ Implementação ]

        public DateTime DataEntrega
        {
            get
            {
                return DataEntregaDateTimePicker.Value;
            }
            set
            {
                DataEntregaDateTimePicker.Value = value;
            }
        }

        #endregion

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            this.Close();
            RemoverObjetosSessao();
        }

        private void RemoverObjetosSessao()
        {
            ContextHelper.FreeNamedDataSlot("Entrega");
        }

        private void SalvarButton_Click(object sender, EventArgs e)
        {
            int erro = 0;
            if (DataEntrega > DateTime.Now)
            {
                erro = 1;
                MessageBox.Show("Data e hora da entrega não pode ser maior que a Data e hora de hoje");
            }

            ItemEntregaModel itemEntrega = new ItemEntregaModel();
            itemEntrega = ObterEntregaSessao();
            if (itemEntrega.Status == "Entregue com Atraso" || itemEntrega.Status == "Entregue")
            {
                erro = 1;
                MessageBox.Show("Entrega já foi Realizada!");
            }
            if (erro == 0)
            {
                if (DataEntrega > itemEntrega.DataEntrega)
                    itemEntrega.Status = "Entregue com Atraso";
                else
                    itemEntrega.Status = "Entregue";

                bool entregaRealizada = new EntregaService().ConfirmarEntrega(itemEntrega);
                if (entregaRealizada)
                {
                    MessageBox.Show("Operação realizada com sucesso!");
                    var listaEntregas = new EntregaService().ObterEntregas("NOME/RAZÃO SOCIAL", "Todos", "");

                    List<ItemEntregaModel> lsita = new List<ItemEntregaModel>();

                    if (listaEntregas.Any())
                    {
                        foreach (var item in listaEntregas)
                        {
                            ItemEntregaModel entrega = new ItemEntregaModel();
                            var usuario = new UsuarioService().GetUsuarioById(item.idUsuario.ToInt());
                            var cliente = new ClienteService().GetClienteById(item.idCliente.ToInt());
                            entrega.Codigo = item.Codigo;
                            entrega.DataCompra = item.DataCompra;
                            entrega.DataEntrega = item.DataEntrega;
                            entrega.Desconto = item.Desconto;

                            string formaPagamento = string.Empty;
                            formaPagamento = item.Dinheiro > 0 ? "Dinheiro" : string.Empty;

                            if (string.IsNullOrWhiteSpace(formaPagamento))
                                formaPagamento = item.Credito > 0 ? "Crédito" : string.Empty;
                            else
                                formaPagamento = formaPagamento + (item.Credito > 0 ? " - Crédito" : string.Empty);

                            if (string.IsNullOrWhiteSpace(formaPagamento))
                                formaPagamento = item.Credito > 0 ? "Débito" : string.Empty;
                            else
                                formaPagamento = formaPagamento + (item.Debito > 0 ? " - Débito" : string.Empty);

                            entrega.FormaPagamento = formaPagamento;
                            entrega.NomeUsuario = usuario.Nome;
                            entrega.NomeCliente = !string.IsNullOrWhiteSpace(cliente.CPF) ? cliente.Nome : cliente.RazaoSocial;
                            entrega.EnderecoCliente = cliente.Endereco;
                            entrega.IdVenda = item.idVenda;
                            entrega.QuantidadeParcela = item.QuantidadeParcela;
                            entrega.Telefone = cliente.Telefone;
                            entrega.Status = item.Status;
                            entrega.ValorTotal = item.ValorTotal;
                            lsita.Add(entrega);
                        }
                    }
                    this.RefreshDgv(lsita);
                    RemoverObjetosSessao();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ocorreu um erro inesperado no sistema");
                }
            }
        }
        private ItemEntregaModel ObterEntregaSessao()
        {
            ItemEntregaModel entregaModel = (ItemEntregaModel)ContextHelper.GetData("Entrega");
            return entregaModel;
        }
    }
}
