using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static BankApplication.Classes.BankLogin;

namespace BankApplication.Classes
{
    //Chukwuemeka Emmanuel Obasi
    // Student ID : 23606
    /// <summary>
    /// Driver code. 
    /// This class Driver holds all classes and code and pushes it to the Main
    /// By doing this i have reduced the amount of code in my Main
    /// By calling **run** 
    /// </summary>
    public class Driver : ILogin, IBalance, ITransction, IDeposit
    {
        private const decimal minimum_kept_amt = 20;

        
        private static decimal transaction_amt;
        private static BankAccount selectedAccount;
        private static BankAccount inputAccount;
        private static List<Transaction> _listOfTransactions;
        //List<string> firstName = new List<string>();


        //run
        public void run()
        {
            BankLogin.showMenu1();

            string input;

            input = Console.ReadLine();


            while (input == "1")
            {
                Utility.getOptionMainMenu("your option");
                {

                    BankLogin.showMenu3();



                    switch (Utility.GetValidInputEmpoyyeMenu("your option"))
                    {

                        case (int)secureEmpoyeeMenu.createAccount:

                            CreateAccount(selectedAccount);

                            break;
                        case (int)secureEmpoyeeMenu.deleteAccount:
                            deleteAccount(selectedAccount);
                            break;

                        case (int)secureEmpoyeeMenu.customerList:
                            CustomerList(selectedAccount);
                            break;

                        case (int)secureEmpoyeeMenu.transction:
                            transaction(selectedAccount);
                            break;

                        case (int)secureEmpoyeeMenu.logout:
                            Utility.PrintMessage("You have succesfully logout...", true);

                            run();
                            break;
                        default:
                            Utility.PrintMessage("Invalid Option Entered.", false);

                            break;

                    }

                }
            }


            while (input == "2")
            {
                Utility.getOptionMainMenu2("your option");
                {
                    //case 1:

                    CheckAccount();

                    _listOfTransactions = new List<Transaction>();

                    BankLogin.showMenu2();


                    switch (Utility.GetValidInputCustomerMenu("your option"))
                    {
                        case (int)secureMenu.checkBalance:
                            CheckBalance(selectedAccount);

                            break;
                        case (int)secureMenu.placeDeposit:
                            PlaceDeposit(selectedAccount);
                            break;
                        case (int)secureMenu.makeWithdrawal:
                            MakeWithdrawal(selectedAccount);
                            break;

                        case (int)secureMenu.viewTransaction:
                            ViewTransaction(selectedAccount);
                            break;

                        case (int)secureMenu.Logout:
                            Utility.PrintMessage("You have succesfully logout...", true);

                            run();
                            break;
                        default:
                            Utility.PrintMessage("Invalid Option Entered.", false);

                            break;





                    }


                }

            }

        }


        public void CheckAccount()
        {


            var data = new BankAccount[]
            {
                new BankAccount (){firstName = "Emmanuel", lastName = "Obasi", accNumber = "EO130515", accPin = "0515"},



            };

          

            bool pass = false;

            do
            {
                inputAccount = new BankAccount();
                foreach (BankAccount account1 in data)
                {

                    System.IO.File.ReadAllLines(@"C:\Users\Mexii\Note_Pad\customer.txt");


                    bool correct = false;
                    //bool correct2 = false;
                    do
                    {
                        Console.WriteLine("Enter Your First Name:");
                        inputAccount.firstName = Console.ReadLine();
                        if (inputAccount.firstName == account1.firstName)
                        {
                            correct = true;
                            selectedAccount = account1;
                            break;

                        }
                        else
                        {

                            correct = false;
                            Console.WriteLine("Invalid input. Try again");

                        }
                    } while (correct == false);



                    do
                    {
                        Console.WriteLine("Enter your Surname:");
                        inputAccount.lastName = Console.ReadLine();
                        if (inputAccount.lastName == account1.lastName)
                        {
                            correct = true;
                            // Console.WriteLine("Enter your Account number");
                            selectedAccount = account1;
                            break;
                        }
                        else
                        {
                            correct = false;
                            Console.WriteLine("Invalid input. Try again");

                        }
                    } while (correct == false);





                    do
                    {
                        Console.WriteLine("Enter your Account Number:");
                        inputAccount.accNumber = Console.ReadLine();
                        if (inputAccount.accNumber == account1.accNumber)
                        {
                            correct = true;
                            // Console.WriteLine("Enter your Account number");
                            selectedAccount = account1;
                            break;
                        }
                        else
                        {
                            correct = false;
                            Console.WriteLine("Invalid input. Try again");

                        }
                    } while (correct == false);




                    do
                    {
                        Console.WriteLine("Enter your Account Pin:");
                        inputAccount.accPin = Console.ReadLine();
                        if (inputAccount.accPin == account1.accPin)
                        {
                            correct = true;
                            // Console.WriteLine("Enter your Account number");
                            selectedAccount = account1;
                            break;
                        }
                        else
                        {
                            correct = false;
                            Console.WriteLine("Invalid input. Try again");

                        }
                    } while (correct == false);


                } pass = true;


                Console.Clear();

            } while (pass == false);




        }

        public void CheckBalance(BankAccount bankAccount)
        {

            Console.WriteLine("Press (1) for Current Account");
            Console.WriteLine("Press (2) for Savings Account;");
            string input = Console.ReadLine();

            while (input == "1")
            {
                Utility.PrintMessage($"Your bank account balance amount is: {Utility.FormatAmount(bankAccount.currentBalance)}", true);

                Console.Clear();
                BankLogin.showMenu2();


                switch (Utility.GetValidInputCustomerMenu("your option"))
                {
                    case (int)secureMenu.checkBalance:
                        CheckBalance(selectedAccount);

                        break;
                    case (int)secureMenu.placeDeposit:
                        PlaceDeposit(selectedAccount);
                        break;
                    case (int)secureMenu.makeWithdrawal:
                        MakeWithdrawal(selectedAccount);
                        break;

                    case (int)secureMenu.viewTransaction:
                        ViewTransaction(selectedAccount);
                        break;

                    case (int)secureMenu.Logout:
                        Utility.PrintMessage("You have succesfully logout...", true);

                        run();
                        break;
                    default:
                        Utility.PrintMessage("Invalid Option Entered.", false);

                        break;





                }
            }

            while (input == "2")
            {
                Utility.PrintMessage($"Your bank account balance amount is: {Utility.FormatAmount(bankAccount.savingBalance)}", true);

                Console.Clear();
                BankLogin.showMenu2();


                switch (Utility.GetValidInputCustomerMenu("your option"))
                {
                    case (int)secureMenu.checkBalance:
                        CheckBalance(selectedAccount);

                        break;
                    case (int)secureMenu.placeDeposit:
                        PlaceDeposit(selectedAccount);
                        break;
                    case (int)secureMenu.makeWithdrawal:
                        MakeWithdrawal(selectedAccount);
                        break;

                    case (int)secureMenu.viewTransaction:
                        ViewTransaction(selectedAccount);
                        break;

                    case (int)secureMenu.Logout:
                        Utility.PrintMessage("You have succesfully logout...", true);

                        run();
                        break;
                    default:
                        Utility.PrintMessage("Invalid Option Entered.", false);

                        break;





                }
            }
        }





        public void CreateAccount(BankAccount bankAccount)
        {
            List<string> output = new List<string>();
            bool Continue = false;
            do
            {
                string firstName;
                string lastName;
                string email;


                Console.WriteLine("Enter First Name:");
                firstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name");
                lastName = Console.ReadLine();

                Console.WriteLine("Enter email:");
                email = Console.ReadLine();

                string p1;
                int p2;
                int p3;
                int p4;
                string accPin;
                string accNumber;
                string pin;


                p1 = firstName[0].ToString() + lastName[0].ToString();
                p2 = firstName.Length + lastName.Length;
                p3 = (firstName[0] - 64);
                p4 = (lastName[0] - 64);



                pin = ($"{p3}{p4}").ToString();
                accNumber = ($"{p1}-{p2}-{p3}-{p4}");
                accPin = pin.ToString();



                Console.WriteLine(accNumber, accPin);

                Console.WriteLine("Account Detailes:");
                Console.WriteLine($"User First Name: {firstName}");
                Console.WriteLine($"User  Last Name: {lastName}");
                Console.WriteLine($"User  AccNumber: {accNumber}");
                Console.WriteLine($"User    accPin : {accPin}");




                var filePath = @$"C:\Users\Mexii\Note_Pad\customer.txt";

                using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {

                    output.Add($"{firstName}, {lastName} ,{email}, {accNumber}, {accPin} " + Environment.NewLine);

                }

                File.WriteAllLines(filePath, output);

                Console.WriteLine("Creating Account please wait.");
                int timer = 100;
                for (var x = 0; x < timer; x++)
                {
                    System.Console.Write("=");
                    Thread.Sleep(100);
                }
                Console.WriteLine("Account created");

                Console.Clear();

                Console.WriteLine("Note:");
                Console.WriteLine("To protect information here at Bank of Emmanuel");
                Console.WriteLine("All users must logout befor viewing customer list");
                Console.WriteLine("Press (1) to create another user press (0) to go back to employee");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    Continue = false;

                } else if (input == "0")
                {
                    Continue = true;
                }
                else
                {
                    Utility.PrintMessage("Invalid Option Entered.", false);
                }




            } while (Continue == false);

            Console.WriteLine("All Entries Written");


            Console.Clear();

            BankLogin.showMenu3();



            switch (Utility.GetValidInputEmpoyyeMenu("your option"))
            {

                case (int)secureEmpoyeeMenu.createAccount:

                    CreateAccount(selectedAccount);

                    break;
                case (int)secureEmpoyeeMenu.deleteAccount:
                    deleteAccount(selectedAccount);
                    break;
                case (int)secureEmpoyeeMenu.transction:
                    transaction(selectedAccount);
                    break;

                case (int)secureEmpoyeeMenu.logout:
                    Utility.PrintMessage("You have succesfully logout...", true);

                    run();
                    break;
                default:
                    Utility.PrintMessage("Invalid Option Entered.", false);

                    break;

            }



        }


        public void deleteAccount(BankAccount bankAccount)
        {
            List<string> output = new List<string>();

            var filePath = @"C:\Users\Mexii\Note_Pad\customer.txt";

            //string tempFile = Path.GetTempFileName();

            List<string> quotelist = File.ReadAllLines(filePath).ToList();


            foreach (string i in quotelist) //.Skip(oddNumbers+1))
            {
                Console.WriteLine($"(...) {i}");
            }
            Console.WriteLine("Enter the details (First Name, Last Name, Email, Accont Number, Account Pin) of the user you  would  like to delete:");

            Console.WriteLine("First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Account Number:");
            string accNumber = Console.ReadLine();
            Console.WriteLine("Accont Pin:");
            string accPin = Console.ReadLine();

            string word = Convert.ToString(firstName);
            string word2 = Convert.ToString(lastName);
            string word3 = Convert.ToString(email);
            string word4 = Convert.ToString(accNumber);
            string word5 = Convert.ToString(accPin);


            var oldlines = File.ReadAllLines(filePath);
            var newLines = oldlines.Where(line => !line.Contains(word));
            File.WriteAllLines(filePath, newLines);
            FileStream obj = new FileStream(filePath, FileMode.Append);
            obj.Close();

            FileStream Obj1 = new FileStream(filePath, FileMode.Append);
            Obj1.Close();


            Console.WriteLine("Press (0) to exit");
            bool input = false;
            do
            {

                string exit = Console.ReadLine();
                if (exit == "0")
                {
                    input = true;
                    BankLogin.showMenu3();
                }
                else
                {
                    Console.WriteLine("Invalid enter. Press (0 to exit)");
                    input = false;

                }
            } while (input == false);

            Console.Clear();

            BankLogin.showMenu3();



            switch (Utility.GetValidInputEmpoyyeMenu("your option"))
            {

                case (int)secureEmpoyeeMenu.createAccount:

                    CreateAccount(selectedAccount);

                    break;
                case (int)secureEmpoyeeMenu.deleteAccount:
                    deleteAccount(selectedAccount);
                    break;
                case (int)secureEmpoyeeMenu.transction:
                    transaction(selectedAccount);
                    break;

                case (int)secureEmpoyeeMenu.logout:
                    Utility.PrintMessage("You have succesfully logout...", true);

                    run();
                    break;
                default:
                    Utility.PrintMessage("Invalid Option Entered.", false);

                    break;

            }

        }

        public void CustomerList(BankAccount bankAccount)
        {

            Console.WriteLine("List Of Customers:");

            List<string> lines = File.ReadAllLines(@$"C:\Users\Mexii\Note_Pad\customer.txt").ToList();

            foreach (var i in lines)
            {
                Console.WriteLine(i + Environment.NewLine);
            }




            Console.WriteLine("Press (0) to exit");
            bool input = false;
            do
            {

                string exit = Console.ReadLine();
                if (exit == "0")
                {
                    input = true;
                    BankLogin.showMenu3();
                }
                else
                {
                    Console.WriteLine("Invalid enter. Press (0 to exit)");
                    input = false;

                }
            } while (input == false);

            Console.Clear();

            BankLogin.showMenu3();



            switch (Utility.GetValidInputEmpoyyeMenu("your option"))
            {

                case (int)secureEmpoyeeMenu.createAccount:

                    CreateAccount(selectedAccount);

                    break;
                case (int)secureEmpoyeeMenu.deleteAccount:
                    deleteAccount(selectedAccount);
                    break;
                case (int)secureEmpoyeeMenu.transction:
                    transaction(selectedAccount);
                    break;

                case (int)secureEmpoyeeMenu.logout:
                    Utility.PrintMessage("You have succesfully logout...", true);

                    run();
                    break;
                default:
                    Utility.PrintMessage("Invalid Option Entered.", false);

                    break;

            }

        }

        public void transaction(BankAccount bankAccount)
        {
            Console.WriteLine("List of customers Transaction");

            List<string> lines = File.ReadAllLines(@"C:\Users\Mexii\Note_Pad\CurrentAccount.txt").ToList();



            foreach (var i in lines)
            {
                Console.WriteLine(i + Environment.NewLine);

            }

            Console.WriteLine("Press (0) to exit");
            bool input = false;
            do
            {

                string exit = Console.ReadLine();
                if (exit == "0")
                {
                    input = true;
                    BankLogin.showMenu3();
                }
                else
                {
                    Console.WriteLine("Invalid enter. Press (0 to exit)");
                    input = false;

                }
            } while (input == false);

            Console.Clear();

            BankLogin.showMenu3();



            switch (Utility.GetValidInputEmpoyyeMenu("your option"))
            {

                case (int)secureEmpoyeeMenu.createAccount:

                    CreateAccount(selectedAccount);

                    break;
                case (int)secureEmpoyeeMenu.deleteAccount:
                    deleteAccount(selectedAccount);
                    break;
                case (int)secureEmpoyeeMenu.transction:
                    transaction(selectedAccount);
                    break;

                case (int)secureEmpoyeeMenu.logout:
                    Utility.PrintMessage("You have succesfully logout...", true);

                    run();
                    break;
                default:
                    Utility.PrintMessage("Invalid Option Entered.", false);

                    break;

            }

           


        }

        public void PlaceDeposit(BankAccount bankAccount)
        {


            Console.WriteLine("Press (1) for Current Account");
            Console.WriteLine("Press (2) for Savings Account;");
            string input = Console.ReadLine();

            do
            {
                //Console.Write("Enter amount: " + ATMScreen.cur);
                transaction_amt = Utility.GetValidDecimalInputAmt("amount");

                System.Console.Write("\nLoading.");
                Utility.printDotAnimation();

                if (transaction_amt <= 0)
                    Utility.PrintMessage("Amount needs to be more than zero. Try again.", false);
                else if (transaction_amt % 10 != 0)
                    Utility.PrintMessage($"Key in the deposit amount only with multiply of 10. Try again.", false);

                else if (!PreviewBankNotesCount(transaction_amt))
                    Utility.PrintMessage($"You have cancelled your action.", false);
                else
                {

                    // Bind transaction_amt to Transaction object
                    ////Add transaction record - Start
                    var transaction = new Transaction()
                    {
                        BankAccountNoFrom = bankAccount.accNumber,
                        //BankAccountNoTo = Convert.ToInt64(bankAccount.accNumber),
                        TransactionType = TransactionType.Deposit,
                        TransactionAmount = transaction_amt,
                        TransactionDate = DateTime.Now
                    };
                    // InsertTransaction(bankAccount, transaction);
                    // Add transaction record - End

                    // Another method to update account balance.
                    bankAccount.currentBalance = bankAccount.currentBalance + transaction_amt;

                    Utility.PrintMessage($"You have successfully deposited ${Utility.FormatAmount(transaction_amt)}", true);

                    List<string> output = new List<string>();

                    foreach (Transaction transaction_amt in _listOfTransactions)
                    {
                        output.Add($"{DateTime.Now}\t Deposit \t {transaction_amt} {bankAccount.currentBalance}");
                    }
                    File.WriteAllLines(@"C:\Users\Mexii\Note_Pad\CurrentAccount.txt", output);

                }
                Console.Clear();

                BankLogin.showMenu2();


                switch (Utility.GetValidInputCustomerMenu("your option"))
                {
                    case (int)secureMenu.checkBalance:
                        CheckBalance(selectedAccount);

                        break;
                    case (int)secureMenu.placeDeposit:
                        PlaceDeposit(selectedAccount);
                        break;
                    case (int)secureMenu.makeWithdrawal:
                        MakeWithdrawal(selectedAccount);
                        break;

                    case (int)secureMenu.viewTransaction:
                        ViewTransaction(selectedAccount);
                        break;

                    case (int)secureMenu.Logout:
                        Utility.PrintMessage("You have succesfully logout...", true);

                        run();
                        break;
                    default:
                        Utility.PrintMessage("Invalid Option Entered.", false);

                        break;





                }
            } while (input == "1");


            do
            {

                transaction_amt = Utility.GetValidDecimalInputAmt("amount");

                System.Console.Write("\nLoading.");
                Utility.printDotAnimation();

                if (transaction_amt <= 0)
                    Utility.PrintMessage("Amount needs to be more than zero. Try again.", false);
                else if (transaction_amt % 10 != 0)
                    Utility.PrintMessage($"Key in the deposit amount only with multiply of 10. Try again.", false);

                else if (!PreviewBankNotesCount(transaction_amt))
                    Utility.PrintMessage($"You have cancelled your action.", false);
                else
                {

                    // Bind transaction_amt to Transaction object
                    // Add transaction record - Start
                    var transaction = new Transaction()
                    {
                        BankAccountNoFrom = bankAccount.accNumber,
                        TransactionType = TransactionType.Deposit,
                        TransactionAmount = transaction_amt,
                        TransactionDate = DateTime.Now
                    };
                    InsertTransaction(bankAccount, transaction);
                    // Add transaction record - End

                    // Another method to update account balance.
                    bankAccount.savingBalance = bankAccount.savingBalance + transaction_amt;

                    Utility.PrintMessage($"You have successfully deposited {Utility.FormatAmount(transaction_amt)}", true);


                    List<string> output = new List<string>();

                    foreach (Transaction transaction_amt in _listOfTransactions)
                    {
                        output.Add($"{DateTime.Now}\t Deposit \t {transaction_amt} {bankAccount.savingBalance}");
                    }
                    File.WriteAllLines(@"C:\Users\Mexii\Note_Pad\SavingAccount.txt", output);
                }
                Console.Clear();

                BankLogin.showMenu2();


                switch (Utility.GetValidInputCustomerMenu("your option"))
                {
                    case (int)secureMenu.checkBalance:
                        CheckBalance(selectedAccount);

                        break;
                    case (int)secureMenu.placeDeposit:
                        PlaceDeposit(selectedAccount);
                        break;
                    case (int)secureMenu.makeWithdrawal:
                        MakeWithdrawal(selectedAccount);
                        break;

                    case (int)secureMenu.viewTransaction:
                        ViewTransaction(selectedAccount);
                        break;

                    case (int)secureMenu.Logout:
                        Utility.PrintMessage("You have succesfully logout...", true);

                        run();
                        break;
                    default:
                        Utility.PrintMessage("Invalid Option Entered.", false);

                        break;





                }
            } while (input == "2");
        }

        private void InsertTransaction(BankAccount bankAccount, Transaction transaction)
        {
            _listOfTransactions.Add(transaction);
        }

        public void MakeWithdrawal(BankAccount bankAccount)
        {
            Console.WriteLine("\nNote: Try are new kids saver Account, the future could be made certin");
            Console.Write("choose some default withdrawal amount. \n\n");


            Console.WriteLine("Press (1) for Current Account");
            Console.WriteLine("Press (2) for Savings Account;");
            string input = Console.ReadLine();


            do
            {
                transaction_amt = Utility.GetValidDecimalInputAmt("amount");

                if (transaction_amt <= 0)
                    Utility.PrintMessage("Amount needs to be more than zero. Try again.", false);
                else if (transaction_amt > bankAccount.currentBalance)
                    Utility.PrintMessage($"Withdrawal failed. You do not have enough fund to withdraw {Utility.FormatAmount(transaction_amt)}", false);
                else if ((bankAccount.currentBalance - transaction_amt) < minimum_kept_amt)
                    Utility.PrintMessage($"Withdrawal failed. Your account needs to have minimum {Utility.FormatAmount(minimum_kept_amt)}", false);
                else if (transaction_amt % 10 != 0)
                    Utility.PrintMessage($"Key in the deposit amount only with multiply of 10. Try again.", false);
                else
                {
                    // Bind transaction_amt to Transaction object
                    // Add transaction record - Start
                    var transaction = new Transaction()
                    {
                        BankAccountNoFrom = bankAccount.accNumber,
                        TransactionType = TransactionType.Withdrawal,
                        TransactionAmount = transaction_amt,
                        TransactionDate = DateTime.Now
                    };
                    InsertTransaction(bankAccount, transaction);
                    // Add transaction record - End

                    // Another method to update account balance.
                    bankAccount.currentBalance = bankAccount.currentBalance - transaction_amt;

                    Utility.PrintMessage($"You have successfully withdrawn ${Utility.FormatAmount(transaction_amt)}", true);

                    List<string> output = new List<string>();

                    foreach (Transaction transaction_amt in _listOfTransactions)

                    {
                        Console.WriteLine("......Transaction Type..Transaction Amount......Balance");
                        output.Add($"{DateTime.Now}\t Withdraw \t ${transaction_amt} {bankAccount.currentBalance}");
                    }
                    File.WriteAllLines(@"C:\Users\Mexii\Note_Pad\CurrentAccount.txt", output);
                }



                Console.Clear();

                BankLogin.showMenu2();

                switch (Utility.GetValidInputCustomerMenu("your option"))
                {
                    case (int)secureMenu.checkBalance:
                        CheckBalance(selectedAccount);

                        break;
                    case (int)secureMenu.placeDeposit:
                        PlaceDeposit(selectedAccount);
                        break;
                    case (int)secureMenu.makeWithdrawal:
                        MakeWithdrawal(selectedAccount);
                        break;

                    case (int)secureMenu.viewTransaction:
                        ViewTransaction(selectedAccount);
                        break;

                    case (int)secureMenu.Logout:
                        Utility.PrintMessage("You have succesfully logout...", true);

                        run();
                        break;
                    default:
                        Utility.PrintMessage("Invalid Option Entered.", false);

                        break;

                }


            } while (input == "1");



            do
            {
                transaction_amt = Utility.GetValidDecimalInputAmt("amount");

                if (transaction_amt <= 0)
                    Utility.PrintMessage("Amount needs to be more than zero. Try again.", false);
                else if (transaction_amt > bankAccount.savingBalance)
                    Utility.PrintMessage($"Withdrawal failed. You do not have enough fund to withdraw {Utility.FormatAmount(transaction_amt)}", false);
                else if ((bankAccount.savingBalance - transaction_amt) < minimum_kept_amt)
                    Utility.PrintMessage($"Withdrawal failed. Your account needs to have minimum {Utility.FormatAmount(minimum_kept_amt)}", false);
                else if (transaction_amt % 10 != 0)
                    Utility.PrintMessage($"Key in the deposit amount only with multiply of 10. Try again.", false);
                else
                {
                    // Bind transaction_amt to Transaction object
                    // Add transaction record - Start
                    var transaction = new Transaction()
                    {
                        BankAccountNoFrom = bankAccount.accNumber,
                        TransactionType = TransactionType.Withdrawal,
                        TransactionAmount = transaction_amt,
                        TransactionDate = DateTime.Now
                    };
                    InsertTransaction(bankAccount, transaction);
                    // Add transaction record - End

                    // Another method to update account balance.
                    bankAccount.savingBalance = bankAccount.savingBalance - transaction_amt;

                    Utility.PrintMessage($"Please collect your money. You have successfully withdraw {Utility.FormatAmount(transaction_amt)}", true);

                    List<string> output = new List<string>();

                    foreach (Transaction transaction_amt in _listOfTransactions)
                    {
                        output.Add($"{DateTime.Now}\t Withdraw \t {transaction_amt} {bankAccount.savingBalance}");
                    }
                    File.WriteAllLines(@"C:\Users\Mexii\Note_Pad\Account.txt", output);
                }

                Console.Clear();


                BankLogin.showMenu2();
            } while (input == "2");

            switch (Utility.GetValidInputCustomerMenu("your option"))
            {
                case (int)secureMenu.checkBalance:
                    CheckBalance(selectedAccount);

                    break;
                case (int)secureMenu.placeDeposit:
                    PlaceDeposit(selectedAccount);
                    break;
                case (int)secureMenu.makeWithdrawal:
                    MakeWithdrawal(selectedAccount);
                    break;

                case (int)secureMenu.viewTransaction:
                    ViewTransaction(selectedAccount);
                    break;

                case (int)secureMenu.Logout:
                    Utility.PrintMessage("You have succesfully logout...", true);

                    run();
                    break;
                default:
                    Utility.PrintMessage("Invalid Option Entered.", false);

                    break;
            }
        }



        private static bool PreviewBankNotesCount(decimal amount)
        {
           
            Console.WriteLine("\nSummary");
            Console.WriteLine("-------");
            Console.WriteLine($"Note, Bank Of Emmanuel will never ask for your account info.");
            Console.WriteLine($" Do not click on any suspicious Link on website");
            Console.WriteLine($"If you have click on any link call the 24 hour line to close your account immidiately");
            Console.Write($"Total amount: {Utility.FormatAmount(amount)}\n\n");

            //Console.Write("\n\nPress 1 to confirm or 0 to cancel: ");
            string opt = Utility.GetValidIntInput("1 to confirm or 0 to cancel").ToString();

            return (opt.Equals("1")) ? true : false;
        }


        public void InserTransaction(BankAccount bankAccount, Transaction transaction)
        {
            _listOfTransactions.Add(transaction);
        }

        public void ViewTransaction(BankAccount bankAccount)
        {

            if (_listOfTransactions.Count <= 0)
                Utility.PrintMessage($"There is no transaction yet.", true);
            else
            {
                var table = new ConsoleTable("Type", "From", "To", "Amount " + Screen.cur, "Transaction Date");

                foreach (var tran in _listOfTransactions)
                {
                    Console.WriteLine($"{tran.TransactionType} {tran.BankAccountNoFrom} {tran.TransactionAmount} {tran.TransactionDate}");
                   
                }
               
                Utility.PrintMessage($"You have performed {_listOfTransactions.Count} transactions.", true);

            }
            Console.Clear();

            BankLogin.showMenu2();


            switch (Utility.GetValidInputCustomerMenu("your option"))
            {
                case (int)secureMenu.checkBalance:
                    CheckBalance(selectedAccount);

                    break;
                case (int)secureMenu.placeDeposit:
                    PlaceDeposit(selectedAccount);
                    break;
                case (int)secureMenu.makeWithdrawal:
                    MakeWithdrawal(selectedAccount);
                    break;

                case (int)secureMenu.viewTransaction:
                    ViewTransaction(selectedAccount);
                    break;

                case (int)secureMenu.Logout:
                    Utility.PrintMessage("You have succesfully logout...", true);

                    run();
                    break;
                default:
                    Utility.PrintMessage("Invalid Option Entered.", false);

                    break;
            }
        }
            private static BankAccount BankAccount()
            {
                throw new NotImplementedException();
            }


    }

}




//████████╗██╗  ██╗███████╗     ██████╗ █████╗ ██╗  ██╗███████╗
//╚══██╔══╝██║  ██║██╔════╝    ██╔════╝██╔══██╗██║ ██╔╝██╔════╝
//   ██║   ███████║█████╗      ██║     ███████║█████╔╝ █████╗  
//   ██║   ██╔══██║██╔══╝      ██║     ██╔══██║██╔═██╗ ██╔══╝  
//   ██║   ██║  ██║███████╗    ╚██████╗██║  ██║██║  ██╗███████╗
//   ╚═╝   ╚═╝  ╚═╝╚══════╝     ╚═════╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝
                                                             
//██╗███████╗     █████╗     ██╗     ██╗███████╗██╗            
//██║██╔════╝    ██╔══██╗    ██║     ██║██╔════╝██║            
//██║███████╗    ███████║    ██║     ██║█████╗  ██║            
//██║╚════██║    ██╔══██║    ██║     ██║██╔══╝  ╚═╝            
//██║███████║    ██║  ██║    ███████╗██║███████╗██╗            
//╚═╝╚══════╝    ╚═╝  ╚═╝    ╚══════╝╚═╝╚══════╝╚═╝       