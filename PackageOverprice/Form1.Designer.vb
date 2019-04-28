<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.Magic = New System.Windows.Forms.Button()
        Me.PackageCost = New System.Windows.Forms.Label()
        Me.PackageCostBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MonthRemainingBox = New System.Windows.Forms.TextBox()
        Me.resultBox = New System.Windows.Forms.TextBox()
        Me.ShipCost = New System.Windows.Forms.Label()
        Me.ShipCostBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Magic
        '
        Me.Magic.Location = New System.Drawing.Point(155, 59)
        Me.Magic.Name = "Magic"
        Me.Magic.Size = New System.Drawing.Size(112, 26)
        Me.Magic.TabIndex = 0
        Me.Magic.Text = "Посчитать"
        Me.Magic.UseVisualStyleBackColor = True
        '
        'PackageCost
        '
        Me.PackageCost.AutoSize = True
        Me.PackageCost.Location = New System.Drawing.Point(9, 9)
        Me.PackageCost.Name = "PackageCost"
        Me.PackageCost.Size = New System.Drawing.Size(113, 13)
        Me.PackageCost.TabIndex = 1
        Me.PackageCost.Text = "Стоимость посылки"
        '
        'PackageCostBox
        '
        Me.PackageCostBox.Location = New System.Drawing.Point(12, 25)
        Me.PackageCostBox.Name = "PackageCostBox"
        Me.PackageCostBox.Size = New System.Drawing.Size(110, 22)
        Me.PackageCostBox.TabIndex = 2
        Me.PackageCostBox.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Остаток перед налогом"
        '
        'MonthRemainingBox
        '
        Me.MonthRemainingBox.Location = New System.Drawing.Point(12, 85)
        Me.MonthRemainingBox.Name = "MonthRemainingBox"
        Me.MonthRemainingBox.Size = New System.Drawing.Size(110, 22)
        Me.MonthRemainingBox.TabIndex = 4
        Me.MonthRemainingBox.Text = "0"
        '
        'resultBox
        '
        Me.resultBox.Location = New System.Drawing.Point(155, 85)
        Me.resultBox.Name = "resultBox"
        Me.resultBox.Size = New System.Drawing.Size(110, 22)
        Me.resultBox.TabIndex = 5
        '
        'ShipCost
        '
        Me.ShipCost.AutoSize = True
        Me.ShipCost.Location = New System.Drawing.Point(152, 9)
        Me.ShipCost.Name = "ShipCost"
        Me.ShipCost.Size = New System.Drawing.Size(115, 13)
        Me.ShipCost.TabIndex = 6
        Me.ShipCost.Text = "Стоимость доставки"
        '
        'ShipCostBox
        '
        Me.ShipCostBox.Location = New System.Drawing.Point(155, 25)
        Me.ShipCostBox.Name = "ShipCostBox"
        Me.ShipCostBox.Size = New System.Drawing.Size(110, 22)
        Me.ShipCostBox.TabIndex = 7
        Me.ShipCostBox.Text = "0"
        '
        'MainWindow
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(277, 116)
        Me.Controls.Add(Me.ShipCostBox)
        Me.Controls.Add(Me.ShipCost)
        Me.Controls.Add(Me.resultBox)
        Me.Controls.Add(Me.MonthRemainingBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PackageCostBox)
        Me.Controls.Add(Me.PackageCost)
        Me.Controls.Add(Me.Magic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Overpricer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Magic As Button
    Friend WithEvents PackageCost As Label
    Friend WithEvents PackageCostBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MonthRemainingBox As TextBox
    Friend WithEvents resultBox As TextBox
    Friend WithEvents ShipCost As Label
    Friend WithEvents ShipCostBox As TextBox
End Class
