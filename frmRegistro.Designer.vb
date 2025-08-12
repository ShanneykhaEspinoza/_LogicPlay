<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistro))
        Me.txtNombreUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtCedulaUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtContraseniaUsuario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAlmacenarRegistro = New Guna.UI2.WinForms.Guna2Button()
        Me.IDU_OBJ = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtConfirmarContrasenia = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.IDU_OBJ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreUsuario.BorderRadius = 10
        Me.txtNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreUsuario.DefaultText = ""
        Me.txtNombreUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombreUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombreUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtNombreUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreUsuario.Location = New System.Drawing.Point(41, 106)
        Me.txtNombreUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.PlaceholderText = "Digite su nombre..."
        Me.txtNombreUsuario.SelectedText = ""
        Me.txtNombreUsuario.Size = New System.Drawing.Size(348, 48)
        Me.txtNombreUsuario.TabIndex = 1
        '
        'txtCedulaUsuario
        '
        Me.txtCedulaUsuario.BackColor = System.Drawing.Color.Transparent
        Me.txtCedulaUsuario.BorderRadius = 10
        Me.txtCedulaUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCedulaUsuario.DefaultText = ""
        Me.txtCedulaUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCedulaUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCedulaUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCedulaUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCedulaUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCedulaUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCedulaUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtCedulaUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCedulaUsuario.Location = New System.Drawing.Point(84, 185)
        Me.txtCedulaUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCedulaUsuario.MaxLength = 9
        Me.txtCedulaUsuario.Name = "txtCedulaUsuario"
        Me.txtCedulaUsuario.PlaceholderText = "Digite su identificación..."
        Me.txtCedulaUsuario.SelectedText = ""
        Me.txtCedulaUsuario.Size = New System.Drawing.Size(254, 48)
        Me.txtCedulaUsuario.TabIndex = 2
        '
        'txtContraseniaUsuario
        '
        Me.txtContraseniaUsuario.BackColor = System.Drawing.Color.Transparent
        Me.txtContraseniaUsuario.BorderRadius = 10
        Me.txtContraseniaUsuario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContraseniaUsuario.DefaultText = ""
        Me.txtContraseniaUsuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtContraseniaUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtContraseniaUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraseniaUsuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtContraseniaUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContraseniaUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtContraseniaUsuario.ForeColor = System.Drawing.Color.Black
        Me.txtContraseniaUsuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtContraseniaUsuario.Location = New System.Drawing.Point(84, 275)
        Me.txtContraseniaUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContraseniaUsuario.MaxLength = 8
        Me.txtContraseniaUsuario.Name = "txtContraseniaUsuario"
        Me.txtContraseniaUsuario.PlaceholderText = "Cree una contraseña..."
        Me.txtContraseniaUsuario.SelectedText = ""
        Me.txtContraseniaUsuario.Size = New System.Drawing.Size(254, 47)
        Me.txtContraseniaUsuario.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(100, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(203, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cree una contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Digite su número de cédula"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Digite su nombre completo"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(-4, -1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(422, 65)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "     Registro de usuarios"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAlmacenarRegistro
        '
        Me.btnAlmacenarRegistro.BackColor = System.Drawing.Color.Transparent
        Me.btnAlmacenarRegistro.BorderRadius = 10
        Me.btnAlmacenarRegistro.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAlmacenarRegistro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAlmacenarRegistro.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAlmacenarRegistro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAlmacenarRegistro.FillColor = System.Drawing.Color.GreenYellow
        Me.btnAlmacenarRegistro.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAlmacenarRegistro.ForeColor = System.Drawing.Color.Black
        Me.btnAlmacenarRegistro.Image = CType(resources.GetObject("btnAlmacenarRegistro.Image"), System.Drawing.Image)
        Me.btnAlmacenarRegistro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAlmacenarRegistro.Location = New System.Drawing.Point(237, 453)
        Me.btnAlmacenarRegistro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAlmacenarRegistro.Name = "btnAlmacenarRegistro"
        Me.btnAlmacenarRegistro.Size = New System.Drawing.Size(152, 48)
        Me.btnAlmacenarRegistro.TabIndex = 12
        Me.btnAlmacenarRegistro.Text = "&Almacenar"
        '
        'IDU_OBJ
        '
        Me.IDU_OBJ.BackColor = System.Drawing.Color.MidnightBlue
        Me.IDU_OBJ.FillColor = System.Drawing.Color.Transparent
        Me.IDU_OBJ.Image = CType(resources.GetObject("IDU_OBJ.Image"), System.Drawing.Image)
        Me.IDU_OBJ.ImageRotate = 0!
        Me.IDU_OBJ.Location = New System.Drawing.Point(7, -1)
        Me.IDU_OBJ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IDU_OBJ.Name = "IDU_OBJ"
        Me.IDU_OBJ.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.IDU_OBJ.Size = New System.Drawing.Size(76, 65)
        Me.IDU_OBJ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IDU_OBJ.TabIndex = 14
        Me.IDU_OBJ.TabStop = False
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
        Me.Guna2Button1.Location = New System.Drawing.Point(41, 453)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(152, 48)
        Me.Guna2Button1.TabIndex = 15
        Me.Guna2Button1.Text = "&Regresar"
        '
        'txtConfirmarContrasenia
        '
        Me.txtConfirmarContrasenia.BackColor = System.Drawing.Color.Transparent
        Me.txtConfirmarContrasenia.BorderRadius = 10
        Me.txtConfirmarContrasenia.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmarContrasenia.DefaultText = ""
        Me.txtConfirmarContrasenia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmarContrasenia.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmarContrasenia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmarContrasenia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmarContrasenia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmarContrasenia.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtConfirmarContrasenia.ForeColor = System.Drawing.Color.Black
        Me.txtConfirmarContrasenia.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmarContrasenia.Location = New System.Drawing.Point(84, 368)
        Me.txtConfirmarContrasenia.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirmarContrasenia.MaxLength = 8
        Me.txtConfirmarContrasenia.Name = "txtConfirmarContrasenia"
        Me.txtConfirmarContrasenia.PlaceholderText = "Cree una contraseña..."
        Me.txtConfirmarContrasenia.SelectedText = ""
        Me.txtConfirmarContrasenia.Size = New System.Drawing.Size(254, 47)
        Me.txtConfirmarContrasenia.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(100, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 20)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Confirmar contraseña"
        '
        'frmRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(416, 512)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtConfirmarContrasenia)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.IDU_OBJ)
        Me.Controls.Add(Me.btnAlmacenarRegistro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtContraseniaUsuario)
        Me.Controls.Add(Me.txtCedulaUsuario)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.IDU_OBJ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombreUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtCedulaUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtContraseniaUsuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAlmacenarRegistro As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents IDU_OBJ As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtConfirmarContrasenia As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
End Class
