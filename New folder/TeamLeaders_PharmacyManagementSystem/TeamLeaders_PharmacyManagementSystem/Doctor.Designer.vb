<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctor
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doctor))
        Dim Doctor_s_Ref_NoLabel As System.Windows.Forms.Label
        Dim Doctor_s_NHS_NoLabel As System.Windows.Forms.Label
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim Medical_Center_NameLabel As System.Windows.Forms.Label
        Dim Address_of_Medical_CenterLabel As System.Windows.Forms.Label
        Dim Phone_NoLabel As System.Windows.Forms.Label
        Dim Email_AddressLabel As System.Windows.Forms.Label
        Dim Patient_Reference_NoLabel As System.Windows.Forms.Label
        Dim GP_Appointment_Reference_NoLabel As System.Windows.Forms.Label
        Dim Patient_IDLabel As System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TeamLeaders_PharmacyMSDataSet = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSet()
        Me.DoctorFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorFormTableAdapter = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.DoctorFormTableAdapter()
        Me.TableAdapterManager = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager()
        Me.DoctorFormBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.DoctorFormBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Doctor_s_Ref_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_s_NHS_NoTextBox = New System.Windows.Forms.TextBox()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.Medical_Center_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Address_of_Medical_CenterTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Email_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_Reference_NoTextBox = New System.Windows.Forms.TextBox()
        Me.GP_Appointment_Reference_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.DoctorFormDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Doctor_s_Ref_NoLabel = New System.Windows.Forms.Label()
        Doctor_s_NHS_NoLabel = New System.Windows.Forms.Label()
        FirstnameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        Medical_Center_NameLabel = New System.Windows.Forms.Label()
        Address_of_Medical_CenterLabel = New System.Windows.Forms.Label()
        Phone_NoLabel = New System.Windows.Forms.Label()
        Email_AddressLabel = New System.Windows.Forms.Label()
        Patient_Reference_NoLabel = New System.Windows.Forms.Label()
        GP_Appointment_Reference_NoLabel = New System.Windows.Forms.Label()
        Patient_IDLabel = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.TeamLeaders_PharmacyMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorFormBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DoctorFormBindingNavigator.SuspendLayout()
        CType(Me.DoctorFormDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox2.Controls.Add(Me.btnexit)
        Me.GroupBox2.Controls.Add(Me.btnclose)
        Me.GroupBox2.Controls.Add(Me.btnprev)
        Me.GroupBox2.Controls.Add(Me.btnnext)
        Me.GroupBox2.Controls.Add(Me.btndel)
        Me.GroupBox2.Controls.Add(Me.btnadd)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1045, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(171, 370)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options:"
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(27, 312)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(121, 38)
        Me.btnexit.TabIndex = 5
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(27, 259)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(121, 38)
        Me.btnclose.TabIndex = 4
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.Location = New System.Drawing.Point(27, 206)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(121, 38)
        Me.btnprev.TabIndex = 3
        Me.btnprev.Text = "Previous"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(27, 153)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(121, 38)
        Me.btnnext.TabIndex = 2
        Me.btnnext.Text = "Next"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Location = New System.Drawing.Point(27, 98)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(121, 38)
        Me.btndel.TabIndex = 1
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(27, 45)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(121, 38)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "Add New"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel4.Controls.Add(Doctor_s_Ref_NoLabel)
        Me.Panel4.Controls.Add(Me.Doctor_s_Ref_NoTextBox)
        Me.Panel4.Controls.Add(Doctor_s_NHS_NoLabel)
        Me.Panel4.Controls.Add(Me.Doctor_s_NHS_NoTextBox)
        Me.Panel4.Controls.Add(FirstnameLabel)
        Me.Panel4.Controls.Add(Me.FirstnameTextBox)
        Me.Panel4.Controls.Add(SurnameLabel)
        Me.Panel4.Controls.Add(Me.SurnameTextBox)
        Me.Panel4.Controls.Add(Medical_Center_NameLabel)
        Me.Panel4.Controls.Add(Me.Medical_Center_NameTextBox)
        Me.Panel4.Controls.Add(Address_of_Medical_CenterLabel)
        Me.Panel4.Controls.Add(Me.Address_of_Medical_CenterTextBox)
        Me.Panel4.Controls.Add(Phone_NoLabel)
        Me.Panel4.Controls.Add(Me.Phone_NoTextBox)
        Me.Panel4.Controls.Add(Email_AddressLabel)
        Me.Panel4.Controls.Add(Me.Email_AddressTextBox)
        Me.Panel4.Controls.Add(Patient_Reference_NoLabel)
        Me.Panel4.Controls.Add(Me.Patient_Reference_NoTextBox)
        Me.Panel4.Controls.Add(GP_Appointment_Reference_NoLabel)
        Me.Panel4.Controls.Add(Me.GP_Appointment_Reference_NoTextBox)
        Me.Panel4.Controls.Add(Patient_IDLabel)
        Me.Panel4.Controls.Add(Me.Patient_IDTextBox)
        Me.Panel4.Location = New System.Drawing.Point(31, 121)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(993, 261)
        Me.Panel4.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(31, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(993, 92)
        Me.Panel3.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label1.Location = New System.Drawing.Point(24, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(876, 73)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Doctors' Information Window"
        '
        'TeamLeaders_PharmacyMSDataSet
        '
        Me.TeamLeaders_PharmacyMSDataSet.DataSetName = "TeamLeaders_PharmacyMSDataSet"
        Me.TeamLeaders_PharmacyMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DoctorFormBindingSource
        '
        Me.DoctorFormBindingSource.DataMember = "DoctorForm"
        Me.DoctorFormBindingSource.DataSource = Me.TeamLeaders_PharmacyMSDataSet
        '
        'DoctorFormTableAdapter
        '
        Me.DoctorFormTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorFormTableAdapter = Me.DoctorFormTableAdapter
        Me.TableAdapterManager.GPAFormTableAdapter = Nothing
        Me.TableAdapterManager.PatientFormTableAdapter = Nothing
        Me.TableAdapterManager.PaymentFormTableAdapter = Nothing
        Me.TableAdapterManager.PharmacyFormTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DoctorFormBindingNavigator
        '
        Me.DoctorFormBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DoctorFormBindingNavigator.BindingSource = Me.DoctorFormBindingSource
        Me.DoctorFormBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DoctorFormBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DoctorFormBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DoctorFormBindingNavigatorSaveItem})
        Me.DoctorFormBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DoctorFormBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DoctorFormBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DoctorFormBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DoctorFormBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DoctorFormBindingNavigator.Name = "DoctorFormBindingNavigator"
        Me.DoctorFormBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DoctorFormBindingNavigator.Size = New System.Drawing.Size(1246, 25)
        Me.DoctorFormBindingNavigator.TabIndex = 11
        Me.DoctorFormBindingNavigator.Text = "BindingNavigator1"
        Me.DoctorFormBindingNavigator.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'DoctorFormBindingNavigatorSaveItem
        '
        Me.DoctorFormBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DoctorFormBindingNavigatorSaveItem.Image = CType(resources.GetObject("DoctorFormBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DoctorFormBindingNavigatorSaveItem.Name = "DoctorFormBindingNavigatorSaveItem"
        Me.DoctorFormBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DoctorFormBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Doctor_s_Ref_NoLabel
        '
        Doctor_s_Ref_NoLabel.AutoSize = True
        Doctor_s_Ref_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_s_Ref_NoLabel.Location = New System.Drawing.Point(16, 14)
        Doctor_s_Ref_NoLabel.Name = "Doctor_s_Ref_NoLabel"
        Doctor_s_Ref_NoLabel.Size = New System.Drawing.Size(184, 25)
        Doctor_s_Ref_NoLabel.TabIndex = 0
        Doctor_s_Ref_NoLabel.Text = "Doctor's Ref No:"
        '
        'Doctor_s_Ref_NoTextBox
        '
        Me.Doctor_s_Ref_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Doctor's Ref No", True))
        Me.Doctor_s_Ref_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doctor_s_Ref_NoTextBox.Location = New System.Drawing.Point(342, 11)
        Me.Doctor_s_Ref_NoTextBox.Name = "Doctor_s_Ref_NoTextBox"
        Me.Doctor_s_Ref_NoTextBox.Size = New System.Drawing.Size(130, 31)
        Me.Doctor_s_Ref_NoTextBox.TabIndex = 1
        '
        'Doctor_s_NHS_NoLabel
        '
        Doctor_s_NHS_NoLabel.AutoSize = True
        Doctor_s_NHS_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_s_NHS_NoLabel.Location = New System.Drawing.Point(16, 51)
        Doctor_s_NHS_NoLabel.Name = "Doctor_s_NHS_NoLabel"
        Doctor_s_NHS_NoLabel.Size = New System.Drawing.Size(195, 25)
        Doctor_s_NHS_NoLabel.TabIndex = 2
        Doctor_s_NHS_NoLabel.Text = "Doctor's NHS No:"
        '
        'Doctor_s_NHS_NoTextBox
        '
        Me.Doctor_s_NHS_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Doctor's NHS No", True))
        Me.Doctor_s_NHS_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doctor_s_NHS_NoTextBox.Location = New System.Drawing.Point(342, 48)
        Me.Doctor_s_NHS_NoTextBox.Name = "Doctor_s_NHS_NoTextBox"
        Me.Doctor_s_NHS_NoTextBox.Size = New System.Drawing.Size(130, 31)
        Me.Doctor_s_NHS_NoTextBox.TabIndex = 3
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstnameLabel.Location = New System.Drawing.Point(16, 88)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(123, 25)
        FirstnameLabel.TabIndex = 4
        FirstnameLabel.Text = "Firstname:"
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Firstname", True))
        Me.FirstnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstnameTextBox.Location = New System.Drawing.Point(342, 85)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(130, 31)
        Me.FirstnameTextBox.TabIndex = 5
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SurnameLabel.Location = New System.Drawing.Point(16, 125)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(112, 25)
        SurnameLabel.TabIndex = 6
        SurnameLabel.Text = "Surname:"
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Surname", True))
        Me.SurnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SurnameTextBox.Location = New System.Drawing.Point(342, 122)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(130, 31)
        Me.SurnameTextBox.TabIndex = 7
        '
        'Medical_Center_NameLabel
        '
        Medical_Center_NameLabel.AutoSize = True
        Medical_Center_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Medical_Center_NameLabel.Location = New System.Drawing.Point(16, 162)
        Medical_Center_NameLabel.Name = "Medical_Center_NameLabel"
        Medical_Center_NameLabel.Size = New System.Drawing.Size(245, 25)
        Medical_Center_NameLabel.TabIndex = 8
        Medical_Center_NameLabel.Text = "Medical Center Name:"
        '
        'Medical_Center_NameTextBox
        '
        Me.Medical_Center_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Medical Center Name", True))
        Me.Medical_Center_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medical_Center_NameTextBox.Location = New System.Drawing.Point(342, 159)
        Me.Medical_Center_NameTextBox.Name = "Medical_Center_NameTextBox"
        Me.Medical_Center_NameTextBox.Size = New System.Drawing.Size(130, 31)
        Me.Medical_Center_NameTextBox.TabIndex = 9
        '
        'Address_of_Medical_CenterLabel
        '
        Address_of_Medical_CenterLabel.AutoSize = True
        Address_of_Medical_CenterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Address_of_Medical_CenterLabel.Location = New System.Drawing.Point(16, 199)
        Address_of_Medical_CenterLabel.Name = "Address_of_Medical_CenterLabel"
        Address_of_Medical_CenterLabel.Size = New System.Drawing.Size(298, 25)
        Address_of_Medical_CenterLabel.TabIndex = 10
        Address_of_Medical_CenterLabel.Text = "Address of Medical Center:"
        '
        'Address_of_Medical_CenterTextBox
        '
        Me.Address_of_Medical_CenterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Address of Medical Center", True))
        Me.Address_of_Medical_CenterTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address_of_Medical_CenterTextBox.Location = New System.Drawing.Point(342, 196)
        Me.Address_of_Medical_CenterTextBox.Name = "Address_of_Medical_CenterTextBox"
        Me.Address_of_Medical_CenterTextBox.Size = New System.Drawing.Size(130, 31)
        Me.Address_of_Medical_CenterTextBox.TabIndex = 11
        '
        'Phone_NoLabel
        '
        Phone_NoLabel.AutoSize = True
        Phone_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NoLabel.Location = New System.Drawing.Point(503, 14)
        Phone_NoLabel.Name = "Phone_NoLabel"
        Phone_NoLabel.Size = New System.Drawing.Size(122, 25)
        Phone_NoLabel.TabIndex = 12
        Phone_NoLabel.Text = "Phone No:"
        '
        'Phone_NoTextBox
        '
        Me.Phone_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Phone No", True))
        Me.Phone_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_NoTextBox.Location = New System.Drawing.Point(849, 11)
        Me.Phone_NoTextBox.Name = "Phone_NoTextBox"
        Me.Phone_NoTextBox.Size = New System.Drawing.Size(119, 31)
        Me.Phone_NoTextBox.TabIndex = 13
        '
        'Email_AddressLabel
        '
        Email_AddressLabel.AutoSize = True
        Email_AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Email_AddressLabel.Location = New System.Drawing.Point(503, 51)
        Email_AddressLabel.Name = "Email_AddressLabel"
        Email_AddressLabel.Size = New System.Drawing.Size(170, 25)
        Email_AddressLabel.TabIndex = 14
        Email_AddressLabel.Text = "Email Address:"
        '
        'Email_AddressTextBox
        '
        Me.Email_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Email Address", True))
        Me.Email_AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_AddressTextBox.Location = New System.Drawing.Point(849, 48)
        Me.Email_AddressTextBox.Name = "Email_AddressTextBox"
        Me.Email_AddressTextBox.Size = New System.Drawing.Size(119, 31)
        Me.Email_AddressTextBox.TabIndex = 15
        '
        'Patient_Reference_NoLabel
        '
        Patient_Reference_NoLabel.AutoSize = True
        Patient_Reference_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_Reference_NoLabel.Location = New System.Drawing.Point(503, 88)
        Patient_Reference_NoLabel.Name = "Patient_Reference_NoLabel"
        Patient_Reference_NoLabel.Size = New System.Drawing.Size(244, 25)
        Patient_Reference_NoLabel.TabIndex = 16
        Patient_Reference_NoLabel.Text = "Patient Reference No:"
        '
        'Patient_Reference_NoTextBox
        '
        Me.Patient_Reference_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Patient Reference No", True))
        Me.Patient_Reference_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patient_Reference_NoTextBox.Location = New System.Drawing.Point(849, 85)
        Me.Patient_Reference_NoTextBox.Name = "Patient_Reference_NoTextBox"
        Me.Patient_Reference_NoTextBox.Size = New System.Drawing.Size(119, 31)
        Me.Patient_Reference_NoTextBox.TabIndex = 17
        '
        'GP_Appointment_Reference_NoLabel
        '
        GP_Appointment_Reference_NoLabel.AutoSize = True
        GP_Appointment_Reference_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GP_Appointment_Reference_NoLabel.Location = New System.Drawing.Point(503, 125)
        GP_Appointment_Reference_NoLabel.Name = "GP_Appointment_Reference_NoLabel"
        GP_Appointment_Reference_NoLabel.Size = New System.Drawing.Size(340, 25)
        GP_Appointment_Reference_NoLabel.TabIndex = 18
        GP_Appointment_Reference_NoLabel.Text = "GP Appointment Reference No:"
        '
        'GP_Appointment_Reference_NoTextBox
        '
        Me.GP_Appointment_Reference_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "GP Appointment Reference No", True))
        Me.GP_Appointment_Reference_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GP_Appointment_Reference_NoTextBox.Location = New System.Drawing.Point(849, 122)
        Me.GP_Appointment_Reference_NoTextBox.Name = "GP_Appointment_Reference_NoTextBox"
        Me.GP_Appointment_Reference_NoTextBox.Size = New System.Drawing.Size(119, 31)
        Me.GP_Appointment_Reference_NoTextBox.TabIndex = 19
        '
        'Patient_IDLabel
        '
        Patient_IDLabel.AutoSize = True
        Patient_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_IDLabel.Location = New System.Drawing.Point(503, 162)
        Patient_IDLabel.Name = "Patient_IDLabel"
        Patient_IDLabel.Size = New System.Drawing.Size(122, 25)
        Patient_IDLabel.TabIndex = 20
        Patient_IDLabel.Text = "Patient ID:"
        '
        'Patient_IDTextBox
        '
        Me.Patient_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Patient ID", True))
        Me.Patient_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patient_IDTextBox.Location = New System.Drawing.Point(849, 159)
        Me.Patient_IDTextBox.Name = "Patient_IDTextBox"
        Me.Patient_IDTextBox.Size = New System.Drawing.Size(119, 31)
        Me.Patient_IDTextBox.TabIndex = 21
        '
        'DoctorFormDataGridView
        '
        Me.DoctorFormDataGridView.AutoGenerateColumns = False
        Me.DoctorFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorFormDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.DoctorFormDataGridView.DataSource = Me.DoctorFormBindingSource
        Me.DoctorFormDataGridView.Location = New System.Drawing.Point(31, 404)
        Me.DoctorFormDataGridView.Name = "DoctorFormDataGridView"
        Me.DoctorFormDataGridView.Size = New System.Drawing.Size(1185, 271)
        Me.DoctorFormDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Doctor's Ref No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Doctor's Ref No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Doctor's NHS No"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Doctor's NHS No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Firstname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Firstname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Medical Center Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Medical Center Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Address of Medical Center"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Address of Medical Center"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Phone No"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Phone No"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Email Address"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Email Address"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Patient Reference No"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Patient Reference No"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "GP Appointment Reference No"
        Me.DataGridViewTextBoxColumn10.HeaderText = "GP Appointment Reference No"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Patient ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Doctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1246, 700)
        Me.Controls.Add(Me.DoctorFormDataGridView)
        Me.Controls.Add(Me.DoctorFormBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "Doctor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Doctor"
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.TeamLeaders_PharmacyMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorFormBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DoctorFormBindingNavigator.ResumeLayout(False)
        Me.DoctorFormBindingNavigator.PerformLayout()
        CType(Me.DoctorFormDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btnprev As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TeamLeaders_PharmacyMSDataSet As TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSet
    Friend WithEvents DoctorFormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DoctorFormTableAdapter As TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.DoctorFormTableAdapter
    Friend WithEvents TableAdapterManager As TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DoctorFormBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DoctorFormBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Doctor_s_Ref_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Doctor_s_NHS_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Medical_Center_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Address_of_Medical_CenterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Email_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Patient_Reference_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GP_Appointment_Reference_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Patient_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DoctorFormDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
