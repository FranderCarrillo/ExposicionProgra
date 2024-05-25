using System;

// Paso 1: Definir una interfaz
public interface IVehiculo
{
    void Mover();
}

// Paso 2: Implementar clases concretas que implementen la interfaz
public class Coche : IVehiculo
{
    public void Mover()
    {
        Console.WriteLine("El coche se mueve.");
    }
}

public class Bicicleta : IVehiculo
{
    public void Mover()
    {
        Console.WriteLine("La bicicleta se mueve.");
    }
}

// Paso 3: Implementar la Factory
public class VehiculoFactory
{
    public IVehiculo CrearVehiculo(string tipo)
    {
        switch (tipo.ToLower())
        {
            case "coche":
                return new Coche();
            case "bicicleta":
                return new Bicicleta();
            default:
                throw new ArgumentException("Tipo de vehículo desconocido.");
        }
    }
}

// Uso de la Factory
class Program
{
    static void Main(string[] args)
    {
        VehiculoFactory factory = new VehiculoFactory();

        Console.WriteLine("¿Qué vehículo desea crear? (coche/bicicleta)");
        string tipoVehiculo = Console.ReadLine();

        try
        {
            // Crear un vehículo según la entrada del usuario
            IVehiculo vehiculo = factory.CrearVehiculo(tipoVehiculo);
            vehiculo.Mover();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
}
