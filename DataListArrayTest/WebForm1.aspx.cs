using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DataListArrayTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] arr1 = new int[3];
            arr1[0] = 1;
            arr1[1] = 11;
            arr1[2] = 111;

            int[] arr2 = new int[3];
            arr2[0] = 2;
            arr2[1] = 22;
            arr2[2] = 222;

            GridView1.DataSource = ArraysToDatatable(arr1, arr2);
            GridView1.DataBind();
        }

        public DataTable ArraysToDatatable(int[] arr1, int[] arr2)
        {
            //create the table
            DataTable dt = new DataTable();
            
            //add the colums. number og columns same as number of elements in array
            foreach(int i in arr1)
                dt.Columns.Add(new DataColumn());
            dt.AcceptChanges();
            //add rows to table with the content
            DataRow dr1 = dt.NewRow();
            DataRow dr2 = dt.NewRow();
            for(int i=0;i<arr1.Length;i++)
            {
                dr1[i] = arr1[i];
                dr2[i] = arr2[i];
            }
            dt.Rows.Add(dr1);//adds row to table
            dt.Rows.Add (dr2);
            
            return dt;
        }
    }
}