<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCustomers
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
        LblCustomersName = New Label()
        LblCustomersEmail = New Label()
        LblCustomersAddress = New Label()
        LblCustomersContactNum = New Label()
        TxtCustomerName = New TextBox()
        TxtCustomerEmail = New TextBox()
        TxtCustomerAddress = New TextBox()
        TxtCustomerContactNum = New TextBox()
        CmbCustomerName = New ComboBox()
        BtnCustomers = New Button()
        SuspendLayout()
        ' 
        ' LblCustomersName
        ' 
        LblCustomersName.AutoSize = True
        LblCustomersName.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCustomersName.Location = New Point(211, 71)
        LblCustomersName.Margin = New Padding(4, 0, 4, 0)
        LblCustomersName.Name = "LblCustomersName"
        LblCustomersName.Size = New Size(45, 15)
        LblCustomersName.TabIndex = 1
        LblCustomersName.Text = "Name"
        ' 
        ' LblCustomersEmail
        ' 
        LblCustomersEmail.AutoSize = True
        LblCustomersEmail.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCustomersEmail.Location = New Point(212, 142)
        LblCustomersEmail.Margin = New Padding(4, 0, 4, 0)
        LblCustomersEmail.Name = "LblCustomersEmail"
        LblCustomersEmail.Size = New Size(44, 15)
        LblCustomersEmail.TabIndex = 2
        LblCustomersEmail.Text = "Email"
        ' 
        ' LblCustomersAddress
        ' 
        LblCustomersAddress.AutoSize = True
        LblCustomersAddress.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCustomersAddress.Location = New Point(196, 216)
        LblCustomersAddress.Margin = New Padding(4, 0, 4, 0)
        LblCustomersAddress.Name = "LblCustomersAddress"
        LblCustomersAddress.Size = New Size(58, 15)
        LblCustomersAddress.TabIndex = 3
        LblCustomersAddress.Text = "Address"
        ' 
        ' LblCustomersContactNum
        ' 
        LblCustomersContactNum.AutoSize = True
        LblCustomersContactNum.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCustomersContactNum.Location = New Point(136, 298)
        LblCustomersContactNum.Margin = New Padding(4, 0, 4, 0)
        LblCustomersContactNum.Name = "LblCustomersContactNum"
        LblCustomersContactNum.Size = New Size(110, 15)
        LblCustomersContactNum.TabIndex = 4
        LblCustomersContactNum.Text = "Contact Number"
        ' 
        ' TxtCustomerName
        ' 
        TxtCustomerName.Location = New Point(362, 68)
        TxtCustomerName.Margin = New Padding(4, 3, 4, 3)
        TxtCustomerName.Multiline = True
        TxtCustomerName.Name = "TxtCustomerName"
        TxtCustomerName.Size = New Size(268, 34)
        TxtCustomerName.TabIndex = 7
        ' 
        ' TxtCustomerEmail
        ' 
        TxtCustomerEmail.Location = New Point(362, 141)
        TxtCustomerEmail.Margin = New Padding(4, 3, 4, 3)
        TxtCustomerEmail.Multiline = True
        TxtCustomerEmail.Name = "TxtCustomerEmail"
        TxtCustomerEmail.Size = New Size(268, 34)
        TxtCustomerEmail.TabIndex = 8
        ' 
        ' TxtCustomerAddress
        ' 
        TxtCustomerAddress.Location = New Point(362, 214)
        TxtCustomerAddress.Margin = New Padding(4, 3, 4, 3)
        TxtCustomerAddress.Multiline = True
        TxtCustomerAddress.Name = "TxtCustomerAddress"
        TxtCustomerAddress.Size = New Size(268, 34)
        TxtCustomerAddress.TabIndex = 9
        ' 
        ' TxtCustomerContactNum
        ' 
        TxtCustomerContactNum.Location = New Point(362, 293)
        TxtCustomerContactNum.Margin = New Padding(4, 3, 4, 3)
        TxtCustomerContactNum.Multiline = True
        TxtCustomerContactNum.Name = "TxtCustomerContactNum"
        TxtCustomerContactNum.Size = New Size(268, 34)
        TxtCustomerContactNum.TabIndex = 10
        ' 
        ' CmbCustomerName
        ' 
        CmbCustomerName.DropDownStyle = ComboBoxStyle.DropDownList
        CmbCustomerName.FormattingEnabled = True
        CmbCustomerName.Location = New Point(362, 73)
        CmbCustomerName.Margin = New Padding(4, 3, 4, 3)
        CmbCustomerName.MaxDropDownItems = 100
        CmbCustomerName.Name = "CmbCustomerName"
        CmbCustomerName.Size = New Size(268, 23)
        CmbCustomerName.Sorted = True
        CmbCustomerName.TabIndex = 12
        ' 
        ' BtnCustomers
        ' 
        BtnCustomers.BackColor = Color.MediumAquamarine
        BtnCustomers.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCustomers.Location = New Point(139, 392)
        BtnCustomers.Margin = New Padding(4, 3, 4, 3)
        BtnCustomers.Name = "BtnCustomers"
        BtnCustomers.Size = New Size(491, 58)
        BtnCustomers.TabIndex = 13
        BtnCustomers.Text = "ADD"
        BtnCustomers.UseVisualStyleBackColor = False
        ' 
        ' FormCustomers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(767, 516)
        Controls.Add(BtnCustomers)
        Controls.Add(CmbCustomerName)
        Controls.Add(TxtCustomerContactNum)
        Controls.Add(TxtCustomerAddress)
        Controls.Add(TxtCustomerEmail)
        Controls.Add(TxtCustomerName)
        Controls.Add(LblCustomersContactNum)
        Controls.Add(LblCustomersAddress)
        Controls.Add(LblCustomersEmail)
        Controls.Add(LblCustomersName)
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "FormCustomers"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Customers"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents LblCustomersName As System.Windows.Forms.Label
    Friend WithEvents LblCustomersEmail As System.Windows.Forms.Label
    Friend WithEvents LblCustomersAddress As System.Windows.Forms.Label
    Friend WithEvents LblCustomersContactNum As System.Windows.Forms.Label
    Friend WithEvents TxtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerAddress As System.Windows.Forms.TextBox
    Friend WithEvents TxtCustomerContactNum As System.Windows.Forms.TextBox
    Friend WithEvents CmbCustomerName As System.Windows.Forms.ComboBox
    Friend WithEvents BtnCustomers As System.Windows.Forms.Button
End Class
