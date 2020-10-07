Imports System

Module Program
    Sub Main(args As String())
        Dim i16 As Short = 1
        Dim i32 As Integer = 1
        Dim db As Double = 1
        i16 = i32
        i16 = db
        i32 = i16
        i32 = db
        db = i16
        db = i32
    End Sub
End Module
