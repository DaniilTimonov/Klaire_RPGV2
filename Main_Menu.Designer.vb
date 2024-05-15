<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Menu))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        GroupBox1 = New GroupBox()
        PictureBox4 = New PictureBox()
        Timer1 = New Timer(components)
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = My.Resources.Resources.start_button
        PictureBox1.Location = New Point(452, 143)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(219, 99)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = My.Resources.Resources.exit_button
        PictureBox2.Location = New Point(407, 359)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(311, 104)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Cursor = Cursors.Hand
        PictureBox3.Image = My.Resources.Resources.Controls_button
        PictureBox3.Location = New Point(440, 248)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(244, 105)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackgroundImage = My.Resources.Resources.contols_block
        GroupBox1.BackgroundImageLayout = ImageLayout.Stretch
        GroupBox1.Controls.Add(PictureBox4)
        GroupBox1.Location = New Point(0, 105)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(810, 348)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        GroupBox1.Visible = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Cursor = Cursors.Hand
        PictureBox4.Image = My.Resources.Resources.back_button
        PictureBox4.Location = New Point(531, 249)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(251, 110)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' Main_Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        BackgroundImage = My.Resources.Resources.menu_background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        DoubleBuffered = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Main_Menu"
        Text = "Main_Menu"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
