Public Class Form1



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click

        'If txtazient.Text = "" Then
        '    If txtangulo.Text Then
        '    End If
        If combovelocidad.Text = "" Then
            MsgBox("asigne velocidad ")
        Else

            If txtazisalida.Text = "" Or txtazient.Text = "" Then
                MsgBox("asigne valor o valores de azimut ")
            Else

                If txtazisalida.Text > 360 Then
                    MsgBox(" asigne azimut de salida menor a 360")
                Else

                    If txtazient.Text > 360 Then
                        MsgBox(" asigne azimut de entrada menor a 360")

                    Else
                        If longbop.Text = "" Then
                            MsgBox("asigne longitud")
                        Else
                            If txtpie.Text = "" Or txtpin.Text = "" Then
                                MsgBox("asigne cordenadas")
                            Else
                                If combocuerda.Text = "" Then
                                    MsgBox("asigne cuerda")
                                Else
                                    azisal = txtazisalida.Text
                                    azient = txtazient.Text
                                    angulodeflexion = Math.Abs(azisal - azient)
                                    angulodeflexion1 = azisal - azient





                                    If combovelocidad.Text = 40 Then
                                        radio = 41
                                    End If
                                    If combovelocidad.Text = 50 Then
                                        radio = 73
                                    End If
                                    If combovelocidad.Text = 60 Then
                                        radio = 113
                                    End If
                                    If combovelocidad.Text = 70 Then
                                        radio = 168
                                    End If
                                    If combovelocidad.Text = 80 Then
                                        radio = 229
                                    End If
                                    If combovelocidad.Text = 90 Then
                                        radio = 304
                                    End If
                                    If combovelocidad.Text = 100 Then
                                        radio = 394
                                    End If
                                    If combovelocidad.Text = 110 Then
                                        radio = 501
                                    End If
                                    If combovelocidad.Text = 120 Then
                                        radio = 667
                                    End If
                                    If combovelocidad.Text = 130 Then
                                        radio = 832
                                    End If



                                    ve = combovelocidad.Text

                                    le = ve ^ 3 / (28 * radio)

                                    a = le * radio


                                    tetae = (le * 90) / (3.1416 * radio)
                                    anguloprima = angulodeflexion - (tetae * 2)
                                    If anguloprima < 0 Then
                                        MsgBox("la curva no se puede espiralizar aumente la velocidad especifica o revise los azimut")
                                    Else

                                        xe = le * (1 - 3.05 * 10 ^ -5 * tetae ^ 2 + 4.2959 * 10 ^ -10 * tetae ^ 4)
                                        ye = le * (((5.8177 * 10 ^ -3) * tetae) - ((1.2658 * 10 ^ -7) * tetae ^ 3) + ((1.2269 * 10 ^ -12) * tetae ^ 5))
                                        p = ye - (radio - radio * Math.Cos(0.017453292 * (tetae)))
                                        k = xe - radio * Math.Sin(0.017453292 * (tetae))
                                        If te < 0 Then
                                            MsgBox("la curva no se puede espiralizar revise los datos de entrada")
                                        Else

                                            te = (radio + p) * Math.Tan(0.017453292 * (angulodeflexion / 2)) + k
                                            ee = (radio + p) * (1 / (Math.Cos(0.017453292 * (angulodeflexion / 2)))) - radio
                                            tl = xe - ye * (1 / (Math.Tan(0.017453292 * (tetae))))
                                            tc = ye * (1 / (Math.Sin(0.017453292 * (tetae))))
                                            t = p * (1 / (Math.Cos(0.017453292 * (angulodeflexion / 2))))

                                            z1 = 3 * 10 ^ -3 * tetae ^ 3 + 2.3 * 10 ^ -8 * tetae ^ 5
                                            z = (z1 / 3600)
                                            gamae = (tetae / 3) - z
                                            cl = (xe ^ 2 + ye ^ 2) ^ (1 / 2)
                                            g = 180 / 3.1416 * (2 * Math.Asin(10 / (2 * radio)))
                                            lcarco = (anguloprima * 3.1416 * radio) / 180
                                            clcurva = 2 * radio * Math.Sin(0.017453292 * (anguloprima / 2))
                                            abspi = longbop.Text
                                            abste = longbop.Text - te
                                            If abste < 0 Then
                                                MsgBox("revise la distancia del bop al pi ")
                                            Else
                                                absec = abste + le
                                                absce = absec + lcarco
                                                abset = absce + le
                                                pite = azient + 180
                                                pin = txtpin.Text
                                                pie = txtpie.Text


                                                cuerda = combocuerda.Text
                                                If cuerda = 5 Then
                                                    five1 = abste Mod 5
                                                    five2 = 5 - five1
                                                    abset1 = abste + five2
                                                    absaproximadate1 = abset1

                                                    five3 = absec Mod 5
                                                    five4 = 5 - five3
                                                    absec1 = absec + five4
                                                    absaproximadaec1 = absec1

                                                    five5 = absce Mod 5
                                                    five6 = 5 - five5
                                                    absce1 = absce + five6
                                                    absaproximadace1 = absce1
                                                Else


                                                    ten1 = abste Mod 10
                                                    ten2 = 10 - ten1
                                                    abset2 = abste + ten2
                                                    absaproximadate1 = abset2


                                                    ten3 = absec Mod 10
                                                    ten4 = 10 - ten3
                                                    absec2 = absec + ten4
                                                    absaproximadaec1 = absec2

                                                    ten5 = absce Mod 10
                                                    ten6 = 10 - ten5
                                                    absce2 = absce + ten6
                                                    absaproximadace1 = absce2


                                                End If








                                                If angulodeflexion1 > 0 Then
                                                    teec = azient + gamae
                                                Else
                                                    teec = azient - gamae
                                                End If

                                                If angulodeflexion1 > 0 Then
                                                    pieec = azient + tetae
                                                Else
                                                    pieec = azient - tetae
                                                End If

                                                If angulodeflexion1 > 0 Then
                                                    eco = pieec + 90
                                                Else
                                                    eco = pieec - 90
                                                End If






                                                datos.Show()
                                            End If

                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

            End If

        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub combovelocidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles combovelocidad.KeyPress
        Select Case Asc(e.KeyChar)
      
            Case 13
                If combovelocidad.Text = "" Then
                  
                End If
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub combovelocidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combovelocidad.SelectedIndexChanged

    End Sub

    Private Sub checkpi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub txtazisalida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtazisalida.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case 46

                If InStr(txtazisalida.Text, ".") <> 0 Then
                    e.Handled = True
                ElseIf Len(txtazisalida.Text) = 0 Then
                    e.Handled = True

                End If
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtazisalida_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtazisalida.TextChanged

    End Sub

    Private Sub txtazient_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtazient.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case 46

                If InStr(txtazient.Text, ".") <> 0 Then
                    e.Handled = True
                ElseIf Len(txtazient.Text) = 0 Then
                    e.Handled = True

                End If
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtazient_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtazient.TextChanged

    End Sub

    Private Sub longbop_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles longbop.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case 46

                If InStr(longbop.Text, ".") <> 0 Then
                    e.Handled = True
                ElseIf Len(longbop.Text) = 0 Then
                    e.Handled = True

                End If
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub longbop_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles longbop.TextChanged

    End Sub

    Private Sub txtpin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpin.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case 46

                If InStr(txtpin.Text, ".") <> 0 Then
                    e.Handled = True
                ElseIf Len(txtpin.Text) = 0 Then
                    e.Handled = True

                End If
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtpin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpin.TextChanged

    End Sub

    Private Sub txtpie_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpie.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case 46

                If InStr(txtpie.Text, ".") <> 0 Then
                    e.Handled = True
                ElseIf Len(txtpie.Text) = 0 Then
                    e.Handled = True

                End If
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtpie_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpie.TextChanged

    End Sub

    Private Sub combocuerda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles combocuerda.KeyPress
        Select Case Asc(e.KeyChar)

            Case 13
                If combocuerda.Text = "" Then

                End If
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub combocuerda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combocuerda.SelectedIndexChanged

    End Sub
End Class
