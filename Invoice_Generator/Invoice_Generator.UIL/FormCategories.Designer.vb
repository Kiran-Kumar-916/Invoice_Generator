<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCategories
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
        LblCategoriesName = New Label()
        LblCategoriesDescription = New Label()
        TxtCategoryName = New TextBox()
        TxtCategoryDescription = New TextBox()
        BtnCategories = New Button()
        CmbCategoryName = New ComboBox()
        LblCategoriesTaxrate = New Label()
        TxtCategoryTaxrate = New TextBox()
        SuspendLayout()
        ' 
        ' LblCategoriesName
        ' 
        LblCategoriesName.AutoSize = True
        LblCategoriesName.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCategoriesName.Location = New Point(250, 86)
        LblCategoriesName.Name = "LblCategoriesName"
        LblCategoriesName.Size = New Size(45, 15)
        LblCategoriesName.TabIndex = 0
        LblCategoriesName.Text = "Name"
        ' 
        ' LblCategoriesDescription
        ' 
        LblCategoriesDescription.AutoSize = True
        LblCategoriesDescription.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCategoriesDescription.Location = New Point(214, 173)
        LblCategoriesDescription.Name = "LblCategoriesDescription"
        LblCategoriesDescription.Size = New Size(81, 15)
        LblCategoriesDescription.TabIndex = 1
        LblCategoriesDescription.Text = "Descriprion"
        ' 
        ' TxtCategoryName
        ' 
        TxtCategoryName.Location = New Point(341, 82)
        TxtCategoryName.Multiline = True
        TxtCategoryName.Name = "TxtCategoryName"
        TxtCategoryName.Size = New Size(230, 30)
        TxtCategoryName.TabIndex = 2
        ' 
        ' TxtCategoryDescription
        ' 
        TxtCategoryDescription.Location = New Point(341, 158)
        TxtCategoryDescription.Multiline = True
        TxtCategoryDescription.Name = "TxtCategoryDescription"
        TxtCategoryDescription.Size = New Size(230, 30)
        TxtCategoryDescription.TabIndex = 3
        ' 
        ' BtnCategories
        ' 
        BtnCategories.BackColor = Color.MediumAquamarine
        BtnCategories.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnCategories.Location = New Point(191, 342)
        BtnCategories.Name = "BtnCategories"
        BtnCategories.Size = New Size(380, 50)
        BtnCategories.TabIndex = 4
        BtnCategories.Text = "ADD"
        BtnCategories.UseVisualStyleBackColor = False
        ' 
        ' CmbCategoryName
        ' 
        CmbCategoryName.DropDownStyle = ComboBoxStyle.DropDownList
        CmbCategoryName.FormattingEnabled = True
        CmbCategoryName.Location = New Point(341, 85)
        CmbCategoryName.MaxDropDownItems = 100
        CmbCategoryName.Name = "CmbCategoryName"
        CmbCategoryName.Size = New Size(230, 23)
        CmbCategoryName.Sorted = True
        CmbCategoryName.TabIndex = 5
        ' 
        ' LblCategoriesTaxrate
        ' 
        LblCategoriesTaxrate.AutoSize = True
        LblCategoriesTaxrate.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCategoriesTaxrate.Location = New Point(181, 242)
        LblCategoriesTaxrate.Name = "LblCategoriesTaxrate"
        LblCategoriesTaxrate.Size = New Size(114, 15)
        LblCategoriesTaxrate.TabIndex = 6
        LblCategoriesTaxrate.Text = "Tax Rate ( in % )"
        ' 
        ' TxtCategoryTaxrate
        ' 
        TxtCategoryTaxrate.Location = New Point(341, 241)
        TxtCategoryTaxrate.Multiline = True
        TxtCategoryTaxrate.Name = "TxtCategoryTaxrate"
        TxtCategoryTaxrate.Size = New Size(230, 30)
        TxtCategoryTaxrate.TabIndex = 7
        ' 
        ' FormCategories
        ' 
        ClientSize = New Size(767, 516)
        Controls.Add(TxtCategoryTaxrate)
        Controls.Add(LblCategoriesTaxrate)
        Controls.Add(CmbCategoryName)
        Controls.Add(BtnCategories)
        Controls.Add(TxtCategoryDescription)
        Controls.Add(TxtCategoryName)
        Controls.Add(LblCategoriesDescription)
        Controls.Add(LblCategoriesName)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "FormCategories"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Categories"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LblCategoriesName As System.Windows.Forms.Label
    Friend WithEvents LblCategoriesDescription As System.Windows.Forms.Label
    Friend WithEvents TxtCategoryName As System.Windows.Forms.TextBox
    Friend WithEvents TxtCategoryDescription As System.Windows.Forms.TextBox
    Friend WithEvents BtnCategories As System.Windows.Forms.Button
    Friend WithEvents CmbCategoryName As System.Windows.Forms.ComboBox
    Friend WithEvents LblCategoriesTaxrate As System.Windows.Forms.Label
    Friend WithEvents TxtCategoryTaxrate As System.Windows.Forms.TextBox
End Class
