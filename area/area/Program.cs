﻿using System;

class area
{
    public class Geometry
    {
        public const double pi = Math.PI;

        protected double r;

        public Geometry()
        { 
        }

        public Geometry(double x)
        {
            r = x;
        }

        //求面积，为虚方法，子类可重载该方法
        public virtual double Area()
        {
            return r * r;
        }
       
    }

    //圆
    public class Circle : Geometry
    {
        public Circle(double r): base(r)
        { 
        }

        //方法重载
        public override double Area()
        {
            return pi * r * r;
        }
    }

    //球体
    public class Sphere : Geometry
    {
        public Sphere(double r): base(r)
        {       
        }

        public override double Area()
        {
            return 4 * pi * r * r;
        }
    }

    //等边三角形
    public class EquilateralTriangle : Geometry
    {
        public EquilateralTriangle(double r): base(r)
        { 
        }

        public override double Area()
        {
            return r * r * Math.Sin(pi / 3.0) / 2.0;
        }
    }

    public static void Main()
    {
        double r = 4.0;

        Geometry a = new Geometry(r);
        Geometry c = new Circle(r);
        Geometry s = new Sphere(r);
        Geometry et = new EquilateralTriangle(r);

        Console.WriteLine("r={0},相应的", r);
        Console.WriteLine("正方形的面积：{0}", a.Area());
        Console.WriteLine("圆形的面积：{0}", c.Area());
        Console.WriteLine("球体的面积：{0}", s.Area());
        Console.WriteLine("等边三角形面积：{0}", et.Area());

        Console.ReadLine();
    }
}
