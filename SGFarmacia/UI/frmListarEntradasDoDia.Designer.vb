﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListarEntradasDoDia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListarEntradasDoDia))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTotalVenda = New System.Windows.Forms.TextBox()
        Me.txtTotalCompra = New System.Windows.Forms.TextBox()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRegistar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskData = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgEntradaProdutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel3.Controls.Add(Me.txtTotalVenda)
        Me.Panel3.Controls.Add(Me.txtTotalCompra)
        Me.Panel3.Controls.Add(Me.btnStock)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 538)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(835, 10)
        Me.Panel3.TabIndex = 14
        Me.Panel3.Visible = False
        '
        'txtTotalVenda
        '
        Me.txtTotalVenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalVenda.Location = New System.Drawing.Point(665, -22)
        Me.txtTotalVenda.Name = "txtTotalVenda"
        Me.txtTotalVenda.ReadOnly = True
        Me.txtTotalVenda.Size = New System.Drawing.Size(152, 20)
        Me.txtTotalVenda.TabIndex = 2
        Me.txtTotalVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalVenda.Visible = False
        '
        'txtTotalCompra
        '
        Me.txtTotalCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalCompra.Location = New System.Drawing.Point(665, -46)
        Me.txtTotalCompra.Name = "txtTotalCompra"
        Me.txtTotalCompra.ReadOnly = True
        Me.txtTotalCompra.Size = New System.Drawing.Size(152, 20)
        Me.txtTotalCompra.TabIndex = 2
        Me.txtTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalCompra.Visible = False
        '
        'btnStock
        '
        Me.btnStock.BackColor = System.Drawing.Color.Blue
        Me.btnStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStock.FlatAppearance.BorderSize = 0
        Me.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStock.ForeColor = System.Drawing.Color.White
        Me.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStock.Location = New System.Drawing.Point(22, 13)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(142, 33)
        Me.btnStock.TabIndex = 10
        Me.btnStock.Text = "Verificar stock"
        Me.btnStock.UseVisualStyleBackColor = False
        Me.btnStock.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(592, -19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total venda:"
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(587, -43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total compra:"
        Me.Label1.Visible = False
        '
        'btnRegistar
        '
        Me.btnRegistar.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnRegistar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistar.FlatAppearance.BorderSize = 0
        Me.btnRegistar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnRegistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistar.ForeColor = System.Drawing.Color.White
        Me.btnRegistar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegistar.Location = New System.Drawing.Point(12, 49)
        Me.btnRegistar.Name = "btnRegistar"
        Me.btnRegistar.Size = New System.Drawing.Size(76, 29)
        Me.btnRegistar.TabIndex = 10
        Me.btnRegistar.Text = "Novo"
        Me.btnRegistar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.mskData)
        Me.GroupBox1.Location = New System.Drawing.Point(105, 39)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(358, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(455, 46)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar entradas entre datas "
        Me.GroupBox2.Visible = False
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
        Me.Button2.Location = New System.Drawing.Point(374, 13)
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
        Me.Label6.Location = New System.Drawing.Point(198, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Fim:"
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
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.GroupBox2)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.btnRegistar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(835, 103)
        Me.Panel4.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(835, 25)
        Me.Panel1.TabIndex = 31
        '
        'dgEntradaProdutos
        '
        Me.dgEntradaProdutos.AllowUserToAddRows = False
        Me.dgEntradaProdutos.AllowUserToDeleteRows = False
        Me.dgEntradaProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgEntradaProdutos.BackgroundColor = System.Drawing.Color.White
        Me.dgEntradaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgEntradaProdutos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.designacaoproduto, Me.tipoentrada, Me.qtdintroduzir, Me.Column1, Me.qtdcx, Me.precocompra, Me.precovendas, Me.colEditar, Me.colRemover})
        Me.dgEntradaProdutos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgEntradaProdutos.EnableHeadersVisualStyles = False
        Me.dgEntradaProdutos.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgEntradaProdutos.Location = New System.Drawing.Point(0, 103)
        Me.dgEntradaProdutos.Name = "dgEntradaProdutos"
        Me.dgEntradaProdutos.ReadOnly = True
        Me.dgEntradaProdutos.RowHeadersVisible = False
        Me.dgEntradaProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgEntradaProdutos.Size = New System.Drawing.Size(835, 435)
        Me.dgEntradaProdutos.TabIndex = 20
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
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.SGFarmacia.My.Resources.Resources.add_stock
        Me.PictureBox1.Location = New System.Drawing.Point(405, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.Teal
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(810, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 25)
        Me.Button3.TabIndex = 6
        Me.Button3.UseVisualStyleBackColor = False
        '
        'frmListarEntradasDoDia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 548)
        Me.Controls.Add(Me.dgEntradaProdutos)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmListarEntradasDoDia"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listar entradas do dia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgEntradaProdutos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtTotalVenda As TextBox
    Friend WithEvents txtTotalCompra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRegistar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents mskData As MaskedTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnStock As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgEntradaProdutos As DataGridView
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button3 As Button
End Class
