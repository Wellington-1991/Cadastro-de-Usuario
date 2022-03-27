using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginSenha
{
    public partial class Cadastro : Form
    {
        ConexaoSQL conexao = new ConexaoSQL();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;

        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastrar(Nome.Text,Usuario.Text,Email.Text,Senha.Text);

            MessageBox.Show(mensagem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 newForm2 = new Form1();
            newForm2.ShowDialog();
        }
        public void cadastrar(String NomeCompleto, String Usuario, String email, String Senha)
        {
            cmd.CommandText = "Insert into Cadastro (Nome,Usuario,email,Senha) values(@"+ Nome + ",@" + Usuario + ",@" + Email +",@"+ Senha +")";
            cmd.Parameters.AddWithValue("@Nome",Nome);
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@Senha", Senha);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.DesConectar();
                this.mensagem = "Cadastrado com sucesso!!";

            }
            catch (Exception)
            {
                this.mensagem = "Erro ao tentar se conectar com o banco de dados!!";
            }
        }
    }
}
