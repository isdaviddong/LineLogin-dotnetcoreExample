using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using isRock.LineBot.Extensions;

namespace LineLogin.Pages
{
    public class indexModel : PageModel
    {
        public IConfigurationSection Channel_ID, Channel_Secret, CallbackURL;

        [BindProperty]
        public string txb_token { get; set; }
        [BindProperty]
        public string txb_email { get; set; }
        [BindProperty]
        public string txb_area1 { get; set; }
        public indexModel(IConfiguration config)
        {
            Channel_ID = config.GetSection("LINE-Login-Setting:Channel_ID");
            Channel_Secret = config.GetSection("LINE-Login-Setting:Channel_Secret");
            CallbackURL = config.GetSection("LINE-Login-Setting:CallbackURL");
        }

        public void OnGet()
        {
            this.txb_token = HttpContext.Request.Query["token"].ToString();
            this.txb_email = HttpContext.Request.Query["email"].ToString();
        }

        public void OnPostGetUserProfile()
        {
            //利用access_token取得用戶資料
            var user = isRock.LineLoginV21.Utility.GetUserProfile(this.txb_token);
            txb_area1 = user.ToJson();
        }
    }
}