using Microsoft.AspNetCore.Mvc.Rendering;

namespace ColorCode.Provider.Models
{
    public class PageModel
    {
        public SelectList ColorCodes { get; set; }
        public string BandACode { get; set; }
        public string BandBCode { get; set; }
        public SelectList Multiplier { get; set; }
        public string MultiplierCode { get; set; }
        public SelectList Tolerance { get; set; }
        public string ToleranceCode { get; set; }
        
        public string OhmValue { get; set; }
    }
}
