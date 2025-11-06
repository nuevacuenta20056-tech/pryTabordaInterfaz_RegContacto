namespace pryTabordaInterfaz_Reg
{
    partial class FrmRegistrar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGrabar = new Button();
            lblContacto = new Label();
            lblTelefono = new Label();
            label3 = new Label();
            txtContacto = new TextBox();
            mskTelefono = new MaskedTextBox();
            chklstResultado = new CheckedListBox();
            SuspendLayout();
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(229, 281);
            btnGrabar.Margin = new Padding(3, 4, 3, 4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(98, 60);
            btnGrabar.TabIndex = 1;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.BorderStyle = BorderStyle.Fixed3D;
            lblContacto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContacto.Location = new Point(66, 131);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(90, 27);
            lblContacto.TabIndex = 2;
            lblContacto.Text = "Contacto";
            lblContacto.Click += label1_Click;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BorderStyle = BorderStyle.Fixed3D;
            lblTelefono.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(66, 205);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(86, 27);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(89, 48);
            label3.Name = "label3";
            label3.Size = new Size(211, 34);
            label3.TabIndex = 4;
            label3.Text = "Registrar Contacto";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(184, 132);
            txtContacto.Margin = new Padding(3, 4, 3, 4);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(114, 27);
            txtContacto.TabIndex = 5;
            // 
            // mskTelefono
            // 
            mskTelefono.Location = new Point(184, 207);
            mskTelefono.Margin = new Padding(3, 4, 3, 4);
            mskTelefono.Mask = "000-000-0000";
            mskTelefono.Name = "mskTelefono";
            mskTelefono.Size = new Size(114, 27);
            mskTelefono.TabIndex = 6;
            // 
            // chklstResultado
            // 
            chklstResultado.FormattingEnabled = true;
            chklstResultado.Location = new Point(89, 380);
            chklstResultado.Margin = new Padding(3, 4, 3, 4);
            chklstResultado.Name = "chklstResultado";
            chklstResultado.Size = new Size(209, 92);
            chklstResultado.TabIndex = 7;
            chklstResultado.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // FrmRegistrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(391, 497);
            Controls.Add(chklstResultado);
            Controls.Add(mskTelefono);
            Controls.Add(txtContacto);
            Controls.Add(label3);
            Controls.Add(lblTelefono);
            Controls.Add(lblContacto);
            Controls.Add(btnGrabar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmRegistrar";
            Text = "Registrar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGrabar;
        private Label lblContacto;
        private Label lblTelefono;
        private Label label3;
        private TextBox txtContacto;
        private MaskedTextBox mskTelefono;
        private CheckedListBox chklstResultado;
    }
}
