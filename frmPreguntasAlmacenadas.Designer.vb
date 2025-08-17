<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreguntasAlmacenadas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreguntasAlmacenadas))
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGuardarPreguntas = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.L_PreguntasAlmacenadas = New System.Windows.Forms.ListView()
        Me.ColumnHeader0 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Cuestionario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAgregarCuestionario = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditarRespuestas = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Guna2ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Guna2Button6.Location = New System.Drawing.Point(8, 4)
        Me.Guna2Button6.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.Size = New System.Drawing.Size(105, 34)
        Me.Guna2Button6.TabIndex = 22
        Me.Guna2Button6.Text = "&Regresar"
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
        Me.btnGuardarPreguntas.Location = New System.Drawing.Point(530, 399)
        Me.btnGuardarPreguntas.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardarPreguntas.Name = "btnGuardarPreguntas"
        Me.btnGuardarPreguntas.Size = New System.Drawing.Size(141, 34)
        Me.btnGuardarPreguntas.TabIndex = 23
        Me.btnGuardarPreguntas.Text = "&Guardar preguntas "
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.GreenYellow
        Me.Label4.Font = New System.Drawing.Font("MS PGothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 4)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(686, 34)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Preguntas almacenadas"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'L_PreguntasAlmacenadas
        '
        Me.L_PreguntasAlmacenadas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader0, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader1, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.L_PreguntasAlmacenadas.ContextMenuStrip = Me.Guna2ContextMenuStrip1
        Me.L_PreguntasAlmacenadas.FullRowSelect = True
        Me.L_PreguntasAlmacenadas.GridLines = True
        Me.L_PreguntasAlmacenadas.HideSelection = False
        Me.L_PreguntasAlmacenadas.Location = New System.Drawing.Point(-6, 109)
        Me.L_PreguntasAlmacenadas.Margin = New System.Windows.Forms.Padding(2)
        Me.L_PreguntasAlmacenadas.MultiSelect = False
        Me.L_PreguntasAlmacenadas.Name = "L_PreguntasAlmacenadas"
        Me.L_PreguntasAlmacenadas.Size = New System.Drawing.Size(694, 286)
        Me.L_PreguntasAlmacenadas.TabIndex = 25
        Me.L_PreguntasAlmacenadas.UseCompatibleStateImageBehavior = False
        Me.L_PreguntasAlmacenadas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader0
        '
        Me.ColumnHeader0.Text = "ID_PREGUNTAS"
        Me.ColumnHeader0.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Pregunta"
        Me.ColumnHeader2.Width = 198
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tiempo"
        Me.ColumnHeader4.Width = 110
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Respuestas"
        Me.ColumnHeader5.Width = 228
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Correcta"
        Me.ColumnHeader6.Width = 144
        '
        'Cuestionario
        '
        Me.Cuestionario.AutoSize = True
        Me.Cuestionario.BackColor = System.Drawing.Color.Transparent
        Me.Cuestionario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cuestionario.Location = New System.Drawing.Point(345, 56)
        Me.Cuestionario.Name = "Cuestionario"
        Me.Cuestionario.Size = New System.Drawing.Size(0, 16)
        Me.Cuestionario.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(235, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 16)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Cuestionario"
        '
        'btnAgregarCuestionario
        '
        Me.btnAgregarCuestionario.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarCuestionario.BorderRadius = 10
        Me.btnAgregarCuestionario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAgregarCuestionario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAgregarCuestionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAgregarCuestionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAgregarCuestionario.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnAgregarCuestionario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAgregarCuestionario.ForeColor = System.Drawing.Color.White
        Me.btnAgregarCuestionario.Location = New System.Drawing.Point(37, 71)
        Me.btnAgregarCuestionario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarCuestionario.Name = "btnAgregarCuestionario"
        Me.btnAgregarCuestionario.Size = New System.Drawing.Size(86, 34)
        Me.btnAgregarCuestionario.TabIndex = 40
        Me.btnAgregarCuestionario.Text = "Agregar"
        '
        'btnEditarRespuestas
        '
        Me.btnEditarRespuestas.BackColor = System.Drawing.Color.Transparent
        Me.btnEditarRespuestas.BorderRadius = 10
        Me.btnEditarRespuestas.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarRespuestas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarRespuestas.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditarRespuestas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditarRespuestas.Enabled = False
        Me.btnEditarRespuestas.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnEditarRespuestas.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEditarRespuestas.ForeColor = System.Drawing.Color.White
        Me.btnEditarRespuestas.Location = New System.Drawing.Point(564, 71)
        Me.btnEditarRespuestas.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditarRespuestas.Name = "btnEditarRespuestas"
        Me.btnEditarRespuestas.Size = New System.Drawing.Size(88, 34)
        Me.btnEditarRespuestas.TabIndex = 41
        Me.btnEditarRespuestas.Text = "Actualizar"
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Guna2ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ELIMINAR})
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
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(122, 30)
        '
        'ELIMINAR
        '
        Me.ELIMINAR.Image = CType(resources.GetObject("ELIMINAR.Image"), System.Drawing.Image)
        Me.ELIMINAR.Name = "ELIMINAR"
        Me.ELIMINAR.Size = New System.Drawing.Size(184, 26)
        Me.ELIMINAR.Text = "Eliminar"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID_RESPUESTA"
        Me.ColumnHeader1.Width = 0
        '
        'frmPreguntasAlmacenadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(682, 444)
        Me.Controls.Add(Me.btnAgregarCuestionario)
        Me.Controls.Add(Me.btnEditarRespuestas)
        Me.Controls.Add(Me.Cuestionario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.L_PreguntasAlmacenadas)
        Me.Controls.Add(Me.Guna2Button6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGuardarPreguntas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmPreguntasAlmacenadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        Me.Guna2ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGuardarPreguntas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents L_PreguntasAlmacenadas As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Cuestionario As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ColumnHeader0 As ColumnHeader
    Friend WithEvents btnAgregarCuestionario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditarRespuestas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents ELIMINAR As ToolStripMenuItem
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
