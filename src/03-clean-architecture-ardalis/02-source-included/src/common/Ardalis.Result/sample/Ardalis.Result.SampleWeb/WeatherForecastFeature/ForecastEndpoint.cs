﻿using Ardalis.ApiEndpoints;
using Ardalis.Result.AspNetCore;
using Ardalis.Result.Sample.Core.DTOs;
using Ardalis.Result.Sample.Core.Model;
using Ardalis.Result.Sample.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Ardalis.Result.SampleWeb.WeatherForecastFeature;

public class ForecastEndpoint : EndpointBaseSync
    .WithRequest<ForecastRequestDto>
    .WithActionResult<IEnumerable<WeatherForecast>>
{
    private readonly WeatherService _weatherService;

    public ForecastEndpoint(WeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    /// <summary>
    /// This uses an extension method to convert to an ActionResult
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    [HttpPost("/Forecast/New")]
    public override ActionResult<IEnumerable<WeatherForecast>> Handle(ForecastRequestDto request)
    {
        if (DateTime.Now.Second % 2 == 0) // just so we can show both versions
        {
            // Extension method on ControllerBase
            return this.ToActionResult(_weatherService.GetForecast(request));
        }

        Result<IEnumerable<WeatherForecast>> result = _weatherService.GetForecast(request);

        // Extension method on a Result instance (passing in ControllerBase instance)
        return result.ToActionResult(this);
    }
}
