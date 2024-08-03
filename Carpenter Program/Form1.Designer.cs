
namespace Carpenter_Program
{
    partial class frmCarpenterProgram
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
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetQuote = new System.Windows.Forms.Button();
            this.labe4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtNumDrawers = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radCherry = new System.Windows.Forms.RadioButton();
            this.radMohagany = new System.Windows.Forms.RadioButton();
            this.radOak = new System.Windows.Forms.RadioButton();
            this.radPine = new System.Windows.Forms.RadioButton();
            this.lblQuote = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLength
            // 
            this.txtLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLength.Location = new System.Drawing.Point(449, 50);
            this.txtLength.MaxLength = 13;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(365, 49);
            this.txtLength.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.label3.Location = new System.Drawing.Point(56, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 50);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of Drawers:";
            // 
            // btnGetQuote
            // 
            this.btnGetQuote.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.btnGetQuote.Location = new System.Drawing.Point(449, 555);
            this.btnGetQuote.Name = "btnGetQuote";
            this.btnGetQuote.Size = new System.Drawing.Size(272, 54);
            this.btnGetQuote.TabIndex = 1;
            this.btnGetQuote.Text = "Get Quote";
            this.btnGetQuote.UseVisualStyleBackColor = true;
            this.btnGetQuote.Click += new System.EventHandler(this.btnGetQuote_Click);
            // 
            // labe4
            // 
            this.labe4.AutoSize = true;
            this.labe4.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.labe4.Location = new System.Drawing.Point(56, 236);
            this.labe4.Name = "labe4";
            this.labe4.Size = new System.Drawing.Size(282, 50);
            this.labe4.TabIndex = 3;
            this.labe4.Text = "Type of wood:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.label5.Location = new System.Drawing.Point(56, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 50);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quote price is:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Desk Length[mm]:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.label2.Location = new System.Drawing.Point(56, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 50);
            this.label2.TabIndex = 12;
            this.label2.Text = "Desk Width[mm]:";
            // 
            // txtWidth
            // 
            this.txtWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidth.Location = new System.Drawing.Point(449, 104);
            this.txtWidth.MaxLength = 13;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(365, 49);
            this.txtWidth.TabIndex = 14;
            // 
            // txtNumDrawers
            // 
            this.txtNumDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDrawers.Location = new System.Drawing.Point(449, 159);
            this.txtNumDrawers.MaxLength = 13;
            this.txtNumDrawers.Name = "txtNumDrawers";
            this.txtNumDrawers.Size = new System.Drawing.Size(365, 49);
            this.txtNumDrawers.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radPine);
            this.panel1.Controls.Add(this.radOak);
            this.panel1.Controls.Add(this.radMohagany);
            this.panel1.Controls.Add(this.radCherry);
            this.panel1.Location = new System.Drawing.Point(449, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 248);
            this.panel1.TabIndex = 16;
            // 
            // radCherry
            // 
            this.radCherry.AutoSize = true;
            this.radCherry.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.radCherry.Location = new System.Drawing.Point(14, 3);
            this.radCherry.Name = "radCherry";
            this.radCherry.Size = new System.Drawing.Size(158, 54);
            this.radCherry.TabIndex = 0;
            this.radCherry.TabStop = true;
            this.radCherry.Text = "Cherry";
            this.radCherry.UseVisualStyleBackColor = true;
            // 
            // radMohagany
            // 
            this.radMohagany.AutoSize = true;
            this.radMohagany.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.radMohagany.Location = new System.Drawing.Point(14, 63);
            this.radMohagany.Name = "radMohagany";
            this.radMohagany.Size = new System.Drawing.Size(214, 54);
            this.radMohagany.TabIndex = 1;
            this.radMohagany.TabStop = true;
            this.radMohagany.Text = "Mohagany";
            this.radMohagany.UseVisualStyleBackColor = true;
            // 
            // radOak
            // 
            this.radOak.AutoSize = true;
            this.radOak.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.radOak.Location = new System.Drawing.Point(14, 122);
            this.radOak.Name = "radOak";
            this.radOak.Size = new System.Drawing.Size(106, 54);
            this.radOak.TabIndex = 2;
            this.radOak.TabStop = true;
            this.radOak.Text = "Oak";
            this.radOak.UseVisualStyleBackColor = true;
            // 
            // radPine
            // 
            this.radPine.AutoSize = true;
            this.radPine.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.radPine.Location = new System.Drawing.Point(13, 182);
            this.radPine.Name = "radPine";
            this.radPine.Size = new System.Drawing.Size(118, 54);
            this.radPine.TabIndex = 3;
            this.radPine.TabStop = true;
            this.radPine.Text = "Pine";
            this.radPine.UseVisualStyleBackColor = true;
            // 
            // lblQuote
            // 
            this.lblQuote.AutoSize = true;
            this.lblQuote.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.lblQuote.Location = new System.Drawing.Point(440, 487);
            this.lblQuote.Name = "lblQuote";
            this.lblQuote.Size = new System.Drawing.Size(314, 50);
            this.lblQuote.TabIndex = 17;
            this.lblQuote.Text = "Quote goes here";
            // 
            // frmCarpenterProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 641);
            this.Controls.Add(this.lblQuote);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNumDrawers);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labe4);
            this.Controls.Add(this.btnGetQuote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLength);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCarpenterProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carpenter Program";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGetQuote;
        private System.Windows.Forms.Label labe4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtNumDrawers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radPine;
        private System.Windows.Forms.RadioButton radOak;
        private System.Windows.Forms.RadioButton radMohagany;
        private System.Windows.Forms.RadioButton radCherry;
        private System.Windows.Forms.Label lblQuote;
    }
}

