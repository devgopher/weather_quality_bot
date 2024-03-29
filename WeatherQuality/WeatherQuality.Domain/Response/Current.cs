﻿using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace WeatherQuality.Domain.Response;

public class Current
{
    [JsonPropertyName("time")]
    [JsonProperty("time")]
    public string? Time { get; set; }

    [JsonPropertyName("interval")]
    [JsonProperty("interval")]
    public int? Interval { get; set; }

    [JsonPropertyName("european_aqi")]
    [JsonProperty("european_aqi")]
    public int? EuropeanAqi { get; set; }

    [JsonPropertyName("pm10")]
    [JsonProperty("pm10")]
    public double? Pm10 { get; set; }

    [JsonPropertyName("pm2_5")]
    [JsonProperty("pm2_5")]
    public double? Pm25 { get; set; }

    [JsonPropertyName("carbon_monoxide")]
    [JsonProperty("carbon_monoxide")]
    public double? CarbonMonoxide { get; set; }

    [JsonPropertyName("nitrogen_dioxide")]
    [JsonProperty("nitrogen_dioxide")]
    public double? NitrogenDioxide { get; set; }

    [JsonPropertyName("sulphur_dioxide")]
    [JsonProperty("sulphur_dioxide")]
    public double? SulphurDioxide { get; set; }

    [JsonPropertyName("ozone")]
    [JsonProperty("ozone")]
    public double? Ozone { get; set; }

    [JsonPropertyName("aerosol_optical_depth")]
    [JsonProperty("aerosol_optical_depth")]
    public double? AerosolOpticalDepth { get; set; }

    [JsonPropertyName("dust")]
    [JsonProperty("dust")]
    public double? Dust { get; set; }

    [JsonPropertyName("uv_index")]
    [JsonProperty("uv_index")]
    public double? UvIndex { get; set; }

    [JsonPropertyName("uv_index_clear_sky")]
    [JsonProperty("uv_index_clear_sky")]
    public double? UvIndexClearSky { get; set; }

    [JsonPropertyName("ammonia")]
    [JsonProperty("ammonia")]
    public double? Ammonia { get; set; }

    [JsonPropertyName("alder_pollen")]
    [JsonProperty("alder_pollen")]
    public double? AlderPollen { get; set; }

    [JsonPropertyName("birch_pollen")]
    [JsonProperty("birch_pollen")]
    public double? BirchPollen { get; set; }

    [JsonPropertyName("grass_pollen")]
    [JsonProperty("grass_pollen")]
    public double? GrassPollen { get; set; }

    [JsonPropertyName("mugwort_pollen")]
    [JsonProperty("mugwort_pollen")]
    public double? MugwortPollen { get; set; }

    [JsonPropertyName("olive_pollen")]
    [JsonProperty("olive_pollen")]
    public double? OlivePollen { get; set; }

    [JsonPropertyName("ragweed_pollen")]
    [JsonProperty("ragweed_pollen")]
    public double? RagweedPollen { get; set; }
}