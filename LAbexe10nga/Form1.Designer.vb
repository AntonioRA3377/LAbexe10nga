<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.NumInput = New System.Windows.Forms.NumericUpDown()
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.Listbox1 = New System.Windows.Forms.ListBox()
        Me.btnSort = New System.Windows.Forms.Button()
        CType(Me.NumInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter  Number:"
        '
        'NumInput
        '
        Me.NumInput.Location = New System.Drawing.Point(163, 39)
        Me.NumInput.Name = "NumInput"
        Me.NumInput.Size = New System.Drawing.Size(155, 20)
        Me.NumInput.TabIndex = 1
        '
        'btnWrite
        '
        Me.btnWrite.Location = New System.Drawing.Point(348, 40)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(132, 31)
        Me.btnWrite.TabIndex = 2
        Me.btnWrite.Text = "WRITE"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(108, 115)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(132, 31)
        Me.btnRead.TabIndex = 3
        Me.btnRead.Text = "READ"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'Listbox1
        '
        Me.Listbox1.FormattingEnabled = True
        Me.Listbox1.Location = New System.Drawing.Point(246, 88)
        Me.Listbox1.Name = "Listbox1"
        Me.Listbox1.Size = New System.Drawing.Size(234, 95)
        Me.Listbox1.TabIndex = 4
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(348, 204)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(132, 31)
        Me.btnSort.TabIndex = 5
        Me.btnSort.Text = "SORT"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.Listbox1)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnWrite)
        Me.Controls.Add(Me.NumInput)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = " "
        CType(Me.NumInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NumInput As NumericUpDown
    Friend WithEvents btnWrite As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents Listbox1 As ListBox
    Friend WithEvents btnSort As Button
End Class
