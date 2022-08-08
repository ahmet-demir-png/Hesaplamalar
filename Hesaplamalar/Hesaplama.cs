using System;

public class Hesaplama
{
    public static double PIDegeriniGetir()
    {
        return 3.14;
    }

    public double Toplama(double a, double b)
    {
        return a + b;
    }

    public double Cikartma(double a, double b)
    {
        return a - b;
    }

    public double Carpma(double a, double b)
    {
        return a * b;
    }

    public double Bolme(double a, double b)
    {
        return a / b;
    }

    public double kalanbolme(double a, double b)
    {
        return a % b;
    }
    public double dairealan(double c)
    {
        return PIDegeriniGetir() * (c * c);
    }

    public double dairecevre(double c)
    {
        return 2 * PIDegeriniGetir() * c;
    }

    public double dikdortgencevre(double a, double b)
    {
        return 2 * (a + b);
    }

    public double dikdortgenalan(double a, double b)
    {
        return a * b;
    }

    public double karecevre(double c)
    {
        return c * 4;
    }

    public double karealan(double c)
    {
        return c * c;
    }

    public double hizhesaplama(double x, double t)
    {
        return x / t;
    }

    public double yolhesaplama(double v, double t)
    {
        return v * t;
    }

    public double zamanhesaplama(double x, double v)
    {
        return x / v;
    }

    public string zaman_karekter(string a)
    {
        string akontrol = Convert.ToString(a);
        if (akontrol.Length == 1)
        {
            a = "0" + akontrol;

        }
        else
        {
            a = akontrol;
        }
        return a;
    }

    public string rakam_metin_kontrol(string metin)
    {
        if (metin.Any(c => !Char.IsDigit(c)))
        {
            MessageBox.Show("Hatalı giriş");
        }
        return metin;
    }
}
