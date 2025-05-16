int a = 5;
int b = 6;
int c = 7;
int islem = a + c / (b - c) * 10;
int islemm = a + c / b - c * 10;
int islemmm = a + c * b - c / 10;

if (islem >= 0)
    Console.WriteLine("Sonuç pozitiftir.");
else
    Console.WriteLine("Sonuç negatiftir.");
if (islemm >= 0)
    Console.WriteLine("Sonuç pozitiftir.");
else
    Console.WriteLine("Sonuç negatiftir.");
if (islemmm >= 0)
    Console.WriteLine("Sonuç pozitiftir.");
else
    Console.WriteLine("Sonuç negatiftir.");
