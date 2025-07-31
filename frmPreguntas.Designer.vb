<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPreguntas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreguntas))
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPreguntaCuestionario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRespuestaCorrecta = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRespuestaErronea2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRespuestaErronea1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRespuestaErronea3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnVerPreguntasAlmacenadas = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAgregarPregunta = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreCuestionario = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.ABRIR = New System.Windows.Forms.OpenFileDialog()
        Me.btnAgregarImagen = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPuntos = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(195, -2)
        Me.Guna2CirclePictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(75, 58)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 13
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(-3, -2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(584, 58)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "     Registro de preguntas"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPreguntaCuestionario
        '
        Me.txtPreguntaCuestionario.BackColor = System.Drawing.Color.Transparent
        Me.txtPreguntaCuestionario.BorderRadius = 10
        Me.txtPreguntaCuestionario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPreguntaCuestionario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPreguntaCuestionario.DefaultText = ""
        Me.txtPreguntaCuestionario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPreguntaCuestionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPreguntaCuestionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPreguntaCuestionario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPreguntaCuestionario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPreguntaCuestionario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPreguntaCuestionario.ForeColor = System.Drawing.Color.Black
        Me.txtPreguntaCuestionario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPreguntaCuestionario.Location = New System.Drawing.Point(27, 200)
        Me.txtPreguntaCuestionario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPreguntaCuestionario.Name = "txtPreguntaCuestionario"
        Me.txtPreguntaCuestionario.PlaceholderText = "Ingrese una pregunta..."
        Me.txtPreguntaCuestionario.SelectedText = ""
        Me.txtPreguntaCuestionario.Size = New System.Drawing.Size(517, 34)
        Me.txtPreguntaCuestionario.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(457, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Ingrese la pregunta con su respectiva respuesta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Indique respuestas posibles (3):"
        '
        'txtRespuestaCorrecta
        '
        Me.txtRespuestaCorrecta.BackColor = System.Drawing.Color.Transparent
        Me.txtRespuestaCorrecta.BorderRadius = 10
        Me.txtRespuestaCorrecta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRespuestaCorrecta.DefaultText = ""
        Me.txtRespuestaCorrecta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRespuestaCorrecta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRespuestaCorrecta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRespuestaCorrecta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRespuestaCorrecta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRespuestaCorrecta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRespuestaCorrecta.ForeColor = System.Drawing.Color.Black
        Me.txtRespuestaCorrecta.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRespuestaCorrecta.Location = New System.Drawing.Point(27, 242)
        Me.txtRespuestaCorrecta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRespuestaCorrecta.Name = "txtRespuestaCorrecta"
        Me.txtRespuestaCorrecta.PlaceholderText = "Indique la respuesta a su pregunta..."
        Me.txtRespuestaCorrecta.SelectedText = ""
        Me.txtRespuestaCorrecta.Size = New System.Drawing.Size(517, 34)
        Me.txtRespuestaCorrecta.TabIndex = 17
        '
        'txtRespuestaErronea2
        '
        Me.txtRespuestaErronea2.BackColor = System.Drawing.Color.Transparent
        Me.txtRespuestaErronea2.BorderRadius = 10
        Me.txtRespuestaErronea2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRespuestaErronea2.DefaultText = ""
        Me.txtRespuestaErronea2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRespuestaErronea2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRespuestaErronea2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRespuestaErronea2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRespuestaErronea2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRespuestaErronea2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRespuestaErronea2.ForeColor = System.Drawing.Color.Black
        Me.txtRespuestaErronea2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRespuestaErronea2.Location = New System.Drawing.Point(27, 328)
        Me.txtRespuestaErronea2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRespuestaErronea2.Name = "txtRespuestaErronea2"
        Me.txtRespuestaErronea2.PlaceholderText = "Digite una respuesta posible..."
        Me.txtRespuestaErronea2.SelectedText = ""
        Me.txtRespuestaErronea2.Size = New System.Drawing.Size(517, 32)
        Me.txtRespuestaErronea2.TabIndex = 18
        '
        'txtRespuestaErronea1
        '
        Me.txtRespuestaErronea1.BackColor = System.Drawing.Color.Transparent
        Me.txtRespuestaErronea1.BorderRadius = 10
        Me.txtRespuestaErronea1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRespuestaErronea1.DefaultText = ""
        Me.txtRespuestaErronea1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRespuestaErronea1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRespuestaErronea1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRespuestaErronea1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRespuestaErronea1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRespuestaErronea1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRespuestaErronea1.ForeColor = System.Drawing.Color.Black
        Me.txtRespuestaErronea1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRespuestaErronea1.Location = New System.Drawing.Point(27, 370)
        Me.txtRespuestaErronea1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRespuestaErronea1.Name = "txtRespuestaErronea1"
        Me.txtRespuestaErronea1.PlaceholderText = "Digite una respuesta posible..."
        Me.txtRespuestaErronea1.SelectedText = ""
        Me.txtRespuestaErronea1.Size = New System.Drawing.Size(517, 34)
        Me.txtRespuestaErronea1.TabIndex = 19
        '
        'txtRespuestaErronea3
        '
        Me.txtRespuestaErronea3.BackColor = System.Drawing.Color.Transparent
        Me.txtRespuestaErronea3.BorderRadius = 10
        Me.txtRespuestaErronea3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRespuestaErronea3.DefaultText = ""
        Me.txtRespuestaErronea3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRespuestaErronea3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRespuestaErronea3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRespuestaErronea3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRespuestaErronea3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRespuestaErronea3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtRespuestaErronea3.ForeColor = System.Drawing.Color.Black
        Me.txtRespuestaErronea3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRespuestaErronea3.Location = New System.Drawing.Point(27, 412)
        Me.txtRespuestaErronea3.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRespuestaErronea3.Name = "txtRespuestaErronea3"
        Me.txtRespuestaErronea3.PlaceholderText = "Digite una respuesta posible..."
        Me.txtRespuestaErronea3.SelectedText = ""
        Me.txtRespuestaErronea3.Size = New System.Drawing.Size(517, 30)
        Me.txtRespuestaErronea3.TabIndex = 20
        '
        'btnVerPreguntasAlmacenadas
        '
        Me.btnVerPreguntasAlmacenadas.BackColor = System.Drawing.Color.Transparent
        Me.btnVerPreguntasAlmacenadas.BorderRadius = 10
        Me.btnVerPreguntasAlmacenadas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnVerPreguntasAlmacenadas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnVerPreguntasAlmacenadas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnVerPreguntasAlmacenadas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnVerPreguntasAlmacenadas.FillColor = System.Drawing.Color.GreenYellow
        Me.btnVerPreguntasAlmacenadas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVerPreguntasAlmacenadas.ForeColor = System.Drawing.Color.Black
        Me.btnVerPreguntasAlmacenadas.Image = CType(resources.GetObject("btnVerPreguntasAlmacenadas.Image"), System.Drawing.Image)
        Me.btnVerPreguntasAlmacenadas.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnVerPreguntasAlmacenadas.Location = New System.Drawing.Point(334, 831)
        Me.btnVerPreguntasAlmacenadas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVerPreguntasAlmacenadas.Name = "btnVerPreguntasAlmacenadas"
        Me.btnVerPreguntasAlmacenadas.Size = New System.Drawing.Size(222, 38)
        Me.btnVerPreguntasAlmacenadas.TabIndex = 21
        Me.btnVerPreguntasAlmacenadas.Text = "&Verificar almacenadas "
        '
        'btnAgregarPregunta
        '
        Me.btnAgregarPregunta.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarPregunta.BorderRadius = 10
        Me.btnAgregarPregunta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAgregarPregunta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAgregarPregunta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAgregarPregunta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAgregarPregunta.FillColor = System.Drawing.Color.GreenYellow
        Me.btnAgregarPregunta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAgregarPregunta.ForeColor = System.Drawing.Color.Black
        Me.btnAgregarPregunta.Image = CType(resources.GetObject("btnAgregarPregunta.Image"), System.Drawing.Image)
        Me.btnAgregarPregunta.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAgregarPregunta.Location = New System.Drawing.Point(18, 831)
        Me.btnAgregarPregunta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAgregarPregunta.Name = "btnAgregarPregunta"
        Me.btnAgregarPregunta.Size = New System.Drawing.Size(222, 38)
        Me.btnAgregarPregunta.TabIndex = 22
        Me.btnAgregarPregunta.Text = "&Agregar pregunta "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(304, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Indique nombre del cuestionario"
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
        Me.txtNombreCuestionario.Location = New System.Drawing.Point(27, 113)
        Me.txtNombreCuestionario.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreCuestionario.Name = "txtNombreCuestionario"
        Me.txtNombreCuestionario.PlaceholderText = "Nombre del cuestionario..."
        Me.txtNombreCuestionario.SelectedText = ""
        Me.txtNombreCuestionario.Size = New System.Drawing.Size(517, 41)
        Me.txtNombreCuestionario.TabIndex = 24
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
        Me.Guna2Button6.Location = New System.Drawing.Point(11, 10)
        Me.Guna2Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.Size = New System.Drawing.Size(156, 42)
        Me.Guna2Button6.TabIndex = 25
        Me.Guna2Button6.Text = " &Regresar"
        '
        'ABRIR
        '
        Me.ABRIR.Filter = " |*.jpg; *.png; *.jpeg; *.mp4; *.gif"
        Me.ABRIR.Title = "Seleccione un archivo"
        '
        'btnAgregarImagen
        '
        Me.btnAgregarImagen.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarImagen.BorderRadius = 10
        Me.btnAgregarImagen.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAgregarImagen.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAgregarImagen.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAgregarImagen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAgregarImagen.FillColor = System.Drawing.Color.GreenYellow
        Me.btnAgregarImagen.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAgregarImagen.ForeColor = System.Drawing.Color.Black
        Me.btnAgregarImagen.Image = CType(resources.GetObject("btnAgregarImagen.Image"), System.Drawing.Image)
        Me.btnAgregarImagen.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnAgregarImagen.Location = New System.Drawing.Point(334, 777)
        Me.btnAgregarImagen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAgregarImagen.Name = "btnAgregarImagen"
        Me.btnAgregarImagen.Size = New System.Drawing.Size(222, 38)
        Me.btnAgregarImagen.TabIndex = 26
        Me.btnAgregarImagen.Text = "&Agregar imagen"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 466)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(299, 20)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Puntos por respuesta correcta:"
        '
        'txtPuntos
        '
        Me.txtPuntos.BackColor = System.Drawing.Color.Transparent
        Me.txtPuntos.BorderRadius = 10
        Me.txtPuntos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPuntos.DefaultText = ""
        Me.txtPuntos.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPuntos.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPuntos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPuntos.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPuntos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPuntos.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPuntos.ForeColor = System.Drawing.Color.Black
        Me.txtPuntos.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPuntos.Location = New System.Drawing.Point(27, 495)
        Me.txtPuntos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPuntos.Name = "txtPuntos"
        Me.txtPuntos.PlaceholderText = "Digite los puntos..."
        Me.txtPuntos.SelectedText = ""
        Me.txtPuntos.Size = New System.Drawing.Size(158, 38)
        Me.txtPuntos.TabIndex = 29
        '
        'frmPreguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(581, 886)
        Me.Controls.Add(Me.txtPuntos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAgregarImagen)
        Me.Controls.Add(Me.Guna2Button6)
        Me.Controls.Add(Me.txtNombreCuestionario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAgregarPregunta)
        Me.Controls.Add(Me.btnVerPreguntasAlmacenadas)
        Me.Controls.Add(Me.txtRespuestaErronea3)
        Me.Controls.Add(Me.txtRespuestaErronea1)
        Me.Controls.Add(Me.txtRespuestaErronea2)
        Me.Controls.Add(Me.txtRespuestaCorrecta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPreguntaCuestionario)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmPreguntas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form6"
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPreguntaCuestionario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRespuestaCorrecta As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRespuestaErronea2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRespuestaErronea1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRespuestaErronea3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnVerPreguntasAlmacenadas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAgregarPregunta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreCuestionario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ABRIR As OpenFileDialog
    Friend WithEvents btnAgregarImagen As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPuntos As Guna.UI2.WinForms.Guna2TextBox
End Class
