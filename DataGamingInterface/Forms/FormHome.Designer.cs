﻿namespace DataGamingInterface.Forms
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
            this.buttonGameEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSelectGame
            // 
            this.buttonSelectGame.Location = new System.Drawing.Point(303, 134);
            this.buttonSelectGame.Name = "buttonSelectGame";
            this.buttonSelectGame.Size = new System.Drawing.Size(190, 230);
            this.buttonSelectGame.TabIndex = 0;
            this.buttonSelectGame.Text = "Seleccionar Juego";
            this.buttonSelectGame.UseVisualStyleBackColor = true;
            this.buttonSelectGame.Click += new System.EventHandler(this.ButtonSelectGame_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 230);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonGameEdit
            // 
            this.buttonGameEdit.Location = new System.Drawing.Point(28, 134);
            this.buttonGameEdit.Name = "buttonGameEdit";
            this.buttonGameEdit.Size = new System.Drawing.Size(190, 230);
            this.buttonGameEdit.TabIndex = 2;
            this.buttonGameEdit.Text = "Recursos de juego";
            this.buttonGameEdit.UseVisualStyleBackColor = true;
            this.buttonGameEdit.Click += new System.EventHandler(this.ButtonGameEdit_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataGamingInterface.Properties.Resources.external_content_duckduckgo_com;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.buttonGameEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSelectGame);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGameEdit;
    }
}