<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListarProdutos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListarProdutos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgListaFuncionarios = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnRegistar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dpData = New System.Windows.Forms.DateTimePicker()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomegenerico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stockactual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precocompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valordia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtdcaixa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.validade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paisorigem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEditar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colRemover = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgListaFuncionarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 476)
        Me.Panel1.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgListaFuncionarios)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 71)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(800, 372)
        Me.Panel5.TabIndex = 13
        '
        'dgListaFuncionarios
        '
        Me.dgListaFuncionarios.AllowUserToAddRows = False
        Me.dgListaFuncionarios.AllowUserToDeleteRows = False
        Me.dgListaFuncionarios.BackgroundColor = System.Drawing.Color.White
        Me.dgListaFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgListaFuncionarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.produto, Me.nomegenerico, Me.categoria, Me.stockactual, Me.precocompra, Me.valordia, Me.qtdcaixa, Me.validade, Me.paisorigem, Me.colEditar, Me.colRemover})
        Me.dgListaFuncionarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgListaFuncionarios.EnableHeadersVisualStyles = False
        Me.dgListaFuncionarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgListaFuncionarios.Location = New System.Drawing.Point(0, 0)
        Me.dgListaFuncionarios.Name = "dgListaFuncionarios"
        Me.dgListaFuncionarios.ReadOnly = True
        Me.dgListaFuncionarios.RowHeadersVisible = False
        Me.dgListaFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListaFuncionarios.Size = New System.Drawing.Size(800, 372)
        Me.dgListaFuncionarios.TabIndex = 17
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnRegistar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 33)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(800, 38)
        Me.Panel4.TabIndex = 12
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
        Me.btnRegistar.Location = New System.Drawing.Point(12, 3)
        Me.btnRegistar.Name = "btnRegistar"
        Me.btnRegistar.Size = New System.Drawing.Size(76, 29)
        Me.btnRegistar.TabIndex = 10
        Me.btnRegistar.Text = "Novo"
        Me.btnRegistar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 443)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 33)
        Me.Panel3.TabIndex = 11
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.ForestGreen
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(775, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 25)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel2.Controls.Add(Me.dpData)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 33)
        Me.Panel2.TabIndex = 1
        '
        'dpData
        '
        Me.dpData.Location = New System.Drawing.Point(302, 6)
        Me.dpData.Name = "dpData"
        Me.dpData.Size = New System.Drawing.Size(196, 20)
        Me.dpData.TabIndex = 23
        '
        'id
        '
        Me.id.Frozen = True
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Width = 30
        '
        'produto
        '
        Me.produto.Frozen = True
        Me.produto.HeaderText = "Designacao do produto"
        Me.produto.Name = "produto"
        Me.produto.ReadOnly = True
        Me.produto.Width = 185
        '
        'nomegenerico
        '
        Me.nomegenerico.Frozen = True
        Me.nomegenerico.HeaderText = "Nome genérico"
        Me.nomegenerico.Name = "nomegenerico"
        Me.nomegenerico.ReadOnly = True
        Me.nomegenerico.Visible = False
        Me.nomegenerico.Width = 175
        '
        'categoria
        '
        Me.categoria.Frozen = True
        Me.categoria.HeaderText = "Categoria"
        Me.categoria.Name = "categoria"
        Me.categoria.ReadOnly = True
        Me.categoria.Width = 150
        '
        'stockactual
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.stockactual.DefaultCellStyle = DataGridViewCellStyle1
        Me.stockactual.HeaderText = "Stock actual"
        Me.stockactual.Name = "stockactual"
        Me.stockactual.ReadOnly = True
        '
        'precocompra
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.precocompra.DefaultCellStyle = DataGridViewCellStyle2
        Me.precocompra.HeaderText = "Preço compra"
        Me.precocompra.Name = "precocompra"
        Me.precocompra.ReadOnly = True
        '
        'valordia
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.valordia.DefaultCellStyle = DataGridViewCellStyle3
        Me.valordia.HeaderText = "Preço venda"
        Me.valordia.Name = "valordia"
        Me.valordia.ReadOnly = True
        '
        'qtdcaixa
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.qtdcaixa.DefaultCellStyle = DataGridViewCellStyle4
        Me.qtdcaixa.HeaderText = "Qtd por caixa"
        Me.qtdcaixa.Name = "qtdcaixa"
        Me.qtdcaixa.ReadOnly = True
        '
        'validade
        '
        Me.validade.HeaderText = "Validade"
        Me.validade.Name = "validade"
        Me.validade.ReadOnly = True
        Me.validade.Width = 195
        '
        'paisorigem
        '
        Me.paisorigem.HeaderText = "Pais origem"
        Me.paisorigem.Name = "paisorigem"
        Me.paisorigem.ReadOnly = True
        Me.paisorigem.Visible = False
        '
        'colEditar
        '
        Me.colEditar.HeaderText = ""
        Me.colEditar.Name = "colEditar"
        Me.colEditar.ReadOnly = True
        '
        'colRemover
        '
        Me.colRemover.HeaderText = ""
        Me.colRemover.Name = "colRemover"
        Me.colRemover.ReadOnly = True
        '
        'frmListarProdutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 476)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmListarProdutos"
        Me.ShowIcon = False
        Me.Text = "frmListarProdutos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgListaFuncionarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRegistar As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dgListaFuncionarios As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dpData As DateTimePicker
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents produto As DataGridViewTextBoxColumn
    Friend WithEvents nomegenerico As DataGridViewTextBoxColumn
    Friend WithEvents categoria As DataGridViewTextBoxColumn
    Friend WithEvents stockactual As DataGridViewTextBoxColumn
    Friend WithEvents precocompra As DataGridViewTextBoxColumn
    Friend WithEvents valordia As DataGridViewTextBoxColumn
    Friend WithEvents qtdcaixa As DataGridViewTextBoxColumn
    Friend WithEvents validade As DataGridViewTextBoxColumn
    Friend WithEvents paisorigem As DataGridViewTextBoxColumn
    Friend WithEvents colEditar As DataGridViewButtonColumn
    Friend WithEvents colRemover As DataGridViewButtonColumn
End Class
