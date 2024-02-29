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
using System.Threading;

namespace ATMSimulator
{
    public partial class ATMMenu : Form
    {
        public ATMMenu()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\skyfl\OneDrive\Desktop\CIT1701\Final Project\ATMSimulator\ATMSimulator\ATMCustomerDB.mdf;Integrated Security=True;");
        string activeCardNum = "";

        private void GetSetAvailableCash(string cardNum)
        {
            try
            {
                SqlCommand cashCommand = new SqlCommand("SELECT AvailableCash FROM Cards" +
                " WHERE (CardNumber = @CardNum)", conn);
                cashCommand.Parameters.Clear();
                cashCommand.Parameters.AddWithValue("@CardNum", cardNum);
                conn.Open();

                if (cashCommand.ExecuteScalar() != null)
                {
                    decimal availableCash = (decimal)cashCommand.ExecuteScalar();
                    availableCashLabel.Text = availableCash.ToString("c");
                }
                else
                {
                    MessageBox.Show("Failed to get available cash balance.");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetSetTransactionHistory(string cardNum)
        {
            List<TransactionHistory> transHistoryList = new List<TransactionHistory>();
            transactionListBox.Items.Clear();
            try
            {
                SqlCommand transCommand = new SqlCommand("SELECT TOP (5) [Transaction], Date " +
                    " FROM  TransactionHistory " +
                    " WHERE (CardNumber = @CardNum) ORDER BY Date DESC", conn);
                transCommand.Parameters.Clear();
                transCommand.Parameters.AddWithValue("@CardNum", cardNum);
                conn.Open();

                SqlDataReader reader = transCommand.ExecuteReader();

                while (reader.Read())
                {
                    TransactionHistory transHistory = new TransactionHistory();
                    transHistory.CardNum = cardNum;
                    transHistory.Transaction = (decimal)reader[0];
                    transHistory.Date = (DateTime)reader[1];
                    transHistoryList.Add(transHistory);
                }

                foreach (TransactionHistory transaction in transHistoryList)
                {
                    string transString = transaction.Transaction.ToString("c") +
                        "\t" + transaction.Date.ToString();
                    transactionListBox.Items.Add(transString);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateAvailableCash(string cardNum)
        {
            try
            {
                SqlCommand getCashCommand = new SqlCommand("SELECT AvailableCash FROM Cards" +
                " WHERE (CardNumber = @CardNum)", conn);
                getCashCommand.Parameters.Clear();
                getCashCommand.Parameters.AddWithValue("@CardNum", cardNum);
                conn.Open();

                if (getCashCommand.ExecuteScalar() != null)
                {
                    decimal availableCash = (decimal)getCashCommand.ExecuteScalar();
                    decimal withdrawalCash = 0m;
                    if (decimal.TryParse(withdrawalCashTextBox.Text, out withdrawalCash))
                    {
                        if ((withdrawalCash <= 500.00m && withdrawalCash > 0m) && availableCash >= withdrawalCash)
                        {
                            errorProviderWithdrawal.Clear();
                            availableCash -= withdrawalCash;
                            try
                            {
                                SqlCommand updateCashCommand = new SqlCommand("UPDATE Cards " +
                                    "SET AvailableCash = @AvailableCash WHERE (CardNumber = @CardNum)", conn);
                                updateCashCommand.Parameters.Clear();
                                updateCashCommand.Parameters.AddWithValue("@CardNum", cardNum);
                                updateCashCommand.Parameters.AddWithValue("@AvailableCash", availableCash);
                                updateCashCommand.ExecuteNonQuery();
                                MessageBox.Show("Successfully Withdrew " + withdrawalCash.ToString("c") +
                                    "\nNew Balance is " + availableCash.ToString("c"), "Success");
                                InsertNewTransactionHistory(activeCardNum);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                        else
                        {
                            errorProviderWithdrawal.SetError(withdrawalCashTextBox, "Invalid Withdrawal Amount");
                        }
                    }
                    else
                    {
                        errorProviderWithdrawal.SetError(withdrawalCashTextBox, "Invalid Withdrawal Input");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to get available cash balance.");
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertNewTransactionHistory(string cardNum)
        {
            try
            {
                decimal transAmount;
                DateTime transDate;
                decimal.TryParse(withdrawalCashTextBox.Text, out transAmount);
                transDate = DateTime.Now;

                SqlCommand insertTransCommand = new SqlCommand("INSERT INTO [dbo].[TransactionHistory] " +
                    " ([Transaction], [Date], [CardNumber]) VALUES (@Transaction, @Date, @CardNum);", conn);
                insertTransCommand.Parameters.Clear();
                insertTransCommand.Parameters.AddWithValue("@Transaction", transAmount);
                insertTransCommand.Parameters.AddWithValue("@Date", transDate);
                insertTransCommand.Parameters.AddWithValue("@CardNum", cardNum);
                insertTransCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ATMMenu_Load(object sender, EventArgs e)
        {
            activeCardNum = Form1.activeCardNum;
            GetSetAvailableCash(activeCardNum);
            GetSetTransactionHistory(activeCardNum);
        }

        private void withdrawalButton_Click(object sender, EventArgs e)
        {
            UpdateAvailableCash(activeCardNum);
            GetSetAvailableCash(activeCardNum);
            GetSetTransactionHistory(activeCardNum);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
