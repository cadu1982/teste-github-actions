using System;

namespace Groffe.Distancias
{
    public static class ConversorDistancias
    {
        public static double MilhasParaKm(double milhas) =>
            milhas * 1.609; // Simulação de falha
            //Math.Round(milhas * 1.609, 3);

        public static double KmParaMilhas(double km) =>
            km / 1.609; // Simulação de falha
            //Math.Round(km / 1.609, 3);
    }
<<<<<<< HEAD
}

=======
}
>>>>>>> 05967a9b37aa28fa7539d444ebaf019548ece7a7
