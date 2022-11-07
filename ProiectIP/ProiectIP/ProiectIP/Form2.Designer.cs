
namespace ProiectIP
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.labelQuestion = new System.Windows.Forms.Label();
            this.var1 = new System.Windows.Forms.Button();
            this.var2 = new System.Windows.Forms.Button();
            this.var3 = new System.Windows.Forms.Button();
            this.var4 = new System.Windows.Forms.Button();
            this.pictureBoxChestionar = new System.Windows.Forms.PictureBox();
            this.labelSucces = new System.Windows.Forms.Label();
            this.buttonHelpChestionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChestionar)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.BackColor = System.Drawing.Color.BurlyWood;
            this.labelQuestion.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuestion.Location = new System.Drawing.Point(181, 249);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(101, 26);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "Question";
            this.labelQuestion.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // var1
            // 
            this.var1.BackColor = System.Drawing.Color.Coral;
            this.var1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.var1.Location = new System.Drawing.Point(85, 300);
            this.var1.Name = "var1";
            this.var1.Size = new System.Drawing.Size(264, 68);
            this.var1.TabIndex = 2;
            this.var1.Tag = "1";
            this.var1.Text = "button1";
            this.var1.UseVisualStyleBackColor = false;
            this.var1.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // var2
            // 
            this.var2.BackColor = System.Drawing.Color.Coral;
            this.var2.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.var2.Location = new System.Drawing.Point(85, 405);
            this.var2.Name = "var2";
            this.var2.Size = new System.Drawing.Size(264, 75);
            this.var2.TabIndex = 3;
            this.var2.Tag = "2";
            this.var2.Text = "button2";
            this.var2.UseVisualStyleBackColor = false;
            this.var2.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // var3
            // 
            this.var3.BackColor = System.Drawing.Color.Coral;
            this.var3.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.var3.Location = new System.Drawing.Point(485, 300);
            this.var3.Name = "var3";
            this.var3.Size = new System.Drawing.Size(291, 68);
            this.var3.TabIndex = 4;
            this.var3.Tag = "3";
            this.var3.Text = "button3";
            this.var3.UseVisualStyleBackColor = false;
            this.var3.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // var4
            // 
            this.var4.BackColor = System.Drawing.Color.Coral;
            this.var4.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold);
            this.var4.Location = new System.Drawing.Point(485, 405);
            this.var4.Name = "var4";
            this.var4.Size = new System.Drawing.Size(291, 75);
            this.var4.TabIndex = 5;
            this.var4.Tag = "4";
            this.var4.Text = "button4";
            this.var4.UseVisualStyleBackColor = false;
            this.var4.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // pictureBoxChestionar
            // 
            this.pictureBoxChestionar.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBoxChestionar.Image = global::ProiectIP.Properties.Resources.math;
            this.pictureBoxChestionar.Location = new System.Drawing.Point(249, 12);
            this.pictureBoxChestionar.Name = "pictureBoxChestionar";
            this.pictureBoxChestionar.Size = new System.Drawing.Size(308, 209);
            this.pictureBoxChestionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChestionar.TabIndex = 0;
            this.pictureBoxChestionar.TabStop = false;
            this.pictureBoxChestionar.Click += new System.EventHandler(this.pictureBoxChestionar_Click);
            // 
            // labelSucces
            // 
            this.labelSucces.AutoSize = true;
            this.labelSucces.Location = new System.Drawing.Point(650, 12);
            this.labelSucces.Name = "labelSucces";
            this.labelSucces.Size = new System.Drawing.Size(46, 17);
            this.labelSucces.TabIndex = 6;
            this.labelSucces.Text = "label2";
            this.labelSucces.Click += new System.EventHandler(this.labelSucces_Click);
            // 
            // buttonHelpChestionar
            // 
            this.buttonHelpChestionar.BackColor = System.Drawing.Color.SandyBrown;
            this.buttonHelpChestionar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelpChestionar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHelpChestionar.Location = new System.Drawing.Point(85, 12);
            this.buttonHelpChestionar.Name = "buttonHelpChestionar";
            this.buttonHelpChestionar.Size = new System.Drawing.Size(96, 41);
            this.buttonHelpChestionar.TabIndex = 16;
            this.buttonHelpChestionar.Tag = "a";
            this.buttonHelpChestionar.Text = "Help";
            this.buttonHelpChestionar.UseVisualStyleBackColor = false;
            this.buttonHelpChestionar.Click += new System.EventHandler(this.buttonHelpChestionar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1071, 512);
            this.Controls.Add(this.buttonHelpChestionar);
            this.Controls.Add(this.labelSucces);
            this.Controls.Add(this.var4);
            this.Controls.Add(this.var3);
            this.Controls.Add(this.var2);
            this.Controls.Add(this.var1);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.pictureBoxChestionar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Chestionar";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChestionar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxChestionar;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button var1;
        private System.Windows.Forms.Button var2;
        private System.Windows.Forms.Button var3;
        private System.Windows.Forms.Button var4;
        private System.Windows.Forms.Label labelSucces;
        private System.Windows.Forms.Button buttonHelpChestionar;
    }
}