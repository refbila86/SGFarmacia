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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNrVD = New System.Windows.Forms.TextBox()
        Me.dgVendaItens = New System.Windows.Forms.DataGridView()
        Me.artigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.produto_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precounitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desconto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalunitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEditar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colRemover = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.chkIncluirCliente = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblEndereco = New System.Windows.Forms.Label()
        Me.lblContacto = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalUnitario = New System.Windows.Forms.TextBox()
        Me.txtDesconto = New System.Windows.Forms.TextBox()
        Me.txtQtd = New System.Windows.Forms.TextBox()
        Me.txtPrecoUnitario = New System.Windows.Forms.TextBox()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.txtNuit = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.txtProduto = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotalDesconto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalGeral = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.txtStockActual = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblNrVenda = New System.Windows.Forms.Label()
        Me.txtNrVenda = New System.Windows.Forms.TextBox()
        Me.btnRegistar = New System.Windows.Forms.Button()
        Me.btnNovaVenda = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.mskData = New System.Windows.Forms.MaskedTextBox()
        Me.btnCancelarVenda = New System.Windows.Forms.Button()
        Me.txtCodigoNotaCredito = New System.Windows.Forms.TextBox()
        Me.lblNotaCredito = New System.Windows.Forms.Label()
        Me.btnGravaNota = New System.Windows.Forms.Button()
        Me.dgPesquisar = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.designacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.origem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precovenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precodecompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtdcaixa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSelecionar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnPesquisar = New System.Windows.Forms.Panel()
        Me.Panel4.SuspendLayout()
        CType(Me.dgVendaItens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnPesquisar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Teal
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.txtNrVD)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(772, 59)
        Me.Panel4.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label1.Location = New System.Drawing.Point(210, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 46)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Venda de produtos"
        '
        'txtNrVD
        '
        Me.txtNrVD.BackColor = System.Drawing.Color.Black
        Me.txtNrVD.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNrVD.ForeColor = System.Drawing.Color.White
        Me.txtNrVD.Location = New System.Drawing.Point(590, 8)
        Me.txtNrVD.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNrVD.Multiline = True
        Me.txtNrVD.Name = "txtNrVD"
        Me.txtNrVD.ReadOnly = True
        Me.txtNrVD.Size = New System.Drawing.Size(140, 31)
        Me.txtNrVD.TabIndex = 3
        Me.txtNrVD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNrVD.Visible = False
        '
        'dgVendaItens
        '
        Me.dgVendaItens.AllowUserToAddRows = False
        Me.dgVendaItens.AllowUserToDeleteRows = False
        Me.dgVendaItens.BackgroundColor = System.Drawing.Color.White
        Me.dgVendaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgVendaItens.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.artigo, Me.produto_id, Me.produto, Me.precounitario, Me.qtd, Me.desconto, Me.totalunitario, Me.colEditar, Me.colRemover})
        Me.dgVendaItens.EnableHeadersVisualStyles = False
        Me.dgVendaItens.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgVendaItens.Location = New System.Drawing.Point(9, 305)
        Me.dgVendaItens.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgVendaItens.Name = "dgVendaItens"
        Me.dgVendaItens.ReadOnly = True
        Me.dgVendaItens.RowHeadersVisible = False
        Me.dgVendaItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVendaItens.Size = New System.Drawing.Size(754, 208)
        Me.dgVendaItens.TabIndex = 18
        '
        'artigo
        '
        Me.artigo.HeaderText = "Artigo"
        Me.artigo.Name = "artigo"
        Me.artigo.ReadOnly = True
        Me.artigo.Width = 75
        '
        'produto_id
        '
        Me.produto_id.HeaderText = "produto_id"
        Me.produto_id.Name = "produto_id"
        Me.produto_id.ReadOnly = True
        Me.produto_id.Visible = False
        '
        'produto
        '
        Me.produto.HeaderText = "Designação"
        Me.produto.Name = "produto"
        Me.produto.ReadOnly = True
        Me.produto.Width = 240
        '
        'precounitario
        '
        Me.precounitario.HeaderText = "Preço unitário"
        Me.precounitario.Name = "precounitario"
        Me.precounitario.ReadOnly = True
        Me.precounitario.Width = 80
        '
        'qtd
        '
        Me.qtd.HeaderText = "Qtd"
        Me.qtd.Name = "qtd"
        Me.qtd.ReadOnly = True
        Me.qtd.Width = 80
        '
        'desconto
        '
        Me.desconto.HeaderText = "Desconto"
        Me.desconto.Name = "desconto"
        Me.desconto.ReadOnly = True
        Me.desconto.Width = 80
        '
        'totalunitario
        '
        Me.totalunitario.HeaderText = "Total unitário"
        Me.totalunitario.Name = "totalunitario"
        Me.totalunitario.ReadOnly = True
        Me.totalunitario.Width = 80
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
        Me.GroupBox1.Controls.Add(Me.btnAdicionar)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodigoBarras)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 117)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(753, 180)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionar.Location = New System.Drawing.Point(468, 130)
        Me.btnAdicionar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(285, 40)
        Me.btnAdicionar.TabIndex = 5
        Me.btnAdicionar.Text = "ADICIONAR A LISTA"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.chkIncluirCliente)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblEndereco)
        Me.GroupBox2.Controls.Add(Me.lblContacto)
        Me.GroupBox2.Controls.Add(Me.lblCliente)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtTotalUnitario)
        Me.GroupBox2.Controls.Add(Me.txtDesconto)
        Me.GroupBox2.Controls.Add(Me.txtQtd)
        Me.GroupBox2.Controls.Add(Me.txtPrecoUnitario)
        Me.GroupBox2.Controls.Add(Me.txtContacto)
        Me.GroupBox2.Controls.Add(Me.txtNuit)
        Me.GroupBox2.Controls.Add(Me.txtCliente)
        Me.GroupBox2.Controls.Add(Me.txtProduto)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 48)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(455, 122)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(393, 70)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(58, 20)
        Me.TextBox1.TabIndex = 30
        '
        'chkIncluirCliente
        '
        Me.chkIncluirCliente.AutoSize = True
        Me.chkIncluirCliente.ForeColor = System.Drawing.Color.Red
        Me.chkIncluirCliente.Location = New System.Drawing.Point(356, 17)
        Me.chkIncluirCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chkIncluirCliente.Name = "chkIncluirCliente"
        Me.chkIncluirCliente.Size = New System.Drawing.Size(96, 20)
        Me.chkIncluirCliente.TabIndex = 21
        Me.chkIncluirCliente.Text = "Incluir cliente"
        Me.chkIncluirCliente.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(357, 98)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Total:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(261, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 16)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Desc.:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(163, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Qtd:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(2, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Preço unitário:"
        '
        'lblEndereco
        '
        Me.lblEndereco.AutoSize = True
        Me.lblEndereco.Enabled = False
        Me.lblEndereco.ForeColor = System.Drawing.Color.Blue
        Me.lblEndereco.Location = New System.Drawing.Point(224, 48)
        Me.lblEndereco.Name = "lblEndereco"
        Me.lblEndereco.Size = New System.Drawing.Size(55, 16)
        Me.lblEndereco.TabIndex = 9
        Me.lblEndereco.Text = "Contacto"
        '
        'lblContacto
        '
        Me.lblContacto.AutoSize = True
        Me.lblContacto.Enabled = False
        Me.lblContacto.ForeColor = System.Drawing.Color.Blue
        Me.lblContacto.Location = New System.Drawing.Point(45, 48)
        Me.lblContacto.Name = "lblContacto"
        Me.lblContacto.Size = New System.Drawing.Size(33, 16)
        Me.lblContacto.TabIndex = 9
        Me.lblContacto.Text = "Nuit:"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Enabled = False
        Me.lblCliente.ForeColor = System.Drawing.Color.Blue
        Me.lblCliente.Location = New System.Drawing.Point(32, 18)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(47, 16)
        Me.lblCliente.TabIndex = 9
        Me.lblCliente.Text = "Cliente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(-1, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Produto-Stock:"
        '
        'txtTotalUnitario
        '
        Me.txtTotalUnitario.Location = New System.Drawing.Point(394, 95)
        Me.txtTotalUnitario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalUnitario.Name = "txtTotalUnitario"
        Me.txtTotalUnitario.ReadOnly = True
        Me.txtTotalUnitario.Size = New System.Drawing.Size(57, 20)
        Me.txtTotalUnitario.TabIndex = 2
        Me.txtTotalUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesconto
        '
        Me.txtDesconto.Location = New System.Drawing.Point(301, 95)
        Me.txtDesconto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDesconto.Name = "txtDesconto"
        Me.txtDesconto.ReadOnly = True
        Me.txtDesconto.Size = New System.Drawing.Size(56, 20)
        Me.txtDesconto.TabIndex = 3
        Me.txtDesconto.Text = "0.0 Mtn"
        Me.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQtd
        '
        Me.txtQtd.Location = New System.Drawing.Point(195, 95)
        Me.txtQtd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtQtd.Name = "txtQtd"
        Me.txtQtd.Size = New System.Drawing.Size(57, 20)
        Me.txtQtd.TabIndex = 4
        Me.txtQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrecoUnitario
        '
        Me.txtPrecoUnitario.Location = New System.Drawing.Point(85, 95)
        Me.txtPrecoUnitario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPrecoUnitario.Name = "txtPrecoUnitario"
        Me.txtPrecoUnitario.ReadOnly = True
        Me.txtPrecoUnitario.Size = New System.Drawing.Size(77, 20)
        Me.txtPrecoUnitario.TabIndex = 4
        Me.txtPrecoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtContacto
        '
        Me.txtContacto.Enabled = False
        Me.txtContacto.Location = New System.Drawing.Point(280, 43)
        Me.txtContacto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtContacto.MaxLength = 9
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(169, 20)
        Me.txtContacto.TabIndex = 2
        Me.txtContacto.Text = "N/A"
        Me.txtContacto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNuit
        '
        Me.txtNuit.Enabled = False
        Me.txtNuit.Location = New System.Drawing.Point(85, 43)
        Me.txtNuit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNuit.MaxLength = 9
        Me.txtNuit.Name = "txtNuit"
        Me.txtNuit.Size = New System.Drawing.Size(122, 20)
        Me.txtNuit.TabIndex = 1
        Me.txtNuit.Text = "N/A"
        Me.txtNuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(84, 16)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCliente.MaxLength = 50
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(269, 20)
        Me.txtCliente.TabIndex = 0
        Me.txtCliente.Text = "N/A"
        Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProduto
        '
        Me.txtProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduto.ForeColor = System.Drawing.Color.Navy
        Me.txtProduto.Location = New System.Drawing.Point(85, 69)
        Me.txtProduto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtProduto.Name = "txtProduto"
        Me.txtProduto.Size = New System.Drawing.Size(307, 21)
        Me.txtProduto.TabIndex = 3
        Me.txtProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtTotalDesconto)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtTotalGeral)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(468, 10)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 112)
        Me.Panel1.TabIndex = 3
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(153, 7)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(125, 30)
        Me.txtTotal.TabIndex = 7
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label6.Location = New System.Drawing.Point(77, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "TOTAL:"
        '
        'txtTotalDesconto
        '
        Me.txtTotalDesconto.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDesconto.Location = New System.Drawing.Point(153, 39)
        Me.txtTotalDesconto.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalDesconto.Multiline = True
        Me.txtTotalDesconto.Name = "txtTotalDesconto"
        Me.txtTotalDesconto.ReadOnly = True
        Me.txtTotalDesconto.Size = New System.Drawing.Size(125, 30)
        Me.txtTotalDesconto.TabIndex = 7
        Me.txtTotalDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label5.Location = New System.Drawing.Point(29, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "DESCONTO:"
        '
        'txtTotalGeral
        '
        Me.txtTotalGeral.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalGeral.Location = New System.Drawing.Point(153, 71)
        Me.txtTotalGeral.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalGeral.Multiline = True
        Me.txtTotalGeral.Name = "txtTotalGeral"
        Me.txtTotalGeral.ReadOnly = True
        Me.txtTotalGeral.Size = New System.Drawing.Size(125, 30)
        Me.txtTotalGeral.TabIndex = 7
        Me.txtTotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label4.Location = New System.Drawing.Point(3, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TOTAL GERAL:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SGFarmacia.My.Resources.Resources.cb
        Me.PictureBox1.Location = New System.Drawing.Point(384, 10)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cod. barras:"
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.BackColor = System.Drawing.Color.Silver
        Me.txtCodigoBarras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoBarras.Location = New System.Drawing.Point(137, 10)
        Me.txtCodigoBarras.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigoBarras.Multiline = True
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(244, 34)
        Me.txtCodigoBarras.TabIndex = 0
        '
        'txtStockActual
        '
        Me.txtStockActual.Enabled = False
        Me.txtStockActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockActual.ForeColor = System.Drawing.Color.Navy
        Me.txtStockActual.Location = New System.Drawing.Point(143, 527)
        Me.txtStockActual.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStockActual.Name = "txtStockActual"
        Me.txtStockActual.Size = New System.Drawing.Size(57, 21)
        Me.txtStockActual.TabIndex = 20
        Me.txtStockActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtStockActual.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(610, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Utilizador:"
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(610, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Data:"
        Me.Label11.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(669, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Utilizador:"
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(669, 574)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 16)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Data:"
        Me.Label13.Visible = False
        '
        'lblNrVenda
        '
        Me.lblNrVenda.AutoSize = True
        Me.lblNrVenda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNrVenda.Location = New System.Drawing.Point(19, 88)
        Me.lblNrVenda.Name = "lblNrVenda"
        Me.lblNrVenda.Size = New System.Drawing.Size(120, 24)
        Me.lblNrVenda.TabIndex = 1
        Me.lblNrVenda.Text = "Nº de venda:"
        '
        'txtNrVenda
        '
        Me.txtNrVenda.BackColor = System.Drawing.Color.Black
        Me.txtNrVenda.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNrVenda.ForeColor = System.Drawing.Color.White
        Me.txtNrVenda.Location = New System.Drawing.Point(150, 85)
        Me.txtNrVenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNrVenda.Multiline = True
        Me.txtNrVenda.Name = "txtNrVenda"
        Me.txtNrVenda.ReadOnly = True
        Me.txtNrVenda.Size = New System.Drawing.Size(140, 31)
        Me.txtNrVenda.TabIndex = 3
        Me.txtNrVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnRegistar
        '
        Me.btnRegistar.BackColor = System.Drawing.Color.Teal
        Me.btnRegistar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistar.FlatAppearance.BorderSize = 0
        Me.btnRegistar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnRegistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistar.ForeColor = System.Drawing.Color.White
        Me.btnRegistar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistar.Location = New System.Drawing.Point(283, 521)
        Me.btnRegistar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRegistar.Name = "btnRegistar"
        Me.btnRegistar.Size = New System.Drawing.Size(171, 36)
        Me.btnRegistar.TabIndex = 28
        Me.btnRegistar.Text = "REGISTAR VENDA"
        Me.btnRegistar.UseVisualStyleBackColor = False
        '
        'btnNovaVenda
        '
        Me.btnNovaVenda.BackColor = System.Drawing.Color.Navy
        Me.btnNovaVenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovaVenda.FlatAppearance.BorderSize = 0
        Me.btnNovaVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnNovaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovaVenda.ForeColor = System.Drawing.Color.White
        Me.btnNovaVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovaVenda.Location = New System.Drawing.Point(9, 527)
        Me.btnNovaVenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnNovaVenda.Name = "btnNovaVenda"
        Me.btnNovaVenda.Size = New System.Drawing.Size(171, 36)
        Me.btnNovaVenda.TabIndex = 28
        Me.btnNovaVenda.Text = "IMPRIMIR"
        Me.btnNovaVenda.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(652, 59)
        Me.txtID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtID.MaxLength = 9
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(122, 20)
        Me.txtID.TabIndex = 5
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtID.Visible = False
        '
        'mskData
        '
        Me.mskData.Enabled = False
        Me.mskData.Location = New System.Drawing.Point(555, 582)
        Me.mskData.Mask = "####-##-##"
        Me.mskData.Name = "mskData"
        Me.mskData.Size = New System.Drawing.Size(115, 20)
        Me.mskData.TabIndex = 30
        Me.mskData.Visible = False
        '
        'btnCancelarVenda
        '
        Me.btnCancelarVenda.BackColor = System.Drawing.Color.Red
        Me.btnCancelarVenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelarVenda.FlatAppearance.BorderSize = 0
        Me.btnCancelarVenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnCancelarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarVenda.ForeColor = System.Drawing.Color.White
        Me.btnCancelarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelarVenda.Location = New System.Drawing.Point(283, 521)
        Me.btnCancelarVenda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCancelarVenda.Name = "btnCancelarVenda"
        Me.btnCancelarVenda.Size = New System.Drawing.Size(171, 36)
        Me.btnCancelarVenda.TabIndex = 28
        Me.btnCancelarVenda.Text = "CANCELAR VENDA"
        Me.btnCancelarVenda.UseVisualStyleBackColor = False
        '
        'txtCodigoNotaCredito
        '
        Me.txtCodigoNotaCredito.BackColor = System.Drawing.Color.Black
        Me.txtCodigoNotaCredito.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoNotaCredito.ForeColor = System.Drawing.Color.White
        Me.txtCodigoNotaCredito.Location = New System.Drawing.Point(633, 90)
        Me.txtCodigoNotaCredito.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCodigoNotaCredito.Multiline = True
        Me.txtCodigoNotaCredito.Name = "txtCodigoNotaCredito"
        Me.txtCodigoNotaCredito.ReadOnly = True
        Me.txtCodigoNotaCredito.Size = New System.Drawing.Size(132, 31)
        Me.txtCodigoNotaCredito.TabIndex = 3
        Me.txtCodigoNotaCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtCodigoNotaCredito.Visible = False
        '
        'lblNotaCredito
        '
        Me.lblNotaCredito.AutoSize = True
        Me.lblNotaCredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotaCredito.Location = New System.Drawing.Point(484, 92)
        Me.lblNotaCredito.Name = "lblNotaCredito"
        Me.lblNotaCredito.Size = New System.Drawing.Size(143, 24)
        Me.lblNotaCredito.TabIndex = 1
        Me.lblNotaCredito.Text = "Nota de credito:"
        Me.lblNotaCredito.Visible = False
        '
        'btnGravaNota
        '
        Me.btnGravaNota.Location = New System.Drawing.Point(581, 518)
        Me.btnGravaNota.Name = "btnGravaNota"
        Me.btnGravaNota.Size = New System.Drawing.Size(162, 38)
        Me.btnGravaNota.TabIndex = 31
        Me.btnGravaNota.Text = "Gravar Nota"
        Me.btnGravaNota.UseVisualStyleBackColor = True
        Me.btnGravaNota.Visible = False
        '
        'dgPesquisar
        '
        Me.dgPesquisar.AllowUserToAddRows = False
        Me.dgPesquisar.AllowUserToDeleteRows = False
        Me.dgPesquisar.BackgroundColor = System.Drawing.Color.White
        Me.dgPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgPesquisar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.designacao, Me.origem, Me.precovenda, Me.precodecompra, Me.qtdcaixa, Me.colSelecionar})
        Me.dgPesquisar.EnableHeadersVisualStyles = False
        Me.dgPesquisar.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgPesquisar.Location = New System.Drawing.Point(4, 9)
        Me.dgPesquisar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgPesquisar.Name = "dgPesquisar"
        Me.dgPesquisar.ReadOnly = True
        Me.dgPesquisar.RowHeadersVisible = False
        Me.dgPesquisar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPesquisar.Size = New System.Drawing.Size(600, 194)
        Me.dgPesquisar.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 45
        '
        'designacao
        '
        Me.designacao.HeaderText = "Designação do produto"
        Me.designacao.Name = "designacao"
        Me.designacao.ReadOnly = True
        Me.designacao.Width = 130
        '
        'origem
        '
        Me.origem.HeaderText = "Pais origem"
        Me.origem.Name = "origem"
        Me.origem.ReadOnly = True
        '
        'precovenda
        '
        Me.precovenda.HeaderText = "Preço venda"
        Me.precovenda.Name = "precovenda"
        Me.precovenda.ReadOnly = True
        Me.precovenda.Width = 85
        '
        'precodecompra
        '
        Me.precodecompra.HeaderText = "Preço compra"
        Me.precodecompra.Name = "precodecompra"
        Me.precodecompra.ReadOnly = True
        Me.precodecompra.Width = 85
        '
        'qtdcaixa
        '
        Me.qtdcaixa.HeaderText = "Qtd caixa"
        Me.qtdcaixa.Name = "qtdcaixa"
        Me.qtdcaixa.ReadOnly = True
        Me.qtdcaixa.Width = 65
        '
        'colSelecionar
        '
        Me.colSelecionar.HeaderText = ""
        Me.colSelecionar.Name = "colSelecionar"
        Me.colSelecionar.ReadOnly = True
        Me.colSelecionar.Width = 85
        '
        'pnPesquisar
        '
        Me.pnPesquisar.Controls.Add(Me.dgPesquisar)
        Me.pnPesquisar.Location = New System.Drawing.Point(56, 257)
        Me.pnPesquisar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnPesquisar.Name = "pnPesquisar"
        Me.pnPesquisar.Size = New System.Drawing.Size(614, 209)
        Me.pnPesquisar.TabIndex = 29
        Me.pnPesquisar.Visible = False
        '
        'frmSaidaProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 568)
        Me.Controls.Add(Me.btnGravaNota)
        Me.Controls.Add(Me.mskData)
        Me.Controls.Add(Me.txtStockActual)
        Me.Controls.Add(Me.pnPesquisar)
        Me.Controls.Add(Me.btnNovaVenda)
        Me.Controls.Add(Me.btnCancelarVenda)
        Me.Controls.Add(Me.btnRegistar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgVendaItens)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblNotaCredito)
        Me.Controls.Add(Me.lblNrVenda)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.txtCodigoNotaCredito)
        Me.Controls.Add(Me.txtNrVenda)
        Me.Controls.Add(Me.txtID)
        Me.Font = New System.Drawing.Font("Trebuchet MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "frmSaidaProdutos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venda de produtos"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgVendaItens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgPesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnPesquisar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgVendaItens As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigoBarras As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotalDesconto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotalGeral As TextBox
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
    Friend WithEvents btnAdicionar As Button
    Friend WithEvents lblEndereco As Label
    Friend WithEvents lblContacto As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents txtNuit As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lblNrVenda As Label
    Friend WithEvents txtNrVenda As TextBox
    Friend WithEvents chkIncluirCliente As CheckBox
    Friend WithEvents btnRegistar As Button
    Friend WithEvents btnNovaVenda As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents txtDesconto As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents artigo As DataGridViewTextBoxColumn
    Friend WithEvents produto_id As DataGridViewTextBoxColumn
    Friend WithEvents produto As DataGridViewTextBoxColumn
    Friend WithEvents precounitario As DataGridViewTextBoxColumn
    Friend WithEvents qtd As DataGridViewTextBoxColumn
    Friend WithEvents desconto As DataGridViewTextBoxColumn
    Friend WithEvents totalunitario As DataGridViewTextBoxColumn
    Friend WithEvents colEditar As DataGridViewButtonColumn
    Friend WithEvents colRemover As DataGridViewButtonColumn
    Friend WithEvents txtNrVD As TextBox
    Friend WithEvents mskData As MaskedTextBox
    Friend WithEvents btnCancelarVenda As Button
    Friend WithEvents txtCodigoNotaCredito As TextBox
    Friend WithEvents lblNotaCredito As Label
    Friend WithEvents btnGravaNota As Button
    Friend WithEvents dgPesquisar As DataGridView
    Friend WithEvents pnPesquisar As Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents designacao As DataGridViewTextBoxColumn
    Friend WithEvents origem As DataGridViewTextBoxColumn
    Friend WithEvents precovenda As DataGridViewTextBoxColumn
    Friend WithEvents precodecompra As DataGridViewTextBoxColumn
    Friend WithEvents qtdcaixa As DataGridViewTextBoxColumn
    Friend WithEvents colSelecionar As DataGridViewButtonColumn
End Class
