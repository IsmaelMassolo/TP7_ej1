/*Desarrollar una aplicación que solicite las calificaciones de alumnos de un curso,
previamente se debe almacenar nombre del curso y turno. Al finalizar se debe informar la nota
promedio y asociarlo al nombre del curso registrado (Ejemplo: Primer Año – Turno Mañana –
Promedio: 7). Se debe permitir que la cantidad de alumnos por curso sea variable.*/
using System;
using System.Threading;
namespace Ej1Tp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            float promedio = 0, numDeAlumnos = 0;
            string curso = "", turno="";
            titular();
            Console.WriteLine("Ingrese el nombre del curso");
            curso = Console.ReadLine();
            Console.WriteLine("Ingrese el turno");
            turno = Console.ReadLine();
            titular();
            Console.WriteLine("Ingrese la cantidad de alumnos del curso "+ curso );
            numDeAlumnos = Convert.ToInt32(Console.ReadLine());
            titular();
            for (i = 1; i <= numDeAlumnos; i++)
                {
                    Console.WriteLine(curso + "\n");
                    Console.WriteLine("Ingrese nota del alumno " + i + "\n");
                    promedio = promedio + Convert.ToSingle(Console.ReadLine());
                    titular();
                }
            titular();
            Console.WriteLine("Curso: " +curso+ " - Turno: " +turno +" - Alumnos registrados: "+ numDeAlumnos+" - Promedio general: " + (promedio / numDeAlumnos + "\n"));
            Console.WriteLine("                    gracias por usar promedi.ar \n");
            Console.WriteLine("****************************************************************");
        }
        static void titular()
        {
            string titulo = "---------------------- P R O M E D I . A R --------------------- \n";
            Console.Clear();
            Console.WriteLine(titulo);
        }
    }
}