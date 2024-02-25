using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace БлэкДжек_со_шлюхами
{
    public partial class Form1 : Form
    {
        private int userCount = 0;
        private int dealerCount = 0;
        private Random rand = new Random();
        private int wins = 0;
        private int losses = 0;
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int additionalCard = rand.Next(2, 11);
            userCount += additionalCard;
            lblUserPoints.Text = "Your points: " + userCount.ToString();

            if ((userCount >= 21) || (dealerCount > 21))
            {
                // Пользователь набрал 21 или больше
                EndGame();
            }
            else
            {
                // Ход дилера
                DealerLogic();
            }

        }
        private List<int> dealerCards = new List<int>(); // Хранение карт дилера
        private void Form1_Load(object sender, EventArgs e)
        {
            // Начальная инициализация счетчиков
            userCount += rand.Next(2, 11);
            userCount += rand.Next(2, 11);
            dealerCards.Add(rand.Next(2, 11)); // Открытая карта дилера
            lblDealerPoints.Text = "Dealer's open card: " + dealerCards[0].ToString();

            // Отображение начальных очков
            lblUserPoints.Text = "Your points: " + userCount.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EndGame();
        }


        private void EndGame()
        {
            // Определение результата игры и вывод сообщения
            if ((dealerCount > userCount && dealerCount <= 21) || userCount > 21)
            {
                losses++;
                MessageBox.Show("You lose, sucker! Dealer's points: " + dealerCount);
            }
            else
            {
                wins++;
                MessageBox.Show("You've won this time. Dealer's points: " + dealerCount);
            }

            // Отображение счетчиков побед и поражений
            lblWins.Text = "Wins: " + wins.ToString();
            lblLosses.Text = "Losses: " + losses.ToString();

            // Сброс игры
            ResetGame();
            DealerLogic();
        }

        private void ResetGame()
        {
            // Сброс счетчиков и отображения
            userCount = 0;
            dealerCount = 0;
            dealerCards.Clear();
            lblUserPoints.Text = "Your points: 0";
            lblDealerPoints.Text = "Dealer's open card: 0";

            // Дилер продолжает брать карты
            DealerLogic();

        }

        private void DealerLogic()
        {
            while (true)
            {
                if (dealerCount < 16)
                {
                    dealerCount += rand.Next(2, 11);
                    MessageBox.Show("The dealer took the card");

                }
                else break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
