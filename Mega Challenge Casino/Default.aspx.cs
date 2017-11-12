using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Mega_Challenge_Casino
{
    public partial class Default : System.Web.UI.Page
    {
        Random random = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState.Add("PlayersMoney", "100.0");
            string playersMoney = (string)ViewState["PlayersMoney"];


            if (!Page.IsPostBack)
            {
                playersMoneyLabel.Text = $"{playersMoney:C}";

                slotImage1.ImageUrl = "Images/" + spinReel() + ".png";
                slotImage2.ImageUrl = "Images/" + spinReel() + ".png";
                slotImage3.ImageUrl = "Images/" + spinReel() + ".png";
            }
        }

        protected void pullButton_Click(object sender, EventArgs e)
        {
            valueOfSpin(spinReel(), spinReel(), spinReel());
        }

        private void valueOfSpin(string reel1, string reel2, string reel3)
        {
            if(reel1 == "Bar" || reel2 == "Bar" || reel3 == "Bar")
            {
                calculateWinLoss("Bar");
                displaySpin(reel1, reel2, reel3);
            }
        }

        private void displaySpin(string reel1, string reel2, string reel3)
        {
            slotImage1.ImageUrl = "Images/" + reel1 + ".png";
            slotImage2.ImageUrl = "Images/" + reel2 + ".png";
            slotImage3.ImageUrl = "Images/" + reel3 + ".png";
        }

        private void calculateWinLoss(string pull)
        {
            if(pull == "Bar")
            {
                resultLabel.Text = $"Sorry you lost. Better luck next time.";
            }
            if(pull == "1Cherry")
            {
                resultLabel.Text = $"You bet ";
            }
        }

        Random rand = new Random();
        private string spinReel()
        {
            string[] images = new string[] { "Strawberry", "Bar", "Lemon", "Bell", "Clover", "Cherry", "Diamond", "Orange", "Seven", "HorseShoe", "Plum", "Watermelon" };
            return images[rand.Next(11)];
        }
    }
}