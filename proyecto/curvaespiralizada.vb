Public Class curvaespiralizada

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub curvaespiralizada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cuerda <> 5 Then


            data.Rows.Clear()

            For x = 1 To suma + 2
                data.Rows.Add(x, "")
            Next
            sumao = suma + 1
          
            data.Item(1, suma).Value = "   Te "
            data.Item(1, cantidadec).Value = "   Ec "
            data.Item(1, cantidadec2).Value = "   Ec "
            data.Item(1, cantidadce).Value = "   Ce "
            data.Item(1, cantidadce2).Value = "   Ce "
            data.Item(1, cantidadet).Value = "   Et "
            data.Item(1, suma + 1).Value = "   Or"
            data.Item(1, suma + 2).Value = "   Pi"

            data.Item(2, suma).Value = abste
            data.Item(2, cantidadec).Value = absec
            data.Item(2, cantidadec2).Value = absec
            data.Item(2, cantidadce).Value = absce
            data.Item(2, cantidadce2).Value = absce
            data.Item(2, cantidadet).Value = abset
            sumate = suma - 1

            'For xxx = 0 To cantidad1
            'For xx = sumate To 0 Step -1

            '    data.Item(2, sumate).Value = vector(ñññ)
            'Next
            ''Nex

            'absisa 

            For i = absaproximadate To absec Step 10
                For xxx = sumate To cantidadec + 1 Step -1
                    data.Item(2, xxx).Value() = "        " & i
                Next
                sumate = sumate - 1
            Next

            For ui = absaproximadaec To absce Step 10

                For xxx = cantidadec2 - 1 To cantidadce + 1 Step -1
                    data.Item(2, xxx).Value() = "     " & ui
                Next
                cantidadec2 = cantidadec2 - 1
            Next


            For ii = absaproximadace To abset Step 10
                For xxx = cantidadce2 - 1 To cantidadet + 1 Step -1
                    data.Item(2, xxx).Value() = "     " & ii
                Next
                cantidadce2 = cantidadce2 - 1

            Next







            ''cuerda()le

            qq = absaproximadate - abste

            kk = absaproximadaec - absec
            rr = absaproximadaec - absec
            zz = abset - data.Item(2, cantidadet + 1).Value

            data.Item(3, cantidadec).Value = le

            data.Item(3, cantidadce).Value = lcarco

            data.Item(3, cantidadce - 1).Value = le


            'tetae 

            ppp = (le * 90) / (3.1416 * radio)
            ccc = (lcarco * 90) / (3.1416 * radio)



            data.Item(4, cantidadce - 1).Value = ppp
            data.Item(4, cantidadec).Value = ppp
            data.Item(4, cantidadce).Value = anguloprima




            'xe(

            data.Item(5, cantidadce - 1).Value = xe
            data.Item(5, cantidadec).Value = xe


            'ye()


            data.Item(6, cantidadce - 1).Value = ye
            data.Item(6, cantidadec).Value = ye

            'Fie

            data.Item(7, cantidadce - 1).Value = gamae
            data.Item(7, cantidadec).Value = gamae

            'cuerda larga 

            data.Item(8, cantidadce - 1).Value = cl
            data.Item(8, cantidadec).Value = cl
            data.Item(8, cantidadce).Value = radio


            'azimut()  'azimut() 
            'azimut()  'azimut() 
            If teec > 360 Then
                teec = teec - 360

            End If

            'angulodeflexion negativo?

            data.Item(9, cantidadec).Value = teec

            If angulodeflexion1 > 0 Then
                etce1 = (azisal + 180) - gamae
            Else
                etce1 = azisal + gamae
            End If
            If etce1 > 360 Then
                etce1 = etce1 - 360
            End If


            data.Item(9, cantidadce - 1).Value = etce1


            'PROYECCIONES(PROYECCIONES)


            azientte = azient + 180


            'pteyeccionte 
            proyeccionten = te * Math.Cos(0.017453292 * azientte)
            proyecciontee = te * Math.Sin(0.017453292 * azientte)

            data.Item(10, suma).Value = proyeccionten
            data.Item(11, suma).Value = proyecciontee

            'proyeccionet()

            proyeccionetn = te * Math.Cos(0.017453292 * (azisal))
            proyeccionete = te * Math.Sin(0.017453292 * azisal)

            data.Item(10, cantidadet).Value = proyeccionetn
            data.Item(11, cantidadet).Value = proyeccionete


            'proyeccion ec y  ce 

            proyeccionecn = cl * Math.Cos(0.017453292 * (teec))
            proyeccionece = cl * Math.Sin(0.017453292 * teec)

            proyeccioncen = cl * Math.Cos(0.017453292 * (etce1))
            proyeccioncee = cl * Math.Sin(0.017453292 * etce1)



            data.Item(10, cantidadec).Value = proyeccionecn
            data.Item(11, cantidadec).Value = proyeccionece

            data.Item(10, cantidadce - 1).Value = proyeccioncen
            data.Item(11, cantidadce - 1).Value = proyeccioncee


            'cordendas 
            data.Item(12, suma + 2).Value = pin
            data.Item(13, suma + 2).Value = pie

            'cordendas(te)

            nortete = pin + proyeccionten
            estete = pie + proyecciontee

            data.Item(12, suma).Value = nortete
            data.Item(13, suma).Value = estete


            'cordenadas ec 
            norteec = nortete + proyeccionecn
            esteec = estete + proyeccionece

            data.Item(12, cantidadec).Value = norteec
            data.Item(13, cantidadec).Value = esteec

            'cordenadas(et)
            norteet = pin + proyeccionetn
            esteet = pie + proyeccionete

            data.Item(12, cantidadet).Value = norteet
            data.Item(13, cantidadet).Value = esteet

            'cordenadas ce 
            nortece = norteet + proyeccioncen
            estece = esteet + proyeccioncee


            data.Item(12, cantidadce - 1).Value = nortece
            data.Item(13, cantidadce - 1).Value = estece







            'te  hasta ec 

            For ll = qq To le Step 10
                For ññ = suma - 1 To cantidadec + 1 Step -1
                    data.Item(3, ññ).Value = ll
                Next


                llpp = (ll * 90) / (3.1416 * radio)


                For pñ = suma - 1 To cantidadec + 1 Step -1
                    data.Item(4, pñ).Value = llpp
                Next

                xx = ll * (1 - 3.05 * 10 ^ -5 * llpp ^ 2 + 4.2959 * 10 ^ -10 * llpp ^ 4)


                For bn = suma - 1 To cantidadec + 1 Step -1
                    data.Item(5, bn).Value = xx
                Next

                yy = ll * ((5.8177 * 10 ^ -3 * llpp) - (1.2658 * 10 ^ -7 * llpp ^ 3) + (1.2269 * 10 ^ -12 * llpp ^ 5))

                For bnn = suma - 1 To cantidadec + 1 Step -1
                    data.Item(6, bnn).Value = yy
                Next


                gama1 = 180 / 3.1416 * Math.Atan(yy / xx)

                For bnn1 = suma - 1 To cantidadec + 1 Step -1
                    data.Item(7, bnn1).Value = gama1
                Next


                'cuerda(larga)
                cl1 = ((xx ^ 2 + yy ^ 2)) ^ (1 / 2)


                For bnn12 = suma - 1 To cantidadec + 1 Step -1
                    data.Item(8, bnn12).Value = cl1
                Next


                If angulodeflexion1 > 0 Then
                    teec1 = azient + gama1
                Else
                    teec1 = azient - gama1
                End If
                If teec1 > 360 Then
                    teec1 = teec1 - 360
                End If
                'azimut 
                For bnn123 = suma - 1 To cantidadec + 1 Step -1
                    data.Item(9, bnn123).Value = teec1
                Next


                'proyecciones
                proyeccionetn1 = cl1 * Math.Cos(0.017453292 * (teec1))
                proyeccionete1 = cl1 * Math.Sin(0.017453292 * (teec1))

                For bnn1234 = suma - 1 To cantidadec + 1 Step -1
                    data.Item(10, bnn1234).Value = proyeccionetn1
                Next


                For bnn12345 = suma - 1 To cantidadec + 1 Step -1
                    data.Item(11, bnn12345).Value = proyeccionete1
                Next



                norte1 = nortete + proyeccionetn1
                este1 = estete + proyeccionete1

                For bnn123456 = suma - 1 To cantidadec + 1 Step -1
                    data.Item(12, bnn123456).Value = norte1
                Next


                For bnn1234567 = suma - 1 To cantidadec + 1 Step -1
                    data.Item(13, bnn1234567).Value = este1
                Next



                suma = suma - 1
            Next










            'ec hasta ce 

            For uui = rr To lcarco Step 10

                For xxx = cantidadec - 2 To cantidadce + 1 Step -1
                    data.Item(3, xxx).Value = uui

                Next

                lpp = (uui * 90) / (3.1416 * radio)

                g1 = (uui * g) / 10


                For jk = cantidadec - 2 To cantidadce + 1 Step -1
                    data.Item(4, jk).Value() = g1
                Next

                'xx2 = uui * (1 - 3.05 * 10 ^ -5 * lpp ^ 2 + 4.2959 * 10 ^ -10 * lpp ^ 4)

                'For op = cantidadec - 2 To cantidadce + 1 Step -1
                '    data.Item(5, op).Value() = xx2
                'Next

                For jk2 = cantidadec - 2 To cantidadce + 1 Step -1
                    data.Item(8, jk2).Value() = radio
                Next

                'azimut()

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



                proyeccioon = radio * Math.Cos(0.017453292 * (eco))
                proyecciooe = radio * Math.Sin(0.017453292 * (eco))
                norteo = norteec + proyeccioon

                esteo = esteec + proyecciooe

                data.Item(12, sumao).Value = norteo
                data.Item(13, sumao).Value = esteo




                oce = eco + 180

                If angulodeflexion1 > 0 Then
                    oce2 = oce + anguloprima
                Else
                    oce2 = oce - anguloprima
                End If
                If oce2 > 360 Then
                    oce2 = oce2 - 360
                End If
                data.Item(9, cantidadce).Value = oce2

                proyeccioncen1 = radio * Math.Cos(0.017453292 * (oce2))
                proyeccioncee1 = radio * Math.Sin(0.017453292 * oce2)
                data.Item(10, cantidadce).Value = proyeccioncen1
                data.Item(11, cantidadce).Value = proyeccioncee1

                norteoce = norteo + proyeccioncen1
                esteoce = esteo + proyeccioncee1

                data.Item(12, cantidadce).Value = norteoce
                data.Item(13, cantidadce).Value = esteoce





                If angulodeflexion1 > 0 Then
                    oce1 = oce + g1
                Else
                    oce1 = oce - g1
                End If

                If oce1 > 360 Then
                    oce1 = oce1 - 360
                End If

                For jk2 = cantidadec - 2 To cantidadce + 1 Step -1
                    data.Item(9, jk2).Value() = oce1
                Next

                'proyecciones()
                proyeccioncurvacn = radio * Math.Cos(0.017453292 * (oce1))
                proyeccioncurvace = radio * Math.Sin(0.017453292 * (oce1))


                For jk23 = cantidadec - 2 To cantidadce + 1 Step -1
                    data.Item(10, jk23).Value() = proyeccioncurvacn
                Next

                For jk234 = cantidadec - 2 To cantidadce + 1 Step -1
                    data.Item(11, jk234).Value() = proyeccioncurvace
                Next

                norte2 = norteo + proyeccioncurvacn
                este2 = esteo + proyeccioncurvace


                For jk2345 = cantidadec - 2 To cantidadce + 1 Step -1
                    data.Item(12, jk2345).Value() = norte2
                Next
                For jk23456 = cantidadec - 2 To cantidadce + 1 Step -1
                    data.Item(13, jk23456).Value() = este2
                Next


                cantidadec = cantidadec - 1


            Next





            'Ce hasta et



            For dd = zz To le Step 10

                For xxxx = cantidadet + 1 To cantidadce - 2 Step +1
                    data.Item(3, xxxx).Value = dd
                Next

                llp = (dd * 90) / (3.1416 * radio)

                For xpp = cantidadet + 1 To cantidadce - 2 Step +1
                    data.Item(4, xpp).Value = llp
                Next


                xx2 = dd * (1 - 3.05 * 10 ^ -5 * llp ^ 2 + 4.2959 * 10 ^ -10 * llp ^ 4)

                For xpo = cantidadet + 1 To cantidadce - 2 Step +1
                    data.Item(5, xpo).Value = xx2
                Next

                yy2 = dd * ((5.8177 * 10 ^ -3 * llp) - (1.2658 * 10 ^ -7 * llp ^ 3) + (1.2269 * 10 ^ -12 * llp ^ 5))

                For xpox = cantidadet + 1 To cantidadce - 2 Step +1
                    data.Item(6, xpox).Value = yy2
                Next


                gama2 = 180 / 3.1416 * Math.Atan(yy2 / xx2)

                For xpox1 = cantidadet + 1 To cantidadce - 2 Step +1
                    data.Item(7, xpox1).Value = gama1
                Next

                'cuerda(larga)

                cl3 = ((xx2 ^ 2 + yy2 ^ 2)) ^ (1 / 2)

                For xpox12 = cantidadet + 1 To cantidadce - 2 Step +1
                    data.Item(8, xpox12).Value = cl3
                Next

                'azimut()


                If angulodeflexion1 > 0 Then
                    etce = (azisal + 180) - gama2
                Else
                    etce = azisal + gama2
                End If

                If etce > 360 Then
                    etce = etce - 360
                End If

                For xpox13 = cantidadet + 1 To cantidadce - 2 Step +1

                    data.Item(9, xpox13).Value = etce
                Next


                proyeccionetn3 = cl3 * Math.Cos(0.017453292 * (etce))
                proyeccionete3 = cl3 * Math.Sin(0.017453292 * (etce))

                For xpox134 = cantidadet + 1 To cantidadce - 2 Step +1

                    data.Item(10, xpox134).Value = proyeccionetn3
                Next
                For xpox1345 = cantidadet + 1 To cantidadce - 2 Step +1

                    data.Item(11, xpox1345).Value = proyeccionete3
                Next


                'cordenadas 
                norte3 = norteet + proyeccionetn3
                este3 = esteet + proyeccionete3


                For xpox13456 = cantidadet + 1 To cantidadce - 2 Step +1

                    data.Item(12, xpox13456).Value = norte3
                Next


                For xpox134567 = cantidadet + 1 To cantidadce - 2 Step +1

                    data.Item(13, xpox134567).Value = este3
                Next

                cantidadet = cantidadet + 1



            Next
   




        Else



            data.Rows.Clear()

            For x = 1 To suma + 2
                data.Rows.Add(x, "")
            Next
            sumao = suma + 1
            

            data.Item(1, suma).Value = "   Te "
            data.Item(1, cantidadec).Value = "   Ec "
            data.Item(1, cantidadec2).Value = "   Ec "
            data.Item(1, cantidadce).Value = "   Ce "
            data.Item(1, cantidadce2).Value = "   Ce "
            data.Item(1, cantidadet).Value = "   Et "
            data.Item(1, suma + 1).Value = "   Or"
            data.Item(1, suma + 2).Value = "   Pi"

            data.Item(2, suma).Value = abste
            data.Item(2, cantidadec).Value = absec
            data.Item(2, cantidadec2).Value = absec
            data.Item(2, cantidadce).Value = absce
            data.Item(2, cantidadce2).Value = absce
            data.Item(2, cantidadet).Value = abset
            sumate = suma - 1

            'For xxx = 0 To cantidad1
            'For xx = sumate To 0 Step -1

            '    data.Item(2, sumate).Value = vector(ñññ)
            'Next
            ''Nex

            'absisa 

            For i = absaproximadate To absec Step 5
                For xxx = sumate To cantidadec + 1 Step -1
                    data.Item(2, xxx).Value() = "        " & i
                Next
                sumate = sumate - 1
            Next

            For ui = absaproximadaec To absce Step 5

                For xxx = cantidadec2 - 1 To cantidadce + 1 Step -1
                    data.Item(2, xxx).Value() = "     " & ui
                Next
                cantidadec2 = cantidadec2 - 1
            Next


            For ii = absaproximadace To abset Step 5
                For xxx = cantidadce2 - 1 To cantidadet + 1 Step -1
                    data.Item(2, xxx).Value() = "     " & ii
                Next
                cantidadce2 = cantidadce2 - 1

            Next







            ''cuerda()le

            qq = absaproximadate - abste

            kk = absaproximadaec - absec
            rr = absaproximadaec - absec
            zz = abset - data.Item(2, cantidadet + 1).Value

            data.Item(3, cantidadec).Value = le

            data.Item(3, cantidadce).Value = lcarco

            data.Item(3, cantidadce - 1).Value = le


            'tetae 

            ppp = (le * 90) / (3.1416 * radio)
            ccc = (lcarco * 90) / (3.1416 * radio)



            data.Item(4, cantidadce - 1).Value = ppp
            data.Item(4, cantidadec).Value = ppp
            data.Item(4, cantidadce).Value = anguloprima




            'xe(

            data.Item(5, cantidadce - 1).Value = xe
            data.Item(5, cantidadec).Value = xe


            'ye()


            data.Item(6, cantidadce - 1).Value = ye
            data.Item(6, cantidadec).Value = ye

            'Fie

            data.Item(7, cantidadce - 1).Value = gamae
            data.Item(7, cantidadec).Value = gamae

            'cuerda larga 

            data.Item(8, cantidadce - 1).Value = cl
            data.Item(8, cantidadec).Value = cl
            data.Item(8, cantidadce).Value = radio


            'azimut()  'azimut() 
            'azimut()  'azimut() 
            If teec > 360 Then
                teec = teec - 360

            End If

            'angulodeflexion negativo?

            data.Item(9, cantidadec).Value = teec

            If angulodeflexion1 > 0 Then
                etce1 = (azisal + 180) - gamae
            Else
                etce1 = azisal + gamae
            End If
            If etce1 > 360 Then
                etce1 = etce1 - 360
            End If


            data.Item(9, cantidadce - 1).Value = etce1


            'PROYECCIONES(PROYECCIONES)


            azientte = azient + 180


            'pteyeccionte 
            proyeccionten = te * Math.Cos(0.017453292 * azientte)
            proyecciontee = te * Math.Sin(0.017453292 * azientte)

            data.Item(10, suma).Value = proyeccionten
            data.Item(11, suma).Value = proyecciontee

            'proyeccionet()

            proyeccionetn = te * Math.Cos(0.017453292 * (azisal))
            proyeccionete = te * Math.Sin(0.017453292 * azisal)

            data.Item(10, cantidadet).Value = proyeccionetn
            data.Item(11, cantidadet).Value = proyeccionete


            'proyeccion ec y  ce 

            proyeccionecn = cl * Math.Cos(0.017453292 * (teec))
            proyeccionece = cl * Math.Sin(0.017453292 * teec)

            proyeccioncen = cl * Math.Cos(0.017453292 * (etce1))
            proyeccioncee = cl * Math.Sin(0.017453292 * etce1)



            data.Item(10, cantidadec).Value = proyeccionecn
            data.Item(11, cantidadec).Value = proyeccionece

            data.Item(10, cantidadce - 1).Value = proyeccioncen
            data.Item(11, cantidadce - 1).Value = proyeccioncee


            'cordendas 
            data.Item(12, suma + 2).Value = pin
            data.Item(13, suma + 2).Value = pie

            'cordendas(te)

            nortete = pin + proyeccionten
            estete = pie + proyecciontee

            data.Item(12, suma).Value = nortete
            data.Item(13, suma).Value = estete


            'cordenadas ec 
            norteec = nortete + proyeccionecn
            esteec = estete + proyeccionece

            data.Item(12, cantidadec).Value = norteec
            data.Item(13, cantidadec).Value = esteec

            'cordenadas(et)
            norteet = pin + proyeccionetn
            esteet = pie + proyeccionete

            data.Item(12, cantidadet).Value = norteet
            data.Item(13, cantidadet).Value = esteet

            'cordenadas ce 
            nortece = norteet + proyeccioncen
            estece = esteet + proyeccioncee


            data.Item(12, cantidadce - 1).Value = nortece
            data.Item(13, cantidadce - 1).Value = estece







            'te  hasta ec 

            For ll = qq To le Step 5
                For ññ = suma - 1 To cantidadec + 1 Step -1
                    data.Item(3, ññ).Value = ll
                Next


                llpp = (ll * 90) / (3.1416 * radio)


                For pñ = suma - 1 To cantidadec + 1 Step -1
                    data.Item(4, pñ).Value = llpp
                Next

                xx = ll * (1 - 3.05 * 10 ^ -5 * llpp ^ 2 + 4.2959 * 10 ^ -10 * llpp ^ 4)


                For bn = suma - 1 To cantidadec + 1 Step -1
                    data.Item(5, bn).Value = xx
                Next

                yy = ll * ((5.8177 * 10 ^ -3 * llpp) - (1.2658 * 10 ^ -7 * llpp ^ 3) + (1.2269 * 10 ^ -12 * llpp ^ 5))

                For bnn = suma - 1 To cantidadec + 1 Step -1
                    data.Item(6, bnn).Value = yy
                Next


                gama1 = 180 / 3.1416 * Math.Atan(yy / xx)

                For bnn1 = suma - 1 To cantidadec + 1 Step -1
                    data.Item(7, bnn1).Value = gama1
                Next


                'cuerda(larga)
                cl1 = ((xx ^ 2 + yy ^ 2)) ^ (1 / 2)


                For bnn12 = suma - 1 To cantidadec + 1 Step -1
                    data.Item(8, bnn12).Value = cl1
                Next


                If angulodeflexion1 > 0 Then
                    teec1 = azient + gama1
                Else
                    teec1 = azient - gama1
                End If
                If teec1 > 360 Then
                    teec1 = teec1 - 360
                End If
                'azimut 
                For bnn123 = suma - 1 To cantidadec + 1 Step -1
                    data.Item(9, bnn123).Value = teec1
                Next


                'proyecciones
                proyeccionetn1 = cl1 * Math.Cos(0.017453292 * (teec1))
                proyeccionete1 = cl1 * Math.Sin(0.017453292 * (teec1))

                For bnn1234 = suma - 1 To cantidadec + 1 Step -1
                    data.Item(10, bnn1234).Value = proyeccionetn1
                Next


                For bnn12345 = suma - 1 To cantidadec + 1 Step -1
                    data.Item(11, bnn12345).Value = proyeccionete1
                Next



                norte1 = nortete + proyeccionetn1
                este1 = estete + proyeccionete1

                For bnn123456 = suma - 1 To cantidadec + 1 Step -1
                    data.Item(12, bnn123456).Value = norte1
                Next


                For bnn1234567 = suma - 1 To cantidadec + 1 Step -1
                    data.Item(13, bnn1234567).Value = este1
                Next



                suma = suma - 1
            Next










            'ec hasta ce 

            For uui = rr To lcarco Step 5

                For xxx = cantidadec - 2 To cantidadce + 1 Step -1
                    data.Item(3, xxx).Value = uui

                Next

                lpp = (uui * 90) / (3.1416 * radio)

                g1 = (uui * g) / 10


                For jk = cantidadec - 2 To cantidadce + 1 Step -1
                    data.Item(4, jk).Value() = g1
                Next

                'xx2 = uui * (1 - 3.05 * 10 ^ -5 * lpp ^ 2 + 4.2959 * 10 ^ -10 * lpp ^ 4)

                'For op = cantidadec - 2 To cantidadce + 1 Step -1
                '    data.Item(5, op).Value() = xx2
                'Next

                For jk2 = cantidadec - 2 To cantidadce + 1 Step -1
                    data.Item(8, jk2).Value() = radio
                Next

                'azimut()

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



                proyeccioon = radio * Math.Cos(0.017453292 * (eco))
                proyecciooe = radio * Math.Sin(0.017453292 * (eco))
                norteo = norteec + proyeccioon

                esteo = esteec + proyecciooe

                data.Item(12, sumao).Value = norteo
                data.Item(13, sumao).Value = esteo




                oce = eco + 180

                If angulodeflexion1 > 0 Then
                    oce2 = oce + anguloprima
                Else
                    oce2 = oce - anguloprima
                End If
                If oce2 > 360 Then
                    oce2 = oce2 - 360
                End If
                data.Item(9, cantidadce).Value = oce2

                proyeccioncen1 = radio * Math.Cos(0.017453292 * (oce2))
                proyeccioncee1 = radio * Math.Sin(0.017453292 * oce2)
                data.Item(10, cantidadce).Value = proyeccioncen1
                data.Item(11, cantidadce).Value = proyeccioncee1

                norteoce = norteo + proyeccioncen1
                esteoce = esteo + proyeccioncee1

                data.Item(12, cantidadce).Value = norteoce
                data.Item(13, cantidadce).Value = esteoce





                If angulodeflexion1 > 0 Then
                    oce1 = oce + g1
                Else
                    oce1 = oce - g1
                End If

                If oce1 > 360 Then
                    oce1 = oce1 - 360
                End If

                For jk2 = cantidadec - 2 To cantidadce + 1 Step -1
                    data.Item(9, jk2).Value() = oce1
                Next

                'proyecciones()
                proyeccioncurvacn = radio * Math.Cos(0.017453292 * (oce1))
                proyeccioncurvace = radio * Math.Sin(0.017453292 * (oce1))


                For jk23 = cantidadec - 2 To cantidadce + 1 Step -1
                    data.Item(10, jk23).Value() = proyeccioncurvacn
                Next

                For jk234 = cantidadec - 2 To cantidadce + 1 Step -1
                    data.Item(11, jk234).Value() = proyeccioncurvace
                Next

                norte2 = norteo + proyeccioncurvacn
                este2 = esteo + proyeccioncurvace


                For jk2345 = cantidadec - 2 To cantidadce + 1 Step -1
                    data.Item(12, jk2345).Value() = norte2
                Next
                For jk23456 = cantidadec - 2 To cantidadce + 1 Step -1
                    data.Item(13, jk23456).Value() = este2
                Next


                cantidadec = cantidadec - 1


            Next





            'Ce hasta et



            For dd = zz To le Step 5

                For xxxx = cantidadet + 1 To cantidadce - 2 Step +1
                    data.Item(3, xxxx).Value = dd
                Next

                llp = (dd * 90) / (3.1416 * radio)

                For xpp = cantidadet + 1 To cantidadce - 2 Step +1
                    data.Item(4, xpp).Value = llp
                Next


                xx2 = dd * (1 - 3.05 * 10 ^ -5 * llp ^ 2 + 4.2959 * 10 ^ -10 * llp ^ 4)

                For xpo = cantidadet + 1 To cantidadce - 2 Step +1
                    data.Item(5, xpo).Value = xx2
                Next

                yy2 = dd * ((5.8177 * 10 ^ -3 * llp) - (1.2658 * 10 ^ -7 * llp ^ 3) + (1.2269 * 10 ^ -12 * llp ^ 5))

                For xpox = cantidadet + 1 To cantidadce - 2 Step +1
                    data.Item(6, xpox).Value = yy2
                Next


                gama2 = 180 / 3.1416 * Math.Atan(yy2 / xx2)

                For xpox1 = cantidadet + 1 To cantidadce - 2 Step +1
                    data.Item(7, xpox1).Value = gama1
                Next

                'cuerda(larga)

                cl3 = ((xx2 ^ 2 + yy2 ^ 2)) ^ (1 / 2)

                For xpox12 = cantidadet + 1 To cantidadce - 2 Step +1
                    data.Item(8, xpox12).Value = cl3
                Next

                'azimut()


                If angulodeflexion1 > 0 Then
                    etce = (azisal + 180) - gama2
                Else
                    etce = azisal + gama2
                End If

                If etce > 360 Then
                    etce = etce - 360
                End If

                For xpox13 = cantidadet + 1 To cantidadce - 2 Step +1

                    data.Item(9, xpox13).Value = etce
                Next


                proyeccionetn3 = cl3 * Math.Cos(0.017453292 * (etce))
                proyeccionete3 = cl3 * Math.Sin(0.017453292 * (etce))

                For xpox134 = cantidadet + 1 To cantidadce - 2 Step +1

                    data.Item(10, xpox134).Value = proyeccionetn3
                Next
                For xpox1345 = cantidadet + 1 To cantidadce - 2 Step +1

                    data.Item(11, xpox1345).Value = proyeccionete3
                Next


                'cordenadas 
                norte3 = norteet + proyeccionetn3
                este3 = esteet + proyeccionete3


                For xpox13456 = cantidadet + 1 To cantidadce - 2 Step +1

                    data.Item(12, xpox13456).Value = norte3
                Next


                For xpox134567 = cantidadet + 1 To cantidadce - 2 Step +1

                    data.Item(13, xpox134567).Value = este3
                Next

                cantidadet = cantidadet + 1



            Next
        End If






    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub Exportar_Excel(ByVal dgv As DataGridView, ByVal Ruta As String)
        'crear una nueva hoja de calculo 
        Dim xlApp As Object = CreateObject("Excel.Application")
        Dim xlWB As Object = xlApp.WorkBooks.add
        ' se crea la Hoja de calculo
        Dim xlWS As Object = xlWB.WorkSheets(1)

        'exportamos los encabezados  (titulos) de las columnas
        For i As Integer = 0 To dgv.Columns.Count - 1
            xlWS.cells(1, i + 1).value = dgv.Columns(i).HeaderText
        Next
        'exportamos los datos del datagrid recorriendo por fila y columnas
        For j As Integer = 0 To dgv.RowCount - 1
            For i As Integer = 0 To dgv.Columns.Count - 1
                xlWS.cells(j + 2, i + 1).value = dgv.Item(i, j).Value
            Next
        Next
        'guardamos la hoja de calculo en la ruta especificada 
        xlWB.saveas(Ruta)
        xlWS = Nothing
        xlWB = Nothing
        xlApp.quit()
        xlApp = Nothing
    End Sub



    Private Sub btnimportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnimportar.Click
        Dim grabar As New SaveFileDialog
        grabar.Filter = "Archivo Excel | *.xlsx"
        If grabar.ShowDialog = Windows.Forms.DialogResult.OK Then
            Exportar_Excel(Me.data, grabar.FileName)
        End If
    End Sub
    Public Sub Exportar_Excel2(ByVal dgv As DataGridView, ByVal Ruta As String)
        'crear una nueva hoja de calculo 
        Dim xlApp As Object = CreateObject("Excel.Application")
        Dim xlWB As Object = xlApp.WorkBooks.add
        ' se crea la Hoja de calculo
        Dim xlWS As Object = xlWB.WorkSheets(1)

        ''exportamos los encabezados  (titulos) de las columnas
        'For i As Integer = 0 To dgv.Columns.Count - 1
        '    xlWS.cells(1, i + 1).value = dgv.Columns(i).HeaderText
        'Next
        'exportamos los datos del datagrid recorriendo por fila y columnas
        For j As Integer = 0 To dgv.RowCount - 1
            For i As Integer = 12 To dgv.Columns.Count - 1
                xlWS.cells(j + 2, i + 1).value = dgv.Item(i, j).Value
            Next
        Next
        'guardamos la hoja de calculo en la ruta especificada 
        xlWB.saveas(Ruta)
        xlWS = Nothing
        xlWB = Nothing
        xlApp.quit()
        xlApp = Nothing
    End Sub
    Private Sub txtexportar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtexportar2.Click
        Dim grabar2 As New SaveFileDialog
        grabar2.Filter = "Archivo Excel | *.xlsx"
        If grabar2.ShowDialog = Windows.Forms.DialogResult.OK Then
            Exportar_Excel2(Me.data, grabar2.FileName)
        End If
    End Sub
End Class