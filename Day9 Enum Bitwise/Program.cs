using System;

class Program
{
    static void Main()
    {
        Status userPermissions = Status.View | Status.Edit;
        Console.WriteLine("User Permissions: " + userPermissions);

        if ((userPermissions & Status.View) == Status.View)
        {
            Console.WriteLine("User has View permission.");
        }

        if ((userPermissions & Status.Edit) == Status.Edit)
        {
            Console.WriteLine("User has Edit permission.");
        }

        Status adminPermissions = Status.View | Status.Edit | Status.Delete;
        Console.WriteLine("Admin Permissions: " + adminPermissions);
    }
}

[Flags]
public enum Status
{
    None = 0,
    View = 1,
    Edit = 2,
    Delete = 4,
    Create = 8
}
