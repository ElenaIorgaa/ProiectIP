
namespace ProiectIP
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.labelFelicitari = new System.Windows.Forms.Label();
            this.labelScorFinal = new System.Windows.Forms.Label();
            this.labelPunctaj = new System.Windows.Forms.Label();
            this.labelProcent = new System.Windows.Forms.Label();
            this.buttonAlegeDomeniu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFelicitari
            // 
            this.labelFelicitari.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.labelFelicitari.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFelicitari.ForeColor = System.Drawing.Color.Red;
            this.labelFelicitari.Location = new System.Drawing.Point(251, 55);
            this.labelFelicitari.Name = "labelFelicitari";
            this.labelFelicitari.Size = new System.Drawing.Size(322, 118);
            this.labelFelicitari.TabIndex = 0;
            this.labelFelicitari.Text = "FELICITĂRI";
            this.labelFelicitari.Click += new System.EventHandler(this.labelFelicitari_Click);
            // 
            // labelScorFinal
            // 
            this.labelScorFinal.BackColor = System.Drawing.Color.LightSalmon;
            this.labelScorFinal.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScorFinal.ForeColor = System.Drawing.Color.Red;
            this.labelScorFinal.Location = new System.Drawing.Point(253, 204);
            this.labelScorFinal.Name = "labelScorFinal";
            this.labelScorFinal.Size = new System.Drawing.Size(140, 29);
            this.labelScorFinal.TabIndex = 1;
            this.labelScorFinal.Text = "Scor final:";
            this.labelScorFinal.Click += new System.EventHandler(this.labelScorFinal_Click);
            // 
            // labelPunctaj
            // 
            this.labelPunctaj.BackColor = System.Drawing.Color.LightSalmon;
            this.labelPunctaj.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPunctaj.ForeColor = System.Drawing.Color.Red;
            this.labelPunctaj.Location = new System.Drawing.Point(392, 204);
            this.labelPunctaj.Name = "labelPunctaj";
            this.labelPunctaj.Size = new System.Drawing.Size(79, 29);
            this.labelPunctaj.TabIndex = 3;
            this.labelPunctaj.Text = "label3";
            this.labelPunctaj.Click += new System.EventHandler(this.labelPunctaj_Click);
            // 
            // labelProcent
            // 
            this.labelProcent.BackColor = System.Drawing.Color.LightSalmon;
            this.labelProcent.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcent.ForeColor = System.Drawing.Color.Red;
            this.labelProcent.Location = new System.Drawing.Point(468, 204);
            this.labelProcent.Name = "labelProcent";
            this.labelProcent.Size = new System.Drawing.Size(35, 29);
            this.labelProcent.TabIndex = 4;
            this.labelProcent.Text = "%";
            this.labelProcent.Click += new System.EventHandler(this.labelProcent_Click);
            // 
            // buttonAlegeDomeniu
            // 
            this.buttonAlegeDomeniu.BackColor = System.Drawing.Color.Coral;
            this.buttonAlegeDomeniu.ForeColor = System.Drawing.Color.Black;
            this.buttonAlegeDomeniu.Location = new System.Drawing.Point(289, 281);
            this.buttonAlegeDomeniu.Name = "buttonAlegeDomeniu";
            this.buttonAlegeDomeniu.Size = new System.Drawing.Size(182, 59);
            this.buttonAlegeDomeniu.TabIndex = 5;
            this.buttonAlegeDomeniu.Text = "Alege alt domeniu";
            this.buttonAlegeDomeniu.UseVisualStyleBackColor = false;
            this.buttonAlegeDomeniu.Click += new System.EventHandler(this.buttonAlegeDomeniu_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProiectIP.Properties.Resources.c___Copy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAlegeDomeniu);
            this.Controls.Add(this.labelProcent);
            this.Controls.Add(this.labelPunctaj);
            this.Controls.Add(this.labelScorFinal);
            this.Controls.Add(this.labelFelicitari);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "COMPLETED";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFelicitari;
        private System.Windows.Forms.Label labelScorFinal;
        private System.Windows.Forms.Label labelPunctaj;
        private System.Windows.Forms.Label labelProcent;
        private System.Windows.Forms.Button buttonAlegeDomeniu;
    }
}