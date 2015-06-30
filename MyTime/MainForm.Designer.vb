<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.fnameTxtBox = New System.Windows.Forms.TextBox
        Me.lnameTxtBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.fname = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.salute = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.resultListView = New System.Windows.Forms.ListView
        Me.fundingSourcesCombo = New System.Windows.Forms.ComboBox
        Me.fundingLbl = New System.Windows.Forms.Label
        Me.costCentreTxtBox = New System.Windows.Forms.TextBox
        Me.costCentreLbl = New System.Windows.Forms.Label
        Me.costCentreSrchBtn = New System.Windows.Forms.Button
        Me.wbsNoTxtBox = New System.Windows.Forms.TextBox
        Me.serviceElemGroupCombo = New System.Windows.Forms.ComboBox
        Me.funcAreaCombo = New System.Windows.Forms.ComboBox
        Me.businessUnitCombo = New System.Windows.Forms.ComboBox
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(894, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(270, 562)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "&OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(379, 562)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'fnameTxtBox
        '
        Me.fnameTxtBox.Location = New System.Drawing.Point(101, 124)
        Me.fnameTxtBox.Name = "fnameTxtBox"
        Me.fnameTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.fnameTxtBox.TabIndex = 4
        '
        'lnameTxtBox
        '
        Me.lnameTxtBox.Location = New System.Drawing.Point(101, 168)
        Me.lnameTxtBox.Name = "lnameTxtBox"
        Me.lnameTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.lnameTxtBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Salutation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(292, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 33)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Title"
        '
        'fname
        '
        Me.fname.AutoSize = True
        Me.fname.Location = New System.Drawing.Point(22, 127)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(57, 13)
        Me.fname.TabIndex = 8
        Me.fname.Tag = " "
        Me.fname.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Last Name"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(486, 549)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 58)
        Me.Button3.TabIndex = 10
        Me.Button3.UseVisualStyleBackColor = True
        '
        'salute
        '
        Me.salute.FormattingEnabled = True
        Me.salute.Items.AddRange(New Object() {"", "Mr.", "Mrs.", "Ms."})
        Me.salute.Location = New System.Drawing.Point(103, 88)
        Me.salute.Name = "salute"
        Me.salute.Size = New System.Drawing.Size(108, 21)
        Me.salute.TabIndex = 11
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(101, 219)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "BirthDay"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(138, 559)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 28)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Export"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'resultListView
        '
        Me.resultListView.Location = New System.Drawing.Point(83, 392)
        Me.resultListView.Name = "resultListView"
        Me.resultListView.Size = New System.Drawing.Size(669, 118)
        Me.resultListView.TabIndex = 15
        Me.resultListView.UseCompatibleStateImageBehavior = False
        '
        'fundingSourcesCombo
        '
        Me.fundingSourcesCombo.FormattingEnabled = True
        Me.fundingSourcesCombo.Location = New System.Drawing.Point(100, 274)
        Me.fundingSourcesCombo.Name = "fundingSourcesCombo"
        Me.fundingSourcesCombo.Size = New System.Drawing.Size(100, 21)
        Me.fundingSourcesCombo.TabIndex = 16
        '
        'fundingLbl
        '
        Me.fundingLbl.AutoSize = True
        Me.fundingLbl.Location = New System.Drawing.Point(27, 277)
        Me.fundingLbl.Name = "fundingLbl"
        Me.fundingLbl.Size = New System.Drawing.Size(45, 13)
        Me.fundingLbl.TabIndex = 17
        Me.fundingLbl.Text = "Funding"
        '
        'costCentreTxtBox
        '
        Me.costCentreTxtBox.Location = New System.Drawing.Point(373, 145)
        Me.costCentreTxtBox.Name = "costCentreTxtBox"
        Me.costCentreTxtBox.Size = New System.Drawing.Size(80, 20)
        Me.costCentreTxtBox.TabIndex = 18
        '
        'costCentreLbl
        '
        Me.costCentreLbl.AutoSize = True
        Me.costCentreLbl.Location = New System.Drawing.Point(306, 145)
        Me.costCentreLbl.Name = "costCentreLbl"
        Me.costCentreLbl.Size = New System.Drawing.Size(39, 13)
        Me.costCentreLbl.TabIndex = 19
        Me.costCentreLbl.Text = "Label5"
        '
        'costCentreSrchBtn
        '
        Me.costCentreSrchBtn.Location = New System.Drawing.Point(498, 148)
        Me.costCentreSrchBtn.Name = "costCentreSrchBtn"
        Me.costCentreSrchBtn.Size = New System.Drawing.Size(62, 16)
        Me.costCentreSrchBtn.TabIndex = 20
        Me.costCentreSrchBtn.Text = "Button5"
        Me.costCentreSrchBtn.UseVisualStyleBackColor = True
        '
        'wbsNoTxtBox
        '
        Me.wbsNoTxtBox.Location = New System.Drawing.Point(364, 186)
        Me.wbsNoTxtBox.Name = "wbsNoTxtBox"
        Me.wbsNoTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.wbsNoTxtBox.TabIndex = 21
        '
        'serviceElemGroupCombo
        '
        Me.serviceElemGroupCombo.FormattingEnabled = True
        Me.serviceElemGroupCombo.Location = New System.Drawing.Point(364, 222)
        Me.serviceElemGroupCombo.Name = "serviceElemGroupCombo"
        Me.serviceElemGroupCombo.Size = New System.Drawing.Size(121, 21)
        Me.serviceElemGroupCombo.TabIndex = 22
        '
        'funcAreaCombo
        '
        Me.funcAreaCombo.FormattingEnabled = True
        Me.funcAreaCombo.Location = New System.Drawing.Point(364, 277)
        Me.funcAreaCombo.Name = "funcAreaCombo"
        Me.funcAreaCombo.Size = New System.Drawing.Size(121, 21)
        Me.funcAreaCombo.TabIndex = 23
        '
        'businessUnitCombo
        '
        Me.businessUnitCombo.FormattingEnabled = True
        Me.businessUnitCombo.Location = New System.Drawing.Point(364, 249)
        Me.businessUnitCombo.Name = "businessUnitCombo"
        Me.businessUnitCombo.Size = New System.Drawing.Size(121, 21)
        Me.businessUnitCombo.TabIndex = 24
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 655)
        Me.Controls.Add(Me.businessUnitCombo)
        Me.Controls.Add(Me.funcAreaCombo)
        Me.Controls.Add(Me.serviceElemGroupCombo)
        Me.Controls.Add(Me.wbsNoTxtBox)
        Me.Controls.Add(Me.costCentreSrchBtn)
        Me.Controls.Add(Me.costCentreLbl)
        Me.Controls.Add(Me.costCentreTxtBox)
        Me.Controls.Add(Me.fundingLbl)
        Me.Controls.Add(Me.fundingSourcesCombo)
        Me.Controls.Add(Me.resultListView)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.salute)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lnameTxtBox)
        Me.Controls.Add(Me.fnameTxtBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "MyTime"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents fnameTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents lnameTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fname As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents salute As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents resultListView As System.Windows.Forms.ListView
    Friend WithEvents fundingSourcesCombo As System.Windows.Forms.ComboBox
    Friend WithEvents fundingLbl As System.Windows.Forms.Label
    Friend WithEvents costCentreTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents costCentreLbl As System.Windows.Forms.Label
    Friend WithEvents costCentreSrchBtn As System.Windows.Forms.Button
    Friend WithEvents wbsNoTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents serviceElemGroupCombo As System.Windows.Forms.ComboBox
    Friend WithEvents funcAreaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents businessUnitCombo As System.Windows.Forms.ComboBox

End Class
