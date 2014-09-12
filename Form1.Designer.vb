<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SerialPortETM = New System.IO.Ports.SerialPort(Me.components)
        Me.LabelComMsg = New System.Windows.Forms.Label()
        Me.ComboBoxComPorts = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelMagnetSetPoint = New System.Windows.Forms.Label()
        Me.LabelMagnetIMON = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelHeaterSetPoint = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelHeaterVmon = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelLambdaVpeak = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LabelLambdaSetPointModeA = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelThyrHeaterVmon = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LabelThyrHtrSetPoint = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LabelThyrResrHeaterVmon = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LabelThyrResrHtrSetPoint = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LabelPulseVoltageModeA = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.LabelPulseCurrentModeA = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.LabelPulseCurrentMinModeA = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.LabelMagnetVmon = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.LabelHeaterImon = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.LabelPulseCurrentMaxModeA = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox49 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronStatusBit4 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronFaultBit4 = New System.Windows.Forms.CheckBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.CheckBox105 = New System.Windows.Forms.CheckBox()
        Me.CheckBox107 = New System.Windows.Forms.CheckBox()
        Me.CheckBox108 = New System.Windows.Forms.CheckBox()
        Me.CheckBox110 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronStatusBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronStatusBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronStatusBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronStatusBit0 = New System.Windows.Forms.CheckBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.CheckBoxMagnetronFaultBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronFaultBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronFaultBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronFaultBit0 = New System.Windows.Forms.CheckBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.LabelState = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.TextBoxSetLambdaModeA = New System.Windows.Forms.TextBox()
        Me.ButtonSetLambdaModeA = New System.Windows.Forms.Button()
        Me.ButtonSetMagnet = New System.Windows.Forms.Button()
        Me.TextBoxSetMagnet = New System.Windows.Forms.TextBox()
        Me.LabelEnergyPerPulse = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.LabelPRF = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.LabelMagnetronPower = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.LabelArcsTotal = New System.Windows.Forms.Label()
        Me.LabelPulsesTotal = New System.Windows.Forms.Label()
        Me.LabelArcsHVOn = New System.Windows.Forms.Label()
        Me.LabelPulsesHVon = New System.Windows.Forms.Label()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonUpdateAll = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonSetFilament = New System.Windows.Forms.Button()
        Me.TextBoxSetFilament = New System.Windows.Forms.TextBox()
        Me.ButtonSetLambdaModeB = New System.Windows.Forms.Button()
        Me.TextBoxSetLambdaModeB = New System.Windows.Forms.TextBox()
        Me.LabelLambdaSetPointModeB = New System.Windows.Forms.Label()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.LabelPulseVoltagetMaxModeA = New System.Windows.Forms.Label()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.LabelPulseVoltagetMinModeA = New System.Windows.Forms.Label()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.LabelPulseVoltagetMaxModeB = New System.Windows.Forms.Label()
        Me.Label114 = New System.Windows.Forms.Label()
        Me.LabelPulseVoltagetMinModeB = New System.Windows.Forms.Label()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.LabelPulseCurrentMaxModeB = New System.Windows.Forms.Label()
        Me.Label118 = New System.Windows.Forms.Label()
        Me.LabelPulseCurrentMinModeB = New System.Windows.Forms.Label()
        Me.Label120 = New System.Windows.Forms.Label()
        Me.LabelPulseCurrentModeB = New System.Windows.Forms.Label()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.LabelPulseVoltageModeB = New System.Windows.Forms.Label()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.LabelMagnetronCurrent = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.LabelMagnetronVoltage = New System.Windows.Forms.Label()
        Me.Label115 = New System.Windows.Forms.Label()
        Me.Label117 = New System.Windows.Forms.Label()
        Me.CheckBox18 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronStatusBit9 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronFaultBit9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox21 = New System.Windows.Forms.CheckBox()
        Me.CheckBox22 = New System.Windows.Forms.CheckBox()
        Me.CheckBox23 = New System.Windows.Forms.CheckBox()
        Me.CheckBox24 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronStatusBit8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronStatusBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronStatusBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronStatusBit5 = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.CheckBoxMagnetronFaultBit8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronFaultBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronFaultBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronFaultBit5 = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CheckBox39 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronStatusBit15 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronFaultBit15 = New System.Windows.Forms.CheckBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.CheckBox48 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronStatusBit14 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronFaultBit14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox53 = New System.Windows.Forms.CheckBox()
        Me.CheckBox54 = New System.Windows.Forms.CheckBox()
        Me.CheckBox55 = New System.Windows.Forms.CheckBox()
        Me.CheckBox56 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronStatusBit13 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronStatusBit11 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronStatusBit12 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronStatusBit10 = New System.Windows.Forms.CheckBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.CheckBoxMagnetronFaultBit13 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronFaultBit11 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronFaultBit12 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxMagnetronFaultBit10 = New System.Windows.Forms.CheckBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVStatusBit15 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVFaultBit15 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVStatusBit14 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVFaultBit14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox10 = New System.Windows.Forms.CheckBox()
        Me.CheckBox11 = New System.Windows.Forms.CheckBox()
        Me.CheckBox12 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVStatusBit13 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVStatusBit11 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVStatusBit12 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVStatusBit10 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CheckBoxHVFaultBit13 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVFaultBit11 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVFaultBit12 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVFaultBit10 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CheckBox31 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVStatusBit9 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVFaultBit9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox34 = New System.Windows.Forms.CheckBox()
        Me.CheckBox35 = New System.Windows.Forms.CheckBox()
        Me.CheckBox36 = New System.Windows.Forms.CheckBox()
        Me.CheckBox37 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVStatusBit8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVStatusBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVStatusBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVStatusBit5 = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.CheckBoxHVFaultBit8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVFaultBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVFaultBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVFaultBit5 = New System.Windows.Forms.CheckBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.CheckBox52 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVStatusBit4 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVFaultBit4 = New System.Windows.Forms.CheckBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.CheckBox63 = New System.Windows.Forms.CheckBox()
        Me.CheckBox64 = New System.Windows.Forms.CheckBox()
        Me.CheckBox65 = New System.Windows.Forms.CheckBox()
        Me.CheckBox66 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVStatusBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVStatusBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVStatusBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVStatusBit0 = New System.Windows.Forms.CheckBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.CheckBoxHVFaultBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVFaultBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVFaultBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxHVFaultBit0 = New System.Windows.Forms.CheckBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit15 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit15 = New System.Windows.Forms.CheckBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit14 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox29 = New System.Windows.Forms.CheckBox()
        Me.CheckBox30 = New System.Windows.Forms.CheckBox()
        Me.CheckBox33 = New System.Windows.Forms.CheckBox()
        Me.CheckBox44 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit13 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit11 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit12 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit10 = New System.Windows.Forms.CheckBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.CheckBoxThyratronFaultBit13 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit11 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit12 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit10 = New System.Windows.Forms.CheckBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.CheckBox75 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit9 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox78 = New System.Windows.Forms.CheckBox()
        Me.CheckBox79 = New System.Windows.Forms.CheckBox()
        Me.CheckBox80 = New System.Windows.Forms.CheckBox()
        Me.CheckBox81 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit5 = New System.Windows.Forms.CheckBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.CheckBoxThyratronFaultBit8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit5 = New System.Windows.Forms.CheckBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.CheckBox90 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit4 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit4 = New System.Windows.Forms.CheckBox()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.CheckBox93 = New System.Windows.Forms.CheckBox()
        Me.CheckBox94 = New System.Windows.Forms.CheckBox()
        Me.CheckBox95 = New System.Windows.Forms.CheckBox()
        Me.CheckBox96 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronStatusBit0 = New System.Windows.Forms.CheckBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.CheckBoxThyratronFaultBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxThyratronFaultBit0 = New System.Windows.Forms.CheckBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.CheckBox106 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardStatusBit15 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardFaultBit15 = New System.Windows.Forms.CheckBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.CheckBox112 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardStatusBit14 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardFaultBit14 = New System.Windows.Forms.CheckBox()
        Me.CheckBox118 = New System.Windows.Forms.CheckBox()
        Me.CheckBox120 = New System.Windows.Forms.CheckBox()
        Me.CheckBox121 = New System.Windows.Forms.CheckBox()
        Me.CheckBox122 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardStatusBit13 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardStatusBit11 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardStatusBit12 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardStatusBit10 = New System.Windows.Forms.CheckBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.CheckBoxControlBoardFaultBit13 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardFaultBit11 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardFaultBit12 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardFaultBit10 = New System.Windows.Forms.CheckBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.CheckBox131 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardStatusBit9 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardFaultBit9 = New System.Windows.Forms.CheckBox()
        Me.CheckBox134 = New System.Windows.Forms.CheckBox()
        Me.CheckBox135 = New System.Windows.Forms.CheckBox()
        Me.CheckBox136 = New System.Windows.Forms.CheckBox()
        Me.CheckBox137 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardStatusBit8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardStatusBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardStatusBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardStatusBit5 = New System.Windows.Forms.CheckBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.CheckBoxControlBoardFaultBit8 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardFaultBit6 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardFaultBit7 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardFaultBit5 = New System.Windows.Forms.CheckBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.CheckBox146 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardStatusBit4 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardFaultBit4 = New System.Windows.Forms.CheckBox()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.CheckBox149 = New System.Windows.Forms.CheckBox()
        Me.CheckBox150 = New System.Windows.Forms.CheckBox()
        Me.CheckBox151 = New System.Windows.Forms.CheckBox()
        Me.CheckBox152 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardStatusBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardStatusBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardStatusBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardStatusBit0 = New System.Windows.Forms.CheckBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.CheckBoxControlBoardFaultBit3 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardFaultBit1 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardFaultBit2 = New System.Windows.Forms.CheckBox()
        Me.CheckBoxControlBoardFaultBit0 = New System.Windows.Forms.CheckBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.LabelLambdaVmon = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.LabelADCFalseTrigger = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.LabelSPI1BusError = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.LabelI2CBusError = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.LabelMagnetronVoltageGlitch = New System.Windows.Forms.Label()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.LabelMagnetronCurrentGlitch = New System.Windows.Forms.Label()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.LabelReverseScale16BitSaturation = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.LabelScale16BitSaturation = New System.Windows.Forms.Label()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.LabelInvalidSetPoint = New System.Windows.Forms.Label()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.LabelLTC2656WriteError = New System.Windows.Forms.Label()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.LabelSPI2BusError = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.CheckBoxIOExpanderError = New System.Windows.Forms.CheckBox()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.CheckBoxIOPUWR = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTRAPR = New System.Windows.Forms.CheckBox()
        Me.CheckBoxWDT = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBOR = New System.Windows.Forms.CheckBox()
        Me.Label132 = New System.Windows.Forms.Label()
        Me.Label133 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.CheckBoxSWReset = New System.Windows.Forms.CheckBox()
        Me.CheckBoxPOR = New System.Windows.Forms.CheckBox()
        Me.CheckBoxExtReset = New System.Windows.Forms.CheckBox()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.ButtonReadState = New System.Windows.Forms.Button()
        Me.ButtonSetBaudRate = New System.Windows.Forms.Button()
        Me.TextBoxBaudRate = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalibrationDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MagnetSupplyCalibrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ETMOverrideModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalRemoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoteMagnetCurrentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LocalMagnetCurrentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilamentCurrentControlModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelGUIVersion = New System.Windows.Forms.Label()
        Me.LabelMCUVersion = New System.Windows.Forms.Label()
        Me.LabelMagnetControlStatus = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ButtonSkipWarmup = New System.Windows.Forms.Button()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.LabelInt1TimingError = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.LabeluPCrashCount = New System.Windows.Forms.Label()
        Me.Label121 = New System.Windows.Forms.Label()
        Me.LabelActionBeforeCrash = New System.Windows.Forms.Label()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.LabelLVDIntCount = New System.Windows.Forms.Label()
        Me.Label134 = New System.Windows.Forms.Label()
        Me.LabelOscConBeforeCrash = New System.Windows.Forms.Label()
        Me.Label136 = New System.Windows.Forms.Label()
        Me.LabelMagnetronType = New System.Windows.Forms.Label()
        Me.LabelControlBoardType = New System.Windows.Forms.Label()
        Me.ButtonSetModeBTargetI = New System.Windows.Forms.Button()
        Me.TextBoxModeBTargetI = New System.Windows.Forms.TextBox()
        Me.ButtonSetModeATargetI = New System.Windows.Forms.Button()
        Me.TextBoxModeATargetI = New System.Windows.Forms.TextBox()
        Me.LabelModeBTargetISetPoint = New System.Windows.Forms.Label()
        Me.Label113 = New System.Windows.Forms.Label()
        Me.LabelModeATargetISetPoint = New System.Windows.Forms.Label()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.LabelModeBTargetIMonitor = New System.Windows.Forms.Label()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.LabelModeATargetIMonitor = New System.Windows.Forms.Label()
        Me.Label137 = New System.Windows.Forms.Label()
        Me.ButtonStartDataLogging = New System.Windows.Forms.Button()
        Me.ButtonStopDataLogging = New System.Windows.Forms.Button()
        Me.ButtonSetFilamentCurrent = New System.Windows.Forms.Button()
        Me.LabelHeaterISetPoint = New System.Windows.Forms.Label()
        Me.Label135 = New System.Windows.Forms.Label()
        Me.LabelPulseLatchError = New System.Windows.Forms.Label()
        Me.Label138 = New System.Windows.Forms.Label()
        Me.ButtonLowEnergyAdjustNumPulses = New System.Windows.Forms.Button()
        Me.TextBoxLowEnergyAdjustPulses = New System.Windows.Forms.TextBox()
        Me.ButtonLowEnergyAdjustMag = New System.Windows.Forms.Button()
        Me.TextBoxLowEnergyAdjustMag = New System.Windows.Forms.TextBox()
        Me.ButtonLowEnergyAdjDir = New System.Windows.Forms.Button()
        Me.TextBoxLowEnergyAdjDir = New System.Windows.Forms.TextBox()
        Me.LabelTargetAdjustInitial = New System.Windows.Forms.Label()
        Me.Label141 = New System.Windows.Forms.Label()
        Me.LabelTargetAdjustMaxTime = New System.Windows.Forms.Label()
        Me.Label143 = New System.Windows.Forms.Label()
        Me.LabelTargetAdjustMaxMag = New System.Windows.Forms.Label()
        Me.Label145 = New System.Windows.Forms.Label()
        Me.LabelTargetAdjustPulse = New System.Windows.Forms.Label()
        Me.Label147 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPortETM
        '
        Me.SerialPortETM.BaudRate = 125000
        Me.SerialPortETM.ReadBufferSize = 8192
        Me.SerialPortETM.ReadTimeout = 100
        Me.SerialPortETM.WriteBufferSize = 8192
        '
        'LabelComMsg
        '
        Me.LabelComMsg.AutoSize = True
        Me.LabelComMsg.Location = New System.Drawing.Point(303, 649)
        Me.LabelComMsg.Name = "LabelComMsg"
        Me.LabelComMsg.Size = New System.Drawing.Size(98, 13)
        Me.LabelComMsg.TabIndex = 1
        Me.LabelComMsg.Text = "Selected COM Port"
        '
        'ComboBoxComPorts
        '
        Me.ComboBoxComPorts.FormattingEnabled = True
        Me.ComboBoxComPorts.Location = New System.Drawing.Point(302, 665)
        Me.ComboBoxComPorts.Name = "ComboBoxComPorts"
        Me.ComboBoxComPorts.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxComPorts.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Magnet Set Point"
        '
        'LabelMagnetSetPoint
        '
        Me.LabelMagnetSetPoint.AutoSize = True
        Me.LabelMagnetSetPoint.Location = New System.Drawing.Point(141, 80)
        Me.LabelMagnetSetPoint.Name = "LabelMagnetSetPoint"
        Me.LabelMagnetSetPoint.Size = New System.Drawing.Size(10, 13)
        Me.LabelMagnetSetPoint.TabIndex = 8
        Me.LabelMagnetSetPoint.Text = "-"
        '
        'LabelMagnetIMON
        '
        Me.LabelMagnetIMON.AutoSize = True
        Me.LabelMagnetIMON.Location = New System.Drawing.Point(141, 93)
        Me.LabelMagnetIMON.Name = "LabelMagnetIMON"
        Me.LabelMagnetIMON.Size = New System.Drawing.Size(10, 13)
        Me.LabelMagnetIMON.TabIndex = 10
        Me.LabelMagnetIMON.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Magnet IMON"
        '
        'LabelHeaterSetPoint
        '
        Me.LabelHeaterSetPoint.AutoSize = True
        Me.LabelHeaterSetPoint.Location = New System.Drawing.Point(365, 82)
        Me.LabelHeaterSetPoint.Name = "LabelHeaterSetPoint"
        Me.LabelHeaterSetPoint.Size = New System.Drawing.Size(10, 13)
        Me.LabelHeaterSetPoint.TabIndex = 12
        Me.LabelHeaterSetPoint.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(228, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Heater V Set Point"
        '
        'LabelHeaterVmon
        '
        Me.LabelHeaterVmon.AutoSize = True
        Me.LabelHeaterVmon.Location = New System.Drawing.Point(365, 95)
        Me.LabelHeaterVmon.Name = "LabelHeaterVmon"
        Me.LabelHeaterVmon.Size = New System.Drawing.Size(10, 13)
        Me.LabelHeaterVmon.TabIndex = 14
        Me.LabelHeaterVmon.Text = "-"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(228, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Heater VMON"
        '
        'LabelLambdaVpeak
        '
        Me.LabelLambdaVpeak.AutoSize = True
        Me.LabelLambdaVpeak.Location = New System.Drawing.Point(363, 335)
        Me.LabelLambdaVpeak.Name = "LabelLambdaVpeak"
        Me.LabelLambdaVpeak.Size = New System.Drawing.Size(10, 13)
        Me.LabelLambdaVpeak.TabIndex = 18
        Me.LabelLambdaVpeak.Text = "-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(228, 335)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Lambda Vpeak Reading"
        '
        'LabelLambdaSetPointModeA
        '
        Me.LabelLambdaSetPointModeA.AutoSize = True
        Me.LabelLambdaSetPointModeA.Location = New System.Drawing.Point(142, 137)
        Me.LabelLambdaSetPointModeA.Name = "LabelLambdaSetPointModeA"
        Me.LabelLambdaSetPointModeA.Size = New System.Drawing.Size(10, 13)
        Me.LabelLambdaSetPointModeA.TabIndex = 16
        Me.LabelLambdaSetPointModeA.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Mode A Set Point"
        '
        'LabelThyrHeaterVmon
        '
        Me.LabelThyrHeaterVmon.AutoSize = True
        Me.LabelThyrHeaterVmon.Location = New System.Drawing.Point(635, 409)
        Me.LabelThyrHeaterVmon.Name = "LabelThyrHeaterVmon"
        Me.LabelThyrHeaterVmon.Size = New System.Drawing.Size(10, 13)
        Me.LabelThyrHeaterVmon.TabIndex = 22
        Me.LabelThyrHeaterVmon.Text = "-"
        Me.LabelThyrHeaterVmon.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(499, 409)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Thyr Htr Reading"
        Me.Label14.Visible = False
        '
        'LabelThyrHtrSetPoint
        '
        Me.LabelThyrHtrSetPoint.AutoSize = True
        Me.LabelThyrHtrSetPoint.Location = New System.Drawing.Point(635, 396)
        Me.LabelThyrHtrSetPoint.Name = "LabelThyrHtrSetPoint"
        Me.LabelThyrHtrSetPoint.Size = New System.Drawing.Size(10, 13)
        Me.LabelThyrHtrSetPoint.TabIndex = 20
        Me.LabelThyrHtrSetPoint.Text = "-"
        Me.LabelThyrHtrSetPoint.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(499, 396)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Thyr Cath Htr Set"
        Me.Label16.Visible = False
        '
        'LabelThyrResrHeaterVmon
        '
        Me.LabelThyrResrHeaterVmon.AutoSize = True
        Me.LabelThyrResrHeaterVmon.Location = New System.Drawing.Point(635, 459)
        Me.LabelThyrResrHeaterVmon.Name = "LabelThyrResrHeaterVmon"
        Me.LabelThyrResrHeaterVmon.Size = New System.Drawing.Size(10, 13)
        Me.LabelThyrResrHeaterVmon.TabIndex = 26
        Me.LabelThyrResrHeaterVmon.Text = "-"
        Me.LabelThyrResrHeaterVmon.Visible = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(499, 459)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(113, 13)
        Me.Label18.TabIndex = 25
        Me.Label18.Text = "Thyr Resr Htr Reading"
        Me.Label18.Visible = False
        '
        'LabelThyrResrHtrSetPoint
        '
        Me.LabelThyrResrHtrSetPoint.AutoSize = True
        Me.LabelThyrResrHtrSetPoint.Location = New System.Drawing.Point(635, 446)
        Me.LabelThyrResrHtrSetPoint.Name = "LabelThyrResrHtrSetPoint"
        Me.LabelThyrResrHtrSetPoint.Size = New System.Drawing.Size(10, 13)
        Me.LabelThyrResrHtrSetPoint.TabIndex = 24
        Me.LabelThyrResrHtrSetPoint.Text = "-"
        Me.LabelThyrResrHtrSetPoint.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(499, 446)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 13)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Thyr Resr Htr Set"
        Me.Label20.Visible = False
        '
        'LabelPulseVoltageModeA
        '
        Me.LabelPulseVoltageModeA.AutoSize = True
        Me.LabelPulseVoltageModeA.Location = New System.Drawing.Point(142, 163)
        Me.LabelPulseVoltageModeA.Name = "LabelPulseVoltageModeA"
        Me.LabelPulseVoltageModeA.Size = New System.Drawing.Size(10, 13)
        Me.LabelPulseVoltageModeA.TabIndex = 28
        Me.LabelPulseVoltageModeA.Text = "-"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(5, 161)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 13)
        Me.Label22.TabIndex = 27
        Me.Label22.Text = "Pulse Voltage"
        '
        'LabelPulseCurrentModeA
        '
        Me.LabelPulseCurrentModeA.AutoSize = True
        Me.LabelPulseCurrentModeA.Location = New System.Drawing.Point(142, 176)
        Me.LabelPulseCurrentModeA.Name = "LabelPulseCurrentModeA"
        Me.LabelPulseCurrentModeA.Size = New System.Drawing.Size(10, 13)
        Me.LabelPulseCurrentModeA.TabIndex = 30
        Me.LabelPulseCurrentModeA.Text = "-"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(5, 174)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(70, 13)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "Pulse Current"
        '
        'LabelPulseCurrentMinModeA
        '
        Me.LabelPulseCurrentMinModeA.AutoSize = True
        Me.LabelPulseCurrentMinModeA.Location = New System.Drawing.Point(142, 189)
        Me.LabelPulseCurrentMinModeA.Name = "LabelPulseCurrentMinModeA"
        Me.LabelPulseCurrentMinModeA.Size = New System.Drawing.Size(10, 13)
        Me.LabelPulseCurrentMinModeA.TabIndex = 32
        Me.LabelPulseCurrentMinModeA.Text = "-"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(5, 187)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(90, 13)
        Me.Label26.TabIndex = 31
        Me.Label26.Text = "Pulse Current Min"
        '
        'LabelMagnetVmon
        '
        Me.LabelMagnetVmon.AutoSize = True
        Me.LabelMagnetVmon.Location = New System.Drawing.Point(141, 106)
        Me.LabelMagnetVmon.Name = "LabelMagnetVmon"
        Me.LabelMagnetVmon.Size = New System.Drawing.Size(10, 13)
        Me.LabelMagnetVmon.TabIndex = 34
        Me.LabelMagnetVmon.Text = "-"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(5, 106)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(78, 13)
        Me.Label28.TabIndex = 33
        Me.Label28.Text = "Magnet VMON"
        '
        'LabelHeaterImon
        '
        Me.LabelHeaterImon.AutoSize = True
        Me.LabelHeaterImon.Location = New System.Drawing.Point(365, 108)
        Me.LabelHeaterImon.Name = "LabelHeaterImon"
        Me.LabelHeaterImon.Size = New System.Drawing.Size(10, 13)
        Me.LabelHeaterImon.TabIndex = 36
        Me.LabelHeaterImon.Text = "-"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(228, 106)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(70, 13)
        Me.Label30.TabIndex = 35
        Me.Label30.Text = "Heater IMON"
        '
        'LabelPulseCurrentMaxModeA
        '
        Me.LabelPulseCurrentMaxModeA.AutoSize = True
        Me.LabelPulseCurrentMaxModeA.Location = New System.Drawing.Point(142, 202)
        Me.LabelPulseCurrentMaxModeA.Name = "LabelPulseCurrentMaxModeA"
        Me.LabelPulseCurrentMaxModeA.Size = New System.Drawing.Size(10, 13)
        Me.LabelPulseCurrentMaxModeA.TabIndex = 38
        Me.LabelPulseCurrentMaxModeA.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Pulse Current Max"
        '
        'CheckBox49
        '
        Me.CheckBox49.AutoCheck = False
        Me.CheckBox49.AutoSize = True
        Me.CheckBox49.Location = New System.Drawing.Point(851, 373)
        Me.CheckBox49.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox49.Name = "CheckBox49"
        Me.CheckBox49.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox49.TabIndex = 344
        Me.CheckBox49.UseVisualStyleBackColor = True
        Me.CheckBox49.Visible = False
        '
        'CheckBoxMagnetronStatusBit4
        '
        Me.CheckBoxMagnetronStatusBit4.AutoCheck = False
        Me.CheckBoxMagnetronStatusBit4.AutoSize = True
        Me.CheckBoxMagnetronStatusBit4.Location = New System.Drawing.Point(830, 373)
        Me.CheckBoxMagnetronStatusBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronStatusBit4.Name = "CheckBoxMagnetronStatusBit4"
        Me.CheckBoxMagnetronStatusBit4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronStatusBit4.TabIndex = 343
        Me.CheckBoxMagnetronStatusBit4.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronFaultBit4
        '
        Me.CheckBoxMagnetronFaultBit4.AutoCheck = False
        Me.CheckBoxMagnetronFaultBit4.AutoSize = True
        Me.CheckBoxMagnetronFaultBit4.Location = New System.Drawing.Point(809, 373)
        Me.CheckBoxMagnetronFaultBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronFaultBit4.Name = "CheckBoxMagnetronFaultBit4"
        Me.CheckBoxMagnetronFaultBit4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronFaultBit4.TabIndex = 341
        Me.CheckBoxMagnetronFaultBit4.UseVisualStyleBackColor = True
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(684, 290)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(137, 13)
        Me.Label60.TabIndex = 340
        Me.Label60.Text = "MAGNETRON FAULTS"
        '
        'CheckBox105
        '
        Me.CheckBox105.AutoCheck = False
        Me.CheckBox105.AutoSize = True
        Me.CheckBox105.Location = New System.Drawing.Point(851, 359)
        Me.CheckBox105.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox105.Name = "CheckBox105"
        Me.CheckBox105.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox105.TabIndex = 336
        Me.CheckBox105.UseVisualStyleBackColor = True
        Me.CheckBox105.Visible = False
        '
        'CheckBox107
        '
        Me.CheckBox107.AutoCheck = False
        Me.CheckBox107.AutoSize = True
        Me.CheckBox107.Location = New System.Drawing.Point(851, 331)
        Me.CheckBox107.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox107.Name = "CheckBox107"
        Me.CheckBox107.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox107.TabIndex = 334
        Me.CheckBox107.UseVisualStyleBackColor = True
        Me.CheckBox107.Visible = False
        '
        'CheckBox108
        '
        Me.CheckBox108.AutoCheck = False
        Me.CheckBox108.AutoSize = True
        Me.CheckBox108.Location = New System.Drawing.Point(851, 345)
        Me.CheckBox108.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox108.Name = "CheckBox108"
        Me.CheckBox108.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox108.TabIndex = 333
        Me.CheckBox108.UseVisualStyleBackColor = True
        Me.CheckBox108.Visible = False
        '
        'CheckBox110
        '
        Me.CheckBox110.AutoCheck = False
        Me.CheckBox110.AutoSize = True
        Me.CheckBox110.Location = New System.Drawing.Point(851, 317)
        Me.CheckBox110.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox110.Name = "CheckBox110"
        Me.CheckBox110.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox110.TabIndex = 331
        Me.CheckBox110.UseVisualStyleBackColor = True
        Me.CheckBox110.Visible = False
        '
        'CheckBoxMagnetronStatusBit3
        '
        Me.CheckBoxMagnetronStatusBit3.AutoCheck = False
        Me.CheckBoxMagnetronStatusBit3.AutoSize = True
        Me.CheckBoxMagnetronStatusBit3.Location = New System.Drawing.Point(830, 359)
        Me.CheckBoxMagnetronStatusBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronStatusBit3.Name = "CheckBoxMagnetronStatusBit3"
        Me.CheckBoxMagnetronStatusBit3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronStatusBit3.TabIndex = 327
        Me.CheckBoxMagnetronStatusBit3.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronStatusBit1
        '
        Me.CheckBoxMagnetronStatusBit1.AutoCheck = False
        Me.CheckBoxMagnetronStatusBit1.AutoSize = True
        Me.CheckBoxMagnetronStatusBit1.Location = New System.Drawing.Point(830, 331)
        Me.CheckBoxMagnetronStatusBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronStatusBit1.Name = "CheckBoxMagnetronStatusBit1"
        Me.CheckBoxMagnetronStatusBit1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronStatusBit1.TabIndex = 325
        Me.CheckBoxMagnetronStatusBit1.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronStatusBit2
        '
        Me.CheckBoxMagnetronStatusBit2.AutoCheck = False
        Me.CheckBoxMagnetronStatusBit2.AutoSize = True
        Me.CheckBoxMagnetronStatusBit2.Location = New System.Drawing.Point(830, 345)
        Me.CheckBoxMagnetronStatusBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronStatusBit2.Name = "CheckBoxMagnetronStatusBit2"
        Me.CheckBoxMagnetronStatusBit2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronStatusBit2.TabIndex = 324
        Me.CheckBoxMagnetronStatusBit2.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronStatusBit0
        '
        Me.CheckBoxMagnetronStatusBit0.AutoCheck = False
        Me.CheckBoxMagnetronStatusBit0.AutoSize = True
        Me.CheckBoxMagnetronStatusBit0.Location = New System.Drawing.Point(830, 317)
        Me.CheckBoxMagnetronStatusBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronStatusBit0.Name = "CheckBoxMagnetronStatusBit0"
        Me.CheckBoxMagnetronStatusBit0.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronStatusBit0.TabIndex = 322
        Me.CheckBoxMagnetronStatusBit0.UseVisualStyleBackColor = True
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(684, 345)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(111, 13)
        Me.Label61.TabIndex = 321
        Me.Label61.Text = "Filament Over Voltage"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(684, 331)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(114, 13)
        Me.Label65.TabIndex = 317
        Me.Label65.Text = "Filament OV Hard Limit"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(684, 373)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(109, 13)
        Me.Label66.TabIndex = 316
        Me.Label66.Text = "Filament Over Current"
        '
        'CheckBoxMagnetronFaultBit3
        '
        Me.CheckBoxMagnetronFaultBit3.AutoCheck = False
        Me.CheckBoxMagnetronFaultBit3.AutoSize = True
        Me.CheckBoxMagnetronFaultBit3.Location = New System.Drawing.Point(809, 359)
        Me.CheckBoxMagnetronFaultBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronFaultBit3.Name = "CheckBoxMagnetronFaultBit3"
        Me.CheckBoxMagnetronFaultBit3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronFaultBit3.TabIndex = 312
        Me.CheckBoxMagnetronFaultBit3.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronFaultBit1
        '
        Me.CheckBoxMagnetronFaultBit1.AutoCheck = False
        Me.CheckBoxMagnetronFaultBit1.AutoSize = True
        Me.CheckBoxMagnetronFaultBit1.Location = New System.Drawing.Point(809, 331)
        Me.CheckBoxMagnetronFaultBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronFaultBit1.Name = "CheckBoxMagnetronFaultBit1"
        Me.CheckBoxMagnetronFaultBit1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronFaultBit1.TabIndex = 310
        Me.CheckBoxMagnetronFaultBit1.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronFaultBit2
        '
        Me.CheckBoxMagnetronFaultBit2.AutoCheck = False
        Me.CheckBoxMagnetronFaultBit2.AutoSize = True
        Me.CheckBoxMagnetronFaultBit2.Location = New System.Drawing.Point(809, 345)
        Me.CheckBoxMagnetronFaultBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronFaultBit2.Name = "CheckBoxMagnetronFaultBit2"
        Me.CheckBoxMagnetronFaultBit2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronFaultBit2.TabIndex = 309
        Me.CheckBoxMagnetronFaultBit2.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronFaultBit0
        '
        Me.CheckBoxMagnetronFaultBit0.AutoCheck = False
        Me.CheckBoxMagnetronFaultBit0.AutoSize = True
        Me.CheckBoxMagnetronFaultBit0.Location = New System.Drawing.Point(809, 317)
        Me.CheckBoxMagnetronFaultBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronFaultBit0.Name = "CheckBoxMagnetronFaultBit0"
        Me.CheckBoxMagnetronFaultBit0.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronFaultBit0.TabIndex = 307
        Me.CheckBoxMagnetronFaultBit0.UseVisualStyleBackColor = True
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(684, 359)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(117, 13)
        Me.Label67.TabIndex = 306
        Me.Label67.Text = "Filament Under Voltage"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(684, 317)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(92, 13)
        Me.Label68.TabIndex = 305
        Me.Label68.Text = "HW Filamanet OV"
        '
        'LabelState
        '
        Me.LabelState.AutoSize = True
        Me.LabelState.Location = New System.Drawing.Point(218, 32)
        Me.LabelState.Name = "LabelState"
        Me.LabelState.Size = New System.Drawing.Size(10, 13)
        Me.LabelState.TabIndex = 438
        Me.LabelState.Text = "-"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(167, 32)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(37, 13)
        Me.Label93.TabIndex = 437
        Me.Label93.Text = "State"
        '
        'TextBoxSetLambdaModeA
        '
        Me.TextBoxSetLambdaModeA.Location = New System.Drawing.Point(14, 445)
        Me.TextBoxSetLambdaModeA.Name = "TextBoxSetLambdaModeA"
        Me.TextBoxSetLambdaModeA.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxSetLambdaModeA.TabIndex = 439
        '
        'ButtonSetLambdaModeA
        '
        Me.ButtonSetLambdaModeA.Location = New System.Drawing.Point(91, 442)
        Me.ButtonSetLambdaModeA.Name = "ButtonSetLambdaModeA"
        Me.ButtonSetLambdaModeA.Size = New System.Drawing.Size(114, 23)
        Me.ButtonSetLambdaModeA.TabIndex = 440
        Me.ButtonSetLambdaModeA.Text = "Set Lambda Mode A"
        Me.ButtonSetLambdaModeA.UseVisualStyleBackColor = True
        '
        'ButtonSetMagnet
        '
        Me.ButtonSetMagnet.Location = New System.Drawing.Point(91, 557)
        Me.ButtonSetMagnet.Name = "ButtonSetMagnet"
        Me.ButtonSetMagnet.Size = New System.Drawing.Size(114, 23)
        Me.ButtonSetMagnet.TabIndex = 442
        Me.ButtonSetMagnet.Text = "Set Magnet Current"
        Me.ButtonSetMagnet.UseVisualStyleBackColor = True
        '
        'TextBoxSetMagnet
        '
        Me.TextBoxSetMagnet.Location = New System.Drawing.Point(14, 560)
        Me.TextBoxSetMagnet.Name = "TextBoxSetMagnet"
        Me.TextBoxSetMagnet.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxSetMagnet.TabIndex = 441
        '
        'LabelEnergyPerPulse
        '
        Me.LabelEnergyPerPulse.AutoSize = True
        Me.LabelEnergyPerPulse.Location = New System.Drawing.Point(363, 309)
        Me.LabelEnergyPerPulse.Name = "LabelEnergyPerPulse"
        Me.LabelEnergyPerPulse.Size = New System.Drawing.Size(10, 13)
        Me.LabelEnergyPerPulse.TabIndex = 447
        Me.LabelEnergyPerPulse.Text = "-"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Location = New System.Drawing.Point(228, 309)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(88, 13)
        Me.Label94.TabIndex = 446
        Me.Label94.Text = "Energy Per Pulse"
        '
        'LabelPRF
        '
        Me.LabelPRF.AutoSize = True
        Me.LabelPRF.Location = New System.Drawing.Point(363, 322)
        Me.LabelPRF.Name = "LabelPRF"
        Me.LabelPRF.Size = New System.Drawing.Size(10, 13)
        Me.LabelPRF.TabIndex = 449
        Me.LabelPRF.Text = "-"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Location = New System.Drawing.Point(228, 322)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(28, 13)
        Me.Label96.TabIndex = 448
        Me.Label96.Text = "PRF"
        '
        'LabelMagnetronPower
        '
        Me.LabelMagnetronPower.AutoSize = True
        Me.LabelMagnetronPower.Location = New System.Drawing.Point(363, 297)
        Me.LabelMagnetronPower.Name = "LabelMagnetronPower"
        Me.LabelMagnetronPower.Size = New System.Drawing.Size(10, 13)
        Me.LabelMagnetronPower.TabIndex = 451
        Me.LabelMagnetronPower.Text = "-"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Location = New System.Drawing.Point(228, 297)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(118, 13)
        Me.Label98.TabIndex = 450
        Me.Label98.Text = "Magnetron Input Power"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Location = New System.Drawing.Point(4, 297)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(81, 13)
        Me.Label102.TabIndex = 481
        Me.Label102.Text = "HV ON - Pulses"
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Location = New System.Drawing.Point(4, 309)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(71, 13)
        Me.Label104.TabIndex = 482
        Me.Label104.Text = "HV ON - Arcs"
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Location = New System.Drawing.Point(3, 335)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(61, 13)
        Me.Label105.TabIndex = 484
        Me.Label105.Text = "Total - Arcs"
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Location = New System.Drawing.Point(3, 322)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(71, 13)
        Me.Label106.TabIndex = 483
        Me.Label106.Text = "Total - Pulses"
        '
        'LabelArcsTotal
        '
        Me.LabelArcsTotal.AutoSize = True
        Me.LabelArcsTotal.Location = New System.Drawing.Point(141, 335)
        Me.LabelArcsTotal.Name = "LabelArcsTotal"
        Me.LabelArcsTotal.Size = New System.Drawing.Size(10, 13)
        Me.LabelArcsTotal.TabIndex = 488
        Me.LabelArcsTotal.Text = "-"
        '
        'LabelPulsesTotal
        '
        Me.LabelPulsesTotal.AutoSize = True
        Me.LabelPulsesTotal.Location = New System.Drawing.Point(141, 322)
        Me.LabelPulsesTotal.Name = "LabelPulsesTotal"
        Me.LabelPulsesTotal.Size = New System.Drawing.Size(10, 13)
        Me.LabelPulsesTotal.TabIndex = 487
        Me.LabelPulsesTotal.Text = "-"
        '
        'LabelArcsHVOn
        '
        Me.LabelArcsHVOn.AutoSize = True
        Me.LabelArcsHVOn.Location = New System.Drawing.Point(141, 309)
        Me.LabelArcsHVOn.Name = "LabelArcsHVOn"
        Me.LabelArcsHVOn.Size = New System.Drawing.Size(10, 13)
        Me.LabelArcsHVOn.TabIndex = 486
        Me.LabelArcsHVOn.Text = "-"
        '
        'LabelPulsesHVon
        '
        Me.LabelPulsesHVon.AutoSize = True
        Me.LabelPulsesHVon.Location = New System.Drawing.Point(141, 297)
        Me.LabelPulsesHVon.Name = "LabelPulsesHVon"
        Me.LabelPulsesHVon.Size = New System.Drawing.Size(10, 13)
        Me.LabelPulsesHVon.TabIndex = 485
        Me.LabelPulsesHVon.Text = "-"
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.Location = New System.Drawing.Point(4, 361)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(10, 13)
        Me.LabelTime.TabIndex = 492
        Me.LabelTime.Text = "-"
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.Location = New System.Drawing.Point(228, 281)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(106, 13)
        Me.Label103.TabIndex = 493
        Me.Label103.Text = "Magnetron Power"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'ButtonUpdateAll
        '
        Me.ButtonUpdateAll.Location = New System.Drawing.Point(8, 54)
        Me.ButtonUpdateAll.Name = "ButtonUpdateAll"
        Me.ButtonUpdateAll.Size = New System.Drawing.Size(91, 23)
        Me.ButtonUpdateAll.TabIndex = 494
        Me.ButtonUpdateAll.Text = "Update All"
        Me.ButtonUpdateAll.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 60000
        '
        'ButtonSetFilament
        '
        Me.ButtonSetFilament.Location = New System.Drawing.Point(306, 558)
        Me.ButtonSetFilament.Name = "ButtonSetFilament"
        Me.ButtonSetFilament.Size = New System.Drawing.Size(114, 23)
        Me.ButtonSetFilament.TabIndex = 496
        Me.ButtonSetFilament.Text = "Set Filament Voltage"
        Me.ButtonSetFilament.UseVisualStyleBackColor = True
        '
        'TextBoxSetFilament
        '
        Me.TextBoxSetFilament.Location = New System.Drawing.Point(229, 560)
        Me.TextBoxSetFilament.Name = "TextBoxSetFilament"
        Me.TextBoxSetFilament.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxSetFilament.TabIndex = 495
        '
        'ButtonSetLambdaModeB
        '
        Me.ButtonSetLambdaModeB.Location = New System.Drawing.Point(306, 442)
        Me.ButtonSetLambdaModeB.Name = "ButtonSetLambdaModeB"
        Me.ButtonSetLambdaModeB.Size = New System.Drawing.Size(114, 23)
        Me.ButtonSetLambdaModeB.TabIndex = 498
        Me.ButtonSetLambdaModeB.Text = "Set Lambda Mode B"
        Me.ButtonSetLambdaModeB.UseVisualStyleBackColor = True
        '
        'TextBoxSetLambdaModeB
        '
        Me.TextBoxSetLambdaModeB.Location = New System.Drawing.Point(229, 445)
        Me.TextBoxSetLambdaModeB.Name = "TextBoxSetLambdaModeB"
        Me.TextBoxSetLambdaModeB.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxSetLambdaModeB.TabIndex = 497
        '
        'LabelLambdaSetPointModeB
        '
        Me.LabelLambdaSetPointModeB.AutoSize = True
        Me.LabelLambdaSetPointModeB.Location = New System.Drawing.Point(364, 133)
        Me.LabelLambdaSetPointModeB.Name = "LabelLambdaSetPointModeB"
        Me.LabelLambdaSetPointModeB.Size = New System.Drawing.Size(10, 13)
        Me.LabelLambdaSetPointModeB.TabIndex = 500
        Me.LabelLambdaSetPointModeB.Text = "-"
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.Location = New System.Drawing.Point(229, 135)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(106, 13)
        Me.Label111.TabIndex = 499
        Me.Label111.Text = "Mode B Set Point"
        '
        'LabelPulseVoltagetMaxModeA
        '
        Me.LabelPulseVoltagetMaxModeA.AutoSize = True
        Me.LabelPulseVoltagetMaxModeA.Location = New System.Drawing.Point(142, 228)
        Me.LabelPulseVoltagetMaxModeA.Name = "LabelPulseVoltagetMaxModeA"
        Me.LabelPulseVoltagetMaxModeA.Size = New System.Drawing.Size(10, 13)
        Me.LabelPulseVoltagetMaxModeA.TabIndex = 504
        Me.LabelPulseVoltagetMaxModeA.Text = "-"
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.Location = New System.Drawing.Point(5, 226)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(95, 13)
        Me.Label109.TabIndex = 503
        Me.Label109.Text = "Pulse Voltage Max"
        '
        'LabelPulseVoltagetMinModeA
        '
        Me.LabelPulseVoltagetMinModeA.AutoSize = True
        Me.LabelPulseVoltagetMinModeA.Location = New System.Drawing.Point(142, 215)
        Me.LabelPulseVoltagetMinModeA.Name = "LabelPulseVoltagetMinModeA"
        Me.LabelPulseVoltagetMinModeA.Size = New System.Drawing.Size(10, 13)
        Me.LabelPulseVoltagetMinModeA.TabIndex = 502
        Me.LabelPulseVoltagetMinModeA.Text = "-"
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Location = New System.Drawing.Point(5, 213)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(92, 13)
        Me.Label112.TabIndex = 501
        Me.Label112.Text = "Pulse Voltage Min"
        '
        'LabelPulseVoltagetMaxModeB
        '
        Me.LabelPulseVoltagetMaxModeB.AutoSize = True
        Me.LabelPulseVoltagetMaxModeB.Location = New System.Drawing.Point(364, 226)
        Me.LabelPulseVoltagetMaxModeB.Name = "LabelPulseVoltagetMaxModeB"
        Me.LabelPulseVoltagetMaxModeB.Size = New System.Drawing.Size(10, 13)
        Me.LabelPulseVoltagetMaxModeB.TabIndex = 516
        Me.LabelPulseVoltagetMaxModeB.Text = "-"
        '
        'Label114
        '
        Me.Label114.AutoSize = True
        Me.Label114.Location = New System.Drawing.Point(229, 226)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(95, 13)
        Me.Label114.TabIndex = 515
        Me.Label114.Text = "Pulse Voltage Max"
        '
        'LabelPulseVoltagetMinModeB
        '
        Me.LabelPulseVoltagetMinModeB.AutoSize = True
        Me.LabelPulseVoltagetMinModeB.Location = New System.Drawing.Point(364, 213)
        Me.LabelPulseVoltagetMinModeB.Name = "LabelPulseVoltagetMinModeB"
        Me.LabelPulseVoltagetMinModeB.Size = New System.Drawing.Size(10, 13)
        Me.LabelPulseVoltagetMinModeB.TabIndex = 514
        Me.LabelPulseVoltagetMinModeB.Text = "-"
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Location = New System.Drawing.Point(229, 213)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(92, 13)
        Me.Label116.TabIndex = 513
        Me.Label116.Text = "Pulse Voltage Min"
        '
        'LabelPulseCurrentMaxModeB
        '
        Me.LabelPulseCurrentMaxModeB.AutoSize = True
        Me.LabelPulseCurrentMaxModeB.Location = New System.Drawing.Point(364, 200)
        Me.LabelPulseCurrentMaxModeB.Name = "LabelPulseCurrentMaxModeB"
        Me.LabelPulseCurrentMaxModeB.Size = New System.Drawing.Size(10, 13)
        Me.LabelPulseCurrentMaxModeB.TabIndex = 512
        Me.LabelPulseCurrentMaxModeB.Text = "-"
        '
        'Label118
        '
        Me.Label118.AutoSize = True
        Me.Label118.Location = New System.Drawing.Point(229, 200)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(93, 13)
        Me.Label118.TabIndex = 511
        Me.Label118.Text = "Pulse Current Max"
        '
        'LabelPulseCurrentMinModeB
        '
        Me.LabelPulseCurrentMinModeB.AutoSize = True
        Me.LabelPulseCurrentMinModeB.Location = New System.Drawing.Point(364, 187)
        Me.LabelPulseCurrentMinModeB.Name = "LabelPulseCurrentMinModeB"
        Me.LabelPulseCurrentMinModeB.Size = New System.Drawing.Size(10, 13)
        Me.LabelPulseCurrentMinModeB.TabIndex = 510
        Me.LabelPulseCurrentMinModeB.Text = "-"
        '
        'Label120
        '
        Me.Label120.AutoSize = True
        Me.Label120.Location = New System.Drawing.Point(229, 187)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(90, 13)
        Me.Label120.TabIndex = 509
        Me.Label120.Text = "Pulse Current Min"
        '
        'LabelPulseCurrentModeB
        '
        Me.LabelPulseCurrentModeB.AutoSize = True
        Me.LabelPulseCurrentModeB.Location = New System.Drawing.Point(364, 174)
        Me.LabelPulseCurrentModeB.Name = "LabelPulseCurrentModeB"
        Me.LabelPulseCurrentModeB.Size = New System.Drawing.Size(10, 13)
        Me.LabelPulseCurrentModeB.TabIndex = 508
        Me.LabelPulseCurrentModeB.Text = "-"
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Location = New System.Drawing.Point(229, 174)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(70, 13)
        Me.Label122.TabIndex = 507
        Me.Label122.Text = "Pulse Current"
        '
        'LabelPulseVoltageModeB
        '
        Me.LabelPulseVoltageModeB.AutoSize = True
        Me.LabelPulseVoltageModeB.Location = New System.Drawing.Point(364, 161)
        Me.LabelPulseVoltageModeB.Name = "LabelPulseVoltageModeB"
        Me.LabelPulseVoltageModeB.Size = New System.Drawing.Size(10, 13)
        Me.LabelPulseVoltageModeB.TabIndex = 506
        Me.LabelPulseVoltageModeB.Text = "-"
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.Location = New System.Drawing.Point(229, 161)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(72, 13)
        Me.Label124.TabIndex = 505
        Me.Label124.Text = "Pulse Voltage"
        '
        'LabelMagnetronCurrent
        '
        Me.LabelMagnetronCurrent.AutoSize = True
        Me.LabelMagnetronCurrent.Location = New System.Drawing.Point(363, 361)
        Me.LabelMagnetronCurrent.Name = "LabelMagnetronCurrent"
        Me.LabelMagnetronCurrent.Size = New System.Drawing.Size(10, 13)
        Me.LabelMagnetronCurrent.TabIndex = 520
        Me.LabelMagnetronCurrent.Text = "-"
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Location = New System.Drawing.Point(228, 361)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(114, 13)
        Me.Label110.TabIndex = 519
        Me.Label110.Text = "Previous Pulse Current"
        '
        'LabelMagnetronVoltage
        '
        Me.LabelMagnetronVoltage.AutoSize = True
        Me.LabelMagnetronVoltage.Location = New System.Drawing.Point(363, 348)
        Me.LabelMagnetronVoltage.Name = "LabelMagnetronVoltage"
        Me.LabelMagnetronVoltage.Size = New System.Drawing.Size(10, 13)
        Me.LabelMagnetronVoltage.TabIndex = 518
        Me.LabelMagnetronVoltage.Text = "-"
        '
        'Label115
        '
        Me.Label115.AutoSize = True
        Me.Label115.Location = New System.Drawing.Point(228, 348)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(116, 13)
        Me.Label115.TabIndex = 517
        Me.Label115.Text = "Previous Pulse Voltage"
        '
        'Label117
        '
        Me.Label117.AutoSize = True
        Me.Label117.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.Location = New System.Drawing.Point(5, 281)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(57, 13)
        Me.Label117.TabIndex = 521
        Me.Label117.Text = "Counters"
        '
        'CheckBox18
        '
        Me.CheckBox18.AutoCheck = False
        Me.CheckBox18.AutoSize = True
        Me.CheckBox18.Location = New System.Drawing.Point(851, 443)
        Me.CheckBox18.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox18.TabIndex = 561
        Me.CheckBox18.UseVisualStyleBackColor = True
        Me.CheckBox18.Visible = False
        '
        'CheckBoxMagnetronStatusBit9
        '
        Me.CheckBoxMagnetronStatusBit9.AutoCheck = False
        Me.CheckBoxMagnetronStatusBit9.AutoSize = True
        Me.CheckBoxMagnetronStatusBit9.Location = New System.Drawing.Point(830, 443)
        Me.CheckBoxMagnetronStatusBit9.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronStatusBit9.Name = "CheckBoxMagnetronStatusBit9"
        Me.CheckBoxMagnetronStatusBit9.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronStatusBit9.TabIndex = 560
        Me.CheckBoxMagnetronStatusBit9.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronFaultBit9
        '
        Me.CheckBoxMagnetronFaultBit9.AutoCheck = False
        Me.CheckBoxMagnetronFaultBit9.AutoSize = True
        Me.CheckBoxMagnetronFaultBit9.Location = New System.Drawing.Point(809, 443)
        Me.CheckBoxMagnetronFaultBit9.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronFaultBit9.Name = "CheckBoxMagnetronFaultBit9"
        Me.CheckBoxMagnetronFaultBit9.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronFaultBit9.TabIndex = 559
        Me.CheckBoxMagnetronFaultBit9.UseVisualStyleBackColor = True
        '
        'CheckBox21
        '
        Me.CheckBox21.AutoCheck = False
        Me.CheckBox21.AutoSize = True
        Me.CheckBox21.Location = New System.Drawing.Point(851, 429)
        Me.CheckBox21.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox21.TabIndex = 558
        Me.CheckBox21.UseVisualStyleBackColor = True
        Me.CheckBox21.Visible = False
        '
        'CheckBox22
        '
        Me.CheckBox22.AutoCheck = False
        Me.CheckBox22.AutoSize = True
        Me.CheckBox22.Location = New System.Drawing.Point(851, 401)
        Me.CheckBox22.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox22.TabIndex = 557
        Me.CheckBox22.UseVisualStyleBackColor = True
        Me.CheckBox22.Visible = False
        '
        'CheckBox23
        '
        Me.CheckBox23.AutoCheck = False
        Me.CheckBox23.AutoSize = True
        Me.CheckBox23.Location = New System.Drawing.Point(851, 415)
        Me.CheckBox23.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox23.TabIndex = 556
        Me.CheckBox23.UseVisualStyleBackColor = True
        Me.CheckBox23.Visible = False
        '
        'CheckBox24
        '
        Me.CheckBox24.AutoCheck = False
        Me.CheckBox24.AutoSize = True
        Me.CheckBox24.Location = New System.Drawing.Point(851, 387)
        Me.CheckBox24.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox24.Name = "CheckBox24"
        Me.CheckBox24.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox24.TabIndex = 555
        Me.CheckBox24.UseVisualStyleBackColor = True
        Me.CheckBox24.Visible = False
        '
        'CheckBoxMagnetronStatusBit8
        '
        Me.CheckBoxMagnetronStatusBit8.AutoCheck = False
        Me.CheckBoxMagnetronStatusBit8.AutoSize = True
        Me.CheckBoxMagnetronStatusBit8.Location = New System.Drawing.Point(830, 429)
        Me.CheckBoxMagnetronStatusBit8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronStatusBit8.Name = "CheckBoxMagnetronStatusBit8"
        Me.CheckBoxMagnetronStatusBit8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronStatusBit8.TabIndex = 554
        Me.CheckBoxMagnetronStatusBit8.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronStatusBit6
        '
        Me.CheckBoxMagnetronStatusBit6.AutoCheck = False
        Me.CheckBoxMagnetronStatusBit6.AutoSize = True
        Me.CheckBoxMagnetronStatusBit6.Location = New System.Drawing.Point(830, 401)
        Me.CheckBoxMagnetronStatusBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronStatusBit6.Name = "CheckBoxMagnetronStatusBit6"
        Me.CheckBoxMagnetronStatusBit6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronStatusBit6.TabIndex = 553
        Me.CheckBoxMagnetronStatusBit6.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronStatusBit7
        '
        Me.CheckBoxMagnetronStatusBit7.AutoCheck = False
        Me.CheckBoxMagnetronStatusBit7.AutoSize = True
        Me.CheckBoxMagnetronStatusBit7.Location = New System.Drawing.Point(830, 415)
        Me.CheckBoxMagnetronStatusBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronStatusBit7.Name = "CheckBoxMagnetronStatusBit7"
        Me.CheckBoxMagnetronStatusBit7.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronStatusBit7.TabIndex = 552
        Me.CheckBoxMagnetronStatusBit7.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronStatusBit5
        '
        Me.CheckBoxMagnetronStatusBit5.AutoCheck = False
        Me.CheckBoxMagnetronStatusBit5.AutoSize = True
        Me.CheckBoxMagnetronStatusBit5.Location = New System.Drawing.Point(830, 387)
        Me.CheckBoxMagnetronStatusBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronStatusBit5.Name = "CheckBoxMagnetronStatusBit5"
        Me.CheckBoxMagnetronStatusBit5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronStatusBit5.TabIndex = 551
        Me.CheckBoxMagnetronStatusBit5.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(684, 415)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 13)
        Me.Label13.TabIndex = 550
        Me.Label13.Text = "Filament Unused #2"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(684, 401)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 13)
        Me.Label15.TabIndex = 549
        Me.Label15.Text = "Filament Unused #1"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(684, 442)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(111, 13)
        Me.Label17.TabIndex = 548
        Me.Label17.Text = "Magnet OC Hard Limit"
        '
        'CheckBoxMagnetronFaultBit8
        '
        Me.CheckBoxMagnetronFaultBit8.AutoCheck = False
        Me.CheckBoxMagnetronFaultBit8.AutoSize = True
        Me.CheckBoxMagnetronFaultBit8.Location = New System.Drawing.Point(809, 429)
        Me.CheckBoxMagnetronFaultBit8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronFaultBit8.Name = "CheckBoxMagnetronFaultBit8"
        Me.CheckBoxMagnetronFaultBit8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronFaultBit8.TabIndex = 547
        Me.CheckBoxMagnetronFaultBit8.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronFaultBit6
        '
        Me.CheckBoxMagnetronFaultBit6.AutoCheck = False
        Me.CheckBoxMagnetronFaultBit6.AutoSize = True
        Me.CheckBoxMagnetronFaultBit6.Location = New System.Drawing.Point(809, 401)
        Me.CheckBoxMagnetronFaultBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronFaultBit6.Name = "CheckBoxMagnetronFaultBit6"
        Me.CheckBoxMagnetronFaultBit6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronFaultBit6.TabIndex = 546
        Me.CheckBoxMagnetronFaultBit6.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronFaultBit7
        '
        Me.CheckBoxMagnetronFaultBit7.AutoCheck = False
        Me.CheckBoxMagnetronFaultBit7.AutoSize = True
        Me.CheckBoxMagnetronFaultBit7.Location = New System.Drawing.Point(809, 415)
        Me.CheckBoxMagnetronFaultBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronFaultBit7.Name = "CheckBoxMagnetronFaultBit7"
        Me.CheckBoxMagnetronFaultBit7.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronFaultBit7.TabIndex = 545
        Me.CheckBoxMagnetronFaultBit7.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronFaultBit5
        '
        Me.CheckBoxMagnetronFaultBit5.AutoCheck = False
        Me.CheckBoxMagnetronFaultBit5.AutoSize = True
        Me.CheckBoxMagnetronFaultBit5.Location = New System.Drawing.Point(809, 387)
        Me.CheckBoxMagnetronFaultBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronFaultBit5.Name = "CheckBoxMagnetronFaultBit5"
        Me.CheckBoxMagnetronFaultBit5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronFaultBit5.TabIndex = 544
        Me.CheckBoxMagnetronFaultBit5.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(684, 429)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(111, 13)
        Me.Label19.TabIndex = 543
        Me.Label19.Text = "HW Magnet Cur OOR"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(684, 387)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(115, 13)
        Me.Label21.TabIndex = 542
        Me.Label21.Text = "Filament Under Current"
        '
        'CheckBox39
        '
        Me.CheckBox39.AutoCheck = False
        Me.CheckBox39.AutoSize = True
        Me.CheckBox39.Location = New System.Drawing.Point(851, 527)
        Me.CheckBox39.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox39.Name = "CheckBox39"
        Me.CheckBox39.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox39.TabIndex = 595
        Me.CheckBox39.UseVisualStyleBackColor = True
        Me.CheckBox39.Visible = False
        '
        'CheckBoxMagnetronStatusBit15
        '
        Me.CheckBoxMagnetronStatusBit15.AutoCheck = False
        Me.CheckBoxMagnetronStatusBit15.AutoSize = True
        Me.CheckBoxMagnetronStatusBit15.Location = New System.Drawing.Point(830, 527)
        Me.CheckBoxMagnetronStatusBit15.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronStatusBit15.Name = "CheckBoxMagnetronStatusBit15"
        Me.CheckBoxMagnetronStatusBit15.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronStatusBit15.TabIndex = 591
        Me.CheckBoxMagnetronStatusBit15.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronFaultBit15
        '
        Me.CheckBoxMagnetronFaultBit15.AutoCheck = False
        Me.CheckBoxMagnetronFaultBit15.AutoSize = True
        Me.CheckBoxMagnetronFaultBit15.Location = New System.Drawing.Point(809, 527)
        Me.CheckBoxMagnetronFaultBit15.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronFaultBit15.Name = "CheckBoxMagnetronFaultBit15"
        Me.CheckBoxMagnetronFaultBit15.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronFaultBit15.TabIndex = 584
        Me.CheckBoxMagnetronFaultBit15.UseVisualStyleBackColor = True
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(684, 527)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(99, 13)
        Me.Label31.TabIndex = 582
        Me.Label31.Text = "Magnet Unused #2"
        '
        'CheckBox48
        '
        Me.CheckBox48.AutoCheck = False
        Me.CheckBox48.AutoSize = True
        Me.CheckBox48.Location = New System.Drawing.Point(851, 513)
        Me.CheckBox48.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox48.Name = "CheckBox48"
        Me.CheckBox48.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox48.TabIndex = 581
        Me.CheckBox48.UseVisualStyleBackColor = True
        Me.CheckBox48.Visible = False
        '
        'CheckBoxMagnetronStatusBit14
        '
        Me.CheckBoxMagnetronStatusBit14.AutoCheck = False
        Me.CheckBoxMagnetronStatusBit14.AutoSize = True
        Me.CheckBoxMagnetronStatusBit14.Location = New System.Drawing.Point(830, 513)
        Me.CheckBoxMagnetronStatusBit14.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronStatusBit14.Name = "CheckBoxMagnetronStatusBit14"
        Me.CheckBoxMagnetronStatusBit14.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronStatusBit14.TabIndex = 580
        Me.CheckBoxMagnetronStatusBit14.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronFaultBit14
        '
        Me.CheckBoxMagnetronFaultBit14.AutoCheck = False
        Me.CheckBoxMagnetronFaultBit14.AutoSize = True
        Me.CheckBoxMagnetronFaultBit14.Location = New System.Drawing.Point(809, 513)
        Me.CheckBoxMagnetronFaultBit14.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronFaultBit14.Name = "CheckBoxMagnetronFaultBit14"
        Me.CheckBoxMagnetronFaultBit14.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronFaultBit14.TabIndex = 579
        Me.CheckBoxMagnetronFaultBit14.UseVisualStyleBackColor = True
        '
        'CheckBox53
        '
        Me.CheckBox53.AutoCheck = False
        Me.CheckBox53.AutoSize = True
        Me.CheckBox53.Location = New System.Drawing.Point(851, 499)
        Me.CheckBox53.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox53.Name = "CheckBox53"
        Me.CheckBox53.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox53.TabIndex = 578
        Me.CheckBox53.UseVisualStyleBackColor = True
        Me.CheckBox53.Visible = False
        '
        'CheckBox54
        '
        Me.CheckBox54.AutoCheck = False
        Me.CheckBox54.AutoSize = True
        Me.CheckBox54.Location = New System.Drawing.Point(851, 471)
        Me.CheckBox54.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox54.Name = "CheckBox54"
        Me.CheckBox54.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox54.TabIndex = 577
        Me.CheckBox54.UseVisualStyleBackColor = True
        Me.CheckBox54.Visible = False
        '
        'CheckBox55
        '
        Me.CheckBox55.AutoCheck = False
        Me.CheckBox55.AutoSize = True
        Me.CheckBox55.Location = New System.Drawing.Point(851, 485)
        Me.CheckBox55.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox55.Name = "CheckBox55"
        Me.CheckBox55.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox55.TabIndex = 576
        Me.CheckBox55.UseVisualStyleBackColor = True
        Me.CheckBox55.Visible = False
        '
        'CheckBox56
        '
        Me.CheckBox56.AutoCheck = False
        Me.CheckBox56.AutoSize = True
        Me.CheckBox56.Location = New System.Drawing.Point(851, 457)
        Me.CheckBox56.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox56.Name = "CheckBox56"
        Me.CheckBox56.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox56.TabIndex = 575
        Me.CheckBox56.UseVisualStyleBackColor = True
        Me.CheckBox56.Visible = False
        '
        'CheckBoxMagnetronStatusBit13
        '
        Me.CheckBoxMagnetronStatusBit13.AutoCheck = False
        Me.CheckBoxMagnetronStatusBit13.AutoSize = True
        Me.CheckBoxMagnetronStatusBit13.Location = New System.Drawing.Point(830, 499)
        Me.CheckBoxMagnetronStatusBit13.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronStatusBit13.Name = "CheckBoxMagnetronStatusBit13"
        Me.CheckBoxMagnetronStatusBit13.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronStatusBit13.TabIndex = 574
        Me.CheckBoxMagnetronStatusBit13.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronStatusBit11
        '
        Me.CheckBoxMagnetronStatusBit11.AutoCheck = False
        Me.CheckBoxMagnetronStatusBit11.AutoSize = True
        Me.CheckBoxMagnetronStatusBit11.Location = New System.Drawing.Point(830, 471)
        Me.CheckBoxMagnetronStatusBit11.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronStatusBit11.Name = "CheckBoxMagnetronStatusBit11"
        Me.CheckBoxMagnetronStatusBit11.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronStatusBit11.TabIndex = 573
        Me.CheckBoxMagnetronStatusBit11.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronStatusBit12
        '
        Me.CheckBoxMagnetronStatusBit12.AutoCheck = False
        Me.CheckBoxMagnetronStatusBit12.AutoSize = True
        Me.CheckBoxMagnetronStatusBit12.Location = New System.Drawing.Point(830, 485)
        Me.CheckBoxMagnetronStatusBit12.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronStatusBit12.Name = "CheckBoxMagnetronStatusBit12"
        Me.CheckBoxMagnetronStatusBit12.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronStatusBit12.TabIndex = 572
        Me.CheckBoxMagnetronStatusBit12.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronStatusBit10
        '
        Me.CheckBoxMagnetronStatusBit10.AutoCheck = False
        Me.CheckBoxMagnetronStatusBit10.AutoSize = True
        Me.CheckBoxMagnetronStatusBit10.Location = New System.Drawing.Point(830, 457)
        Me.CheckBoxMagnetronStatusBit10.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronStatusBit10.Name = "CheckBoxMagnetronStatusBit10"
        Me.CheckBoxMagnetronStatusBit10.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronStatusBit10.TabIndex = 571
        Me.CheckBoxMagnetronStatusBit10.UseVisualStyleBackColor = True
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(684, 485)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(108, 13)
        Me.Label32.TabIndex = 570
        Me.Label32.Text = "Magnet Over Voltage"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(684, 471)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(112, 13)
        Me.Label33.TabIndex = 569
        Me.Label33.Text = "Magnet Under Current"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(684, 513)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(99, 13)
        Me.Label34.TabIndex = 568
        Me.Label34.Text = "Magnet Unused #1"
        '
        'CheckBoxMagnetronFaultBit13
        '
        Me.CheckBoxMagnetronFaultBit13.AutoCheck = False
        Me.CheckBoxMagnetronFaultBit13.AutoSize = True
        Me.CheckBoxMagnetronFaultBit13.Location = New System.Drawing.Point(809, 499)
        Me.CheckBoxMagnetronFaultBit13.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronFaultBit13.Name = "CheckBoxMagnetronFaultBit13"
        Me.CheckBoxMagnetronFaultBit13.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronFaultBit13.TabIndex = 567
        Me.CheckBoxMagnetronFaultBit13.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronFaultBit11
        '
        Me.CheckBoxMagnetronFaultBit11.AutoCheck = False
        Me.CheckBoxMagnetronFaultBit11.AutoSize = True
        Me.CheckBoxMagnetronFaultBit11.Location = New System.Drawing.Point(809, 471)
        Me.CheckBoxMagnetronFaultBit11.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronFaultBit11.Name = "CheckBoxMagnetronFaultBit11"
        Me.CheckBoxMagnetronFaultBit11.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronFaultBit11.TabIndex = 566
        Me.CheckBoxMagnetronFaultBit11.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronFaultBit12
        '
        Me.CheckBoxMagnetronFaultBit12.AutoCheck = False
        Me.CheckBoxMagnetronFaultBit12.AutoSize = True
        Me.CheckBoxMagnetronFaultBit12.Location = New System.Drawing.Point(809, 485)
        Me.CheckBoxMagnetronFaultBit12.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronFaultBit12.Name = "CheckBoxMagnetronFaultBit12"
        Me.CheckBoxMagnetronFaultBit12.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronFaultBit12.TabIndex = 565
        Me.CheckBoxMagnetronFaultBit12.UseVisualStyleBackColor = True
        '
        'CheckBoxMagnetronFaultBit10
        '
        Me.CheckBoxMagnetronFaultBit10.AutoCheck = False
        Me.CheckBoxMagnetronFaultBit10.AutoSize = True
        Me.CheckBoxMagnetronFaultBit10.Location = New System.Drawing.Point(809, 457)
        Me.CheckBoxMagnetronFaultBit10.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxMagnetronFaultBit10.Name = "CheckBoxMagnetronFaultBit10"
        Me.CheckBoxMagnetronFaultBit10.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMagnetronFaultBit10.TabIndex = 564
        Me.CheckBoxMagnetronFaultBit10.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(684, 499)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(114, 13)
        Me.Label35.TabIndex = 563
        Me.Label35.Text = "Magnet Under Voltage"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(684, 457)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(106, 13)
        Me.Label36.TabIndex = 562
        Me.Label36.Text = "Magnet Over Current"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoCheck = False
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(1070, 264)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 660
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'CheckBoxHVStatusBit15
        '
        Me.CheckBoxHVStatusBit15.AutoCheck = False
        Me.CheckBoxHVStatusBit15.AutoSize = True
        Me.CheckBoxHVStatusBit15.Location = New System.Drawing.Point(1049, 264)
        Me.CheckBoxHVStatusBit15.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVStatusBit15.Name = "CheckBoxHVStatusBit15"
        Me.CheckBoxHVStatusBit15.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVStatusBit15.TabIndex = 659
        Me.CheckBoxHVStatusBit15.UseVisualStyleBackColor = True
        '
        'CheckBoxHVFaultBit15
        '
        Me.CheckBoxHVFaultBit15.AutoCheck = False
        Me.CheckBoxHVFaultBit15.AutoSize = True
        Me.CheckBoxHVFaultBit15.Location = New System.Drawing.Point(1028, 264)
        Me.CheckBoxHVFaultBit15.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVFaultBit15.Name = "CheckBoxHVFaultBit15"
        Me.CheckBoxHVFaultBit15.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVFaultBit15.TabIndex = 658
        Me.CheckBoxHVFaultBit15.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(903, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 657
        Me.Label2.Text = "Lambda Phase Loss"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoCheck = False
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(1070, 250)
        Me.CheckBox4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox4.TabIndex = 656
        Me.CheckBox4.UseVisualStyleBackColor = True
        Me.CheckBox4.Visible = False
        '
        'CheckBoxHVStatusBit14
        '
        Me.CheckBoxHVStatusBit14.AutoCheck = False
        Me.CheckBoxHVStatusBit14.AutoSize = True
        Me.CheckBoxHVStatusBit14.Location = New System.Drawing.Point(1049, 250)
        Me.CheckBoxHVStatusBit14.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVStatusBit14.Name = "CheckBoxHVStatusBit14"
        Me.CheckBoxHVStatusBit14.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVStatusBit14.TabIndex = 655
        Me.CheckBoxHVStatusBit14.UseVisualStyleBackColor = True
        '
        'CheckBoxHVFaultBit14
        '
        Me.CheckBoxHVFaultBit14.AutoCheck = False
        Me.CheckBoxHVFaultBit14.AutoSize = True
        Me.CheckBoxHVFaultBit14.Location = New System.Drawing.Point(1028, 250)
        Me.CheckBoxHVFaultBit14.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVFaultBit14.Name = "CheckBoxHVFaultBit14"
        Me.CheckBoxHVFaultBit14.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVFaultBit14.TabIndex = 654
        Me.CheckBoxHVFaultBit14.UseVisualStyleBackColor = True
        '
        'CheckBox9
        '
        Me.CheckBox9.AutoCheck = False
        Me.CheckBox9.AutoSize = True
        Me.CheckBox9.Location = New System.Drawing.Point(1070, 236)
        Me.CheckBox9.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox9.TabIndex = 653
        Me.CheckBox9.UseVisualStyleBackColor = True
        Me.CheckBox9.Visible = False
        '
        'CheckBox10
        '
        Me.CheckBox10.AutoCheck = False
        Me.CheckBox10.AutoSize = True
        Me.CheckBox10.Location = New System.Drawing.Point(1070, 208)
        Me.CheckBox10.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox10.TabIndex = 652
        Me.CheckBox10.UseVisualStyleBackColor = True
        Me.CheckBox10.Visible = False
        '
        'CheckBox11
        '
        Me.CheckBox11.AutoCheck = False
        Me.CheckBox11.AutoSize = True
        Me.CheckBox11.Location = New System.Drawing.Point(1070, 222)
        Me.CheckBox11.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox11.TabIndex = 651
        Me.CheckBox11.UseVisualStyleBackColor = True
        Me.CheckBox11.Visible = False
        '
        'CheckBox12
        '
        Me.CheckBox12.AutoCheck = False
        Me.CheckBox12.AutoSize = True
        Me.CheckBox12.Location = New System.Drawing.Point(1070, 194)
        Me.CheckBox12.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox12.TabIndex = 650
        Me.CheckBox12.UseVisualStyleBackColor = True
        Me.CheckBox12.Visible = False
        '
        'CheckBoxHVStatusBit13
        '
        Me.CheckBoxHVStatusBit13.AutoCheck = False
        Me.CheckBoxHVStatusBit13.AutoSize = True
        Me.CheckBoxHVStatusBit13.Location = New System.Drawing.Point(1049, 236)
        Me.CheckBoxHVStatusBit13.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVStatusBit13.Name = "CheckBoxHVStatusBit13"
        Me.CheckBoxHVStatusBit13.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVStatusBit13.TabIndex = 649
        Me.CheckBoxHVStatusBit13.UseVisualStyleBackColor = True
        '
        'CheckBoxHVStatusBit11
        '
        Me.CheckBoxHVStatusBit11.AutoCheck = False
        Me.CheckBoxHVStatusBit11.AutoSize = True
        Me.CheckBoxHVStatusBit11.Location = New System.Drawing.Point(1049, 208)
        Me.CheckBoxHVStatusBit11.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVStatusBit11.Name = "CheckBoxHVStatusBit11"
        Me.CheckBoxHVStatusBit11.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVStatusBit11.TabIndex = 648
        Me.CheckBoxHVStatusBit11.UseVisualStyleBackColor = True
        '
        'CheckBoxHVStatusBit12
        '
        Me.CheckBoxHVStatusBit12.AutoCheck = False
        Me.CheckBoxHVStatusBit12.AutoSize = True
        Me.CheckBoxHVStatusBit12.Location = New System.Drawing.Point(1049, 222)
        Me.CheckBoxHVStatusBit12.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVStatusBit12.Name = "CheckBoxHVStatusBit12"
        Me.CheckBoxHVStatusBit12.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVStatusBit12.TabIndex = 647
        Me.CheckBoxHVStatusBit12.UseVisualStyleBackColor = True
        '
        'CheckBoxHVStatusBit10
        '
        Me.CheckBoxHVStatusBit10.AutoCheck = False
        Me.CheckBoxHVStatusBit10.AutoSize = True
        Me.CheckBoxHVStatusBit10.Location = New System.Drawing.Point(1049, 194)
        Me.CheckBoxHVStatusBit10.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVStatusBit10.Name = "CheckBoxHVStatusBit10"
        Me.CheckBoxHVStatusBit10.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVStatusBit10.TabIndex = 646
        Me.CheckBoxHVStatusBit10.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(903, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 645
        Me.Label5.Text = "Lambda Over Temp"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(903, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 644
        Me.Label7.Text = "Lambda Vpeak UV"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(903, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 13)
        Me.Label9.TabIndex = 643
        Me.Label9.Text = "Lambda Load Fault"
        '
        'CheckBoxHVFaultBit13
        '
        Me.CheckBoxHVFaultBit13.AutoCheck = False
        Me.CheckBoxHVFaultBit13.AutoSize = True
        Me.CheckBoxHVFaultBit13.Location = New System.Drawing.Point(1028, 236)
        Me.CheckBoxHVFaultBit13.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVFaultBit13.Name = "CheckBoxHVFaultBit13"
        Me.CheckBoxHVFaultBit13.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVFaultBit13.TabIndex = 642
        Me.CheckBoxHVFaultBit13.UseVisualStyleBackColor = True
        '
        'CheckBoxHVFaultBit11
        '
        Me.CheckBoxHVFaultBit11.AutoCheck = False
        Me.CheckBoxHVFaultBit11.AutoSize = True
        Me.CheckBoxHVFaultBit11.Location = New System.Drawing.Point(1028, 208)
        Me.CheckBoxHVFaultBit11.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVFaultBit11.Name = "CheckBoxHVFaultBit11"
        Me.CheckBoxHVFaultBit11.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVFaultBit11.TabIndex = 641
        Me.CheckBoxHVFaultBit11.UseVisualStyleBackColor = True
        '
        'CheckBoxHVFaultBit12
        '
        Me.CheckBoxHVFaultBit12.AutoCheck = False
        Me.CheckBoxHVFaultBit12.AutoSize = True
        Me.CheckBoxHVFaultBit12.Location = New System.Drawing.Point(1028, 222)
        Me.CheckBoxHVFaultBit12.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVFaultBit12.Name = "CheckBoxHVFaultBit12"
        Me.CheckBoxHVFaultBit12.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVFaultBit12.TabIndex = 640
        Me.CheckBoxHVFaultBit12.UseVisualStyleBackColor = True
        '
        'CheckBoxHVFaultBit10
        '
        Me.CheckBoxHVFaultBit10.AutoCheck = False
        Me.CheckBoxHVFaultBit10.AutoSize = True
        Me.CheckBoxHVFaultBit10.Location = New System.Drawing.Point(1028, 194)
        Me.CheckBoxHVFaultBit10.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVFaultBit10.Name = "CheckBoxHVFaultBit10"
        Me.CheckBoxHVFaultBit10.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVFaultBit10.TabIndex = 639
        Me.CheckBoxHVFaultBit10.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(903, 236)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(103, 13)
        Me.Label11.TabIndex = 638
        Me.Label11.Text = "Lambda Interlock Flt"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(903, 194)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(91, 13)
        Me.Label23.TabIndex = 637
        Me.Label23.Text = "Lamba Vpeak OV"
        '
        'CheckBox31
        '
        Me.CheckBox31.AutoCheck = False
        Me.CheckBox31.AutoSize = True
        Me.CheckBox31.Location = New System.Drawing.Point(1070, 180)
        Me.CheckBox31.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox31.Name = "CheckBox31"
        Me.CheckBox31.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox31.TabIndex = 636
        Me.CheckBox31.UseVisualStyleBackColor = True
        Me.CheckBox31.Visible = False
        '
        'CheckBoxHVStatusBit9
        '
        Me.CheckBoxHVStatusBit9.AutoCheck = False
        Me.CheckBoxHVStatusBit9.AutoSize = True
        Me.CheckBoxHVStatusBit9.Location = New System.Drawing.Point(1049, 180)
        Me.CheckBoxHVStatusBit9.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVStatusBit9.Name = "CheckBoxHVStatusBit9"
        Me.CheckBoxHVStatusBit9.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVStatusBit9.TabIndex = 635
        Me.CheckBoxHVStatusBit9.UseVisualStyleBackColor = True
        '
        'CheckBoxHVFaultBit9
        '
        Me.CheckBoxHVFaultBit9.AutoCheck = False
        Me.CheckBoxHVFaultBit9.AutoSize = True
        Me.CheckBoxHVFaultBit9.Location = New System.Drawing.Point(1028, 180)
        Me.CheckBoxHVFaultBit9.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVFaultBit9.Name = "CheckBoxHVFaultBit9"
        Me.CheckBoxHVFaultBit9.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVFaultBit9.TabIndex = 634
        Me.CheckBoxHVFaultBit9.UseVisualStyleBackColor = True
        '
        'CheckBox34
        '
        Me.CheckBox34.AutoCheck = False
        Me.CheckBox34.AutoSize = True
        Me.CheckBox34.Location = New System.Drawing.Point(1070, 166)
        Me.CheckBox34.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox34.Name = "CheckBox34"
        Me.CheckBox34.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox34.TabIndex = 633
        Me.CheckBox34.UseVisualStyleBackColor = True
        Me.CheckBox34.Visible = False
        '
        'CheckBox35
        '
        Me.CheckBox35.AutoCheck = False
        Me.CheckBox35.AutoSize = True
        Me.CheckBox35.Location = New System.Drawing.Point(1070, 138)
        Me.CheckBox35.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox35.Name = "CheckBox35"
        Me.CheckBox35.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox35.TabIndex = 632
        Me.CheckBox35.UseVisualStyleBackColor = True
        Me.CheckBox35.Visible = False
        '
        'CheckBox36
        '
        Me.CheckBox36.AutoCheck = False
        Me.CheckBox36.AutoSize = True
        Me.CheckBox36.Location = New System.Drawing.Point(1070, 152)
        Me.CheckBox36.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox36.Name = "CheckBox36"
        Me.CheckBox36.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox36.TabIndex = 631
        Me.CheckBox36.UseVisualStyleBackColor = True
        Me.CheckBox36.Visible = False
        '
        'CheckBox37
        '
        Me.CheckBox37.AutoCheck = False
        Me.CheckBox37.AutoSize = True
        Me.CheckBox37.Location = New System.Drawing.Point(1070, 124)
        Me.CheckBox37.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox37.Name = "CheckBox37"
        Me.CheckBox37.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox37.TabIndex = 630
        Me.CheckBox37.UseVisualStyleBackColor = True
        Me.CheckBox37.Visible = False
        '
        'CheckBoxHVStatusBit8
        '
        Me.CheckBoxHVStatusBit8.AutoCheck = False
        Me.CheckBoxHVStatusBit8.AutoSize = True
        Me.CheckBoxHVStatusBit8.Location = New System.Drawing.Point(1049, 166)
        Me.CheckBoxHVStatusBit8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVStatusBit8.Name = "CheckBoxHVStatusBit8"
        Me.CheckBoxHVStatusBit8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVStatusBit8.TabIndex = 629
        Me.CheckBoxHVStatusBit8.UseVisualStyleBackColor = True
        '
        'CheckBoxHVStatusBit6
        '
        Me.CheckBoxHVStatusBit6.AutoCheck = False
        Me.CheckBoxHVStatusBit6.AutoSize = True
        Me.CheckBoxHVStatusBit6.Location = New System.Drawing.Point(1049, 138)
        Me.CheckBoxHVStatusBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVStatusBit6.Name = "CheckBoxHVStatusBit6"
        Me.CheckBoxHVStatusBit6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVStatusBit6.TabIndex = 628
        Me.CheckBoxHVStatusBit6.UseVisualStyleBackColor = True
        '
        'CheckBoxHVStatusBit7
        '
        Me.CheckBoxHVStatusBit7.AutoCheck = False
        Me.CheckBoxHVStatusBit7.AutoSize = True
        Me.CheckBoxHVStatusBit7.Location = New System.Drawing.Point(1049, 152)
        Me.CheckBoxHVStatusBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVStatusBit7.Name = "CheckBoxHVStatusBit7"
        Me.CheckBoxHVStatusBit7.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVStatusBit7.TabIndex = 627
        Me.CheckBoxHVStatusBit7.UseVisualStyleBackColor = True
        '
        'CheckBoxHVStatusBit5
        '
        Me.CheckBoxHVStatusBit5.AutoCheck = False
        Me.CheckBoxHVStatusBit5.AutoSize = True
        Me.CheckBoxHVStatusBit5.Location = New System.Drawing.Point(1049, 124)
        Me.CheckBoxHVStatusBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVStatusBit5.Name = "CheckBoxHVStatusBit5"
        Me.CheckBoxHVStatusBit5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVStatusBit5.TabIndex = 626
        Me.CheckBoxHVStatusBit5.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(903, 152)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(109, 13)
        Me.Label25.TabIndex = 625
        Me.Label25.Text = "Pulse Voltage OOR B"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(903, 138)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(109, 13)
        Me.Label27.TabIndex = 624
        Me.Label27.Text = "Pulse Voltage OOR A"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(903, 180)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(111, 13)
        Me.Label29.TabIndex = 623
        Me.Label29.Text = "Lambda EOC Timeout"
        '
        'CheckBoxHVFaultBit8
        '
        Me.CheckBoxHVFaultBit8.AutoCheck = False
        Me.CheckBoxHVFaultBit8.AutoSize = True
        Me.CheckBoxHVFaultBit8.Location = New System.Drawing.Point(1028, 166)
        Me.CheckBoxHVFaultBit8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVFaultBit8.Name = "CheckBoxHVFaultBit8"
        Me.CheckBoxHVFaultBit8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVFaultBit8.TabIndex = 622
        Me.CheckBoxHVFaultBit8.UseVisualStyleBackColor = True
        '
        'CheckBoxHVFaultBit6
        '
        Me.CheckBoxHVFaultBit6.AutoCheck = False
        Me.CheckBoxHVFaultBit6.AutoSize = True
        Me.CheckBoxHVFaultBit6.Location = New System.Drawing.Point(1028, 138)
        Me.CheckBoxHVFaultBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVFaultBit6.Name = "CheckBoxHVFaultBit6"
        Me.CheckBoxHVFaultBit6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVFaultBit6.TabIndex = 621
        Me.CheckBoxHVFaultBit6.UseVisualStyleBackColor = True
        '
        'CheckBoxHVFaultBit7
        '
        Me.CheckBoxHVFaultBit7.AutoCheck = False
        Me.CheckBoxHVFaultBit7.AutoSize = True
        Me.CheckBoxHVFaultBit7.Location = New System.Drawing.Point(1028, 152)
        Me.CheckBoxHVFaultBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVFaultBit7.Name = "CheckBoxHVFaultBit7"
        Me.CheckBoxHVFaultBit7.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVFaultBit7.TabIndex = 620
        Me.CheckBoxHVFaultBit7.UseVisualStyleBackColor = True
        '
        'CheckBoxHVFaultBit5
        '
        Me.CheckBoxHVFaultBit5.AutoCheck = False
        Me.CheckBoxHVFaultBit5.AutoSize = True
        Me.CheckBoxHVFaultBit5.Location = New System.Drawing.Point(1028, 124)
        Me.CheckBoxHVFaultBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVFaultBit5.Name = "CheckBoxHVFaultBit5"
        Me.CheckBoxHVFaultBit5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVFaultBit5.TabIndex = 619
        Me.CheckBoxHVFaultBit5.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(903, 166)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(113, 13)
        Me.Label37.TabIndex = 618
        Me.Label37.Text = "HV Lambda Sum Fault"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(903, 124)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(107, 13)
        Me.Label39.TabIndex = 617
        Me.Label39.Text = "Pulse Current OOR B"
        '
        'CheckBox52
        '
        Me.CheckBox52.AutoCheck = False
        Me.CheckBox52.AutoSize = True
        Me.CheckBox52.Location = New System.Drawing.Point(1070, 110)
        Me.CheckBox52.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox52.Name = "CheckBox52"
        Me.CheckBox52.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox52.TabIndex = 616
        Me.CheckBox52.UseVisualStyleBackColor = True
        Me.CheckBox52.Visible = False
        '
        'CheckBoxHVStatusBit4
        '
        Me.CheckBoxHVStatusBit4.AutoCheck = False
        Me.CheckBoxHVStatusBit4.AutoSize = True
        Me.CheckBoxHVStatusBit4.Location = New System.Drawing.Point(1049, 110)
        Me.CheckBoxHVStatusBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVStatusBit4.Name = "CheckBoxHVStatusBit4"
        Me.CheckBoxHVStatusBit4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVStatusBit4.TabIndex = 615
        Me.CheckBoxHVStatusBit4.UseVisualStyleBackColor = True
        '
        'CheckBoxHVFaultBit4
        '
        Me.CheckBoxHVFaultBit4.AutoCheck = False
        Me.CheckBoxHVFaultBit4.AutoSize = True
        Me.CheckBoxHVFaultBit4.Location = New System.Drawing.Point(1028, 110)
        Me.CheckBoxHVFaultBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVFaultBit4.Name = "CheckBoxHVFaultBit4"
        Me.CheckBoxHVFaultBit4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVFaultBit4.TabIndex = 614
        Me.CheckBoxHVFaultBit4.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(903, 27)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(150, 13)
        Me.Label41.TabIndex = 613
        Me.Label41.Text = "HIGH VOLTAGE FAULTS"
        '
        'CheckBox63
        '
        Me.CheckBox63.AutoCheck = False
        Me.CheckBox63.AutoSize = True
        Me.CheckBox63.Location = New System.Drawing.Point(1070, 96)
        Me.CheckBox63.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox63.Name = "CheckBox63"
        Me.CheckBox63.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox63.TabIndex = 612
        Me.CheckBox63.UseVisualStyleBackColor = True
        Me.CheckBox63.Visible = False
        '
        'CheckBox64
        '
        Me.CheckBox64.AutoCheck = False
        Me.CheckBox64.AutoSize = True
        Me.CheckBox64.Location = New System.Drawing.Point(1070, 68)
        Me.CheckBox64.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox64.Name = "CheckBox64"
        Me.CheckBox64.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox64.TabIndex = 611
        Me.CheckBox64.UseVisualStyleBackColor = True
        Me.CheckBox64.Visible = False
        '
        'CheckBox65
        '
        Me.CheckBox65.AutoCheck = False
        Me.CheckBox65.AutoSize = True
        Me.CheckBox65.Location = New System.Drawing.Point(1070, 82)
        Me.CheckBox65.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox65.Name = "CheckBox65"
        Me.CheckBox65.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox65.TabIndex = 610
        Me.CheckBox65.UseVisualStyleBackColor = True
        Me.CheckBox65.Visible = False
        '
        'CheckBox66
        '
        Me.CheckBox66.AutoCheck = False
        Me.CheckBox66.AutoSize = True
        Me.CheckBox66.Location = New System.Drawing.Point(1070, 54)
        Me.CheckBox66.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox66.Name = "CheckBox66"
        Me.CheckBox66.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox66.TabIndex = 609
        Me.CheckBox66.UseVisualStyleBackColor = True
        Me.CheckBox66.Visible = False
        '
        'CheckBoxHVStatusBit3
        '
        Me.CheckBoxHVStatusBit3.AutoCheck = False
        Me.CheckBoxHVStatusBit3.AutoSize = True
        Me.CheckBoxHVStatusBit3.Location = New System.Drawing.Point(1049, 96)
        Me.CheckBoxHVStatusBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVStatusBit3.Name = "CheckBoxHVStatusBit3"
        Me.CheckBoxHVStatusBit3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVStatusBit3.TabIndex = 608
        Me.CheckBoxHVStatusBit3.UseVisualStyleBackColor = True
        '
        'CheckBoxHVStatusBit1
        '
        Me.CheckBoxHVStatusBit1.AutoCheck = False
        Me.CheckBoxHVStatusBit1.AutoSize = True
        Me.CheckBoxHVStatusBit1.Location = New System.Drawing.Point(1049, 68)
        Me.CheckBoxHVStatusBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVStatusBit1.Name = "CheckBoxHVStatusBit1"
        Me.CheckBoxHVStatusBit1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVStatusBit1.TabIndex = 607
        Me.CheckBoxHVStatusBit1.UseVisualStyleBackColor = True
        '
        'CheckBoxHVStatusBit2
        '
        Me.CheckBoxHVStatusBit2.AutoCheck = False
        Me.CheckBoxHVStatusBit2.AutoSize = True
        Me.CheckBoxHVStatusBit2.Location = New System.Drawing.Point(1049, 82)
        Me.CheckBoxHVStatusBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVStatusBit2.Name = "CheckBoxHVStatusBit2"
        Me.CheckBoxHVStatusBit2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVStatusBit2.TabIndex = 606
        Me.CheckBoxHVStatusBit2.UseVisualStyleBackColor = True
        '
        'CheckBoxHVStatusBit0
        '
        Me.CheckBoxHVStatusBit0.AutoCheck = False
        Me.CheckBoxHVStatusBit0.AutoSize = True
        Me.CheckBoxHVStatusBit0.Location = New System.Drawing.Point(1049, 54)
        Me.CheckBoxHVStatusBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVStatusBit0.Name = "CheckBoxHVStatusBit0"
        Me.CheckBoxHVStatusBit0.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVStatusBit0.TabIndex = 605
        Me.CheckBoxHVStatusBit0.UseVisualStyleBackColor = True
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(903, 82)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(73, 13)
        Me.Label42.TabIndex = 604
        Me.Label42.Text = "Arc Limit Slow"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(903, 68)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(70, 13)
        Me.Label43.TabIndex = 603
        Me.Label43.Text = "Arc Limit Fast"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(903, 110)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(107, 13)
        Me.Label44.TabIndex = 602
        Me.Label44.Text = "Pulse Current OOR A"
        '
        'CheckBoxHVFaultBit3
        '
        Me.CheckBoxHVFaultBit3.AutoCheck = False
        Me.CheckBoxHVFaultBit3.AutoSize = True
        Me.CheckBoxHVFaultBit3.Location = New System.Drawing.Point(1028, 96)
        Me.CheckBoxHVFaultBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVFaultBit3.Name = "CheckBoxHVFaultBit3"
        Me.CheckBoxHVFaultBit3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVFaultBit3.TabIndex = 601
        Me.CheckBoxHVFaultBit3.UseVisualStyleBackColor = True
        '
        'CheckBoxHVFaultBit1
        '
        Me.CheckBoxHVFaultBit1.AutoCheck = False
        Me.CheckBoxHVFaultBit1.AutoSize = True
        Me.CheckBoxHVFaultBit1.Location = New System.Drawing.Point(1028, 68)
        Me.CheckBoxHVFaultBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVFaultBit1.Name = "CheckBoxHVFaultBit1"
        Me.CheckBoxHVFaultBit1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVFaultBit1.TabIndex = 600
        Me.CheckBoxHVFaultBit1.UseVisualStyleBackColor = True
        '
        'CheckBoxHVFaultBit2
        '
        Me.CheckBoxHVFaultBit2.AutoCheck = False
        Me.CheckBoxHVFaultBit2.AutoSize = True
        Me.CheckBoxHVFaultBit2.Location = New System.Drawing.Point(1028, 82)
        Me.CheckBoxHVFaultBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVFaultBit2.Name = "CheckBoxHVFaultBit2"
        Me.CheckBoxHVFaultBit2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVFaultBit2.TabIndex = 599
        Me.CheckBoxHVFaultBit2.UseVisualStyleBackColor = True
        '
        'CheckBoxHVFaultBit0
        '
        Me.CheckBoxHVFaultBit0.AutoCheck = False
        Me.CheckBoxHVFaultBit0.AutoSize = True
        Me.CheckBoxHVFaultBit0.Location = New System.Drawing.Point(1028, 54)
        Me.CheckBoxHVFaultBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxHVFaultBit0.Name = "CheckBoxHVFaultBit0"
        Me.CheckBoxHVFaultBit0.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxHVFaultBit0.TabIndex = 598
        Me.CheckBoxHVFaultBit0.UseVisualStyleBackColor = True
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(903, 96)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(63, 13)
        Me.Label45.TabIndex = 597
        Me.Label45.Text = "Arc Unused"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(903, 54)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(109, 13)
        Me.Label46.TabIndex = 596
        Me.Label46.Text = "Arc Limit Consecutive"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoCheck = False
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(643, 264)
        Me.CheckBox3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox3.TabIndex = 725
        Me.CheckBox3.UseVisualStyleBackColor = True
        Me.CheckBox3.Visible = False
        '
        'CheckBoxThyratronStatusBit15
        '
        Me.CheckBoxThyratronStatusBit15.AutoCheck = False
        Me.CheckBoxThyratronStatusBit15.AutoSize = True
        Me.CheckBoxThyratronStatusBit15.Location = New System.Drawing.Point(622, 264)
        Me.CheckBoxThyratronStatusBit15.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit15.Name = "CheckBoxThyratronStatusBit15"
        Me.CheckBoxThyratronStatusBit15.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit15.TabIndex = 724
        Me.CheckBoxThyratronStatusBit15.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit15
        '
        Me.CheckBoxThyratronFaultBit15.AutoCheck = False
        Me.CheckBoxThyratronFaultBit15.AutoSize = True
        Me.CheckBoxThyratronFaultBit15.Location = New System.Drawing.Point(601, 264)
        Me.CheckBoxThyratronFaultBit15.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit15.Name = "CheckBoxThyratronFaultBit15"
        Me.CheckBoxThyratronFaultBit15.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit15.TabIndex = 723
        Me.CheckBoxThyratronFaultBit15.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(476, 264)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(60, 13)
        Me.Label38.TabIndex = 722
        Me.Label38.Text = "Unused #6"
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoCheck = False
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Location = New System.Drawing.Point(643, 250)
        Me.CheckBox8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox8.TabIndex = 721
        Me.CheckBox8.UseVisualStyleBackColor = True
        Me.CheckBox8.Visible = False
        '
        'CheckBoxThyratronStatusBit14
        '
        Me.CheckBoxThyratronStatusBit14.AutoCheck = False
        Me.CheckBoxThyratronStatusBit14.AutoSize = True
        Me.CheckBoxThyratronStatusBit14.Location = New System.Drawing.Point(622, 250)
        Me.CheckBoxThyratronStatusBit14.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit14.Name = "CheckBoxThyratronStatusBit14"
        Me.CheckBoxThyratronStatusBit14.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit14.TabIndex = 720
        Me.CheckBoxThyratronStatusBit14.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit14
        '
        Me.CheckBoxThyratronFaultBit14.AutoCheck = False
        Me.CheckBoxThyratronFaultBit14.AutoSize = True
        Me.CheckBoxThyratronFaultBit14.Location = New System.Drawing.Point(601, 250)
        Me.CheckBoxThyratronFaultBit14.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit14.Name = "CheckBoxThyratronFaultBit14"
        Me.CheckBoxThyratronFaultBit14.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit14.TabIndex = 719
        Me.CheckBoxThyratronFaultBit14.UseVisualStyleBackColor = True
        '
        'CheckBox29
        '
        Me.CheckBox29.AutoCheck = False
        Me.CheckBox29.AutoSize = True
        Me.CheckBox29.Location = New System.Drawing.Point(643, 236)
        Me.CheckBox29.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox29.Name = "CheckBox29"
        Me.CheckBox29.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox29.TabIndex = 718
        Me.CheckBox29.UseVisualStyleBackColor = True
        Me.CheckBox29.Visible = False
        '
        'CheckBox30
        '
        Me.CheckBox30.AutoCheck = False
        Me.CheckBox30.AutoSize = True
        Me.CheckBox30.Location = New System.Drawing.Point(643, 208)
        Me.CheckBox30.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox30.Name = "CheckBox30"
        Me.CheckBox30.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox30.TabIndex = 717
        Me.CheckBox30.UseVisualStyleBackColor = True
        Me.CheckBox30.Visible = False
        '
        'CheckBox33
        '
        Me.CheckBox33.AutoCheck = False
        Me.CheckBox33.AutoSize = True
        Me.CheckBox33.Location = New System.Drawing.Point(643, 222)
        Me.CheckBox33.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox33.Name = "CheckBox33"
        Me.CheckBox33.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox33.TabIndex = 716
        Me.CheckBox33.UseVisualStyleBackColor = True
        Me.CheckBox33.Visible = False
        '
        'CheckBox44
        '
        Me.CheckBox44.AutoCheck = False
        Me.CheckBox44.AutoSize = True
        Me.CheckBox44.Location = New System.Drawing.Point(643, 194)
        Me.CheckBox44.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox44.Name = "CheckBox44"
        Me.CheckBox44.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox44.TabIndex = 715
        Me.CheckBox44.UseVisualStyleBackColor = True
        Me.CheckBox44.Visible = False
        '
        'CheckBoxThyratronStatusBit13
        '
        Me.CheckBoxThyratronStatusBit13.AutoCheck = False
        Me.CheckBoxThyratronStatusBit13.AutoSize = True
        Me.CheckBoxThyratronStatusBit13.Location = New System.Drawing.Point(622, 236)
        Me.CheckBoxThyratronStatusBit13.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit13.Name = "CheckBoxThyratronStatusBit13"
        Me.CheckBoxThyratronStatusBit13.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit13.TabIndex = 714
        Me.CheckBoxThyratronStatusBit13.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit11
        '
        Me.CheckBoxThyratronStatusBit11.AutoCheck = False
        Me.CheckBoxThyratronStatusBit11.AutoSize = True
        Me.CheckBoxThyratronStatusBit11.Location = New System.Drawing.Point(622, 208)
        Me.CheckBoxThyratronStatusBit11.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit11.Name = "CheckBoxThyratronStatusBit11"
        Me.CheckBoxThyratronStatusBit11.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit11.TabIndex = 713
        Me.CheckBoxThyratronStatusBit11.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit12
        '
        Me.CheckBoxThyratronStatusBit12.AutoCheck = False
        Me.CheckBoxThyratronStatusBit12.AutoSize = True
        Me.CheckBoxThyratronStatusBit12.Location = New System.Drawing.Point(622, 222)
        Me.CheckBoxThyratronStatusBit12.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit12.Name = "CheckBoxThyratronStatusBit12"
        Me.CheckBoxThyratronStatusBit12.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit12.TabIndex = 712
        Me.CheckBoxThyratronStatusBit12.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit10
        '
        Me.CheckBoxThyratronStatusBit10.AutoCheck = False
        Me.CheckBoxThyratronStatusBit10.AutoSize = True
        Me.CheckBoxThyratronStatusBit10.Location = New System.Drawing.Point(622, 194)
        Me.CheckBoxThyratronStatusBit10.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit10.Name = "CheckBoxThyratronStatusBit10"
        Me.CheckBoxThyratronStatusBit10.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit10.TabIndex = 711
        Me.CheckBoxThyratronStatusBit10.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(476, 222)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(60, 13)
        Me.Label40.TabIndex = 710
        Me.Label40.Text = "Unused #3"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(476, 208)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(60, 13)
        Me.Label47.TabIndex = 709
        Me.Label47.Text = "Unused #2"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(476, 250)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(60, 13)
        Me.Label48.TabIndex = 708
        Me.Label48.Text = "Unused #5"
        '
        'CheckBoxThyratronFaultBit13
        '
        Me.CheckBoxThyratronFaultBit13.AutoCheck = False
        Me.CheckBoxThyratronFaultBit13.AutoSize = True
        Me.CheckBoxThyratronFaultBit13.Location = New System.Drawing.Point(601, 236)
        Me.CheckBoxThyratronFaultBit13.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit13.Name = "CheckBoxThyratronFaultBit13"
        Me.CheckBoxThyratronFaultBit13.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit13.TabIndex = 707
        Me.CheckBoxThyratronFaultBit13.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit11
        '
        Me.CheckBoxThyratronFaultBit11.AutoCheck = False
        Me.CheckBoxThyratronFaultBit11.AutoSize = True
        Me.CheckBoxThyratronFaultBit11.Location = New System.Drawing.Point(601, 208)
        Me.CheckBoxThyratronFaultBit11.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit11.Name = "CheckBoxThyratronFaultBit11"
        Me.CheckBoxThyratronFaultBit11.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit11.TabIndex = 706
        Me.CheckBoxThyratronFaultBit11.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit12
        '
        Me.CheckBoxThyratronFaultBit12.AutoCheck = False
        Me.CheckBoxThyratronFaultBit12.AutoSize = True
        Me.CheckBoxThyratronFaultBit12.Location = New System.Drawing.Point(601, 222)
        Me.CheckBoxThyratronFaultBit12.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit12.Name = "CheckBoxThyratronFaultBit12"
        Me.CheckBoxThyratronFaultBit12.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit12.TabIndex = 705
        Me.CheckBoxThyratronFaultBit12.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit10
        '
        Me.CheckBoxThyratronFaultBit10.AutoCheck = False
        Me.CheckBoxThyratronFaultBit10.AutoSize = True
        Me.CheckBoxThyratronFaultBit10.Location = New System.Drawing.Point(601, 194)
        Me.CheckBoxThyratronFaultBit10.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit10.Name = "CheckBoxThyratronFaultBit10"
        Me.CheckBoxThyratronFaultBit10.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit10.TabIndex = 704
        Me.CheckBoxThyratronFaultBit10.UseVisualStyleBackColor = True
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(476, 236)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(60, 13)
        Me.Label49.TabIndex = 703
        Me.Label49.Text = "Unused #4"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(476, 194)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(68, 13)
        Me.Label50.TabIndex = 702
        Me.Label50.Text = "False Trigger"
        '
        'CheckBox75
        '
        Me.CheckBox75.AutoCheck = False
        Me.CheckBox75.AutoSize = True
        Me.CheckBox75.Location = New System.Drawing.Point(643, 180)
        Me.CheckBox75.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox75.Name = "CheckBox75"
        Me.CheckBox75.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox75.TabIndex = 701
        Me.CheckBox75.UseVisualStyleBackColor = True
        Me.CheckBox75.Visible = False
        '
        'CheckBoxThyratronStatusBit9
        '
        Me.CheckBoxThyratronStatusBit9.AutoCheck = False
        Me.CheckBoxThyratronStatusBit9.AutoSize = True
        Me.CheckBoxThyratronStatusBit9.Location = New System.Drawing.Point(622, 180)
        Me.CheckBoxThyratronStatusBit9.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit9.Name = "CheckBoxThyratronStatusBit9"
        Me.CheckBoxThyratronStatusBit9.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit9.TabIndex = 700
        Me.CheckBoxThyratronStatusBit9.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit9
        '
        Me.CheckBoxThyratronFaultBit9.AutoCheck = False
        Me.CheckBoxThyratronFaultBit9.AutoSize = True
        Me.CheckBoxThyratronFaultBit9.Location = New System.Drawing.Point(601, 180)
        Me.CheckBoxThyratronFaultBit9.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit9.Name = "CheckBoxThyratronFaultBit9"
        Me.CheckBoxThyratronFaultBit9.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit9.TabIndex = 699
        Me.CheckBoxThyratronFaultBit9.UseVisualStyleBackColor = True
        '
        'CheckBox78
        '
        Me.CheckBox78.AutoCheck = False
        Me.CheckBox78.AutoSize = True
        Me.CheckBox78.Location = New System.Drawing.Point(643, 166)
        Me.CheckBox78.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox78.Name = "CheckBox78"
        Me.CheckBox78.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox78.TabIndex = 698
        Me.CheckBox78.UseVisualStyleBackColor = True
        Me.CheckBox78.Visible = False
        '
        'CheckBox79
        '
        Me.CheckBox79.AutoCheck = False
        Me.CheckBox79.AutoSize = True
        Me.CheckBox79.Location = New System.Drawing.Point(643, 138)
        Me.CheckBox79.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox79.Name = "CheckBox79"
        Me.CheckBox79.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox79.TabIndex = 697
        Me.CheckBox79.UseVisualStyleBackColor = True
        Me.CheckBox79.Visible = False
        '
        'CheckBox80
        '
        Me.CheckBox80.AutoCheck = False
        Me.CheckBox80.AutoSize = True
        Me.CheckBox80.Location = New System.Drawing.Point(643, 152)
        Me.CheckBox80.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox80.Name = "CheckBox80"
        Me.CheckBox80.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox80.TabIndex = 696
        Me.CheckBox80.UseVisualStyleBackColor = True
        Me.CheckBox80.Visible = False
        '
        'CheckBox81
        '
        Me.CheckBox81.AutoCheck = False
        Me.CheckBox81.AutoSize = True
        Me.CheckBox81.Location = New System.Drawing.Point(643, 124)
        Me.CheckBox81.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox81.Name = "CheckBox81"
        Me.CheckBox81.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox81.TabIndex = 695
        Me.CheckBox81.UseVisualStyleBackColor = True
        Me.CheckBox81.Visible = False
        '
        'CheckBoxThyratronStatusBit8
        '
        Me.CheckBoxThyratronStatusBit8.AutoCheck = False
        Me.CheckBoxThyratronStatusBit8.AutoSize = True
        Me.CheckBoxThyratronStatusBit8.Location = New System.Drawing.Point(622, 166)
        Me.CheckBoxThyratronStatusBit8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit8.Name = "CheckBoxThyratronStatusBit8"
        Me.CheckBoxThyratronStatusBit8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit8.TabIndex = 694
        Me.CheckBoxThyratronStatusBit8.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit6
        '
        Me.CheckBoxThyratronStatusBit6.AutoCheck = False
        Me.CheckBoxThyratronStatusBit6.AutoSize = True
        Me.CheckBoxThyratronStatusBit6.Location = New System.Drawing.Point(622, 138)
        Me.CheckBoxThyratronStatusBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit6.Name = "CheckBoxThyratronStatusBit6"
        Me.CheckBoxThyratronStatusBit6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit6.TabIndex = 693
        Me.CheckBoxThyratronStatusBit6.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit7
        '
        Me.CheckBoxThyratronStatusBit7.AutoCheck = False
        Me.CheckBoxThyratronStatusBit7.AutoSize = True
        Me.CheckBoxThyratronStatusBit7.Location = New System.Drawing.Point(622, 152)
        Me.CheckBoxThyratronStatusBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit7.Name = "CheckBoxThyratronStatusBit7"
        Me.CheckBoxThyratronStatusBit7.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit7.TabIndex = 692
        Me.CheckBoxThyratronStatusBit7.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit5
        '
        Me.CheckBoxThyratronStatusBit5.AutoCheck = False
        Me.CheckBoxThyratronStatusBit5.AutoSize = True
        Me.CheckBoxThyratronStatusBit5.Location = New System.Drawing.Point(622, 124)
        Me.CheckBoxThyratronStatusBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit5.Name = "CheckBoxThyratronStatusBit5"
        Me.CheckBoxThyratronStatusBit5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit5.TabIndex = 691
        Me.CheckBoxThyratronStatusBit5.UseVisualStyleBackColor = True
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(476, 152)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(105, 13)
        Me.Label51.TabIndex = 690
        Me.Label51.Text = "Reservoir Under Volt"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(476, 138)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(99, 13)
        Me.Label52.TabIndex = 689
        Me.Label52.Text = "Reservoir Over Volt"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(476, 180)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(107, 13)
        Me.Label53.TabIndex = 688
        Me.Label53.Text = "Reservoir Control Sat"
        '
        'CheckBoxThyratronFaultBit8
        '
        Me.CheckBoxThyratronFaultBit8.AutoCheck = False
        Me.CheckBoxThyratronFaultBit8.AutoSize = True
        Me.CheckBoxThyratronFaultBit8.Location = New System.Drawing.Point(601, 166)
        Me.CheckBoxThyratronFaultBit8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit8.Name = "CheckBoxThyratronFaultBit8"
        Me.CheckBoxThyratronFaultBit8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit8.TabIndex = 687
        Me.CheckBoxThyratronFaultBit8.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit6
        '
        Me.CheckBoxThyratronFaultBit6.AutoCheck = False
        Me.CheckBoxThyratronFaultBit6.AutoSize = True
        Me.CheckBoxThyratronFaultBit6.Location = New System.Drawing.Point(601, 138)
        Me.CheckBoxThyratronFaultBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit6.Name = "CheckBoxThyratronFaultBit6"
        Me.CheckBoxThyratronFaultBit6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit6.TabIndex = 686
        Me.CheckBoxThyratronFaultBit6.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit7
        '
        Me.CheckBoxThyratronFaultBit7.AutoCheck = False
        Me.CheckBoxThyratronFaultBit7.AutoSize = True
        Me.CheckBoxThyratronFaultBit7.Location = New System.Drawing.Point(601, 152)
        Me.CheckBoxThyratronFaultBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit7.Name = "CheckBoxThyratronFaultBit7"
        Me.CheckBoxThyratronFaultBit7.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit7.TabIndex = 685
        Me.CheckBoxThyratronFaultBit7.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit5
        '
        Me.CheckBoxThyratronFaultBit5.AutoCheck = False
        Me.CheckBoxThyratronFaultBit5.AutoSize = True
        Me.CheckBoxThyratronFaultBit5.Location = New System.Drawing.Point(601, 124)
        Me.CheckBoxThyratronFaultBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit5.Name = "CheckBoxThyratronFaultBit5"
        Me.CheckBoxThyratronFaultBit5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit5.TabIndex = 684
        Me.CheckBoxThyratronFaultBit5.UseVisualStyleBackColor = True
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(476, 166)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(105, 13)
        Me.Label54.TabIndex = 683
        Me.Label54.Text = "Reservoir Driver FLT"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(476, 124)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(125, 13)
        Me.Label55.TabIndex = 682
        Me.Label55.Text = "Reservoir Over Volt Hard"
        '
        'CheckBox90
        '
        Me.CheckBox90.AutoCheck = False
        Me.CheckBox90.AutoSize = True
        Me.CheckBox90.Location = New System.Drawing.Point(643, 110)
        Me.CheckBox90.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox90.Name = "CheckBox90"
        Me.CheckBox90.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox90.TabIndex = 681
        Me.CheckBox90.UseVisualStyleBackColor = True
        Me.CheckBox90.Visible = False
        '
        'CheckBoxThyratronStatusBit4
        '
        Me.CheckBoxThyratronStatusBit4.AutoCheck = False
        Me.CheckBoxThyratronStatusBit4.AutoSize = True
        Me.CheckBoxThyratronStatusBit4.Location = New System.Drawing.Point(622, 110)
        Me.CheckBoxThyratronStatusBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit4.Name = "CheckBoxThyratronStatusBit4"
        Me.CheckBoxThyratronStatusBit4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit4.TabIndex = 680
        Me.CheckBoxThyratronStatusBit4.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit4
        '
        Me.CheckBoxThyratronFaultBit4.AutoCheck = False
        Me.CheckBoxThyratronFaultBit4.AutoSize = True
        Me.CheckBoxThyratronFaultBit4.Location = New System.Drawing.Point(601, 110)
        Me.CheckBoxThyratronFaultBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit4.Name = "CheckBoxThyratronFaultBit4"
        Me.CheckBoxThyratronFaultBit4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit4.TabIndex = 679
        Me.CheckBoxThyratronFaultBit4.UseVisualStyleBackColor = True
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(476, 27)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(135, 13)
        Me.Label56.TabIndex = 678
        Me.Label56.Text = "THYRATRON FAUTLS"
        '
        'CheckBox93
        '
        Me.CheckBox93.AutoCheck = False
        Me.CheckBox93.AutoSize = True
        Me.CheckBox93.Location = New System.Drawing.Point(643, 96)
        Me.CheckBox93.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox93.Name = "CheckBox93"
        Me.CheckBox93.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox93.TabIndex = 677
        Me.CheckBox93.UseVisualStyleBackColor = True
        Me.CheckBox93.Visible = False
        '
        'CheckBox94
        '
        Me.CheckBox94.AutoCheck = False
        Me.CheckBox94.AutoSize = True
        Me.CheckBox94.Location = New System.Drawing.Point(643, 68)
        Me.CheckBox94.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox94.Name = "CheckBox94"
        Me.CheckBox94.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox94.TabIndex = 676
        Me.CheckBox94.UseVisualStyleBackColor = True
        Me.CheckBox94.Visible = False
        '
        'CheckBox95
        '
        Me.CheckBox95.AutoCheck = False
        Me.CheckBox95.AutoSize = True
        Me.CheckBox95.Location = New System.Drawing.Point(643, 82)
        Me.CheckBox95.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox95.Name = "CheckBox95"
        Me.CheckBox95.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox95.TabIndex = 675
        Me.CheckBox95.UseVisualStyleBackColor = True
        Me.CheckBox95.Visible = False
        '
        'CheckBox96
        '
        Me.CheckBox96.AutoCheck = False
        Me.CheckBox96.AutoSize = True
        Me.CheckBox96.Location = New System.Drawing.Point(643, 54)
        Me.CheckBox96.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox96.Name = "CheckBox96"
        Me.CheckBox96.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox96.TabIndex = 674
        Me.CheckBox96.UseVisualStyleBackColor = True
        Me.CheckBox96.Visible = False
        '
        'CheckBoxThyratronStatusBit3
        '
        Me.CheckBoxThyratronStatusBit3.AutoCheck = False
        Me.CheckBoxThyratronStatusBit3.AutoSize = True
        Me.CheckBoxThyratronStatusBit3.Location = New System.Drawing.Point(622, 96)
        Me.CheckBoxThyratronStatusBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit3.Name = "CheckBoxThyratronStatusBit3"
        Me.CheckBoxThyratronStatusBit3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit3.TabIndex = 673
        Me.CheckBoxThyratronStatusBit3.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit1
        '
        Me.CheckBoxThyratronStatusBit1.AutoCheck = False
        Me.CheckBoxThyratronStatusBit1.AutoSize = True
        Me.CheckBoxThyratronStatusBit1.Location = New System.Drawing.Point(622, 68)
        Me.CheckBoxThyratronStatusBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit1.Name = "CheckBoxThyratronStatusBit1"
        Me.CheckBoxThyratronStatusBit1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit1.TabIndex = 672
        Me.CheckBoxThyratronStatusBit1.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit2
        '
        Me.CheckBoxThyratronStatusBit2.AutoCheck = False
        Me.CheckBoxThyratronStatusBit2.AutoSize = True
        Me.CheckBoxThyratronStatusBit2.Location = New System.Drawing.Point(622, 82)
        Me.CheckBoxThyratronStatusBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit2.Name = "CheckBoxThyratronStatusBit2"
        Me.CheckBoxThyratronStatusBit2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit2.TabIndex = 671
        Me.CheckBoxThyratronStatusBit2.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronStatusBit0
        '
        Me.CheckBoxThyratronStatusBit0.AutoCheck = False
        Me.CheckBoxThyratronStatusBit0.AutoSize = True
        Me.CheckBoxThyratronStatusBit0.Location = New System.Drawing.Point(622, 54)
        Me.CheckBoxThyratronStatusBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronStatusBit0.Name = "CheckBoxThyratronStatusBit0"
        Me.CheckBoxThyratronStatusBit0.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronStatusBit0.TabIndex = 670
        Me.CheckBoxThyratronStatusBit0.UseVisualStyleBackColor = True
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(476, 82)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(100, 13)
        Me.Label57.TabIndex = 669
        Me.Label57.Text = "Cathode Under Volt"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(476, 68)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(94, 13)
        Me.Label58.TabIndex = 668
        Me.Label58.Text = "Cathode Over Volt"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(476, 110)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(102, 13)
        Me.Label59.TabIndex = 667
        Me.Label59.Text = "Cathode Control Sat"
        '
        'CheckBoxThyratronFaultBit3
        '
        Me.CheckBoxThyratronFaultBit3.AutoCheck = False
        Me.CheckBoxThyratronFaultBit3.AutoSize = True
        Me.CheckBoxThyratronFaultBit3.Location = New System.Drawing.Point(601, 96)
        Me.CheckBoxThyratronFaultBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit3.Name = "CheckBoxThyratronFaultBit3"
        Me.CheckBoxThyratronFaultBit3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit3.TabIndex = 666
        Me.CheckBoxThyratronFaultBit3.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit1
        '
        Me.CheckBoxThyratronFaultBit1.AutoCheck = False
        Me.CheckBoxThyratronFaultBit1.AutoSize = True
        Me.CheckBoxThyratronFaultBit1.Location = New System.Drawing.Point(601, 68)
        Me.CheckBoxThyratronFaultBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit1.Name = "CheckBoxThyratronFaultBit1"
        Me.CheckBoxThyratronFaultBit1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit1.TabIndex = 665
        Me.CheckBoxThyratronFaultBit1.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit2
        '
        Me.CheckBoxThyratronFaultBit2.AutoCheck = False
        Me.CheckBoxThyratronFaultBit2.AutoSize = True
        Me.CheckBoxThyratronFaultBit2.Location = New System.Drawing.Point(601, 82)
        Me.CheckBoxThyratronFaultBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit2.Name = "CheckBoxThyratronFaultBit2"
        Me.CheckBoxThyratronFaultBit2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit2.TabIndex = 664
        Me.CheckBoxThyratronFaultBit2.UseVisualStyleBackColor = True
        '
        'CheckBoxThyratronFaultBit0
        '
        Me.CheckBoxThyratronFaultBit0.AutoCheck = False
        Me.CheckBoxThyratronFaultBit0.AutoSize = True
        Me.CheckBoxThyratronFaultBit0.Location = New System.Drawing.Point(601, 54)
        Me.CheckBoxThyratronFaultBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxThyratronFaultBit0.Name = "CheckBoxThyratronFaultBit0"
        Me.CheckBoxThyratronFaultBit0.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxThyratronFaultBit0.TabIndex = 663
        Me.CheckBoxThyratronFaultBit0.UseVisualStyleBackColor = True
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(476, 96)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(100, 13)
        Me.Label62.TabIndex = 662
        Me.Label62.Text = "Cathode Driver FLT"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(476, 54)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(120, 13)
        Me.Label63.TabIndex = 661
        Me.Label63.Text = "Cathode Over Volt Hard"
        '
        'CheckBox106
        '
        Me.CheckBox106.AutoCheck = False
        Me.CheckBox106.AutoSize = True
        Me.CheckBox106.Location = New System.Drawing.Point(851, 264)
        Me.CheckBox106.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox106.Name = "CheckBox106"
        Me.CheckBox106.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox106.TabIndex = 790
        Me.CheckBox106.UseVisualStyleBackColor = True
        Me.CheckBox106.Visible = False
        '
        'CheckBoxControlBoardStatusBit15
        '
        Me.CheckBoxControlBoardStatusBit15.AutoCheck = False
        Me.CheckBoxControlBoardStatusBit15.AutoSize = True
        Me.CheckBoxControlBoardStatusBit15.Location = New System.Drawing.Point(830, 264)
        Me.CheckBoxControlBoardStatusBit15.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardStatusBit15.Name = "CheckBoxControlBoardStatusBit15"
        Me.CheckBoxControlBoardStatusBit15.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardStatusBit15.TabIndex = 789
        Me.CheckBoxControlBoardStatusBit15.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardFaultBit15
        '
        Me.CheckBoxControlBoardFaultBit15.AutoCheck = False
        Me.CheckBoxControlBoardFaultBit15.AutoSize = True
        Me.CheckBoxControlBoardFaultBit15.Location = New System.Drawing.Point(809, 264)
        Me.CheckBoxControlBoardFaultBit15.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardFaultBit15.Name = "CheckBoxControlBoardFaultBit15"
        Me.CheckBoxControlBoardFaultBit15.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardFaultBit15.TabIndex = 788
        Me.CheckBoxControlBoardFaultBit15.UseVisualStyleBackColor = True
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(684, 264)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(66, 13)
        Me.Label64.TabIndex = 787
        Me.Label64.Text = "Unused #10"
        '
        'CheckBox112
        '
        Me.CheckBox112.AutoCheck = False
        Me.CheckBox112.AutoSize = True
        Me.CheckBox112.Location = New System.Drawing.Point(851, 250)
        Me.CheckBox112.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox112.Name = "CheckBox112"
        Me.CheckBox112.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox112.TabIndex = 786
        Me.CheckBox112.UseVisualStyleBackColor = True
        Me.CheckBox112.Visible = False
        '
        'CheckBoxControlBoardStatusBit14
        '
        Me.CheckBoxControlBoardStatusBit14.AutoCheck = False
        Me.CheckBoxControlBoardStatusBit14.AutoSize = True
        Me.CheckBoxControlBoardStatusBit14.Location = New System.Drawing.Point(830, 250)
        Me.CheckBoxControlBoardStatusBit14.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardStatusBit14.Name = "CheckBoxControlBoardStatusBit14"
        Me.CheckBoxControlBoardStatusBit14.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardStatusBit14.TabIndex = 785
        Me.CheckBoxControlBoardStatusBit14.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardFaultBit14
        '
        Me.CheckBoxControlBoardFaultBit14.AutoCheck = False
        Me.CheckBoxControlBoardFaultBit14.AutoSize = True
        Me.CheckBoxControlBoardFaultBit14.Location = New System.Drawing.Point(809, 250)
        Me.CheckBoxControlBoardFaultBit14.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardFaultBit14.Name = "CheckBoxControlBoardFaultBit14"
        Me.CheckBoxControlBoardFaultBit14.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardFaultBit14.TabIndex = 784
        Me.CheckBoxControlBoardFaultBit14.UseVisualStyleBackColor = True
        '
        'CheckBox118
        '
        Me.CheckBox118.AutoCheck = False
        Me.CheckBox118.AutoSize = True
        Me.CheckBox118.Location = New System.Drawing.Point(851, 236)
        Me.CheckBox118.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox118.Name = "CheckBox118"
        Me.CheckBox118.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox118.TabIndex = 783
        Me.CheckBox118.UseVisualStyleBackColor = True
        Me.CheckBox118.Visible = False
        '
        'CheckBox120
        '
        Me.CheckBox120.AutoCheck = False
        Me.CheckBox120.AutoSize = True
        Me.CheckBox120.Location = New System.Drawing.Point(851, 208)
        Me.CheckBox120.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox120.Name = "CheckBox120"
        Me.CheckBox120.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox120.TabIndex = 782
        Me.CheckBox120.UseVisualStyleBackColor = True
        Me.CheckBox120.Visible = False
        '
        'CheckBox121
        '
        Me.CheckBox121.AutoCheck = False
        Me.CheckBox121.AutoSize = True
        Me.CheckBox121.Location = New System.Drawing.Point(851, 222)
        Me.CheckBox121.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox121.Name = "CheckBox121"
        Me.CheckBox121.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox121.TabIndex = 781
        Me.CheckBox121.UseVisualStyleBackColor = True
        Me.CheckBox121.Visible = False
        '
        'CheckBox122
        '
        Me.CheckBox122.AutoCheck = False
        Me.CheckBox122.AutoSize = True
        Me.CheckBox122.Location = New System.Drawing.Point(851, 194)
        Me.CheckBox122.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox122.Name = "CheckBox122"
        Me.CheckBox122.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox122.TabIndex = 780
        Me.CheckBox122.UseVisualStyleBackColor = True
        Me.CheckBox122.Visible = False
        '
        'CheckBoxControlBoardStatusBit13
        '
        Me.CheckBoxControlBoardStatusBit13.AutoCheck = False
        Me.CheckBoxControlBoardStatusBit13.AutoSize = True
        Me.CheckBoxControlBoardStatusBit13.Location = New System.Drawing.Point(830, 236)
        Me.CheckBoxControlBoardStatusBit13.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardStatusBit13.Name = "CheckBoxControlBoardStatusBit13"
        Me.CheckBoxControlBoardStatusBit13.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardStatusBit13.TabIndex = 779
        Me.CheckBoxControlBoardStatusBit13.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardStatusBit11
        '
        Me.CheckBoxControlBoardStatusBit11.AutoCheck = False
        Me.CheckBoxControlBoardStatusBit11.AutoSize = True
        Me.CheckBoxControlBoardStatusBit11.Location = New System.Drawing.Point(830, 208)
        Me.CheckBoxControlBoardStatusBit11.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardStatusBit11.Name = "CheckBoxControlBoardStatusBit11"
        Me.CheckBoxControlBoardStatusBit11.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardStatusBit11.TabIndex = 778
        Me.CheckBoxControlBoardStatusBit11.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardStatusBit12
        '
        Me.CheckBoxControlBoardStatusBit12.AutoCheck = False
        Me.CheckBoxControlBoardStatusBit12.AutoSize = True
        Me.CheckBoxControlBoardStatusBit12.Location = New System.Drawing.Point(830, 222)
        Me.CheckBoxControlBoardStatusBit12.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardStatusBit12.Name = "CheckBoxControlBoardStatusBit12"
        Me.CheckBoxControlBoardStatusBit12.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardStatusBit12.TabIndex = 777
        Me.CheckBoxControlBoardStatusBit12.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardStatusBit10
        '
        Me.CheckBoxControlBoardStatusBit10.AutoCheck = False
        Me.CheckBoxControlBoardStatusBit10.AutoSize = True
        Me.CheckBoxControlBoardStatusBit10.Location = New System.Drawing.Point(830, 194)
        Me.CheckBoxControlBoardStatusBit10.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardStatusBit10.Name = "CheckBoxControlBoardStatusBit10"
        Me.CheckBoxControlBoardStatusBit10.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardStatusBit10.TabIndex = 776
        Me.CheckBoxControlBoardStatusBit10.UseVisualStyleBackColor = True
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(684, 222)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(60, 13)
        Me.Label69.TabIndex = 775
        Me.Label69.Text = "Unused #7"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(684, 208)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(60, 13)
        Me.Label70.TabIndex = 774
        Me.Label70.Text = "Unused #6"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(684, 250)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(60, 13)
        Me.Label71.TabIndex = 773
        Me.Label71.Text = "Unused #9"
        '
        'CheckBoxControlBoardFaultBit13
        '
        Me.CheckBoxControlBoardFaultBit13.AutoCheck = False
        Me.CheckBoxControlBoardFaultBit13.AutoSize = True
        Me.CheckBoxControlBoardFaultBit13.Location = New System.Drawing.Point(809, 236)
        Me.CheckBoxControlBoardFaultBit13.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardFaultBit13.Name = "CheckBoxControlBoardFaultBit13"
        Me.CheckBoxControlBoardFaultBit13.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardFaultBit13.TabIndex = 772
        Me.CheckBoxControlBoardFaultBit13.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardFaultBit11
        '
        Me.CheckBoxControlBoardFaultBit11.AutoCheck = False
        Me.CheckBoxControlBoardFaultBit11.AutoSize = True
        Me.CheckBoxControlBoardFaultBit11.Location = New System.Drawing.Point(809, 208)
        Me.CheckBoxControlBoardFaultBit11.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardFaultBit11.Name = "CheckBoxControlBoardFaultBit11"
        Me.CheckBoxControlBoardFaultBit11.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardFaultBit11.TabIndex = 771
        Me.CheckBoxControlBoardFaultBit11.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardFaultBit12
        '
        Me.CheckBoxControlBoardFaultBit12.AutoCheck = False
        Me.CheckBoxControlBoardFaultBit12.AutoSize = True
        Me.CheckBoxControlBoardFaultBit12.Location = New System.Drawing.Point(809, 222)
        Me.CheckBoxControlBoardFaultBit12.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardFaultBit12.Name = "CheckBoxControlBoardFaultBit12"
        Me.CheckBoxControlBoardFaultBit12.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardFaultBit12.TabIndex = 770
        Me.CheckBoxControlBoardFaultBit12.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardFaultBit10
        '
        Me.CheckBoxControlBoardFaultBit10.AutoCheck = False
        Me.CheckBoxControlBoardFaultBit10.AutoSize = True
        Me.CheckBoxControlBoardFaultBit10.Location = New System.Drawing.Point(809, 194)
        Me.CheckBoxControlBoardFaultBit10.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardFaultBit10.Name = "CheckBoxControlBoardFaultBit10"
        Me.CheckBoxControlBoardFaultBit10.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardFaultBit10.TabIndex = 769
        Me.CheckBoxControlBoardFaultBit10.UseVisualStyleBackColor = True
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(684, 236)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(60, 13)
        Me.Label72.TabIndex = 768
        Me.Label72.Text = "Unused #8"
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(684, 194)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(60, 13)
        Me.Label73.TabIndex = 767
        Me.Label73.Text = "Unused #5"
        '
        'CheckBox131
        '
        Me.CheckBox131.AutoCheck = False
        Me.CheckBox131.AutoSize = True
        Me.CheckBox131.Location = New System.Drawing.Point(851, 180)
        Me.CheckBox131.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox131.Name = "CheckBox131"
        Me.CheckBox131.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox131.TabIndex = 766
        Me.CheckBox131.UseVisualStyleBackColor = True
        Me.CheckBox131.Visible = False
        '
        'CheckBoxControlBoardStatusBit9
        '
        Me.CheckBoxControlBoardStatusBit9.AutoCheck = False
        Me.CheckBoxControlBoardStatusBit9.AutoSize = True
        Me.CheckBoxControlBoardStatusBit9.Location = New System.Drawing.Point(830, 180)
        Me.CheckBoxControlBoardStatusBit9.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardStatusBit9.Name = "CheckBoxControlBoardStatusBit9"
        Me.CheckBoxControlBoardStatusBit9.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardStatusBit9.TabIndex = 765
        Me.CheckBoxControlBoardStatusBit9.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardFaultBit9
        '
        Me.CheckBoxControlBoardFaultBit9.AutoCheck = False
        Me.CheckBoxControlBoardFaultBit9.AutoSize = True
        Me.CheckBoxControlBoardFaultBit9.Location = New System.Drawing.Point(809, 180)
        Me.CheckBoxControlBoardFaultBit9.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardFaultBit9.Name = "CheckBoxControlBoardFaultBit9"
        Me.CheckBoxControlBoardFaultBit9.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardFaultBit9.TabIndex = 764
        Me.CheckBoxControlBoardFaultBit9.UseVisualStyleBackColor = True
        '
        'CheckBox134
        '
        Me.CheckBox134.AutoCheck = False
        Me.CheckBox134.AutoSize = True
        Me.CheckBox134.Location = New System.Drawing.Point(851, 166)
        Me.CheckBox134.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox134.Name = "CheckBox134"
        Me.CheckBox134.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox134.TabIndex = 763
        Me.CheckBox134.UseVisualStyleBackColor = True
        Me.CheckBox134.Visible = False
        '
        'CheckBox135
        '
        Me.CheckBox135.AutoCheck = False
        Me.CheckBox135.AutoSize = True
        Me.CheckBox135.Location = New System.Drawing.Point(851, 138)
        Me.CheckBox135.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox135.Name = "CheckBox135"
        Me.CheckBox135.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox135.TabIndex = 762
        Me.CheckBox135.UseVisualStyleBackColor = True
        Me.CheckBox135.Visible = False
        '
        'CheckBox136
        '
        Me.CheckBox136.AutoCheck = False
        Me.CheckBox136.AutoSize = True
        Me.CheckBox136.Location = New System.Drawing.Point(851, 152)
        Me.CheckBox136.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox136.Name = "CheckBox136"
        Me.CheckBox136.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox136.TabIndex = 761
        Me.CheckBox136.UseVisualStyleBackColor = True
        Me.CheckBox136.Visible = False
        '
        'CheckBox137
        '
        Me.CheckBox137.AutoCheck = False
        Me.CheckBox137.AutoSize = True
        Me.CheckBox137.Location = New System.Drawing.Point(851, 124)
        Me.CheckBox137.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox137.Name = "CheckBox137"
        Me.CheckBox137.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox137.TabIndex = 760
        Me.CheckBox137.UseVisualStyleBackColor = True
        Me.CheckBox137.Visible = False
        '
        'CheckBoxControlBoardStatusBit8
        '
        Me.CheckBoxControlBoardStatusBit8.AutoCheck = False
        Me.CheckBoxControlBoardStatusBit8.AutoSize = True
        Me.CheckBoxControlBoardStatusBit8.Location = New System.Drawing.Point(830, 166)
        Me.CheckBoxControlBoardStatusBit8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardStatusBit8.Name = "CheckBoxControlBoardStatusBit8"
        Me.CheckBoxControlBoardStatusBit8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardStatusBit8.TabIndex = 759
        Me.CheckBoxControlBoardStatusBit8.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardStatusBit6
        '
        Me.CheckBoxControlBoardStatusBit6.AutoCheck = False
        Me.CheckBoxControlBoardStatusBit6.AutoSize = True
        Me.CheckBoxControlBoardStatusBit6.Location = New System.Drawing.Point(830, 138)
        Me.CheckBoxControlBoardStatusBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardStatusBit6.Name = "CheckBoxControlBoardStatusBit6"
        Me.CheckBoxControlBoardStatusBit6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardStatusBit6.TabIndex = 758
        Me.CheckBoxControlBoardStatusBit6.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardStatusBit7
        '
        Me.CheckBoxControlBoardStatusBit7.AutoCheck = False
        Me.CheckBoxControlBoardStatusBit7.AutoSize = True
        Me.CheckBoxControlBoardStatusBit7.Location = New System.Drawing.Point(830, 152)
        Me.CheckBoxControlBoardStatusBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardStatusBit7.Name = "CheckBoxControlBoardStatusBit7"
        Me.CheckBoxControlBoardStatusBit7.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardStatusBit7.TabIndex = 757
        Me.CheckBoxControlBoardStatusBit7.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardStatusBit5
        '
        Me.CheckBoxControlBoardStatusBit5.AutoCheck = False
        Me.CheckBoxControlBoardStatusBit5.AutoSize = True
        Me.CheckBoxControlBoardStatusBit5.Location = New System.Drawing.Point(830, 124)
        Me.CheckBoxControlBoardStatusBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardStatusBit5.Name = "CheckBoxControlBoardStatusBit5"
        Me.CheckBoxControlBoardStatusBit5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardStatusBit5.TabIndex = 756
        Me.CheckBoxControlBoardStatusBit5.UseVisualStyleBackColor = True
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(684, 152)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(60, 13)
        Me.Label74.TabIndex = 755
        Me.Label74.Text = "Unused #2"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(684, 138)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(60, 13)
        Me.Label75.TabIndex = 754
        Me.Label75.Text = "Unused #1"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(684, 180)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(60, 13)
        Me.Label76.TabIndex = 753
        Me.Label76.Text = "Unused #4"
        '
        'CheckBoxControlBoardFaultBit8
        '
        Me.CheckBoxControlBoardFaultBit8.AutoCheck = False
        Me.CheckBoxControlBoardFaultBit8.AutoSize = True
        Me.CheckBoxControlBoardFaultBit8.Location = New System.Drawing.Point(809, 166)
        Me.CheckBoxControlBoardFaultBit8.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardFaultBit8.Name = "CheckBoxControlBoardFaultBit8"
        Me.CheckBoxControlBoardFaultBit8.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardFaultBit8.TabIndex = 752
        Me.CheckBoxControlBoardFaultBit8.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardFaultBit6
        '
        Me.CheckBoxControlBoardFaultBit6.AutoCheck = False
        Me.CheckBoxControlBoardFaultBit6.AutoSize = True
        Me.CheckBoxControlBoardFaultBit6.Location = New System.Drawing.Point(809, 138)
        Me.CheckBoxControlBoardFaultBit6.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardFaultBit6.Name = "CheckBoxControlBoardFaultBit6"
        Me.CheckBoxControlBoardFaultBit6.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardFaultBit6.TabIndex = 751
        Me.CheckBoxControlBoardFaultBit6.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardFaultBit7
        '
        Me.CheckBoxControlBoardFaultBit7.AutoCheck = False
        Me.CheckBoxControlBoardFaultBit7.AutoSize = True
        Me.CheckBoxControlBoardFaultBit7.Location = New System.Drawing.Point(809, 152)
        Me.CheckBoxControlBoardFaultBit7.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardFaultBit7.Name = "CheckBoxControlBoardFaultBit7"
        Me.CheckBoxControlBoardFaultBit7.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardFaultBit7.TabIndex = 750
        Me.CheckBoxControlBoardFaultBit7.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardFaultBit5
        '
        Me.CheckBoxControlBoardFaultBit5.AutoCheck = False
        Me.CheckBoxControlBoardFaultBit5.AutoSize = True
        Me.CheckBoxControlBoardFaultBit5.Location = New System.Drawing.Point(809, 124)
        Me.CheckBoxControlBoardFaultBit5.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardFaultBit5.Name = "CheckBoxControlBoardFaultBit5"
        Me.CheckBoxControlBoardFaultBit5.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardFaultBit5.TabIndex = 749
        Me.CheckBoxControlBoardFaultBit5.UseVisualStyleBackColor = True
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(684, 166)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(60, 13)
        Me.Label77.TabIndex = 748
        Me.Label77.Text = "Unused #3"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(684, 124)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(76, 13)
        Me.Label78.TabIndex = 747
        Me.Label78.Text = "SPI Fatal Fault"
        '
        'CheckBox146
        '
        Me.CheckBox146.AutoCheck = False
        Me.CheckBox146.AutoSize = True
        Me.CheckBox146.Location = New System.Drawing.Point(851, 110)
        Me.CheckBox146.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox146.Name = "CheckBox146"
        Me.CheckBox146.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox146.TabIndex = 746
        Me.CheckBox146.UseVisualStyleBackColor = True
        Me.CheckBox146.Visible = False
        '
        'CheckBoxControlBoardStatusBit4
        '
        Me.CheckBoxControlBoardStatusBit4.AutoCheck = False
        Me.CheckBoxControlBoardStatusBit4.AutoSize = True
        Me.CheckBoxControlBoardStatusBit4.Location = New System.Drawing.Point(830, 110)
        Me.CheckBoxControlBoardStatusBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardStatusBit4.Name = "CheckBoxControlBoardStatusBit4"
        Me.CheckBoxControlBoardStatusBit4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardStatusBit4.TabIndex = 745
        Me.CheckBoxControlBoardStatusBit4.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardFaultBit4
        '
        Me.CheckBoxControlBoardFaultBit4.AutoCheck = False
        Me.CheckBoxControlBoardFaultBit4.AutoSize = True
        Me.CheckBoxControlBoardFaultBit4.Location = New System.Drawing.Point(809, 110)
        Me.CheckBoxControlBoardFaultBit4.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardFaultBit4.Name = "CheckBoxControlBoardFaultBit4"
        Me.CheckBoxControlBoardFaultBit4.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardFaultBit4.TabIndex = 744
        Me.CheckBoxControlBoardFaultBit4.UseVisualStyleBackColor = True
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(684, 27)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(164, 13)
        Me.Label79.TabIndex = 743
        Me.Label79.Text = "CONTROL BOARD FAULTS"
        '
        'CheckBox149
        '
        Me.CheckBox149.AutoCheck = False
        Me.CheckBox149.AutoSize = True
        Me.CheckBox149.Location = New System.Drawing.Point(851, 96)
        Me.CheckBox149.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox149.Name = "CheckBox149"
        Me.CheckBox149.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox149.TabIndex = 742
        Me.CheckBox149.UseVisualStyleBackColor = True
        Me.CheckBox149.Visible = False
        '
        'CheckBox150
        '
        Me.CheckBox150.AutoCheck = False
        Me.CheckBox150.AutoSize = True
        Me.CheckBox150.Location = New System.Drawing.Point(851, 68)
        Me.CheckBox150.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox150.Name = "CheckBox150"
        Me.CheckBox150.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox150.TabIndex = 741
        Me.CheckBox150.UseVisualStyleBackColor = True
        Me.CheckBox150.Visible = False
        '
        'CheckBox151
        '
        Me.CheckBox151.AutoCheck = False
        Me.CheckBox151.AutoSize = True
        Me.CheckBox151.Location = New System.Drawing.Point(851, 82)
        Me.CheckBox151.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox151.Name = "CheckBox151"
        Me.CheckBox151.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox151.TabIndex = 740
        Me.CheckBox151.UseVisualStyleBackColor = True
        Me.CheckBox151.Visible = False
        '
        'CheckBox152
        '
        Me.CheckBox152.AutoCheck = False
        Me.CheckBox152.AutoSize = True
        Me.CheckBox152.Location = New System.Drawing.Point(851, 54)
        Me.CheckBox152.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBox152.Name = "CheckBox152"
        Me.CheckBox152.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox152.TabIndex = 739
        Me.CheckBox152.UseVisualStyleBackColor = True
        Me.CheckBox152.Visible = False
        '
        'CheckBoxControlBoardStatusBit3
        '
        Me.CheckBoxControlBoardStatusBit3.AutoCheck = False
        Me.CheckBoxControlBoardStatusBit3.AutoSize = True
        Me.CheckBoxControlBoardStatusBit3.Location = New System.Drawing.Point(830, 96)
        Me.CheckBoxControlBoardStatusBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardStatusBit3.Name = "CheckBoxControlBoardStatusBit3"
        Me.CheckBoxControlBoardStatusBit3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardStatusBit3.TabIndex = 738
        Me.CheckBoxControlBoardStatusBit3.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardStatusBit1
        '
        Me.CheckBoxControlBoardStatusBit1.AutoCheck = False
        Me.CheckBoxControlBoardStatusBit1.AutoSize = True
        Me.CheckBoxControlBoardStatusBit1.Location = New System.Drawing.Point(830, 68)
        Me.CheckBoxControlBoardStatusBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardStatusBit1.Name = "CheckBoxControlBoardStatusBit1"
        Me.CheckBoxControlBoardStatusBit1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardStatusBit1.TabIndex = 737
        Me.CheckBoxControlBoardStatusBit1.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardStatusBit2
        '
        Me.CheckBoxControlBoardStatusBit2.AutoCheck = False
        Me.CheckBoxControlBoardStatusBit2.AutoSize = True
        Me.CheckBoxControlBoardStatusBit2.Location = New System.Drawing.Point(830, 82)
        Me.CheckBoxControlBoardStatusBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardStatusBit2.Name = "CheckBoxControlBoardStatusBit2"
        Me.CheckBoxControlBoardStatusBit2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardStatusBit2.TabIndex = 736
        Me.CheckBoxControlBoardStatusBit2.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardStatusBit0
        '
        Me.CheckBoxControlBoardStatusBit0.AutoCheck = False
        Me.CheckBoxControlBoardStatusBit0.AutoSize = True
        Me.CheckBoxControlBoardStatusBit0.Location = New System.Drawing.Point(830, 54)
        Me.CheckBoxControlBoardStatusBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardStatusBit0.Name = "CheckBoxControlBoardStatusBit0"
        Me.CheckBoxControlBoardStatusBit0.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardStatusBit0.TabIndex = 735
        Me.CheckBoxControlBoardStatusBit0.UseVisualStyleBackColor = True
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(684, 82)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(70, 13)
        Me.Label80.TabIndex = 734
        Me.Label80.Text = "SF6 Interlock"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Location = New System.Drawing.Point(684, 68)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(105, 13)
        Me.Label81.TabIndex = 733
        Me.Label81.Text = "Water Flow Interlock"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Location = New System.Drawing.Point(684, 110)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(64, 13)
        Me.Label82.TabIndex = 732
        Me.Label82.Text = "Interlock #4"
        '
        'CheckBoxControlBoardFaultBit3
        '
        Me.CheckBoxControlBoardFaultBit3.AutoCheck = False
        Me.CheckBoxControlBoardFaultBit3.AutoSize = True
        Me.CheckBoxControlBoardFaultBit3.Location = New System.Drawing.Point(809, 96)
        Me.CheckBoxControlBoardFaultBit3.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardFaultBit3.Name = "CheckBoxControlBoardFaultBit3"
        Me.CheckBoxControlBoardFaultBit3.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardFaultBit3.TabIndex = 731
        Me.CheckBoxControlBoardFaultBit3.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardFaultBit1
        '
        Me.CheckBoxControlBoardFaultBit1.AutoCheck = False
        Me.CheckBoxControlBoardFaultBit1.AutoSize = True
        Me.CheckBoxControlBoardFaultBit1.Location = New System.Drawing.Point(809, 68)
        Me.CheckBoxControlBoardFaultBit1.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardFaultBit1.Name = "CheckBoxControlBoardFaultBit1"
        Me.CheckBoxControlBoardFaultBit1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardFaultBit1.TabIndex = 730
        Me.CheckBoxControlBoardFaultBit1.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardFaultBit2
        '
        Me.CheckBoxControlBoardFaultBit2.AutoCheck = False
        Me.CheckBoxControlBoardFaultBit2.AutoSize = True
        Me.CheckBoxControlBoardFaultBit2.Location = New System.Drawing.Point(809, 82)
        Me.CheckBoxControlBoardFaultBit2.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardFaultBit2.Name = "CheckBoxControlBoardFaultBit2"
        Me.CheckBoxControlBoardFaultBit2.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardFaultBit2.TabIndex = 729
        Me.CheckBoxControlBoardFaultBit2.UseVisualStyleBackColor = True
        '
        'CheckBoxControlBoardFaultBit0
        '
        Me.CheckBoxControlBoardFaultBit0.AutoCheck = False
        Me.CheckBoxControlBoardFaultBit0.AutoSize = True
        Me.CheckBoxControlBoardFaultBit0.Location = New System.Drawing.Point(809, 54)
        Me.CheckBoxControlBoardFaultBit0.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxControlBoardFaultBit0.Name = "CheckBoxControlBoardFaultBit0"
        Me.CheckBoxControlBoardFaultBit0.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxControlBoardFaultBit0.TabIndex = 728
        Me.CheckBoxControlBoardFaultBit0.UseVisualStyleBackColor = True
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Location = New System.Drawing.Point(684, 96)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(103, 13)
        Me.Label83.TabIndex = 727
        Me.Label83.Text = "Thyratron Temp SW"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Location = New System.Drawing.Point(684, 54)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(110, 13)
        Me.Label84.TabIndex = 726
        Me.Label84.Text = "Lambda Not Powered"
        '
        'LabelLambdaVmon
        '
        Me.LabelLambdaVmon.AutoSize = True
        Me.LabelLambdaVmon.Location = New System.Drawing.Point(363, 374)
        Me.LabelLambdaVmon.Name = "LabelLambdaVmon"
        Me.LabelLambdaVmon.Size = New System.Drawing.Size(10, 13)
        Me.LabelLambdaVmon.TabIndex = 792
        Me.LabelLambdaVmon.Text = "-"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Location = New System.Drawing.Point(228, 374)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(118, 13)
        Me.Label86.TabIndex = 791
        Me.Label86.Text = "Lambda Vmon Reading"
        '
        'LabelADCFalseTrigger
        '
        Me.LabelADCFalseTrigger.AutoSize = True
        Me.LabelADCFalseTrigger.Location = New System.Drawing.Point(1038, 382)
        Me.LabelADCFalseTrigger.Name = "LabelADCFalseTrigger"
        Me.LabelADCFalseTrigger.Size = New System.Drawing.Size(10, 13)
        Me.LabelADCFalseTrigger.TabIndex = 802
        Me.LabelADCFalseTrigger.Text = "-"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Location = New System.Drawing.Point(903, 382)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(93, 13)
        Me.Label89.TabIndex = 801
        Me.Label89.Text = "ADC False Trigger"
        '
        'LabelSPI1BusError
        '
        Me.LabelSPI1BusError.AutoSize = True
        Me.LabelSPI1BusError.Location = New System.Drawing.Point(1038, 356)
        Me.LabelSPI1BusError.Name = "LabelSPI1BusError"
        Me.LabelSPI1BusError.Size = New System.Drawing.Size(10, 13)
        Me.LabelSPI1BusError.TabIndex = 800
        Me.LabelSPI1BusError.Text = "-"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Location = New System.Drawing.Point(903, 356)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(81, 13)
        Me.Label91.TabIndex = 799
        Me.Label91.Text = "SPI1 Bus Errors"
        '
        'LabelI2CBusError
        '
        Me.LabelI2CBusError.AutoSize = True
        Me.LabelI2CBusError.Location = New System.Drawing.Point(1038, 343)
        Me.LabelI2CBusError.Name = "LabelI2CBusError"
        Me.LabelI2CBusError.Size = New System.Drawing.Size(10, 13)
        Me.LabelI2CBusError.TabIndex = 798
        Me.LabelI2CBusError.Text = "-"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Location = New System.Drawing.Point(903, 343)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(74, 13)
        Me.Label95.TabIndex = 797
        Me.Label95.Text = "I2C Bus Errors"
        '
        'LabelMagnetronVoltageGlitch
        '
        Me.LabelMagnetronVoltageGlitch.AutoSize = True
        Me.LabelMagnetronVoltageGlitch.Location = New System.Drawing.Point(1038, 330)
        Me.LabelMagnetronVoltageGlitch.Name = "LabelMagnetronVoltageGlitch"
        Me.LabelMagnetronVoltageGlitch.Size = New System.Drawing.Size(10, 13)
        Me.LabelMagnetronVoltageGlitch.TabIndex = 796
        Me.LabelMagnetronVoltageGlitch.Text = "-"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Location = New System.Drawing.Point(903, 330)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(125, 13)
        Me.Label99.TabIndex = 795
        Me.Label99.Text = "Magnetron Voltage glitch"
        '
        'LabelMagnetronCurrentGlitch
        '
        Me.LabelMagnetronCurrentGlitch.AutoSize = True
        Me.LabelMagnetronCurrentGlitch.Location = New System.Drawing.Point(1038, 317)
        Me.LabelMagnetronCurrentGlitch.Name = "LabelMagnetronCurrentGlitch"
        Me.LabelMagnetronCurrentGlitch.Size = New System.Drawing.Size(10, 13)
        Me.LabelMagnetronCurrentGlitch.TabIndex = 794
        Me.LabelMagnetronCurrentGlitch.Text = "-"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Location = New System.Drawing.Point(903, 317)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(125, 13)
        Me.Label101.TabIndex = 793
        Me.Label101.Text = "Magnetron Current Glitch"
        '
        'LabelReverseScale16BitSaturation
        '
        Me.LabelReverseScale16BitSaturation.AutoSize = True
        Me.LabelReverseScale16BitSaturation.Location = New System.Drawing.Point(1038, 434)
        Me.LabelReverseScale16BitSaturation.Name = "LabelReverseScale16BitSaturation"
        Me.LabelReverseScale16BitSaturation.Size = New System.Drawing.Size(10, 13)
        Me.LabelReverseScale16BitSaturation.TabIndex = 810
        Me.LabelReverseScale16BitSaturation.Text = "-"
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.Location = New System.Drawing.Point(903, 434)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(126, 13)
        Me.Label108.TabIndex = 809
        Me.Label108.Text = "16 Bit Reverse Sat Errors"
        '
        'LabelScale16BitSaturation
        '
        Me.LabelScale16BitSaturation.AutoSize = True
        Me.LabelScale16BitSaturation.Location = New System.Drawing.Point(1038, 421)
        Me.LabelScale16BitSaturation.Name = "LabelScale16BitSaturation"
        Me.LabelScale16BitSaturation.Size = New System.Drawing.Size(10, 13)
        Me.LabelScale16BitSaturation.TabIndex = 808
        Me.LabelScale16BitSaturation.Text = "-"
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Location = New System.Drawing.Point(903, 421)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(83, 13)
        Me.Label119.TabIndex = 807
        Me.Label119.Text = "16 Bit Sat Errors"
        '
        'LabelInvalidSetPoint
        '
        Me.LabelInvalidSetPoint.AutoSize = True
        Me.LabelInvalidSetPoint.Location = New System.Drawing.Point(1038, 408)
        Me.LabelInvalidSetPoint.Name = "LabelInvalidSetPoint"
        Me.LabelInvalidSetPoint.Size = New System.Drawing.Size(10, 13)
        Me.LabelInvalidSetPoint.TabIndex = 806
        Me.LabelInvalidSetPoint.Text = "-"
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Location = New System.Drawing.Point(903, 408)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(80, 13)
        Me.Label123.TabIndex = 805
        Me.Label123.Text = "Invalid Setpoint"
        '
        'LabelLTC2656WriteError
        '
        Me.LabelLTC2656WriteError.AutoSize = True
        Me.LabelLTC2656WriteError.Location = New System.Drawing.Point(1038, 395)
        Me.LabelLTC2656WriteError.Name = "LabelLTC2656WriteError"
        Me.LabelLTC2656WriteError.Size = New System.Drawing.Size(10, 13)
        Me.LabelLTC2656WriteError.TabIndex = 804
        Me.LabelLTC2656WriteError.Text = "-"
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.Location = New System.Drawing.Point(903, 395)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(109, 13)
        Me.Label126.TabIndex = 803
        Me.Label126.Text = "LTC2656 Write Errors"
        '
        'LabelSPI2BusError
        '
        Me.LabelSPI2BusError.AutoSize = True
        Me.LabelSPI2BusError.Location = New System.Drawing.Point(1038, 369)
        Me.LabelSPI2BusError.Name = "LabelSPI2BusError"
        Me.LabelSPI2BusError.Size = New System.Drawing.Size(10, 13)
        Me.LabelSPI2BusError.TabIndex = 812
        Me.LabelSPI2BusError.Text = "-"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(903, 369)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(76, 13)
        Me.Label87.TabIndex = 811
        Me.Label87.Text = "SPI2 Bus Error"
        '
        'CheckBoxIOExpanderError
        '
        Me.CheckBoxIOExpanderError.AutoCheck = False
        Me.CheckBoxIOExpanderError.AutoSize = True
        Me.CheckBoxIOExpanderError.Location = New System.Drawing.Point(1124, 635)
        Me.CheckBoxIOExpanderError.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxIOExpanderError.Name = "CheckBoxIOExpanderError"
        Me.CheckBoxIOExpanderError.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxIOExpanderError.TabIndex = 831
        Me.CheckBoxIOExpanderError.UseVisualStyleBackColor = True
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Location = New System.Drawing.Point(903, 622)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(93, 13)
        Me.Label129.TabIndex = 821
        Me.Label129.Text = "Watch Dog Reset"
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Location = New System.Drawing.Point(903, 608)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(75, 13)
        Me.Label130.TabIndex = 820
        Me.Label130.Text = "TRAPR Reset"
        '
        'Label131
        '
        Me.Label131.AutoSize = True
        Me.Label131.Location = New System.Drawing.Point(1033, 635)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(91, 13)
        Me.Label131.TabIndex = 819
        Me.Label131.Text = "IO Expander Error"
        '
        'CheckBoxIOPUWR
        '
        Me.CheckBoxIOPUWR.AutoCheck = False
        Me.CheckBoxIOPUWR.AutoSize = True
        Me.CheckBoxIOPUWR.Location = New System.Drawing.Point(1006, 635)
        Me.CheckBoxIOPUWR.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxIOPUWR.Name = "CheckBoxIOPUWR"
        Me.CheckBoxIOPUWR.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxIOPUWR.TabIndex = 818
        Me.CheckBoxIOPUWR.UseVisualStyleBackColor = True
        '
        'CheckBoxTRAPR
        '
        Me.CheckBoxTRAPR.AutoCheck = False
        Me.CheckBoxTRAPR.AutoSize = True
        Me.CheckBoxTRAPR.Location = New System.Drawing.Point(1006, 607)
        Me.CheckBoxTRAPR.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxTRAPR.Name = "CheckBoxTRAPR"
        Me.CheckBoxTRAPR.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxTRAPR.TabIndex = 817
        Me.CheckBoxTRAPR.UseVisualStyleBackColor = True
        '
        'CheckBoxWDT
        '
        Me.CheckBoxWDT.AutoCheck = False
        Me.CheckBoxWDT.AutoSize = True
        Me.CheckBoxWDT.Location = New System.Drawing.Point(1006, 621)
        Me.CheckBoxWDT.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxWDT.Name = "CheckBoxWDT"
        Me.CheckBoxWDT.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxWDT.TabIndex = 816
        Me.CheckBoxWDT.UseVisualStyleBackColor = True
        '
        'CheckBoxBOR
        '
        Me.CheckBoxBOR.AutoCheck = False
        Me.CheckBoxBOR.AutoSize = True
        Me.CheckBoxBOR.Location = New System.Drawing.Point(1006, 593)
        Me.CheckBoxBOR.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxBOR.Name = "CheckBoxBOR"
        Me.CheckBoxBOR.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxBOR.TabIndex = 815
        Me.CheckBoxBOR.UseVisualStyleBackColor = True
        '
        'Label132
        '
        Me.Label132.AutoSize = True
        Me.Label132.Location = New System.Drawing.Point(903, 636)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(83, 13)
        Me.Label132.TabIndex = 814
        Me.Label132.Text = "IOPUWR Reset"
        '
        'Label133
        '
        Me.Label133.AutoSize = True
        Me.Label133.Location = New System.Drawing.Point(903, 594)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(88, 13)
        Me.Label133.TabIndex = 813
        Me.Label133.Text = "Brown Out Reset"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1025, 558)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 23)
        Me.Button1.TabIndex = 832
        Me.Button1.Text = "Clear Reset Data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Location = New System.Drawing.Point(1033, 607)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(76, 13)
        Me.Label85.TabIndex = 838
        Me.Label85.Text = "External Reset"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Location = New System.Drawing.Point(1033, 593)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(85, 13)
        Me.Label88.TabIndex = 837
        Me.Label88.Text = "Power On Reset"
        '
        'CheckBoxSWReset
        '
        Me.CheckBoxSWReset.AutoCheck = False
        Me.CheckBoxSWReset.AutoSize = True
        Me.CheckBoxSWReset.Location = New System.Drawing.Point(1124, 621)
        Me.CheckBoxSWReset.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxSWReset.Name = "CheckBoxSWReset"
        Me.CheckBoxSWReset.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxSWReset.TabIndex = 836
        Me.CheckBoxSWReset.UseVisualStyleBackColor = True
        '
        'CheckBoxPOR
        '
        Me.CheckBoxPOR.AutoCheck = False
        Me.CheckBoxPOR.AutoSize = True
        Me.CheckBoxPOR.Location = New System.Drawing.Point(1124, 593)
        Me.CheckBoxPOR.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxPOR.Name = "CheckBoxPOR"
        Me.CheckBoxPOR.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxPOR.TabIndex = 835
        Me.CheckBoxPOR.UseVisualStyleBackColor = True
        '
        'CheckBoxExtReset
        '
        Me.CheckBoxExtReset.AutoCheck = False
        Me.CheckBoxExtReset.AutoSize = True
        Me.CheckBoxExtReset.Location = New System.Drawing.Point(1124, 607)
        Me.CheckBoxExtReset.Margin = New System.Windows.Forms.Padding(0)
        Me.CheckBoxExtReset.Name = "CheckBoxExtReset"
        Me.CheckBoxExtReset.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxExtReset.TabIndex = 834
        Me.CheckBoxExtReset.UseVisualStyleBackColor = True
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Location = New System.Drawing.Point(1033, 621)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(80, 13)
        Me.Label90.TabIndex = 833
        Me.Label90.Text = "Software Reset"
        '
        'ButtonReadState
        '
        Me.ButtonReadState.Location = New System.Drawing.Point(8, 27)
        Me.ButtonReadState.Name = "ButtonReadState"
        Me.ButtonReadState.Size = New System.Drawing.Size(91, 23)
        Me.ButtonReadState.TabIndex = 839
        Me.ButtonReadState.Text = "Read State"
        Me.ButtonReadState.UseVisualStyleBackColor = True
        '
        'ButtonSetBaudRate
        '
        Me.ButtonSetBaudRate.Location = New System.Drawing.Point(379, 689)
        Me.ButtonSetBaudRate.Name = "ButtonSetBaudRate"
        Me.ButtonSetBaudRate.Size = New System.Drawing.Size(114, 23)
        Me.ButtonSetBaudRate.TabIndex = 841
        Me.ButtonSetBaudRate.Text = "Set Baud Rate"
        Me.ButtonSetBaudRate.UseVisualStyleBackColor = True
        '
        'TextBoxBaudRate
        '
        Me.TextBoxBaudRate.Location = New System.Drawing.Point(302, 691)
        Me.TextBoxBaudRate.Name = "TextBoxBaudRate"
        Me.TextBoxBaudRate.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxBaudRate.TabIndex = 840
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.LocalRemoteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1154, 24)
        Me.MenuStrip1.TabIndex = 843
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalibrationDataToolStripMenuItem, Me.MagnetSupplyCalibrationToolStripMenuItem, Me.ETMOverrideModeToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(77, 20)
        Me.ToolStripMenuItem1.Text = "Calibration"
        '
        'CalibrationDataToolStripMenuItem
        '
        Me.CalibrationDataToolStripMenuItem.Name = "CalibrationDataToolStripMenuItem"
        Me.CalibrationDataToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.CalibrationDataToolStripMenuItem.Text = "Magnet Current Scaling"
        '
        'MagnetSupplyCalibrationToolStripMenuItem
        '
        Me.MagnetSupplyCalibrationToolStripMenuItem.Name = "MagnetSupplyCalibrationToolStripMenuItem"
        Me.MagnetSupplyCalibrationToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.MagnetSupplyCalibrationToolStripMenuItem.Text = "Calibration Factors"
        '
        'ETMOverrideModeToolStripMenuItem
        '
        Me.ETMOverrideModeToolStripMenuItem.Name = "ETMOverrideModeToolStripMenuItem"
        Me.ETMOverrideModeToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ETMOverrideModeToolStripMenuItem.Text = "ETM Override Mode"
        '
        'LocalRemoteToolStripMenuItem
        '
        Me.LocalRemoteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoteMagnetCurrentToolStripMenuItem, Me.LocalMagnetCurrentToolStripMenuItem, Me.FilamentCurrentControlModeToolStripMenuItem})
        Me.LocalRemoteToolStripMenuItem.Name = "LocalRemoteToolStripMenuItem"
        Me.LocalRemoteToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.LocalRemoteToolStripMenuItem.Text = "Local/Remote"
        '
        'RemoteMagnetCurrentToolStripMenuItem
        '
        Me.RemoteMagnetCurrentToolStripMenuItem.Name = "RemoteMagnetCurrentToolStripMenuItem"
        Me.RemoteMagnetCurrentToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.RemoteMagnetCurrentToolStripMenuItem.Text = "Mode A Sets Magnet Current"
        '
        'LocalMagnetCurrentToolStripMenuItem
        '
        Me.LocalMagnetCurrentToolStripMenuItem.Name = "LocalMagnetCurrentToolStripMenuItem"
        Me.LocalMagnetCurrentToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.LocalMagnetCurrentToolStripMenuItem.Text = "GUI Sets Magnet Current"
        '
        'FilamentCurrentControlModeToolStripMenuItem
        '
        Me.FilamentCurrentControlModeToolStripMenuItem.Name = "FilamentCurrentControlModeToolStripMenuItem"
        Me.FilamentCurrentControlModeToolStripMenuItem.Size = New System.Drawing.Size(237, 22)
        Me.FilamentCurrentControlModeToolStripMenuItem.Text = "Toggle Filament Control Mode"
        '
        'LabelGUIVersion
        '
        Me.LabelGUIVersion.AutoSize = True
        Me.LabelGUIVersion.Location = New System.Drawing.Point(9, 649)
        Me.LabelGUIVersion.Name = "LabelGUIVersion"
        Me.LabelGUIVersion.Size = New System.Drawing.Size(45, 13)
        Me.LabelGUIVersion.TabIndex = 844
        Me.LabelGUIVersion.Text = "Label92"
        '
        'LabelMCUVersion
        '
        Me.LabelMCUVersion.AutoSize = True
        Me.LabelMCUVersion.Location = New System.Drawing.Point(9, 628)
        Me.LabelMCUVersion.Name = "LabelMCUVersion"
        Me.LabelMCUVersion.Size = New System.Drawing.Size(45, 13)
        Me.LabelMCUVersion.TabIndex = 848
        Me.LabelMCUVersion.Text = "Label97"
        '
        'LabelMagnetControlStatus
        '
        Me.LabelMagnetControlStatus.AutoSize = True
        Me.LabelMagnetControlStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMagnetControlStatus.Location = New System.Drawing.Point(6, 527)
        Me.LabelMagnetControlStatus.Name = "LabelMagnetControlStatus"
        Me.LabelMagnetControlStatus.Size = New System.Drawing.Size(61, 13)
        Me.LabelMagnetControlStatus.TabIndex = 852
        Me.LabelMagnetControlStatus.Text = "UnKnown"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(502, 354)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 23)
        Me.Button2.TabIndex = 853
        Me.Button2.Text = "Software Reset"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'ButtonSkipWarmup
        '
        Me.ButtonSkipWarmup.Location = New System.Drawing.Point(687, 561)
        Me.ButtonSkipWarmup.Name = "ButtonSkipWarmup"
        Me.ButtonSkipWarmup.Size = New System.Drawing.Size(93, 23)
        Me.ButtonSkipWarmup.TabIndex = 854
        Me.ButtonSkipWarmup.Text = "Skip Warmup"
        Me.ButtonSkipWarmup.UseVisualStyleBackColor = True
        Me.ButtonSkipWarmup.Visible = False
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(903, 290)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(83, 13)
        Me.Label92.TabIndex = 855
        Me.Label92.Text = "DEBUG INFO"
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(903, 563)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(100, 13)
        Me.Label97.TabIndex = 856
        Me.Label97.Text = "uP RESET INFO"
        '
        'LabelInt1TimingError
        '
        Me.LabelInt1TimingError.AutoSize = True
        Me.LabelInt1TimingError.Location = New System.Drawing.Point(1038, 447)
        Me.LabelInt1TimingError.Name = "LabelInt1TimingError"
        Me.LabelInt1TimingError.Size = New System.Drawing.Size(10, 13)
        Me.LabelInt1TimingError.TabIndex = 858
        Me.LabelInt1TimingError.Text = "-"
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Location = New System.Drawing.Point(903, 447)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(84, 13)
        Me.Label107.TabIndex = 857
        Me.Label107.Text = "Int1 Timing Error"
        '
        'LabeluPCrashCount
        '
        Me.LabeluPCrashCount.AutoSize = True
        Me.LabeluPCrashCount.Location = New System.Drawing.Point(1038, 461)
        Me.LabeluPCrashCount.Name = "LabeluPCrashCount"
        Me.LabeluPCrashCount.Size = New System.Drawing.Size(10, 13)
        Me.LabeluPCrashCount.TabIndex = 860
        Me.LabeluPCrashCount.Text = "-"
        '
        'Label121
        '
        Me.Label121.AutoSize = True
        Me.Label121.Location = New System.Drawing.Point(903, 461)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(81, 13)
        Me.Label121.TabIndex = 859
        Me.Label121.Text = "uP Crash Count"
        '
        'LabelActionBeforeCrash
        '
        Me.LabelActionBeforeCrash.AutoSize = True
        Me.LabelActionBeforeCrash.Location = New System.Drawing.Point(1038, 474)
        Me.LabelActionBeforeCrash.Name = "LabelActionBeforeCrash"
        Me.LabelActionBeforeCrash.Size = New System.Drawing.Size(10, 13)
        Me.LabelActionBeforeCrash.TabIndex = 862
        Me.LabelActionBeforeCrash.Text = "-"
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.Location = New System.Drawing.Point(903, 474)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(101, 13)
        Me.Label127.TabIndex = 861
        Me.Label127.Text = "Action Before Crash"
        '
        'LabelLVDIntCount
        '
        Me.LabelLVDIntCount.AutoSize = True
        Me.LabelLVDIntCount.Location = New System.Drawing.Point(1038, 487)
        Me.LabelLVDIntCount.Name = "LabelLVDIntCount"
        Me.LabelLVDIntCount.Size = New System.Drawing.Size(10, 13)
        Me.LabelLVDIntCount.TabIndex = 864
        Me.LabelLVDIntCount.Text = "-"
        '
        'Label134
        '
        Me.Label134.AutoSize = True
        Me.Label134.Location = New System.Drawing.Point(903, 487)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(74, 13)
        Me.Label134.TabIndex = 863
        Me.Label134.Text = "LVD Int Count"
        '
        'LabelOscConBeforeCrash
        '
        Me.LabelOscConBeforeCrash.AutoSize = True
        Me.LabelOscConBeforeCrash.Location = New System.Drawing.Point(1038, 500)
        Me.LabelOscConBeforeCrash.Name = "LabelOscConBeforeCrash"
        Me.LabelOscConBeforeCrash.Size = New System.Drawing.Size(10, 13)
        Me.LabelOscConBeforeCrash.TabIndex = 866
        Me.LabelOscConBeforeCrash.Text = "-"
        '
        'Label136
        '
        Me.Label136.AutoSize = True
        Me.Label136.Location = New System.Drawing.Point(903, 500)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(116, 13)
        Me.Label136.TabIndex = 865
        Me.Label136.Text = "OSCCON Before Crash"
        '
        'LabelMagnetronType
        '
        Me.LabelMagnetronType.AutoSize = True
        Me.LabelMagnetronType.Location = New System.Drawing.Point(9, 667)
        Me.LabelMagnetronType.Name = "LabelMagnetronType"
        Me.LabelMagnetronType.Size = New System.Drawing.Size(85, 13)
        Me.LabelMagnetronType.TabIndex = 867
        Me.LabelMagnetronType.Text = "Magnetron Type"
        '
        'LabelControlBoardType
        '
        Me.LabelControlBoardType.AutoSize = True
        Me.LabelControlBoardType.Location = New System.Drawing.Point(9, 688)
        Me.LabelControlBoardType.Name = "LabelControlBoardType"
        Me.LabelControlBoardType.Size = New System.Drawing.Size(71, 13)
        Me.LabelControlBoardType.TabIndex = 868
        Me.LabelControlBoardType.Text = "Control Board"
        '
        'ButtonSetModeBTargetI
        '
        Me.ButtonSetModeBTargetI.Location = New System.Drawing.Point(305, 482)
        Me.ButtonSetModeBTargetI.Name = "ButtonSetModeBTargetI"
        Me.ButtonSetModeBTargetI.Size = New System.Drawing.Size(114, 23)
        Me.ButtonSetModeBTargetI.TabIndex = 872
        Me.ButtonSetModeBTargetI.Text = "Mode B I TGT"
        Me.ButtonSetModeBTargetI.UseVisualStyleBackColor = True
        '
        'TextBoxModeBTargetI
        '
        Me.TextBoxModeBTargetI.Location = New System.Drawing.Point(228, 485)
        Me.TextBoxModeBTargetI.Name = "TextBoxModeBTargetI"
        Me.TextBoxModeBTargetI.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxModeBTargetI.TabIndex = 871
        '
        'ButtonSetModeATargetI
        '
        Me.ButtonSetModeATargetI.Location = New System.Drawing.Point(90, 482)
        Me.ButtonSetModeATargetI.Name = "ButtonSetModeATargetI"
        Me.ButtonSetModeATargetI.Size = New System.Drawing.Size(114, 23)
        Me.ButtonSetModeATargetI.TabIndex = 870
        Me.ButtonSetModeATargetI.Text = "Mode A I TGT"
        Me.ButtonSetModeATargetI.UseVisualStyleBackColor = True
        '
        'TextBoxModeATargetI
        '
        Me.TextBoxModeATargetI.Location = New System.Drawing.Point(13, 485)
        Me.TextBoxModeATargetI.Name = "TextBoxModeATargetI"
        Me.TextBoxModeATargetI.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxModeATargetI.TabIndex = 869
        '
        'LabelModeBTargetISetPoint
        '
        Me.LabelModeBTargetISetPoint.AutoSize = True
        Me.LabelModeBTargetISetPoint.Location = New System.Drawing.Point(364, 148)
        Me.LabelModeBTargetISetPoint.Name = "LabelModeBTargetISetPoint"
        Me.LabelModeBTargetISetPoint.Size = New System.Drawing.Size(10, 13)
        Me.LabelModeBTargetISetPoint.TabIndex = 876
        Me.LabelModeBTargetISetPoint.Text = "-"
        '
        'Label113
        '
        Me.Label113.AutoSize = True
        Me.Label113.Location = New System.Drawing.Point(229, 148)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(90, 13)
        Me.Label113.TabIndex = 875
        Me.Label113.Text = "Target I Set Point"
        '
        'LabelModeATargetISetPoint
        '
        Me.LabelModeATargetISetPoint.AutoSize = True
        Me.LabelModeATargetISetPoint.Location = New System.Drawing.Point(142, 150)
        Me.LabelModeATargetISetPoint.Name = "LabelModeATargetISetPoint"
        Me.LabelModeATargetISetPoint.Size = New System.Drawing.Size(10, 13)
        Me.LabelModeATargetISetPoint.TabIndex = 874
        Me.LabelModeATargetISetPoint.Text = "-"
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.Location = New System.Drawing.Point(5, 148)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(90, 13)
        Me.Label128.TabIndex = 873
        Me.Label128.Text = "Target I Set Point"
        '
        'LabelModeBTargetIMonitor
        '
        Me.LabelModeBTargetIMonitor.AutoSize = True
        Me.LabelModeBTargetIMonitor.Location = New System.Drawing.Point(364, 239)
        Me.LabelModeBTargetIMonitor.Name = "LabelModeBTargetIMonitor"
        Me.LabelModeBTargetIMonitor.Size = New System.Drawing.Size(10, 13)
        Me.LabelModeBTargetIMonitor.TabIndex = 880
        Me.LabelModeBTargetIMonitor.Text = "-"
        '
        'Label125
        '
        Me.Label125.AutoSize = True
        Me.Label125.Location = New System.Drawing.Point(229, 239)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(82, 13)
        Me.Label125.TabIndex = 879
        Me.Label125.Text = "Target I Monitor"
        '
        'LabelModeATargetIMonitor
        '
        Me.LabelModeATargetIMonitor.AutoSize = True
        Me.LabelModeATargetIMonitor.Location = New System.Drawing.Point(142, 241)
        Me.LabelModeATargetIMonitor.Name = "LabelModeATargetIMonitor"
        Me.LabelModeATargetIMonitor.Size = New System.Drawing.Size(10, 13)
        Me.LabelModeATargetIMonitor.TabIndex = 878
        Me.LabelModeATargetIMonitor.Text = "-"
        '
        'Label137
        '
        Me.Label137.AutoSize = True
        Me.Label137.Location = New System.Drawing.Point(5, 239)
        Me.Label137.Name = "Label137"
        Me.Label137.Size = New System.Drawing.Size(82, 13)
        Me.Label137.TabIndex = 877
        Me.Label137.Text = "Target I Monitor"
        '
        'ButtonStartDataLogging
        '
        Me.ButtonStartDataLogging.Location = New System.Drawing.Point(443, 603)
        Me.ButtonStartDataLogging.Name = "ButtonStartDataLogging"
        Me.ButtonStartDataLogging.Size = New System.Drawing.Size(93, 23)
        Me.ButtonStartDataLogging.TabIndex = 881
        Me.ButtonStartDataLogging.Text = "Start Logging"
        Me.ButtonStartDataLogging.UseVisualStyleBackColor = True
        '
        'ButtonStopDataLogging
        '
        Me.ButtonStopDataLogging.Enabled = False
        Me.ButtonStopDataLogging.Location = New System.Drawing.Point(542, 602)
        Me.ButtonStopDataLogging.Name = "ButtonStopDataLogging"
        Me.ButtonStopDataLogging.Size = New System.Drawing.Size(93, 23)
        Me.ButtonStopDataLogging.TabIndex = 882
        Me.ButtonStopDataLogging.Text = "Stop Logging"
        Me.ButtonStopDataLogging.UseVisualStyleBackColor = True
        '
        'ButtonSetFilamentCurrent
        '
        Me.ButtonSetFilamentCurrent.Enabled = False
        Me.ButtonSetFilamentCurrent.Location = New System.Drawing.Point(306, 584)
        Me.ButtonSetFilamentCurrent.Name = "ButtonSetFilamentCurrent"
        Me.ButtonSetFilamentCurrent.Size = New System.Drawing.Size(114, 23)
        Me.ButtonSetFilamentCurrent.TabIndex = 883
        Me.ButtonSetFilamentCurrent.Text = "Set Filament Current"
        Me.ButtonSetFilamentCurrent.UseVisualStyleBackColor = True
        '
        'LabelHeaterISetPoint
        '
        Me.LabelHeaterISetPoint.AutoSize = True
        Me.LabelHeaterISetPoint.Location = New System.Drawing.Point(365, 69)
        Me.LabelHeaterISetPoint.Name = "LabelHeaterISetPoint"
        Me.LabelHeaterISetPoint.Size = New System.Drawing.Size(10, 13)
        Me.LabelHeaterISetPoint.TabIndex = 885
        Me.LabelHeaterISetPoint.Text = "-"
        '
        'Label135
        '
        Me.Label135.AutoSize = True
        Me.Label135.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label135.Location = New System.Drawing.Point(228, 67)
        Me.Label135.Name = "Label135"
        Me.Label135.Size = New System.Drawing.Size(109, 13)
        Me.Label135.TabIndex = 884
        Me.Label135.Text = "Heater I Set Point"
        '
        'LabelPulseLatchError
        '
        Me.LabelPulseLatchError.AutoSize = True
        Me.LabelPulseLatchError.Location = New System.Drawing.Point(1038, 513)
        Me.LabelPulseLatchError.Name = "LabelPulseLatchError"
        Me.LabelPulseLatchError.Size = New System.Drawing.Size(10, 13)
        Me.LabelPulseLatchError.TabIndex = 887
        Me.LabelPulseLatchError.Text = "-"
        '
        'Label138
        '
        Me.Label138.AutoSize = True
        Me.Label138.Location = New System.Drawing.Point(903, 513)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(88, 13)
        Me.Label138.TabIndex = 886
        Me.Label138.Text = "Pulse Latch Error"
        '
        'ButtonLowEnergyAdjustNumPulses
        '
        Me.ButtonLowEnergyAdjustNumPulses.Location = New System.Drawing.Point(622, 633)
        Me.ButtonLowEnergyAdjustNumPulses.Name = "ButtonLowEnergyAdjustNumPulses"
        Me.ButtonLowEnergyAdjustNumPulses.Size = New System.Drawing.Size(114, 23)
        Me.ButtonLowEnergyAdjustNumPulses.TabIndex = 889
        Me.ButtonLowEnergyAdjustNumPulses.Text = "# Pulses"
        Me.ButtonLowEnergyAdjustNumPulses.UseVisualStyleBackColor = True
        '
        'TextBoxLowEnergyAdjustPulses
        '
        Me.TextBoxLowEnergyAdjustPulses.Location = New System.Drawing.Point(545, 636)
        Me.TextBoxLowEnergyAdjustPulses.Name = "TextBoxLowEnergyAdjustPulses"
        Me.TextBoxLowEnergyAdjustPulses.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxLowEnergyAdjustPulses.TabIndex = 888
        '
        'ButtonLowEnergyAdjustMag
        '
        Me.ButtonLowEnergyAdjustMag.Location = New System.Drawing.Point(622, 659)
        Me.ButtonLowEnergyAdjustMag.Name = "ButtonLowEnergyAdjustMag"
        Me.ButtonLowEnergyAdjustMag.Size = New System.Drawing.Size(114, 23)
        Me.ButtonLowEnergyAdjustMag.TabIndex = 891
        Me.ButtonLowEnergyAdjustMag.Text = "Magnitude"
        Me.ButtonLowEnergyAdjustMag.UseVisualStyleBackColor = True
        '
        'TextBoxLowEnergyAdjustMag
        '
        Me.TextBoxLowEnergyAdjustMag.Location = New System.Drawing.Point(545, 662)
        Me.TextBoxLowEnergyAdjustMag.Name = "TextBoxLowEnergyAdjustMag"
        Me.TextBoxLowEnergyAdjustMag.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxLowEnergyAdjustMag.TabIndex = 890
        '
        'ButtonLowEnergyAdjDir
        '
        Me.ButtonLowEnergyAdjDir.Location = New System.Drawing.Point(622, 685)
        Me.ButtonLowEnergyAdjDir.Name = "ButtonLowEnergyAdjDir"
        Me.ButtonLowEnergyAdjDir.Size = New System.Drawing.Size(114, 23)
        Me.ButtonLowEnergyAdjDir.TabIndex = 893
        Me.ButtonLowEnergyAdjDir.Text = "Max Cooldown Sec"
        Me.ButtonLowEnergyAdjDir.UseVisualStyleBackColor = True
        '
        'TextBoxLowEnergyAdjDir
        '
        Me.TextBoxLowEnergyAdjDir.Location = New System.Drawing.Point(545, 688)
        Me.TextBoxLowEnergyAdjDir.Name = "TextBoxLowEnergyAdjDir"
        Me.TextBoxLowEnergyAdjDir.Size = New System.Drawing.Size(71, 20)
        Me.TextBoxLowEnergyAdjDir.TabIndex = 892
        '
        'LabelTargetAdjustInitial
        '
        Me.LabelTargetAdjustInitial.AutoSize = True
        Me.LabelTargetAdjustInitial.Location = New System.Drawing.Point(838, 698)
        Me.LabelTargetAdjustInitial.Name = "LabelTargetAdjustInitial"
        Me.LabelTargetAdjustInitial.Size = New System.Drawing.Size(10, 13)
        Me.LabelTargetAdjustInitial.TabIndex = 901
        Me.LabelTargetAdjustInitial.Text = "-"
        '
        'Label141
        '
        Me.Label141.AutoSize = True
        Me.Label141.Location = New System.Drawing.Point(742, 698)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(55, 13)
        Me.Label141.TabIndex = 900
        Me.Label141.Text = "Initial Mag"
        '
        'LabelTargetAdjustMaxTime
        '
        Me.LabelTargetAdjustMaxTime.AutoSize = True
        Me.LabelTargetAdjustMaxTime.Location = New System.Drawing.Point(838, 685)
        Me.LabelTargetAdjustMaxTime.Name = "LabelTargetAdjustMaxTime"
        Me.LabelTargetAdjustMaxTime.Size = New System.Drawing.Size(10, 13)
        Me.LabelTargetAdjustMaxTime.TabIndex = 899
        Me.LabelTargetAdjustMaxTime.Text = "-"
        '
        'Label143
        '
        Me.Label143.AutoSize = True
        Me.Label143.Location = New System.Drawing.Point(742, 685)
        Me.Label143.Name = "Label143"
        Me.Label143.Size = New System.Drawing.Size(77, 13)
        Me.Label143.TabIndex = 898
        Me.Label143.Text = "Time Max Mag"
        '
        'LabelTargetAdjustMaxMag
        '
        Me.LabelTargetAdjustMaxMag.AutoSize = True
        Me.LabelTargetAdjustMaxMag.Location = New System.Drawing.Point(838, 672)
        Me.LabelTargetAdjustMaxMag.Name = "LabelTargetAdjustMaxMag"
        Me.LabelTargetAdjustMaxMag.Size = New System.Drawing.Size(10, 13)
        Me.LabelTargetAdjustMaxMag.TabIndex = 897
        Me.LabelTargetAdjustMaxMag.Text = "-"
        '
        'Label145
        '
        Me.Label145.AutoSize = True
        Me.Label145.Location = New System.Drawing.Point(742, 672)
        Me.Label145.Name = "Label145"
        Me.Label145.Size = New System.Drawing.Size(51, 13)
        Me.Label145.TabIndex = 896
        Me.Label145.Text = "Max Mag"
        '
        'LabelTargetAdjustPulse
        '
        Me.LabelTargetAdjustPulse.AutoSize = True
        Me.LabelTargetAdjustPulse.Location = New System.Drawing.Point(838, 659)
        Me.LabelTargetAdjustPulse.Name = "LabelTargetAdjustPulse"
        Me.LabelTargetAdjustPulse.Size = New System.Drawing.Size(10, 13)
        Me.LabelTargetAdjustPulse.TabIndex = 895
        Me.LabelTargetAdjustPulse.Text = "-"
        '
        'Label147
        '
        Me.Label147.AutoSize = True
        Me.Label147.Location = New System.Drawing.Point(742, 659)
        Me.Label147.Name = "Label147"
        Me.Label147.Size = New System.Drawing.Size(43, 13)
        Me.Label147.TabIndex = 894
        Me.Label147.Text = "# Pulse"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 712)
        Me.Controls.Add(Me.LabelTargetAdjustInitial)
        Me.Controls.Add(Me.Label141)
        Me.Controls.Add(Me.LabelTargetAdjustMaxTime)
        Me.Controls.Add(Me.Label143)
        Me.Controls.Add(Me.LabelTargetAdjustMaxMag)
        Me.Controls.Add(Me.Label145)
        Me.Controls.Add(Me.LabelTargetAdjustPulse)
        Me.Controls.Add(Me.Label147)
        Me.Controls.Add(Me.ButtonLowEnergyAdjDir)
        Me.Controls.Add(Me.TextBoxLowEnergyAdjDir)
        Me.Controls.Add(Me.ButtonLowEnergyAdjustMag)
        Me.Controls.Add(Me.TextBoxLowEnergyAdjustMag)
        Me.Controls.Add(Me.ButtonLowEnergyAdjustNumPulses)
        Me.Controls.Add(Me.TextBoxLowEnergyAdjustPulses)
        Me.Controls.Add(Me.LabelPulseLatchError)
        Me.Controls.Add(Me.Label138)
        Me.Controls.Add(Me.LabelHeaterISetPoint)
        Me.Controls.Add(Me.Label135)
        Me.Controls.Add(Me.ButtonSetFilamentCurrent)
        Me.Controls.Add(Me.ButtonStopDataLogging)
        Me.Controls.Add(Me.ButtonStartDataLogging)
        Me.Controls.Add(Me.LabelModeBTargetIMonitor)
        Me.Controls.Add(Me.Label125)
        Me.Controls.Add(Me.LabelModeATargetIMonitor)
        Me.Controls.Add(Me.Label137)
        Me.Controls.Add(Me.LabelModeBTargetISetPoint)
        Me.Controls.Add(Me.Label113)
        Me.Controls.Add(Me.LabelModeATargetISetPoint)
        Me.Controls.Add(Me.Label128)
        Me.Controls.Add(Me.ButtonSetModeBTargetI)
        Me.Controls.Add(Me.TextBoxModeBTargetI)
        Me.Controls.Add(Me.ButtonSetModeATargetI)
        Me.Controls.Add(Me.TextBoxModeATargetI)
        Me.Controls.Add(Me.LabelControlBoardType)
        Me.Controls.Add(Me.LabelMagnetronType)
        Me.Controls.Add(Me.LabelOscConBeforeCrash)
        Me.Controls.Add(Me.Label136)
        Me.Controls.Add(Me.LabelLVDIntCount)
        Me.Controls.Add(Me.Label134)
        Me.Controls.Add(Me.LabelActionBeforeCrash)
        Me.Controls.Add(Me.Label127)
        Me.Controls.Add(Me.LabeluPCrashCount)
        Me.Controls.Add(Me.Label121)
        Me.Controls.Add(Me.LabelInt1TimingError)
        Me.Controls.Add(Me.Label107)
        Me.Controls.Add(Me.Label97)
        Me.Controls.Add(Me.Label92)
        Me.Controls.Add(Me.ButtonSkipWarmup)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LabelMagnetControlStatus)
        Me.Controls.Add(Me.LabelMCUVersion)
        Me.Controls.Add(Me.LabelGUIVersion)
        Me.Controls.Add(Me.ButtonSetBaudRate)
        Me.Controls.Add(Me.TextBoxBaudRate)
        Me.Controls.Add(Me.ButtonReadState)
        Me.Controls.Add(Me.Label85)
        Me.Controls.Add(Me.Label88)
        Me.Controls.Add(Me.CheckBoxSWReset)
        Me.Controls.Add(Me.CheckBoxPOR)
        Me.Controls.Add(Me.CheckBoxExtReset)
        Me.Controls.Add(Me.Label90)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBoxIOExpanderError)
        Me.Controls.Add(Me.Label129)
        Me.Controls.Add(Me.Label130)
        Me.Controls.Add(Me.Label131)
        Me.Controls.Add(Me.CheckBoxIOPUWR)
        Me.Controls.Add(Me.CheckBoxTRAPR)
        Me.Controls.Add(Me.CheckBoxWDT)
        Me.Controls.Add(Me.CheckBoxBOR)
        Me.Controls.Add(Me.Label132)
        Me.Controls.Add(Me.Label133)
        Me.Controls.Add(Me.LabelSPI2BusError)
        Me.Controls.Add(Me.Label87)
        Me.Controls.Add(Me.LabelReverseScale16BitSaturation)
        Me.Controls.Add(Me.Label108)
        Me.Controls.Add(Me.LabelScale16BitSaturation)
        Me.Controls.Add(Me.Label119)
        Me.Controls.Add(Me.LabelInvalidSetPoint)
        Me.Controls.Add(Me.Label123)
        Me.Controls.Add(Me.LabelLTC2656WriteError)
        Me.Controls.Add(Me.Label126)
        Me.Controls.Add(Me.LabelADCFalseTrigger)
        Me.Controls.Add(Me.Label89)
        Me.Controls.Add(Me.LabelSPI1BusError)
        Me.Controls.Add(Me.Label91)
        Me.Controls.Add(Me.LabelI2CBusError)
        Me.Controls.Add(Me.Label95)
        Me.Controls.Add(Me.LabelMagnetronVoltageGlitch)
        Me.Controls.Add(Me.Label99)
        Me.Controls.Add(Me.LabelMagnetronCurrentGlitch)
        Me.Controls.Add(Me.Label101)
        Me.Controls.Add(Me.LabelLambdaVmon)
        Me.Controls.Add(Me.Label86)
        Me.Controls.Add(Me.CheckBox106)
        Me.Controls.Add(Me.CheckBoxControlBoardStatusBit15)
        Me.Controls.Add(Me.CheckBoxControlBoardFaultBit15)
        Me.Controls.Add(Me.Label64)
        Me.Controls.Add(Me.CheckBox112)
        Me.Controls.Add(Me.CheckBoxControlBoardStatusBit14)
        Me.Controls.Add(Me.CheckBoxControlBoardFaultBit14)
        Me.Controls.Add(Me.CheckBox118)
        Me.Controls.Add(Me.CheckBox120)
        Me.Controls.Add(Me.CheckBox121)
        Me.Controls.Add(Me.CheckBox122)
        Me.Controls.Add(Me.CheckBoxControlBoardStatusBit13)
        Me.Controls.Add(Me.CheckBoxControlBoardStatusBit11)
        Me.Controls.Add(Me.CheckBoxControlBoardStatusBit12)
        Me.Controls.Add(Me.CheckBoxControlBoardStatusBit10)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.Label70)
        Me.Controls.Add(Me.Label71)
        Me.Controls.Add(Me.CheckBoxControlBoardFaultBit13)
        Me.Controls.Add(Me.CheckBoxControlBoardFaultBit11)
        Me.Controls.Add(Me.CheckBoxControlBoardFaultBit12)
        Me.Controls.Add(Me.CheckBoxControlBoardFaultBit10)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.CheckBox131)
        Me.Controls.Add(Me.CheckBoxControlBoardStatusBit9)
        Me.Controls.Add(Me.CheckBoxControlBoardFaultBit9)
        Me.Controls.Add(Me.CheckBox134)
        Me.Controls.Add(Me.CheckBox135)
        Me.Controls.Add(Me.CheckBox136)
        Me.Controls.Add(Me.CheckBox137)
        Me.Controls.Add(Me.CheckBoxControlBoardStatusBit8)
        Me.Controls.Add(Me.CheckBoxControlBoardStatusBit6)
        Me.Controls.Add(Me.CheckBoxControlBoardStatusBit7)
        Me.Controls.Add(Me.CheckBoxControlBoardStatusBit5)
        Me.Controls.Add(Me.Label74)
        Me.Controls.Add(Me.Label75)
        Me.Controls.Add(Me.Label76)
        Me.Controls.Add(Me.CheckBoxControlBoardFaultBit8)
        Me.Controls.Add(Me.CheckBoxControlBoardFaultBit6)
        Me.Controls.Add(Me.CheckBoxControlBoardFaultBit7)
        Me.Controls.Add(Me.CheckBoxControlBoardFaultBit5)
        Me.Controls.Add(Me.Label77)
        Me.Controls.Add(Me.Label78)
        Me.Controls.Add(Me.CheckBox146)
        Me.Controls.Add(Me.CheckBoxControlBoardStatusBit4)
        Me.Controls.Add(Me.CheckBoxControlBoardFaultBit4)
        Me.Controls.Add(Me.Label79)
        Me.Controls.Add(Me.CheckBox149)
        Me.Controls.Add(Me.CheckBox150)
        Me.Controls.Add(Me.CheckBox151)
        Me.Controls.Add(Me.CheckBox152)
        Me.Controls.Add(Me.CheckBoxControlBoardStatusBit3)
        Me.Controls.Add(Me.CheckBoxControlBoardStatusBit1)
        Me.Controls.Add(Me.CheckBoxControlBoardStatusBit2)
        Me.Controls.Add(Me.CheckBoxControlBoardStatusBit0)
        Me.Controls.Add(Me.Label80)
        Me.Controls.Add(Me.Label81)
        Me.Controls.Add(Me.Label82)
        Me.Controls.Add(Me.CheckBoxControlBoardFaultBit3)
        Me.Controls.Add(Me.CheckBoxControlBoardFaultBit1)
        Me.Controls.Add(Me.CheckBoxControlBoardFaultBit2)
        Me.Controls.Add(Me.CheckBoxControlBoardFaultBit0)
        Me.Controls.Add(Me.Label83)
        Me.Controls.Add(Me.Label84)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit15)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit15)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.CheckBox8)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit14)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit14)
        Me.Controls.Add(Me.CheckBox29)
        Me.Controls.Add(Me.CheckBox30)
        Me.Controls.Add(Me.CheckBox33)
        Me.Controls.Add(Me.CheckBox44)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit13)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit11)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit12)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit10)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit13)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit11)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit12)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit10)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label50)
        Me.Controls.Add(Me.CheckBox75)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit9)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit9)
        Me.Controls.Add(Me.CheckBox78)
        Me.Controls.Add(Me.CheckBox79)
        Me.Controls.Add(Me.CheckBox80)
        Me.Controls.Add(Me.CheckBox81)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit8)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit6)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit7)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit5)
        Me.Controls.Add(Me.Label51)
        Me.Controls.Add(Me.Label52)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit8)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit6)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit7)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit5)
        Me.Controls.Add(Me.Label54)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.CheckBox90)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit4)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit4)
        Me.Controls.Add(Me.Label56)
        Me.Controls.Add(Me.CheckBox93)
        Me.Controls.Add(Me.CheckBox94)
        Me.Controls.Add(Me.CheckBox95)
        Me.Controls.Add(Me.CheckBox96)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit3)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit1)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit2)
        Me.Controls.Add(Me.CheckBoxThyratronStatusBit0)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.Label58)
        Me.Controls.Add(Me.Label59)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit3)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit1)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit2)
        Me.Controls.Add(Me.CheckBoxThyratronFaultBit0)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.CheckBoxHVStatusBit15)
        Me.Controls.Add(Me.CheckBoxHVFaultBit15)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBoxHVStatusBit14)
        Me.Controls.Add(Me.CheckBoxHVFaultBit14)
        Me.Controls.Add(Me.CheckBox9)
        Me.Controls.Add(Me.CheckBox10)
        Me.Controls.Add(Me.CheckBox11)
        Me.Controls.Add(Me.CheckBox12)
        Me.Controls.Add(Me.CheckBoxHVStatusBit13)
        Me.Controls.Add(Me.CheckBoxHVStatusBit11)
        Me.Controls.Add(Me.CheckBoxHVStatusBit12)
        Me.Controls.Add(Me.CheckBoxHVStatusBit10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CheckBoxHVFaultBit13)
        Me.Controls.Add(Me.CheckBoxHVFaultBit11)
        Me.Controls.Add(Me.CheckBoxHVFaultBit12)
        Me.Controls.Add(Me.CheckBoxHVFaultBit10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.CheckBox31)
        Me.Controls.Add(Me.CheckBoxHVStatusBit9)
        Me.Controls.Add(Me.CheckBoxHVFaultBit9)
        Me.Controls.Add(Me.CheckBox34)
        Me.Controls.Add(Me.CheckBox35)
        Me.Controls.Add(Me.CheckBox36)
        Me.Controls.Add(Me.CheckBox37)
        Me.Controls.Add(Me.CheckBoxHVStatusBit8)
        Me.Controls.Add(Me.CheckBoxHVStatusBit6)
        Me.Controls.Add(Me.CheckBoxHVStatusBit7)
        Me.Controls.Add(Me.CheckBoxHVStatusBit5)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.CheckBoxHVFaultBit8)
        Me.Controls.Add(Me.CheckBoxHVFaultBit6)
        Me.Controls.Add(Me.CheckBoxHVFaultBit7)
        Me.Controls.Add(Me.CheckBoxHVFaultBit5)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.CheckBox52)
        Me.Controls.Add(Me.CheckBoxHVStatusBit4)
        Me.Controls.Add(Me.CheckBoxHVFaultBit4)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.CheckBox63)
        Me.Controls.Add(Me.CheckBox64)
        Me.Controls.Add(Me.CheckBox65)
        Me.Controls.Add(Me.CheckBox66)
        Me.Controls.Add(Me.CheckBoxHVStatusBit3)
        Me.Controls.Add(Me.CheckBoxHVStatusBit1)
        Me.Controls.Add(Me.CheckBoxHVStatusBit2)
        Me.Controls.Add(Me.CheckBoxHVStatusBit0)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.Label43)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.CheckBoxHVFaultBit3)
        Me.Controls.Add(Me.CheckBoxHVFaultBit1)
        Me.Controls.Add(Me.CheckBoxHVFaultBit2)
        Me.Controls.Add(Me.CheckBoxHVFaultBit0)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.CheckBox39)
        Me.Controls.Add(Me.CheckBoxMagnetronStatusBit15)
        Me.Controls.Add(Me.CheckBoxMagnetronFaultBit15)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.CheckBox48)
        Me.Controls.Add(Me.CheckBoxMagnetronStatusBit14)
        Me.Controls.Add(Me.CheckBoxMagnetronFaultBit14)
        Me.Controls.Add(Me.CheckBox53)
        Me.Controls.Add(Me.CheckBox54)
        Me.Controls.Add(Me.CheckBox55)
        Me.Controls.Add(Me.CheckBox56)
        Me.Controls.Add(Me.CheckBoxMagnetronStatusBit13)
        Me.Controls.Add(Me.CheckBoxMagnetronStatusBit11)
        Me.Controls.Add(Me.CheckBoxMagnetronStatusBit12)
        Me.Controls.Add(Me.CheckBoxMagnetronStatusBit10)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.CheckBoxMagnetronFaultBit13)
        Me.Controls.Add(Me.CheckBoxMagnetronFaultBit11)
        Me.Controls.Add(Me.CheckBoxMagnetronFaultBit12)
        Me.Controls.Add(Me.CheckBoxMagnetronFaultBit10)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.CheckBox18)
        Me.Controls.Add(Me.CheckBoxMagnetronStatusBit9)
        Me.Controls.Add(Me.CheckBoxMagnetronFaultBit9)
        Me.Controls.Add(Me.CheckBox21)
        Me.Controls.Add(Me.CheckBox22)
        Me.Controls.Add(Me.CheckBox23)
        Me.Controls.Add(Me.CheckBox24)
        Me.Controls.Add(Me.CheckBoxMagnetronStatusBit8)
        Me.Controls.Add(Me.CheckBoxMagnetronStatusBit6)
        Me.Controls.Add(Me.CheckBoxMagnetronStatusBit7)
        Me.Controls.Add(Me.CheckBoxMagnetronStatusBit5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.CheckBoxMagnetronFaultBit8)
        Me.Controls.Add(Me.CheckBoxMagnetronFaultBit6)
        Me.Controls.Add(Me.CheckBoxMagnetronFaultBit7)
        Me.Controls.Add(Me.CheckBoxMagnetronFaultBit5)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label117)
        Me.Controls.Add(Me.LabelMagnetronCurrent)
        Me.Controls.Add(Me.Label110)
        Me.Controls.Add(Me.LabelMagnetronVoltage)
        Me.Controls.Add(Me.Label115)
        Me.Controls.Add(Me.LabelPulseVoltagetMaxModeB)
        Me.Controls.Add(Me.Label114)
        Me.Controls.Add(Me.LabelPulseVoltagetMinModeB)
        Me.Controls.Add(Me.Label116)
        Me.Controls.Add(Me.LabelPulseCurrentMaxModeB)
        Me.Controls.Add(Me.Label118)
        Me.Controls.Add(Me.LabelPulseCurrentMinModeB)
        Me.Controls.Add(Me.Label120)
        Me.Controls.Add(Me.LabelPulseCurrentModeB)
        Me.Controls.Add(Me.Label122)
        Me.Controls.Add(Me.LabelPulseVoltageModeB)
        Me.Controls.Add(Me.Label124)
        Me.Controls.Add(Me.LabelPulseVoltagetMaxModeA)
        Me.Controls.Add(Me.Label109)
        Me.Controls.Add(Me.LabelPulseVoltagetMinModeA)
        Me.Controls.Add(Me.Label112)
        Me.Controls.Add(Me.LabelLambdaSetPointModeB)
        Me.Controls.Add(Me.Label111)
        Me.Controls.Add(Me.ButtonSetLambdaModeB)
        Me.Controls.Add(Me.TextBoxSetLambdaModeB)
        Me.Controls.Add(Me.ButtonSetFilament)
        Me.Controls.Add(Me.TextBoxSetFilament)
        Me.Controls.Add(Me.ButtonUpdateAll)
        Me.Controls.Add(Me.Label103)
        Me.Controls.Add(Me.LabelTime)
        Me.Controls.Add(Me.LabelArcsTotal)
        Me.Controls.Add(Me.LabelPulsesTotal)
        Me.Controls.Add(Me.LabelArcsHVOn)
        Me.Controls.Add(Me.LabelPulsesHVon)
        Me.Controls.Add(Me.Label105)
        Me.Controls.Add(Me.Label106)
        Me.Controls.Add(Me.Label104)
        Me.Controls.Add(Me.Label102)
        Me.Controls.Add(Me.LabelMagnetronPower)
        Me.Controls.Add(Me.Label98)
        Me.Controls.Add(Me.LabelPRF)
        Me.Controls.Add(Me.Label96)
        Me.Controls.Add(Me.LabelEnergyPerPulse)
        Me.Controls.Add(Me.Label94)
        Me.Controls.Add(Me.ButtonSetMagnet)
        Me.Controls.Add(Me.TextBoxSetMagnet)
        Me.Controls.Add(Me.ButtonSetLambdaModeA)
        Me.Controls.Add(Me.TextBoxSetLambdaModeA)
        Me.Controls.Add(Me.LabelState)
        Me.Controls.Add(Me.Label93)
        Me.Controls.Add(Me.CheckBox49)
        Me.Controls.Add(Me.CheckBoxMagnetronStatusBit4)
        Me.Controls.Add(Me.CheckBoxMagnetronFaultBit4)
        Me.Controls.Add(Me.Label60)
        Me.Controls.Add(Me.CheckBox105)
        Me.Controls.Add(Me.CheckBox107)
        Me.Controls.Add(Me.CheckBox108)
        Me.Controls.Add(Me.CheckBox110)
        Me.Controls.Add(Me.CheckBoxMagnetronStatusBit3)
        Me.Controls.Add(Me.CheckBoxMagnetronStatusBit1)
        Me.Controls.Add(Me.CheckBoxMagnetronStatusBit2)
        Me.Controls.Add(Me.CheckBoxMagnetronStatusBit0)
        Me.Controls.Add(Me.Label61)
        Me.Controls.Add(Me.Label65)
        Me.Controls.Add(Me.Label66)
        Me.Controls.Add(Me.CheckBoxMagnetronFaultBit3)
        Me.Controls.Add(Me.CheckBoxMagnetronFaultBit1)
        Me.Controls.Add(Me.CheckBoxMagnetronFaultBit2)
        Me.Controls.Add(Me.CheckBoxMagnetronFaultBit0)
        Me.Controls.Add(Me.Label67)
        Me.Controls.Add(Me.Label68)
        Me.Controls.Add(Me.LabelPulseCurrentMaxModeA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelHeaterImon)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.LabelMagnetVmon)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.LabelPulseCurrentMinModeA)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.LabelPulseCurrentModeA)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.LabelPulseVoltageModeA)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.LabelThyrResrHeaterVmon)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.LabelThyrResrHtrSetPoint)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.LabelThyrHeaterVmon)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.LabelThyrHtrSetPoint)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.LabelLambdaVpeak)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LabelLambdaSetPointModeA)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LabelHeaterVmon)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabelHeaterSetPoint)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelMagnetIMON)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabelMagnetSetPoint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxComPorts)
        Me.Controls.Add(Me.LabelComMsg)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Company R - Test GUI"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SerialPortETM As System.IO.Ports.SerialPort
    Friend WithEvents LabelComMsg As System.Windows.Forms.Label
    Friend WithEvents ComboBoxComPorts As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabelMagnetSetPoint As System.Windows.Forms.Label
    Friend WithEvents LabelMagnetIMON As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LabelHeaterSetPoint As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelHeaterVmon As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LabelLambdaVpeak As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LabelLambdaSetPointModeA As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LabelThyrHeaterVmon As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LabelThyrHtrSetPoint As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LabelThyrResrHeaterVmon As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents LabelThyrResrHtrSetPoint As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents LabelPulseVoltageModeA As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LabelPulseCurrentModeA As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents LabelPulseCurrentMinModeA As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents LabelMagnetVmon As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents LabelHeaterImon As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents LabelPulseCurrentMaxModeA As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox49 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronStatusBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronFaultBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents CheckBox105 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox107 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox108 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox110 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronStatusBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronStatusBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronStatusBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronStatusBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxMagnetronFaultBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronFaultBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronFaultBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronFaultBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents LabelState As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSetLambdaModeA As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSetLambdaModeA As System.Windows.Forms.Button
    Friend WithEvents ButtonSetMagnet As System.Windows.Forms.Button
    Friend WithEvents TextBoxSetMagnet As System.Windows.Forms.TextBox
    Friend WithEvents LabelEnergyPerPulse As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents LabelPRF As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents LabelMagnetronPower As System.Windows.Forms.Label
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents LabelArcsTotal As System.Windows.Forms.Label
    Friend WithEvents LabelPulsesTotal As System.Windows.Forms.Label
    Friend WithEvents LabelArcsHVOn As System.Windows.Forms.Label
    Friend WithEvents LabelPulsesHVon As System.Windows.Forms.Label
    Friend WithEvents LabelTime As System.Windows.Forms.Label
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ButtonUpdateAll As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ButtonSetFilament As System.Windows.Forms.Button
    Friend WithEvents TextBoxSetFilament As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSetLambdaModeB As System.Windows.Forms.Button
    Friend WithEvents TextBoxSetLambdaModeB As System.Windows.Forms.TextBox
    Friend WithEvents LabelLambdaSetPointModeB As System.Windows.Forms.Label
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents LabelPulseVoltagetMaxModeA As System.Windows.Forms.Label
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents LabelPulseVoltagetMinModeA As System.Windows.Forms.Label
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents LabelPulseVoltagetMaxModeB As System.Windows.Forms.Label
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents LabelPulseVoltagetMinModeB As System.Windows.Forms.Label
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents LabelPulseCurrentMaxModeB As System.Windows.Forms.Label
    Friend WithEvents Label118 As System.Windows.Forms.Label
    Friend WithEvents LabelPulseCurrentMinModeB As System.Windows.Forms.Label
    Friend WithEvents Label120 As System.Windows.Forms.Label
    Friend WithEvents LabelPulseCurrentModeB As System.Windows.Forms.Label
    Friend WithEvents Label122 As System.Windows.Forms.Label
    Friend WithEvents LabelPulseVoltageModeB As System.Windows.Forms.Label
    Friend WithEvents Label124 As System.Windows.Forms.Label
    Friend WithEvents LabelMagnetronCurrent As System.Windows.Forms.Label
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents LabelMagnetronVoltage As System.Windows.Forms.Label
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents Label117 As System.Windows.Forms.Label
    Friend WithEvents CheckBox18 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronStatusBit9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronFaultBit9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox21 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox22 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox23 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox24 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronStatusBit8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronStatusBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronStatusBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronStatusBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxMagnetronFaultBit8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronFaultBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronFaultBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronFaultBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CheckBox39 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronStatusBit15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronFaultBit15 As System.Windows.Forms.CheckBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents CheckBox48 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronStatusBit14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronFaultBit14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox53 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox54 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox55 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox56 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronStatusBit13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronStatusBit11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronStatusBit12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronStatusBit10 As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxMagnetronFaultBit13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronFaultBit11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronFaultBit12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMagnetronFaultBit10 As System.Windows.Forms.CheckBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVStatusBit15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVFaultBit15 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVStatusBit14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVFaultBit14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVStatusBit13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVStatusBit11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVStatusBit12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVStatusBit10 As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxHVFaultBit13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVFaultBit11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVFaultBit12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVFaultBit10 As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents CheckBox31 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVStatusBit9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVFaultBit9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox34 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox35 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox36 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox37 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVStatusBit8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVStatusBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVStatusBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVStatusBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxHVFaultBit8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVFaultBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVFaultBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVFaultBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents CheckBox52 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVStatusBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVFaultBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents CheckBox63 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox64 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox65 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox66 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVStatusBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVStatusBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVStatusBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVStatusBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxHVFaultBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVFaultBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVFaultBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxHVFaultBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit15 As System.Windows.Forms.CheckBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox29 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox30 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox33 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox44 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit10 As System.Windows.Forms.CheckBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxThyratronFaultBit13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit10 As System.Windows.Forms.CheckBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents CheckBox75 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox78 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox79 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox80 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox81 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxThyratronFaultBit8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents CheckBox90 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents CheckBox93 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox94 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox95 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox96 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronStatusBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxThyratronFaultBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxThyratronFaultBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents CheckBox106 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardStatusBit15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardFaultBit15 As System.Windows.Forms.CheckBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents CheckBox112 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardStatusBit14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardFaultBit14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox118 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox120 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox121 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox122 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardStatusBit13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardStatusBit11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardStatusBit12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardStatusBit10 As System.Windows.Forms.CheckBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxControlBoardFaultBit13 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardFaultBit11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardFaultBit12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardFaultBit10 As System.Windows.Forms.CheckBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents CheckBox131 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardStatusBit9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardFaultBit9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox134 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox135 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox136 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox137 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardStatusBit8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardStatusBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardStatusBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardStatusBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxControlBoardFaultBit8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardFaultBit6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardFaultBit7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardFaultBit5 As System.Windows.Forms.CheckBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents CheckBox146 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardStatusBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardFaultBit4 As System.Windows.Forms.CheckBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents CheckBox149 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox150 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox151 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox152 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardStatusBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardStatusBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardStatusBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardStatusBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxControlBoardFaultBit3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardFaultBit1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardFaultBit2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxControlBoardFaultBit0 As System.Windows.Forms.CheckBox
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents LabelLambdaVmon As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents LabelADCFalseTrigger As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents LabelSPI1BusError As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents LabelI2CBusError As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents LabelMagnetronVoltageGlitch As System.Windows.Forms.Label
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents LabelMagnetronCurrentGlitch As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents LabelReverseScale16BitSaturation As System.Windows.Forms.Label
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents LabelScale16BitSaturation As System.Windows.Forms.Label
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents LabelInvalidSetPoint As System.Windows.Forms.Label
    Friend WithEvents Label123 As System.Windows.Forms.Label
    Friend WithEvents LabelLTC2656WriteError As System.Windows.Forms.Label
    Friend WithEvents Label126 As System.Windows.Forms.Label
    Friend WithEvents LabelSPI2BusError As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxIOExpanderError As System.Windows.Forms.CheckBox
    Friend WithEvents Label129 As System.Windows.Forms.Label
    Friend WithEvents Label130 As System.Windows.Forms.Label
    Friend WithEvents Label131 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxIOPUWR As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxTRAPR As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxWDT As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxBOR As System.Windows.Forms.CheckBox
    Friend WithEvents Label132 As System.Windows.Forms.Label
    Friend WithEvents Label133 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxSWReset As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxPOR As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxExtReset As System.Windows.Forms.CheckBox
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents ButtonReadState As System.Windows.Forms.Button
    Friend WithEvents ButtonSetBaudRate As System.Windows.Forms.Button
    Friend WithEvents TextBoxBaudRate As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalibrationDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MagnetSupplyCalibrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelGUIVersion As System.Windows.Forms.Label
    Friend WithEvents LabelMCUVersion As System.Windows.Forms.Label
    Friend WithEvents LocalRemoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoteMagnetCurrentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LocalMagnetCurrentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelMagnetControlStatus As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ButtonSkipWarmup As System.Windows.Forms.Button
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents LabelInt1TimingError As System.Windows.Forms.Label
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents LabeluPCrashCount As System.Windows.Forms.Label
    Friend WithEvents Label121 As System.Windows.Forms.Label
    Friend WithEvents LabelActionBeforeCrash As System.Windows.Forms.Label
    Friend WithEvents Label127 As System.Windows.Forms.Label
    Friend WithEvents LabelLVDIntCount As System.Windows.Forms.Label
    Friend WithEvents Label134 As System.Windows.Forms.Label
    Friend WithEvents LabelOscConBeforeCrash As System.Windows.Forms.Label
    Friend WithEvents Label136 As System.Windows.Forms.Label
    Friend WithEvents ETMOverrideModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelMagnetronType As System.Windows.Forms.Label
    Friend WithEvents LabelControlBoardType As System.Windows.Forms.Label
    Friend WithEvents ButtonSetModeBTargetI As System.Windows.Forms.Button
    Friend WithEvents TextBoxModeBTargetI As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSetModeATargetI As System.Windows.Forms.Button
    Friend WithEvents TextBoxModeATargetI As System.Windows.Forms.TextBox
    Friend WithEvents LabelModeBTargetISetPoint As System.Windows.Forms.Label
    Friend WithEvents Label113 As System.Windows.Forms.Label
    Friend WithEvents LabelModeATargetISetPoint As System.Windows.Forms.Label
    Friend WithEvents Label128 As System.Windows.Forms.Label
    Friend WithEvents LabelModeBTargetIMonitor As System.Windows.Forms.Label
    Friend WithEvents Label125 As System.Windows.Forms.Label
    Friend WithEvents LabelModeATargetIMonitor As System.Windows.Forms.Label
    Friend WithEvents Label137 As System.Windows.Forms.Label
    Friend WithEvents ButtonStartDataLogging As System.Windows.Forms.Button
    Friend WithEvents ButtonStopDataLogging As System.Windows.Forms.Button
    Friend WithEvents ButtonSetFilamentCurrent As System.Windows.Forms.Button
    Friend WithEvents LabelHeaterISetPoint As System.Windows.Forms.Label
    Friend WithEvents Label135 As System.Windows.Forms.Label
    Friend WithEvents LabelPulseLatchError As System.Windows.Forms.Label
    Friend WithEvents Label138 As System.Windows.Forms.Label
    Friend WithEvents FilamentCurrentControlModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonLowEnergyAdjustNumPulses As System.Windows.Forms.Button
    Friend WithEvents TextBoxLowEnergyAdjustPulses As System.Windows.Forms.TextBox
    Friend WithEvents ButtonLowEnergyAdjustMag As System.Windows.Forms.Button
    Friend WithEvents TextBoxLowEnergyAdjustMag As System.Windows.Forms.TextBox
    Friend WithEvents ButtonLowEnergyAdjDir As System.Windows.Forms.Button
    Friend WithEvents TextBoxLowEnergyAdjDir As System.Windows.Forms.TextBox
    Friend WithEvents LabelTargetAdjustInitial As System.Windows.Forms.Label
    Friend WithEvents Label141 As System.Windows.Forms.Label
    Friend WithEvents LabelTargetAdjustMaxTime As System.Windows.Forms.Label
    Friend WithEvents Label143 As System.Windows.Forms.Label
    Friend WithEvents LabelTargetAdjustMaxMag As System.Windows.Forms.Label
    Friend WithEvents Label145 As System.Windows.Forms.Label
    Friend WithEvents LabelTargetAdjustPulse As System.Windows.Forms.Label
    Friend WithEvents Label147 As System.Windows.Forms.Label

End Class
