<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaixaDiario
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
        Me.dgListaVendas = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnRegistar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskData = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.nrvenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valortotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDetalhes = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colRemover = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtTotalGeral = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgListaVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgListaVendas
        '
        Me.dgListaVendas.AllowUserToAddRows = False
        Me.dgListaVendas.AllowUserToDeleteRows = False
        Me.dgListaVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgListaVendas.BackgroundColor = System.Drawing.Color.White
        Me.dgListaVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgListaVendas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nrvenda, Me.total, Me.nuit, Me.contacto, Me.valortotal, Me.colDetalhes, Me.colRemover})
        Me.dgListaVendas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgListaVendas.EnableHeadersVisualStyles = False
        Me.dgListaVendas.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgListaVendas.Location = New System.Drawing.Point(0, 0)
        Me.dgListaVendas.Name = "dgListaVendas"
        Me.dgListaVendas.ReadOnly = True
        Me.dgListaVendas.RowHeadersVisible = False
        Me.dgListaVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListaVendas.Size = New System.Drawing.Size(846, 418)
        Me.dgListaVendas.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel2.Controls.Add(Me.dgListaVendas)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(846, 418)
        Me.Panel2.TabIndex = 24
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 472)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(846, 32)
        Me.Panel3.TabIndex = 26
        '
        'btnRegistar
        '
        Me.btnRegistar.BackColor = System.Drawing.Color.ForestGreen
        Me.btnRegistar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistar.FlatAppearance.BorderSize = 0
        Me.btnRegistar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnRegistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistar.ForeColor = System.Drawing.Color.White
        Me.btnRegistar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistar.Location = New System.Drawing.Point(8, 17)
        Me.btnRegistar.Name = "btnRegistar"
        Me.btnRegistar.Size = New System.Drawing.Size(76, 29)
        Me.btnRegistar.TabIndex = 10
        Me.btnRegistar.Text = "Novo"
        Me.btnRegistar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(166, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Pesquisar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(6, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Data:"
        '
        'mskData
        '
        Me.mskData.Location = New System.Drawing.Point(45, 20)
        Me.mskData.Mask = "####-##-##"
        Me.mskData.Name = "mskData"
        Me.mskData.Size = New System.Drawing.Size(115, 20)
        Me.mskData.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.mskData)
        Me.GroupBox1.Location = New System.Drawing.Point(89, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 46)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar vendas do dia"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.txtTotalGeral)
        Me.Panel4.Controls.Add(Me.btnRegistar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(846, 54)
        Me.Panel4.TabIndex = 25
        '
        'nrvenda
        '
        Me.nrvenda.FillWeight = 106.8817!
        Me.nrvenda.HeaderText = "Nº Venda"
        Me.nrvenda.Name = "nrvenda"
        Me.nrvenda.ReadOnly = True
        '
        'total
        '
        Me.total.FillWeight = 106.8817!
        Me.total.HeaderText = "Cliente"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'nuit
        '
        Me.nuit.FillWeight = 106.8817!
        Me.nuit.HeaderText = "Nuit"
        Me.nuit.Name = "nuit"
        Me.nuit.ReadOnly = True
        '
        'contacto
        '
        Me.contacto.FillWeight = 106.8817!
        Me.contacto.HeaderText = "Contacto"
        Me.contacto.Name = "contacto"
        Me.contacto.ReadOnly = True
        '
        'valortotal
        '
        Me.valortotal.FillWeight = 106.8817!
        Me.valortotal.HeaderText = "Valor da VD"
        Me.valortotal.Name = "valortotal"
        Me.valortotal.ReadOnly = True
        '
        'colDetalhes
        '
        Me.colDetalhes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colDetalhes.HeaderText = ""
        Me.colDetalhes.Name = "colDetalhes"
        Me.colDetalhes.ReadOnly = True
        Me.colDetalhes.Text = ""
        Me.colDetalhes.Width = 5
        '
        'colRemover
        '
        Me.colRemover.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colRemover.HeaderText = ""
        Me.colRemover.Name = "colRemover"
        Me.colRemover.ReadOnly = True
        Me.colRemover.Text = "Remover"
        Me.colRemover.Visible = False
        Me.colRemover.Width = 5
        '
        'txtTotalGeral
        '
        Me.txtTotalGeral.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalGeral.Location = New System.Drawing.Point(618, 24)
        Me.txtTotalGeral.Name = "txtTotalGeral"
        Me.txtTotalGeral.ReadOnly = True
        Me.txtTotalGeral.Size = New System.Drawing.Size(162, 22)
        Me.txtTotalGeral.TabIndex = 0
        Me.txtTotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(623, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Valor total do dia:"
        '
        'frmCaixaDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 504)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmCaixaDiario"
        Me.Text = "frmCaixaDiario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgListaVendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgListaVendas As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnRegistar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents mskData As MaskedTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents nrvenda As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents nuit As DataGridViewTextBoxColumn
    Friend WithEvents contacto As DataGridViewTextBoxColumn
    Friend WithEvents valortotal As DataGridViewTextBoxColumn
    Friend WithEvents colDetalhes As DataGridViewButtonColumn
    Friend WithEvents colRemover As DataGridViewButtonColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalGeral As TextBox
End Class
