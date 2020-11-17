namespace HMSTutorial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.DocNameTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.PassTb = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 71);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(36, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DocNameTb
            // 
            this.DocNameTb.BorderColorFocused = System.Drawing.Color.MediumSpringGreen;
            this.DocNameTb.BorderColorIdle = System.Drawing.Color.LimeGreen;
            this.DocNameTb.BorderColorMouseHover = System.Drawing.Color.SpringGreen;
            this.DocNameTb.BorderThickness = 3;
            this.DocNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocNameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DocNameTb.ForeColor = System.Drawing.Color.LimeGreen;
            this.DocNameTb.isPassword = false;
            this.DocNameTb.Location = new System.Drawing.Point(36, 112);
            this.DocNameTb.Margin = new System.Windows.Forms.Padding(4);
            this.DocNameTb.Name = "DocNameTb";
            this.DocNameTb.Size = new System.Drawing.Size(196, 42);
            this.DocNameTb.TabIndex = 2;
            this.DocNameTb.Text = "DocName";
            this.DocNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PassTb
            // 
            this.PassTb.BorderColorFocused = System.Drawing.Color.MediumSpringGreen;
            this.PassTb.BorderColorIdle = System.Drawing.Color.LimeGreen;
            this.PassTb.BorderColorMouseHover = System.Drawing.Color.SpringGreen;
            this.PassTb.BorderThickness = 3;
            this.PassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PassTb.ForeColor = System.Drawing.Color.LimeGreen;
            this.PassTb.isPassword = true;
            this.PassTb.Location = new System.Drawing.Point(36, 171);
            this.PassTb.Margin = new System.Windows.Forms.Padding(4);
            this.PassTb.Name = "PassTb";
            this.PassTb.Size = new System.Drawing.Size(196, 42);
            this.PassTb.TabIndex = 3;
            this.PassTb.Text = "DocPassword";
            this.PassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.LimeGreen;
            this.label2.Location = new System.Drawing.Point(105, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clear";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(5, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clinic Management System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(255, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.DocNameTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private Bunifu.Framework.UI.BunifuMetroTextbox DocNameTb;
        private Bunifu.Framework.UI.BunifuMetroTextbox PassTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

