
namespace NumbersConvert
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
            this.ButtonForConvert = new System.Windows.Forms.Button();
            this.LabelForResult = new System.Windows.Forms.Label();
            this.NumFoConv = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonForConvert
            // 
            this.ButtonForConvert.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonForConvert.Location = new System.Drawing.Point(12, 189);
            this.ButtonForConvert.Name = "ButtonForConvert";
            this.ButtonForConvert.Size = new System.Drawing.Size(180, 52);
            this.ButtonForConvert.TabIndex = 0;
            this.ButtonForConvert.Text = "Нажмите для конвертации";
            this.ButtonForConvert.UseVisualStyleBackColor = true;
            this.ButtonForConvert.Click += new System.EventHandler(this.ButtonForConvert_Click);
            // 
            // LabelForResult
            // 
            this.LabelForResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelForResult.AutoSize = true;
            this.LabelForResult.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelForResult.Location = new System.Drawing.Point(12, 290);
            this.LabelForResult.Name = "LabelForResult";
            this.LabelForResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LabelForResult.Size = new System.Drawing.Size(90, 21);
            this.LabelForResult.TabIndex = 1;
            this.LabelForResult.Text = "Результат";
            this.LabelForResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumFoConv
            // 
            this.NumFoConv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumFoConv.Location = new System.Drawing.Point(12, 122);
            this.NumFoConv.Name = "NumFoConv";
            this.NumFoConv.Size = new System.Drawing.Size(428, 26);
            this.NumFoConv.TabIndex = 2;
            this.NumFoConv.Text = "Введите число (Не более 999 999 и не менее -999 999)";
            this.NumFoConv.Click += new System.EventHandler(this.NumFoConv_Click);
            this.NumFoConv.TextChanged += new System.EventHandler(this.NumFoConv_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumFoConv);
            this.Controls.Add(this.LabelForResult);
            this.Controls.Add(this.ButtonForConvert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonForConvert;
        private System.Windows.Forms.Label LabelForResult;
        private System.Windows.Forms.TextBox NumFoConv;
    }
}

