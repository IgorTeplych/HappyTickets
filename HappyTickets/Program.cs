public static class Program
{
    static ulong[,] valueTables;
    static ulong[] happyTickets;
    static void Main()
    {
        var vr = Resolve(10);
    }

    public static ulong Resolve(int sizeTickets)
    {
        valueTables = new ulong[sizeTickets, 9 * sizeTickets + 1];
        happyTickets = new ulong[sizeTickets];

        //Заполненеие массива для n = 1
        for (int k = 0; k < 10; k++)
        {
            valueTables[0, k] = 1;
        }
        //конец заполнения массива для n = 1

        for (int n = 1; n < sizeTickets; n++)
        {
            for (int k = 9 * sizeTickets; k >= 0; k--)
            {
                happyTickets[n] += (ulong)Math.Pow(ShiftWindow(n, k), 2);
            }
        }
        return happyTickets[sizeTickets - 1];
    }



    static ulong ShiftWindow(int n, int k)
    {
        for (int i = 0; (i <= k && i < 10); i++)
        {
            valueTables[n, k] += valueTables[n - 1, k - i];
        }
        return valueTables[n, k];
    }

}
