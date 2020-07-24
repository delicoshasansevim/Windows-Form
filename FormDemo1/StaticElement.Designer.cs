namespace FormDemo1
{
    partial class StaticElement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxKugelvolumen = new System.Windows.Forms.TextBox();
            this.textBoxKreiumfang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNetto = new System.Windows.Forms.TextBox();
            this.textBoxBrutto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxKugelvolumen);
            this.groupBox1.Controls.Add(this.textBoxKreiumfang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(67, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // textBoxKugelvolumen
            // 
            this.textBoxKugelvolumen.Location = new System.Drawing.Point(247, 107);
            this.textBoxKugelvolumen.Name = "textBoxKugelvolumen";
            this.textBoxKugelvolumen.ReadOnly = true;
            this.textBoxKugelvolumen.Size = new System.Drawing.Size(100, 20);
            this.textBoxKugelvolumen.TabIndex = 5;
            // 
            // textBoxKreiumfang
            // 
            this.textBoxKreiumfang.Location = new System.Drawing.Point(247, 51);
            this.textBoxKreiumfang.Name = "textBoxKreiumfang";
            this.textBoxKreiumfang.ReadOnly = true;
            this.textBoxKreiumfang.Size = new System.Drawing.Size(100, 20);
            this.textBoxKreiumfang.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kugelvolumen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "kreisumfang";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "radius";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textBoxNetto);
            this.groupBox2.Controls.Add(this.textBoxBrutto);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(67, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Berechnung starten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNetto
            // 
            this.textBoxNetto.Location = new System.Drawing.Point(247, 50);
            this.textBoxNetto.Name = "textBoxNetto";
            this.textBoxNetto.ReadOnly = true;
            this.textBoxNetto.Size = new System.Drawing.Size(100, 20);
            this.textBoxNetto.TabIndex = 3;
            // 
            // textBoxBrutto
            // 
            this.textBoxBrutto.Location = new System.Drawing.Point(10, 50);
            this.textBoxBrutto.Name = "textBoxBrutto";
            this.textBoxBrutto.Size = new System.Drawing.Size(100, 20);
            this.textBoxBrutto.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Netto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Brutto";
            // 
            // StaticElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(477, 455);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "StaticElement";
            this.Text = "StaticElement";
            this.Load += new System.EventHandler(this.StaticElement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxKugelvolumen;
        private System.Windows.Forms.TextBox textBoxKreiumfang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxNetto;
        private System.Windows.Forms.TextBox textBoxBrutto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}