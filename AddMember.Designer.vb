﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddMember
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
        Me.groupBox1 = New System.Windows.Forms.GroupBox
        Me.txtFinalAmount = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPlan = New System.Windows.Forms.TextBox
        Me.btnPlan = New System.Windows.Forms.Button
        Me.cmbGender = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.label7 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.label6 = New System.Windows.Forms.Label
        Me.dateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.label5 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.label4 = New System.Windows.Forms.Label
        Me.txtContactNo = New System.Windows.Forms.TextBox
        Me.label3 = New System.Windows.Forms.Label
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.button1 = New System.Windows.Forms.Button
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.label1 = New System.Windows.Forms.Label
        Me.groupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupBox1
        '
        Me.groupBox1.BackColor = System.Drawing.Color.MidnightBlue
        Me.groupBox1.Controls.Add(Me.txtFinalAmount)
        Me.groupBox1.Controls.Add(Me.Label10)
        Me.groupBox1.Controls.Add(Me.txtPlan)
        Me.groupBox1.Controls.Add(Me.btnPlan)
        Me.groupBox1.Controls.Add(Me.cmbGender)
        Me.groupBox1.Controls.Add(Me.Label9)
        Me.groupBox1.Controls.Add(Me.txtID)
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.label7)
        Me.groupBox1.Controls.Add(Me.txtAmount)
        Me.groupBox1.Controls.Add(Me.label6)
        Me.groupBox1.Controls.Add(Me.dateTimePicker1)
        Me.groupBox1.Controls.Add(Me.label5)
        Me.groupBox1.Controls.Add(Me.txtAddress)
        Me.groupBox1.Controls.Add(Me.label4)
        Me.groupBox1.Controls.Add(Me.txtContactNo)
        Me.groupBox1.Controls.Add(Me.label3)
        Me.groupBox1.Controls.Add(Me.txtLastName)
        Me.groupBox1.Controls.Add(Me.label2)
        Me.groupBox1.Controls.Add(Me.button1)
        Me.groupBox1.Controls.Add(Me.txtFirstName)
        Me.groupBox1.Controls.Add(Me.label1)
        Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBox1.ForeColor = System.Drawing.Color.White
        Me.groupBox1.Location = New System.Drawing.Point(276, 0)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(440, 741)
        Me.groupBox1.TabIndex = 1
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Fill the following information"
        '
        'txtFinalAmount
        '
        Me.txtFinalAmount.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtFinalAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalAmount.ForeColor = System.Drawing.Color.White
        Me.txtFinalAmount.Location = New System.Drawing.Point(173, 593)
        Me.txtFinalAmount.MaxLength = 10
        Me.txtFinalAmount.Name = "txtFinalAmount"
        Me.txtFinalAmount.Size = New System.Drawing.Size(218, 24)
        Me.txtFinalAmount.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoEllipsis = True
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(48, 595)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 20)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Final Amount"
        '
        'txtPlan
        '
        Me.txtPlan.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtPlan.Enabled = False
        Me.txtPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlan.ForeColor = System.Drawing.Color.White
        Me.txtPlan.Location = New System.Drawing.Point(173, 489)
        Me.txtPlan.MaxLength = 200
        Me.txtPlan.Name = "txtPlan"
        Me.txtPlan.Size = New System.Drawing.Size(218, 24)
        Me.txtPlan.TabIndex = 24
        '
        'btnPlan
        '
        Me.btnPlan.BackgroundImage = Global.Fitness_Club_Management_System.My.Resources.Resources.Untitled_7
        Me.btnPlan.Location = New System.Drawing.Point(397, 489)
        Me.btnPlan.Name = "btnPlan"
        Me.btnPlan.Size = New System.Drawing.Size(37, 24)
        Me.btnPlan.TabIndex = 7
        Me.btnPlan.UseVisualStyleBackColor = True
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.cmbGender.Location = New System.Drawing.Point(173, 237)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(218, 24)
        Me.cmbGender.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoEllipsis = True
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(48, 237)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 20)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Gender"
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.Red
        Me.txtID.Location = New System.Drawing.Point(173, 35)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(218, 24)
        Me.txtID.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoEllipsis = True
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(48, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 20)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "ID"
        '
        'label7
        '
        Me.label7.AutoEllipsis = True
        Me.label7.AutoSize = True
        Me.label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.Location = New System.Drawing.Point(48, 491)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(77, 20)
        Me.label7.TabIndex = 18
        Me.label7.Text = "Plan Type"
        '
        'txtAmount
        '
        Me.txtAmount.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.ForeColor = System.Drawing.Color.White
        Me.txtAmount.Location = New System.Drawing.Point(173, 543)
        Me.txtAmount.MaxLength = 10
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(218, 24)
        Me.txtAmount.TabIndex = 9
        '
        'label6
        '
        Me.label6.AutoEllipsis = True
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.Location = New System.Drawing.Point(48, 545)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(67, 20)
        Me.label6.TabIndex = 16
        Me.label6.Text = "Amount"
        '
        'dateTimePicker1
        '
        Me.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTimePicker1.Location = New System.Drawing.Point(173, 433)
        Me.dateTimePicker1.Name = "dateTimePicker1"
        Me.dateTimePicker1.Size = New System.Drawing.Size(218, 22)
        Me.dateTimePicker1.TabIndex = 6
        '
        'label5
        '
        Me.label5.AutoEllipsis = True
        Me.label5.AutoSize = True
        Me.label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.Location = New System.Drawing.Point(48, 433)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(118, 20)
        Me.label5.TabIndex = 14
        Me.label5.Text = "Date Of Joining"
        '
        'txtAddress
        '
        Me.txtAddress.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.ForeColor = System.Drawing.Color.White
        Me.txtAddress.Location = New System.Drawing.Point(173, 290)
        Me.txtAddress.MaxLength = 200
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAddress.Size = New System.Drawing.Size(218, 112)
        Me.txtAddress.TabIndex = 5
        '
        'label4
        '
        Me.label4.AutoEllipsis = True
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(48, 292)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(66, 20)
        Me.label4.TabIndex = 12
        Me.label4.Text = "Address"
        '
        'txtContactNo
        '
        Me.txtContactNo.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtContactNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactNo.ForeColor = System.Drawing.Color.White
        Me.txtContactNo.Location = New System.Drawing.Point(173, 187)
        Me.txtContactNo.MaxLength = 10
        Me.txtContactNo.Name = "txtContactNo"
        Me.txtContactNo.Size = New System.Drawing.Size(218, 24)
        Me.txtContactNo.TabIndex = 3
        '
        'label3
        '
        Me.label3.AutoEllipsis = True
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(48, 187)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(92, 20)
        Me.label3.TabIndex = 10
        Me.label3.Text = "Contact No."
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.ForeColor = System.Drawing.Color.White
        Me.txtLastName.Location = New System.Drawing.Point(173, 134)
        Me.txtLastName.MaxLength = 200
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(218, 24)
        Me.txtLastName.TabIndex = 2
        '
        'label2
        '
        Me.label2.AutoEllipsis = True
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(48, 134)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(84, 20)
        Me.label2.TabIndex = 8
        Me.label2.Text = "Last Name"
        '
        'button1
        '
        Me.button1.BackColor = System.Drawing.Color.MidnightBlue
        Me.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.White
        Me.button1.Location = New System.Drawing.Point(58, 365)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(61, 28)
        Me.button1.TabIndex = 10
        Me.button1.Text = "Go"
        Me.button1.UseVisualStyleBackColor = False
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.Color.MidnightBlue
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.ForeColor = System.Drawing.Color.White
        Me.txtFirstName.Location = New System.Drawing.Point(173, 85)
        Me.txtFirstName.MaxLength = 200
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(218, 24)
        Me.txtFirstName.TabIndex = 1
        '
        'label1
        '
        Me.label1.AutoEllipsis = True
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(48, 85)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(86, 20)
        Me.label1.TabIndex = 5
        Me.label1.Text = "First Name"
        '
        'AddMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Fitness_Club_Management_System.My.Resources.Resources._1265618_newcommercialspinningbiketr_950a
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(716, 741)
        Me.Controls.Add(Me.groupBox1)
        Me.Name = "AddMember"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fitness Club Management"
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents dateTimePicker1 As System.Windows.Forms.DateTimePicker
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents txtAddress As System.Windows.Forms.TextBox
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents txtContactNo As System.Windows.Forms.TextBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents txtLastName As System.Windows.Forms.TextBox
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents txtFirstName As System.Windows.Forms.TextBox
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtID As System.Windows.Forms.TextBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents cmbGender As System.Windows.Forms.ComboBox
    Private WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnPlan As System.Windows.Forms.Button
    Friend WithEvents txtPlan As System.Windows.Forms.TextBox
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtFinalAmount As System.Windows.Forms.TextBox
    Private WithEvents Label10 As System.Windows.Forms.Label
End Class
