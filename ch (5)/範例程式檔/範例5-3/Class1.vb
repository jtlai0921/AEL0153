Public Class mymath
    Public Overloads Function area(ByVal m1 As Single, ByVal m2 As Single)
        Return m1 * m2 / 2
    End Function
    Public Overloads Function area(ByVal m1 As Single)
        Return 3.14 * m1 * m1
    End Function
End Class
