namespace Kursach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            width = new Label();
            height = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            color = new Label();
            label7 = new Label();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label2 = new Label();
            label3 = new Label();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(153, 49);
            button1.Name = "button1";
            button1.Size = new Size(127, 43);
            button1.TabIndex = 1;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button2.Location = new Point(153, 111);
            button2.Name = "button2";
            button2.Size = new Size(127, 54);
            button2.TabIndex = 2;
            button2.Text = "Удалить корень";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(49, 26);
            label1.Name = "label1";
            label1.Size = new Size(0, 16);
            label1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Location = new Point(345, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(443, 283);
            dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "№";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Длина";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ширина";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Цвет";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // width
            // 
            width.AutoSize = true;
            width.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Italic, GraphicsUnit.Point);
            width.Location = new Point(40, 26);
            width.Name = "width";
            width.Size = new Size(42, 16);
            width.TabIndex = 7;
            width.Text = "Длина";
            // 
            // height
            // 
            height.AutoSize = true;
            height.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Italic, GraphicsUnit.Point);
            height.Location = new Point(35, 76);
            height.Name = "height";
            height.Size = new Size(49, 16);
            height.TabIndex = 10;
            height.Text = "Ширина";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(49, 76);
            label5.Name = "label5";
            label5.Size = new Size(0, 16);
            label5.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(12, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // color
            // 
            color.AutoSize = true;
            color.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Italic, GraphicsUnit.Point);
            color.Location = new Point(40, 123);
            color.Name = "color";
            color.Size = new Size(35, 16);
            color.TabIndex = 13;
            color.Text = "Цвет";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(49, 123);
            label7.Name = "label7";
            label7.Size = new Size(0, 16);
            label7.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Черный", "Белый", "Красный", "Синий", "Розовый", "Фиолетовый" });
            comboBox1.Location = new Point(12, 141);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 24);
            comboBox1.TabIndex = 14;
            // 
            // button3
            // 
            button3.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(12, 292);
            button3.Name = "button3";
            button3.Size = new Size(143, 43);
            button3.TabIndex = 15;
            button3.Text = "Перестроить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Italic, GraphicsUnit.Point);
            button4.Location = new Point(519, 383);
            button4.Name = "button4";
            button4.Size = new Size(115, 43);
            button4.TabIndex = 16;
            button4.Text = "Загрузить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(666, 383);
            button5.Name = "button5";
            button5.Size = new Size(122, 43);
            button5.TabIndex = 17;
            button5.Text = "Сохранить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button6.Location = new Point(12, 356);
            button6.Name = "button6";
            button6.Size = new Size(143, 70);
            button6.TabIndex = 18;
            button6.Text = "Изменить корень кучи";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(357, 26);
            label2.Name = "label2";
            label2.Size = new Size(189, 19);
            label2.TabIndex = 19;
            label2.Text = "Размеры наибольшего ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(552, 26);
            label3.Name = "label3";
            label3.Size = new Size(0, 19);
            label3.TabIndex = 20;
            // 
            // button7
            // 
            button7.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button7.Location = new Point(191, 356);
            button7.Name = "button7";
            button7.Size = new Size(127, 70);
            button7.TabIndex = 21;
            button7.Text = "Очистить кучу";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("JetBrains Mono", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button8.Location = new Point(182, 292);
            button8.Name = "button8";
            button8.Size = new Size(148, 50);
            button8.TabIndex = 22;
            button8.Text = "Слияние с кучей из файла";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(color);
            Controls.Add(label7);
            Controls.Add(height);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(width);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Binary Heap";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private DataGridView dataGridView1;
        private Label width;
        private Label height;
        private Label label5;
        private TextBox textBox2;
        private Label color;
        private Label label7;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label2;
        private Label label3;
        private Button button7;
        private Button button8;
    }
}