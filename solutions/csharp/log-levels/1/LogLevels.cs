static class LogLine
{
    public static string Message(string logLine)
    {
        //ChatGPT help to find how to crop after [<LEVEL>] with Remove methode:
        
        string str1 = "[ERROR]:";
        string str2 = "[WARNING]:";
        string str3 = "[INFO]:";
        
        if(logLine.Contains(str1)){
            return logLine.Remove(0, str1.Length).Trim();
        }
        else if(logLine.Contains(str2)){
             return logLine.Remove(0, str2.Length).Trim();
        }
        else if(logLine.Contains(str3)){
             return logLine.Remove(0, str3.Length).Trim();
        }
        
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {

        //I know the best is to take only letter from de string and pass from uppercase to lowercase, but i do not know how
        string str1 = "[ERROR]:";
        string str2 = "[WARNING]:";
        string str3 = "[INFO]:";

        if(logLine.Contains(str1)){
            return "error";
        }
        else if(logLine.Contains(str2)){
             return "warning";
        }
        else if(logLine.Contains(str3)){
             return "info";
        }
        
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        string str1 = "[ERROR]:";
        string str2 = "[WARNING]:";
        string str3 = "[INFO]:";

        if(logLine.Contains(str1) ||logLine.Contains(str2) ||logLine.Contains(str3) ){
            return Message(logLine)+" (" +LogLevel(logLine)+")";
        }
        
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
