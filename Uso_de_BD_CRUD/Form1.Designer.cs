
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.comboBoxRank = new System.Windows.Forms.ComboBox();
            this.numboxDivisao = new System.Windows.Forms.NumericUpDown();
            this.lblRank = new System.Windows.Forms.Label();
            this.btnConectar = new System.Windows.Forms.Button();
            this.listBoxSaida = new System.Windows.Forms.ListBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numboxDivisao)).BeginInit();
            this.SuspendLayout();
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
            // txtBoxInvocador
            // 
            this.txtBoxInvocador.Font = new System.Drawing.Font("Algerian", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInvocador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(23)))));
            this.txtBoxInvocador.Location = new System.Drawing.Point(117, 6);
            this.txtBoxInvocador.Name = "txtBoxInvocador";
            this.txtBoxInvocador.Size = new System.Drawing.Size(212, 30);
            this.txtBoxInvocador.TabIndex = 1;
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
            this.lblInvocador.TabIndex = 0;
            this.lblInvocador.Text = "Invocador: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnAdicionar);
            this.panel1.Controls.Add(this.comboBoxRank);
            this.panel1.Controls.Add(this.numboxDivisao);
            this.panel1.Controls.Add(this.lblRank);
            this.panel1.Controls.Add(this.txtBoxInvocador);
            this.panel1.Controls.Add(this.lblInvocador);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 118);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnAtualizar);
            this.panel3.Controls.Add(this.lblID);
            this.panel3.Controls.Add(this.txtBoxID);
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
            this.btnAtualizar.Location = new System.Drawing.Point(52, 39);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(109, 27);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "Atualizar ID";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(82)))));
            this.lblID.Location = new System.Drawing.Point(73, 1);
            this.lblID.Name = "lblID";
            this.lblID.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblID.Size = new System.Drawing.Size(37, 35);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID: ";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Font = new System.Drawing.Font("Algerian", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(23)))));
            this.txtBoxID.Location = new System.Drawing.Point(116, 6);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(36, 30);
            this.txtBoxID.TabIndex = 4;
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
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // comboBoxRank
            // 
            this.comboBoxRank.Font = new System.Drawing.Font("Algerian", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxRank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(23)))));
            this.comboBoxRank.FormattingEnabled = true;
            this.comboBoxRank.Items.AddRange(new object[] {
            "Ferro",
            "Bronze",
            "Prata",
            "Ouro",
            "Platina",
            "Diamante",
            "Mestre",
            "Grão-Mestre"});
            this.comboBoxRank.Location = new System.Drawing.Point(150, 56);
            this.comboBoxRank.Name = "comboBoxRank";
            this.comboBoxRank.Size = new System.Drawing.Size(121, 27);
            this.comboBoxRank.TabIndex = 2;
            // 
            // numboxDivisao
            // 
            this.numboxDivisao.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numboxDivisao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(23)))));
            this.numboxDivisao.Location = new System.Drawing.Point(291, 54);
            this.numboxDivisao.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numboxDivisao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numboxDivisao.Name = "numboxDivisao";
            this.numboxDivisao.Size = new System.Drawing.Size(38, 29);
            this.numboxDivisao.TabIndex = 3;
            this.numboxDivisao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.lblRank.TabIndex = 0;
            this.lblRank.Text = "Rank: ";
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
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(184)))), ((int)(((byte)(82)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Algerian", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(62)))), ((int)(((byte)(30)))));
            this.btnDelete.Location = new System.Drawing.Point(52, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 27);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete ID";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(458, 317);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 27);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(24)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(570, 356);
            this.Controls.Add(this.btnSair);
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
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numboxDivisao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxInvocador;
        private System.Windows.Forms.Label lblInvocador;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.NumericUpDown numboxDivisao;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.ComboBox comboBoxRank;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ListBox listBoxSaida;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnSair;
    }
}

