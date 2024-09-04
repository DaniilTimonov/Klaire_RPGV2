<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Engine_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Engine_Form))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        PictureBox6 = New PictureBox()
        Label2 = New Label()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.claire_right
        PictureBox1.Location = New Point(90, 98)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(63, 111)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.left_chris
        PictureBox2.Location = New Point(404, 121)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(83, 142)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.icons8_enter_100
        PictureBox3.Location = New Point(420, 80)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(37, 35)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        PictureBox3.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        Label1.ForeColor = SystemColors.ControlDarkDark
        Label1.Location = New Point(310, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 18)
        Label1.TabIndex = 3
        Label1.Text = "click Enter for interract"
        Label1.Visible = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.BurlyWood
        GroupBox1.Controls.Add(PictureBox6)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(PictureBox5)
        GroupBox1.Controls.Add(PictureBox4)
        GroupBox1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(204))
        GroupBox1.Location = New Point(522, 98)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(208, 198)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Chris Redfield"
        GroupBox1.Visible = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.close
        PictureBox6.Location = New Point(168, 0)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(40, 36)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 5
        PictureBox6.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Impact", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(16, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(177, 23)
        Label2.TabIndex = 5
        Label2.Text = "Hi , where is Winters?"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.Chris_portrait
        PictureBox5.Location = New Point(6, 32)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(75, 73)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 1
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Location = New Point(307, -4)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(100, 50)
        PictureBox4.TabIndex = 0
        PictureBox4.TabStop = False
        ' 
        ' Engine_Form
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Engine_Form"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox6 As PictureBox

End Class
