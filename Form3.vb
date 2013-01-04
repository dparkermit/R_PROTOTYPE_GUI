Public Class Form3

    Public Function WriteCalibrationData(ByVal CommandByte As Byte) As Boolean
        Dim ProgramWord As UInt16
        Dim SignedData As Int16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte
        Dim Failure As Boolean = False

        ProgramWord = TextBoxVSetPoint.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_V_SET_POINT, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If

        ProgramWord = TextBoxVDACGain.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_V_DAC_CAL_GAIN, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If


        SignedData = TextBoxVDACOffset.Text
        If SignedData >= 0 Then
            ProgramWord = SignedData
        Else
            ProgramWord = SignedData + 2 ^ 16
        End If

        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_V_DAC_CAL_OFFSET, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If

        ProgramWord = TextBoxVADCGain.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_V_ADC_CAL_GAIN, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If


        SignedData = TextBoxVADCOffset.Text
        If SignedData >= 0 Then
            ProgramWord = SignedData
        Else
            ProgramWord = SignedData + 2 ^ 16
        End If
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_V_ADC_CAL_OFFSET, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If

        ProgramWord = TextBoxISetPoint.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_I_SET_POINT, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If

        ProgramWord = TextBoxIDACGain.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_I_DAC_CAL_GAIN, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If


        SignedData = TextBoxIDACOffset.Text
        If SignedData >= 0 Then
            ProgramWord = SignedData
        Else
            ProgramWord = SignedData + 2 ^ 16
        End If
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_I_DAC_CAL_OFFSET, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If

        ProgramWord = TextBoxIADCGain.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_I_ADC_CAL_GAIN, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If


        SignedData = TextBoxIADCOffset.Text
        If SignedData >= 0 Then
            ProgramWord = SignedData
        Else
            ProgramWord = SignedData + 2 ^ 16
        End If
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_I_ADC_CAL_OFFSET, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If

        ProgramWord = TextBoxUnused1.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_UNUSED_1, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If

        ProgramWord = TextBoxUnused2.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_UNUSED_2, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If

        ProgramWord = TextBoxUnused3.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_UNUSED_3, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If

        ProgramWord = TextBoxUnused4.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_UNUSED_4, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If

        ProgramWord = TextBoxUnused5.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_UNUSED_5, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If

        Return Failure

    End Function

    Private Sub ReadCalibrationData(ByVal CommandByte As Byte)
        Dim SignedReturnData As Int16 = 0
        Dim TempInt As UInt16 = 0
        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_V_SET_POINT, 0, 0) = True Then
            TextBoxVSetPoint.Text = Form1.ReturnData
        Else
            TextBoxVSetPoint.Text = "error"
        End If

        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_V_DAC_CAL_GAIN, 0, 0) = True Then
            TextBoxVDACGain.Text = Form1.ReturnData
        Else
            TextBoxVDACGain.Text = "error"
        End If

        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_V_DAC_CAL_OFFSET, 0, 0) = True Then
            TempInt = Form1.ReturnData
            If TempInt > 2 ^ 15 Then
                SignedReturnData = (TempInt - 2 ^ 16)
            Else
                SignedReturnData = TempInt
            End If
            TextBoxVDACOffset.Text = SignedReturnData
        Else
            TextBoxVDACOffset.Text = "error"
        End If

        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_V_ADC_CAL_GAIN, 0, 0) = True Then
            TextBoxVADCGain.Text = Form1.ReturnData
        Else
            TextBoxVADCGain.Text = "error"
        End If

        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_V_ADC_CAL_OFFSET, 0, 0) = True Then
            TempInt = Form1.ReturnData
            If TempInt > 2 ^ 15 Then
                SignedReturnData = (TempInt - 2 ^ 16)
            Else
                SignedReturnData = TempInt
            End If

            TextBoxVADCOffset.Text = SignedReturnData
        Else
            TextBoxVADCOffset.Text = "error"
        End If

        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_I_SET_POINT, 0, 0) = True Then
            TextBoxISetPoint.Text = Form1.ReturnData
        Else
            TextBoxISetPoint.Text = "error"
        End If

        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_I_DAC_CAL_GAIN, 0, 0) = True Then
            TextBoxIDACGain.Text = Form1.ReturnData
        Else
            TextBoxIDACGain.Text = "error"
        End If

        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_I_DAC_CAL_OFFSET, 0, 0) = True Then
            TempInt = Form1.ReturnData
            If TempInt > 2 ^ 15 Then
                SignedReturnData = (TempInt - 2 ^ 16)
            Else
                SignedReturnData = TempInt
            End If
            TextBoxIDACOffset.Text = SignedReturnData
        Else
            TextBoxIDACOffset.Text = "error"
        End If

        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_I_ADC_CAL_GAIN, 0, 0) = True Then
            TextBoxIADCGain.Text = Form1.ReturnData
        Else
            TextBoxIADCGain.Text = "error"
        End If

        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_I_ADC_CAL_OFFSET, 0, 0) = True Then
            TempInt = Form1.ReturnData
            If TempInt > 2 ^ 15 Then
                SignedReturnData = (TempInt - 2 ^ 16)
            Else
                SignedReturnData = TempInt
            End If
            TextBoxIADCOffset.Text = SignedReturnData
        Else
            TextBoxIADCOffset.Text = "error"
        End If

        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_UNUSED_1, 0, 0) = True Then
            TextBoxUnused1.Text = Form1.ReturnData
        Else
            TextBoxUnused1.Text = "error"
        End If

        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_UNUSED_2, 0, 0) = True Then
            TextBoxUnused2.Text = Form1.ReturnData
        Else
            TextBoxUnused2.Text = "error"
        End If

        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_UNUSED_3, 0, 0) = True Then
            TextBoxUnused3.Text = Form1.ReturnData
        Else
            TextBoxUnused3.Text = "error"
        End If

        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_UNUSED_4, 0, 0) = True Then
            TextBoxUnused4.Text = Form1.ReturnData
        Else
            TextBoxUnused4.Text = "error"
        End If

        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_UNUSED_5, 0, 0) = True Then
            TextBoxUnused5.Text = Form1.ReturnData
        Else
            TextBoxUnused5.Text = "error"
        End If

        If Form1.SendAndValidateCommand(CommandByte, Form1.EEPROM_CRC, 0, 0) = True Then
            TextBoxCRC.Text = Form1.ReturnData
        Else
            TextBoxCRC.Text = "error"
        End If
    End Sub

    Private Sub ButtonReadMagnetPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReadMagnetPS.Click
        ReadCalibrationData(Form1.CMD_READ_MAGNET_PS_CAL_DATA)
    End Sub

    Private Sub ButtonWriteMagnetPs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWriteMagnetPs.Click
        WriteCalibrationData(Form1.CMD_SET_MAGNET_PS_CAL_DATA)
        If Form1.SendAndValidateCommand(Form1.CMD_SAVE_MAGNET_PS_CAL_DATA_TO_EEPROM, 0, 0, 0) = True Then
            ' the command Succeded
        End If
    End Sub

    Private Sub ButtonReadFilamentPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReadFilamentPS.Click
        ReadCalibrationData(Form1.CMD_READ_FILAMENT_PS_CAL_DATA)
    End Sub

    Private Sub ButtonWriteFilamentPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWriteFilamentPS.Click
        WriteCalibrationData(Form1.CMD_SET_FILAMENT_PS_CAL_DATA)
        If Form1.SendAndValidateCommand(Form1.CMD_SAVE_FILAMENT_PS_CAL_DATA_TO_EEPROM, 0, 0, 0) = True Then
            ' the command Succeded
        End If
    End Sub

    Private Sub ButtonReadThyrCathodePS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReadThyrCathodePS.Click
        ReadCalibrationData(Form1.CMD_READ_THYR_CATHODE_PS_CAL_DATA)
    End Sub

    Private Sub ButtonWriteThyrCathodePS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWriteThyrCathodePS.Click
        WriteCalibrationData(Form1.CMD_SET_THYR_CATHODE_PS_CAL_DATA)
        If Form1.SendAndValidateCommand(Form1.CMD_SAVE_THYR_CATHODE_PS_CAL_DATA_TO_EEPROM, 0, 0, 0) = True Then
            ' the command Succeded
        End If
    End Sub

    Private Sub ButtonReadThyrReservoirPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReadThyrReservoirPS.Click
        ReadCalibrationData(Form1.CMD_READ_THYR_RESERVOIR_PS_CAL_DATA)
    End Sub

    Private Sub ButtonWriteThyrReservoirPS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWriteThyrReservoirPS.Click
        WriteCalibrationData(Form1.CMD_SET_THYR_RESERVOIR_PS_CAL_DATA)
        If Form1.SendAndValidateCommand(Form1.CMD_SAVE_THYR_RESERVOIR_PS_CAL_DATA_TO_EEPROM, 0, 0, 0) = True Then
            ' the command Succeded
        End If
    End Sub

    Private Sub ButtonReadHVModeA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReadHVModeA.Click
        ReadCalibrationData(Form1.CMD_READ_HV_LAMBDA_MODE_A_CAL_DATA)
    End Sub

    Private Sub ButtonWriteHVModeA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWriteHVModeA.Click
        WriteCalibrationData(Form1.CMD_SET_HV_LAMBDA_MODE_A_CAL_DATA)
        If Form1.SendAndValidateCommand(Form1.CMD_SAVE_HV_LAMBDA_MODE_A_CAL_DATA_TO_EEPROM, 0, 0, 0) = True Then
            ' the command Succeded
        End If
    End Sub

    Private Sub ButtonReadHVModeB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReadHVModeB.Click
        ReadCalibrationData(Form1.CMD_READ_HV_LAMBDA_MODE_B_CAL_DATA)
    End Sub

    Private Sub ButtonWriteHVModeB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWriteHVModeB.Click
        WriteCalibrationData(Form1.CMD_SET_HV_LAMBDA_MODE_B_CAL_DATA)
        If Form1.SendAndValidateCommand(Form1.CMD_SAVE_HV_LAMBDA_MODE_B_CAL_DATA_TO_EEPROM, 0, 0, 0) = True Then
            ' the command Succeded
        End If
    End Sub

    Private Sub ButtonReadMagnetronModeA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReadMagnetronModeA.Click
        ReadCalibrationData(Form1.CMD_READ_MAGNETRON_MODE_A_CAL_DATA)
    End Sub

    Private Sub ButtonWriteMagnetronModeA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWriteMagnetronModeA.Click
        WriteCalibrationData(Form1.CMD_SET_MAGNETRON_MODE_A_CAL_DATA)
        If Form1.SendAndValidateCommand(Form1.CMD_SAVE_MAGNETRON_MODE_A_CAL_DATA_TO_EEPROM, 0, 0, 0) = True Then
            ' the command Succeded
        End If
    End Sub

    Private Sub ButtonReadMagnetronModeB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReadMagnetronModeB.Click
        ReadCalibrationData(Form1.CMD_READ_MAGNETRON_MODE_B_CAL_DATA)
    End Sub

    Private Sub ButtonWriteMagnetronModeB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWriteMagnetronModeB.Click
        WriteCalibrationData(Form1.CMD_SET_MAGNETRON_MODE_B_CAL_DATA)
        If Form1.SendAndValidateCommand(Form1.CMD_SAVE_MAGNETRON_MODE_B_CAL_DATA_TO_EEPROM, 0, 0, 0) = True Then
            ' the command Succeded
        End If
    End Sub


    Private Sub WriteConfigLine(ByVal CommandByte As Byte, ByVal FileToWrite As System.IO.StreamWriter)
        ReadCalibrationData(CommandByte)
        FileToWrite.Write(TextBoxVSetPoint.Text & " , ")
        FileToWrite.Write(TextBoxVDACGain.Text & " , ")
        FileToWrite.Write(TextBoxVDACOffset.Text & " , ")
        FileToWrite.Write(TextBoxVADCGain.Text & " , ")
        FileToWrite.Write(TextBoxVADCOffset.Text & " , ")
        FileToWrite.Write(TextBoxISetPoint.Text & " , ")
        FileToWrite.Write(TextBoxIDACGain.Text & " , ")
        FileToWrite.Write(TextBoxIDACOffset.Text & " , ")
        FileToWrite.Write(TextBoxIADCGain.Text & " , ")
        FileToWrite.Write(TextBoxIADCOffset.Text & " , ")
        FileToWrite.Write(TextBoxUnused1.Text & " , ")
        FileToWrite.Write(TextBoxUnused2.Text & " , ")
        FileToWrite.Write(TextBoxUnused3.Text & " , ")
        FileToWrite.Write(TextBoxUnused4.Text & " , ")
        FileToWrite.Write(TextBoxUnused5.Text)
        FileToWrite.WriteLine()
    End Sub

    Private Sub ReadConfigLine(ByVal CommandByteWrite As Byte, ByVal CommandByteSave As Byte, ByVal FileToRead As System.IO.StreamReader)
        Dim TextLine As String
        Dim SplitLine As String()
        TextLine = FileToRead.ReadLine()
        SplitLine = TextLine.Split(",")
        TextBoxVSetPoint.Text = SplitLine(0)
        TextBoxVDACGain.Text = SplitLine(1)
        TextBoxVDACOffset.Text = SplitLine(2)
        TextBoxVADCGain.Text = SplitLine(3)
        TextBoxVADCOffset.Text = SplitLine(4)
        TextBoxISetPoint.Text = SplitLine(5)
        TextBoxIDACGain.Text = SplitLine(6)
        TextBoxIDACOffset.Text = SplitLine(7)
        TextBoxIADCGain.Text = SplitLine(8)
        TextBoxIADCOffset.Text = SplitLine(9)
        TextBoxUnused1.Text = SplitLine(10)
        TextBoxUnused2.Text = SplitLine(11)
        TextBoxUnused3.Text = SplitLine(12)
        TextBoxUnused4.Text = SplitLine(13)
        TextBoxUnused5.Text = SplitLine(14)
        WriteCalibrationData(CommandByteWrite)
        If Form1.SendAndValidateCommand(CommandByteSave, 0, 0, 0) = True Then
            ' the command Succeded
        End If

    End Sub

    Private Sub ButtonSaveConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveConfig.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        Dim SaveFileName As String
        Dim file As System.IO.StreamWriter

        saveFileDialog1.Filter = "csv files (*.csv)|*.csv"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            SaveFileName = saveFileDialog1.FileName
            file = My.Computer.FileSystem.OpenTextFileWriter(SaveFileName, False)
            file.WriteLine("none")
            WriteConfigLine(Form1.CMD_READ_MAGNET_PS_CAL_DATA, file)
            WriteConfigLine(Form1.CMD_READ_FILAMENT_PS_CAL_DATA, file)
            WriteConfigLine(Form1.CMD_READ_THYR_CATHODE_PS_CAL_DATA, file)
            WriteConfigLine(Form1.CMD_READ_THYR_RESERVOIR_PS_CAL_DATA, file)
            WriteConfigLine(Form1.CMD_READ_HV_LAMBDA_MODE_A_CAL_DATA, file)
            WriteConfigLine(Form1.CMD_READ_HV_LAMBDA_MODE_B_CAL_DATA, file)
            WriteConfigLine(Form1.CMD_READ_MAGNETRON_MODE_A_CAL_DATA, file)
            WriteConfigLine(Form1.CMD_READ_MAGNETRON_MODE_B_CAL_DATA, file)
            WriteConfigLine(Form1.CMD_READ_CNTRL_CAL_DATA, file)
            file.Close()
        End If
    End Sub

    Private Sub ButtonLoadConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoadConfig.Click
        Dim OpenFileDialog1 As New OpenFileDialog()
        Dim OpenFileName As String
        Dim file As System.IO.StreamReader
        Dim LineOfText As String

        OpenFileDialog1.Filter = "csv files (*.csv)|*.csv"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            OpenFileName = OpenFileDialog1.FileName
            file = My.Computer.FileSystem.OpenTextFileReader(OpenFileName)
            LineOfText = file.ReadLine()


            ReadConfigLine(Form1.CMD_SET_MAGNET_PS_CAL_DATA, Form1.CMD_SAVE_MAGNET_PS_CAL_DATA_TO_EEPROM, file)
            ReadConfigLine(Form1.CMD_SET_FILAMENT_PS_CAL_DATA, Form1.CMD_SAVE_FILAMENT_PS_CAL_DATA_TO_EEPROM, file)
            ReadConfigLine(Form1.CMD_SET_THYR_CATHODE_PS_CAL_DATA, Form1.CMD_SAVE_THYR_CATHODE_PS_CAL_DATA_TO_EEPROM, file)
            ReadConfigLine(Form1.CMD_SET_THYR_RESERVOIR_PS_CAL_DATA, Form1.CMD_SAVE_THYR_RESERVOIR_PS_CAL_DATA_TO_EEPROM, file)
            ReadConfigLine(Form1.CMD_SET_HV_LAMBDA_MODE_A_CAL_DATA, Form1.CMD_SAVE_HV_LAMBDA_MODE_A_CAL_DATA_TO_EEPROM, file)
            ReadConfigLine(Form1.CMD_SET_HV_LAMBDA_MODE_B_CAL_DATA, Form1.CMD_SAVE_HV_LAMBDA_MODE_B_CAL_DATA_TO_EEPROM, file)
            ReadConfigLine(Form1.CMD_SET_MAGNETRON_MODE_A_CAL_DATA, Form1.CMD_SAVE_MAGNETRON_MODE_A_CAL_DATA_TO_EEPROM, file)
            ReadConfigLine(Form1.CMD_SET_MAGNETRON_MODE_B_CAL_DATA, Form1.CMD_SAVE_MAGNETRON_MODE_B_CAL_DATA_TO_EEPROM, file)
            ReadConfigLine(Form1.CMD_SET_CNTRL_CAL_DATA, Form1.CMD_SAVE_CNTRL_CAL_DATA_TO_EEPROM, file)

        End If
    End Sub
End Class