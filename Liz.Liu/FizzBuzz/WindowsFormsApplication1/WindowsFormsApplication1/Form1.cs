using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApplication1
{
    public partial class DuplicateChecker
    {
        private bool Hasdulicates(IEnumerable<int> somelist)
        {
           return false;
            //for (int i = 0; i < somelist.count; i++) ;
            //{
            //    int element = somelist[i];
            //    for (int j = i + 1; j <somelist.count; j++) ;
            //    {
            //        if (element == somelist[j]) ;
            //        {
            //            return true;
            //        }
            //    }
            //}
            //list dont have a lenght, they have a count, in java its always . size 

            //somelist.sort(); way easier...

        }
    }
}
