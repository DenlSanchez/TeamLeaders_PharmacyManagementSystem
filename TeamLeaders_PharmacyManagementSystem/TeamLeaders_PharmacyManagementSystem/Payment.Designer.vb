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
        Me.pay5 = New System.Windows.Forms.TextBox()
        Me.pay7 = New System.Windows.Forms.TextBox()
        Me.pay8 = New System.Windows.Forms.TextBox()
        Me.pay9 = New System.Windows.Forms.TextBox()
        Me.pay1 = New System.Windows.Forms.TextBox()
        Me.pay2 = New System.Windows.Forms.TextBox()
        Me.pay3 = New System.Windows.Forms.TextBox()
        Me.pay4 = New System.Windows.Forms.TextBox()
        Me.pay6 = New System.Windows.Forms.TextBox()
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
        Me.PaymentFormBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TeamLeaders_PharmacyMSDataSet2 = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSet2()
        Me.PaymentFormBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentFormTableAdapter1 = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSet2TableAdapters.PaymentFormTableAdapter()
        Me.TableAdapterManager1 = New TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSet2TableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentFormDataGridView = New System.Windows.Forms.DataGridView()
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
        CType(Me.TeamLeaders_PharmacyMSDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentFormBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentFormDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Invoice_NoLabel
        '
        Invoice_NoLabel.AutoSize = True
        Invoice_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Invoice_NoLabel.Location = New System.Drawing.Point(21, 22)
        Invoice_NoLabel.Name = "Invoice_NoLabel"
        Invoice_NoLabel.Size = New System.Drawing.Size(86, 16)
        Invoice_NoLabel.TabIndex = 0
        Invoice_NoLabel.Text = "Invoice No:"
        '
        'Amount_PaidLabel
        '
        Amount_PaidLabel.AutoSize = True
        Amount_PaidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Amount_PaidLabel.Location = New System.Drawing.Point(21, 50)
        Amount_PaidLabel.Name = "Amount_PaidLabel"
        Amount_PaidLabel.Size = New System.Drawing.Size(99, 16)
        Amount_PaidLabel.TabIndex = 2
        Amount_PaidLabel.Text = "Amount Paid:"
        '
        'Method_of_PaymentLabel
        '
        Method_of_PaymentLabel.AutoSize = True
        Method_of_PaymentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Method_of_PaymentLabel.Location = New System.Drawing.Point(21, 80)
        Method_of_PaymentLabel.Name = "Method_of_PaymentLabel"
        Method_of_PaymentLabel.Size = New System.Drawing.Size(144, 16)
        Method_of_PaymentLabel.TabIndex = 4
        Method_of_PaymentLabel.Text = "Method of Payment:"
        '
        'Patient_IDLabel
        '
        Patient_IDLabel.AutoSize = True
        Patient_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_IDLabel.Location = New System.Drawing.Point(21, 111)
        Patient_IDLabel.Name = "Patient_IDLabel"
        Patient_IDLabel.Size = New System.Drawing.Size(79, 16)
        Patient_IDLabel.TabIndex = 6
        Patient_IDLabel.Text = "Patient ID:"
        '
        'Per_Paid_PlanLabel
        '
        Per_Paid_PlanLabel.AutoSize = True
        Per_Paid_PlanLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Per_Paid_PlanLabel.Location = New System.Drawing.Point(21, 139)
        Per_Paid_PlanLabel.Name = "Per_Paid_PlanLabel"
        Per_Paid_PlanLabel.Size = New System.Drawing.Size(107, 16)
        Per_Paid_PlanLabel.TabIndex = 8
        Per_Paid_PlanLabel.Text = "Per Paid Plan:"
        '
        'Patient_NHS_NoLabel
        '
        Patient_NHS_NoLabel.AutoSize = True
        Patient_NHS_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Patient_NHS_NoLabel.Location = New System.Drawing.Point(378, 19)
        Patient_NHS_NoLabel.Name = "Patient_NHS_NoLabel"
        Patient_NHS_NoLabel.Size = New System.Drawing.Size(120, 16)
        Patient_NHS_NoLabel.TabIndex = 10
        Patient_NHS_NoLabel.Text = "Patient NHS No:"
        '
        'Paid_Thru_CashLabel
        '
        Paid_Thru_CashLabel.AutoSize = True
        Paid_Thru_CashLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Paid_Thru_CashLabel.Location = New System.Drawing.Point(378, 47)
        Paid_Thru_CashLabel.Name = "Paid_Thru_CashLabel"
        Paid_Thru_CashLabel.Size = New System.Drawing.Size(118, 16)
        Paid_Thru_CashLabel.TabIndex = 12
        Paid_Thru_CashLabel.Text = "Paid Thru Cash:"
        '
        'Paid_Thru_Credit_CardLabel
        '
        Paid_Thru_Credit_CardLabel.AutoSize = True
        Paid_Thru_Credit_CardLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Paid_Thru_Credit_CardLabel.Location = New System.Drawing.Point(378, 77)
        Paid_Thru_Credit_CardLabel.Name = "Paid_Thru_Credit_CardLabel"
        Paid_Thru_Credit_CardLabel.Size = New System.Drawing.Size(161, 16)
        Paid_Thru_Credit_CardLabel.TabIndex = 14
        Paid_Thru_Credit_CardLabel.Text = "Paid Thru Credit Card:"
        '
        'Paid_Thru_Debit_CardLabel
        '
        Paid_Thru_Debit_CardLabel.AutoSize = True
        Paid_Thru_Debit_CardLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Paid_Thru_Debit_CardLabel.Location = New System.Drawing.Point(378, 108)
        Paid_Thru_Debit_CardLabel.Name = "Paid_Thru_Debit_CardLabel"
        Paid_Thru_Debit_CardLabel.Size = New System.Drawing.Size(157, 16)
        Paid_Thru_Debit_CardLabel.TabIndex = 16
        Paid_Thru_Debit_CardLabel.Text = "Paid Thru Debit Card:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.pay5)
        Me.Panel1.Controls.Add(Me.pay7)
        Me.Panel1.Controls.Add(Me.pay8)
        Me.Panel1.Controls.Add(Me.pay9)
        Me.Panel1.Controls.Add(Invoice_NoLabel)
        Me.Panel1.Controls.Add(Me.pay1)
        Me.Panel1.Controls.Add(Amount_PaidLabel)
        Me.Panel1.Controls.Add(Me.pay2)
        Me.Panel1.Controls.Add(Method_of_PaymentLabel)
        Me.Panel1.Controls.Add(Me.pay3)
        Me.Panel1.Controls.Add(Patient_IDLabel)
        Me.Panel1.Controls.Add(Me.pay4)
        Me.Panel1.Controls.Add(Per_Paid_PlanLabel)
        Me.Panel1.Controls.Add(Patient_NHS_NoLabel)
        Me.Panel1.Controls.Add(Me.pay6)
        Me.Panel1.Controls.Add(Paid_Thru_CashLabel)
        Me.Panel1.Controls.Add(Paid_Thru_Credit_CardLabel)
        Me.Panel1.Controls.Add(Paid_Thru_Debit_CardLabel)
        Me.Panel1.Location = New System.Drawing.Point(12, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(773, 191)
        Me.Panel1.TabIndex = 27
        '
        'pay5
        '
        Me.pay5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay5.Location = New System.Drawing.Point(172, 136)
        Me.pay5.Name = "pay5"
        Me.pay5.Size = New System.Drawing.Size(188, 22)
        Me.pay5.TabIndex = 20
        '
        'pay7
        '
        Me.pay7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay7.Location = New System.Drawing.Point(550, 44)
        Me.pay7.Name = "pay7"
        Me.pay7.Size = New System.Drawing.Size(197, 22)
        Me.pay7.TabIndex = 17
        '
        'pay8
        '
        Me.pay8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay8.Location = New System.Drawing.Point(550, 74)
        Me.pay8.Name = "pay8"
        Me.pay8.Size = New System.Drawing.Size(197, 22)
        Me.pay8.TabIndex = 18
        '
        'pay9
        '
        Me.pay9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay9.Location = New System.Drawing.Point(550, 105)
        Me.pay9.Name = "pay9"
        Me.pay9.Size = New System.Drawing.Size(197, 22)
        Me.pay9.TabIndex = 19
        '
        'pay1
        '
        Me.pay1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay1.Location = New System.Drawing.Point(172, 16)
        Me.pay1.Name = "pay1"
        Me.pay1.Size = New System.Drawing.Size(188, 22)
        Me.pay1.TabIndex = 1
        '
        'pay2
        '
        Me.pay2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay2.Location = New System.Drawing.Point(172, 44)
        Me.pay2.Name = "pay2"
        Me.pay2.Size = New System.Drawing.Size(188, 22)
        Me.pay2.TabIndex = 3
        '
        'pay3
        '
        Me.pay3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay3.Location = New System.Drawing.Point(172, 74)
        Me.pay3.Name = "pay3"
        Me.pay3.Size = New System.Drawing.Size(188, 22)
        Me.pay3.TabIndex = 5
        '
        'pay4
        '
        Me.pay4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay4.Location = New System.Drawing.Point(172, 105)
        Me.pay4.Name = "pay4"
        Me.pay4.Size = New System.Drawing.Size(188, 22)
        Me.pay4.TabIndex = 7
        '
        'pay6
        '
        Me.pay6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pay6.Location = New System.Drawing.Point(550, 16)
        Me.pay6.Name = "pay6"
        Me.pay6.Size = New System.Drawing.Size(197, 22)
        Me.pay6.TabIndex = 11
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
        Me.GroupBox1.Location = New System.Drawing.Point(804, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(152, 282)
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
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(22, 189)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 36)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Save"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Silver
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(22, 233)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(113, 36)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Close"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Silver
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(57, 147)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(44, 36)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "↓"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Silver
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(57, 106)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 36)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "↑"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(22, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Silver
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(22, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 36)
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
        Me.Panel2.Size = New System.Drawing.Size(773, 81)
        Me.Panel2.TabIndex = 28
        '
        'LblDoctor
        '
        Me.LblDoctor.AutoSize = True
        Me.LblDoctor.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDoctor.Location = New System.Drawing.Point(107, 24)
        Me.LblDoctor.Name = "LblDoctor"
        Me.LblDoctor.Size = New System.Drawing.Size(528, 42)
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
        Me.PaymentFormBindingNavigator.Size = New System.Drawing.Size(972, 25)
        Me.PaymentFormBindingNavigator.TabIndex = 30
        Me.PaymentFormBindingNavigator.Text = "BindingNavigator1"
        Me.PaymentFormBindingNavigator.Visible = False
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
        'PaymentFormBindingNavigatorSaveItem
        '
        Me.PaymentFormBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PaymentFormBindingNavigatorSaveItem.Image = CType(resources.GetObject("PaymentFormBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PaymentFormBindingNavigatorSaveItem.Name = "PaymentFormBindingNavigatorSaveItem"
        Me.PaymentFormBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PaymentFormBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TeamLeaders_PharmacyMSDataSet2
        '
        Me.TeamLeaders_PharmacyMSDataSet2.DataSetName = "TeamLeaders_PharmacyMSDataSet2"
        Me.TeamLeaders_PharmacyMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PaymentFormBindingSource1
        '
        Me.PaymentFormBindingSource1.DataMember = "PaymentForm"
        Me.PaymentFormBindingSource1.DataSource = Me.TeamLeaders_PharmacyMSDataSet2
        '
        'PaymentFormTableAdapter1
        '
        Me.PaymentFormTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.DoctorFormTableAdapter = Nothing
        Me.TableAdapterManager1.GPAFormTableAdapter = Nothing
        Me.TableAdapterManager1.PatientFormTableAdapter = Nothing
        Me.TableAdapterManager1.PaymentFormTableAdapter = Me.PaymentFormTableAdapter1
        Me.TableAdapterManager1.PharmacyFormTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Paid Thru Debit Card"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Paid Thru Debit Card"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Paid Thru Credit Card"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Paid Thru Credit Card"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Paid Thru Cash"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Paid Thru Cash"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Patient NHS No"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Patient NHS No"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Per Paid Plan"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Per Paid Plan"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Patient ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Patient ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Method of Payment"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Method of Payment"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Amount Paid"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Amount Paid"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Invoice No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Invoice No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'PaymentFormDataGridView
        '
        Me.PaymentFormDataGridView.AutoGenerateColumns = False
        Me.PaymentFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PaymentFormDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.PaymentFormDataGridView.DataSource = Me.PaymentFormBindingSource1
        Me.PaymentFormDataGridView.Location = New System.Drawing.Point(12, 324)
        Me.PaymentFormDataGridView.Name = "PaymentFormDataGridView"
        Me.PaymentFormDataGridView.Size = New System.Drawing.Size(944, 220)
        Me.PaymentFormDataGridView.TabIndex = 30
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(972, 550)
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
        CType(Me.TeamLeaders_PharmacyMSDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentFormBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentFormDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pay1 As System.Windows.Forms.TextBox
    Friend WithEvents pay2 As System.Windows.Forms.TextBox
    Friend WithEvents pay3 As System.Windows.Forms.TextBox
    Friend WithEvents pay4 As System.Windows.Forms.TextBox
    Friend WithEvents pay6 As System.Windows.Forms.TextBox
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
    Friend WithEvents TeamLeaders_PharmacyMSDataSet2 As TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSet2
    Friend WithEvents PaymentFormBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PaymentFormTableAdapter1 As TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSet2TableAdapters.PaymentFormTableAdapter
    Friend WithEvents TableAdapterManager1 As TeamLeaders_PharmacyManagementSystem.TeamLeaders_PharmacyMSDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents pay5 As System.Windows.Forms.TextBox
    Friend WithEvents pay7 As System.Windows.Forms.TextBox
    Friend WithEvents pay8 As System.Windows.Forms.TextBox
    Friend WithEvents pay9 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentFormDataGridView As System.Windows.Forms.DataGridView
End Class
