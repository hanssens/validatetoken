using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidateToken
{
    public class RequireSessionKey : ActionFilterAttribute
    {
        public string TokenFieldName { get; set; }

        public RequireSessionKey(string tokenFieldName)
        {
            this.TokenFieldName = tokenFieldName;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string token = null;

            try
            {
                // Fetch the provided token
                if (filterContext != null)
                    token = filterContext.HttpContext.Request.Headers.GetValues(TokenFieldName).FirstOrDefault();
            }
            catch (ArgumentException)
            {
                // Token/SessionKey hasn't been provided
            }
            catch (Exception ex)
            {
                // Something awful happened here...
                throw ex;
            }

            // Validate token
            if (!IsValidToken(token))
                throw new UnauthorizedAccessException("Invalid token");

            // Finish executing the action
            base.OnActionExecuting(filterContext);
        }

        public virtual bool IsValidToken(string token)
        {
            if (String.IsNullOrEmpty(token))
                return false;

            return (token == "12345");
        }

    }
}