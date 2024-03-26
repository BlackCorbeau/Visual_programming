using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend
{
    class backend_for_Picture_list
    {
        public string Initialize_picture(int pucture_number)
        {
            string adress = "C:\\Users\\woron\\OneDrive\\Документы\\Code\\Visual_programming\\work2_var2\\work2_var2\\Pictures\\";
            string picture_name = pucture_number.ToString() + ".jpg";
            adress += picture_name;
            return adress;
        }
    }
}