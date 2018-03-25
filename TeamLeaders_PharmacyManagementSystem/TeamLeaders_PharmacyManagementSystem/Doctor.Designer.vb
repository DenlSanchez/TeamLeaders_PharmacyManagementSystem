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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doctor))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btnprev = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.doc1 = New System.Windows.Forms.TextBox()
        Me.DoctorFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamLeaders_PharmacyMSDataSet = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSet()
        Me.doc2 = New System.Windows.Forms.TextBox()
        Me.doc3 = New System.Windows.Forms.TextBox()
        Me.doc4 = New System.Windows.Forms.TextBox()
        Me.doc5 = New System.Windows.Forms.TextBox()
        Me.doc6 = New System.Windows.Forms.TextBox()
        Me.doc7 = New System.Windows.Forms.TextBox()
        Me.doc8 = New System.Windows.Forms.TextBox()
        Me.doc9 = New System.Windows.Forms.TextBox()
        Me.doc10 = New System.Windows.Forms.TextBox()
        Me.doc11 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DoctorFormTableAdapter = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.DoctorFormTableAdapter()
        Me.TableAdapterManager = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager()
        Me.DoctorFormBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DoctorFormBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
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
        CType(Me.DoctorFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamLeaders_PharmacyMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DoctorFormBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DoctorFormBindingNavigator.SuspendLayout()
        CType(Me.DoctorFormDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Doctor_s_Ref_NoLabel
        '
        Doctor_s_Ref_NoLabel.AutoSize = True
        Doctor_s_Ref_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_s_Ref_NoLabel.Location = New System.Drawing.Point(16, 14)
        Doctor_s_Ref_NoLabel.Name = "Doctor_s_Ref_NoLabel"
        Doctor_s_Ref_NoLabel.Size = New System.Drawing.Size(122, 16)
        Doctor_s_Ref_NoLabel.TabIndex = 0
        Doctor_s_Ref_NoLabel.Text = "Doctor's Ref No:"
        '
        'Doctor_s_NHS_NoLabel
        '
        Doctor_s_NHS_NoLabel.AutoSize = True
        Doctor_s_NHS_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_s_NHS_NoLabel.Location = New System.Drawing.Point(16, 38)
        Doctor_s_NHS_NoLabel.Name = "Doctor_s_NHS_NoLabel"
        Doctor_s_NHS_NoLabel.Size = New System.Drawing.Size(130, 16)
        Doctor_s_NHS_NoLabel.TabIndex = 2
        Doctor_s_NHS_NoLabel.Text = "Doctor's NHS No:"
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstnameLabel.Location = New System.Drawing.Point(16, 62)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(80, 16)
        FirstnameLabel.TabIndex = 4
        FirstnameLabel.Text = "Firstname:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SurnameLabel.Location = New System.Drawing.Point(16, 86)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(73, 16)
        SurnameLabel.TabIndex = 6
        SurnameLabel.Text = "Surname:"
        '
        'Medical_Center_NameLabel
        '
        Medical_Center_NameLabel.AutoSize = True
        Medical_Center_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Medical_Center_NameLabel.Location = New System.Drawing.Point(16, 110)
        Medical_Center_NameLabel.Name = "Medical_Center_NameLabel"
        Medical_Center_NameLabel.Size = New System.Drawing.Size(161, 16)
        Medical_Center_NameLabel.TabIndex = 8
        Medical_Center_NameLabel.Text = "Medical Center Name:"
        '
        'Address_of_Medical_CenterLabel
        '
        Address_of_Medical_CenterLabel.AutoSize = True
        Address_of_Medical_CenterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Address_of_Medical_CenterLabel.Location = New System.Drawing.Point(16, 134)
        Address_of_Medical_CenterLabel.Name = "Address_of_Medical_CenterLabel"
        Address_of_Medical_CenterLabel.Size = New System.Drawing.Size(195, 16)
        Address_of_Medical_CenterLabel.TabIndex = 10
        Address_of_Medical_CenterLabel.Text = "Address of Medical Center:"
        '
        'Phone_NoLabel
        '
        Phone_NoLabel.AutoSize = True
        Phone_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NoLabel.Location = New System.Drawing.Point(409, 14)
        Phone_NoLabel.Name = "Phone_NoLabel"
        Phone_NoLabel.Size = New System.Drawing.Size(80, 16)
        Phone_NoLabel.TabIndex = 12
        Phone_NoLabel.Text = "Phone No:"
        '
        'Email_AddressLabel
        '
        Email_AddressLabel.AutoSize = True
        Email_AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Email_AddressLabel.Location = New System.Drawing.Point(409, 38)
        Email_AddressLabel.Name = "Email_AddressLabel"
        Email_AddressLabel.Size = New System.Drawing.Size(113, 16)
        Email_AddressLabel.TabIndex = 14
        Email_AddressLabel.Text = "Email Address:"
        '
        'Patient_Reference_NoLabel
        '
        Patient_Reference_NoLabel.AutoSize = True
        Patient_Reference_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_Reference_NoLabel.Location = New System.Drawing.Point(409, 62)
        Patient_Reference_NoLabel.Name = "Patient_Reference_NoLabel"
        Patient_Reference_NoLabel.Size = New System.Drawing.Size(160, 16)
        Patient_Reference_NoLabel.TabIndex = 16
        Patient_Reference_NoLabel.Text = "Patient Reference No:"
        '
        'GP_Appointment_Reference_NoLabel
        '
        GP_Appointment_Reference_NoLabel.AutoSize = True
        GP_Appointment_Reference_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GP_Appointment_Reference_NoLabel.Location = New System.Drawing.Point(409, 86)
        GP_Appointment_Reference_NoLabel.Name = "GP_Appointment_Reference_NoLabel"
        GP_Appointment_Reference_NoLabel.Size = New System.Drawing.Size(223, 16)
        GP_Appointment_Reference_NoLabel.TabIndex = 18
        GP_Appointment_Reference_NoLabel.Text = "GP Appointment Reference No:"
        '
        'Patient_IDLabel
        '
        Patient_IDLabel.AutoSize = True
        Patient_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_IDLabel.Location = New System.Drawing.Point(409, 110)
        Patient_IDLabel.Name = "Patient_IDLabel"
        Patient_IDLabel.Size = New System.Drawing.Size(79, 16)
        Patient_IDLabel.TabIndex = 20
        Patient_IDLabel.Text = "Patient ID:"
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
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(834, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(115, 244)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options:"
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(13, 166)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(86, 29)
        Me.btnexit.TabIndex = 5
        Me.btnexit.Text = "Save"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.Location = New System.Drawing.Point(13, 201)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(86, 29)
        Me.btnclose.TabIndex = 4
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'btnprev
        '
        Me.btnprev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprev.Location = New System.Drawing.Point(40, 131)
        Me.btnprev.Name = "btnprev"
        Me.btnprev.Size = New System.Drawing.Size(32, 29)
        Me.btnprev.TabIndex = 3
        Me.btnprev.Text = "↓"
        Me.btnprev.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.Location = New System.Drawing.Point(40, 97)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(32, 29)
        Me.btnnext.TabIndex = 2
        Me.btnnext.Text = "↑"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.Location = New System.Drawing.Point(13, 62)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(86, 29)
        Me.btndel.TabIndex = 1
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(13, 27)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(86, 29)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "Add New"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel4.Controls.Add(Doctor_s_Ref_NoLabel)
        Me.Panel4.Controls.Add(Me.doc1)
        Me.Panel4.Controls.Add(Doctor_s_NHS_NoLabel)
        Me.Panel4.Controls.Add(Me.doc2)
        Me.Panel4.Controls.Add(FirstnameLabel)
        Me.Panel4.Controls.Add(Me.doc3)
        Me.Panel4.Controls.Add(SurnameLabel)
        Me.Panel4.Controls.Add(Me.doc4)
        Me.Panel4.Controls.Add(Medical_Center_NameLabel)
        Me.Panel4.Controls.Add(Me.doc5)
        Me.Panel4.Controls.Add(Address_of_Medical_CenterLabel)
        Me.Panel4.Controls.Add(Me.doc6)
        Me.Panel4.Controls.Add(Phone_NoLabel)
        Me.Panel4.Controls.Add(Me.doc7)
        Me.Panel4.Controls.Add(Email_AddressLabel)
        Me.Panel4.Controls.Add(Me.doc8)
        Me.Panel4.Controls.Add(Patient_Reference_NoLabel)
        Me.Panel4.Controls.Add(Me.doc9)
        Me.Panel4.Controls.Add(GP_Appointment_Reference_NoLabel)
        Me.Panel4.Controls.Add(Me.doc10)
        Me.Panel4.Controls.Add(Patient_IDLabel)
        Me.Panel4.Controls.Add(Me.doc11)
        Me.Panel4.Location = New System.Drawing.Point(31, 87)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(784, 169)
        Me.Panel4.TabIndex = 9
        '
        'doc1
        '
        Me.doc1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Doctor's Ref No", True))
        Me.doc1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doc1.Location = New System.Drawing.Point(248, 11)
        Me.doc1.Name = "doc1"
        Me.doc1.Size = New System.Drawing.Size(130, 22)
        Me.doc1.TabIndex = 1
        '
        'DoctorFormBindingSource
        '
        Me.DoctorFormBindingSource.DataMember = "DoctorForm"
        Me.DoctorFormBindingSource.DataSource = Me.TeamLeaders_PharmacyMSDataSet
        '
        'TeamLeaders_PharmacyMSDataSet
        '
        Me.TeamLeaders_PharmacyMSDataSet.DataSetName = "TeamLeaders_PharmacyMSDataSet"
        Me.TeamLeaders_PharmacyMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'doc2
        '
        Me.doc2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Doctor's NHS No", True))
        Me.doc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doc2.Location = New System.Drawing.Point(248, 35)
        Me.doc2.Name = "doc2"
        Me.doc2.Size = New System.Drawing.Size(130, 22)
        Me.doc2.TabIndex = 3
        '
        'doc3
        '
        Me.doc3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Firstname", True))
        Me.doc3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doc3.Location = New System.Drawing.Point(248, 59)
        Me.doc3.Name = "doc3"
        Me.doc3.Size = New System.Drawing.Size(130, 22)
        Me.doc3.TabIndex = 5
        '
        'doc4
        '
        Me.doc4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Surname", True))
        Me.doc4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doc4.Location = New System.Drawing.Point(248, 83)
        Me.doc4.Name = "doc4"
        Me.doc4.Size = New System.Drawing.Size(130, 22)
        Me.doc4.TabIndex = 7
        '
        'doc5
        '
        Me.doc5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Medical Center Name", True))
        Me.doc5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doc5.Location = New System.Drawing.Point(248, 107)
        Me.doc5.Name = "doc5"
        Me.doc5.Size = New System.Drawing.Size(130, 22)
        Me.doc5.TabIndex = 9
        '
        'doc6
        '
        Me.doc6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Address of Medical Center", True))
        Me.doc6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doc6.Location = New System.Drawing.Point(248, 131)
        Me.doc6.Name = "doc6"
        Me.doc6.Size = New System.Drawing.Size(130, 22)
        Me.doc6.TabIndex = 11
        '
        'doc7
        '
        Me.doc7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Phone No", True))
        Me.doc7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doc7.Location = New System.Drawing.Point(647, 11)
        Me.doc7.Name = "doc7"
        Me.doc7.Size = New System.Drawing.Size(119, 22)
        Me.doc7.TabIndex = 13
        '
        'doc8
        '
        Me.doc8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Email Address", True))
        Me.doc8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doc8.Location = New System.Drawing.Point(647, 35)
        Me.doc8.Name = "doc8"
        Me.doc8.Size = New System.Drawing.Size(119, 22)
        Me.doc8.TabIndex = 15
        '
        'doc9
        '
        Me.doc9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Patient Reference No", True))
        Me.doc9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doc9.Location = New System.Drawing.Point(647, 59)
        Me.doc9.Name = "doc9"
        Me.doc9.Size = New System.Drawing.Size(119, 22)
        Me.doc9.TabIndex = 17
        '
        'doc10
        '
        Me.doc10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "GP Appointment Reference No", True))
        Me.doc10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doc10.Location = New System.Drawing.Point(647, 83)
        Me.doc10.Name = "doc10"
        Me.doc10.Size = New System.Drawing.Size(119, 22)
        Me.doc10.TabIndex = 19
        '
        'doc11
        '
        Me.doc11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource, "Patient ID", True))
        Me.doc11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.doc11.Location = New System.Drawing.Point(647, 107)
        Me.doc11.Name = "doc11"
        Me.doc11.Size = New System.Drawing.Size(119, 22)
        Me.doc11.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(31, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(784, 62)
        Me.Panel3.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(114, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(518, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Doctors' Information Window"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'DoctorFormBindingNavigatorSaveItem
        '
        Me.DoctorFormBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DoctorFormBindingNavigatorSaveItem.Image = CType(resources.GetObject("DoctorFormBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DoctorFormBindingNavigatorSaveItem.Name = "DoctorFormBindingNavigatorSaveItem"
        Me.DoctorFormBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DoctorFormBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DoctorFormDataGridView
        '
        Me.DoctorFormDataGridView.AutoGenerateColumns = False
        Me.DoctorFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorFormDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.DoctorFormDataGridView.DataSource = Me.DoctorFormBindingSource
        Me.DoctorFormDataGridView.Location = New System.Drawing.Point(31, 270)
        Me.DoctorFormDataGridView.Name = "DoctorFormDataGridView"
        Me.DoctorFormDataGridView.Size = New System.Drawing.Size(918, 230)
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
        Me.ClientSize = New System.Drawing.Size(983, 512)
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
        CType(Me.DoctorFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamLeaders_PharmacyMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
    Friend WithEvents doc1 As System.Windows.Forms.TextBox
    Friend WithEvents doc2 As System.Windows.Forms.TextBox
    Friend WithEvents doc3 As System.Windows.Forms.TextBox
    Friend WithEvents doc4 As System.Windows.Forms.TextBox
    Friend WithEvents doc5 As System.Windows.Forms.TextBox
    Friend WithEvents doc6 As System.Windows.Forms.TextBox
    Friend WithEvents doc7 As System.Windows.Forms.TextBox
    Friend WithEvents doc8 As System.Windows.Forms.TextBox
    Friend WithEvents doc9 As System.Windows.Forms.TextBox
    Friend WithEvents doc10 As System.Windows.Forms.TextBox
    Friend WithEvents doc11 As System.Windows.Forms.TextBox
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
