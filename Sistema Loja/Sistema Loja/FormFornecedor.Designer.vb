<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFornecedor
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
        Dim Cod_FornecedorLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim TelefoneLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonSair = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TelefoneTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Cod_FornecedorTextBox = New System.Windows.Forms.TextBox()
        Cod_FornecedorLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        TelefoneLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cod_FornecedorLabel
        '
        Cod_FornecedorLabel.AutoSize = True
        Cod_FornecedorLabel.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cod_FornecedorLabel.Location = New System.Drawing.Point(13, 105)
        Cod_FornecedorLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cod_FornecedorLabel.Name = "Cod_FornecedorLabel"
        Cod_FornecedorLabel.Size = New System.Drawing.Size(278, 24)
        Cod_FornecedorLabel.TabIndex = 1
        Cod_FornecedorLabel.Text = "Cod Fornecedor:"
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(13, 196)
        NomeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(100, 24)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(13, 342)
        EmailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(107, 24)
        EmailLabel.TabIndex = 5
        EmailLabel.Text = "Email:"
        '
        'TelefoneLabel
        '
        TelefoneLabel.AutoSize = True
        TelefoneLabel.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefoneLabel.Location = New System.Drawing.Point(13, 433)
        TelefoneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefoneLabel.Name = "TelefoneLabel"
        TelefoneLabel.Size = New System.Drawing.Size(164, 24)
        TelefoneLabel.TabIndex = 7
        TelefoneLabel.Text = "Telefone:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Engravers MT", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(41, 11)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(464, 47)
        Label1.TabIndex = 95
        Label1.Text = "Fornecedores"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.Location = New System.Drawing.Point(131, 196)
        Me.NomeTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NomeTextBox.Multiline = True
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(500, 79)
        Me.NomeTextBox.TabIndex = 2
        '
        'ButtonSair
        '
        Me.ButtonSair.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSair.Location = New System.Drawing.Point(296, 561)
        Me.ButtonSair.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonSair.Name = "ButtonSair"
        Me.ButtonSair.Size = New System.Drawing.Size(336, 34)
        Me.ButtonSair.TabIndex = 8
        Me.ButtonSair.Text = "Sair"
        Me.ButtonSair.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(7, 519)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(281, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Incerir / Novo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(296, 519)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(336, 34)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Editar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(7, 561)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(281, 34)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Excruir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ListView3
        '
        Me.ListView3.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.ListView3.AllowColumnReorder = True
        Me.ListView3.AllowDrop = True
        Me.ListView3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.ListView3.Font = New System.Drawing.Font("Engravers MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView3.FullRowSelect = True
        Me.ListView3.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView3.HideSelection = False
        Me.ListView3.ImeMode = System.Windows.Forms.ImeMode.AlphaFull
        Me.ListView3.Location = New System.Drawing.Point(640, 4)
        Me.ListView3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListView3.Size = New System.Drawing.Size(689, 602)
        Me.ListView3.TabIndex = 94
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.UseWaitCursor = True
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "CD_Fornecedor"
        Me.ColumnHeader7.Width = 178
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Nome"
        Me.ColumnHeader8.Width = 109
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Email"
        Me.ColumnHeader9.Width = 100
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Telefone"
        Me.ColumnHeader10.Width = 114
        '
        'TelefoneTextBox
        '
        Me.TelefoneTextBox.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefoneTextBox.Location = New System.Drawing.Point(227, 433)
        Me.TelefoneTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TelefoneTextBox.Mask = "(999) 0000-0000 / (999) 00000-0000"
        Me.TelefoneTextBox.Name = "TelefoneTextBox"
        Me.TelefoneTextBox.Size = New System.Drawing.Size(404, 31)
        Me.TelefoneTextBox.TabIndex = 4
        '
        'EmailTextBox
        '
        Me.EmailTextBox.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.Location = New System.Drawing.Point(136, 342)
        Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EmailTextBox.Multiline = True
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(495, 31)
        Me.EmailTextBox.TabIndex = 3
        '
        'Cod_FornecedorTextBox
        '
        Me.Cod_FornecedorTextBox.Font = New System.Drawing.Font("Engravers MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cod_FornecedorTextBox.Location = New System.Drawing.Point(324, 106)
        Me.Cod_FornecedorTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Cod_FornecedorTextBox.Name = "Cod_FornecedorTextBox"
        Me.Cod_FornecedorTextBox.Size = New System.Drawing.Size(307, 31)
        Me.Cod_FornecedorTextBox.TabIndex = 1
        '
        'FormFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1345, 620)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Cod_FornecedorTextBox)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(Me.TelefoneTextBox)
        Me.Controls.Add(Me.ListView3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonSair)
        Me.Controls.Add(Cod_FornecedorLabel)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(TelefoneLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormFornecedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSair As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Protected Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents TelefoneTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cod_FornecedorTextBox As System.Windows.Forms.TextBox
End Class
