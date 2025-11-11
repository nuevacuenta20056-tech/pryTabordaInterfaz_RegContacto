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

            // aca las validaciones de campos vacios
            if (string.IsNullOrWhiteSpace(contacto) || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Debe completar todos los campos para agregar el contacto.",
                                "Campos incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            //validaciones del formato telefono
            string item = $"{contacto} - {telefono}";

            // utilizo este codigo para agregar a la checklist
            chklstResultado.Items.Add(item);

            //limpio los campos
            txtContacto.Clear();
            mskTelefono.Clear();
            txtContacto.Focus();
        }

        private void FrmRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // limpia solo los campos
            txtContacto.Clear();
            mskTelefono.Clear();

            // limpia los datos de la checkedlistBox
            chklstResultado.Items.Clear();

            //vuelvo al primer campo
            txtContacto.Focus();
        }
    }
}
