using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    public partial class Form1 : Form {
        private double firstNumber;
        private double secondNumber;
        private double result;
        private string operation;

        public Form1() {
            InitializeComponent();
        }
        private bool firstNumberEntered = false;
        private void number_Click(object sender, EventArgs e) {
            var button = (Button)sender;

            if (!firstNumberEntered) {

                if (textBox1.Text == "0" && textBox1.Text != null) {
                    textBox1.Text = button.Text;
                }
                else {
                    textBox1.Text = textBox1.Text + button.Text;
                }
            }
            if (firstNumberEntered) {
                if (textBox2.Text == "0" && textBox2.Text != null) {
                    textBox2.Text = button.Text;
                }
                else {
                    textBox2.Text = textBox2.Text + button.Text;
                }
            }
        }
        private void operator_Click(object sender, EventArgs e) {
            var button = (Button)sender;
            operation = button.Text;
            textBox3.Text = operation;
            firstNumberEntered = true;
        }
        private void equals_Click(object sender, EventArgs e) {
            if (secondNumber == 0) {
                if (operation == "/") {
                    MessageBox.Show("You cannot divide by 0!\nTry again with a valid operation.");
                    StartOver();
                }
            }
            firstNumber = Convert.ToDouble(textBox1.Text);
            secondNumber = Convert.ToDouble(textBox2.Text);
            switch (operation) {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }
            textBox4.Text = Convert.ToString(result);
        }
        private void clear_Click(object sender, EventArgs e) {
            StartOver();
        }
        private void StartOver() {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = null;
            textBox4.Text = null;
            operation = null;
            firstNumberEntered = false;
        }
    }
}