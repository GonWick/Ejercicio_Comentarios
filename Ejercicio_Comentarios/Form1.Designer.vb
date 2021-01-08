<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxOrganizacion = New System.Windows.Forms.TextBox()
        Me.TextBoxComentarios = New System.Windows.Forms.TextBox()
        Me.ButtonEnviar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelOrganizacion = New System.Windows.Forms.Label()
        Me.LabelComentarios = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(117, 25)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNombre.TabIndex = 0
        '
        'TextBoxOrganizacion
        '
        Me.TextBoxOrganizacion.Location = New System.Drawing.Point(117, 71)
        Me.TextBoxOrganizacion.Name = "TextBoxOrganizacion"
        Me.TextBoxOrganizacion.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxOrganizacion.TabIndex = 1
        '
        'TextBoxComentarios
        '
        Me.TextBoxComentarios.Location = New System.Drawing.Point(117, 114)
        Me.TextBoxComentarios.Multiline = True
        Me.TextBoxComentarios.Name = "TextBoxComentarios"
        Me.TextBoxComentarios.Size = New System.Drawing.Size(227, 114)
        Me.TextBoxComentarios.TabIndex = 2
        '
        'ButtonEnviar
        '
        Me.ButtonEnviar.Location = New System.Drawing.Point(269, 23)
        Me.ButtonEnviar.Name = "ButtonEnviar"
        Me.ButtonEnviar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEnviar.TabIndex = 3
        Me.ButtonEnviar.Text = "Enviar Mensaje"
        Me.ButtonEnviar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(426, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Location = New System.Drawing.Point(22, 28)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(54, 13)
        Me.LabelNombre.TabIndex = 5
        Me.LabelNombre.Text = "NOMBRE"
        '
        'LabelOrganizacion
        '
        Me.LabelOrganizacion.AutoSize = True
        Me.LabelOrganizacion.Location = New System.Drawing.Point(22, 71)
        Me.LabelOrganizacion.Name = "LabelOrganizacion"
        Me.LabelOrganizacion.Size = New System.Drawing.Size(89, 13)
        Me.LabelOrganizacion.TabIndex = 6
        Me.LabelOrganizacion.Text = "ORGANIZACIÓN"
        '
        'LabelComentarios
        '
        Me.LabelComentarios.AutoSize = True
        Me.LabelComentarios.Location = New System.Drawing.Point(22, 114)
        Me.LabelComentarios.Name = "LabelComentarios"
        Me.LabelComentarios.Size = New System.Drawing.Size(86, 13)
        Me.LabelComentarios.TabIndex = 7
        Me.LabelComentarios.Text = "COMENTARIOS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 241)
        Me.Controls.Add(Me.LabelComentarios)
        Me.Controls.Add(Me.LabelOrganizacion)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonEnviar)
        Me.Controls.Add(Me.TextBoxComentarios)
        Me.Controls.Add(Me.TextBoxOrganizacion)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxOrganizacion As TextBox
    Friend WithEvents TextBoxComentarios As TextBox
    Friend WithEvents ButtonEnviar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelNombre As Label
    Friend WithEvents LabelOrganizacion As Label
    Friend WithEvents LabelComentarios As Label
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
