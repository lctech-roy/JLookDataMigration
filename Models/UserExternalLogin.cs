using Netcorext.EntityFramework.UserIdentityPattern.Entities;

namespace JKTankDataMigration.Models;

public class UserExternalLogin : Entity
{
    public string Provider { get; set; } = null!;
    public string UniqueId { get; set; } = null!;
}