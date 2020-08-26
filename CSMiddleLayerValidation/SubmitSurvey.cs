using System;
using System.Collections.Generic;
using System.Text;
using CSMiddleLayerContract;
using CSMiddleLayerContract.Validation;

namespace CSMiddleLayerValidation
{
    public class SubmitSurvey : IValidate<ISurveyResponse>
    {
        #region Methods
        public (bool, IEnumerable<string>) Validate(ISurveyResponse entity)
        {
            //Validation rules will be impletemened  here like, no question should have emplty / unselected response etc.
            throw new NotImplementedException();
            
        }
        #endregion
    }
}
