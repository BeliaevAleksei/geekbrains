namespace Task2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.workLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resValue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resValue);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.inputBox);
            this.groupBox1.Controls.Add(this.workLabel);
            this.groupBox1.Controls.Add(this.startLabel);
            this.groupBox1.Location = new System.Drawing.Point(139, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // workLabel
            // 
            this.workLabel.AutoSize = true;
            this.workLabel.Location = new System.Drawing.Point(17, 36);
            this.workLabel.Name = "workLabel";
            this.workLabel.Size = new System.Drawing.Size(35, 13);
            this.workLabel.TabIndex = 4;
            this.workLabel.Text = "label1";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(18, 125);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(80, 13);
            this.startLabel.TabIndex = 1;
            this.startLabel.Text = "Your number is:";
            this.startLabel.Visible = false;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(104, 64);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(100, 20);
            this.inputBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Try!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter a number";
            // 
            // resValue
            // 
            this.resValue.AutoSize = true;
            this.resValue.Location = new System.Drawing.Point(101, 125);
            this.resValue.Name = "resValue";
            this.resValue.Size = new System.Drawing.Size(35, 13);
            this.resValue.TabIndex = 8;
            this.resValue.Text = "label2";
            this.resValue.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label workLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label resValue;
    }
}

