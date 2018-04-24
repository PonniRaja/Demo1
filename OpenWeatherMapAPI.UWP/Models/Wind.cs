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
    public class Wind : BaseModel 
    {
        // These fields hold the values for the public properties.
        private double? speed;
        private int? deg;

        /// <summary>
        /// Wind speed. Unit Default: meter/sec, Metric: meter/sec, Imperial: miles/hour.
        /// </summary>
        [JsonProperty("speed")]
        public double? Speed 
        { 
            get 
            {
                return this.speed; 
            } 
            set 
            {
                this.speed = value;
                onPropertyChanged("Speed");
            }
        }

        /// <summary>
        /// Wind direction, degrees (meteorological)
        /// </summary>
        [JsonProperty("deg")]
        public int? Deg 
        { 
            get 
            {
                return this.deg; 
            } 
            set 
            {
                this.deg = value;
                onPropertyChanged("Deg");
            }
        }
    }
} 