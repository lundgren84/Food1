using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokeBowlWebApplication.Services
{
    public class CookieService
    {
        public string Get(string cookie)
        {
            return HttpContext.Current.Request.Cookies[cookie]?.Value;
        }

        public void Set(string cookie, string value)
        {
            HttpContext.Current.Response.Cookies.Add(new HttpCookie(cookie) { Value = value, Expires = DateTime.Now.AddYears(1) });
        }

        public void Remove(string cookie)
        {
            if (HttpContext.Current.Request.Cookies[cookie] == null) return;

            var cookieToDelete = HttpContext.Current.Request.Cookies[cookie];
            cookieToDelete.Expires = DateTime.Now.AddDays(-1d);
            HttpContext.Current.Request.Cookies.Add(cookieToDelete);
        }
    }
}