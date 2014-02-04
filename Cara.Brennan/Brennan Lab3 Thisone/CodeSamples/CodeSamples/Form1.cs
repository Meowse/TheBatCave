using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CodeSamples
{
    public partial class Form1 : Form
    {
        private int _count = 1;

        public Form1()
        {
            InitializeComponent();

            DisplayCount();
        }

        private void increment_Click(object sender, EventArgs e)
        {
            // Add one to count
            _count++;

            // Add one to count
            //_count += 1;

            // Add one to _count
            // _count = _count + 1;

            DisplayCount();
        }


        private static int findMin(int[] inputs)
        {
            int min = inputs[0];
            return inputs.Concat(new[] {min}).Min();
        }

        private static int findMax(int[] inputs)
        {
            int max = inputs[0];
            return inputs.Concat(new[] {max}).Max();
        }

        private static int findMin3(IEnumerable<int> inputs)
        {
            return inputs.Min();
        }

        private static int findMax3(IEnumerable<int> inputs)
        {
            return inputs.Max();
        }

        private static int FindMax4(IEnumerable<int> inputs)
        {
            return inputs.Max();
        }

        private static int findMin4(IEnumerable<int> inputs)
        {
            return inputs.Min();
        }


//        private void OverlyLargeMethod()
//        {
//            // 10 lines of variables
//            if (something)
//            {
//                // a few lines of confusion here
//                if (somethingElse)
//                {
//                    // 50 lines
//                }
//                else
//                {
//                    // different 50 lines
//                }
//            }
//            else
//            {
//                if (somethingElse)
//                {
//                    // yet another 50 lines
//                }
//                else
//                {
//                    // I swear I'm not making this up: another different 50 lines
//                }
//            }
//        }

        private void DisplayCount()
        {
            displayCount.Text = _count.ToString();
        }

        private void doSomethingSpecial_Click(object sender, EventArgs e)
        {
            if (_count == 3)
            {
                _count = 17;
            }
            else if (_count == 5)
            {
                _count = 3;
            }
            else if (_count == 17)
            {
                _count = 9;
            }
            else switch (_count)
            {
                case 11:
                    _count = 5;
                    break;
                default:
                    _count = _count - 2;
                    break;
            }
            DisplayCount();
        }
    }
}