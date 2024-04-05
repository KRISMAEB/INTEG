namespace SomasFamilyRestaurant
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.con1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(203, 88);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(353, 21);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Welcome to Soma\'s Family Restaurant";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(295, 150);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(192, 21);
            this.tb1.TabIndex = 1;
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(167, 148);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(122, 21);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Enter a Day:";
            this.lbl2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // con1
            // 
            this.con1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.con1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con1.Location = new System.Drawing.Point(336, 189);
            this.con1.Name = "con1";
            this.con1.Size = new System.Drawing.Size(117, 31);
            this.con1.TabIndex = 3;
            this.con1.Text = "CONTINUE";
            this.con1.UseVisualStyleBackColor = true;
            this.con1.Click += new System.EventHandler(this.btn1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.con1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button con1;
    }
}

