
using System;

// Q9, Q11
class Car : IMoveable
{
    public void MoveForward()
    {
        Console.WriteLine("Car moves forward on the ground");
    }

    public void MoveBackward()
    {
        Console.WriteLine("Car moves backward on the ground");
    }
}

// Q10
interface IMoveable
{
    void MoveForward();
    void MoveBackward();
}

interface IFlyable
{
    void MoveUp();
    void MoveDown();
}

// Q11
class Ship : IMoveable
{
    public void MoveForward()
    {
        Console.WriteLine("Ship moves forward on the sea");
    }

    public void MoveBackward()
    {
        Console.WriteLine("Ship moves backward on the sea");
    }
}

class Airplane : IMoveable, IFlyable
{
    public void MoveForward()
    {
        Console.WriteLine("Airplane moves forward in the air");
    }

    public void MoveBackward()
    {
        Console.WriteLine("Airplane moves backward in the air");
    }

    public void MoveUp()
    {
        Console.WriteLine("Airplane moves up");
    }

    public void MoveDown()
    {
        Console.WriteLine("Airplane moves down");
    }
}

// Q13
interface IVehicle : IMoveable, IFlyable
{
}

class Vehicle : IVehicle
{
    public virtual void MoveForward()
    {
        Console.WriteLine("Vehicle moves forward");
    }

    public virtual void MoveBackward()
    {
        Console.WriteLine("Vehicle moves backward");
    }

    public virtual void MoveUp()
    {
        Console.WriteLine("Vehicle moves up");
    }

    public virtual void MoveDown()
    {
        Console.WriteLine("Vehicle moves down");
    }
}

// Q14
class ExplicitShip : IMoveable
{
    void IMoveable.MoveForward()
    {
        Console.WriteLine("Ship moves forward on the sea");
    }

    public void MoveBackward()
    {
        Console.WriteLine("Ship moves backward on the sea");
    }
}

class Program
{
    static void Main()
    {
        // Q9: Car
        Car car = new Car();

        car.MoveForward();
        car.MoveBackward();

        // Q11: Ship
        Ship ship = new Ship();

        ship.MoveForward();
        ship.MoveBackward();

        // Q11: Airplane
        Airplane airplane = new Airplane();

        airplane.MoveForward();
        airplane.MoveBackward();
        airplane.MoveUp();
        airplane.MoveDown();

        // Q12: Interface References
        IMoveable carRef = new Car();

        carRef.MoveForward();
        carRef.MoveBackward();

        IMoveable planeRef = new Airplane();

        planeRef.MoveForward();
        planeRef.MoveBackward();

        // planeRef.MoveUp(); 
        // Error because IMoveable does not contain MoveUp()

        IFlyable flyRef = new Airplane();

        flyRef.MoveUp();
        flyRef.MoveDown();

        // Q13: Interface Inheritance
        Vehicle vehicle = new Vehicle();

        vehicle.MoveForward();
        vehicle.MoveBackward();
        vehicle.MoveUp();
        vehicle.MoveDown();

        // Q14: Explicit Interface Implementation
        ExplicitShip explicitShip = new ExplicitShip();

        // explicitShip.MoveForward(); 
        // Error because MoveForward is explicitly implemented.

        IMoveable explicitShipRef = explicitShip;

        explicitShipRef.MoveForward();
        explicitShipRef.MoveBackward();
    }
}
