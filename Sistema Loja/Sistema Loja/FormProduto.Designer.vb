<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProduto
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Cod_FornecedorLabel1 As System.Windows.Forms.Label
        Dim NomeLabel1 As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim Cod_ProdutoLabel1 As System.Windows.Forms.Label
        Dim Preço_VendaLabel As System.Windows.Forms.Label
        Dim DescriçãoLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim Cod_FornecedorLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.ButtonSair = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cod_FornecedorTextBox1 = New System.Windows.Forms.TextBox()
        Me.NomeTextBox1 = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TelefoneTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Cod_ProdutoTextBox = New System.Windows.Forms.TextBox()
        Me.Preço_VendaTextBox = New System.Windows.Forms.TextBox()
        Me.DescriçãoTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_FornecedorTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Cod_FornecedorLabel1 = New System.Windows.Forms.Label()
        NomeLabel1 = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        Cod_ProdutoLabel1 = New System.Windows.Forms.Label()
        Preço_VendaLabel = New System.Windows.Forms.Label()
        DescriçãoLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        Cod_FornecedorLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cod_FornecedorLabel1
        '
        Cod_FornecedorLabel1.AutoSize = True
        Cod_FornecedorLabel1.Enabled = False
        Cod_FornecedorLabel1.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_FornecedorLabel1.Location = New System.Drawing.Point(21, 20)
        Cod_FornecedorLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cod_FornecedorLabel1.Name = "Cod_FornecedorLabel1"
        Cod_FornecedorLabel1.Size = New System.Drawing.Size(202, 16)
        Cod_FornecedorLabel1.TabIndex = 0
        Cod_FornecedorLabel1.Text = "Cod Fornecedor:"
        '
        'NomeLabel1
        '
        NomeLabel1.AutoSize = True
        NomeLabel1.Enabled = False
        NomeLabel1.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel1.Location = New System.Drawing.Point(21, 52)
        NomeLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NomeLabel1.Name = "NomeLabel1"
        NomeLabel1.Size = New System.Drawing.Size(73, 16)
        NomeLabel1.TabIndex = 2
        NomeLabel1.Text = "Nome:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Enabled = False
        EmailLabel.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(21, 84)
        EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(78, 16)
        EmailLabel.TabIndex = 4
        EmailLabel.Text = "Email:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Enabled = False
        TelefoneLabel.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefoneLabel.Location = New System.Drawing.Point(21, 116)
        TelefoneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(121, 16)
        TelefoneLabel.TabIndex = 6
        TelefoneLabel.Text = "Telefone:"
        '
        'Cod_ProdutoLabel1
        '
        Cod_ProdutoLabel1.AutoSize = True
        Cod_ProdutoLabel1.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_ProdutoLabel1.Location = New System.Drawing.Point(16, 59)
        Cod_ProdutoLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cod_ProdutoLabel1.Name = "Cod_ProdutoLabel1"
        Cod_ProdutoLabel1.Size = New System.Drawing.Size(161, 16)
        Cod_ProdutoLabel1.TabIndex = 19
        Cod_ProdutoLabel1.Text = "Cod Produto:"
        '
        'Preço_VendaLabel
        '
        Preço_VendaLabel.AutoSize = True
        Preço_VendaLabel.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Preço_VendaLabel.Location = New System.Drawing.Point(29, 121)
        Preço_VendaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Preço_VendaLabel.Name = "Preço_VendaLabel"
        Preço_VendaLabel.Size = New System.Drawing.Size(157, 16)
        Preço_VendaLabel.TabIndex = 8
        Preço_VendaLabel.Text = "Preço Venda:"
        '
        'DescriçãoLabel
        '
        DescriçãoLabel.AutoSize = True
        DescriçãoLabel.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriçãoLabel.Location = New System.Drawing.Point(29, 89)
        DescriçãoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DescriçãoLabel.Name = "DescriçãoLabel"
        DescriçãoLabel.Size = New System.Drawing.Size(130, 16)
        DescriçãoLabel.TabIndex = 6
        DescriçãoLabel.Text = "Descrição:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(29, 57)
        NomeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(73, 16)
        NomeLabel.TabIndex = 4
        NomeLabel.Text = "Nome:"
        '
        'Cod_FornecedorLabel
        '
        Cod_FornecedorLabel.AutoSize = True
        Cod_FornecedorLabel.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_FornecedorLabel.Location = New System.Drawing.Point(29, 25)
        Cod_FornecedorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cod_FornecedorLabel.Name = "Cod_FornecedorLabel"
        Cod_FornecedorLabel.Size = New System.Drawing.Size(202, 16)
        Cod_FornecedorLabel.TabIndex = 2
        Cod_FornecedorLabel.Text = "Cod Fornecedor:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Engravers MT", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(363, 7)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(300, 43)
        Label1.TabIndex = 10
        Label1.Text = "produtos"
        '
        'ButtonSair
        '
        Me.ButtonSair.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSair.Location = New System.Drawing.Point(999, 242)
        Me.ButtonSair.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonSair.Name = "ButtonSair"
        Me.ButtonSair.Size = New System.Drawing.Size(100, 28)
        Me.ButtonSair.TabIndex = 13
        Me.ButtonSair.Text = "Sair"
        Me.ButtonSair.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Cod_FornecedorLabel1)
        Me.GroupBox1.Controls.Add(Me.Cod_FornecedorTextBox1)
        Me.GroupBox1.Controls.Add(NomeLabel1)
        Me.GroupBox1.Controls.Add(Me.NomeTextBox1)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(TelefoneLabel)
        Me.GroupBox1.Controls.Add(Me.TelefoneTextBox)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(648, 59)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(452, 180)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Fornecedor"
        '
        'Cod_FornecedorTextBox1
        '
        Me.Cod_FornecedorTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Cod_FornecedorTextBox1.Enabled = False
        Me.Cod_FornecedorTextBox1.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod_FornecedorTextBox1.Location = New System.Drawing.Point(244, 16)
        Me.Cod_FornecedorTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cod_FornecedorTextBox1.Name = "Cod_FornecedorTextBox1"
        Me.Cod_FornecedorTextBox1.ReadOnly = True
        Me.Cod_FornecedorTextBox1.Size = New System.Drawing.Size(185, 24)
        Me.Cod_FornecedorTextBox1.TabIndex = 1
        '
        'NomeTextBox1
        '
        Me.NomeTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.NomeTextBox1.Enabled = False
        Me.NomeTextBox1.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox1.Location = New System.Drawing.Point(111, 48)
        Me.NomeTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NomeTextBox1.Name = "NomeTextBox1"
        Me.NomeTextBox1.ReadOnly = True
        Me.NomeTextBox1.Size = New System.Drawing.Size(319, 24)
        Me.NomeTextBox1.TabIndex = 3
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.EmailTextBox.Enabled = False
        Me.EmailTextBox.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(111, 85)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.ReadOnly = True
        Me.EmailTextBox.Size = New System.Drawing.Size(319, 24)
        Me.EmailTextBox.TabIndex = 5
        '
        'TelefoneTextBox
        '
        Me.TelefoneTextBox.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TelefoneTextBox.Enabled = False
        Me.TelefoneTextBox.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefoneTextBox.Location = New System.Drawing.Point(156, 117)
        Me.TelefoneTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TelefoneTextBox.Name = "TelefoneTextBox"
        Me.TelefoneTextBox.ReadOnly = True
        Me.TelefoneTextBox.Size = New System.Drawing.Size(273, 24)
        Me.TelefoneTextBox.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(20, 242)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(213, 28)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "&Novo / Produto"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(241, 242)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(252, 28)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "&Atualizar / editar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(501, 242)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 28)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "&Excluir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Cod_ProdutoTextBox
        '
        Me.Cod_ProdutoTextBox.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod_ProdutoTextBox.Location = New System.Drawing.Point(192, 59)
        Me.Cod_ProdutoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cod_ProdutoTextBox.Name = "Cod_ProdutoTextBox"
        Me.Cod_ProdutoTextBox.Size = New System.Drawing.Size(224, 24)
        Me.Cod_ProdutoTextBox.TabIndex = 1
        '
        'Preço_VendaTextBox
        '
        Me.Preço_VendaTextBox.Location = New System.Drawing.Point(204, 117)
        Me.Preço_VendaTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Preço_VendaTextBox.Name = "Preço_VendaTextBox"
        Me.Preço_VendaTextBox.Size = New System.Drawing.Size(391, 24)
        Me.Preço_VendaTextBox.TabIndex = 9
        '
        'DescriçãoTextBox
        '
        Me.DescriçãoTextBox.Location = New System.Drawing.Point(184, 85)
        Me.DescriçãoTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DescriçãoTextBox.Name = "DescriçãoTextBox"
        Me.DescriçãoTextBox.Size = New System.Drawing.Size(391, 24)
        Me.DescriçãoTextBox.TabIndex = 7
        '
        'NomeTextBox
        '
        Me.NomeTextBox.Location = New System.Drawing.Point(113, 53)
        Me.NomeTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(481, 24)
        Me.NomeTextBox.TabIndex = 5
        '
        'Cod_FornecedorTextBox
        '
        Me.Cod_FornecedorTextBox.Location = New System.Drawing.Point(253, 21)
        Me.Cod_FornecedorTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cod_FornecedorTextBox.Name = "Cod_FornecedorTextBox"
        Me.Cod_FornecedorTextBox.Size = New System.Drawing.Size(324, 24)
        Me.Cod_FornecedorTextBox.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Cod_FornecedorLabel)
        Me.GroupBox2.Controls.Add(Me.Cod_FornecedorTextBox)
        Me.GroupBox2.Controls.Add(NomeLabel)
        Me.GroupBox2.Controls.Add(Me.NomeTextBox)
        Me.GroupBox2.Controls.Add(DescriçãoLabel)
        Me.GroupBox2.Controls.Add(Me.DescriçãoTextBox)
        Me.GroupBox2.Controls.Add(Preço_VendaLabel)
        Me.GroupBox2.Controls.Add(Me.Preço_VendaTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 91)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(624, 148)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Produto"
        '
        'ListView2
        '
        Me.ListView2.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.ListView2.AllowColumnReorder = True
        Me.ListView2.AllowDrop = True
        Me.ListView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView2.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.HideSelection = False
        Me.ListView2.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.ListView2.Location = New System.Drawing.Point(21, 276)
        Me.ListView2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListView2.Size = New System.Drawing.Size(1079, 364)
        Me.ListView2.TabIndex = 93
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.UseWaitCursor = True
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "CD_Produto"
        Me.ColumnHeader6.Width = 147
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "CD_Fornecedor"
        Me.ColumnHeader7.Width = 171
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Nome"
        Me.ColumnHeader8.Width = 191
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Descrição"
        Me.ColumnHeader9.Width = 171
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Preço_Venda"
        Me.ColumnHeader10.Width = 66
        '
        'FormProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1127, 676)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Cod_ProdutoLabel1)
        Me.Controls.Add(Me.Cod_ProdutoTextBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonSair)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormProduto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonSair As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cod_FornecedorTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Cod_ProdutoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Preço_VendaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriçãoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cod_FornecedorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Protected Friend WithEvents ListView2 As System.Windows.Forms.ListView
End Class
