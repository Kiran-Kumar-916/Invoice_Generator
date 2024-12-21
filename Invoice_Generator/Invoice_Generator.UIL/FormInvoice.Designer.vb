<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInvoice
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
        LblInvoice = New Label()
        LblCustDetails1 = New Label()
        DgvFinalInvoice = New DataGridView()
        LblPurchaseDetails1 = New Label()
        LblTotalAmount1 = New Label()
        LblPaymentOption1 = New Label()
        LblPaymentStatus1 = New Label()
        BtnInvoiceOK = New Button()
        LblCustDetails2 = New Label()
        LblPaymentOption2 = New Label()
        LblTotalAmount2 = New Label()
        LblPurchaseDetails2 = New Label()
        Label1 = New Label()
        LblDateOfPayment1 = New Label()
        LblDateOfPayment2 = New Label()
        Label2 = New Label()
        CType(DgvFinalInvoice, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LblInvoice
        ' 
        LblInvoice.AutoSize = True
        LblInvoice.Font = New Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblInvoice.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        LblInvoice.Location = New Point(336, 27)
        LblInvoice.Margin = New Padding(4, 0, 4, 0)
        LblInvoice.Name = "LblInvoice"
        LblInvoice.Size = New Size(116, 26)
        LblInvoice.TabIndex = 0
        LblInvoice.Text = "INVOICE"
        ' 
        ' LblCustDetails1
        ' 
        LblCustDetails1.AutoSize = True
        LblCustDetails1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCustDetails1.Location = New Point(24, 78)
        LblCustDetails1.Margin = New Padding(4, 0, 4, 0)
        LblCustDetails1.Name = "LblCustDetails1"
        LblCustDetails1.Size = New Size(149, 18)
        LblCustDetails1.TabIndex = 1
        LblCustDetails1.Text = "Customer Details :"
        ' 
        ' DgvFinalInvoice
        ' 
        DgvFinalInvoice.BackgroundColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DgvFinalInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvFinalInvoice.Location = New Point(354, 812)
        DgvFinalInvoice.Margin = New Padding(4, 3, 4, 3)
        DgvFinalInvoice.Name = "DgvFinalInvoice"
        DgvFinalInvoice.Size = New Size(37, 31)
        DgvFinalInvoice.TabIndex = 2
        DgvFinalInvoice.Visible = False
        ' 
        ' LblPurchaseDetails1
        ' 
        LblPurchaseDetails1.AutoSize = True
        LblPurchaseDetails1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblPurchaseDetails1.Location = New Point(20, 168)
        LblPurchaseDetails1.Margin = New Padding(4, 0, 4, 0)
        LblPurchaseDetails1.Name = "LblPurchaseDetails1"
        LblPurchaseDetails1.Size = New Size(171, 18)
        LblPurchaseDetails1.TabIndex = 3
        LblPurchaseDetails1.Text = "Purchased Products: "
        ' 
        ' LblTotalAmount1
        ' 
        LblTotalAmount1.AutoSize = True
        LblTotalAmount1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblTotalAmount1.Location = New Point(20, 454)
        LblTotalAmount1.Margin = New Padding(4, 0, 4, 0)
        LblTotalAmount1.Name = "LblTotalAmount1"
        LblTotalAmount1.Size = New Size(156, 18)
        LblTotalAmount1.TabIndex = 4
        LblTotalAmount1.Text = "Total Amount Paid :"
        ' 
        ' LblPaymentOption1
        ' 
        LblPaymentOption1.AutoSize = True
        LblPaymentOption1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblPaymentOption1.Location = New Point(20, 506)
        LblPaymentOption1.Margin = New Padding(4, 0, 4, 0)
        LblPaymentOption1.Name = "LblPaymentOption1"
        LblPaymentOption1.Size = New Size(194, 16)
        LblPaymentOption1.TabIndex = 5
        LblPaymentOption1.Text = "Selected Payment Option : "
        ' 
        ' LblPaymentStatus1
        ' 
        LblPaymentStatus1.AutoSize = True
        LblPaymentStatus1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblPaymentStatus1.Location = New Point(20, 552)
        LblPaymentStatus1.Margin = New Padding(4, 0, 4, 0)
        LblPaymentStatus1.Name = "LblPaymentStatus1"
        LblPaymentStatus1.Size = New Size(122, 16)
        LblPaymentStatus1.TabIndex = 6
        LblPaymentStatus1.Text = "Payment Status :"
        ' 
        ' BtnInvoiceOK
        ' 
        BtnInvoiceOK.BackColor = SystemColors.ActiveCaption
        BtnInvoiceOK.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        BtnInvoiceOK.Location = New Point(286, 802)
        BtnInvoiceOK.Margin = New Padding(4, 3, 4, 3)
        BtnInvoiceOK.Name = "BtnInvoiceOK"
        BtnInvoiceOK.Size = New Size(220, 55)
        BtnInvoiceOK.TabIndex = 7
        BtnInvoiceOK.Text = "OK"
        BtnInvoiceOK.UseVisualStyleBackColor = False
        ' 
        ' LblCustDetails2
        ' 
        LblCustDetails2.AutoSize = True
        LblCustDetails2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCustDetails2.Location = New Point(270, 80)
        LblCustDetails2.Margin = New Padding(4, 0, 4, 0)
        LblCustDetails2.Name = "LblCustDetails2"
        LblCustDetails2.Size = New Size(131, 16)
        LblCustDetails2.TabIndex = 8
        LblCustDetails2.Text = "(customer details)"
        ' 
        ' LblPaymentOption2
        ' 
        LblPaymentOption2.AutoSize = True
        LblPaymentOption2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblPaymentOption2.Location = New Point(270, 506)
        LblPaymentOption2.Margin = New Padding(4, 0, 4, 0)
        LblPaymentOption2.Name = "LblPaymentOption2"
        LblPaymentOption2.Size = New Size(187, 16)
        LblPaymentOption2.TabIndex = 9
        LblPaymentOption2.Text = "(selected payment option)"
        ' 
        ' LblTotalAmount2
        ' 
        LblTotalAmount2.AutoSize = True
        LblTotalAmount2.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblTotalAmount2.Location = New Point(270, 454)
        LblTotalAmount2.Margin = New Padding(4, 0, 4, 0)
        LblTotalAmount2.Name = "LblTotalAmount2"
        LblTotalAmount2.Size = New Size(150, 18)
        LblTotalAmount2.TabIndex = 10
        LblTotalAmount2.Text = "(total amount paid)"
        ' 
        ' LblPurchaseDetails2
        ' 
        LblPurchaseDetails2.AutoSize = True
        LblPurchaseDetails2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblPurchaseDetails2.Location = New Point(270, 173)
        LblPurchaseDetails2.Margin = New Padding(4, 0, 4, 0)
        LblPurchaseDetails2.Name = "LblPurchaseDetails2"
        LblPurchaseDetails2.Size = New Size(127, 13)
        LblPurchaseDetails2.TabIndex = 11
        LblPurchaseDetails2.Text = "(purchased products)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Highlight
        Label1.Location = New Point(270, 652)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(254, 18)
        Label1.TabIndex = 12
        Label1.Text = "Thank you for shopping With Us!"
        ' 
        ' LblDateOfPayment1
        ' 
        LblDateOfPayment1.AutoSize = True
        LblDateOfPayment1.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblDateOfPayment1.Location = New Point(20, 596)
        LblDateOfPayment1.Margin = New Padding(4, 0, 4, 0)
        LblDateOfPayment1.Name = "LblDateOfPayment1"
        LblDateOfPayment1.Size = New Size(131, 16)
        LblDateOfPayment1.TabIndex = 13
        LblDateOfPayment1.Text = "Date Of Payment :"
        ' 
        ' LblDateOfPayment2
        ' 
        LblDateOfPayment2.AutoSize = True
        LblDateOfPayment2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblDateOfPayment2.Location = New Point(270, 596)
        LblDateOfPayment2.Margin = New Padding(4, 0, 4, 0)
        LblDateOfPayment2.Name = "LblDateOfPayment2"
        LblDateOfPayment2.Size = New Size(111, 16)
        LblDateOfPayment2.TabIndex = 14
        LblDateOfPayment2.Text = "(date payment)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(270, 552)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 16)
        Label2.TabIndex = 15
        Label2.Text = "Success"
        ' 
        ' FormInvoice
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(765, 711)
        Controls.Add(Label2)
        Controls.Add(LblDateOfPayment2)
        Controls.Add(LblDateOfPayment1)
        Controls.Add(Label1)
        Controls.Add(LblPurchaseDetails2)
        Controls.Add(LblTotalAmount2)
        Controls.Add(LblPaymentOption2)
        Controls.Add(LblCustDetails2)
        Controls.Add(BtnInvoiceOK)
        Controls.Add(LblPaymentStatus1)
        Controls.Add(LblPaymentOption1)
        Controls.Add(LblTotalAmount1)
        Controls.Add(LblPurchaseDetails1)
        Controls.Add(DgvFinalInvoice)
        Controls.Add(LblCustDetails1)
        Controls.Add(LblInvoice)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        Name = "FormInvoice"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Invoice"
        CType(DgvFinalInvoice, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents LblInvoice As System.Windows.Forms.Label
    Friend WithEvents LblCustDetails1 As System.Windows.Forms.Label
    Friend WithEvents DgvFinalInvoice As System.Windows.Forms.DataGridView
    Friend WithEvents LblPurchaseDetails1 As System.Windows.Forms.Label
    Friend WithEvents LblTotalAmount1 As System.Windows.Forms.Label
    Friend WithEvents LblPaymentOption1 As System.Windows.Forms.Label
    Friend WithEvents LblPaymentStatus1 As System.Windows.Forms.Label
    Friend WithEvents BtnInvoiceOK As System.Windows.Forms.Button
    Friend WithEvents LblCustDetails2 As System.Windows.Forms.Label
    Friend WithEvents LblPaymentOption2 As System.Windows.Forms.Label
    Friend WithEvents LblTotalAmount2 As System.Windows.Forms.Label
    Friend WithEvents LblPurchaseDetails2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblDateOfPayment1 As System.Windows.Forms.Label
    Friend WithEvents LblDateOfPayment2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
