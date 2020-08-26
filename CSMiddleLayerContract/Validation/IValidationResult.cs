using System;
using System.Collections.Generic;
using System.Text;

namespace CSMiddleLayerContract.Validation
{
    //Will use later
    public interface IValidationResult
    {
        bool IsValid { get; set; }
        IEnumerable<string> ErrorMessage { get; set; }

    }
}
