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
            if (string.IsNullOrWhiteSpace(contacto) || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Debe completar todos los campos para agregar el contacto.",
                                "Campos incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

           //Validaciones
            string item = $"{contacto} - {telefono}";

            // Agregar a la checklist
            chklstResultado.Items.Add(item);

            // Limpiar campos
            txtContacto.Clear();
            mskTelefono.Clear();
            txtContacto.Focus();
        }

        private void FrmRegistrar_Load(object sender, EventArgs e)
        {

        }
    }
}
