using System;
using System.Collections.Generic;
using System.Text;
using CSMiddleLayerContract;
using CSMiddleLayerContract.Validation;

namespace CSMiddleLayerValidation
{
    public class AddEditSurvey :IValidate<ISurvey>
    {
        public AddEditSurvey()
        {

        }

        public (bool, IEnumerable<string>) Validate(ISurvey survey)
        {
            IList<string> errorMessage = new List<String>();

            if (string.IsNullOrWhiteSpace(survey.Name))
                errorMessage.Add("Survey Name is required.");

            if (errorMessage.Count > 0)
                return (false, errorMessage as IEnumerable<string>);

            return (true, null);

        }
    }
}
