using System;
using System.Collections.Generic;
using System.Text;
using CSMiddleLayerContract;
using CSMiddleLayerContract.Validation;

namespace CSMiddleLayer
{
    public class Question: IQuestion
    {
        IValidate<IQuestion> validationStrategy;

        #region - Constructor
        public Question(IValidate<IQuestion> _validationStrategy)
        {
            validationStrategy = _validationStrategy;
        }
        #endregion


        #region- Private members
        private int id;
        private int surveyId;
        private string statement;
        private QuestionTypes type;
        private ICollection<IOption> Options;
        private bool isActive;

        #endregion

        #region - Interface Properties
        int IQuestion.Id { get => id; set => id = value; }
        int IQuestion.SurveyId { get => surveyId; set => surveyId = value; }
        string IQuestion.Statement { get => statement; set => statement = value; }
        QuestionTypes IQuestion.Type { get => type; set => type=value; }
        ICollection<IOption> IQuestion.Options { get => Options; set => Options = value; }
        bool IQuestion.IsActive { get => isActive; set => isActive = false; }
        #endregion

        #region Methods
        public (bool, IEnumerable<string>) Validate()
        {
            return validationStrategy.Validate(this);
        }
        #endregion
    }
}
