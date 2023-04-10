<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastrarProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastrarProduto))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblRegistar = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtDesignacao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrecoVenda = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPrecoCompra = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dpValidade = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtQtdCaixa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboUnidadeMedida = New System.Windows.Forms.ComboBox()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnRegistar = New System.Windows.Forms.Button()
        Me.txtIDCategoria = New System.Windows.Forms.TextBox()
        Me.cboPaisOrigem = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNomeGenerico = New System.Windows.Forms.TextBox()
        Me.txtCodigoBarras = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel1.Controls.Add(Me.lblRegistar)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(672, 69)
        Me.Panel1.TabIndex = 1
        '
        'lblRegistar
        '
        Me.lblRegistar.AutoSize = True
        Me.lblRegistar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistar.ForeColor = System.Drawing.Color.White
        Me.lblRegistar.Location = New System.Drawing.Point(279, 36)
        Me.lblRegistar.Name = "lblRegistar"
        Me.lblRegistar.Size = New System.Drawing.Size(175, 24)
        Me.lblRegistar.TabIndex = 6
        Me.lblRegistar.Text = "Registar Produtos"
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
        Me.Button3.Location = New System.Drawing.Point(647, 3)
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
        Me.Panel2.Size = New System.Drawing.Size(672, 33)
        Me.Panel2.TabIndex = 1
        '
        'txtDesignacao
        '
        Me.txtDesignacao.Location = New System.Drawing.Point(153, 118)
        Me.txtDesignacao.Name = "txtDesignacao"
        Me.txtDesignacao.Size = New System.Drawing.Size(312, 20)
        Me.txtDesignacao.TabIndex = 1
        Me.txtDesignacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(52, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Designação:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(508, 91)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(101, 20)
        Me.txtID.TabIndex = 6
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtID.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(505, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID:"
        Me.Label1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(64, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Categoria:"
        '
        'cboCategoria
        '
        Me.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(154, 90)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(154, 21)
        Me.cboCategoria.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(48, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Preço venda:"
        '
        'txtPrecoVenda
        '
        Me.txtPrecoVenda.Location = New System.Drawing.Point(154, 203)
        Me.txtPrecoVenda.Name = "txtPrecoVenda"
        Me.txtPrecoVenda.Size = New System.Drawing.Size(312, 20)
        Me.txtPrecoVenda.TabIndex = 4
        Me.txtPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(43, 235)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Preço compra:"
        '
        'txtPrecoCompra
        '
        Me.txtPrecoCompra.Location = New System.Drawing.Point(154, 233)
        Me.txtPrecoCompra.Name = "txtPrecoCompra"
        Me.txtPrecoCompra.Size = New System.Drawing.Size(312, 20)
        Me.txtPrecoCompra.TabIndex = 5
        Me.txtPrecoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(325, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Validade:"
        '
        'dpValidade
        '
        Me.dpValidade.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dpValidade.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dpValidade.Location = New System.Drawing.Point(382, 91)
        Me.dpValidade.Name = "dpValidade"
        Me.dpValidade.Size = New System.Drawing.Size(84, 20)
        Me.dpValidade.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(471, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(198, 281)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "IMAGEM"
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
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(24, 247)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 28)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "BROWSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.SGFarmacia.My.Resources.Resources.medico
        Me.PictureBox1.Location = New System.Drawing.Point(8, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(55, 265)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Pais origem:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(46, 295)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Qtd por caixa:"
        '
        'txtQtdCaixa
        '
        Me.txtQtdCaixa.Location = New System.Drawing.Point(154, 294)
        Me.txtQtdCaixa.Name = "txtQtdCaixa"
        Me.txtQtdCaixa.Size = New System.Drawing.Size(312, 20)
        Me.txtQtdCaixa.TabIndex = 7
        Me.txtQtdCaixa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(16, 325)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Unidade de Medida:"
        '
        'cboUnidadeMedida
        '
        Me.cboUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidadeMedida.FormattingEnabled = True
        Me.cboUnidadeMedida.Items.AddRange(New Object() {"l", "ml", "un"})
        Me.cboUnidadeMedida.Location = New System.Drawing.Point(154, 324)
        Me.cboUnidadeMedida.Name = "cboUnidadeMedida"
        Me.cboUnidadeMedida.Size = New System.Drawing.Size(189, 21)
        Me.cboUnidadeMedida.TabIndex = 7
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.ForestGreen
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.ForeColor = System.Drawing.Color.White
        Me.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNovo.Location = New System.Drawing.Point(180, 360)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(261, 29)
        Me.btnNovo.TabIndex = 10
        Me.btnNovo.Text = "&Novo produto"
        Me.btnNovo.UseVisualStyleBackColor = False
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
        Me.btnRegistar.Location = New System.Drawing.Point(180, 360)
        Me.btnRegistar.Name = "btnRegistar"
        Me.btnRegistar.Size = New System.Drawing.Size(261, 29)
        Me.btnRegistar.TabIndex = 11
        Me.btnRegistar.Text = "Registar produto"
        Me.btnRegistar.UseVisualStyleBackColor = False
        '
        'txtIDCategoria
        '
        Me.txtIDCategoria.Location = New System.Drawing.Point(548, 90)
        Me.txtIDCategoria.Name = "txtIDCategoria"
        Me.txtIDCategoria.ReadOnly = True
        Me.txtIDCategoria.Size = New System.Drawing.Size(117, 20)
        Me.txtIDCategoria.TabIndex = 6
        Me.txtIDCategoria.Visible = False
        '
        'cboPaisOrigem
        '
        Me.cboPaisOrigem.Location = New System.Drawing.Point(154, 263)
        Me.cboPaisOrigem.Name = "cboPaisOrigem"
        Me.cboPaisOrigem.Size = New System.Drawing.Size(312, 20)
        Me.cboPaisOrigem.TabIndex = 6
        Me.cboPaisOrigem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(37, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Nome genérico:"
        '
        'txtNomeGenerico
        '
        Me.txtNomeGenerico.Location = New System.Drawing.Point(153, 144)
        Me.txtNomeGenerico.Name = "txtNomeGenerico"
        Me.txtNomeGenerico.Size = New System.Drawing.Size(312, 20)
        Me.txtNomeGenerico.TabIndex = 2
        Me.txtNomeGenerico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCodigoBarras
        '
        Me.txtCodigoBarras.ForeColor = System.Drawing.Color.Red
        Me.txtCodigoBarras.Location = New System.Drawing.Point(153, 172)
        Me.txtCodigoBarras.Name = "txtCodigoBarras"
        Me.txtCodigoBarras.Size = New System.Drawing.Size(312, 20)
        Me.txtCodigoBarras.TabIndex = 3
        Me.txtCodigoBarras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(44, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Codigo barras:"
        '
        'frmCadastrarProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 398)
        Me.Controls.Add(Me.cboPaisOrigem)
        Me.Controls.Add(Me.btnRegistar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dpValidade)
        Me.Controls.Add(Me.cboUnidadeMedida)
        Me.Controls.Add(Me.cboCategoria)
        Me.Controls.Add(Me.txtQtdCaixa)
        Me.Controls.Add(Me.txtPrecoCompra)
        Me.Controls.Add(Me.txtCodigoBarras)
        Me.Controls.Add(Me.txtPrecoVenda)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNomeGenerico)
        Me.Controls.Add(Me.txtDesignacao)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIDCategoria)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnNovo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCadastrarProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCadastrarProduto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblRegistar As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtDesignacao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPrecoVenda As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPrecoCompra As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dpValidade As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtQtdCaixa As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboUnidadeMedida As ComboBox
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnRegistar As Button
    Friend WithEvents txtIDCategoria As TextBox
    Friend WithEvents cboPaisOrigem As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNomeGenerico As TextBox
    Friend WithEvents txtCodigoBarras As TextBox
    Friend WithEvents Label3 As Label
End Class
