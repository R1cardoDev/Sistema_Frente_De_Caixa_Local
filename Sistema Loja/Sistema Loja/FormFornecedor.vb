Imports System
Imports System.Data.OleDb
Public Class FormFornecedor
    Private Sub ButtonSair_Click(sender As Object, e As EventArgs) Handles ButtonSair.Click
        Me.ResetText()
        Button1.Text = "Inserir / Novo"
        Button2.Text = "Editar"
        Button2.Enabled = True
        Button3.Enabled = True
        Cod_FornecedorTextBox.Enabled = True
        Cod_FornecedorTextBox.Focus()
        Me.Hide()
    End Sub
    Sub Carregar_Tabela_Fornecedor_Listview()
        Dim myConnction As New OleDbConnection(myConnstring)
        myConnction.Open()
        Dim myCommand As New OleDbCommand("SELECT * FROM FORNECEDORES ", myConnction)
        Dim myReader As OleDbDataReader = myCommand.ExecuteReader
        'limpar intem Listvwiew
        ListView3.Items.Clear()
        While myReader.Read
            Dim newlistViewItem As New ListViewItem
            newlistViewItem.Text = myReader.GetInt32(0)
            newlistViewItem.SubItems.Add(myReader.GetString(1))
            newlistViewItem.SubItems.Add(myReader.GetString(2))
            newlistViewItem.SubItems.Add(myReader.GetString(3))
            ListView3.Items.Add(newlistViewItem)
            NomeTextBox.Clear()
            EmailTextBox.Clear()
            TelefoneTextBox.Clear()
            Cod_FornecedorTextBox.Clear()
        End While
        myConnction.Close()
    End Sub
    Sub Carregar_Busca_Tabela_Fornecedor()
        'linpar listView
        ListView3.Items.Clear()
        Dim myConnction As New OleDbConnection(myConnstring)
        myConnction.Open()
        Dim myCommand As New OleDbCommand("SELECT * FROM FORNECEDORES WHERE Cod_Fornecedor LIKE @Cod_Fornecedor", myConnction)
        myCommand.Parameters.AddWithValue("@Cod_Fornecedor", Cod_FornecedorTextBox.Text) 'Para Buscar Pela Primeira Letra Adicionar no fim &%
        Dim myReader As OleDbDataReader = myCommand.ExecuteReader
        While myReader.Read
            Dim newlistViewItem As New ListViewItem
            newlistViewItem.Text = myReader.GetInt32(0)
            newlistViewItem.SubItems.Add(myReader.GetString(1))
            newlistViewItem.SubItems.Add(myReader.GetString(2))
            newlistViewItem.SubItems.Add(myReader.GetString(3))
            ListView3.Items.Add(newlistViewItem)
            Cod_FornecedorTextBox.Text = myReader("Cod_Fornecedor")
            NomeTextBox.Text = myReader("Nome")
            EmailTextBox.Text = myReader("Email")
            TelefoneTextBox.Text = myReader("Telefone")
        End While
        myConnction.Close()
    End Sub
    Private Sub Cod_FornecedorTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles Cod_FornecedorTextBox.TextChanged
        Carregar_Busca_Tabela_Fornecedor()
        If Cod_FornecedorTextBox.Text = "" Then Carregar_Tabela_Fornecedor_Listview()
    End Sub
    Sub Incerir_Registro_Tabela_Fornecedor()
        If NomeTextBox.Text <> "" And EmailTextBox.Text <> "" And TelefoneTextBox.Text <> "" Then
            Dim myConnction As New OleDbConnection(myConnstring)
            myConnction.Open()
            Dim myCommand As New OleDbCommand("INSERT INTO FORNECEDORES (Nome, Email, Telefone) VALUES (@Nome, @Email, @Telefone )", myConnction)
            myCommand.Parameters.AddWithValue("@Nome", NomeTextBox.Text)
            myCommand.Parameters.AddWithValue("@Email", EmailTextBox.Text)
            myCommand.Parameters.AddWithValue("@Telefone", TelefoneTextBox.Text)
            myCommand.ExecuteNonQuery()
            myConnction.Close()
            Carregar_Tabela_Fornecedor_Listview()
            Cod_FornecedorTextBox.Focus()
        Else
            MessageBox.Show("FALTA DADOS A SER CADASTRADO")
            Cod_FornecedorTextBox.Focus() '
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Cod_FornecedorTextBox.Enabled = True Then
            Cod_FornecedorTextBox.Enabled = False
            NomeTextBox.Focus()
            Button1.Text = "Salvar"
            Button2.Enabled = False
            Button3.Enabled = False
            Carregar_Tabela_Fornecedor_Listview()
        Else
            Incerir_Registro_Tabela_Fornecedor()
            Button1.Text = "Inserir / Novo"
            Button2.Enabled = True
            Button3.Enabled = True
            Cod_FornecedorTextBox.Enabled = True
        End If
    End Sub
    Public Sub FormFornecedor_Load()
        Carregar_Tabela_Fornecedor_Listview()
    End Sub
    Sub Editar_Dados_Tabela_Fornecedor()
        If NomeTextBox.Text <> "" And EmailTextBox.Text <> "" And TelefoneTextBox.Text <> "" Then
            Dim myConnction As New OleDbConnection(myConnstring)
            myConnction.Open()
            Dim myCommand As New OleDbCommand("UPDATE FORNECEDORES SET Nome =  @Nome, Email = @Email, Telefone = @Telefone WHERE Cod_Fornecedor = @Cod_Fornedor", myConnction)
            myCommand.Parameters.AddWithValue("@Nome", NomeTextBox.Text)
            myCommand.Parameters.AddWithValue("@Email", EmailTextBox.Text)
            myCommand.Parameters.AddWithValue("@Telefone", TelefoneTextBox.Text)
            myCommand.Parameters.AddWithValue("@Cod_Produto", Integer.Parse(Cod_FornecedorTextBox.Text))
            myCommand.ExecuteNonQuery()
            myConnction.Close()
            Carregar_Tabela_Fornecedor_Listview()
            Cod_FornecedorTextBox.Focus()
        Else
            MessageBox.Show("FALTA DADOS A SER EDITADO")
            Cod_FornecedorTextBox.Focus() '
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text <> "Editar e Salvar" Then
            Button2.Text = "Editar e Salvar"
            Button1.Enabled = False
            Button3.Enabled = False
            Cod_FornecedorTextBox.Focus()
        Else
            Editar_Dados_Tabela_Fornecedor()
            Button2.Text = "Editar"
            Button1.Enabled = True
            Button3.Enabled = True
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Cod_FornecedorTextBox.Text <> "" Then
            Dim myConnction As New OleDbConnection(myConnstring)
            myConnction.Open()
            Dim myCommand As New OleDbCommand("DELETE FROM PRODUTOS WHERE Cod_Produto = @Cod_Produto", myConnction)
            myCommand.Parameters.AddWithValue("@Cod_Produto", Cod_FornecedorTextBox.Text)
            myCommand.ExecuteNonQuery()
            myConnction.Close()
            MessageBox.Show("Intem Excluido Com Sucesso")
            Carregar_Tabela_Fornecedor_Listview()
        Else
            MessageBox.Show("Selecione Um Codigo A ser Deletado")
            Cod_FornecedorTextBox.Focus()
        End If
    End Sub

End Class