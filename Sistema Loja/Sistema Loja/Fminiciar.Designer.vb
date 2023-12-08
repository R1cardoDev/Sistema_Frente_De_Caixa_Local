<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fminiciar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fminiciar))
        Me.EstoqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaixaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripiniciar = New System.Windows.Forms.MenuStrip()
        Me.UtilitariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timerhora = New System.Windows.Forms.Timer(Me.components)
        Me.Timercontrol = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Toohora = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Toodata = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Toologado = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.statussystema = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStripiniciar.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EstoqueToolStripMenuItem
        '
        Me.EstoqueToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator1, Me.CadastroToolStripMenuItem, Me.ToolStripSeparator2, Me.VendaToolStripMenuItem})
        resources.ApplyResources(Me.EstoqueToolStripMenuItem, "EstoqueToolStripMenuItem")
        Me.EstoqueToolStripMenuItem.Name = "EstoqueToolStripMenuItem"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        resources.ApplyResources(Me.CadastroToolStripMenuItem, "CadastroToolStripMenuItem")
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        resources.ApplyResources(Me.ToolStripSeparator2, "ToolStripSeparator2")
        '
        'VendaToolStripMenuItem
        '
        Me.VendaToolStripMenuItem.Name = "VendaToolStripMenuItem"
        resources.ApplyResources(Me.VendaToolStripMenuItem, "VendaToolStripMenuItem")
        '
        'CaixaToolStripMenuItem
        '
        resources.ApplyResources(Me.CaixaToolStripMenuItem, "CaixaToolStripMenuItem")
        Me.CaixaToolStripMenuItem.Name = "CaixaToolStripMenuItem"
        '
        'SairToolStripMenuItem
        '
        resources.ApplyResources(Me.SairToolStripMenuItem, "SairToolStripMenuItem")
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        '
        'MenuStripiniciar
        '
        resources.ApplyResources(Me.MenuStripiniciar, "MenuStripiniciar")
        Me.MenuStripiniciar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EstoqueToolStripMenuItem, Me.CaixaToolStripMenuItem, Me.SairToolStripMenuItem, Me.UtilitariosToolStripMenuItem})
        Me.MenuStripiniciar.Name = "MenuStripiniciar"
        '
        'UtilitariosToolStripMenuItem
        '
        Me.UtilitariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.CalculadoraToolStripMenuItem, Me.ToolStripSeparator7, Me.NotepadToolStripMenuItem})
        resources.ApplyResources(Me.UtilitariosToolStripMenuItem, "UtilitariosToolStripMenuItem")
        Me.UtilitariosToolStripMenuItem.Name = "UtilitariosToolStripMenuItem"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        resources.ApplyResources(Me.ToolStripSeparator6, "ToolStripSeparator6")
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        resources.ApplyResources(Me.CalculadoraToolStripMenuItem, "CalculadoraToolStripMenuItem")
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        resources.ApplyResources(Me.ToolStripSeparator7, "ToolStripSeparator7")
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        resources.ApplyResources(Me.NotepadToolStripMenuItem, "NotepadToolStripMenuItem")
        '
        'Timerhora
        '
        Me.Timerhora.Enabled = True
        Me.Timerhora.Interval = 1000
        '
        'Timercontrol
        '
        Me.Timercontrol.Enabled = True
        Me.Timercontrol.Interval = 30000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Toohora, Me.Toodata, Me.Toologado, Me.ToolStripProgressBar1, Me.statussystema})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'Toohora
        '
        Me.Toohora.ForeColor = System.Drawing.Color.Blue
        Me.Toohora.Name = "Toohora"
        resources.ApplyResources(Me.Toohora, "Toohora")
        '
        'Toodata
        '
        Me.Toodata.ForeColor = System.Drawing.Color.Blue
        Me.Toodata.Name = "Toodata"
        resources.ApplyResources(Me.Toodata, "Toodata")
        '
        'Toologado
        '
        resources.ApplyResources(Me.Toologado, "Toologado")
        Me.Toologado.ForeColor = System.Drawing.Color.Blue
        Me.Toologado.Name = "Toologado"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        resources.ApplyResources(Me.ToolStripProgressBar1, "ToolStripProgressBar1")
        '
        'statussystema
        '
        Me.statussystema.Name = "statussystema"
        resources.ApplyResources(Me.statussystema, "statussystema")
        '
        'fminiciar
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStripiniciar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStripiniciar
        Me.MaximizeBox = False
        Me.Name = "fminiciar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStripiniciar.ResumeLayout(False)
        Me.MenuStripiniciar.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UtilitariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstoqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaixaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStripiniciar As System.Windows.Forms.MenuStrip
    Friend WithEvents Timerhora As System.Windows.Forms.Timer
    Friend WithEvents Timercontrol As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Toohora As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Toodata As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Toologado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents VendaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents statussystema As System.Windows.Forms.ToolStripStatusLabel
End Class
