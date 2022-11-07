
namespace ProiectIP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LabelTitlu = new System.Windows.Forms.Label();
            this.labelDomeniu = new System.Windows.Forms.Label();
            this.buttonMatematica = new System.Windows.Forms.Button();
            this.buttonChimie = new System.Windows.Forms.Button();
            this.buttonIstorie = new System.Windows.Forms.Button();
            this.buttonRomana = new System.Windows.Forms.Button();
            this.buttonSport = new System.Windows.Forms.Button();
            this.buttonArta = new System.Windows.Forms.Button();
            this.buttonMuzica = new System.Windows.Forms.Button();
            this.pictureBoxQuizNight = new System.Windows.Forms.PictureBox();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelNume = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonGeografie = new System.Windows.Forms.Button();
            this.buttonSeteaza = new System.Windows.Forms.Button();
            this.labelVarsta = new System.Windows.Forms.Label();
            this.textBoxVarsta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuizNight)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitlu
            // 
            this.LabelTitlu.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitlu.ForeColor = System.Drawing.Color.Peru;
            this.LabelTitlu.Location = new System.Drawing.Point(426, 9);
            this.LabelTitlu.Name = "LabelTitlu";
            this.LabelTitlu.Size = new System.Drawing.Size(266, 35);
            this.LabelTitlu.TabIndex = 1;
            this.LabelTitlu.Text = "Te consideri deștept?";
            this.LabelTitlu.Click += new System.EventHandler(this.labelTitlu_Click);
            // 
            // labelDomeniu
            // 
            this.labelDomeniu.AutoSize = true;
            this.labelDomeniu.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDomeniu.ForeColor = System.Drawing.Color.Peru;
            this.labelDomeniu.Location = new System.Drawing.Point(22, 286);
            this.labelDomeniu.Name = "labelDomeniu";
            this.labelDomeniu.Size = new System.Drawing.Size(346, 26);
            this.labelDomeniu.TabIndex = 2;
            this.labelDomeniu.Text = "Alege un domeniu dacă ai curaj:";
            this.labelDomeniu.Click += new System.EventHandler(this.labelDomeniu_Click);
            // 
            // buttonMatematica
            // 
            this.buttonMatematica.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonMatematica.Enabled = false;
            this.buttonMatematica.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMatematica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMatematica.Location = new System.Drawing.Point(61, 445);
            this.buttonMatematica.Name = "buttonMatematica";
            this.buttonMatematica.Size = new System.Drawing.Size(168, 80);
            this.buttonMatematica.TabIndex = 4;
            this.buttonMatematica.Tag = "m";
            this.buttonMatematica.Text = "Matematică";
            this.buttonMatematica.UseVisualStyleBackColor = false;
            this.buttonMatematica.Click += new System.EventHandler(this.buttonMatematica_Click);
            // 
            // buttonChimie
            // 
            this.buttonChimie.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonChimie.Enabled = false;
            this.buttonChimie.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChimie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonChimie.Location = new System.Drawing.Point(325, 342);
            this.buttonChimie.Name = "buttonChimie";
            this.buttonChimie.Size = new System.Drawing.Size(173, 72);
            this.buttonChimie.TabIndex = 5;
            this.buttonChimie.Tag = "c";
            this.buttonChimie.Text = "Chimie";
            this.buttonChimie.UseVisualStyleBackColor = false;
            this.buttonChimie.Click += new System.EventHandler(this.buttonChimie_Click);
            // 
            // buttonIstorie
            // 
            this.buttonIstorie.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonIstorie.Enabled = false;
            this.buttonIstorie.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIstorie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonIstorie.Location = new System.Drawing.Point(325, 445);
            this.buttonIstorie.Name = "buttonIstorie";
            this.buttonIstorie.Size = new System.Drawing.Size(173, 80);
            this.buttonIstorie.TabIndex = 6;
            this.buttonIstorie.Tag = "i";
            this.buttonIstorie.Text = "Istorie";
            this.buttonIstorie.UseVisualStyleBackColor = false;
            this.buttonIstorie.Click += new System.EventHandler(this.buttonIstorie_Click);
            // 
            // buttonRomana
            // 
            this.buttonRomana.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonRomana.Enabled = false;
            this.buttonRomana.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRomana.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRomana.Location = new System.Drawing.Point(602, 437);
            this.buttonRomana.Name = "buttonRomana";
            this.buttonRomana.Size = new System.Drawing.Size(185, 88);
            this.buttonRomana.TabIndex = 7;
            this.buttonRomana.Tag = "llr";
            this.buttonRomana.Text = "Limba și literatura română";
            this.buttonRomana.UseVisualStyleBackColor = false;
            this.buttonRomana.Click += new System.EventHandler(this.buttonRomana_Click);
            // 
            // buttonSport
            // 
            this.buttonSport.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonSport.Enabled = false;
            this.buttonSport.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSport.Location = new System.Drawing.Point(621, 342);
            this.buttonSport.Name = "buttonSport";
            this.buttonSport.Size = new System.Drawing.Size(146, 72);
            this.buttonSport.TabIndex = 8;
            this.buttonSport.Tag = "l";
            this.buttonSport.Text = "Sport";
            this.buttonSport.UseVisualStyleBackColor = false;
            this.buttonSport.Click += new System.EventHandler(this.buttonSport_Click);
            // 
            // buttonArta
            // 
            this.buttonArta.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonArta.Enabled = false;
            this.buttonArta.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonArta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonArta.Location = new System.Drawing.Point(883, 342);
            this.buttonArta.Name = "buttonArta";
            this.buttonArta.Size = new System.Drawing.Size(146, 72);
            this.buttonArta.TabIndex = 9;
            this.buttonArta.Tag = "a";
            this.buttonArta.Text = "Artă";
            this.buttonArta.UseVisualStyleBackColor = false;
            this.buttonArta.Click += new System.EventHandler(this.buttonArta_Click);
            // 
            // buttonMuzica
            // 
            this.buttonMuzica.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonMuzica.Enabled = false;
            this.buttonMuzica.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMuzica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonMuzica.Location = new System.Drawing.Point(883, 445);
            this.buttonMuzica.Name = "buttonMuzica";
            this.buttonMuzica.Size = new System.Drawing.Size(146, 72);
            this.buttonMuzica.TabIndex = 10;
            this.buttonMuzica.Tag = "m";
            this.buttonMuzica.Text = "Muzică";
            this.buttonMuzica.UseVisualStyleBackColor = false;
            this.buttonMuzica.Click += new System.EventHandler(this.buttonMuzica_Click);
            // 
            // pictureBoxQuizNight
            // 
            this.pictureBoxQuizNight.Image = global::ProiectIP.Properties.Resources.Quiz;
            this.pictureBoxQuizNight.Location = new System.Drawing.Point(336, 47);
            this.pictureBoxQuizNight.Name = "pictureBoxQuizNight";
            this.pictureBoxQuizNight.Size = new System.Drawing.Size(463, 236);
            this.pictureBoxQuizNight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxQuizNight.TabIndex = 0;
            this.pictureBoxQuizNight.TabStop = false;
            this.pictureBoxQuizNight.Click += new System.EventHandler(this.pictureBoxQuizNight_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(880, 17);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(169, 17);
            this.labelWelcome.TabIndex = 11;
            this.labelWelcome.Text = "Bine ai venit, necunoscut!";
            this.labelWelcome.Click += new System.EventHandler(this.labelWelcome_Click);
            // 
            // labelNume
            // 
            this.labelNume.AutoSize = true;
            this.labelNume.Location = new System.Drawing.Point(805, 60);
            this.labelNume.Name = "labelNume";
            this.labelNume.Size = new System.Drawing.Size(128, 17);
            this.labelNume.TabIndex = 12;
            this.labelNume.Text = "Introduceti numele:";
            this.labelNume.Click += new System.EventHandler(this.labelNume_Click);
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(967, 60);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(100, 22);
            this.textBoxNume.TabIndex = 13;
            this.textBoxNume.TextChanged += new System.EventHandler(this.textBoxNume_TextChanged);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonHelp.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHelp.Location = new System.Drawing.Point(61, 17);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(96, 41);
            this.buttonHelp.TabIndex = 15;
            this.buttonHelp.Tag = "a";
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonGeografie
            // 
            this.buttonGeografie.BackColor = System.Drawing.Color.NavajoWhite;
            this.buttonGeografie.Enabled = false;
            this.buttonGeografie.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGeografie.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGeografie.Location = new System.Drawing.Point(61, 342);
            this.buttonGeografie.Name = "buttonGeografie";
            this.buttonGeografie.Size = new System.Drawing.Size(168, 72);
            this.buttonGeografie.TabIndex = 3;
            this.buttonGeografie.Tag = "g";
            this.buttonGeografie.Text = "Geografie";
            this.buttonGeografie.UseVisualStyleBackColor = false;
            this.buttonGeografie.Click += new System.EventHandler(this.buttonGeografie_Click);
            // 
            // buttonSeteaza
            // 
            this.buttonSeteaza.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonSeteaza.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeteaza.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSeteaza.Location = new System.Drawing.Point(860, 142);
            this.buttonSeteaza.Name = "buttonSeteaza";
            this.buttonSeteaza.Size = new System.Drawing.Size(120, 35);
            this.buttonSeteaza.TabIndex = 16;
            this.buttonSeteaza.Tag = "g";
            this.buttonSeteaza.Text = "Seteaza";
            this.buttonSeteaza.UseVisualStyleBackColor = false;
            this.buttonSeteaza.Click += new System.EventHandler(this.buttonSeteaza_Click);
            // 
            // labelVarsta
            // 
            this.labelVarsta.AutoSize = true;
            this.labelVarsta.Location = new System.Drawing.Point(802, 103);
            this.labelVarsta.Name = "labelVarsta";
            this.labelVarsta.Size = new System.Drawing.Size(159, 17);
            this.labelVarsta.TabIndex = 17;
            this.labelVarsta.Text = "Introduceti anul nasterii:";
            // 
            // textBoxVarsta
            // 
            this.textBoxVarsta.Location = new System.Drawing.Point(967, 100);
            this.textBoxVarsta.Name = "textBoxVarsta";
            this.textBoxVarsta.Size = new System.Drawing.Size(100, 22);
            this.textBoxVarsta.TabIndex = 18;
            this.textBoxVarsta.TextChanged += new System.EventHandler(this.textBoxVarsta_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1130, 582);
            this.Controls.Add(this.textBoxVarsta);
            this.Controls.Add(this.labelVarsta);
            this.Controls.Add(this.buttonSeteaza);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelNume);
            this.Controls.Add(this.labelWelcome);
            this.Controls.Add(this.buttonMuzica);
            this.Controls.Add(this.buttonArta);
            this.Controls.Add(this.buttonSport);
            this.Controls.Add(this.buttonRomana);
            this.Controls.Add(this.buttonIstorie);
            this.Controls.Add(this.buttonChimie);
            this.Controls.Add(this.buttonMatematica);
            this.Controls.Add(this.buttonGeografie);
            this.Controls.Add(this.labelDomeniu);
            this.Controls.Add(this.LabelTitlu);
            this.Controls.Add(this.pictureBoxQuizNight);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TEST CULTURA GENERALA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQuizNight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelTitlu;
        private System.Windows.Forms.PictureBox pictureBoxQuizNight;
        private System.Windows.Forms.Label labelDomeniu;
        private System.Windows.Forms.Button buttonMatematica;
        private System.Windows.Forms.Button buttonChimie;
        private System.Windows.Forms.Button buttonIstorie;
        private System.Windows.Forms.Button buttonRomana;
        private System.Windows.Forms.Button buttonSport;
        private System.Windows.Forms.Button buttonArta;
        private System.Windows.Forms.Button buttonMuzica;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelNume;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonGeografie;
        private System.Windows.Forms.Button buttonSeteaza;
        private System.Windows.Forms.Label labelVarsta;
        private System.Windows.Forms.TextBox textBoxVarsta;
    }
}

