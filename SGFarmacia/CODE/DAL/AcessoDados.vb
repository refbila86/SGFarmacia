Imports MySql.Data.MySqlClient
Public Class AcessoDados
    Public cmd As MySqlCommand
    Public adpt As MySqlDataAdapter
    Public ds As New DataSet
    Public con As MySqlConnection
    Public tbl, dt As New DataTable
    Public dr As MySqlDataReader

    Public imgnome As String
    Public codigo As Integer



    Dim daImagem As MySqlDataAdapter
    Dim dsImagem As DataSet

    'Public acessoBLL As AcessoBLL

    Public adptImagem As MySqlDataAdapter

    ''Dim servidor = "192.168.168.37"
    ''Dim user = "fvServer"
    ''Dim pass = "@fvServer2023"
    ''Dim basedados = "fam"

    Dim servidor = "localhost"
    Dim user = "root"
    Dim pass = "root"
    Dim basedados = "farmacia"

    Public strCon = $"server={servidor}; user id={user}; password={pass}; database={basedados}; Convert Zero Datetime=True"
    Public Sub ConnectarMySql()
        Try
            Using con
                con = New MySqlConnection(strCon)
                con.Open()
                'MsgBox("Conectado")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message & "Erro ao conectar o sistema com a base de dados")
        End Try
    End Sub
    Public Sub ExecutarComandoSQL(ByVal sql As String)
        con = New MySqlConnection(strCon)
        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao executar o comando: " + ex.Message + "!", MsgBoxStyle.Critical, "ERRO")
        Finally
            con.Close()
        End Try
    End Sub

    Public Function Listar(ByVal sql As String)
        con = New MySqlConnection(strCon)
        Try
            con.Open()
            adpt = New MySqlDataAdapter(sql, con)
            ds.Clear()
            adpt.Fill(ds)
        Catch ex As Exception
            MsgBox("Erro gerar o codigo " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            con.Close()
        End Try
        Return ds
    End Function

    Public Function ListarEspecifico(ByVal sql As String)
        con = New MySqlConnection(strCon)
        Try
            con.Open()
            adpt = New MySqlDataAdapter(sql, con)
            tbl.Clear()
            adpt.Fill(tbl)

        Catch ex As Exception

            MsgBox("Erro ao listar os dados " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            con.Close()
        End Try
        Return tbl
    End Function

    Public Function ListarBeneficios(ByVal sql As String)
        con = New MySqlConnection(strCon)
        Try
            con.Open()
            adpt = New MySqlDataAdapter(sql, con)
            tbl.Clear()
            adpt.Fill(tbl)


            For i = 0 To tbl.Rows.Count - 1
                'frmCadastrarColaborador.lstBeneficios.SetItemChecked(i, (tbl.Rows(i).Item(0)))
            Next

        Catch ex As Exception
            MsgBox("Erro ao listar os beneficios " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            con.Close()
        End Try
        Return tbl
    End Function

    Public Function ListarEspecificoIgual(ByVal sql As String)
        con = New MySqlConnection()
        Try
            con.Open()
            adpt = New MySqlDataAdapter(sql, con)
            tbl.Clear()
            adpt.Fill(tbl)
        Catch ex As Exception
            MsgBox("Erro ao listar os dados " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        Finally
            con.Close()
        End Try
        Return tbl
    End Function
    Public Function getcount(ByVal sql As String) As Integer
        con = New MySqlConnection()
        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
        Catch ex As Exception
            MsgBox("Ocorreu um erro ao contar os registos " & ex.Message)
        Finally
            con.Close()
        End Try
        Return cmd.ExecuteScalar()
    End Function
    Public Sub ListarProdutos(sql As String)
        frmListarProdutos.dgListaFuncionarios.Rows.Clear()
        Dim i As Integer
        con = New MySqlConnection(strCon)
        con.Open()
        Try
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += i
                frmListarProdutos.dgListaFuncionarios.Rows.Add(dr.Item("id").ToString, dr.Item("designacao").ToString, dr.Item("nome_generico").ToString, dr.Item("categoria").ToString, dr.Item("stock actual").ToString, dr.Item("preco compra").ToString, dr.Item("preco venda").ToString, dr.Item("qtd_cx").ToString, dr.Item("validade").ToString, dr.Item("pais_origem").ToString, "Editar", "Remover")
            End While
        Catch ex As Exception
            dr.Close()
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Public Sub ListarEntradaProduto(sql As String)
        frmListarEntradasDoDia.dgEntradaProdutos.Rows.Clear()
        Dim i As Integer
        con = New MySqlConnection(strCon)
        con.Open()
        Try
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += i
                frmListarEntradasDoDia.dgEntradaProdutos.Rows.Add(dr.Item("id").ToString, dr.Item("designacao").ToString, dr.Item("tipo_entrada").ToString, dr.Item("origem").ToString, dr.Item("qtd_introduzir").ToString, dr.Item("total_introduzir").ToString, dr.Item("qtd_por_cx").ToString, dr.Item("preco_compra").ToString, dr.Item("preco_venda").ToString, "Editar", "Remover")
            End While
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro: " + ex.Message)
        Finally
            dr.Close()
            con.Close()

        End Try
    End Sub
    Public Sub ListarSaidaProduto(sql As String)
        frmListarSaidasDoDia.dgListaVendas.Rows.Clear()
        Dim i As Integer
        con = New MySqlConnection(strCon)
        con.Open()
        Try
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += i
                frmListarSaidasDoDia.dgListaVendas.Rows.Add(dr.Item("nrvenda").ToString, dr.Item("cliente").ToString, dr.Item("nuit").ToString, dr.Item("contacto").ToString, dr.Item("totalgeral").ToString, "Editar", "Remover")
            End While
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro: " + ex.Message)
        Finally
            dr.Close()
            con.Close()

        End Try
    End Sub
    Public Sub ListarProdutosPorNome(sql As String)
        frmEntradaProdutos.dgPesquisar.Rows.Clear()
        Dim i As Integer
        con = New MySqlConnection(strCon)
        con.Open()
        Try
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += i
                frmEntradaProdutos.dgPesquisar.Rows.Add(dr.Item("id").ToString, dr.Item("designacao").ToString, dr.Item("pais_origem").ToString, dr.Item("preco_venda").ToString, dr.Item("preco_compra").ToString, dr.Item("qtd_cx").ToString, "Seleccionar")
            End While
        Catch ex As Exception
            dr.Close()
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Public Sub ListarProdutosPorNomeSaida(sql As String)
        frmSaidaProdutos.dgPesquisar.Rows.Clear()
        Dim i As Integer
        con = New MySqlConnection(strCon)
        con.Open()
        Try
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += i
                frmSaidaProdutos.dgPesquisar.Rows.Add(dr.Item("id").ToString, dr.Item("designacao").ToString, dr.Item("pais_origem").ToString, dr.Item("preco_venda").ToString, dr.Item("preco_compra").ToString, dr.Item("qtd_cx").ToString, "Seleccionar")
            End While
        Catch ex As Exception
            dr.Close()
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Public Sub ListarItensDaVenda(sql As String)
        frmSaidaProdutos.dgVendaItens.Rows.Clear()
        Dim i As Integer
        con = New MySqlConnection(strCon)
        con.Open()
        Try
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += i
                frmSaidaProdutos.dgVendaItens.Rows.Add(dr.Item("id").ToString, dr.Item("produto_id").ToString, dr.Item("designacao").ToString, dr.Item("qtd").ToString, dr.Item("precounitario").ToString, dr.Item("totalunitario").ToString, dr.Item("desconto").ToString, "Editar", "Remover")
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub
    Public Sub ListarDetalhesDaVenda(sql As String)
        frmSaidaProdutos.dgVendaItens.Rows.Clear()
        Dim i As Integer
        con = New MySqlConnection(strCon)
        con.Open()
        Try
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += i
                frmSaidaProdutos.dgVendaItens.Rows.Add(dr.Item("artigo").ToString, dr.Item("produtoid").ToString, dr.Item("designacao").ToString, dr.Item("precounitario").ToString, dr.Item("qtd").ToString, dr.Item("desconto").ToString, dr.Item("totalunitario").ToString, "Editar", "Remover")
            End While
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub
    Public Sub ListarColaboradores(sql As String)

        'frmListarColaborador.dgListaFuncionarios.Rows.Clear()

        Dim i As Integer
        con = New MySqlConnection(strCon)
        con.Open()
        Try
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += i
                ' frmListarColaborador.dgListaFuncionarios.Rows.Add(dr.Item("id").ToString, dr.Item("nome").ToString, dr.Item("sexo").ToString, dr.Item("funcao").ToString, dr.Item("salario").ToString, dr.Item("salario liquido").ToString, dr.Item("inss").ToString, dr.Item("irps").ToString, dr.Item("total receber").ToString, "Editar", "Remover")
            End While
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro: " + ex.Message)
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub
    Public Sub ListarBeneficio(sql As String)

        'frmBonificacoes.dgListarBeneficio.Rows.Clear()

        Dim i As Integer
        con = New MySqlConnection(strCon)
        con.Open()
        Try
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += i
                ' frmBonificacoes.dgListarBeneficio.Rows.Add(dr.Item("id").ToString, dr.Item("designacao").ToString, "Editar", "Remover")
            End While
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao listar os beneficios: " + ex.Message)
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub
    Public Sub ListarDesconto(sql As String)

        'frmBonificacoes.dgListarDescontos.Rows.Clear()

        Dim i As Integer
        con = New MySqlConnection(strCon)
        con.Open()
        Try
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += i
                ' frmBonificacoes.dgListarDescontos.Rows.Add(dr.Item("id").ToString, dr.Item("designacao").ToString, "Editar", "Remover")
            End While
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao listar os descontos: " + ex.Message)
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub
    Public Sub ListarCategoria(sql As String)

        frmCadastrarCategoria.dgListarCategoria.Rows.Clear()

        Dim i As Integer
        con = New MySqlConnection(strCon)
        con.Open()
        Try
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += i
                frmCadastrarCategoria.dgListarCategoria.Rows.Add(dr.Item("id").ToString, dr.Item("designacao").ToString, "Editar", "Remover")
            End While
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao listar os descontos: " + ex.Message)
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub
    Public Sub ListarUtilizadores(sql As String)

        ' frmGerirUtilizadores.dgListarUtilizadores.Rows.Clear()

        Dim i As Integer
        con = New MySqlConnection(strCon)
        con.Open()
        Try
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += i
                ' frmGerirUtilizadores.dgListarUtilizadores.Rows.Add(dr.Item("ID").ToString, dr.Item("Utilizador").ToString, dr.Item("Password").ToString, dr.Item("Nome").ToString, dr.Item("Perfil").ToString, dr.Item("Bloqueado").ToString, dr.Item("Data bloqueio").ToString, dr.Item("Data criacao").ToString, "Editar", "Remover")
            End While
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro ao listar os utilizadores: " + ex.Message)
        Finally
            dr.Close()
            con.Close()
        End Try
    End Sub
    Public Function VerificaSeExiste(ByVal sql As String)
        ' utilizador = frmSplash.txtUser.Text
        con = New MySqlConnection(strCon)
        'existe = 1
        Try
            con.Open()
            adpt = New MySqlDataAdapter(sql, con)
            dt = New DataTable
            adpt.Fill(dt)
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    utilizador = row("Utilizador").ToString
                    perfil = row("Perfil")

                    ' MessageBox.Show("Utilizador existe")
                    existe = 1

                Next
            Else
                MessageBox.Show("Utilizador não existe")
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        Finally
            con.Close()
        End Try
        Return dt
    End Function
    Public Function VerificaSeEstaBloqueado(ByVal sql As String)
        ' utilizador = frmSplash.txtUser.Text
        con = New MySqlConnection(strCon)

        Try
            con.Open()
            adpt = New MySqlDataAdapter(sql, con)
            dt = New DataTable
            adpt.Fill(dt)
            If dt.Rows.Count > 0 Then
                For Each row As DataRow In dt.Rows
                    'utilizador = row("user").ToString
                    If row("user") = utilizador And row("bloqueado") = True Then
                        MsgBox("O utilizador: " & utilizador & " está bloqueado... O sistema será encerrado!", vbCritical, "Contacte o suporte técnico")
                        End
                    Else
                        '      MessageBox.Show("Utilizador não esta bloqueado")
                    End If

                    existe = 1
                Next
            Else

            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        Finally
            con.Close()
        End Try
        Return dt
    End Function
    Public Function VerificaSeProduto(ByVal sql As String)

        con = New MySqlConnection(strCon)
        Try
            con.Open()
            cmd = New MySqlCommand(sql, con)
            existe = cmd.ExecuteScalar
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        Finally
            con.Close()
        End Try
        'Return VerificaSeProduto
    End Function
    'Public Sub CarregarImagem()
    '    Dim cn As New MySqlConnection(strCon)
    '    Try
    '        cn.Open()
    '        daImagem = New MySqlDataAdapter
    '        daImagem.SelectCommand = New MySqlCommand("Select * FROM funcionario_foto", cn)

    '        dsImagem = New DataSet("dsimagem")
    '        daImagem.Fill(dsImagem)

    '        Dim dataTable As DataTable = dsImagem.Tables(0)

    '        If frmCadastrarColaborador.pbPhoto.Image IsNot Nothing Then
    '            frmCadastrarColaborador.pbPhoto.Image.Dispose()
    '        End If

    '        Dim fsImage As New FileStream("image.jpg", FileMode.Create)

    '        For Each datarow As DataRow In dataTable.Rows
    '            If datarow(0).ToString() = frmCadastrarColaborador.txtBuscarDados.Text Then
    '                Dim blob As Byte() = DirectCast(datarow(1), Byte())
    '                fsImage.Write(blob, 0, blob.Length)
    '                fsImage.Close()
    '                fsImage = Nothing
    '                frmCadastrarColaborador.pbPhoto.Image = Image.FromFile("image.jpg")
    '                frmCadastrarColaborador.pbPhoto.SizeMode = PictureBoxSizeMode.StretchImage
    '                frmCadastrarColaborador.pbPhoto.Refresh()
    '            End If
    '        Next
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    'fsImage = Nothing
    'End Sub
    'Public Sub SalvarImagem()
    '    Try
    '        If imgnome <> "" Then
    '            Dim fs As FileStream

    '            fs = New FileStream(imgnome, FileMode.Open, FileAccess.Read)
    '            Dim picByte As Byte() = New Byte(fs.Length - 1) {}
    '            fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
    '            fs.Close()

    '            Dim CN As New MySqlConnection(strCon)
    '            CN.Open()
    '            Dim strSQL As String
    '            strSQL = "INSERT INTO funcionario_foto(id, foto) VALUES (" & funcionario_id & ", " & " @Img)"

    '            Dim imgParam As New MySqlParameter

    '            imgParam.MySqlDbType = MySqlDbType.Binary
    '            imgParam.ParameterName = "Img"
    '            imgParam.Value = picByte

    '            Dim cmd As New MySqlCommand(strSQL, CN)
    '            cmd.Parameters.Add(imgParam)
    '            cmd.ExecuteNonQuery()

    '            cmd.Dispose()
    '            CN.Close()
    '            CN.Dispose()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    'Public Sub SalvarImagemUser()
    '    Try
    '        If imgnome <> "" Then
    '            Dim fs As FileStream

    '            fs = New FileStream(imgnome, FileMode.Open, FileAccess.Read)
    '            Dim picByte As Byte() = New Byte(fs.Length - 1) {}
    '            fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length))
    '            fs.Close()

    '            Dim CN As New MySqlConnection(strCon)
    '            CN.Open()
    '            Dim strSQL As String
    '            strSQL = "INSERT INTO utilizador_foto(id, foto) VALUES (" & funcionario_id & ", " & " @Img)"

    '            Dim imgParam As New MySqlParameter

    '            imgParam.MySqlDbType = MySqlDbType.Binary
    '            imgParam.ParameterName = "Img"
    '            imgParam.Value = picByte

    '            Dim cmd As New MySqlCommand(strSQL, CN)
    '            cmd.Parameters.Add(imgParam)
    '            cmd.ExecuteNonQuery()
    '            cmd.Dispose()
    '            CN.Close()
    '            CN.Dispose()
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Public Sub AcessoSistema(ByVal sql As String)
        con = New MySqlConnection(strCon)
        Try
            con.Open()
            Dim cmd = New MySqlCommand(sql, con)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            If dr.Read = False Then
                If contaTentativasAcesso <= 2 Then
                    contaTentativasAcesso = contaTentativasAcesso + 1
                    MsgBox("Senha invalida, verifica, tentativa: " & contaTentativasAcesso, vbCritical, "Erro")
                    'frmSplash.txtPass.Text = ""
                    ' frmSplash.txtPass.Focus()
                    Exit Sub
                End If
                If contaTentativasAcesso = 3 Then
                    ' MsgBox("Atingiu o limite de tentativas, o utilizador:<< " & frmSplash.txtUser.Text & " >>  será bloqueado", vbCritical, "Credenciais errados")
                    'acessoBLL = New AcessoBLL
                    '  acessoBLL.BloqueiaUtilizador(utilizador)
                    'MsgBox("Utilizador bloqueado") '
                    End
                    'limite = True
                End If
            Else
                'MsgBox("Seja Bem vindo: " & frmAcesso.txtUser.Text & "", vbInformation, ".::ACESSO::.")
                'frmSplash.Hide()
                'mdiPrincipal.Show()
                'mdiPrincipal.lblNomeUsuario.Text = frmSplash.txtUser.Text
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

End Class
