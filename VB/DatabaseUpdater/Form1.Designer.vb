Namespace DatabaseUpdater
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.button1 = New System.Windows.Forms.Button()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.button2 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(11, 60)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(186, 23)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Create Schema"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' textBox1
			' 
			Me.textBox1.Location = New System.Drawing.Point(12, 34)
			Me.textBox1.Name = "textBox1"
			Me.textBox1.ReadOnly = True
			Me.textBox1.Size = New System.Drawing.Size(632, 20)
			Me.textBox1.TabIndex = 1
			Me.textBox1.Text = "XpoProvider=MSSqlServer;data source=(local);integrated security=SSPI;initial catalog=XpoWebTest"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(12, 15)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(243, 13)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Connection string with the XpoProvider parameter:"
			' 
			' button2
			' 
			Me.button2.Location = New System.Drawing.Point(203, 60)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(186, 23)
			Me.button2.TabIndex = 3
			Me.button2.Text = "Create Default Data"
			Me.button2.UseVisualStyleBackColor = True
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(656, 105)
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.button1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents button1 As System.Windows.Forms.Button
		Private textBox1 As System.Windows.Forms.TextBox
		Private label1 As System.Windows.Forms.Label
		Private WithEvents button2 As System.Windows.Forms.Button
	End Class
End Namespace

