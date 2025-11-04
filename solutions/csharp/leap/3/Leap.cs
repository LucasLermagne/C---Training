public static class Leap
{
    //As the IsLeapYear method only has a single statement, consider converting the method to an expression-bodied method.
    public static bool IsLeapYear(int year) =>  ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
}