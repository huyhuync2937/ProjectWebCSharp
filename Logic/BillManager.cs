using Microsoft.Data.SqlClient;
using Project2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Project2.DataAccess;

namespace Project2.Logic
{
    public class BillManager
    {
        private static List<Bill> ConvertToListBill(DataTable dt)
        {
            List<Bill> BillList = new List<Bill>();
            foreach (DataRow dr in dt.Rows)
            {
                BillList.Add(new Bill(
                   Convert.ToInt32(dr[0]),
                    dr[1].ToString(),
                    Convert.ToInt32(dr[2]),
                    Convert.ToInt32(dr[3]),
                    Convert.ToInt32(dr[4]),
                    Convert.ToDateTime(dr[5]),
                    Convert.ToBoolean(dr[6]),
                    Convert.ToInt32(dr[7])
                   ));
            }
            return BillList;
        }
    


      

    }
}