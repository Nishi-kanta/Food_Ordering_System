using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace Foodie
{
    public class Connection
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        }
    }
    public class Utils
    {
        public static bool IsValidExtension(string fileName)
        {
            bool isValid = false;
            string[] fileextension = { ".jpg", ".png", ".jpeg" };
            for(int i=0;i<=fileextension.Length-1;i++)
            {
                if (fileName.Contains(fileextension[i]))
                {
                    isValid = true;
                    break;
                }
            }
            return isValid;
        }
        // Setting Default Image  if there is no image for any job  
        public static string GetImageUrl(Object url)
        {
            string url1 = "";
            if (string.IsNullOrEmpty(url.ToString()) || url == DBNull.Value)
            {
                url1 = "../Images/NO_image.png";
            }
            else
            {
                url1 = string.Format("../{0}", url);
            }
            return url1;
        }
    }
}