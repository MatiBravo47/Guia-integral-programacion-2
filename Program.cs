using Guia_integral_programacion;
using System;
using System.Globalization;
using Controllers;
using Models;
using Utils;
using Views;
namespace Guia_integral_programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Guia integral programacion";
            var menuController = new MenuPrincipalController();
            menuController.ShowMenu();
        }
    }
}
