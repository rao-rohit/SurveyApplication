using System;
using System.Collections.Generic;
using System.Text;

namespace CSMiddleLayerContract
{
    public interface IOption
    {
        int Id { get; set; }
        string Statement { get; set; }
        IQuestion QuestionID { get; set;}
        (bool, IEnumerable<string>) Validate();
    }
}
