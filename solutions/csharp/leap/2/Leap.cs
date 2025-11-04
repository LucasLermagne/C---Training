public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        //Find with chatgpt > "%" is modulo the rest of the division
        return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
    }
}