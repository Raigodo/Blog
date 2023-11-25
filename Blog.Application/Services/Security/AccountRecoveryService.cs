using Blog.Domain.Entities.User.Vo;

namespace Blog.Application.Services.Security;

public sealed class AccountRecoveryService
{
    public void ChangePassword(UserId issuer, UserId userId, string newPassword)
    {
        throw new NotImplementedException();
    }

    public void ChangeEmail(UserId issuer, UserId userId, string newEmial)
    {
        throw new NotImplementedException();
    }

    public void ChangeUsername(UserId issuer, UserId userId, string newUsername)
    {
        throw new NotImplementedException();
    }
}
