Imports System.Security.Authentication.ExtendedProtection

Public Class Form1

    Dim listaCurso As String
    Public Sub New()
        InitializeComponent()

        Me.Text = "Cadastro de Cursos de Extensão do Aluno"


        lblCurso.Text = "DIGITE O NOME DO CURSO DE EXTENSÃO PARA COMPENSAÇÃO DE HORAS EXTRACURRICULARES"
        btnAdicioanar.Text = "Adicionar"
        btnLimpar.Text = "Limpar"


    End Sub





    Private Sub btnAdicioanar_Click(sender As Object, e As EventArgs) Handles btnAdicioanar.Click
        Dim cursoDigitado As String = txtCurso.Text
        listaCurso = listaCurso + cursoDigitado + vbCrLf
        txtLista.Text = listaCurso

        MsgBox("Um novo curso foi adicionado: " + vbCrLf + cursoDigitado, MsgBoxStyle.Information, "CURSO ADICIONADO")

        txtCurso.Text = ("")

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click

        MsgBox("Ao clicar em LIMPAR todos os cursos que foram adicionados serão excluidos !", MsgBoxStyle.Information, "LIMPAR")

        MsgBox("Deseja prosseguir com a exclusão de todos os cursos? ", MsgBoxStyle.YesNo, "LIMPAR")

        If MsgBox("Deseja prosseguir com a exclusão de todos os cursos? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            listaCurso = ("")
            txtLista.Text = listaCurso

        ElseIf MsgBox("Deseja prosseguir com a exclusão de todos os cursos? ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            txtLista.Text = listaCurso

        End If




    End Sub

    Private Sub txtCurso_TextChanged(sender As Object, e As EventArgs) Handles txtCurso.TextChanged

    End Sub
End Class
