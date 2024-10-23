//ÖDEV ÖDEV ÖDEV ÖDEV  bİR BANKA SİSTEMİ YAPILACAK 1 BAKİYE LİSTELE,2PARA GÖNDERME,3PARA ÇEKME,4PARA YATIRMA,BİR DEKONT MAİLİ GÖNDERME
using FirstWeekHomework.Accounts;

int withdrawalCount;
int depositeCount;
int targetAccount;
bool accountFound = false;
byte wantedNumber;
Users users = new Users();
Accounts whichAccount = null;

Console.WriteLine("Welcome The ****** Bank!");
Console.WriteLine("Please enter your account number!");

while (accountFound != true)
{
    int accountNum = int.Parse(Console.ReadLine());
    whichAccount = users.accountsList.FirstOrDefault(a => a.accountNumber == accountNum);
    if (whichAccount != null)
    {
        accountFound = true;
        Console.WriteLine("Please Select what action you want to take \n (Please Enter A Number) \n 1)Show Balance \n 2)Send Money \n 3)Withdrawal Money \n 4)Deposit Money \n 5)Send Receipt to E-Mail");
        while (!byte.TryParse(Console.ReadLine(), out wantedNumber) || wantedNumber! < 1 || wantedNumber! > 5 || Convert.ToString(wantedNumber).StartsWith("0"))
        {
            Console.WriteLine("Your choose is wrong, try again!");
        }
        switch (wantedNumber)
        {
            case 1:
                whichAccount.ShowBalance();
                //Console.WriteLine("Press 'E' for return main menu.");
                //if (Console.ReadLine()=="e"||Console.ReadLine()=="E")
                //{
                //}
                break;
            case 2:
                Console.WriteLine("Enter the account number to send money:");
                if (int.TryParse(Console.ReadLine(), out int accountNumSend))
                {
                    Console.WriteLine("Enter the amount you want to send:");
                    if (int.TryParse(Console.ReadLine(), out int amountToSend))
                    {
                        whichAccount.SendMoney(accountNumSend, amountToSend, users);
                    }
                    else
                        Console.WriteLine("Entered amount incorrect!");
                }
                else
                    Console.WriteLine("Entered account number not found!");
                
                break;
            case 3:
                Console.WriteLine("Enter the amount you want to withdrawal");
                while(int.TryParse(Console.ReadLine(),out withdrawalCount))
                {
                    whichAccount.WithdrawalMoney(withdrawalCount);
                }
                break;
            case 4:
                Console.WriteLine("Enter the amount you want to deposit");
                while (int.TryParse(Console.ReadLine(), out depositeCount))
                {
                    whichAccount.DepositMoney(depositeCount);
                }
                break;
            case 5:
                whichAccount.SendAccountReceipt(whichAccount);
                break;

        }
    }
    else
        Console.WriteLine("Account number not found.");

}
Console.ReadLine();
