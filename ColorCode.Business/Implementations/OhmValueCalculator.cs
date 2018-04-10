using System;
using System.Collections.Generic;
using ColorCode.Business.Contracts;
using ColorCode.Data.Contracts;
using ColorCode.Data.Entities;

namespace ColorCode.Business.Implementations
{
    /// <summary>
    /// Business interface implementation
    /// </summary>
    public class OhmValueCalculator : IOhmValueCalculator
    {
        #region Private Members
        private readonly IColorCodeData _dataProvider;  
        #endregion
        public OhmValueCalculator(IColorCodeData colorCodeData)
        {
            _dataProvider = colorCodeData ?? throw new Exception("Data provider is NULL");
        }

        #region Public Methods
        /// <summary>
        /// Calculate Ohm value based on the color codes
        /// </summary>
        /// <param name="bandAColor"></param>
        /// <param name="bandBColor"></param>
        /// <param name="bandCColor"></param>
        /// <param name="bandDColor"></param>
        /// <returns>ohm value</returns>
        public double CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            // Get the data for the passed in color codes.

            double colorValue = Convert.ToInt32("" + _dataProvider.GetColorValue(bandAColor) + _dataProvider.GetColorValue(bandBColor)) * _dataProvider.GetMultiplier(bandCColor);
            return colorValue;
        }

        /// <summary>
        /// Get all color code data
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, ColorDataEntity> GetColorcodes()
        {
            return _dataProvider.GetColorCodes();
        }
        #endregion
    }
}
