﻿Public Class Form9
    Dim filepath As String
    Dim fdialog As New Form3
    Dim Pagh1 As String
    Dim Pagh2 As String
    Dim Pagh3 As String
    Dim Pagh4 As String
    Dim Pagh5 As String
    Dim Pagh6 As String
    Dim Pagh7 As String
    Dim Pagh8 As String
    Dim Pagh9 As String
    Dim Pagh10 As String
    Dim Pagh11 As String
    Dim Pagh12 As String
    Dim Pagh13 As String
    Dim Tmusc As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filepath = Form1.Label39.Text
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value = 14 Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        If NumericUpDown2.Value = 14 Then
            TextBox2.Enabled = True
        Else
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown3_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown3.ValueChanged
        If NumericUpDown3.Value = 14 Then
            TextBox4.Enabled = True
        Else
            TextBox4.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown6_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown6.ValueChanged
        If NumericUpDown6.Value = 14 Then
            TextBox3.Enabled = True
        Else
            TextBox3.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown5_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown5.ValueChanged
        If NumericUpDown5.Value = 14 Then
            TextBox8.Enabled = True
        Else
            TextBox8.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged
        If NumericUpDown4.Value = 14 Then
            TextBox7.Enabled = True
        Else
            TextBox7.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown9_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown9.ValueChanged
        If NumericUpDown9.Value = 14 Then
            TextBox6.Enabled = True
        Else
            TextBox6.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown8_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown8.ValueChanged
        If NumericUpDown8.Value = 14 Then
            TextBox5.Enabled = True
        Else
            TextBox5.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown7_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown7.ValueChanged
        If NumericUpDown7.Value = 14 Then
            TextBox12.Enabled = True
        Else
            TextBox12.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown12_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown12.ValueChanged
        If NumericUpDown12.Value = 14 Then
            TextBox11.Enabled = True
        Else
            TextBox11.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown11_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown11.ValueChanged
        If NumericUpDown11.Value = 14 Then
            TextBox10.Enabled = True
        Else
            TextBox10.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown10_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown10.ValueChanged
        If NumericUpDown10.Value = 14 Then
            TextBox9.Enabled = True
        Else
            TextBox9.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown13_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown13.ValueChanged
        If NumericUpDown13.Value = 14 Then
            TextBox13.Enabled = True
        Else
            TextBox13.Enabled = False
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim Reader As New PackageIO.Reader(filepath, PackageIO.Endian.Little)
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                Reader.Position = &H17B6E4
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                Reader.Position = &H17B6E4 + &H5C4
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + &H5C4
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + &H5C4 + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + &H5C4 + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + &H5C4 + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + &H5C4 + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + &H5C4 + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + &H5C4 + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + &H5C4 + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + &H5C4 + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + &H5C4 + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + &H5C4 + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + &H5C4 + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + &H5C4 + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + &H5C4 + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + &H5C4 + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + &H5C4 + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + &H5C4 + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + &H5C4 + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + &H5C4 + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + &H5C4 + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + &H5C4 + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + &H5C4 + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + &H5C4 + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + &H5C4 + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + &H5C4 + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + &H5C4
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(2) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 2)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 2)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 2) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 2) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 2) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 2) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 2) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 2) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 2) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 2) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 2) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 2) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 2) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 2) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 2) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 2) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 2) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 2) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 2) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 2) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 2) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 2) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 2) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 2) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 2) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 2) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 2)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(3) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 3)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 3)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 3) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 3) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 3) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 3) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 3) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 3) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 3) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 3) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 3) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 3) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 3) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 3) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 3) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 3) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 3) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 3) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 3) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 3) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 3) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 3) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 3) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 3) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 3) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 3) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 3)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(4) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 4)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 4)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 4) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 4) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 4) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 4) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 4) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 4) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 4) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 4) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 4) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 4) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 4) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 4) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 4) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 4) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 4) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 4) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 4) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 4) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 4) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 4) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 4) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 4) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 4) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 4) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 4)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(5) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 5)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 5)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 5) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 5) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 5) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 5) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 5) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 5) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 5) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 5) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 5) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 5) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 5) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 5) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 5) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 5) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 5) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 5) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 5) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 5) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 5) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 5) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 5) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 5) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 5) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 5) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 5)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(6) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 6)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 6)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 6) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 6) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 6) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 6) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 6) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 6) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 6) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 6) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 6) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 6) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 6) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 6) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 6) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 6) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 6) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 6) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 6) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 6) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 6) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 6) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 6) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 6) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 6) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 6) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 6)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(7) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 7)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 7)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 7) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 7) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 7) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 7) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 7) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 7) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 7) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 7) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 7) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 7) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 7) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 7) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 7) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 7) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 7) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 7) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 7) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 7) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 7) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 7) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 7) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 7) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 7) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 7) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 7)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(8) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 8)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 8)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 8) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 8) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 8) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 8) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 8) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 8) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 8) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 8) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 8) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 8) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 8) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 8) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 8) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 8) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 8) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 8) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 8) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 8) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 8) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 8) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 8) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 8) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 8) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 8) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 8)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(9) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 9)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 9)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 9) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 9) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 9) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 9) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 9) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 9) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 9) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 9) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 9) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 9) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 9) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 9) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 9) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 9) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 9) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 9) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 9) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 9) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 9) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 9) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 9) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 9) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 9) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 9) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 9)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(10) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 10)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 10)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 10) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 10) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 10) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 10) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 10) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 10) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 10) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 10) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 10) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 10) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 10) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 10) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 10) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 10) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 10) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 10) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 10) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 10) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 10) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 10) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 10) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 10) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 10) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 10) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 10)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(11) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 11)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 11)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 11) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 11) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 11) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 11) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 11) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 11) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 11) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 11) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 11) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 11) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 11) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 11) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 11) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 11) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 11) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 11) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 11) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 11) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 11) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 11) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 11) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 11) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 11) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 11) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 11)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(12) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 12)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 12)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 12) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 12) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 12) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 12) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 12) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 12) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 12) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 12) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 12) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 12) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 12) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 12) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 12) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 12) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 12) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 12) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 12) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 12) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 12) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 12) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 12) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 12) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 12) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 12) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 12)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(13) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 13)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 13)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 13) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 13) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 13) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 13) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 13) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 13) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 13) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 13) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 13) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 13) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 13) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 13) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 13) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 13) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 13) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 13) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 13) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 13) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 13) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 13) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 13) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 13) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 13) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 13) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 13)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(14) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 14)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 14)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 14) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 14) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 14) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 14) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 14) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 14) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 14) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 14) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 14) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 14) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 14) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 14) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 14) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 14) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 14) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 14) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 14) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 14) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 14) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 14) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 14) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 14) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 14) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 14) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 14)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(15) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 15)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 15)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 15) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 15) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 15) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 15) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 15) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 15) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 15) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 15) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 15) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 15) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 15) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 15) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 15) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 15) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 15) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 15) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 15) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 15) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 15) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 15) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 15) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 15) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 15) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 15) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 15)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(16) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 16)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 16)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 16) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 16) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 16) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 16) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 16) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 16) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 16) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 16) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 16) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 16) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 16) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 16) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 16) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 16) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 16) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 16) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 16) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 16) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 16) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 16) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 16) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 16) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 16) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 16) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 16)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(17) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 17)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 17)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 17) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 17) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 17) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 17) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 17) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 17) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 17) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 17) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 17) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 17) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 17) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 17) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 17) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 17) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 17) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 17) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 17) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 17) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 17) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 17) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 17) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 17) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 17) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 17) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 17)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(18) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 18)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 18)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 18) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 18) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 18) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 18) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 18) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 18) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 18) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 18) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 18) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 18) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 18) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 18) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 18) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 18) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 18) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 18) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 18) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 18) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 18) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 18) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 18) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 18) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 18) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 18) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 18)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(19) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 19)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 19)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 19) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 19) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 19) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 19) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 19) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 19) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 19) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 19) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 19) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 19) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 19) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 19) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 19) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 19) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 19) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 19) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 19) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 19) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 19) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 19) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 19) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 19) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 19) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 19) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 19)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(20) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 20)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 20)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 20) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 20) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 20) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 20) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 20) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 20) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 20) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 20) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 20) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 20) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 20) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 20) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 20) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 20) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 20) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 20) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 20) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 20) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 20) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 20) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 20) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 20) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 20) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 20) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 20)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(21) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 21)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 21)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 21) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 21) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 21) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 21) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 21) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 21) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 21) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 21) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 21) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 21) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 21) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 21) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 21) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 21) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 21) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 21) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 21) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 21) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 21) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 21) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 21) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 21) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 21) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 21) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 21)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(22) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 22)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 22)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 22) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 22) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 22) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 22) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 22) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 22) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 22) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 22) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 22) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 22) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 22) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 22) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 22) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 22) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 22) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 22) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 22) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 22) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 22) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 22) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 22) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 22) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 22) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 22) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 22)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(23) Then
                Reader.Position = &H17B6E4 + (&H5C4 * 23)
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 23)
                Pagh1 = Reader.Position
                TextBox1.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 23) + &H68
                NumericUpDown2.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 23) + &H68
                Pagh2 = Reader.Position
                TextBox2.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 23) + (&H68 * 2)
                NumericUpDown3.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 23) + (&H68 * 2)
                Pagh3 = Reader.Position
                TextBox4.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 23) + (&H68 * 3)
                NumericUpDown6.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 23) + (&H68 * 3)
                Pagh4 = Reader.Position
                TextBox3.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 23) + (&H68 * 4)
                NumericUpDown5.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 23) + (&H68 * 4)
                Pagh5 = Reader.Position
                TextBox8.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 23) + (&H68 * 5)
                NumericUpDown4.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 23) + (&H68 * 5)
                Pagh6 = Reader.Position
                TextBox7.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 23) + (&H68 * 6)
                NumericUpDown9.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 23) + (&H68 * 6)
                Pagh7 = Reader.Position
                TextBox6.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 23) + (&H68 * 7)
                NumericUpDown8.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 23) + (&H68 * 7)
                Pagh8 = Reader.Position
                TextBox5.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 23) + (&H68 * 8)
                NumericUpDown7.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 23) + (&H68 * 8)
                Pagh9 = Reader.Position
                TextBox12.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 23) + (&H68 * 9)
                NumericUpDown12.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 23) + (&H68 * 9)
                Pagh10 = Reader.Position
                TextBox11.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 23) + (&H68 * 10)
                NumericUpDown11.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 23) + (&H68 * 10)
                Pagh11 = Reader.Position
                TextBox10.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 23) + (&H68 * 11)
                NumericUpDown10.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 23) + (&H68 * 11)
                Pagh12 = Reader.Position
                TextBox9.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17B6E4 + (&H5C4 * 23) + (&H68 * 12)
                NumericUpDown13.Value = Reader.ReadInt8
                Reader.Position = &H17B6EA + (&H5C4 * 23) + (&H68 * 12)
                Pagh13 = Reader.Position
                TextBox13.Text = Reader.ReadUnicodeString(48)
                Reader.Position = &H17BC2C + (&H5C4 * 23)
                Tmusc = Reader.Position
                TextBox14.Text = Reader.ReadUnicodeString(32)
            End If

        Catch ex As Exception
            If Form1.ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "Une erreur est survenue, ouvrez une sauvegarde avant"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "An error has occured, load a save first"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "DE" Then
                fdialog.Label1.Text = "ein Fehler ist aufgetreten, lade vorher einen Speicherstand"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "PT" Then
                fdialog.Label1.Text = "Um erro ocorreu, carregue um arquivo primeiro"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "ES" Then
                fdialog.Label1.Text = "Ha ocurrido un error, Abre una partida antes"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            If NumericUpDown1.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh1 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh1
                Writer.WriteUnicodeString(TextBox1.Text)
            End If
            If NumericUpDown2.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh2 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh2
                Writer.WriteUnicodeString(TextBox2.Text)
            End If
            If NumericUpDown3.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh3 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh3
                Writer.WriteUnicodeString(TextBox4.Text)
            End If
            If NumericUpDown4.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh6 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh6
                Writer.WriteUnicodeString(TextBox7.Text)
            End If
            If NumericUpDown5.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh5 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh5
                Writer.WriteUnicodeString(TextBox8.Text)
            End If
            If NumericUpDown6.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh4 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh4
                Writer.WriteUnicodeString(TextBox3.Text)
            End If
            If NumericUpDown7.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh9 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh9
                Writer.WriteUnicodeString(TextBox12.Text)
            End If
            If NumericUpDown8.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh8 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh8
                Writer.WriteUnicodeString(TextBox5.Text)
            End If
            If NumericUpDown9.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh7 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh7
                Writer.WriteUnicodeString(TextBox6.Text)
            End If
            If NumericUpDown10.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh12 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh12
                Writer.WriteUnicodeString(TextBox9.Text)
            End If
            If NumericUpDown11.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh11 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh11
                Writer.WriteUnicodeString(TextBox10.Text)
            End If
            If NumericUpDown12.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh10 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh10
                Writer.WriteUnicodeString(TextBox11.Text)
            End If
            If NumericUpDown13.Value = 14 Then
                For i As Integer = 0 To 95
                    Writer.Position = Pagh13 + i
                    Writer.WriteInt8(0)
                Next
                Writer.Position = Pagh13
                Writer.WriteUnicodeString(TextBox13.Text)
            End If
            For i As Integer = 0 To 63
                Writer.Position = Tmusc + i
                Writer.WriteInt8(0)
            Next
            Writer.Position = Tmusc
            Writer.WriteUnicodeString(TextBox14.Text)

            If Form1.ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "Sauvegarde enregistré"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "File Saved"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "DE" Then
                fdialog.Label1.Text = "Datei speichern"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "PT" Then
                fdialog.Label1.Text = "Arquivo Salvo"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "ES" Then
                fdialog.Label1.Text = "Archivo guardado"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If Form1.ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "Une erreur est survenue, ouvrez une sauvegarde avant"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "An error has occured, load a save first"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "DE" Then
                fdialog.Label1.Text = "ein Fehler ist aufgetreten, lade vorher einen Speicherstand"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "PT" Then
                fdialog.Label1.Text = "Um erro ocorreu, carregue um arquivo primeiro"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "ES" Then
                fdialog.Label1.Text = "Ha ocurrido un error, Abre una partida antes"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub
End Class