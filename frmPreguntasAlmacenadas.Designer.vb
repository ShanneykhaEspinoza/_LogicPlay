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
        Me.listaPreguntasAlmacenadas = New System.Windows.Forms.ListView()
        Me.btnEliminarPregunta = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGuardarPreguntas = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Guna2Button6.Location = New System.Drawing.Point(11, 5)
        Me.Guna2Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.Size = New System.Drawing.Size(125, 42)
        Me.Guna2Button6.TabIndex = 22
        Me.Guna2Button6.Text = "&Regresar"
        '
        'listaPreguntasAlmacenadas
        '
        Me.listaPreguntasAlmacenadas.HideSelection = False
        Me.listaPreguntasAlmacenadas.Location = New System.Drawing.Point(2, 80)
        Me.listaPreguntasAlmacenadas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.listaPreguntasAlmacenadas.Name = "listaPreguntasAlmacenadas"
        Me.listaPreguntasAlmacenadas.Size = New System.Drawing.Size(906, 329)
        Me.listaPreguntasAlmacenadas.TabIndex = 15
        Me.listaPreguntasAlmacenadas.UseCompatibleStateImageBehavior = False
        '
        'btnEliminarPregunta
        '
        Me.btnEliminarPregunta.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminarPregunta.BorderRadius = 10
        Me.btnEliminarPregunta.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEliminarPregunta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEliminarPregunta.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEliminarPregunta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEliminarPregunta.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnEliminarPregunta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEliminarPregunta.ForeColor = System.Drawing.Color.White
        Me.btnEliminarPregunta.Image = CType(resources.GetObject("btnEliminarPregunta.Image"), System.Drawing.Image)
        Me.btnEliminarPregunta.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnEliminarPregunta.Location = New System.Drawing.Point(723, 429)
        Me.btnEliminarPregunta.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminarPregunta.Name = "btnEliminarPregunta"
        Me.btnEliminarPregunta.Size = New System.Drawing.Size(177, 42)
        Me.btnEliminarPregunta.TabIndex = 18
        Me.btnEliminarPregunta.Text = "&Eliminar pregunta   "
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
        Me.btnGuardarPreguntas.Location = New System.Drawing.Point(521, 429)
        Me.btnGuardarPreguntas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGuardarPreguntas.Name = "btnGuardarPreguntas"
        Me.btnGuardarPreguntas.Size = New System.Drawing.Size(188, 42)
        Me.btnGuardarPreguntas.TabIndex = 23
        Me.btnGuardarPreguntas.Text = "&Guardar preguntas "
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.GreenYellow
        Me.Label4.Font = New System.Drawing.Font("MS PGothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(915, 42)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Preguntas almacenadas"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPreguntasAlmacenadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(910, 484)
        Me.Controls.Add(Me.Guna2Button6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGuardarPreguntas)
        Me.Controls.Add(Me.listaPreguntasAlmacenadas)
        Me.Controls.Add(Me.btnEliminarPregunta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmPreguntasAlmacenadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents listaPreguntasAlmacenadas As ListView
    Friend WithEvents btnEliminarPregunta As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGuardarPreguntas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
End Class
