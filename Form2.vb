Public Class Form2

    Private Sub ButtonSquaredFactor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte
        ProgramWord = TextBoxLinearFactor.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256

        If Form1.SendAndValidateCommand(Form1.CMD_SET_LAMBDA_VOLTAGE_MODE_A, 0, ProgramHB, ProgramLB) = True Then
            'the command Succeded
        Else
            MsgBox("Set Lambda Voltage Command Failed")
        End If
    End Sub



    Private Sub ButtonWriteControlCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonWriteControlCal.Click
        Dim ProgramWord As UInt16
        Dim ProgramHB As Byte
        Dim ProgramLB As Byte
        Dim Failure As Boolean = False


        ProgramWord = TextBoxSquaredFactor.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(Form1.CMD_SET_CNTRL_CAL_DATA, Form1.EEPROM_CNTRL_MAGNET_FACTOR_SQUARE, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If

        ProgramWord = TextBoxLinearFactor.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(Form1.CMD_SET_CNTRL_CAL_DATA, Form1.EEPROM_CNTRL_MAGNET_FACTOR_LINEAR, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If


        ProgramWord = TextBoxConstantFactor.Text
        ProgramHB = Int(ProgramWord / 256)
        ProgramLB = ProgramWord Mod 256
        If Form1.SendAndValidateCommand(Form1.CMD_SET_CNTRL_CAL_DATA, Form1.EEPROM_CNTRL_MAGNET_FACTOR_CONST, ProgramHB, ProgramLB) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If

        If Form1.SendAndValidateCommand(Form1.CMD_SAVE_CNTRL_CAL_DATA_TO_EEPROM, 0, 0, 0) = True Then
            ' the command Succeded
        Else
            Failure = True
        End If


        If Failure = True Then
            MsgBox("Command Failed - Data could be corrupted")
        End If

    End Sub

    Private Sub ButtonReadControlCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReadControlCal.Click
        ' Read Calibration Data From Ram
        If Form1.SendAndValidateCommand(Form1.CMD_READ_CNTRL_CAL_DATA, Form1.EEPROM_CNTRL_MAGNET_FACTOR_SQUARE, 0, 0) = True Then
            TextBoxSquaredFactor.Text = Form1.ReturnData
        Else
            TextBoxSquaredFactor.Text = "error"
        End If

        If Form1.SendAndValidateCommand(Form1.CMD_READ_CNTRL_CAL_DATA, Form1.EEPROM_CNTRL_MAGNET_FACTOR_LINEAR, 0, 0) = True Then
            TextBoxLinearFactor.Text = Form1.ReturnData
        Else
            TextBoxLinearFactor.Text = "error"
        End If
        If Form1.SendAndValidateCommand(Form1.CMD_READ_CNTRL_CAL_DATA, Form1.EEPROM_CNTRL_MAGNET_FACTOR_CONST, 0, 0) = True Then
            TextBoxConstantFactor.Text = Form1.ReturnData
        Else
            TextBoxConstantFactor.Text = "error"
        End If

    End Sub
End Class