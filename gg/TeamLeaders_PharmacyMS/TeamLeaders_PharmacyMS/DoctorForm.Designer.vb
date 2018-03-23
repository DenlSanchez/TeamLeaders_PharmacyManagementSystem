<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DoctorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DoctorForm))
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TeamLeaders_PharmacyMSDataSet1 = New TeamLeaders_PharmacyMS.TeamLeaders_PharmacyMSDataSet()
        Me.DoctorFormBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DoctorFormTableAdapter1 = New TeamLeaders_PharmacyMS.TeamLeaders_PharmacyMSDataSetTableAdapters.DoctorFormTableAdapter()
        Me.TableAdapterManager1 = New TeamLeaders_PharmacyMS.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager()
        Me.DoctorFormBindingSource1BindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.DoctorFormBindingSource1BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.DoctorFormDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.TeamLeaders_PharmacyMSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorFormBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoctorFormBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DoctorFormBindingSource1BindingNavigator.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DoctorFormDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(41, 29)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(993, 92)
        Me.Panel3.TabIndex = 0
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
        Me.Panel4.Location = New System.Drawing.Point(41, 138)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(993, 261)
        Me.Panel4.TabIndex = 1
        '
        'TeamLeaders_PharmacyMSDataSet1
        '
        Me.TeamLeaders_PharmacyMSDataSet1.DataSetName = "TeamLeaders_PharmacyMSDataSet"
        Me.TeamLeaders_PharmacyMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DoctorFormBindingSource1
        '
        Me.DoctorFormBindingSource1.DataMember = "DoctorForm"
        Me.DoctorFormBindingSource1.DataSource = Me.TeamLeaders_PharmacyMSDataSet1
        '
        'DoctorFormTableAdapter1
        '
        Me.DoctorFormTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.DoctorFormTableAdapter = Me.DoctorFormTableAdapter1
        Me.TableAdapterManager1.GPAFormTableAdapter = Nothing
        Me.TableAdapterManager1.PatientFormTableAdapter = Nothing
        Me.TableAdapterManager1.PaymentFormTableAdapter = Nothing
        Me.TableAdapterManager1.PharmacyFormTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = TeamLeaders_PharmacyMS.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DoctorFormBindingSource1BindingNavigator
        '
        Me.DoctorFormBindingSource1BindingNavigator.AddNewItem = Me.ToolStripButton5
        Me.DoctorFormBindingSource1BindingNavigator.BindingSource = Me.DoctorFormBindingSource1
        Me.DoctorFormBindingSource1BindingNavigator.CountItem = Me.ToolStripLabel1
        Me.DoctorFormBindingSource1BindingNavigator.DeleteItem = Me.ToolStripButton6
        Me.DoctorFormBindingSource1BindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton6, Me.DoctorFormBindingSource1BindingNavigatorSaveItem})
        Me.DoctorFormBindingSource1BindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.DoctorFormBindingSource1BindingNavigator.MoveFirstItem = Me.ToolStripButton1
        Me.DoctorFormBindingSource1BindingNavigator.MoveLastItem = Me.ToolStripButton4
        Me.DoctorFormBindingSource1BindingNavigator.MoveNextItem = Me.ToolStripButton3
        Me.DoctorFormBindingSource1BindingNavigator.MovePreviousItem = Me.ToolStripButton2
        Me.DoctorFormBindingSource1BindingNavigator.Name = "DoctorFormBindingSource1BindingNavigator"
        Me.DoctorFormBindingSource1BindingNavigator.PositionItem = Me.ToolStripTextBox1
        Me.DoctorFormBindingSource1BindingNavigator.Size = New System.Drawing.Size(1238, 25)
        Me.DoctorFormBindingSource1BindingNavigator.TabIndex = 2
        Me.DoctorFormBindingSource1BindingNavigator.Text = "BindingNavigator1"
        Me.DoctorFormBindingSource1BindingNavigator.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "BindingNavigatorMoveFirstItem"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Move first"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "BindingNavigatorMovePreviousItem"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "BindingNavigatorSeparator"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "BindingNavigatorPositionItem"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "BindingNavigatorCountItem"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "BindingNavigatorSeparator"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "BindingNavigatorMoveNextItem"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move next"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "BindingNavigatorMoveLastItem"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "BindingNavigatorSeparator"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "BindingNavigatorAddNewItem"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Add new"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "BindingNavigatorDeleteItem"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Delete"
        '
        'DoctorFormBindingSource1BindingNavigatorSaveItem
        '
        Me.DoctorFormBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DoctorFormBindingSource1BindingNavigatorSaveItem.Image = CType(resources.GetObject("DoctorFormBindingSource1BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DoctorFormBindingSource1BindingNavigatorSaveItem.Name = "DoctorFormBindingSource1BindingNavigatorSaveItem"
        Me.DoctorFormBindingSource1BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.DoctorFormBindingSource1BindingNavigatorSaveItem.Text = "Save Data"
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
        Me.Doctor_s_Ref_NoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource1, "Doctor's Ref No", True))
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
        Me.Doctor_s_NHS_NoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource1, "Doctor's NHS No", True))
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
        Me.FirstnameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource1, "Firstname", True))
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
        Me.SurnameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource1, "Surname", True))
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
        Me.Medical_Center_NameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource1, "Medical Center Name", True))
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
        Me.Address_of_Medical_CenterTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource1, "Address of Medical Center", True))
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
        Me.Phone_NoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource1, "Phone No", True))
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
        Me.Email_AddressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource1, "Email Address", True))
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
        Me.Patient_Reference_NoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource1, "Patient Reference No", True))
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
        Me.GP_Appointment_Refererence_NoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource1, "GP Appointment Refererence No", True))
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
        Me.Patient_IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DoctorFormBindingSource1, "Patient ID", True))
        Me.Patient_IDTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.Patient_IDTextBox1.Location = New System.Drawing.Point(832, 164)
        Me.Patient_IDTextBox1.Name = "Patient_IDTextBox1"
        Me.Patient_IDTextBox1.Size = New System.Drawing.Size(144, 31)
        Me.Patient_IDTextBox1.TabIndex = 21
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
        Me.GroupBox2.Location = New System.Drawing.Point(1055, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(171, 370)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options:"
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
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(27, 98)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(121, 38)
        Me.Button8.TabIndex = 1
        Me.Button8.Text = "Delete"
        Me.Button8.UseVisualStyleBackColor = True
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
        'DoctorFormDataGridView1
        '
        Me.DoctorFormDataGridView1.AutoGenerateColumns = False
        Me.DoctorFormDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorFormDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.DoctorFormDataGridView1.DataSource = Me.DoctorFormBindingSource1
        Me.DoctorFormDataGridView1.Location = New System.Drawing.Point(41, 416)
        Me.DoctorFormDataGridView1.Name = "DoctorFormDataGridView1"
        Me.DoctorFormDataGridView1.Size = New System.Drawing.Size(1175, 272)
        Me.DoctorFormDataGridView1.TabIndex = 4
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Doctor's Ref No"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Doctor's Ref No"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Doctor's NHS No"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Doctor's NHS No"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Firstname"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Firstname"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Medical Center Name"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Medical Center Name"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Address of Medical Center"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Address of Medical Center"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Phone No"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Phone No"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Email Address"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Email Address"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Patient Reference No"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Patient Reference No"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "GP Appointment Refererence No"
        Me.DataGridViewTextBoxColumn21.HeaderText = "GP Appointment Refererence No"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Patient ID"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DoctorForm
        '
        Me.ClientSize = New System.Drawing.Size(1246, 700)
        Me.Controls.Add(Me.DoctorFormDataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DoctorFormBindingSource1BindingNavigator)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "DoctorForm"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.TeamLeaders_PharmacyMSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorFormBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoctorFormBindingSource1BindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DoctorFormBindingSource1BindingNavigator.ResumeLayout(False)
        Me.DoctorFormBindingSource1BindingNavigator.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DoctorFormDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LblDoctor As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Doctor_s_Ref_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Doctor_s_NHS_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SurnameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Medical_Center_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Address_of_Medical_CenterTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Phone_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Email_AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Patient_Reference_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GP_Appointment_Refererence_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Patient_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DoctorFormDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TeamLeaders_PharmacyMSDataSet1 As TeamLeaders_PharmacyMS.TeamLeaders_PharmacyMSDataSet
    Friend WithEvents DoctorFormBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DoctorFormTableAdapter1 As TeamLeaders_PharmacyMS.TeamLeaders_PharmacyMSDataSetTableAdapters.DoctorFormTableAdapter
    Friend WithEvents TableAdapterManager1 As TeamLeaders_PharmacyMS.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DoctorFormBindingSource1BindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DoctorFormBindingSource1BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents DoctorFormDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
