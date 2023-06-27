Sub CalculateStockMetrics()

    ' Define workbook
    Dim wb As Workbook
    Set wb = ThisWorkbook

    ' Loop through each sheet in the workbook
    Dim ws As Worksheet
    For Each ws In wb.Sheets

        ' Define variables
        Dim currentTicker As String
        Dim startPrice As Double
        Dim endPrice As Double
        Dim totalVolume As Double
        Dim yearlyChange As Double
        Dim percentChange As Double
        Dim i As Long
        Dim outputRow As Long

        Dim greatestIncrease As Double
        Dim greatestDecrease As Double
        Dim greatestVolume As Double
        Dim tickerGreatestIncrease As String
        Dim tickerGreatestDecrease As String
        Dim tickerGreatestVolume As String

        ' Initialize variables
        currentTicker = ws.Range("A2").Value
        startPrice = ws.Range("C2").Value
        totalVolume = 0
        outputRow = 2 ' Start output at row 2

        greatestIncrease = 0
        greatestDecrease = 0
        greatestVolume = 0

        ' Title the cells in the first row
        ws.Cells(1, "I").Value = "Ticker"
        ws.Cells(1, "J").Value = "Yearly Change"
        ws.Cells(1, "K").Value = "Percent Change"
        ws.Cells(1, "L").Value = "Total Stock Volume"

        ' Title the cells for Greatest values
        ws.Cells(2, "N").Value = "Greatest % Increase"
        ws.Cells(3, "N").Value = "Greatest % Decrease"
        ws.Cells(4, "N").Value = "Greatest Total Volume"
        ws.Cells(1, "O").Value = "Ticker"
        ws.Cells(1, "P").Value = "Value"

        ' Loop through rows
        For i = 2 To ws.Cells(ws.Rows.Count, "A").End(xlUp).Row

            ' Check if we're still on the same ticker
            If ws.Cells(i, "A").Value = currentTicker Then

                ' Update end price and total volume
                endPrice = ws.Cells(i, "F").Value
                totalVolume = totalVolume + ws.Cells(i, "G").Value

            Else ' We've reached a new ticker

                ' Calculate yearly change and percentage change for the previous ticker
                yearlyChange = endPrice - startPrice
                If startPrice <> 0 Then
                    percentChange = yearlyChange / startPrice
                Else
                    percentChange = 0
                End If

                ' Check for greatest values
                If percentChange > greatestIncrease Then
                    greatestIncrease = percentChange
                    tickerGreatestIncrease = currentTicker
                ElseIf percentChange < greatestDecrease Then
                    greatestDecrease = percentChange
                    tickerGreatestDecrease = currentTicker
                End If

                If totalVolume > greatestVolume Then
                    greatestVolume = totalVolume
                    tickerGreatestVolume = currentTicker
                End If

                ' Write ticker and calculations to the output row
                ws.Cells(outputRow, "I").Value = currentTicker
                ws.Cells(outputRow, "J").Value = yearlyChange
                ws.Cells(outputRow, "K").Value = percentChange
                ws.Cells(outputRow, "L").Value = totalVolume

                ' Conditional formatting for yearly change column
                With ws.Cells(outputRow, "J")
                    .FormatConditions.Delete
                    .FormatConditions.Add Type:=xlCellValue, Operator:=xlGreaterEqual, Formula1:="0"
                    .FormatConditions(1).Interior.Color = RGB(0, 255, 0)
                    .FormatConditions.Add Type:=xlCellValue, Operator:=xlLess, Formula1:="0"
                    .FormatConditions(2).Interior.Color = RGB(255, 0, 0)
                End With

                ' Auto-format the Percentage column, and the greatest increase and decrease into % formatting
                ws.Cells(outputRow, "K").NumberFormat = "0.00%"
                ws.Cells(2, "P").NumberFormat = "0.00%"
                ws.Cells(3, "P").NumberFormat = "0.00%"

                ' Move to the next output row
                outputRow = outputRow + 1

                ' Start tracking the new ticker
                currentTicker = ws.Cells(i, "A").Value
                startPrice = ws.Cells(i, "C").Value
                totalVolume = ws.Cells(i, "G").Value

            End If

        Next i

        ' Write the greatest values to cells
        ws.Cells(2, "O").Value = tickerGreatestIncrease
        ws.Cells(3, "O").Value = tickerGreatestDecrease
        ws.Cells(4, "O").Value = tickerGreatestVolume
        ws.Cells(2, "P").Value = greatestIncrease
        ws.Cells(3, "P").Value = greatestDecrease
        ws.Cells(4, "P").Value = greatestVolume

    Next ws

End Sub

