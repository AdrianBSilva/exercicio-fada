using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuaFada.Com
{
    public partial class Form1 : Form
    {
        List<Fada> fadas = new List<Fada>();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "jpg|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                picturi.ImageLocation = file.FileName;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cbElemento.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um elemento");
                return;
            }

            try
            {
                Fada fada = new Fada()
                {

                    Nome = txtNome.Text,
                    Familia = txtFamilia.Text,
                    Cor = txtCor.Text,
                    CorAsa = txtCorAsa.Text,
                    Tamanho = Convert.ToDouble(txtTamanho.Text),
                    AsaQuebrada = rbSimAsaQuebrada.Checked,
                    Sexo = rbSimMulher.Checked,
                    Barulho = rbFzBarulho.Checked,
                    Elemento = cbElemento.SelectedItem.ToString(),

                };
                fadas.Add(fada);
                AdiconarfadasNaTabaela(fada);
                MessageBox.Show("Cadastro realizado com sucesso");
                LimparCampos();
                tabControl1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtFamilia.Text = "";
            txtCor.Text = "";
            txtCorAsa.Text = "";
            txtTamanho.Text = "";
            rbFzBarulho.Checked = true;
            rbNaoBarulho.Checked = false;
            rbSimMulher.Checked = true;
            rbNaoMulher.Checked = false;
            rbSimAsaQuebrada.Checked = true;
            rbNaoAsaQuebrada.Checked = false;
            cbElemento.SelectedIndex = -1;
        }

        private void AdiconarfadasNaTabaela(Fada fada)
        {
            if (rbSimMulher.Checked == true)
            {
                fada.Sexo = true;
            }
            else
            {
                fada.Sexo = false;
            }
            dataGridView1.Rows.Add(new Object[]{
                fada.Nome, fada.Familia, fada.Cor, fada.CorAsa, fada.Sexo  == true ? "mulher" : "homem"
            });
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            string nome = dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString();
            foreach (Fada fada in fadas)
            {
                if (fada.Nome == nome)
                {
                    txtNome.Text = fada.Nome;
                    txtFamilia.Text = fada.Familia;
                    txtCor.Text = fada.Cor;
                    txtCorAsa.Text = fada.CorAsa;
                    txtTamanho.Text = Convert.ToString(fada.Tamanho);
                    if (fada.Barulho)
                    {
                        rbFzBarulho.Checked = true;
                    }
                    else
                    {
                        rbNaoBarulho.Checked = true;

                    }

                    if (fada.AsaQuebrada)
                    {
                        rbSimAsaQuebrada.Checked = true;

                    }
                    else
                    {
                        rbNaoAsaQuebrada.Checked = true;

                    }
                    if(fada.Sexo)
                    {
                        rbSimMulher.Checked = true;
                    }
                    else
                    {
                        rbNaoMulher.Checked = true;
                    }
                    cbElemento.SelectedItem = fada.Elemento;
                    tabControl1.SelectedIndex = 1;
                    break;
                }
            }

        }



    }
}
