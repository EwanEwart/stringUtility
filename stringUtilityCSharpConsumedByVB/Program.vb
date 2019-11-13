Imports System

Module Program
    Sub Main(args As String())

        Console.WriteLine("Consume stringUtility.")

        ' Consume C# class library
        Dim theStringUtility As New StringUtility.StringLibrary()
        Console.WriteLine(theStringUtility.StartsWithUpper("Sts"))

    End Sub
End Module
