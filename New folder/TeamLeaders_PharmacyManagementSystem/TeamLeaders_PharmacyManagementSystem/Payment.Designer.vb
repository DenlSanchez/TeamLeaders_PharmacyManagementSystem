<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Dim Invoice_NoLabel As System.Windows.Forms.Label
        Dim Amount_PaidLabel As System.Windows.Forms.Label
        Dim Method_of_PaymentLabel As System.Windows.Forms.Label
        Dim Patient_IDLabel As System.Windows.Forms.Label
        Dim Per_Paid_PlanLabel As System.Windows.Forms.Label
        Dim Patient_NHS_NoLabel As System.Windows.Forms.Label
        Dim Paid_Thru_CashLabel As System.Windows.Forms.Label
        Dim Paid_Thru_Credit_CardLabel As System.Windows.Forms.Label
        Dim Paid_Thru_Debit_CardLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Invoice_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_PaidTextBox = New System.Windows.Forms.TextBox()
        Me.Method_of_PaymentTextBox = New System.Windows.Forms.TextBox()
        Me.Patient_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Per_Paid_PlanCheckBox = New System.Windows.Forms.CheckBox()
        Me.Patient_NHS_NoTextBox = New System.Windows.Forms.TextBox()
        Me.Paid_Thru_CashCheckBox = New System.Windows.Forms.CheckBox()
        Me.Paid_Thru_Credit_CardCheckBox = New System.Windows.Forms.CheckBox()
        Me.Paid_Thru_Debit_CardCheckBox = New System.Windows.Forms.CheckBox()
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
        Me.PaymentFormBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentFormTableAdapter = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.PaymentFormTableAdapter()
        Me.TableAdapterManager = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager()
        Me.PaymentFormBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PaymentFormBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PaymentFormDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn4 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Invoice_NoLabel = New System.Windows.Forms.Label()
        Amount_PaidLabel = New System.Windows.Forms.Label()
        Method_of_PaymentLabel = New System.Windows.Forms.Label()
        Patient_IDLabel = New System.Windows.Forms.Label()
        Per_Paid_PlanLabel = New System.Windows.Forms.Label()
        Patient_NHS_NoLabel = New System.Windows.Forms.Label()
        Paid_Thru_CashLabel = New System.Windows.Forms.Label()
        Paid_Thru_Credit_CardLabel = New System.Windows.Forms.Label()
        Paid_Thru_Debit_CardLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TeamLeaders_PharmacyMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentFormBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentFormBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaymentFormBindingNavigator.SuspendLayout()
        CType(Me.PaymentFormDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Invoice_NoLabel)
        Me.Panel1.Controls.Add(Me.Invoice_NoTextBox)
        Me.Panel1.Controls.Add(Amount_PaidLabel)
        Me.Panel1.Controls.Add(Me.Amount_PaidTextBox)
        Me.Panel1.Controls.Add(Method_of_PaymentLabel)
        Me.Panel1.Controls.Add(Me.Method_of_PaymentTextBox)
        Me.Panel1.Controls.Add(Patient_IDLabel)
        Me.Panel1.Controls.Add(Me.Patient_IDTextBox)
        Me.Panel1.Controls.Add(Per_Paid_PlanLabel)
        Me.Panel1.Controls.Add(Me.Per_Paid_PlanCheckBox)
        Me.Panel1.Controls.Add(Patient_NHS_NoLabel)
        Me.Panel1.Controls.Add(Me.Patient_NHS_NoTextBox)
        Me.Panel1.Controls.Add(Paid_Thru_CashLabel)
        Me.Panel1.Controls.Add(Me.Paid_Thru_CashCheckBox)
        Me.Panel1.Controls.Add(Paid_Thru_Credit_CardLabel)
        Me.Panel1.Controls.Add(Me.Paid_Thru_Credit_CardCheckBox)
        Me.Panel1.Controls.Add(Paid_Thru_Debit_CardLabel)
        Me.Panel1.Controls.Add(Me.Paid_Thru_Debit_CardCheckBox)
        Me.Panel1.Location = New System.Drawing.Point(12, 137)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(993, 271)
        Me.Panel1.TabIndex = 27
        '
        'Invoice_NoLabel
        '
        Invoice_NoLabel.AutoSize = True
        Invoice_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Invoice_NoLabel.Location = New System.Drawing.Point(21, 22)
        Invoice_NoLabel.Name = "Invoice_NoLabel"
        Invoice_NoLabel.Size = New System.Drawing.Size(130, 25)
        Invoice_NoLabel.TabIndex = 0
        Invoice_NoLabel.Text = "Invoice No:"
        '
        'Invoice_NoTextBox
        '
        Me.Invoice_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_NoTextBox.Location = New System.Drawing.Point(279, 19)
        Me.Invoice_NoTextBox.Name = "Invoice_NoTextBox"
        Me.Invoice_NoTextBox.Size = New System.Drawing.Size(188, 31)
        Me.Invoice_NoTextBox.TabIndex = 1
        '
        'Amount_PaidLabel
        '
        Amount_PaidLabel.AutoSize = True
        Amount_PaidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Amount_PaidLabel.Location = New System.Drawing.Point(21, 71)
        Amount_PaidLabel.Name = "Amount_PaidLabel"
        Amount_PaidLabel.Size = New System.Drawing.Size(152, 25)
        Amount_PaidLabel.TabIndex = 2
        Amount_PaidLabel.Text = "Amount Paid:"
        '
        'Amount_PaidTextBox
        '
        Me.Amount_PaidTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amount_PaidTextBox.Location = New System.Drawing.Point(279, 68)
        Me.Amount_PaidTextBox.Name = "Amount_PaidTextBox"
        Me.Amount_PaidTextBox.Size = New System.Drawing.Size(188, 31)
        Me.Amount_PaidTextBox.TabIndex = 3
        '
        'Method_of_PaymentLabel
        '
        Method_of_PaymentLabel.AutoSize = True
        Method_of_PaymentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Method_of_PaymentLabel.Location = New System.Drawing.Point(21, 122)
        Method_of_PaymentLabel.Name = "Method_of_PaymentLabel"
        Method_of_PaymentLabel.Size = New System.Drawing.Size(222, 25)
        Method_of_PaymentLabel.TabIndex = 4
        Method_of_PaymentLabel.Text = "Method of Payment:"
        '
        'Method_of_PaymentTextBox
        '
        Me.Method_of_PaymentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Method_of_PaymentTextBox.Location = New System.Drawing.Point(279, 119)
        Me.Method_of_PaymentTextBox.Name = "Method_of_PaymentTextBox"
        Me.Method_of_PaymentTextBox.Size = New System.Drawing.Size(188, 31)
        Me.Method_of_PaymentTextBox.TabIndex = 5
        '
        'Patient_IDLabel
        '
        Patient_IDLabel.AutoSize = True
        Patient_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_IDLabel.Location = New System.Drawing.Point(21, 172)
        Patient_IDLabel.Name = "Patient_IDLabel"
        Patient_IDLabel.Size = New System.Drawing.Size(122, 25)
        Patient_IDLabel.TabIndex = 6
        Patient_IDLabel.Text = "Patient ID:"
        '
        'Patient_IDTextBox
        '
        Me.Patient_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patient_IDTextBox.Location = New System.Drawing.Point(279, 169)
        Me.Patient_IDTextBox.Name = "Patient_IDTextBox"
        Me.Patient_IDTextBox.Size = New System.Drawing.Size(188, 31)
        Me.Patient_IDTextBox.TabIndex = 7
        '
        'Per_Paid_PlanLabel
        '
        Per_Paid_PlanLabel.AutoSize = True
        Per_Paid_PlanLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Per_Paid_PlanLabel.Location = New System.Drawing.Point(21, 225)
        Per_Paid_PlanLabel.Name = "Per_Paid_PlanLabel"
        Per_Paid_PlanLabel.Size = New System.Drawing.Size(163, 25)
        Per_Paid_PlanLabel.TabIndex = 8
        Per_Paid_PlanLabel.Text = "Per Paid Plan:"
        '
        'Per_Paid_PlanCheckBox
        '
        Me.Per_Paid_PlanCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Per_Paid_PlanCheckBox.Location = New System.Drawing.Point(279, 220)
        Me.Per_Paid_PlanCheckBox.Name = "Per_Paid_PlanCheckBox"
        Me.Per_Paid_PlanCheckBox.Size = New System.Drawing.Size(17, 24)
        Me.Per_Paid_PlanCheckBox.TabIndex = 9
        Me.Per_Paid_PlanCheckBox.Text = "CheckBox1"
        Me.Per_Paid_PlanCheckBox.UseVisualStyleBackColor = True
        '
        'Patient_NHS_NoLabel
        '
        Patient_NHS_NoLabel.AutoSize = True
        Patient_NHS_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_NHS_NoLabel.Location = New System.Drawing.Point(511, 19)
        Patient_NHS_NoLabel.Name = "Patient_NHS_NoLabel"
        Patient_NHS_NoLabel.Size = New System.Drawing.Size(183, 25)
        Patient_NHS_NoLabel.TabIndex = 10
        Patient_NHS_NoLabel.Text = "Patient NHS No:"
        '
        'Patient_NHS_NoTextBox
        '
        Me.Patient_NHS_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Patient_NHS_NoTextBox.Location = New System.Drawing.Point(781, 19)
        Me.Patient_NHS_NoTextBox.Name = "Patient_NHS_NoTextBox"
        Me.Patient_NHS_NoTextBox.Size = New System.Drawing.Size(197, 31)
        Me.Patient_NHS_NoTextBox.TabIndex = 11
        '
        'Paid_Thru_CashLabel
        '
        Paid_Thru_CashLabel.AutoSize = True
        Paid_Thru_CashLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Paid_Thru_CashLabel.Location = New System.Drawing.Point(511, 68)
        Paid_Thru_CashLabel.Name = "Paid_Thru_CashLabel"
        Paid_Thru_CashLabel.Size = New System.Drawing.Size(182, 25)
        Paid_Thru_CashLabel.TabIndex = 12
        Paid_Thru_CashLabel.Text = "Paid Thru Cash:"
        '
        'Paid_Thru_CashCheckBox
        '
        Me.Paid_Thru_CashCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paid_Thru_CashCheckBox.Location = New System.Drawing.Point(781, 66)
        Me.Paid_Thru_CashCheckBox.Name = "Paid_Thru_CashCheckBox"
        Me.Paid_Thru_CashCheckBox.Size = New System.Drawing.Size(23, 24)
        Me.Paid_Thru_CashCheckBox.TabIndex = 13
        Me.Paid_Thru_CashCheckBox.Text = "CheckBox1"
        Me.Paid_Thru_CashCheckBox.UseVisualStyleBackColor = True
        '
        'Paid_Thru_Credit_CardLabel
        '
        Paid_Thru_Credit_CardLabel.AutoSize = True
        Paid_Thru_Credit_CardLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Paid_Thru_Credit_CardLabel.Location = New System.Drawing.Point(511, 119)
        Paid_Thru_Credit_CardLabel.Name = "Paid_Thru_Credit_CardLabel"
        Paid_Thru_Credit_CardLabel.Size = New System.Drawing.Size(248, 25)
        Paid_Thru_Credit_CardLabel.TabIndex = 14
        Paid_Thru_Credit_CardLabel.Text = "Paid Thru Credit Card:"
        '
        'Paid_Thru_Credit_CardCheckBox
        '
        Me.Paid_Thru_Credit_CardCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paid_Thru_Credit_CardCheckBox.Location = New System.Drawing.Point(781, 117)
        Me.Paid_Thru_Credit_CardCheckBox.Name = "Paid_Thru_Credit_CardCheckBox"
        Me.Paid_Thru_Credit_CardCheckBox.Size = New System.Drawing.Size(23, 24)
        Me.Paid_Thru_Credit_CardCheckBox.TabIndex = 15
        Me.Paid_Thru_Credit_CardCheckBox.Text = "CheckBox1"
        Me.Paid_Thru_Credit_CardCheckBox.UseVisualStyleBackColor = True
        '
        'Paid_Thru_Debit_CardLabel
        '
        Paid_Thru_Debit_CardLabel.AutoSize = True
        Paid_Thru_Debit_CardLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Paid_Thru_Debit_CardLabel.Location = New System.Drawing.Point(511, 169)
        Paid_Thru_Debit_CardLabel.Name = "Paid_Thru_Debit_CardLabel"
        Paid_Thru_Debit_CardLabel.Size = New System.Drawing.Size(240, 25)
        Paid_Thru_Debit_CardLabel.TabIndex = 16
        Paid_Thru_Debit_CardLabel.Text = "Paid Thru Debit Card:"
        '
        'Paid_Thru_Debit_CardCheckBox
        '
        Me.Paid_Thru_Debit_CardCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paid_Thru_Debit_CardCheckBox.Location = New System.Drawing.Point(781, 167)
        Me.Paid_Thru_Debit_CardCheckBox.Name = "Paid_Thru_Debit_CardCheckBox"
        Me.Paid_Thru_Debit_CardCheckBox.Size = New System.Drawing.Size(23, 24)
        Me.Paid_Thru_Debit_CardCheckBox.TabIndex = 17
        Me.Paid_Thru_Debit_CardCheckBox.Text = "CheckBox1"
        Me.Paid_Thru_Debit_CardCheckBox.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(1026, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 383)
        Me.GroupBox1.TabIndex = 29
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
        Me.Panel2.Location = New System.Drawing.Point(12, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(993, 92)
        Me.Panel2.TabIndex = 28
        '
        'LblDoctor
        '
        Me.LblDoctor.AutoSize = True
        Me.LblDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDoctor.Location = New System.Drawing.Point(13, 14)
        Me.LblDoctor.Name = "LblDoctor"
        Me.LblDoctor.Size = New System.Drawing.Size(896, 73)
        Me.LblDoctor.TabIndex = 0
        Me.LblDoctor.Text = "Payment Information Window"
        '
        'TeamLeaders_PharmacyMSDataSet
        '
        Me.TeamLeaders_PharmacyMSDataSet.DataSetName = "TeamLeaders_PharmacyMSDataSet"
        Me.TeamLeaders_PharmacyMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentFormBindingSource
        '
        Me.PaymentFormBindingSource.DataMember = "PaymentForm"
        Me.PaymentFormBindingSource.DataSource = Me.TeamLeaders_PharmacyMSDataSet
        '
        'PaymentFormTableAdapter
        '
        Me.PaymentFormTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DoctorFormTableAdapter = Nothing
        Me.TableAdapterManager.GPAFormTableAdapter = Nothing
        Me.TableAdapterManager.PatientFormTableAdapter = Nothing
        Me.TableAdapterManager.PaymentFormTableAdapter = Me.PaymentFormTableAdapter
        Me.TableAdapterManager.PharmacyFormTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PaymentFormBindingNavigator
        '
        Me.PaymentFormBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PaymentFormBindingNavigator.BindingSource = Me.PaymentFormBindingSource
        Me.PaymentFormBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PaymentFormBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PaymentFormBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PaymentFormBindingNavigatorSaveItem})
        Me.PaymentFormBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PaymentFormBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PaymentFormBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PaymentFormBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PaymentFormBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PaymentFormBindingNavigator.Name = "PaymentFormBindingNavigator"
        Me.PaymentFormBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PaymentFormBindingNavigator.Size = New System.Drawing.Size(1246, 25)
        Me.PaymentFormBindingNavigator.TabIndex = 30
        Me.PaymentFormBindingNavigator.Text = "BindingNavigator1"
        Me.PaymentFormBindingNavigator.Visible = False
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
        'PaymentFormBindingNavigatorSaveItem
        '
        Me.PaymentFormBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PaymentFormBindingNavigatorSaveItem.Image = CType(resources.GetObject("PaymentFormBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PaymentFormBindingNavigatorSaveItem.Name = "PaymentFormBindingNavigatorSaveItem"
        Me.PaymentFormBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.PaymentFormBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PaymentFormDataGridView
        '
        Me.PaymentFormDataGridView.AutoGenerateColumns = False
        Me.PaymentFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PaymentFormDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3, Me.DataGridViewCheckBoxColumn4})
        Me.PaymentFormDataGridView.DataSource = Me.PaymentFormBindingSource
        Me.PaymentFormDataGridView.Location = New System.Drawing.Point(137, 435)
        Me.PaymentFormDataGridView.Name = "PaymentFormDataGridView"
        Me.PaymentFormDataGridView.Size = New System.Drawing.Size(958, 220)
        Me.PaymentFormDataGridView.TabIndex = 30
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Invoice No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Invoice No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Amount Paid"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Amount Paid"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Method of Payment"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Method of Payment"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Patient ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Per Paid Plan"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Per Paid Plan"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Patient NHS No"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Patient NHS No"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Paid Thru Cash"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Paid Thru Cash"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Paid Thru Credit Card"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Paid Thru Credit Card"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        '
        'DataGridViewCheckBoxColumn4
        '
        Me.DataGridViewCheckBoxColumn4.DataPropertyName = "Paid Thru Debit Card"
        Me.DataGridViewCheckBoxColumn4.HeaderText = "Paid Thru Debit Card"
        Me.DataGridViewCheckBoxColumn4.Name = "DataGridViewCheckBoxColumn4"
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1246, 678)
        Me.Controls.Add(Me.PaymentFormDataGridView)
        Me.Controls.Add(Me.PaymentFormBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TeamLeaders_PharmacyMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentFormBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentFormBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaymentFormBindingNavigator.ResumeLayout(False)
        Me.PaymentFormBindingNavigator.PerformLayout()
        CType(Me.PaymentFormDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Invoice_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amount_PaidTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Method_of_PaymentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Patient_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Per_Paid_PlanCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Patient_NHS_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Paid_Thru_CashCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Paid_Thru_Credit_CardCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Paid_Thru_Debit_CardCheckBox As System.Windows.Forms.CheckBox
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
    Friend WithEvents PaymentFormBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PaymentFormTableAdapter As TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.PaymentFormTableAdapter
    Friend WithEvents TableAdapterManager As TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PaymentFormBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PaymentFormBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PaymentFormDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn4 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
