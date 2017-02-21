Imports System.IO.Ports

Public Class frmSerialPort



    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        GetSerialPortNames()
    End Sub

    Private Sub btnOpen_Click(sender As System.Object, e As System.EventArgs) Handles btnOpen.Click

    End Sub

    Sub GetSerialPortNames()
        tslStatus.Text = "suche..."
        cbxSerialPort.Items.Clear()
        cbxSerialPort.Text = String.Empty
        Try
            ' Show all available COM ports.
            For Each sp As String In My.Computer.Ports.SerialPortNames
                cbxSerialPort.Items.Add(sp)

            Next
        Catch ex As Exception
            tslStatus.Text = ex.Message
        Finally
            tslStatus.Text = "...fertig"
        End Try
        If cbxSerialPort.Items.Count < 1 Then
            cbxSerialPort.Items.Add("...keine gefunden...")
        End If
    End Sub

    Function ReceiveSerialData(ByVal _com As String) As String
        ' Receive strings from a serial port.
        Dim returnStr As String = ""

        Dim com1 As IO.Ports.SerialPort = Nothing
        Try
            com1 = My.Computer.Ports.OpenSerialPort(_com)
            com1.ReadTimeout = 10000
            Do
                Dim Incoming As String = com1.ReadLine()
                If Incoming Is Nothing Then
                    Exit Do
                Else
                    returnStr &= Incoming & vbCrLf
                End If
            Loop
        Catch ex As TimeoutException
            returnStr = "Error: Serial Port read timed out."
        Finally
            If com1 IsNot Nothing Then com1.Close()
        End Try

        Return returnStr
    End Function

    Private Sub btnRead_Click(sender As System.Object, e As System.EventArgs) Handles btnRead.Click
        rtbSerialOutput.Text = ReceiveSerialData("Com4")
    End Sub
End Class
