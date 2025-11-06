namespace pryTabordaInterfaz_Reg
{
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string contacto = txtContacto.Text.Trim();
            string telefono = mskTelefono.Text.Trim();

            // Validación
            if (contacto == "" || telefono == "")
            {
                MessageBox.Show("Completá contacto y teléfono antes de grabar.");
                return;
            }

            //Texto que se mostrará en la checklist
            string item = $"{contacto} - {telefono}";

            chklstResultado.Items.Add(item);

            // Limpiamor los campos
            txtContacto.Clear();
            mskTelefono.Clear();
            txtContacto.Focus();
        }
    }
}
