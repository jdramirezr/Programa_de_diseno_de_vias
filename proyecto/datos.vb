Public Class datos

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub datos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txttetae.Text = tetae
        txtanguloprima.Text = anguloprima
        txtxe.Text = xe
        txtye.Text = ye
        txtp.Text = p
        txtA.Text = a
        txtp.Text = p
        txtradio.Text = radio
        txtle.Text = le
        txtk.Text = k
        txtte.Text = te
        txtEe.Text = ee
        txttl.Text = tl
        txttc.Text = tc
        txtt.Text = t
        txtgamae.Text = gamae
        txtz.Text = z
        txtcl.Text = cl
        txtg.Text = g
        txtlcarc.Text = lcarco
        txtclcurva.Text = clcurva
        txtazient.Text = azient
        txtazisalida.Text = azisal
        txtabspi.Text = abspi
        txtabste.Text = abste
        txtabset.Text = abset
        txtabsce.Text = absce
        txtabsec.Text = absec
        txtpite.Text = pite
        txtpieec.Text = pieec
        txteco.Text = eco
        txtteec.Text = teec
        TextBox1.Text = absaproximadate1
        TextBox2.Text = absaproximadace1
        TextBox3.Text = absaproximadaec1
        
    End Sub

    Private Sub btncalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncalcular.Click
        
        absaproximadate = TextBox1.Text
        absaproximadace = TextBox2.Text
        absaproximadaec = TextBox3.Text
       
        If cuerda <> 5 Then


            For i = absaproximadate To absec Step 10

                cantidad1 = cantidad1 + 1


            Next


            For ii = absaproximadace To abset Step 10

                cantidad2 = cantidad2 + 1
            Next

            For ui = absaproximadaec To absce Step 10
                cantidad3 = cantidad3 + 1

            Next
         

            suma = cantidad1 + cantidad2 + cantidad3 + 5
            sumas = cantidad1 + cantidad2 + cantidad3 + 5

            cantidadec = suma - cantidad1 - 1
            cantidadec2 = cantidadec - 1
            cantidadce = cantidadec2 - cantidad3 - 1
            cantidadce2 = cantidadce - 1
            cantidadet = cantidadce2 - cantidad2 - 1


            curvaespiralizada.Show()

        Else

            For i = absaproximadate To absec Step 5

                cantidad1 = cantidad1 + 1


            Next


            For ii = absaproximadace To abset Step 5

                cantidad2 = cantidad2 + 1
            Next

            For ui = absaproximadaec To absce Step 5
                cantidad3 = cantidad3 + 1

            Next
           

            suma = cantidad1 + cantidad2 + cantidad3 + 5
            sumas = cantidad1 + cantidad2 + cantidad3 + 5

            cantidadec = suma - cantidad1 - 1
            cantidadec2 = cantidadec - 1
            cantidadce = cantidadec2 - cantidad3 - 1
            cantidadce2 = cantidadce - 1
            cantidadet = cantidadce2 - cantidad2 - 1


            curvaespiralizada.Show()




        End If


    End Sub

    Private Sub txtradio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtradio.KeyPress
        Select Case Asc(e.KeyChar)
        
            Case 13
                If txtradio.Text = "" Then

                End If
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtradio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtradio.TextChanged

    End Sub

    Private Sub txtpite_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpite.TextChanged

    End Sub
End Class