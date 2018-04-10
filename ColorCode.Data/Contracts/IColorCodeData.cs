using System.Collections.Generic;
using ColorCode.Data.Entities;

namespace ColorCode.Data.Contracts
{
    public interface IColorCodeData
    {
        /// <summary>
        /// Get the color code value
        /// </summary>
        /// <param name="colorCode"></param>
        /// <returns></returns>
        int GetColorValue(string colorCode);

        /// <summary>
        /// Get multiplier value
        /// </summary>
        /// <param name="colorCode"></param>
        /// <returns></returns>
        double GetMultiplier(string colorCode);

        /// <summary>
        /// Get Tolerance 
        /// </summary>
        /// <param name="colorCode"></param>
        /// <returns></returns>
        double GetTolerancePercentage(string colorCode);

        /// <summary>
        /// Get Color Data
        /// </summary>
        /// <param name="colorCode"></param>
        /// <returns></returns>
        ColorDataEntity GetColorData(string colorCode);

        /// <summary>
        /// Get Color Data
        /// </summary>
        /// <returns></returns>
        Dictionary<string, ColorDataEntity> GetColorCodes();
    }
}
