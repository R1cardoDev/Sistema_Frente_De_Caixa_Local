Imports System.Data
Imports System.Data.OleDb
Public Class FormEstoque
    Dim Vericar_Qual_Busca As Boolean
    Dim Cod_Incerir_Estoque, Cod_Atualizar_Estoque As Integer
    Public Sub loadform()
        Carregar_Tabela_ListView()
    End Sub
    Private Sub ButtonSair_Click_1(sender As Object, e As EventArgs) Handles ButtonSair.Click
        Me.ResetText()
        Me.Hide()
    End Sub
    Sub Carregar_Tabela_ListView()
        ListView5.Items.Clear() 'Limpar Intem Listvwiew
        Dim myConnction As New OleDbConnection(myConnstring)
        myConnction.Open()
        Dim myCommand As New OleDbCommand("SELECT * FROM ESTOQUE ", myConnction)
        Dim myReader As OleDbDataReader = myCommand.ExecuteReader
        While myReader.Read
            Dim newlistViewItem As New ListViewItem
            newlistViewItem.Text = myReader.GetInt32(0)
            newlistViewItem.SubItems.Add(myReader.GetInt32(1))
            newlistViewItem.SubItems.Add(myReader.GetDateTime(2))
            newlistViewItem.SubItems.Add(myReader.GetDateTime(3))
            newlistViewItem.SubItems.Add(myReader.GetInt32(4))
            ListView5.Items.Add(newlistViewItem)
            Cod_EstoqueTextBox.Clear()
            Data_EntradaTextBox.Text = Date.Today
            Data_SaidaTextBox.Text = Date.Today
            QuantidadeTextBox.Clear()
            NomeTextBox.Clear()
            DescriçãoTextBox.Clear()
            Preço_VendaTextBox.Clear()
            Data_EntradaTextBox.Clear()
            Data_SaidaTextBox.Clear()
            Cod_EstoqueTextBox.Focus()
            Button1.Enabled = False
        End While
        myConnction.Close()
    End Sub
    '||INICIO DA BUSCA PELO CODIGO DO ESTOQUE
    Private Sub Cod_EstoqueTextBox_TextChanged(sender As Object, e As EventArgs) Handles Cod_EstoqueTextBox.TextChanged
        If CheckBox1.Checked = False Then
            If Cod_EstoqueTextBox.Text <> "" Then Carregar_Busca_Cod_Estoque_P1() Else Carregar_Tabela_ListView() '||Retornando Valor NO listiView
        Else
            If Cod_EstoqueTextBox.Text <> "" Then Carregar_Busca_Cod_Produto_P1() Else Carregar_Tabela_ListView()
        End If

    End Sub
    Sub Carregar_Busca_Cod_Estoque_P1()
        Dim myconnction As New OleDbConnection(myConnstring)
        myconnction.Open()              '/selecionando tabela produto o valor cod_produto
        Dim mycommand As New OleDbCommand("SELECT * FROM Consulta_Para_Venda WHERE Cod_Estoque like @Cod_Estoque", myconnction)
        mycommand.Parameters.AddWithValue("@Cod_Estoque", Cod_EstoqueTextBox.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader
        While myreader.Read '|||carregando dados nos textbox
            QuantidadeTextBox.Text = myreader("Quantidade")
            NomeTextBox.Text = myreader("Nome")
            DescriçãoTextBox.Text = myreader("Descrição")
            Preço_VendaTextBox.Text = myreader("Preço_Venda")
        End While
        myconnction.Close()
        Carregar_Busca_Cod_Estoque_P2()
    End Sub
    Sub Carregar_Busca_Cod_Estoque_P2()
        Dim myconnction As New OleDbConnection(myConnstring)
        myconnction.Open()              '/selecionando tabela produto o valor cod_produto
        Dim mycommand As New OleDbCommand("SELECT * FROM ESTOQUE WHERE Cod_Estoque like @Cod_Estoque", myconnction)
        mycommand.Parameters.AddWithValue("@Cod_Estoque", Cod_EstoqueTextBox.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader
        While myreader.Read
            Dim newlistViewItem As New ListViewItem
            Cod_Incerir_Estoque = myreader("Cod_Produto")
            Data_EntradaTextBox.Text = myreader("Data_Entrada")
            Data_SaidaTextBox.Text = myreader("Data_Saida")
            'Linpar ListView
            ListView5.Items.Clear()
            newlistViewItem.Text = myreader.GetInt32(0)
            newlistViewItem.SubItems.Add(myreader.GetInt32(1))
            newlistViewItem.SubItems.Add(myreader.GetDateTime(2))
            newlistViewItem.SubItems.Add(myreader.GetDateTime(3)) 'Data de saida--
            newlistViewItem.SubItems.Add(myreader.GetInt32(4))
            ListView5.Items.Add(newlistViewItem)
        End While
        myconnction.Close()
    End Sub
    '||FIM DA BUSCA PELO CODIGO DO ESTOQUE
    '||INICIO DA BUSCA PELO CODIGO PRODUTO
    Sub Carregar_Busca_Cod_Produto_P1()
        Dim myconnction As New OleDbConnection(myConnstring)
        myconnction.Open()              '/selecionando tabela produto o valor cod_produto
        Dim mycommand As New OleDbCommand("SELECT * FROM ESTOQUE WHERE Cod_Produto like @Cod_Produto", myconnction)
        mycommand.Parameters.AddWithValue("@Cod_Produto", Cod_EstoqueTextBox.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader
        While myreader.Read
            Dim newlistViewItem As New ListViewItem
            Cod_Atualizar_Estoque = myreader("Cod_Estoque")
            Data_EntradaTextBox.Text = myreader("Data_Entrada")
            Data_SaidaTextBox.Text = myreader("Data_Saida")
            QuantidadeTextBox.Text = myreader("Quantidade")
            Cod_Incerir_Estoque = Cod_EstoqueTextBox.Text
            'Linpar ListView
            ListView5.Items.Clear()
            newlistViewItem.Text = myreader.GetInt32(0)
            newlistViewItem.SubItems.Add(myreader.GetInt32(1))
            newlistViewItem.SubItems.Add(myreader.GetDateTime(2))
            newlistViewItem.SubItems.Add(myreader.GetDateTime(3))
            newlistViewItem.SubItems.Add(myreader.GetInt32(4))
            ListView5.Items.Add(newlistViewItem)
        End While
        myconnction.Close()
        Carregar_Busca_Cod_Produto_P2()
    End Sub
   
    Sub Carregar_Busca_Cod_Produto_P2()
        Dim myconnction As New OleDbConnection(myConnstring)
        myconnction.Open()              '/selecionando tabela produto o valor cod_produto
        Dim mycommand As New OleDbCommand("SELECT * FROM PRODUTOS WHERE Cod_Produto like @Cod_Produto", myconnction)
        mycommand.Parameters.AddWithValue("@Cod_Produto", Cod_EstoqueTextBox.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader
        While myreader.Read '|||carregando dados nos textbox
            NomeTextBox.Text = myreader("Nome")
            DescriçãoTextBox.Text = myreader("Descrição")
            Preço_VendaTextBox.Text = myreader("Preço_Venda")
        End While
        myconnction.Close()
        If Data_EntradaTextBox.Text = "" And Data_SaidaTextBox.Text = "" And QuantidadeTextBox.Text = "" Then Button1.Enabled = True
    End Sub
    '||FIM DA BUSCA PELO CODIGO PRODUTO
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Text = "Buscar Por" & " Codigo Estoque"
            Cod_EstoqueLabel.Text = "Codigo Produto:"
            Cod_EstoqueTextBox.Clear()
            Cod_EstoqueTextBox.Focus()
        Else
            CheckBox1.Text = "Buscar Por" & " Codigo Produto"
            Cod_EstoqueLabel.Text = "Codigo Estoque:"
            Cod_EstoqueTextBox.Clear()
            Cod_EstoqueTextBox.Focus()
        End If
    End Sub
    '||INCERIR ITEM NO ESTOQUE
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If QuantidadeTextBox.Text <> "" Then
            Dim myconnction As New OleDbConnection(myConnstring)
            myconnction.Open()
            Dim mycommand As New OleDbCommand("INSERT INTO ESTOQUE (Cod_Produto, Data_Entrada, Data_Saida, Quantidade) values (@Cod_Produto, @Data_Entrada, @Data_Saida, @Quantidade )", myconnction)
            mycommand.Parameters.AddWithValue("@Cod_Produto", Cod_EstoqueTextBox.Text)
            mycommand.Parameters.AddWithValue("@Data_Entrada", Date.Today)
            mycommand.Parameters.AddWithValue("@Data_Saida", Date.Today)
            mycommand.Parameters.AddWithValue("@Quantidade", QuantidadeTextBox.Text)
            mycommand.ExecuteNonQuery()
            myconnction.Close()
            ListView5.Items.Clear()
            Cod_EstoqueTextBox.Clear()
            Carregar_Tabela_ListView()
            Button1.Enabled = False
        Else
            MessageBox.Show("favor digite quantidade")
        End If
    End Sub

    Private Sub Data_EntradaTextBox_TextChanged(sender As Object, e As EventArgs) Handles Data_EntradaTextBox.TextChanged
        If QuantidadeTextBox.Text = "" Then Data_SaidaTextBox.ReadOnly = False
    End Sub
    Sub Atualizar_Editar_intem()
        If CheckBox1.Checked = False Then
            Dim myConnction As New OleDbConnection(myConnstring)
            myConnction.Open()
            Dim myCommand As New OleDbCommand("UPDATE ESTOQUE SET Cod_Produto = @Cod_Produto, Data_Entrada =  @Data_Entrada, Data_Saida = @Data_Saida, Quantidade = @Quantidade WHERE Cod_Estoque = @Cod_Estoque", myConnction)
            myCommand.Parameters.AddWithValue("@Cod_Produto", Cod_Incerir_Estoque)
            myCommand.Parameters.AddWithValue("@Data_Entrada", Data_EntradaTextBox.Text)
            myCommand.Parameters.AddWithValue("@Data_Saida", Data_SaidaTextBox.Text)
            myCommand.Parameters.AddWithValue("@Quantidade", QuantidadeTextBox.Text)
            myCommand.Parameters.AddWithValue("Cod_Estoque", Integer.Parse(Cod_EstoqueTextBox.Text))
            myCommand.ExecuteNonQuery()
            myConnction.Close()
            MessageBox.Show("Intem Atualizado Com Sucesso")
            Cod_EstoqueTextBox.Clear()
        Else
            Dim myConnction As New OleDbConnection(myConnstring)
            myConnction.Open()
            Dim myCommand As New OleDbCommand("UPDATE ESTOQUE SET Cod_Produto = @Cod_Produto, Data_Entrada =  @Data_Entrada, Data_Saida = @Data_Saida, Quantidade = @Quantidade WHERE Cod_Estoque = @Cod_Estoque", myConnction)
            myCommand.Parameters.AddWithValue("@Cod_Produto", Cod_Incerir_Estoque)
            myCommand.Parameters.AddWithValue("@Data_Entrada", Data_EntradaTextBox.Text)
            myCommand.Parameters.AddWithValue("@Data_Saida", Data_SaidaTextBox.Text)
            myCommand.Parameters.AddWithValue("@Quantidade", QuantidadeTextBox.Text)
            myCommand.Parameters.AddWithValue("Cod_Estoque", Integer.Parse(Cod_Atualizar_Estoque))
            myCommand.ExecuteNonQuery()
            myConnction.Close()
            MessageBox.Show("Intem Atualizado Com Sucesso")
            Cod_EstoqueTextBox.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Cod_EstoqueTextBox.Text <> "" Then Atualizar_Editar_intem() Else Cod_EstoqueTextBox.Focus()
    End Sub
End Class