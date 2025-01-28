class ConditionalAndLoops
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    public static void Run()
    {
        int hour = 10;
        if (hour > 0 && hour < 12)
        {
            Console.WriteLine("It's morning");
        }
        else if (hour >= 12 && hour < 18)
        {
            Console.WriteLine("It's afternoon");
        }
        else
        {
            Console.WriteLine("It's evening");
        }

        bool isGoldcustomer = true;
        float price = (isGoldcustomer) ? 19.95f : 29.95f;
        Console.WriteLine(price);

        var season = Season.Autumn;
        switch (season)
        {
            case Season.Autumn:
                Console.WriteLine("It's autumn and a beautiful season.");
                break;
            case Season.Summer:
                Console.WriteLine("It's time to surf.");
                break;
            default:
                Console.WriteLine("I don't understand that season!");
                break;
        }

        switch (season)
        {
            case Season.Autumn:
            case Season.Summer:
                Console.WriteLine("It's time to surf.");
                break;
            default:
                Console.WriteLine("I don't understand that season!");
                break;
        }
    }
}
