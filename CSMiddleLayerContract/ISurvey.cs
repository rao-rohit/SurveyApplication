using System;
using System.Collections.Generic;
using System.Text;

namespace CSMiddleLayerContract
{
    public interface ISurvey
    {
        int Id { get; set; }
        string Name { get; set; }
        int CreatedBy { get; set; }
        bool IsActive { get; set; }
        ICollection<IQuestion> Questions { get; set; }
        (bool, IEnumerable<string>) Validate();
    }
}
