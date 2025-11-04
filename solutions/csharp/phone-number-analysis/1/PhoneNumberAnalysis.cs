public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        //To do : best practice detect "-" and separ in array ? 
        string str1 = phoneNumber.Substring (0,3);
        string str2 = phoneNumber.Substring (4,3);
        string str3 = phoneNumber.Substring (8,4);


        //TO do : I think is not the best way to do the conditions
        bool IsNewYork;
        bool IsFake;
        
        if(str1 == "212"){
            IsNewYork = true;  
        }
        else{
            IsNewYork = false;   
        }
        if( str2 == "555"){
            IsFake = true;
        }
        else {
            IsFake = false; 
        }
        return (IsNewYork,IsFake,str3);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
       return phoneNumberInfo.IsFake ;
    }
}
