namespace SuaFada.Com
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbFzBarulho = new System.Windows.Forms.RadioButton();
            this.rbNaoBarulho = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbSimMulher = new System.Windows.Forms.RadioButton();
            this.rbNaoMulher = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSimAsaQuebrada = new System.Windows.Forms.RadioButton();
            this.rbNaoAsaQuebrada = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbElemento = new System.Windows.Forms.ComboBox();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorAsa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picturi = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFamilia = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFamilia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCorAsa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturi)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tab);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(995, 649);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(987, 623);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista Fada";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Indigo;
            this.button3.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Fuchsia;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button3.Location = new System.Drawing.Point(768, 168);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 47);
            this.button3.TabIndex = 4;
            this.button3.Text = "Adicionar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Indigo;
            this.button2.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Fuchsia;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(768, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Fuchsia;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(768, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNome,
            this.ColumnFamilia,
            this.ColumnCor,
            this.ColumnCorAsa,
            this.ColumnSexo});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DarkViolet;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.LightGreen;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(759, 458);
            this.dataGridView1.TabIndex = 1;
            // 
            // tab
            // 
            this.tab.BackColor = System.Drawing.Color.Indigo;
            this.tab.Controls.Add(this.groupBox2);
            this.tab.Controls.Add(this.groupBox3);
            this.tab.Controls.Add(this.groupBox1);
            this.tab.Controls.Add(this.button5);
            this.tab.Controls.Add(this.button4);
            this.tab.Controls.Add(this.label9);
            this.tab.Controls.Add(this.cbElemento);
            this.tab.Controls.Add(this.txtTamanho);
            this.tab.Controls.Add(this.label5);
            this.tab.Controls.Add(this.txtCorAsa);
            this.tab.Controls.Add(this.label4);
            this.tab.Controls.Add(this.txtCor);
            this.tab.Controls.Add(this.label3);
            this.tab.Controls.Add(this.picturi);
            this.tab.Controls.Add(this.label2);
            this.tab.Controls.Add(this.txtFamilia);
            this.tab.Controls.Add(this.txtNome);
            this.tab.Controls.Add(this.label1);
            this.tab.Location = new System.Drawing.Point(4, 22);
            this.tab.Name = "tab";
            this.tab.Padding = new System.Windows.Forms.Padding(3);
            this.tab.Size = new System.Drawing.Size(987, 623);
            this.tab.TabIndex = 1;
            this.tab.Text = "Cadastrar Fadinhas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFzBarulho);
            this.groupBox2.Controls.Add(this.rbNaoBarulho);
            this.groupBox2.Font = new System.Drawing.Font("Mistral", 20.25F);
            this.groupBox2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.groupBox2.Location = new System.Drawing.Point(255, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Faz Barulho?";
            // 
            // rbFzBarulho
            // 
            this.rbFzBarulho.AutoSize = true;
            this.rbFzBarulho.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFzBarulho.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.rbFzBarulho.Location = new System.Drawing.Point(6, 39);
            this.rbFzBarulho.Name = "rbFzBarulho";
            this.rbFzBarulho.Size = new System.Drawing.Size(67, 37);
            this.rbFzBarulho.TabIndex = 19;
            this.rbFzBarulho.Text = "Sim";
            this.rbFzBarulho.UseVisualStyleBackColor = true;
            // 
            // rbNaoBarulho
            // 
            this.rbNaoBarulho.AutoSize = true;
            this.rbNaoBarulho.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNaoBarulho.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.rbNaoBarulho.Location = new System.Drawing.Point(105, 39);
            this.rbNaoBarulho.Name = "rbNaoBarulho";
            this.rbNaoBarulho.Size = new System.Drawing.Size(67, 37);
            this.rbNaoBarulho.TabIndex = 20;
            this.rbNaoBarulho.Text = "Não";
            this.rbNaoBarulho.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbSimMulher);
            this.groupBox3.Controls.Add(this.rbNaoMulher);
            this.groupBox3.Font = new System.Drawing.Font("Mistral", 20.25F);
            this.groupBox3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.groupBox3.Location = new System.Drawing.Point(15, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "É Mulher?";
            // 
            // rbSimMulher
            // 
            this.rbSimMulher.AutoSize = true;
            this.rbSimMulher.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSimMulher.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.rbSimMulher.Location = new System.Drawing.Point(20, 39);
            this.rbSimMulher.Name = "rbSimMulher";
            this.rbSimMulher.Size = new System.Drawing.Size(67, 37);
            this.rbSimMulher.TabIndex = 16;
            this.rbSimMulher.Text = "Sim";
            this.rbSimMulher.UseVisualStyleBackColor = true;
            // 
            // rbNaoMulher
            // 
            this.rbNaoMulher.AutoSize = true;
            this.rbNaoMulher.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNaoMulher.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.rbNaoMulher.Location = new System.Drawing.Point(107, 39);
            this.rbNaoMulher.Name = "rbNaoMulher";
            this.rbNaoMulher.Size = new System.Drawing.Size(67, 37);
            this.rbNaoMulher.TabIndex = 17;
            this.rbNaoMulher.Text = "Não";
            this.rbNaoMulher.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSimAsaQuebrada);
            this.groupBox1.Controls.Add(this.rbNaoAsaQuebrada);
            this.groupBox1.Font = new System.Drawing.Font("Mistral", 20.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.groupBox1.Location = new System.Drawing.Point(504, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "A Asa é Quebrada?";
            // 
            // rbSimAsaQuebrada
            // 
            this.rbSimAsaQuebrada.AutoSize = true;
            this.rbSimAsaQuebrada.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSimAsaQuebrada.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.rbSimAsaQuebrada.Location = new System.Drawing.Point(16, 39);
            this.rbSimAsaQuebrada.Name = "rbSimAsaQuebrada";
            this.rbSimAsaQuebrada.Size = new System.Drawing.Size(67, 37);
            this.rbSimAsaQuebrada.TabIndex = 13;
            this.rbSimAsaQuebrada.Text = "Sim";
            this.rbSimAsaQuebrada.UseVisualStyleBackColor = true;
            // 
            // rbNaoAsaQuebrada
            // 
            this.rbNaoAsaQuebrada.AutoSize = true;
            this.rbNaoAsaQuebrada.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNaoAsaQuebrada.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.rbNaoAsaQuebrada.Location = new System.Drawing.Point(115, 39);
            this.rbNaoAsaQuebrada.Name = "rbNaoAsaQuebrada";
            this.rbNaoAsaQuebrada.Size = new System.Drawing.Size(67, 37);
            this.rbNaoAsaQuebrada.TabIndex = 14;
            this.rbNaoAsaQuebrada.Text = "Não";
            this.rbNaoAsaQuebrada.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Indigo;
            this.button5.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Fuchsia;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button5.Location = new System.Drawing.Point(739, 364);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(213, 47);
            this.button5.TabIndex = 24;
            this.button5.Text = "Salavar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Indigo;
            this.button4.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Fuchsia;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button4.Location = new System.Drawing.Point(511, 364);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(213, 47);
            this.button4.TabIndex = 23;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label9.Location = new System.Drawing.Point(8, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 42);
            this.label9.TabIndex = 22;
            this.label9.Text = "Elemento";
            // 
            // cbElemento
            // 
            this.cbElemento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbElemento.FormattingEnabled = true;
            this.cbElemento.Items.AddRange(new object[] {
            "Fogo",
            "Água",
            "Ar",
            "Gelo",
            "Terra",
            "Luz",
            "Dark",
            "LUIS FADINHA",
            "GOD"});
            this.cbElemento.Location = new System.Drawing.Point(134, 317);
            this.cbElemento.Name = "cbElemento";
            this.cbElemento.Size = new System.Drawing.Size(151, 28);
            this.cbElemento.TabIndex = 21;
            // 
            // txtTamanho
            // 
            this.txtTamanho.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTamanho.Location = new System.Drawing.Point(258, 145);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(197, 24);
            this.txtTamanho.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label5.Location = new System.Drawing.Point(251, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 42);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tamanho da Asa";
            // 
            // txtCorAsa
            // 
            this.txtCorAsa.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorAsa.Location = new System.Drawing.Point(15, 145);
            this.txtCorAsa.Name = "txtCorAsa";
            this.txtCorAsa.Size = new System.Drawing.Size(197, 24);
            this.txtCorAsa.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(8, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cor da Asa";
            // 
            // txtCor
            // 
            this.txtCor.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCor.Location = new System.Drawing.Point(507, 48);
            this.txtCor.Name = "txtCor";
            this.txtCor.Size = new System.Drawing.Size(197, 24);
            this.txtCor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(500, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cor";
            // 
            // picturi
            // 
            this.picturi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturi.Image = ((System.Drawing.Image)(resources.GetObject("picturi.Image")));
            this.picturi.Location = new System.Drawing.Point(766, 6);
            this.picturi.Name = "picturi";
            this.picturi.Size = new System.Drawing.Size(169, 197);
            this.picturi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturi.TabIndex = 5;
            this.picturi.TabStop = false;
            this.picturi.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(253, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Família\r\n";
            // 
            // txtFamilia
            // 
            this.txtFamilia.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFamilia.Location = new System.Drawing.Point(258, 48);
            this.txtFamilia.Name = "txtFamilia";
            this.txtFamilia.Size = new System.Drawing.Size(197, 24);
            this.txtFamilia.TabIndex = 3;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(15, 48);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(197, 24);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(987, 623);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cadastro Rápido";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(987, 623);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Cadastro ultra rápido";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ColumnNome
            // 
            this.ColumnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkViolet;
            this.ColumnNome.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnFamilia
            // 
            this.ColumnFamilia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFamilia.HeaderText = "Família";
            this.ColumnFamilia.Name = "ColumnFamilia";
            this.ColumnFamilia.ReadOnly = true;
            // 
            // ColumnCor
            // 
            this.ColumnCor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCor.HeaderText = "Cor";
            this.ColumnCor.Name = "ColumnCor";
            this.ColumnCor.ReadOnly = true;
            // 
            // ColumnCorAsa
            // 
            this.ColumnCorAsa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCorAsa.HeaderText = "Cor da Asa";
            this.ColumnCorAsa.Name = "ColumnCorAsa";
            this.ColumnCorAsa.ReadOnly = true;
            // 
            // ColumnSexo
            // 
            this.ColumnSexo.HeaderText = "Sexo";
            this.ColumnSexo.Name = "ColumnSexo";
            this.ColumnSexo.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 484);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ww.Fadinhas.com.br";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tab.ResumeLayout(false);
            this.tab.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tab;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFamilia;
        private System.Windows.Forms.PictureBox picturi;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorAsa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbNaoAsaQuebrada;
        private System.Windows.Forms.RadioButton rbSimAsaQuebrada;
        private System.Windows.Forms.RadioButton rbNaoMulher;
        private System.Windows.Forms.RadioButton rbSimMulher;
        private System.Windows.Forms.RadioButton rbNaoBarulho;
        private System.Windows.Forms.RadioButton rbFzBarulho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbElemento;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFamilia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCorAsa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSexo;
    }
}

