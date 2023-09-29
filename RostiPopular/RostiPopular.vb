Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices
Imports System.Xml

Public Class RostiPopular

    Public Mesa As String
    Public Sala As String
    Public Cliente As String
    Public BIN As String

    Private Sub RostiPopular_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim BD As New ClassBaseDatos

        Me.WindowState = FormWindowState.Maximized
        btnAvanzar.Enabled = False
        Try
            BD.ActualizarCamposLibres()
        Catch ex As Exception
            Me.Close()
        End Try

        Try
            LeeArchivoDatos()
        Catch ex As Exception
            Me.Close()
        End Try


        Try
            If Sala IsNot Nothing Then
                If BD.ConsultaAraticulos(Sala, Mesa, Cliente) Then
                    Me.WindowState = FormWindowState.Maximized
                    Me.TopMost = True
                Else
                    Process.GetProcessesByName("RostiPopular")(0).CloseMainWindow()
                    'RostiPopular.ActiveForm.Close()
                    'Me.Dispose()
                    'Me.Close()
                    'Me.Finalize()

                End If
            Else
                Process.GetProcessesByName("RostiPopular")(0).Kill()
                Me.Dispose()
                Me.Finalize()
                Me.Close()
            End If
        Catch ex As Exception
            Process.GetProcessesByName("RostiPopular")(0).Kill()
            Me.Close()
        End Try
        'Process.GetProcessesByName("RostiPopular")(0).Dispose()
        'Me.Dispose()
        'Me.Close()
        'Me.Finalize()


    End Sub


    Private Sub LeeArchivoDatos()
        Dim inDoc As New XmlDocument

        If My.Computer.FileSystem.FileExists("PopularTXT") Then

            Try
                inDoc.Load("PopularTXT")
            Catch ex As Exception
                'MsgBox("Archivo: " + "PopularTXT" + " no encontrado")
                Me.Close()
            End Try

            Dim doc As XmlNodeList = inDoc.GetElementsByTagName("doc")

            For Each nodo As XmlElement In inDoc.GetElementsByTagName("sala")
                Sala = nodo.InnerText
            Next
            For Each nodo As XmlElement In inDoc.GetElementsByTagName("mesa")
                Mesa = nodo.InnerText
            Next
            For Each nodo As XmlElement In inDoc.GetElementsByTagName("codcliente")
                Cliente = nodo.InnerText
            Next

        Else

        End If

    End Sub

    Private Sub txtBines_TextChanged(sender As Object, e As EventArgs) Handles txtBines.TextChanged
        Dim Valida As Boolean = False
        If txtBines.Text.Count >= 4 Then
            If Mid(txtBines.Text, 1, 4) = Mid("40293200", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("40293200", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("40570501", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("40973111", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("40973112", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("40973113", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("40973114", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("40973115", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("40973116", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("40973117", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("40973121", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("40973122", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("40973123", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("47639901", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("47639902", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("47639903", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("47639905", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("47639906", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("47639907", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("47639909", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("47639910", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("47639911", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374401", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374408", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374409", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374415", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374420", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374425", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374426", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374428", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374429", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374430", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374431", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374432", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374433", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374434", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374501", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374506", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374511", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374512", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374514", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374515", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374519", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("49374520", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("52494600", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("52494601", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("52494602", 1, 4) Then
                Valida = True
            End If
            If Mid(txtBines.Text, 1, 4) = Mid("52494603", 1, 4) Then
                Valida = True
            End If

            If Valida Then
                txtMensaje.BackColor = Color.Green
                txtMensaje.ForeColor = Color.White
                txtMensaje.Text = "Esta tarjeta es Válida, por favor proceder a cobrar"
                BIN = Mid(txtBines.Text, 1, 4)
                btnAvanzar.Enabled = True
            Else
                txtMensaje.BackColor = Color.Orange
                txtMensaje.ForeColor = Color.Black
                txtMensaje.Text = "Esta tarjeta NO es Válida, NO cobrar. Elimine los artículos promocionales"
                BIN = "NA"
                'btnAvanzar.Enabled = True
            End If
        Else
            btnAvanzar.Enabled = False
        End If



    End Sub

    Private Sub btnAvanzar_Click(sender As Object, e As EventArgs) Handles btnAvanzar.Click
        Dim BD As New ClassBaseDatos
        BD.GuardaBin(Sala, Mesa, Cliente, BIN)
        Me.Close()
    End Sub



    'Private Sub RostiPopular_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
    '    Me.Dispose() 'Destruyo el formulario.me.
    '    Close() 'Lo cierro por si queda abierto.
    '    Finalize()
    'End Sub
End Class
