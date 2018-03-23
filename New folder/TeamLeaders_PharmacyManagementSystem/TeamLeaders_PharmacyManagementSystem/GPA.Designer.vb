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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GPA))
        Dim GP_Appointment_Reference_NoLabel As System.Windows.Forms.Label
        Dim Patient_NHS_NoLabel As System.Windows.Forms.Label
        Dim GP_AppointmentLabel As System.Windows.Forms.Label
        Dim Patient_Full_NameLabel As System.Windows.Forms.Label
        Dim Patient_IDLabel As System.Windows.Forms.Label
        Dim Medical_Center_NameLabel As System.Windows.Forms.Label
        Dim Doctor_s_NHS_NoLabel As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.TeamLeaders_PharmacyMSDataSet = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSet()
        Me.GPAFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GPAFormTableAdapter = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.GPAFormTableAdapter()
        Me.TableAdapterManager = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager()
        Me.GPAFormBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.GPAFormBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GP_Appointment_Reference_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_NHS_NoTextBox = New System.Windows.Forms.TextBox()
        Me.GP_AppointmentTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_Full_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Medical_Center_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Doctor_s_NHS_NoTextBox = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TeamLeaders_PharmacyMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GPAFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GPAFormBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPAFormBindingNavigator.SuspendLayout()
        CType(Me.GPAFormDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(GP_Appointment_Reference_NoLabel)
        Me.Panel1.Controls.Add(Me.GP_Appointment_Reference_NoTextBox)
        Me.Panel1.Controls.Add(Patient_NHS_NoLabel)
        Me.Panel1.Controls.Add(Me.Patient_NHS_NoTextBox)
        Me.Panel1.Controls.Add(GP_AppointmentLabel)
        Me.Panel1.Controls.Add(Me.GP_AppointmentTextBox)
        Me.Panel1.Controls.Add(Patient_Full_NameLabel)
        Me.Panel1.Controls.Add(Me.Patient_Full_NameTextBox)
        Me.Panel1.Controls.Add(Patient_IDLabel)
        Me.Panel1.Controls.Add(Me.Patient_IDTextBox)
        Me.Panel1.Controls.Add(Medical_Center_NameLabel)
        Me.Panel1.Controls.Add(Me.Medical_Center_NameTextBox)
        Me.Panel1.Controls.Add(Doctor_s_NHS_NoLabel)
        Me.Panel1.Controls.Add(Me.Doctor_s_NHS_NoTextBox)
        Me.Panel1.Location = New System.Drawing.Point(17, 145)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(993, 271)
        Me.Panel1.TabIndex = 21
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
        Me.GroupBox1.Location = New System.Drawing.Point(1031, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 383)
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
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(28, 316)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(154, 36)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Silver
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(28, 264)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(154, 36)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Silver
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(28, 212)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(154, 36)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Previous"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(28, 159)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(154, 36)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Next"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(28, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(28, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 36)
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
        Me.Panel2.Size = New System.Drawing.Size(993, 92)
        Me.Panel2.TabIndex = 22
        '
        'LblDoctor
        '
        Me.LblDoctor.AutoSize = True
        Me.LblDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDoctor.Location = New System.Drawing.Point(13, 14)
        Me.LblDoctor.Name = "LblDoctor"
        Me.LblDoctor.Size = New System.Drawing.Size(820, 73)
        Me.LblDoctor.TabIndex = 0
        Me.LblDoctor.Text = "GPAs' Information Window"
        '
        'TeamLeaders_PharmacyMSDataSet
        '
        Me.TeamLeaders_PharmacyMSDataSet.DataSetName = "TeamLeaders_PharmacyMSDataSet"
        Me.TeamLeaders_PharmacyMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GPAFormBindingSource
        '
        Me.GPAFormBindingSource.DataMember = "GPAForm"
        Me.GPAFormBindingSource.DataSource = Me.TeamLeaders_PharmacyMSDataSet
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
        'GPAFormBindingNavigatorSaveItem
        '
        Me.GPAFormBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GPAFormBindingNavigatorSaveItem.Image = CType(resources.GetObject("GPAFormBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GPAFormBindingNavigatorSaveItem.Name = "GPAFormBindingNavigatorSaveItem"
        Me.GPAFormBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.GPAFormBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GP_Appointment_Reference_NoLabel
        '
        GP_Appointment_Reference_NoLabel.AutoSize = True
        GP_Appointment_Reference_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GP_Appointment_Reference_NoLabel.Location = New System.Drawing.Point(21, 27)
        GP_Appointment_Reference_NoLabel.Name = "GP_Appointment_Reference_NoLabel"
        GP_Appointment_Reference_NoLabel.Size = New System.Drawing.Size(340, 25)
        GP_Appointment_Reference_NoLabel.TabIndex = 0
        GP_Appointment_Reference_NoLabel.Text = "GP Appointment Reference No:"
        '
        'GP_Appointment_Reference_NoTextBox
        '
        Me.GP_Appointment_Reference_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPAFormBindingSource, "GP Appointment Reference No", True))
        Me.GP_Appointment_Reference_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GP_Appointment_Reference_NoTextBox.Location = New System.Drawing.Point(503, 24)
        Me.GP_Appointment_Reference_NoTextBox.Name = "GP_Appointment_Reference_NoTextBox"
        Me.GP_Appointment_Reference_NoTextBox.Size = New System.Drawing.Size(413, 31)
        Me.GP_Appointment_Reference_NoTextBox.TabIndex = 1
        '
        'Patient_NHS_NoLabel
        '
        Patient_NHS_NoLabel.AutoSize = True
        Patient_NHS_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_NHS_NoLabel.Location = New System.Drawing.Point(21, 60)
        Patient_NHS_NoLabel.Name = "Patient_NHS_NoLabel"
        Patient_NHS_NoLabel.Size = New System.Drawing.Size(183, 25)
        Patient_NHS_NoLabel.TabIndex = 2
        Patient_NHS_NoLabel.Text = "Patient NHS No:"
        '
        'Patient_NHS_NoTextBox
        '
        Me.Patient_NHS_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPAFormBindingSource, "Patient NHS No", True))
        Me.Patient_NHS_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patient_NHS_NoTextBox.Location = New System.Drawing.Point(503, 57)
        Me.Patient_NHS_NoTextBox.Name = "Patient_NHS_NoTextBox"
        Me.Patient_NHS_NoTextBox.Size = New System.Drawing.Size(413, 31)
        Me.Patient_NHS_NoTextBox.TabIndex = 3
        '
        'GP_AppointmentLabel
        '
        GP_AppointmentLabel.AutoSize = True
        GP_AppointmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GP_AppointmentLabel.Location = New System.Drawing.Point(21, 93)
        GP_AppointmentLabel.Name = "GP_AppointmentLabel"
        GP_AppointmentLabel.Size = New System.Drawing.Size(189, 25)
        GP_AppointmentLabel.TabIndex = 4
        GP_AppointmentLabel.Text = "GP Appointment:"
        '
        'GP_AppointmentTextBox
        '
        Me.GP_AppointmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPAFormBindingSource, "GP Appointment", True))
        Me.GP_AppointmentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GP_AppointmentTextBox.Location = New System.Drawing.Point(503, 90)
        Me.GP_AppointmentTextBox.Name = "GP_AppointmentTextBox"
        Me.GP_AppointmentTextBox.Size = New System.Drawing.Size(413, 31)
        Me.GP_AppointmentTextBox.TabIndex = 5
        '
        'Patient_Full_NameLabel
        '
        Patient_Full_NameLabel.AutoSize = True
        Patient_Full_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_Full_NameLabel.Location = New System.Drawing.Point(21, 126)
        Patient_Full_NameLabel.Name = "Patient_Full_NameLabel"
        Patient_Full_NameLabel.Size = New System.Drawing.Size(206, 25)
        Patient_Full_NameLabel.TabIndex = 6
        Patient_Full_NameLabel.Text = "Patient Full Name:"
        '
        'Patient_Full_NameTextBox
        '
        Me.Patient_Full_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPAFormBindingSource, "Patient Full Name", True))
        Me.Patient_Full_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patient_Full_NameTextBox.Location = New System.Drawing.Point(503, 123)
        Me.Patient_Full_NameTextBox.Name = "Patient_Full_NameTextBox"
        Me.Patient_Full_NameTextBox.Size = New System.Drawing.Size(413, 31)
        Me.Patient_Full_NameTextBox.TabIndex = 7
        '
        'Patient_IDLabel
        '
        Patient_IDLabel.AutoSize = True
        Patient_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_IDLabel.Location = New System.Drawing.Point(21, 159)
        Patient_IDLabel.Name = "Patient_IDLabel"
        Patient_IDLabel.Size = New System.Drawing.Size(122, 25)
        Patient_IDLabel.TabIndex = 8
        Patient_IDLabel.Text = "Patient ID:"
        '
        'Patient_IDTextBox
        '
        Me.Patient_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPAFormBindingSource, "Patient ID", True))
        Me.Patient_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patient_IDTextBox.Location = New System.Drawing.Point(503, 156)
        Me.Patient_IDTextBox.Name = "Patient_IDTextBox"
        Me.Patient_IDTextBox.Size = New System.Drawing.Size(413, 31)
        Me.Patient_IDTextBox.TabIndex = 9
        '
        'Medical_Center_NameLabel
        '
        Medical_Center_NameLabel.AutoSize = True
        Medical_Center_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Medical_Center_NameLabel.Location = New System.Drawing.Point(21, 192)
        Medical_Center_NameLabel.Name = "Medical_Center_NameLabel"
        Medical_Center_NameLabel.Size = New System.Drawing.Size(245, 25)
        Medical_Center_NameLabel.TabIndex = 10
        Medical_Center_NameLabel.Text = "Medical Center Name:"
        '
        'Medical_Center_NameTextBox
        '
        Me.Medical_Center_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPAFormBindingSource, "Medical Center Name", True))
        Me.Medical_Center_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Medical_Center_NameTextBox.Location = New System.Drawing.Point(503, 189)
        Me.Medical_Center_NameTextBox.Name = "Medical_Center_NameTextBox"
        Me.Medical_Center_NameTextBox.Size = New System.Drawing.Size(413, 31)
        Me.Medical_Center_NameTextBox.TabIndex = 11
        '
        'Doctor_s_NHS_NoLabel
        '
        Doctor_s_NHS_NoLabel.AutoSize = True
        Doctor_s_NHS_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Doctor_s_NHS_NoLabel.Location = New System.Drawing.Point(21, 226)
        Doctor_s_NHS_NoLabel.Name = "Doctor_s_NHS_NoLabel"
        Doctor_s_NHS_NoLabel.Size = New System.Drawing.Size(195, 25)
        Doctor_s_NHS_NoLabel.TabIndex = 12
        Doctor_s_NHS_NoLabel.Text = "Doctor's NHS No:"
        '
        'Doctor_s_NHS_NoTextBox
        '
        Me.Doctor_s_NHS_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GPAFormBindingSource, "Doctor's NHS No", True))
        Me.Doctor_s_NHS_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doctor_s_NHS_NoTextBox.Location = New System.Drawing.Point(503, 223)
        Me.Doctor_s_NHS_NoTextBox.Name = "Doctor_s_NHS_NoTextBox"
        Me.Doctor_s_NHS_NoTextBox.Size = New System.Drawing.Size(413, 31)
        Me.Doctor_s_NHS_NoTextBox.TabIndex = 13
        '
        'GPAFormDataGridView
        '
        Me.GPAFormDataGridView.AutoGenerateColumns = False
        Me.GPAFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GPAFormDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.GPAFormDataGridView.DataSource = Me.GPAFormBindingSource
        Me.GPAFormDataGridView.Location = New System.Drawing.Point(250, 456)
        Me.GPAFormDataGridView.Name = "GPAFormDataGridView"
        Me.GPAFormDataGridView.Size = New System.Drawing.Size(760, 253)
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
        Me.ClientSize = New System.Drawing.Size(1251, 738)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TeamLeaders_PharmacyMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GPAFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GP_Appointment_Reference_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Patient_NHS_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GP_AppointmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Patient_Full_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Patient_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Medical_Center_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Doctor_s_NHS_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GPAFormDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
