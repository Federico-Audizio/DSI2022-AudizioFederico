namespace PobreTITO
{
    partial class RegistrarProblema
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listProblema = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PobreTITO = new System.Windows.Forms.Label();
            this.textCUIL = new System.Windows.Forms.TextBox();
            this.Grilla = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 58);
            this.label2.TabIndex = 12;
            this.label2.Text = "Incidente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textDireccion
            // 
            this.textDireccion.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDireccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textDireccion.Location = new System.Drawing.Point(32, 252);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.PlaceholderText = "Dirección";
            this.textDireccion.Size = new System.Drawing.Size(231, 27);
            this.textDireccion.TabIndex = 11;
            this.textDireccion.TextChanged += new System.EventHandler(this.textDireccion_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(60, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 34);
            this.button3.TabIndex = 8;
            this.button3.Text = "Registrar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // listProblema
            // 
            this.listProblema.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listProblema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listProblema.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listProblema.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.listProblema.FormattingEnabled = true;
            this.listProblema.ItemHeight = 21;
            this.listProblema.Items.AddRange(new object[] {
            "Alumbrado público",
            "Bacheo",
            "Cloacas",
            "Plazas y espacios",
            "Predio baldio o edificado",
            "Semáforos"});
            this.listProblema.Location = new System.Drawing.Point(32, 213);
            this.listProblema.Name = "listProblema";
            this.listProblema.Size = new System.Drawing.Size(231, 23);
            this.listProblema.TabIndex = 1;
            this.listProblema.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.PobreTITO);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 51);
            this.panel1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(712, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // PobreTITO
            // 
            this.PobreTITO.AutoSize = true;
            this.PobreTITO.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PobreTITO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PobreTITO.Location = new System.Drawing.Point(0, 9);
            this.PobreTITO.Name = "PobreTITO";
            this.PobreTITO.Size = new System.Drawing.Size(144, 33);
            this.PobreTITO.TabIndex = 5;
            this.PobreTITO.Text = "PobreTITO";
            // 
            // textCUIL
            // 
            this.textCUIL.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textCUIL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCUIL.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textCUIL.Location = new System.Drawing.Point(32, 169);
            this.textCUIL.Name = "textCUIL";
            this.textCUIL.PlaceholderText = "CUIL";
            this.textCUIL.Size = new System.Drawing.Size(231, 27);
            this.textCUIL.TabIndex = 14;
            // 
            // Grilla
            // 
            this.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grilla.Location = new System.Drawing.Point(288, 97);
            this.Grilla.Name = "Grilla";
            this.Grilla.RowTemplate.Height = 25;
            this.Grilla.Size = new System.Drawing.Size(443, 235);
            this.Grilla.TabIndex = 15;
            this.Grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RegistrarProblema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(754, 411);
            this.Controls.Add(this.Grilla);
            this.Controls.Add(this.textCUIL);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listProblema);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarProblema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private TextBox textDireccion;
        private Button button3;
        private ListBox listProblema;
        private Panel panel1;
        private Button button1;
        private Label PobreTITO;
        public TextBox textCUIL;
        private DataGridView Grilla;
    }
}