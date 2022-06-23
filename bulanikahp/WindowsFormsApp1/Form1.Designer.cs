namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.textBox52 = new System.Windows.Forms.TextBox();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sonucDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adayPersonelBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bulanik_AhpDataSet1 = new WindowsFormsApp1.Bulanik_AhpDataSet1();
            this.adayPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adayPersonelDataSet = new WindowsFormsApp1.adayPersonelDataSet();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.comboBox35 = new System.Windows.Forms.ComboBox();
            this.comboBox34 = new System.Windows.Forms.ComboBox();
            this.comboBox33 = new System.Windows.Forms.ComboBox();
            this.comboBox32 = new System.Windows.Forms.ComboBox();
            this.comboBox31 = new System.Windows.Forms.ComboBox();
            this.comboBox27 = new System.Windows.Forms.ComboBox();
            this.comboBox23 = new System.Windows.Forms.ComboBox();
            this.comboBox22 = new System.Windows.Forms.ComboBox();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.comboBox20 = new System.Windows.Forms.ComboBox();
            this.comboBox21 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.comboBox24 = new System.Windows.Forms.ComboBox();
            this.comboBox25 = new System.Windows.Forms.ComboBox();
            this.comboBox26 = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.masterDataSet = new WindowsFormsApp1.masterDataSet();
            this.masterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adayPersonelTableAdapter = new WindowsFormsApp1.adayPersonelDataSetTableAdapters.adayPersonelTableAdapter();
            this.bulanik_AhpDataSet = new WindowsFormsApp1.Bulanik_AhpDataSet();
            this.adayPersonelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.adayPersonelTableAdapter1 = new WindowsFormsApp1.Bulanik_AhpDataSetTableAdapters.adayPersonelTableAdapter();
            this.adayPersonelTableAdapter2 = new WindowsFormsApp1.Bulanik_AhpDataSet1TableAdapters.adayPersonelTableAdapter();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox62 = new System.Windows.Forms.ComboBox();
            this.comboBox61 = new System.Windows.Forms.ComboBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.comboBox60 = new System.Windows.Forms.ComboBox();
            this.comboBox59 = new System.Windows.Forms.ComboBox();
            this.comboBox58 = new System.Windows.Forms.ComboBox();
            this.comboBox57 = new System.Windows.Forms.ComboBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adayPersonelBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulanik_AhpDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adayPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adayPersonelDataSet)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulanik_AhpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adayPersonelBindingSource1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label31);
            this.tabPage4.Controls.Add(this.label30);
            this.tabPage4.Controls.Add(this.label29);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Controls.Add(this.textBox53);
            this.tabPage4.Controls.Add(this.textBox52);
            this.tabPage4.Controls.Add(this.textBox51);
            this.tabPage4.Controls.Add(this.textBox50);
            this.tabPage4.Controls.Add(this.button9);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(720, 497);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Sonuçlar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox53
            // 
            this.textBox53.Location = new System.Drawing.Point(155, 37);
            this.textBox53.Name = "textBox53";
            this.textBox53.ReadOnly = true;
            this.textBox53.Size = new System.Drawing.Size(100, 20);
            this.textBox53.TabIndex = 12;
            // 
            // textBox52
            // 
            this.textBox52.Location = new System.Drawing.Point(155, 78);
            this.textBox52.Name = "textBox52";
            this.textBox52.ReadOnly = true;
            this.textBox52.Size = new System.Drawing.Size(100, 20);
            this.textBox52.TabIndex = 11;
            // 
            // textBox51
            // 
            this.textBox51.Location = new System.Drawing.Point(554, 34);
            this.textBox51.Name = "textBox51";
            this.textBox51.ReadOnly = true;
            this.textBox51.Size = new System.Drawing.Size(100, 20);
            this.textBox51.TabIndex = 10;
            // 
            // textBox50
            // 
            this.textBox50.Location = new System.Drawing.Point(554, 78);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(100, 20);
            this.textBox50.TabIndex = 9;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(482, 447);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(96, 38);
            this.button9.TabIndex = 2;
            this.button9.Text = "Sil";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(601, 447);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 38);
            this.button5.TabIndex = 1;
            this.button5.Text = "Yeni Aday Ekle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn2,
            this.soyadDataGridViewTextBoxColumn2,
            this.sonucDataGridViewTextBoxColumn,
            this.telefon});
            this.dataGridView1.DataSource = this.adayPersonelBindingSource2;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(6, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(708, 294);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // adDataGridViewTextBoxColumn2
            // 
            this.adDataGridViewTextBoxColumn2.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn2.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn2.Name = "adDataGridViewTextBoxColumn2";
            this.adDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn2
            // 
            this.soyadDataGridViewTextBoxColumn2.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn2.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn2.Name = "soyadDataGridViewTextBoxColumn2";
            this.soyadDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // sonucDataGridViewTextBoxColumn
            // 
            this.sonucDataGridViewTextBoxColumn.DataPropertyName = "sonuc";
            this.sonucDataGridViewTextBoxColumn.HeaderText = "sonuc";
            this.sonucDataGridViewTextBoxColumn.Name = "sonucDataGridViewTextBoxColumn";
            this.sonucDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefon
            // 
            this.telefon.DataPropertyName = "telefon";
            this.telefon.HeaderText = "telefon";
            this.telefon.Name = "telefon";
            this.telefon.ReadOnly = true;
            // 
            // adayPersonelBindingSource2
            // 
            this.adayPersonelBindingSource2.DataMember = "adayPersonel";
            this.adayPersonelBindingSource2.DataSource = this.bulanik_AhpDataSet1;
            // 
            // bulanik_AhpDataSet1
            // 
            this.bulanik_AhpDataSet1.DataSetName = "Bulanik_AhpDataSet1";
            this.bulanik_AhpDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adayPersonelBindingSource
            // 
            this.adayPersonelBindingSource.DataMember = "adayPersonel";
            this.adayPersonelBindingSource.DataSource = this.adayPersonelDataSet;
            // 
            // adayPersonelDataSet
            // 
            this.adayPersonelDataSet.DataSetName = "adayPersonelDataSet";
            this.adayPersonelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.label27);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.comboBox35);
            this.tabPage3.Controls.Add(this.comboBox34);
            this.tabPage3.Controls.Add(this.comboBox33);
            this.tabPage3.Controls.Add(this.comboBox32);
            this.tabPage3.Controls.Add(this.comboBox31);
            this.tabPage3.Controls.Add(this.comboBox27);
            this.tabPage3.Controls.Add(this.comboBox23);
            this.tabPage3.Controls.Add(this.comboBox22);
            this.tabPage3.Controls.Add(this.comboBox18);
            this.tabPage3.Controls.Add(this.comboBox17);
            this.tabPage3.Controls.Add(this.comboBox16);
            this.tabPage3.Controls.Add(this.comboBox15);
            this.tabPage3.Controls.Add(this.comboBox14);
            this.tabPage3.Controls.Add(this.comboBox13);
            this.tabPage3.Controls.Add(this.comboBox12);
            this.tabPage3.Controls.Add(this.comboBox8);
            this.tabPage3.Controls.Add(this.textBox24);
            this.tabPage3.Controls.Add(this.textBox23);
            this.tabPage3.Controls.Add(this.textBox22);
            this.tabPage3.Controls.Add(this.textBox14);
            this.tabPage3.Controls.Add(this.textBox10);
            this.tabPage3.Controls.Add(this.comboBox6);
            this.tabPage3.Controls.Add(this.comboBox5);
            this.tabPage3.Controls.Add(this.comboBox4);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(720, 497);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Alternatifler";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(600, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 33);
            this.button2.TabIndex = 114;
            this.button2.Text = "Sonuç";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(29, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(490, 43);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alt Kriter:";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 20);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(108, 17);
            this.radioButton6.TabIndex = 106;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "1.1-Bilgi Paylaşımı";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(120, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(114, 17);
            this.radioButton5.TabIndex = 107;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "1.2-İletişim Becerisi";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(364, 19);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(120, 17);
            this.radioButton7.TabIndex = 109;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "1.4-Müşteri Odaklılık";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(240, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(118, 17);
            this.radioButton4.TabIndex = 108;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "1.3-Çözüm Odaklılık";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(29, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 46);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ana Kriter:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(106, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1-Temel Yetkinlik";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(118, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(118, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2-Yönetsel Yetkinlik";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(240, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(133, 17);
            this.radioButton3.TabIndex = 18;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3-Fonksiyonel Yetkinlik";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // comboBox35
            // 
            this.comboBox35.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox35.FormattingEnabled = true;
            this.comboBox35.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox35.Location = new System.Drawing.Point(478, 390);
            this.comboBox35.Name = "comboBox35";
            this.comboBox35.Size = new System.Drawing.Size(71, 21);
            this.comboBox35.TabIndex = 80;
            this.comboBox35.SelectedIndexChanged += new System.EventHandler(this.comboBox35_SelectedIndexChanged);
            // 
            // comboBox34
            // 
            this.comboBox34.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox34.FormattingEnabled = true;
            this.comboBox34.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox34.Location = new System.Drawing.Point(358, 390);
            this.comboBox34.Name = "comboBox34";
            this.comboBox34.Size = new System.Drawing.Size(71, 21);
            this.comboBox34.TabIndex = 79;
            this.comboBox34.SelectedIndexChanged += new System.EventHandler(this.comboBox34_SelectedIndexChanged);
            // 
            // comboBox33
            // 
            this.comboBox33.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox33.FormattingEnabled = true;
            this.comboBox33.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox33.Location = new System.Drawing.Point(240, 390);
            this.comboBox33.Name = "comboBox33";
            this.comboBox33.Size = new System.Drawing.Size(71, 21);
            this.comboBox33.TabIndex = 78;
            this.comboBox33.SelectedIndexChanged += new System.EventHandler(this.comboBox33_SelectedIndexChanged);
            // 
            // comboBox32
            // 
            this.comboBox32.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox32.FormattingEnabled = true;
            this.comboBox32.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox32.Location = new System.Drawing.Point(240, 333);
            this.comboBox32.Name = "comboBox32";
            this.comboBox32.Size = new System.Drawing.Size(71, 21);
            this.comboBox32.TabIndex = 77;
            this.comboBox32.SelectedIndexChanged += new System.EventHandler(this.comboBox32_SelectedIndexChanged);
            // 
            // comboBox31
            // 
            this.comboBox31.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox31.FormattingEnabled = true;
            this.comboBox31.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox31.Location = new System.Drawing.Point(358, 333);
            this.comboBox31.Name = "comboBox31";
            this.comboBox31.Size = new System.Drawing.Size(71, 21);
            this.comboBox31.TabIndex = 76;
            this.comboBox31.SelectedIndexChanged += new System.EventHandler(this.comboBox31_SelectedIndexChanged);
            // 
            // comboBox27
            // 
            this.comboBox27.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox27.FormattingEnabled = true;
            this.comboBox27.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox27.Location = new System.Drawing.Point(604, 333);
            this.comboBox27.Name = "comboBox27";
            this.comboBox27.Size = new System.Drawing.Size(71, 21);
            this.comboBox27.TabIndex = 72;
            this.comboBox27.SelectedIndexChanged += new System.EventHandler(this.comboBox27_SelectedIndexChanged);
            // 
            // comboBox23
            // 
            this.comboBox23.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox23.FormattingEnabled = true;
            this.comboBox23.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox23.Location = new System.Drawing.Point(604, 276);
            this.comboBox23.Name = "comboBox23";
            this.comboBox23.Size = new System.Drawing.Size(71, 21);
            this.comboBox23.TabIndex = 68;
            this.comboBox23.SelectedIndexChanged += new System.EventHandler(this.comboBox23_SelectedIndexChanged);
            // 
            // comboBox22
            // 
            this.comboBox22.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox22.FormattingEnabled = true;
            this.comboBox22.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox22.Location = new System.Drawing.Point(478, 276);
            this.comboBox22.Name = "comboBox22";
            this.comboBox22.Size = new System.Drawing.Size(71, 21);
            this.comboBox22.TabIndex = 67;
            this.comboBox22.SelectedIndexChanged += new System.EventHandler(this.comboBox22_SelectedIndexChanged);
            // 
            // comboBox18
            // 
            this.comboBox18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox18.FormattingEnabled = true;
            this.comboBox18.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox18.Location = new System.Drawing.Point(604, 216);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(71, 21);
            this.comboBox18.TabIndex = 63;
            this.comboBox18.SelectedIndexChanged += new System.EventHandler(this.comboBox18_SelectedIndexChanged);
            // 
            // comboBox17
            // 
            this.comboBox17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox17.FormattingEnabled = true;
            this.comboBox17.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox17.Location = new System.Drawing.Point(478, 216);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(71, 21);
            this.comboBox17.TabIndex = 62;
            this.comboBox17.SelectedIndexChanged += new System.EventHandler(this.comboBox17_SelectedIndexChanged);
            // 
            // comboBox16
            // 
            this.comboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox16.FormattingEnabled = true;
            this.comboBox16.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox16.Location = new System.Drawing.Point(358, 216);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(71, 21);
            this.comboBox16.TabIndex = 61;
            this.comboBox16.SelectedIndexChanged += new System.EventHandler(this.comboBox16_SelectedIndexChanged);
            // 
            // comboBox15
            // 
            this.comboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox15.FormattingEnabled = true;
            this.comboBox15.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox15.Location = new System.Drawing.Point(240, 276);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(71, 21);
            this.comboBox15.TabIndex = 60;
            this.comboBox15.SelectedIndexChanged += new System.EventHandler(this.comboBox15_SelectedIndexChanged);
            // 
            // comboBox14
            // 
            this.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox14.FormattingEnabled = true;
            this.comboBox14.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox14.Location = new System.Drawing.Point(127, 276);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(71, 21);
            this.comboBox14.TabIndex = 59;
            this.comboBox14.SelectedIndexChanged += new System.EventHandler(this.comboBox14_SelectedIndexChanged_1);
            // 
            // comboBox13
            // 
            this.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox13.FormattingEnabled = true;
            this.comboBox13.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox13.Location = new System.Drawing.Point(127, 333);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(71, 21);
            this.comboBox13.TabIndex = 58;
            this.comboBox13.SelectedIndexChanged += new System.EventHandler(this.comboBox13_SelectedIndexChanged);
            // 
            // comboBox12
            // 
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox12.Location = new System.Drawing.Point(127, 390);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(71, 21);
            this.comboBox12.TabIndex = 57;
            this.comboBox12.SelectedIndexChanged += new System.EventHandler(this.comboBox12_SelectedIndexChanged);
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox8.Location = new System.Drawing.Point(127, 216);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(71, 21);
            this.comboBox8.TabIndex = 53;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged_1);
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox24.Location = new System.Drawing.Point(130, 166);
            this.textBox24.Name = "textBox24";
            this.textBox24.ReadOnly = true;
            this.textBox24.Size = new System.Drawing.Size(68, 13);
            this.textBox24.TabIndex = 52;
            this.textBox24.Text = "Eşit Önem";
            this.textBox24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox23.Location = new System.Drawing.Point(240, 224);
            this.textBox23.Name = "textBox23";
            this.textBox23.ReadOnly = true;
            this.textBox23.Size = new System.Drawing.Size(71, 13);
            this.textBox23.TabIndex = 51;
            this.textBox23.Text = "Eşit Önem";
            this.textBox23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox22.Location = new System.Drawing.Point(358, 279);
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(71, 13);
            this.textBox22.TabIndex = 50;
            this.textBox22.Text = "Eşit Önem";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Location = new System.Drawing.Point(478, 339);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(71, 13);
            this.textBox14.TabIndex = 49;
            this.textBox14.Text = "Eşit Önem";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(604, 393);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(71, 13);
            this.textBox10.TabIndex = 45;
            this.textBox10.Text = "Eşit Önem";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox6.Location = new System.Drawing.Point(358, 163);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(71, 21);
            this.comboBox6.TabIndex = 36;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged_1);
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox5.Location = new System.Drawing.Point(478, 163);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(71, 21);
            this.comboBox5.TabIndex = 35;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged_1);
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox4.Location = new System.Drawing.Point(604, 163);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(71, 21);
            this.comboBox4.TabIndex = 34;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(240, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(438, 452);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 33);
            this.button4.TabIndex = 23;
            this.button4.Text = "Kaydet";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(519, 452);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 22;
            this.button3.Text = "Yenile";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.textBox11);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.comboBox7);
            this.tabPage2.Controls.Add(this.comboBox9);
            this.tabPage2.Controls.Add(this.comboBox10);
            this.tabPage2.Controls.Add(this.comboBox11);
            this.tabPage2.Controls.Add(this.comboBox19);
            this.tabPage2.Controls.Add(this.comboBox20);
            this.tabPage2.Controls.Add(this.comboBox21);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.comboBox24);
            this.tabPage2.Controls.Add(this.comboBox25);
            this.tabPage2.Controls.Add(this.comboBox26);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alt Kriterler";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox11.Location = new System.Drawing.Point(562, 309);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(71, 13);
            this.textBox11.TabIndex = 110;
            this.textBox11.Text = "Eşit Önem";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(481, 390);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 33);
            this.button6.TabIndex = 109;
            this.button6.Text = "Kaydet";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(562, 390);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 33);
            this.button7.TabIndex = 108;
            this.button7.Text = "Yenile";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox2.Location = new System.Drawing.Point(301, 306);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(71, 21);
            this.comboBox2.TabIndex = 101;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox3.Location = new System.Drawing.Point(427, 306);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(71, 21);
            this.comboBox3.TabIndex = 100;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox7.Location = new System.Drawing.Point(562, 243);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(71, 21);
            this.comboBox7.TabIndex = 99;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // comboBox9
            // 
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox9.Location = new System.Drawing.Point(562, 181);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(71, 21);
            this.comboBox9.TabIndex = 98;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // comboBox10
            // 
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox10.Location = new System.Drawing.Point(427, 181);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(71, 21);
            this.comboBox10.TabIndex = 97;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            // 
            // comboBox11
            // 
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox11.Location = new System.Drawing.Point(301, 243);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(71, 21);
            this.comboBox11.TabIndex = 96;
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.comboBox11_SelectedIndexChanged);
            // 
            // comboBox19
            // 
            this.comboBox19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox19.FormattingEnabled = true;
            this.comboBox19.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox19.Location = new System.Drawing.Point(181, 243);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(71, 21);
            this.comboBox19.TabIndex = 95;
            this.comboBox19.SelectedIndexChanged += new System.EventHandler(this.comboBox19_SelectedIndexChanged);
            // 
            // comboBox20
            // 
            this.comboBox20.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox20.FormattingEnabled = true;
            this.comboBox20.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox20.Location = new System.Drawing.Point(181, 306);
            this.comboBox20.Name = "comboBox20";
            this.comboBox20.Size = new System.Drawing.Size(71, 21);
            this.comboBox20.TabIndex = 94;
            this.comboBox20.SelectedIndexChanged += new System.EventHandler(this.comboBox20_SelectedIndexChanged);
            // 
            // comboBox21
            // 
            this.comboBox21.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox21.FormattingEnabled = true;
            this.comboBox21.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox21.Location = new System.Drawing.Point(181, 181);
            this.comboBox21.Name = "comboBox21";
            this.comboBox21.Size = new System.Drawing.Size(71, 21);
            this.comboBox21.TabIndex = 93;
            this.comboBox21.SelectedIndexChanged += new System.EventHandler(this.comboBox21_SelectedIndexChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox7.Location = new System.Drawing.Point(181, 119);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(71, 13);
            this.textBox7.TabIndex = 92;
            this.textBox7.Text = "Eşit Önem";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox8.Location = new System.Drawing.Point(301, 184);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(71, 13);
            this.textBox8.TabIndex = 91;
            this.textBox8.Text = "Eşit Önem";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox9.Location = new System.Drawing.Point(427, 246);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(71, 13);
            this.textBox9.TabIndex = 90;
            this.textBox9.Text = "Eşit Önem";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox24
            // 
            this.comboBox24.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox24.FormattingEnabled = true;
            this.comboBox24.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox24.Location = new System.Drawing.Point(562, 116);
            this.comboBox24.Name = "comboBox24";
            this.comboBox24.Size = new System.Drawing.Size(71, 21);
            this.comboBox24.TabIndex = 86;
            this.comboBox24.SelectedIndexChanged += new System.EventHandler(this.comboBox24_SelectedIndexChanged);
            // 
            // comboBox25
            // 
            this.comboBox25.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox25.FormattingEnabled = true;
            this.comboBox25.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox25.Location = new System.Drawing.Point(427, 116);
            this.comboBox25.Name = "comboBox25";
            this.comboBox25.Size = new System.Drawing.Size(71, 21);
            this.comboBox25.TabIndex = 85;
            this.comboBox25.SelectedIndexChanged += new System.EventHandler(this.comboBox25_SelectedIndexChanged);
            // 
            // comboBox26
            // 
            this.comboBox26.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox26.FormattingEnabled = true;
            this.comboBox26.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox26.Location = new System.Drawing.Point(301, 116);
            this.comboBox26.Name = "comboBox26";
            this.comboBox26.Size = new System.Drawing.Size(71, 21);
            this.comboBox26.TabIndex = 80;
            this.comboBox26.SelectedIndexChanged += new System.EventHandler(this.comboBox26_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 523);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.PaleGreen;
            this.tabPage5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Controls.Add(this.button8);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Controls.Add(this.textBox44);
            this.tabPage5.Controls.Add(this.textBox43);
            this.tabPage5.Controls.Add(this.textBox41);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabPage5.Size = new System.Drawing.Size(720, 497);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Aday Ekleme";
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(370, 300);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(98, 34);
            this.button8.TabIndex = 8;
            this.button8.Text = "Yenile";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(254, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox44
            // 
            this.textBox44.Location = new System.Drawing.Point(345, 212);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(123, 20);
            this.textBox44.TabIndex = 6;
            // 
            // textBox43
            // 
            this.textBox43.Location = new System.Drawing.Point(345, 161);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(123, 20);
            this.textBox43.TabIndex = 5;
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(345, 112);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(123, 20);
            this.textBox41.TabIndex = 4;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // masterDataSetBindingSource
            // 
            this.masterDataSetBindingSource.DataSource = this.masterDataSet;
            this.masterDataSetBindingSource.Position = 0;
            // 
            // adayPersonelTableAdapter
            // 
            this.adayPersonelTableAdapter.ClearBeforeFill = true;
            // 
            // bulanik_AhpDataSet
            // 
            this.bulanik_AhpDataSet.DataSetName = "Bulanik_AhpDataSet";
            this.bulanik_AhpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adayPersonelBindingSource1
            // 
            this.adayPersonelBindingSource1.DataMember = "adayPersonel";
            this.adayPersonelBindingSource1.DataSource = this.bulanik_AhpDataSet;
            // 
            // adayPersonelTableAdapter1
            // 
            this.adayPersonelTableAdapter1.ClearBeforeFill = true;
            // 
            // adayPersonelTableAdapter2
            // 
            this.adayPersonelTableAdapter2.ClearBeforeFill = true;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 186;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 186;
            // 
            // adDataGridViewTextBoxColumn1
            // 
            this.adDataGridViewTextBoxColumn1.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn1.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn1.Name = "adDataGridViewTextBoxColumn1";
            this.adDataGridViewTextBoxColumn1.Width = 186;
            // 
            // soyadDataGridViewTextBoxColumn1
            // 
            this.soyadDataGridViewTextBoxColumn1.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn1.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn1.Name = "soyadDataGridViewTextBoxColumn1";
            this.soyadDataGridViewTextBoxColumn1.Width = 186;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(251, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(251, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Telefonu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(251, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Soyadı:";
            // 
            // comboBox62
            // 
            this.comboBox62.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox62.FormattingEnabled = true;
            this.comboBox62.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox62.Location = new System.Drawing.Point(368, 134);
            this.comboBox62.Name = "comboBox62";
            this.comboBox62.Size = new System.Drawing.Size(71, 21);
            this.comboBox62.TabIndex = 64;
            this.comboBox62.SelectedIndexChanged += new System.EventHandler(this.comboBox62_SelectedIndexChanged);
            // 
            // comboBox61
            // 
            this.comboBox61.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox61.FormattingEnabled = true;
            this.comboBox61.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox61.Location = new System.Drawing.Point(529, 134);
            this.comboBox61.Name = "comboBox61";
            this.comboBox61.Size = new System.Drawing.Size(71, 21);
            this.comboBox61.TabIndex = 68;
            this.comboBox61.SelectedIndexChanged += new System.EventHandler(this.comboBox61_SelectedIndexChanged);
            // 
            // textBox27
            // 
            this.textBox27.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox27.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox27.Location = new System.Drawing.Point(529, 269);
            this.textBox27.Name = "textBox27";
            this.textBox27.ReadOnly = true;
            this.textBox27.Size = new System.Drawing.Size(71, 13);
            this.textBox27.TabIndex = 70;
            this.textBox27.Text = "Eşit Önem";
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox26
            // 
            this.textBox26.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox26.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox26.Location = new System.Drawing.Point(368, 199);
            this.textBox26.Name = "textBox26";
            this.textBox26.ReadOnly = true;
            this.textBox26.Size = new System.Drawing.Size(71, 13);
            this.textBox26.TabIndex = 71;
            this.textBox26.Text = "Eşit Önem";
            this.textBox26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox25
            // 
            this.textBox25.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox25.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox25.Location = new System.Drawing.Point(213, 137);
            this.textBox25.Name = "textBox25";
            this.textBox25.ReadOnly = true;
            this.textBox25.Size = new System.Drawing.Size(71, 13);
            this.textBox25.TabIndex = 72;
            this.textBox25.Text = "Eşit Önem";
            this.textBox25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox60
            // 
            this.comboBox60.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox60.FormattingEnabled = true;
            this.comboBox60.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox60.Location = new System.Drawing.Point(213, 196);
            this.comboBox60.Name = "comboBox60";
            this.comboBox60.Size = new System.Drawing.Size(71, 21);
            this.comboBox60.TabIndex = 73;
            this.comboBox60.SelectedIndexChanged += new System.EventHandler(this.comboBox60_SelectedIndexChanged);
            // 
            // comboBox59
            // 
            this.comboBox59.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox59.FormattingEnabled = true;
            this.comboBox59.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox59.Location = new System.Drawing.Point(213, 266);
            this.comboBox59.Name = "comboBox59";
            this.comboBox59.Size = new System.Drawing.Size(71, 21);
            this.comboBox59.TabIndex = 74;
            this.comboBox59.SelectedIndexChanged += new System.EventHandler(this.comboBox59_SelectedIndexChanged);
            // 
            // comboBox58
            // 
            this.comboBox58.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox58.FormattingEnabled = true;
            this.comboBox58.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox58.Location = new System.Drawing.Point(368, 266);
            this.comboBox58.Name = "comboBox58";
            this.comboBox58.Size = new System.Drawing.Size(71, 21);
            this.comboBox58.TabIndex = 75;
            this.comboBox58.SelectedIndexChanged += new System.EventHandler(this.comboBox58_SelectedIndexChanged);
            // 
            // comboBox57
            // 
            this.comboBox57.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox57.FormattingEnabled = true;
            this.comboBox57.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox57.Location = new System.Drawing.Point(529, 196);
            this.comboBox57.Name = "comboBox57";
            this.comboBox57.Size = new System.Drawing.Size(71, 21);
            this.comboBox57.TabIndex = 76;
            this.comboBox57.SelectedIndexChanged += new System.EventHandler(this.comboBox57_SelectedIndexChanged);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(563, 385);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 33);
            this.button11.TabIndex = 82;
            this.button11.Text = "Yenile";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(482, 385);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 33);
            this.button10.TabIndex = 83;
            this.button10.Text = "Kaydet";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox37
            // 
            this.textBox37.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox37.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox37.ForeColor = System.Drawing.Color.Maroon;
            this.textBox37.Location = new System.Drawing.Point(48, 405);
            this.textBox37.Name = "textBox37";
            this.textBox37.Size = new System.Drawing.Size(183, 13);
            this.textBox37.TabIndex = 84;
            this.textBox37.Text = "Not: Değer girilmediği takdirde 1 alınır.";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox37);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.comboBox57);
            this.tabPage1.Controls.Add(this.comboBox58);
            this.tabPage1.Controls.Add(this.comboBox59);
            this.tabPage1.Controls.Add(this.comboBox60);
            this.tabPage1.Controls.Add(this.textBox25);
            this.tabPage1.Controls.Add(this.textBox26);
            this.tabPage1.Controls.Add(this.textBox27);
            this.tabPage1.Controls.Add(this.comboBox61);
            this.tabPage1.Controls.Add(this.comboBox62);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(720, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ana Kriterler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(500, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "3-Fonksiyonel Yetkinlik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(351, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "2-Yönetsel Yetkinlik";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(191, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 89;
            this.label8.Text = "1-Temel Yetkinlik";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(45, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 13);
            this.label9.TabIndex = 91;
            this.label9.Text = "1-Temel Yetkinlik";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(45, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 13);
            this.label10.TabIndex = 90;
            this.label10.Text = "2-Yönetsel Yetkinlik";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(45, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 13);
            this.label6.TabIndex = 92;
            this.label6.Text = "3-Fonksiyonel Yetkinlik";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 112;
            this.label11.Text = "1.1-Bilgi Paylaşımı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 13);
            this.label12.TabIndex = 113;
            this.label12.Text = "1.2-İletişim Becerisi";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 13);
            this.label13.TabIndex = 114;
            this.label13.Text = "1.3-Çözüm Odaklılık";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(32, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 13);
            this.label14.TabIndex = 115;
            this.label14.Text = "1.4-Müşteri Odaklılık";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(536, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 119;
            this.label7.Text = "1.4-Müşteri Odaklılık";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(411, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 13);
            this.label15.TabIndex = 118;
            this.label15.Text = "1.3-Çözüm Odaklılık";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(288, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 13);
            this.label16.TabIndex = 117;
            this.label16.Text = "1.2-İletişim Becerisi";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(158, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 13);
            this.label17.TabIndex = 116;
            this.label17.Text = "1.1-Bilgi Paylaşımı";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(23, 166);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 13);
            this.label18.TabIndex = 115;
            this.label18.Text = "Karar Verme";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(23, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 13);
            this.label19.TabIndex = 116;
            this.label19.Text = "İş Bilgisi";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(23, 279);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 13);
            this.label20.TabIndex = 117;
            this.label20.Text = "Temsil Yeteneği";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(23, 336);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 13);
            this.label21.TabIndex = 118;
            this.label21.Text = "Ekip Çalışması";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(23, 393);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 13);
            this.label22.TabIndex = 119;
            this.label22.Text = "Proje Yönetimi";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label23.Location = new System.Drawing.Point(595, 128);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 13);
            this.label23.TabIndex = 124;
            this.label23.Text = "Proje Yönetimi";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.Location = new System.Drawing.Point(470, 128);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 13);
            this.label24.TabIndex = 123;
            this.label24.Text = "Ekip Çalışması";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label25.Location = new System.Drawing.Point(343, 128);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(97, 13);
            this.label25.TabIndex = 122;
            this.label25.Text = "Temsil Yeteneği";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.Location = new System.Drawing.Point(247, 128);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(54, 13);
            this.label26.TabIndex = 121;
            this.label26.Text = "İş Bilgisi";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.Location = new System.Drawing.Point(124, 128);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(76, 13);
            this.label27.TabIndex = 120;
            this.label27.Text = "Karar Verme";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(62, 37);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(25, 13);
            this.label28.TabIndex = 13;
            this.label28.Text = "Adı:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(62, 81);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 13);
            this.label29.TabIndex = 14;
            this.label29.Text = "Soyadı:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(479, 37);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(64, 13);
            this.label30.TabIndex = 15;
            this.label30.Text = "Aday Puanı:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(479, 81);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(52, 13);
            this.label31.TabIndex = 16;
            this.label31.Text = "Telefonu:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(35, 410);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 13);
            this.textBox1.TabIndex = 120;
            this.textBox1.Text = "Not: Değer girilmediği takdirde 1 alınır.";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.Color.Maroon;
            this.textBox2.Location = new System.Drawing.Point(26, 472);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 13);
            this.textBox2.TabIndex = 125;
            this.textBox2.Text = "Not: Değer girilmediği takdirde 1 alınır.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 519);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adayPersonelBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulanik_AhpDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adayPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adayPersonelDataSet)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulanik_AhpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adayPersonelBindingSource1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox35;
        private System.Windows.Forms.ComboBox comboBox34;
        private System.Windows.Forms.ComboBox comboBox33;
        private System.Windows.Forms.ComboBox comboBox32;
        private System.Windows.Forms.ComboBox comboBox31;
        private System.Windows.Forms.ComboBox comboBox27;
        private System.Windows.Forms.ComboBox comboBox23;
        private System.Windows.Forms.ComboBox comboBox22;
        private System.Windows.Forms.ComboBox comboBox18;
        private System.Windows.Forms.ComboBox comboBox17;
        private System.Windows.Forms.ComboBox comboBox16;
        private System.Windows.Forms.ComboBox comboBox15;
        private System.Windows.Forms.ComboBox comboBox14;
        private System.Windows.Forms.ComboBox comboBox13;
        private System.Windows.Forms.ComboBox comboBox12;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox11;
        private System.Windows.Forms.ComboBox comboBox19;
        private System.Windows.Forms.ComboBox comboBox20;
        private System.Windows.Forms.ComboBox comboBox21;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox comboBox24;
        private System.Windows.Forms.ComboBox comboBox25;
        private System.Windows.Forms.ComboBox comboBox26;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox44;
        private System.Windows.Forms.TextBox textBox43;
        private System.Windows.Forms.TextBox textBox41;
        private System.Windows.Forms.BindingSource masterDataSetBindingSource;
        private masterDataSet masterDataSet;
        private adayPersonelDataSet adayPersonelDataSet;
        private System.Windows.Forms.BindingSource adayPersonelBindingSource;
        private adayPersonelDataSetTableAdapters.adayPersonelTableAdapter adayPersonelTableAdapter;
        private Bulanik_AhpDataSet bulanik_AhpDataSet;
        private System.Windows.Forms.BindingSource adayPersonelBindingSource1;
        private Bulanik_AhpDataSetTableAdapters.adayPersonelTableAdapter adayPersonelTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Bulanik_AhpDataSet1 bulanik_AhpDataSet1;
        private System.Windows.Forms.BindingSource adayPersonelBindingSource2;
        private Bulanik_AhpDataSet1TableAdapters.adayPersonelTableAdapter adayPersonelTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sonucDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefon;
        private System.Windows.Forms.TextBox textBox53;
        private System.Windows.Forms.TextBox textBox52;
        private System.Windows.Forms.TextBox textBox51;
        private System.Windows.Forms.TextBox textBox50;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox37;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ComboBox comboBox57;
        private System.Windows.Forms.ComboBox comboBox58;
        private System.Windows.Forms.ComboBox comboBox59;
        private System.Windows.Forms.ComboBox comboBox60;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.ComboBox comboBox61;
        private System.Windows.Forms.ComboBox comboBox62;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

