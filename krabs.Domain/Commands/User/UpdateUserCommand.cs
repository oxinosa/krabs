using System;
using krabs.Domain.Commands.UserManagement;

namespace krabs.Domain.Commands.User
{
    public class UpdateUserCommand : UserManagementCommand
    {
        public UpdateUserCommand(string email,string userName, string name, string phoneNumber, bool emailConfirmed, bool phoneNumberConfirmed, bool twoFactorEnabled, DateTimeOffset? lockoutEnd, bool lockoutEnabled, int accessFailedCount)
        {
            Email = email;
            Username = userName;
            EmailConfirmed = emailConfirmed;
            PhoneNumberConfirmed = phoneNumberConfirmed;
            TwoFactorEnabled = twoFactorEnabled;
            LockoutEnd = lockoutEnd;
            LockoutEnabled = lockoutEnabled;
            AccessFailedCount = accessFailedCount;
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public override bool IsValid()
        {
            //ValidationResult = new UpdateUserCommandValidation().Validate(this);
            //return ValidationResult.IsValid;
            return true;
        }
    }
}