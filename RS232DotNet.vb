Public Class Form1

    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived

        Try
            Dim data As String
            data = SerialPort1.ReadExisting()
            tDatos.AppendText(data)
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Control.CheckForIllegalCrossThreadCalls = False
        
        If SerialPort1.IsOpen = True Then
            SerialPort1.Close()
            SerialPort1.Open()
        Else
            SerialPort1.Open()
        End If

    End Sub

End Class
