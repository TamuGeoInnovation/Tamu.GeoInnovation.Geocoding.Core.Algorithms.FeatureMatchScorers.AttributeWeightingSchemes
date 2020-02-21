using Newtonsoft.Json;
using System;

namespace USC.GISResearchLab.Geocoding.Core.Algorithms.FeatureMatchScorers
{
    [Serializable]
    public class AttributeWeightingScheme
    {
        #region Properties

        [JsonIgnore]
        public bool ShouldTakeAddressRangeHouseUncertaintyPenalty { get; set; }

        public double WeightNumber { get; set; }
        public double WeightNumberParity { get; set; }
        public double WeightPreDirectional { get; set; }
        public double WeightPreType { get; set; }
        public double WeightPreQualifier { get; set; }
        public double WeightPreArticle { get; set; }
        public double WeightName { get; set; }
        public double WeightPostArticle { get; set; }
        public double WeightSuffix { get; set; }
        public double WeightPostDirectional { get; set; }
        public double WeightPostQualifier { get; set; }
        public double WeightCity { get; set; }
        public double WeightZip { get; set; }
        public double WeightZipPlus4 { get; set; }
        public double WeightState { get; set; }
        [JsonIgnore]
        public double MaxBlocksAway { get; set; }

        public double TotalWeight { get { return WeightNumber + WeightNumberParity + WeightPreDirectional + WeightPreType + WeightPreQualifier + WeightPreArticle + WeightName + WeightPostArticle + WeightSuffix + WeightPostDirectional + WeightPostQualifier + WeightCity + WeightZip + WeightState; } }

        [JsonIgnore]
        public double ProportionalWeightNumber { get { return WeightNumber / TotalWeight; } }
        [JsonIgnore]
        public double ProportionalWeightNumberParity { get { return WeightNumberParity / TotalWeight; } }
        [JsonIgnore]
        public double ProportionalWeightPreDirectional { get { return WeightPreDirectional / TotalWeight; } }
        [JsonIgnore]
        public double ProportionalWeightPreType { get { return WeightPreType / TotalWeight; } }
        [JsonIgnore]
        public double ProportionalWeightPreQualifier { get { return WeightPreQualifier / TotalWeight; } }
        [JsonIgnore]
        public double ProportionalWeightPreArticle { get { return WeightPreArticle / TotalWeight; } }
        [JsonIgnore]
        public double ProportionalWeightName { get { return WeightName / TotalWeight; } }
        [JsonIgnore]
        public double ProportionalWeightPostArticle { get { return WeightPostArticle / TotalWeight; } }
        [JsonIgnore]
        public double ProportionalWeightSuffix { get { return WeightSuffix / TotalWeight; } }
        [JsonIgnore]
        public double ProportionalWeightPostDirectional { get { return WeightPostDirectional / TotalWeight; } }
        [JsonIgnore]
        public double ProportionalWeightPostQualifier { get { return WeightPostQualifier / TotalWeight; } }
        [JsonIgnore]
        public double ProportionalWeightCity { get { return WeightCity / TotalWeight; } }
        [JsonIgnore]
        public double ProportionalWeightZip { get { return WeightZip / TotalWeight; } }
        [JsonIgnore]
        public double ProportionalWeightZipPlus4 { get { return WeightZipPlus4 / TotalWeight; } }
        [JsonIgnore]
        public double ProportionalWeightState { get { return WeightState / TotalWeight; } }

        #endregion

        public AttributeWeightingScheme()
        {
        }


        public AttributeWeightingScheme(double weightNumber, double weightNumberParity, double weightPreDirectional, double weightPreQualifier, double weightPreType, double weightPreArticle, double weightName, double weightPostArticle, double weightSuffix, double weightPostQualifier, double weightPostDirectional, double weightCity, double weightZip, double weightZipPlus4, double weightState)
        {
            WeightNumber = weightNumber;
            WeightNumberParity = weightNumberParity;
            WeightCity = weightCity;
            WeightName = weightName;
            WeightPostArticle = weightPostArticle;
            WeightPostDirectional = weightPostDirectional;
            WeightPostQualifier = weightPostQualifier;
            WeightPreArticle = weightPreArticle;
            WeightPreDirectional = weightPreDirectional;
            WeightPreType = weightPreType;
            WeightPreQualifier = weightPreQualifier;
            WeightSuffix = weightSuffix;
            WeightZip = weightZip;
            WeightZipPlus4 = weightZipPlus4;
            WeightState = weightState;
        }
    }
}
