namespace JoeEBob
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
            this.joeCash = new System.Windows.Forms.Label();
            this.bobCash = new System.Windows.Forms.Label();
            this.bankCash = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joeGiveToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joeCash
            // 
            this.joeCash.AutoSize = true;
            this.joeCash.Location = new System.Drawing.Point(26, 49);
            this.joeCash.Name = "joeCash";
            this.joeCash.Size = new System.Drawing.Size(63, 13);
            this.joeCash.TabIndex = 3;
            this.joeCash.Text = "DinheiroJoe";
            // 
            // bobCash
            // 
            this.bobCash.AutoSize = true;
            this.bobCash.Location = new System.Drawing.Point(26, 101);
            this.bobCash.Name = "bobCash";
            this.bobCash.Size = new System.Drawing.Size(65, 13);
            this.bobCash.TabIndex = 4;
            this.bobCash.Text = "DinheiroBob";
            // 
            // bankCash
            // 
            this.bankCash.AutoSize = true;
            this.bankCash.Location = new System.Drawing.Point(26, 146);
            this.bankCash.Name = "bankCash";
            this.bankCash.Size = new System.Drawing.Size(77, 13);
            this.bankCash.TabIndex = 5;
            this.bankCash.Text = "DinheiroBanco";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "De R$10 para Joe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 49);
            this.button2.TabIndex = 7;
            this.button2.Text = "Receba R$5 de Bob";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joeGiveToBob
            // 
            this.joeGiveToBob.Location = new System.Drawing.Point(29, 273);
            this.joeGiveToBob.Name = "joeGiveToBob";
            this.joeGiveToBob.Size = new System.Drawing.Size(109, 54);
            this.joeGiveToBob.TabIndex = 8;
            this.joeGiveToBob.Text = "Joe da R$10 para Bob";
            this.joeGiveToBob.UseVisualStyleBackColor = true;
            this.joeGiveToBob.Click += new System.EventHandler(this.joeGiveToBob_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(181, 273);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(102, 54);
            this.bobGivesToJoe.TabIndex = 9;
            this.bobGivesToJoe.Text = "Bob da R$5 para Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 377);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGiveToBob);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bankCash);
            this.Controls.Add(this.bobCash);
            this.Controls.Add(this.joeCash);
            this.Name = "Form1";
            this.Text = "Dividas Bob e Joe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joeCash;
        private System.Windows.Forms.Label bobCash;
        private System.Windows.Forms.Label bankCash;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button joeGiveToBob;
        private System.Windows.Forms.Button bobGivesToJoe;
    }
}

