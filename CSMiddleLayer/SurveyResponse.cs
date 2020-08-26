using CSMiddleLayerContract.Validation;
using System;
using System.Collections.Generic;
using System.Text;
using CSMiddleLayerContract;

namespace CSMiddleLayer
{
    public class SurveyResponse : ISurveyResponse
    {
        IValidate<ISurveyResponse> validationStrategy;

        #region - Constructor
        public SurveyResponse(IValidate<ISurveyResponse> _validationStrategy)
        {
            validationStrategy = _validationStrategy;
        }
        #endregion


        #region- Private members
        private int id;
        private int surveyId;
        private int createdby;
        private ICollection<ValueTuple<int, int>> questionResponse;
        private DateTime createdDate;
        #endregion


        #region Interface Properties
        int ISurveyResponse.Id { get => this.id; set => this.id = value; }
        int ISurveyResponse.SurveyId { get => this.surveyId; set => this.surveyId = value; }
        ICollection<ValueTuple<int, int>> ISurveyResponse.QuestionResponse { get => this.questionResponse; set => this.questionResponse = value; }
        int ISurveyResponse.UserId { get => this.createdby; set => this.createdby = value; }
        DateTime ISurveyResponse.CreatedDate { get => this.createdDate; set => this.createdDate = value; }
        #endregion

        #region Methods
        public (bool, IEnumerable<string>) Validate()
        {
            return validationStrategy.Validate(this);
        }
        #endregion
    }
}
