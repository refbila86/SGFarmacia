<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntradaProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntradaProdutos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgEntradaProdutos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.designacaoproduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoentrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtdintroduzir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtdcx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precocompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precovendas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEditar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colRemover = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNrEntrada = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pnPesquisar = New System.Windows.Forms.Panel()
        Me.dgPesquisar = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.designacao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paisorigem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precovenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precodecompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtdcaixa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSelecionar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.mskData = New System.Windows.Forms.MaskedTextBox()
        Me.btnRegistar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtStockActual = New System.Windows.Forms.TextBox()
        Me.btnAdicionaar = New System.Windows.Forms.Button()
        Me.cboTipoEntrada = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalIntroduzir = New System.Windows.Forms.TextBox()
        Me.txtQtdIntroduzir = New System.Windows.Forms.TextBox()
        Me.txtPrecoVenda = New System.Windows.Forms.TextBox()
        Me.txtPrecoCompra = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtQtdCaixa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPaisOrigem = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDesignacao = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dpData = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotalGasto = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTotalEsperado = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dpValidade = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgEntradaProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.pnPesquisar.SuspendLayout()
        CType(Me.dgPesquisar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(654, 33)
        Me.Panel1.TabIndex = 2
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
        Me.Button3.Location = New System.Drawing.Point(628, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 25)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(654, 33)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label1.Location = New System.Drawing.Point(125, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 46)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Entrada de produtos"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 33)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(654, 50)
        Me.Panel4.TabIndex = 7
        '
        'dgEntradaProdutos
        '
        Me.dgEntradaProdutos.AllowUserToAddRows = False
        Me.dgEntradaProdutos.AllowUserToDeleteRows = False
        Me.dgEntradaProdutos.BackgroundColor = System.Drawing.Color.White
        Me.dgEntradaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgEntradaProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.designacaoproduto, Me.tipoentrada, Me.qtdintroduzir, Me.Column1, Me.qtdcx, Me.precocompra, Me.precovendas, Me.colEditar, Me.colRemover})
        Me.dgEntradaProdutos.EnableHeadersVisualStyles = False
        Me.dgEntradaProdutos.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgEntradaProdutos.Location = New System.Drawing.Point(50, 474)
        Me.dgEntradaProdutos.Name = "dgEntradaProdutos"
        Me.dgEntradaProdutos.ReadOnly = True
        Me.dgEntradaProdutos.RowHeadersVisible = False
        Me.dgEntradaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEntradaProdutos.Size = New System.Drawing.Size(780, 263)
        Me.dgEntradaProdutos.TabIndex = 18
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 20
        '
        'designacaoproduto
        '
        Me.designacaoproduto.HeaderText = "Designação do produto"
        Me.designacaoproduto.Name = "designacaoproduto"
        Me.designacaoproduto.ReadOnly = True
        Me.designacaoproduto.Width = 130
        '
        'tipoentrada
        '
        Me.tipoentrada.HeaderText = "Tipo de entrada"
        Me.tipoentrada.Name = "tipoentrada"
        Me.tipoentrada.ReadOnly = True
        '
        'qtdintroduzir
        '
        Me.qtdintroduzir.HeaderText = "Qtd Introduzir"
        Me.qtdintroduzir.Name = "qtdintroduzir"
        Me.qtdintroduzir.ReadOnly = True
        Me.qtdintroduzir.Width = 80
        '
        'Column1
        '
        Me.Column1.HeaderText = "Total a introduzir"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'qtdcx
        '
        Me.qtdcx.HeaderText = "Qtd por caixa"
        Me.qtdcx.Name = "qtdcx"
        Me.qtdcx.ReadOnly = True
        Me.qtdcx.Width = 80
        '
        'precocompra
        '
        Me.precocompra.HeaderText = "Preço compra"
        Me.precocompra.Name = "precocompra"
        Me.precocompra.ReadOnly = True
        Me.precocompra.Width = 80
        '
        'precovendas
        '
        Me.precovendas.HeaderText = "Preco Venda"
        Me.precovendas.Name = "precovendas"
        Me.precovendas.ReadOnly = True
        Me.precovendas.Width = 80
        '
        'colEditar
        '
        Me.colEditar.HeaderText = ""
        Me.colEditar.Name = "colEditar"
        Me.colEditar.ReadOnly = True
        Me.colEditar.Width = 50
        '
        'colRemover
        '
        Me.colRemover.HeaderText = ""
        Me.colRemover.Name = "colRemover"
        Me.colRemover.ReadOnly = True
        Me.colRemover.Width = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(42, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Nº de Entrada:"
        '
        'txtNrEntrada
        '
        Me.txtNrEntrada.Location = New System.Drawing.Point(133, 90)
        Me.txtNrEntrada.Name = "txtNrEntrada"
        Me.txtNrEntrada.ReadOnly = True
        Me.txtNrEntrada.Size = New System.Drawing.Size(98, 20)
        Me.txtNrEntrada.TabIndex = 20
        Me.txtNrEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pnPesquisar)
        Me.GroupBox1.Controls.Add(Me.mskData)
        Me.GroupBox1.Controls.Add(Me.btnRegistar)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtStockActual)
        Me.GroupBox1.Controls.Add(Me.btnAdicionaar)
        Me.GroupBox1.Controls.Add(Me.cboTipoEntrada)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTotalIntroduzir)
        Me.GroupBox1.Controls.Add(Me.txtQtdIntroduzir)
        Me.GroupBox1.Controls.Add(Me.txtPrecoVenda)
        Me.GroupBox1.Controls.Add(Me.txtPrecoCompra)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtQtdCaixa)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtPaisOrigem)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtDesignacao)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(646, 280)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'pnPesquisar
        '
        Me.pnPesquisar.Controls.Add(Me.dgPesquisar)
        Me.pnPesquisar.Location = New System.Drawing.Point(69, 31)
        Me.pnPesquisar.Name = "pnPesquisar"
        Me.pnPesquisar.Size = New System.Drawing.Size(566, 226)
        Me.pnPesquisar.TabIndex = 28
        Me.pnPesquisar.Visible = False
        '
        'dgPesquisar
        '
        Me.dgPesquisar.AllowUserToAddRows = False
        Me.dgPesquisar.AllowUserToDeleteRows = False
        Me.dgPesquisar.BackgroundColor = System.Drawing.Color.White
        Me.dgPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgPesquisar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.designacao, Me.paisorigem, Me.precovenda, Me.precodecompra, Me.qtdcaixa, Me.colSelecionar})
        Me.dgPesquisar.EnableHeadersVisualStyles = False
        Me.dgPesquisar.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgPesquisar.Location = New System.Drawing.Point(5, 5)
        Me.dgPesquisar.Name = "dgPesquisar"
        Me.dgPesquisar.ReadOnly = True
        Me.dgPesquisar.RowHeadersVisible = False
        Me.dgPesquisar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgPesquisar.Size = New System.Drawing.Size(557, 216)
        Me.dgPesquisar.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 45
        '
        'designacao
        '
        Me.designacao.HeaderText = "Designação do produto"
        Me.designacao.Name = "designacao"
        Me.designacao.ReadOnly = True
        Me.designacao.Width = 130
        '
        'paisorigem
        '
        Me.paisorigem.HeaderText = "Pais origem"
        Me.paisorigem.Name = "paisorigem"
        Me.paisorigem.ReadOnly = True
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
        'mskData
        '
        Me.mskData.Location = New System.Drawing.Point(12, 260)
        Me.mskData.Mask = "####-##-##"
        Me.mskData.Name = "mskData"
        Me.mskData.Size = New System.Drawing.Size(196, 20)
        Me.mskData.TabIndex = 27
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
        Me.btnRegistar.Location = New System.Drawing.Point(237, 250)
        Me.btnRegistar.Name = "btnRegistar"
        Me.btnRegistar.Size = New System.Drawing.Size(261, 29)
        Me.btnRegistar.TabIndex = 27
        Me.btnRegistar.Text = "Registar entrada"
        Me.btnRegistar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(457, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(172, 185)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "IMAGEM"
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(104, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 28)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "LIMPAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.Location = New System.Drawing.Point(24, 247)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(74, 28)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "BROWSE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.SGFarmacia.My.Resources.Resources.medico
        Me.PictureBox1.Location = New System.Drawing.Point(8, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 156)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtStockActual
        '
        Me.txtStockActual.Enabled = False
        Me.txtStockActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockActual.Location = New System.Drawing.Point(356, 134)
        Me.txtStockActual.Multiline = True
        Me.txtStockActual.Name = "txtStockActual"
        Me.txtStockActual.Size = New System.Drawing.Size(95, 36)
        Me.txtStockActual.TabIndex = 10
        Me.txtStockActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAdicionaar
        '
        Me.btnAdicionaar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdicionaar.Location = New System.Drawing.Point(540, 231)
        Me.btnAdicionaar.Name = "btnAdicionaar"
        Me.btnAdicionaar.Size = New System.Drawing.Size(95, 49)
        Me.btnAdicionaar.TabIndex = 9
        Me.btnAdicionaar.Text = "Adicionar"
        Me.btnAdicionaar.UseVisualStyleBackColor = True
        Me.btnAdicionaar.Visible = False
        '
        'cboTipoEntrada
        '
        Me.cboTipoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoEntrada.FormattingEnabled = True
        Me.cboTipoEntrada.Items.AddRange(New Object() {"Retalho", "Grosso"})
        Me.cboTipoEntrada.Location = New System.Drawing.Point(133, 40)
        Me.cboTipoEntrada.Name = "cboTipoEntrada"
        Me.cboTipoEntrada.Size = New System.Drawing.Size(318, 21)
        Me.cboTipoEntrada.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(31, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Data:"
        '
        'txtTotalIntroduzir
        '
        Me.txtTotalIntroduzir.Enabled = False
        Me.txtTotalIntroduzir.Location = New System.Drawing.Point(133, 93)
        Me.txtTotalIntroduzir.Name = "txtTotalIntroduzir"
        Me.txtTotalIntroduzir.Size = New System.Drawing.Size(318, 20)
        Me.txtTotalIntroduzir.TabIndex = 5
        Me.txtTotalIntroduzir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtQtdIntroduzir
        '
        Me.txtQtdIntroduzir.Location = New System.Drawing.Point(133, 67)
        Me.txtQtdIntroduzir.Name = "txtQtdIntroduzir"
        Me.txtQtdIntroduzir.Size = New System.Drawing.Size(318, 20)
        Me.txtQtdIntroduzir.TabIndex = 5
        Me.txtQtdIntroduzir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.Enabled = False
        Me.txtPrecoVenda.Location = New System.Drawing.Point(133, 205)
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.ReadOnly = True
        Me.txtPrecoVenda.Size = New System.Drawing.Size(318, 20)
        Me.txtPrecoVenda.TabIndex = 5
        Me.txtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPrecoCompra
        '
        Me.txtPrecoCompra.Enabled = False
        Me.txtPrecoCompra.Location = New System.Drawing.Point(133, 176)
        Me.txtPrecoCompra.Name = "txtPrecoCompra"
        Me.txtPrecoCompra.ReadOnly = True
        Me.txtPrecoCompra.Size = New System.Drawing.Size(318, 20)
        Me.txtPrecoCompra.TabIndex = 5
        Me.txtPrecoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(31, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Total a introduzir:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(34, 39)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Tipo de entrada:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(40, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Preço venda:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(47, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Qtd introduzir:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(35, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Preço compra:"
        '
        'txtQtdCaixa
        '
        Me.txtQtdCaixa.Enabled = False
        Me.txtQtdCaixa.Location = New System.Drawing.Point(133, 150)
        Me.txtQtdCaixa.Name = "txtQtdCaixa"
        Me.txtQtdCaixa.ReadOnly = True
        Me.txtQtdCaixa.Size = New System.Drawing.Size(196, 20)
        Me.txtQtdCaixa.TabIndex = 5
        Me.txtQtdCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(56, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Qtd caixa:"
        '
        'txtPaisOrigem
        '
        Me.txtPaisOrigem.Enabled = False
        Me.txtPaisOrigem.Location = New System.Drawing.Point(133, 125)
        Me.txtPaisOrigem.Name = "txtPaisOrigem"
        Me.txtPaisOrigem.ReadOnly = True
        Me.txtPaisOrigem.Size = New System.Drawing.Size(196, 20)
        Me.txtPaisOrigem.TabIndex = 5
        Me.txtPaisOrigem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(44, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "País origem:"
        '
        'txtDesignacao
        '
        Me.txtDesignacao.Location = New System.Drawing.Point(133, 13)
        Me.txtDesignacao.Name = "txtDesignacao"
        Me.txtDesignacao.Size = New System.Drawing.Size(496, 20)
        Me.txtDesignacao.TabIndex = 5
        Me.txtDesignacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(367, 118)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(67, 13)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "Stock actual"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(52, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Designação:"
        '
        'dpData
        '
        Me.dpData.Location = New System.Drawing.Point(80, 510)
        Me.dpData.Name = "dpData"
        Me.dpData.Size = New System.Drawing.Size(196, 20)
        Me.dpData.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(434, 505)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Total gasto:"
        '
        'txtTotalGasto
        '
        Me.txtTotalGasto.Location = New System.Drawing.Point(561, 508)
        Me.txtTotalGasto.Name = "txtTotalGasto"
        Me.txtTotalGasto.Size = New System.Drawing.Size(220, 20)
        Me.txtTotalGasto.TabIndex = 5
        Me.txtTotalGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(237, 90)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(98, 20)
        Me.txtID.TabIndex = 20
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(415, 531)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Total a receber:"
        '
        'txtTotalEsperado
        '
        Me.txtTotalEsperado.Location = New System.Drawing.Point(561, 534)
        Me.txtTotalEsperado.Name = "txtTotalEsperado"
        Me.txtTotalEsperado.Size = New System.Drawing.Size(220, 20)
        Me.txtTotalEsperado.TabIndex = 5
        Me.txtTotalEsperado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(356, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Pesquisar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dpValidade
        '
        Me.dpValidade.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dpValidade.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpValidade.Location = New System.Drawing.Point(545, 86)
        Me.dpValidade.Name = "dpValidade"
        Me.dpValidade.Size = New System.Drawing.Size(84, 20)
        Me.dpValidade.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(488, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(51, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Validade:"
        '
        'frmEntradaProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 402)
        Me.Controls.Add(Me.dpValidade)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dpData)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtNrEntrada)
        Me.Controls.Add(Me.txtTotalEsperado)
        Me.Controls.Add(Me.txtTotalGasto)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dgEntradaProdutos)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEntradaProdutos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEntradaProdutos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgEntradaProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.pnPesquisar.ResumeLayout(False)
        CType(Me.dgPesquisar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgEntradaProdutos As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNrEntrada As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dpData As DateTimePicker
    Friend WithEvents btnAdicionaar As Button
    Friend WithEvents cboTipoEntrada As ComboBox
    Friend WithEvents txtTotalIntroduzir As TextBox
    Friend WithEvents txtQtdIntroduzir As TextBox
    Friend WithEvents txtPrecoCompra As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtQtdCaixa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDesignacao As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotalGasto As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPrecoVenda As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPaisOrigem As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtStockActual As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtTotalEsperado As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents mskData As MaskedTextBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents designacaoproduto As DataGridViewTextBoxColumn
    Friend WithEvents tipoentrada As DataGridViewTextBoxColumn
    Friend WithEvents qtdintroduzir As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents qtdcx As DataGridViewTextBoxColumn
    Friend WithEvents precocompra As DataGridViewTextBoxColumn
    Friend WithEvents precovendas As DataGridViewTextBoxColumn
    Friend WithEvents colEditar As DataGridViewButtonColumn
    Friend WithEvents colRemover As DataGridViewButtonColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRegistar As Button
    Friend WithEvents dpValidade As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents pnPesquisar As Panel
    Friend WithEvents dgPesquisar As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents designacao As DataGridViewTextBoxColumn
    Friend WithEvents paisorigem As DataGridViewTextBoxColumn
    Friend WithEvents precovenda As DataGridViewTextBoxColumn
    Friend WithEvents precodecompra As DataGridViewTextBoxColumn
    Friend WithEvents qtdcaixa As DataGridViewTextBoxColumn
    Friend WithEvents colSelecionar As DataGridViewButtonColumn
End Class
