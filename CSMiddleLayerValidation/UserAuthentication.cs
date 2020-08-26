using System;
using System.Collections.Generic;
using System.Text;
using CSMiddleLayerContract;
using CSMiddleLayerContract.Validation;

namespace CSMiddleLayerValidation
{
    public class UserAuthentication : IValidate<IUser>
    {
        public UserAuthentication()
        {

        }

        public (bool, IEnumerable<string>) Validate(IUser user)
        {
            IList<string> errorMessage= new List<String>();
            
            if (string.IsNullOrWhiteSpace(user.UserName))
                errorMessage.Add("UserName is required.");
            if (string.IsNullOrWhiteSpace(user.Password))
                errorMessage.Add("Password is required");

            if (errorMessage.Count > 0)
                return (false, errorMessage as IEnumerable<string>);

            return (true, null);

        }
    }
}
