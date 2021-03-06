﻿using ClaimProject.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClaimProject
{
    public partial class SiteMaster : MasterPage
    {
        ClaimFunction function = new ClaimFunction();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Charset = "UTF-8";

            if (Request.Cookies["ClaimLogin"] != null)
            {
                Session.Add("User", Request.Cookies["ClaimLogin"]["User"]);
                Session.Add("UserName", function.GetSelectValue("tbl_user","username = '"+ Request.Cookies["ClaimLogin"]["User"] + "'","name"));
                Session.Add("UserPrivilegeId", function.GetSelectValue("tbl_user", "username = '" + Request.Cookies["ClaimLogin"]["User"] + "'", "level"));
                Session.Add("UserPrivilege", function.GetLevel(int.Parse(Session["UserPrivilegeId"].ToString())));
                Session.Add("UserCpoint", Request.Cookies["ClaimLogin"]["UserCpoint"]);
                Session.Timeout = 60 * 24;
            }

            if (Session["User"] == null)
            {
                Response.Redirect("/Login");
            }
            else
            {
                lbUser.Text = "ยินดีต้อนรับ : " + Session["UserName"].ToString() + " : " + Session["UserPrivilege"] + " " + function.GetSelectValue("tbl_cpoint", "cpoint_id='" + Session["UserCpoint"].ToString() + "'", "cpoint_name");
                if (function.CheckLevel("Techno", Session["UserPrivilegeId"].ToString()))
                {
                    nav3.Visible = true;
                }
                else
                {
                    nav3.Visible = false;
                }

                if (!function.CheckLevel("Department", Session["UserPrivilegeId"].ToString()))
                {
                    nav0.Visible = false;
                    //nav6.Visible = false;
                }
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Session.Clear();
            Session.Contents.RemoveAll();
            Session.RemoveAll();
            Response.Cookies["ClaimLogin"].Expires = DateTime.Now.AddDays(-1);
            Response.Redirect("/");
        }

    }
}