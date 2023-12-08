Public Class FormCaixaPagamento
    Dim Dinheiroo, Cartaoo, Chequee, Finalise As Boolean
    Dim Valor_Entrada As Double
    Dim Valor_Total As Double = FormCaixa.Valor_Total_Final
    Dim Restante As Boolean = False
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "&Parcelado" Then
            ComboBox1.Visible = True
            Label1.Focus()
            Cartaoo = True
            Button2.Enabled = True
        End If
        If Button1.Text = "&Credito" Then '----se a escolha for credito o botton vira Parcela ----
            Button1.BackColor = Color.Gold
            Button1.Text = "&Parcelado"
            Button2.Enabled = False
            Button1.Focus()
        End If
        If Button1.Text = "&Cartão" Then '----se a escolha for cartão o botton vira credito ----
            Button1.BackColor = Color.Lavender
            Button1.Text = "&Credito"
            Button2.Text = "&Debito"
            Button1.Focus()
        End If

    End Sub

    Private Sub FormCaixaPagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Restante = False Then Label1.Text = ("R$ " & FormCaixa.Valor_Total_Final)

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.BackColor = Color.Gold
        FormCaixa.VendaCancelada()
        Finalizar_Form()
    End Sub

    Private Sub FormCaixaPagamento_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.F1
                Button1_Click(sender, e)
            Case Keys.F2
                Button2_Click(sender, e)
            Case Keys.F5
                Button4_Click(sender, e)
            Case Keys.Enter
                Button5.Focus()
                Button5.BackColor = Color.Green
        End Select
    End Sub

    Private Sub Button1_KeyUp(sender As Object, e As KeyEventArgs) Handles Button1.KeyUp
        FormCaixaPagamento_KeyUp(sender, e)

    End Sub

    Private Sub Button2_KeyUp(sender As Object, e As KeyEventArgs) Handles Button2.KeyUp
        FormCaixaPagamento_KeyUp(sender, e)
    End Sub

    Private Sub Button3_KeyUp(sender As Object, e As KeyEventArgs)
        FormCaixaPagamento_KeyUp(sender, e)
    End Sub

    Private Sub Button4_KeyUp(sender As Object, e As KeyEventArgs) Handles Button4.KeyUp
        FormCaixaPagamento_KeyUp(sender, e)
    End Sub

    Private Sub ComboBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles ComboBox1.KeyUp
        FormCaixaPagamento_KeyUp(sender, e)
    End Sub
    Sub Finalizar_Form()
        ' FormCaixa.Valor_Total_Final_ListView = FormCaixa.Valor_Total_Final
        Me.Hide()
        Varios_Pagamentos_Loop()
        Valor_Entrada = (0)
        Restante = False
FormCaixa.Valor_Total_Final = (0)

    End Sub
    Sub Varios_Pagamentos_Loop()
        Dinheiroo = False
        Dinheiroo = False
        Cartaoo = False
        Chequee = False
        ComboBox1.Visible = False
        Button1.BackColor = Color.Gainsboro
        Button2.BackColor = Color.Gainsboro
        Button4.BackColor = Color.Gainsboro
        Button5.BackColor = Color.Gainsboro
        Label6.Text = "TOTAL"
        Label1.ForeColor = Color.Black
        Button1.Focus()
        Button1.Text = "&Cartão"
        Button2.Text = "&dinheiro"
        Valor_Total = Valor_Total - Valor_Entrada
        Label1.Text = ("R$ " & Valor_Total)
        Restante = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Select Case True
            Case Finalise
                Finalizar_Form()
            Case Cartaoo
                If ComboBox1.Text <> "" Then
                    Valor_Entrada = Label1.Text
                    FormCaixa.QdtParcela = ComboBox1.Text
                    If Valor_Entrada = Valor_Total Then
                        Finalizar_Form()
                        FormCaixa.PagamentoCartão()
                    Else
                        Varios_Pagamentos_Loop()
                    End If
                Else
                    ComboBox1.Focus()
                End If
            Case Dinheiroo
                Valor_Entrada = Label1.Text
                If Label1.Text <> "" Then
                    If Valor_Entrada > Valor_Total Then
                        Valor_Total = Valor_Total - Valor_Entrada
                        Label6.Text = "Troco"
                        Label1.Text = ("R$ " & Valor_Total)
                        Label1.ForeColor = Color.Red
                        Finalise = True
                        Dinheiroo = False
                        Cartaoo = False
                        FormCaixa.PagamentoDinheiro()

                    End If
                    If Valor_Entrada < Valor_Total And Finalise = False Then
                        Varios_Pagamentos_Loop()
                    End If
                    If Valor_Total = Valor_Entrada Then
                        Finalizar_Form()
                        FormCaixa.PagamentoDinheiro()
                    End If
                End If
            Case Finalise
                Finalizar_Form()

        End Select
        'inpressora aqui
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "&Debito" Then
            Button1.BackColor = Color.Gainsboro
            Button2.BackColor = Color.Green
            Label1.Focus()
            Dinheiroo = True
        Else
            '||Pagamento
            Label6.Text = "&ENTRADA"
            Label1.Text = ""
            Label1.Focus()
            Button5.BackColor = Color.Green
            Button2.BackColor = Color.Gold
            Dinheiroo = True
        End If
    End Sub


End Class