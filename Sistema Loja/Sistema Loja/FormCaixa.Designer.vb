﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCaixa
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
        Me.components = New System.ComponentModel.Container()
        Dim Label4 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListBoxCupon = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxCod_Barra = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxQuatidade_intem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxValor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxDescrição = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxNome = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Timerstring = New System.Windows.Forms.Timer(Me.components)
        Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Engravers MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Label4.Location = New System.Drawing.Point(381, 12)
        Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(711, 51)
        Label4.TabIndex = 92
        Label4.Text = "software e services"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ListBoxCupon)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBoxCod_Barra)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextBoxTotal)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBoxQuatidade_intem)
        Me.Panel1.Controls.Add(Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBoxValor)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBoxDescrição)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBoxNome)
        Me.Panel1.Controls.Add(Me.GroupBox8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1811, 911)
        Me.Panel1.TabIndex = 0
        '
        'ListBoxCupon
        '
        Me.ListBoxCupon.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxCupon.FormattingEnabled = True
        Me.ListBoxCupon.ItemHeight = 29
        Me.ListBoxCupon.Location = New System.Drawing.Point(16, 114)
        Me.ListBoxCupon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBoxCupon.Name = "ListBoxCupon"
        Me.ListBoxCupon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ListBoxCupon.Size = New System.Drawing.Size(733, 613)
        Me.ListBoxCupon.TabIndex = 99
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Engravers MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(837, 780)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(325, 28)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "codigo de barra"
        '
        'TextBoxCod_Barra
        '
        Me.TextBoxCod_Barra.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBoxCod_Barra.Font = New System.Drawing.Font("Engravers MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCod_Barra.Location = New System.Drawing.Point(843, 805)
        Me.TextBoxCod_Barra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxCod_Barra.Name = "TextBoxCod_Barra"
        Me.TextBoxCod_Barra.Size = New System.Drawing.Size(925, 58)
        Me.TextBoxCod_Barra.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Engravers MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1343, 641)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 28)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Total"
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBoxTotal.Font = New System.Drawing.Font("Engravers MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotal.Location = New System.Drawing.Point(1340, 666)
        Me.TextBoxTotal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.ReadOnly = True
        Me.TextBoxTotal.Size = New System.Drawing.Size(431, 58)
        Me.TextBoxTotal.TabIndex = 97
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Engravers MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(849, 641)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(413, 28)
        Me.Label6.TabIndex = 96
        Me.Label6.Text = "quantidade de itens"
        '
        'TextBoxQuatidade_intem
        '
        Me.TextBoxQuatidade_intem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBoxQuatidade_intem.Font = New System.Drawing.Font("Engravers MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxQuatidade_intem.Location = New System.Drawing.Point(843, 666)
        Me.TextBoxQuatidade_intem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxQuatidade_intem.Name = "TextBoxQuatidade_intem"
        Me.TextBoxQuatidade_intem.Size = New System.Drawing.Size(473, 58)
        Me.TextBoxQuatidade_intem.TabIndex = 95
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Engravers MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(873, 455)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 28)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "valor"
        '
        'TextBoxValor
        '
        Me.TextBoxValor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBoxValor.Font = New System.Drawing.Font("Engravers MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxValor.Location = New System.Drawing.Point(864, 480)
        Me.TextBoxValor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxValor.Name = "TextBoxValor"
        Me.TextBoxValor.ReadOnly = True
        Me.TextBoxValor.Size = New System.Drawing.Size(907, 58)
        Me.TextBoxValor.TabIndex = 90
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Engravers MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(873, 290)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 28)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "descrição"
        '
        'TextBoxDescrição
        '
        Me.TextBoxDescrição.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBoxDescrição.Font = New System.Drawing.Font("Engravers MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDescrição.Location = New System.Drawing.Point(864, 315)
        Me.TextBoxDescrição.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxDescrição.Name = "TextBoxDescrição"
        Me.TextBoxDescrição.ReadOnly = True
        Me.TextBoxDescrição.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TextBoxDescrição.Size = New System.Drawing.Size(907, 58)
        Me.TextBoxDescrição.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Engravers MT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(873, 114)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 28)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "nome"
        '
        'TextBoxNome
        '
        Me.TextBoxNome.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBoxNome.Font = New System.Drawing.Font("Engravers MT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNome.Location = New System.Drawing.Point(864, 139)
        Me.TextBoxNome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBoxNome.Name = "TextBoxNome"
        Me.TextBoxNome.ReadOnly = True
        Me.TextBoxNome.Size = New System.Drawing.Size(907, 58)
        Me.TextBoxNome.TabIndex = 86
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.Controls.Add(Me.Label12)
        Me.GroupBox8.Controls.Add(Me.Label11)
        Me.GroupBox8.Font = New System.Drawing.Font("Engravers MT", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Black
        Me.GroupBox8.Location = New System.Drawing.Point(16, 758)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox8.Size = New System.Drawing.Size(735, 106)
        Me.GroupBox8.TabIndex = 85
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Funçoes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(509, 75)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 16)
        Me.Label8.TabIndex = 86
        Me.Label8.Text = "[Esc] Sair"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(509, 22)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 16)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "[F4] Novo"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(509, 47)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 16)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "[F5] Ajuda"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(13, 22)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(283, 16)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "[F1] Alterar Quantidade"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(13, 75)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(156, 16)
        Me.Label12.TabIndex = 82
        Me.Label12.Text = "[F3] Cancelar"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(13, 47)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 16)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "[F2] Finalizar"
        '
        'Timerstring
        '
        Me.Timerstring.Enabled = True
        Me.Timerstring.Interval = 50
        '
        'FormCaixa
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1811, 911)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormCaixa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCaixa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxValor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDescrição As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNome As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxQuatidade_intem As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timerstring As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxCod_Barra As System.Windows.Forms.TextBox
    Friend WithEvents ListBoxCupon As System.Windows.Forms.ListBox
End Class
