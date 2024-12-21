<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCart
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
        CmbCustomerInCart = New ComboBox()
        LblCustomerInCart = New Label()
        DgvStocks = New DataGridView()
        DgvCart = New DataGridView()
        BtnAddToCart = New Button()
        BtnPlaceOrder = New Button()
        LblProductsInStock = New Label()
        LblMyCart = New Label()
        BtnRemoveAllFromCart = New Button()
        CType(DgvStocks, ComponentModel.ISupportInitialize).BeginInit()
        CType(DgvCart, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' CmbCustomerInCart
        ' 
        CmbCustomerInCart.DropDownHeight = 200
        CmbCustomerInCart.DropDownStyle = ComboBoxStyle.DropDownList
        CmbCustomerInCart.FormattingEnabled = True
        CmbCustomerInCart.IntegralHeight = False
        CmbCustomerInCart.ItemHeight = 15
        CmbCustomerInCart.Location = New Point(263, 37)
        CmbCustomerInCart.Margin = New Padding(4, 3, 4, 3)
        CmbCustomerInCart.MaxDropDownItems = 100
        CmbCustomerInCart.Name = "CmbCustomerInCart"
        CmbCustomerInCart.Size = New Size(378, 23)
        CmbCustomerInCart.Sorted = True
        CmbCustomerInCart.TabIndex = 0
        ' 
        ' LblCustomerInCart
        ' 
        LblCustomerInCart.AutoSize = True
        LblCustomerInCart.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCustomerInCart.Location = New Point(56, 40)
        LblCustomerInCart.Margin = New Padding(4, 0, 4, 0)
        LblCustomerInCart.Name = "LblCustomerInCart"
        LblCustomerInCart.Size = New Size(147, 20)
        LblCustomerInCart.TabIndex = 1
        LblCustomerInCart.Text = "Customer Name :"
        ' 
        ' DgvStocks
        ' 
        DgvStocks.AllowUserToAddRows = False
        DgvStocks.AllowUserToDeleteRows = False
        DgvStocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvStocks.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DgvStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvStocks.Location = New Point(80, 137)
        DgvStocks.Margin = New Padding(4, 3, 4, 3)
        DgvStocks.Name = "DgvStocks"
        DgvStocks.RowHeadersWidth = 50
        DgvStocks.Size = New Size(561, 332)
        DgvStocks.TabIndex = 2
        ' 
        ' DgvCart
        ' 
        DgvCart.AllowUserToAddRows = False
        DgvCart.AllowUserToDeleteRows = False
        DgvCart.AllowUserToOrderColumns = True
        DgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvCart.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvCart.Location = New Point(708, 137)
        DgvCart.Margin = New Padding(4, 3, 4, 3)
        DgvCart.Name = "DgvCart"
        DgvCart.RowHeadersWidth = 50
        DgvCart.Size = New Size(588, 332)
        DgvCart.TabIndex = 3
        ' 
        ' BtnAddToCart
        ' 
        BtnAddToCart.BackColor = Color.LightGreen
        BtnAddToCart.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnAddToCart.Location = New Point(384, 516)
        BtnAddToCart.Margin = New Padding(4, 3, 4, 3)
        BtnAddToCart.Name = "BtnAddToCart"
        BtnAddToCart.Size = New Size(257, 76)
        BtnAddToCart.TabIndex = 4
        BtnAddToCart.Text = "Add More to Cart"
        BtnAddToCart.UseVisualStyleBackColor = False
        ' 
        ' BtnPlaceOrder
        ' 
        BtnPlaceOrder.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        BtnPlaceOrder.Font = New Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnPlaceOrder.ForeColor = Color.Blue
        BtnPlaceOrder.Location = New Point(240, 635)
        BtnPlaceOrder.Margin = New Padding(4, 3, 4, 3)
        BtnPlaceOrder.Name = "BtnPlaceOrder"
        BtnPlaceOrder.Size = New Size(863, 54)
        BtnPlaceOrder.TabIndex = 5
        BtnPlaceOrder.Text = "Place Order"
        BtnPlaceOrder.UseVisualStyleBackColor = False
        ' 
        ' LblProductsInStock
        ' 
        LblProductsInStock.AutoSize = True
        LblProductsInStock.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblProductsInStock.Location = New Point(56, 94)
        LblProductsInStock.Margin = New Padding(4, 0, 4, 0)
        LblProductsInStock.Name = "LblProductsInStock"
        LblProductsInStock.Size = New Size(162, 20)
        LblProductsInStock.TabIndex = 6
        LblProductsInStock.Text = "Products In Stock :"
        ' 
        ' LblMyCart
        ' 
        LblMyCart.AutoSize = True
        LblMyCart.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblMyCart.Location = New Point(708, 94)
        LblMyCart.Margin = New Padding(4, 0, 4, 0)
        LblMyCart.Name = "LblMyCart"
        LblMyCart.Size = New Size(80, 20)
        LblMyCart.TabIndex = 7
        LblMyCart.Text = "My Cart :"
        ' 
        ' BtnRemoveAllFromCart
        ' 
        BtnRemoveAllFromCart.BackColor = Color.LightSalmon
        BtnRemoveAllFromCart.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnRemoveAllFromCart.Location = New Point(708, 516)
        BtnRemoveAllFromCart.Margin = New Padding(4, 3, 4, 3)
        BtnRemoveAllFromCart.Name = "BtnRemoveAllFromCart"
        BtnRemoveAllFromCart.Size = New Size(254, 76)
        BtnRemoveAllFromCart.TabIndex = 8
        BtnRemoveAllFromCart.Text = "Remove Product From Cart"
        BtnRemoveAllFromCart.UseVisualStyleBackColor = False
        ' 
        ' FormCart
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 749)
        Controls.Add(BtnRemoveAllFromCart)
        Controls.Add(LblMyCart)
        Controls.Add(LblProductsInStock)
        Controls.Add(BtnPlaceOrder)
        Controls.Add(BtnAddToCart)
        Controls.Add(DgvCart)
        Controls.Add(DgvStocks)
        Controls.Add(LblCustomerInCart)
        Controls.Add(CmbCustomerInCart)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MinimizeBox = False
        Name = "FormCart"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Shopping Cart"
        CType(DgvStocks, ComponentModel.ISupportInitialize).EndInit()
        CType(DgvCart, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents CmbCustomerInCart As System.Windows.Forms.ComboBox
    Friend WithEvents LblCustomerInCart As System.Windows.Forms.Label
    Friend WithEvents DgvStocks As System.Windows.Forms.DataGridView
    Friend WithEvents DgvCart As System.Windows.Forms.DataGridView
    Friend WithEvents BtnAddToCart As System.Windows.Forms.Button
    Friend WithEvents BtnPlaceOrder As System.Windows.Forms.Button
    Friend WithEvents LblProductsInStock As System.Windows.Forms.Label
    Friend WithEvents LblMyCart As System.Windows.Forms.Label
    Friend WithEvents BtnRemoveAllFromCart As System.Windows.Forms.Button
End Class
