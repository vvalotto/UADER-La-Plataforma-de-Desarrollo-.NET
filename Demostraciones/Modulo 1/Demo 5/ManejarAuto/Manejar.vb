Imports IntegracionAuto.Auto

Module Manejar

    Sub Main()

        Dim a As IntegracionAuto.Auto = New IntegracionAuto.Auto

        Console.WriteLine("PRUEBA: Uso de la Clase Auto en VB heredando de la biblioteca Vehiculo")
        Console.WriteLine("----------------------------------------------------------------------")
        a.DoblarDerecha()
        a.DoblarIzquierda()
        a.AplicarFrenos()
        Console.WriteLine("Un tecla para continuar")
        Console.ReadLine()

    End Sub

End Module
