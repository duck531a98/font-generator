Imports System.Text

Public Class Form1
    Public chars(1) As Byte
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FontDialog1.ShowDialog()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim start_unicode As Integer
        Dim end_unicode As Integer
        Dim start_high, start_low, end_high, end_low As Integer
        Dim c_width As Integer = CInt(char_width.Value)
        Dim c_height As Integer = CInt(char_height.Value)
        Dim pic As New Bitmap(c_width, c_height) 'bitmap in picture box
        PictureBox1.Image = pic
        Dim g As Graphics = Graphics.FromImage(pic) 'gdi object of bitmap
        Dim stream As New System.IO.FileStream("font", IO.FileMode.Create) ' font file
        Dim byte_in_height As Integer = c_height / 8 'how many bytes in height
        Dim remainder_in_height As Integer = c_height Mod 8
        Dim pixels_in_height_need As Integer

        If c_height Mod 8 = 0 Then
            pixels_in_height_need = c_height - 1
        Else
            pixels_in_height_need = c_height - 1 + 8 - (c_height Mod 8)
        End If
        start_low = 0
        start_high = 255
        end_low = 0
        end_high = 255
        If CheckBox1.Checked = True Then
            start_unicode = Int32.Parse(startbox.Text, Globalization.NumberStyles.HexNumber)
            end_unicode = Int32.Parse(endbox.Text, Globalization.NumberStyles.HexNumber)
            start_low = start_unicode And 255
            start_high = (start_unicode >> 8) And 255
            end_low = end_unicode And 255
            end_high = (end_unicode >> 8) And 255
        Else
            start_unicode = 0
            end_unicode = 65535

        End If
        For i = start_unicode To end_unicode 'high

            chars(0) = i And 255
            chars(1) = (i >> 8) And 255
            g.Clear(Color.Transparent)
            g.DrawString(Encoding.Unicode.GetString(chars), FontDialog1.Font, Brushes.Black, New Point(offset_x.Value, offset_y.Value))
            PictureBox1.Refresh()
            For px = 0 To c_width - 1
                Dim temp As Byte
                Dim p_color As Color
                temp = 0
                For py = 0 To pixels_in_height_need    'c_height - 1 
                    If py < c_height Then
                        p_color = pic.GetPixel(px, py)
                    End If

                    If ((py + 1) Mod 8 <> 0) Then
                        temp = temp Or CInt(p_color.A / 255)
                        temp = temp << 1
                    Else
                        temp = temp Or CInt(p_color.A / 255)
                        stream.WriteByte(temp)
                        temp = 0
                    End If
                Next
            Next
            ProgressBar1.Value = i * 100 / (end_unicode - start_unicode)
            Application.DoEvents()

        Next
        stream.Close()
    End Sub
    Private Sub char_width_ValueChanged(sender As Object, e As EventArgs) Handles char_width.ValueChanged, high8.ValueChanged
        PictureBox1.Width = char_width.Value
        If Me.Created = True Then
            updatebitmap()
        End If
    End Sub
    Private Sub char_height_ValueChanged(sender As Object, e As EventArgs) Handles char_height.ValueChanged, low8.ValueChanged
        PictureBox1.Height = char_height.Value
        If Me.Created = True Then
            updatebitmap()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chars(0) = &H2D
        chars(1) = &H9E
        updatebitmap()
    End Sub

    Private Sub FontDialog1_Apply(sender As Object, e As EventArgs) Handles FontDialog1.Apply
       
        updatebitmap()
    End Sub

    

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        chars(0) = CInt(low8.Value)
        chars(1) = CInt(high8.Value)
        updatebitmap()
    End Sub
    Private Sub updatebitmap()
        Dim c_width As Integer = CInt(char_width.Value)
        Dim c_height As Integer = CInt(char_height.Value)
        Dim pic As New Bitmap(c_width, c_height) 'bitmap in picture box 6674
        PictureBox1.Image = pic
        Dim g As Graphics = Graphics.FromImage(pic) 'gdi object of bitmap
        g.Clear(Color.Transparent)
        g.DrawString(Encoding.Unicode.GetString(chars), FontDialog1.Font, Brushes.Black, New Point(offset_x.Value, offset_y.Value))
        PictureBox1.Image = pic
        PictureBox1.Refresh()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Image.Save("pic.jpg")
    End Sub

    Private Sub offset_y_ValueChanged(sender As Object, e As EventArgs) Handles offset_y.ValueChanged
        updatebitmap()
    End Sub

    Private Sub offset_x_ValueChanged(sender As Object, e As EventArgs) Handles offset_x.ValueChanged
        updatebitmap()
    End Sub
End Class
