﻿using Flurl;
using Flurl.Http;
using Microsoft.Extensions.Logging;
using WeatherQuality.Domain.Request;
using WeatherQuality.Domain.Response;

namespace WeatherQuality.Integration;

public class OpenMeteoIntegration : IIntegration
{
    private ILogger<OpenMeteoIntegration> _logger;
    private string _baseUrl = "https://air-quality-api.open-meteo.com/v1/air-quality";

    public OpenMeteoIntegration(ILogger<OpenMeteoIntegration> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Gets air quality results
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public async Task<Response> GetAirQualityAsync(Request request)
    {
        try
        {
            var result = await _baseUrl
                .SetQueryParams(request)
                .GetJsonAsync<Response>();

            result.IsSuccess = true;

            return result;
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error: {ex.Message}", ex);

            return new Response()
            {
                IsSuccess = false,
                Error = ex.Message
            };
        }
    }
}