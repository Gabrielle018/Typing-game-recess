namespace Typing_game_recess
{
    partial class TypingGameRecess
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.ListBox lstGuessedFoods;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypingGameRecess));
            pictureBox = new PictureBox();
            lblTimeLeft = new Label();
            lblScore = new Label();
            txtGuess = new TextBox();
            btnSubmit = new Button();
            btnStartGame = new Button();
            lstGuessedFoods = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Location = new Point(432, 12);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(445, 278);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // lblTimeLeft
            // 
            lblTimeLeft.AutoSize = true;
            lblTimeLeft.BackColor = Color.Transparent;
            lblTimeLeft.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblTimeLeft.Location = new Point(501, 309);
            lblTimeLeft.Name = "lblTimeLeft";
            lblTimeLeft.Size = new Size(81, 17);
            lblTimeLeft.TabIndex = 1;
            lblTimeLeft.Text = "Time left: ";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.BackColor = Color.Transparent;
            lblScore.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            lblScore.Location = new Point(711, 309);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(69, 17);
            lblScore.TabIndex = 6;
            lblScore.Text = "Score: 0";
            // 
            // txtGuess
            // 
            txtGuess.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtGuess.Location = new Point(432, 346);
            txtGuess.Multiline = true;
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(445, 33);
            txtGuess.TabIndex = 2;
            txtGuess.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.DarkCyan;
            btnSubmit.FlatAppearance.BorderColor = Color.Teal;
            btnSubmit.FlatAppearance.BorderSize = 5;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(482, 400);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(122, 42);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit Guess";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnStartGame
            // 
            btnStartGame.BackColor = Color.DarkCyan;
            btnStartGame.FlatAppearance.BorderColor = Color.Teal;
            btnStartGame.FlatAppearance.BorderSize = 5;
            btnStartGame.FlatStyle = FlatStyle.Flat;
            btnStartGame.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStartGame.ForeColor = Color.White;
            btnStartGame.Location = new Point(682, 400);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(122, 42);
            btnStartGame.TabIndex = 4;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = false;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // lstGuessedFoods
            // 
            lstGuessedFoods.BackColor = Color.LemonChiffon;
            lstGuessedFoods.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstGuessedFoods.FormattingEnabled = true;
            lstGuessedFoods.ItemHeight = 22;
            lstGuessedFoods.Location = new Point(482, 466);
            lstGuessedFoods.Name = "lstGuessedFoods";
            lstGuessedFoods.Size = new Size(322, 114);
            lstGuessedFoods.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1284, 661);
            Controls.Add(lstGuessedFoods);
            Controls.Add(lblScore);
            Controls.Add(btnStartGame);
            Controls.Add(btnSubmit);
            Controls.Add(txtGuess);
            Controls.Add(lblTimeLeft);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Guess the Food Game";
            Load += FoodGuessGameForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
