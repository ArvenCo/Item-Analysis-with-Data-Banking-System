using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatic_Item_Analysis_and_Data_Banking_System
{
    internal class Formula
    {
        //Connect cnt = new Connect();
        public int getTwentySeven(int i)
        {
            //GET 27% SAMPLE OF STUDENTS
            i = (27/100) * i;
            return i;
        }

        public int getHigh(int num,List <int> itemList)
        {
            int correctItems=0;
            
            num = getTwentySeven(num);

            for (int i = 0; i < num; i++)//<--------------------Sum of all Correct items from Upper of total
            {
                correctItems += itemList[i];
            }
            return correctItems;
        }

        public int getLow(int num, List<int> itemList)
        {
            int correctItems =0;
            int total = num;
            num = (total - getTwentySeven(total)) - 1;

            for (int i = num; i < total; i++)
            {
                correctItems += itemList[i];
            }

            return correctItems;
        }


        public double P_VALUE(List<int> itemList)
        {///DIFICULTY INDEX [P-VALUE];
            
            double pValue = 0;                           //DIFICULIT INDEX OF AN ITEM
            
            int total = itemList.Count;
            int Ru = getHigh(total, itemList),                                         //THE NUMBER OF UPPER GROUP;
                Rl = getLow(total, itemList);                                     //THE NUMEBR OF LOWER GROUP;
             

            pValue = (Ru + Rl) / total;
            
            return pValue;
        }
            
        public double discriminationIndex(List<int> itemList)
        {
             
            double DI = 0;                                                      //THE DISCRIMINITION INDEX OF AN ITEM
            int total = itemList.Count(),
                Ru = getHigh(total,itemList),                                         //THE NUMBER OF UPPER GROUP;
                Rl = getLow(total, itemList);                                     //THE NUMEBR OF LOWER GROUP; 
                                                                                // THE TOTAL NUMBER OF STUDENTS;
            
           
            DI = (Ru - Rl) / (0.5 * total);
            return DI;
        }



        public string descIterpretation(double descIndex) {
            string[] decision = {"Very Good", "Reasonably Good", "Marginal","Poor" };
            int i = 0;
            if (descIndex >= 0.4) { i = 0; }
            if (descIndex >= 0.3) { i = 1; }
            if (descIndex >= 0.2) { i = 2; }
            if (descIndex <= 0.19) { i = 3; }
            return decision[i];

        }

        public string dfcltInterpretation(double diffIndex) {
            string interp = " ";

            if (diffIndex >= 0.2) { interp = "Very Good"; }
            if (diffIndex >= 0.3) { interp = "Reasonably Good"; }
            if (diffIndex >= 0.2) { interp = "Marginal"; }
            if (diffIndex <= 0.19) { interp = "Poor"; }
            
            return interp;
        }

        public string finalDec(string desc, string diff) {
            string fD = " ";
            if (desc == "Very Good" && diff == "Easy") { fD = "Revise"; }
            if (desc == "Reasonably Good" && diff == "Easy") { fD = "Revise"; }
            if (desc == "Marginal" && diff == "Easy") { fD = "Revise"; }
            if (desc == "Poor" && diff == "Easy") { fD = "Reject"; }
            if (desc == "Poor" && diff == "Diffcult") { fD = "Revise"; }
            if (desc == "Poor" && diff == "Average") { fD = "Revise"; }
            else { fD = "Retain"; } 
            return fD;
        }
    }
}
