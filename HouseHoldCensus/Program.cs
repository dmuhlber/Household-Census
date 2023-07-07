using System;
using System.Collections.Generic;
using System.Text;

namespace Household
{
    class HouseholdCensus
    {
        //Private arrays
        String[] namesOfHeads = new String[10];
        double[] annualIncome = new double[10];
        int[] numberOfMembers = new int[10];
        char[] assistanceCode = new char[10];
        //Private variable
        int counter;

        public HouseholdCensus()
        {
            counter = 0;
        }
        public void inputHouseholdInfo()
        {
            char choice = 'y';
            //Loop repeats until the user enters 'n'
            do
            {
                Console.Write("\tEnter the name of the household: ");
                namesOfHeads[counter] = Console.ReadLine();
                Console.Write("\tEnter annual income of household:$ ");
                annualIncome[counter] = Convert.ToDouble(Console.ReadLine());
                Console.Write("\tEnter number of house hold members: ");
                numberOfMembers[counter] = Convert.ToInt32(Console.ReadLine());
                //Increment counter
                counter++;
                Console.WriteLine();
                Console.Write("\tDo you have more households to enter? (y/n): ");
                choice = Console.ReadLine()[0];
                Console.WriteLine();
            } while (choice == 'y');
        }
        public void determineAssistance()
        {
            for (int i = 0; i < counter; i++)
            {
                if (numberOfMembers[i] == 1)
                {
                    if (annualIncome[i] < 16000)
                        assistanceCode[i] = 'Y';
                    else
                        assistanceCode[i] = 'N';
                }
                else if (numberOfMembers[i] == 2)
                {
                    if (annualIncome[i] < 22000)
                        assistanceCode[i] = 'Y';
                    else
                        assistanceCode[i] = 'N';
                }
                else if (numberOfMembers[i] == 3)
                {
                    if (annualIncome[i] < 28000)
                        assistanceCode[i] = 'Y';
                    else
                        assistanceCode[i] = 'N';
                }
                else if (numberOfMembers[i] == 4)
                {
                    if (annualIncome[i] < 33000)
                        assistanceCode[i] = 'Y';
                    else
                        assistanceCode[i] = 'N';
                }
                else if (numberOfMembers[i] == 5)
                {
                    if (annualIncome[i] < 34000)
                        assistanceCode[i] = 'Y';
                    else
                        assistanceCode[i] = 'N';
                }
                else if (numberOfMembers[i] == 6)
                {
                    if (annualIncome[i] < 45000)
                        assistanceCode[i] = 'Y';
                    else
                        assistanceCode[i] = 'N';
                }
                else if (numberOfMembers[i] == 7)
                {
                    if (annualIncome[i] < 50000)
                        assistanceCode[i] = 'Y';
                    else
                        assistanceCode[i] = 'N';
                }
                else if (numberOfMembers[i] == 8)
                {
                    if (annualIncome[i] < 55000)
                        assistanceCode[i] = 'Y';
                    else
                        assistanceCode[i] = 'N';
                }
                else if (numberOfMembers[i] > 8)
                {
                    int additional_incomelevel = (numberOfMembers[i] - 8) * 5000;
                    if (annualIncome[i] < (55000 + additional_incomelevel))
                        assistanceCode[i] = 'Y';
                    else
                        assistanceCode[i] = 'N';
                }
            }
            //Call function to display details
            displayHouseholdInfo(namesOfHeads, annualIncome,
            numberOfMembers, assistanceCode, counter);
        }
        public void displayHouseholdInfo(string[] namesOfHeads, double[] annualIncome,
            int[] numberOfMembers, char[] assistanceCode, int counter)
        {
            double sum = 0;
            Console.WriteLine("\tHOUSEHOLD NAME\tANNUAL INCOME\tNUMBER OF HOUSEHOLD\tMEMBERS\tASSISTANCE?");
            Console.WriteLine("\t---------------------------------------------------------------------------");
            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("\t" + namesOfHeads[i] + "\t$ " + annualIncome[i].ToString("#,##0.00") + "\t\t" + numberOfMembers[i] + "\t\t\t" + assistanceCode[i]);
                sum = sum + annualIncome[i];
                Console.WriteLine();
            }
            Console.WriteLine("\t---------------------------------------------------------------------------");
            double averageIncome = sum / counter;
            //Calculate and print average
            Console.WriteLine("\tAVERAGE INCOME = $ " + averageIncome.ToString("#,##0.00"));
            Console.WriteLine("\t---------------------------------------------------------------------------");
        }
    }
}
