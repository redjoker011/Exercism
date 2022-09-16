using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var badge = string.Empty;

        if (id is not null)
            badge += $"[{id}] - ";

        badge += $"{name} - ";

        badge += department is null ? "OWNER" : department.ToUpper();

        return badge;
    }
}
