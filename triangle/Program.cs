using System;
class Program
{
    static void Main()
    {
        float cylinderRadius = Inputfloat("円柱の底面積の半径");
        float cylinderHeight = Inputfloat("円柱の高さ");
        float cylinderVol = Cylinder.GetCylinderVolume(cylinderRadius, cylinderHeight);
        float cylinderSur = Cylinder.GetCylinderSurface(cylinderRadius, cylinderHeight);
        Console.WriteLine($"円柱の表面積は{cylinderSur}");
        Console.WriteLine($"円柱の体積は{cylinderVol}");

        float sphereRadius = Inputfloat("球の半径");
        float sphereVol = Sphere.GetSphereVolume(sphereRadius);
        float sphereSur = Sphere.GetSphereSurface(sphereRadius);
        Console.WriteLine($"球の表面積は{sphereSur}");
        Console.WriteLine($"球の体積は{sphereVol}");

        float triangularSide = Inputfloat("三角柱の底面の2辺の長さ");
        float triangularHeight = Inputfloat("三角柱の高さ");
        float triangularVol = Triangular.GetTriVolume(triangularSide, triangularHeight);
        float triangularSur = Triangular.GetTriSurface(triangularSide, triangularHeight);
        Console.WriteLine($"三角柱の表面積は{triangularSur}");
        Console.WriteLine($"三角柱の体積は{triangularVol}");
    }
    static float Inputfloat(string s)
    {
        while (true)
        {
            Console.WriteLine(s);
            try
            {
                float a = float.Parse(Console.ReadLine());
                if (a <= 0)
                {
                    Console.WriteLine("入力エラー");
                }
                else
                {
                    return a;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("数字を入れてください");
            }
        }
    }
}
static class Cylinder
{
    static public float GetCylinderVolume(float rad,float height)
    {
        return rad * rad * (float)Math.PI * height;
    }

    static public float GetCylinderSurface(float rad,float height)
    {
        return 2*rad * rad * (float)Math.PI + 2*rad*(float)Math.PI * height;
    }
}

static class Sphere
{
    static public float GetSphereVolume(float rad)
    {
        return (float)4 / (float)3 * (float)Math.PI * rad * rad * rad;
    }
    static public float GetSphereSurface(float rad)
    {
        return 4*(float)Math.PI * rad * rad;
    }
}
static class Triangular
{
    static public float GetTriVolume(float side,float height)
    {
        return side * side / 2 * height;
    }
    static public float GetTriSurface(float side, float height)
    {
        return side * side + side * height * 2 + (float)Math.Sqrt(2) * side * height;
    }
}