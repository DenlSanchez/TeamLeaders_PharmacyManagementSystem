<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patient
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
        Dim NI_NoLabel As System.Windows.Forms.Label
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim Date_of_BirthLabel As System.Windows.Forms.Label
        Dim Billing_NameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Postal_CodeLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim Patient_IDLabel As System.Windows.Forms.Label
        Dim Patient_NHS_NoLabel As System.Windows.Forms.Label
        Dim GP_Appointment_Reference_NoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Patient))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pat1 = New System.Windows.Forms.TextBox()
        Me.PatientFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamLeaders_PharmacyMSDataSet = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSet()
        Me.pat2 = New System.Windows.Forms.TextBox()
        Me.pat3 = New System.Windows.Forms.TextBox()
        Me.pat4 = New System.Windows.Forms.TextBox()
        Me.pat5 = New System.Windows.Forms.TextBox()
        Me.pat7 = New System.Windows.Forms.TextBox()
        Me.pat6 = New System.Windows.Forms.TextBox()
        Me.pat8 = New System.Windows.Forms.TextBox()
        Me.pat9 = New System.Windows.Forms.TextBox()
        Me.pat10 = New System.Windows.Forms.TextBox()
        Me.pat11 = New System.Windows.Forms.TextBox()
        Me.pat12 = New System.Windows.Forms.TextBox()
        Me.pat13 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblDoctor = New System.Windows.Forms.Label()
        Me.PatientFormTableAdapter = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.PatientFormTableAdapter()
        Me.TableAdapterManager = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager()
        Me.PatientFormBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PatientFormBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PatientFormDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NI_NoLabel = New System.Windows.Forms.Label()
        FirstnameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        Date_of_BirthLabel = New System.Windows.Forms.Label()
        Billing_NameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Postal_CodeLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Patient_IDLabel = New System.Windows.Forms.Label()
        Patient_NHS_NoLabel = New System.Windows.Forms.Label()
        GP_Appointment_Reference_NoLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PatientFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamLeaders_PharmacyMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PatientFormBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientFormBindingNavigator.SuspendLayout()
        CType(Me.PatientFormDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NI_NoLabel
        '
        NI_NoLabel.AutoSize = True
        NI_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NI_NoLabel.Location = New System.Drawing.Point(23, 13)
        NI_NoLabel.Name = "NI_NoLabel"
        NI_NoLabel.Size = New System.Drawing.Size(51, 16)
        NI_NoLabel.TabIndex = 0
        NI_NoLabel.Text = "NI No:"
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstnameLabel.Location = New System.Drawing.Point(23, 42)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(80, 16)
        FirstnameLabel.TabIndex = 2
        FirstnameLabel.Text = "Firstname:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SurnameLabel.Location = New System.Drawing.Point(23, 71)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(73, 16)
        SurnameLabel.TabIndex = 4
        SurnameLabel.Text = "Surname:"
        '
        'Date_of_BirthLabel
        '
        Date_of_BirthLabel.AutoSize = True
        Date_of_BirthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Date_of_BirthLabel.Location = New System.Drawing.Point(23, 99)
        Date_of_BirthLabel.Name = "Date_of_BirthLabel"
        Date_of_BirthLabel.Size = New System.Drawing.Size(97, 16)
        Date_of_BirthLabel.TabIndex = 6
        Date_of_BirthLabel.Text = "Date of Birth:"
        '
        'Billing_NameLabel
        '
        Billing_NameLabel.AutoSize = True
        Billing_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Billing_NameLabel.Location = New System.Drawing.Point(23, 127)
        Billing_NameLabel.Name = "Billing_NameLabel"
        Billing_NameLabel.Size = New System.Drawing.Size(100, 16)
        Billing_NameLabel.TabIndex = 8
        Billing_NameLabel.Text = "Billing Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(23, 181)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(70, 16)
        AddressLabel.TabIndex = 10
        AddressLabel.Text = "Address:"
        '
        'Postal_CodeLabel
        '
        Postal_CodeLabel.AutoSize = True
        Postal_CodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Postal_CodeLabel.Location = New System.Drawing.Point(23, 155)
        Postal_CodeLabel.Name = "Postal_CodeLabel"
        Postal_CodeLabel.Size = New System.Drawing.Size(97, 16)
        Postal_CodeLabel.TabIndex = 12
        Postal_CodeLabel.Text = "Postal Code:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.Location = New System.Drawing.Point(344, 8)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(38, 16)
        CityLabel.TabIndex = 14
        CityLabel.Text = "City:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CountryLabel.Location = New System.Drawing.Point(344, 31)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(64, 16)
        CountryLabel.TabIndex = 16
        CountryLabel.Text = "Country:"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NumberLabel.Location = New System.Drawing.Point(344, 66)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(114, 16)
        Phone_NumberLabel.TabIndex = 18
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'Patient_IDLabel
        '
        Patient_IDLabel.AutoSize = True
        Patient_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_IDLabel.Location = New System.Drawing.Point(344, 94)
        Patient_IDLabel.Name = "Patient_IDLabel"
        Patient_IDLabel.Size = New System.Drawing.Size(79, 16)
        Patient_IDLabel.TabIndex = 20
        Patient_IDLabel.Text = "Patient ID:"
        '
        'Patient_NHS_NoLabel
        '
        Patient_NHS_NoLabel.AutoSize = True
        Patient_NHS_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_NHS_NoLabel.Location = New System.Drawing.Point(344, 122)
        Patient_NHS_NoLabel.Name = "Patient_NHS_NoLabel"
        Patient_NHS_NoLabel.Size = New System.Drawing.Size(120, 16)
        Patient_NHS_NoLabel.TabIndex = 22
        Patient_NHS_NoLabel.Text = "Patient NHS No:"
        '
        'GP_Appointment_Reference_NoLabel
        '
        GP_Appointment_Reference_NoLabel.AutoSize = True
        GP_Appointment_Reference_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GP_Appointment_Reference_NoLabel.Location = New System.Drawing.Point(344, 150)
        GP_Appointment_Reference_NoLabel.Name = "GP_Appointment_Reference_NoLabel"
        GP_Appointment_Reference_NoLabel.Size = New System.Drawing.Size(223, 16)
        GP_Appointment_Reference_NoLabel.TabIndex = 24
        GP_Appointment_Reference_NoLabel.Text = "GP Appointment Reference No:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(NI_NoLabel)
        Me.Panel1.Controls.Add(Me.pat1)
        Me.Panel1.Controls.Add(FirstnameLabel)
        Me.Panel1.Controls.Add(Me.pat2)
        Me.Panel1.Controls.Add(SurnameLabel)
        Me.Panel1.Controls.Add(Me.pat3)
        Me.Panel1.Controls.Add(Date_of_BirthLabel)
        Me.Panel1.Controls.Add(Me.pat4)
        Me.Panel1.Controls.Add(Billing_NameLabel)
        Me.Panel1.Controls.Add(Me.pat5)
        Me.Panel1.Controls.Add(AddressLabel)
        Me.Panel1.Controls.Add(Me.pat7)
        Me.Panel1.Controls.Add(Postal_CodeLabel)
        Me.Panel1.Controls.Add(Me.pat6)
        Me.Panel1.Controls.Add(CityLabel)
        Me.Panel1.Controls.Add(Me.pat8)
        Me.Panel1.Controls.Add(CountryLabel)
        Me.Panel1.Controls.Add(Me.pat9)
        Me.Panel1.Controls.Add(Phone_NumberLabel)
        Me.Panel1.Controls.Add(Me.pat10)
        Me.Panel1.Controls.Add(Patient_IDLabel)
        Me.Panel1.Controls.Add(Me.pat11)
        Me.Panel1.Controls.Add(Patient_NHS_NoLabel)
        Me.Panel1.Controls.Add(Me.pat12)
        Me.Panel1.Controls.Add(GP_Appointment_Reference_NoLabel)
        Me.Panel1.Controls.Add(Me.pat13)
        Me.Panel1.Location = New System.Drawing.Point(20, 139)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(726, 232)
        Me.Panel1.TabIndex = 24
        '
        'pat1
        '
        Me.pat1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientFormBindingSource, "NI No", True))
        Me.pat1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pat1.Location = New System.Drawing.Point(186, 10)
        Me.pat1.Name = "pat1"
        Me.pat1.Size = New System.Drawing.Size(100, 22)
        Me.pat1.TabIndex = 1
        '
        'PatientFormBindingSource
        '
        Me.PatientFormBindingSource.DataMember = "PatientForm"
        Me.PatientFormBindingSource.DataSource = Me.TeamLeaders_PharmacyMSDataSet
        '
        'TeamLeaders_PharmacyMSDataSet
        '
        Me.TeamLeaders_PharmacyMSDataSet.DataSetName = "TeamLeaders_PharmacyMSDataSet"
        Me.TeamLeaders_PharmacyMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pat2
        '
        Me.pat2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientFormBindingSource, "Firstname", True))
        Me.pat2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pat2.Location = New System.Drawing.Point(186, 39)
        Me.pat2.Name = "pat2"
        Me.pat2.Size = New System.Drawing.Size(100, 22)
        Me.pat2.TabIndex = 3
        '
        'pat3
        '
        Me.pat3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientFormBindingSource, "Surname", True))
        Me.pat3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pat3.Location = New System.Drawing.Point(186, 68)
        Me.pat3.Name = "pat3"
        Me.pat3.Size = New System.Drawing.Size(100, 22)
        Me.pat3.TabIndex = 5
        '
        'pat4
        '
        Me.pat4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientFormBindingSource, "Date of Birth", True))
        Me.pat4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pat4.Location = New System.Drawing.Point(186, 96)
        Me.pat4.Name = "pat4"
        Me.pat4.Size = New System.Drawing.Size(100, 22)
        Me.pat4.TabIndex = 7
        '
        'pat5
        '
        Me.pat5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientFormBindingSource, "Billing Name", True))
        Me.pat5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pat5.Location = New System.Drawing.Point(186, 124)
        Me.pat5.Name = "pat5"
        Me.pat5.Size = New System.Drawing.Size(100, 22)
        Me.pat5.TabIndex = 9
        '
        'pat7
        '
        Me.pat7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientFormBindingSource, "Address", True))
        Me.pat7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pat7.Location = New System.Drawing.Point(186, 182)
        Me.pat7.Name = "pat7"
        Me.pat7.Size = New System.Drawing.Size(502, 22)
        Me.pat7.TabIndex = 11
        '
        'pat6
        '
        Me.pat6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientFormBindingSource, "Postal Code", True))
        Me.pat6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pat6.Location = New System.Drawing.Point(186, 152)
        Me.pat6.Name = "pat6"
        Me.pat6.Size = New System.Drawing.Size(100, 22)
        Me.pat6.TabIndex = 13
        '
        'pat8
        '
        Me.pat8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientFormBindingSource, "City", True))
        Me.pat8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pat8.Location = New System.Drawing.Point(588, 11)
        Me.pat8.Name = "pat8"
        Me.pat8.Size = New System.Drawing.Size(100, 22)
        Me.pat8.TabIndex = 15
        '
        'pat9
        '
        Me.pat9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientFormBindingSource, "Country", True))
        Me.pat9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pat9.Location = New System.Drawing.Point(588, 40)
        Me.pat9.Name = "pat9"
        Me.pat9.Size = New System.Drawing.Size(100, 22)
        Me.pat9.TabIndex = 17
        '
        'pat10
        '
        Me.pat10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientFormBindingSource, "Phone Number", True))
        Me.pat10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pat10.Location = New System.Drawing.Point(588, 69)
        Me.pat10.Name = "pat10"
        Me.pat10.Size = New System.Drawing.Size(100, 22)
        Me.pat10.TabIndex = 19
        '
        'pat11
        '
        Me.pat11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientFormBindingSource, "Patient ID", True))
        Me.pat11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pat11.Location = New System.Drawing.Point(588, 97)
        Me.pat11.Name = "pat11"
        Me.pat11.Size = New System.Drawing.Size(100, 22)
        Me.pat11.TabIndex = 21
        '
        'pat12
        '
        Me.pat12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientFormBindingSource, "Patient NHS No", True))
        Me.pat12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pat12.Location = New System.Drawing.Point(588, 125)
        Me.pat12.Name = "pat12"
        Me.pat12.Size = New System.Drawing.Size(100, 22)
        Me.pat12.TabIndex = 23
        '
        'pat13
        '
        Me.pat13.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PatientFormBindingSource, "GP Appointment Reference No", True))
        Me.pat13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pat13.Location = New System.Drawing.Point(588, 153)
        Me.pat13.Name = "pat13"
        Me.pat13.Size = New System.Drawing.Size(100, 22)
        Me.pat13.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(767, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 344)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-1234, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(876, 73)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Doctors' Information Window"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Silver
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(28, 243)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 36)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Silver
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(28, 297)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 36)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Silver
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(48, 192)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(55, 36)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "↓"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(48, 139)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(55, 36)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "↑"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(28, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(28, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel2.Controls.Add(Me.LblDoctor)
        Me.Panel2.Location = New System.Drawing.Point(20, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(726, 92)
        Me.Panel2.TabIndex = 25
        '
        'LblDoctor
        '
        Me.LblDoctor.AutoSize = True
        Me.LblDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDoctor.Location = New System.Drawing.Point(101, 21)
        Me.LblDoctor.Name = "LblDoctor"
        Me.LblDoctor.Size = New System.Drawing.Size(525, 42)
        Me.LblDoctor.TabIndex = 0
        Me.LblDoctor.Text = "Patients' Information Window"
        '
        'PatientFormTableAdapter
        '
        Me.PatientFormTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorFormTableAdapter = Nothing
        Me.TableAdapterManager.GPAFormTableAdapter = Nothing
        Me.TableAdapterManager.PatientFormTableAdapter = Me.PatientFormTableAdapter
        Me.TableAdapterManager.PaymentFormTableAdapter = Nothing
        Me.TableAdapterManager.PharmacyFormTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PatientFormBindingNavigator
        '
        Me.PatientFormBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PatientFormBindingNavigator.BindingSource = Me.PatientFormBindingSource
        Me.PatientFormBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PatientFormBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PatientFormBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PatientFormBindingNavigatorSaveItem})
        Me.PatientFormBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PatientFormBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PatientFormBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PatientFormBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PatientFormBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PatientFormBindingNavigator.Name = "PatientFormBindingNavigator"
        Me.PatientFormBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PatientFormBindingNavigator.Size = New System.Drawing.Size(1254, 25)
        Me.PatientFormBindingNavigator.TabIndex = 27
        Me.PatientFormBindingNavigator.Text = "BindingNavigator1"
        Me.PatientFormBindingNavigator.Visible = False
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
        'PatientFormBindingNavigatorSaveItem
        '
        Me.PatientFormBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PatientFormBindingNavigatorSaveItem.Image = CType(resources.GetObject("PatientFormBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PatientFormBindingNavigatorSaveItem.Name = "PatientFormBindingNavigatorSaveItem"
        Me.PatientFormBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PatientFormBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PatientFormDataGridView
        '
        Me.PatientFormDataGridView.AutoGenerateColumns = False
        Me.PatientFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientFormDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.PatientFormDataGridView.DataSource = Me.PatientFormBindingSource
        Me.PatientFormDataGridView.Location = New System.Drawing.Point(20, 377)
        Me.PatientFormDataGridView.Name = "PatientFormDataGridView"
        Me.PatientFormDataGridView.Size = New System.Drawing.Size(892, 198)
        Me.PatientFormDataGridView.TabIndex = 27
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NI No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NI No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Firstname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Firstname"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Surname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Surname"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Date of Birth"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Date of Birth"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Billing Name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Billing Name"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Postal Code"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Postal Code"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn8.HeaderText = "City"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Country"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Phone Number"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Phone Number"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Patient ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Patient NHS No"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Patient NHS No"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "GP Appointment Reference No"
        Me.DataGridViewTextBoxColumn13.HeaderText = "GP Appointment Reference No"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(939, 587)
        Me.Controls.Add(Me.PatientFormDataGridView)
        Me.Controls.Add(Me.PatientFormBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Patient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Patient"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PatientFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamLeaders_PharmacyMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PatientFormBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientFormBindingNavigator.ResumeLayout(False)
        Me.PatientFormBindingNavigator.PerformLayout()
        CType(Me.PatientFormDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents LblDoctor As System.Windows.Forms.Label
    Friend WithEvents TeamLeaders_PharmacyMSDataSet As TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSet
    Friend WithEvents PatientFormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PatientFormTableAdapter As TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.PatientFormTableAdapter
    Friend WithEvents TableAdapterManager As TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PatientFormBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PatientFormBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents pat1 As System.Windows.Forms.TextBox
    Friend WithEvents pat2 As System.Windows.Forms.TextBox
    Friend WithEvents pat3 As System.Windows.Forms.TextBox
    Friend WithEvents pat4 As System.Windows.Forms.TextBox
    Friend WithEvents pat5 As System.Windows.Forms.TextBox
    Friend WithEvents pat7 As System.Windows.Forms.TextBox
    Friend WithEvents pat6 As System.Windows.Forms.TextBox
    Friend WithEvents pat8 As System.Windows.Forms.TextBox
    Friend WithEvents pat9 As System.Windows.Forms.TextBox
    Friend WithEvents pat10 As System.Windows.Forms.TextBox
    Friend WithEvents pat11 As System.Windows.Forms.TextBox
    Friend WithEvents pat12 As System.Windows.Forms.TextBox
    Friend WithEvents pat13 As System.Windows.Forms.TextBox
    Friend WithEvents PatientFormDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
