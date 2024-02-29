using ATMSimulator.ATMCustomerDBDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ATMSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\skyfl\OneDrive\Desktop\CIT1701\Final Project\ATMSimulator\ATMSimulator\ATMCustomerDB.mdf;Integrated Security=True;");
        public static string activeCardNum = "";

        private void loginButton_Click(object sender, EventArgs e)
        {
            errorProviderLogin.SetError(cardNumberTextBox, "");

            try
            {
                SqlCommand command = new SqlCommand("SELECT COUNT (*) FROM Cards" +
                " WHERE CardNumber = @cardNum AND PIN = @pin", conn);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@cardNum", cardNumberTextBox.Text);
                command.Parameters.AddWithValue("@pin", pinTextBox.Text);
                conn.Open();

                if (command.ExecuteScalar().ToString() == "1")
                {
                    activeCardNum = cardNumberTextBox.Text;
                    string mobileNum = "";
                    try
                    {
                        SqlCommand getMobileNumberCommand = new SqlCommand("SELECT Accounts.MobileNumber " +
                            " FROM Accounts INNER JOIN " +
                            " Cards ON Accounts.AccountID = Cards.AccountID " +
                            "WHERE (Cards.CardNumber = @CardNum)", conn);
                        getMobileNumberCommand.Parameters.Clear();
                        getMobileNumberCommand.Parameters.AddWithValue("@CardNum", activeCardNum);
                        mobileNum = (string)getMobileNumberCommand.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    string userTwoStepAuth = Interaction.InputBox("Please Enter Authentication Code Sent to" +
                        "\nMobile Number: " + mobileNum + "\n(XXXX)", "Two-Step Authentication");
                    if (userTwoStepAuth == "1111")
                    {
                        ATMMenu atmMenu = new ATMMenu();
                        atmMenu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Failed Two-Step Aithentication", "Failed");
                    }
                }
                else
                {
                    errorProviderLogin.SetError(cardNumberTextBox, "Card Number or PIN is Invalid");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
