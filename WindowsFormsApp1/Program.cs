using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;
namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddition()
        {
            Form1 calculator = new Form1();
            //calculator.textBox1.Text = "5";
            calculator.button13_Click(calculator.button10, null);
            calculator.button13_Click(calculator.button20, null);
            //calculator.textBox1.Text = "3";
            calculator.button13_Click(calculator.button15, null);
            calculator.button13_Click(calculator.button19, null);

            Assert.AreEqual("8", calculator.textBox1.Text);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            Form1 calculator = new Form1();
            //calculator.textBox1.Text = "10";
            calculator.button13_Click(calculator.button13, null);
            calculator.button13_Click(calculator.button17, null);
            calculator.button13_Click(calculator.button16, null);
            //calculator.textBox1.Text = "4";
            calculator.button13_Click(calculator.button9, null);
            calculator.button13_Click(calculator.button19, null);

            Assert.AreEqual("6", calculator.textBox1.Text);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            Form1 calculator = new Form1();
            //calculator.textBox1.Text = "6";
            calculator.button13_Click(calculator.button11, null);
            calculator.button13_Click(calculator.button12, null);
            //calculator.textBox1.Text = "7";
            calculator.button13_Click(calculator.button5, null);
            calculator.button13_Click(calculator.button19, null);

            Assert.AreEqual("42", calculator.textBox1.Text);
        }
        

        [TestMethod]
        public void TestDivision()
        {
            Form1 calculator = new Form1();
            //calculator.textBox1.Text = "20";
            calculator.button13_Click(calculator.button14, null);
            calculator.button13_Click(calculator.button17, null);
            //
           // calculator.textBox1.Text = "5";
            calculator.button13_Click(calculator.button8, null);
            calculator.button13_Click(calculator.button10, null);
            calculator.button13_Click(calculator.button19, null);

            Assert.AreEqual("4", calculator.textBox1.Text);
        }

        [TestMethod]
        public void TestSine()
        {
            Form1 calculator = new Form1();
            //calculator.textBox1.Text = "30";
            calculator.button13_Click(calculator.button15, null);
            calculator.button13_Click(calculator.button17, null);
            calculator.button13_Click(calculator.button21, null);
            Assert.AreEqual("0.5", calculator.textBox1.Text);
        }

        [TestMethod]
        public void Testln()
        {
            Form1 calculator = new Form1();
            //calculator.textBox1.Text = "e";
            calculator.button13_Click(calculator.button30, null);
            calculator.button13_Click(calculator.button25, null);
            Assert.AreEqual("1", calculator.textBox1.Text);
        }
        [TestMethod]
        public void Testsqrt()
        {
            Form1 calculator = new Form1();
            //calculator.textBox1.Text = "9";
            calculator.button13_Click(calculator.button7, null);
            calculator.button13_Click(calculator.button29, null);
            Assert.AreEqual("3", calculator.textBox1.Text);
        }
        [TestMethod]
        public void Testcifang()
        {
            Form1 calculator = new Form1();
            //calculator.textBox1.Text = "3";
            calculator.button13_Click(calculator.button15, null);
            calculator.button13_Click(calculator.button24, null);
            //calculator.textBox1.Text = "3";
            calculator.button13_Click(calculator.button15, null);
            calculator.button13_Click(calculator.button19, null);
            Assert.AreEqual("27", calculator.textBox1.Text);
        }
        [TestMethod]
        public void Testpifang()
        {
            Form1 calculator = new Form1();
            //calculator.textBox1.Text = "3";
            calculator.button13_Click(calculator.button15, null);
            calculator.button13_Click(calculator.button3, null);
            Assert.AreEqual("9", calculator.textBox1.Text);
        }
    }
}
