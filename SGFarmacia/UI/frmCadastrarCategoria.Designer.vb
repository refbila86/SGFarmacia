<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastrarCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastrarCategoria))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDesignacao = New System.Windows.Forms.TextBox()
        Me.btnRegistar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.dgListarCategoria = New System.Windows.Forms.DataGridView()
        Me.irps = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEditar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colRemover = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dgListarCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LimeGreen
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(482, 69)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(165, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Registar Categoria"
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
        Me.Button3.Location = New System.Drawing.Point(457, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(22, 25)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(482, 33)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID:"
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(120, 106)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(312, 20)
        Me.txtID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Designação:"
        '
        'txtDesignacao
        '
        Me.txtDesignacao.Location = New System.Drawing.Point(120, 146)
        Me.txtDesignacao.Name = "txtDesignacao"
        Me.txtDesignacao.Size = New System.Drawing.Size(312, 20)
        Me.txtDesignacao.TabIndex = 0
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
        Me.btnRegistar.Location = New System.Drawing.Point(290, 174)
        Me.btnRegistar.Name = "btnRegistar"
        Me.btnRegistar.Size = New System.Drawing.Size(142, 29)
        Me.btnRegistar.TabIndex = 3
        Me.btnRegistar.Text = "Registar"
        Me.btnRegistar.UseVisualStyleBackColor = False
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
        Me.btnNovo.Location = New System.Drawing.Point(120, 174)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(142, 29)
        Me.btnNovo.TabIndex = 3
        Me.btnNovo.Text = "&Nova"
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'dgListarCategoria
        '
        Me.dgListarCategoria.AllowUserToAddRows = False
        Me.dgListarCategoria.AllowUserToDeleteRows = False
        Me.dgListarCategoria.BackgroundColor = System.Drawing.Color.White
        Me.dgListarCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgListarCategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.irps, Me.total, Me.colEditar, Me.colRemover})
        Me.dgListarCategoria.EnableHeadersVisualStyles = False
        Me.dgListarCategoria.GridColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.dgListarCategoria.Location = New System.Drawing.Point(12, 209)
        Me.dgListarCategoria.Name = "dgListarCategoria"
        Me.dgListarCategoria.ReadOnly = True
        Me.dgListarCategoria.RowHeadersVisible = False
        Me.dgListarCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListarCategoria.Size = New System.Drawing.Size(458, 199)
        Me.dgListarCategoria.TabIndex = 17
        '
        'irps
        '
        Me.irps.HeaderText = "Id"
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
        'frmCadastrarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 419)
        Me.Controls.Add(Me.dgListarCategoria)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnRegistar)
        Me.Controls.Add(Me.txtDesignacao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmCadastrarCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgListarCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDesignacao As TextBox
    Friend WithEvents btnRegistar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents dgListarCategoria As DataGridView
    Friend WithEvents irps As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents colEditar As DataGridViewButtonColumn
    Friend WithEvents colRemover As DataGridViewButtonColumn
End Class
