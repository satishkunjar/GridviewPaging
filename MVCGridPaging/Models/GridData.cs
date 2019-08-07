using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGridPaging.Models
{
    public class GridData
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
    
        public string Department { get; set; }
        public DateTime? JoiningDate { get; set; }       
    }
}