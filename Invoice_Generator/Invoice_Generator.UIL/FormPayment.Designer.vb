<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPayment
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
        GrbPaymentOptions = New GroupBox()
        LblDigitalWallets = New Label()
        Rdb8 = New RadioButton()
        Rdb7 = New RadioButton()
        Rdb6 = New RadioButton()
        Rdb5 = New RadioButton()
        LblCreditDebit = New Label()
        Rdb4 = New RadioButton()
        Rdb3 = New RadioButton()
        Rdb2 = New RadioButton()
        Rdb1 = New RadioButton()
        LblSelectPaymentOption = New Label()
        LblPurchaseSummary = New Label()
        DgvPurchaseSummary = New DataGridView()
        LblOrderTotal1 = New Label()
        TxtFlatDiscount = New TextBox()
        LblFlatDiscount = New Label()
        LblTotAfterFlatDiscount1 = New Label()
        BtnProceedPay = New Button()
        BtnApplyFlatDiscount = New Button()
        LblTotAfterFlatDiscount2 = New Label()
        LblOrderTotal2 = New Label()
        PbBar = New ProgressBar()
        LblTotalAfterTax2 = New Label()
        LblTotalAfterDiscntAndTax1 = New Label()
        GrbPaymentOptions.SuspendLayout()
        CType(DgvPurchaseSummary, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GrbPaymentOptions
        ' 
        GrbPaymentOptions.BackColor = SystemColors.GradientInactiveCaption
        GrbPaymentOptions.Controls.Add(LblDigitalWallets)
        GrbPaymentOptions.Controls.Add(Rdb8)
        GrbPaymentOptions.Controls.Add(Rdb7)
        GrbPaymentOptions.Controls.Add(Rdb6)
        GrbPaymentOptions.Controls.Add(Rdb5)
        GrbPaymentOptions.Controls.Add(LblCreditDebit)
        GrbPaymentOptions.Controls.Add(Rdb4)
        GrbPaymentOptions.Controls.Add(Rdb3)
        GrbPaymentOptions.Controls.Add(Rdb2)
        GrbPaymentOptions.Controls.Add(Rdb1)
        GrbPaymentOptions.Controls.Add(LblSelectPaymentOption)
        GrbPaymentOptions.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GrbPaymentOptions.Location = New Point(175, 422)
        GrbPaymentOptions.Margin = New Padding(4)
        GrbPaymentOptions.Name = "GrbPaymentOptions"
        GrbPaymentOptions.Padding = New Padding(4)
        GrbPaymentOptions.Size = New Size(504, 299)
        GrbPaymentOptions.TabIndex = 1
        GrbPaymentOptions.TabStop = False
        ' 
        ' LblDigitalWallets
        ' 
        LblDigitalWallets.AutoSize = True
        LblDigitalWallets.Location = New Point(277, 63)
        LblDigitalWallets.Margin = New Padding(4, 0, 4, 0)
        LblDigitalWallets.Name = "LblDigitalWallets"
        LblDigitalWallets.Size = New Size(93, 16)
        LblDigitalWallets.TabIndex = 10
        LblDigitalWallets.Text = "Digital Wallets"
        ' 
        ' Rdb8
        ' 
        Rdb8.AutoSize = True
        Rdb8.Location = New Point(291, 226)
        Rdb8.Margin = New Padding(4)
        Rdb8.Name = "Rdb8"
        Rdb8.Size = New Size(109, 20)
        Rdb8.TabIndex = 9
        Rdb8.TabStop = True
        Rdb8.Text = "Samsung Pay"
        Rdb8.UseVisualStyleBackColor = True
        ' 
        ' Rdb7
        ' 
        Rdb7.AutoSize = True
        Rdb7.Location = New Point(291, 188)
        Rdb7.Margin = New Padding(4)
        Rdb7.Name = "Rdb7"
        Rdb7.Size = New Size(88, 20)
        Rdb7.TabIndex = 8
        Rdb7.TabStop = True
        Rdb7.Text = "Apple Pay"
        Rdb7.UseVisualStyleBackColor = True
        ' 
        ' Rdb6
        ' 
        Rdb6.AutoSize = True
        Rdb6.Location = New Point(291, 148)
        Rdb6.Margin = New Padding(4)
        Rdb6.Name = "Rdb6"
        Rdb6.Size = New Size(69, 20)
        Rdb6.TabIndex = 7
        Rdb6.TabStop = True
        Rdb6.Text = "PayPal"
        Rdb6.UseVisualStyleBackColor = True
        ' 
        ' Rdb5
        ' 
        Rdb5.AutoSize = True
        Rdb5.Location = New Point(291, 106)
        Rdb5.Margin = New Padding(4)
        Rdb5.Name = "Rdb5"
        Rdb5.Size = New Size(97, 20)
        Rdb5.TabIndex = 6
        Rdb5.TabStop = True
        Rdb5.Text = "Google Pay"
        Rdb5.UseVisualStyleBackColor = True
        ' 
        ' LblCreditDebit
        ' 
        LblCreditDebit.AutoSize = True
        LblCreditDebit.Location = New Point(44, 62)
        LblCreditDebit.Margin = New Padding(4, 0, 4, 0)
        LblCreditDebit.Name = "LblCreditDebit"
        LblCreditDebit.Size = New Size(117, 16)
        LblCreditDebit.TabIndex = 5
        LblCreditDebit.Text = "Credit/Debit Cards"
        ' 
        ' Rdb4
        ' 
        Rdb4.AutoSize = True
        Rdb4.Location = New Point(57, 225)
        Rdb4.Margin = New Padding(4)
        Rdb4.Name = "Rdb4"
        Rdb4.Size = New Size(79, 20)
        Rdb4.TabIndex = 4
        Rdb4.TabStop = True
        Rdb4.Text = "Discover"
        Rdb4.UseVisualStyleBackColor = True
        ' 
        ' Rdb3
        ' 
        Rdb3.AutoSize = True
        Rdb3.Location = New Point(57, 187)
        Rdb3.Margin = New Padding(4)
        Rdb3.Name = "Rdb3"
        Rdb3.Size = New Size(134, 20)
        Rdb3.TabIndex = 3
        Rdb3.TabStop = True
        Rdb3.Text = "American Express"
        Rdb3.UseVisualStyleBackColor = True
        ' 
        ' Rdb2
        ' 
        Rdb2.AutoSize = True
        Rdb2.Location = New Point(57, 148)
        Rdb2.Margin = New Padding(4)
        Rdb2.Name = "Rdb2"
        Rdb2.Size = New Size(95, 20)
        Rdb2.TabIndex = 2
        Rdb2.TabStop = True
        Rdb2.Text = "MasterCard"
        Rdb2.UseVisualStyleBackColor = True
        ' 
        ' Rdb1
        ' 
        Rdb1.AutoSize = True
        Rdb1.Location = New Point(57, 105)
        Rdb1.Margin = New Padding(4)
        Rdb1.Name = "Rdb1"
        Rdb1.Size = New Size(52, 20)
        Rdb1.TabIndex = 1
        Rdb1.TabStop = True
        Rdb1.Text = "Visa"
        Rdb1.UseVisualStyleBackColor = True
        ' 
        ' LblSelectPaymentOption
        ' 
        LblSelectPaymentOption.AutoSize = True
        LblSelectPaymentOption.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblSelectPaymentOption.Location = New Point(8, 20)
        LblSelectPaymentOption.Margin = New Padding(4, 0, 4, 0)
        LblSelectPaymentOption.Name = "LblSelectPaymentOption"
        LblSelectPaymentOption.Size = New Size(172, 16)
        LblSelectPaymentOption.TabIndex = 0
        LblSelectPaymentOption.Text = "Select Payment Option :"
        ' 
        ' LblPurchaseSummary
        ' 
        LblPurchaseSummary.AutoSize = True
        LblPurchaseSummary.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblPurchaseSummary.Location = New Point(73, 39)
        LblPurchaseSummary.Margin = New Padding(4, 0, 4, 0)
        LblPurchaseSummary.Name = "LblPurchaseSummary"
        LblPurchaseSummary.Size = New Size(173, 20)
        LblPurchaseSummary.TabIndex = 2
        LblPurchaseSummary.Text = "Purchase Summary :"
        ' 
        ' DgvPurchaseSummary
        ' 
        DgvPurchaseSummary.AllowUserToOrderColumns = True
        DgvPurchaseSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DgvPurchaseSummary.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DgvPurchaseSummary.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvPurchaseSummary.Location = New Point(108, 87)
        DgvPurchaseSummary.Margin = New Padding(4)
        DgvPurchaseSummary.Name = "DgvPurchaseSummary"
        DgvPurchaseSummary.Size = New Size(1045, 283)
        DgvPurchaseSummary.TabIndex = 3
        ' 
        ' LblOrderTotal1
        ' 
        LblOrderTotal1.AutoSize = True
        LblOrderTotal1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblOrderTotal1.Location = New Point(823, 582)
        LblOrderTotal1.Margin = New Padding(4, 0, 4, 0)
        LblOrderTotal1.Name = "LblOrderTotal1"
        LblOrderTotal1.Size = New Size(143, 20)
        LblOrderTotal1.TabIndex = 6
        LblOrderTotal1.Text = "ORDER TOTAL :"
        ' 
        ' TxtFlatDiscount
        ' 
        TxtFlatDiscount.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TxtFlatDiscount.Location = New Point(1018, 473)
        TxtFlatDiscount.Margin = New Padding(4)
        TxtFlatDiscount.Name = "TxtFlatDiscount"
        TxtFlatDiscount.Size = New Size(132, 22)
        TxtFlatDiscount.TabIndex = 7
        ' 
        ' LblFlatDiscount
        ' 
        LblFlatDiscount.AutoSize = True
        LblFlatDiscount.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblFlatDiscount.Location = New Point(722, 476)
        LblFlatDiscount.Margin = New Padding(4, 0, 4, 0)
        LblFlatDiscount.Name = "LblFlatDiscount"
        LblFlatDiscount.Size = New Size(243, 16)
        LblFlatDiscount.TabIndex = 8
        LblFlatDiscount.Text = "Coupen Code for Flat Discount (Rs.500):"
        ' 
        ' LblTotAfterFlatDiscount1
        ' 
        LblTotAfterFlatDiscount1.AutoSize = True
        LblTotAfterFlatDiscount1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTotAfterFlatDiscount1.Location = New Point(814, 525)
        LblTotAfterFlatDiscount1.Margin = New Padding(4, 0, 4, 0)
        LblTotAfterFlatDiscount1.Name = "LblTotAfterFlatDiscount1"
        LblTotAfterFlatDiscount1.Size = New Size(151, 16)
        LblTotAfterFlatDiscount1.TabIndex = 10
        LblTotAfterFlatDiscount1.Text = "Total After Flat Discount:"
        ' 
        ' BtnProceedPay
        ' 
        BtnProceedPay.BackColor = Color.LightGreen
        BtnProceedPay.Font = New Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnProceedPay.ForeColor = Color.Crimson
        BtnProceedPay.Location = New Point(839, 645)
        BtnProceedPay.Margin = New Padding(4)
        BtnProceedPay.Name = "BtnProceedPay"
        BtnProceedPay.Size = New Size(311, 81)
        BtnProceedPay.TabIndex = 11
        BtnProceedPay.Text = "Proceed Payment"
        BtnProceedPay.UseVisualStyleBackColor = False
        ' 
        ' BtnApplyFlatDiscount
        ' 
        BtnApplyFlatDiscount.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnApplyFlatDiscount.Location = New Point(1359, 475)
        BtnApplyFlatDiscount.Margin = New Padding(4)
        BtnApplyFlatDiscount.Name = "BtnApplyFlatDiscount"
        BtnApplyFlatDiscount.Size = New Size(96, 31)
        BtnApplyFlatDiscount.TabIndex = 13
        BtnApplyFlatDiscount.Text = "Apply"
        BtnApplyFlatDiscount.UseVisualStyleBackColor = True
        ' 
        ' LblTotAfterFlatDiscount2
        ' 
        LblTotAfterFlatDiscount2.AutoSize = True
        LblTotAfterFlatDiscount2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTotAfterFlatDiscount2.Location = New Point(1014, 525)
        LblTotAfterFlatDiscount2.Margin = New Padding(4, 0, 4, 0)
        LblTotAfterFlatDiscount2.Name = "LblTotAfterFlatDiscount2"
        LblTotAfterFlatDiscount2.Size = New Size(142, 16)
        LblTotAfterFlatDiscount2.TabIndex = 14
        LblTotAfterFlatDiscount2.Text = "(total after flat discount)"
        ' 
        ' LblOrderTotal2
        ' 
        LblOrderTotal2.AutoSize = True
        LblOrderTotal2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblOrderTotal2.Location = New Point(1014, 582)
        LblOrderTotal2.Margin = New Padding(4, 0, 4, 0)
        LblOrderTotal2.Name = "LblOrderTotal2"
        LblOrderTotal2.Size = New Size(104, 20)
        LblOrderTotal2.TabIndex = 15
        LblOrderTotal2.Text = "(order total)"
        ' 
        ' PbBar
        ' 
        PbBar.Location = New Point(883, 770)
        PbBar.Margin = New Padding(4)
        PbBar.MarqueeAnimationSpeed = 1
        PbBar.Name = "PbBar"
        PbBar.RightToLeft = RightToLeft.No
        PbBar.Size = New Size(600, 41)
        PbBar.Step = 90
        PbBar.TabIndex = 0
        PbBar.Visible = False
        ' 
        ' LblTotalAfterTax2
        ' 
        LblTotalAfterTax2.AutoSize = True
        LblTotalAfterTax2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTotalAfterTax2.Location = New Point(1014, 425)
        LblTotalAfterTax2.Margin = New Padding(4, 0, 4, 0)
        LblTotalAfterTax2.Name = "LblTotalAfterTax2"
        LblTotalAfterTax2.Size = New Size(168, 16)
        LblTotalAfterTax2.TabIndex = 16
        LblTotalAfterTax2.Text = "(total after discount and tax)"
        ' 
        ' LblTotalAfterDiscntAndTax1
        ' 
        LblTotalAfterDiscntAndTax1.AutoSize = True
        LblTotalAfterDiscntAndTax1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblTotalAfterDiscntAndTax1.Location = New Point(783, 425)
        LblTotalAfterDiscntAndTax1.Margin = New Padding(4, 0, 4, 0)
        LblTotalAfterDiscntAndTax1.Name = "LblTotalAfterDiscntAndTax1"
        LblTotalAfterDiscntAndTax1.Size = New Size(182, 16)
        LblTotalAfterDiscntAndTax1.TabIndex = 9
        LblTotalAfterDiscntAndTax1.Text = "Total After Discount And Tax: "
        ' 
        ' FormPayment
        ' 
        AutoScaleDimensions = New SizeF(8F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1370, 749)
        Controls.Add(PbBar)
        Controls.Add(LblTotalAfterTax2)
        Controls.Add(LblOrderTotal2)
        Controls.Add(LblTotAfterFlatDiscount2)
        Controls.Add(BtnApplyFlatDiscount)
        Controls.Add(BtnProceedPay)
        Controls.Add(LblTotAfterFlatDiscount1)
        Controls.Add(LblTotalAfterDiscntAndTax1)
        Controls.Add(LblFlatDiscount)
        Controls.Add(TxtFlatDiscount)
        Controls.Add(LblOrderTotal1)
        Controls.Add(DgvPurchaseSummary)
        Controls.Add(LblPurchaseSummary)
        Controls.Add(GrbPaymentOptions)
        Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4)
        MaximizeBox = False
        Name = "FormPayment"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Payment"
        GrbPaymentOptions.ResumeLayout(False)
        GrbPaymentOptions.PerformLayout()
        CType(DgvPurchaseSummary, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents GrbPaymentOptions As System.Windows.Forms.GroupBox
    Friend WithEvents LblSelectPaymentOption As System.Windows.Forms.Label
    Friend WithEvents LblDigitalWallets As System.Windows.Forms.Label
    Friend WithEvents Rdb8 As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb7 As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb6 As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb5 As System.Windows.Forms.RadioButton
    Friend WithEvents LblCreditDebit As System.Windows.Forms.Label
    Friend WithEvents Rdb4 As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb3 As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb1 As System.Windows.Forms.RadioButton
    Friend WithEvents LblPurchaseSummary As System.Windows.Forms.Label
    Friend WithEvents DgvPurchaseSummary As System.Windows.Forms.DataGridView
    Friend WithEvents LblOrderTotal1 As System.Windows.Forms.Label
    Friend WithEvents TxtFlatDiscount As System.Windows.Forms.TextBox
    Friend WithEvents LblFlatDiscount As System.Windows.Forms.Label
    Friend WithEvents LblTotAfterFlatDiscount1 As System.Windows.Forms.Label
    Friend WithEvents BtnProceedPay As System.Windows.Forms.Button
    Friend WithEvents BtnApplyFlatDiscount As System.Windows.Forms.Button
    Friend WithEvents LblTotAfterFlatDiscount2 As System.Windows.Forms.Label
    Friend WithEvents LblOrderTotal2 As System.Windows.Forms.Label
    Friend WithEvents PbBar As System.Windows.Forms.ProgressBar
    Friend WithEvents LblTotalAfterTax2 As System.Windows.Forms.Label
    Friend WithEvents LblTotalAfterDiscntAndTax1 As System.Windows.Forms.Label
End Class
