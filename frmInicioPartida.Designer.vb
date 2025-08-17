<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInicioPartida
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicioPartida))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbxCuestionario = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnCompartirCodigo = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS PGothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(93, 104)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cuestionario"
        '
        'cbxCuestionario
        '
        Me.cbxCuestionario.BackColor = System.Drawing.Color.Transparent
        Me.cbxCuestionario.BorderRadius = 10
        Me.cbxCuestionario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxCuestionario.DropDownHeight = 200
        Me.cbxCuestionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCuestionario.FillColor = System.Drawing.Color.YellowGreen
        Me.cbxCuestionario.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxCuestionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxCuestionario.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxCuestionario.ForeColor = System.Drawing.Color.Black
        Me.cbxCuestionario.IntegralHeight = False
        Me.cbxCuestionario.ItemHeight = 30
        Me.cbxCuestionario.Location = New System.Drawing.Point(11, 164)
        Me.cbxCuestionario.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxCuestionario.Name = "cbxCuestionario"
        Me.cbxCuestionario.Size = New System.Drawing.Size(283, 36)
        Me.cbxCuestionario.TabIndex = 4
        '
        'btnCompartirCodigo
        '
        Me.btnCompartirCodigo.BackColor = System.Drawing.Color.Transparent
        Me.btnCompartirCodigo.BorderRadius = 10
        Me.btnCompartirCodigo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCompartirCodigo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCompartirCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCompartirCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCompartirCodigo.Enabled = False
        Me.btnCompartirCodigo.FillColor = System.Drawing.Color.GreenYellow
        Me.btnCompartirCodigo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCompartirCodigo.ForeColor = System.Drawing.Color.Black
        Me.btnCompartirCodigo.Image = CType(resources.GetObject("btnCompartirCodigo.Image"), System.Drawing.Image)
        Me.btnCompartirCodigo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnCompartirCodigo.Location = New System.Drawing.Point(85, 339)
        Me.btnCompartirCodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCompartirCodigo.Name = "btnCompartirCodigo"
        Me.btnCompartirCodigo.Size = New System.Drawing.Size(156, 30)
        Me.btnCompartirCodigo.TabIndex = 13
        Me.btnCompartirCodigo.Text = "&Generar Codigo"
        '
        'Guna2Button6
        '
        Me.Guna2Button6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button6.BorderRadius = 10
        Me.Guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button6.FillColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Button6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button6.ForeColor = System.Drawing.Color.GhostWhite
        Me.Guna2Button6.Image = CType(resources.GetObject("Guna2Button6.Image"), System.Drawing.Image)
        Me.Guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Guna2Button6.Location = New System.Drawing.Point(-14, 9)
        Me.Guna2Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.Size = New System.Drawing.Size(113, 34)
        Me.Guna2Button6.TabIndex = 15
        Me.Guna2Button6.Text = "&Regresar"
        '
        'frmInicioPartida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(305, 415)
        Me.Controls.Add(Me.Guna2Button6)
        Me.Controls.Add(Me.cbxCuestionario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCompartirCodigo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmInicioPartida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbxCuestionario As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnCompartirCodigo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
End Class
