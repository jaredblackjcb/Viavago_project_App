﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Viavago_project
{
    public partial class Viavago : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegister_OnServerClick(object sender, EventArgs e)
        {
            if(txtRegisterPassword.Text == txtConfirmPassword.Text)
            {

            }
        }
    }
}