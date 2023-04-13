using CleanArchitecture.Application.Common.Models;
using CleanArchitecture.Application.ExternalServices.OpenWeather.Request;
using CleanArchitecture.Application.ExternalServices.OpenWeather.Response;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Common.Interfaces
{
    public interface IOpenWeatherService
    {
        Task<ServiceResult<OpenWeatherResponse>> GetCurrentWeatherForecast(OpenWeatherRequest request,
            CancellationToken cancellationToken);
    }
}