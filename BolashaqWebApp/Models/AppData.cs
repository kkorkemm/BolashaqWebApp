using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BolashaqWebApp.Models
{
    public class AppData
    {
        private static BolashaqDBEntities context;
        public static BolashaqDBEntities GetContext()
        {
            if (context == null)
                context = new BolashaqDBEntities();
            return context;
        }

        public static Kruzhok NewZayavka { get; set; }
        public static bool IsZayavka { get; set;}
        public static string ErrorZayavka { get; set; }
    }
}