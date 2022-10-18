namespace Exercicios {
    class Triangulo {

        public double A;
        public double B;
        public double C;


        public double Area() {

            double perimetro = (A + B + C) / 2.0;

            double raiz = Math.Sqrt(perimetro * (perimetro - A) * (perimetro - B) * (perimetro - C));

            return raiz;
        }
    }
}