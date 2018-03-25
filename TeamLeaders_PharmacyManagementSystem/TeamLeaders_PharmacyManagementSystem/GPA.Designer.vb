<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GPA
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
        Dim GP_Appointment_Reference_NoLabel As System.Windows.Forms.Label
        Dim Patient_NHS_NoLabel As System.Windows.Forms.Label
        Dim GP_AppointmentLabel As System.Windows.Forms.Label
        Dim Patient_Full_NameLabel As System.Windows.Forms.Label
        Dim Patient_IDLabel As System.Windows.Forms.Label
        Dim Medical_Center_NameLabel As System.Windows.Forms.Label
        Dim Doctor_s_NHS_NoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GPA))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gpa1 = New System.Windows.Forms.TextBox()
        Me.GPAFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeamLeaders_PharmacyMSDataSet = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSet()
        Me.gpa2 = New System.Windows.Forms.TextBox()
        Me.gpa3 = New System.Windows.Forms.TextBox()
        Me.gpa4 = New System.Windows.Forms.TextBox()
        Me.gpa5 = New System.Windows.Forms.TextBox()
        Me.gpa6 = New System.Windows.Forms.TextBox()
        Me.gpa7 = New System.Windows.Forms.TextBox()
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
        Me.GPAFormTableAdapter = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.GPAFormTableAdapter()
        Me.TableAdapterManager = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager()
        Me.GPAFormBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.GPAFormBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GPAFormDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        GP_Appointment_Reference_NoLabel = New System.Windows.Forms.Label()
        Patient_NHS_NoLabel = New System.Windows.Forms.Label()
        GP_AppointmentLabel = New System.Windows.Forms.Label()
        Patient_Full_NameLabel = New System.Windows.Forms.Label()
        Patient_IDLabel = New System.Windows.Forms.Label()
        Medical_Center_NameLabel = New System.Windows.Forms.Label()
        Doctor_s_NHS_NoLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.GPAFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamLeaders_PharmacyMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GPAFormBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPAFormBindingNavigator.SuspendLayout()
        CType(Me.GPAFormDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GP_Appointment_Reference_NoLabel
        '
        GP_Appointment_Reference_NoLabel.AutoSize = True
        GP_Appointment_Reference_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GP_Appointment_Reference_NoLabel.Location = New System.Drawing.Point(21, 27)
        GP_Appointment_Reference_NoLabel.Name = "GP_Appointment_Reference_NoLabel"
        GP_Appointment_Reference_NoLabel.Size = New System.Drawing.Size(223, 16)
        GP_Appointment_Reference_NoLabel.TabIndex = 0
        GP_Appointment_Reference_NoLabel.Text = "GP Appointment Reference No:"
        '
        'Patient_NHS_NoLabel
        '
        Patient_NHS_NoLabel.AutoSize = True
        Patient_NHS_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_NHS_NoLabel.Location = New System.Drawing.Point(21, 50)
        Patient_NHS_NoLabel.Name = "Patient_NHS_NoLabel"
        Patient_NHS_NoLabel.Size = New System.Drawing.Size(120, 16)
        Patient_NHS_NoLabel.TabIndex = 2
        Patient_NHS_NoLabel.Text = "Patient NHS No:"
        '
        'GP_AppointmentLabel
        '
        GP_AppointmentLabel.AutoSize = True
        GP_AppointmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GP_AppointmentLabel.Location = New System.Drawing.Point(21, 73)
        GP_AppointmentLabel.Name = "GP_AppointmentLabel"
        GP_AppointmentLabel.Size = New System.Drawing.Size(123, 16)
        GP_AppointmentLabel.TabIndex = 4
        GP_AppointmentLabel.Text = "GP Appointment:"
        '
        'Patient_Full_NameLabel
        '
        Patient_Full_NameLabel.AutoSize = True
        Patient_Full_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_Full_NameLabel.Location = New System.Drawing.Point(21, 96)
        Patient_Full_NameLabel.Name = "Patient_Full_NameLabel"
        Patient_Full_NameLabel.Size = New System.Drawing.Size(134, 16)
        Patient_Full_NameLabel.TabIndex = 6
        Patient_Full_NameLabel.Text = "Patient Full Name:"
        '
        'Patient_IDLabel
        '
        Patient_IDLabel.AutoSize = True
        Patient_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_IDLabel.Location = New System.Drawing.Point(21, 119)
        Patient_IDLabel.Name = "Patient_IDLabel"
        Patient_IDLabel.Size = New System.Drawing.Size(79, 16)
        Patient_IDLabel.TabIndex = 8
        Patient_IDLabel.Text = "Patient ID:"
        '
        'Medical_Center_NameLabel
        '
        Medical_Center_NameLabel.AutoSize = True
        Medical_Center_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Medical_Center_NameLabel.Location = New System.Drawing.Point(21, 142)
        Medical_Center_NameLabel.Name = "Medical_Center_NameLabel"
        Medical_Center_NameLabel.Size = New System.Drawing.Size(161, 16)
        Medical_Center_NameLabel.TabIndex = 10
        Medical_Center_NameLabel.Text = "Medical Center Name:"
        '
        'Doctor_s_NHS_NoLabel
        '
        Doctor_s_NHS_NoLabel.AutoSize = True
        Doctor_s_NHS_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_s_NHS_NoLabel.Location = New System.Drawing.Point(21, 165)
        Doctor_s_NHS_NoLabel.Name = "Doctor_s_NHS_NoLabel"
        Doctor_s_NHS_NoLabel.Size = New System.Drawing.Size(130, 16)
        Doctor_s_NHS_NoLabel.TabIndex = 12
        Doctor_s_NHS_NoLabel.Text = "Doctor's NHS No:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(GP_Appointment_Reference_NoLabel)
        Me.Panel1.Controls.Add(Me.gpa1)
        Me.Panel1.Controls.Add(Patient_NHS_NoLabel)
        Me.Panel1.Controls.Add(Me.gpa2)
        Me.Panel1.Controls.Add(GP_AppointmentLabel)
        Me.Panel1.Controls.Add(Me.gpa3)
        Me.Panel1.Controls.Add(Patient_Full_NameLabel)
        Me.Panel1.Controls.Add(Me.gpa4)
        Me.Panel1.Controls.Add(Patient_IDLabel)
        Me.Panel1.Controls.Add(Me.gpa5)
        Me.Panel1.Controls.Add(Medical_Center_NameLabel)
        Me.Panel1.Controls.Add(Me.gpa6)
        Me.Panel1.Controls.Add(Doctor_s_NHS_NoLabel)
        Me.Panel1.Controls.Add(Me.gpa7)
        Me.Panel1.Location = New System.Drawing.Point(17, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(662, 205)
        Me.Panel1.TabIndex = 21
        '
        'gpa1
        '
        Me.gpa1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPAFormBindingSource, "GP Appointment Reference No", True))
        Me.gpa1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpa1.Location = New System.Drawing.Point(345, 21)
        Me.gpa1.Name = "gpa1"
        Me.gpa1.Size = New System.Drawing.Size(287, 22)
        Me.gpa1.TabIndex = 1
        '
        'GPAFormBindingSource
        '
        Me.GPAFormBindingSource.DataMember = "GPAForm"
        Me.GPAFormBindingSource.DataSource = Me.TeamLeaders_PharmacyMSDataSet
        '
        'TeamLeaders_PharmacyMSDataSet
        '
        Me.TeamLeaders_PharmacyMSDataSet.DataSetName = "TeamLeaders_PharmacyMSDataSet"
        Me.TeamLeaders_PharmacyMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'gpa2
        '
        Me.gpa2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPAFormBindingSource, "Patient NHS No", True))
        Me.gpa2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpa2.Location = New System.Drawing.Point(345, 44)
        Me.gpa2.Name = "gpa2"
        Me.gpa2.Size = New System.Drawing.Size(287, 22)
        Me.gpa2.TabIndex = 3
        '
        'gpa3
        '
        Me.gpa3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPAFormBindingSource, "GP Appointment", True))
        Me.gpa3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpa3.Location = New System.Drawing.Point(345, 67)
        Me.gpa3.Name = "gpa3"
        Me.gpa3.Size = New System.Drawing.Size(287, 22)
        Me.gpa3.TabIndex = 5
        '
        'gpa4
        '
        Me.gpa4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPAFormBindingSource, "Patient Full Name", True))
        Me.gpa4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpa4.Location = New System.Drawing.Point(345, 90)
        Me.gpa4.Name = "gpa4"
        Me.gpa4.Size = New System.Drawing.Size(287, 22)
        Me.gpa4.TabIndex = 7
        '
        'gpa5
        '
        Me.gpa5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPAFormBindingSource, "Patient ID", True))
        Me.gpa5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpa5.Location = New System.Drawing.Point(345, 113)
        Me.gpa5.Name = "gpa5"
        Me.gpa5.Size = New System.Drawing.Size(287, 22)
        Me.gpa5.TabIndex = 9
        '
        'gpa6
        '
        Me.gpa6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPAFormBindingSource, "Medical Center Name", True))
        Me.gpa6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpa6.Location = New System.Drawing.Point(345, 136)
        Me.gpa6.Name = "gpa6"
        Me.gpa6.Size = New System.Drawing.Size(287, 22)
        Me.gpa6.TabIndex = 11
        '
        'gpa7
        '
        Me.gpa7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPAFormBindingSource, "Doctor's NHS No", True))
        Me.gpa7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpa7.Location = New System.Drawing.Point(345, 159)
        Me.gpa7.Name = "gpa7"
        Me.gpa7.Size = New System.Drawing.Size(287, 22)
        Me.gpa7.TabIndex = 13
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
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(698, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(138, 312)
        Me.GroupBox1.TabIndex = 23
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
        Me.Button4.Location = New System.Drawing.Point(22, 218)
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
        Me.Button5.Location = New System.Drawing.Point(22, 264)
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
        Me.Button6.Location = New System.Drawing.Point(43, 172)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(46, 36)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "↓"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(43, 126)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(46, 36)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "↑"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(22, 78)
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
        Me.Button1.Location = New System.Drawing.Point(22, 30)
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
        Me.Panel2.Location = New System.Drawing.Point(17, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(662, 92)
        Me.Panel2.TabIndex = 22
        '
        'LblDoctor
        '
        Me.LblDoctor.AutoSize = True
        Me.LblDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDoctor.Location = New System.Drawing.Point(77, 24)
        Me.LblDoctor.Name = "LblDoctor"
        Me.LblDoctor.Size = New System.Drawing.Size(484, 42)
        Me.LblDoctor.TabIndex = 0
        Me.LblDoctor.Text = "GPAs' Information Window"
        '
        'GPAFormTableAdapter
        '
        Me.GPAFormTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorFormTableAdapter = Nothing
        Me.TableAdapterManager.GPAFormTableAdapter = Me.GPAFormTableAdapter
        Me.TableAdapterManager.PatientFormTableAdapter = Nothing
        Me.TableAdapterManager.PaymentFormTableAdapter = Nothing
        Me.TableAdapterManager.PharmacyFormTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GPAFormBindingNavigator
        '
        Me.GPAFormBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GPAFormBindingNavigator.BindingSource = Me.GPAFormBindingSource
        Me.GPAFormBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GPAFormBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GPAFormBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GPAFormBindingNavigatorSaveItem})
        Me.GPAFormBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GPAFormBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GPAFormBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GPAFormBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GPAFormBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GPAFormBindingNavigator.Name = "GPAFormBindingNavigator"
        Me.GPAFormBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GPAFormBindingNavigator.Size = New System.Drawing.Size(1251, 25)
        Me.GPAFormBindingNavigator.TabIndex = 24
        Me.GPAFormBindingNavigator.Text = "BindingNavigator1"
        Me.GPAFormBindingNavigator.Visible = False
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
        'GPAFormBindingNavigatorSaveItem
        '
        Me.GPAFormBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GPAFormBindingNavigatorSaveItem.Image = CType(resources.GetObject("GPAFormBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GPAFormBindingNavigatorSaveItem.Name = "GPAFormBindingNavigatorSaveItem"
        Me.GPAFormBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.GPAFormBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GPAFormDataGridView
        '
        Me.GPAFormDataGridView.AutoGenerateColumns = False
        Me.GPAFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GPAFormDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.GPAFormDataGridView.DataSource = Me.GPAFormBindingSource
        Me.GPAFormDataGridView.Location = New System.Drawing.Point(61, 361)
        Me.GPAFormDataGridView.Name = "GPAFormDataGridView"
        Me.GPAFormDataGridView.Size = New System.Drawing.Size(755, 139)
        Me.GPAFormDataGridView.TabIndex = 24
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "GP Appointment Reference No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "GP Appointment Reference No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Patient NHS No"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Patient NHS No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "GP Appointment"
        Me.DataGridViewTextBoxColumn3.HeaderText = "GP Appointment"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Patient Full Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Patient Full Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Patient ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Medical Center Name"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Medical Center Name"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Doctor's NHS No"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Doctor's NHS No"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'GPA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(858, 512)
        Me.Controls.Add(Me.GPAFormDataGridView)
        Me.Controls.Add(Me.GPAFormBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "GPA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GPA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GPAFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamLeaders_PharmacyMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GPAFormBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPAFormBindingNavigator.ResumeLayout(False)
        Me.GPAFormBindingNavigator.PerformLayout()
        CType(Me.GPAFormDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GPAFormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GPAFormTableAdapter As TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.GPAFormTableAdapter
    Friend WithEvents TableAdapterManager As TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GPAFormBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents GPAFormBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents gpa1 As System.Windows.Forms.TextBox
    Friend WithEvents gpa2 As System.Windows.Forms.TextBox
    Friend WithEvents gpa3 As System.Windows.Forms.TextBox
    Friend WithEvents gpa4 As System.Windows.Forms.TextBox
    Friend WithEvents gpa5 As System.Windows.Forms.TextBox
    Friend WithEvents gpa6 As System.Windows.Forms.TextBox
    Friend WithEvents gpa7 As System.Windows.Forms.TextBox
    Friend WithEvents GPAFormDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
