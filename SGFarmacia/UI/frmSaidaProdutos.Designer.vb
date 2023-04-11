<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaidaProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSaidaProdutos))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgListarCategoria = New System.Windows.Forms.DataGridView()
        Me.irps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precounitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desconto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalunitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEditar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colRemover = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalUnitario = New System.Windows.Forms.TextBox()
        Me.txtQtd = New System.Windows.Forms.TextBox()
        Me.txtPrecoUnitario = New System.Windows.Forms.TextBox()
        Me.txtProduto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtStockActual = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtUtilizador = New System.Windows.Forms.TextBox()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgListarCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(772, 33)
        Me.Panel2.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 33)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(772, 50)
        Me.Panel4.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label1.Location = New System.Drawing.Point(210, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 46)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Venda de produtos"
        '
        'dgListarCategoria
        '
        Me.dgListarCategoria.AllowUserToAddRows = False
        Me.dgListarCategoria.AllowUserToDeleteRows = False
        Me.dgListarCategoria.BackgroundColor = System.Drawing.Color.White
        Me.dgListarCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgListarCategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.irps, Me.total, Me.precounitario, Me.qtd, Me.desconto, Me.totalunitario, Me.colEditar, Me.colRemover})
        Me.dgListarCategoria.EnableHeadersVisualStyles = False
        Me.dgListarCategoria.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgListarCategoria.Location = New System.Drawing.Point(13, 271)
        Me.dgListarCategoria.Name = "dgListarCategoria"
        Me.dgListarCategoria.ReadOnly = True
        Me.dgListarCategoria.RowHeadersVisible = False
        Me.dgListarCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListarCategoria.Size = New System.Drawing.Size(754, 207)
        Me.dgListarCategoria.TabIndex = 18
        '
        'irps
        '
        Me.irps.HeaderText = "Artigo"
        Me.irps.Name = "irps"
        Me.irps.ReadOnly = True
        Me.irps.Width = 75
        '
        'total
        '
        Me.total.HeaderText = "Designação"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        Me.total.Width = 270
        '
        'precounitario
        '
        Me.precounitario.HeaderText = "Preço unitário"
        Me.precounitario.Name = "precounitario"
        Me.precounitario.ReadOnly = True
        '
        'qtd
        '
        Me.qtd.HeaderText = "Qtd"
        Me.qtd.Name = "qtd"
        Me.qtd.ReadOnly = True
        Me.qtd.Width = 45
        '
        'desconto
        '
        Me.desconto.HeaderText = "Desconto"
        Me.desconto.Name = "desconto"
        Me.desconto.ReadOnly = True
        '
        'totalunitario
        '
        Me.totalunitario.HeaderText = "Total unitário"
        Me.totalunitario.Name = "totalunitario"
        Me.totalunitario.ReadOnly = True
        '
        'colEditar
        '
        Me.colEditar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colEditar.HeaderText = ""
        Me.colEditar.Name = "colEditar"
        Me.colEditar.ReadOnly = True
        Me.colEditar.Text = "Editar"
        Me.colEditar.Width = 5
        '
        'colRemover
        '
        Me.colRemover.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colRemover.HeaderText = ""
        Me.colRemover.Name = "colRemover"
        Me.colRemover.ReadOnly = True
        Me.colRemover.Text = "Remover"
        Me.colRemover.Width = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodigoBarras)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 182)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtStockActual)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtTotalUnitario)
        Me.GroupBox2.Controls.Add(Me.txtQtd)
        Me.GroupBox2.Controls.Add(Me.txtPrecoUnitario)
        Me.GroupBox2.Controls.Add(Me.txtEndereco)
        Me.GroupBox2.Controls.Add(Me.txtContacto)
        Me.GroupBox2.Controls.Add(Me.txtUtilizador)
        Me.GroupBox2.Controls.Add(Me.txtProduto)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(455, 126)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(468, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 114)
        Me.Panel1.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(153, 10)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(125, 25)
        Me.TextBox3.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label6.Location = New System.Drawing.Point(77, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "TOTAL:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(153, 41)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 25)
        Me.TextBox2.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label5.Location = New System.Drawing.Point(29, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "DESCONTO:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(153, 72)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 25)
        Me.TextBox1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(3, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TOTAL GERAL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cod. barras:"
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.BackColor = System.Drawing.Color.Silver
        Me.txtCodigoBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoBarras.Location = New System.Drawing.Point(124, 8)
        Me.txtCodigoBarras.Multiline = True
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(233, 36)
        Me.txtCodigoBarras.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(315, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(184, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Qtd:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Preço unitário:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Produto-Stock:"
        '
        'txtTotalUnitario
        '
        Me.txtTotalUnitario.Enabled = False
        Me.txtTotalUnitario.Location = New System.Drawing.Point(366, 94)
        Me.txtTotalUnitario.Name = "txtTotalUnitario"
        Me.txtTotalUnitario.Size = New System.Drawing.Size(83, 20)
        Me.txtTotalUnitario.TabIndex = 2
        Me.txtTotalUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQtd
        '
        Me.txtQtd.Location = New System.Drawing.Point(218, 94)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(87, 20)
        Me.txtQtd.TabIndex = 3
        Me.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrecoUnitario
        '
        Me.txtPrecoUnitario.Enabled = False
        Me.txtPrecoUnitario.Location = New System.Drawing.Point(90, 94)
        Me.txtPrecoUnitario.Name = "txtPrecoUnitario"
        Me.txtPrecoUnitario.Size = New System.Drawing.Size(88, 20)
        Me.txtPrecoUnitario.TabIndex = 4
        Me.txtPrecoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtProduto
        '
        Me.txtProduto.Location = New System.Drawing.Point(90, 68)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(275, 20)
        Me.txtProduto.TabIndex = 5
        Me.txtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 481)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Utilizador:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(30, 497)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(33, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Data:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(69, 481)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Utilizador:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(69, 497)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Data:"
        '
        'txtStockActual
        '
        Me.txtStockActual.Enabled = False
        Me.txtStockActual.Location = New System.Drawing.Point(366, 68)
        Me.txtStockActual.Name = "txtStockActual"
        Me.txtStockActual.Size = New System.Drawing.Size(83, 20)
        Me.txtStockActual.TabIndex = 20
        Me.txtStockActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(475, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(270, 46)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "ADICIONAR A LISTA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SGFarmacia.My.Resources.Resources.cb
        Me.PictureBox1.Location = New System.Drawing.Point(363, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(744, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 25)
        Me.Button3.TabIndex = 6
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Enabled = False
        Me.Label14.Location = New System.Drawing.Point(31, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(42, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Cliente:"
        '
        'txtUtilizador
        '
        Me.txtUtilizador.Enabled = False
        Me.txtUtilizador.Location = New System.Drawing.Point(87, 13)
        Me.txtUtilizador.Name = "txtUtilizador"
        Me.txtUtilizador.Size = New System.Drawing.Size(362, 20)
        Me.txtUtilizador.TabIndex = 5
        Me.txtUtilizador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContacto
        '
        Me.txtContacto.Enabled = False
        Me.txtContacto.Location = New System.Drawing.Point(87, 40)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(135, 20)
        Me.txtContacto.TabIndex = 5
        Me.txtContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Enabled = False
        Me.Label15.Location = New System.Drawing.Point(31, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Contacto:"
        '
        'txtEndereco
        '
        Me.txtEndereco.Enabled = False
        Me.txtEndereco.Location = New System.Drawing.Point(280, 42)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(169, 20)
        Me.txtEndereco.TabIndex = 5
        Me.txtEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Enabled = False
        Me.Label16.Location = New System.Drawing.Point(224, 45)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 13)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Endereço:"
        '
        'frmSaidaProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 519)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgListarCategoria)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSaidaProdutos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venda de produtos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgListarCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgListarCategoria As DataGridView
    Friend WithEvents irps As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents precounitario As DataGridViewTextBoxColumn
    Friend WithEvents qtd As DataGridViewTextBoxColumn
    Friend WithEvents desconto As DataGridViewTextBoxColumn
    Friend WithEvents totalunitario As DataGridViewTextBoxColumn
    Friend WithEvents colEditar As DataGridViewButtonColumn
    Friend WithEvents colRemover As DataGridViewButtonColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigoBarras As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStockActual As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalUnitario As TextBox
    Friend WithEvents txtQtd As TextBox
    Friend WithEvents txtPrecoUnitario As TextBox
    Friend WithEvents txtProduto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents txtUtilizador As TextBox
End Class
