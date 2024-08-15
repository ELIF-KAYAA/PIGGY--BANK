public abstract class Para
{
    public string İsim { get; set; }
    public double Değer { get; set; }

    protected Para(string isim, double değer)
    {
        İsim = isim;
        Değer = değer;
    }

    public abstract double Hacim();
}


