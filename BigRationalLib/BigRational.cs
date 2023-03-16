using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace BigRationalLib

{
    public readonly struct BigRational
    {

        //dane 

        public BigInteger Numerator { get; init; }
        public BigInteger Denominator { get; init; }  
        public BigRational (BigInteger numerator, BigInteger denominator)
        {
           
            Numerator = numerator; 
            Denominator = denominator;

            // normalizacja znakow 
            if(Numerator >= 0 && Denominator < 0 || Numerator < 0 && Denominator < 0)
            {
                (Numerator,Denominator ) = ((-1) * Numerator, (-1) * Denominator);
            }
            //decimal num = 0;
            //decimal den = 0;
            //num = Math.Abs((decimal)Denominator);
            //num = Math.Abs((decimal)Numerator);
            //Numerator = ((BigInteger)Denominator);
            //Denominator = ((BigInteger)Numerator);
            //upraszczanie
            var nwd = BigInteger.GreatestCommonDivisor(Numerator, Denominator);
            Numerator = Numerator / nwd;
            Denominator = Denominator / nwd;
            
        }
        public override string ToString() => String.Format("{0}/{1}/",Numerator,Denominator);

        //konstrutory

        // przesloniecie ToString

        //inne metody :
        // tozsamosc

        //operatory arytemtyczne 
        // porównanie, operatory realcyjne 
        //konwersje 





    }
}