<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarEntradasDoDia
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskData = New System.Windows.Forms.MaskedTextBox()
        Me.btnRegistar = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTotalVenda = New System.Windows.Forms.TextBox()
        Me.txtTotalCompra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgEntradaProdutos = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.designacaoproduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoentrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.origem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtdintroduzir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtdcx = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precocompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precovendas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEditar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colRemover = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgEntradaProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(835, 33)
        Me.Panel2.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.btnRegistar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 33)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(835, 55)
        Me.Panel4.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(368, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(455, 46)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar entradas entre datas "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(166, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "A"
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(374, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Pesquisar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(186, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Fim"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(6, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Inicio:"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(227, 19)
        Me.MaskedTextBox2.Mask = "####-##-##"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(115, 20)
        Me.MaskedTextBox2.TabIndex = 29
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(45, 20)
        Me.MaskedTextBox1.Mask = "####-##-##"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(115, 20)
        Me.MaskedTextBox1.TabIndex = 29
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.mskData)
        Me.GroupBox1.Location = New System.Drawing.Point(115, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 46)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar entradas do dia"
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
        'btnRegistar
        '
        Me.btnRegistar.BackColor = System.Drawing.Color.ForestGreen
        Me.btnRegistar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistar.FlatAppearance.BorderSize = 0
        Me.btnRegistar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnRegistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistar.ForeColor = System.Drawing.Color.White
        Me.btnRegistar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistar.Location = New System.Drawing.Point(12, 17)
        Me.btnRegistar.Name = "btnRegistar"
        Me.btnRegistar.Size = New System.Drawing.Size(76, 29)
        Me.btnRegistar.TabIndex = 10
        Me.btnRegistar.Text = "Novo"
        Me.btnRegistar.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel3.Controls.Add(Me.txtTotalVenda)
        Me.Panel3.Controls.Add(Me.txtTotalCompra)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 390)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(835, 60)
        Me.Panel3.TabIndex = 14
        '
        'txtTotalVenda
        '
        Me.txtTotalVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalVenda.Location = New System.Drawing.Point(81, 30)
        Me.txtTotalVenda.Name = "txtTotalVenda"
        Me.txtTotalVenda.ReadOnly = True
        Me.txtTotalVenda.Size = New System.Drawing.Size(152, 20)
        Me.txtTotalVenda.TabIndex = 2
        Me.txtTotalVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalCompra
        '
        Me.txtTotalCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalCompra.Location = New System.Drawing.Point(81, 4)
        Me.txtTotalCompra.Name = "txtTotalCompra"
        Me.txtTotalCompra.ReadOnly = True
        Me.txtTotalCompra.Size = New System.Drawing.Size(152, 20)
        Me.txtTotalCompra.TabIndex = 2
        Me.txtTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total venda:"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total compra:"
        '
        'dgEntradaProdutos
        '
        Me.dgEntradaProdutos.AllowUserToAddRows = False
        Me.dgEntradaProdutos.AllowUserToDeleteRows = False
        Me.dgEntradaProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgEntradaProdutos.BackgroundColor = System.Drawing.Color.White
        Me.dgEntradaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgEntradaProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.designacaoproduto, Me.tipoentrada, Me.origem, Me.qtdintroduzir, Me.Column1, Me.qtdcx, Me.precocompra, Me.precovendas, Me.colEditar, Me.colRemover})
        Me.dgEntradaProdutos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgEntradaProdutos.EnableHeadersVisualStyles = False
        Me.dgEntradaProdutos.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgEntradaProdutos.Location = New System.Drawing.Point(0, 88)
        Me.dgEntradaProdutos.Name = "dgEntradaProdutos"
        Me.dgEntradaProdutos.ReadOnly = True
        Me.dgEntradaProdutos.RowHeadersVisible = False
        Me.dgEntradaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEntradaProdutos.Size = New System.Drawing.Size(835, 302)
        Me.dgEntradaProdutos.TabIndex = 19
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'designacaoproduto
        '
        Me.designacaoproduto.HeaderText = "Designação do produto"
        Me.designacaoproduto.Name = "designacaoproduto"
        Me.designacaoproduto.ReadOnly = True
        '
        'tipoentrada
        '
        Me.tipoentrada.HeaderText = "Tipo de entrada"
        Me.tipoentrada.Name = "tipoentrada"
        Me.tipoentrada.ReadOnly = True
        '
        'origem
        '
        Me.origem.HeaderText = "Origem"
        Me.origem.Name = "origem"
        Me.origem.ReadOnly = True
        '
        'qtdintroduzir
        '
        Me.qtdintroduzir.HeaderText = "Qtd Introduzir"
        Me.qtdintroduzir.Name = "qtdintroduzir"
        Me.qtdintroduzir.ReadOnly = True
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
        '
        'precocompra
        '
        Me.precocompra.HeaderText = "Preço compra"
        Me.precocompra.Name = "precocompra"
        Me.precocompra.ReadOnly = True
        '
        'precovendas
        '
        Me.precovendas.HeaderText = "Preco Venda"
        Me.precovendas.Name = "precovendas"
        Me.precovendas.ReadOnly = True
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
        'frmListarEntradasDoDia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 450)
        Me.Controls.Add(Me.dgEntradaProdutos)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmListarEntradasDoDia"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListarEntradasDoDia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgEntradaProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnRegistar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgEntradaProdutos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mskData As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents designacaoproduto As DataGridViewTextBoxColumn
    Friend WithEvents tipoentrada As DataGridViewTextBoxColumn
    Friend WithEvents origem As DataGridViewTextBoxColumn
    Friend WithEvents qtdintroduzir As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents qtdcx As DataGridViewTextBoxColumn
    Friend WithEvents precocompra As DataGridViewTextBoxColumn
    Friend WithEvents precovendas As DataGridViewTextBoxColumn
    Friend WithEvents colEditar As DataGridViewButtonColumn
    Friend WithEvents colRemover As DataGridViewButtonColumn
    Friend WithEvents txtTotalVenda As TextBox
    Friend WithEvents txtTotalCompra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
End Class
