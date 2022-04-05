using System;

// TODO: define the 'AccountType' enum
public enum AccountType
{
    Guest,
    User,
    Moderator
} 

// TODO: define the 'Permission' enum
[Flags]
public enum Permission : short
{
    None = 0,
    Read = 1,
    Write = 2,
    Delete = 4,
    All = 7,
} 

static class Permissions
{
    public static Permission Default(AccountType accountType) => accountType switch
    {
        AccountType.Guest => Permission.Read,
        AccountType.User => Permission.Read | Permission.Write,
        AccountType.Moderator => Permission.Read | Permission.Write | Permission.Delete,
        _ => Permission.None
    };

    public static Permission Grant(Permission current, Permission grant) => current | grant; 

    public static Permission Revoke(Permission current, Permission revoke) => current & ~revoke;

    public static bool Check(Permission current, Permission check) => current.HasFlag(check);
}
