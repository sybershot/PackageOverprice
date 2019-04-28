Public Class MainWindow
    Dim packPrice, packRemain, shippingCost, res As Double
    Private Sub Overpricer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Страшные костыли
    Private Sub PackagePriceBox_Click(sender As Object, e As EventArgs) Handles PackageCostBox.Click
        PackageCostBox.Clear()
    End Sub

    Private Sub ShippingCostBox_Click(sender As Object, e As EventArgs) Handles ShipCostBox.Click
        ShipCostBox.Clear()
    End Sub

    Private Sub MonthRemainingBox_Click(sender As Object, e As EventArgs) Handles MonthRemainingBox.Click
        MonthRemainingBox.Clear()
    End Sub

    'Private Sub BoxClickHandler(sender As Object, e As EventArgs) Handles PackageCostBox.Click, ShipCostBox.Click, MonthRemainingBox.Click
    '    Select Case e
    '        Case PackageCostBox
    '    End Select
    'End Sub
    Private Sub Magic_Click(sender As Object, e As EventArgs) Handles Magic.Click
        Try
            packPrice = PackageCostBox.Text
            packRemain = MonthRemainingBox.Text
            shippingCost = ShipCostBox.Text
        Catch ex As System.InvalidCastException
        End Try
        If (packPrice - packRemain) > 0 Then
            res = packPrice + ((packPrice - packRemain) * 0.3) + shippingCost + 5
        Else
            res = packPrice + shippingCost
        End If
        resultBox.Text = CDbl(res)
    End Sub
End Class
