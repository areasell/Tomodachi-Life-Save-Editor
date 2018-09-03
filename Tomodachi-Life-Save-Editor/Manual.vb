﻿Public Class Manual
    Private Sub Closebutton_Click(sender As Object, e As EventArgs) Handles Closebutton.Click
        Me.Close()
        TL_SaveEditor.Show()
    End Sub

    Public Sub hidepanels()
        Panel_extractsave.Visible = False
        Panel_restoresave.Visible = False
    End Sub

    Public Sub hidemenu()
        Text_extractsave.BorderStyle = BorderStyle.None
        Text_restoresave.BorderStyle = BorderStyle.None
    End Sub

    Private Sub Closebutton_MouseMove(sender As Object, e As EventArgs) Handles Closebutton.MouseMove
        Closebutton.Image = My.Resources.close_red
    End Sub

    Private Sub Closebutton_MouseLeave(sender As Object, e As EventArgs) Handles Closebutton.MouseLeave
        Closebutton.Image = My.Resources.close
    End Sub

    Private Sub Panel_extractsave_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_extractsave.MouseMove
        Info_image.Location = New Point(e.X + 200, e.Y + 15)
    End Sub

    Private Sub Info_extractsave_1_MouseMove(sender As Object, e As EventArgs) Handles Info_extractsave_1.MouseMove
        Info_image.Image = My.Resources.JKSM_launch
        Info_image.Visible = True
    End Sub

    Private Sub Info_extractsave_1_MouseLeave(sender As Object, e As EventArgs) Handles Info_extractsave_1.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_extractsave_2_MouseMove(sender As Object, e As EventArgs) Handles Info_extractsave_2.MouseMove
        Info_image.Image = My.Resources.JKSM_titles
        Info_image.Visible = True
    End Sub

    Private Sub Info_extractsave_2_MouseLeave(sender As Object, e As EventArgs) Handles Info_extractsave_2.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_extractsave_3_MouseMove(sender As Object, e As EventArgs) Handles Info_extractsave_3.MouseMove
        Info_image.Image = My.Resources.JKSM_tomodachi
        Info_image.Visible = True
    End Sub

    Private Sub Info_extractsave_3_MouseLeave(sender As Object, e As EventArgs) Handles Info_extractsave_3.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_extractsave_4_MouseMove(sender As Object, e As EventArgs) Handles Info_extractsave_4.MouseMove
        Info_image.Image = My.Resources.JKSM_savedata
        Info_image.Visible = True
    End Sub

    Private Sub Info_extractsave_4_MouseLeave(sender As Object, e As EventArgs) Handles Info_extractsave_4.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_extractsave_5_MouseMove(sender As Object, e As EventArgs) Handles Info_extractsave_5.MouseMove
        Info_image.Image = My.Resources.JKSM_newfolder
        Info_image.Visible = True
    End Sub

    Private Sub Info_extractsave_5_MouseLeave(sender As Object, e As EventArgs) Handles Info_extractsave_5.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_extractsave_6_MouseMove(sender As Object, e As EventArgs) Handles Info_extractsave_6.MouseMove
        Info_image.Image = My.Resources.JKSM_backup
        Info_image.Visible = True
    End Sub

    Private Sub Info_extractsave_6_MouseLeave(sender As Object, e As EventArgs) Handles Info_extractsave_6.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Text_HtuTLSEold_Click(sender As Object, e As EventArgs) Handles Text_HtuTLSEold.Click
        Process.Start("https://www.youtube.com/watch?v=EIpuxMg9SVE")
    End Sub

    Private Sub Panel_restoresave_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_restoresave.MouseMove
        Info_image.Location = New Point(e.X + 200, e.Y + 15)
    End Sub

    Private Sub Info_restoresave_1_MouseMove(sender As Object, e As EventArgs) Handles Info_restoresave_1.MouseMove
        Info_image.Image = My.Resources.JKSM_launch
        Info_image.Visible = True
    End Sub

    Private Sub Info_restoresave_1_MouseLeave(sender As Object, e As EventArgs) Handles Info_restoresave_1.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_restoresave_2_MouseMove(sender As Object, e As EventArgs) Handles Info_restoresave_2.MouseMove
        Info_image.Image = My.Resources.JKSM_titles
        Info_image.Visible = True
    End Sub

    Private Sub Info_restoresave_2_MouseLeave(sender As Object, e As EventArgs) Handles Info_restoresave_2.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_restoresave_3_MouseMove(sender As Object, e As EventArgs) Handles Info_restoresave_3.MouseMove
        Info_image.Image = My.Resources.JKSM_tomodachi
        Info_image.Visible = True
    End Sub

    Private Sub Info_restoresave_3_MouseLeave(sender As Object, e As EventArgs) Handles Info_restoresave_3.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_restoresave_4_MouseMove(sender As Object, e As EventArgs) Handles Info_restoresave_4.MouseMove
        Info_image.Image = My.Resources.JKSM_savedata
        Info_image.Visible = True
    End Sub

    Private Sub Info_restoresave_4_MouseLeave(sender As Object, e As EventArgs) Handles Info_restoresave_4.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Info_restoresave_5_MouseMove(sender As Object, e As EventArgs) Handles Info_restoresave_5.MouseMove
        Info_image.Image = My.Resources.JKSM_backup
        Info_image.Visible = True
    End Sub

    Private Sub Info_restoresave_5_MouseLeave(sender As Object, e As EventArgs) Handles Info_restoresave_5.MouseLeave
        Info_image.Visible = False
    End Sub

    Private Sub Text_extractsave_Click(sender As Object, e As EventArgs) Handles Text_extractsave.Click
        hidepanels()
        Panel_extractsave.Visible = True
        hidemenu()
        Text_extractsave.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub Text_restoresave_Click(sender As Object, e As EventArgs) Handles Text_restoresave.Click
        hidepanels()
        Panel_restoresave.Visible = True
        hidemenu()
        Text_restoresave.BorderStyle = BorderStyle.FixedSingle
    End Sub
End Class