﻿'------------------------------------------------------------------------------
' <auto-generated>
'    Este código se generó a partir de una plantilla.
'
'    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class FinanzasG2Entities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=FinanzasG2Entities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Property tbl_detalle_move() As DbSet(Of tbl_detalle_move)
    Public Property tbl_mf_bancos() As DbSet(Of tbl_mf_bancos)
    Public Property tbl_mf_catalogo() As DbSet(Of tbl_mf_catalogo)
    Public Property tbl_mf_conciliacion() As DbSet(Of tbl_mf_conciliacion)
    Public Property tbl_mf_cuenta() As DbSet(Of tbl_mf_cuenta)
    Public Property tbl_mf_detalle_conc() As DbSet(Of tbl_mf_detalle_conc)
    Public Property tbl_mf_detalle_partida() As DbSet(Of tbl_mf_detalle_partida)
    Public Property tbl_mf_empresa() As DbSet(Of tbl_mf_empresa)
    Public Property tbl_mf_extracto_bancario() As DbSet(Of tbl_mf_extracto_bancario)
    Public Property tbl_mf_modeda() As DbSet(Of tbl_mf_modeda)
    Public Property tbl_mf_modulo() As DbSet(Of tbl_mf_modulo)
    Public Property tbl_mf_partida() As DbSet(Of tbl_mf_partida)
    Public Property tbl_mf_periodo_contable() As DbSet(Of tbl_mf_periodo_contable)
    Public Property tbl_mf_permisos() As DbSet(Of tbl_mf_permisos)
    Public Property tbl_mf_saldos() As DbSet(Of tbl_mf_saldos)
    Public Property tbl_mf_tipo_cuenta() As DbSet(Of tbl_mf_tipo_cuenta)
    Public Property tbl_mf_tipo_doc() As DbSet(Of tbl_mf_tipo_doc)
    Public Property tbl_mf_tipo_movimiento() As DbSet(Of tbl_mf_tipo_movimiento)
    Public Property tbl_mf_tipo_poliza() As DbSet(Of tbl_mf_tipo_poliza)
    Public Property tbl_mf_usuarios() As DbSet(Of tbl_mf_usuarios)

End Class
