namespace NLAS15
{
    partial class Authentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification));
            this.Blab = new System.Windows.Forms.Label();
            this.connbtn = new System.Windows.Forms.Button();
            this.MdPtxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Blab
            // 
            this.Blab.AutoSize = true;
            this.Blab.BackColor = System.Drawing.Color.White;
            this.Blab.ForeColor = System.Drawing.Color.Black;
            this.Blab.Location = new System.Drawing.Point(189, 145);
            this.Blab.Name = "Blab";
            this.Blab.Size = new System.Drawing.Size(57, 13);
            this.Blab.TabIndex = 13;
            this.Blab.Text = "Bienvenue";
            // 
            // connbtn
            // 
            this.connbtn.BackColor = System.Drawing.Color.White;
            this.connbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.connbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.connbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connbtn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.connbtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.connbtn.Location = new System.Drawing.Point(192, 309);
            this.connbtn.Name = "connbtn";
            this.connbtn.Size = new System.Drawing.Size(90, 44);
            this.connbtn.TabIndex = 12;
            this.connbtn.Text = "Connexion";
            this.connbtn.UseVisualStyleBackColor = false;
            this.connbtn.Click += new System.EventHandler(this.connbtn_Click_1);
            // 
            // MdPtxt
            // 
            this.MdPtxt.Location = new System.Drawing.Point(192, 261);
            this.MdPtxt.Name = "MdPtxt";
            this.MdPtxt.PasswordChar = '*';
            this.MdPtxt.Size = new System.Drawing.Size(303, 21);
            this.MdPtxt.TabIndex = 11;
            this.MdPtxt.UseSystemPasswordChar = true;
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(192, 214);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(303, 21);
            this.usertxt.TabIndex = 10;
            // 
            // Authentification
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Zoom;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(685, 498);
            this.Controls.Add(this.Blab);
            this.Controls.Add(this.connbtn);
            this.Controls.Add(this.MdPtxt);
            this.Controls.Add(this.usertxt);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(701, 537);
            this.MinimumSize = new System.Drawing.Size(701, 537);
            this.Name = "Authentification";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Authentification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Blab;
        private System.Windows.Forms.Button connbtn;
        private System.Windows.Forms.TextBox MdPtxt;
        private System.Windows.Forms.TextBox usertxt;
    }
}

