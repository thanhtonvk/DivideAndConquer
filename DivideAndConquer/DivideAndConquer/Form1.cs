using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivideAndConquer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] arr = ReadFile.listNumSorted();
        int length;
        private void button1_Click(object sender, EventArgs e)
        {
            
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Search.linearSearch(arr, arr[0]);
            stopwatch.Stop();
            best_sequences.Text = stopwatch.ElapsedTicks.ToString();


            stopwatch.Start();
            Search.binarySearch(arr,0,length-1, arr[length/2]);
            stopwatch.Stop();
            best_binary.Text = stopwatch.ElapsedTicks.ToString();

            stopwatch.Start();
            Search.ternary(arr, arr[length/3]);
            stopwatch.Stop();
            best_tenary.Text = stopwatch.ElapsedTicks.ToString();


            stopwatch.Start();
            Search.jumpSearch(arr, arr[0]);
            stopwatch.Stop();
            best_jump.Text = stopwatch.ElapsedTicks.ToString();

            stopwatch.Start();
            Search.expoSearch(arr, arr[length/2]);
            stopwatch.Stop();
            best_exp.Text = stopwatch.ElapsedTicks.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            length= arr.Length;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Search.linearSearch(arr, arr[length/2]);
            stopwatch.Stop();
            normal_sequences.Text = stopwatch.ElapsedTicks.ToString();


            stopwatch.Start();
            Search.binarySearch(arr, 0, length - 1, arr[length / 4]);
            stopwatch.Stop();
            normal_binary.Text = stopwatch.ElapsedTicks.ToString();

            stopwatch.Start();
            Search.ternary(arr, arr[length / 9]);
            stopwatch.Stop();
            normal_tenary.Text = stopwatch.ElapsedTicks.ToString();


            stopwatch.Start();
            Search.jumpSearch(arr, arr[length/2]);
            stopwatch.Stop();
            normal_jump.Text = stopwatch.ElapsedTicks.ToString();

            stopwatch.Start();
            Search.expoSearch(arr, arr[length / 4]);
            stopwatch.Stop();
            normal_exp.Text = stopwatch.ElapsedTicks.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Search.linearSearch(arr, -1);
            stopwatch.Stop();
            worse_sequences.Text = stopwatch.ElapsedTicks.ToString();


            stopwatch.Start();
            Search.binarySearch(arr, 0, length - 1, -1);
            stopwatch.Stop();
            worse_binary.Text = stopwatch.ElapsedTicks.ToString();

            stopwatch.Start();
            Search.ternary(arr,-1);
            stopwatch.Stop();
            worse_tenary.Text = stopwatch.ElapsedTicks.ToString();


            stopwatch.Start();
            Search.jumpSearch(arr,-1);
            stopwatch.Stop();
            worse_jump.Text = stopwatch.ElapsedTicks.ToString();

            stopwatch.Start();
            Search.expoSearch(arr, -1);
            stopwatch.Stop();
            worse_exp.Text = stopwatch.ElapsedTicks.ToString();

        }
    }
}
