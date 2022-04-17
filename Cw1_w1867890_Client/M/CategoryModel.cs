using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw1_w1867890.M
{
    public class CategoryModel
    {
        public Boolean DataFieldsFilledCheck(String catName, int catTypeIndex, String catBudget)
        {
            if (catName != "" && catTypeIndex != -1)
            {
                if (catTypeIndex == 1)
                {
                    if (catBudget != "")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
