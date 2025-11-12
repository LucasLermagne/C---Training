static class Badge
{
    public static string Print(int? id, string name, string? department)
    {

        //In this interation i use "Interpolation" instead of "concatenation"
        //concatenation : "" + X +  "" + X
        //Interpolation : += $"{name} - "


        
        
        // If no departement it is OWNER    
        //?. — Null-conditional operator (Call methode if only not null)
        //?? — Null-coalescing operator (if left value is null take right value)
        string dept = department?.ToUpper() ?? "OWNER";

        // If ID exist
        if (id != null)
        {
            return $"[{id}] - {name} - {dept}";
        }

        // new employee without ID
        return $"{name} - {dept}";
    }
}