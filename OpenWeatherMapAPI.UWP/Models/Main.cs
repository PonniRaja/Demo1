/*
 * OpenWeatherMapAPI.UWP
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenWeatherMapAPI.UWP;
using OpenWeatherMapAPI.UWP.Utilities;


namespace OpenWeatherMapAPI.UWP.Models
{
    public class Main : BaseModel 
    {
        // These fields hold the values for the public properties.
        private double? temp;
        private int? pressure;
        private int? humidity;
        private double? tempMin;
        private double? tempMax;
        private double? seaLevel;
        private double? grndLevel;

        /// <summary>
        /// Temperature. Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
        /// </summary>
        [JsonProperty("temp")]
        public double? Temp 
        { 
            get 
            {
                return this.temp; 
            } 
            set 
            {
                this.temp = value;
                onPropertyChanged("Temp");
            }
        }

        /// <summary>
        /// Atmospheric pressure (on the sea level, if there is no sea_level or grnd_level data), hPa
        /// </summary>
        [JsonProperty("pressure")]
        public int? Pressure 
        { 
            get 
            {
                return this.pressure; 
            } 
            set 
            {
                this.pressure = value;
                onPropertyChanged("Pressure");
            }
        }

        /// <summary>
        /// Humidity, %
        /// </summary>
        [JsonProperty("humidity")]
        public int? Humidity 
        { 
            get 
            {
                return this.humidity; 
            } 
            set 
            {
                this.humidity = value;
                onPropertyChanged("Humidity");
            }
        }

        /// <summary>
        /// Minimum temperature at the moment. This is deviation from current temp that is possible for large cities and megalopolises geographically expanded (use these parameter optionally). Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
        /// </summary>
        [JsonProperty("temp_min")]
        public double? TempMin 
        { 
            get 
            {
                return this.tempMin; 
            } 
            set 
            {
                this.tempMin = value;
                onPropertyChanged("TempMin");
            }
        }

        /// <summary>
        /// Maximum temperature at the moment. This is deviation from current temp that is possible for large cities and megalopolises geographically expanded (use these parameter optionally). Unit Default: Kelvin, Metric: Celsius, Imperial: Fahrenheit.
        /// </summary>
        [JsonProperty("temp_max")]
        public double? TempMax 
        { 
            get 
            {
                return this.tempMax; 
            } 
            set 
            {
                this.tempMax = value;
                onPropertyChanged("TempMax");
            }
        }

        /// <summary>
        /// Atmospheric pressure on the sea level, hPa
        /// </summary>
        [JsonProperty("sea_level")]
        public double? SeaLevel 
        { 
            get 
            {
                return this.seaLevel; 
            } 
            set 
            {
                this.seaLevel = value;
                onPropertyChanged("SeaLevel");
            }
        }

        /// <summary>
        /// Atmospheric pressure on the ground level, hPa
        /// </summary>
        [JsonProperty("grnd_level")]
        public double? GrndLevel 
        { 
            get 
            {
                return this.grndLevel; 
            } 
            set 
            {
                this.grndLevel = value;
                onPropertyChanged("GrndLevel");
            }
        }
    }
} 