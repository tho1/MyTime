Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop.Excel

Module excelModule

    Sub Main()
        ' Create new Application.
        Dim excel As Application = New Application

        ' Open Excel spreadsheet.
        Dim w As Workbook = excel.Workbooks.Open("C:\work\test.xlsx")

        ' Loop over all sheets.
        For i As Integer = 1 To w.Sheets.Count

            ' Get sheet.
            Dim sheet As Worksheet = w.Sheets(i)

            ' Get range.
            Dim r As Range = sheet.UsedRange

            ' Load all cells into 2d array.
            Dim array(,) As Object = r.Value(XlRangeValueDataType.xlRangeValueDefault)

            ' Scan the cells.
            If array IsNot Nothing Then
                Console.WriteLine("Length: {0}", array.Length)

                ' Get bounds of the array.
                Dim bound0 As Integer = array.GetUpperBound(0)
                Dim bound1 As Integer = array.GetUpperBound(1)

                Console.WriteLine("Dimension 0: {0}", bound0)
                Console.WriteLine("Dimension 1: {0}", bound1)

                ' Loop over all elements.
                For j As Integer = 1 To bound0
                    For x As Integer = 1 To bound1
                        Dim s1 As String = array(j, x)
                        Console.Write(s1)
                        Console.Write(" "c)
                    Next
                    Console.WriteLine()
                Next
            End If
        Next

        ' Close.
        w.Close()
    End Sub
End Module
