<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdministrarUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdministrarUsuarios))
        Me.L_ADMINUSUARIO = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAgregarUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEditarUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVerUsuario = New Guna.UI2.WinForms.Guna2Button()
        Me.txtFiltrarParticipante = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.ELIMINAR_ADMINUSUARIO = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'L_ADMINUSUARIO
        '
        Me.L_ADMINUSUARIO.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.L_ADMINUSUARIO.FullRowSelect = True
        Me.L_ADMINUSUARIO.GridLines = True
        Me.L_ADMINUSUARIO.HideSelection = False
        Me.L_ADMINUSUARIO.Location = New System.Drawing.Point(-4, 248)
        Me.L_ADMINUSUARIO.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.L_ADMINUSUARIO.MultiSelect = False
        Me.L_ADMINUSUARIO.Name = "L_ADMINUSUARIO"
        Me.L_ADMINUSUARIO.Size = New System.Drawing.Size(1026, 389)
        Me.L_ADMINUSUARIO.TabIndex = 5
        Me.L_ADMINUSUARIO.UseCompatibleStateImageBehavior = False
        Me.L_ADMINUSUARIO.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cedula"
        Me.ColumnHeader2.Width = 220
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nombre"
        Me.ColumnHeader3.Width = 240
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Rol"
        Me.ColumnHeader4.Width = 220
        '
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregarUsuario.BorderRadius = 10
        Me.btnAgregarUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAgregarUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAgregarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAgregarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAgregarUsuario.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnAgregarUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAgregarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnAgregarUsuario.Location = New System.Drawing.Point(37, 178)
        Me.btnAgregarUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(129, 52)
        Me.btnAgregarUsuario.TabIndex = 6
        Me.btnAgregarUsuario.Text = "Agregar"
        '
        'btnEditarUsuario
        '
        Me.btnEditarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.btnEditarUsuario.BorderRadius = 10
        Me.btnEditarUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEditarUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEditarUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEditarUsuario.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnEditarUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEditarUsuario.ForeColor = System.Drawing.Color.White
        Me.btnEditarUsuario.Location = New System.Drawing.Point(191, 178)
        Me.btnEditarUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditarUsuario.Name = "btnEditarUsuario"
        Me.btnEditarUsuario.Size = New System.Drawing.Size(137, 52)
        Me.btnEditarUsuario.TabIndex = 7
        Me.btnEditarUsuario.Text = "Actualizar"
        '
        'btnVerUsuario
        '
        Me.btnVerUsuario.BackColor = System.Drawing.Color.Transparent
        Me.btnVerUsuario.BorderRadius = 10
        Me.btnVerUsuario.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnVerUsuario.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnVerUsuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnVerUsuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnVerUsuario.FillColor = System.Drawing.Color.MidnightBlue
        Me.btnVerUsuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnVerUsuario.ForeColor = System.Drawing.Color.White
        Me.btnVerUsuario.Location = New System.Drawing.Point(366, 178)
        Me.btnVerUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnVerUsuario.Name = "btnVerUsuario"
        Me.btnVerUsuario.Size = New System.Drawing.Size(129, 52)
        Me.btnVerUsuario.TabIndex = 9
        Me.btnVerUsuario.Text = "Ver"
        '
        'txtFiltrarParticipante
        '
        Me.txtFiltrarParticipante.BackColor = System.Drawing.Color.Transparent
        Me.txtFiltrarParticipante.BorderRadius = 10
        Me.txtFiltrarParticipante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltrarParticipante.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFiltrarParticipante.DefaultText = ""
        Me.txtFiltrarParticipante.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFiltrarParticipante.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFiltrarParticipante.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFiltrarParticipante.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFiltrarParticipante.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFiltrarParticipante.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFiltrarParticipante.ForeColor = System.Drawing.Color.Black
        Me.txtFiltrarParticipante.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFiltrarParticipante.Location = New System.Drawing.Point(191, 102)
        Me.txtFiltrarParticipante.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFiltrarParticipante.Name = "txtFiltrarParticipante"
        Me.txtFiltrarParticipante.PlaceholderText = "Digite el nombre del participante..."
        Me.txtFiltrarParticipante.SelectedText = ""
        Me.txtFiltrarParticipante.Size = New System.Drawing.Size(595, 49)
        Me.txtFiltrarParticipante.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("MS PGothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 33)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Búsqueda "
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
        Me.Guna2Button6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button6.Location = New System.Drawing.Point(-4, 12)
        Me.Guna2Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.Size = New System.Drawing.Size(204, 52)
        Me.Guna2Button6.TabIndex = 14
        Me.Guna2Button6.Text = "    &Regresar    "
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(184, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(849, 52)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "    Administrar usuarios"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Guna2ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ELIMINAR_ADMINUSUARIO})
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
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(151, 36)
        '
        'ELIMINAR_ADMINUSUARIO
        '
        Me.ELIMINAR_ADMINUSUARIO.Image = CType(resources.GetObject("ELIMINAR_ADMINUSUARIO.Image"), System.Drawing.Image)
        Me.ELIMINAR_ADMINUSUARIO.Name = "ELIMINAR_ADMINUSUARIO"
        Me.ELIMINAR_ADMINUSUARIO.Size = New System.Drawing.Size(150, 32)
        Me.ELIMINAR_ADMINUSUARIO.Text = "Eliminar"
        '
        'frmAdministrarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1022, 638)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2Button6)
        Me.Controls.Add(Me.txtFiltrarParticipante)
        Me.Controls.Add(Me.L_ADMINUSUARIO)
        Me.Controls.Add(Me.btnAgregarUsuario)
        Me.Controls.Add(Me.btnEditarUsuario)
        Me.Controls.Add(Me.btnVerUsuario)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmAdministrarUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Guna2ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents L_ADMINUSUARIO As ListView
    Friend WithEvents btnAgregarUsuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditarUsuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVerUsuario As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtFiltrarParticipante As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents ELIMINAR_ADMINUSUARIO As ToolStripMenuItem
End Class
