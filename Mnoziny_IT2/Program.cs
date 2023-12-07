using Mnoziny_IT2;

Vycet A = new Vycet();
A.Prvky = new double[] { 3, 4, 6, 7 };

Vycet B = new Vycet();
B.Prvky = new double[] { 10, 12, 6, 8, 7 };

Interval C = new Interval();
C.Zacatek = 5;
C.Konec = 10;

Mnozina M1 = A;
Mnozina M2 = B;
Mnozina M3 = C;

Vycet X = (Vycet)M1;

Console.WriteLine(M1.GetType());
Console.WriteLine(M2.GetType());
Console.WriteLine(M3.GetType());