using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NameSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> boysNames= new List<string>();

        List<string> girlsNames = new List<string>();

        StreamReader boysInputFile = File.OpenText("BoyNames.txt");

        StreamReader girlsInputFile = File.OpenText("GirlNames.txt");

        string boyName, girlName;
        private void ReadBoysFile()
        {
            int count = 0;

            while (!boysInputFile.EndOfStream) 
            {
                boysNames.Add(boysInputFile.ReadLine());
                count++;
            }
            boysInputFile.Close();
        }

        private void ReadGirlsFile() 
        {
            int count = 0;

            while (!girlsInputFile.EndOfStream) 
            {
                girlsNames.Add(girlsInputFile.ReadLine());
                count++;
            }
            girlsInputFile.Close();
        }

        private string getBoyName()
        {
            boyName = txtBoyName.Text;
            return boyName;
        }

        private string getGirlName() 
        {
            girlName = txtGirlName.Text;
            return girlName;
        }

        private int Search(List<string> inputList, string name)
        {
            bool found = false;
            int position = -100;
            int index = 0;

            while (!found && (index < inputList.Count))
            {
                if (inputList[index] == name)
                {
                    position = index;
                    found = true;
                }
                index++;
            }
            return position;
        }

        private void CompareBoyName(string boyName)
        {
            if (Search(boysNames, boyName) != -100)
            {
                MessageBox.Show("The name " + boyName + " is among the most popular for boys.");
            }
            else
            {
                MessageBox.Show("The name " + boyName + " is not among the most popular for boys.");
            }
        }

        private void CompareGirlName(string girlName)
        {
            if (Search(girlsNames, girlName) != -100)
            {
                MessageBox.Show("The name " + girlName + " is among the most popular for girls.");
            }
            else
            {
                MessageBox.Show("The name " + girlName + " is not among the most popular for girls.");
            }
        }

        private void CompareBothNames(string boyName, string girlName)
        {
            if ((Search(boysNames, boyName) != -100) && (Search(girlsNames, girlName) != -100))
            {
                MessageBox.Show("The name '" + boyName + "' is among the most popular for boys.\n\n" +
                    "The name '" + girlName + "' is among the most popular for girls.");
            }
            else if ((Search(boysNames, boyName) != -100) && (Search(girlsNames, girlName) == -100))
            {
                MessageBox.Show("The name '" + boyName + "' is among the most popular for boys.\n\n" +
                    "The name '" + girlName + "' is not among the most popular for girls.");
            }
            else if ((Search(boysNames, boyName) == -100) && (Search(girlsNames, girlName) != -100))
            {
                MessageBox.Show("The name '" + boyName + "' is not among the most popular for boys.\n\n" +
                    "The name '" + girlName + "' is among the most popular for girls.");
            }
            else
            {
                MessageBox.Show("The name '" + boyName + "' is not among the most popular for boys.\n\n" +
                    "The name '" + girlName + "' is not among the most popular for girls.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadBoysFile();
            ReadGirlsFile();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getBoyName();
            getGirlName();

            if (boyName != "" && girlName != "")
            {
                CompareBothNames(boyName, girlName);
                txtBoyName.Focus();
                txtBoyName.Text = string.Empty;
                txtGirlName.Text = string.Empty;
            }
            else if (boyName != "" && girlName == "")
            {
                CompareBoyName(boyName);
                txtBoyName.Focus();
                txtBoyName.Text = string.Empty;
                txtGirlName.Text = string.Empty;
            }
            else if (girlName != "" && boyName == "")
            {
                CompareGirlName(girlName);
                txtGirlName.Focus();
                txtBoyName.Text = string.Empty;
                txtGirlName.Text = string.Empty;
            }
        }
    }
}