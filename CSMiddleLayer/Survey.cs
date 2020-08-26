using System;
using System.Collections.Generic;
using System.Text;
using CSMiddleLayerContract;
using CSMiddleLayerContract.Validation;

namespace CSMiddleLayer
{
    public class Survey : ISurvey
    {

        IValidate<ISurvey> validationStrategy;

        #region - Constructor
        public Survey(IValidate<ISurvey> _validationStrategy)
        {
            validationStrategy = _validationStrategy;
        }
        #endregion


        #region- Private members
        private int id;
        private string name;
        private int createdby ;
        private bool isActive;
        private ICollection<IQuestion> questions;
        #endregion

        #region - Interface Properties
        //interface properties
        int ISurvey.Id { get => id; set => id = value; }
        string ISurvey.Name { get => name; set => name = value; }
        bool ISurvey.IsActive { get => isActive; set => isActive = false; }
        int ISurvey.CreatedBy { get => createdby; set => createdby = value; }
        ICollection<IQuestion> ISurvey.Questions { get => questions; set => questions = value; }
        #endregion

        #region Methods
        public (bool, IEnumerable<string>) Validate()
        {
            return validationStrategy.Validate(this);
        }

        (bool, IEnumerable<string>) ISurvey.Validate()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
