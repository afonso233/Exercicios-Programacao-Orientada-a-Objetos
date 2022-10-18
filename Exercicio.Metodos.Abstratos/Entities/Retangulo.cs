using Exercicios.Entities.Enums;
namespace Exercicios.Entities {

    class Retangulo : Shape {
        public double Width { get; set; }
        public double Height { get; set; }


        public Retangulo(double width, double height, Color color) : base(color) {
            Width = width;
            Height = height;
        }

        public override double Area() {
            return Width * Height;
        }
    }
}
