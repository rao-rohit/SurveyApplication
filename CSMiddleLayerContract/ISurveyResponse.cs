using System;
using System.Collections.Generic;
using System.Text;

namespace CSMiddleLayerContract
{
    public interface ISurveyResponse
    {
        int Id { get; set; }
        int SurveyId { get; set; }
        ICollection<ValueTuple<int, int>> QuestionResponse { get; set; }
        int UserId { get; set; }
        DateTime CreatedDate { get; set; }
        (bool, IEnumerable<string>) Validate();
    }
}
