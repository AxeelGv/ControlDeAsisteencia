using System;
using ControlDeAsisteencia; 

class Program
{
    static void Main(string[] args)
    {
       
        Universidad.Estudiante[] estudiantes = new Universidad.Estudiante[]
        {
            new Universidad.Estudiante("Carlos Pérez", 20, 15),
            new Universidad.Estudiante("Ana García", 25, 22),
            new Universidad.Estudiante("Luis Fernández", 30, 20),
            new Universidad.Estudiante("Marta López", 20, 14)
        };