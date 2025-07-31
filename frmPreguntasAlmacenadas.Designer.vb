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
        Me.listaPreguntasAlmacenadas = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.btnGuardarPreguntas.Location = New System.Drawing.Point(710, 431)
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
        'listaPreguntasAlmacenadas
        '
        Me.listaPreguntasAlmacenadas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.listaPreguntasAlmacenadas.FullRowSelect = True
        Me.listaPreguntasAlmacenadas.GridLines = True
        Me.listaPreguntasAlmacenadas.HideSelection = False
        Me.listaPreguntasAlmacenadas.Location = New System.Drawing.Point(-4, 77)
        Me.listaPreguntasAlmacenadas.MultiSelect = False
        Me.listaPreguntasAlmacenadas.Name = "listaPreguntasAlmacenadas"
        Me.listaPreguntasAlmacenadas.Size = New System.Drawing.Size(921, 349)
        Me.listaPreguntasAlmacenadas.TabIndex = 25
        Me.listaPreguntasAlmacenadas.UseCompatibleStateImageBehavior = False
        Me.listaPreguntasAlmacenadas.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Pregunta"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tema"
        Me.ColumnHeader3.Width = 120
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Tiempo"
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Respuestas"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Correcta"
        Me.ColumnHeader6.Width = 150
        '
        'frmPreguntasAlmacenadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(910, 484)
        Me.Controls.Add(Me.listaPreguntasAlmacenadas)
        Me.Controls.Add(Me.Guna2Button6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnGuardarPreguntas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmPreguntasAlmacenadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGuardarPreguntas As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents listaPreguntasAlmacenadas As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
End Class
