﻿using System;

namespace DataGamingInterface.Forms
{
    partial class FormGameEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGameEdit));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.ButtonEditGameAndSave = new System.Windows.Forms.Button();
            this.ButtonAddNewGame = new System.Windows.Forms.Button();
            this.labelSelectGameFromEdit = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelInfoGame = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(26, 146);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(260, 274);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // ButtonEditGameAndSave
            // 
            this.ButtonEditGameAndSave.Location = new System.Drawing.Point(360, 278);
            this.ButtonEditGameAndSave.Name = "ButtonEditGameAndSave";
            this.ButtonEditGameAndSave.Size = new System.Drawing.Size(101, 46);
            this.ButtonEditGameAndSave.TabIndex = 1;
            this.ButtonEditGameAndSave.Text = "Editar juego y guardar";
            this.ButtonEditGameAndSave.UseVisualStyleBackColor = true;
            this.ButtonEditGameAndSave.Click += new System.EventHandler(this.ButtonEditGameAndSave_Click);
            // 
            // ButtonAddNewGame
            // 
            this.ButtonAddNewGame.Location = new System.Drawing.Point(360, 172);
            this.ButtonAddNewGame.Name = "ButtonAddNewGame";
            this.ButtonAddNewGame.Size = new System.Drawing.Size(101, 46);
            this.ButtonAddNewGame.TabIndex = 2;
            this.ButtonAddNewGame.Text = "Añadir nuevo Juego";
            this.ButtonAddNewGame.UseVisualStyleBackColor = true;
            this.ButtonAddNewGame.Click += new System.EventHandler(this.ButtonAddNewGame_Click);
            // 
            // labelSelectGameFromEdit
            // 
            this.labelSelectGameFromEdit.AutoSize = true;
            this.labelSelectGameFromEdit.Font = new System.Drawing.Font("Matrix", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectGameFromEdit.Location = new System.Drawing.Point(45, 86);
            this.labelSelectGameFromEdit.Name = "labelSelectGameFromEdit";
            this.labelSelectGameFromEdit.Size = new System.Drawing.Size(203, 36);
            this.labelSelectGameFromEdit.TabIndex = 3;
            this.labelSelectGameFromEdit.Text = "Seleccione un juego para \r\neditarlo";
            this.labelSelectGameFromEdit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(555, 217);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 203);
            this.textBox1.TabIndex = 4;
            // 
            // labelInfoGame
            // 
            this.labelInfoGame.AutoSize = true;
            this.labelInfoGame.Font = new System.Drawing.Font("Matrix", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoGame.Location = new System.Drawing.Point(585, 172);
            this.labelInfoGame.Name = "labelInfoGame";
            this.labelInfoGame.Size = new System.Drawing.Size(146, 16);
            this.labelInfoGame.TabIndex = 5;
            this.labelInfoGame.Text = "Informacion del juego";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(360, 371);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(101, 38);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Atras";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DataGamingInterface.Properties.Resources.obsidian;
            this.pictureBox1.Image = global::DataGamingInterface.Properties.Resources.DataGamingInterfaceText;
            this.pictureBox1.Location = new System.Drawing.Point(268, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(524, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FormGameEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataGamingInterface.Properties.Resources.obsidian;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelInfoGame);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelSelectGameFromEdit);
            this.Controls.Add(this.ButtonAddNewGame);
            this.Controls.Add(this.ButtonEditGameAndSave);
            this.Controls.Add(this.checkedListBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGameEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGameEdit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button ButtonEditGameAndSave;
        private System.Windows.Forms.Button ButtonAddNewGame;
        private System.Windows.Forms.Label labelSelectGameFromEdit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelInfoGame;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}