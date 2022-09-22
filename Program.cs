using System;

namespace DzmitryKryvenki
{
 public static class Program
 {
   public static void Main(string[] args)
  {
   var _ferrari = new Car();
   var _titanik = new Ship();
   var _boeing = new Plane();

   Console.WriteLine(_ferrari.Go());
   Console.WriteLine(_titanik.Go());
   Console.WriteLine(_boeing.Go());
  }
   public abstract class Vehicle
  {
   public abstract string Go();
  }

  public class Car : Vehicle
  {
   public override string Go() => "Бип!";
  }

  public class Ship : Vehicle
  {
   public override string Go() => "ТУУУУ!";
  }

  public class Plane : Vehicle
  {
   public override string Go() => "Ууууу!";
  }
 }
}