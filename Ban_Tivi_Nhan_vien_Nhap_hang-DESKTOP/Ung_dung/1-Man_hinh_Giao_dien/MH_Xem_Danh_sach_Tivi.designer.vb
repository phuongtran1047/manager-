﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MH_Xem_Danh_sach_Tivi
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Th_Danh_sach_Tivi = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Th_Danh_sach_Tivi
        '
        Me.Th_Danh_sach_Tivi.AutoScroll = True
        Me.Th_Danh_sach_Tivi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Th_Danh_sach_Tivi.Location = New System.Drawing.Point(0, 0)
        Me.Th_Danh_sach_Tivi.Name = "Th_Danh_sach_Tivi"
        Me.Th_Danh_sach_Tivi.Size = New System.Drawing.Size(612, 347)
        Me.Th_Danh_sach_Tivi.TabIndex = 0
        '
        'MH_Xem_Danh_sach_Tivi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.Controls.Add(Me.Th_Danh_sach_Tivi)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "MH_Xem_Danh_sach_Tivi"
        Me.Size = New System.Drawing.Size(612, 347)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Th_Danh_sach_Tivi As FlowLayoutPanel
End Class
