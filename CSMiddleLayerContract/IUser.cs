using System;
using System.Collections.Generic;
using System.Text;

namespace CSMiddleLayerContract
{
    public interface IUser
    {
        int UserId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        bool IsActive { get; set; }

        (bool, IEnumerable<string>) Validate();
    }
}
