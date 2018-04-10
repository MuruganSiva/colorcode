using System.Collections;
using System.Collections.Generic;
using ColorCode.Data.Entities;

namespace ColorCode.Business.Contracts
{
    public interface IOhmValueCalculator
    {

        /// <summary>
        /// Calculates the Ohm value of a resistor based on the band colors.
        /// </summary>
        /// <param name="bandAColor">The color of the first figure of component value band.</param>
        /// <param name="bandBColor">The color of the second significant figure band.</param>
        /// <param name="bandCColor">The color of the decimal multiplier band.</param>
        /// <param name="bandDColor">The color of the tolerance value band.</param>
        double CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor);

        /// <summary>
        /// Get Color Code data
        /// </summary>
        /// <returns></returns>
        Dictionary<string, ColorDataEntity> GetColorcodes();
    }
}
