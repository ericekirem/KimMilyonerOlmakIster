
int correctAnswers = 0;
string userInput;

// 1. Soru
Console.WriteLine("En çok uyuyan hayvan hangisidir ?");
Console.WriteLine("a) Koala b) Çöl Faresi");
userInput = Console.ReadLine().Trim().ToLower(); // büyük ve küçük harf duyarlılığı için

if (userInput == "a")
{
    correctAnswers++;
    Console.WriteLine("Doğru cevap!");
}
else
{
    Console.WriteLine("Yanlış cevap!");
}

// 2. Soru
Console.WriteLine("Hangi gezegen mavi gezegen olarak bilinir ?");
Console.WriteLine("a) Neptün b) Jüpiter");
userInput = Console.ReadLine().Trim().ToLower(); // büyük ve küçük harf duyarlılığı için

if (userInput == "a")
{
    correctAnswers++;
    Console.WriteLine("Doğru cevap!");
}
else
{
    Console.WriteLine("Yanlış cevap!");
}

// Eğer kullanıcı 2. soruya kadar 2 yanlış yaptıysa, 3. soruyu sormayız
if (correctAnswers < 2)
{
    // 3. Soru
    Console.WriteLine("İnsan vücudunda en güçlü kas hangisidir? ?");
    Console.WriteLine("a) Kalp b) Dil");
    userInput = Console.ReadLine().Trim().ToLower();  // büyük ve küçük harf duyarlılığı için


    if (userInput == "b")
    {
        correctAnswers++;
        Console.WriteLine("Doğru cevap!");
    }
    else
    {
        Console.WriteLine("Yanlış cevap!");
    }
}

// Final durumu
if (correctAnswers >= 2)
{
    Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
}
else
{
    Console.WriteLine("Maalesef, büyük ödülü kazanamadınız.");
}
