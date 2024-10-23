using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeekHomework.Accounts
{
    public class Accounts
    {
        public int accountNumber { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        private int balance;

        public int Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Balance is not suitable for requested value!");
                }
                else
                balance = value;
            }
        }
        public string eMail { get; set; }

        public void ShowBalance()
        {
            Console.WriteLine($"Account Number: {accountNumber},Your Account Balance: {balance}$");
        }
        public void SendMoney(int accountNumSend,int count,Users users)
        {
            if (count > 0 && count <= balance)
            { Accounts targetAccount = users.accountsList.FirstOrDefault(a => a.accountNumber == accountNumSend);
                balance -= count;
                targetAccount.balance += count;
                Console.WriteLine($"{count}$ was sent to account number {accountNumSend}. Your new balance is: {balance}$");
            }
            else
                Console.WriteLine("Your Balance is not suitable for requested value");
           
        }
        public void WithdrawalMoney(int count)
        {
            if(count <= balance)
            {
                balance -= count;
                Console.WriteLine($"You Withdrawal {count}$ Your current balance is :{balance}$ ");
            }
            else
                Console.WriteLine("You dont have enough money!");     
        }
        public void DepositMoney(int count)
        {
            balance += count;
            Console.WriteLine($"You Deposited {count}$ Your current balance is :{balance}$");
        }
        public void SendAccountReceipt(Accounts account)
        {
            string senderEmail = "smtpmailsender11@gmail.com";
            string password = "zzgq xmpz tvie ibhh";
            string receiverEmail = account.eMail;
            string subject = "Account Balance Statement (****** Bank)";

            string body = $"Account Number: {account.accountNumber}\n" +
                          $"User Name: {account.userName}\n" +
                          $"Balance: {account.Balance:C}"; 

            string smtpServer = "smtp.gmail.com";
            int port = 587;

            try
            {
                using (SmtpClient client = new SmtpClient(smtpServer, port))
                {
                    client.EnableSsl = true; 
                    client.Credentials = new NetworkCredential(senderEmail, password);

                    MailMessage mail = new MailMessage(senderEmail, receiverEmail, subject, body);
                    client.Send(mail);
                    Console.WriteLine("E-mail sent successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Problem while e-mail sent: " + ex.Message);
            }
        }
    }
}
