using System.Collections.Generic;
using ColorCode.Data.Contracts;
using ColorCode.Data.Entities;

namespace ColorCode.Data.Implementations
{
    /// <summary>
    /// Data Provider Implementation
    /// </summary>
    public class ColorCodeData : IColorCodeData
    {
        #region Private Members
        private static Dictionary<string, ColorDataEntity> _colorCodeData;
        #endregion

        public ColorCodeData()
        {
            _colorCodeData = _colorCodeData ?? PopulateColorCodeData();
        }

        /// <summary>
        /// Get Color Value
        /// </summary>
        /// <param name="colorCode"></param>
        /// <returns></returns>
        public int GetColorValue(string colorCode)
        {
            int value = 0;
            if (_colorCodeData.ContainsKey(colorCode))
            {
                value = _colorCodeData[colorCode].ColorValue; 
            }
            return value;
        }

        /// <summary>
        /// Get Multiplier value
        /// </summary>
        /// <param name="colorCode"></param>
        /// <returns></returns>
        public double GetMultiplier(string colorCode)
        {
            double value = 0;
            if (_colorCodeData.ContainsKey(colorCode))
            {
                value = _colorCodeData[colorCode].Multiplier;
            }
            return value;
        }

        /// <summary>
        /// Get Tolerance
        /// </summary>
        /// <param name="colorCode"></param>
        /// <returns></returns>
        public double GetTolerancePercentage(string colorCode)
        {
            double value = 0;
            if (_colorCodeData.ContainsKey(colorCode))
            {
                value = _colorCodeData[colorCode].Tolerance;
            }
            return value;
        }

        /// <summary>
        /// Get Color Data
        /// </summary>
        /// <param name="colorCode"></param>
        /// <returns></returns>
        public ColorDataEntity GetColorData(string colorCode)
        {
            ColorDataEntity dataEntity = null;
            if (_colorCodeData.ContainsKey(colorCode))
            {
                dataEntity = _colorCodeData[colorCode];
            }
            return dataEntity;
        }

        /// <summary>
        /// Get all color codes
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, ColorDataEntity> GetColorCodes()
        {
            return _colorCodeData;
        }

        /// <summary>
        /// In-memory data for all color code values. 
        /// This class will be used as a singleton instance, so that once instance will be shared across all requests
        /// </summary>
        /// <returns></returns>
        private static Dictionary<string, ColorDataEntity> PopulateColorCodeData()
        {
            Dictionary<string, ColorDataEntity> colorCodeData = new Dictionary<string, ColorDataEntity>();
            colorCodeData.Add("PK", new ColorDataEntity { ColorName = "Pink", Multiplier = .001 });
            colorCodeData.Add("SR", new ColorDataEntity { ColorName = "Silver", Multiplier = .01, Tolerance = 10 });
            colorCodeData.Add("GD", new ColorDataEntity { ColorName = "Gold", Multiplier = .1, Tolerance = 5 });
            colorCodeData.Add("BK", new ColorDataEntity { ColorName = "Black", ColorValue = 0, Multiplier = 1 });
            colorCodeData.Add("BN", new ColorDataEntity { ColorName = "Brown", ColorValue = 1, Multiplier = 10, Tolerance = 1 });
            colorCodeData.Add("RD", new ColorDataEntity { ColorName = "Red", ColorValue = 2, Multiplier = 100, Tolerance = 2 });
            colorCodeData.Add("OG", new ColorDataEntity { ColorName = "Orange", ColorValue = 3, Multiplier = 1000 });
            colorCodeData.Add("YE", new ColorDataEntity { ColorName = "Yellow", ColorValue = 4, Multiplier = 10000, Tolerance = 5 });
            colorCodeData.Add("GN", new ColorDataEntity { ColorName = "Green", ColorValue = 5, Multiplier = 100000, Tolerance = .5 });
            colorCodeData.Add("BU", new ColorDataEntity { ColorName = "Blue", ColorValue = 6, Multiplier = 1000000, Tolerance = .25 });
            colorCodeData.Add("VT", new ColorDataEntity { ColorName = "Violet", ColorValue = 7, Multiplier = 10000000, Tolerance = .1 });
            colorCodeData.Add("GY", new ColorDataEntity { ColorName = "Gray", ColorValue = 8, Multiplier = 100000000, Tolerance = .05 });
            colorCodeData.Add("WH", new ColorDataEntity { ColorName = "White", ColorValue = 9, Multiplier = 1000000000 });
            return colorCodeData;
        }
    }
}
