<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCodigoParticipante
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCodigoParticipante))
        Me.txtCodigoIngresadoJugador = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCopiarCodigo = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodigoIngresadoJugador
        '
        Me.txtCodigoIngresadoJugador.BackColor = System.Drawing.Color.Transparent
        Me.txtCodigoIngresadoJugador.BorderRadius = 7
        Me.txtCodigoIngresadoJugador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigoIngresadoJugador.DefaultText = ""
        Me.txtCodigoIngresadoJugador.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCodigoIngresadoJugador.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCodigoIngresadoJugador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCodigoIngresadoJugador.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCodigoIngresadoJugador.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigoIngresadoJugador.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCodigoIngresadoJugador.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigoIngresadoJugador.Location = New System.Drawing.Point(26, 236)
        Me.txtCodigoIngresadoJugador.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodigoIngresadoJugador.Name = "txtCodigoIngresadoJugador"
        Me.txtCodigoIngresadoJugador.PlaceholderText = "Ingrese el código para esta partida..."
        Me.txtCodigoIngresadoJugador.SelectedText = ""
        Me.txtCodigoIngresadoJugador.Size = New System.Drawing.Size(359, 57)
        Me.txtCodigoIngresadoJugador.TabIndex = 27
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Guna2CirclePictureBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox2.Image = CType(resources.GetObject("Guna2CirclePictureBox2.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(26, -2)
        Me.Guna2CirclePictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(71, 58)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox2.TabIndex = 26
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(-4, -2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(427, 58)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Código"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.Location = New System.Drawing.Point(271, 8)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(152, 48)
        Me.Guna2Button1.TabIndex = 29
        Me.Guna2Button1.Text = "&Regresar"
        '
        'btnCopiarCodigo
        '
        Me.btnCopiarCodigo.BackColor = System.Drawing.Color.Transparent
        Me.btnCopiarCodigo.BorderRadius = 10
        Me.btnCopiarCodigo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCopiarCodigo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCopiarCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCopiarCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCopiarCodigo.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnCopiarCodigo.FocusedColor = System.Drawing.Color.WhiteSmoke
        Me.btnCopiarCodigo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopiarCodigo.ForeColor = System.Drawing.Color.White
        Me.btnCopiarCodigo.Image = CType(resources.GetObject("btnCopiarCodigo.Image"), System.Drawing.Image)
        Me.btnCopiarCodigo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnCopiarCodigo.Location = New System.Drawing.Point(121, 419)
        Me.btnCopiarCodigo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCopiarCodigo.Name = "btnCopiarCodigo"
        Me.btnCopiarCodigo.Size = New System.Drawing.Size(165, 42)
        Me.btnCopiarCodigo.TabIndex = 31
        Me.btnCopiarCodigo.Text = "&Unirme a sala"
        '
        'frmCodigoParticipante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(421, 633)
        Me.Controls.Add(Me.btnCopiarCodigo)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.txtCodigoIngresadoJugador)
        Me.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmCodigoParticipante"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form11"
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtCodigoIngresadoJugador As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCopiarCodigo As Guna.UI2.WinForms.Guna2Button
End Class
