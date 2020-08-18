using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Trelicas
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public bool completo = false;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nomeUsuario, senha;

            if (txbNomeUsuario.Text.Trim().Length == 0)
            {
                MessageBox.Show("O campo Nome de Usuário é obrigatório");
                return;
            }
            if (txbSenha.Text.Trim().Length == 0)
            {
                MessageBox.Show("O campo senha é obrigatório");
                return;
            }

            nomeUsuario = txbNomeUsuario.Text;
            senha = txbSenha.Text;
            string auxUserFinder = "";
            string auxPasswordFinder = "";

            if (!File.Exists("dados.txt"))
                File.Create("dados.txt");

            string[] aux;
            aux = File.ReadAllLines("dados.txt", Encoding.UTF8);

            //Procura o nome de usuário e senha no arquivo texto
            int exerc =1;
            for (int i = 0; i < aux.Length; i++)
            {
                string[] cut = aux[i].Split('|');
                if (cut[0] == nomeUsuario)
                {
                    auxUserFinder = cut[0];

                    if (cut[1] == senha)
                    {
                        auxPasswordFinder = cut[1];
                        exerc = Convert.ToInt32(cut[2]);
                    }
                }
            }

            if (auxUserFinder != nomeUsuario)
            {
                MessageBox.Show("Nome de usuário não encontrado");
                return;
            }
            if (auxPasswordFinder != senha)
            {
                MessageBox.Show("Senha incorreta");
                return;
            }


            MessageBox.Show("Logado");
            completo = true;
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txbSenha.UseSystemPasswordChar = !checkBox1.Checked;
            txtRepete.UseSystemPasswordChar = !checkBox1.Checked;
        }

        bool primClickCadastro = true;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txbSenha.UseSystemPasswordChar = true;
            txtRepete.UseSystemPasswordChar = true;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (txbSenha.Text == "" || txbNomeUsuario.Text == "")
            {
                MessageBox.Show("Há campos vazios");
                return;
            }
            if (primClickCadastro)
            {
                lblRepete.Visible = true;
                txtRepete.Visible = true;
                primClickCadastro = false;
                
                MessageBox.Show("Repita a senha para concluir o cadastro");
            }
            else
            {
                if (txtRepete.Text == txbSenha.Text)
                {
                    if (!File.Exists("dados.txt"))
                        File.Create("dados.txt");
                    string[] cadastros = File.ReadAllLines("dados.txt");

                    for (int i = 0; i < cadastros.Length; i++)
                    {
                        if (cadastros[i].Split('|')[0] == txbNomeUsuario.Text)
                        {
                            MessageBox.Show("Esse nome de usuario já está sendo usado");
                            return;
                        }
                    }

                    File.AppendAllText("dados.txt", $"{txbNomeUsuario.Text}|{txbSenha.Text}|1" + Environment.NewLine, Encoding.UTF8);

                    MessageBox.Show("Cadastrado com Sucesso");
                    completo = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Senhas não conferem");
                }
            }
        }
    }
}
