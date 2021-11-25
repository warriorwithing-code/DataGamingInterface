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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.buttonSelectGame = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonGameEdit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelectGame
            // 
            this.buttonSelectGame.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelectGame.BackgroundImage = global::DataGamingInterface.Properties.Resources.shield2_preview_rev_1;
            this.buttonSelectGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonSelectGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectGame.Location = new System.Drawing.Point(309, 154);
            this.buttonSelectGame.Name = "buttonSelectGame";
            this.buttonSelectGame.Size = new System.Drawing.Size(201, 205);
            this.buttonSelectGame.TabIndex = 0;
            this.buttonSelectGame.Text = "Seleccionar Juego";
            this.buttonSelectGame.UseVisualStyleBackColor = false;
            this.buttonSelectGame.Click += new System.EventHandler(this.ButtonSelectGame_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::DataGamingInterface.Properties.Resources.shield2_preview_rev_1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(565, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 205);
            this.button1.TabIndex = 1;
            this.button1.Text = "Feature(Not Function)";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonGameEdit
            // 
            this.buttonGameEdit.BackColor = System.Drawing.Color.Transparent;
            this.buttonGameEdit.BackgroundImage = global::DataGamingInterface.Properties.Resources.shield2_preview_rev_1;
            this.buttonGameEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonGameEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGameEdit.ForeColor = System.Drawing.Color.Black;
            this.buttonGameEdit.Location = new System.Drawing.Point(46, 149);
            this.buttonGameEdit.Name = "buttonGameEdit";
            this.buttonGameEdit.Size = new System.Drawing.Size(201, 215);
            this.buttonGameEdit.TabIndex = 2;
            this.buttonGameEdit.Text = "Recursos de juego";
            this.buttonGameEdit.UseVisualStyleBackColor = false;
            this.buttonGameEdit.Click += new System.EventHandler(this.ButtonGameEdit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DataGamingInterface.Properties.Resources.obsidian;
            this.pictureBox1.Image = global::DataGamingInterface.Properties.Resources.DataGamingInterfaceText;
            this.pictureBox1.Location = new System.Drawing.Point(73, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DataGamingInterface.Properties.Resources.obsidian;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGameEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSelectGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectGame;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonGameEdit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}