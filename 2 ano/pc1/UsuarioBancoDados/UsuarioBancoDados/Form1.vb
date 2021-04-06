﻿Public Class Form1
    Dim novo As Boolean = True
    Dim usuario As New Usuario
    Dim bd As New BdUsuario

    Private Sub telaToUsuario()
        usuario.Nome = txtnome.Text
        usuario.Senha = txtsenha.Text
        usuario.User = txtuser.Text
    End Sub
    Private Sub usuarioToTela()
        txtnome.Text = usuario.Nome
        txtsenha.Text = usuario.Senha
        txtuser.Text = usuario.User
    End Sub
    Private Sub limpaTela()
        txtnome.Text = ""
        txtsenha.Text = ""
        txtuser.Text = ""
    End Sub
    Private Sub btnnovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        novo = True
        limpaTela()
    End Sub
    Private Sub btnsalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvar.Click
        telaToUsuario()
        If novo Then
            bd.inserir(usuario)
        Else
            bd.atualizar(usuario)
        End If
        novo = False
    End Sub
    Private Sub btnexcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        telaToUsuario()
        bd.excluir(usuario.User)
        limpaTela()
    End Sub
    Private Sub btnlocalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlocalizar.Click
        Dim busca As String = InputBox("Digite o usuário a localizar")
        usuario = bd.localizar(busca)
        If Not usuario.Nome.Equals("") Then
            usuarioToTela()
            novo = False
        Else
            MsgBox("Usuário não Existente", vbExclamation + vbOKOnly, "Atenção")
            limpaTela()
            novo = True
        End If
    End Sub
End Class
