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
        Me.components = New System.ComponentModel.Container()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxOrganizacion = New System.Windows.Forms.TextBox()
        Me.TextBoxComentarios = New System.Windows.Forms.TextBox()
        Me.ButtonEnviar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrganizacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComentariosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComentariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EjercicioComentariosDataSet = New Ejercicio_Comentarios.EjercicioComentariosDataSet()
        Me.LabelNombre = New System.Windows.Forms.Label()
        Me.LabelOrganizacion = New System.Windows.Forms.Label()
        Me.LabelComentarios = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ComentariosTableAdapter = New Ejercicio_Comentarios.EjercicioComentariosDataSetTableAdapters.ComentariosTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComentariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EjercicioComentariosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TextBoxComentarios.Location = New System.Drawing.Point(241, 49)
        Me.TextBoxComentarios.Multiline = True
        Me.TextBoxComentarios.Name = "TextBoxComentarios"
        Me.TextBoxComentarios.Size = New System.Drawing.Size(227, 42)
        Me.TextBoxComentarios.TabIndex = 2
        '
        'ButtonEnviar
        '
        Me.ButtonEnviar.Location = New System.Drawing.Point(393, 23)
        Me.ButtonEnviar.Name = "ButtonEnviar"
        Me.ButtonEnviar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEnviar.TabIndex = 3
        Me.ButtonEnviar.Text = "Enviar Mensaje"
        Me.ButtonEnviar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.OrganizacionDataGridViewTextBoxColumn, Me.ComentariosDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ComentariosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 108)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(453, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrganizacionDataGridViewTextBoxColumn
        '
        Me.OrganizacionDataGridViewTextBoxColumn.DataPropertyName = "Organizacion"
        Me.OrganizacionDataGridViewTextBoxColumn.HeaderText = "Organizacion"
        Me.OrganizacionDataGridViewTextBoxColumn.Name = "OrganizacionDataGridViewTextBoxColumn"
        Me.OrganizacionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComentariosDataGridViewTextBoxColumn
        '
        Me.ComentariosDataGridViewTextBoxColumn.DataPropertyName = "Comentarios"
        Me.ComentariosDataGridViewTextBoxColumn.HeaderText = "Comentarios"
        Me.ComentariosDataGridViewTextBoxColumn.Name = "ComentariosDataGridViewTextBoxColumn"
        Me.ComentariosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComentariosBindingSource
        '
        Me.ComentariosBindingSource.DataMember = "Comentarios"
        Me.ComentariosBindingSource.DataSource = Me.EjercicioComentariosDataSet
        '
        'EjercicioComentariosDataSet
        '
        Me.EjercicioComentariosDataSet.DataSetName = "EjercicioComentariosDataSet"
        Me.EjercicioComentariosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelNombre
        '
        Me.LabelNombre.AutoSize = True
        Me.LabelNombre.Location = New System.Drawing.Point(12, 28)
        Me.LabelNombre.Name = "LabelNombre"
        Me.LabelNombre.Size = New System.Drawing.Size(54, 13)
        Me.LabelNombre.TabIndex = 5
        Me.LabelNombre.Text = "NOMBRE"
        '
        'LabelOrganizacion
        '
        Me.LabelOrganizacion.AutoSize = True
        Me.LabelOrganizacion.Location = New System.Drawing.Point(12, 71)
        Me.LabelOrganizacion.Name = "LabelOrganizacion"
        Me.LabelOrganizacion.Size = New System.Drawing.Size(89, 13)
        Me.LabelOrganizacion.TabIndex = 6
        Me.LabelOrganizacion.Text = "ORGANIZACIÓN"
        '
        'LabelComentarios
        '
        Me.LabelComentarios.AutoSize = True
        Me.LabelComentarios.Location = New System.Drawing.Point(238, 28)
        Me.LabelComentarios.Name = "LabelComentarios"
        Me.LabelComentarios.Size = New System.Drawing.Size(86, 13)
        Me.LabelComentarios.TabIndex = 7
        Me.LabelComentarios.Text = "COMENTARIOS"
        '
        'ComentariosTableAdapter
        '
        Me.ComentariosTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(348, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Color"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 270)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelComentarios)
        Me.Controls.Add(Me.LabelOrganizacion)
        Me.Controls.Add(Me.LabelNombre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonEnviar)
        Me.Controls.Add(Me.TextBoxComentarios)
        Me.Controls.Add(Me.TextBoxOrganizacion)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Name = "Form1"
        Me.Text = "ERCICIO CONTROLES BASICOS 13_01_2021"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComentariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EjercicioComentariosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents EjercicioComentariosDataSet As EjercicioComentariosDataSet
    Friend WithEvents ComentariosBindingSource As BindingSource
    Friend WithEvents ComentariosTableAdapter As EjercicioComentariosDataSetTableAdapters.ComentariosTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrganizacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ComentariosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
