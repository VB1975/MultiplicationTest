<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumberToTest = New System.Windows.Forms.TextBox()
        Me.TxtIterations = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnStartTest = New System.Windows.Forms.Button()
        Me.BtnDisplayResults = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number To Test:"
        '
        'TxtNumberToTest
        '
        Me.TxtNumberToTest.BackColor = System.Drawing.SystemColors.Info
        Me.TxtNumberToTest.ForeColor = System.Drawing.Color.Teal
        Me.TxtNumberToTest.Location = New System.Drawing.Point(186, 12)
        Me.TxtNumberToTest.Name = "TxtNumberToTest"
        Me.TxtNumberToTest.Size = New System.Drawing.Size(62, 29)
        Me.TxtNumberToTest.TabIndex = 3
        Me.TxtNumberToTest.Text = "7"
        Me.TxtNumberToTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtIterations
        '
        Me.TxtIterations.BackColor = System.Drawing.SystemColors.Info
        Me.TxtIterations.ForeColor = System.Drawing.Color.Teal
        Me.TxtIterations.Location = New System.Drawing.Point(399, 12)
        Me.TxtIterations.Name = "TxtIterations"
        Me.TxtIterations.Size = New System.Drawing.Size(62, 29)
        Me.TxtIterations.TabIndex = 4
        Me.TxtIterations.Text = "12"
        Me.TxtIterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(293, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Iterations:"
        '
        'BtnStartTest
        '
        Me.BtnStartTest.BackColor = System.Drawing.Color.Green
        Me.BtnStartTest.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnStartTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple
        Me.BtnStartTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnStartTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStartTest.ForeColor = System.Drawing.Color.White
        Me.BtnStartTest.Location = New System.Drawing.Point(84, 80)
        Me.BtnStartTest.Name = "BtnStartTest"
        Me.BtnStartTest.Size = New System.Drawing.Size(158, 73)
        Me.BtnStartTest.TabIndex = 0
        Me.BtnStartTest.Text = "Start" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Test"
        Me.BtnStartTest.UseVisualStyleBackColor = False
        '
        'BtnDisplayResults
        '
        Me.BtnDisplayResults.BackColor = System.Drawing.Color.Teal
        Me.BtnDisplayResults.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnDisplayResults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple
        Me.BtnDisplayResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnDisplayResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDisplayResults.ForeColor = System.Drawing.Color.White
        Me.BtnDisplayResults.Location = New System.Drawing.Point(248, 80)
        Me.BtnDisplayResults.Name = "BtnDisplayResults"
        Me.BtnDisplayResults.Size = New System.Drawing.Size(158, 73)
        Me.BtnDisplayResults.TabIndex = 1
        Me.BtnDisplayResults.Text = "Display" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Results"
        Me.BtnDisplayResults.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(166, 159)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(158, 73)
        Me.BtnExit.TabIndex = 2
        Me.BtnExit.Text = "Exit!"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 247)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnDisplayResults)
        Me.Controls.Add(Me.BtnStartTest)
        Me.Controls.Add(Me.TxtIterations)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNumberToTest)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "FrmMain"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Multiplication Test"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNumberToTest As TextBox
    Friend WithEvents TxtIterations As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnStartTest As Button
    Friend WithEvents BtnDisplayResults As Button
    Friend WithEvents BtnExit As Button
End Class
