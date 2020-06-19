Public Class BsnUsuario

    Dim daoUsuario As New DaoUsuario

    Public Function ValidarUsuario(usuario As Usuarios)

        Return daoUsuario.ValidarUsuario(usuario)

    End Function

    Public Function AgregarUsuario(usuario As Usuarios)

        Return daoUsuario.AgregarUsuario(usuario)

    End Function

End Class
