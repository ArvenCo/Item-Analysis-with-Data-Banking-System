using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


//using MySql.Data.MySqlClient;

namespace Automatic_Item_Analysis_and_Data_Banking_System
{

    internal class Connect
    {
        // EDIT NECESSARY CLIENTS INPUT FOR CONNECTION
        //MySqlConnection conn = new MySqlConnection("Data Source=localhost;port=3306;username=root;password=;Database='*****'");


        public List<string> getListofItems()
        {   List<string> listofItems = new List<string>();
            return  listofItems;
        }
        public List<int> itemStatuss(String testID, String subjectID, String classID)
        { //<<< A DESC LIST OF STUDENT'S ITEM STATUS (1 OR 0);
            List<int> ivs = new List<int>();
            ivs.Clear();
            //MySqlDataReader ivsReader;
            //MySqlCommand ivsCMD;
            //try
            //{
            //    conn.Open();
            //    ivsCMD = new MySqlCommand("SELECT 'ITEM_STATUS' FROM 'TABLE(S)' WHERE 'Item' 'TEST_ID' = '" + testID + "' AND" +
            //        " 'SUBJECT_ID' = '" + subjectID + "' AND 'CLASS_ID' = '" + classID + "' AND ORDER BY 'TOTAL_SCORE' DESC", conn);
            //    ivsReader = ivsCMD.ExecuteReader();
            //    while (ivsReader.Read())
            //    {
            //        ivs.Add(ivsReader.GetInt32("'ITEM_STATUS'")); // expected value 1 or 0
            //    }
            //    ivsReader.Close();
            //}
            //catch (MySqlException e) { Console.Error.WriteLine(e.Message + " - onnect.itemStatus"); }
            //finally { conn.Close(); }
            return ivs;
        }

        public List<int> scoreList(String testID, String subjectID, String classID)
        { // A DESC LIST OF SCORES OF STUDENTS 
            List<int> sList = new List<int>();
            //sList.Clear();
            //MySqlDataReader slReader;
            //MySqlCommand slCMD;
            //try
            //{
            //    conn.Open();
            //    slCMD = new MySqlCommand("SELECT 'TOTAL_SCORE' FROM 'TABLE(S) WHERE 'TEST_ID' = '" + testID + "' AND" +
            //        " 'SUBJECT_ID' = '" + subjectID + "' AND 'CLASS_ID' = '" + classID + "' AND ORDER BY 'TOTAL_SCORE' DESC'", conn);
            //    slReader = slCMD.ExecuteReader();
            //    while (slReader.Read())
            //    {
            //        sList.Add(slReader.GetInt32("TOTAL_SCORE"));
            //    }
            //    slReader.Close();
            //}
            //catch (MySqlException e) { Console.Error.WriteLine(e.Message + " - Connect.scoreList"); }
            //finally { conn.Close(); }
            return sList;
        }
    }
}
