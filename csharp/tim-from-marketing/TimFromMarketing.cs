using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string employeeNumber = id != null ? $"[{id}] - " : "";
        return $"{employeeNumber}{name} - {department?.ToUpper() ?? "OWNER"}";
    }
}
