namespace LAB_GUI2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculate = new System.Windows.Forms.Button();
            this.Label_radius = new System.Windows.Forms.Label();
            this.label_height = new System.Windows.Forms.Label();
            this.text_radius = new System.Windows.Forms.TextBox();
            this.text_Height = new System.Windows.Forms.TextBox();
            this.labelRound = new System.Windows.Forms.Label();
            this.labelCylinder = new System.Windows.Forms.Label();
            this.richTextBoxRound = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCylinder = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RichTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.Result = new System.Windows.Forms.Label();
            this.StartCalculating = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(69, 95);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(101, 34);
            this.calculate.TabIndex = 0;
            this.calculate.Text = "Start";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // Label_radius
            // 
            this.Label_radius.AutoSize = true;
            this.Label_radius.Location = new System.Drawing.Point(13, 28);
            this.Label_radius.Name = "Label_radius";
            this.Label_radius.Size = new System.Drawing.Size(52, 17);
            this.Label_radius.TabIndex = 1;
            this.Label_radius.Text = "Radius";
            // 
            // label_height
            // 
            this.label_height.AutoSize = true;
            this.label_height.Location = new System.Drawing.Point(12, 56);
            this.label_height.Name = "label_height";
            this.label_height.Size = new System.Drawing.Size(49, 17);
            this.label_height.TabIndex = 2;
            this.label_height.Text = "Height";
            // 
            // text_radius
            // 
            this.text_radius.Location = new System.Drawing.Point(70, 28);
            this.text_radius.Name = "text_radius";
            this.text_radius.Size = new System.Drawing.Size(100, 22);
            this.text_radius.TabIndex = 3;
            // 
            // text_Height
            // 
            this.text_Height.Location = new System.Drawing.Point(70, 57);
            this.text_Height.Name = "text_Height";
            this.text_Height.Size = new System.Drawing.Size(100, 22);
            this.text_Height.TabIndex = 4;
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.Location = new System.Drawing.Point(83, 142);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(50, 17);
            this.labelRound.TabIndex = 5;
            this.labelRound.Text = "Round";
            // 
            // labelCylinder
            // 
            this.labelCylinder.AutoSize = true;
            this.labelCylinder.Location = new System.Drawing.Point(83, 316);
            this.labelCylinder.Name = "labelCylinder";
            this.labelCylinder.Size = new System.Drawing.Size(59, 17);
            this.labelCylinder.TabIndex = 6;
            this.labelCylinder.Text = "Cylinder";
            // 
            // richTextBoxRound
            // 
            this.richTextBoxRound.Location = new System.Drawing.Point(12, 172);
            this.richTextBoxRound.Name = "richTextBoxRound";
            this.richTextBoxRound.Size = new System.Drawing.Size(211, 130);
            this.richTextBoxRound.TabIndex = 7;
            this.richTextBoxRound.Text = "";
            // 
            // richTextBoxCylinder
            // 
            this.richTextBoxCylinder.Location = new System.Drawing.Point(12, 350);
            this.richTextBoxCylinder.Name = "richTextBoxCylinder";
            this.richTextBoxCylinder.Size = new System.Drawing.Size(211, 130);
            this.richTextBoxCylinder.TabIndex = 8;
            this.richTextBoxCylinder.Text = "";
            // 
            // RichTextBoxResult
            // 
            this.RichTextBoxResult.Location = new System.Drawing.Point(965, 127);
            this.RichTextBoxResult.Name = "RichTextBoxResult";
            this.RichTextBoxResult.Size = new System.Drawing.Size(282, 130);
            this.RichTextBoxResult.TabIndex = 10;
            this.RichTextBoxResult.Text = "";
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(1077, 95);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(48, 17);
            this.Result.TabIndex = 14;
            this.Result.Text = "Result";
            // 
            // StartCalculating
            // 
            this.StartCalculating.Location = new System.Drawing.Point(1025, 30);
            this.StartCalculating.Name = "StartCalculating";
            this.StartCalculating.Size = new System.Drawing.Size(153, 43);
            this.StartCalculating.TabIndex = 15;
            this.StartCalculating.Text = "Start Calculating";
            this.StartCalculating.UseVisualStyleBackColor = true;
            this.StartCalculating.Click += new System.EventHandler(this.StartCalculating_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(243, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(716, 452);
            this.dataGridView1.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Radius";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Heigth";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Area of ​​a circle";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Length of a circle";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Volume of a cylinder";
            this.Column5.Name = "Column5";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bin";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*bin.)|*bin.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 539);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StartCalculating);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.RichTextBoxResult);
            this.Controls.Add(this.richTextBoxCylinder);
            this.Controls.Add(this.richTextBoxRound);
            this.Controls.Add(this.labelCylinder);
            this.Controls.Add(this.labelRound);
            this.Controls.Add(this.text_Height);
            this.Controls.Add(this.text_radius);
            this.Controls.Add(this.label_height);
            this.Controls.Add(this.Label_radius);
            this.Controls.Add(this.calculate);
            this.Name = "Form1";
            this.Text = "Lab_2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label Label_radius;
        private System.Windows.Forms.Label label_height;
        private System.Windows.Forms.TextBox text_radius;
        private System.Windows.Forms.TextBox text_Height;
        private System.Windows.Forms.Label labelRound;
        private System.Windows.Forms.Label labelCylinder;
        private System.Windows.Forms.RichTextBox richTextBoxRound;
        private System.Windows.Forms.RichTextBox richTextBoxCylinder;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox RichTextBoxResult;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button StartCalculating;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

