Imports System
Imports System.Data.OleDb
Public Class FormProduto
    Private Sub ButtonSair_Click(sender As Object, e As EventArgs) Handles ButtonSair.Click
        Me.ResetText()
        Cod_ProdutoTextBox.Enabled = True
        Me.Hide() 'finalizado formulario
    End Sub
    Sub Carregar_tabela_produto_textbox()
        Dim myconnction As New OleDbConnection(myConnstring)
        myconnction.Open()              'selecionando tabela produto o valor cod_produto
        Dim mycommand As New OleDbCommand("SELECT * FROM Produtos WHERE Cod_Produto like @Cod_Produto", myconnction)
        mycommand.Parameters.AddWithValue("@Cod_Produto", Cod_ProdutoTextBox.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader
        'carregando dados nos textbox
        While myreader.Read
            Cod_FornecedorTextBox.Text = myreader("Cod_Fornecedor")
            NomeTextBox.Text = myreader("Nome")
            DescriçãoTextBox.Text = myreader("Descrição")
            Preço_VendaTextBox.Text = myreader("Preço_Venda")
        End While
        myconnction.Close()
        Carregar_Tabela_Produto_TextBox_Fornecedor()
    End Sub
    Sub Carregar_Tabela_Produto_ListView()
        ListView2.Items.Clear()
        Dim myConnction As New OleDbConnection(myConnstring)
        myConnction.Open()
        Dim myCommand As New OleDbCommand("SELECT * FROM PRODUTOS WHERE Cod_Produto LIKE @Cod_Produto", myConnction)
        myCommand.Parameters.AddWithValue("@Cod_Produto", Cod_ProdutoTextBox.Text)
        Dim myReader As OleDbDataReader = myCommand.ExecuteReader
        While myReader.Read
            Dim newlistViewItem As New ListViewItem
            newlistViewItem.Text = myReader.GetInt32(0)
            newlistViewItem.SubItems.Add(myReader.GetInt32(1))
            newlistViewItem.SubItems.Add(myReader.GetString(2))
            newlistViewItem.SubItems.Add(myReader.GetString(3))
            newlistViewItem.SubItems.Add(myReader.GetDecimal(4))
            ListView2.Items.Add(newlistViewItem)
        End While
        myConnction.Close()
        carregar_tabela_produto_textbox()
        If Cod_ProdutoTextBox.Text = "" Then ListView2.Items.Clear()
    End Sub
    Sub Carregar_Tabela_Produto_TextBox_Fornecedor()
        Dim myconnction As New OleDbConnection(myConnstring)
        myconnction.Open()              'selecionando tabela produto o valor cod_produto
        Dim mycommand As New OleDbCommand("SELECT * FROM FORNECEDORES WHERE Cod_Fornecedor like @Cod_Fornecedor", myconnction)
        mycommand.Parameters.AddWithValue("@Cod_Fornecedor", Cod_FornecedorTextBox.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader
        'carregando dados nos textbox
        While myreader.Read
            Cod_FornecedorTextBox1.Text = myreader("Cod_Fornecedor")
            NomeTextBox1.Text = myreader("Nome")
            EmailTextBox.Text = myreader("Email")
            TelefoneTextBox.Text = myreader("Telefone")
        End While
        myconnction.Close()
    End Sub
    Private Sub Cod_ProdutoTextBox_TextChanged(sender As Object, e As EventArgs) Handles Cod_ProdutoTextBox.TextChanged
        If Cod_ProdutoTextBox.Text = "" Then Carregar_Dados_no_Inicio() Else Carregar_Tabela_Produto_ListView()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Cod_ProdutoTextBox.Text <> "" Then
            Dim myConnction As New OleDbConnection(myConnstring)
            myConnction.Open()
            Dim myCommand As New OleDbCommand("DELETE FROM PRODUTOS WHERE Cod_Produto = @Cod_Produto", myConnction)
            myCommand.Parameters.AddWithValue("@Cod_Produto", Cod_ProdutoTextBox.Text)
            myCommand.ExecuteNonQuery()
            myConnction.Close()
            MessageBox.Show("Intem Excluido Com Sucesso")
            Carregar_Dados_no_Inicio()
        Else
            MessageBox.Show("Selecione Um Codigo A ser Deletado")
            Cod_ProdutoTextBox.Focus()
        End If
    End Sub
    Sub Incerir_Dados_Na_Tabela_Produto() 'Incerido dados na tabela Produto
        Dim myConnction As New OleDbConnection(myConnstring)
        myConnction.Open()
        Dim myCommand As New OleDbCommand("INSERT INTO PRODUTOS (Cod_Fornecedor, Nome, Descrição, Preço_Venda) VALUES (@Cod_Fornecedor, @Nome, @Descrição, @Preço_Venda )", myConnction)
        myCommand.Parameters.AddWithValue("@Codigo_Fornecedor", Cod_FornecedorTextBox.Text)
        myCommand.Parameters.AddWithValue("@Nome", NomeTextBox.Text)
        myCommand.Parameters.AddWithValue("@Descrição", DescriçãoTextBox.Text)
        myCommand.Parameters.AddWithValue("@Preço_Venda", Preço_VendaTextBox.Text)
        myCommand.ExecuteNonQuery()
        myConnction.Close()
        MessageBox.Show("Salvo Com Sucesso")
        Me.ResetText()
        Cod_ProdutoTextBox.Enabled = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Cod_ProdutoTextBox.Enabled = True Then 'verificando a posibilidade de Inserir dados na tabela
            Cod_ProdutoTextBox.Enabled = False
            ListView2.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Cod_FornecedorTextBox.Focus()
            Carregar_Dados_no_Inicio()
            Button1.Text = "Salvar"
        Else
            If NomeTextBox.Text <> "" And Preço_VendaTextBox.Text <> "" Then
                Incerir_Dados_Na_Tabela_Produto()
                Carregar_Dados_no_Inicio()
            End If
        End If
    End Sub
    Sub Atulizar_Ou_Editar_intems_Na_Tabela_Produtos()
        Dim myConnction As New OleDbConnection(myConnstring)
        myConnction.Open()
        Dim myCommand As New OleDbCommand("UPDATE PRODUTOS SET Cod_Fornecedor = @Cod_Fornecedor, Nome =  @Nome, Descrição = @Descrição, Preço_Venda = @Preço_Venda WHERE Cod_Produto = @Cod_Produto", myConnction)
        myCommand.Parameters.AddWithValue("@Codigo_Fornecedor", Cod_FornecedorTextBox.Text)
        myCommand.Parameters.AddWithValue("@Nome", NomeTextBox.Text)
        myCommand.Parameters.AddWithValue("@Descrição", DescriçãoTextBox.Text)
        myCommand.Parameters.AddWithValue("@Preço_Venda", Preço_VendaTextBox.Text)
        myCommand.Parameters.AddWithValue("@Cod_Produto", Integer.Parse(Cod_ProdutoTextBox.Text))
        myCommand.ExecuteNonQuery()
        myConnction.Close()
        MessageBox.Show("Intem Atualizado Com Sucesso")
        Carregar_Dados_no_Inicio()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Cod_ProdutoTextBox.Text <> "" Then Atulizar_Ou_Editar_intems_Na_Tabela_Produtos()
    End Sub
    Sub Carregar_Dados_no_Inicio()
        Dim myConnction As New OleDbConnection(myConnstring)
        myConnction.Open()
        Dim myCommand As New OleDbCommand("SELECT * FROM PRODUTOS ", myConnction)
        Dim myReader As OleDbDataReader = myCommand.ExecuteReader
        'limpar Item Listvwiew
        ListView2.Items.Clear()
        While myReader.Read
            Dim newlistViewItem As New ListViewItem
            newlistViewItem.Text = myReader.GetInt32(0)
            newlistViewItem.SubItems.Add(myReader.GetInt32(1))
            newlistViewItem.SubItems.Add(myReader.GetString(2))
            newlistViewItem.SubItems.Add(myReader.GetString(3))
            newlistViewItem.SubItems.Add(myReader.GetDecimal(4))
            ListView2.Items.Add(newlistViewItem)
        End While
        'linpando todos os campos do formulario
        myConnction.Close()
        Cod_FornecedorTextBox.Clear()
        NomeTextBox.Clear()
        DescriçãoTextBox.Clear()
        Preço_VendaTextBox.Clear()
        NomeTextBox1.Clear()
        Cod_FornecedorTextBox1.Clear()
        EmailTextBox.Clear()
        TelefoneTextBox.Clear()
        Cod_ProdutoTextBox.Clear()
        Button1.Text = "&Novo / Produto"
        Button2.Text = "&Atualizar / editar"
        Cod_ProdutoTextBox.Focus()
    End Sub
    Public Sub FormProduto_Load()
        Carregar_Dados_no_Inicio() 'carregando dados inicia do formulario
    End Sub
    Private Sub Cod_FornecedorTextBox_TextChanged(sender As Object, e As EventArgs) Handles Cod_FornecedorTextBox.TextChanged
        If Cod_ProdutoTextBox.Enabled = False Then
            Dim myconnction As New OleDbConnection(myConnstring)
            myconnction.Open()              'selecionando tabela produto o valor cod_produto
            Dim mycommand As New OleDbCommand("SELECT * FROM FORNECEDORES WHERE Cod_Fornecedor like @Cod_Fornecedor", myconnction)
            mycommand.Parameters.AddWithValue("@Cod_Fornecedor", Cod_FornecedorTextBox.Text)
            Dim myreader As OleDbDataReader = mycommand.ExecuteReader
            'carregando dados nos textbox
            While myreader.Read
                Cod_FornecedorTextBox1.Text = myreader("Cod_Fornecedor")
                NomeTextBox1.Text = myreader("Nome")
                EmailTextBox.Text = myreader("Email")
                TelefoneTextBox.Text = myreader("Telefone")
            End While
            myconnction.Close()
        End If
    End Sub


End Class