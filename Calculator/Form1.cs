﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String selectedOperator = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox.Text == "0")
            {
                textBox.Clear();
            }
            Button button = (Button)sender;

            if (button.Name == "button18") {
                textBox.Clear();
            }

            textBox.Text += button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button operatorButton = (Button)sender;
            selectedOperator = operatorButton.Text;
            result = Double.Parse(textBox.Text);
            textBox.Clear();
        }

        private void clear(object sender, EventArgs e)
        {
            textBox.Text = "0";
            result = 0;
        }

        private void backspace(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
        }

        private void equals(object sender, EventArgs e)
        {
            switch (selectedOperator)
            {
                case "+":
                    textBox.Text = (result + Double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (result - Double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (result * Double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (result / Double.Parse(textBox.Text)).ToString();
                    break;
            }
        }
    }
}
