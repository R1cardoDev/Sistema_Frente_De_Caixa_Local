Imports System.Data
Imports System.Data.OleDb
Public Class FormCaixa
    'variavel de verificação de inicio de cupon
    Dim VerificaCupon As Boolean = False
    Dim TraçoCompreto As String = "----------------------------------------------------------------------------------------" 
    Dim Spaço As String = "                    "
    Dim spaço1 As String = "         "
    Dim spaço2 As String = Spaço + Spaço + Spaço + spaço1 + spaço1
    Dim Trava_execuçao As Boolean = False
    Dim Trava_inicio As Boolean = True
    Dim trava_Final As Boolean = False
    Public Valor_Total_Final_ListView As Decimal = TextBoxTotal.Text

    Sub Inicio_Cupon_Fiscal()
        If VerificaCupon = False Then
            ListBoxCupon.Items.Add(TraçoCompreto)
            ListBoxCupon.Items.Add(Spaço + Spaço & "**CUPON FISCAL**")
            ListBoxCupon.Items.Add("ITEM CODIGO" & Spaço & "Descrição")
            ListBoxCupon.Items.Add("QTD." & spaço1 & "UN." & spaço1 & "VL.UNIT.(R$)" & spaço1 & "ST." & spaço1 & "VL.ITEM.(R$)")
            ListBoxCupon.Items.Add(TraçoCompreto)
            VerificaCupon = True

        End If
    End Sub
    Sub Final_Cupon_fiscal()
        ListBoxCupon.Items.Add("MOVIMENTAÇÃO" & Spaço + Spaço & Date.Now)
        ListBoxCupon.Items.Add("CNPJ" & Spaço + Spaço + Spaço & "000.00.000.000.00")
        ListBoxCupon.Items.Add(spaço1 & "OBRIGADO PELA PREFERENCIA! VOLTE SEMPRE")
        Trava_inicio = True
        trava_Final = True
    End Sub

    Public Sub PagamentoDinheiro()
        ListBoxCupon.Items.Add(TraçoCompreto)
        ListBoxCupon.Items.Add("TOTAL" & spaço2 & Valor_Total_Final_ListView)
        ListBoxCupon.Items.Add("TIPO DE PAGAMENTO" & Spaço + spaço1 & spaço1 & "DINHEIRO")
        Final_Cupon_fiscal()
        Trava_inicio = True
        trava_Final = True
    End Sub
    Public QdtParcela As Integer
    Public Sub PagamentoCartão()
        ListBoxCupon.Items.Add(TraçoCompreto)
        ListBoxCupon.Items.Add("TOTAL" & spaço2 & Valor_Total_Final_ListView)
        ListBoxCupon.Items.Add("TIPO DE PAGAMENTO" & Spaço + Spaço + spaço1 & "CARTÃO")
        ListBoxCupon.Items.Add("QUANTIDADE DE PARCELA" & Spaço + Spaço + spaço1 & QdtParcela)
        Final_Cupon_fiscal()
        Trava_inicio = True
        trava_Final = True
    End Sub
    Public Sub VendaCancelada()
        ListBoxCupon.Items.Add(TraçoCompreto)
        ListBoxCupon.Items.Add("VENDA CANCELADA!")
        ListBoxCupon.Items.Add("FAVOR LANÇAR MERCADORIA NO ESTOQUE NOVAMENTE!")
        Trava_execuçao = True
        Trava_inicio = True
        trava_Final = True

    End Sub
    'conexão com banco de dado
    Private Sub Timerstring_Tick(sender As Object, e As EventArgs) Handles Timerstring.Tick
        If Focus() <> TextBoxCod_Barra.Focus Then TextBoxCod_Barra.Focus()
        If TextBoxCod_Barra.Text = "" Then
            TextBoxNome.Clear()
            TextBoxDescrição.Clear()
            TextBoxValor.Clear()
            TextBoxQuatidade_intem.Clear()
            TextBoxTotal.Clear()
        End If
    End Sub
    'adicionando itens a listview
    Sub ListView_Adicionar()
        Inicio_Cupon_Fiscal()
        Valor_Total = QTintem_Vendido * Prod_Preç_Ven
        Dim newlistViewItem As New ListViewItem
        newlistViewItem.Text = (TextBoxNome.Text)
        newlistViewItem.SubItems.Add(TextBoxDescrição.Text)
        newlistViewItem.SubItems.Add(TextBoxValor.Text)
        newlistViewItem.SubItems.Add(TextBoxQuatidade_intem.Text)
        newlistViewItem.SubItems.Add(Valor_Total)
        Dim QuantidadeIntem As Integer = TextBoxQuatidade_intem.Text
        Dim ValorProduto As Integer = TextBoxValor.Text
        Dim TotalSoma As Integer = QuantidadeIntem * ValorProduto
        ListBoxCupon.Items.Add(TextBoxCod_Barra.Text & Spaço & TextBoxNome.Text)
        ListBoxCupon.Items.Add(TextBoxQuatidade_intem.Text & Spaço & "x" & Spaço & TextBoxValor.Text & Spaço & TotalSoma)
        QuantidadeIntem = "0"
        ValorProduto = "0"
        TotalSoma = "0"
        QTintem_Vendido = "1"
        TextBoxNome.Clear()
        TextBoxDescrição.Clear()
        TextBoxValor.Clear()
        TextBoxQuatidade_intem.Clear()
        TextBoxTotal.Clear()
        TextBoxCod_Barra.Text = ""
    End Sub
    Sub FormCaixa_Load()
        ListBoxCupon.Items.Clear()
        TextBoxCod_Barra.Clear()
        QTintem_Vendido = "1"
        TextBoxNome.Clear()
        TextBoxDescrição.Clear()
        TextBoxValor.Clear()
        TextBoxQuatidade_intem.Clear()
        TextBoxTotal.Clear()
        TextBoxCod_Barra.Text = ""
        Inicio_Cupon_Fiscal()
    End Sub

    Private Sub TextBoxCod_Barra_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxCod_Barra.KeyUp
        Select Case e.KeyCode
            Case Keys.F2 'finalizar compra
                If Trava_inicio = False And trava_Final = False Then FormCaixaPagamento.ShowDialog()
            Case Keys.Escape 'finaliza form caixa
                If Timerstring.Enabled = True Then Timerstring.Enabled = False 'desligando timer de atualização
                If fminiciar.MenuStripiniciar.Visible = False Then fminiciar.MenuStripiniciar.Visible = True '/voltando com barra de navegação
                FormCaixa_Load() 'limpando listview
                Trava_execuçao = False
                trava_Final = False
                Trava_inicio = True
                VerificaCupon = False
                Me.Hide() 'finalizado form
            Case Keys.Enter
                Trava_inicio = False
                'adicionando intem a listview e limpando textbox
                If trava_Final = False And TextBoxCod_Barra.Text <> "" Then  'verifica se a valor para dar baixa e chava Sub atualizar_quantidade_intem_passo1
                    If TextBoxNome.Text <> "" And TextBoxNome.Text <> "Intem Não Emcontrado" Then
                        atualizar_qtd_intem_estoque() 'atualizando quantidade de intem no estoque
                        ListView_Adicionar()  'chamado sub listview
                        If Est_Quan < 3 Then MessageBox.Show("Imtem Em Falta No Estoque")
                    Else
                        TextBoxNome.Text = "Intem Não Encontrado"
                        TextBoxCod_Barra.Text = ""
                    End If
                End If
            Case Keys.F1
                If Trava_execuçao = False And trava_Final = False Then
                    Timerstring.Enabled = False
                    TextBoxQuatidade_intem.Focus()
                    Label9.Text = "[F1] SALVAR ALTERAÇÃO"
                End If
            Case Keys.F3
                If Trava_inicio = False And Trava_execuçao = False And trava_Final = False And TextBoxCod_Barra.Text <> "" Then VendaCancelada()
            Case Keys.F4
                VerificaCupon = False
                FormCaixa_Load()
                Timerstring.Enabled = True
                Trava_execuçao = False
                trava_Final = False
                Trava_inicio = True
            Case Keys.F5
                MsgBox("Entre em contato com administrador")
        End Select
    End Sub
    'carregando tabela ESTOQUE
    Dim Est_Cod_Pro, Est_Quan As Integer
    Dim Est_Data_Ent, Est_Data_Said As Date
    Sub Carrega_Estoque_nas_variavel()
        Dim myConnction As New OleDbConnection(myConnstring)
        myConnction.Open()              'selecionando tabela PRODUTO o Valor Cod_Produto
        Dim myCommand As New OleDbCommand("SELECT * FROM ESTOQUE WHERE Cod_Estoque LIKE @Cod_Estoque", myConnction)
        myCommand.Parameters.AddWithValue("@Cod_Estoque", TextBoxCod_Barra.Text)
        Dim myReader As OleDbDataReader = myCommand.ExecuteReader
        'carregando cados nas variaveis
        While myReader.Read
            Est_Cod_Pro = myReader("Cod_Produto") 'carregando variavel
            Est_Data_Ent = myReader("Data_Entrada")
            Est_Data_Said = myReader("Data_Saida")
            Est_Quan = myReader("Quantidade")
            Carregar_tabela_produto_textbox() 'carregando intens nas Textbox
        End While
        myConnction.Close()
    End Sub
    'Carregando tabela PRODUTO
    Public Prod_Preç_Ven, Valor_Total_Final, Valor_Total As Decimal
    Dim QTintem_Vendido As Integer = 1 'variavel utilizada para baixa quatidade de intem no estoque

    Private Sub TextBoxQuatidade_intem_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxQuatidade_intem.KeyUp
        Select Case e.KeyCode
            Case Keys.F1
                If Trava_execuçao = False Then
                    If TextBoxQuatidade_intem.Text = "" Then TextBoxQuatidade_intem.Text = "1"
                    QTintem_Vendido = TextBoxQuatidade_intem.Text
                    TextBoxTotal.Text = ("R$ " & QTintem_Vendido * Prod_Preç_Ven) 'carregando O total A Ser Pago
                    Timerstring.Enabled = True
                    Label9.Text = "[F1] Alterar Quantidade"
                    TextBoxTotal.Clear()
                End If
        End Select
    End Sub

    Sub Carregar_tabela_produto_textbox()
        Dim myconnction As New OleDbConnection(myConnstring)
        myconnction.Open()              '/selecionando tabela produto o valor cod_produto
        Dim mycommand As New OleDbCommand("SELECT * FROM Produtos WHERE Cod_Produto like @Cod_Produto", myconnction)
        mycommand.Parameters.AddWithValue("@Cod_Produto", Est_Cod_Pro)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader
        'carregando dados nos textbox
        While myreader.Read
            TextBoxNome.Text = myreader("Nome")
            TextBoxDescrição.Text = myreader("Descrição")
            Prod_Preç_Ven = myreader("Preço_Venda")
            TextBoxValor.Text = ("R$ " & Prod_Preç_Ven)
            TextBoxQuatidade_intem.Text = QTintem_Vendido
            Valor_Total_Final = Valor_Total_Final + QTintem_Vendido * Prod_Preç_Ven
            TextBoxTotal.Text = ("R$ " & Valor_Total_Final) 'carregando O total A Ser Pago

        End While
        myconnction.Close()
    End Sub
    'atualizando quatidade da tabela estoque
    Sub Atualizar_qtd_intem_estoque()
        Est_Quan = Est_Quan - QTintem_Vendido 'efetuando conta para baixar intem no estoque
        Dim myConnction As New OleDbConnection(myConnstring)
        myConnction.Open() 'abrindo conecção
        Dim mycommand As New OleDbCommand("UPDATE ESTOQUE  SET Data_Saida = @Data_Saida, Quantidade = @Quantidade WHERE Cod_Estoque = @Cod_Estoque ", myConnction)
        mycommand.Parameters.AddWithValue("@Data_Saida", DateString)
        mycommand.Parameters.AddWithValue("@Quantidade", Est_Quan)
        mycommand.Parameters.AddWithValue("@Cod_Estoque", Integer.Parse(TextBoxCod_Barra.Text))
        mycommand.ExecuteNonQuery()
        myConnction.Close()
        ' Incerir_Venda() 'Inserindo Itens na Tabela Venda
    End Sub
    Sub Incerir_Venda()
        Dim myConnction As New OleDbConnection(myConnstring)
        myConnction.Open()
        Dim myCommand As New OleDbCommand("INSERT INTO VENDA (Cod_Estoque) VALUES (@Cod_Estoque)", myConnction)
        myCommand.Parameters.AddWithValue("@Cod_Estoque", Est_Cod_Pro)
        myCommand.ExecuteNonQuery()
        myConnction.Close()
    End Sub
    Private Sub TextBoxCod_Barra_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCod_Barra.TextChanged

        If Trava_execuçao = False And trava_Final = False Then Carrega_Estoque_nas_variavel()

    End Sub
End Class