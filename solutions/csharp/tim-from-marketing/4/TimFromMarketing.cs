static class Badge
{
    public static string Print(int? id, string name, string? department)
    {

        //In this interation i use "Interpolation" instead of "concatenation"
        //concatenation : "" + X +  "" + X
        //Interpolation : += $"{name} - "


        
        
        // If no departement it is OWNER    
        string dept;
        if (department != null)
        {
            dept = department.ToUpper();
        }
        else
        {
            dept = "OWNER";
        }

        // If ID exist
        if (id != null)
        {
            return $"[{id}] - {name} - {dept}";
        }

        // new employee without ID
        return $"{name} - {dept}";
    }
}