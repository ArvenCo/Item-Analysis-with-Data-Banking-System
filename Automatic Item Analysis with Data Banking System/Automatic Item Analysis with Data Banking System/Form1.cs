using Automatic_Item_Analysis_and_Data_Banking_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_Item_Analysis_with_Data_Banking_System
{
    public partial class Form1 : Form
    {

        Formula formula = new Formula();
        Connect cnt = new Connect();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Beginbtn_Click(object sender, EventArgs e)
        {
           
           
            List<string> itemList = cnt.getListofItems();
            int i = 0;
            foreach (string item in itemList)
            {
                List<int> item_statusList = cnt.itemStatuss(item, "subjectID", "classID");

                int PH = formula.getHigh(item_statusList.Count, item_statusList);
                int PL = formula.getLow(item_statusList.Count, item_statusList);

                double pvalue = formula.P_VALUE(item_statusList);
                double dIndex = formula.discriminationIndex(item_statusList);

                string difficulty = formula.dfcltInterpretation(pvalue); 
                string descrimination = formula.descIterpretation(dIndex);
                
               
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[i].Clone();
                row.Cells["Items"].Value = i;
                row.Cells["Items_Right"].Value = PH.ToString() + "-" + PL.ToString() ;

                row.Cells["DI"].Value = dIndex.ToString()+ " - " +descrimination;
                row.Cells["Item_Difficulty"].Value = pvalue.ToString() + " - " + difficulty;

                row.Cells["Final_Decision"].Value = formula.finalDec(descrimination,difficulty);



                i++;
            }
          
        }
    }
}
