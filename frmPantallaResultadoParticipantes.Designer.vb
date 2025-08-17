<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPantallaResultadoParticipantes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPantallaResultadoParticipantes))
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAlmacenarRespuestaParticipante = New Guna.UI2.WinForms.Guna2Button()
        Me.txtPUNTOS = New System.Windows.Forms.Label()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Guna2CirclePictureBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox2.Image = CType(resources.GetObject("Guna2CirclePictureBox2.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(21, -2)
        Me.Guna2CirclePictureBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(53, 47)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox2.TabIndex = 28
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(-4, -2)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(459, 47)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "&Resultados"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = "Lo haz hecho excelente"" nombre"", sigue así..."
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.Black
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(21, 180)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.ReadOnly = True
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(398, 193)
        Me.Guna2TextBox2.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 154)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(442, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "LO HAZ HECHO GENIAL, ACÁ ALGUNA RETROALIMENTACIÓN"
        '
        'btnAlmacenarRespuestaParticipante
        '
        Me.btnAlmacenarRespuestaParticipante.BackColor = System.Drawing.Color.Transparent
        Me.btnAlmacenarRespuestaParticipante.BorderRadius = 10
        Me.btnAlmacenarRespuestaParticipante.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAlmacenarRespuestaParticipante.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAlmacenarRespuestaParticipante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAlmacenarRespuestaParticipante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAlmacenarRespuestaParticipante.FillColor = System.Drawing.Color.GreenYellow
        Me.btnAlmacenarRespuestaParticipante.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAlmacenarRespuestaParticipante.ForeColor = System.Drawing.Color.Black
        Me.btnAlmacenarRespuestaParticipante.Image = CType(resources.GetObject("btnAlmacenarRespuestaParticipante.Image"), System.Drawing.Image)
        Me.btnAlmacenarRespuestaParticipante.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAlmacenarRespuestaParticipante.Location = New System.Drawing.Point(316, 389)
        Me.btnAlmacenarRespuestaParticipante.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAlmacenarRespuestaParticipante.Name = "btnAlmacenarRespuestaParticipante"
        Me.btnAlmacenarRespuestaParticipante.Size = New System.Drawing.Size(111, 31)
        Me.btnAlmacenarRespuestaParticipante.TabIndex = 32
        Me.btnAlmacenarRespuestaParticipante.Text = "&Entendido"
        '
        'txtPUNTOS
        '
        Me.txtPUNTOS.AutoSize = True
        Me.txtPUNTOS.BackColor = System.Drawing.Color.White
        Me.txtPUNTOS.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPUNTOS.Location = New System.Drawing.Point(149, 62)
        Me.txtPUNTOS.Name = "txtPUNTOS"
        Me.txtPUNTOS.Size = New System.Drawing.Size(141, 77)
        Me.txtPUNTOS.TabIndex = 33
        Me.txtPUNTOS.Text = "10/10"
        Me.txtPUNTOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPantallaResultadoParticipantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(449, 438)
        Me.Controls.Add(Me.txtPUNTOS)
        Me.Controls.Add(Me.btnAlmacenarRespuestaParticipante)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2TextBox2)
        Me.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmPantallaResultadoParticipantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form13"
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAlmacenarRespuestaParticipante As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtPUNTOS As Label
End Class
