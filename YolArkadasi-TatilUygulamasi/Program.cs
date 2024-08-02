
// En sonda kullanıcının döngüyü yeniden çalıştırmak isteyip istemediğini soracağım.
bool devam = true;


while (devam)
{
    // LOKASYON
    // Kullanıcının tatil yapacağı lokasyonu belirlemesi için bir değişken belirliyorum.
    string lokasyon = "";
    bool dogruLokasyon = false;

    // Doğru lokasyonu girene kadar tekrar sorması için döngü oluşturuyorum.
    do
    {
        Console.WriteLine("Merhabalar, aşağıda listelenen tatil beldelerinden birini yazınız:\n\n 1 - Bodrum (Paket başlangıç fiyatı 4000 TL)\n\n 2 - Marmaris (Paket başlangıç fiyatı 3000 TL)\n\n 3 - Çeşme (Paket başlangıç fiyatı 5000 TL)\n");
        lokasyon = Console.ReadLine().ToLower().Trim();

        if (lokasyon == "bodrum" || lokasyon == "marmaris" || lokasyon == "çeşme")
            dogruLokasyon = true;         // Lokasyon geçerliyse döngü biter.
        else
            Console.WriteLine("\nHatalı giriş yaptınız. Lütfen geçerli bir geçerli bir lokasyon yazınız.\n".ToUpper());

    } while (!dogruLokasyon);    // Geçerli lokasyon girilene kadar döngüyü devam ettirir.


    // KAÇ KİŞİ
    // Kullanıcının kaç kişilik tatil planlayacağını belirtmesi için bir değişken belirliyorum.
    int kisiSayisi;
    bool dogruKisiSayisi = false;

    // Geçerli sayı girene kadar tekrar sorması için döngü oluşturuyorum.
    do
    {
        Console.Write("\nKaç kişi için tatil planlamak istiyorsunuz?: ");

        if (int.TryParse(Console.ReadLine(), out kisiSayisi) && kisiSayisi > 0)
        {
            dogruKisiSayisi = true;   // Geçerli sayı girilince döngü sonra erer. 
        }
        else
        {
            Console.WriteLine("\nHatalı giriş yaptınız. Lütfen geçerli kişi sayısı giriniz.".ToUpper());
        }

    } while (!dogruKisiSayisi);     // Geçerli sayı girilene kadar döngüyü devam ettirir.



    // AKTİVİTELER
    // Seçilen lokasyona göre beldeler hakkında bilgi veriyorum.
    switch (lokasyon)
    {
        case "bodrum":
            Console.WriteLine("\n----Bodrum Türkiye'nin en popüler tatil merkezlerinden biridir. Deniz kum güneş üçlüsü için muazzam bir yerdir.----");
            break;

        case "marmaris":
            Console.WriteLine("\n----Marmaris muhteşem plajlarıyla ve çok çeşitli konaklama seçenekleriyle unutulmaz bir tatil fırsatı sunar.----");
            break;

        case "çeşme":
            Console.WriteLine("\n----Çeşme geniş plajlarıyla, su sporlarıyla ve gece hayatıyla sizleri içine çekerek harika bir tatil fırsatı yaratır.----");
            break;
    }


    // ULAŞIM
    // Kullanıcının hangi ulaşım yolunu kullanmak istediğini belirtmesi için bir değişken belirliyorum.
    int ulasim;
    bool dogruUlasim = false;

    // Doğru girdiyi verene kadar tekrar sorması için döngü oluşturuyorum.
    do
    {
        Console.Write("\nTatile hangi ulaşım yolu ile gitmek istersiniz?\n\n1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )\n\n2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)\n\nLütfen tercihinizi '1' veya '2' olarak belirtiniz: ");

        if (int.TryParse(Console.ReadLine(), out ulasim) && (ulasim == 1 || ulasim == 2))
        {
            dogruUlasim = true;   // Doğru şekilde giriş yapılırsa döngü biter.
        }
        else
        {
            Console.WriteLine("\nHatalı giriş yaptınız. Lütfen gitmek istediğiniz ulaşım yolunu yalnızca '1' veya '2' olarak giriniz.\n".ToUpper());
        }

    } while (!dogruUlasim);    // Doğru giriş yapılana kadar döngüyü devam ettirir.


    // PAKET FİYATI
    // Kullanıcının seçmil olduğu lokasyon ve kişi sayısına göre fiyat oluştuyorum.
    int paketFiyati = 0;

    if (lokasyon == "bodrum")
        paketFiyati = kisiSayisi * 4000;

    else if (lokasyon == "marmaris")
        paketFiyati = kisiSayisi * 3000;

    else
        paketFiyati = kisiSayisi * 5000;

    // Lokasyon ve kişi sayısının üzerine seçmiş olduğu ulaşım yolunun maaliyetini de ekliyorum.
    if (ulasim == 1)
        paketFiyati += kisiSayisi * 1500;
    else
        paketFiyati += kisiSayisi * 4000;

    Console.WriteLine("\nVermiş olduğunuz bilgiler doğrultusunda tatil paketi fiyatınız: " + paketFiyati + "TL\n");
   

    // YENİDEN PLANLAMA
    // Kullanıcın yeniden tatil planı oluşturmak isteyip istemediğini öğrenmek için yeni bir değişken atayıp döngü oluştuyorum.
    string devamCevap;

    do
    {
        Console.WriteLine("Başka bir tatil planı yapmak ister misiniz? (Evet/Hayır)");
        devamCevap = Console.ReadLine().ToLower().Trim();

        if (devamCevap == "evet")
        {
            devam = true;    // Evet cevabı üzerine işlemleri en başa alarak tekrar plan oluşturur.
        }
        else if (devamCevap == "hayır")
        {
            devam = false;
            Console.WriteLine("\n\nHoşçakalın.");   // Hayır cevabı üzerine çalışmayı sonlandırır.
        }
        else
        {
            Console.WriteLine("\nHatalı giriş yaptınız. Lütfen 'Evet' veya 'Hayır' olarak cevap veriniz.".ToUpper());   // Evet/Hayır dışında giriş yapılırsa hata bildirir.
        }

    } while (devamCevap != "evet" && devamCevap != "hayır");    //// Evet/Hayır dışında giriş yapılırsa geçerli cevabı alana kadar döngüyü devam ettirir.

}
