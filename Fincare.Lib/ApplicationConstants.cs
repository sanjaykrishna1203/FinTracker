﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FincTracker.Lib
{

    public class ApplicationConstants
    {
        public static string UserName = "username";
        public static string UserRefId = "userrefid";
        public static int SessionAndCookieTimeOut = 10;
    }
}
//Scaffold-DbContext "Server=LAPTOP-UGES29ES\SQLEXPRESS;Database=FinTracker;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entity -f