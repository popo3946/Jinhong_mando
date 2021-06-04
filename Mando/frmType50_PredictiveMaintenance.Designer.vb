<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmType50_PredictiveMaintenance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmType50_PredictiveMaintenance))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RMSX = New System.Windows.Forms.TextBox()
        Me.RMSY = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Vibration_Celsius = New System.Windows.Forms.TextBox()
        Me.Vibration_Fahrenheit = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RMSZ = New System.Windows.Forms.TextBox()
        Me.MINZ = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MAXX = New System.Windows.Forms.TextBox()
        Me.MINY = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MAXY = New System.Windows.Forms.TextBox()
        Me.MINX = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MAXZ = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.SensorPayload = New System.Windows.Forms.TextBox()
        Me.CompletePayload = New System.Windows.Forms.TextBox()
        Me.CompleteFrame = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Waiting = New System.Windows.Forms.Label()
        Me.Summary = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Firmware = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SensorType = New System.Windows.Forms.TextBox()
        Me.SensorInfo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Counter = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Battery = New System.Windows.Forms.TextBox()
        Me.BatteryLevel = New System.Windows.Forms.ProgressBar()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NODEID = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Thermocouple_Celsius = New System.Windows.Forms.TextBox()
        Me.Thermocouple_Fahrenheit = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Amps = New System.Windows.Forms.TextBox()
        Me.Milliamps = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.RMSX)
        Me.GroupBox4.Controls.Add(Me.RMSY)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.RMSZ)
        Me.GroupBox4.Controls.Add(Me.MINZ)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.MAXX)
        Me.GroupBox4.Controls.Add(Me.MINY)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.MAXY)
        Me.GroupBox4.Controls.Add(Me.MINX)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.MAXZ)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 221)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(852, 134)
        Me.GroupBox4.TabIndex = 46
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Vibration Sensor Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "RMS X"
        '
        'RMSX
        '
        Me.RMSX.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RMSX.Location = New System.Drawing.Point(77, 21)
        Me.RMSX.Name = "RMSX"
        Me.RMSX.Size = New System.Drawing.Size(100, 29)
        Me.RMSX.TabIndex = 0
        '
        'RMSY
        '
        Me.RMSY.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RMSY.Location = New System.Drawing.Point(77, 56)
        Me.RMSY.Name = "RMSY"
        Me.RMSY.Size = New System.Drawing.Size(100, 29)
        Me.RMSY.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Vibration_Celsius)
        Me.GroupBox1.Controls.Add(Me.Vibration_Fahrenheit)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(603, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 101)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vibration Sensor Temperature"
        '
        'Vibration_Celsius
        '
        Me.Vibration_Celsius.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vibration_Celsius.Location = New System.Drawing.Point(84, 20)
        Me.Vibration_Celsius.Name = "Vibration_Celsius"
        Me.Vibration_Celsius.Size = New System.Drawing.Size(100, 29)
        Me.Vibration_Celsius.TabIndex = 19
        '
        'Vibration_Fahrenheit
        '
        Me.Vibration_Fahrenheit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vibration_Fahrenheit.Location = New System.Drawing.Point(84, 55)
        Me.Vibration_Fahrenheit.Name = "Vibration_Fahrenheit"
        Me.Vibration_Fahrenheit.Size = New System.Drawing.Size(100, 29)
        Me.Vibration_Fahrenheit.TabIndex = 21
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(52, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 20)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "°C"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(52, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "°F"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "RMS Y"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(419, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "MIN Z"
        '
        'RMSZ
        '
        Me.RMSZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RMSZ.Location = New System.Drawing.Point(77, 91)
        Me.RMSZ.Name = "RMSZ"
        Me.RMSZ.Size = New System.Drawing.Size(100, 29)
        Me.RMSZ.TabIndex = 4
        '
        'MINZ
        '
        Me.MINZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MINZ.Location = New System.Drawing.Point(485, 91)
        Me.MINZ.Name = "MINZ"
        Me.MINZ.Size = New System.Drawing.Size(100, 29)
        Me.MINZ.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "RMS Z"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(419, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "MIN Y"
        '
        'MAXX
        '
        Me.MAXX.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MAXX.Location = New System.Drawing.Point(279, 21)
        Me.MAXX.Name = "MAXX"
        Me.MAXX.Size = New System.Drawing.Size(100, 29)
        Me.MAXX.TabIndex = 6
        '
        'MINY
        '
        Me.MINY.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MINY.Location = New System.Drawing.Point(485, 56)
        Me.MINY.Name = "MINY"
        Me.MINY.Size = New System.Drawing.Size(100, 29)
        Me.MINY.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(213, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "MAX X"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(419, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 20)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "MIN X"
        '
        'MAXY
        '
        Me.MAXY.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MAXY.Location = New System.Drawing.Point(279, 56)
        Me.MAXY.Name = "MAXY"
        Me.MAXY.Size = New System.Drawing.Size(100, 29)
        Me.MAXY.TabIndex = 8
        '
        'MINX
        '
        Me.MINX.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MINX.Location = New System.Drawing.Point(485, 21)
        Me.MINX.Name = "MINX"
        Me.MINX.Size = New System.Drawing.Size(100, 29)
        Me.MINX.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(213, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "MAX Y"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(213, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "MAX Z"
        '
        'MAXZ
        '
        Me.MAXZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MAXZ.Location = New System.Drawing.Point(279, 91)
        Me.MAXZ.Name = "MAXZ"
        Me.MAXZ.Size = New System.Drawing.Size(100, 29)
        Me.MAXZ.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.SensorPayload)
        Me.GroupBox3.Controls.Add(Me.CompletePayload)
        Me.GroupBox3.Controls.Add(Me.CompleteFrame)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 492)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(852, 125)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Raw Data from Sensor"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(24, 95)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(105, 16)
        Me.Label22.TabIndex = 43
        Me.Label22.Text = "Sensor Payload"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(9, 67)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 16)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "Complete Payload"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(21, 28)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(108, 16)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Complete Frame"
        '
        'SensorPayload
        '
        Me.SensorPayload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SensorPayload.Location = New System.Drawing.Point(139, 92)
        Me.SensorPayload.Name = "SensorPayload"
        Me.SensorPayload.Size = New System.Drawing.Size(704, 22)
        Me.SensorPayload.TabIndex = 31
        '
        'CompletePayload
        '
        Me.CompletePayload.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompletePayload.Location = New System.Drawing.Point(139, 64)
        Me.CompletePayload.Name = "CompletePayload"
        Me.CompletePayload.Size = New System.Drawing.Size(704, 22)
        Me.CompletePayload.TabIndex = 28
        '
        'CompleteFrame
        '
        Me.CompleteFrame.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompleteFrame.Location = New System.Drawing.Point(139, 22)
        Me.CompleteFrame.Multiline = True
        Me.CompleteFrame.Name = "CompleteFrame"
        Me.CompleteFrame.Size = New System.Drawing.Size(704, 38)
        Me.CompleteFrame.TabIndex = 24
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Waiting)
        Me.GroupBox2.Controls.Add(Me.Summary)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Firmware)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.SensorType)
        Me.GroupBox2.Controls.Add(Me.SensorInfo)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Counter)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Address)
        Me.GroupBox2.Controls.Add(Me.Battery)
        Me.GroupBox2.Controls.Add(Me.BatteryLevel)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.NODEID)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(852, 203)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sensor Info"
        '
        'Waiting
        '
        Me.Waiting.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Waiting.ForeColor = System.Drawing.Color.DarkRed
        Me.Waiting.Location = New System.Drawing.Point(6, 129)
        Me.Waiting.Name = "Waiting"
        Me.Waiting.Size = New System.Drawing.Size(837, 64)
        Me.Waiting.TabIndex = 49
        Me.Waiting.Text = "Waiting for the Next Transmission..."
        Me.Waiting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Summary
        '
        Me.Summary.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Summary.Location = New System.Drawing.Point(88, 86)
        Me.Summary.Multiline = True
        Me.Summary.Name = "Summary"
        Me.Summary.Size = New System.Drawing.Size(446, 99)
        Me.Summary.TabIndex = 40
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 86)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(76, 20)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Summary"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(562, 127)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(132, 20)
        Me.Label18.TabIndex = 38
        Me.Label18.Text = "Firmware Version"
        '
        'Firmware
        '
        Me.Firmware.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Firmware.Location = New System.Drawing.Point(700, 121)
        Me.Firmware.Name = "Firmware"
        Me.Firmware.Size = New System.Drawing.Size(143, 29)
        Me.Firmware.TabIndex = 37
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(42, 22)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 20)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Info"
        '
        'SensorType
        '
        Me.SensorType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SensorType.Location = New System.Drawing.Point(700, 86)
        Me.SensorType.Name = "SensorType"
        Me.SensorType.Size = New System.Drawing.Size(143, 29)
        Me.SensorType.TabIndex = 35
        '
        'SensorInfo
        '
        Me.SensorInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SensorInfo.Location = New System.Drawing.Point(87, 16)
        Me.SensorInfo.Name = "SensorInfo"
        Me.SensorInfo.Size = New System.Drawing.Size(303, 29)
        Me.SensorInfo.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(596, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(98, 20)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Sensor Type"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(489, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(205, 20)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Transmission Cycle Counter"
        '
        'Counter
        '
        Me.Counter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Counter.Location = New System.Drawing.Point(700, 51)
        Me.Counter.Name = "Counter"
        Me.Counter.Size = New System.Drawing.Size(143, 29)
        Me.Counter.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 20)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Address"
        '
        'Address
        '
        Me.Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(87, 51)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(302, 29)
        Me.Address.TabIndex = 29
        '
        'Battery
        '
        Me.Battery.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Battery.Location = New System.Drawing.Point(700, 16)
        Me.Battery.Name = "Battery"
        Me.Battery.Size = New System.Drawing.Size(143, 29)
        Me.Battery.TabIndex = 28
        '
        'BatteryLevel
        '
        Me.BatteryLevel.Location = New System.Drawing.Point(469, 19)
        Me.BatteryLevel.Maximum = 330
        Me.BatteryLevel.Name = "BatteryLevel"
        Me.BatteryLevel.Size = New System.Drawing.Size(225, 23)
        Me.BatteryLevel.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(403, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 20)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Battery"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(626, 162)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 20)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Node ID"
        '
        'NODEID
        '
        Me.NODEID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NODEID.Location = New System.Drawing.Point(700, 156)
        Me.NODEID.Name = "NODEID"
        Me.NODEID.Size = New System.Drawing.Size(143, 29)
        Me.NODEID.TabIndex = 24
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.Thermocouple_Celsius)
        Me.GroupBox5.Controls.Add(Me.Thermocouple_Fahrenheit)
        Me.GroupBox5.Controls.Add(Me.Label24)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 359)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(258, 127)
        Me.GroupBox5.TabIndex = 47
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Thermocouple Temperature"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(42, 27)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(100, 20)
        Me.Label23.TabIndex = 25
        Me.Label23.Text = "Temperature"
        '
        'Thermocouple_Celsius
        '
        Me.Thermocouple_Celsius.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thermocouple_Celsius.Location = New System.Drawing.Point(46, 50)
        Me.Thermocouple_Celsius.Name = "Thermocouple_Celsius"
        Me.Thermocouple_Celsius.Size = New System.Drawing.Size(200, 29)
        Me.Thermocouple_Celsius.TabIndex = 19
        '
        'Thermocouple_Fahrenheit
        '
        Me.Thermocouple_Fahrenheit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thermocouple_Fahrenheit.Location = New System.Drawing.Point(46, 85)
        Me.Thermocouple_Fahrenheit.Name = "Thermocouple_Fahrenheit"
        Me.Thermocouple_Fahrenheit.Size = New System.Drawing.Size(200, 29)
        Me.Thermocouple_Fahrenheit.TabIndex = 21
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(14, 56)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(25, 20)
        Me.Label24.TabIndex = 18
        Me.Label24.Text = "°C"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(14, 91)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(24, 20)
        Me.Label25.TabIndex = 20
        Me.Label25.Text = "°F"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label26)
        Me.GroupBox6.Controls.Add(Me.Amps)
        Me.GroupBox6.Controls.Add(Me.Milliamps)
        Me.GroupBox6.Controls.Add(Me.Label27)
        Me.GroupBox6.Controls.Add(Me.Label28)
        Me.GroupBox6.Location = New System.Drawing.Point(276, 361)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(308, 125)
        Me.GroupBox6.TabIndex = 48
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Current Measurement"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(87, 25)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 20)
        Me.Label26.TabIndex = 25
        Me.Label26.Text = "Current"
        '
        'Amps
        '
        Me.Amps.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amps.Location = New System.Drawing.Point(91, 48)
        Me.Amps.Name = "Amps"
        Me.Amps.Size = New System.Drawing.Size(200, 29)
        Me.Amps.TabIndex = 19
        '
        'Milliamps
        '
        Me.Milliamps.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Milliamps.Location = New System.Drawing.Point(91, 83)
        Me.Milliamps.Name = "Milliamps"
        Me.Milliamps.Size = New System.Drawing.Size(200, 29)
        Me.Milliamps.TabIndex = 21
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(35, 54)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(50, 20)
        Me.Label27.TabIndex = 18
        Me.Label27.Text = "Amps"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(15, 89)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(73, 20)
        Me.Label28.TabIndex = 20
        Me.Label28.Text = "Milliamps"
        '
        'Timer1
        '
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'frmType50_PredictiveMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 627)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmType50_PredictiveMaintenance"
        Me.Text = "frmType50_PredictiveMaintenance"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RMSX As TextBox
    Friend WithEvents RMSY As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RMSZ As TextBox
    Friend WithEvents MINZ As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MAXX As TextBox
    Friend WithEvents MINY As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents MAXY As TextBox
    Friend WithEvents MINX As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MAXZ As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents SensorPayload As TextBox
    Friend WithEvents CompletePayload As TextBox
    Friend WithEvents CompleteFrame As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Summary As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Firmware As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents SensorType As TextBox
    Friend WithEvents SensorInfo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Counter As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Address As TextBox
    Friend WithEvents Battery As TextBox
    Friend WithEvents BatteryLevel As ProgressBar
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents NODEID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Vibration_Celsius As TextBox
    Friend WithEvents Vibration_Fahrenheit As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Thermocouple_Celsius As TextBox
    Friend WithEvents Thermocouple_Fahrenheit As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Amps As TextBox
    Friend WithEvents Milliamps As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Waiting As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
