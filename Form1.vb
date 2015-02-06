'Imports System
'Imports System.IO
'Imports System.Collections

Public Class Form1
    Public ReturnData As UInt16
    Dim ComError As Boolean
    Dim Timer1Tic As Boolean = False
    Dim SerialCommandTransmitBuffer(9) As Byte
    Dim SerialCommandReceiveBuffer(9) As Byte
    Public Const SYNC_1 As Byte = &HF1
    Public Const SYNC_2 As Byte = &HF2
    Public Const SYNC_3_SEND As Byte = &HF3
    Public Const SYNC_3_RECIEVE As Byte = &HF4
    Public Const COMMAND_LENGTH As Byte = 9
    Dim DataLogging As Boolean
    Dim fastfileName As String
    Dim fastfilePath As String
    Dim fastfile As System.IO.StreamWriter

    'Commands


    Public Const CMD_SET_MAGNETRON_CURRENT_REMOTE_MODE As Byte = &H10
    Public Const CMD_SET_MAGNETRON_CURRENT_LOCAL_MODE As Byte = &H11

    Public Const CMD_PAC_SET_MODE_A As Byte = &H20
    Public Const CMD_PAC_SET_MODE_B As Byte = &H21

    Public Const CMD_SET_MAGNETRON_MAGNET_CURRENT As Byte = &H2B
    Public Const CMD_SET_LAMBDA_VOLTAGE_MODE_A As Byte = &H2A
    Public Const CMD_SET_LAMBDA_VOLTAGE_MODE_B As Byte = &H2D
    Public Const CMD_SET_MAGNETRON_FILAMENT_VOLTAGE As Byte = &H2C
    Public Const CMD_SET_MAGNETRON_FILAMENT_CURRENT As Byte = &H2E



    Public Const CMD_READ_RAM_VALUE As Byte = &H30


    Public Const CMD_CLEAR_PROCESSOR_RESET_DATA As Byte = &H40

    Public Const CMD_DATA_LOGGING As Byte = &H50
    Public Const CMD_SET_HIGH_ENERGY_TARGET_CURRENT_SETPOINT As Byte = &H51
    Public Const CMD_SET_LOW_ENERGY_PORTAL_TARGET_CURRENT_SETPOINT As Byte = &H52
    Public Const CMD_SET_TARGET_CURRENT_STARTUP_PULSES As Byte = &H53
    Public Const CMD_SET_TARGET_CURRENT_STARTUP_MAGNITUDE As Byte = &H54
    Public Const CMD_SET_TARGET_CURRENT_STARTUP_DIRECTION As Byte = &H55
    Public Const CMD_SET_LOW_ENERGY_GANTRY_TARGET_CURRENT_SETPOINT As Byte = &H56
    Public Const CMD_SET_FILAMENT_OFFSET As Byte = &H57

    Public Const CMD_FORCE_SOFTWARE_RESTART As Byte = &HA0
    Public Const CMD_SOFTWARE_SKIP_WARMUP As Byte = &HA1


    Public Const CMD_SET_MAGNET_PS_CAL_DATA As Byte = &HD0
    Public Const CMD_READ_MAGNET_PS_CAL_DATA As Byte = &HD1
    Public Const CMD_SAVE_MAGNET_PS_CAL_DATA_TO_EEPROM As Byte = &HD2

    Public Const CMD_SET_FILAMENT_PS_CAL_DATA As Byte = &HD3
    Public Const CMD_READ_FILAMENT_PS_CAL_DATA As Byte = &HD4
    Public Const CMD_SAVE_FILAMENT_PS_CAL_DATA_TO_EEPROM As Byte = &HD5

    Public Const CMD_SET_THYR_CATHODE_PS_CAL_DATA As Byte = &HD6
    Public Const CMD_READ_THYR_CATHODE_PS_CAL_DATA As Byte = &HD7
    Public Const CMD_SAVE_THYR_CATHODE_PS_CAL_DATA_TO_EEPROM As Byte = &HD8

    Public Const CMD_SET_THYR_RESERVOIR_PS_CAL_DATA As Byte = &HD9
    Public Const CMD_READ_THYR_RESERVOIR_PS_CAL_DATA As Byte = &HDA
    Public Const CMD_SAVE_THYR_RESERVOIR_PS_CAL_DATA_TO_EEPROM As Byte = &HDB

    Public Const CMD_SET_HV_LAMBDA_MODE_A_CAL_DATA As Byte = &HDC
    Public Const CMD_READ_HV_LAMBDA_MODE_A_CAL_DATA As Byte = &HDD
    Public Const CMD_SAVE_HV_LAMBDA_MODE_A_CAL_DATA_TO_EEPROM As Byte = &HDE

    Public Const CMD_SET_HV_LAMBDA_MODE_B_CAL_DATA As Byte = &HDF
    Public Const CMD_READ_HV_LAMBDA_MODE_B_CAL_DATA As Byte = &HE0
    Public Const CMD_SAVE_HV_LAMBDA_MODE_B_CAL_DATA_TO_EEPROM As Byte = &HE1

    Public Const CMD_SET_MAGNETRON_MODE_A_CAL_DATA As Byte = &HE2
    Public Const CMD_READ_MAGNETRON_MODE_A_CAL_DATA As Byte = &HE3
    Public Const CMD_SAVE_MAGNETRON_MODE_A_CAL_DATA_TO_EEPROM As Byte = &HE4

    Public Const CMD_SET_MAGNETRON_MODE_B_CAL_DATA As Byte = &HE5
    Public Const CMD_READ_MAGNETRON_MODE_B_CAL_DATA As Byte = &HE6
    Public Const CMD_SAVE_MAGNETRON_MODE_B_CAL_DATA_TO_EEPROM As Byte = &HE7

    Public Const CMD_SET_CNTRL_CAL_DATA As Byte = &HE8
    Public Const CMD_READ_CNTRL_CAL_DATA As Byte = &HE9
    Public Const CMD_SAVE_CNTRL_CAL_DATA_TO_EEPROM As Byte = &HEA



    ' Ram Locations
    Public Const RAM_READ_STATE As Byte = &H1
    Public Const RAM_READ_VERSION As Byte = &H2
    Public Const RAM_READ_LOCAL_REMOTE_MAGNET_CURRENT_CONTROL As Byte = &H3
    Public Const RAM_READ_MAGNETRON_TYPE As Byte = &H4


    Public Const RAM_READ_THYR_CATH_HTR_VOTAGE_SET_POINT As Byte = &H11
    Public Const RAM_READ_THYR_CATH_HTR_VOTAGE_ADC As Byte = &H10
    Public Const RAM_READ_THYR_RESER_HTR_VOLTAGE_SET_POINT As Byte = &H13
    Public Const RAM_READ_THYR_RESER_HTR_VOLTAGE_ADC As Byte = &H12
    Public Const RAM_READ_CONTROL_BOARD_TYPE As Byte = &H5


    Public Const RAM_READ_MAGNETRON_MAGNET_CURRENT_SET_POINT As Byte = &H31
    Public Const RAM_READ_MAGNETRON_MAGNET_CURRENT_ADC As Byte = &H30
    Public Const RAM_READ_MAGNETRON_MAGNET_VOLTAGE_ADC As Byte = &H32

    Public Const RAM_READ_MAGNETRON_HEATER_VOLTAGE_SET_POINT As Byte = &H21
    Public Const RAM_READ_MAGNETRON_HEATER_VOLTAGE_ADC As Byte = &H20
    Public Const RAM_READ_MAGNETRON_HEATER_CURRENT_ADC As Byte = &H22
    Public Const RAM_READ_MAGNETRON_HEATER_CURRENT_SET_POINT As Byte = &H23


    Public Const RAM_READ_HV_LAMBDA_SET_POINT_MODE_A As Byte = &H40
    Public Const RAM_READ_HV_LAMBDA_SET_POINT_MODE_B As Byte = &H48



    Public Const RAM_READ_PREVIOUS_PULSE_MAGNETRON_VOLTAGE_ADC As Byte = &H50
    Public Const RAM_READ_PREVIOUS_PULSE_MAGNETRON_CURRENT_ADC As Byte = &H51


    Public Const RAM_READ_ARC_COUNTER_THIS_HV_ON As Byte = &H58
    Public Const RAM_READ_PULSE_COUNTER_THIS_HV_ON_HIGH_WORD As Byte = &H5D
    Public Const RAM_READ_PULSE_COUNTER_THIS_HV_ON_LOW_WORD As Byte = &H5E
    Public Const RAM_READ_ARC_COUNTER_PERSISTENT_HIGH_WORD As Byte = &H56
    Public Const RAM_READ_ARC_COUNTER_PERSISTENT_LOW_WORD As Byte = &H57
    Public Const RAM_READ_PULSE_COUNTER_PERSISTENT_WORD_3_MSB As Byte = &H59
    Public Const RAM_READ_PULSE_COUNTER_PERSISTENT_WORD_2 As Byte = &H5A
    Public Const RAM_READ_PULSE_COUNTER_PERSISTENT_WORD_1 As Byte = &H5B
    Public Const RAM_READ_PULSE_COUNTER_PERSISTENT_WORD_0_LSB As Byte = &H5C

    Public Const RAM_READ_AVERAGE_PULSE_ENERGY As Byte = &H60
    Public Const RAM_READ_AVERAGE_PULSE_FREQUENCY As Byte = &H61
    Public Const RAM_READ_AVERAGE_MAGNETRON_INPUT_POWER As Byte = &H62
    Public Const RAM_READ_HV_LAMBDA_VPEAK_ADC As Byte = &H63
    Public Const RAM_READ_HV_LAMBDA_VMON_ADC As Byte = &H64
    Public Const RAM_READ_FILAMENT_OFFSET As Byte = &H65


    Public Const RAM_READ_PULSE_MODE_A_FILTERED_CURRENT As Byte = &H70
    Public Const RAM_READ_PULSE_MODE_A_FILTERED_VOLTAGE As Byte = &H71
    Public Const RAM_READ_PULSE_MODE_A_MAX_CURRENT As Byte = &H72
    Public Const RAM_READ_PULSE_MODE_A_MIN_CURRENT As Byte = &H73
    Public Const RAM_READ_PULSE_MODE_A_MAX_VOLTAGE As Byte = &H74
    Public Const RAM_READ_PULSE_MODE_A_MIN_VOLTAGE As Byte = &H75

    Public Const RAM_READ_PULSE_MODE_B_FILTERED_CURRENT As Byte = &H78
    Public Const RAM_READ_PULSE_MODE_B_FILTERED_VOLTAGE As Byte = &H79
    Public Const RAM_READ_PULSE_MODE_B_MAX_CURRENT As Byte = &H7A
    Public Const RAM_READ_PULSE_MODE_B_MIN_CURRENT As Byte = &H7B
    Public Const RAM_READ_PULSE_MODE_B_MAX_VOLTAGE As Byte = &H7C
    Public Const RAM_READ_PULSE_MODE_B_MIN_VOLTAGE As Byte = &H7D



    Public Const RAM_READ_DEBUG_STATUS_REG As Byte = &H90
    Public Const RAM_READ_FAULT_MAGNETRON_FAULT_REG As Byte = &H91
    Public Const RAM_READ_FAULT_MAGNETRON_STATUS_REG As Byte = &H92
    Public Const RAM_READ_FAULT_MAGNETRON_WARNING_REG As Byte = &H93
    Public Const RAM_READ_FAULT_HIGH_VOLTAGE_FAULT_REG As Byte = &H94
    Public Const RAM_READ_FAULT_HIGH_VOLTAGE_STATUS_REG As Byte = &H95
    Public Const RAM_READ_FAULT_HIGH_VOLTAGE_WARNING_REG As Byte = &H96
    Public Const RAM_READ_FAULT_THYRATRON_FAULT_REG As Byte = &H97
    Public Const RAM_READ_FAULT_THYRATRON_STATUS_REG As Byte = &H98
    Public Const RAM_READ_FAULT_THYRATRON_WARNING_REG As Byte = &H99
    Public Const RAM_READ_FAULT_CONTROL_BOARD_FAULT_REG As Byte = &H9A
    Public Const RAM_READ_FAULT_CONTROL_BOARD_STATUS_REG As Byte = &H9B
    Public Const RAM_READ_FAULT_CONTROL_BOARD_WARNING_REG As Byte = &H9C



    Public Const RAM_READ_COUNT_MAGNETRON_CURRENT_ADC_GLITCH As Byte = &HA0
    Public Const RAM_READ_COUNT_MAGNETRON_VOLTAGE_ADC_GLITCH As Byte = &HA1
    Public Const RAM_READ_COUNT_I2C_BUS_ERROR As Byte = &HA2
    Public Const RAM_READ_COUNT_SPI1_BUS_ERROR As Byte = &HA3
    Public Const RAM_READ_COUNT_SPI2_BUS_ERROR As Byte = &HA4
    Public Const RAM_READ_COUNT_EXTERNAL_ADC_FALSE_TRIGGER As Byte = &HA5
    Public Const RAM_READ_COUNT_LTC2656_WRITE_ERROR As Byte = &HA6
    Public Const RAM_READ_COUNT_SETPOINT_NOT_VALID As Byte = &HA7
    Public Const RAM_READ_COUNT_SCALE16BIT_SATURATION As Byte = &HA8
    Public Const RAM_READ_COUNT_REVERSESCALE16BIT_SATURATION As Byte = &HA9

    Public Const RAM_READ_COUNT_TIMING_ERROR_INT1 As Byte = &HAA
    Public Const RAM_READ_COUNT_PROCESSOR_CRASH As Byte = &HAB
    Public Const RAM_READ_LAST_ACTION_BEFORE_CRASH As Byte = &HAC
    Public Const RAM_READ_COUNT_LVD_INTERRUPT As Byte = &HAD
    Public Const RAM_READ_LAST_OSCCON_BEFORE_CRASH As Byte = &HAE
    Public Const RAM_READ_PULSE_LATCH_RESET_ERROR As Byte = &HAF


    Public Const RAM_READ_HIGH_TARGET_CURRENT_SET_POINT As Byte = &HB0
    Public Const RAM_READ_LOW_TARGET_CURRENT_SET_POINT As Byte = &HB1
    Public Const RAM_READ_HIGH_TARGET_CURRENT_READING As Byte = &HB2
    Public Const RAM_READ_LOW_TARGET_CURRENT_READING As Byte = &HB3
    Public Const RAM_READ_TARGET_ADJUST_MAX_PULSES As Byte = &HB4
    Public Const RAM_READ_TARGET_ADJUST_MAX_MAGNITUDE As Byte = &HB5
    Public Const RAM_READ_TARGET_ADJUST_MAX_COOLDOWN As Byte = &HB6
    Public Const RAM_READ_TARGET_ADJUST_INITIAL_MAGNITUDE As Byte = &HB7


    Public Const EEPROM_V_SET_POINT As Byte = 0
    Public Const EEPROM_V_DAC_CAL_GAIN As Byte = 1
    Public Const EEPROM_V_DAC_CAL_OFFSET As Byte = 2
    Public Const EEPROM_V_ADC_CAL_GAIN As Byte = 3
    Public Const EEPROM_V_ADC_CAL_OFFSET As Byte = 4
    Public Const EEPROM_I_SET_POINT As Byte = 5
    Public Const EEPROM_I_DAC_CAL_GAIN As Byte = 6
    Public Const EEPROM_I_DAC_CAL_OFFSET As Byte = 7
    Public Const EEPROM_I_ADC_CAL_GAIN As Byte = 8
    Public Const EEPROM_I_ADC_CAL_OFFSET As Byte = 9
    Public Const EEPROM_UNUSED_1 As Byte = 10
    Public Const EEPROM_UNUSED_2 As Byte = 11
    Public Const EEPROM_UNUSED_3 As Byte = 12
    Public Const EEPROM_UNUSED_4 As Byte = 13
    Public Const EEPROM_UNUSED_5 As Byte = 14
    Public Const EEPROM_CRC As Byte = 15


    Public Const EEPROM_CNTRL_MAGNET_FACTOR_SQUARE As Byte = 0
    Public Const EEPROM_CNTRL_MAGNET_FACTOR_LINEAR As Byte = 1
    Public Const EEPROM_CNTRL_MAGNET_FACTOR_CONST As Byte = 2
    Public Const EEPROM_CNTRL_UNUSED_1 As Byte = 3
    Public Const EEPROM_CNTRL_UNUSED_2 As Byte = 4
    Public Const EEPROM_CNTRL_UNUSED_3 As Byte = 5
    Public Const EEPROM_CNTRL_UNUSED_4 As Byte = 6
    Public Const EEPROM_CNTRL_UNUSED_5 As Byte = 7
    Public Const EEPROM_CNTRL_UNUSED_6 As Byte = 8
    Public Const EEPROM_CNTRL_UNUSED_7 As Byte = 9
    Public Const EEPROM_CNTRL_UNUSED_8 As Byte = 10
    Public Const EEPROM_CNTRL_UNUSED_9 As Byte = 11
    Public Const EEPROM_CNTRL_UNUSED_10 As Byte = 12
    Public Const EEPROM_CNTRL_UNUSED_11 As Byte = 13
    Public Const EEPROM_CNTRL_UNUSED_12 As Byte = 14
    Public Const EEPROM_CNTRL_CRC As Byte = 15



    ' OLD  Commands
    'Public Const CMD_PAC_SET_OUTPUT_CURRENT As Byte = &H20

    'Public Const CMD_SET_LAMBDA_VOLTAGE As Byte = &H24

    'Public Const CMD_SET_MAGNETRON_HEATER_VOLTAGE As Byte = &H26


    'Public Const CMD_READ_EEPROM_REGISTER As Byte = &H31

    'Public Const CMD_SET_CONFIG_VALUE As Byte = &H40
    'Public Const CMD_RESET_PERSITENT_COUNTERS As Byte = &H41

    'Public Const CMD_MAGNETRON_DIRECT_CNTRL As Byte = &H51
    'Public Const CMD_MAGNETRON_PAC As Byte = &H52
    'Public Const CMD_MAGNETRON_PAC_DIGITAL As Byte = &H53
    'Public Const CMD_MAGNETRON_PAC_ANALOG As Byte = &H54
    'Public Const CMD_AUTO_STARTUP_ON As Byte = &H55
    'Public Const CMD_AUTO_STARTUP_OFF As Byte = &H56
    'Public Const CMD_HEATER_REMOTE_CNTRL As Byte = &H57
    'Public Const CMD_HEATER_AUTO_CNTRL As Byte = &H58
    'Public Const CMD_LOAD_DEFAULT_CONTROL_REGISTER As Byte = &H59
    'Public Const CMD_RESET_ALL_FAULTS As Byte = &H6A



    Public Const CMD_IGNORED_BY_CONTROL_BITS As Byte = &H90

    'Debugging Commands - DO NOT USE
    'Public Const CMD_ENABLE_MAGNETRON_HEATER_SUPPLY As Byte = &HD0
    'Public Const CMD_RESET_SPI_BUSSES As Byte = &HD1




    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBoxComPorts.Items.Add(sp)
        Next

        TextBoxBaudRate.Text = My.Settings.SelectedBaudRate

        Try
            ComboBoxComPorts.SelectedText = My.Settings.SelectedComPortString
        Catch ex As Exception
            MsgBox("Please select a Valid Com Port")
        End Try

        If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
            Dim verDeployed As System.Version = My.Application.Deployment.CurrentVersion
            LabelGUIVersion.Text = "GUI Version " & verDeployed.ToString
        Else
            LabelGUIVersion.Text = "GUI Version not Available in Debug Mode"
        End If

        LabelMCUVersion.Text = "PIC Version "

        'System.Reflection.Assembly.GetExecutingAssembly.GetName.Version.ToString()

        TextBoxSetMagnet.Visible = False
        ButtonSetMagnet.Visible = False


        Dim filePath As String
        filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "ETM_Modulator_Log.csv")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(filePath, True)


        file.Write("Time ,")
        file.Write("State ,")
        file.Write("Magnet Imon ,")
        file.Write("Heater Vmon ,")

        file.Write("Mode A Set Point ,")
        file.Write("Pulse Current Mode A ,")
        file.Write("Pulse Voltage Mode A ,")

        file.Write("Mode B Set Point ,")
        file.Write("Pulse Current Mode B ,")
        file.Write("Pulse Voltage Mode B ,")

        file.Write("PRF ,")
        file.Write("Lambda Vpeak ,")
        file.Write("Lambda Vmon ,")

        file.Write("Pulses ,")
        file.Write("Arcs ,")
        file.Write("Pulses Total ,")
        file.Write("Arcs Total")

        file.WriteLine("")

        file.Close()


    End Sub


    Private Sub OpenSerialPortETM()
        Try
            If SerialPortETM.IsOpen Then
                SerialPortETM.Close()
            End If
        Catch ex As Exception
            LabelComMsg.Text = "Serial Port Open/Close Error"
            ComError = True
        End Try

        Try
            SerialPortETM.PortName = My.Settings.SelectedComPortString
            SerialPortETM.ReadTimeout = 100
            SerialPortETM.BaudRate = My.Settings.SelectedBaudRate

        Catch ex As Exception
            MsgBox("Please Select a valid Com Port")
        End Try

        Try
            SerialPortETM.Open()
        Catch ex As Exception
            LabelComMsg.Text = "Serial Port Failed to Open"
            ComError = True
        End Try
    End Sub

    Private Sub CloseSerialPortETM()
        Try
            SerialPortETM.Close()
        Catch ex As Exception
            LabelComMsg.Text = "Serial Port Failed to Close"
            ComError = True
        End Try
    End Sub

    Private Function CheckCRC() As Boolean
        Dim CrcCheck As UInt16 = 0
        Dim CRC As UInt16 = 0
        CrcCheck = Int(SerialCommandReceiveBuffer(0))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(1))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(2))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(3))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(4))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(5))
        CrcCheck = CrcCheck + Int(SerialCommandReceiveBuffer(6))
        CRC = Int(SerialCommandReceiveBuffer(7)) * 256 + Int(SerialCommandReceiveBuffer(8))
        If CrcCheck = CRC Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function SendAndValidateCommand(ByVal commandB As Byte, ByVal locationB As Byte, ByVal DataHB As Byte, ByVal DataLB As Byte) As Boolean
        Dim valid_command As Boolean = False
        Dim CheckSum As UInt16 = 0




        SerialCommandTransmitBuffer(0) = SYNC_1
        SerialCommandTransmitBuffer(1) = SYNC_2
        SerialCommandTransmitBuffer(2) = SYNC_3_SEND
        SerialCommandTransmitBuffer(3) = commandB
        SerialCommandTransmitBuffer(4) = DataHB
        SerialCommandTransmitBuffer(5) = DataLB
        SerialCommandTransmitBuffer(6) = locationB


        CheckSum = SYNC_1
        CheckSum = CheckSum + SYNC_2
        CheckSum = CheckSum + SYNC_3_SEND + commandB + DataHB + DataLB + locationB

        SerialCommandTransmitBuffer(7) = Int(CheckSum / 256)
        SerialCommandTransmitBuffer(8) = CheckSum Mod 256



        LabelComMsg.Text = "-"

        Try
            If SerialPortETM.IsOpen = False Then
                OpenSerialPortETM()
            End If
            SerialPortETM.Write(SerialCommandTransmitBuffer, 0, 9)
        Catch ex As Exception
            LabelComMsg.Text = "Serial Port Failed to Write Command Buffer"
            Return False
        End Try

        Try
            SerialCommandReceiveBuffer(0) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(1) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(2) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(3) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(4) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(5) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(6) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(7) = SerialPortETM.ReadByte
            SerialCommandReceiveBuffer(8) = SerialPortETM.ReadByte

        Catch ex As Exception
            LabelComMsg.Text = "Serial Port Failed to Read Return"
            Return False
        End Try



        Try
            'TextBox1.Text = TransmitBuffer(3)
            'TextBox2.Text = TransmitBuffer(4)
            'TextBox3.Text = TransmitBuffer(5)
            'TextBox4.Text = TransmitBuffer(6)

            'TextBox5.Text = ReceiveBuffer(3)
            'TextBox6.Text = ReceiveBuffer(4)
            'TextBox7.Text = ReceiveBuffer(5)
            'TextBox8.Text = ReceiveBuffer(6)


            If SerialCommandReceiveBuffer(0) = SYNC_1 Then
                If SerialCommandReceiveBuffer(1) = SYNC_2 Then
                    If SerialCommandReceiveBuffer(2) = SYNC_3_RECIEVE Then
                        If CheckCRC() = True Then
                            valid_command = True
                            LabelComMsg.Text = "Message Sent/Received"
                            'A valid return was recieved.  Check what the responce was
                            If SerialCommandReceiveBuffer(3) <> SerialCommandTransmitBuffer(3) Then
                                'The pic was not able to process the command
                                If SerialCommandReceiveBuffer(3) = &H1 Then
                                    LabelComMsg.Text = "ETM Controller Responds - Unknown Command"
                                ElseIf SerialCommandReceiveBuffer(3) = CMD_IGNORED_BY_CONTROL_BITS Then
                                    LabelComMsg.Text = "ETM Controller Responds - Control Bits Prevent Command From Executing"
                                ElseIf SerialCommandReceiveBuffer(3) = &H22 Then
                                    LabelComMsg.Text = "ETM Controller Responds - Program Value out of Valid Range"
                                ElseIf SerialCommandReceiveBuffer(3) = &H23 Then
                                    LabelComMsg.Text = "ETM Controller Responds - EEPROM ERROR - Unable to set value"
                                Else
                                    LabelComMsg.Text = "ETM Controller Responce Error - " & SerialCommandReceiveBuffer(3)
                                End If
                            End If
                        End If
                    End If
                End If
            End If
            If valid_command <> True Then
                LabelComMsg.Text = "Serial Port return data was not valid"
                SerialPortETM.Close()
            End If
        Catch ex As Exception
            LabelComMsg.Text = "Error processing Serial Port data"
            ComError = True
            Return 0
        End Try

        ReturnData = SerialCommandReceiveBuffer(4) * 256 + SerialCommandReceiveBuffer(5)
        Return valid_command
    End Function


    Private Sub ReadAllFromRam()
        'Read Control State
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_STATE, 0, 0) = True Then
            If ReturnData = &H4 Then
                LabelState.Text = "Warm Up"
            ElseIf ReturnData = &H14 Then
                LabelState.Text = "System Cold Read"
            ElseIf ReturnData = &H24 Then
                LabelState.Text = "Warm UP"
            ElseIf ReturnData = &H34 Then
                LabelState.Text = "Warm Ready"
            ElseIf ReturnData = &H35 Then
                LabelState.Text = "HV Startup"
            ElseIf ReturnData = &H44 Then
                LabelState.Text = "HV ON"
            ElseIf ReturnData = &HA0 Then
                LabelState.Text = "MCU CORE FAULT"
            ElseIf ReturnData = &HA4 Then
                LabelState.Text = "Cold Fault"
            ElseIf ReturnData = &HA8 Then
                LabelState.Text = "Warm Fault"
            End If
        Else
            LabelState.Text = "error"
        End If


        ' Data for Magnetron Magnet
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_MAGNETRON_MAGNET_CURRENT_SET_POINT, 0, 0) = True Then
            LabelMagnetSetPoint.Text = Math.Round((ReturnData / 1000), 3) & " Amps"
        Else
            LabelMagnetSetPoint.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_MAGNETRON_MAGNET_VOLTAGE_ADC, 0, 0) = True Then
            LabelMagnetVmon.Text = Math.Round((ReturnData / 1000), 3) & " Volts"
        Else
            LabelMagnetVmon.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_MAGNETRON_MAGNET_CURRENT_ADC, 0, 0) = True Then
            LabelMagnetIMON.Text = Math.Round((ReturnData / 1000), 3) & " Amps"
        Else
            LabelMagnetIMON.Text = "error"
        End If

        ' Data for the Magnetron Heater
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_MAGNETRON_HEATER_VOLTAGE_SET_POINT, 0, 0) = True Then
            LabelHeaterSetPoint.Text = Math.Round((ReturnData / 1000), 3) & " Volts"
        Else
            LabelHeaterSetPoint.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_MAGNETRON_HEATER_CURRENT_SET_POINT, 0, 0) = True Then
            LabelHeaterISetPoint.Text = Math.Round((ReturnData / 1000), 3) & " Amps"
        Else
            LabelHeaterSetPoint.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_MAGNETRON_HEATER_VOLTAGE_ADC, 0, 0) = True Then
            LabelHeaterVmon.Text = Math.Round((ReturnData / 1000), 3) & " Volts"
        Else
            LabelHeaterVmon.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_MAGNETRON_HEATER_CURRENT_ADC, 0, 0) = True Then
            LabelHeaterImon.Text = Math.Round((ReturnData / 1000), 3) & " Amps"
        Else
            LabelHeaterImon.Text = "error"
        End If


        ' Data for Lambda Mode A
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_HV_LAMBDA_SET_POINT_MODE_A, 0, 0) = True Then
            LabelLambdaSetPointModeA.Text = ReturnData & " Volts"
            'TextBoxSetLambda.Text = ReturnData
        Else
            LabelLambdaSetPointModeA.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_MODE_A_FILTERED_CURRENT, 0, 0) = True Then
            LabelPulseCurrentModeA.Text = ReturnData / 100 & " Amps"
        Else
            LabelPulseCurrentModeA.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_MODE_A_MAX_CURRENT, 0, 0) = True Then
            LabelPulseCurrentMaxModeA.Text = ReturnData / 100 & " Amps"
        Else
            LabelPulseCurrentMaxModeA.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_MODE_A_MIN_CURRENT, 0, 0) = True Then
            LabelPulseCurrentMinModeA.Text = ReturnData / 100 & " Amps"
        Else
            LabelPulseCurrentMinModeA.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_MODE_A_FILTERED_VOLTAGE, 0, 0) = True Then
            LabelPulseVoltageModeA.Text = ReturnData & " Volts"
        Else
            LabelPulseVoltageModeA.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_MODE_A_MAX_VOLTAGE, 0, 0) = True Then
            LabelPulseVoltagetMaxModeA.Text = ReturnData & " Volts"
        Else
            LabelPulseVoltagetMaxModeA.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_MODE_A_MIN_VOLTAGE, 0, 0) = True Then
            LabelPulseVoltagetMinModeA.Text = ReturnData & " Volts"
        Else
            LabelPulseVoltagetMinModeA.Text = "error"
        End If



        ' Data for Lambda Mode B
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_HV_LAMBDA_SET_POINT_MODE_B, 0, 0) = True Then
            LabelLambdaSetPointModeB.Text = ReturnData & " Volts"
            'TextBoxSetLambda.Text = ReturnData
        Else
            LabelLambdaSetPointModeB.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_MODE_B_FILTERED_CURRENT, 0, 0) = True Then
            LabelPulseCurrentModeB.Text = ReturnData / 100 & " Amps"
        Else
            LabelPulseCurrentModeB.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_MODE_B_MAX_CURRENT, 0, 0) = True Then
            LabelPulseCurrentMaxModeB.Text = ReturnData / 100 & " Amps"
        Else
            LabelPulseCurrentMaxModeB.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_MODE_B_MIN_CURRENT, 0, 0) = True Then
            LabelPulseCurrentMinModeB.Text = ReturnData / 100 & " Amps"
        Else
            LabelPulseCurrentMinModeB.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_MODE_B_FILTERED_VOLTAGE, 0, 0) = True Then
            LabelPulseVoltageModeB.Text = ReturnData & " Volts"
        Else
            LabelPulseVoltageModeB.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_MODE_B_MAX_VOLTAGE, 0, 0) = True Then
            LabelPulseVoltagetMaxModeB.Text = ReturnData & " Volts"
        Else
            LabelPulseVoltagetMaxModeB.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_MODE_B_MIN_VOLTAGE, 0, 0) = True Then
            LabelPulseVoltagetMinModeB.Text = ReturnData & " Volts"
        Else
            LabelPulseVoltagetMinModeB.Text = "error"
        End If



        ' Data for Thyratron Cathode Heater
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_THYR_CATH_HTR_VOTAGE_SET_POINT, 0, 0) = True Then
            LabelThyrHtrSetPoint.Text = Math.Round((ReturnData / 1000), 3) & " Volts"
        Else
            LabelThyrHtrSetPoint.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_THYR_CATH_HTR_VOTAGE_ADC, 0, 0) = True Then
            LabelThyrHeaterVmon.Text = Math.Round((ReturnData / 1000), 3) & " Volts"
        Else
            LabelThyrHeaterVmon.Text = "error"
        End If


        ' Data for Thyratron Reservoir Heater
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_THYR_RESER_HTR_VOLTAGE_SET_POINT, 0, 0) = True Then
            LabelThyrResrHtrSetPoint.Text = Math.Round((ReturnData / 1000), 3) & " Volts"
        Else
            LabelThyrResrHtrSetPoint.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_THYR_RESER_HTR_VOLTAGE_ADC, 0, 0) = True Then
            LabelThyrResrHeaterVmon.Text = Math.Round((ReturnData / 1000), 3) & " Volts"
        Else
            LabelThyrResrHeaterVmon.Text = "error"
        End If

        ' Data for Magnetron
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PREVIOUS_PULSE_MAGNETRON_CURRENT_ADC, 0, 0) = True Then
            LabelMagnetronCurrent.Text = ReturnData / 100 & " Amps"
        Else
            LabelMagnetronCurrent.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PREVIOUS_PULSE_MAGNETRON_VOLTAGE_ADC, 0, 0) = True Then
            LabelMagnetronVoltage.Text = ReturnData & " Volts"
        Else
            LabelMagnetronVoltage.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_AVERAGE_PULSE_ENERGY, 0, 0) = True Then
            LabelEnergyPerPulse.Text = Math.Round((ReturnData / 1000), 2) & " Joules"
        Else
            LabelThyrResrHtrSetPoint.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_AVERAGE_PULSE_FREQUENCY, 0, 0) = True Then
            LabelPRF.Text = Math.Round((ReturnData / 10), 1) & " Hertz"
        Else
            LabelThyrResrHeaterVmon.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_AVERAGE_MAGNETRON_INPUT_POWER, 0, 0) = True Then
            LabelMagnetronPower.Text = Math.Round((ReturnData), 0) & " Watts"
        Else
            LabelThyrResrHeaterVmon.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_HV_LAMBDA_VPEAK_ADC, 0, 0) = True Then
            LabelLambdaVpeak.Text = Math.Round((ReturnData), 0) & " Volts"
        Else
            LabelLambdaVpeak.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_HV_LAMBDA_VMON_ADC, 0, 0) = True Then
            LabelLambdaVmon.Text = Math.Round((ReturnData), 0) & " Volts"
        Else
            LabelLambdaVmon.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_VERSION, 0, 0) = True Then
            Dim value As Integer = ReturnData
            LabelMCUVersion.Text = "MCU Version 0x" & value.ToString("X4")
        Else
            LabelMCUVersion.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_MAGNETRON_TYPE, 0, 0) = True Then
            LabelMagnetronType.Text = "Type = MG" & Math.Round((ReturnData), 0)
        Else
            LabelMagnetronType.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_CONTROL_BOARD_TYPE, 0, 0) = True Then
            LabelControlBoardType.Text = "Type = A" & Math.Round((ReturnData), 0)
        Else
            LabelControlBoardType.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_LOCAL_REMOTE_MAGNET_CURRENT_CONTROL, 0, 0) = True Then
            If ReturnData = 0 Then
                TextBoxSetMagnet.Visible = False
                ButtonSetMagnet.Visible = False
                LabelMagnetControlStatus.Text = "Magnet Current Set From Mode A Program"
            Else
                LabelMagnetControlStatus.Text = "Magnet Current Set From GUI"
                TextBoxSetMagnet.Visible = True
                ButtonSetMagnet.Visible = True
            End If
        End If

        'Counters
        Dim counter32 As UInt32
        Dim Counter64 As UInt64

        ' Pulses this HV on 32 bit
        LabelPulsesHVon.Text = "Error"
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_COUNTER_THIS_HV_ON_HIGH_WORD, 0, 0) = True Then
            counter32 = ReturnData * 2 ^ 16
            If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_COUNTER_THIS_HV_ON_LOW_WORD, 0, 0) = True Then
                counter32 = counter32 + ReturnData
                LabelPulsesHVon.Text = counter32
            End If
        End If

        ' Arcs this HV ON 16 bit
        LabelArcsHVOn.Text = "error"
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_ARC_COUNTER_THIS_HV_ON, 0, 0) = True Then
            LabelArcsHVOn.Text = ReturnData
        End If


        'Pulse Total 64 bit
        LabelPulsesTotal.Text = "Error"
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_COUNTER_PERSISTENT_WORD_3_MSB, 0, 0) = True Then
            Counter64 = ReturnData * 2 ^ 48
            If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_COUNTER_PERSISTENT_WORD_2, 0, 0) = True Then
                Counter64 = Counter64 + ReturnData * 2 ^ 32
                If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_COUNTER_PERSISTENT_WORD_1, 0, 0) = True Then
                    Counter64 = Counter64 + ReturnData * 2 ^ 16
                    If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_COUNTER_PERSISTENT_WORD_0_LSB, 0, 0) = True Then
                        Counter64 = Counter64 + ReturnData
                        LabelPulsesTotal.Text = Counter64
                    End If
                End If
            End If
        End If


        ' Arcs Total 32 bit
        LabelArcsTotal.Text = "Error"
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_ARC_COUNTER_PERSISTENT_HIGH_WORD, 0, 0) = True Then
            counter32 = ReturnData * 2 ^ 16
            If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_ARC_COUNTER_PERSISTENT_LOW_WORD, 0, 0) = True Then
                counter32 = counter32 + ReturnData
                LabelArcsTotal.Text = counter32
            End If
        End If


        ' Read Debug Counters
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_COUNT_MAGNETRON_CURRENT_ADC_GLITCH, 0, 0) = True Then
            LabelMagnetronCurrentGlitch.Text = ReturnData
        Else
            LabelMagnetronCurrentGlitch.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_COUNT_MAGNETRON_VOLTAGE_ADC_GLITCH, 0, 0) = True Then
            LabelMagnetronVoltageGlitch.Text = ReturnData
        Else
            LabelMagnetronVoltageGlitch.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_COUNT_I2C_BUS_ERROR, 0, 0) = True Then
            LabelI2CBusError.Text = ReturnData
        Else
            LabelI2CBusError.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_COUNT_SPI1_BUS_ERROR, 0, 0) = True Then
            LabelSPI1BusError.Text = ReturnData
        Else
            LabelSPI1BusError.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_COUNT_SPI2_BUS_ERROR, 0, 0) = True Then
            LabelSPI2BusError.Text = ReturnData
        Else
            LabelSPI2BusError.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_COUNT_EXTERNAL_ADC_FALSE_TRIGGER, 0, 0) = True Then
            LabelADCFalseTrigger.Text = ReturnData
        Else
            LabelADCFalseTrigger.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_COUNT_LTC2656_WRITE_ERROR, 0, 0) = True Then
            LabelLTC2656WriteError.Text = ReturnData
        Else
            LabelLTC2656WriteError.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_COUNT_SETPOINT_NOT_VALID, 0, 0) = True Then
            LabelInvalidSetPoint.Text = ReturnData
        Else
            LabelInvalidSetPoint.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_COUNT_SCALE16BIT_SATURATION, 0, 0) = True Then
            LabelScale16BitSaturation.Text = ReturnData
        Else
            LabelScale16BitSaturation.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_COUNT_REVERSESCALE16BIT_SATURATION, 0, 0) = True Then
            LabelReverseScale16BitSaturation.Text = ReturnData
        Else
            LabelReverseScale16BitSaturation.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_COUNT_TIMING_ERROR_INT1, 0, 0) = True Then
            LabelInt1TimingError.Text = ReturnData
        Else
            LabelInt1TimingError.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_COUNT_PROCESSOR_CRASH, 0, 0) = True Then
            LabeluPCrashCount.Text = ReturnData
        Else
            LabeluPCrashCount.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_LAST_ACTION_BEFORE_CRASH, 0, 0) = True Then
            LabelActionBeforeCrash.Text = ReturnData
        Else
            LabelActionBeforeCrash.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_COUNT_LVD_INTERRUPT, 0, 0) = True Then
            LabelLVDIntCount.Text = ReturnData
        Else
            LabelLVDIntCount.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_LAST_OSCCON_BEFORE_CRASH, 0, 0) = True Then
            LabelOscConBeforeCrash.Text = ReturnData
        Else
            LabelOscConBeforeCrash.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_PULSE_LATCH_RESET_ERROR, 0, 0) = True Then
            LabelPulseLatchError.Text = ReturnData
        Else
            LabelPulseLatchError.Text = "error"
        End If


        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_HIGH_TARGET_CURRENT_SET_POINT, 0, 0) = True Then
            LabelModeATargetISetPoint.Text = ReturnData
        Else
            LabelModeATargetISetPoint.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_LOW_TARGET_CURRENT_SET_POINT, 0, 0) = True Then
            LabelModeBTargetISetPoint.Text = ReturnData
        Else
            LabelModeBTargetISetPoint.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_HIGH_TARGET_CURRENT_READING, 0, 0) = True Then
            LabelModeATargetIMonitor.Text = ReturnData
        Else
            LabelModeATargetIMonitor.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_LOW_TARGET_CURRENT_READING, 0, 0) = True Then
            LabelModeBTargetIMonitor.Text = ReturnData
        Else
            LabelModeBTargetIMonitor.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_TARGET_ADJUST_MAX_MAGNITUDE, 0, 0) = True Then
            LabelTargetAdjustMaxMag.Text = ReturnData
        Else
            LabelTargetAdjustMaxMag.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_TARGET_ADJUST_MAX_COOLDOWN, 0, 0) = True Then
            LabelTargetAdjustMaxTime.Text = ReturnData
        Else
            LabelTargetAdjustMaxTime.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_TARGET_ADJUST_MAX_PULSES, 0, 0) = True Then
            LabelTargetAdjustPulse.Text = ReturnData
        Else
            LabelTargetAdjustPulse.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_TARGET_ADJUST_INITIAL_MAGNITUDE, 0, 0) = True Then
            LabelTargetAdjustInitial.Text = ReturnData
        Else
            LabelTargetAdjustInitial.Text = "error"
        End If

        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FILAMENT_OFFSET, 0, 0) = True Then
            LabelFilamentOffset.Text = ConvertToSignedInteger(ReturnData)
        Else
            LabelFilamentOffset.Text = "error"
        End If

        LabelTime.Text = DateTime.Now



    End Sub


    Private Sub ComboBoxComPorts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBoxComPorts.SelectedIndexChanged
        Try
            My.Settings.SelectedComPortString = ComboBoxComPorts.SelectedItem.ToString

        Catch ex As Exception
            MsgBox("Please select a Valid Com Port")
        End Try
        Try
            OpenSerialPortETM()
        Catch ex As Exception
            MsgBox("Unable to open selected Com Port")
        End Try


    End Sub

    Private Sub ReadAllFaults()

        'Magnetron Faults
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FAULT_MAGNETRON_FAULT_REG, 0, 0) = True Then
            If (ReturnData And &H1) Then
                CheckBoxMagnetronFaultBit0.Checked = True
            Else
                CheckBoxMagnetronFaultBit0.Checked = False
            End If
            If (ReturnData And &H2) Then
                CheckBoxMagnetronFaultBit1.Checked = True
            Else
                CheckBoxMagnetronFaultBit1.Checked = False
            End If
            If (ReturnData And &H4) Then
                CheckBoxMagnetronFaultBit2.Checked = True
            Else
                CheckBoxMagnetronFaultBit2.Checked = False
            End If
            If (ReturnData And &H8) Then
                CheckBoxMagnetronFaultBit3.Checked = True
            Else
                CheckBoxMagnetronFaultBit3.Checked = False
            End If
            If (ReturnData And &H10) Then
                CheckBoxMagnetronFaultBit4.Checked = True
            Else
                CheckBoxMagnetronFaultBit4.Checked = False
            End If
            If (ReturnData And &H20) Then
                CheckBoxMagnetronFaultBit5.Checked = True
            Else
                CheckBoxMagnetronFaultBit5.Checked = False
            End If
            If (ReturnData And &H40) Then
                CheckBoxMagnetronFaultBit6.Checked = True
            Else
                CheckBoxMagnetronFaultBit6.Checked = False
            End If
            If (ReturnData And &H80) Then
                CheckBoxMagnetronFaultBit7.Checked = True
            Else
                CheckBoxMagnetronFaultBit7.Checked = False
            End If
            If (ReturnData And &H100) Then
                CheckBoxMagnetronFaultBit8.Checked = True
            Else
                CheckBoxMagnetronFaultBit8.Checked = False
            End If
            If (ReturnData And &H200) Then
                CheckBoxMagnetronFaultBit9.Checked = True
            Else
                CheckBoxMagnetronFaultBit9.Checked = False
            End If
            If (ReturnData And &H400) Then
                CheckBoxMagnetronFaultBit10.Checked = True
            Else
                CheckBoxMagnetronFaultBit10.Checked = False
            End If
            If (ReturnData And &H800) Then
                CheckBoxMagnetronFaultBit11.Checked = True
            Else
                CheckBoxMagnetronFaultBit11.Checked = False
            End If
            If (ReturnData And &H1000) Then
                CheckBoxMagnetronFaultBit12.Checked = True
            Else
                CheckBoxMagnetronFaultBit12.Checked = False
            End If
            If (ReturnData And &H2000) Then
                CheckBoxMagnetronFaultBit13.Checked = True
            Else
                CheckBoxMagnetronFaultBit13.Checked = False
            End If
            If (ReturnData And &H4000) Then
                CheckBoxMagnetronFaultBit14.Checked = True
            Else
                CheckBoxMagnetronFaultBit14.Checked = False
            End If
            If (ReturnData And &H8000) Then
                CheckBoxMagnetronFaultBit15.Checked = True
            Else
                CheckBoxMagnetronFaultBit15.Checked = False
            End If
        End If



        'High Voltage Faults
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FAULT_HIGH_VOLTAGE_FAULT_REG, 0, 0) = True Then
            If (ReturnData And &H1) Then
                CheckBoxHVFaultBit0.Checked = True
            Else
                CheckBoxHVFaultBit0.Checked = False
            End If
            If (ReturnData And &H2) Then
                CheckBoxHVFaultBit1.Checked = True
            Else
                CheckBoxHVFaultBit1.Checked = False
            End If
            If (ReturnData And &H4) Then
                CheckBoxHVFaultBit2.Checked = True
            Else
                CheckBoxHVFaultBit2.Checked = False
            End If
            If (ReturnData And &H8) Then
                CheckBoxHVFaultBit3.Checked = True
            Else
                CheckBoxHVFaultBit3.Checked = False
            End If
            If (ReturnData And &H10) Then
                CheckBoxHVFaultBit4.Checked = True
            Else
                CheckBoxHVFaultBit4.Checked = False
            End If
            If (ReturnData And &H20) Then
                CheckBoxHVFaultBit5.Checked = True
            Else
                CheckBoxHVFaultBit5.Checked = False
            End If
            If (ReturnData And &H40) Then
                CheckBoxHVFaultBit6.Checked = True
            Else
                CheckBoxHVFaultBit6.Checked = False
            End If
            If (ReturnData And &H80) Then
                CheckBoxHVFaultBit7.Checked = True
            Else
                CheckBoxHVFaultBit7.Checked = False
            End If
            If (ReturnData And &H100) Then
                CheckBoxHVFaultBit8.Checked = True
            Else
                CheckBoxHVFaultBit8.Checked = False
            End If
            If (ReturnData And &H200) Then
                CheckBoxHVFaultBit9.Checked = True
            Else
                CheckBoxHVFaultBit9.Checked = False
            End If
            If (ReturnData And &H400) Then
                CheckBoxHVFaultBit10.Checked = True
            Else
                CheckBoxHVFaultBit10.Checked = False
            End If
            If (ReturnData And &H800) Then
                CheckBoxHVFaultBit11.Checked = True
            Else
                CheckBoxHVFaultBit11.Checked = False
            End If
            If (ReturnData And &H1000) Then
                CheckBoxHVFaultBit12.Checked = True
            Else
                CheckBoxHVFaultBit12.Checked = False
            End If
            If (ReturnData And &H2000) Then
                CheckBoxHVFaultBit13.Checked = True
            Else
                CheckBoxHVFaultBit13.Checked = False
            End If
            If (ReturnData And &H4000) Then
                CheckBoxHVFaultBit14.Checked = True
            Else
                CheckBoxHVFaultBit14.Checked = False
            End If
            If (ReturnData And &H8000) Then
                CheckBoxHVFaultBit15.Checked = True
            Else
                CheckBoxHVFaultBit15.Checked = False
            End If
        End If


        ' Thyratron Faults
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FAULT_THYRATRON_FAULT_REG, 0, 0) = True Then
            If (ReturnData And &H1) Then
                CheckBoxThyratronFaultBit0.Checked = True
            Else
                CheckBoxThyratronFaultBit0.Checked = False
            End If
            If (ReturnData And &H2) Then
                CheckBoxThyratronFaultBit1.Checked = True
            Else
                CheckBoxThyratronFaultBit1.Checked = False
            End If
            If (ReturnData And &H4) Then
                CheckBoxThyratronFaultBit2.Checked = True
            Else
                CheckBoxThyratronFaultBit2.Checked = False
            End If
            If (ReturnData And &H8) Then
                CheckBoxThyratronFaultBit3.Checked = True
            Else
                CheckBoxThyratronFaultBit3.Checked = False
            End If
            If (ReturnData And &H10) Then
                CheckBoxThyratronFaultBit4.Checked = True
            Else
                CheckBoxThyratronFaultBit4.Checked = False
            End If
            If (ReturnData And &H20) Then
                CheckBoxThyratronFaultBit5.Checked = True
            Else
                CheckBoxThyratronFaultBit5.Checked = False
            End If
            If (ReturnData And &H40) Then
                CheckBoxThyratronFaultBit6.Checked = True
            Else
                CheckBoxThyratronFaultBit6.Checked = False
            End If
            If (ReturnData And &H80) Then
                CheckBoxThyratronFaultBit7.Checked = True
            Else
                CheckBoxThyratronFaultBit7.Checked = False
            End If
            If (ReturnData And &H100) Then
                CheckBoxThyratronFaultBit8.Checked = True
            Else
                CheckBoxThyratronFaultBit8.Checked = False
            End If
            If (ReturnData And &H200) Then
                CheckBoxThyratronFaultBit9.Checked = True
            Else
                CheckBoxThyratronFaultBit9.Checked = False
            End If
            If (ReturnData And &H400) Then
                CheckBoxThyratronFaultBit10.Checked = True
            Else
                CheckBoxThyratronFaultBit10.Checked = False
            End If
            If (ReturnData And &H800) Then
                CheckBoxThyratronFaultBit11.Checked = True
            Else
                CheckBoxThyratronFaultBit11.Checked = False
            End If
            If (ReturnData And &H1000) Then
                CheckBoxThyratronFaultBit12.Checked = True
            Else
                CheckBoxThyratronFaultBit12.Checked = False
            End If
            If (ReturnData And &H2000) Then
                CheckBoxThyratronFaultBit13.Checked = True
            Else
                CheckBoxThyratronFaultBit13.Checked = False
            End If
            If (ReturnData And &H4000) Then
                CheckBoxThyratronFaultBit14.Checked = True
            Else
                CheckBoxThyratronFaultBit14.Checked = False
            End If
            If (ReturnData And &H8000) Then
                CheckBoxThyratronFaultBit15.Checked = True
            Else
                CheckBoxThyratronFaultBit15.Checked = False
            End If
        End If



        'Control Board Faults
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FAULT_CONTROL_BOARD_FAULT_REG, 0, 0) = True Then
            If (ReturnData And &H1) Then
                CheckBoxControlBoardFaultBit0.Checked = True
            Else
                CheckBoxControlBoardFaultBit0.Checked = False
            End If
            If (ReturnData And &H2) Then
                CheckBoxControlBoardFaultBit1.Checked = True
            Else
                CheckBoxControlBoardFaultBit1.Checked = False
            End If
            If (ReturnData And &H4) Then
                CheckBoxControlBoardFaultBit2.Checked = True
            Else
                CheckBoxControlBoardFaultBit2.Checked = False
            End If
            If (ReturnData And &H8) Then
                CheckBoxControlBoardFaultBit3.Checked = True
            Else
                CheckBoxControlBoardFaultBit3.Checked = False
            End If
            If (ReturnData And &H10) Then
                CheckBoxControlBoardFaultBit4.Checked = True
            Else
                CheckBoxControlBoardFaultBit4.Checked = False
            End If
            If (ReturnData And &H20) Then
                CheckBoxControlBoardFaultBit5.Checked = True
            Else
                CheckBoxControlBoardFaultBit5.Checked = False
            End If
            If (ReturnData And &H40) Then
                CheckBoxControlBoardFaultBit6.Checked = True
            Else
                CheckBoxControlBoardFaultBit6.Checked = False
            End If
            If (ReturnData And &H80) Then
                CheckBoxControlBoardFaultBit7.Checked = True
            Else
                CheckBoxControlBoardFaultBit7.Checked = False
            End If
            If (ReturnData And &H100) Then
                CheckBoxControlBoardFaultBit8.Checked = True
            Else
                CheckBoxControlBoardFaultBit8.Checked = False
            End If
            If (ReturnData And &H200) Then
                CheckBoxControlBoardFaultBit9.Checked = True
            Else
                CheckBoxControlBoardFaultBit9.Checked = False
            End If
            If (ReturnData And &H400) Then
                CheckBoxControlBoardFaultBit10.Checked = True
            Else
                CheckBoxControlBoardFaultBit10.Checked = False
            End If
            If (ReturnData And &H800) Then
                CheckBoxControlBoardFaultBit11.Checked = True
            Else
                CheckBoxControlBoardFaultBit11.Checked = False
            End If
            If (ReturnData And &H1000) Then
                CheckBoxControlBoardFaultBit12.Checked = True
            Else
                CheckBoxControlBoardFaultBit12.Checked = False
            End If
            If (ReturnData And &H2000) Then
                CheckBoxControlBoardFaultBit13.Checked = True
            Else
                CheckBoxControlBoardFaultBit13.Checked = False
            End If
            If (ReturnData And &H4000) Then
                CheckBoxControlBoardFaultBit14.Checked = True
            Else
                CheckBoxControlBoardFaultBit14.Checked = False
            End If
            If (ReturnData And &H8000) Then
                CheckBoxControlBoardFaultBit15.Checked = True
            Else
                CheckBoxControlBoardFaultBit15.Checked = False
            End If
        End If



        'Magnetron Statuss
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FAULT_MAGNETRON_STATUS_REG, 0, 0) = True Then
            If (ReturnData And &H1) Then
                CheckBoxMagnetronStatusBit0.Checked = True
            Else
                CheckBoxMagnetronStatusBit0.Checked = False
            End If
            If (ReturnData And &H2) Then
                CheckBoxMagnetronStatusBit1.Checked = True
            Else
                CheckBoxMagnetronStatusBit1.Checked = False
            End If
            If (ReturnData And &H4) Then
                CheckBoxMagnetronStatusBit2.Checked = True
            Else
                CheckBoxMagnetronStatusBit2.Checked = False
            End If
            If (ReturnData And &H8) Then
                CheckBoxMagnetronStatusBit3.Checked = True
            Else
                CheckBoxMagnetronStatusBit3.Checked = False
            End If
            If (ReturnData And &H10) Then
                CheckBoxMagnetronStatusBit4.Checked = True
            Else
                CheckBoxMagnetronStatusBit4.Checked = False
            End If
            If (ReturnData And &H20) Then
                CheckBoxMagnetronStatusBit5.Checked = True
            Else
                CheckBoxMagnetronStatusBit5.Checked = False
            End If
            If (ReturnData And &H40) Then
                CheckBoxMagnetronStatusBit6.Checked = True
            Else
                CheckBoxMagnetronStatusBit6.Checked = False
            End If
            If (ReturnData And &H80) Then
                CheckBoxMagnetronStatusBit7.Checked = True
            Else
                CheckBoxMagnetronStatusBit7.Checked = False
            End If
            If (ReturnData And &H100) Then
                CheckBoxMagnetronStatusBit8.Checked = True
            Else
                CheckBoxMagnetronStatusBit8.Checked = False
            End If
            If (ReturnData And &H200) Then
                CheckBoxMagnetronStatusBit9.Checked = True
            Else
                CheckBoxMagnetronStatusBit9.Checked = False
            End If
            If (ReturnData And &H400) Then
                CheckBoxMagnetronStatusBit10.Checked = True
            Else
                CheckBoxMagnetronStatusBit10.Checked = False
            End If
            If (ReturnData And &H800) Then
                CheckBoxMagnetronStatusBit11.Checked = True
            Else
                CheckBoxMagnetronStatusBit11.Checked = False
            End If
            If (ReturnData And &H1000) Then
                CheckBoxMagnetronStatusBit12.Checked = True
            Else
                CheckBoxMagnetronStatusBit12.Checked = False
            End If
            If (ReturnData And &H2000) Then
                CheckBoxMagnetronStatusBit13.Checked = True
            Else
                CheckBoxMagnetronStatusBit13.Checked = False
            End If
            If (ReturnData And &H4000) Then
                CheckBoxMagnetronStatusBit14.Checked = True
            Else
                CheckBoxMagnetronStatusBit14.Checked = False
            End If
            If (ReturnData And &H8000) Then
                CheckBoxMagnetronStatusBit15.Checked = True
            Else
                CheckBoxMagnetronStatusBit15.Checked = False
            End If
        End If



        'High Voltage Statuss
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FAULT_HIGH_VOLTAGE_STATUS_REG, 0, 0) = True Then
            If (ReturnData And &H1) Then
                CheckBoxHVStatusBit0.Checked = True
            Else
                CheckBoxHVStatusBit0.Checked = False
            End If
            If (ReturnData And &H2) Then
                CheckBoxHVStatusBit1.Checked = True
            Else
                CheckBoxHVStatusBit1.Checked = False
            End If
            If (ReturnData And &H4) Then
                CheckBoxHVStatusBit2.Checked = True
            Else
                CheckBoxHVStatusBit2.Checked = False
            End If
            If (ReturnData And &H8) Then
                CheckBoxHVStatusBit3.Checked = True
            Else
                CheckBoxHVStatusBit3.Checked = False
            End If
            If (ReturnData And &H10) Then
                CheckBoxHVStatusBit4.Checked = True
            Else
                CheckBoxHVStatusBit4.Checked = False
            End If
            If (ReturnData And &H20) Then
                CheckBoxHVStatusBit5.Checked = True
            Else
                CheckBoxHVStatusBit5.Checked = False
            End If
            If (ReturnData And &H40) Then
                CheckBoxHVStatusBit6.Checked = True
            Else
                CheckBoxHVStatusBit6.Checked = False
            End If
            If (ReturnData And &H80) Then
                CheckBoxHVStatusBit7.Checked = True
            Else
                CheckBoxHVStatusBit7.Checked = False
            End If
            If (ReturnData And &H100) Then
                CheckBoxHVStatusBit8.Checked = True
            Else
                CheckBoxHVStatusBit8.Checked = False
            End If
            If (ReturnData And &H200) Then
                CheckBoxHVStatusBit9.Checked = True
            Else
                CheckBoxHVStatusBit9.Checked = False
            End If
            If (ReturnData And &H400) Then
                CheckBoxHVStatusBit10.Checked = True
            Else
                CheckBoxHVStatusBit10.Checked = False
            End If
            If (ReturnData And &H800) Then
                CheckBoxHVStatusBit11.Checked = True
            Else
                CheckBoxHVStatusBit11.Checked = False
            End If
            If (ReturnData And &H1000) Then
                CheckBoxHVStatusBit12.Checked = True
            Else
                CheckBoxHVStatusBit12.Checked = False
            End If
            If (ReturnData And &H2000) Then
                CheckBoxHVStatusBit13.Checked = True
            Else
                CheckBoxHVStatusBit13.Checked = False
            End If
            If (ReturnData And &H4000) Then
                CheckBoxHVStatusBit14.Checked = True
            Else
                CheckBoxHVStatusBit14.Checked = False
            End If
            If (ReturnData And &H8000) Then
                CheckBoxHVStatusBit15.Checked = True
            Else
                CheckBoxHVStatusBit15.Checked = False
            End If
        End If


        ' Thyratron Statuss
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FAULT_THYRATRON_STATUS_REG, 0, 0) = True Then
            If (ReturnData And &H1) Then
                CheckBoxThyratronStatusBit0.Checked = True
            Else
                CheckBoxThyratronStatusBit0.Checked = False
            End If
            If (ReturnData And &H2) Then
                CheckBoxThyratronStatusBit1.Checked = True
            Else
                CheckBoxThyratronStatusBit1.Checked = False
            End If
            If (ReturnData And &H4) Then
                CheckBoxThyratronStatusBit2.Checked = True
            Else
                CheckBoxThyratronStatusBit2.Checked = False
            End If
            If (ReturnData And &H8) Then
                CheckBoxThyratronStatusBit3.Checked = True
            Else
                CheckBoxThyratronStatusBit3.Checked = False
            End If
            If (ReturnData And &H10) Then
                CheckBoxThyratronStatusBit4.Checked = True
            Else
                CheckBoxThyratronStatusBit4.Checked = False
            End If
            If (ReturnData And &H20) Then
                CheckBoxThyratronStatusBit5.Checked = True
            Else
                CheckBoxThyratronStatusBit5.Checked = False
            End If
            If (ReturnData And &H40) Then
                CheckBoxThyratronStatusBit6.Checked = True
            Else
                CheckBoxThyratronStatusBit6.Checked = False
            End If
            If (ReturnData And &H80) Then
                CheckBoxThyratronStatusBit7.Checked = True
            Else
                CheckBoxThyratronStatusBit7.Checked = False
            End If
            If (ReturnData And &H100) Then
                CheckBoxThyratronStatusBit8.Checked = True
            Else
                CheckBoxThyratronStatusBit8.Checked = False
            End If
            If (ReturnData And &H200) Then
                CheckBoxThyratronStatusBit9.Checked = True
            Else
                CheckBoxThyratronStatusBit9.Checked = False
            End If
            If (ReturnData And &H400) Then
                CheckBoxThyratronStatusBit10.Checked = True
            Else
                CheckBoxThyratronStatusBit10.Checked = False
            End If
            If (ReturnData And &H800) Then
                CheckBoxThyratronStatusBit11.Checked = True
            Else
                CheckBoxThyratronStatusBit11.Checked = False
            End If
            If (ReturnData And &H1000) Then
                CheckBoxThyratronStatusBit12.Checked = True
            Else
                CheckBoxThyratronStatusBit12.Checked = False
            End If
            If (ReturnData And &H2000) Then
                CheckBoxThyratronStatusBit13.Checked = True
            Else
                CheckBoxThyratronStatusBit13.Checked = False
            End If
            If (ReturnData And &H4000) Then
                CheckBoxThyratronStatusBit14.Checked = True
            Else
                CheckBoxThyratronStatusBit14.Checked = False
            End If
            If (ReturnData And &H8000) Then
                CheckBoxThyratronStatusBit15.Checked = True
            Else
                CheckBoxThyratronStatusBit15.Checked = False
            End If
        End If



        'Control Board Statuss
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_FAULT_CONTROL_BOARD_STATUS_REG, 0, 0) = True Then
            If (ReturnData And &H1) Then
                CheckBoxControlBoardStatusBit0.Checked = True
            Else
                CheckBoxControlBoardStatusBit0.Checked = False
            End If
            If (ReturnData And &H2) Then
                CheckBoxControlBoardStatusBit1.Checked = True
            Else
                CheckBoxControlBoardStatusBit1.Checked = False
            End If
            If (ReturnData And &H4) Then
                CheckBoxControlBoardStatusBit2.Checked = True
            Else
                CheckBoxControlBoardStatusBit2.Checked = False
            End If
            If (ReturnData And &H8) Then
                CheckBoxControlBoardStatusBit3.Checked = True
            Else
                CheckBoxControlBoardStatusBit3.Checked = False
            End If
            If (ReturnData And &H10) Then
                CheckBoxControlBoardStatusBit4.Checked = True
            Else
                CheckBoxControlBoardStatusBit4.Checked = False
            End If
            If (ReturnData And &H20) Then
                CheckBoxControlBoardStatusBit5.Checked = True
            Else
                CheckBoxControlBoardStatusBit5.Checked = False
            End If
            If (ReturnData And &H40) Then
                CheckBoxControlBoardStatusBit6.Checked = True
            Else
                CheckBoxControlBoardStatusBit6.Checked = False
            End If
            If (ReturnData And &H80) Then
                CheckBoxControlBoardStatusBit7.Checked = True
            Else
                CheckBoxControlBoardStatusBit7.Checked = False
            End If
            If (ReturnData And &H100) Then
                CheckBoxControlBoardStatusBit8.Checked = True
            Else
                CheckBoxControlBoardStatusBit8.Checked = False
            End If
            If (ReturnData And &H200) Then
                CheckBoxControlBoardStatusBit9.Checked = True
            Else
                CheckBoxControlBoardStatusBit9.Checked = False
            End If
            If (ReturnData And &H400) Then
                CheckBoxControlBoardStatusBit10.Checked = True
            Else
                CheckBoxControlBoardStatusBit10.Checked = False
            End If
            If (ReturnData And &H800) Then
                CheckBoxControlBoardStatusBit11.Checked = True
            Else
                CheckBoxControlBoardStatusBit11.Checked = False
            End If
            If (ReturnData And &H1000) Then
                CheckBoxControlBoardStatusBit12.Checked = True
            Else
                CheckBoxControlBoardStatusBit12.Checked = False
            End If
            If (ReturnData And &H2000) Then
                CheckBoxControlBoardStatusBit13.Checked = True
            Else
                CheckBoxControlBoardStatusBit13.Checked = False
            End If
            If (ReturnData And &H4000) Then
                CheckBoxControlBoardStatusBit14.Checked = True
            Else
                CheckBoxControlBoardStatusBit14.Checked = False
            End If
            If (ReturnData And &H8000) Then
                CheckBoxControlBoardStatusBit15.Checked = True
            Else
                CheckBoxControlBoardStatusBit15.Checked = False
            End If
        End If




        'Debug Status Register
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_DEBUG_STATUS_REG, 0, 0) = True Then
            If (ReturnData And &H1) Then
                CheckBoxBOR.Checked = True
            Else
                CheckBoxBOR.Checked = False
            End If
            If (ReturnData And &H2) Then
                CheckBoxTRAPR.Checked = True
            Else
                CheckBoxTRAPR.Checked = False
            End If
            If (ReturnData And &H4) Then
                CheckBoxWDT.Checked = True
            Else
                CheckBoxWDT.Checked = False
            End If
            If (ReturnData And &H8) Then
                CheckBoxIOPUWR.Checked = True
            Else
                CheckBoxIOPUWR.Checked = False
            End If
            If (ReturnData And &H10) Then
                CheckBoxPOR.Checked = True
            Else
                CheckBoxPOR.Checked = False
            End If
            If (ReturnData And &H20) Then
                CheckBoxExtReset.Checked = True
            Else
                CheckBoxExtReset.Checked = False
            End If
            If (ReturnData And &H40) Then
                CheckBoxSWReset.Checked = True
            Else
                CheckBoxSWReset.Checked = False
            End If
            If (ReturnData And &H80) Then
                CheckBoxIOExpanderError.Checked = True
            Else
                CheckBoxIOExpanderError.Checked = False
            End If
        End If


    End Sub


    Private Sub ButtonSetLambdaModeA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetLambdaModeA.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte
        ProgramWord = TextBoxSetLambdaModeA.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256

        If SendAndValidateCommand(CMD_SET_LAMBDA_VOLTAGE_MODE_A, 0, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            MsgBox("Set Lambda Voltage Command Failed")
        End If
        'ReadAllFromRam()
    End Sub



    Private Sub ButtonSetLambdaModeB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetLambdaModeB.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte
        ProgramWord = TextBoxSetLambdaModeB.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256

        If SendAndValidateCommand(CMD_SET_LAMBDA_VOLTAGE_MODE_B, 0, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            MsgBox("Set Lambda Voltage Command Failed")
        End If
        'ReadAllFromRam()
    End Sub

    Private Sub ButtonSetMagnet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetMagnet.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte
        ProgramWord = TextBoxSetMagnet.Text * 1000
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256

        If SendAndValidateCommand(CMD_SET_MAGNETRON_MAGNET_CURRENT, 0, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            MsgBox("Set Magnet Current Command Failed")
        End If
        'ReadAllFromRam()
    End Sub


    Private Sub WriteToLogFile()
        Dim filePath As String
        filePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "ETM_Modulator_Log.csv")
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(filePath, True)
        file.Write(LabelTime.Text & " , ")
        file.Write(LabelState.Text & " , ")
        file.Write(LabelMagnetIMON.Text & " , ")
        file.Write(LabelHeaterVmon.Text & " , ")

        file.Write(LabelLambdaSetPointModeA.Text & " , ")
        file.Write(LabelPulseCurrentModeA.Text & " , ")
        file.Write(LabelPulseVoltageModeA.Text & " , ")

        file.Write(LabelLambdaSetPointModeB.Text & " , ")
        file.Write(LabelPulseCurrentModeB.Text & " , ")
        file.Write(LabelPulseVoltageModeB.Text & " , ")

        file.Write(LabelPRF.Text & " , ")
        file.Write(LabelLambdaVpeak.Text & " , ")
        file.Write(LabelLambdaVmon.Text & " , ")

        file.Write(LabelPulsesHVon.Text & " , ")
        file.Write(LabelArcsHVOn.Text & " , ")
        file.Write(LabelPulsesTotal.Text & " , ")
        file.Write(LabelArcsTotal.Text)

        file.WriteLine("")

        file.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ReadAllFaults()
        ReadAllFromRam()
    End Sub
 

    Private Sub ButtonUpdateAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdateAll.Click
        ReadAllFaults()
        ReadAllFromRam()


    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        WriteToLogFile()
    End Sub

    Private Sub ButtonSetFilament_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetFilament.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte
        ProgramWord = TextBoxSetFilament.Text * 1000
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256

        If SendAndValidateCommand(CMD_SET_MAGNETRON_FILAMENT_VOLTAGE, 0, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            MsgBox("Set Filament Voltage Command Failed")
        End If
        'ReadAllFromRam()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If SendAndValidateCommand(CMD_CLEAR_PROCESSOR_RESET_DATA, 0, 0, 0) = True Then
            ' the command Succeded
        Else
            MsgBox("Doh!!!!")
        End If
    End Sub

    Private Sub ButtonReadState_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReadState.Click
        If SendAndValidateCommand(CMD_READ_RAM_VALUE, RAM_READ_STATE, 0, 0) = True Then
            If ReturnData = &H4 Then
                LabelState.Text = "Warm Up"
            ElseIf ReturnData = &H14 Then
                LabelState.Text = "System Cold Read"
            ElseIf ReturnData = &H24 Then
                LabelState.Text = "Warm UP"
            ElseIf ReturnData = &H34 Then
                LabelState.Text = "Warm Ready"
            ElseIf ReturnData = &H35 Then
                LabelState.Text = "HV Startup"
            ElseIf ReturnData = &H44 Then
                LabelState.Text = "HV ON"
            ElseIf ReturnData = &HA0 Then
                LabelState.Text = "MCU CORE FAULT"
            ElseIf ReturnData = &HA1 Then
                LabelState.Text = "Illegal Interrupt"
            ElseIf ReturnData = &HA4 Then
                LabelState.Text = "Cold Fault"
            ElseIf ReturnData = &HA8 Then
                LabelState.Text = "Warm Fault"
            End If
        Else
            LabelState.Text = "Dan error"
        End If
    End Sub

    Private Sub ButtonSetBaudRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetBaudRate.Click

        Try
            My.Settings.SelectedBaudRate = TextBoxBaudRate.Text
        Catch ex As Exception
            MsgBox("Baud Rate not a valid Number")
        End Try


        Try
            SerialPortETM.BaudRate = My.Settings.SelectedBaudRate
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CalibrationDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalibrationDataToolStripMenuItem.Click
        Form2.Show()
        Form2.BringToFront()
    End Sub

    Private Sub MagnetSupplyCalibrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MagnetSupplyCalibrationToolStripMenuItem.Click
        Form3.Show()
        Form3.BringToFront()
    End Sub

    Private Sub RemoteMagnetCurrentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoteMagnetCurrentToolStripMenuItem.Click
        If SendAndValidateCommand(CMD_SET_MAGNETRON_CURRENT_REMOTE_MODE, 0, 0, 0) = True Then
            ' the command Succeded
            'ReadAllFromRam()
        Else
            MsgBox("Duh!!!!")
        End If
    End Sub

    Private Sub LocalMagnetCurrentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocalMagnetCurrentToolStripMenuItem.Click
        If SendAndValidateCommand(CMD_SET_MAGNETRON_CURRENT_LOCAL_MODE, 0, 0, 0) = True Then
            '  the command Succeded
            'ReadAllFromRam()
        Else
            MsgBox("Duh!!!!")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If SendAndValidateCommand(CMD_FORCE_SOFTWARE_RESTART, 0, 0, 0) = True Then
            ' the command Succeded
        Else
            MsgBox("Doh!!!!")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSkipWarmup.Click
        If SendAndValidateCommand(CMD_SOFTWARE_SKIP_WARMUP, 0, 0, 0) = True Then
            ' the command Succeded
        Else
            MsgBox("Doh!!!!")
        End If
    End Sub

    Private Sub ETMOverrideModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ETMOverrideModeToolStripMenuItem.Click
        If ButtonSkipWarmup.Visible Then
            ButtonSkipWarmup.Visible() = False
        Else
            ButtonSkipWarmup.Visible() = True
        End If

    End Sub

    Private Sub ButtonSetModeATargetI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetModeATargetI.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte
        ProgramWord = TextBoxModeATargetI.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256

        If SendAndValidateCommand(CMD_SET_HIGH_ENERGY_TARGET_CURRENT_SETPOINT, 0, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            MsgBox("Set Lambda Voltage Command Failed")
        End If
    End Sub


    Private Sub ButtonStartDataLogging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStartDataLogging.Click
        Timer1.Enabled = False
        SendAndValidateCommand(CMD_DATA_LOGGING, 1, 0, 0)
        ButtonStartDataLogging.Enabled = False
        ButtonStopDataLogging.Enabled = True
        DataLogging = True
        LogDataFast()
    End Sub

    Private Sub ButtonStopDataLogging_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStopDataLogging.Click
        DataLogging = False
        SendAndValidateCommand(CMD_DATA_LOGGING, 0, 0, 0)
        ButtonStartDataLogging.Enabled = True
        ButtonStopDataLogging.Enabled = False
        Timer1.Enabled = True
    End Sub

    Private Sub OpenLogFile()


        fastfileName = "ETM_PFN_Log_" & DateTime.Now.ToString("yyyy_MM_dd_HH_mm") & ".csv"
        fastfilePath = System.IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, fastfileName)
        fastfile = My.Computer.FileSystem.OpenTextFileWriter(fastfilePath, True)

        fastfile.Write("Time , ")
        fastfile.Write("High Target Imon , ")
        fastfile.Write("Low Target Imon , ")
        fastfile.Write("Current Adjust , ")
        fastfile.Write("High Offset , ")
        fastfile.Write("Low Offset , ")
        fastfile.Write("Pulses , ")
        fastfile.Write("Magnetron Reading")
        fastfile.WriteLine("")
    End Sub

    Private Sub CLoseLogFile()
        fastfile.Close()
    End Sub

    Private Function ConvertToSignedByte(ByVal value_unsigned As Byte) As Int16
        Dim ReturnDataSigned As Int16
        ReturnDataSigned = 0
        Try
            If value_unsigned <= 127 Then
                ReturnDataSigned = value_unsigned
            Else
                ReturnDataSigned = value_unsigned - 255
            End If

        Catch ex As Exception

        End Try

        Return ReturnDataSigned
    End Function

    Private Sub LogDataFast()
        Dim temp_unsigned As UInt16
        Dim data_byte As Byte
  

        Dim linac_high_energy_target_current_adc_reading As UInt16
        Dim linac_low_energy_target_current_adc_reading As UInt16
        Dim linac_high_energy_program_offset As Int32
        Dim linac_low_energy_program_offset As Int32
        Dim pulse_counter_this_run As UInt16
        Dim pulse_magnetron_current_adc_reading As UInt16
        Dim low_energy_target_current_adjust As UInt16

        OpenSerialPortETM()
        OpenLogFile()
        Do While DataLogging = True
            Application.DoEvents()
            Try
                If SerialPortETM.BytesToRead >= 16 Then
                    data_byte = SerialPortETM.ReadByte
                    If data_byte = &HFE Then
                        data_byte = SerialPortETM.ReadByte

                        temp_unsigned = SerialPortETM.ReadByte
                        temp_unsigned = temp_unsigned * 256
                        temp_unsigned = temp_unsigned + SerialPortETM.ReadByte
                        low_energy_target_current_adjust = temp_unsigned

                        temp_unsigned = SerialPortETM.ReadByte
                        temp_unsigned = temp_unsigned * 256
                        temp_unsigned = temp_unsigned + SerialPortETM.ReadByte
                        linac_high_energy_target_current_adc_reading = temp_unsigned
                        LabelModeATargetIMonitor.Text = linac_high_energy_target_current_adc_reading

                        temp_unsigned = SerialPortETM.ReadByte
                        temp_unsigned = temp_unsigned * 256
                        temp_unsigned = temp_unsigned + SerialPortETM.ReadByte
                        linac_low_energy_target_current_adc_reading = temp_unsigned
                        LabelModeBTargetIMonitor.Text = linac_low_energy_target_current_adc_reading

                        temp_unsigned = SerialPortETM.ReadByte
                        temp_unsigned = temp_unsigned * 256
                        temp_unsigned = temp_unsigned + SerialPortETM.ReadByte
                        linac_high_energy_program_offset = ConvertToSignedInteger(temp_unsigned)

                        temp_unsigned = SerialPortETM.ReadByte
                        temp_unsigned = temp_unsigned * 256
                        temp_unsigned = temp_unsigned + SerialPortETM.ReadByte
                        linac_low_energy_program_offset = ConvertToSignedInteger(temp_unsigned)

                        temp_unsigned = SerialPortETM.ReadByte
                        temp_unsigned = temp_unsigned * 256
                        temp_unsigned = temp_unsigned + SerialPortETM.ReadByte
                        pulse_counter_this_run = temp_unsigned

                        temp_unsigned = SerialPortETM.ReadByte
                        temp_unsigned = temp_unsigned * 256
                        temp_unsigned = temp_unsigned + SerialPortETM.ReadByte
                        pulse_magnetron_current_adc_reading = temp_unsigned


                        fastfile.Write(DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss") & " " & DateTime.Now.Millisecond & " , ")
                        fastfile.Write(linac_high_energy_target_current_adc_reading & " , ")
                        fastfile.Write(linac_low_energy_target_current_adc_reading & " , ")
                        fastfile.Write(low_energy_target_current_adjust & " , ")
                        fastfile.Write(linac_high_energy_program_offset & " , ")
                        fastfile.Write(linac_low_energy_program_offset & " , ")
                        fastfile.Write(pulse_counter_this_run & " , ")
                        fastfile.Write(pulse_magnetron_current_adc_reading & " , ")
                        fastfile.Write(SerialPortETM.BytesToRead)
                        fastfile.WriteLine("")
                    End If
                End If
            Catch ex As Exception
                DataLogging = False
            End Try

        Loop

        CLoseLogFile()
        CloseSerialPortETM()

    End Sub

    Private Function ConvertToSignedInteger(ByVal value_unsigned As UInt16) As Int32
        Dim ReturnDataSigned As Int32
        ReturnDataSigned = 0
        Try
            If value_unsigned <= (2 ^ 15 - 1) Then
                ReturnDataSigned = value_unsigned
            Else
                ReturnDataSigned = value_unsigned - (2 ^ 16)
            End If

        Catch ex As Exception

        End Try

        Return ReturnDataSigned
    End Function

    Private Sub ButtonSetFilamentCurrent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetFilamentCurrent.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte
        ProgramWord = TextBoxSetFilament.Text * 1000
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256

        If SendAndValidateCommand(CMD_SET_MAGNETRON_FILAMENT_CURRENT, 0, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            MsgBox("Set Filament Voltage Command Failed")
        End If
        'ReadAllFromRam()
    End Sub


    Private Sub FilamentCurrentControlModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilamentCurrentControlModeToolStripMenuItem.Click
        If ButtonSetFilament.Enabled Then
            ButtonSetFilament.Enabled = False
            ButtonSetFilamentCurrent.Enabled = True
        Else
            ButtonSetFilament.Enabled = True
            ButtonSetFilamentCurrent.Enabled = False
        End If
    
    End Sub

    Private Sub ButtonLowEnergyAdjustNumPulses_Click(sender As System.Object, e As System.EventArgs) Handles ButtonLowEnergyAdjustNumPulses.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte
        ProgramWord = TextBoxLowEnergyAdjustPulses.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256

        If SendAndValidateCommand(CMD_SET_TARGET_CURRENT_STARTUP_PULSES, 0, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            MsgBox("Set Lambda Voltage Command Failed")
        End If
    End Sub

    Private Sub ButtonLowEnergyAdjustMag_Click(sender As System.Object, e As System.EventArgs) Handles ButtonLowEnergyAdjustMag.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte
        ProgramWord = TextBoxLowEnergyAdjustMag.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256

        If SendAndValidateCommand(CMD_SET_TARGET_CURRENT_STARTUP_MAGNITUDE, 0, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            MsgBox("Set Lambda Voltage Command Failed")
        End If
    End Sub

    Private Sub ButtonLowEnergyAdjDir_Click(sender As System.Object, e As System.EventArgs) Handles ButtonLowEnergyAdjDir.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte
        ProgramWord = TextBoxLowEnergyAdjDir.Text * 100
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256

        If SendAndValidateCommand(CMD_SET_TARGET_CURRENT_STARTUP_DIRECTION, 0, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            MsgBox("Set Lambda Voltage Command Failed")
        End If
    End Sub

    Private Sub ButtonSetPortalTargetI_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSetPortalTargetI.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte
        ProgramWord = TextBoxPortalTargetI.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256

        If SendAndValidateCommand(CMD_SET_LOW_ENERGY_PORTAL_TARGET_CURRENT_SETPOINT, 0, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            MsgBox("Set Lambda Voltage Command Failed")
        End If
    End Sub

    Private Sub ButtonSetGantryTargetI_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSetGantryTargetI.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte
        ProgramWord = TextBoxGantryTargetI.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256

        If SendAndValidateCommand(CMD_SET_LOW_ENERGY_GANTRY_TARGET_CURRENT_SETPOINT, 0, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            MsgBox("Set Lambda Voltage Command Failed")
        End If
    End Sub

    Private Sub ButtonFilamentOffset_Click(sender As System.Object, e As System.EventArgs) Handles ButtonFilamentOffset.Click
        Dim Input As Int32
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte
        Input = TextBoxFilamentOffset.Text
        If Input < 0 Then
            Input = Input + 2 ^ 16
        End If
        ProgramWord = Input
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256

        If SendAndValidateCommand(CMD_SET_FILAMENT_OFFSET, 0, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            MsgBox("Set Lambda Voltage Command Failed")
        End If
    End Sub
End Class
