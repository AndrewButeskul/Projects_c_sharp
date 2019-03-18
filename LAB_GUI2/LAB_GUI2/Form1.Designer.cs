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
            this.Label_radius.Click += new System.EventHandler(this.label1_Click);
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
            this.labelRound.Location = new System.Drawing.Point(83, 160);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(50, 17);
            this.labelRound.TabIndex = 5;
            this.labelRound.Text = "Round";
            // 
            // labelCylinder
            // 
            this.labelCylinder.AutoSize = true;
            this.labelCylinder.Location = new System.Drawing.Point(328, 160);
            this.labelCylinder.Name = "labelCylinder";
            this.labelCylinder.Size = new System.Drawing.Size(59, 17);
            this.labelCylinder.TabIndex = 6;
            this.labelCylinder.Text = "Cylinder";
            // 
            // richTextBoxRound
            // 
            this.richTextBoxRound.Location = new System.Drawing.Point(12, 193);
            this.richTextBoxRound.Name = "richTextBoxRound";
            this.richTextBoxRound.Size = new System.Drawing.Size(198, 130);
            this.richTextBoxRound.TabIndex = 7;
            this.richTextBoxRound.Text = "";
            this.richTextBoxRound.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBoxCylinder
            // 
            this.richTextBoxCylinder.Location = new System.Drawing.Point(247, 193);
            this.richTextBoxCylinder.Name = "richTextBoxCylinder";
            this.richTextBoxCylinder.Size = new System.Drawing.Size(219, 130);
            this.richTextBoxCylinder.TabIndex = 8;
            this.richTextBoxCylinder.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 433);
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
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

