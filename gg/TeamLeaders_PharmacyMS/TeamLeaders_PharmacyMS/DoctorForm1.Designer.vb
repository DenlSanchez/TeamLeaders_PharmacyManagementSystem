<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorForm1
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
        Dim GP_Appointment_Refererence_NoLabel As System.Windows.Forms.Label
        Dim Patient_IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorForm1))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Doctor_s_Ref_NoTextBox1 = New System.Windows.Forms.TextBox()
        Me.Doctor_s_NHS_NoTextBox1 = New System.Windows.Forms.TextBox()
        Me.FirstnameTextBox1 = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Medical_Center_NameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Address_of_Medical_CenterTextBox1 = New System.Windows.Forms.TextBox()
        Me.Phone_NoTextBox1 = New System.Windows.Forms.TextBox()
        Me.Email_AddressTextBox1 = New System.Windows.Forms.TextBox()
        Me.Patient_Reference_NoTextBox1 = New System.Windows.Forms.TextBox()
        Me.GP_Appointment_Refererence_NoTextBox1 = New System.Windows.Forms.TextBox()
        Me.Patient_IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TeamLeaders_PharmacyMSDataSet = New TeamLeaders_PharmacyMS.TeamLeaders_PharmacyMSDataSet()
        Me.DoctorFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorFormTableAdapter = New TeamLeaders_PharmacyMS.TeamLeaders_PharmacyMSDataSetTableAdapters.DoctorFormTableAdapter()
        Me.TableAdapterManager = New TeamLeaders_PharmacyMS.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager()
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
        GP_Appointment_Refererence_NoLabel = New System.Windows.Forms.Label()
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
        Me.GroupBox2.Controls.Add(Me.Button10)
        Me.GroupBox2.Controls.Add(Me.Button11)
        Me.GroupBox2.Controls.Add(Me.Button12)
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1045, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(171, 370)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options:"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(27, 312)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(121, 38)
        Me.Button10.TabIndex = 5
        Me.Button10.Text = "Exit"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(27, 259)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(121, 38)
        Me.Button11.TabIndex = 4
        Me.Button11.Text = "Close"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(27, 206)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(121, 38)
        Me.Button12.TabIndex = 3
        Me.Button12.Text = "Previous"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(27, 153)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(121, 38)
        Me.Button9.TabIndex = 2
        Me.Button9.Text = "Next"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(27, 98)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(121, 38)
        Me.Button8.TabIndex = 1
        Me.Button8.Text = "Delete"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(27, 45)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(121, 38)
        Me.Button7.TabIndex = 0
        Me.Button7.Text = "Add New"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel4.Controls.Add(Doctor_s_Ref_NoLabel)
        Me.Panel4.Controls.Add(Me.Doctor_s_Ref_NoTextBox1)
        Me.Panel4.Controls.Add(Doctor_s_NHS_NoLabel)
        Me.Panel4.Controls.Add(Me.Doctor_s_NHS_NoTextBox1)
        Me.Panel4.Controls.Add(FirstnameLabel)
        Me.Panel4.Controls.Add(Me.FirstnameTextBox1)
        Me.Panel4.Controls.Add(SurnameLabel)
        Me.Panel4.Controls.Add(Me.SurnameTextBox1)
        Me.Panel4.Controls.Add(Medical_Center_NameLabel)
        Me.Panel4.Controls.Add(Me.Medical_Center_NameTextBox1)
        Me.Panel4.Controls.Add(Address_of_Medical_CenterLabel)
        Me.Panel4.Controls.Add(Me.Address_of_Medical_CenterTextBox1)
        Me.Panel4.Controls.Add(Phone_NoLabel)
        Me.Panel4.Controls.Add(Me.Phone_NoTextBox1)
        Me.Panel4.Controls.Add(Email_AddressLabel)
        Me.Panel4.Controls.Add(Me.Email_AddressTextBox1)
        Me.Panel4.Controls.Add(Patient_Reference_NoLabel)
        Me.Panel4.Controls.Add(Me.Patient_Reference_NoTextBox1)
        Me.Panel4.Controls.Add(GP_Appointment_Refererence_NoLabel)
        Me.Panel4.Controls.Add(Me.GP_Appointment_Refererence_NoTextBox1)
        Me.Panel4.Controls.Add(Patient_IDLabel)
        Me.Panel4.Controls.Add(Me.Patient_IDTextBox1)
        Me.Panel4.Location = New System.Drawing.Point(31, 130)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(993, 261)
        Me.Panel4.TabIndex = 6
        '
        'Doctor_s_Ref_NoLabel
        '
        Doctor_s_Ref_NoLabel.AutoSize = True
        Doctor_s_Ref_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Doctor_s_Ref_NoLabel.Location = New System.Drawing.Point(18, 21)
        Doctor_s_Ref_NoLabel.Name = "Doctor_s_Ref_NoLabel"
        Doctor_s_Ref_NoLabel.Size = New System.Drawing.Size(184, 25)
        Doctor_s_Ref_NoLabel.TabIndex = 0
        Doctor_s_Ref_NoLabel.Text = "Doctor's Ref No:"
        '
        'Doctor_s_Ref_NoTextBox1
        '
        Me.Doctor_s_Ref_NoTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Doctor_s_Ref_NoTextBox1.Location = New System.Drawing.Point(333, 18)
        Me.Doctor_s_Ref_NoTextBox1.Name = "Doctor_s_Ref_NoTextBox1"
        Me.Doctor_s_Ref_NoTextBox1.Size = New System.Drawing.Size(100, 31)
        Me.Doctor_s_Ref_NoTextBox1.TabIndex = 1
        '
        'Doctor_s_NHS_NoLabel
        '
        Doctor_s_NHS_NoLabel.AutoSize = True
        Doctor_s_NHS_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Doctor_s_NHS_NoLabel.Location = New System.Drawing.Point(18, 60)
        Doctor_s_NHS_NoLabel.Name = "Doctor_s_NHS_NoLabel"
        Doctor_s_NHS_NoLabel.Size = New System.Drawing.Size(195, 25)
        Doctor_s_NHS_NoLabel.TabIndex = 2
        Doctor_s_NHS_NoLabel.Text = "Doctor's NHS No:"
        '
        'Doctor_s_NHS_NoTextBox1
        '
        Me.Doctor_s_NHS_NoTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Doctor_s_NHS_NoTextBox1.Location = New System.Drawing.Point(333, 57)
        Me.Doctor_s_NHS_NoTextBox1.Name = "Doctor_s_NHS_NoTextBox1"
        Me.Doctor_s_NHS_NoTextBox1.Size = New System.Drawing.Size(100, 31)
        Me.Doctor_s_NHS_NoTextBox1.TabIndex = 3
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        FirstnameLabel.Location = New System.Drawing.Point(18, 97)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(123, 25)
        FirstnameLabel.TabIndex = 4
        FirstnameLabel.Text = "Firstname:"
        '
        'FirstnameTextBox1
        '
        Me.FirstnameTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.FirstnameTextBox1.Location = New System.Drawing.Point(333, 94)
        Me.FirstnameTextBox1.Name = "FirstnameTextBox1"
        Me.FirstnameTextBox1.Size = New System.Drawing.Size(100, 31)
        Me.FirstnameTextBox1.TabIndex = 5
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        SurnameLabel.Location = New System.Drawing.Point(18, 132)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(112, 25)
        SurnameLabel.TabIndex = 6
        SurnameLabel.Text = "Surname:"
        '
        'SurnameTextBox1
        '
        Me.SurnameTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.SurnameTextBox1.Location = New System.Drawing.Point(333, 129)
        Me.SurnameTextBox1.Name = "SurnameTextBox1"
        Me.SurnameTextBox1.Size = New System.Drawing.Size(100, 31)
        Me.SurnameTextBox1.TabIndex = 7
        '
        'Medical_Center_NameLabel
        '
        Medical_Center_NameLabel.AutoSize = True
        Medical_Center_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Medical_Center_NameLabel.Location = New System.Drawing.Point(18, 167)
        Medical_Center_NameLabel.Name = "Medical_Center_NameLabel"
        Medical_Center_NameLabel.Size = New System.Drawing.Size(245, 25)
        Medical_Center_NameLabel.TabIndex = 8
        Medical_Center_NameLabel.Text = "Medical Center Name:"
        '
        'Medical_Center_NameTextBox1
        '
        Me.Medical_Center_NameTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Medical_Center_NameTextBox1.Location = New System.Drawing.Point(333, 164)
        Me.Medical_Center_NameTextBox1.Name = "Medical_Center_NameTextBox1"
        Me.Medical_Center_NameTextBox1.Size = New System.Drawing.Size(100, 31)
        Me.Medical_Center_NameTextBox1.TabIndex = 9
        '
        'Address_of_Medical_CenterLabel
        '
        Address_of_Medical_CenterLabel.AutoSize = True
        Address_of_Medical_CenterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Address_of_Medical_CenterLabel.Location = New System.Drawing.Point(18, 203)
        Address_of_Medical_CenterLabel.Name = "Address_of_Medical_CenterLabel"
        Address_of_Medical_CenterLabel.Size = New System.Drawing.Size(298, 25)
        Address_of_Medical_CenterLabel.TabIndex = 10
        Address_of_Medical_CenterLabel.Text = "Address of Medical Center:"
        '
        'Address_of_Medical_CenterTextBox1
        '
        Me.Address_of_Medical_CenterTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Address_of_Medical_CenterTextBox1.Location = New System.Drawing.Point(333, 200)
        Me.Address_of_Medical_CenterTextBox1.Name = "Address_of_Medical_CenterTextBox1"
        Me.Address_of_Medical_CenterTextBox1.Size = New System.Drawing.Size(100, 31)
        Me.Address_of_Medical_CenterTextBox1.TabIndex = 11
        '
        'Phone_NoLabel
        '
        Phone_NoLabel.AutoSize = True
        Phone_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Phone_NoLabel.Location = New System.Drawing.Point(460, 21)
        Phone_NoLabel.Name = "Phone_NoLabel"
        Phone_NoLabel.Size = New System.Drawing.Size(122, 25)
        Phone_NoLabel.TabIndex = 12
        Phone_NoLabel.Text = "Phone No:"
        '
        'Phone_NoTextBox1
        '
        Me.Phone_NoTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Phone_NoTextBox1.Location = New System.Drawing.Point(832, 18)
        Me.Phone_NoTextBox1.Name = "Phone_NoTextBox1"
        Me.Phone_NoTextBox1.Size = New System.Drawing.Size(144, 31)
        Me.Phone_NoTextBox1.TabIndex = 13
        '
        'Email_AddressLabel
        '
        Email_AddressLabel.AutoSize = True
        Email_AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Email_AddressLabel.Location = New System.Drawing.Point(460, 60)
        Email_AddressLabel.Name = "Email_AddressLabel"
        Email_AddressLabel.Size = New System.Drawing.Size(170, 25)
        Email_AddressLabel.TabIndex = 14
        Email_AddressLabel.Text = "Email Address:"
        '
        'Email_AddressTextBox1
        '
        Me.Email_AddressTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Email_AddressTextBox1.Location = New System.Drawing.Point(832, 57)
        Me.Email_AddressTextBox1.Name = "Email_AddressTextBox1"
        Me.Email_AddressTextBox1.Size = New System.Drawing.Size(144, 31)
        Me.Email_AddressTextBox1.TabIndex = 15
        '
        'Patient_Reference_NoLabel
        '
        Patient_Reference_NoLabel.AutoSize = True
        Patient_Reference_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Patient_Reference_NoLabel.Location = New System.Drawing.Point(460, 97)
        Patient_Reference_NoLabel.Name = "Patient_Reference_NoLabel"
        Patient_Reference_NoLabel.Size = New System.Drawing.Size(244, 25)
        Patient_Reference_NoLabel.TabIndex = 16
        Patient_Reference_NoLabel.Text = "Patient Reference No:"
        '
        'Patient_Reference_NoTextBox1
        '
        Me.Patient_Reference_NoTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Patient_Reference_NoTextBox1.Location = New System.Drawing.Point(832, 94)
        Me.Patient_Reference_NoTextBox1.Name = "Patient_Reference_NoTextBox1"
        Me.Patient_Reference_NoTextBox1.Size = New System.Drawing.Size(144, 31)
        Me.Patient_Reference_NoTextBox1.TabIndex = 17
        '
        'GP_Appointment_Refererence_NoLabel
        '
        GP_Appointment_Refererence_NoLabel.AutoSize = True
        GP_Appointment_Refererence_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        GP_Appointment_Refererence_NoLabel.Location = New System.Drawing.Point(460, 132)
        GP_Appointment_Refererence_NoLabel.Name = "GP_Appointment_Refererence_NoLabel"
        GP_Appointment_Refererence_NoLabel.Size = New System.Drawing.Size(361, 25)
        GP_Appointment_Refererence_NoLabel.TabIndex = 18
        GP_Appointment_Refererence_NoLabel.Text = "GP Appointment Refererence No:"
        '
        'GP_Appointment_Refererence_NoTextBox1
        '
        Me.GP_Appointment_Refererence_NoTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.GP_Appointment_Refererence_NoTextBox1.Location = New System.Drawing.Point(832, 129)
        Me.GP_Appointment_Refererence_NoTextBox1.Name = "GP_Appointment_Refererence_NoTextBox1"
        Me.GP_Appointment_Refererence_NoTextBox1.Size = New System.Drawing.Size(144, 31)
        Me.GP_Appointment_Refererence_NoTextBox1.TabIndex = 19
        '
        'Patient_IDLabel
        '
        Patient_IDLabel.AutoSize = True
        Patient_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Patient_IDLabel.Location = New System.Drawing.Point(460, 167)
        Patient_IDLabel.Name = "Patient_IDLabel"
        Patient_IDLabel.Size = New System.Drawing.Size(122, 25)
        Patient_IDLabel.TabIndex = 20
        Patient_IDLabel.Text = "Patient ID:"
        '
        'Patient_IDTextBox1
        '
        Me.Patient_IDTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Patient_IDTextBox1.Location = New System.Drawing.Point(832, 164)
        Me.Patient_IDTextBox1.Name = "Patient_IDTextBox1"
        Me.Patient_IDTextBox1.Size = New System.Drawing.Size(144, 31)
        Me.Patient_IDTextBox1.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(31, 21)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(993, 92)
        Me.Panel3.TabIndex = 5
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
        Me.TableAdapterManager.UpdateOrder = TeamLeaders_PharmacyMS.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.DoctorFormBindingNavigator.TabIndex = 8
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'DoctorFormBindingNavigatorSaveItem
        '
        Me.DoctorFormBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DoctorFormBindingNavigatorSaveItem.Image = CType(resources.GetObject("DoctorFormBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DoctorFormBindingNavigatorSaveItem.Name = "DoctorFormBindingNavigatorSaveItem"
        Me.DoctorFormBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.DoctorFormBindingNavigatorSaveItem.Text = "Save Data"
        '
        'DoctorFormDataGridView
        '
        Me.DoctorFormDataGridView.AutoGenerateColumns = False
        Me.DoctorFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorFormDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.DoctorFormDataGridView.DataSource = Me.DoctorFormBindingSource
        Me.DoctorFormDataGridView.Location = New System.Drawing.Point(31, 414)
        Me.DoctorFormDataGridView.Name = "DoctorFormDataGridView"
        Me.DoctorFormDataGridView.Size = New System.Drawing.Size(1185, 220)
        Me.DoctorFormDataGridView.TabIndex = 8
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
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "GP Appointment Refererence No"
        Me.DataGridViewTextBoxColumn10.HeaderText = "GP Appointment Refererence No"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Patient ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DoctorForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 700)
        Me.Controls.Add(Me.DoctorFormDataGridView)
        Me.Controls.Add(Me.DoctorFormBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "DoctorForm1"
        Me.Text = "DoctorForm1"
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
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Doctor_s_Ref_NoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Doctor_s_NHS_NoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FirstnameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Medical_Center_NameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Address_of_Medical_CenterTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Phone_NoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Email_AddressTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Patient_Reference_NoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GP_Appointment_Refererence_NoTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Patient_IDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TeamLeaders_PharmacyMSDataSet As TeamLeaders_PharmacyMS.TeamLeaders_PharmacyMSDataSet
    Friend WithEvents DoctorFormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DoctorFormTableAdapter As TeamLeaders_PharmacyMS.TeamLeaders_PharmacyMSDataSetTableAdapters.DoctorFormTableAdapter
    Friend WithEvents TableAdapterManager As TeamLeaders_PharmacyMS.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager
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
