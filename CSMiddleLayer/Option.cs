using CSMiddleLayerContract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSMiddleLayer
{
    public class Option : IOption
    {
        #region- Private members
        private int id;
        private string statement;
        private IQuestion questionId;
        #endregion

        #region - Interface Properties
        int IOption.Id { get => id; set => id = value; }
        IQuestion IOption.QuestionID { get => questionId; set => questionId = value; }
        string IOption.Statement { get => statement; set => statement = value; }
  
        #endregion

        #region Methods
        /// <summary>
        /// Just returning true as handled in questions login on initial design, but it should be heres
        /// </summary>
        /// <returns></returns>
        public (bool, IEnumerable<string>) Validate()
        {
            return (true,null);
        }
        #endregion  
    }
}
