Imports System.Data.OleDb
Public Class DaoUsuario

    Protected conexion As New Conexion()

    Public Function ValidarUsuario(usuario As Usuarios)

        Dim command As New OleDbCommand

        Dim dataset As New DataSet

        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()

        command.CommandText = "select * from Usuarios where NombreUsuario = '" & usuario.Nick & "' and Password = '" & usuario.Password & "'"
        Dim reader As New OleDbDataAdapter
        reader.SelectCommand = command
        reader.Fill(dataset)

        conexion.CerrarConexion()

        Return dataset.Tables(0).Rows.Count
    End Function

    Function AgregarUsuario(usuario As Usuarios)


        Dim command As New OleDbCommand
        command.Connection = conexion.GetConexion()

        conexion.AbrirConexion()


        command.CommandText = "Insert into Usuarios (NombreUsuario, Password) values (" & usuario.Nick & "," & usuario.Password & ")"

        command.ExecuteNonQuery()

        conexion.CerrarConexion()

        Return usuario

    End Function
End Class
