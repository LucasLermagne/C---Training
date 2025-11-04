static class Badge
{
    public static string Print(int? id, string name, string? department)
    {

        //In this interation i use "Interpolation" instead of "concatenation"
        
        string badge = "";
        
        if(id != null){
            badge +=  $"[{id}] - ";
        }
        if( name != null ){
            badge += $"{name} - ";
        }
        if(  department != null){
            badge += $"{department.ToUpper()}";
        }
        else{
            badge += $"OWNER";
        }
        return badge;
    }
}
