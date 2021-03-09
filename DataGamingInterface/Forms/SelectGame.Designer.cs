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
            this.checkedListBoxSelectGame = new System.Windows.Forms.CheckedListBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
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
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(317, 354);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(120, 31);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Tirar dado";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // textBox1
            // 
            this.textBoxResult.Location = new System.Drawing.Point(300, 194);
            this.textBoxResult.Name = "textBox1";
            this.textBoxResult.Size = new System.Drawing.Size(157, 20);
            this.textBoxResult.TabIndex = 2;
            // 
            // SelectGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.checkedListBoxSelectGame);
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
                items.Add(game);
            };
        }
        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxSelectGame;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}