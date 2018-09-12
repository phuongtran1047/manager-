<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MH_Chinh
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Cua_so_Tieu_de = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Th_PET = New System.Windows.Forms.Button()
        Me.Th_Tieu_de = New System.Windows.Forms.Label()
        Me.Cua_so_Chuc_nang = New System.Windows.Forms.Panel()
        Me.Th_Loi_chao = New System.Windows.Forms.Label()
        Me.Th_Hinh_Nguoi_dung = New System.Windows.Forms.Button()
        Me.Th_Chuoi_Tra_cuu = New System.Windows.Forms.TextBox()
        Me.Cua_so_Ket_qua = New System.Windows.Forms.Panel()
        Me.Cua_so_Tieu_de.SuspendLayout()
        Me.Cua_so_Chuc_nang.SuspendLayout()
        Me.SuspendLayout()
        '
        'Cua_so_Tieu_de
        '
        Me.Cua_so_Tieu_de.Controls.Add(Me.Label1)
        Me.Cua_so_Tieu_de.Controls.Add(Me.Th_PET)
        Me.Cua_so_Tieu_de.Controls.Add(Me.Th_Tieu_de)
        Me.Cua_so_Tieu_de.Dock = System.Windows.Forms.DockStyle.Top
        Me.Cua_so_Tieu_de.Location = New System.Drawing.Point(0, 0)
        Me.Cua_so_Tieu_de.Margin = New System.Windows.Forms.Padding(5)
        Me.Cua_so_Tieu_de.Name = "Cua_so_Tieu_de"
        Me.Cua_so_Tieu_de.Size = New System.Drawing.Size(780, 60)
        Me.Cua_so_Tieu_de.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(75, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Mô hình - Công nghệ - Kỹ thuật"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Th_PET
        '
        Me.Th_PET.Location = New System.Drawing.Point(9, 6)
        Me.Th_PET.Name = "Th_PET"
        Me.Th_PET.Size = New System.Drawing.Size(60, 48)
        Me.Th_PET.TabIndex = 10
        Me.Th_PET.UseVisualStyleBackColor = True
        '
        'Th_Tieu_de
        '
        Me.Th_Tieu_de.AutoSize = True
        Me.Th_Tieu_de.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Tieu_de.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Th_Tieu_de.Location = New System.Drawing.Point(417, 18)
        Me.Th_Tieu_de.Name = "Th_Tieu_de"
        Me.Th_Tieu_de.Size = New System.Drawing.Size(84, 25)
        Me.Th_Tieu_de.TabIndex = 9
        Me.Th_Tieu_de.Text = "Tiêu đề"
        Me.Th_Tieu_de.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cua_so_Chuc_nang
        '
        Me.Cua_so_Chuc_nang.BackColor = System.Drawing.Color.DarkGray
        Me.Cua_so_Chuc_nang.Controls.Add(Me.Th_Loi_chao)
        Me.Cua_so_Chuc_nang.Controls.Add(Me.Th_Hinh_Nguoi_dung)
        Me.Cua_so_Chuc_nang.Controls.Add(Me.Th_Chuoi_Tra_cuu)
        Me.Cua_so_Chuc_nang.Dock = System.Windows.Forms.DockStyle.Top
        Me.Cua_so_Chuc_nang.Location = New System.Drawing.Point(0, 60)
        Me.Cua_so_Chuc_nang.Margin = New System.Windows.Forms.Padding(15)
        Me.Cua_so_Chuc_nang.Name = "Cua_so_Chuc_nang"
        Me.Cua_so_Chuc_nang.Size = New System.Drawing.Size(780, 71)
        Me.Cua_so_Chuc_nang.TabIndex = 1
        '
        'Th_Loi_chao
        '
        Me.Th_Loi_chao.AutoSize = True
        Me.Th_Loi_chao.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th_Loi_chao.ForeColor = System.Drawing.Color.White
        Me.Th_Loi_chao.Location = New System.Drawing.Point(76, 18)
        Me.Th_Loi_chao.Name = "Th_Loi_chao"
        Me.Th_Loi_chao.Size = New System.Drawing.Size(94, 25)
        Me.Th_Loi_chao.TabIndex = 10
        Me.Th_Loi_chao.Text = "Lời chào"
        Me.Th_Loi_chao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Th_Hinh_Nguoi_dung
        '
        Me.Th_Hinh_Nguoi_dung.Location = New System.Drawing.Point(10, 6)
        Me.Th_Hinh_Nguoi_dung.Name = "Th_Hinh_Nguoi_dung"
        Me.Th_Hinh_Nguoi_dung.Size = New System.Drawing.Size(60, 48)
        Me.Th_Hinh_Nguoi_dung.TabIndex = 9
        Me.Th_Hinh_Nguoi_dung.UseVisualStyleBackColor = True
        '
        'Th_Chuoi_Tra_cuu
        '
        Me.Th_Chuoi_Tra_cuu.BackColor = System.Drawing.Color.White
        Me.Th_Chuoi_Tra_cuu.ForeColor = System.Drawing.Color.Gray
        Me.Th_Chuoi_Tra_cuu.Location = New System.Drawing.Point(434, 18)
        Me.Th_Chuoi_Tra_cuu.Name = "Th_Chuoi_Tra_cuu"
        Me.Th_Chuoi_Tra_cuu.Size = New System.Drawing.Size(264, 29)
        Me.Th_Chuoi_Tra_cuu.TabIndex = 8
        '
        'Cua_so_Ket_qua
        '
        Me.Cua_so_Ket_qua.AutoScroll = True
        Me.Cua_so_Ket_qua.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Cua_so_Ket_qua.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cua_so_Ket_qua.Location = New System.Drawing.Point(0, 131)
        Me.Cua_so_Ket_qua.Margin = New System.Windows.Forms.Padding(15)
        Me.Cua_so_Ket_qua.Name = "Cua_so_Ket_qua"
        Me.Cua_so_Ket_qua.Size = New System.Drawing.Size(780, 260)
        Me.Cua_so_Ket_qua.TabIndex = 2
        '
        'MH_Chinh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 391)
        Me.Controls.Add(Me.Cua_so_Ket_qua)
        Me.Controls.Add(Me.Cua_so_Chuc_nang)
        Me.Controls.Add(Me.Cua_so_Tieu_de)
        Me.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MH_Chinh"
        Me.Text = "MH_Chinh"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Cua_so_Tieu_de.ResumeLayout(False)
        Me.Cua_so_Tieu_de.PerformLayout()
        Me.Cua_so_Chuc_nang.ResumeLayout(False)
        Me.Cua_so_Chuc_nang.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Cua_so_Tieu_de As Panel
    Friend WithEvents Cua_so_Chuc_nang As Panel
    Friend WithEvents Cua_so_Ket_qua As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Th_PET As Button
    Friend WithEvents Th_Tieu_de As Label
    Friend WithEvents Th_Loi_chao As Label
    Friend WithEvents Th_Hinh_Nguoi_dung As Button
    Friend WithEvents Th_Chuoi_Tra_cuu As TextBox
End Class
