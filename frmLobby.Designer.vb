<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLobby
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLobby))
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnIniciarPartida = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCodigo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.listaUsuariosUnidosAPartida = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnTerminar = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Guna2CirclePictureBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox2.Image = CType(resources.GetObject("Guna2CirclePictureBox2.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox2.ImageRotate = 0!
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(8, -1)
        Me.Guna2CirclePictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(57, 47)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox2.TabIndex = 16
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Cornsilk
        Me.Label4.Location = New System.Drawing.Point(-1, -1)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(412, 47)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Código"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnIniciarPartida
        '
        Me.btnIniciarPartida.BackColor = System.Drawing.Color.Transparent
        Me.btnIniciarPartida.BorderRadius = 10
        Me.btnIniciarPartida.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnIniciarPartida.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnIniciarPartida.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnIniciarPartida.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnIniciarPartida.FillColor = System.Drawing.Color.GreenYellow
        Me.btnIniciarPartida.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.btnIniciarPartida.ForeColor = System.Drawing.Color.Black
        Me.btnIniciarPartida.Image = CType(resources.GetObject("btnIniciarPartida.Image"), System.Drawing.Image)
        Me.btnIniciarPartida.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnIniciarPartida.ImageSize = New System.Drawing.Size(60, 60)
        Me.btnIniciarPartida.Location = New System.Drawing.Point(110, 353)
        Me.btnIniciarPartida.Margin = New System.Windows.Forms.Padding(2)
        Me.btnIniciarPartida.Name = "btnIniciarPartida"
        Me.btnIniciarPartida.Size = New System.Drawing.Size(204, 42)
        Me.btnIniciarPartida.TabIndex = 17
        Me.btnIniciarPartida.Text = "&Iniciar"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.Transparent
        Me.txtCodigo.BorderRadius = 7
        Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigo.DefaultText = ""
        Me.txtCodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(86, 57)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.PlaceholderText = ""
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.SelectedText = ""
        Me.txtCodigo.Size = New System.Drawing.Size(248, 63)
        Me.txtCodigo.TabIndex = 18
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'listaUsuariosUnidosAPartida
        '
        Me.listaUsuariosUnidosAPartida.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.listaUsuariosUnidosAPartida.FullRowSelect = True
        Me.listaUsuariosUnidosAPartida.GridLines = True
        Me.listaUsuariosUnidosAPartida.HideSelection = False
        Me.listaUsuariosUnidosAPartida.Location = New System.Drawing.Point(9, 152)
        Me.listaUsuariosUnidosAPartida.Margin = New System.Windows.Forms.Padding(2)
        Me.listaUsuariosUnidosAPartida.Name = "listaUsuariosUnidosAPartida"
        Me.listaUsuariosUnidosAPartida.Size = New System.Drawing.Size(390, 191)
        Me.listaUsuariosUnidosAPartida.TabIndex = 25
        Me.listaUsuariosUnidosAPartida.UseCompatibleStateImageBehavior = False
        Me.listaUsuariosUnidosAPartida.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Usuarios"
        Me.ColumnHeader2.Width = 204
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("MS PGothic", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 122)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 22)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Usuarios en sala:"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.MidnightBlue
        Me.Guna2Button1.FocusedColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.Location = New System.Drawing.Point(284, 7)
        Me.Guna2Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(114, 39)
        Me.Guna2Button1.TabIndex = 27
        Me.Guna2Button1.Text = "&Regresar"
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Puntos"
        Me.ColumnHeader3.Width = 182
        '
        'btnTerminar
        '
        Me.btnTerminar.BackColor = System.Drawing.Color.Transparent
        Me.btnTerminar.BorderRadius = 10
        Me.btnTerminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnTerminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnTerminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnTerminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnTerminar.FillColor = System.Drawing.Color.Pink
        Me.btnTerminar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminar.ForeColor = System.Drawing.Color.Black
        Me.btnTerminar.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnTerminar.ImageSize = New System.Drawing.Size(60, 60)
        Me.btnTerminar.Location = New System.Drawing.Point(318, 377)
        Me.btnTerminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(87, 30)
        Me.btnTerminar.TabIndex = 28
        Me.btnTerminar.Text = "&Terminar"
        Me.btnTerminar.Visible = False
        '
        'frmLobby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(410, 418)
        Me.Controls.Add(Me.btnTerminar)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.listaUsuariosUnidosAPartida)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.btnIniciarPartida)
        Me.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmLobby"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form9"
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnIniciarPartida As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCodigo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents listaUsuariosUnidosAPartida As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents btnTerminar As Guna.UI2.WinForms.Guna2Button
End Class
