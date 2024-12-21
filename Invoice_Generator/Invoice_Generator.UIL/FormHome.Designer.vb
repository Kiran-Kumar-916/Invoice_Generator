<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormHome))
        MenuStrip1 = New MenuStrip()
        ProductToolStripMenuItem = New ToolStripMenuItem()
        CategoriesToolStripMenuItem = New ToolStripMenuItem()
        CustomersToolStripMenuItem = New ToolStripMenuItem()
        CartToolStripMenuItem = New ToolStripMenuItem()
        BtnHomeAdd = New Button()
        BtnHomeUpdate = New Button()
        BtnHomeDelete = New Button()
        Panel1 = New Panel()
        LblHomeCaption = New Label()
        PictureBoxHome = New PictureBox()
        MenuStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBoxHome, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ProductToolStripMenuItem, CategoriesToolStripMenuItem, CustomersToolStripMenuItem, CartToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 2, 0, 2)
        MenuStrip1.Size = New Size(1197, 34)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ProductToolStripMenuItem
        ' 
        ProductToolStripMenuItem.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ProductToolStripMenuItem.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        ProductToolStripMenuItem.Size = New Size(102, 30)
        ProductToolStripMenuItem.Text = "Products"
        ' 
        ' CategoriesToolStripMenuItem
        ' 
        CategoriesToolStripMenuItem.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CategoriesToolStripMenuItem.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem"
        CategoriesToolStripMenuItem.Size = New Size(119, 30)
        CategoriesToolStripMenuItem.Text = "Categories"
        ' 
        ' CustomersToolStripMenuItem
        ' 
        CustomersToolStripMenuItem.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CustomersToolStripMenuItem.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem"
        CustomersToolStripMenuItem.Size = New Size(120, 30)
        CustomersToolStripMenuItem.Text = "Customers"
        ' 
        ' CartToolStripMenuItem
        ' 
        CartToolStripMenuItem.Font = New Font("Palatino Linotype", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CartToolStripMenuItem.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        CartToolStripMenuItem.Name = "CartToolStripMenuItem"
        CartToolStripMenuItem.Size = New Size(63, 30)
        CartToolStripMenuItem.Text = "Cart"
        ' 
        ' BtnHomeAdd
        ' 
        BtnHomeAdd.BackColor = Color.White
        BtnHomeAdd.Font = New Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnHomeAdd.ForeColor = SystemColors.ControlDarkDark
        BtnHomeAdd.Location = New Point(0, 145)
        BtnHomeAdd.Margin = New Padding(4, 3, 4, 3)
        BtnHomeAdd.Name = "BtnHomeAdd"
        BtnHomeAdd.Size = New Size(261, 92)
        BtnHomeAdd.TabIndex = 1
        BtnHomeAdd.Text = "Add"
        BtnHomeAdd.UseVisualStyleBackColor = False
        ' 
        ' BtnHomeUpdate
        ' 
        BtnHomeUpdate.BackColor = Color.Silver
        BtnHomeUpdate.Font = New Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnHomeUpdate.ForeColor = Color.Black
        BtnHomeUpdate.Location = New Point(0, 310)
        BtnHomeUpdate.Margin = New Padding(4, 3, 4, 3)
        BtnHomeUpdate.Name = "BtnHomeUpdate"
        BtnHomeUpdate.Size = New Size(261, 89)
        BtnHomeUpdate.TabIndex = 2
        BtnHomeUpdate.Text = "Update"
        BtnHomeUpdate.UseVisualStyleBackColor = False
        ' 
        ' BtnHomeDelete
        ' 
        BtnHomeDelete.BackColor = Color.Gray
        BtnHomeDelete.Font = New Font("Stencil", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnHomeDelete.ForeColor = Color.White
        BtnHomeDelete.Location = New Point(-4, 461)
        BtnHomeDelete.Margin = New Padding(4, 3, 4, 3)
        BtnHomeDelete.Name = "BtnHomeDelete"
        BtnHomeDelete.Size = New Size(265, 88)
        BtnHomeDelete.TabIndex = 3
        BtnHomeDelete.Text = "Delete"
        BtnHomeDelete.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightGreen
        Panel1.Controls.Add(BtnHomeDelete)
        Panel1.Controls.Add(BtnHomeUpdate)
        Panel1.Controls.Add(BtnHomeAdd)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 34)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(261, 561)
        Panel1.TabIndex = 4
        ' 
        ' LblHomeCaption
        ' 
        LblHomeCaption.AutoSize = True
        LblHomeCaption.Font = New Font("Algerian", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblHomeCaption.Location = New Point(675, 59)
        LblHomeCaption.Margin = New Padding(4, 0, 4, 0)
        LblHomeCaption.Name = "LblHomeCaption"
        LblHomeCaption.Size = New Size(168, 35)
        LblHomeCaption.TabIndex = 5
        LblHomeCaption.Text = "Products"
        ' 
        ' PictureBoxHome
        ' 
        PictureBoxHome.Image = CType(resources.GetObject("PictureBoxHome.Image"), Image)
        PictureBoxHome.Location = New Point(377, 122)
        PictureBoxHome.Name = "PictureBoxHome"
        PictureBoxHome.Size = New Size(763, 451)
        PictureBoxHome.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxHome.TabIndex = 6
        PictureBoxHome.TabStop = False
        ' 
        ' FormHome
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        ClientSize = New Size(1197, 595)
        Controls.Add(PictureBoxHome)
        Controls.Add(LblHomeCaption)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 3, 4, 3)
        Name = "FormHome"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(PictureBoxHome, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnHomeAdd As System.Windows.Forms.Button
    Friend WithEvents BtnHomeUpdate As System.Windows.Forms.Button
    Friend WithEvents BtnHomeDelete As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LblHomeCaption As System.Windows.Forms.Label
    Friend WithEvents PictureBoxHome As PictureBox

End Class
