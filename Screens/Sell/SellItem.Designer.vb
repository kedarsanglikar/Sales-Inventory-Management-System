<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SellItem))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StockTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.ProDescTextBox = New System.Windows.Forms.TextBox()
        Me.ProNameTextBox = New System.Windows.Forms.TextBox()
        Me.ProIdTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.sellBtn = New System.Windows.Forms.Button()
        Me.changeTextBox = New System.Windows.Forms.TextBox()
        Me.receiveCashTextBox = New System.Windows.Forms.TextBox()
        Me.totalPriceTextBox = New System.Windows.Forms.TextBox()
        Me.unitTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.BrandNameTextBox = New System.Windows.Forms.TextBox()
        Me.searchBtn = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.printBillBtn = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.printPreviewBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1263, 89)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(485, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELL ITEM"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Lime
        Me.GroupBox1.Controls.Add(Me.StockTextBox)
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Controls.Add(Me.ProDescTextBox)
        Me.GroupBox1.Controls.Add(Me.ProNameTextBox)
        Me.GroupBox1.Controls.Add(Me.ProIdTextBox)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(660, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(604, 289)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Info"
        '
        'StockTextBox
        '
        Me.StockTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockTextBox.Location = New System.Drawing.Point(207, 227)
        Me.StockTextBox.Name = "StockTextBox"
        Me.StockTextBox.Size = New System.Drawing.Size(318, 28)
        Me.StockTextBox.TabIndex = 9
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTextBox.Location = New System.Drawing.Point(207, 184)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(318, 28)
        Me.PriceTextBox.TabIndex = 8
        '
        'ProDescTextBox
        '
        Me.ProDescTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProDescTextBox.Location = New System.Drawing.Point(207, 137)
        Me.ProDescTextBox.Name = "ProDescTextBox"
        Me.ProDescTextBox.Size = New System.Drawing.Size(318, 28)
        Me.ProDescTextBox.TabIndex = 7
        '
        'ProNameTextBox
        '
        Me.ProNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProNameTextBox.Location = New System.Drawing.Point(207, 89)
        Me.ProNameTextBox.Name = "ProNameTextBox"
        Me.ProNameTextBox.Size = New System.Drawing.Size(318, 28)
        Me.ProNameTextBox.TabIndex = 6
        '
        'ProIdTextBox
        '
        Me.ProIdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProIdTextBox.Location = New System.Drawing.Point(207, 42)
        Me.ProIdTextBox.Name = "ProIdTextBox"
        Me.ProIdTextBox.Size = New System.Drawing.Size(318, 28)
        Me.ProIdTextBox.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 24)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Stock :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 24)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Price :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(147, 24)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Product Desc :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 24)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Product Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Product ID :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Magenta
        Me.GroupBox2.Controls.Add(Me.clearBtn)
        Me.GroupBox2.Controls.Add(Me.closeBtn)
        Me.GroupBox2.Controls.Add(Me.sellBtn)
        Me.GroupBox2.Controls.Add(Me.changeTextBox)
        Me.GroupBox2.Controls.Add(Me.receiveCashTextBox)
        Me.GroupBox2.Controls.Add(Me.totalPriceTextBox)
        Me.GroupBox2.Controls.Add(Me.unitTextBox)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(660, 390)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(604, 301)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Other info"
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.Location = New System.Drawing.Point(400, 227)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(125, 59)
        Me.closeBtn.TabIndex = 9
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = False
        '
        'sellBtn
        '
        Me.sellBtn.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.sellBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sellBtn.Location = New System.Drawing.Point(138, 227)
        Me.sellBtn.Name = "sellBtn"
        Me.sellBtn.Size = New System.Drawing.Size(125, 59)
        Me.sellBtn.TabIndex = 8
        Me.sellBtn.Text = "Sell"
        Me.sellBtn.UseVisualStyleBackColor = False
        '
        'changeTextBox
        '
        Me.changeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changeTextBox.Location = New System.Drawing.Point(207, 176)
        Me.changeTextBox.Name = "changeTextBox"
        Me.changeTextBox.Size = New System.Drawing.Size(318, 28)
        Me.changeTextBox.TabIndex = 7
        '
        'receiveCashTextBox
        '
        Me.receiveCashTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiveCashTextBox.Location = New System.Drawing.Point(207, 132)
        Me.receiveCashTextBox.Name = "receiveCashTextBox"
        Me.receiveCashTextBox.Size = New System.Drawing.Size(318, 28)
        Me.receiveCashTextBox.TabIndex = 6
        '
        'totalPriceTextBox
        '
        Me.totalPriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPriceTextBox.Location = New System.Drawing.Point(207, 88)
        Me.totalPriceTextBox.Name = "totalPriceTextBox"
        Me.totalPriceTextBox.Size = New System.Drawing.Size(318, 28)
        Me.totalPriceTextBox.TabIndex = 5
        '
        'unitTextBox
        '
        Me.unitTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unitTextBox.Location = New System.Drawing.Point(207, 45)
        Me.unitTextBox.Name = "unitTextBox"
        Me.unitTextBox.Size = New System.Drawing.Size(318, 28)
        Me.unitTextBox.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gold
        Me.Label13.Location = New System.Drawing.Point(38, 179)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 24)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Change :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gold
        Me.Label12.Location = New System.Drawing.Point(38, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 24)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Receive Cash :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(38, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 24)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Total Price :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gold
        Me.Label10.Location = New System.Drawing.Point(38, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 24)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Unit :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(71, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Product Categ."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Enter Brand Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(196, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(259, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "(Eg. : Oil, Biscuits, Grains....)"
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryTextBox.Location = New System.Drawing.Point(246, 160)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(295, 27)
        Me.CategoryTextBox.TabIndex = 7
        '
        'BrandNameTextBox
        '
        Me.BrandNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrandNameTextBox.Location = New System.Drawing.Point(246, 208)
        Me.BrandNameTextBox.Name = "BrandNameTextBox"
        Me.BrandNameTextBox.Size = New System.Drawing.Size(295, 27)
        Me.BrandNameTextBox.TabIndex = 8
        '
        'searchBtn
        '
        Me.searchBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.searchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.searchBtn.Location = New System.Drawing.Point(283, 255)
        Me.searchBtn.Name = "searchBtn"
        Me.searchBtn.Size = New System.Drawing.Size(116, 47)
        Me.searchBtn.TabIndex = 9
        Me.searchBtn.Text = "Search"
        Me.searchBtn.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 336)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(641, 355)
        Me.DataGridView1.TabIndex = 10
        '
        'printBillBtn
        '
        Me.printBillBtn.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.printBillBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printBillBtn.Location = New System.Drawing.Point(1319, 187)
        Me.printBillBtn.Name = "printBillBtn"
        Me.printBillBtn.Size = New System.Drawing.Size(142, 74)
        Me.printBillBtn.TabIndex = 10
        Me.printBillBtn.Text = "Print Bill"
        Me.printBillBtn.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'printPreviewBtn
        '
        Me.printPreviewBtn.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.printPreviewBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printPreviewBtn.Location = New System.Drawing.Point(1319, 310)
        Me.printPreviewBtn.Name = "printPreviewBtn"
        Me.printPreviewBtn.Size = New System.Drawing.Size(142, 74)
        Me.printPreviewBtn.TabIndex = 11
        Me.printPreviewBtn.Text = "Print Preview"
        Me.printPreviewBtn.UseVisualStyleBackColor = False
        '
        'clearBtn
        '
        Me.clearBtn.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.clearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearBtn.Location = New System.Drawing.Point(269, 227)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(125, 59)
        Me.clearBtn.TabIndex = 10
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = False
        '
        'SellItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1504, 703)
        Me.Controls.Add(Me.printPreviewBtn)
        Me.Controls.Add(Me.printBillBtn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.searchBtn)
        Me.Controls.Add(Me.BrandNameTextBox)
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "SellItem"
        Me.Text = "SellItem"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CategoryTextBox As TextBox
    Friend WithEvents BrandNameTextBox As TextBox
    Friend WithEvents searchBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents StockTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents ProDescTextBox As TextBox
    Friend WithEvents ProNameTextBox As TextBox
    Friend WithEvents ProIdTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents changeTextBox As TextBox
    Friend WithEvents receiveCashTextBox As TextBox
    Friend WithEvents totalPriceTextBox As TextBox
    Friend WithEvents unitTextBox As TextBox
    Friend WithEvents closeBtn As Button
    Friend WithEvents sellBtn As Button
    Friend WithEvents printBillBtn As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents printPreviewBtn As Button
    Friend WithEvents clearBtn As Button
End Class
