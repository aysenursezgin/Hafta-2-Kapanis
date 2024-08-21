// 1 - Aşağıdaki çıktıyı yazan bir program.

//Merhaba
//Nasılsın ?
//İyiyim
//Sen nasılsın ?

using System;
using System.Net.NetworkInformation;

Console.WriteLine(" Merhaba\n Nasılsın?\n İyiyim\n Sen nasılsın?");


//2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.

String name = "Aysenur";
int yas = 30;

Console.WriteLine(name + yas);

//3 - Rastgele bir sayı üretip , ekrana yazdırınız.

Random random = new Random();
Console.WriteLine(random.Next(1, 11));


//4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

int rastgele = random.Next(1, 15);
Console.WriteLine($"Olusturulan {rastgele} sayısının 3 e bolumunden kalan : {rastgele % 3}");

//5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.

Console.WriteLine("Lütfen yaşınızı giriniz");
int age;
bool uygunMu = int.TryParse(Console.ReadLine(), out age);

if (!uygunMu)
{
    Console.WriteLine("Yanlis deger girdiniz");
}
else
{
    Console.WriteLine("Uygun deger girdiniz");

    if (age >= 18)
        Console.WriteLine("+");
    else
        Console.WriteLine("-");
}
//6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}

//7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.

Console.WriteLine("ilk ismi girin");
String name1 = Console.ReadLine();

Console.WriteLine("ikinci ismi girin");
String name2 = Console.ReadLine();


Console.WriteLine("İLK İSİM ---->" + name1);
Console.WriteLine("İKİNCİ İSİM ---->" + name2);

String temp = name1;
name1 = name2;
name2 = temp;

Console.WriteLine("İLK İSİM ---->" + name1);
Console.WriteLine("İKİNCİ İSİM ---->" + name2);


//8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.


void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}

BenDegerDondurmem();

//9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.

int SayilariTopla(int sayix, int sayiy)
{
    return sayix + sayiy;
}

int toplam = SayilariTopla(5, 10);
Console.WriteLine(toplam);

//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.

string Metot(bool h)
{
    return "donulen mesaj";
}

Metot(false);

//11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.

int EnYasliOlaniBul(int yas1, int yas2, int yas3)
{
    int enBuyuk = yas1;

    if (yas2 > enBuyuk)
        enBuyuk = yas2;

    if (yas3 > enBuyuk)
        enBuyuk = yas3;

    return enBuyuk;
}

EnYasliOlaniBul(10, 20, 30);
Console.WriteLine("en buyuk yas ---->" + EnYasliOlaniBul);


//12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.

void EnBuyukDegeriBulmaOyunu()
{
    int num;
    int max = int.MinValue;

    while (true)
    {
        Console.Write("Sayi: ")
        bool isAvailable = int.TryParse(Console.ReadL
            ine(), out num);

        if (isAvailable)
        {
            if (num > max)
                max = num;
        }

        else
        {
            Console.WriteLine("Yanlış formatta giriş yaptınız");
        }

        if (max == int.MinValue)
            Console.WriteLine("Henüz gecerli bir sayi degeri girilmedi");

        else
            Console.WriteLine("En buyuk sayi ----> " + max);
    }
}

EnBuyukDegeriBulmaOyunu();

//13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.

void YerDegistir(string k, string l)
{
    string temp = k;
    k = l;
    l = temp;
}

string namek = "Demet Evgar";
string namel = "Gülse Birsel";

YerDegistir(ref namek, ref namel);


//14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.

bool tekMi(int number)
{
    if (number % 2 == 0)
        return false;

    return true;
}

//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.

double GidilenYolHesapla(double hiz, double zaman)
{
    return hiz * zaman;
}

//16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

void DaireAlaniHesapla(double yariCap)
{
    double alan = Math.PI * Math.Pow(yariCap, 2);
    Console.WriteLine("Dairevalan ---->" + alan);
}

DaireAlaniHesapla(4);

//17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.

string metin = "Zaman bir GeRi SayIm";

Console.WriteLine(metin.ToUpper());
Console.WriteLine(metin.ToLower());
Console.WriteLine("---------------");
metin = metin.ToUpper();
Console.WriteLine(metin);


//18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.

string metin2 = "    Selamlar   ";
metin2 = metin2.Trim();
Console.WriteLine(metin2);