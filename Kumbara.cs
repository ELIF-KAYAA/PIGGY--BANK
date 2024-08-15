
using kumbara1;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
public class Kumbara
{
    private bool kırıldı = false;
    private bool yapıştırılabilir = true;
    private List<Para> paralar = new List<Para>();
    private double hacim;          // Kumbaranın toplam hacmi
    private double mevcutHacim;
    private double fazladanHacim;// Kumbaradaki mevcut hacim

    public Kumbara(double hacim)
    {
        this.hacim = hacim;
        this.mevcutHacim = 0;
        this.fazladanHacim = 0;
    }

    public double MevcutHacim
    {
        get { return mevcutHacim; }
    }




    public void ParaAt(Para para)
    {
        if (kırıldı)
        {
            throw new InvalidOperationException(ExceptionLibrary.KumbaraKırılmış);
        }
        if(para is KağıtPara kağıtPara&& !kağıtPara.Katlandı)
        {
            
            throw new InvalidOperationException(ExceptionLibrary.KatlanmamışKağıtPara);
        }

        double paraHacmi = para.Hacim();
        double fazladan = RastgeleFazladanHacim(paraHacmi);
        double toplamHacim = paraHacmi + fazladan;

        if (IsFull() || mevcutHacim + paraHacmi > hacim)
        {
            throw new InvalidOperationException(ExceptionLibrary.KumbaraHacmiDolu);
        }

        paralar.Add(para);
        mevcutHacim += paraHacmi;
        fazladanHacim += fazladan;
    }

    public List<Para> Break()
    {
        if (kırıldı)
        {
            if (yapıştırılabilir)
            {
                mevcutHacim = 0;
                yapıştırılabilir = false;
                fazladanHacim = 0;
                return new List<Para>();
            }
            else
            {
                throw new InvalidOperationException(ExceptionLibrary.KumbaraTekrarKullanılamaz);
            }
        }

        kırıldı = true;
        List<Para> toReturn = new List<Para>(paralar);
        paralar.Clear();
        mevcutHacim = 0;
        fazladanHacim = 0;
        return toReturn;
    }

    public void Shake()
    // Shake işlemi burada uygulanır.
    // Örneğin, paraların0 hacminin %25-%75 arasında bir değere çekilmesi sağlanabilir.
    {
        if (paralar.Count == 0)
        {
            return; // kumbara boşsa birşey yapmaz.

        }
        double minFazladanHacim = 0.25;
        fazladanHacim = Math.Max(fazladanHacim * minFazladanHacim, fazladanHacim);
        mevcutHacim = Math.Min(mevcutHacim, hacim - fazladanHacim);
    }


    private bool IsFull()
    {
        return mevcutHacim + fazladanHacim >= hacim;
    }
    private double RastgeleFazladanHacim(double paraHacmi)
    {
        Random rand = new Random();
        double oran = 0.25 + rand.NextDouble() * (0.75 - 0.25);
        return paraHacmi * oran;
    }
}





