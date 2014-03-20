
import sys
sys.path.append("C:\Users\Victor\Documents\GitHub\PlataformaNET\Ejercicios Plataforma .NET\Modulo 1\Demo 5\DLL")
import clr

clr.AddReferenceToFile("Vehiculo.dll")
from EjemploIntegracion import *
print "PROGRAMA: Usa la clase base Vehiculo"
print "------------------------------------"
v = Vehiculo()
v.DoblarIzquierda()
v.DoblarDerecha()
print ""

clr.AddReferenceToFile("Avion.dll")
from IntegracionAvion import *
print "PROGRAMA: Usa la clase Avion"
print "------------------------------------"
p = Avion()
p.AplicarFrenos()
p.DoblarDerecha()
p.DoblarIzquierda()
print ""

clr.AddReferenceToFile("Auto.dll")
from IntegracionAuto import *
print "PROGRAMA: Usa la clase Auto"
print "------------------------------------"
a = Auto()
a.AplicarFrenos()
a.DoblarDerecha()
a.DoblarIzquierda()
print ""

i = raw_input("Un tecla para seguir:")