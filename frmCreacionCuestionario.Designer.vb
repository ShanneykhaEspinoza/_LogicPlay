<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreacionCuestionario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreacionCuestionario))
        Me.CODIGO = New System.Windows.Forms.Label()
        Me.btnGuardarPreguntas = New Guna.UI2.WinForms.Guna2Button()
        Me.Text1 = New System.Windows.Forms.Label()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtNombreCuestionario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODIGO
        '
        Me.CODIGO.AutoSize = True
        Me.CODIGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CODIGO.Location = New System.Drawing.Point(167, 253)
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.Size = New System.Drawing.Size(0, 16)
        Me.CODIGO.TabIndex = 40
        '
        'btnGuardarPreguntas
        '
        Me.btnGuardarPreguntas.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardarPreguntas.BorderRadius = 10
        Me.btnGuardarPreguntas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardarPreguntas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardarPreguntas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuardarPreguntas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGuardarPreguntas.FillColor = System.Drawing.Color.GreenYellow
        Me.btnGuardarPreguntas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnGuardarPreguntas.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarPreguntas.Image = CType(resources.GetObject("btnGuardarPreguntas.Image"), System.Drawing.Image)
        Me.btnGuardarPreguntas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnGuardarPreguntas.Location = New System.Drawing.Point(158, 389)
        Me.btnGuardarPreguntas.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardarPreguntas.Name = "btnGuardarPreguntas"
        Me.btnGuardarPreguntas.Size = New System.Drawing.Size(180, 31)
        Me.btnGuardarPreguntas.TabIndex = 39
        Me.btnGuardarPreguntas.Text = "&Guardar cuestionario"
        '
        'Text1
        '
        Me.Text1.AutoSize = True
        Me.Text1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.Location = New System.Drawing.Point(45, 253)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(116, 16)
        Me.Text1.TabIndex = 38
        Me.Text1.Text = "EL CODIGO ES:"
        '
        'Guna2Button6
        '
        Me.Guna2Button6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Button6.BorderRadius = 10
        Me.Guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button6.FillColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Button6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button6.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Guna2Button6.Image = CType(resources.GetObject("Guna2Button6.Image"), System.Drawing.Image)
        Me.Guna2Button6.Location = New System.Drawing.Point(2, 19)
        Me.Guna2Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.Size = New System.Drawing.Size(117, 34)
        Me.Guna2Button6.TabIndex = 37
        Me.Guna2Button6.Text = " &Regresar"
        '
        'txtNombreCuestionario
        '
        Me.txtNombreCuestionario.BackColor = System.Drawing.Color.Transparent
        Me.txtNombreCuestionario.BorderRadius = 10
        Me.txtNombreCuestionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreCuestionario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombreCuestionario.DefaultText = ""
        Me.txtNombreCuestionario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombreCuestionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombreCuestionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreCuestionario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombreCuestionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreCuestionario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNombreCuestionario.ForeColor = System.Drawing.Color.Black
        Me.txtNombreCuestionario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombreCuestionario.Location = New System.Drawing.Point(48, 133)
        Me.txtNombreCuestionario.Name = "txtNombreCuestionario"
        Me.txtNombreCuestionario.PlaceholderText = "Nombre del cuestionario..."
        Me.txtNombreCuestionario.SelectedText = ""
        Me.txtNombreCuestionario.Size = New System.Drawing.Size(388, 33)
        Me.txtNombreCuestionario.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(251, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Indique nombre del cuestionario"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(445, 6)
        Me.Guna2CirclePictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(56, 47)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 33
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(-2, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(514, 64)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Creacion de cuestionario"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmCreacionCuestionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 498)
        Me.Controls.Add(Me.CODIGO)
        Me.Controls.Add(Me.btnGuardarPreguntas)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Guna2Button6)
        Me.Controls.Add(Me.txtNombreCuestionario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCreacionCuestionario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCreacionCuestionario"
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CODIGO As Label
    Friend WithEvents btnGuardarPreguntas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Text1 As Label
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtNombreCuestionario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label4 As Label
End Class
