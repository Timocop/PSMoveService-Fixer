﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button_1_1xSmaller = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_2xBigger = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button_2xSmaller = New System.Windows.Forms.Button()
        Me.ComboBox_ScaleAxis = New System.Windows.Forms.ComboBox()
        Me.Button_3xBigger = New System.Windows.Forms.Button()
        Me.Button_3xSmaller = New System.Windows.Forms.Button()
        Me.Button_1_1xBigger = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown_Scale = New System.Windows.Forms.NumericUpDown()
        Me.Button_CustomScale = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown_Scale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(12, 12)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(460, 54)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = resources.GetString("Label4.Text")
        '
        'Button_1_1xSmaller
        '
        Me.Button_1_1xSmaller.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_1_1xSmaller.Location = New System.Drawing.Point(13, 72)
        Me.Button_1_1xSmaller.Name = "Button_1_1xSmaller"
        Me.Button_1_1xSmaller.Size = New System.Drawing.Size(180, 32)
        Me.Button_1_1xSmaller.TabIndex = 37
        Me.Button_1_1xSmaller.Text = "Scale Micro Smaller"
        Me.Button_1_1xSmaller.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 266)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Scaling Axis:"
        '
        'Button_2xBigger
        '
        Me.Button_2xBigger.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_2xBigger.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_2xBigger.Location = New System.Drawing.Point(292, 110)
        Me.Button_2xBigger.Name = "Button_2xBigger"
        Me.Button_2xBigger.Size = New System.Drawing.Size(180, 32)
        Me.Button_2xBigger.TabIndex = 27
        Me.Button_2xBigger.Text = "Scale 2x Bigger"
        Me.Button_2xBigger.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel2.Location = New System.Drawing.Point(15, 259)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(457, 1)
        Me.Panel2.TabIndex = 32
        '
        'Button_2xSmaller
        '
        Me.Button_2xSmaller.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_2xSmaller.Location = New System.Drawing.Point(13, 110)
        Me.Button_2xSmaller.Name = "Button_2xSmaller"
        Me.Button_2xSmaller.Size = New System.Drawing.Size(180, 32)
        Me.Button_2xSmaller.TabIndex = 28
        Me.Button_2xSmaller.Text = "Scale 1/2 Smaller"
        Me.Button_2xSmaller.UseVisualStyleBackColor = True
        '
        'ComboBox_ScaleAxis
        '
        Me.ComboBox_ScaleAxis.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox_ScaleAxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_ScaleAxis.Enabled = False
        Me.ComboBox_ScaleAxis.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ComboBox_ScaleAxis.FormattingEnabled = True
        Me.ComboBox_ScaleAxis.Items.AddRange(New Object() {"All (X, Y, Z)", "X", "Y", "Z"})
        Me.ComboBox_ScaleAxis.Location = New System.Drawing.Point(15, 282)
        Me.ComboBox_ScaleAxis.Name = "ComboBox_ScaleAxis"
        Me.ComboBox_ScaleAxis.Size = New System.Drawing.Size(457, 21)
        Me.ComboBox_ScaleAxis.TabIndex = 38
        '
        'Button_3xBigger
        '
        Me.Button_3xBigger.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_3xBigger.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_3xBigger.Location = New System.Drawing.Point(292, 148)
        Me.Button_3xBigger.Name = "Button_3xBigger"
        Me.Button_3xBigger.Size = New System.Drawing.Size(180, 32)
        Me.Button_3xBigger.TabIndex = 29
        Me.Button_3xBigger.Text = "Scale 3x Bigger"
        Me.Button_3xBigger.UseVisualStyleBackColor = True
        '
        'Button_3xSmaller
        '
        Me.Button_3xSmaller.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_3xSmaller.Location = New System.Drawing.Point(13, 148)
        Me.Button_3xSmaller.Name = "Button_3xSmaller"
        Me.Button_3xSmaller.Size = New System.Drawing.Size(180, 32)
        Me.Button_3xSmaller.TabIndex = 30
        Me.Button_3xSmaller.Text = "Scale 1/3 Smaller"
        Me.Button_3xSmaller.UseVisualStyleBackColor = True
        '
        'Button_1_1xBigger
        '
        Me.Button_1_1xBigger.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_1_1xBigger.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_1_1xBigger.Location = New System.Drawing.Point(292, 72)
        Me.Button_1_1xBigger.Name = "Button_1_1xBigger"
        Me.Button_1_1xBigger.Size = New System.Drawing.Size(180, 32)
        Me.Button_1_1xBigger.TabIndex = 36
        Me.Button_1_1xBigger.Text = "Scale Micro Bigger"
        Me.Button_1_1xBigger.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Location = New System.Drawing.Point(13, 186)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 1)
        Me.Panel1.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(13, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Note: Scaling is relative not absolute."
        '
        'NumericUpDown_Scale
        '
        Me.NumericUpDown_Scale.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumericUpDown_Scale.DecimalPlaces = 2
        Me.NumericUpDown_Scale.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.NumericUpDown_Scale.Location = New System.Drawing.Point(13, 193)
        Me.NumericUpDown_Scale.Name = "NumericUpDown_Scale"
        Me.NumericUpDown_Scale.Size = New System.Drawing.Size(459, 22)
        Me.NumericUpDown_Scale.TabIndex = 33
        Me.NumericUpDown_Scale.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Button_CustomScale
        '
        Me.Button_CustomScale.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_CustomScale.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button_CustomScale.Location = New System.Drawing.Point(13, 221)
        Me.Button_CustomScale.Name = "Button_CustomScale"
        Me.Button_CustomScale.Size = New System.Drawing.Size(459, 32)
        Me.Button_CustomScale.TabIndex = 34
        Me.Button_CustomScale.Text = "Scale"
        Me.Button_CustomScale.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button_1_1xSmaller)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_2xBigger)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button_2xSmaller)
        Me.Controls.Add(Me.ComboBox_ScaleAxis)
        Me.Controls.Add(Me.Button_3xBigger)
        Me.Controls.Add(Me.Button_3xSmaller)
        Me.Controls.Add(Me.Button_1_1xBigger)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDown_Scale)
        Me.Controls.Add(Me.Button_CustomScale)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PSMoveServiceEx - Playspace Scaler"
        CType(Me.NumericUpDown_Scale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Button_1_1xSmaller As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_2xBigger As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button_2xSmaller As Button
    Friend WithEvents ComboBox_ScaleAxis As ComboBox
    Friend WithEvents Button_3xBigger As Button
    Friend WithEvents Button_3xSmaller As Button
    Friend WithEvents Button_1_1xBigger As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown_Scale As NumericUpDown
    Friend WithEvents Button_CustomScale As Button
End Class
