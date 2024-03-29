﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proverka
{
    public partial class Form1 : Form
    {
        Random R;
        private void Form1_Load(object sender, EventArgs e)
        {
            R = new Random();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            int[] mass = new int[10];
            for (int I = 0; I < 10; I++)
            {
                mass[I] = R.Next(-100, 101);
                richTextBox1.Text += mass[I] + "\n";
            }
            for(int I = 0; I < 10; I++)
            {
                
                if (mass[I] < 50 && mass[I] > -50)
                {
                    richTextBox2.Text += mass[I] + "\n";
                }
                if (mass[I] > 50 || mass[I] < -50)
                {
                    richTextBox2.Text += "0 \n";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            int[,] mass = new int[5, 6];
            int boxN = 10;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    mass[i, j] = boxN;
                    richTextBox1.Text += mass[i, j] + "\t";
                    boxN++;
                }
                richTextBox1.Text += "\n\n";
            }
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    sum = mass[i, j] / 10 + mass[i,j] % 10;
                    if (sum < 5)
                    {
                        richTextBox2.Text += mass[i, j] + "\t";
                    }
                    if (sum >= 5)
                    {
                        richTextBox2.Text += (mass[i, j] - 10) + "\t";
                    }
                    sum = 0;
                }
                richTextBox2.Text += "\n\n";
            }
        }

       
        private void button3_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            List<int> list = new List<int>();
            for (int i = 0; i < 15; i++)
            {
                list.Add(R.Next(1, 11));
                richTextBox1.Text += list[i] + "\n";
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 1)
                {
                    list.RemoveAt(i);
                }
            }
            for (int i = 0; i < 10; i++)
            {
                list.Add(R.Next(10,21));
                richTextBox1.Text += list[i] + "\n";
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 15)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                richTextBox2.Text += list[i] + "\n";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            List<int> list = new List<int>();
            for (int i = 0; i < 30; i++)
            {
                list.Add(R.Next(1, 1001));
                if (list[i] % 14 == 3)
                {
                    richTextBox1.Text += list[i] + "\n";
                }
                else
                    richTextBox1.Text += "\t" + list[i] + "\n";
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 14 == 3)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                richTextBox2.Text += list[i] + "\n";
            }
        }
    }
}
