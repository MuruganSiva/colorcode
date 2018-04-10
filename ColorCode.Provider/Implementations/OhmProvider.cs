using System;
using System.Collections.Generic;
using ColorCode.Business.Contracts;
using ColorCode.Provider.Contracts;
using ColorCode.Provider.Models;
using System.Linq;
using ColorCode.Data.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ColorCode.Provider.Implementations
{
    public class OhmProvider : IOhmProvider
    {
        private readonly IOhmValueCalculator _ohmCalculator;

        public OhmProvider(IOhmValueCalculator ohmCalculator)
        {
            _ohmCalculator = ohmCalculator ?? throw new Exception("Calculator is NULL");
        }

        public PageModel InitializeModel()
        {
            PageModel pageModel = CreatePageModel();
            return pageModel;
        }

        public ResponseModel GetDataAsync(PageModel request)
        {
            if(request == null)
            {
                throw new Exception("Request is NULL");
            }
            ResponseModel _response = new ResponseModel();
            _response.OhmValue = _ohmCalculator.CalculateOhmValue(request.BandACode,
                                                                  request.BandBCode,
                                                                  request.MultiplierCode,
                                                                  request.ToleranceCode);

            return _response;
        }

        private PageModel CreatePageModel()
        {
            PageModel pageModel = new PageModel();
            Dictionary<string, ColorDataEntity> data = _ohmCalculator.GetColorcodes();
            if(data != null)
            {
                pageModel.ColorCodes = new SelectList(data.Where(c => c.Value.ColorValue > 0)
                                                 .Select(item => new
                                                 {
                                                     Id = item.Key,
                                                     Value = item.Value.ColorName
                                                 }), "Id", "Value");

                pageModel.Multiplier = new SelectList(data.Where(c => c.Value.Multiplier > 0)
                                                      .Select(item => new
                                                      {
                                                          Id = item.Key,
                                                          Value = item.Value.ColorName
                                                      }), "Id", "Value");

                pageModel.Tolerance = new SelectList(data.Where(c => c.Value.Tolerance > 0)
                                                     .Select(item => new
                                                     {
                                                         Id = item.Key,
                                                         Value = item.Value.ColorName
                                                     }), "Id", "Value");
            }
            
            return pageModel;
        }
    }
}
