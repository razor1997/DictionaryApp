namespace DictionaryApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.markLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.modelName = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // markLabel
            // 
            this.markLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.markLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.markLabel.Location = new System.Drawing.Point(246, 14);
            this.markLabel.Name = "markLabel";
            this.markLabel.Size = new System.Drawing.Size(100, 23);
            this.markLabel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Należy do samochodu marki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "model";
            // 
            // modelName
            // 
            this.modelName.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.modelName.Location = new System.Drawing.Point(410, 16);
            this.modelName.Name = "modelName";
            this.modelName.Size = new System.Drawing.Size(100, 23);
            this.modelName.TabIndex = 5;
            // 
            // number
            // 
            this.number.FormattingEnabled = true;
            this.number.Location = new System.Drawing.Point(57, 16);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(37, 21);
            this.number.TabIndex = 6;
            this.number.SelectedIndexChanged += new System.EventHandler(this.number_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 46);
            this.Controls.Add(this.number);
            this.Controls.Add(this.modelName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.markLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Najszybsze auta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label markLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label modelName;
        private System.Windows.Forms.ComboBox number;
    }
}

