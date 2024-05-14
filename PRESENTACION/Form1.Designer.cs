namespace PRESENTACION
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Txt_Existencias = new TextBox();
            Txt_Referencia = new TextBox();
            label10 = new Label();
            comboBox3 = new ComboBox();
            textBox7 = new TextBox();
            Btn_Limpiar = new Button();
            Cmb_Estado = new ComboBox();
            Btn_Guardar = new Button();
            Txt_Stock = new TextBox();
            Txt_PrecioUnitario = new TextBox();
            Txt_Nombre = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            tabPage2 = new TabPage();
            label14 = new Label();
            textBox6 = new TextBox();
            dataGridView2 = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            cantidadTxt = new TextBox();
            button5 = new Button();
            fechaFacturaDate = new DateTimePicker();
            label1 = new Label();
            idFacturaTxt = new TextBox();
            label2 = new Label();
            comboBox4 = new ComboBox();
            textBox8 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            detallesDtG = new DataGridView();
            Seleccion = new DataGridViewCheckBoxColumn();
            Referencia = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Btn_Buscar = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)detallesDtG).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1370, 749);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Silver;
            tabPage1.Controls.Add(Txt_Existencias);
            tabPage1.Controls.Add(Txt_Referencia);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(comboBox3);
            tabPage1.Controls.Add(textBox7);
            tabPage1.Controls.Add(Btn_Limpiar);
            tabPage1.Controls.Add(Cmb_Estado);
            tabPage1.Controls.Add(Btn_Guardar);
            tabPage1.Controls.Add(Txt_Stock);
            tabPage1.Controls.Add(Txt_PrecioUnitario);
            tabPage1.Controls.Add(Txt_Nombre);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1362, 716);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Productos";
            // 
            // Txt_Existencias
            // 
            Txt_Existencias.BorderStyle = BorderStyle.None;
            Txt_Existencias.Location = new Point(853, 307);
            Txt_Existencias.Multiline = true;
            Txt_Existencias.Name = "Txt_Existencias";
            Txt_Existencias.Size = new Size(331, 35);
            Txt_Existencias.TabIndex = 25;
            // 
            // Txt_Referencia
            // 
            Txt_Referencia.BorderStyle = BorderStyle.None;
            Txt_Referencia.Location = new Point(853, 159);
            Txt_Referencia.Multiline = true;
            Txt_Referencia.Name = "Txt_Referencia";
            Txt_Referencia.Size = new Size(331, 35);
            Txt_Referencia.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(25, 20);
            label10.Name = "label10";
            label10.Size = new Size(160, 41);
            label10.TabIndex = 22;
            label10.Text = "Productos";
            // 
            // comboBox3
            // 
            comboBox3.ForeColor = SystemColors.InactiveCaption;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(587, 83);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(237, 28);
            comboBox3.TabIndex = 21;
            comboBox3.Text = "Filtrar";
            // 
            // textBox7
            // 
            textBox7.ForeColor = SystemColors.InactiveCaption;
            textBox7.Location = new Point(25, 80);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(533, 31);
            textBox7.TabIndex = 20;
            textBox7.Text = "Buscar";
            // 
            // Btn_Limpiar
            // 
            Btn_Limpiar.FlatStyle = FlatStyle.System;
            Btn_Limpiar.Location = new Point(1035, 600);
            Btn_Limpiar.Name = "Btn_Limpiar";
            Btn_Limpiar.Size = new Size(149, 37);
            Btn_Limpiar.TabIndex = 19;
            Btn_Limpiar.Text = "Limpiar";
            Btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // Cmb_Estado
            // 
            Cmb_Estado.BackColor = Color.White;
            Cmb_Estado.FlatStyle = FlatStyle.Popup;
            Cmb_Estado.FormattingEnabled = true;
            Cmb_Estado.Location = new Point(853, 547);
            Cmb_Estado.Name = "Cmb_Estado";
            Cmb_Estado.Size = new Size(331, 28);
            Cmb_Estado.TabIndex = 18;
            // 
            // Btn_Guardar
            // 
            Btn_Guardar.BackgroundImageLayout = ImageLayout.None;
            Btn_Guardar.FlatAppearance.BorderColor = Color.Red;
            Btn_Guardar.FlatAppearance.BorderSize = 2;
            Btn_Guardar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Btn_Guardar.FlatStyle = FlatStyle.System;
            Btn_Guardar.Location = new Point(853, 600);
            Btn_Guardar.Name = "Btn_Guardar";
            Btn_Guardar.Size = new Size(152, 37);
            Btn_Guardar.TabIndex = 17;
            Btn_Guardar.Text = "Guardar";
            Btn_Guardar.UseVisualStyleBackColor = true;
            Btn_Guardar.Click += Btn_Guardar_Click;
            // 
            // Txt_Stock
            // 
            Txt_Stock.BorderStyle = BorderStyle.None;
            Txt_Stock.Location = new Point(853, 459);
            Txt_Stock.Multiline = true;
            Txt_Stock.Name = "Txt_Stock";
            Txt_Stock.Size = new Size(331, 35);
            Txt_Stock.TabIndex = 15;
            // 
            // Txt_PrecioUnitario
            // 
            Txt_PrecioUnitario.BorderStyle = BorderStyle.None;
            Txt_PrecioUnitario.Location = new Point(853, 379);
            Txt_PrecioUnitario.Multiline = true;
            Txt_PrecioUnitario.Name = "Txt_PrecioUnitario";
            Txt_PrecioUnitario.Size = new Size(331, 35);
            Txt_PrecioUnitario.TabIndex = 14;
            // 
            // Txt_Nombre
            // 
            Txt_Nombre.BorderStyle = BorderStyle.None;
            Txt_Nombre.Location = new Point(853, 231);
            Txt_Nombre.Multiline = true;
            Txt_Nombre.Name = "Txt_Nombre";
            Txt_Nombre.Size = new Size(331, 35);
            Txt_Nombre.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(853, 505);
            label9.Name = "label9";
            label9.Size = new Size(88, 27);
            label9.TabIndex = 11;
            label9.Text = "Estado";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(853, 271);
            label8.Name = "label8";
            label8.Size = new Size(133, 27);
            label8.TabIndex = 10;
            label8.Text = "Existencias";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(853, 344);
            label7.Name = "label7";
            label7.Size = new Size(178, 27);
            label7.TabIndex = 9;
            label7.Text = "Precio Unitario";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(853, 423);
            label6.Name = "label6";
            label6.Size = new Size(73, 27);
            label6.TabIndex = 8;
            label6.Text = "Stock";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(853, 197);
            label5.Name = "label5";
            label5.Size = new Size(104, 27);
            label5.TabIndex = 7;
            label5.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(853, 127);
            label4.Name = "label4";
            label4.Size = new Size(136, 27);
            label4.TabIndex = 5;
            label4.Text = "Referencia";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(25, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.White;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(809, 523);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Referencia";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Precio Unitario";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Stock Minimo";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Estado";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Silver;
            tabPage2.Controls.Add(Btn_Buscar);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(textBox6);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1362, 716);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Factura";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(39, 35);
            label14.Name = "label14";
            label14.Size = new Size(121, 41);
            label14.TabIndex = 37;
            label14.Text = "Factura";
            // 
            // textBox6
            // 
            textBox6.ForeColor = SystemColors.InactiveCaption;
            textBox6.Location = new Point(39, 90);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(430, 31);
            textBox6.TabIndex = 35;
            textBox6.Text = "Buscar";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView2.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.White;
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.White;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.Location = new Point(39, 143);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.White;
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(1026, 523);
            dataGridView2.TabIndex = 34;
            // 
            // Column7
            // 
            Column7.HeaderText = "Id Factura";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Fecha Factura";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "Valor Total Facturado";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "Ref Producto";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // Column11
            // 
            Column11.HeaderText = "Nombre";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 125;
            // 
            // Column12
            // 
            Column12.HeaderText = "Cantidad";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Width = 125;
            // 
            // Column13
            // 
            Column13.HeaderText = "Precio Unitario";
            Column13.MinimumWidth = 6;
            Column13.Name = "Column13";
            Column13.Width = 125;
            // 
            // Column14
            // 
            Column14.HeaderText = "Valor Vendido";
            Column14.MinimumWidth = 6;
            Column14.Name = "Column14";
            Column14.Width = 125;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Silver;
            tabPage3.Controls.Add(cantidadTxt);
            tabPage3.Controls.Add(button5);
            tabPage3.Controls.Add(fechaFacturaDate);
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(idFacturaTxt);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(comboBox4);
            tabPage3.Controls.Add(textBox8);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(detallesDtG);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1362, 716);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "LIsta Productos";
            // 
            // cantidadTxt
            // 
            cantidadTxt.ForeColor = SystemColors.InactiveCaption;
            cantidadTxt.Location = new Point(1000, 91);
            cantidadTxt.Multiline = true;
            cantidadTxt.Name = "cantidadTxt";
            cantidadTxt.Size = new Size(145, 31);
            cantidadTxt.TabIndex = 44;
            cantidadTxt.Text = "Cantidad";
            // 
            // button5
            // 
            button5.Location = new Point(427, 621);
            button5.Name = "button5";
            button5.Size = new Size(152, 37);
            button5.TabIndex = 43;
            button5.Text = "Agregar Produco";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // fechaFacturaDate
            // 
            fechaFacturaDate.Location = new Point(400, 45);
            fechaFacturaDate.Name = "fechaFacturaDate";
            fechaFacturaDate.Size = new Size(332, 27);
            fechaFacturaDate.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(400, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 27);
            label1.TabIndex = 41;
            label1.Text = "Fecha";
            // 
            // idFacturaTxt
            // 
            idFacturaTxt.BorderStyle = BorderStyle.None;
            idFacturaTxt.Location = new Point(46, 41);
            idFacturaTxt.Multiline = true;
            idFacturaTxt.Name = "idFacturaTxt";
            idFacturaTxt.Size = new Size(331, 35);
            idFacturaTxt.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 9);
            label2.Name = "label2";
            label2.Size = new Size(127, 27);
            label2.TabIndex = 39;
            label2.Text = "Id Factura";
            // 
            // comboBox4
            // 
            comboBox4.ForeColor = SystemColors.InactiveCaption;
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(609, 91);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(367, 28);
            comboBox4.TabIndex = 38;
            comboBox4.Text = "Filtrar";
            // 
            // textBox8
            // 
            textBox8.ForeColor = SystemColors.InactiveCaption;
            textBox8.Location = new Point(46, 88);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(533, 31);
            textBox8.TabIndex = 37;
            textBox8.Text = "Buscar";
            // 
            // button3
            // 
            button3.Location = new Point(838, 621);
            button3.Name = "button3";
            button3.Size = new Size(149, 37);
            button3.TabIndex = 36;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(993, 621);
            button4.Name = "button4";
            button4.Size = new Size(152, 37);
            button4.TabIndex = 34;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // detallesDtG
            // 
            detallesDtG.BackgroundColor = Color.White;
            detallesDtG.BorderStyle = BorderStyle.None;
            detallesDtG.CellBorderStyle = DataGridViewCellBorderStyle.None;
            detallesDtG.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            detallesDtG.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            detallesDtG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detallesDtG.Columns.AddRange(new DataGridViewColumn[] { Seleccion, Referencia, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            detallesDtG.EnableHeadersVisualStyles = false;
            detallesDtG.Location = new Point(46, 135);
            detallesDtG.Name = "detallesDtG";
            detallesDtG.RowHeadersWidth = 51;
            detallesDtG.Size = new Size(1099, 481);
            detallesDtG.TabIndex = 22;
            // 
            // Seleccion
            // 
            Seleccion.HeaderText = "Seleccion";
            Seleccion.MinimumWidth = 6;
            Seleccion.Name = "Seleccion";
            Seleccion.Width = 125;
            // 
            // Referencia
            // 
            Referencia.HeaderText = "Referencia";
            Referencia.MinimumWidth = 6;
            Referencia.Name = "Referencia";
            Referencia.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Cantidad";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Precio Unitario";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 125;
            // 
            // Btn_Buscar
            // 
            Btn_Buscar.Location = new Point(476, 91);
            Btn_Buscar.Name = "Btn_Buscar";
            Btn_Buscar.Size = new Size(94, 30);
            Btn_Buscar.TabIndex = 38;
            Btn_Buscar.Text = "Buscar";
            Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de Facturas";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)detallesDtG).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private TextBox Txt_Stock;
        private TextBox Txt_PrecioUnitario;
        private TextBox Txt_Nombre;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox comboBox3;
        private TextBox textBox7;
        private Button Btn_Limpiar;
        private ComboBox Cmb_Estado;
        private Button Btn_Guardar;
        private ComboBox comboBox4;
        private TextBox textBox8;
        private Button button3;
        private Button button4;
        private DataGridView detallesDtG;
        private Label label10;
        private Button button5;
        private DateTimePicker fechaFacturaDate;
        private Label label1;
        private TextBox idFacturaTxt;
        private Label label2;
        private TextBox cantidadTxt;
        private DataGridViewCheckBoxColumn Seleccion;
        private DataGridViewTextBoxColumn Referencia;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private TextBox Txt_Existencias;
        private TextBox Txt_Referencia;
        private TabPage tabPage2;
        private Label label14;
        private TextBox textBox6;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private Button Btn_Buscar;
    }
}
