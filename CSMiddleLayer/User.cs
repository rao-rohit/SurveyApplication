using System;
using System.Collections.Generic;
using System.Text;
using CSMiddleLayerContract;
using CSMiddleLayerContract.Validation;

namespace CSMiddleLayer
{
    public class User : IUser
    {
        //It will be used to Hold the validation Logic for User
        private IValidate<IUser> validationStrategy = null;

        public User(IValidate<IUser> _validation)
        {
            validationStrategy = _validation;
        }

        #region- Private members
        private int userId;
        private string firstName;
        private string lastName ;
        private string userName ;
        private string password ;
        private bool isActive;

        #endregion

        #region - Interface Properties
        //interface properties
        int IUser.UserId { get => this.userId; set => this.userId = value; }
        string IUser.FirstName { get => this.firstName; set => this.firstName = value; }
        string IUser.LastName { get => this.lastName; set => this.lastName = value; }
        string IUser.UserName { get => this.userName; set => this.userName = value; }
        string IUser.Password { get => this.password;  set => this.password = value; }
        bool IUser.IsActive { get => this.isActive; set => this.isActive = value; }
        #endregion

        public (bool,IEnumerable<string>) Validate()
        {
            return validationStrategy.Validate(this);
        }
    }
}
