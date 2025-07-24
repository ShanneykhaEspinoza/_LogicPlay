<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEnPartida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnPartida))
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.Guna2ContextMenuStrip2 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.scbTiempoRestante = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPreguntaEnPartida = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pbImagenEnPartida = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAlmacenarRespuestaParticipante = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRespuesta1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.btnRespuesta2 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.btnRespuesta3 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.btnRespuesta4 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.pbImagenEnPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Guna2ContextMenuStrip2
        '
        Me.Guna2ContextMenuStrip2.Enabled = False
        Me.Guna2ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.Guna2ContextMenuStrip2.Name = "Guna2ContextMenuStrip2"
        Me.Guna2ContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip2.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip2.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'scbTiempoRestante
        '
        Me.scbTiempoRestante.BackColor = System.Drawing.Color.Transparent
        Me.scbTiempoRestante.BorderRadius = 10
        Me.scbTiempoRestante.FillColor = System.Drawing.Color.DeepSkyBlue
        Me.scbTiempoRestante.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.scbTiempoRestante.Location = New System.Drawing.Point(11, 38)
        Me.scbTiempoRestante.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.scbTiempoRestante.Maximum = 20
        Me.scbTiempoRestante.Name = "scbTiempoRestante"
        Me.scbTiempoRestante.ProgressColor = System.Drawing.Color.MidnightBlue
        Me.scbTiempoRestante.ProgressColor2 = System.Drawing.Color.MediumBlue
        Me.scbTiempoRestante.ShowText = True
        Me.scbTiempoRestante.Size = New System.Drawing.Size(524, 34)
        Me.scbTiempoRestante.TabIndex = 19
        Me.scbTiempoRestante.Text = "Guna2ProgressBar1"
        Me.scbTiempoRestante.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.scbTiempoRestante.Value = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Tiempo restante:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.YellowGreen
        Me.Label2.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 366)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(524, 46)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "¿Cuál es la respuesta correcta?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPreguntaEnPartida
        '
        Me.txtPreguntaEnPartida.BackColor = System.Drawing.Color.Transparent
        Me.txtPreguntaEnPartida.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPreguntaEnPartida.DefaultText = ""
        Me.txtPreguntaEnPartida.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPreguntaEnPartida.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPreguntaEnPartida.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPreguntaEnPartida.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPreguntaEnPartida.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPreguntaEnPartida.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreguntaEnPartida.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPreguntaEnPartida.Location = New System.Drawing.Point(54, 132)
        Me.txtPreguntaEnPartida.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtPreguntaEnPartida.MaxLength = 40
        Me.txtPreguntaEnPartida.Name = "txtPreguntaEnPartida"
        Me.txtPreguntaEnPartida.PlaceholderText = ""
        Me.txtPreguntaEnPartida.ReadOnly = True
        Me.txtPreguntaEnPartida.SelectedText = ""
        Me.txtPreguntaEnPartida.Size = New System.Drawing.Size(438, 40)
        Me.txtPreguntaEnPartida.TabIndex = 25
        '
        'pbImagenEnPartida
        '
        Me.pbImagenEnPartida.Image = CType(resources.GetObject("pbImagenEnPartida.Image"), System.Drawing.Image)
        Me.pbImagenEnPartida.ImageRotate = 0!
        Me.pbImagenEnPartida.Location = New System.Drawing.Point(144, 177)
        Me.pbImagenEnPartida.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pbImagenEnPartida.Name = "pbImagenEnPartida"
        Me.pbImagenEnPartida.Size = New System.Drawing.Size(243, 173)
        Me.pbImagenEnPartida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagenEnPartida.TabIndex = 24
        Me.pbImagenEnPartida.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(162, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(188, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "LA PREGUNTA ES:"
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
        Me.btnAlmacenarRespuestaParticipante.Location = New System.Drawing.Point(11, 701)
        Me.btnAlmacenarRespuestaParticipante.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAlmacenarRespuestaParticipante.Name = "btnAlmacenarRespuestaParticipante"
        Me.btnAlmacenarRespuestaParticipante.Size = New System.Drawing.Size(148, 38)
        Me.btnAlmacenarRespuestaParticipante.TabIndex = 27
        Me.btnAlmacenarRespuestaParticipante.Text = "&Almacenar"
        '
        'btnRespuesta1
        '
        Me.btnRespuesta1.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnRespuesta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRespuesta1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRespuesta1.CheckedState.BorderThickness = 0
        Me.btnRespuesta1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRespuesta1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.btnRespuesta1.CheckedState.InnerOffset = -4
        Me.btnRespuesta1.Location = New System.Drawing.Point(54, 464)
        Me.btnRespuesta1.Name = "btnRespuesta1"
        Me.btnRespuesta1.Size = New System.Drawing.Size(197, 53)
        Me.btnRespuesta1.TabIndex = 28
        Me.btnRespuesta1.Text = "   A"
        Me.btnRespuesta1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnRespuesta1.UncheckedState.BorderThickness = 2
        Me.btnRespuesta1.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btnRespuesta1.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.btnRespuesta1.UseVisualStyleBackColor = False
        '
        'btnRespuesta2
        '
        Me.btnRespuesta2.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnRespuesta2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRespuesta2.CheckedState.BorderThickness = 0
        Me.btnRespuesta2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRespuesta2.CheckedState.InnerColor = System.Drawing.Color.White
        Me.btnRespuesta2.CheckedState.InnerOffset = -4
        Me.btnRespuesta2.Location = New System.Drawing.Point(302, 464)
        Me.btnRespuesta2.Name = "btnRespuesta2"
        Me.btnRespuesta2.Size = New System.Drawing.Size(197, 53)
        Me.btnRespuesta2.TabIndex = 29
        Me.btnRespuesta2.Text = "    B"
        Me.btnRespuesta2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnRespuesta2.UncheckedState.BorderThickness = 2
        Me.btnRespuesta2.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btnRespuesta2.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'btnRespuesta3
        '
        Me.btnRespuesta3.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnRespuesta3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRespuesta3.CheckedState.BorderThickness = 0
        Me.btnRespuesta3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRespuesta3.CheckedState.InnerColor = System.Drawing.Color.White
        Me.btnRespuesta3.CheckedState.InnerOffset = -4
        Me.btnRespuesta3.Location = New System.Drawing.Point(54, 566)
        Me.btnRespuesta3.Name = "btnRespuesta3"
        Me.btnRespuesta3.Size = New System.Drawing.Size(197, 53)
        Me.btnRespuesta3.TabIndex = 30
        Me.btnRespuesta3.Text = "    C"
        Me.btnRespuesta3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnRespuesta3.UncheckedState.BorderThickness = 2
        Me.btnRespuesta3.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btnRespuesta3.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'btnRespuesta4
        '
        Me.btnRespuesta4.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnRespuesta4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRespuesta4.CheckedState.BorderThickness = 0
        Me.btnRespuesta4.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRespuesta4.CheckedState.InnerColor = System.Drawing.Color.White
        Me.btnRespuesta4.CheckedState.InnerOffset = -4
        Me.btnRespuesta4.Location = New System.Drawing.Point(302, 566)
        Me.btnRespuesta4.Name = "btnRespuesta4"
        Me.btnRespuesta4.Size = New System.Drawing.Size(195, 53)
        Me.btnRespuesta4.TabIndex = 31
        Me.btnRespuesta4.Text = "   D"
        Me.btnRespuesta4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnRespuesta4.UncheckedState.BorderThickness = 2
        Me.btnRespuesta4.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btnRespuesta4.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 440)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 17)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "(Aqui va la respuesta)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(299, 440)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "(Aqui va la respuesta)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(299, 546)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 17)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "(Aqui va la respuesta)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 546)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 17)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "(Aqui va la respuesta)"
        '
        'frmEnPartida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(548, 750)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRespuesta4)
        Me.Controls.Add(Me.btnRespuesta3)
        Me.Controls.Add(Me.btnRespuesta2)
        Me.Controls.Add(Me.btnRespuesta1)
        Me.Controls.Add(Me.btnAlmacenarRespuestaParticipante)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPreguntaEnPartida)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.scbTiempoRestante)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbImagenEnPartida)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmEnPartida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form12"
        CType(Me.pbImagenEnPartida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents Guna2ContextMenuStrip2 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents scbTiempoRestante As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pbImagenEnPartida As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtPreguntaEnPartida As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAlmacenarRespuestaParticipante As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRespuesta1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents btnRespuesta2 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents btnRespuesta3 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents btnRespuesta4 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
