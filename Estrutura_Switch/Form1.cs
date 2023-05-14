namespace Estrutura_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int dia;
            dia = Convert.ToInt32(txtDia.Text);

            switch (dia)
            {
                case 1:
                    lblDiadaSemana.Text = "Domingo";
                    break;
                case 2:
                    lblDiadaSemana.Text = "Segunda-feira";
                    break;
                case 3:
                    lblDiadaSemana.Text = "Terça-feira";
                    break;
                case 4:
                    lblDiadaSemana.Text = "Quarta-feira";
                    break;
                case 5:
                    lblDiadaSemana.Text = "Quinta-feira";
                    break;
                case 6:
                    lblDiadaSemana.Text = "Sexta-feira";
                    break;
                case 7:
                    lblDiadaSemana.Text = "Sabado";
                    break;
                default:
                    lblDiadaSemana.Text = "Dia inválido";
                    break;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDiadaSemana.ResetText();
        }
    }
}