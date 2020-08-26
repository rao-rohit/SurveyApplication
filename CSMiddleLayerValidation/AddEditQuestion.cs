using System;
using System.Collections.Generic;
using System.Text;
using CSMiddleLayerContract;
using CSMiddleLayerContract.Validation;

namespace CSMiddleLayerValidation
{
    public class AddEditQuestion : IValidate<IQuestion>
    {
        public AddEditQuestion()
        {

        }

        public (bool, IEnumerable<string>) Validate(IQuestion question)
        {
            IList<string> errorMessage = new List<String>();

            if (string.IsNullOrWhiteSpace(question.Statement))
                errorMessage.Add("Question statement is required.");

            if(question.Type == QuestionTypes.Boolean)
            {
                //1. options should be 2
                if(question.Options.Count==2)
                {
                    foreach (IOption s in question.Options)
                        if (String.IsNullOrEmpty(s.Statement))
                            errorMessage.Add($"Please enter text for all option");
                }
                else
                    errorMessage.Add("Boolean question should have 2 options.");
            }
            else if (question.Type == QuestionTypes.MultipleChoice)
            {
                //1. options should be 4
                if (question.Options.Count == 4)
                {
                    foreach (IOption s in question.Options)
                        if (String.IsNullOrEmpty(s.Statement))
                            errorMessage.Add($"Please enter text for all options");
                }
                else
                    errorMessage.Add("Multiple choice question should have 4 options.");
            }
            else if(question.Type == QuestionTypes.MultiSelect)
            {
                //1. options should be 4
                if (question.Options.Count == 4)
                {
                    foreach (IOption s in question.Options)
                        if (String.IsNullOrEmpty(s.Statement))
                            errorMessage.Add($"Please enter text for all the options");
                }
                else
                    errorMessage.Add("Multi select question should have 4 options.");
            }


            if (errorMessage.Count > 0)
                return (false, errorMessage as IEnumerable<string>);

            return (true, null);

        }
    }
}
