using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    #region Delegate
    public delegate void myclaculator(int delvar1, int delvar2);
    #endregion

    #region Class
    public partial class Form1 : Form
    {

        #region Constrtor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Variables
        StringBuilder sb = new StringBuilder();

        #endregion

        #region SystemFunctionsAndEvents
        private void displayinfo(object sender, EventArgs e)
        {
            try
            {
                #region VariableDeclaration
                //Creating an object for delegate
                myclaculator myc = null;
                int num1 = 0, num2 = 0;
                int.TryParse(txtnum1.Text, out num1);
                int.TryParse(txrNum2.Text, out num2);

                #endregion

                #region InputValidation
                Regex regex = new Regex(@"[0-9]\d$");

                if (!regex.IsMatch(txtnum1.Text))
                {
                    txtResult.Text = "Please enter Valid Numberic Value for Num 1";
                    txtnum1.Focus();
                    goto EndOfProgram;
                }
                else
                {
                    txtResult.Text = "";
                }

                if (!regex.IsMatch(txrNum2.Text))
                {
                    txtResult.Text = "Please enter Valid Numberic Value for Num 2";
                    txrNum2.Focus();
                    goto EndOfProgram;
                }
                else
                {
                    txtResult.Text = "";
                }

                string strRegex = @"^[a-z0-9][-a-z0-9._]+@([-a-z0-9]+\.)+[a-z]{2,5}$";

                Regex regex2 = new Regex(strRegex);
                if (!regex2.IsMatch(txtEmailAddress.Text))
                {
                    txtResult.Text = "Please enter Valid Email Address";
                    txtEmailAddress.Focus();
                    goto EndOfProgram;
                }
                else
                {
                    txtResult.Text = "";
                }

                #endregion
                #region DelegateAddressMapping

                for (int x = 0; x < checkedListBox1.CheckedItems.Count; x++)
                {
                    switch (checkedListBox1.CheckedItems[x].ToString())
                    {
                        case "Add":
                            myc += AddOf2Num;
                            break;
                        case "Sub":
                            myc += SubOf2Num;
                            break;
                        case "Mul":
                            myc += MulOF2Num;
                            break;
                        case "Div":
                            myc += DivOf2Num;
                            break; ;
                        case "Mod":
                            myc += Modof2Num;
                            break;
                    }
                }

                #endregion

                #region InvokingDelegate
                myc(num1, num2);
                txtResult.Text = sb.ToString();

                #endregion
            EndOfProgram:
                //Passing the values of Delegate
                string wwww;

            }

            catch (Exception ex)
            {
                txtResult.Text = ex.Message;
            }
            finally
            {
                sb.Clear();
            }

            //MessageBox.Show("Hi");
        }
        #endregion

        #region UserDefinedFunctionsAndMethods

        public void AddOf2Num(int val1, int val2)
        {
            sb.Append("The Add function is invoked. The Output is --> ");
            sb.Append(val1 + val2);
            sb.Append(Environment.NewLine);
        }

        public void SubOf2Num(int val1, int val2)
        {
            sb.Append("The Sub function is invoked. The Output is --> ");
            sb.Append(val1 - val2);
            sb.Append(Environment.NewLine);
        }

        public void MulOF2Num(int val1, int val2)
        {
            sb.Append("The Mul function is invoked. The Output is --> ");
            sb.Append(val1 * val2);
            sb.Append(Environment.NewLine);
        }

        public void DivOf2Num(int val1, int val2)
        {
            sb.Append("The Div function is invoked. The Output is --> ");
            sb.Append(val1 / val2);
            sb.Append(Environment.NewLine);
        }

        public void Modof2Num(int val1, int val2)
        {
            sb.Append("The Mod function is invoked. The Output is --> ");
            sb.Append(val1 % val2);
            sb.Append(Environment.NewLine);
        }

        #endregion

    }
    #endregion


    public class A
    {
        public void DOA()
        {
            Console.WriteLine("A");
        }
    }

    public class B
    {
        public void DOB()
        {
            Console.WriteLine("B");
        }
    }


    public class C : A, IDisposable,IEnumerable<int>
    {

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
