namespace Lab_3
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
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtFi = new System.Windows.Forms.TextBox();
            this.btnAlgebraicForm = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnTrigonometricForm = new System.Windows.Forms.Button();
            this.txtResult2 = new System.Windows.Forms.RichTextBox();
            this.txtResult3 = new System.Windows.Forms.RichTextBox();
            this.btnExponentialForm = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnFindExp = new System.Windows.Forms.Button();
            this.txtResult4 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(51, 84);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(44, 20);
            this.txtR.TabIndex = 3;
            // 
            // txtFi
            // 
            this.txtFi.Location = new System.Drawing.Point(140, 84);
            this.txtFi.Name = "txtFi";
            this.txtFi.Size = new System.Drawing.Size(44, 20);
            this.txtFi.TabIndex = 4;
            // 
            // btnAlgebraicForm
            // 
            this.btnAlgebraicForm.Location = new System.Drawing.Point(189, 45);
            this.btnAlgebraicForm.Name = "btnAlgebraicForm";
            this.btnAlgebraicForm.Size = new System.Drawing.Size(175, 31);
            this.btnAlgebraicForm.TabIndex = 7;
            this.btnAlgebraicForm.Text = "В алгебраической форме";
            this.btnAlgebraicForm.UseVisualStyleBackColor = true;
            this.btnAlgebraicForm.Click += new System.EventHandler(this.btnAlgebraicForm_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(189, 82);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(176, 90);
            this.txtResult.TabIndex = 8;
            this.txtResult.Text = "";
            // 
            // btnTrigonometricForm
            // 
            this.btnTrigonometricForm.Location = new System.Drawing.Point(370, 45);
            this.btnTrigonometricForm.Name = "btnTrigonometricForm";
            this.btnTrigonometricForm.Size = new System.Drawing.Size(176, 31);
            this.btnTrigonometricForm.TabIndex = 9;
            this.btnTrigonometricForm.Text = "В тригонометрической форме";
            this.btnTrigonometricForm.UseVisualStyleBackColor = true;
            this.btnTrigonometricForm.Click += new System.EventHandler(this.btnTrigonometricForm_Click);
            // 
            // txtResult2
            // 
            this.txtResult2.Location = new System.Drawing.Point(370, 84);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.Size = new System.Drawing.Size(176, 88);
            this.txtResult2.TabIndex = 10;
            this.txtResult2.Text = "";
            // 
            // txtResult3
            // 
            this.txtResult3.Location = new System.Drawing.Point(552, 82);
            this.txtResult3.Name = "txtResult3";
            this.txtResult3.Size = new System.Drawing.Size(176, 88);
            this.txtResult3.TabIndex = 12;
            this.txtResult3.Text = "";
            // 
            // btnExponentialForm
            // 
            this.btnExponentialForm.Location = new System.Drawing.Point(552, 45);
            this.btnExponentialForm.Name = "btnExponentialForm";
            this.btnExponentialForm.Size = new System.Drawing.Size(176, 31);
            this.btnExponentialForm.TabIndex = 11;
            this.btnExponentialForm.Text = "В экспоненциальной форме";
            this.btnExponentialForm.UseVisualStyleBackColor = true;
            this.btnExponentialForm.Click += new System.EventHandler(this.btnExponentialForm_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(17, 111);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(78, 33);
            this.btnRandom.TabIndex = 13;
            this.btnRandom.Text = "Случайно";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(106, 111);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(78, 33);
            this.btnEnter.TabIndex = 14;
            this.btnEnter.Text = "Ввести";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnFindExp
            // 
            this.btnFindExp.Location = new System.Drawing.Point(105, 243);
            this.btnFindExp.Name = "btnFindExp";
            this.btnFindExp.Size = new System.Drawing.Size(167, 32);
            this.btnFindExp.TabIndex = 16;
            this.btnFindExp.Text = "Найти выражение";
            this.btnFindExp.UseVisualStyleBackColor = true;
            this.btnFindExp.Click += new System.EventHandler(this.btnFindExp_Click);
            // 
            // txtResult4
            // 
            this.txtResult4.Location = new System.Drawing.Point(278, 179);
            this.txtResult4.Name = "txtResult4";
            this.txtResult4.Size = new System.Drawing.Size(357, 96);
            this.txtResult4.TabIndex = 17;
            this.txtResult4.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Введите 4 комплексных числа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label2.Location = new System.Drawing.Point(13, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "p";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(115, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "φ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(102, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "W = a2/a1 + a3 * a4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "a = p * e ^ (φ*i)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(743, 285);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult4);
            this.Controls.Add(this.btnFindExp);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtResult3);
            this.Controls.Add(this.btnExponentialForm);
            this.Controls.Add(this.txtResult2);
            this.Controls.Add(this.btnTrigonometricForm);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnAlgebraicForm);
            this.Controls.Add(this.txtFi);
            this.Controls.Add(this.txtR);
            this.Name = "Form1";
            this.Text = "Lab 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.TextBox txtFi;
        private System.Windows.Forms.Button btnAlgebraicForm;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnTrigonometricForm;
        private System.Windows.Forms.RichTextBox txtResult2;
        private System.Windows.Forms.RichTextBox txtResult3;
        private System.Windows.Forms.Button btnExponentialForm;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnFindExp;
        private System.Windows.Forms.RichTextBox txtResult4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

