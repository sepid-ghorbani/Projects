using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrintingProject
{
    public class Session
    {
        public static bool IsLogin
        {
            get
            {
                if (HttpContext.Current.Session == null) return false;
                if (HttpContext.Current.Session.Contents["UserIsLogin"] == null)
                {
                    HttpContext.Current.Session.Contents["UserIsLogin"] = false;
                }
                return (bool)HttpContext.Current.Session.Contents["UserIsLogin"];
            }
            set { HttpContext.Current.Session.Contents["UserIsLogin"] = value; }
        }
        public static Int32 UserId
        {
            get
            {
                if (HttpContext.Current.Session["UserId"] == null)
                {
                    HttpContext.Current.Session["UserId"] = 0;
                    return (Int32)HttpContext.Current.Session["UserId"];
                }
                return (Int32)HttpContext.Current.Session["UserId"];
            }
            set { HttpContext.Current.Session["UserId"] = value; }
        }
    }
}