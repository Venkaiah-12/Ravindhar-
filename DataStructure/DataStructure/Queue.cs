using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DataStructure
{
    class Queue<T>
    {
        int BankAmount = 200000;
        public Node<T> Left = null;
        public Node<T> Right = null;
        int size = 0;
        public void addingqueue(T Customername)
        {
            Node<T> newnode = new Node<T>(Customername);
            if (Left == null)
            {
                Left = Right = newnode;
            }
            else
            {
                Right.next = newnode;
                Right = newnode;
            }
            size++;
        }
        public void dequeue()
        {
            Node<T> Current;
            if (Left == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                while (Left != null)
                {
                    string str = (string)Left.Data;
                    Console.WriteLine("the customer name " + str);
                    Console.WriteLine("enter the option 1.for withdraw money and 2. for deposit money");
                    int choice = Utility.IntegerInput();
                    switch (choice)
                    {
                        case 1:
                            int amount;
                            Console.WriteLine("enter the amount to withdraw");
                            amount = Utility.IntegerInput();
                            if (amount <= 50000)
                            {
                                WithdrawAmount(str, amount);
                                Console.WriteLine("Customername:" + str + "withdrawamount" + amount);
                                Console.WriteLine("Final BankAmount :" + BankAmount);
                            }
                            else
                            {
                                Console.WriteLine("withdraw amount of daily limit is less than 50000");
                            }
                            break;
                        case 2:
                            Console.WriteLine("enter the amount to deposit ");
                            int depositamount = Utility.IntegerInput();
                            DepositAmount(str, depositamount);
                            Console.WriteLine("Customername:" + str + "depositwamount" + depositamount);
                            Console.WriteLine("Final BankAmount :" + BankAmount);
                            break;
                        default:
                            Console.WriteLine("invalid option enter the correct option");
                            break;
                    }
                    Current = Left;
                    Left = Left.next;
                    Current = null;

                }
            }
        }
        public int WithdrawAmount(string str, int amount)
        {
            int Customeramount = 0;
            Customeramount = Customeramount + amount;
            BankAmount = BankAmount - amount;
            return BankAmount;
        }
        public int DepositAmount(string str, int amount)
        {
            int CustomerAmount = 0;
            CustomerAmount = CustomerAmount + amount;
            BankAmount = BankAmount + amount;


            return BankAmount;
        }

    }
}


