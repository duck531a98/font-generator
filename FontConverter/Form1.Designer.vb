<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.char_height = New System.Windows.Forms.NumericUpDown()
        Me.char_width = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.low8 = New System.Windows.Forms.NumericUpDown()
        Me.high8 = New System.Windows.Forms.NumericUpDown()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.offset_y = New System.Windows.Forms.NumericUpDown()
        Me.offset_x = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.startbox = New System.Windows.Forms.TextBox()
        Me.endbox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.char_height, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.char_width, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.low8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.high8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.offset_y, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.offset_x, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FontDialog1
        '
        Me.FontDialog1.ShowApply = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(447, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 46)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Choose Font"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(445, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 50)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Convert "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'char_height
        '
        Me.char_height.Location = New System.Drawing.Point(492, 147)
        Me.char_height.Name = "char_height"
        Me.char_height.Size = New System.Drawing.Size(45, 21)
        Me.char_height.TabIndex = 3
        Me.char_height.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'char_width
        '
        Me.char_width.Location = New System.Drawing.Point(492, 120)
        Me.char_width.Name = "char_width"
        Me.char_width.Size = New System.Drawing.Size(45, 21)
        Me.char_width.TabIndex = 4
        Me.char_width.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(451, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Width"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(445, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Height"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(67, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 154)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "character"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 50)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(168, 38)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Display "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'low8
        '
        Me.low8.Location = New System.Drawing.Point(129, 20)
        Me.low8.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.low8.Name = "low8"
        Me.low8.Size = New System.Drawing.Size(45, 21)
        Me.low8.TabIndex = 3
        Me.low8.Value = New Decimal(New Integer() {45, 0, 0, 0})
        '
        'high8
        '
        Me.high8.Location = New System.Drawing.Point(49, 20)
        Me.high8.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.high8.Name = "high8"
        Me.high8.Size = New System.Drawing.Size(45, 21)
        Me.high8.TabIndex = 4
        Me.high8.Value = New Decimal(New Integer() {158, 0, 0, 0})
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(6, 106)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(168, 41)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Save image"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.high8)
        Me.GroupBox2.Controls.Add(Me.low8)
        Me.GroupBox2.Location = New System.Drawing.Point(197, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(180, 154)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "display a unicode char"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(100, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 12)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Low"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "High"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 286)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(526, 23)
        Me.ProgressBar1.TabIndex = 13
        '
        'offset_y
        '
        Me.offset_y.Location = New System.Drawing.Point(492, 174)
        Me.offset_y.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.offset_y.Name = "offset_y"
        Me.offset_y.Size = New System.Drawing.Size(45, 21)
        Me.offset_y.TabIndex = 14
        '
        'offset_x
        '
        Me.offset_x.Location = New System.Drawing.Point(492, 201)
        Me.offset_x.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.offset_x.Name = "offset_x"
        Me.offset_x.Size = New System.Drawing.Size(46, 21)
        Me.offset_x.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(403, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 12)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "offset-height"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(409, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 12)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "offset-width"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(423, 228)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(114, 16)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "Convert Partial"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'startbox
        '
        Me.startbox.Location = New System.Drawing.Point(390, 250)
        Me.startbox.Name = "startbox"
        Me.startbox.Size = New System.Drawing.Size(60, 21)
        Me.startbox.TabIndex = 18
        Me.startbox.Text = "0000"
        '
        'endbox
        '
        Me.endbox.Location = New System.Drawing.Point(485, 250)
        Me.endbox.Name = "endbox"
        Me.endbox.Size = New System.Drawing.Size(53, 21)
        Me.endbox.TabIndex = 19
        Me.endbox.Text = "00ff"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(349, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 12)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "start"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(456, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 12)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "end"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 321)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.endbox)
        Me.Controls.Add(Me.startbox)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.offset_x)
        Me.Controls.Add(Me.offset_y)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.char_width)
        Me.Controls.Add(Me.char_height)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Font Converter"
        CType(Me.char_height, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.char_width, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.low8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.high8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.offset_y, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.offset_x, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents char_height As System.Windows.Forms.NumericUpDown
    Friend WithEvents char_width As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents low8 As System.Windows.Forms.NumericUpDown
    Friend WithEvents high8 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents offset_y As System.Windows.Forms.NumericUpDown
    Friend WithEvents offset_x As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents startbox As System.Windows.Forms.TextBox
    Friend WithEvents endbox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
