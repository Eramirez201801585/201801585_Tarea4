Imports System.Math
Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        If txtNombre.Text = "" Then
            MsgBox("Por favor ingrese el nombre del cliente.",, "Error")
            txtNombre.Focus()
            Exit Sub
        ElseIf txtNit.Text = "" Or IsNumeric(txtNit.Text) = False Then
            MsgBox("Por favor Verifique que el NIT del cliente sea válido",, "Error")
            txtNit.Focus()
            Exit Sub
        ElseIf txtSaldoAnterior.Text = "" Or IsNumeric(txtSaldoAnterior.Text) = False Then
            MsgBox("Por favor ingrese saldo anterior",, "Error")
            txtSaldoAnterior.Focus()
            Exit Sub
        ElseIf txtKWH.Text = "" Or IsNumeric(txtKWH.Text) = False Then
            MsgBox("Por favor ingrese consumo de kwh",, "Error")
            txtKWH.Focus()
            Exit Sub
        ElseIf cmbServicio.Text = "" Then
            MsgBox("Por favor seleccione el tipo de Servicio",, "Error")
            Exit Sub
        ElseIf cmbTarifa.Text = "" Then
            MsgBox("Por favor seleccione el tipo de Tarifa",, "Error")
            Exit Sub
        End If
        If indice < 11 Then
            Nombre = txtNombre.Text
            NIT = Str(txtNit.Text)
            SaldoAnterior = Round(Val(txtSaldoAnterior.Text), 2)
            Consumo = Round(Val(txtKWH.Text), 2)
            Servicio = cmbServicio.Text
            Tarifa = cmbTarifa.Text
            Select Case Servicio
                Case "Residencial"
                    Select Case Consumo
                        Case 1 To 100.99
                            PagoInicial = Consumo * QkwhResA
                        Case 101 To 300.99
                            PagoInicial = Consumo * QkwhResB
                        Case >= 301
                            PagoInicial = Consumo * QkwhResC
                    End Select
                Case "Industrial"
                    Select Case Consumo
                        Case 1 To 100.99
                            PagoInicial = Consumo * QkwhIndA
                        Case 101 To 300.99
                            PagoInicial = Consumo * QkwhIndB
                        Case >= 301
                            PagoInicial = Consumo * QkwhIndC
                    End Select
            End Select

            If SaldoAnterior > 0 Then
                mora = SaldoAnterior * Tmora
            Else
                mora = 0
            End If

            Select Case Tarifa
                Case "Social"
                    PagoParcial = SaldoAnterior + PagoInicial
                    descuento = PagoParcial * Tsocial
                    PagoFinal = PagoParcial + mora - descuento

                Case "No social"
                    descuento = PagoInicial * Tnosocial
                    PagoFinal = SaldoAnterior + mora + PagoInicial - descuento

            End Select

            Rcliente(indice) = Nombre
            Rnit(indice) = NIT
            Rservicio(indice) = Servicio
            Rtarifa(indice) = Tarifa
            Ranterior(indice) = Str(Round(SaldoAnterior, 2))
            Rinicial(indice) = Str(Round(PagoInicial, 2))
            Rparcial(indice) = Str(Round(PagoParcial, 2))
            Rdescuento(indice) = Str(descuento)
            Rmora(indice) = Str(Round(mora, 2))
            Rfinal(indice) = Str(Round(PagoFinal, 2))
            Print()

        Else
            MsgBox("Ha llegado al máximo de registros. Limpie los registros.",, "Error")
        End If


    End Sub

    Private Sub btnLentradas_Click(sender As Object, e As EventArgs) Handles btnLentradas.Click
        If MsgBox("¿Desea limpiar las entradas?", vbYesNo, "Avertencia") = MsgBoxResult.Yes Then
            Lentradas()
        End If
    End Sub

    Private Sub btnLregistros_Click(sender As Object, e As EventArgs) Handles btnLregistros.Click
        If MsgBox("¿Desea limpiar los registros", vbYesNo, "Advertencia") = MsgBoxResult.Yes Then
            Lregistros()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        If MsgBox("¿Desea salir?", vbYesNo, "Advertencia") = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub
End Class
