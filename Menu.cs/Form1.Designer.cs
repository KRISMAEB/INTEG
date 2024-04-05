namespace Menu.cs
{
    partial class menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.lunes = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.discountedprice = new System.Windows.Forms.TextBox();
            this.order = new System.Windows.Forms.Label();
            this.martes = new System.Windows.Forms.Label();
            this.miyerkules = new System.Windows.Forms.Label();
            this.huwebes = new System.Windows.Forms.Label();
            this.biyernes = new System.Windows.Forms.Label();
            this.sabado = new System.Windows.Forms.Label();
            this.linggo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.days = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.name);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 37);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(453, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 229);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(474, 235);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(69, 21);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "PRICE:";
            this.lbl1.Click += new System.EventHandler(this.label2_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(549, 235);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(46, 20);
            this.price.TabIndex = 5;
            this.price.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lunes
            // 
            this.lunes.AutoSize = true;
            this.lunes.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lunes.Location = new System.Drawing.Point(21, 84);
            this.lunes.Name = "lunes";
            this.lunes.Size = new System.Drawing.Size(66, 21);
            this.lunes.TabIndex = 6;
            this.lunes.Text = "LUNES";
            this.lunes.Click += new System.EventHandler(this.lunes_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(461, 271);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(108, 21);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "QUANTITY:";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(575, 273);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(42, 20);
            this.quantity.TabIndex = 8;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(461, 305);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(193, 21);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "DISCOUNTED PRICE:";
            // 
            // discountedprice
            // 
            this.discountedprice.Location = new System.Drawing.Point(660, 305);
            this.discountedprice.Name = "discountedprice";
            this.discountedprice.Size = new System.Drawing.Size(42, 20);
            this.discountedprice.TabIndex = 10;
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order.Location = new System.Drawing.Point(259, 72);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(74, 21);
            this.order.TabIndex = 11;
            this.order.Text = "ORDER";
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // martes
            // 
            this.martes.AutoSize = true;
            this.martes.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.martes.Location = new System.Drawing.Point(21, 116);
            this.martes.Name = "martes";
            this.martes.Size = new System.Drawing.Size(80, 21);
            this.martes.TabIndex = 12;
            this.martes.Text = "MARTES";
            this.martes.Click += new System.EventHandler(this.martes_Click);
            // 
            // miyerkules
            // 
            this.miyerkules.AutoSize = true;
            this.miyerkules.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miyerkules.Location = new System.Drawing.Point(21, 148);
            this.miyerkules.Name = "miyerkules";
            this.miyerkules.Size = new System.Drawing.Size(121, 21);
            this.miyerkules.TabIndex = 13;
            this.miyerkules.Text = "MIYERKULES";
            this.miyerkules.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // huwebes
            // 
            this.huwebes.AutoSize = true;
            this.huwebes.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huwebes.Location = new System.Drawing.Point(22, 183);
            this.huwebes.Name = "huwebes";
            this.huwebes.Size = new System.Drawing.Size(94, 21);
            this.huwebes.TabIndex = 14;
            this.huwebes.Text = "HUWEBES";
            // 
            // biyernes
            // 
            this.biyernes.AutoSize = true;
            this.biyernes.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biyernes.Location = new System.Drawing.Point(21, 216);
            this.biyernes.Name = "biyernes";
            this.biyernes.Size = new System.Drawing.Size(95, 21);
            this.biyernes.TabIndex = 15;
            this.biyernes.Text = "BIYERNES";
            // 
            // sabado
            // 
            this.sabado.AutoSize = true;
            this.sabado.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sabado.Location = new System.Drawing.Point(22, 250);
            this.sabado.Name = "sabado";
            this.sabado.Size = new System.Drawing.Size(83, 21);
            this.sabado.TabIndex = 16;
            this.sabado.Text = "SABADO";
            // 
            // linggo
            // 
            this.linggo.AutoSize = true;
            this.linggo.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linggo.Location = new System.Drawing.Point(27, 283);
            this.linggo.Name = "linggo";
            this.linggo.Size = new System.Drawing.Size(78, 21);
            this.linggo.TabIndex = 17;
            this.linggo.Text = "LINGGO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.days);
            this.panel2.Controls.Add(this.lunes);
            this.panel2.Controls.Add(this.linggo);
            this.panel2.Controls.Add(this.martes);
            this.panel2.Controls.Add(this.sabado);
            this.panel2.Controls.Add(this.miyerkules);
            this.panel2.Controls.Add(this.biyernes);
            this.panel2.Controls.Add(this.huwebes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 401);
            this.panel2.TabIndex = 18;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(172, 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(323, 21);
            this.name.TabIndex = 0;
            this.name.Text = "SOMA\'S FAMILY RESTAURANT MENU";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days.Location = new System.Drawing.Point(12, 49);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(59, 21);
            this.days.TabIndex = 19;
            this.days.Text = "DAYS:";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 401);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.order);
            this.Controls.Add(this.discountedprice);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.price);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label lunes;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox discountedprice;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label martes;
        private System.Windows.Forms.Label miyerkules;
        private System.Windows.Forms.Label huwebes;
        private System.Windows.Forms.Label biyernes;
        private System.Windows.Forms.Label sabado;
        private System.Windows.Forms.Label linggo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label days;
    }
}

