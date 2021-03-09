namespace DataGamingInterface.Forms
{
    partial class FormHome
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
            this.buttonSelectGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelectGame
            // 
            this.buttonSelectGame.Location = new System.Drawing.Point(274, 12);
            this.buttonSelectGame.Name = "buttonSelectGame";
            this.buttonSelectGame.Size = new System.Drawing.Size(207, 352);
            this.buttonSelectGame.TabIndex = 0;
            this.buttonSelectGame.Text = "Seleccionar Juego";
            this.buttonSelectGame.UseVisualStyleBackColor = true;
            this.buttonSelectGame.Click += new System.EventHandler(this.ButtonSelectGame_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 352);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(190, 352);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSelectGame);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}