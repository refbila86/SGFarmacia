<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResumo
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
        Me.pnProdutos = New System.Windows.Forms.Panel()
        Me.lblTotalProdutos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnVendas = New System.Windows.Forms.Panel()
        Me.lblNrVendasDia = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalSemStock = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgCaixa = New System.Windows.Forms.DataGridView()
        Me.Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgMenos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgNunca = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pnProdutos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnVendas.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgCaixa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMenos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgNunca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnProdutos
        '
        Me.pnProdutos.BackColor = System.Drawing.Color.Maroon
        Me.pnProdutos.Controls.Add(Me.lblTotalProdutos)
        Me.pnProdutos.Controls.Add(Me.Label1)
        Me.pnProdutos.Controls.Add(Me.PictureBox1)
        Me.pnProdutos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnProdutos.Location = New System.Drawing.Point(3, 12)
        Me.pnProdutos.Name = "pnProdutos"
        Me.pnProdutos.Size = New System.Drawing.Size(220, 99)
        Me.pnProdutos.TabIndex = 14
        '
        'lblTotalProdutos
        '
        Me.lblTotalProdutos.AutoSize = True
        Me.lblTotalProdutos.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalProdutos.ForeColor = System.Drawing.Color.White
        Me.lblTotalProdutos.Location = New System.Drawing.Point(114, 35)
        Me.lblTotalProdutos.Name = "lblTotalProdutos"
        Me.lblTotalProdutos.Size = New System.Drawing.Size(81, 61)
        Me.lblTotalProdutos.TabIndex = 15
        Me.lblTotalProdutos.Text = "..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(102, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Produtos "
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.SGFarmacia.My.Resources.Resources.stock_in_icon
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'pnVendas
        '
        Me.pnVendas.BackColor = System.Drawing.Color.ForestGreen
        Me.pnVendas.Controls.Add(Me.lblNrVendasDia)
        Me.pnVendas.Controls.Add(Me.Label3)
        Me.pnVendas.Controls.Add(Me.PictureBox2)
        Me.pnVendas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pnVendas.Location = New System.Drawing.Point(233, 12)
        Me.pnVendas.Name = "pnVendas"
        Me.pnVendas.Size = New System.Drawing.Size(220, 99)
        Me.pnVendas.TabIndex = 14
        '
        'lblNrVendasDia
        '
        Me.lblNrVendasDia.AutoSize = True
        Me.lblNrVendasDia.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNrVendasDia.ForeColor = System.Drawing.Color.White
        Me.lblNrVendasDia.Location = New System.Drawing.Point(112, 34)
        Me.lblNrVendasDia.Name = "lblNrVendasDia"
        Me.lblNrVendasDia.Size = New System.Drawing.Size(81, 61)
        Me.lblNrVendasDia.TabIndex = 15
        Me.lblNrVendasDia.Text = "..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(72, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Vendas do dia"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.SGFarmacia.My.Resources.Resources.add_stock
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.lblTotalSemStock)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(459, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 99)
        Me.Panel1.TabIndex = 14
        '
        'lblTotalSemStock
        '
        Me.lblTotalSemStock.AutoSize = True
        Me.lblTotalSemStock.Font = New System.Drawing.Font("Trebuchet MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSemStock.ForeColor = System.Drawing.Color.White
        Me.lblTotalSemStock.Location = New System.Drawing.Point(109, 31)
        Me.lblTotalSemStock.Name = "lblTotalSemStock"
        Me.lblTotalSemStock.Size = New System.Drawing.Size(81, 61)
        Me.lblTotalSemStock.TabIndex = 15
        Me.lblTotalSemStock.Text = "..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(55, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Produtos sem stock"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(987, 17)
        Me.Panel2.TabIndex = 15
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Teal
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.PictureBox4)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 17)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(987, 41)
        Me.Panel4.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(7, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(206, 29)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Painel de resumo"
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Image = Global.SGFarmacia.My.Resources.Resources.Summary
        Me.PictureBox4.Location = New System.Drawing.Point(945, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(30, 29)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 33
        Me.PictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Produtos mais comprados"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.pnProdutos)
        Me.Panel3.Controls.Add(Me.pnVendas)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 58)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(987, 118)
        Me.Panel3.TabIndex = 18
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgNunca)
        Me.Panel5.Controls.Add(Me.dgMenos)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.dgCaixa)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 176)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(987, 179)
        Me.Panel5.TabIndex = 19
        '
        'dgCaixa
        '
        Me.dgCaixa.AllowUserToAddRows = False
        Me.dgCaixa.AllowUserToDeleteRows = False
        Me.dgCaixa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCaixa.BackgroundColor = System.Drawing.Color.White
        Me.dgCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgCaixa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Produto, Me.total})
        Me.dgCaixa.EnableHeadersVisualStyles = False
        Me.dgCaixa.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgCaixa.Location = New System.Drawing.Point(6, 23)
        Me.dgCaixa.Name = "dgCaixa"
        Me.dgCaixa.RowHeadersVisible = False
        Me.dgCaixa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCaixa.Size = New System.Drawing.Size(372, 148)
        Me.dgCaixa.TabIndex = 52
        '
        'Produto
        '
        Me.Produto.HeaderText = "Designaçã do produto"
        Me.Produto.Name = "Produto"
        '
        'total
        '
        Me.total.HeaderText = "Numero de vezes comprado"
        Me.total.Name = "total"
        '
        'dgMenos
        '
        Me.dgMenos.AllowUserToAddRows = False
        Me.dgMenos.AllowUserToDeleteRows = False
        Me.dgMenos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgMenos.BackgroundColor = System.Drawing.Color.White
        Me.dgMenos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgMenos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgMenos.EnableHeadersVisualStyles = False
        Me.dgMenos.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgMenos.Location = New System.Drawing.Point(384, 23)
        Me.dgMenos.Name = "dgMenos"
        Me.dgMenos.RowHeadersVisible = False
        Me.dgMenos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMenos.Size = New System.Drawing.Size(369, 148)
        Me.dgMenos.TabIndex = 53
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Designaçã do produto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Numero de vezes comprado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(384, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Produtos menos comprados"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(761, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 20)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Produtos nunca comprados"
        '
        'dgNunca
        '
        Me.dgNunca.AllowUserToAddRows = False
        Me.dgNunca.AllowUserToDeleteRows = False
        Me.dgNunca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgNunca.BackgroundColor = System.Drawing.Color.White
        Me.dgNunca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgNunca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3})
        Me.dgNunca.EnableHeadersVisualStyles = False
        Me.dgNunca.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgNunca.Location = New System.Drawing.Point(761, 23)
        Me.dgNunca.Name = "dgNunca"
        Me.dgNunca.RowHeadersVisible = False
        Me.dgNunca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgNunca.Size = New System.Drawing.Size(214, 148)
        Me.dgNunca.TabIndex = 53
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Designaçã do produto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.Image = Global.SGFarmacia.My.Resources.Resources.stock_in_icon
        Me.PictureBox3.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(51, 46)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 34
        Me.PictureBox3.TabStop = False
        '
        'frmResumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 525)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmResumo"
        Me.Text = "Resumo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnProdutos.ResumeLayout(False)
        Me.pnProdutos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnVendas.ResumeLayout(False)
        Me.pnVendas.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgCaixa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMenos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgNunca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pnProdutos As Panel
    Friend WithEvents lblTotalProdutos As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnVendas As Panel
    Friend WithEvents lblNrVendasDia As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotalSemStock As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dgCaixa As DataGridView
    Friend WithEvents Produto As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents dgMenos As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents dgNunca As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
