

public class Date
{
    private int day, year;
    private string month;

    public void AcceptDate(int dd,string mm,int yy)
    {
        day= dd;
        month= mm;
        year= yy;
    }
    public string PrintDate()
    {
        return $"Date:{day}/{month}/{year}";
    }

}

public class program
{
    static void Main(string[] args)
    {
        Date dateObj1=new Date();
        dateObj1.AcceptDate(4, "Aug", 2023);
        string res=dateObj1.PrintDate();
       Console.WriteLine(res);
    }
}