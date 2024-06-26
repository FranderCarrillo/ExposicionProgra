﻿using System;
using System.Diagnostics.Contracts;

public interface IVehiculo
{
    void MostrarInfo();
}

public class Coche : IVehiculo
{
    public void MostrarInfo()
    {
        Console.WriteLine("Ha alquilado un Coche.");
    }
}

public class Bicicleta : IVehiculo
{
    public void MostrarInfo()
    {
        Console.WriteLine("Ha alquilado una Bicicleta.");
    }
}
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
                return null;
        }
    }
}

// Uso de la Factory
class Program
{
    static void Main(string[] args)
    {
        VehiculoFactory factory = new VehiculoFactory();

        Console.WriteLine("¿Qué tipo de vehículo desea Alquilar? (coche/bicicleta)");
        string tipoVehiculo = Console.ReadLine().ToLower();

        // Verificar si el tipo de vehículo es válido
        if (tipoVehiculo == "coche" || tipoVehiculo == "bicicleta")
        {
            // Crear un vehículo según la entrada del usuario
            IVehiculo vehiculo = factory.CrearVehiculo(tipoVehiculo);
            vehiculo.MostrarInfo();
        }
        else
        {
            Console.WriteLine("Tipo de vehículo desconocido.");
        }
    }
}
