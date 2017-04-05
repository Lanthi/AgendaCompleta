<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DomicilioLabel As System.Windows.Forms.Label
        Dim NumIDLabel As System.Windows.Forms.Label
        Dim NombreLabel1 As System.Windows.Forms.Label
        Dim DomicilioLabel1 As System.Windows.Forms.Label
        Dim TelLabel As System.Windows.Forms.Label
        Dim ProxCitaLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim NumIDLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim NombreLabel2 As System.Windows.Forms.Label
        Dim BirthDateLabel As System.Windows.Forms.Label
        Dim DomicilioLabel2 As System.Windows.Forms.Label
        Dim TelLabel1 As System.Windows.Forms.Label
        Dim ObservacionesLabel1 As System.Windows.Forms.Label
        Dim NumIDLabel2 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Me.CONSULV4DataSet = New WindowsApplication3.CONSULV4DataSet()
        Me.IdentificacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdentificacionTableAdapter = New WindowsApplication3.CONSULV4DataSetTableAdapters.IdentificacionTableAdapter()
        Me.TableAdapterManager = New WindowsApplication3.CONSULV4DataSetTableAdapters.TableAdapterManager()
        Me.IdentificacionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IdentificacionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.LblSelec = New System.Windows.Forms.Label()
        Me.NombreTextBox1 = New System.Windows.Forms.TextBox()
        Me.DomicilioTextBox = New System.Windows.Forms.TextBox()
        Me.NumIDTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.NumIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.ObservacionesTextBox = New System.Windows.Forms.TextBox()
        Me.ProxCitaTextBox = New System.Windows.Forms.TextBox()
        Me.TelTextBox = New System.Windows.Forms.TextBox()
        Me.DomicilioTextBox1 = New System.Windows.Forms.TextBox()
        Me.NombreTextBox2 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TreeView5 = New System.Windows.Forms.TreeView()
        Me.TreeView4 = New System.Windows.Forms.TreeView()
        Me.TreeView3 = New System.Windows.Forms.TreeView()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.HistoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HistoriasTableAdapter = New WindowsApplication3.CONSULV4DataSetTableAdapters.HistoriasTableAdapter()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FisioterapeutasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.NombreTextBox3 = New System.Windows.Forms.TextBox()
        Me.BirthDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DomicilioTextBox2 = New System.Windows.Forms.TextBox()
        Me.TelTextBox1 = New System.Windows.Forms.TextBox()
        Me.ObservacionesTextBox1 = New System.Windows.Forms.TextBox()
        Me.NumIDTextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        NombreLabel = New System.Windows.Forms.Label()
        DomicilioLabel = New System.Windows.Forms.Label()
        NumIDLabel = New System.Windows.Forms.Label()
        NombreLabel1 = New System.Windows.Forms.Label()
        DomicilioLabel1 = New System.Windows.Forms.Label()
        TelLabel = New System.Windows.Forms.Label()
        ProxCitaLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        NumIDLabel1 = New System.Windows.Forms.Label()
        NombreLabel2 = New System.Windows.Forms.Label()
        BirthDateLabel = New System.Windows.Forms.Label()
        DomicilioLabel2 = New System.Windows.Forms.Label()
        TelLabel1 = New System.Windows.Forms.Label()
        ObservacionesLabel1 = New System.Windows.Forms.Label()
        NumIDLabel2 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.CONSULV4DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdentificacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IdentificacionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.IdentificacionBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.HistoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(23, 36)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(47, 13)
        NombreLabel.TabIndex = 8
        NombreLabel.Text = "Nombre:"
        '
        'DomicilioLabel
        '
        DomicilioLabel.AutoSize = True
        DomicilioLabel.Location = New System.Drawing.Point(18, 62)
        DomicilioLabel.Name = "DomicilioLabel"
        DomicilioLabel.Size = New System.Drawing.Size(52, 13)
        DomicilioLabel.TabIndex = 9
        DomicilioLabel.Text = "Domicilio:"
        '
        'NumIDLabel
        '
        NumIDLabel.AutoSize = True
        NumIDLabel.Location = New System.Drawing.Point(235, 36)
        NumIDLabel.Name = "NumIDLabel"
        NumIDLabel.Size = New System.Drawing.Size(46, 13)
        NumIDLabel.TabIndex = 10
        NumIDLabel.Text = "Num ID:"
        '
        'NombreLabel1
        '
        NombreLabel1.AutoSize = True
        NombreLabel1.Location = New System.Drawing.Point(39, 32)
        NombreLabel1.Name = "NombreLabel1"
        NombreLabel1.Size = New System.Drawing.Size(47, 13)
        NombreLabel1.TabIndex = 0
        NombreLabel1.Text = "Nombre:"
        '
        'DomicilioLabel1
        '
        DomicilioLabel1.AutoSize = True
        DomicilioLabel1.Location = New System.Drawing.Point(34, 58)
        DomicilioLabel1.Name = "DomicilioLabel1"
        DomicilioLabel1.Size = New System.Drawing.Size(52, 13)
        DomicilioLabel1.TabIndex = 2
        DomicilioLabel1.Text = "Domicilio:"
        '
        'TelLabel
        '
        TelLabel.AutoSize = True
        TelLabel.Location = New System.Drawing.Point(354, 58)
        TelLabel.Name = "TelLabel"
        TelLabel.Size = New System.Drawing.Size(25, 13)
        TelLabel.TabIndex = 4
        TelLabel.Text = "Tel:"
        '
        'ProxCitaLabel
        '
        ProxCitaLabel.AutoSize = True
        ProxCitaLabel.Location = New System.Drawing.Point(336, 125)
        ProxCitaLabel.Name = "ProxCitaLabel"
        ProxCitaLabel.Size = New System.Drawing.Size(52, 13)
        ProxCitaLabel.TabIndex = 6
        ProxCitaLabel.Text = "Prox Cita:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(5, 105)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 8
        ObservacionesLabel.Text = "Observaciones:"
        '
        'NumIDLabel1
        '
        NumIDLabel1.AutoSize = True
        NumIDLabel1.Location = New System.Drawing.Point(342, 32)
        NumIDLabel1.Name = "NumIDLabel1"
        NumIDLabel1.Size = New System.Drawing.Size(46, 13)
        NumIDLabel1.TabIndex = 11
        NumIDLabel1.Text = "Num ID:"
        '
        'CONSULV4DataSet
        '
        Me.CONSULV4DataSet.DataSetName = "CONSULV4DataSet"
        Me.CONSULV4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IdentificacionBindingSource
        '
        Me.IdentificacionBindingSource.DataMember = "Identificacion"
        Me.IdentificacionBindingSource.DataSource = Me.CONSULV4DataSet
        '
        'IdentificacionTableAdapter
        '
        Me.IdentificacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AgendaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HistoriasTableAdapter = Nothing
        Me.TableAdapterManager.IdentificacionTableAdapter = Me.IdentificacionTableAdapter
        Me.TableAdapterManager.MKVTableAdapter = Nothing
        Me.TableAdapterManager.MUTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication3.CONSULV4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdentificacionBindingNavigator
        '
        Me.IdentificacionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.IdentificacionBindingNavigator.BindingSource = Me.IdentificacionBindingSource
        Me.IdentificacionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.IdentificacionBindingNavigator.CountItemFormat = "{0}"
        Me.IdentificacionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.IdentificacionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.IdentificacionBindingNavigatorSaveItem})
        Me.IdentificacionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.IdentificacionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.IdentificacionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.IdentificacionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.IdentificacionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.IdentificacionBindingNavigator.Name = "IdentificacionBindingNavigator"
        Me.IdentificacionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.IdentificacionBindingNavigator.Size = New System.Drawing.Size(1344, 25)
        Me.IdentificacionBindingNavigator.TabIndex = 0
        Me.IdentificacionBindingNavigator.Text = "BindingNavigator1"
        Me.IdentificacionBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(21, 22)
        Me.BindingNavigatorCountItem.Text = "{0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'IdentificacionBindingNavigatorSaveItem
        '
        Me.IdentificacionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.IdentificacionBindingNavigatorSaveItem.Image = CType(resources.GetObject("IdentificacionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.IdentificacionBindingNavigatorSaveItem.Name = "IdentificacionBindingNavigatorSaveItem"
        Me.IdentificacionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.IdentificacionBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdentificacionBindingSource, "Nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(156, 98)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(27, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(328, 26)
        Me.TextBox1.TabIndex = 4
        '
        'ListBox2
        '
        Me.ListBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 20
        Me.ListBox2.Location = New System.Drawing.Point(27, 53)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(328, 544)
        Me.ListBox2.Sorted = True
        Me.ListBox2.TabIndex = 7
        '
        'LblSelec
        '
        Me.LblSelec.AutoSize = True
        Me.LblSelec.Location = New System.Drawing.Point(59, 75)
        Me.LblSelec.Name = "LblSelec"
        Me.LblSelec.Size = New System.Drawing.Size(39, 13)
        Me.LblSelec.TabIndex = 8
        Me.LblSelec.Text = "Label1"
        '
        'NombreTextBox1
        '
        Me.NombreTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdentificacionBindingSource, "Nombre", True))
        Me.NombreTextBox1.Location = New System.Drawing.Point(76, 33)
        Me.NombreTextBox1.Name = "NombreTextBox1"
        Me.NombreTextBox1.Size = New System.Drawing.Size(153, 20)
        Me.NombreTextBox1.TabIndex = 9
        '
        'DomicilioTextBox
        '
        Me.DomicilioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdentificacionBindingSource, "Domicilio", True))
        Me.DomicilioTextBox.Location = New System.Drawing.Point(76, 59)
        Me.DomicilioTextBox.Name = "DomicilioTextBox"
        Me.DomicilioTextBox.Size = New System.Drawing.Size(311, 20)
        Me.DomicilioTextBox.TabIndex = 10
        '
        'NumIDTextBox
        '
        Me.NumIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdentificacionBindingSource, "NumID", True))
        Me.NumIDTextBox.Location = New System.Drawing.Point(287, 33)
        Me.NumIDTextBox.Name = "NumIDTextBox"
        Me.NumIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumIDTextBox.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.Button14)
        Me.GroupBox1.Controls.Add(Me.Button13)
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Controls.Add(Me.ListBox2)
        Me.GroupBox1.Controls.Add(Me.NombreTextBox)
        Me.GroupBox1.Controls.Add(Me.LblSelec)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1342, 668)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(400, 22)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(105, 27)
        Me.Button13.TabIndex = 10
        Me.Button13.Text = "Nuevo Paciente"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(27, 606)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(328, 42)
        Me.Button12.TabIndex = 9
        Me.Button12.Text = "Aceptar"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DomicilioTextBox)
        Me.GroupBox2.Controls.Add(Me.NombreTextBox1)
        Me.GroupBox2.Controls.Add(NombreLabel)
        Me.GroupBox2.Controls.Add(NumIDLabel)
        Me.GroupBox2.Controls.Add(DomicilioLabel)
        Me.GroupBox2.Controls.Add(Me.NumIDTextBox)
        Me.GroupBox2.Location = New System.Drawing.Point(274, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 131)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Paciente"
        Me.GroupBox2.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(479, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(389, 26)
        Me.DateTimePicker1.TabIndex = 16
        '
        'TreeView1
        '
        Me.TreeView1.AllowDrop = True
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.FullRowSelect = True
        Me.TreeView1.Location = New System.Drawing.Point(6, 107)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.ShowLines = False
        Me.TreeView1.ShowPlusMinus = False
        Me.TreeView1.ShowRootLines = False
        Me.TreeView1.Size = New System.Drawing.Size(260, 319)
        Me.TreeView1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(261, 456)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Label1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TreeView5)
        Me.GroupBox3.Controls.Add(Me.TreeView4)
        Me.GroupBox3.Controls.Add(Me.TreeView3)
        Me.GroupBox3.Controls.Add(Me.TreeView2)
        Me.GroupBox3.Controls.Add(Me.TreeView1)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1342, 674)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(NumIDLabel1)
        Me.GroupBox4.Controls.Add(Me.NumIDTextBox1)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(ObservacionesLabel)
        Me.GroupBox4.Controls.Add(Me.ObservacionesTextBox)
        Me.GroupBox4.Controls.Add(ProxCitaLabel)
        Me.GroupBox4.Controls.Add(Me.ProxCitaTextBox)
        Me.GroupBox4.Controls.Add(TelLabel)
        Me.GroupBox4.Controls.Add(Me.TelTextBox)
        Me.GroupBox4.Controls.Add(DomicilioLabel1)
        Me.GroupBox4.Controls.Add(Me.DomicilioTextBox1)
        Me.GroupBox4.Controls.Add(NombreLabel1)
        Me.GroupBox4.Controls.Add(Me.NombreTextBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 463)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1324, 204)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'NumIDTextBox1
        '
        Me.NumIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdentificacionBindingSource, "NumID", True))
        Me.NumIDTextBox1.Location = New System.Drawing.Point(394, 29)
        Me.NumIDTextBox1.Name = "NumIDTextBox1"
        Me.NumIDTextBox1.Size = New System.Drawing.Size(132, 20)
        Me.NumIDTextBox1.TabIndex = 12
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button11)
        Me.GroupBox5.Controls.Add(Me.Button10)
        Me.GroupBox5.Controls.Add(Me.Button9)
        Me.GroupBox5.Location = New System.Drawing.Point(553, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(114, 165)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GroupBox5"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(21, 123)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 2
        Me.Button11.Text = "Repetir Cita"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(21, 76)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 1
        Me.Button10.Text = "Anular Cita"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(21, 34)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 0
        Me.Button9.Text = "Cambiar Cita"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'ObservacionesTextBox
        '
        Me.ObservacionesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdentificacionBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox.Location = New System.Drawing.Point(92, 102)
        Me.ObservacionesTextBox.Multiline = True
        Me.ObservacionesTextBox.Name = "ObservacionesTextBox"
        Me.ObservacionesTextBox.Size = New System.Drawing.Size(238, 63)
        Me.ObservacionesTextBox.TabIndex = 9
        '
        'ProxCitaTextBox
        '
        Me.ProxCitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdentificacionBindingSource, "ProxCita", True))
        Me.ProxCitaTextBox.Location = New System.Drawing.Point(394, 122)
        Me.ProxCitaTextBox.Name = "ProxCitaTextBox"
        Me.ProxCitaTextBox.Size = New System.Drawing.Size(132, 20)
        Me.ProxCitaTextBox.TabIndex = 7
        '
        'TelTextBox
        '
        Me.TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdentificacionBindingSource, "Tel", True))
        Me.TelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelTextBox.Location = New System.Drawing.Point(394, 55)
        Me.TelTextBox.Multiline = True
        Me.TelTextBox.Name = "TelTextBox"
        Me.TelTextBox.Size = New System.Drawing.Size(132, 64)
        Me.TelTextBox.TabIndex = 5
        '
        'DomicilioTextBox1
        '
        Me.DomicilioTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdentificacionBindingSource, "Domicilio", True))
        Me.DomicilioTextBox1.Location = New System.Drawing.Point(92, 55)
        Me.DomicilioTextBox1.Multiline = True
        Me.DomicilioTextBox1.Name = "DomicilioTextBox1"
        Me.DomicilioTextBox1.Size = New System.Drawing.Size(238, 41)
        Me.DomicilioTextBox1.TabIndex = 3
        '
        'NombreTextBox2
        '
        Me.NombreTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdentificacionBindingSource, "Nombre", True))
        Me.NombreTextBox2.Location = New System.Drawing.Point(92, 29)
        Me.NombreTextBox2.Name = "NombreTextBox2"
        Me.NombreTextBox2.Size = New System.Drawing.Size(238, 20)
        Me.NombreTextBox2.TabIndex = 1
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(1213, 432)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(117, 25)
        Me.Button8.TabIndex = 36
        Me.Button8.Text = "Hora Extra Tarde"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(947, 432)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(117, 25)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "Hora Extra Tarde"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(681, 432)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(117, 25)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "Hora Extra Tarde"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(415, 432)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 25)
        Me.Button5.TabIndex = 33
        Me.Button5.Text = "Hora Extra Tarde"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1070, 432)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(117, 25)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Hora Extra Mañana"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(804, 432)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 25)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Hora Extra Mañana"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(538, 432)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 25)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Hora Extra Mañana"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(272, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 25)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Hora Extra Mañana"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1086, 31)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(50, 20)
        Me.TextBox2.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1070, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(260, 22)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Sergio"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(804, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(260, 22)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Marta"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(538, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 22)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Gloria"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(272, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 22)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Maria"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 22)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Mª Angeles"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TreeView5
        '
        Me.TreeView5.AllowDrop = True
        Me.TreeView5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView5.FullRowSelect = True
        Me.TreeView5.Location = New System.Drawing.Point(1070, 107)
        Me.TreeView5.Name = "TreeView5"
        Me.TreeView5.ShowLines = False
        Me.TreeView5.ShowPlusMinus = False
        Me.TreeView5.ShowRootLines = False
        Me.TreeView5.Size = New System.Drawing.Size(260, 319)
        Me.TreeView5.TabIndex = 21
        '
        'TreeView4
        '
        Me.TreeView4.AllowDrop = True
        Me.TreeView4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView4.FullRowSelect = True
        Me.TreeView4.Location = New System.Drawing.Point(804, 107)
        Me.TreeView4.Name = "TreeView4"
        Me.TreeView4.ShowLines = False
        Me.TreeView4.ShowPlusMinus = False
        Me.TreeView4.ShowRootLines = False
        Me.TreeView4.Size = New System.Drawing.Size(260, 319)
        Me.TreeView4.TabIndex = 20
        '
        'TreeView3
        '
        Me.TreeView3.AllowDrop = True
        Me.TreeView3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView3.FullRowSelect = True
        Me.TreeView3.Location = New System.Drawing.Point(538, 107)
        Me.TreeView3.Name = "TreeView3"
        Me.TreeView3.ShowLines = False
        Me.TreeView3.ShowPlusMinus = False
        Me.TreeView3.ShowRootLines = False
        Me.TreeView3.Size = New System.Drawing.Size(260, 319)
        Me.TreeView3.TabIndex = 19
        '
        'TreeView2
        '
        Me.TreeView2.AllowDrop = True
        Me.TreeView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView2.FullRowSelect = True
        Me.TreeView2.Location = New System.Drawing.Point(272, 107)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.ShowLines = False
        Me.TreeView2.ShowPlusMinus = False
        Me.TreeView2.ShowRootLines = False
        Me.TreeView2.Size = New System.Drawing.Size(260, 319)
        Me.TreeView2.TabIndex = 18
        '
        'HistoriasBindingSource
        '
        Me.HistoriasBindingSource.DataMember = "Historias"
        Me.HistoriasBindingSource.DataSource = Me.CONSULV4DataSet
        '
        'HistoriasTableAdapter
        '
        Me.HistoriasTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1366, 25)
        Me.ToolStrip1.TabIndex = 20
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.OpcionesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1366, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FisioterapeutasToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'FisioterapeutasToolStripMenuItem
        '
        Me.FisioterapeutasToolStripMenuItem.Name = "FisioterapeutasToolStripMenuItem"
        Me.FisioterapeutasToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.FisioterapeutasToolStripMenuItem.Text = "Fisioterapeutas"
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(1303, 18)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(27, 28)
        Me.Button14.TabIndex = 11
        Me.Button14.Text = "X"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(NumIDLabel2)
        Me.GroupBox6.Controls.Add(Me.NumIDTextBox2)
        Me.GroupBox6.Controls.Add(ObservacionesLabel1)
        Me.GroupBox6.Controls.Add(Me.ObservacionesTextBox1)
        Me.GroupBox6.Controls.Add(TelLabel1)
        Me.GroupBox6.Controls.Add(Me.TelTextBox1)
        Me.GroupBox6.Controls.Add(Label7)
        Me.GroupBox6.Controls.Add(DomicilioLabel2)
        Me.GroupBox6.Controls.Add(Me.TextBox3)
        Me.GroupBox6.Controls.Add(Me.DomicilioTextBox2)
        Me.GroupBox6.Controls.Add(BirthDateLabel)
        Me.GroupBox6.Controls.Add(Me.BirthDateDateTimePicker)
        Me.GroupBox6.Controls.Add(NombreLabel2)
        Me.GroupBox6.Controls.Add(Me.NombreTextBox3)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(398, 76)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(926, 572)
        Me.GroupBox6.TabIndex = 12
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Datos del paciente"
        '
        'NombreLabel2
        '
        NombreLabel2.AutoSize = True
        NombreLabel2.Location = New System.Drawing.Point(29, 35)
        NombreLabel2.Name = "NombreLabel2"
        NombreLabel2.Size = New System.Drawing.Size(67, 16)
        NombreLabel2.TabIndex = 0
        NombreLabel2.Text = "Nombre:"
        '
        'NombreTextBox3
        '
        Me.NombreTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdentificacionBindingSource, "Nombre", True))
        Me.NombreTextBox3.Location = New System.Drawing.Point(102, 32)
        Me.NombreTextBox3.Name = "NombreTextBox3"
        Me.NombreTextBox3.Size = New System.Drawing.Size(347, 22)
        Me.NombreTextBox3.TabIndex = 1
        '
        'BirthDateLabel
        '
        BirthDateLabel.AutoSize = True
        BirthDateLabel.Location = New System.Drawing.Point(620, 39)
        BirthDateLabel.Name = "BirthDateLabel"
        BirthDateLabel.Size = New System.Drawing.Size(146, 16)
        BirthDateLabel.TabIndex = 2
        BirthDateLabel.Text = "Fecha Naciemiento:"
        '
        'BirthDateDateTimePicker
        '
        Me.BirthDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IdentificacionBindingSource, "BirthDate", True))
        Me.BirthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.BirthDateDateTimePicker.Location = New System.Drawing.Point(768, 35)
        Me.BirthDateDateTimePicker.Name = "BirthDateDateTimePicker"
        Me.BirthDateDateTimePicker.Size = New System.Drawing.Size(111, 22)
        Me.BirthDateDateTimePicker.TabIndex = 3
        '
        'DomicilioLabel2
        '
        DomicilioLabel2.AutoSize = True
        DomicilioLabel2.Location = New System.Drawing.Point(148, 104)
        DomicilioLabel2.Name = "DomicilioLabel2"
        DomicilioLabel2.Size = New System.Drawing.Size(77, 16)
        DomicilioLabel2.TabIndex = 4
        DomicilioLabel2.Text = "Domicilio:"
        '
        'DomicilioTextBox2
        '
        Me.DomicilioTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdentificacionBindingSource, "Domicilio", True))
        Me.DomicilioTextBox2.Location = New System.Drawing.Point(231, 101)
        Me.DomicilioTextBox2.Name = "DomicilioTextBox2"
        Me.DomicilioTextBox2.Size = New System.Drawing.Size(100, 22)
        Me.DomicilioTextBox2.TabIndex = 5
        '
        'TelLabel1
        '
        TelLabel1.AutoSize = True
        TelLabel1.Location = New System.Drawing.Point(85, 148)
        TelLabel1.Name = "TelLabel1"
        TelLabel1.Size = New System.Drawing.Size(35, 16)
        TelLabel1.TabIndex = 6
        TelLabel1.Text = "Tel:"
        '
        'TelTextBox1
        '
        Me.TelTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdentificacionBindingSource, "Tel", True))
        Me.TelTextBox1.Location = New System.Drawing.Point(126, 145)
        Me.TelTextBox1.Name = "TelTextBox1"
        Me.TelTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TelTextBox1.TabIndex = 7
        '
        'ObservacionesLabel1
        '
        ObservacionesLabel1.AutoSize = True
        ObservacionesLabel1.Location = New System.Drawing.Point(442, 130)
        ObservacionesLabel1.Name = "ObservacionesLabel1"
        ObservacionesLabel1.Size = New System.Drawing.Size(117, 16)
        ObservacionesLabel1.TabIndex = 8
        ObservacionesLabel1.Text = "Observaciones:"
        '
        'ObservacionesTextBox1
        '
        Me.ObservacionesTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdentificacionBindingSource, "Observaciones", True))
        Me.ObservacionesTextBox1.Location = New System.Drawing.Point(565, 127)
        Me.ObservacionesTextBox1.Name = "ObservacionesTextBox1"
        Me.ObservacionesTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.ObservacionesTextBox1.TabIndex = 9
        '
        'NumIDLabel2
        '
        NumIDLabel2.AutoSize = True
        NumIDLabel2.Location = New System.Drawing.Point(455, 38)
        NumIDLabel2.Name = "NumIDLabel2"
        NumIDLabel2.Size = New System.Drawing.Size(38, 16)
        NumIDLabel2.TabIndex = 10
        NumIDLabel2.Text = "DNI:"
        '
        'NumIDTextBox2
        '
        Me.NumIDTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IdentificacionBindingSource, "NumID", True))
        Me.NumIDTextBox2.Location = New System.Drawing.Point(499, 35)
        Me.NumIDTextBox2.Name = "NumIDTextBox2"
        Me.NumIDTextBox2.Size = New System.Drawing.Size(100, 22)
        Me.NumIDTextBox2.TabIndex = 11
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(102, 79)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 5
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(19, 82)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(77, 16)
        Label7.TabIndex = 4
        Label7.Text = "Domicilio:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 729)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.IdentificacionBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.CONSULV4DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdentificacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IdentificacionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.IdentificacionBindingNavigator.ResumeLayout(False)
        Me.IdentificacionBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.HistoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CONSULV4DataSet As CONSULV4DataSet
    Friend WithEvents IdentificacionBindingSource As BindingSource
    Friend WithEvents IdentificacionTableAdapter As CONSULV4DataSetTableAdapters.IdentificacionTableAdapter
    Friend WithEvents TableAdapterManager As CONSULV4DataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdentificacionBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents IdentificacionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents LblSelec As Label
    Friend WithEvents NombreTextBox1 As TextBox
    Friend WithEvents DomicilioTextBox As TextBox
    Friend WithEvents NumIDTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TreeView5 As TreeView
    Friend WithEvents TreeView4 As TreeView
    Friend WithEvents TreeView3 As TreeView
    Friend WithEvents TreeView2 As TreeView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents HistoriasBindingSource As BindingSource
    Friend WithEvents HistoriasTableAdapter As CONSULV4DataSetTableAdapters.HistoriasTableAdapter
    Friend WithEvents ObservacionesTextBox As TextBox
    Friend WithEvents ProxCitaTextBox As TextBox
    Friend WithEvents TelTextBox As TextBox
    Friend WithEvents DomicilioTextBox1 As TextBox
    Friend WithEvents NombreTextBox2 As TextBox
    Friend WithEvents Button13 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents NumIDTextBox1 As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FisioterapeutasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button14 As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents NumIDTextBox2 As TextBox
    Friend WithEvents ObservacionesTextBox1 As TextBox
    Friend WithEvents TelTextBox1 As TextBox
    Friend WithEvents DomicilioTextBox2 As TextBox
    Friend WithEvents BirthDateDateTimePicker As DateTimePicker
    Friend WithEvents NombreTextBox3 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
