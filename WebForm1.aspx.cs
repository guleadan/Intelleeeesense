using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Intellisense
{
    public partial class Intel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cars = new List<string>() { "Toyota Avalon", "Toyota Camry", "Toyota Corolla", "Toyota Corolla Hybrid",
                                             "Honda City", "Honda BR-V", "Honda CR-v", "Honda Civic", "Honda Accord",
                                             "Audi A4",  "Audi A5", "Audi e-tron GT", "Audi e-tron", "Audi Q7",
                                             "Mercedes GLA SUV", "Mercedes GLB SUV","Mercedes G-Class SUV", "A-Class Sedan" };


        }
        [WebMethod]
        public static List<string> GenerateList(string txt, int length)
        {
            var cars = new List<string>() { "Toyota Avalon", "Toyota Camry", "Toyota Corolla", "Toyota Corolla Hybrid",
                                             "Honda City", "Honda BR-V", "Honda CR-v", "Honda Civic", "Honda Accord",
                                             "Audi A4",  "Audi A5", "Audi e-tron GT", "Audi e-tron", "Audi Q7",
                                             "Mercedes GLA SUV", "Mercedes GLB SUV","Mercedes G-Class SUV", "A-Class Sedan" };
            var optList = new List<string>();

            if (length == 1)
            {
                for (int j = 0; j < cars.Count; j++)
                {
                    if (cars[j][0] == Convert.ToChar(txt))
                    {
                        optList.Add(cars[j]);
                    }

                }
                optList.Add(Convert.ToString(optList.Count));


            }
            return optList;
        }
    }
}