using CleanArchitecture.Api.Services;
using CleanArchitecture.Application.Common.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CleanArchitecture.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class MailController : BaseApiController
    {
        private readonly IMailService mailService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mailService"></param>
        public MailController(IMailService mailService)
        {
            this.mailService = mailService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost("send")]
        [EnableCors("AllowOrigin")]
        public async Task<IActionResult> SendMail([FromForm] MailRequest request)
        {
            try
            {
                await mailService.SendEmailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return Ok(ex.Message);
            }

        }
    }
}
