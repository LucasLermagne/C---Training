static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string badge = "";
        
        if(id != null){
            badge =  "["+id+"] - ";
        }
        if( name != null ){
           badge  = badge +name+" - ";
        }
        if(  department != null){
            badge = badge +department.ToUpper();
        }
        else{
            badge = badge +"OWNER";
        }
        return badge;
    }
}
