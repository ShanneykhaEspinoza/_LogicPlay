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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnPartida))
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.Guna2ContextMenuStrip2 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.scbTiempoRestante = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pbImagenEnPartida = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Nombre_pregunta = New System.Windows.Forms.Label()
        Me.btnAlmacenarRespuestaParticipante = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRespuesta1 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.btnRespuesta2 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.btnRespuesta3 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.btnRespuesta4 = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.txtRespuesta1 = New System.Windows.Forms.Label()
        Me.txtRespuesta2 = New System.Windows.Forms.Label()
        Me.txtRespuesta4 = New System.Windows.Forms.Label()
        Me.txtRespuesta3 = New System.Windows.Forms.Label()
        Me.IMAGEN = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TmrTiempo = New System.Windows.Forms.Timer(Me.components)
        Me.VIDEO = New AxWMPLib.AxWindowsMediaPlayer()
        Me.lbOcultar = New System.Windows.Forms.Label()
        CType(Me.pbImagenEnPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMAGEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VIDEO, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.scbTiempoRestante.Location = New System.Drawing.Point(8, 31)
        Me.scbTiempoRestante.Margin = New System.Windows.Forms.Padding(2)
        Me.scbTiempoRestante.Maximum = 20
        Me.scbTiempoRestante.Name = "scbTiempoRestante"
        Me.scbTiempoRestante.ProgressColor = System.Drawing.Color.MidnightBlue
        Me.scbTiempoRestante.ProgressColor2 = System.Drawing.Color.MediumBlue
        Me.scbTiempoRestante.ShowText = True
        Me.scbTiempoRestante.Size = New System.Drawing.Size(493, 28)
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
        Me.Label1.Location = New System.Drawing.Point(193, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Tiempo restante:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.YellowGreen
        Me.Label2.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 316)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(422, 37)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "¿Cuál es la respuesta correcta?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbImagenEnPartida
        '
        Me.pbImagenEnPartida.Image = CType(resources.GetObject("pbImagenEnPartida.Image"), System.Drawing.Image)
        Me.pbImagenEnPartida.ImageRotate = 0!
        Me.pbImagenEnPartida.Location = New System.Drawing.Point(151, 133)
        Me.pbImagenEnPartida.Margin = New System.Windows.Forms.Padding(2)
        Me.pbImagenEnPartida.Name = "pbImagenEnPartida"
        Me.pbImagenEnPartida.Size = New System.Drawing.Size(217, 161)
        Me.pbImagenEnPartida.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagenEnPartida.TabIndex = 24
        Me.pbImagenEnPartida.TabStop = False
        '
        'Nombre_pregunta
        '
        Me.Nombre_pregunta.AutoEllipsis = True
        Me.Nombre_pregunta.AutoSize = True
        Me.Nombre_pregunta.BackColor = System.Drawing.Color.Transparent
        Me.Nombre_pregunta.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre_pregunta.Location = New System.Drawing.Point(27, 70)
        Me.Nombre_pregunta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Nombre_pregunta.MaximumSize = New System.Drawing.Size(467, 0)
        Me.Nombre_pregunta.Name = "Nombre_pregunta"
        Me.Nombre_pregunta.Size = New System.Drawing.Size(153, 16)
        Me.Nombre_pregunta.TabIndex = 26
        Me.Nombre_pregunta.Text = "LA PREGUNTA ES:"
        Me.Nombre_pregunta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAlmacenarRespuestaParticipante
        '
        Me.btnAlmacenarRespuestaParticipante.BackColor = System.Drawing.Color.Transparent
        Me.btnAlmacenarRespuestaParticipante.BorderRadius = 10
        Me.btnAlmacenarRespuestaParticipante.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAlmacenarRespuestaParticipante.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAlmacenarRespuestaParticipante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAlmacenarRespuestaParticipante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAlmacenarRespuestaParticipante.Enabled = False
        Me.btnAlmacenarRespuestaParticipante.FillColor = System.Drawing.Color.GreenYellow
        Me.btnAlmacenarRespuestaParticipante.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAlmacenarRespuestaParticipante.ForeColor = System.Drawing.Color.Black
        Me.btnAlmacenarRespuestaParticipante.Image = CType(resources.GetObject("btnAlmacenarRespuestaParticipante.Image"), System.Drawing.Image)
        Me.btnAlmacenarRespuestaParticipante.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAlmacenarRespuestaParticipante.Location = New System.Drawing.Point(11, 616)
        Me.btnAlmacenarRespuestaParticipante.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAlmacenarRespuestaParticipante.Name = "btnAlmacenarRespuestaParticipante"
        Me.btnAlmacenarRespuestaParticipante.Size = New System.Drawing.Size(111, 31)
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
        Me.btnRespuesta1.Location = New System.Drawing.Point(52, 431)
        Me.btnRespuesta1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRespuesta1.Name = "btnRespuesta1"
        Me.btnRespuesta1.Size = New System.Drawing.Size(148, 43)
        Me.btnRespuesta1.TabIndex = 28
        Me.btnRespuesta1.Text = "    A"
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
        Me.btnRespuesta2.Location = New System.Drawing.Point(323, 431)
        Me.btnRespuesta2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRespuesta2.Name = "btnRespuesta2"
        Me.btnRespuesta2.Size = New System.Drawing.Size(148, 43)
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
        Me.btnRespuesta3.Location = New System.Drawing.Point(52, 558)
        Me.btnRespuesta3.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRespuesta3.Name = "btnRespuesta3"
        Me.btnRespuesta3.Size = New System.Drawing.Size(148, 43)
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
        Me.btnRespuesta4.Location = New System.Drawing.Point(323, 558)
        Me.btnRespuesta4.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRespuesta4.Name = "btnRespuesta4"
        Me.btnRespuesta4.Size = New System.Drawing.Size(148, 43)
        Me.btnRespuesta4.TabIndex = 31
        Me.btnRespuesta4.Text = "    D"
        Me.btnRespuesta4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.btnRespuesta4.UncheckedState.BorderThickness = 2
        Me.btnRespuesta4.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.btnRespuesta4.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'txtRespuesta1
        '
        Me.txtRespuesta1.AutoSize = True
        Me.txtRespuesta1.Location = New System.Drawing.Point(27, 368)
        Me.txtRespuesta1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtRespuesta1.MaximumSize = New System.Drawing.Size(222, 0)
        Me.txtRespuesta1.Name = "txtRespuesta1"
        Me.txtRespuesta1.Size = New System.Drawing.Size(222, 13)
        Me.txtRespuesta1.TabIndex = 32
        Me.txtRespuesta1.Text = "Aqui se agrega la respuesta ..........................."
        Me.txtRespuesta1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtRespuesta2
        '
        Me.txtRespuesta2.AutoSize = True
        Me.txtRespuesta2.Location = New System.Drawing.Point(279, 368)
        Me.txtRespuesta2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtRespuesta2.MaximumSize = New System.Drawing.Size(222, 0)
        Me.txtRespuesta2.Name = "txtRespuesta2"
        Me.txtRespuesta2.Size = New System.Drawing.Size(222, 13)
        Me.txtRespuesta2.TabIndex = 33
        Me.txtRespuesta2.Text = "Aqui se agrega la respuesta ..........................."
        Me.txtRespuesta2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtRespuesta4
        '
        Me.txtRespuesta4.AutoEllipsis = True
        Me.txtRespuesta4.AutoSize = True
        Me.txtRespuesta4.Location = New System.Drawing.Point(279, 497)
        Me.txtRespuesta4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtRespuesta4.MaximumSize = New System.Drawing.Size(222, 0)
        Me.txtRespuesta4.Name = "txtRespuesta4"
        Me.txtRespuesta4.Size = New System.Drawing.Size(222, 13)
        Me.txtRespuesta4.TabIndex = 34
        Me.txtRespuesta4.Text = "Aqui se agrega la respuesta ..........................."
        '
        'txtRespuesta3
        '
        Me.txtRespuesta3.AutoSize = True
        Me.txtRespuesta3.Location = New System.Drawing.Point(17, 497)
        Me.txtRespuesta3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtRespuesta3.MaximumSize = New System.Drawing.Size(222, 0)
        Me.txtRespuesta3.Name = "txtRespuesta3"
        Me.txtRespuesta3.Size = New System.Drawing.Size(198, 13)
        Me.txtRespuesta3.TabIndex = 35
        Me.txtRespuesta3.Text = "Aqui se agrega la respuesta...................."
        Me.txtRespuesta3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'IMAGEN
        '
        Me.IMAGEN.ImageRotate = 0!
        Me.IMAGEN.Location = New System.Drawing.Point(125, 124)
        Me.IMAGEN.Name = "IMAGEN"
        Me.IMAGEN.Size = New System.Drawing.Size(273, 180)
        Me.IMAGEN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IMAGEN.TabIndex = 49
        Me.IMAGEN.TabStop = False
        Me.IMAGEN.Visible = False
        '
        'VIDEO
        '
        Me.VIDEO.Enabled = True
        Me.VIDEO.Location = New System.Drawing.Point(24, 124)
        Me.VIDEO.Name = "VIDEO"
        Me.VIDEO.OcxState = CType(resources.GetObject("VIDEO.OcxState"), System.Windows.Forms.AxHost.State)
        Me.VIDEO.Size = New System.Drawing.Size(464, 180)
        Me.VIDEO.TabIndex = 50
        Me.VIDEO.Visible = False
        '
        'lbOcultar
        '
        Me.lbOcultar.BackColor = System.Drawing.Color.Black
        Me.lbOcultar.Location = New System.Drawing.Point(27, 244)
        Me.lbOcultar.Name = "lbOcultar"
        Me.lbOcultar.Size = New System.Drawing.Size(430, 15)
        Me.lbOcultar.TabIndex = 51
        Me.lbOcultar.Text = "Label3"
        Me.lbOcultar.Visible = False
        '
        'frmEnPartida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(512, 658)
        Me.Controls.Add(Me.lbOcultar)
        Me.Controls.Add(Me.VIDEO)
        Me.Controls.Add(Me.txtRespuesta3)
        Me.Controls.Add(Me.txtRespuesta4)
        Me.Controls.Add(Me.txtRespuesta2)
        Me.Controls.Add(Me.txtRespuesta1)
        Me.Controls.Add(Me.btnRespuesta4)
        Me.Controls.Add(Me.btnRespuesta3)
        Me.Controls.Add(Me.btnRespuesta2)
        Me.Controls.Add(Me.btnRespuesta1)
        Me.Controls.Add(Me.btnAlmacenarRespuestaParticipante)
        Me.Controls.Add(Me.Nombre_pregunta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.scbTiempoRestante)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IMAGEN)
        Me.Controls.Add(Me.pbImagenEnPartida)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmEnPartida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form12"
        CType(Me.pbImagenEnPartida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMAGEN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VIDEO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents Guna2ContextMenuStrip2 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents scbTiempoRestante As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pbImagenEnPartida As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Nombre_pregunta As Label
    Friend WithEvents btnAlmacenarRespuestaParticipante As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRespuesta1 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents btnRespuesta2 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents btnRespuesta3 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents btnRespuesta4 As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents txtRespuesta1 As Label
    Friend WithEvents txtRespuesta2 As Label
    Friend WithEvents txtRespuesta4 As Label
    Friend WithEvents txtRespuesta3 As Label
    Friend WithEvents IMAGEN As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents VIDEO As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents TmrTiempo As Timer
    Friend WithEvents lbOcultar As Label
End Class
