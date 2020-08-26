using System;
using System.Collections.Generic;
using System.Text;

namespace CSMiddleLayerContract
{
    public interface IQuestion
    {
        int Id { get; set; }
        int SurveyId { get; set; }
        string Statement { get; set; }
        QuestionTypes Type { get; set; }
        ICollection<IOption> Options { get; set; }
        bool IsActive { get; set; }

        (bool, IEnumerable<string>) Validate();
    }

    public enum QuestionTypes
    {
        Boolean,
        MultipleChoice,
        MultiSelect,
        Text
    }
}
