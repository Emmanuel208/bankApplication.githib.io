# bankApplication.githib.io
Bank application (Console)

Console Bank Application **Console Bank Application by Chukwuemeka Emmanuel Obasi, student ID 23606

=============================================================================================

This console bank application is able to distinguish between an employee and a customer As an employee, one is able to create delete and read users in the banks system.
You are able to login to a password protected system and do these changes.

Logging In • An opening menu should ask if you are a Bank Employee or a Customer.
• To successfully login as a bank employee you must type in the pin 'A1234' 
• To successfully login as a customer, you must enter your first name, last name, account number and pin.

  To login as a customer a name, account code and a pin number is needed.
1 A customer can retrieve the transaction history for their specified account.
2 They can add and subtract money to either their savings account or current account.
3 They cannot have negative balances.
4 Bank Employee View

1 As a bank employee you can create and delete customers.
2 Each new customer gets a savings account and a current account.
3 You can only delete customers who have zero balances.
4 You can create transactions (lodge, deposit) for each customer. You should be able to add and withdraw for a specified account.
5 To create a customer account you need first name, last name and email.
6 You should be able to show a complete list of customers including their balances in savings and current account.
7 There should be a menu item allowing you to list customers, their account numbers.
Creating Accounts

Your application should create a file called customers.txt which stores a list of customer accounts. 
Each account should be stored on a single line; it is up to you to decide the format. This file should be created when the program runs for the first time.

The system should create accounts based on the following rules: 
The filename will be called xx-nn-yy-zz where xx is the initials of the customer, nn is the length of the total name
(first name and last name, yy is the alphabetical position of the first initial and zz is the alphabetical position of the second initial (see table below)
- together they make up the pin number

A B C D E F G H I J  K   L M   N O  P  Q  R
1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18

S   T U  V  W  X  Y  Z
19 20 21 22 23 24 25 26

===================================================================================================================================

While doing this project I learned many new things concerning c# and .NET 
creating and manipulating txt files, reading writing and appending files proved to be useful. 
Although, the code still has a few bugs that will be worked on in the futuer. In general, the code seems to be working and doing majority of what it needs to do.
