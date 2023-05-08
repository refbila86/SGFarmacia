
Module modGeral
    Public ano_id, mes_id, categoria_id, produto_id, folha_mes_id, c, folha_de_salario_id, funcionario_id, stock_actual, saida_id, entrada_id, provincia_id, salario_id, Faltas_, Dias_Trabalhados_, Pagamento_Diario_, Dias_Trabalho_, existe, tipo_contrato, funcao_id, beneficio_id, desconto_id, contrato_id_ As Integer
    Public Nome_Completo, Categoria_, nr_venda, strmessage, aprovado, folha_gerada, contaTentativasAcesso, erro, perfil, utilizador, acao, data_inicio, data_fim, artigo As String
    Public Salario_Base_, Salario_Liquido_, qtd_retirar, Alimentacao_, Combustivel_, Bonus_, Total_Subsidio_, INSS_, IRPS_, O_Despesas_, Total_Despesas_, Salario_Receber_ As Double
    Dim i As Integer
    'Dim strmessage As String
    Public encontrou, folha_salario, limite As Boolean


    Function SoLETRAS(ByVal KeyAscii As Integer) As Integer
        'Transformar letras minusculas em Maiúsculas
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
        ' Intercepta um código ASCII recebido e admite somente letras
        If InStr("AÃÁBCÇDEÉÊFGHIÍJKLMNOPQRSTUÚVWXYZ", Chr(KeyAscii)) = 0 Then
            SoLETRAS = 0
        Else
            SoLETRAS = KeyAscii
        End If
        ' teclas adicionais permitidas
        If KeyAscii = 8 Then SoLETRAS = KeyAscii ' Backspace
        If KeyAscii = 13 Then SoLETRAS = KeyAscii ' Enter
        If KeyAscii = 32 Then SoLETRAS = KeyAscii ' Espace
    End Function

    Function SoNumeros(ByVal Keyascii As Short) As Short
        If InStr("1234567890", Chr(Keyascii)) = 0 Then
            SoNumeros = 0
        Else
            SoNumeros = Keyascii
        End If
        Select Case Keyascii
            Case 8
                SoNumeros = Keyascii
            Case 13
                SoNumeros = Keyascii
            Case 32
                SoNumeros = Keyascii
        End Select
    End Function
End Module
