using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Paidev.Web.Etc
{
    public partial class Delegate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private delegate int Compare(int a, int b);

        private int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        private int DescendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (1 == b)
                return 0;
            else
                return -1;
        }

        private void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        protected void btnCompare_Button(object sender, EventArgs e)
        {
            int[] array = new [] { 0, 0, 0, 0, 0 };
            int[] array2 = new[] { 0, 0, 0, 0, 0 };

            string[] temp = this.txtCompare1.Text.ToString().Split(',');
            string[] temp2 = this.txtCompare2.Text.ToString().Split(',');

            for (int i = 0; i < temp.Length; i++)
            {
                array[i] = Convert.ToInt32(temp[i]);                
            }
            for (int i = 0; i < temp2.Length; i++)
            {
                array2[i] = Convert.ToInt32(temp2[i]);
            }

            this.lblResult1.Text = "Sorting ascending...";
            this.lblResult2.Text = "Sorting descending...";

            BubbleSort(array, new Compare(AscendCompare));

            for (int i = 0; i < array.Length; i++)
            {
                this.lblResult1.Text += array[i];
            }

            BubbleSort(array2, new Compare(DescendCompare));

            for (int i = 0; i < array2.Length; i++)
            {
                this.lblResult2.Text += array2[i];
            }
        }
    }
}