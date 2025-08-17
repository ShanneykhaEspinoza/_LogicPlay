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
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBuscar = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregarCuestionario = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditarCuestionario = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVerCuestionario = New Guna.UI2.WinForms.Guna2Button()
        Me.L_ADMINCUESTIONARIO = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.ELIMINAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Guna2Button6.ForeColor = System.Drawing.Color.GhostWhite
        Me.Guna2Button6.Image = CType(resources.GetObject("Guna2Button6.Image"), System.Drawing.Image)
        Me.Guna2Button6.Location = New System.Drawing.Point(-1, -3)
        Me.Guna2Button6.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.Size = New System.Drawing.Size(96, 34)
        Me.Guna2Button6.TabIndex = 22
        Me.Guna2Button6.Text = " &Regresar"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(-5, -3)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(693, 34)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "    Administrar cuestionarios"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.Transparent
        Me.txtBuscar.BorderRadius = 10
        Me.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscar.DefaultText = ""
        Me.txtBuscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBuscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBuscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscar.ForeColor = System.Drawing.Color.Black
        Me.txtBuscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscar.Location = New System.Drawing.Point(158, 70)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.PlaceholderText = "Digite el nombre del participante..."
        Me.txtBuscar.SelectedText = ""
        Me.txtBuscar.Size = New System.Drawing.Size(360, 32)
        Me.txtBuscar.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS PGothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(285, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 22)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Búsqueda "
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
        Me.btnAgregarCuestionario.Location = New System.Drawing.Point(158, 117)
        Me.btnAgregarCuestionario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarCuestionario.Name = "btnAgregarCuestionario"
        Me.btnAgregarCuestionario.Size = New System.Drawing.Size(86, 34)
        Me.btnAgregarCuestionario.TabIndex = 30
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
        Me.btnEditarCuestionario.Location = New System.Drawing.Point(298, 117)
        Me.btnEditarCuestionario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEditarCuestionario.Name = "btnEditarCuestionario"
        Me.btnEditarCuestionario.Size = New System.Drawing.Size(88, 34)
        Me.btnEditarCuestionario.TabIndex = 31
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
        Me.btnVerCuestionario.Location = New System.Drawing.Point(432, 117)
        Me.btnVerCuestionario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVerCuestionario.Name = "btnVerCuestionario"
        Me.btnVerCuestionario.Size = New System.Drawing.Size(86, 34)
        Me.btnVerCuestionario.TabIndex = 32
        Me.btnVerCuestionario.Text = "Ver"
        '
        'L_ADMINCUESTIONARIO
        '
        Me.L_ADMINCUESTIONARIO.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader6})
        Me.L_ADMINCUESTIONARIO.ContextMenuStrip = Me.Guna2ContextMenuStrip1
        Me.L_ADMINCUESTIONARIO.FullRowSelect = True
        Me.L_ADMINCUESTIONARIO.GridLines = True
        Me.L_ADMINCUESTIONARIO.HideSelection = False
        Me.L_ADMINCUESTIONARIO.LabelEdit = True
        Me.L_ADMINCUESTIONARIO.Location = New System.Drawing.Point(-1, 164)
        Me.L_ADMINCUESTIONARIO.Margin = New System.Windows.Forms.Padding(2)
        Me.L_ADMINCUESTIONARIO.MultiSelect = False
        Me.L_ADMINCUESTIONARIO.Name = "L_ADMINCUESTIONARIO"
        Me.L_ADMINCUESTIONARIO.Size = New System.Drawing.Size(689, 241)
        Me.L_ADMINCUESTIONARIO.TabIndex = 35
        Me.L_ADMINCUESTIONARIO.UseCompatibleStateImageBehavior = False
        Me.L_ADMINCUESTIONARIO.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nombre / Titulo"
        Me.ColumnHeader2.Width = 323
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "# Preguntas"
        Me.ColumnHeader4.Width = 212
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Fecha creacion"
        Me.ColumnHeader6.Width = 150
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
        Me.ELIMINAR.Size = New System.Drawing.Size(121, 26)
        Me.ELIMINAR.Text = "Eliminar"
        '
        'frmAdministrarCuestionarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(688, 406)
        Me.Controls.Add(Me.L_ADMINCUESTIONARIO)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAgregarCuestionario)
        Me.Controls.Add(Me.btnEditarCuestionario)
        Me.Controls.Add(Me.btnVerCuestionario)
        Me.Controls.Add(Me.Guna2Button6)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.Name = "frmAdministrarCuestionarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form5"
        Me.Guna2ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBuscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregarCuestionario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditarCuestionario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVerCuestionario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents L_ADMINCUESTIONARIO As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents ELIMINAR As ToolStripMenuItem
End Class
