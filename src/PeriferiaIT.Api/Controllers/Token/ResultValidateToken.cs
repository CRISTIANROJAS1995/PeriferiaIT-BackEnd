using System.Security.Claims;

namespace PeriferiaIT.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class ResultValidateToken
    {
        public ClaimsPrincipal Principal { get; set; }
        public string Message { get; set; }
        public bool Result { get; set; }
    }
}