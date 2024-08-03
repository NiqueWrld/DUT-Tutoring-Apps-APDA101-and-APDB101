
namespace ID_Parsing_App
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
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnParse = new System.Windows.Forms.Button();
            this.labe3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblCitizenship = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNumber.Location = new System.Drawing.Point(21, 62);
            this.txtIDNumber.MaxLength = 13;
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(768, 49);
            this.txtIDNumber.TabIndex = 0;
            this.txtIDNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.label2.Location = new System.Drawing.Point(12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 50);
            this.label2.TabIndex = 2;
            this.label2.Text = "Age:";
            // 
            // btnParse
            // 
            this.btnParse.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.btnParse.Location = new System.Drawing.Point(612, 117);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(176, 54);
            this.btnParse.TabIndex = 1;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // labe3
            // 
            this.labe3.AutoSize = true;
            this.labe3.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.labe3.Location = new System.Drawing.Point(12, 293);
            this.labe3.Name = "labe3";
            this.labe3.Size = new System.Drawing.Size(158, 50);
            this.labe3.TabIndex = 3;
            this.labe3.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.label4.Location = new System.Drawing.Point(12, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 50);
            this.label4.TabIndex = 4;
            this.label4.Text = "Citizenship:";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("MV Boli", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(275, 50);
            this.lblHeader.TabIndex = 5;
            this.lblHeader.Text = "ID Parser App";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.lblAge.Location = new System.Drawing.Point(297, 236);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(92, 50);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "*****";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.lblGender.Location = new System.Drawing.Point(297, 293);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(92, 50);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "*****";
            // 
            // lblCitizenship
            // 
            this.lblCitizenship.AutoSize = true;
            this.lblCitizenship.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.lblCitizenship.Location = new System.Drawing.Point(297, 348);
            this.lblCitizenship.Name = "lblCitizenship";
            this.lblCitizenship.Size = new System.Drawing.Size(92, 50);
            this.lblCitizenship.TabIndex = 11;
            this.lblCitizenship.Text = "*****";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.lblDateOfBirth.Location = new System.Drawing.Point(297, 186);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(92, 50);
            this.lblDateOfBirth.TabIndex = 13;
            this.lblDateOfBirth.Text = "*****";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 22.2F);
            this.label1.Location = new System.Drawing.Point(8, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date of birth:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCitizenship);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labe3);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIDNumber);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Label labe3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCitizenship;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label label1;
    }
}

