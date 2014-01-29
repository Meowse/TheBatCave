using System;
using System.Linq;
using System.Runtime.Remoting.Services;
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



        private int AverageMaxAndMin(int[] inputs)
        {
            int biggest = inputs[0];
            int smallest = inputs[0];
            foreach (int input in inputs)
            {
                if (biggest > input)
                {
                    biggest = input;
                }
                if (smallest < input)
                {
                    smallest = input;
                }
            }
            return (biggest + smallest) / 2;
        }

        private int AverageMaxAndMin2(int[] inputs)
        {
            int max = findMax(inputs);
            int min = findMin(inputs);
            return (max + min) / 2;
        }

        private int findMin(int[] inputs)
        {
            int min = inputs[0];
            foreach (int input in inputs)
            {
                if (min > input)
                {
                    min = input;
                }
            }
            return min;
        }

        private int findMax(int[] inputs)
        {
            int max = inputs[0];
            foreach (int input in inputs)
            {
                if (max < input)
                {
                    max = input;
                }
            }
            return max;
        }

        private int AverageMaxAndMin3(int[] inputs)
        {
            int max = findMax3(inputs);
            int min = findMin3(inputs);
            return (max + min) / 2;
        }

        private int findMin3(int[] inputs)
        {
            return inputs.Min();
        }

        private int findMax3(int[] inputs)
        {
            return inputs.Max();
        }

        private int AverageMaxAndMin4(int[] inputs)
        {
            string initializedToFred = "Fred";

            int[] newArray = {1, 3, 5};
            int[] newArray2 = new int [] { 1, 3, 5 };

            // newArray[0] == 1
            // newArray[1] == 3
            // newArray[2] == 5
            // newArray[3] == <an ArrayIndexOutOfBoundsException>
            // newArray[-1] == <an ArrayIndexOutOfBoundsException>

            newArray[1] = 7;

            // At this point, newArray has the values "1, 7, 5"
            // and newArray2 has the values "1, 3, 5"

            for (int i = 1; i < newArray.Length; i++)
            {
                // do something with newArray[i];
            }


            int something = findMax4(newArray);

            int max = findMax4(inputs);
            int min = findMin4(inputs);
            return (max + min) / 2;
        }

        private static int findMax4(int[] inputs)
        {
            return inputs.Max();
        }

        private int findMin4(int[] inputs)
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
            else if (_count == 11)
            {
                _count = 5;
            }
            else
            {
                _count = _count - 2;
            }
            DisplayCount();
        }
    }
}
