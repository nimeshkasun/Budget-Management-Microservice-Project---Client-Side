using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw1_w1867890.M
{
    public class CategoryModel
    {
        
        private int CatId { get; set; }
        private String CatName { get; set; }
        private String CatType { get; set; }
        private Double CatBudget { get; set; }

        public CategoryModel()
        {
            
        }

        public CategoryModel(int CategoryId, String CategoryName, String CatType, Double CatBudget)
        {
            this.CatId = CategoryId;
            this.CatName = CategoryName;
            this.CatType = CatType; 
            this.CatBudget = CatBudget;
        }


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
