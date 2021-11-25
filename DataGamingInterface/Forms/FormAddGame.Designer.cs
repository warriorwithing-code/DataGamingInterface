using Aplication.Dto;
using System.Collections.Generic;

namespace DataGamingInterface.Forms
{
    partial class FormAddGame
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
            this.labelAddGender = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonAddGame = new System.Windows.Forms.Button();
            this.buttonAddGender = new System.Windows.Forms.Button();
            this.textBoxAddGame = new System.Windows.Forms.TextBox();
            this.textBoxAddGender = new System.Windows.Forms.TextBox();
            this.comboBoxSelectGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxDTGI = new System.Windows.Forms.PictureBox();
            this.LabelErrorGender = new System.Windows.Forms.Label();
            this.labelErrorAddGender = new System.Windows.Forms.Label();
            this.buttonDeleteGame = new System.Windows.Forms.Button();
            this.buttonDelteGender = new System.Windows.Forms.Button();
            this.comboBoxDeleteGame = new System.Windows.Forms.ComboBox();
            this.comboBoxDeleteGender = new System.Windows.Forms.ComboBox();
            this.labelCorrectSave = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDTGI)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAddGender
            // 
            this.labelAddGender.AutoSize = true;
            this.labelAddGender.Location = new System.Drawing.Point(309, 79);
            this.labelAddGender.Name = "labelAddGender";
            this.labelAddGender.Size = new System.Drawing.Size(91, 13);
            this.labelAddGender.TabIndex = 0;
            this.labelAddGender.Text = "Añada un Genero";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(3, 279);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Cerrar";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // buttonAddGame
            // 
            this.buttonAddGame.Location = new System.Drawing.Point(167, 238);
            this.buttonAddGame.Name = "buttonAddGame";
            this.buttonAddGame.Size = new System.Drawing.Size(75, 23);
            this.buttonAddGame.TabIndex = 2;
            this.buttonAddGame.Text = "Añadir Juego";
            this.buttonAddGame.UseVisualStyleBackColor = true;
            this.buttonAddGame.Click += new System.EventHandler(this.ButtonAddGame_Click);
            // 
            // buttonAddGender
            // 
            this.buttonAddGender.Location = new System.Drawing.Point(325, 238);
            this.buttonAddGender.Name = "buttonAddGender";
            this.buttonAddGender.Size = new System.Drawing.Size(75, 23);
            this.buttonAddGender.TabIndex = 3;
            this.buttonAddGender.Text = "Añadir Genero";
            this.buttonAddGender.UseVisualStyleBackColor = true;
            this.buttonAddGender.Click += new System.EventHandler(this.ButtonAddGender_Click);
            // 
            // textBoxAddGame
            // 
            this.textBoxAddGame.Location = new System.Drawing.Point(148, 106);
            this.textBoxAddGame.Name = "textBoxAddGame";
            this.textBoxAddGame.Size = new System.Drawing.Size(121, 20);
            this.textBoxAddGame.TabIndex = 4;
            this.textBoxAddGame.Text = "Introduzca nombre";
            this.textBoxAddGame.Click += new System.EventHandler(this.TextBoxAddGame_Click);
            // 
            // textBoxAddGender
            // 
            this.textBoxAddGender.Location = new System.Drawing.Point(300, 130);
            this.textBoxAddGender.Name = "textBoxAddGender";
            this.textBoxAddGender.Size = new System.Drawing.Size(114, 20);
            this.textBoxAddGender.TabIndex = 5;
            this.textBoxAddGender.Text = "Introduzca Genero";
            this.textBoxAddGender.Click += new System.EventHandler(this.TextBoxAddGender_Click);
            // 
            // comboBoxSelectGender
            // 
            this.comboBoxSelectGender.FormattingEnabled = true;
            this.comboBoxSelectGender.Location = new System.Drawing.Point(148, 152);
            this.comboBoxSelectGender.Name = "comboBoxSelectGender";
            this.comboBoxSelectGender.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectGender.TabIndex = 6;
            this.comboBoxSelectGender.Text = "Seleccione genero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Añada un juego";
            // 
            // pictureBoxDTGI
            // 
            this.pictureBoxDTGI.BackgroundImage = global::DataGamingInterface.Properties.Resources.obsidian;
            this.pictureBoxDTGI.Image = global::DataGamingInterface.Properties.Resources.DataGamingInterfaceText;
            this.pictureBoxDTGI.Location = new System.Drawing.Point(26, 12);
            this.pictureBoxDTGI.Name = "pictureBoxDTGI";
            this.pictureBoxDTGI.Size = new System.Drawing.Size(374, 50);
            this.pictureBoxDTGI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDTGI.TabIndex = 8;
            this.pictureBoxDTGI.TabStop = false;
            // 
            // LabelErrorGender
            // 
            this.LabelErrorGender.AutoSize = true;
            this.LabelErrorGender.BackColor = System.Drawing.Color.Transparent;
            this.LabelErrorGender.Font = new System.Drawing.Font("Matrix", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelErrorGender.ForeColor = System.Drawing.Color.Red;
            this.LabelErrorGender.Location = new System.Drawing.Point(145, 202);
            this.LabelErrorGender.Name = "LabelErrorGender";
            this.LabelErrorGender.Size = new System.Drawing.Size(128, 14);
            this.LabelErrorGender.TabIndex = 9;
            this.LabelErrorGender.Text = "Introduzca un Genero";
            this.LabelErrorGender.Visible = false;
            // 
            // labelErrorAddGender
            // 
            this.labelErrorAddGender.AutoSize = true;
            this.labelErrorAddGender.BackColor = System.Drawing.Color.Transparent;
            this.labelErrorAddGender.Font = new System.Drawing.Font("Matrix", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorAddGender.ForeColor = System.Drawing.Color.Red;
            this.labelErrorAddGender.Location = new System.Drawing.Point(305, 202);
            this.labelErrorAddGender.Name = "labelErrorAddGender";
            this.labelErrorAddGender.Size = new System.Drawing.Size(109, 14);
            this.labelErrorAddGender.TabIndex = 10;
            this.labelErrorAddGender.Text = "Escriba un Genero";
            this.labelErrorAddGender.Visible = false;
            // 
            // buttonDeleteGame
            // 
            this.buttonDeleteGame.Location = new System.Drawing.Point(36, 139);
            this.buttonDeleteGame.Name = "buttonDeleteGame";
            this.buttonDeleteGame.Size = new System.Drawing.Size(75, 34);
            this.buttonDeleteGame.TabIndex = 11;
            this.buttonDeleteGame.Text = "Eliminar Juego";
            this.buttonDeleteGame.UseVisualStyleBackColor = true;
            this.buttonDeleteGame.Click += new System.EventHandler(this.ButtonDeleteGame_Click);
            // 
            // buttonDelteGender
            // 
            this.buttonDelteGender.Location = new System.Drawing.Point(36, 226);
            this.buttonDelteGender.Name = "buttonDelteGender";
            this.buttonDelteGender.Size = new System.Drawing.Size(75, 35);
            this.buttonDelteGender.TabIndex = 12;
            this.buttonDelteGender.Text = "Eliminar Genero";
            this.buttonDelteGender.UseVisualStyleBackColor = true;
            this.buttonDelteGender.Click += new System.EventHandler(this.ButtonDeleteGender_Click);
            // 
            // comboBoxDeleteGame
            // 
            this.comboBoxDeleteGame.FormattingEnabled = true;
            this.comboBoxDeleteGame.Location = new System.Drawing.Point(12, 106);
            this.comboBoxDeleteGame.Name = "comboBoxDeleteGame";
            this.comboBoxDeleteGame.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeleteGame.TabIndex = 13;
            this.comboBoxDeleteGame.Text = "Seleccione juego";
            // 
            // comboBoxDeleteGender
            // 
            this.comboBoxDeleteGender.FormattingEnabled = true;
            this.comboBoxDeleteGender.Location = new System.Drawing.Point(12, 195);
            this.comboBoxDeleteGender.Name = "comboBoxDeleteGender";
            this.comboBoxDeleteGender.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDeleteGender.TabIndex = 14;
            this.comboBoxDeleteGender.Text = "Seleccione Genero";
            // 
            // labelCorrectSave
            // 
            this.labelCorrectSave.AutoSize = true;
            this.labelCorrectSave.BackColor = System.Drawing.Color.Transparent;
            this.labelCorrectSave.Font = new System.Drawing.Font("Matrix", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrectSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelCorrectSave.Location = new System.Drawing.Point(133, 180);
            this.labelCorrectSave.Name = "labelCorrectSave";
            this.labelCorrectSave.Size = new System.Drawing.Size(154, 12);
            this.labelCorrectSave.TabIndex = 15;
            this.labelCorrectSave.Text = "Se a guardado correctamente";
            this.labelCorrectSave.Visible = false;
            // 
            // FormAddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataGamingInterface.Properties.Resources.obsidian;
            this.ClientSize = new System.Drawing.Size(426, 314);
            this.Controls.Add(this.labelCorrectSave);
            this.Controls.Add(this.comboBoxDeleteGender);
            this.Controls.Add(this.comboBoxDeleteGame);
            this.Controls.Add(this.buttonDelteGender);
            this.Controls.Add(this.buttonDeleteGame);
            this.Controls.Add(this.labelErrorAddGender);
            this.Controls.Add(this.LabelErrorGender);
            this.Controls.Add(this.pictureBoxDTGI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSelectGender);
            this.Controls.Add(this.textBoxAddGender);
            this.Controls.Add(this.textBoxAddGame);
            this.Controls.Add(this.buttonAddGender);
            this.Controls.Add(this.buttonAddGame);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelAddGender);
            this.Name = "FormAddGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddGame";
            this.Load += new System.EventHandler(this.FormAddGame_Load);
            this.Click += new System.EventHandler(this.FormAddGame_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDTGI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    #endregion

    private System.Windows.Forms.Label labelAddGender;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonAddGame;
        private System.Windows.Forms.Button buttonAddGender;
        private System.Windows.Forms.TextBox textBoxAddGame;
        private System.Windows.Forms.TextBox textBoxAddGender;
        private System.Windows.Forms.ComboBox comboBoxSelectGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxDTGI;
        private System.Windows.Forms.Label LabelErrorGender;
        private System.Windows.Forms.Label labelErrorAddGender;
        private System.Windows.Forms.Button buttonDeleteGame;
        private System.Windows.Forms.Button buttonDelteGender;
        private System.Windows.Forms.ComboBox comboBoxDeleteGame;
        private System.Windows.Forms.ComboBox comboBoxDeleteGender;
        private System.Windows.Forms.Label labelCorrectSave;
    }
}