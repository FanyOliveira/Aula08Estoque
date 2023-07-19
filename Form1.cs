namespace Aula08Estoque
{
    public partial class Form1 : Form
    {
        //VÁRIAVEIS GLOBAIS

        List<string> produto_nome = new List<string>();
        List<int> produto_quantidade = new List<int>();




        public Form1()
        {
            InitializeComponent();
        }

        // MINHAS FUNÇÕES 
        void adicionaProduto ( )
        {
            string nome = txtNome.Text;
            int quantidade = int.Parse ( txtQuantidade.Text );    
            produto_nome.Add( nome );
            produto_quantidade.Add( quantidade );
        }

        void atualizaInterface()
        {
            int quantidadeCadastrada = produto_nome.Count();
            lblCadastros.Text = quantidadeCadastrada.ToString();
        }

        void limpaCampos ()
        {
            txtNome.Clear();
            txtQuantidade.Clear();
            txtNome.Focus();
        }
      
        void mostraPrododuto( bool primeiro )          // BOOL true - false      // VAR - PODE SER SUBSTITUÍDA POR VÁRIAVEIS
        {

            if ( listaEstaVazia() == true)
            {
                MessageBox.Show("Você não pode ver a Lista ainda...");
                return;
            }
            

            string nome;
            int quantidade;

            if (primeiro == true)
            {
                nome = produto_nome[0];
                quantidade = produto_quantidade[0];
            }
            else
            {
                nome = produto_nome [ produto_nome.Count() - 1 ];
                quantidade = produto_quantidade [ produto_quantidade.Count() - 1 ];
            }

            MessageBox.Show($"Nome:{nome} , Quantidade: {quantidade} ");
        }

        void removerProduto ()
        {
            if ( listaEstaVazia () == true)
            {
                MessageBox.Show("Você não pode remover!");
            }
            else
            {
                produto_nome.RemoveAt(0);
                produto_quantidade.RemoveAt(0);
            }

        }

        bool listaEstaVazia()
        {
            if ( produto_nome.Count > 0 )
            {
                return false;
            }
            else
            {
                return true;         
            }

        }

        // ------------------------------------------------------------------------------------------

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            adicionaProduto();
            atualizaInterface();
            limpaCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaCampos();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            mostraPrododuto( true );
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            mostraPrododuto(false);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            removerProduto();
            atualizaInterface();
            MessageBox.Show("Item removido com sucesso!");
        }
    }
}