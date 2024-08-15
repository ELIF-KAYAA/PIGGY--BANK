using kumbara1;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class Program
{
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form2());

        Kumbara kumbara = new Kumbara(5000); // 5000 cm³ hacminde bir kumbara

        KağıtPara besTL = KağıtParaÖrnekleri.BesTL;
        KağıtPara onTL = KağıtParaÖrnekleri.OnTL;

        try
        {
            // Kağıt parayı katlamadan eklemeyi dene
            kumbara.ParaAt(besTL);
            Console.WriteLine("Para eklendi: " + besTL.İsim);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Kağıt parayı katla ve tekrar eklemeyi dene
        besTL.Katla();
        try
        {
            kumbara.ParaAt(besTL);
            Console.WriteLine("Katlanmış para eklendi: " + besTL.İsim);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Bozuk paraları kumbara ekle
        try
        {
            kumbara.ParaAt(BozukParaÖrnekleri.BirKurus);
            kumbara.ParaAt(BozukParaÖrnekleri.BesKurus);
            kumbara.ParaAt(BozukParaÖrnekleri.OnKurus);
            Console.WriteLine("Bozuk paralar eklendi.");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // Kumbarayı sallama
        kumbara.Shake();
        Console.WriteLine("Kumbara sallandı.");

        // Kumbaranın mevcut hacmini göster
        Console.WriteLine("Kumbara mevcut hacim: " + kumbara.MevcutHacim + " cm³");

        // Kumbara kırılma ve içindeki paraları gösterme
        List<Para> paralar;
        try
        {
            paralar = kumbara.Break();
            Console.WriteLine("Kumbara kırıldı ve içindeki paralar alındı.");
            foreach (Para para in paralar)
            {
                Console.WriteLine($"{para.İsim}: {para.Değer} TL");
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
