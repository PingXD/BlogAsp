﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class CookieChecker
    {
        public static bool CookieCheckeBool() => DAL.CookieChecker.CookieCheacker();
    }
}
