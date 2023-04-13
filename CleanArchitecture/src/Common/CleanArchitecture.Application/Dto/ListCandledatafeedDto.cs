using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System;
using System.Collections.Generic;

namespace CleanArchitecture.Application.Dto
{
    public class ListCandledatafeedDto
    {
        public List<CandledatafeedDto> CandleData { get; }
    }


    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public CustomDateTimeConverter()
        {
            base.DateTimeFormat = "yyyy-MM-dd'T'HH:mm:ss.'000Z'";
        }
    }

    public sealed class CandledatafeedDto
    {

        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime DT { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public int Volume { get; set; }
    }
}