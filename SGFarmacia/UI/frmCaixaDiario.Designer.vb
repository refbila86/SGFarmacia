﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCaixaDiario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaixaDiario))
        Me.dgListaVendas = New System.Windows.Forms.DataGridView()
        Me.nrvenda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contacto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.valortotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lucrovd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDetalhes = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colRemover = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTotalGeral = New System.Windows.Forms.TextBox()
        Me.btnLucroDoDia = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFecharCaixa = New System.Windows.Forms.Button()
        Me.btnRegistar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mskData = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.btnPesquisaEntreDatas = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.pnLucro = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEstadoCaixa = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.txtLucro = New System.Windows.Forms.TextBox()
        Me.lblLucro = New System.Windows.Forms.TextBox()
        CType(Me.dgListaVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.pnLucro.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgListaVendas
        '
        Me.dgListaVendas.AllowUserToAddRows = False
        Me.dgListaVendas.AllowUserToDeleteRows = False
        Me.dgListaVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgListaVendas.BackgroundColor = System.Drawing.Color.White
        Me.dgListaVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgListaVendas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nrvenda, Me.cliente, Me.nuit, Me.contacto, Me.valortotal, Me.lucrovd, Me.colDetalhes, Me.colRemover})
        Me.dgListaVendas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgListaVendas.EnableHeadersVisualStyles = False
        Me.dgListaVendas.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgListaVendas.Location = New System.Drawing.Point(0, 0)
        Me.dgListaVendas.Name = "dgListaVendas"
        Me.dgListaVendas.ReadOnly = True
        Me.dgListaVendas.RowHeadersVisible = False
        Me.dgListaVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListaVendas.Size = New System.Drawing.Size(1097, 359)
        Me.dgListaVendas.TabIndex = 27
        '
        'nrvenda
        '
        Me.nrvenda.FillWeight = 106.8817!
        Me.nrvenda.HeaderText = "Nº Venda"
        Me.nrvenda.Name = "nrvenda"
        Me.nrvenda.ReadOnly = True
        '
        'cliente
        '
        Me.cliente.FillWeight = 106.8817!
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
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
        'lucrovd
        '
        Me.lucrovd.HeaderText = "Lucro na VD"
        Me.lucrovd.Name = "lucrovd"
        Me.lucrovd.ReadOnly = True
        Me.lucrovd.Visible = False
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
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.dgListaVendas)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 105)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1097, 359)
        Me.Panel2.TabIndex = 24
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.btnLucroDoDia)
        Me.Panel3.Controls.Add(Me.btnFecharCaixa)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 464)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1097, 40)
        Me.Panel3.TabIndex = 26
        '
        'txtTotalGeral
        '
        Me.txtTotalGeral.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalGeral.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalGeral.Location = New System.Drawing.Point(969, 76)
        Me.txtTotalGeral.Name = "txtTotalGeral"
        Me.txtTotalGeral.ReadOnly = True
        Me.txtTotalGeral.Size = New System.Drawing.Size(103, 24)
        Me.txtTotalGeral.TabIndex = 0
        Me.txtTotalGeral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnLucroDoDia
        '
        Me.btnLucroDoDia.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnLucroDoDia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLucroDoDia.FlatAppearance.BorderSize = 0
        Me.btnLucroDoDia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnLucroDoDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLucroDoDia.ForeColor = System.Drawing.Color.White
        Me.btnLucroDoDia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLucroDoDia.Location = New System.Drawing.Point(8, 6)
        Me.btnLucroDoDia.Name = "btnLucroDoDia"
        Me.btnLucroDoDia.Size = New System.Drawing.Size(132, 29)
        Me.btnLucroDoDia.TabIndex = 10
        Me.btnLucroDoDia.Text = "Verificar lucro do dia"
        Me.btnLucroDoDia.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(893, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 18)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Valor total: "
        '
        'btnFecharCaixa
        '
        Me.btnFecharCaixa.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnFecharCaixa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFecharCaixa.FlatAppearance.BorderSize = 0
        Me.btnFecharCaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.btnFecharCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFecharCaixa.ForeColor = System.Drawing.Color.White
        Me.btnFecharCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFecharCaixa.Location = New System.Drawing.Point(146, 6)
        Me.btnFecharCaixa.Name = "btnFecharCaixa"
        Me.btnFecharCaixa.Size = New System.Drawing.Size(132, 29)
        Me.btnFecharCaixa.TabIndex = 10
        Me.btnFecharCaixa.Text = "Fechar o caixa diario"
        Me.btnFecharCaixa.UseVisualStyleBackColor = False
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
        Me.btnRegistar.Location = New System.Drawing.Point(8, 42)
        Me.btnRegistar.Name = "btnRegistar"
        Me.btnRegistar.Size = New System.Drawing.Size(76, 29)
        Me.btnRegistar.TabIndex = 10
        Me.btnRegistar.Text = "Novo"
        Me.btnRegistar.UseVisualStyleBackColor = False
        Me.btnRegistar.Visible = False
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(176, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 23)
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
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.mskData)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 46)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar vendas do dia"
        '
        'btnReset
        '
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.Location = New System.Drawing.Point(268, 17)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(84, 23)
        Me.btnReset.TabIndex = 30
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtLucro)
        Me.Panel4.Controls.Add(Me.txtTotalGeral)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.pnLucro)
        Me.Panel4.Controls.Add(Me.lblEstadoCaixa)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Panel1)
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Controls.Add(Me.btnRegistar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1097, 105)
        Me.Panel4.TabIndex = 25
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.dtpDateTo)
        Me.GroupBox2.Controls.Add(Me.btnPesquisaEntreDatas)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.dtpDateFrom)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(551, 51)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(498, 46)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pesquisar venda entre datas"
        Me.GroupBox2.Visible = False
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(278, 18)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(119, 20)
        Me.dtpDateTo.TabIndex = 14
        '
        'btnPesquisaEntreDatas
        '
        Me.btnPesquisaEntreDatas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPesquisaEntreDatas.Image = Global.SGFarmacia.My.Resources.Resources.eye_16px
        Me.btnPesquisaEntreDatas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesquisaEntreDatas.Location = New System.Drawing.Point(414, 16)
        Me.btnPesquisaEntreDatas.Name = "btnPesquisaEntreDatas"
        Me.btnPesquisaEntreDatas.Size = New System.Drawing.Size(75, 23)
        Me.btnPesquisaEntreDatas.TabIndex = 30
        Me.btnPesquisaEntreDatas.Text = "Pesquisar"
        Me.btnPesquisaEntreDatas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisaEntreDatas.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(209, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Data final :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Data inicial :"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.Location = New System.Drawing.Point(84, 18)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(119, 20)
        Me.dtpDateFrom.TabIndex = 11
        '
        'pnLucro
        '
        Me.pnLucro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnLucro.BackColor = System.Drawing.Color.Teal
        Me.pnLucro.Controls.Add(Me.Label4)
        Me.pnLucro.Controls.Add(Me.lblLucro)
        Me.pnLucro.Location = New System.Drawing.Point(863, 49)
        Me.pnLucro.Name = "pnLucro"
        Me.pnLucro.Size = New System.Drawing.Size(213, 25)
        Me.pnLucro.TabIndex = 28
        Me.pnLucro.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Lucro do dia:"
        '
        'lblEstadoCaixa
        '
        Me.lblEstadoCaixa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstadoCaixa.AutoSize = True
        Me.lblEstadoCaixa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoCaixa.ForeColor = System.Drawing.Color.Blue
        Me.lblEstadoCaixa.Location = New System.Drawing.Point(1027, 31)
        Me.lblEstadoCaixa.Name = "lblEstadoCaixa"
        Me.lblEstadoCaixa.Size = New System.Drawing.Size(54, 16)
        Me.lblEstadoCaixa.TabIndex = 32
        Me.lblEstadoCaixa.Text = "Aberto"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(860, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Estado do caixa do dia:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1097, 28)
        Me.Panel1.TabIndex = 33
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
        Me.Button3.Location = New System.Drawing.Point(1072, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 25)
        Me.Button3.TabIndex = 7
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(7, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 20)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(358, 18)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(91, 22)
        Me.btnImprimir.TabIndex = 31
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'txtLucro
        '
        Me.txtLucro.Location = New System.Drawing.Point(736, 57)
        Me.txtLucro.Name = "txtLucro"
        Me.txtLucro.Size = New System.Drawing.Size(100, 20)
        Me.txtLucro.TabIndex = 34
        Me.txtLucro.Visible = False
        '
        'lblLucro
        '
        Me.lblLucro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLucro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLucro.Location = New System.Drawing.Point(98, 1)
        Me.lblLucro.Name = "lblLucro"
        Me.lblLucro.ReadOnly = True
        Me.lblLucro.Size = New System.Drawing.Size(111, 22)
        Me.lblLucro.TabIndex = 0
        Me.lblLucro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmCaixaDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 504)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "frmCaixaDiario"
        Me.Text = "frmCaixaDiario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgListaVendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.pnLucro.ResumeLayout(False)
        Me.pnLucro.PerformLayout()
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalGeral As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnFecharCaixa As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lblEstadoCaixa As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents pnLucro As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnLucroDoDia As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpDateTo As DateTimePicker
    Friend WithEvents btnPesquisaEntreDatas As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpDateFrom As DateTimePicker
    Friend WithEvents nrvenda As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents nuit As DataGridViewTextBoxColumn
    Friend WithEvents contacto As DataGridViewTextBoxColumn
    Friend WithEvents valortotal As DataGridViewTextBoxColumn
    Friend WithEvents lucrovd As DataGridViewTextBoxColumn
    Friend WithEvents colDetalhes As DataGridViewButtonColumn
    Friend WithEvents colRemover As DataGridViewButtonColumn
    Friend WithEvents btnImprimir As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtLucro As TextBox
    Friend WithEvents lblLucro As TextBox
End Class
