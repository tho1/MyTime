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
        Me.OKBtn = New System.Windows.Forms.Button
        Me.cancelBtn = New System.Windows.Forms.Button
        Me.fnameTxtBox = New System.Windows.Forms.TextBox
        Me.lnameTxtBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.fname = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.picBtn = New System.Windows.Forms.Button
        Me.salute = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.exportBtn = New System.Windows.Forms.Button
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
        Me.saveBtn = New System.Windows.Forms.Button
        Me.delBtn = New System.Windows.Forms.Button
        Me.EditBtn = New System.Windows.Forms.Button
        Me.AddBtn = New System.Windows.Forms.Button
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.ccCodeTxtBox = New System.Windows.Forms.TextBox
        Me.ccDescTxtBox = New System.Windows.Forms.TextBox
        Me.ccShortDescTxtBox = New System.Windows.Forms.TextBox
        Me.wbsTxtbox = New System.Windows.Forms.TextBox
        Me.closeBtn = New System.Windows.Forms.Button
        Me.SearchBtn = New System.Windows.Forms.Button
        Me.ClearSearchBtn = New System.Windows.Forms.Button
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
        'OKBtn
        '
        Me.OKBtn.Location = New System.Drawing.Point(232, 508)
        Me.OKBtn.Name = "OKBtn"
        Me.OKBtn.Size = New System.Drawing.Size(75, 23)
        Me.OKBtn.TabIndex = 1
        Me.OKBtn.Text = "&OK"
        Me.OKBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(341, 508)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelBtn.TabIndex = 2
        Me.cancelBtn.Text = "&Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
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
        'picBtn
        '
        Me.picBtn.Image = CType(resources.GetObject("picBtn.Image"), System.Drawing.Image)
        Me.picBtn.Location = New System.Drawing.Point(448, 495)
        Me.picBtn.Name = "picBtn"
        Me.picBtn.Size = New System.Drawing.Size(66, 58)
        Me.picBtn.TabIndex = 10
        Me.picBtn.UseVisualStyleBackColor = True
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
        'exportBtn
        '
        Me.exportBtn.Location = New System.Drawing.Point(100, 505)
        Me.exportBtn.Name = "exportBtn"
        Me.exportBtn.Size = New System.Drawing.Size(88, 28)
        Me.exportBtn.TabIndex = 14
        Me.exportBtn.Text = "Export"
        Me.exportBtn.UseVisualStyleBackColor = True
        '
        'resultListView
        '
        Me.resultListView.FullRowSelect = True
        Me.resultListView.GridLines = True
        Me.resultListView.HideSelection = False
        Me.resultListView.Location = New System.Drawing.Point(51, 338)
        Me.resultListView.MultiSelect = False
        Me.resultListView.Name = "resultListView"
        Me.resultListView.Size = New System.Drawing.Size(669, 118)
        Me.resultListView.TabIndex = 15
        Me.resultListView.UseCompatibleStateImageBehavior = False
        Me.resultListView.View = System.Windows.Forms.View.Details
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
        Me.costCentreTxtBox.Location = New System.Drawing.Point(265, 147)
        Me.costCentreTxtBox.Name = "costCentreTxtBox"
        Me.costCentreTxtBox.Size = New System.Drawing.Size(80, 20)
        Me.costCentreTxtBox.TabIndex = 18
        '
        'costCentreLbl
        '
        Me.costCentreLbl.AutoSize = True
        Me.costCentreLbl.Location = New System.Drawing.Point(454, 88)
        Me.costCentreLbl.Name = "costCentreLbl"
        Me.costCentreLbl.Size = New System.Drawing.Size(39, 13)
        Me.costCentreLbl.TabIndex = 19
        Me.costCentreLbl.Text = "Label5"
        '
        'costCentreSrchBtn
        '
        Me.costCentreSrchBtn.Location = New System.Drawing.Point(526, 80)
        Me.costCentreSrchBtn.Name = "costCentreSrchBtn"
        Me.costCentreSrchBtn.Size = New System.Drawing.Size(62, 29)
        Me.costCentreSrchBtn.TabIndex = 20
        Me.costCentreSrchBtn.Text = "Button5"
        Me.costCentreSrchBtn.UseVisualStyleBackColor = True
        '
        'wbsNoTxtBox
        '
        Me.wbsNoTxtBox.Location = New System.Drawing.Point(256, 188)
        Me.wbsNoTxtBox.Name = "wbsNoTxtBox"
        Me.wbsNoTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.wbsNoTxtBox.TabIndex = 21
        '
        'serviceElemGroupCombo
        '
        Me.serviceElemGroupCombo.FormattingEnabled = True
        Me.serviceElemGroupCombo.Location = New System.Drawing.Point(247, 223)
        Me.serviceElemGroupCombo.Name = "serviceElemGroupCombo"
        Me.serviceElemGroupCombo.Size = New System.Drawing.Size(121, 21)
        Me.serviceElemGroupCombo.TabIndex = 22
        '
        'funcAreaCombo
        '
        Me.funcAreaCombo.FormattingEnabled = True
        Me.funcAreaCombo.Location = New System.Drawing.Point(247, 278)
        Me.funcAreaCombo.Name = "funcAreaCombo"
        Me.funcAreaCombo.Size = New System.Drawing.Size(121, 21)
        Me.funcAreaCombo.TabIndex = 23
        '
        'businessUnitCombo
        '
        Me.businessUnitCombo.FormattingEnabled = True
        Me.businessUnitCombo.Location = New System.Drawing.Point(247, 250)
        Me.businessUnitCombo.Name = "businessUnitCombo"
        Me.businessUnitCombo.Size = New System.Drawing.Size(121, 21)
        Me.businessUnitCombo.TabIndex = 24
        '
        'saveBtn
        '
        Me.saveBtn.Enabled = False
        Me.saveBtn.Location = New System.Drawing.Point(101, 565)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(88, 28)
        Me.saveBtn.TabIndex = 25
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'delBtn
        '
        Me.delBtn.Enabled = False
        Me.delBtn.Location = New System.Drawing.Point(448, 565)
        Me.delBtn.Name = "delBtn"
        Me.delBtn.Size = New System.Drawing.Size(88, 28)
        Me.delBtn.TabIndex = 26
        Me.delBtn.Text = "Delete"
        Me.delBtn.UseVisualStyleBackColor = True
        '
        'EditBtn
        '
        Me.EditBtn.Enabled = False
        Me.EditBtn.Location = New System.Drawing.Point(341, 565)
        Me.EditBtn.Name = "EditBtn"
        Me.EditBtn.Size = New System.Drawing.Size(88, 28)
        Me.EditBtn.TabIndex = 27
        Me.EditBtn.Text = "Edit"
        Me.EditBtn.UseVisualStyleBackColor = True
        '
        'AddBtn
        '
        Me.AddBtn.Location = New System.Drawing.Point(232, 565)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(88, 28)
        Me.AddBtn.TabIndex = 28
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(403, 215)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 29
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(403, 239)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 30
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'ccCodeTxtBox
        '
        Me.ccCodeTxtBox.Location = New System.Drawing.Point(514, 211)
        Me.ccCodeTxtBox.Name = "ccCodeTxtBox"
        Me.ccCodeTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.ccCodeTxtBox.TabIndex = 31
        '
        'ccDescTxtBox
        '
        Me.ccDescTxtBox.Location = New System.Drawing.Point(620, 212)
        Me.ccDescTxtBox.Name = "ccDescTxtBox"
        Me.ccDescTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.ccDescTxtBox.TabIndex = 32
        '
        'ccShortDescTxtBox
        '
        Me.ccShortDescTxtBox.Location = New System.Drawing.Point(726, 211)
        Me.ccShortDescTxtBox.Name = "ccShortDescTxtBox"
        Me.ccShortDescTxtBox.Size = New System.Drawing.Size(100, 20)
        Me.ccShortDescTxtBox.TabIndex = 33
        '
        'wbsTxtbox
        '
        Me.wbsTxtbox.Location = New System.Drawing.Point(514, 239)
        Me.wbsTxtbox.Name = "wbsTxtbox"
        Me.wbsTxtbox.Size = New System.Drawing.Size(100, 20)
        Me.wbsTxtbox.TabIndex = 34
        '
        'closeBtn
        '
        Me.closeBtn.Location = New System.Drawing.Point(573, 565)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(88, 28)
        Me.closeBtn.TabIndex = 35
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'SearchBtn
        '
        Me.SearchBtn.Location = New System.Drawing.Point(416, 278)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(88, 28)
        Me.SearchBtn.TabIndex = 36
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'ClearSearchBtn
        '
        Me.ClearSearchBtn.Location = New System.Drawing.Point(526, 278)
        Me.ClearSearchBtn.Name = "ClearSearchBtn"
        Me.ClearSearchBtn.Size = New System.Drawing.Size(88, 28)
        Me.ClearSearchBtn.TabIndex = 37
        Me.ClearSearchBtn.Text = "Clear Search"
        Me.ClearSearchBtn.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 655)
        Me.Controls.Add(Me.ClearSearchBtn)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.wbsTxtbox)
        Me.Controls.Add(Me.ccShortDescTxtBox)
        Me.Controls.Add(Me.ccDescTxtBox)
        Me.Controls.Add(Me.ccCodeTxtBox)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.EditBtn)
        Me.Controls.Add(Me.delBtn)
        Me.Controls.Add(Me.saveBtn)
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
        Me.Controls.Add(Me.exportBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.salute)
        Me.Controls.Add(Me.picBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lnameTxtBox)
        Me.Controls.Add(Me.fnameTxtBox)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.OKBtn)
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
    Friend WithEvents OKBtn As System.Windows.Forms.Button
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents fnameTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents lnameTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fname As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents picBtn As System.Windows.Forms.Button
    Friend WithEvents salute As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents exportBtn As System.Windows.Forms.Button
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
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents delBtn As System.Windows.Forms.Button
    Friend WithEvents EditBtn As System.Windows.Forms.Button
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents ccCodeTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents ccDescTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents ccShortDescTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents wbsTxtbox As System.Windows.Forms.TextBox
    Friend WithEvents closeBtn As System.Windows.Forms.Button
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents ClearSearchBtn As System.Windows.Forms.Button

End Class
