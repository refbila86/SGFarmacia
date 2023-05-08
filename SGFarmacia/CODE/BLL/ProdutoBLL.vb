Public Class ProdutoBLL
    Dim sql As String
    Dim ds As New DataSet
    Dim con As New AcessoDados
    Dim tbl As New DataTable

    Public Sub RemoverProduto(ByRef id As Integer)
        sql = "Delete from Produto WHERE ID= " & id & ""
        con.ExecutarComandoSQL(sql)
    End Sub
    Public Function ListarProdutos()
        con.ConnectarMySql()
        ' sql = "SELECT f.nome as 'nome_completo', c.designacao as 'categoria',coalesce(s.valor,'0') as 'salario_base',coalesce(fs.nr_dias,30) as 'nr_dias', coalesce(fs.nr_faltas,0) as 'faltas', coalesce(fs.dias_trabalhados, 30) as 'dias_pagar', coalesce(fs.salario_por_dia,round(s.valor/30,2),'0.0') as 'valor_diario',coalesce(fs.alimento,'0.0') as 'subsidio_alimentacao',coalesce(fs.combustivel,'0.0') as 'subsidio_combustivel',coalesce(fs.bonus,'0.0') as 'bonus',coalesce(fs.total_subsidio,'0.0') as 'total_subsidio',coalesce(fs.valor_inss,coalesce(0.03*s.valor,'0.0')) as 'inss',coalesce(fs.valor_irps,'0.0') as 'irps',coalesce(fs.outras_despesas,'0.0') as 'outras_despesas',coalesce(fs.total_deducao,'0.0') as 'total_abates', coalesce(fs.salario_receber,'0.0') as 'salario_receber', coalesce(fs.salario_liquido,'0.0') as 'salario_liquido', fs.folha_mes_id FROM funcionario f left join salario s on f.id=s.funcionario_id left join folha_de_salario fs on f.id=fs.funcionario_id left join categoria c on c.id=f.categoria_id left join ano a on a.id=fs.ano_id group by f.nome;"
        sql = "select p.id, p.designacao, p.nome_generico, c.designacao as categoria, s.stock_actual 'stock actual', p.preco_compra 'preco compra', p.preco_venda 'preco venda', p.qtd_cx, p.validade, p.pais_origem from produto p left join produto_stock s on p.id=s.produto_id inner join categoria c on c.id=p.categoria_id;"
        con.ListarProdutos(sql)
        Return ds
    End Function
    Public Function PesquisarProduto(ByRef produto As String)
        con.ConnectarMySql()
        ' sql = "SELECT f.nome as 'nome_completo', c.designacao as 'categoria',coalesce(s.valor,'0') as 'salario_base',coalesce(fs.nr_dias,30) as 'nr_dias', coalesce(fs.nr_faltas,0) as 'faltas', coalesce(fs.dias_trabalhados, 30) as 'dias_pagar', coalesce(fs.salario_por_dia,round(s.valor/30,2),'0.0') as 'valor_diario',coalesce(fs.alimento,'0.0') as 'subsidio_alimentacao',coalesce(fs.combustivel,'0.0') as 'subsidio_combustivel',coalesce(fs.bonus,'0.0') as 'bonus',coalesce(fs.total_subsidio,'0.0') as 'total_subsidio',coalesce(fs.valor_inss,coalesce(0.03*s.valor,'0.0')) as 'inss',coalesce(fs.valor_irps,'0.0') as 'irps',coalesce(fs.outras_despesas,'0.0') as 'outras_despesas',coalesce(fs.total_deducao,'0.0') as 'total_abates', coalesce(fs.salario_receber,'0.0') as 'salario_receber', coalesce(fs.salario_liquido,'0.0') as 'salario_liquido', fs.folha_mes_id FROM funcionario f left join salario s on f.id=s.funcionario_id left join folha_de_salario fs on f.id=fs.funcionario_id left join categoria c on c.id=f.categoria_id left join ano a on a.id=fs.ano_id group by f.nome;"
        sql = "select p.id, p.designacao,  p.pais_origem, p.preco_venda, p.preco_compra, p.qtd_cx from produto p where p.designacao like '%" & produto & "%'"
        con.ListarProdutosPorNome(sql)
        Return ds
    End Function
    Public Function PesquisarProdutoSaida(ByRef produto As String)
        con.ConnectarMySql()
        ' sql = "SELECT f.nome as 'nome_completo', c.designacao as 'categoria',coalesce(s.valor,'0') as 'salario_base',coalesce(fs.nr_dias,30) as 'nr_dias', coalesce(fs.nr_faltas,0) as 'faltas', coalesce(fs.dias_trabalhados, 30) as 'dias_pagar', coalesce(fs.salario_por_dia,round(s.valor/30,2),'0.0') as 'valor_diario',coalesce(fs.alimento,'0.0') as 'subsidio_alimentacao',coalesce(fs.combustivel,'0.0') as 'subsidio_combustivel',coalesce(fs.bonus,'0.0') as 'bonus',coalesce(fs.total_subsidio,'0.0') as 'total_subsidio',coalesce(fs.valor_inss,coalesce(0.03*s.valor,'0.0')) as 'inss',coalesce(fs.valor_irps,'0.0') as 'irps',coalesce(fs.outras_despesas,'0.0') as 'outras_despesas',coalesce(fs.total_deducao,'0.0') as 'total_abates', coalesce(fs.salario_receber,'0.0') as 'salario_receber', coalesce(fs.salario_liquido,'0.0') as 'salario_liquido', fs.folha_mes_id FROM funcionario f left join salario s on f.id=s.funcionario_id left join folha_de_salario fs on f.id=fs.funcionario_id left join categoria c on c.id=f.categoria_id left join ano a on a.id=fs.ano_id group by f.nome;"
        sql = "select p.id, p.designacao, p.pais_origem origem, p.preco_venda, p.preco_compra, p.qtd_cx from produto p where p.designacao like '%" & produto & "%'"
        con.ListarProdutosPorNomeSaida(sql)
        Return ds
    End Function
    '
    Public Sub RegistarProduto(produtoDTO As ProdutoDTO)
        sql = "INSERT INTO produto (designacao,nome_generico, preco_venda, preco_compra, qtd_cx, pais_origem, criado, user, categoria_id) VALUES ('" & produtoDTO.Designacao & "','" & produtoDTO.Nome_Generico & "', '" & produtoDTO.Preco_Venda & "', '" & produtoDTO.Preco_Compra & "', '" & produtoDTO.Qtd_Cx & "', '" & produtoDTO.Pais_Origem & "', '" & produtoDTO.Criado & "', 'admin', '" & produtoDTO.Categoria_ID & "')"
        con.ExecutarComandoSQL(sql)
    End Sub
    Public Sub ActualizarProduto(produtoDTO As ProdutoDTO)
        sql = "UPDATE Produto set designacao = '" & produtoDTO.Designacao & "',nome_generico = '" & produtoDTO.Designacao & "', preco_venda=" & produtoDTO.Preco_Venda & ", preco_compra = " & produtoDTO.Preco_Compra & ", qtd_cx = " & produtoDTO.Qtd_Cx & ", validade ='" & produtoDTO.Validade & "', pais_origem = '" & produtoDTO.Pais_Origem & "', criado = '" & produtoDTO.Criado & "', user = 'refbila', categoria_id = '" & produtoDTO.Categoria_ID & "' WHERE id= " & produtoDTO.ID & ""
        con.ExecutarComandoSQL(sql)
    End Sub
    Public Sub ActualizarValidade(produtoDTO As ProdutoDTO)
        sql = "UPDATE Produto set  validade ='" & produtoDTO.Validade & "', user = 'refbila' WHERE id= " & produtoDTO.ID & ""
        con.ExecutarComandoSQL(sql)
    End Sub
End Class
