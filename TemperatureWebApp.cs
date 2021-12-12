using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TemperatureWebApp
{
    /// <summary>
    /// Summary description for WebTempService
    /// </summary>
    [WebService(Namespace = "http://temperatureV.J.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebTempService : System.Web.Services.WebService
    {
        int celsius;
        int farenheit;
        int kelvin;


        [WebMethod]
        public int Fahrenheit(int num, string key)
        {
            WebTempService obj = new WebTempService();

            if (key == "farenheit" || key == "celcius" || key == "kelvin")
            {
                celsius = (int)(num - 32) * 5 / 9;
                farenheit = num;
                kelvin = (int)((int)(num - 32) * 5 / 9 + 273.15);

                if (key == "celcius")
                {
                    return celsius;
                }
                else if (key == "kelvin")
                {
                    return kelvin;
                }
            }

            return farenheit;


        }
        [WebMethod]
        public int Celsius(int num, string key)
        {
            WebTempService obj = new WebTempService();

            if (key == "farenheit" || key == "celcius" || key == "kelvin")
            {

                celsius = num;
                farenheit = (int)(num * 1.8) + 32;
                kelvin = (int)(num + 273.15);

                if (key == "farenheit")
                {
                    return farenheit;
                }
                else if (key == "kelvin")
                {
                    return kelvin;
                }
            }
            return celsius;

        }
        [WebMethod]
        public int Kelvin(int num, string key)
        {
            WebTempService obj = new WebTempService();

            if (key == "farenheit" || key == "celcius" || key == "kelvin")
            {
                celsius = (int)(num - 273.15);
                farenheit = (int)(num - 273.15) * 9 / 5 + 32;
                kelvin = num;

                if (key == "farenheit")
                {
                    return farenheit;
                }
                else if (key == "celcius")
                {
                    return celsius;
                }
            }
            return kelvin;

        }

    }
}