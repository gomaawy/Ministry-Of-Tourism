using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    static class Global
    {
        private static string id = "";
        private static string idlog = "";

        public static string GlobalVar
        {
            get { return id; }
            set { id = value; }
        }
        public static string globalid
        {
            get { return idlog; }
            set { idlog = value; }
        }
    }
}
