using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestaoHotel
{
    public partial class frmHotel : Form
    {
        int nroRegistro = 0;
        int totalRegistro = 0;
        DataTable hotel = HotelDAO.Listar();

        public frmHotel()
        {
            InitializeComponent();
        }

        private void MostrarDados(DataTable dataTable, int linha)
        {
            txtCodigo.Text = dataTable.Rows[linha]["id"].ToString();
            txtNomeHotel.Text = dataTable.Rows[linha]["nome_hotel"].ToString();
            txtNomeGerente.Text = dataTable.Rows[linha]["nome_gerente"].ToString();
            txtCNPJ.Text = dataTable.Rows[linha]["cnpj"].ToString();
            txtInscEst.Text = dataTable.Rows[linha]["insc_esc"].ToString();
            txtEndereco.Text = dataTable.Rows[linha]["endereco"].ToString();
            txtNumero.Text = dataTable.Rows[linha]["numero"].ToString();
            txtBairro.Text = dataTable.Rows[linha]["bairro"].ToString();
            txtCidade.Text = dataTable.Rows[linha]["cidade"].ToString();
            cboUF.Text = dataTable.Rows[linha]["UF"].ToString();
            txtCEP.Text = dataTable.Rows[linha]["cep"].ToString();
            txtTelefone.Text = dataTable.Rows[linha]["telefone_fixo"].ToString();
            txtCelular.Text = dataTable.Rows[linha]["telefone_celular"].ToString();
            txtEmail.Text = dataTable.Rows[linha]["email"].ToString();
        }

        private void LimparControles()
        {
            txtCodigo.Text = "";
            txtNomeHotel.Text = "";
            txtNomeGerente.Text = "";
            txtCNPJ.Text = "";
            txtInscEst.Text = "";
            txtEndereco.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cboUF.Text = "";
            txtCEP.Text = "";
            txtTelefone.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            totalRegistro = hotel.Rows.Count - 1;
            MostrarDados(hotel, 0);

            btnSalvar.Enabled = true;
            btnCancel.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparControles();
            txtNomeHotel.Focus();

            //desabilita botoes 
            btnAbrir.Enabled = false;
            btnLocalizar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnProximo.Enabled = false;
            btnAnterior.Enabled = false;

            //habilitar botoes
            btnSalvar.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("confirma o cadastro", "salvar", MessageBoxButtons.OKCancel) == DialogResult.Yes)
            {
                if (MessageBox.Show("Deseja salvar os dados?", "salvar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (txtCodigo.Text == "")//insercao de registro
                    {
                        HotelDAO.Criar(txtNomeHotel.Text,
                                txtNomeGerente.Text, txtCNPJ.Text,
                                txtInscEst.Text, txtEndereco.Text,
                                txtNumero.Text, txtBairro.Text,
                                txtCidade.Text, cboUF.Text, txtCEP.Text,
                                txtTelefone.Text, txtCelular.Text,
                                txtEmail.Text);
                    }
                    else//alteracao de registro
                    {
                        HotelDAO.Atualizar(txtCodigo.Text, txtNomeHotel.Text,
                                txtNomeGerente.Text, txtCNPJ.Text,
                                txtInscEst.Text, txtEndereco.Text,
                                txtNumero.Text, txtBairro.Text,
                                txtCidade.Text, cboUF.Text, txtCEP.Text,
                                txtTelefone.Text, txtCelular.Text,
                                txtEmail.Text);
                    }
                    hotel = HotelDAO.Listar();
                    nroRegistro = hotel.Rows.Count;
                    MostrarDados(hotel, nroRegistro);
                    MessageBox.Show("Dados salvos com sucesso!", "Gravar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (nroRegistro > 0)
            {
                nroRegistro = nroRegistro - 1;
                MostrarDados(hotel, nroRegistro);
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (nroRegistro < totalRegistro)
            {
                nroRegistro = nroRegistro + 1;
                MostrarDados(hotel, nroRegistro);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar suas alterações", "Cancelar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MostrarDados(hotel, nroRegistro);

            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esse registro?", "Cancelar",
    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MostrarDados(hotel, nroRegistro);

            }
            HotelDAO.Deletar(txtCodigo.Text);

            hotel = HotelDAO.Listar();
            MostrarDados(hotel, nroRegistro);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable pesquisa = new DataTable();
            string codigo = Interaction.InputBox("Informe o codigo:", "Pesquisar");

            pesquisa = HotelDAO.LocalizarPorCodigo(codigo);
            MostrarDados(pesquisa, 0);
        }

        private void btnBuscaCnpj_Click(object sender, EventArgs e)
        {
            DataTable pesquisa = new DataTable();
            string cnpj = Interaction.InputBox("Informe o cnpj:", "Pesquisar");

            pesquisa = HotelDAO.LocalizarPorCodigo(cnpj);
            MostrarDados(pesquisa, 0);
        }
    }
}
