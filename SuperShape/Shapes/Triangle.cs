using SuperShape.Interfaces;

namespace SuperShape.Shapes {
    public class Triangle : IShape
    {
        private readonly int sideA, sideB, sideC;
        
        public Triangle(int sideA, int sideB, int sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double CalculateArea() 
        {
            double p = (sideA + sideB + sideC) / 2.0;
      
            return Math.Round(Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC)), 2);
        }

        public bool IsRightTriangle()
        {
            double qadSideA = Math.Pow(sideA, 2);
            double qadSideB = Math.Pow(sideB, 2);
            double qadSideC = Math.Pow(sideC, 2);

            return (qadSideA == (qadSideB + qadSideC) || qadSideB == (qadSideA + qadSideC) || qadSideC == (qadSideA + qadSideB));
        }
           
    }
}
