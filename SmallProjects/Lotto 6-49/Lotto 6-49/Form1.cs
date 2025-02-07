using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto_6_49
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //event that will generate our 6 'random' numbers
            //we will hold numbers in int[] array
            //assign a random number to each element
            //display each element in corresponding label

            int[] myArray = generateNumbers();
            myArray = SortArray(myArray);
            displayNumbers(myArray);

        }

        //method simply to display numbers in the array
        private void displayNumbers(int[] numbers)
        {
            lblNum1.Text = numbers[0].ToString();
            lblNum2.Text = numbers[1].ToString();
            lblNum3.Text = numbers[2].ToString();
            lblNum4.Text = numbers[3].ToString();
            lblNum5.Text = numbers[4].ToString();
            lblNum6.Text = numbers[5].ToString();

        }

        //method to generate 6 random ints and assign to array
        private int[] generateNumbers()
        {

            int[] myNum = new int[6];
            int[] checkArray = new int[6];
            Random rand = new Random();

            for (int i = 0; i < myNum.Length; i++)
            {
                myNum[i] = rand.Next(49) + 1;
                checkArray[i] = rand.Next(49) + 1; // array values > 0, values <= 49.
                if (!checkArray.Contains(myNum[i])) // checks if array contains value.
                {
                    checkArray[i] = myNum[i];
                }
                else
                {
                    i--;
                }
            } 

            return checkArray;
        }


        private int[] SortArray(int[] iArray)
        {
            int minIndex, minValue;
            for (int startScan = 0; startScan < iArray.Length - 1; startScan++)
            {
                minIndex = startScan;
                minValue = iArray[startScan];
                for (int index = startScan + 1; index < iArray.Length; index++)
                {
                    if (iArray[index] < minValue) 
                    { 
                        minValue = iArray[index];
                        minIndex = index;
                    }
                }
                Swap(ref iArray[minIndex], ref iArray[startScan]);
            }

            return iArray;
        }
        private void Swap(ref int a, ref int b) 
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
