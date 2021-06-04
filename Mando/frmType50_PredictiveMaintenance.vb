Public Class frmType50_PredictiveMaintenance

    Public NCDComponent1 As NCDEnterprise.NCDController        ' define a public variable so that the parents form can assign a value to it
    Public SensorAddress As String
    Public Shared DataFrame As New NCDLib.Wireless.S3B_API.SensorData
    Public Shared Type50 As New NCDLib.Wireless.S3B_API.SensorData.TypeData.Type50
    Private Sub frmType50_Predictive_Maintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Type 50 Predictive Maintenance Sensor - Address: " + SensorAddress
        Timer1.Interval = 10 '3000
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False  ' disable timer1
        BackgroundWorker1.RunWorkerAsync()
        Return
    End Sub
    Private Sub frmClose(sender As Object, e As EventArgs) Handles MyBase.Closed
        Timer1.Stop()
        BackgroundWorker1.CancelAsync()
        While BackgroundWorker1.IsBusy
            Application.DoEvents()
            Timer1.Stop()
        End While
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        'Receive Data from Wireless Sensor
        If BackgroundWorker1.CancellationPending = True Then Exit Sub
        Debug.Print("----------------------------------------------------------------------------------------------------------------------------Sensor Type DoWork Loop Start ------------ ")
        DataFrame = NCDLib.Wireless.S3B_API.SensorDataCapture(NCDComponent1, SensorAddress)
        Debug.Print(" ------------ DoWork Loop  Stop")
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Debug.Print("----------------------------------------------------------------------------------------------------------------------------Sensor Worker Finished ------------ ")
        'Parse Data
        If (DataFrame.Valid) Then
            Waiting.Visible = False
            BatteryLevel.Value = DataFrame.BatteryInt   'Show Battery Progress Bar
            Battery.Text = DataFrame.Battery            'Show Battery Voltage in Text Box
            NODEID.Text = DataFrame.NodeID              'Show Device Node ID Data
            Address.Text = SensorAddress                'Show Sensor Address
            Counter.Text = DataFrame.Counter.ToString   'Show Transmission Cycle Counter
            SensorType.Text = DataFrame.SensorType.ToString 'Show Sensor Type
            SensorInfo.Text = DataFrame.Description     'Show Sensor Description
            Firmware.Text = DataFrame.Firmware          'Show Firmware Version
            Summary.Text = DataFrame.SensorReadings     'Show a Summary View of All Sensor Data

            CompleteFrame.Text = NCDLib.Math.ConvertBytesToHexArrayString(DataFrame.CompleteFrame)
            CompletePayload.Text = NCDLib.Math.ConvertBytesToHexArrayString(DataFrame.CompletePayload)
            SensorPayload.Text = NCDLib.Math.ConvertBytesToHexArrayString(DataFrame.SensorPayload)

            RMSX.Text = Type50.RMSX.ToString
            RMSY.Text = Type50.RMSY.ToString
            RMSZ.Text = Type50.RMSZ.ToString

            MAXX.Text = Type50.MAXX.ToString
            MAXY.Text = Type50.MAXY.ToString
            MAXZ.Text = Type50.MAXZ.ToString

            MINX.Text = Type50.MINX.ToString
            MINY.Text = Type50.MINY.ToString
            MINZ.Text = Type50.MINZ.ToString

            Vibration_Celsius.Text = Type50.Vibration_Celsius
            Vibration_Fahrenheit.Text = Type50.Vibration_Fahrenheit

            Thermocouple_Celsius.Text = Type50.Thermocouple_Celsius
            Thermocouple_Fahrenheit.Text = Type50.Thermocouple_Fahrenheit

            Amps.Text = Type50.Amps.ToString
            Milliamps.Text = Type50.Milliamps.ToString
        End If
        Timer1.Enabled = True
    End Sub
End Class