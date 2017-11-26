using System;
using System.IO;   
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CardGameClasses;


namespace BlackJackGame
{
    public partial class Form1 : Form
    {
        public Deck myDeck = new Deck();
        public Hand playerHand = new Hand();
        public Hand dealerHand = new Hand();
        public int playerCardCount = 0;
        public int dealerCardCount = 0;
        public int playerScore = 0;
        public int dealerScore = 0;

        public Form1()
        {
            InitializeComponent();
            myDeck.Initialize();
            pbDealer1.ImageLocation = @"CardImages\redback.png";
            pbDealer2.ImageLocation = @"CardImages\redback.png";
            pbPlayer1.ImageLocation = @"CardImages\blueback.png";
            pbPlayer2.ImageLocation = @"CardImages\blueback.png";
        }

       

        private void btnHit_Click(object sender, EventArgs e)
        {
            try
            {
                // deal a card to player
                playerHand.Cards.Add(myDeck.GetCard());
                                
                playerScore = playerHand.CalculateTotal();
                
                // update score display
                txtPlayerScore.Text = playerScore.ToString();
                playerCardCount += 1;

                if (playerCardCount == 2)
                {
                    pbPlayer3.ImageLocation = playerHand.Cards[playerCardCount].Image;
                    pbPlayer3.Visible = true;
                }
                else if (playerCardCount == 3)
                {
                    pbPlayer4.ImageLocation = playerHand.Cards[playerCardCount].Image;
                    pbPlayer4.Visible = true;
                }
                else if (playerCardCount == 4)
                {
                    pbPlayer5.ImageLocation = playerHand.Cards[playerCardCount].Image;
                    pbPlayer5.Visible = true;
                    MessageBox.Show("Five Card Charlie!");
                    btnHit.Enabled = true;
                    btnStand.Enabled = true;
                    btnDeal.Enabled = false;
                    btnNewGame.Enabled = true;
                }
  

                // check if less than or equal to 21
                if (playerScore == 21)
                {
                    txtPlayerScore.BackColor = Color.LightCyan;
                }
                else if (playerScore > 21)
                {
                    txtPlayerScore.BackColor = Color.Red;
                    MessageBox.Show("Busted!");
                    btnHit.Enabled = true;
                    btnStand.Enabled = true;
                    btnDeal.Enabled = false;
                    btnNewGame.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            try
            {

                // disable Player buttons while Dealer is playing hand
                btnStand.Enabled = false;
                btnHit.Enabled = false;
                
                // reveal Dealer's hidden card and update score
                pbDealer2.Visible = true;
                pbDealer2.ImageLocation = dealerHand.Cards[dealerCardCount].Image;
                txtDealerScore.Text = dealerScore.ToString();
                dealerScore = dealerHand.dealerPlays();

                if (dealerScore > 16)
                {
                    checkScores();
                }
                
                while (dealerScore <= 16)
                {
                    // deal a card to player
                    dealerHand.Cards.Add(myDeck.GetCard());

                    dealerScore = dealerHand.dealerPlays();
                    txtDealerScore.Text = dealerScore.ToString();
                    dealerCardCount += 1;

                    if ((dealerCardCount) == 2)
                    {
                        pbDealer3.Visible = true;
                        pbDealer3.ImageLocation = dealerHand.Cards[dealerCardCount].Image;
                    }
                    else if ((dealerCardCount) == 3)
                    {
                        pbDealer4.Visible = true;
                        pbDealer4.ImageLocation = dealerHand.Cards[dealerCardCount].Image;
                    }
                    else if ((dealerCardCount == 4))
                    {
                        pbDealer5.Visible = true;
                        pbDealer5.ImageLocation = dealerHand.Cards[dealerCardCount].Image;
                    }
                    else
                    {
                        checkScores();
                    }
                }

                checkScores();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

       
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
           NewGame();
        }

        public void NewGame()
        {
            try
            {
                // reshuffle deck
                myDeck.Initialize();

                // reset score counters to 0
                txtDealerScore.Text = "0";
                txtPlayerScore.Text = "0";
                txtPlayerScore.BackColor = Color.White;

                // clear scores of player and dealer
                playerHand.Cards.Clear();
                dealerHand.Cards.Clear();
                playerScore = 0;
                dealerScore = 0;

                // make Hit and Stand Buttons available
                // disable Deal button while game is on
                btnHit.Enabled = true;
                btnStand.Enabled = true;
                btnDeal.Enabled = false;

                pbPlayer3.Visible = false;
                pbPlayer4.Visible = false;
                pbPlayer5.Visible = false;

                pbDealer3.Visible = false;
                pbDealer4.Visible = false;
                pbDealer5.Visible = false;

                // deal initial cards
                playerHand.Cards.Add(myDeck.GetCard());
                pbPlayer1.ImageLocation = playerHand.Cards[0].Image;

                dealerHand.Cards.Add(myDeck.GetCard());
                pbDealer1.ImageLocation = dealerHand.Cards[0].Image;

                playerHand.Cards.Add(myDeck.GetCard());
                pbPlayer2.ImageLocation = playerHand.Cards[1].Image;

                // do not show the Dealer's 2nd card
                dealerHand.Cards.Add(myDeck.GetCard());
                pbDealer2.ImageLocation = @"CardImages\blueback.png";

                playerCardCount = 1;
                dealerCardCount = 1;

                // update Player score
                playerScore = playerHand.CalculateTotal();
                txtPlayerScore.Text = playerScore.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // start a new game
            NewGame();
        }

        public void checkScores()
        {
            try
            {
                if (dealerScore > 21)
                {
                    MessageBox.Show("Dealer Busts, Player Wins!");
                    btnHit.Enabled = false;
                    btnStand.Enabled = false;
                    btnDeal.Enabled = true;
                    btnNewGame.Enabled = true;
                }
                else if (dealerScore == playerScore)
                {
                    MessageBox.Show("Push!");
                    btnHit.Enabled = false;
                    btnStand.Enabled = false;
                    btnDeal.Enabled = true;
                    btnNewGame.Enabled = true;
                }
                else if (dealerScore > playerScore)
                {
                    MessageBox.Show("Dealer Wins :(");
                    btnHit.Enabled = false;
                    btnStand.Enabled = false;
                    btnDeal.Enabled = true;
                    btnNewGame.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Player Wins! :):)");
                    btnHit.Enabled = false;
                    btnStand.Enabled = false;
                    btnDeal.Enabled = true;
                    btnNewGame.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
    }
}
