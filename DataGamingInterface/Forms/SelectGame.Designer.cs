using DataGamingInterface.Process;
using Aplication.Dto;
using System.Collections.Generic;

namespace DataGamingInterface.Forms
{
    partial class SelectGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        CheckBoxListOperations checkListOperations = new CheckBoxListOperations();

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectGame));
            this.checkedListBoxSelectGame = new System.Windows.Forms.CheckedListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSearchGame = new System.Windows.Forms.Button();
            this.CheckedListBoxGamesPrepared = new System.Windows.Forms.CheckedListBox();
            this.textBoxShowGame = new System.Windows.Forms.TextBox();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelGameResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBoxSelectGame
            // 
            this.checkedListBoxSelectGame.FormattingEnabled = true;
            this.checkedListBoxSelectGame.Location = new System.Drawing.Point(29, 66);
            this.checkedListBoxSelectGame.Name = "checkedListBoxSelectGame";
            this.checkedListBoxSelectGame.Size = new System.Drawing.Size(199, 319);
            this.checkedListBoxSelectGame.TabIndex = 0;
            this.checkedListBoxSelectGame.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxSelectGame_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(376, 96);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 31);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Añadir Juego";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(29, 405);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Actualizar Juego";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // buttonSearchGame
            // 
            this.buttonSearchGame.Location = new System.Drawing.Point(139, 405);
            this.buttonSearchGame.Name = "buttonSearchGame";
            this.buttonSearchGame.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchGame.TabIndex = 5;
            this.buttonSearchGame.Text = "Buscar Juego";
            this.buttonSearchGame.UseVisualStyleBackColor = true;
            this.buttonSearchGame.Click += new System.EventHandler(this.ButtonSearchGame_Click);
            // 
            // CheckedListBoxGamesPrepared
            // 
            this.CheckedListBoxGamesPrepared.FormattingEnabled = true;
            this.CheckedListBoxGamesPrepared.Location = new System.Drawing.Point(631, 216);
            this.CheckedListBoxGamesPrepared.Name = "CheckedListBoxGamesPrepared";
            this.CheckedListBoxGamesPrepared.Size = new System.Drawing.Size(157, 169);
            this.CheckedListBoxGamesPrepared.TabIndex = 6;
            this.CheckedListBoxGamesPrepared.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxGamesPrepared_SelectedIndexChanged);
            // 
            // textBoxShowGame
            // 
            this.textBoxShowGame.Location = new System.Drawing.Point(360, 203);
            this.textBoxShowGame.Name = "textBoxShowGame";
            this.textBoxShowGame.Size = new System.Drawing.Size(164, 20);
            this.textBoxShowGame.TabIndex = 7;
            // 
            // buttonRoll
            // 
            this.buttonRoll.Location = new System.Drawing.Point(376, 300);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(120, 44);
            this.buttonRoll.TabIndex = 8;
            this.buttonRoll.Text = "Roll";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.ButtonRoll_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(673, 405);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(398, 405);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 10;
            this.Back.Text = "Atras";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DataGamingInterface.Properties.Resources.obsidian;
            this.pictureBox1.Image = global::DataGamingInterface.Properties.Resources.DataGamingInterfaceText;
            this.pictureBox1.Location = new System.Drawing.Point(258, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(624, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Juegos preparados para roll";
            // 
            // labelGameResult
            // 
            this.labelGameResult.AutoSize = true;
            this.labelGameResult.Location = new System.Drawing.Point(395, 171);
            this.labelGameResult.Name = "labelGameResult";
            this.labelGameResult.Size = new System.Drawing.Size(87, 13);
            this.labelGameResult.TabIndex = 13;
            this.labelGameResult.Text = "Resultado Juego";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matrix", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Lista de juegos";
            // 
            // SelectGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataGamingInterface.Properties.Resources.obsidian;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelGameResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRoll);
            this.Controls.Add(this.textBoxShowGame);
            this.Controls.Add(this.CheckedListBoxGamesPrepared);
            this.Controls.Add(this.buttonSearchGame);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkedListBoxSelectGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectGame";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void GetListGames()
        {
            listGamesDto = new List<GameDto>();
            foreach (var x in processInterface.Get_ListGames())
            {
                listGamesDto.Add(x);
                this.checkedListBoxSelectGame.Items.Add(x.Name);
            }
        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxSelectGame;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSearchGame;
        private System.Windows.Forms.CheckedListBox CheckedListBoxGamesPrepared;
        private System.Windows.Forms.TextBox textBoxShowGame;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGameResult;
        private System.Windows.Forms.Label label2;
    }
}