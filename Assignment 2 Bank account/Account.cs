﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2_Bank_account
{
    class Account
    {
        private string name;
        private double balance;

        public Account(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public double CheckBalance()
        {
            return balance;
        }
        public double DepositMoney(double MoneyIn)
        {
            if(MoneyIn> 0)
            {
                Console.WriteLine("Money added successfully!");
                balance = balance + MoneyIn;
            }
            else
            {
                Console.WriteLine("Scam attempt");
            }
            return balance;

        }
        public double WithdrawMoney(double MoneyOut)
        {
            if (MoneyOut > balance)
            {
                Console.WriteLine("You do not have enough money");
            }
            else if(MoneyOut > 0)
            {
                Console.WriteLine("Withdraw successful!");
                balance = balance - MoneyOut;
            }
            else
            {
                Console.WriteLine("Dont try and scam us with negative numbers!");  
            }
            return balance;

        }
        // Interest rate is in the format 1.05
        //This means 5%
        public double AddInterest(double InterestRate)
        {
            string date = DateTime.Now.ToShortDateString();
            Console.WriteLine(date);
            if(date == "01/01/2021")
            {
               balance = balance * InterestRate;
            }
        
            return balance;
        } 
    }
}

