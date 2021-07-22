
namespace Polymorphism_Yarıs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblmercedes = new System.Windows.Forms.Label();
            this.lblbmw = new System.Windows.Forms.Label();
            this.lbltofas = new System.Windows.Forms.Label();
            this.lblfinis = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblmercedes
            // 
            this.lblmercedes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblmercedes.Location = new System.Drawing.Point(181, 22);
            this.lblmercedes.Name = "lblmercedes";
            this.lblmercedes.Size = new System.Drawing.Size(116, 72);
            this.lblmercedes.TabIndex = 0;
            this.lblmercedes.Text = "Mercedes";
            this.lblmercedes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblbmw
            // 
            this.lblbmw.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblbmw.Location = new System.Drawing.Point(181, 138);
            this.lblbmw.Name = "lblbmw";
            this.lblbmw.Size = new System.Drawing.Size(116, 72);
            this.lblbmw.TabIndex = 1;
            this.lblbmw.Text = "BMW";
            this.lblbmw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbltofas
            // 
            this.lbltofas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbltofas.Location = new System.Drawing.Point(181, 253);
            this.lbltofas.Name = "lbltofas";
            this.lbltofas.Size = new System.Drawing.Size(116, 72);
            this.lbltofas.TabIndex = 2;
            this.lbltofas.Text = "Tofaş";
            this.lbltofas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblfinis
            // 
            this.lblfinis.BackColor = System.Drawing.Color.Red;
            this.lblfinis.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfinis.Location = new System.Drawing.Point(763, 22);
            this.lblfinis.Name = "lblfinis";
            this.lblfinis.Size = new System.Drawing.Size(32, 314);
            this.lblfinis.TabIndex = 3;
            this.lblfinis.Text = "Bitiş";
            this.lblfinis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnstart
            // 
            this.btnstart.BackColor = System.Drawing.Color.Yellow;
            this.btnstart.Location = new System.Drawing.Point(12, 363);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(162, 54);
            this.btnstart.TabIndex = 4;
            this.btnstart.Text = "Başlat";
            this.btnstart.UseVisualStyleBackColor = false;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // tm
            // 
            this.tm.Interval = 1000;
            this.tm.Tick += new System.EventHandler(this.tm_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lblfinis);
            this.Controls.Add(this.lbltofas);
            this.Controls.Add(this.lblbmw);
            this.Controls.Add(this.lblmercedes);
            this.Name = "Form1";
            this.Text = "Yarış";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblmercedes;
        private System.Windows.Forms.Label lblbmw;
        private System.Windows.Forms.Label lbltofas;
        private System.Windows.Forms.Label lblfinis;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Timer tm;
    }
}

