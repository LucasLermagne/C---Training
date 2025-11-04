static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0){
            return 0 ;
        }
        else if (speed <= 4 && speed >= 1){
            return 1 ;
        }
        else if(speed <= 8 && speed >= 5){
            return 0.90 ;
        }
        else if(speed == 9){
            return 0.80 ;
        }
        else if(speed == 10){
            return 0.77 ;
        }   
        else{
             throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double CARS_PRODUCT_HOUR = 221;
        double carProductionBasic = CARS_PRODUCT_HOUR * speed;
        
        return carProductionBasic  *SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed)/60;
        
    }
}
