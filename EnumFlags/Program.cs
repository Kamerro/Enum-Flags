var e = Flags.User;
e |= Flags.Super_User;
if (e.HasFlag(Flags.Super_User))
{
    if (e.HasFlag(Flags.Admin))
    {
        Console.WriteLine("Admin and superuser");
    }
}

[Flags]
public enum Flags
{
    None = 1<<0,
    User = 1<<1,
    Super_User = 1<<2,
    Admin = 1<<3,
}
