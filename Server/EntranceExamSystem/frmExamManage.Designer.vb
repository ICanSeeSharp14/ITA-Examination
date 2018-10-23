<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamManage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExamManage))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnedittime = New System.Windows.Forms.Button()
        Me.btnsavetime = New System.Windows.Forms.Button()
        Me.btncanceltime = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txttimeduration = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveitem = New System.Windows.Forms.Button()
        Me.btnCancelitem = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEdititem = New System.Windows.Forms.Button()
        Me.txtitems = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txttimeduration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtitems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 29)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "MINUTE(S)"
        '
        'btnedittime
        '
        Me.btnedittime.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnedittime.BackgroundImage = CType(resources.GetObject("btnedittime.BackgroundImage"), System.Drawing.Image)
        Me.btnedittime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnedittime.ForeColor = System.Drawing.Color.Azure
        Me.btnedittime.Location = New System.Drawing.Point(22, 102)
        Me.btnedittime.Name = "btnedittime"
        Me.btnedittime.Size = New System.Drawing.Size(78, 54)
        Me.btnedittime.TabIndex = 110
        Me.btnedittime.UseVisualStyleBackColor = False
        '
        'btnsavetime
        '
        Me.btnsavetime.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnsavetime.BackgroundImage = CType(resources.GetObject("btnsavetime.BackgroundImage"), System.Drawing.Image)
        Me.btnsavetime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsavetime.Enabled = False
        Me.btnsavetime.ForeColor = System.Drawing.Color.Azure
        Me.btnsavetime.Location = New System.Drawing.Point(106, 102)
        Me.btnsavetime.Name = "btnsavetime"
        Me.btnsavetime.Size = New System.Drawing.Size(78, 54)
        Me.btnsavetime.TabIndex = 111
        Me.btnsavetime.UseVisualStyleBackColor = False
        '
        'btncanceltime
        '
        Me.btncanceltime.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncanceltime.BackgroundImage = CType(resources.GetObject("btncanceltime.BackgroundImage"), System.Drawing.Image)
        Me.btncanceltime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btncanceltime.Enabled = False
        Me.btncanceltime.Location = New System.Drawing.Point(190, 102)
        Me.btncanceltime.Name = "btncanceltime"
        Me.btncanceltime.Size = New System.Drawing.Size(78, 54)
        Me.btncanceltime.TabIndex = 112
        Me.btncanceltime.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btncanceltime)
        Me.GroupBox3.Controls.Add(Me.btnsavetime)
        Me.GroupBox3.Controls.Add(Me.btnedittime)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txttimeduration)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(356, 61)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(287, 189)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Exam Time Duration"
        '
        'txttimeduration
        '
        Me.txttimeduration.Enabled = False
        Me.txttimeduration.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttimeduration.Location = New System.Drawing.Point(34, 31)
        Me.txttimeduration.Name = "txttimeduration"
        Me.txttimeduration.Size = New System.Drawing.Size(90, 38)
        Me.txttimeduration.TabIndex = 82
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(129, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 29)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "ITEM(S)"
        '
        'btnSaveitem
        '
        Me.btnSaveitem.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnSaveitem.BackgroundImage = CType(resources.GetObject("btnSaveitem.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveitem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveitem.Enabled = False
        Me.btnSaveitem.ForeColor = System.Drawing.Color.Azure
        Me.btnSaveitem.Location = New System.Drawing.Point(100, 102)
        Me.btnSaveitem.Name = "btnSaveitem"
        Me.btnSaveitem.Size = New System.Drawing.Size(78, 52)
        Me.btnSaveitem.TabIndex = 108
        Me.btnSaveitem.UseVisualStyleBackColor = False
        '
        'btnCancelitem
        '
        Me.btnCancelitem.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCancelitem.BackgroundImage = CType(resources.GetObject("btnCancelitem.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelitem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelitem.Enabled = False
        Me.btnCancelitem.Location = New System.Drawing.Point(185, 102)
        Me.btnCancelitem.Name = "btnCancelitem"
        Me.btnCancelitem.Size = New System.Drawing.Size(78, 52)
        Me.btnCancelitem.TabIndex = 109
        Me.btnCancelitem.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCancelitem)
        Me.GroupBox2.Controls.Add(Me.btnSaveitem)
        Me.GroupBox2.Controls.Add(Me.btnEdititem)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtitems)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(32, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 189)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Limit Exam Questions"
        '
        'btnEdititem
        '
        Me.btnEdititem.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnEdititem.BackgroundImage = CType(resources.GetObject("btnEdititem.BackgroundImage"), System.Drawing.Image)
        Me.btnEdititem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdititem.ForeColor = System.Drawing.Color.Azure
        Me.btnEdititem.Location = New System.Drawing.Point(16, 102)
        Me.btnEdititem.Name = "btnEdititem"
        Me.btnEdititem.Size = New System.Drawing.Size(78, 52)
        Me.btnEdititem.TabIndex = 105
        Me.btnEdititem.UseVisualStyleBackColor = False
        '
        'txtitems
        '
        Me.txtitems.Enabled = False
        Me.txtitems.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtitems.Location = New System.Drawing.Point(33, 36)
        Me.txtitems.Name = "txtitems"
        Me.txtitems.Size = New System.Drawing.Size(90, 38)
        Me.txtitems.TabIndex = 84
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(246, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 29)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "MANAGE EXAM"
        '
        'frmExamManage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(669, 279)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExamManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EXAM MANAGER"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txttimeduration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtitems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnedittime As System.Windows.Forms.Button
    Friend WithEvents btnsavetime As System.Windows.Forms.Button
    Friend WithEvents btncanceltime As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSaveitem As System.Windows.Forms.Button
    Friend WithEvents btnCancelitem As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnEdititem As System.Windows.Forms.Button
    Friend WithEvents txttimeduration As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtitems As System.Windows.Forms.NumericUpDown
End Class
