namespace Projeto_Sagra
{
    partial class compra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compra));
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txtNumero = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFunc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCpfCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblFunc = new System.Windows.Forms.Label();
            this.lblCpfCliente = new System.Windows.Forms.Label();
            this.numericQtde = new System.Windows.Forms.NumericUpDown();
            this.gridviewCompra = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericQtde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCompra)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 18;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Black;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(782, 509);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(127, 36);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Voltar";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.BorderRadius = 18;
            this.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumero.DefaultText = "";
            this.txtNumero.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumero.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumero.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNumero.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumero.Location = new System.Drawing.Point(136, 260);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.PlaceholderText = "";
            this.txtNumero.SelectedText = "";
            this.txtNumero.Size = new System.Drawing.Size(235, 36);
            this.txtNumero.TabIndex = 1;
            this.txtNumero.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // txtFunc
            // 
            this.txtFunc.BorderRadius = 18;
            this.txtFunc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFunc.DefaultText = "";
            this.txtFunc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFunc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFunc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFunc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFunc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFunc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFunc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFunc.Location = new System.Drawing.Point(136, 364);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.PasswordChar = '\0';
            this.txtFunc.PlaceholderText = "";
            this.txtFunc.SelectedText = "";
            this.txtFunc.Size = new System.Drawing.Size(641, 36);
            this.txtFunc.TabIndex = 2;
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.BorderRadius = 18;
            this.txtCpfCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCpfCliente.DefaultText = "";
            this.txtCpfCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCpfCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCpfCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCpfCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCpfCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCpfCliente.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCpfCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCpfCliente.Location = new System.Drawing.Point(136, 448);
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.PasswordChar = '\0';
            this.txtCpfCliente.PlaceholderText = "";
            this.txtCpfCliente.SelectedText = "";
            this.txtCpfCliente.Size = new System.Drawing.Size(641, 36);
            this.txtCpfCliente.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(37, 271);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(44, 13);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Numero";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(402, 271);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Location = new System.Drawing.Point(37, 376);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(85, 13);
            this.lblFunc.TabIndex = 7;
            this.lblFunc.Text = "Nro. Funcionario";
            // 
            // lblCpfCliente
            // 
            this.lblCpfCliente.AutoSize = true;
            this.lblCpfCliente.Location = new System.Drawing.Point(40, 462);
            this.lblCpfCliente.Name = "lblCpfCliente";
            this.lblCpfCliente.Size = new System.Drawing.Size(62, 13);
            this.lblCpfCliente.TabIndex = 8;
            this.lblCpfCliente.Text = "CPF Cliente";
            this.lblCpfCliente.Click += new System.EventHandler(this.lblCpfCliente_Click);
            // 
            // numericQtde
            // 
            this.numericQtde.Location = new System.Drawing.Point(484, 269);
            this.numericQtde.Name = "numericQtde";
            this.numericQtde.Size = new System.Drawing.Size(45, 20);
            this.numericQtde.TabIndex = 9;
            // 
            // gridviewCompra
            // 
            this.gridviewCompra.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridviewCompra.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewCompra.ColumnHeadersHeight = 30;
            this.gridviewCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewCompra.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridviewCompra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewCompra.Location = new System.Drawing.Point(581, 202);
            this.gridviewCompra.Name = "gridviewCompra";
            this.gridviewCompra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewCompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridviewCompra.RowHeadersVisible = false;
            this.gridviewCompra.Size = new System.Drawing.Size(305, 117);
            this.gridviewCompra.TabIndex = 10;
            this.gridviewCompra.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewCompra.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewCompra.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridviewCompra.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.gridviewCompra.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridviewCompra.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridviewCompra.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridviewCompra.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
            this.gridviewCompra.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridviewCompra.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewCompra.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridviewCompra.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gridviewCompra.ThemeStyle.HeaderStyle.Height = 30;
            this.gridviewCompra.ThemeStyle.ReadOnly = false;
            this.gridviewCompra.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridviewCompra.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridviewCompra.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridviewCompra.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridviewCompra.ThemeStyle.RowsStyle.Height = 22;
            this.gridviewCompra.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver;
            this.gridviewCompra.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 32;
            this.btnAdd.Location = new System.Drawing.Point(27, 509);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(204, 41);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Registrar compra";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddProdutos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 165);
            this.panel1.TabIndex = 13;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(888, 1);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(538, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(359, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Compras";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 71);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridviewCompra);
            this.Controls.Add(this.numericQtde);
            this.Controls.Add(this.lblCpfCliente);
            this.Controls.Add(this.lblFunc);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtCpfCliente);
            this.Controls.Add(this.txtFunc);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.guna2Button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "compra";
            ((System.ComponentModel.ISupportInitialize)(this.numericQtde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewCompra)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txtNumero;
        private Guna.UI2.WinForms.Guna2TextBox txtFunc;
        private Guna.UI2.WinForms.Guna2TextBox txtCpfCliente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.Label lblCpfCliente;
        private System.Windows.Forms.NumericUpDown numericQtde;
        private Guna.UI2.WinForms.Guna2DataGridView gridviewCompra;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}