namespace Sem3EjerciciosMultipleAnidada03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string categoria = cmbCat.Text;
            float sueldoAc = float.Parse(txtSueldo.Text);
            int numHijos = int.Parse(txtNroHijos.Text);
            float imcremento = 0.0f;

            switch (categoria)
            {
                case "A":
                    // imcremento en 25 %
                    imcremento = 0.25f;
                    break;

                case "B":
                    //incremento en 20 % 
                    imcremento = 0.20f;
                    break;
                case "C":
                    //incremento en 15 %
                    imcremento = 0.15f;
                    break;
                case "D":
                    //incremento en 10 % 
                    imcremento = 0.10f;
                    break;
                default:
                    //categoria no valida
                    break;

            }

            float aumento = (sueldoAc * imcremento) + sueldoAc;


            float imcrementohijos = numHijos * 0.025f;
            float nuevoSueldo = (aumento * imcrementohijos) + aumento;

            float impuesto = 0.0f;
            float totalNeto = 0.0f;

            if (nuevoSueldo > 2000)
            {
                impuesto = nuevoSueldo * 0.03f;
                totalNeto = nuevoSueldo - impuesto;

            }
            else {
                totalNeto = nuevoSueldo;

            }
            txtIncreSueldo.Text = Convert.ToString(aumento);
            txtAumento.Text = Convert.ToString(nuevoSueldo);
            txtDescuento.Text = Convert.ToString(impuesto);
            txtPago.Text = Convert.ToString(totalNeto);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAumento.Clear();
            txtDescuento.Clear();
            txtPago.Clear();
            txtIncreSueldo.Clear();
            txtNroHijos.Clear();
            txtSueldo.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}