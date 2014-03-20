Imports System
Imports EjemploIntegracion

Public Class Auto
    Inherits Vehiculo

    Public Overrides Sub DoblarIzquierda()
        Console.WriteLine("El auto dobla a la izquierda")
    End Sub

    Public Overrides Sub DoblarDerecha()
        Console.WriteLine("El auto dobla a la derecha")
    End Sub

    Public Overrides Sub AplicarFrenos()
        Console.WriteLine("El auto frenó")
    End Sub


End Class




