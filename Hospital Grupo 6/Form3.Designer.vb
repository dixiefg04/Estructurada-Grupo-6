<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim ID_CONSULTALabel As System.Windows.Forms.Label
        Dim DPI_PACIENTELabel As System.Windows.Forms.Label
        Dim ID_EMPLEADOLabel As System.Windows.Forms.Label
        Dim PadecimientoLabel As System.Windows.Forms.Label
        Dim Estado_ConsultaLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReporte = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ID_CONSULTATextBox = New System.Windows.Forms.TextBox()
        Me.DPI_PACIENTETextBox = New System.Windows.Forms.TextBox()
        Me.ID_EMPLEADOTextBox = New System.Windows.Forms.TextBox()
        Me.PadecimientoTextBox = New System.Windows.Forms.TextBox()
        Me.Estado_ConsultaTextBox = New System.Windows.Forms.TextBox()
        Me.ConsultaDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        ID_CONSULTALabel = New System.Windows.Forms.Label()
        DPI_PACIENTELabel = New System.Windows.Forms.Label()
        ID_EMPLEADOLabel = New System.Windows.Forms.Label()
        PadecimientoLabel = New System.Windows.Forms.Label()
        Estado_ConsultaLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.ConsultaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(436, 211)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(553, 60)
        Me.Panel1.TabIndex = 115
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(19, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(486, 35)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Area de Registro de Consultas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnReporte
        '
        Me.btnReporte.BackColor = System.Drawing.Color.Yellow
        Me.btnReporte.FlatAppearance.BorderSize = 0
        Me.btnReporte.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReporte.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReporte.ForeColor = System.Drawing.Color.Black
        Me.btnReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReporte.Location = New System.Drawing.Point(185, 517)
        Me.btnReporte.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReporte.Name = "btnReporte"
        Me.btnReporte.Size = New System.Drawing.Size(152, 36)
        Me.btnReporte.TabIndex = 114
        Me.btnReporte.Text = "Ver Reporte"
        Me.btnReporte.UseVisualStyleBackColor = False
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.Color.Yellow
        Me.btnMostrar.FlatAppearance.BorderSize = 0
        Me.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.ForeColor = System.Drawing.Color.Black
        Me.btnMostrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMostrar.Location = New System.Drawing.Point(18, 517)
        Me.btnMostrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(119, 36)
        Me.btnMostrar.TabIndex = 113
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Yellow
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(185, 446)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(119, 36)
        Me.btnBuscar.TabIndex = 112
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Yellow
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(18, 446)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(119, 36)
        Me.btnEliminar.TabIndex = 111
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Yellow
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.Black
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(185, 391)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(119, 36)
        Me.btnModificar.TabIndex = 110
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Yellow
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(18, 391)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(119, 36)
        Me.btnAgregar.TabIndex = 109
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(174, 94)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 26)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "Verbena Hospital" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ID_CONSULTALabel
        '
        ID_CONSULTALabel.AutoSize = True
        ID_CONSULTALabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ID_CONSULTALabel.Location = New System.Drawing.Point(8, 211)
        ID_CONSULTALabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ID_CONSULTALabel.Name = "ID_CONSULTALabel"
        ID_CONSULTALabel.Size = New System.Drawing.Size(99, 16)
        ID_CONSULTALabel.TabIndex = 93
        ID_CONSULTALabel.Text = "ID CONSULTA:"
        '
        'ID_CONSULTATextBox
        '
        Me.ID_CONSULTATextBox.Location = New System.Drawing.Point(132, 208)
        Me.ID_CONSULTATextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ID_CONSULTATextBox.Name = "ID_CONSULTATextBox"
        Me.ID_CONSULTATextBox.Size = New System.Drawing.Size(265, 22)
        Me.ID_CONSULTATextBox.TabIndex = 94
        '
        'DPI_PACIENTELabel
        '
        DPI_PACIENTELabel.AutoSize = True
        DPI_PACIENTELabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DPI_PACIENTELabel.Location = New System.Drawing.Point(8, 243)
        DPI_PACIENTELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DPI_PACIENTELabel.Name = "DPI_PACIENTELabel"
        DPI_PACIENTELabel.Size = New System.Drawing.Size(102, 16)
        DPI_PACIENTELabel.TabIndex = 95
        DPI_PACIENTELabel.Text = "DPI PACIENTE:"
        '
        'DPI_PACIENTETextBox
        '
        Me.DPI_PACIENTETextBox.Location = New System.Drawing.Point(132, 240)
        Me.DPI_PACIENTETextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DPI_PACIENTETextBox.Name = "DPI_PACIENTETextBox"
        Me.DPI_PACIENTETextBox.Size = New System.Drawing.Size(265, 22)
        Me.DPI_PACIENTETextBox.TabIndex = 96
        '
        'ID_EMPLEADOLabel
        '
        ID_EMPLEADOLabel.AutoSize = True
        ID_EMPLEADOLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        ID_EMPLEADOLabel.Location = New System.Drawing.Point(8, 275)
        ID_EMPLEADOLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ID_EMPLEADOLabel.Name = "ID_EMPLEADOLabel"
        ID_EMPLEADOLabel.Size = New System.Drawing.Size(100, 16)
        ID_EMPLEADOLabel.TabIndex = 97
        ID_EMPLEADOLabel.Text = "ID EMPLEADO:"
        '
        'ID_EMPLEADOTextBox
        '
        Me.ID_EMPLEADOTextBox.Location = New System.Drawing.Point(132, 272)
        Me.ID_EMPLEADOTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ID_EMPLEADOTextBox.Name = "ID_EMPLEADOTextBox"
        Me.ID_EMPLEADOTextBox.Size = New System.Drawing.Size(265, 22)
        Me.ID_EMPLEADOTextBox.TabIndex = 98
        '
        'PadecimientoLabel
        '
        PadecimientoLabel.AutoSize = True
        PadecimientoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        PadecimientoLabel.Location = New System.Drawing.Point(9, 304)
        PadecimientoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PadecimientoLabel.Name = "PadecimientoLabel"
        PadecimientoLabel.Size = New System.Drawing.Size(93, 16)
        PadecimientoLabel.TabIndex = 103
        PadecimientoLabel.Text = "Padecimiento:"
        '
        'PadecimientoTextBox
        '
        Me.PadecimientoTextBox.Location = New System.Drawing.Point(133, 301)
        Me.PadecimientoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PadecimientoTextBox.Name = "PadecimientoTextBox"
        Me.PadecimientoTextBox.Size = New System.Drawing.Size(265, 22)
        Me.PadecimientoTextBox.TabIndex = 104
        '
        'Estado_ConsultaLabel
        '
        Estado_ConsultaLabel.AutoSize = True
        Estado_ConsultaLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Estado_ConsultaLabel.Location = New System.Drawing.Point(9, 336)
        Estado_ConsultaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Estado_ConsultaLabel.Name = "Estado_ConsultaLabel"
        Estado_ConsultaLabel.Size = New System.Drawing.Size(108, 16)
        Estado_ConsultaLabel.TabIndex = 105
        Estado_ConsultaLabel.Text = "Estado Consulta:"
        '
        'Estado_ConsultaTextBox
        '
        Me.Estado_ConsultaTextBox.Location = New System.Drawing.Point(133, 333)
        Me.Estado_ConsultaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Estado_ConsultaTextBox.Name = "Estado_ConsultaTextBox"
        Me.Estado_ConsultaTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Estado_ConsultaTextBox.TabIndex = 106
        '
        'ConsultaDataGridView
        '
        Me.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsultaDataGridView.Location = New System.Drawing.Point(423, 304)
        Me.ConsultaDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.ConsultaDataGridView.Name = "ConsultaDataGridView"
        Me.ConsultaDataGridView.RowHeadersWidth = 51
        Me.ConsultaDataGridView.Size = New System.Drawing.Size(725, 271)
        Me.ConsultaDataGridView.TabIndex = 92
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 26)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "X" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(627, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 30)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Bienvenido a la sección de Consultas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1183, 640)
        Me.Panel2.TabIndex = 117
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Hospital_Grupo_6.My.Resources.Resources.consulta
        Me.PictureBox1.Location = New System.Drawing.Point(470, 29)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 138)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Hospital_Grupo_6.My.Resources.Resources.pngegg
        Me.PictureBox2.Location = New System.Drawing.Point(58, 55)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(99, 96)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 107
        Me.PictureBox2.TabStop = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 648)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnReporte)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(ID_CONSULTALabel)
        Me.Controls.Add(Me.ID_CONSULTATextBox)
        Me.Controls.Add(DPI_PACIENTELabel)
        Me.Controls.Add(Me.DPI_PACIENTETextBox)
        Me.Controls.Add(ID_EMPLEADOLabel)
        Me.Controls.Add(Me.ID_EMPLEADOTextBox)
        Me.Controls.Add(PadecimientoLabel)
        Me.Controls.Add(Me.PadecimientoTextBox)
        Me.Controls.Add(Estado_ConsultaLabel)
        Me.Controls.Add(Me.Estado_ConsultaTextBox)
        Me.Controls.Add(Me.ConsultaDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ConsultaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Private WithEvents btnReporte As Button
    Private WithEvents btnMostrar As Button
    Private WithEvents btnBuscar As Button
    Private WithEvents btnEliminar As Button
    Private WithEvents btnModificar As Button
    Private WithEvents btnAgregar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ID_CONSULTATextBox As TextBox
    Friend WithEvents DPI_PACIENTETextBox As TextBox
    Friend WithEvents ID_EMPLEADOTextBox As TextBox
    Friend WithEvents PadecimientoTextBox As TextBox
    Friend WithEvents Estado_ConsultaTextBox As TextBox
    Friend WithEvents ConsultaDataGridView As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
End Class
