

Structure Car

    Dim year As String
    Dim make As String
    Dim model As String
    Dim color As String
    Dim license As String

End Structure


Public Class ParkingLot
    Dim myCar(49) As Car
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim sr As IO.StreamReader = IO.File.OpenText("..\..\CarFile.txt")
        Dim i As Integer

        Try
            Do While (sr.Peek <> -1)

                i += 1

                myCar(i).year = sr.ReadLine
                myCar(i).make = sr.ReadLine
                myCar(i).model = sr.ReadLine
                myCar(i).color = sr.ReadLine
                myCar(i).license = sr.ReadLine

                txtYear.Text = myCar(i).year
                txtMake.Text = myCar(i).make
                txtModel.Text = myCar(i).model
                txtColor.Text = myCar(i).color
                txtLic.Text = myCar(i).license

            Loop

        Catch ex As InvalidCastException
            MessageBox.Show("Invalid Data")
        Catch ex As Exception
            MessageBox.Show("Error occurred")
        End Try

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

    End Sub

    Private Sub btnForward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForward.Click

    End Sub

    Private Sub btnGo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click

        Dim intGo As Integer = CInt(txtGoTo.Text)


    End Sub
End Class
