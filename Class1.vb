Imports Microsoft.VisualBasic

Public Class Class1
    Module Program
        Sub Main(args As String())
            Dim Xl As Single
            Dim F As Single
            Dim I As Single
            Dim PI As Single
            Console.WriteLine("Ingrese el valor de la frecuencia: ")
            F = Console.ReadLine()
            Console.WriteLine("Ingrese el valor de la inductancia: ")
            I = Console.ReadLine()
            PI = 3.1415
            Xl = 2 * PI * F * I
            Console.WriteLine("El valor de Xl es: " & Xl)
            Console.ReadLine()
        End Sub
    End Module

End Class
