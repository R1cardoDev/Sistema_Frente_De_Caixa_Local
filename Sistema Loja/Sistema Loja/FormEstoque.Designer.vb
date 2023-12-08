<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstoque
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
        Dim QuantidadeLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim DescriçãoLabel As System.Windows.Forms.Label
        Dim Preço_VendaLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Data_EntradaLabel As System.Windows.Forms.Label
        Dim Data_SaidaLabel As System.Windows.Forms.Label
        Me.Cod_EstoqueLabel = New System.Windows.Forms.Label()
        Me.Cod_EstoqueTextBox = New System.Windows.Forms.TextBox()
        Me.QuantidadeTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonSair = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListView5 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.DescriçãoTextBox = New System.Windows.Forms.TextBox()
        Me.Preço_VendaTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Data_SaidaTextBox = New System.Windows.Forms.TextBox()
        Me.Data_EntradaTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        QuantidadeLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        DescriçãoLabel = New System.Windows.Forms.Label()
        Preço_VendaLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Data_EntradaLabel = New System.Windows.Forms.Label()
        Data_SaidaLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'QuantidadeLabel
        '
        QuantidadeLabel.AutoSize = True
        QuantidadeLabel.Location = New System.Drawing.Point(17, 94)
        QuantidadeLabel.Name = "QuantidadeLabel"
        QuantidadeLabel.Size = New System.Drawing.Size(138, 15)
        QuantidadeLabel.TabIndex = 9
        QuantidadeLabel.Text = "Quantidade:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(7, 26)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(67, 15)
        NomeLabel.TabIndex = 4
        NomeLabel.Text = "Nome:"
        '
        'DescriçãoLabel
        '
        DescriçãoLabel.AutoSize = True
        DescriçãoLabel.Location = New System.Drawing.Point(7, 63)
        DescriçãoLabel.Name = "DescriçãoLabel"
        DescriçãoLabel.Size = New System.Drawing.Size(121, 15)
        DescriçãoLabel.TabIndex = 6
        DescriçãoLabel.Text = "Descrição:"
        '
        'Preço_VendaLabel
        '
        Preço_VendaLabel.AutoSize = True
        Preço_VendaLabel.Location = New System.Drawing.Point(7, 109)
        Preço_VendaLabel.Name = "Preço_VendaLabel"
        Preço_VendaLabel.Size = New System.Drawing.Size(145, 15)
        Preço_VendaLabel.TabIndex = 8
        Preço_VendaLabel.Text = "Preço Venda:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Engravers MT", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.White
        Label1.Location = New System.Drawing.Point(131, 16)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(203, 34)
        Label1.TabIndex = 11
        Label1.Text = "ESTOQUE"
        '
        'Data_EntradaLabel
        '
        Data_EntradaLabel.AutoSize = True
        Data_EntradaLabel.Location = New System.Drawing.Point(17, 21)
        Data_EntradaLabel.Name = "Data_EntradaLabel"
        Data_EntradaLabel.Size = New System.Drawing.Size(158, 15)
        Data_EntradaLabel.TabIndex = 10
        Data_EntradaLabel.Text = "Data Entrada:"
        '
        'Data_SaidaLabel
        '
        Data_SaidaLabel.AutoSize = True
        Data_SaidaLabel.Location = New System.Drawing.Point(17, 57)
        Data_SaidaLabel.Name = "Data_SaidaLabel"
        Data_SaidaLabel.Size = New System.Drawing.Size(125, 15)
        Data_SaidaLabel.TabIndex = 11
        Data_SaidaLabel.Text = "Data Saida:"
        '
        'Cod_EstoqueLabel
        '
        Me.Cod_EstoqueLabel.AutoSize = True
        Me.Cod_EstoqueLabel.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod_EstoqueLabel.Location = New System.Drawing.Point(12, 63)
        Me.Cod_EstoqueLabel.Name = "Cod_EstoqueLabel"
        Me.Cod_EstoqueLabel.Size = New System.Drawing.Size(179, 15)
        Me.Cod_EstoqueLabel.TabIndex = 1
        Me.Cod_EstoqueLabel.Text = "Codigo Estoque:"
        '
        'Cod_EstoqueTextBox
        '
        Me.Cod_EstoqueTextBox.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod_EstoqueTextBox.Location = New System.Drawing.Point(197, 59)
        Me.Cod_EstoqueTextBox.Name = "Cod_EstoqueTextBox"
        Me.Cod_EstoqueTextBox.Size = New System.Drawing.Size(220, 23)
        Me.Cod_EstoqueTextBox.TabIndex = 1
        '
        'QuantidadeTextBox
        '
        Me.QuantidadeTextBox.Location = New System.Drawing.Point(161, 94)
        Me.QuantidadeTextBox.Name = "QuantidadeTextBox"
        Me.QuantidadeTextBox.Size = New System.Drawing.Size(182, 23)
        Me.QuantidadeTextBox.TabIndex = 10
        '
        'ButtonSair
        '
        Me.ButtonSair.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSair.Location = New System.Drawing.Point(371, 459)
        Me.ButtonSair.Name = "ButtonSair"
        Me.ButtonSair.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSair.TabIndex = 14
        Me.ButtonSair.Text = "&Sair"
        Me.ButtonSair.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 397)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(434, 23)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "&Inserir Intem No Estoque"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListView5
        '
        Me.ListView5.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView5.Location = New System.Drawing.Point(452, 16)
        Me.ListView5.Name = "ListView5"
        Me.ListView5.Size = New System.Drawing.Size(535, 466)
        Me.ListView5.TabIndex = 88
        Me.ListView5.UseCompatibleStateImageBehavior = False
        Me.ListView5.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "COD_ESTOQUE"
        Me.ColumnHeader1.Width = 113
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "COD_PRODUTO"
        Me.ColumnHeader2.Width = 103
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "DATA_ENTRADA"
        Me.ColumnHeader3.Width = 118
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DATA_SAIDA"
        Me.ColumnHeader4.Width = 91
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "QUANTIDADE"
        Me.ColumnHeader5.Width = 105
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NomeTextBox)
        Me.GroupBox1.Controls.Add(NomeLabel)
        Me.GroupBox1.Controls.Add(DescriçãoLabel)
        Me.GroupBox1.Controls.Add(Me.DescriçãoTextBox)
        Me.GroupBox1.Controls.Add(Preço_VendaLabel)
        Me.GroupBox1.Controls.Add(Me.Preço_VendaTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 243)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 139)
        Me.GroupBox1.TabIndex = 89
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRODUTO"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.BackColor = System.Drawing.Color.White
        Me.NomeTextBox.Location = New System.Drawing.Point(71, 26)
        Me.NomeTextBox.Multiline = True
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.ReadOnly = True
        Me.NomeTextBox.Size = New System.Drawing.Size(357, 23)
        Me.NomeTextBox.TabIndex = 10
        '
        'DescriçãoTextBox
        '
        Me.DescriçãoTextBox.BackColor = System.Drawing.Color.White
        Me.DescriçãoTextBox.Location = New System.Drawing.Point(127, 63)
        Me.DescriçãoTextBox.Multiline = True
        Me.DescriçãoTextBox.Name = "DescriçãoTextBox"
        Me.DescriçãoTextBox.ReadOnly = True
        Me.DescriçãoTextBox.Size = New System.Drawing.Size(301, 40)
        Me.DescriçãoTextBox.TabIndex = 7
        '
        'Preço_VendaTextBox
        '
        Me.Preço_VendaTextBox.Location = New System.Drawing.Point(153, 110)
        Me.Preço_VendaTextBox.Name = "Preço_VendaTextBox"
        Me.Preço_VendaTextBox.Size = New System.Drawing.Size(165, 23)
        Me.Preço_VendaTextBox.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Data_SaidaLabel)
        Me.GroupBox2.Controls.Add(Me.Data_SaidaTextBox)
        Me.GroupBox2.Controls.Add(Data_EntradaLabel)
        Me.GroupBox2.Controls.Add(Me.Data_EntradaTextBox)
        Me.GroupBox2.Controls.Add(Me.QuantidadeTextBox)
        Me.GroupBox2.Controls.Add(QuantidadeLabel)
        Me.GroupBox2.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 114)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(434, 126)
        Me.GroupBox2.TabIndex = 90
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ESTOQUE"
        '
        'Data_SaidaTextBox
        '
        Me.Data_SaidaTextBox.BackColor = System.Drawing.Color.White
        Me.Data_SaidaTextBox.Location = New System.Drawing.Point(148, 57)
        Me.Data_SaidaTextBox.Name = "Data_SaidaTextBox"
        Me.Data_SaidaTextBox.ReadOnly = True
        Me.Data_SaidaTextBox.Size = New System.Drawing.Size(195, 23)
        Me.Data_SaidaTextBox.TabIndex = 12
        '
        'Data_EntradaTextBox
        '
        Me.Data_EntradaTextBox.Location = New System.Drawing.Point(181, 21)
        Me.Data_EntradaTextBox.Name = "Data_EntradaTextBox"
        Me.Data_EntradaTextBox.Size = New System.Drawing.Size(162, 23)
        Me.Data_EntradaTextBox.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(12, 430)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(434, 23)
        Me.Button2.TabIndex = 91
        Me.Button2.Text = "&Atualizar Intem"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(15, 86)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(285, 16)
        Me.CheckBox1.TabIndex = 92
        Me.CheckBox1.Text = "Buscar Por Codigo Produto"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FormEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(991, 490)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cod_EstoqueLabel)
        Me.Controls.Add(Me.ButtonSair)
        Me.Controls.Add(Me.Cod_EstoqueTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormEstoque"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cod_EstoqueTextBox As System.Windows.Forms.TextBox
    Friend WithEvents QuantidadeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSair As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ListView5 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DescriçãoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Preço_VendaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Data_SaidaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Data_EntradaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Cod_EstoqueLabel As System.Windows.Forms.Label
End Class
