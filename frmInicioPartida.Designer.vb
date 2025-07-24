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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxTiempo = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnGenerarCodigo = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS PGothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Cuestionario"
        '
        'cbxCuestionario
        '
        Me.cbxCuestionario.BackColor = System.Drawing.Color.Transparent
        Me.cbxCuestionario.BorderRadius = 10
        Me.cbxCuestionario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxCuestionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCuestionario.FillColor = System.Drawing.Color.YellowGreen
        Me.cbxCuestionario.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxCuestionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxCuestionario.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxCuestionario.ForeColor = System.Drawing.Color.Black
        Me.cbxCuestionario.ItemHeight = 30
        Me.cbxCuestionario.Location = New System.Drawing.Point(96, 159)
        Me.cbxCuestionario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxCuestionario.Name = "cbxCuestionario"
        Me.cbxCuestionario.Size = New System.Drawing.Size(213, 36)
        Me.cbxCuestionario.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS PGothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 265)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 28)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tiempo por pregunta"
        '
        'cbxTiempo
        '
        Me.cbxTiempo.BackColor = System.Drawing.Color.Transparent
        Me.cbxTiempo.BorderRadius = 10
        Me.cbxTiempo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxTiempo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTiempo.FillColor = System.Drawing.Color.YellowGreen
        Me.cbxTiempo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxTiempo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbxTiempo.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxTiempo.ForeColor = System.Drawing.Color.Black
        Me.cbxTiempo.ItemHeight = 30
        Me.cbxTiempo.Location = New System.Drawing.Point(93, 295)
        Me.cbxTiempo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbxTiempo.Name = "cbxTiempo"
        Me.cbxTiempo.Size = New System.Drawing.Size(213, 36)
        Me.cbxTiempo.TabIndex = 6
        '
        'btnGenerarCodigo
        '
        Me.btnGenerarCodigo.BackColor = System.Drawing.Color.Transparent
        Me.btnGenerarCodigo.BorderRadius = 10
        Me.btnGenerarCodigo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGenerarCodigo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGenerarCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGenerarCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGenerarCodigo.FillColor = System.Drawing.Color.GreenYellow
        Me.btnGenerarCodigo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnGenerarCodigo.ForeColor = System.Drawing.Color.Black
        Me.btnGenerarCodigo.Image = CType(resources.GetObject("btnGenerarCodigo.Image"), System.Drawing.Image)
        Me.btnGenerarCodigo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnGenerarCodigo.Location = New System.Drawing.Point(219, 463)
        Me.btnGenerarCodigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGenerarCodigo.Name = "btnGenerarCodigo"
        Me.btnGenerarCodigo.Size = New System.Drawing.Size(176, 37)
        Me.btnGenerarCodigo.TabIndex = 13
        Me.btnGenerarCodigo.Text = "&Generar código"
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
        Me.Guna2Button6.Location = New System.Drawing.Point(-18, 11)
        Me.Guna2Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.Size = New System.Drawing.Size(151, 42)
        Me.Guna2Button6.TabIndex = 15
        Me.Guna2Button6.Text = "&Regresar"
        '
        'frmInicioPartida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(407, 511)
        Me.Controls.Add(Me.Guna2Button6)
        Me.Controls.Add(Me.btnGenerarCodigo)
        Me.Controls.Add(Me.cbxTiempo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxCuestionario)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmInicioPartida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbxCuestionario As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxTiempo As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnGenerarCodigo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
End Class
