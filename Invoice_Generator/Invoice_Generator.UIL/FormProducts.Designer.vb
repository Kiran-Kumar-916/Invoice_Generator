<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProducts
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
        LblProductName = New Label()
        LblProductDescription = New Label()
        LblProductPrice = New Label()
        LblProductQuantity = New Label()
        LblProductCategory = New Label()
        TxtProductName = New TextBox()
        TxtProductDescription = New TextBox()
        TxtProductPrice = New TextBox()
        TxtProductQuantity = New TextBox()
        BtnProduct = New Button()
        CmbProductName = New ComboBox()
        LblProductDiscount = New Label()
        TxtProductDiscount = New TextBox()
        CmbProductCategory = New ComboBox()
        SuspendLayout()
        ' 
        ' LblProductName
        ' 
        LblProductName.AutoSize = True
        LblProductName.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblProductName.Location = New Point(190, 50)
        LblProductName.Margin = New Padding(4, 0, 4, 0)
        LblProductName.Name = "LblProductName"
        LblProductName.Size = New Size(45, 15)
        LblProductName.TabIndex = 0
        LblProductName.Text = "Name"
        ' 
        ' LblProductDescription
        ' 
        LblProductDescription.AutoSize = True
        LblProductDescription.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblProductDescription.Location = New Point(153, 105)
        LblProductDescription.Margin = New Padding(4, 0, 4, 0)
        LblProductDescription.Name = "LblProductDescription"
        LblProductDescription.Size = New Size(80, 15)
        LblProductDescription.TabIndex = 1
        LblProductDescription.Text = "Description"
        ' 
        ' LblProductPrice
        ' 
        LblProductPrice.AutoSize = True
        LblProductPrice.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblProductPrice.Location = New Point(193, 224)
        LblProductPrice.Margin = New Padding(4, 0, 4, 0)
        LblProductPrice.Name = "LblProductPrice"
        LblProductPrice.Size = New Size(40, 15)
        LblProductPrice.TabIndex = 2
        LblProductPrice.Text = "Price"
        ' 
        ' LblProductQuantity
        ' 
        LblProductQuantity.AutoSize = True
        LblProductQuantity.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblProductQuantity.Location = New Point(176, 287)
        LblProductQuantity.Margin = New Padding(4, 0, 4, 0)
        LblProductQuantity.Name = "LblProductQuantity"
        LblProductQuantity.Size = New Size(59, 15)
        LblProductQuantity.TabIndex = 3
        LblProductQuantity.Text = "Quantity"
        ' 
        ' LblProductCategory
        ' 
        LblProductCategory.AutoSize = True
        LblProductCategory.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblProductCategory.Location = New Point(170, 170)
        LblProductCategory.Margin = New Padding(4, 0, 4, 0)
        LblProductCategory.Name = "LblProductCategory"
        LblProductCategory.Size = New Size(63, 15)
        LblProductCategory.TabIndex = 4
        LblProductCategory.Text = "Category"
        ' 
        ' TxtProductName
        ' 
        TxtProductName.Location = New Point(313, 49)
        TxtProductName.Margin = New Padding(4, 3, 4, 3)
        TxtProductName.Multiline = True
        TxtProductName.Name = "TxtProductName"
        TxtProductName.Size = New Size(268, 34)
        TxtProductName.TabIndex = 5
        ' 
        ' TxtProductDescription
        ' 
        TxtProductDescription.Location = New Point(313, 103)
        TxtProductDescription.Margin = New Padding(4, 3, 4, 3)
        TxtProductDescription.Multiline = True
        TxtProductDescription.Name = "TxtProductDescription"
        TxtProductDescription.Size = New Size(268, 34)
        TxtProductDescription.TabIndex = 6
        ' 
        ' TxtProductPrice
        ' 
        TxtProductPrice.Location = New Point(313, 222)
        TxtProductPrice.Margin = New Padding(4, 3, 4, 3)
        TxtProductPrice.Multiline = True
        TxtProductPrice.Name = "TxtProductPrice"
        TxtProductPrice.Size = New Size(268, 34)
        TxtProductPrice.TabIndex = 7
        ' 
        ' TxtProductQuantity
        ' 
        TxtProductQuantity.Location = New Point(313, 285)
        TxtProductQuantity.Margin = New Padding(4, 3, 4, 3)
        TxtProductQuantity.Multiline = True
        TxtProductQuantity.Name = "TxtProductQuantity"
        TxtProductQuantity.Size = New Size(268, 34)
        TxtProductQuantity.TabIndex = 8
        ' 
        ' BtnProduct
        ' 
        BtnProduct.BackColor = Color.MediumAquamarine
        BtnProduct.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnProduct.Location = New Point(130, 426)
        BtnProduct.Margin = New Padding(4, 3, 4, 3)
        BtnProduct.Name = "BtnProduct"
        BtnProduct.Size = New Size(451, 58)
        BtnProduct.TabIndex = 10
        BtnProduct.Text = "ADD"
        BtnProduct.UseVisualStyleBackColor = False
        ' 
        ' CmbProductName
        ' 
        CmbProductName.DropDownStyle = ComboBoxStyle.DropDownList
        CmbProductName.FormattingEnabled = True
        CmbProductName.Location = New Point(313, 53)
        CmbProductName.Margin = New Padding(4, 3, 4, 3)
        CmbProductName.MaxDropDownItems = 100
        CmbProductName.Name = "CmbProductName"
        CmbProductName.Size = New Size(268, 23)
        CmbProductName.Sorted = True
        CmbProductName.TabIndex = 11
        ' 
        ' LblProductDiscount
        ' 
        LblProductDiscount.AutoSize = True
        LblProductDiscount.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblProductDiscount.Location = New Point(126, 356)
        LblProductDiscount.Margin = New Padding(4, 0, 4, 0)
        LblProductDiscount.Name = "LblProductDiscount"
        LblProductDiscount.Size = New Size(109, 15)
        LblProductDiscount.TabIndex = 12
        LblProductDiscount.Text = "Discount ( in %)"
        ' 
        ' TxtProductDiscount
        ' 
        TxtProductDiscount.Location = New Point(313, 354)
        TxtProductDiscount.Margin = New Padding(4, 3, 4, 3)
        TxtProductDiscount.Multiline = True
        TxtProductDiscount.Name = "TxtProductDiscount"
        TxtProductDiscount.Size = New Size(268, 34)
        TxtProductDiscount.TabIndex = 13
        ' 
        ' CmbProductCategory
        ' 
        CmbProductCategory.DropDownHeight = 30
        CmbProductCategory.DropDownStyle = ComboBoxStyle.DropDownList
        CmbProductCategory.FormattingEnabled = True
        CmbProductCategory.IntegralHeight = False
        CmbProductCategory.Location = New Point(313, 168)
        CmbProductCategory.Margin = New Padding(4, 3, 4, 3)
        CmbProductCategory.MaxDropDownItems = 100
        CmbProductCategory.Name = "CmbProductCategory"
        CmbProductCategory.Size = New Size(268, 23)
        CmbProductCategory.Sorted = True
        CmbProductCategory.TabIndex = 14
        ' 
        ' FormProducts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(767, 699)
        Controls.Add(CmbProductCategory)
        Controls.Add(TxtProductDiscount)
        Controls.Add(LblProductDiscount)
        Controls.Add(CmbProductName)
        Controls.Add(BtnProduct)
        Controls.Add(TxtProductQuantity)
        Controls.Add(TxtProductPrice)
        Controls.Add(TxtProductDescription)
        Controls.Add(TxtProductName)
        Controls.Add(LblProductCategory)
        Controls.Add(LblProductQuantity)
        Controls.Add(LblProductPrice)
        Controls.Add(LblProductDescription)
        Controls.Add(LblProductName)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "FormProducts"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Products"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents LblProductName As System.Windows.Forms.Label
    Friend WithEvents LblProductDescription As System.Windows.Forms.Label
    Friend WithEvents LblProductPrice As System.Windows.Forms.Label
    Friend WithEvents LblProductQuantity As System.Windows.Forms.Label
    Friend WithEvents LblProductCategory As System.Windows.Forms.Label
    Friend WithEvents TxtProductName As System.Windows.Forms.TextBox
    Friend WithEvents TxtProductDescription As System.Windows.Forms.TextBox
    Friend WithEvents TxtProductPrice As System.Windows.Forms.TextBox
    Friend WithEvents TxtProductQuantity As System.Windows.Forms.TextBox
    Friend WithEvents BtnProduct As System.Windows.Forms.Button
    Friend WithEvents CmbProductName As System.Windows.Forms.ComboBox
    Friend WithEvents LblProductDiscount As System.Windows.Forms.Label
    Friend WithEvents TxtProductDiscount As System.Windows.Forms.TextBox
    Friend WithEvents CmbProductCategory As System.Windows.Forms.ComboBox
End Class
