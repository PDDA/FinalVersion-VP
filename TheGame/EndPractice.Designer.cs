namespace TheGame
{
    partial class EndPractice
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
            this.backToMenu = new System.Windows.Forms.Label();
            this.finishMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backToMenu
            // 
            this.backToMenu.AutoSize = true;
            this.backToMenu.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToMenu.Location = new System.Drawing.Point(130, 278);
            this.backToMenu.Name = "backToMenu";
            this.backToMenu.Size = new System.Drawing.Size(120, 30);
            this.backToMenu.TabIndex = 5;
            this.backToMenu.Text = "Main menu";
            this.backToMenu.Click += new System.EventHandler(this.backToMenu_Click);
            this.backToMenu.MouseEnter += new System.EventHandler(this.backToMenu_MouseEnter);
            this.backToMenu.MouseLeave += new System.EventHandler(this.backToMenu_MouseLeave);
            // 
            // finishMessage
            // 
            this.finishMessage.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finishMessage.Location = new System.Drawing.Point(27, 183);
            this.finishMessage.Name = "finishMessage";
            this.finishMessage.Size = new System.Drawing.Size(348, 81);
            this.finishMessage.TabIndex = 3;
            this.finishMessage.Text = "Congratulations, you passed the practice part. Let\'s try the game.";
            this.finishMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TheGame.Properties.Resources.snorlax;
            this.pictureBox1.Location = new System.Drawing.Point(119, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 134);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // EndPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 341);
            this.Controls.Add(this.backToMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.finishMessage);
            this.Name = "EndPractice";
            this.Text = "EndPractice";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label backToMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label finishMessage;
    }
}