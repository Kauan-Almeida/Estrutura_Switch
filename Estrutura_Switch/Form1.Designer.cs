namespace Estrutura_Switch
{
    partial class Form1
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
            lblDia = new Label();
            lblDiadaSemana = new Label();
            btnVerificar = new Button();
            btnFechar = new Button();
            txtDia = new TextBox();
            SuspendLayout();
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(24, 22);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(24, 15);
            lblDia.TabIndex = 0;
            lblDia.Text = "Dia";
            // 
            // lblDiadaSemana
            // 
            lblDiadaSemana.AutoSize = true;
            lblDiadaSemana.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiadaSemana.ForeColor = Color.Red;
            lblDiadaSemana.Location = new Point(88, 70);
            lblDiadaSemana.Name = "lblDiadaSemana";
            lblDiadaSemana.Size = new Size(57, 20);
            lblDiadaSemana.TabIndex = 1;
            lblDiadaSemana.Text = "label2";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(52, 137);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(75, 23);
            btnVerificar.TabIndex = 2;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(165, 137);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 3;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(88, 22);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 4;
            txtDia.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 288);
            ControlBox = false;
            Controls.Add(txtDia);
            Controls.Add(btnFechar);
            Controls.Add(btnVerificar);
            Controls.Add(lblDiadaSemana);
            Controls.Add(lblDia);
            Name = "Form1";
            Text = "Seleciona dia";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDia;
        private Label lblDiadaSemana;
        private Button btnVerificar;
        private Button btnFechar;
        private TextBox txtDia;
    }
}