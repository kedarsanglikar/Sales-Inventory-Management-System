<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DashboardForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Registrationbtn = New System.Windows.Forms.Button()
        Me.Stockbtn = New System.Windows.Forms.Button()
        Me.Sellbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoggedUserLabel = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LoggedTypeLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.HotPink
        Me.Panel1.Controls.Add(Me.Registrationbtn)
        Me.Panel1.Controls.Add(Me.Stockbtn)
        Me.Panel1.Controls.Add(Me.Sellbtn)
        Me.Panel1.Location = New System.Drawing.Point(0, 149)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 637)
        Me.Panel1.TabIndex = 0
        '
        'Registrationbtn
        '
        Me.Registrationbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Registrationbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Registrationbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Registrationbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registrationbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Registrationbtn.Location = New System.Drawing.Point(29, 438)
        Me.Registrationbtn.Name = "Registrationbtn"
        Me.Registrationbtn.Size = New System.Drawing.Size(197, 89)
        Me.Registrationbtn.TabIndex = 2
        Me.Registrationbtn.Text = "Registration"
        Me.Registrationbtn.UseVisualStyleBackColor = False
        '
        'Stockbtn
        '
        Me.Stockbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Stockbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Stockbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Stockbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stockbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Stockbtn.Location = New System.Drawing.Point(29, 72)
        Me.Stockbtn.Name = "Stockbtn"
        Me.Stockbtn.Size = New System.Drawing.Size(197, 89)
        Me.Stockbtn.TabIndex = 1
        Me.Stockbtn.Text = "Stock"
        Me.Stockbtn.UseVisualStyleBackColor = False
        '
        'Sellbtn
        '
        Me.Sellbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Sellbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Sellbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sellbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sellbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Sellbtn.Location = New System.Drawing.Point(29, 258)
        Me.Sellbtn.Name = "Sellbtn"
        Me.Sellbtn.Size = New System.Drawing.Size(197, 89)
        Me.Sellbtn.TabIndex = 0
        Me.Sellbtn.Text = "Sell"
        Me.Sellbtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1721, 149)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(455, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(712, 46)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Sales Inventory Management System"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(256, 149)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1465, 634)
        Me.Panel2.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(388, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(647, 46)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "GENERAL STORES PRODUCTS"
        '
        'LoggedUserLabel
        '
        Me.LoggedUserLabel.AutoSize = True
        Me.LoggedUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoggedUserLabel.ForeColor = System.Drawing.Color.Red
        Me.LoggedUserLabel.Location = New System.Drawing.Point(24, 67)
        Me.LoggedUserLabel.Name = "LoggedUserLabel"
        Me.LoggedUserLabel.Size = New System.Drawing.Size(54, 25)
        Me.LoggedUserLabel.TabIndex = 6
        Me.LoggedUserLabel.Text = "user"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Yellow
        Me.LinkLabel1.Location = New System.Drawing.Point(1339, 63)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(93, 29)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Logout"
        '
        'LoggedTypeLabel
        '
        Me.LoggedTypeLabel.AutoSize = True
        Me.LoggedTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoggedTypeLabel.ForeColor = System.Drawing.Color.Red
        Me.LoggedTypeLabel.Location = New System.Drawing.Point(208, 67)
        Me.LoggedTypeLabel.Name = "LoggedTypeLabel"
        Me.LoggedTypeLabel.Size = New System.Drawing.Size(53, 25)
        Me.LoggedTypeLabel.TabIndex = 9
        Me.LoggedTypeLabel.Text = "type"
        '
        'DashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(1721, 782)
        Me.Controls.Add(Me.LoggedTypeLabel)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LoggedUserLabel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "DashboardForm"
        Me.Text = "DashboardForm"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Sellbtn As Button
    Friend WithEvents Registrationbtn As Button
    Friend WithEvents Stockbtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents LoggedUserLabel As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LoggedTypeLabel As Label
End Class
