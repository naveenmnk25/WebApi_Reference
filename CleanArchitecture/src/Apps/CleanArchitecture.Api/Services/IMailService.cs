using CleanArchitecture.Application.Common.Models;
using System.Threading.Tasks;

namespace CleanArchitecture.Api.Services
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMailService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mailRequest"></param>
        /// <returns></returns>
        Task SendEmailAsync(MailRequest mailRequest);
        //Task SendWelcomeEmailAsync(WelcomeRequest request);
    }
}

