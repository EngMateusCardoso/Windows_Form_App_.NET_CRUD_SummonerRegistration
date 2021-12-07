
namespace Uso_de_BD_CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxInvocador = new System.Windows.Forms.TextBox();
            this.lblInvocador = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblRank = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.listBoxSaida = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtIDDelete = new System.Windows.Forms.TextBox();
            this.lblIDDelete = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxInvocador
            // 
            this.txtBoxInvocador.Font = new System.Drawing.Font("Algerian", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInvocador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(23)))));
            this.txtBoxInvocador.Location = new System.Drawing.Point(117, 6);
            this.txtBoxInvocador.Name = "txtBoxInvocador";
            this.txtBoxInvocador.Size = new System.Drawing.Size(212, 30);
            this.txtBoxInvocador.TabIndex = 0;
            // 
            // lblInvocador
            // 
            this.lblInvocador.AutoSize = true;
            this.lblInvocador.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvocador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(82)))));
            this.lblInvocador.Location = new System.Drawing.Point(3, 4);
            this.lblInvocador.Name = "lblInvocador";
            this.lblInvocador.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblInvocador.Size = new System.Drawing.Size(121, 35);
            this.lblInvocador.TabIndex = 1;
            this.lblInvocador.Text = "Invocador: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.lblRank);
            this.panel1.Controls.Add(this.txtBoxInvocador);
            this.panel1.Controls.Add(this.lblInvocador);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 118);
            this.panel1.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(82)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdicionar.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(30)))));
            this.btnAdicionar.Location = new System.Drawing.Point(230, 92);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(99, 27);
            this.btnAdicionar.TabIndex = 7;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Algerian", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(23)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ferro",
            "Bronze",
            "Prata",
            "Ouro",
            "Platina",
            "Diamante",
            "Mestre",
            "Grão-Mestre"});
            this.comboBox1.Location = new System.Drawing.Point(150, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(23)))));
            this.numericUpDown1.Location = new System.Drawing.Point(291, 54);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 29);
            this.numericUpDown1.TabIndex = 5;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(82)))));
            this.lblRank.Location = new System.Drawing.Point(74, 53);
            this.lblRank.Name = "lblRank";
            this.lblRank.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblRank.Size = new System.Drawing.Size(70, 35);
            this.lblRank.TabIndex = 4;
            this.lblRank.Text = "Rank: ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Algerian", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(23)))));
            this.textBox1.Location = new System.Drawing.Point(116, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 30);
            this.textBox1.TabIndex = 3;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(82)))));
            this.lblID.Location = new System.Drawing.Point(73, 39);
            this.lblID.Name = "lblID";
            this.lblID.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblID.Size = new System.Drawing.Size(37, 35);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID: ";
            // 
            // btnConectar
            // 
            this.btnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(82)))));
            this.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConectar.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(30)))));
            this.btnConectar.Location = new System.Drawing.Point(242, 265);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(99, 27);
            this.btnConectar.TabIndex = 8;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = false;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // listBoxSaida
            // 
            this.listBoxSaida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(23)))));
            this.listBoxSaida.FormattingEnabled = true;
            this.listBoxSaida.Location = new System.Drawing.Point(15, 177);
            this.listBoxSaida.Name = "listBoxSaida";
            this.listBoxSaida.Size = new System.Drawing.Size(545, 82);
            this.listBoxSaida.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.txtIDDelete);
            this.panel2.Controls.Add(this.lblIDDelete);
            this.panel2.Location = new System.Drawing.Point(12, 298);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 81);
            this.panel2.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(82)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(30)))));
            this.btnDelete.Location = new System.Drawing.Point(436, 47);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(99, 27);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // txtIDDelete
            // 
            this.txtIDDelete.Font = new System.Drawing.Font("Algerian", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(23)))));
            this.txtIDDelete.Location = new System.Drawing.Point(499, 9);
            this.txtIDDelete.Name = "txtIDDelete";
            this.txtIDDelete.Size = new System.Drawing.Size(36, 30);
            this.txtIDDelete.TabIndex = 3;
            // 
            // lblIDDelete
            // 
            this.lblIDDelete.AutoSize = true;
            this.lblIDDelete.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(82)))));
            this.lblIDDelete.Location = new System.Drawing.Point(456, 9);
            this.lblIDDelete.Name = "lblIDDelete";
            this.lblIDDelete.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblIDDelete.Size = new System.Drawing.Size(37, 35);
            this.lblIDDelete.TabIndex = 2;
            this.lblIDDelete.Text = "ID: ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAtualizar);
            this.panel3.Controls.Add(this.lblID);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Location = new System.Drawing.Point(381, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 109);
            this.panel3.TabIndex = 8;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(82)))));
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtualizar.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(30)))));
            this.btnAtualizar.Location = new System.Drawing.Point(55, 79);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(99, 27);
            this.btnAtualizar.TabIndex = 9;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listBoxSaida);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "Form1";
            this.Text = "Gerenciador de times";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxInvocador;
        private System.Windows.Forms.Label lblInvocador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ListBox listBoxSaida;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtIDDelete;
        private System.Windows.Forms.Label lblIDDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAtualizar;
    }
}

