<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuParticipante
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuParticipante))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnIngresarCodigo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAdministrarCuestionario = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(-10, -2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(422, 58)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "    Menú"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnIngresarCodigo
        '
        Me.btnIngresarCodigo.BackColor = System.Drawing.Color.Transparent
        Me.btnIngresarCodigo.BorderRadius = 10
        Me.btnIngresarCodigo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnIngresarCodigo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnIngresarCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnIngresarCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnIngresarCodigo.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnIngresarCodigo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnIngresarCodigo.ForeColor = System.Drawing.Color.White
        Me.btnIngresarCodigo.Location = New System.Drawing.Point(95, 148)
        Me.btnIngresarCodigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIngresarCodigo.Name = "btnIngresarCodigo"
        Me.btnIngresarCodigo.Size = New System.Drawing.Size(225, 46)
        Me.btnIngresarCodigo.TabIndex = 17
        Me.btnIngresarCodigo.Text = "Ingresar &código"
        '
        'btnAdministrarCuestionario
        '
        Me.btnAdministrarCuestionario.BackColor = System.Drawing.Color.Transparent
        Me.btnAdministrarCuestionario.BorderRadius = 10
        Me.btnAdministrarCuestionario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdministrarCuestionario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdministrarCuestionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdministrarCuestionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdministrarCuestionario.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnAdministrarCuestionario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAdministrarCuestionario.ForeColor = System.Drawing.Color.White
        Me.btnAdministrarCuestionario.Location = New System.Drawing.Point(95, 215)
        Me.btnAdministrarCuestionario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdministrarCuestionario.Name = "btnAdministrarCuestionario"
        Me.btnAdministrarCuestionario.Size = New System.Drawing.Size(225, 46)
        Me.btnAdministrarCuestionario.TabIndex = 16
        Me.btnAdministrarCuestionario.Text = "&Historial"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.Location = New System.Drawing.Point(12, 379)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(152, 48)
        Me.Guna2Button1.TabIndex = 20
        Me.Guna2Button1.Text = "&Regresar"
        '
        'frmMenuParticipante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(412, 454)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnIngresarCodigo)
        Me.Controls.Add(Me.btnAdministrarCuestionario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmMenuParticipante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form10"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents btnIngresarCodigo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAdministrarCuestionario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
