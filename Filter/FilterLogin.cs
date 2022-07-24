using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Web.Mvc.Filters;
using System.Web;

namespace Project2.Filter
{
    public class Custom_Authentication : IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            //if (string.IsNullOrEmpty(Convert.ToString(filterContext.HttpContext.Sesstion["sd"])))
            //{
            //    filterContext.Re
            //}

        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            throw new NotImplementedException();
        }
    }


}
