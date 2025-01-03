using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Typing_game_recess
{
    public partial class TypingGameRecess : Form
    {
        private List<string> foodList = new List<string> { "burger", "fries", "hotdog" };
        private List<int> usedIndices = new List<int>();
        private List<string> imagePaths = new List<string>(); // List of image file paths
        private HashSet<string> guessedFoods = new HashSet<string>();
        private int timeLeft = 30; // Time for each round
        private int totalGameTime = 30 * 60; // 30 minutes in seconds
        private int score = 0; // Player's score
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer gameDurationTimer;
        private Random random = new Random();
        public TypingGameRecess()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void InitializeGame()
        {
            // Initialize the timer
            gameTimer = new System.Windows.Forms.Timer();
            gameTimer.Interval = 1000; // 1 second
            gameTimer.Tick += GameTimer_Tick;

            gameDurationTimer = new System.Windows.Forms.Timer();
            gameDurationTimer.Interval = 1000; // 1 second
            gameDurationTimer.Tick += GameDurationTimer_Tick;

            // Load images into the imagePaths list
            string imageDirectory = @"C:\Users\Administrator\source\repos\LSPU'dventure\LSPU'dventure\Food"; // Update this to the folder where your images are stored
            if (Directory.Exists(imageDirectory))
            {
                imagePaths = Directory.GetFiles(imageDirectory, "*.jpg").ToList();
            }

            lblTimeLeft.Text = $"Time Left: {timeLeft} seconds";
            lblScore.Text = $"Score: {score}";

            pictureBox.Visible = false;
            txtGuess.Enabled = false;
        }

        private void LoadRandomImage()
        {
            if (imagePaths.Count == 0)
            {
                MessageBox.Show("No images found in the specified directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int index;
            do
            {
                index = random.Next(imagePaths.Count);
            } while (usedIndices.Contains(index));

            usedIndices.Add(index);

            pictureBox.Image = Image.FromFile(imagePaths[index]);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Update the food list for the new image
            switch (index)
            {
                case 0:
                    foodList = new List<string> { "brocolli", "egg", "bacon" };
                    break;
                case 1:
                    foodList = new List<string> { "bacon", "bread", "egg", "cheese", "berries" };
                    break;
                case 2:
                    foodList = new List<string> { "chicken", "egg", "bread" };
                    break;
                case 3:
                    foodList = new List<string> { "burger", "fries", "hotdog" };
                    break;
                case 4:
                    foodList = new List<string> { "kwek kwek" };
                    break;
                case 5:
                    foodList = new List<string> { "taco" };
                    break;
                case 6:
                    foodList = new List<string> { "tomato", "egg", "avocado" };
                    break;
                default:
                    foodList = new List<string>(); // Fallback for unexpected cases
                    break;
            }
        }


        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                lblTimeLeft.Text = $"Time Left: {timeLeft} seconds";
            }
            else
            {
                gameTimer.Stop();
                txtGuess.Clear();
                MessageBox.Show("Time's up! Game over.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSubmit.Enabled = false;
                txtGuess.Enabled = false;
                btnStartGame.Enabled = true;
            }
        }

        private void GameDurationTimer_Tick(object sender, EventArgs e)
        {
            if (totalGameTime > 0)
            {
                totalGameTime--;
            }
            else
            {
                gameDurationTimer.Stop();
                gameTimer.Stop();
                MessageBox.Show($"Game Over! Your total score is: {score}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSubmit.Enabled = false;
                txtGuess.Enabled = false;
                btnStartGame.Enabled = true;
            }
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            timeLeft = 30; // Set the initial countdown time
            totalGameTime = 30 * 60;
            score = 0;
            lblTimeLeft.Text = $"Time Left: {timeLeft} seconds";
            lblScore.Text = $"Score: {score}";
            guessedFoods.Clear();
            lstGuessedFoods.Items.Clear();

            usedIndices.Clear(); // Reset used images

            pictureBox.Visible = true; // Ensure the pictureBox is visible

            gameTimer.Start(); // Start the timers
            gameDurationTimer.Start();

            btnSubmit.Enabled = true; // Enable submit button
            txtGuess.Enabled = true;
            btnStartGame.Enabled = false; // Disable start button

            LoadRandomImage(); // Load the first image
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string userGuess = txtGuess.Text.Trim().ToLower();

            // Normalize the food list for comparison
            List<string> normalizedFoodList = foodList.Select(food => food.Trim().ToLower()).ToList();

            if (normalizedFoodList.Contains(userGuess) && !guessedFoods.Contains(userGuess))
            {
                guessedFoods.Add(userGuess);
                lstGuessedFoods.Items.Add(userGuess);
                txtGuess.Clear();
                score += 10; // Add 10 points for a correct answer
                lblScore.Text = $"Score: {score}";

                if (guessedFoods.Count == foodList.Count)
                {
                    LoadRandomImage();
                    guessedFoods.Clear();
                    lstGuessedFoods.Items.Clear();
                }
            }
            else
            {
                MessageBox.Show("Incorrect guess or already guessed.", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGuess.Clear();
            }
        }



        private void FoodGuessGameForm_Load(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
        }
    }
}
