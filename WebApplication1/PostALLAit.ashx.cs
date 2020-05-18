﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Model;
using BLL;
using Newtonsoft.Json;
using System.Data;
namespace WebApplication1
{
    /// <summary>
    /// PostALLAit 的摘要说明
    /// </summary>
    public class PostALLAit : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {

            int id;
            DataTable ds=null;
            string get = context.Request.Form["article_idd"];
            if (get=="全部")
            {
                
                ds = BLL.Art.GetAitAllA();
                context.Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(ds));
            }
            else
            {

                articles art = new articles();
                if (get!="")
                {
                    ds = Art.GetAitAll(Convert.ToInt32(get));
                    DataRow dr = ds.Rows[0];
                    art.article_title = dr["article_title"].ToString();
                    art.article_content = dr["article_content"].ToString();
                    context.Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(art));

                }
                    
                
                    
                   
                


                //context.Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(art));
            }

            //articles art = new articles();
            //if (ds !=null)
            //{
            //    DataRow dr = ds.Rows[0];
            //    art.article_title = dr["article_title"].ToString();
            //    art.article_content = dr["article_content"].ToString();
            //}


            //context.Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(art));



        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}