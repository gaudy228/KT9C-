namespace _9KT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sphere originalSphere = new Sphere(10, 13, 4, "Red", 25);
            originalSphere.Info();

            Sphere cloneSphere1 = (Sphere)originalSphere.Clone();
            Sphere cloneSphere2 = (Sphere)originalSphere.Clone();

            cloneSphere1.X = 0;
            cloneSphere1.Y = 0;
            cloneSphere1.Z = 0;
            cloneSphere1.Radius = 0;
            cloneSphere1.Color = "Blue";
            cloneSphere1.Info();

            cloneSphere2.X = 1;
            cloneSphere2.Y = 1;
            cloneSphere2.Z = 1;
            cloneSphere2.Radius = 1;
            cloneSphere2.Color = "Yellow";
            cloneSphere2.Info();

            originalSphere.Info();

            Cube originalCube = new Cube(22, 33, 44, "Red", 5);
            originalCube.Info();

            Cube cloneCube1 = (Cube)originalCube.Clone();
            Cube cloneCube2 = (Cube)originalCube.Clone();
            cloneCube1.X = 0;
            cloneCube1.Y = 0;
            cloneCube1.Z = 0;
            cloneCube1.Size = 0;
            cloneCube1.Color = "Yellow";
            cloneCube1.Info();

            cloneCube2.X = 1;
            cloneCube2.Y = 1;
            cloneCube2.Z = 1;
            cloneCube2.Size = 1;
            cloneCube2.Color = "Blue";
            cloneCube2.Info();

            originalCube.Info();
        }
    }

    public interface ICloneable3D
    {
        public ICloneable3D Clone();
    }
    public abstract class Shape3D : ICloneable3D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public string Color { get; set; }
        public Shape3D(float x, float y, float z, string color)
        {
            X = x;
            Y = y;
            Z = z;
            Color = color;
        }
        public abstract ICloneable3D Clone();

        public abstract void Info();
    }
    public class Sphere : Shape3D
    {
        public float Radius { get; set; }
        public Sphere(float x, float y, float z, string color, float radius)
            : base(x, y, z, color)
        {
            Radius = radius;
        }
        public override ICloneable3D Clone()
        {
            return new Sphere(X, Y, Z, Color, Radius);
        }
        public override void Info()
        {
            Console.WriteLine($"{X} {Y} {Z} {Color} {Radius}");
        }
    }
    public class Cube : Shape3D
    {
        public float Size { get; set; }
        public Cube(float x, float y, float z, string color, float size)
            : base(x, y, z, color)
        {
            Size = size;
        }
        public override ICloneable3D Clone()
        {
            return new Cube(X, Y, Z, Color, Size);
        }
        public override void Info()
        {
            Console.WriteLine($"{X} {Y} {Z} {Color} {Size}");
        }
    }
}
