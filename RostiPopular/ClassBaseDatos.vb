Imports System.Net
Imports System.Web
Imports System.Security.Cryptography
Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Xml.Linq
Imports System.Xml
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Configuration
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Net.Mail
Imports Microsoft.Win32
Imports System.Collections.Specialized
Imports System.Runtime.InteropServices
Public Class ClassBaseDatos
    Public dbBaseDatos As String
    Public dbServidor As String
    Public strConexion As String
    Public Function ConsultaAraticulos(Sala As String, Mesa As String, CodCliente As String) As Boolean

        Dim Comando As String

        Dim DS As DataSet
        Dim MiConnection As SqlConnection
        Dim MiDataAdapter As SqlDataAdapter
        MiDataAdapter = New SqlDataAdapter


        dbBaseDatos = My.Computer.Registry.GetValue(
                "HKEY_CURRENT_USER\Software\ICG\FrontRest2007", "DataBaseSQL5", Nothing)

        dbServidor = My.Computer.Registry.GetValue(
                "HKEY_CURRENT_USER\Software\ICG\FrontRest2007", "ServerSQL5", Nothing)

        strConexion = "server=" + dbServidor + ";database=" + dbBaseDatos + ";User ID=ICGADMIN;Password=masterkey"

        'strConexion = "server=" + "DESKTOP-GF3U3M0" + ";database=" + "DBFRESTpruebas" + ";User ID=sa;Password=masterkey"

        MiConnection = New SqlConnection(strConexion)



        Comando = "
        SELECT CODARTICULO FROM MINUTASLIN WHERE SALA = " + Sala + " AND MESA = " + Mesa + " AND CODCLIENTE =  " + CodCliente + "
"
        MiDataAdapter.SelectCommand = New SqlCommand(Comando, MiConnection)

        DS = New DataSet()
        Try
            MiDataAdapter.Fill(DS, "DATOS")
            If DS.HasErrors = False Then
                For i As Integer = 0 To DS.Tables(0).Rows.Count - 1
                    Dim Articulo = DS.Tables(0).Rows(i)(0)
                    If Articulo = "10257" Then
                        Return True
                    End If
                    If Articulo = "10258" Then
                        Return True
                    End If
                    If Articulo = "10259" Then
                        Return True
                    End If
                    If Articulo = "10260" Then
                        Return True
                    End If
                    If Articulo = "10261" Then
                        Return True
                    End If
                    If Articulo = "10262" Then
                        Return True
                    End If
                    If Articulo = "10263" Then
                        Return True
                    End If
                    If Articulo = "10264" Then
                        Return True
                    End If
                    If Articulo = "10265" Then
                        Return True
                    End If
                    If Articulo = "10266" Then
                        Return True
                    End If
                    If Articulo = "10267" Then
                        Return True
                    End If
                    If Articulo = "10268" Then
                        Return True
                    End If
                    If Articulo = "10269" Then
                        Return True
                    End If
                    If Articulo = "10270" Then
                        Return True
                    End If
                    If Articulo = "10271" Then
                        Return True
                    End If
                    If Articulo = "10272" Then
                        Return True
                    End If
                    If Articulo = "10273" Then
                        Return True
                    End If
                    If Articulo = "10274" Then
                        Return True
                    End If
                Next
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

        MiDataAdapter.Dispose()
        MiConnection.Close()



    End Function


    Public Function GuardaBin(Sala As String, Mesa As String, CodCliente As String, Bin As String) As Boolean

        Dim Comando As String

        Dim DS As DataSet
        Dim MiConnection As SqlConnection
        Dim MiDataAdapter As SqlDataAdapter
        MiDataAdapter = New SqlDataAdapter


        dbBaseDatos = My.Computer.Registry.GetValue(
                "HKEY_CURRENT_USER\Software\ICG\FrontRest2007", "DataBaseSQL5", Nothing)

        dbServidor = My.Computer.Registry.GetValue(
                "HKEY_CURRENT_USER\Software\ICG\FrontRest2007", "ServerSQL5", Nothing)

        strConexion = "server=" + dbServidor + ";database=" + dbBaseDatos + ";User ID=ICGADMIN;Password=masterkey"

        'strConexion = "server=" + "DESKTOP-GF3U3M0" + ";database=" + "DBFRESTpruebas" + ";User ID=sa;Password=masterkey"

        MiConnection = New SqlConnection(strConexion)



        Comando = "
        DECLARE @IDMINUTA NVARCHAR(10), @BIN NVARCHAR(10)
        SET @BIN = '" + Bin + "'
        SELECT @IDMINUTA = IDMINUTA FROM MINUTASCAB WHERE SALA = " + Sala + " AND MESA = " + Mesa + " AND CODCLIENTE =  " + CodCliente + "
    
        IF (SELECT COUNT(IDMINUTA) FROM ROSTI_POPULAR_MINUTA WHERE IDMINUTA = @IDMINUTA ) = 0
        BEGIN
	        INSERT INTO ROSTI_POPULAR_MINUTA (IDMINUTA,BIN_POPULAR)
	        VALUES (@IDMINUTA,@BIN)
        END
        ELSE
        BEGIN
	        UPDATE ROSTI_POPULAR_MINUTA 
		        SET BIN_POPULAR = @BIN WHERE IDMINUTA = @IDMINUTA
        END

"

        MiDataAdapter.SelectCommand = New SqlCommand(Comando, MiConnection)

        DS = New DataSet()
        Try
            MiDataAdapter.Fill(DS, "DATOS")
            If DS.HasErrors = False Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try

        MiDataAdapter.Dispose()
        MiConnection.Close()



    End Function

    Public Function ActualizarCamposLibres() As Boolean

        Dim Comando As String

        Dim DS As DataSet
        Dim MiConnection As SqlConnection
        Dim MiDataAdapter As SqlDataAdapter
        MiDataAdapter = New SqlDataAdapter


        dbBaseDatos = My.Computer.Registry.GetValue(
                "HKEY_CURRENT_USER\Software\ICG\FrontRest2007", "DataBaseSQL5", Nothing)

        dbServidor = My.Computer.Registry.GetValue(
                "HKEY_CURRENT_USER\Software\ICG\FrontRest2007", "ServerSQL5", Nothing)

        strConexion = "server=" + dbServidor + ";database=" + dbBaseDatos + ";User ID=ICGADMIN;Password=masterkey"

        'strConexion = "server=" + "10.1.13.2" + ";database=" + "DBFREST" + ";User ID=sa;Password=masterkey"

        MiConnection = New SqlConnection(strConexion)



        Comando = "
        UPDATE TVC
	        SET TVC.BIN_POPULAR = RP.BIN_POPULAR
	        FROM TIQUETSVENTACAMPOSLIBRES TVC
        INNER JOIN TIQUETSCAB TC 
        ON TC.SERIE = TVC.SERIE AND TC.NUMERO = TVC.NUMERO AND TC.N = TVC.N
        INNER JOIN ROSTI_POPULAR_MINUTA RP
        ON RP.IDMINUTA = TC.IDMINUTA AND RP.CAMPOLIBRE IS NULL

"

        MiDataAdapter.SelectCommand = New SqlCommand(Comando, MiConnection)
        MiDataAdapter.SelectCommand.CommandTimeout = 4000

        DS = New DataSet()
        Try
            MiDataAdapter.Fill(DS, "DATOS")
            If DS.HasErrors = False Then
                Return True
            End If
        Catch ex As Exception
            MiDataAdapter.Dispose()
            MiConnection.Close()

            Return False
        End Try
        RostiPopular.Close()



    End Function

End Class

