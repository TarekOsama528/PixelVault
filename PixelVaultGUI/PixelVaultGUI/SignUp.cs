﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixelVaultGUI
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void GamerButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamerSignUp signUp = new GamerSignUp();
            signUp.ShowDialog();
            //this.Show();
        }

        private void GamePublisherButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GamePublisherSignUp signUp = new GamePublisherSignUp();
            signUp.ShowDialog();
            //this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void GameStoreButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StoreSignUp signUp = new StoreSignUp();
            signUp.ShowDialog();
        }
    }
}
