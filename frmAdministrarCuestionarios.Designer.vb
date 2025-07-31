<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdministrarCuestionarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministrarCuestionarios))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btnAgregarCuestionario = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditarCuestionario = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVerCuestionario = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(-7, 195)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1040, 410)
        Me.ListView1.TabIndex = 15
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
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
        Me.btnAgregarCuestionario.Location = New System.Drawing.Point(43, 162)
        Me.btnAgregarCuestionario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAgregarCuestionario.Name = "btnAgregarCuestionario"
        Me.btnAgregarCuestionario.Size = New System.Drawing.Size(129, 52)
        Me.btnAgregarCuestionario.TabIndex = 16
        Me.btnAgregarCuestionario.Text = "Agregar"
        '
        'btnEditarCuestionario
        '
        Me.btnEditarCuestionario.BackColor = System.Drawing.Color.Transparent
        Me.btnEditarCuestionario.BorderRadius = 10
        Me.btnEditarCuestionario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarCuestionario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarCuestionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditarCuestionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditarCuestionario.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnEditarCuestionario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEditarCuestionario.ForeColor = System.Drawing.Color.White
        Me.btnEditarCuestionario.Location = New System.Drawing.Point(190, 162)
        Me.btnEditarCuestionario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditarCuestionario.Name = "btnEditarCuestionario"
        Me.btnEditarCuestionario.Size = New System.Drawing.Size(133, 52)
        Me.btnEditarCuestionario.TabIndex = 17
        Me.btnEditarCuestionario.Text = "Actualizar"
        '
        'btnVerCuestionario
        '
        Me.btnVerCuestionario.BackColor = System.Drawing.Color.Transparent
        Me.btnVerCuestionario.BorderRadius = 10
        Me.btnVerCuestionario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnVerCuestionario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnVerCuestionario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnVerCuestionario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnVerCuestionario.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnVerCuestionario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVerCuestionario.ForeColor = System.Drawing.Color.White
        Me.btnVerCuestionario.Location = New System.Drawing.Point(454, 130)
        Me.btnVerCuestionario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVerCuestionario.Name = "btnVerCuestionario"
        Me.btnVerCuestionario.Size = New System.Drawing.Size(129, 52)
        Me.btnVerCuestionario.TabIndex = 19
        Me.btnVerCuestionario.Text = "Ver"
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
        Me.Guna2Button6.Location = New System.Drawing.Point(-8, 25)
        Me.Guna2Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.Size = New System.Drawing.Size(180, 52)
        Me.Guna2Button6.TabIndex = 22
        Me.Guna2Button6.Text = " &Regresar"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(145, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(888, 52)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "    Administrar cuestionarios"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre / Titulo"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tema "
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "# Preguntas"
        Me.ColumnHeader4.Width = 70
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Tiempo total"
        Me.ColumnHeader5.Width = 70
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Fecha creacion"
        Me.ColumnHeader6.Width = 150
        '
        'frmAdministrarCuestionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(910, 510)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2Button6)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnAgregarCuestionario)
        Me.Controls.Add(Me.btnEditarCuestionario)
        Me.Controls.Add(Me.btnVerCuestionario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmAdministrarCuestionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnAgregarCuestionario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditarCuestionario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVerCuestionario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
End Class
