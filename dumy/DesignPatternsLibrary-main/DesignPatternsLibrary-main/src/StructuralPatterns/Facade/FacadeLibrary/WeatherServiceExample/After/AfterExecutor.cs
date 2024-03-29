﻿using System.Globalization;
using BuildingBlocks;
using FacadeLibrary.WeatherServiceExample.After.TemperatureFacade;

namespace FacadeLibrary.WeatherServiceExample.After;

public static class AfterExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Weather service example - after");

        const string zipCode = "83714";
        var temperatureService = new TemperatureLookupService();
        var localTemperature = temperatureService.GetTemperature(zipCode);

        Console.WriteLine(
            "The current temperature is {0}F/{1}C in {2}, {3}",
            localTemperature.Fahrenheit.ToString("F1", CultureInfo.InvariantCulture),
            localTemperature.Celsius.ToString("F1", CultureInfo.InvariantCulture),
            localTemperature.City,
            localTemperature.State);
    }
}
