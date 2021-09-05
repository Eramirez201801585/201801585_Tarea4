Module Module1

    Public Const QkwhResA As Double = 0.99
    Public Const QkwhResB As Double = 1.2
    Public Const QkwhResC As Double = 3.0
    Public Const QkwhIndA As Double = 1.99
    Public Const QkwhIndB As Double = 2.2
    Public Const QkwhIndC As Double = 4.0
    Public Const Tsocial As Double = 20 / 100
    Public Const Tnosocial As Double = 10 / 100
    Public Const Tmora As Double = 2 / 100

    Public Nombre, Servicio, Tarifa, NIT As String
    Public Consumo, SaldoAnterior As Double
    Public PagoInicial, PagoParcial, descuento, mora, PagoFinal As Double
    Public indice As Byte = 0

    Public Rcliente(11), Rnit(11), Rservicio(11), Rtarifa(11), Ranterior(11), Rmora(11), Rinicial(11), Rdescuento(11), Rparcial(11), Rfinal(11) As String

    Sub Print()
        Form1.listCliente.Items.Add(Rcliente(indice))
        Form1.listNIT.Items.Add(Rnit(indice))
        Form1.listServicio.Items.Add(Rservicio(indice))
        Form1.listTarifa.Items.Add(Rtarifa(indice))
        Form1.listSaldo.Items.Add(Ranterior(indice))
        Form1.listMora.Items.Add(Rmora(indice))
        Form1.listInicial.Items.Add(Rinicial(indice))
        Form1.listDescuento.Items.Add(Rdescuento(indice))
        Form1.listParcial.Items.Add(Rparcial(indice))
        Form1.listFinal.Items.Add(Rfinal(indice))
        indice = indice + 1
    End Sub
    Sub Lentradas()
        Form1.txtNombre.Clear()
        Form1.txtNit.Clear()
        Form1.txtSaldoAnterior.Clear()
        Form1.txtKWH.Clear()
        Form1.cmbServicio.Text = ""
        Form1.cmbTarifa.Text = ""
    End Sub

    Sub Lregistros()
        Form1.listCliente.Items.Clear()
        Form1.listNIT.Items.Clear()
        Form1.listServicio.Items.Clear()
        Form1.listTarifa.Items.Clear()
        Form1.listSaldo.Items.Clear()
        Form1.listMora.Items.Clear()
        Form1.listInicial.Items.Clear()
        Form1.listDescuento.Items.Clear()
        Form1.listParcial.Items.Clear()
        Form1.listFinal.Items.Clear()
        indice = 0
    End Sub

End Module
