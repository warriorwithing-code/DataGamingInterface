using static System.Windows.Forms.CheckedListBox;
using DataGamingInterface.Process;

namespace DataGamingInterface.Forms
{
    partial class SelectGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        ObjectCollection items;
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
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonSearchGame = new System.Windows.Forms.Button();
            this.CheckedListBoxGamesPrepared = new System.Windows.Forms.CheckedListBox();
            this.textBoxShowGame = new System.Windows.Forms.TextBox();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBoxSelectGame
            // 
            this.checkedListBoxSelectGame.FormattingEnabled = true;
            this.checkedListBoxSelectGame.Location = new System.Drawing.Point(29, 21);
            this.checkedListBoxSelectGame.Name = "checkedListBoxSelectGame";
            this.checkedListBoxSelectGame.Size = new System.Drawing.Size(199, 364);
            this.checkedListBoxSelectGame.TabIndex = 0;
            this.checkedListBoxSelectGame.SelectedIndexChanged += new System.EventHandler(this.CheckedListBoxSelectGame_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(377, 133);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 31);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Añadir Juego";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(357, 40);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(164, 20);
            this.textBoxResult.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matrix", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escriba el juego que desee añadir y genero\r\n";
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
            this.textBoxShowGame.Location = new System.Drawing.Point(357, 230);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(376, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Matrix", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Añada un genero";
            // 
            // SelectGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataGamingInterface.Properties.Resources.external_content_duckduckgo_com;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonRoll);
            this.Controls.Add(this.textBoxShowGame);
            this.Controls.Add(this.CheckedListBoxGamesPrepared);
            this.Controls.Add(this.buttonSearchGame);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.checkedListBoxSelectGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RellenarItems()
        {
            items = new ObjectCollection(checkedListBoxSelectGame);
            foreach (var game in checkListOperations.addItemList())
            {
                this.checkedListBoxSelectGame.Items.Add(game);
            };
        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxSelectGame;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonSearchGame;
        private System.Windows.Forms.CheckedListBox CheckedListBoxGamesPrepared;
        private System.Windows.Forms.TextBox textBoxShowGame;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}