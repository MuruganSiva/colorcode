using System.Collections.Generic;
using ColorCode.Provider.Models;

namespace ColorCode.Provider.Contracts
{
    /// <summary>
    /// Provider interface to handle data from business layer
    /// </summary>
    public interface IOhmProvider
    {
        ResponseModel GetDataAsync(PageModel request);

        PageModel InitializeModel();
    }
}
