Public Class fminiciar
    Private Sub calculadoratoolstripmenuitem_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        'abri a calculadora
        Shell("calc")
    End Sub
    Private Sub notepadtoolstripmenuitem_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        'abri notepad
        Shell("notepad", AppWinStyle.NormalFocus)
    End Sub
    Private Sub sairtoolstripmenuitem_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        If MsgBox("VOCÊ DESEJA REALMENTE SAIR", vbYesNo, "") = MsgBoxResult.Yes Then Application.Exit() Else Me.ResetText() 'sair do sistemaS
    End Sub
    Private Sub timerhora_tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timerhora.Tick
        'função hora e data na barra superior
        Toohora.Text = TimeOfDay
        Toodata.Text = DateString
        statussystema.Text = My.Computer.Name
    End Sub
    Private Sub timercontrol_tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timercontrol.Tick
        'retorna os comentarios da barra interior
        If Toologado.Text <> "" Then
            Toologado.Text = ""
            ToolStripProgressBar1.Value = (0)
        End If
    End Sub
    Private Sub vendatoolstripmenuitem_click(sender As Object, e As EventArgs) Handles VendaToolStripMenuItem.Click
        '||Abrir Form Estoque
        FormEstoque.MdiParent = Me
        FormEstoque.Show()
        FormEstoque.loadform()

        ' FormEstoque.Carregar_Tabela_ListView()
        '//////////////////////////////
        ''form item vendidos
        'Fmestoque.MdiParent = Me
        'Fmestoque.Show()
        'Fmestoque.tabelavenda()
    End Sub
    Private Sub ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        '||Abril Form Fornecedor
        FormFornecedor.MdiParent = Me
        FormFornecedor.Show()
        FormFornecedor.FormFornecedor_Load()
        '/////////////////////////////
        'form comsulta estoque
        'fmestoque.mdiparent = Me
        'fmestoque.show()
        'fmestoque.tabelaconsulta()
    End Sub
    Private Sub CadastroToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CadastroToolStripMenuItem.Click
        '|Abrir Form Produto
        FormProduto.MdiParent = Me
        FormProduto.Show()
        FormProduto.FormProduto_Load()
        '//////////////////
        ''form cadastro estoque
        'fmestoque.mdiparent = Me
        'fmestoque.show()
        'fmestoque.tabelanovoestoque()
    End Sub
    Private Sub CaixaToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CaixaToolStripMenuItem.Click
        'formcaixa
        'menustripiniciar.visible = false
        FormCaixa.MdiParent = Me
        FormCaixa.Show()
        FormCaixa.FormCaixa_Load()
        If MenuStripiniciar.Visible = True Then MenuStripiniciar.Visible = False '/Sumindo Com Menu De Navegação
    End Sub
End Class
