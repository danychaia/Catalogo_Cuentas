'------------------------------------------------------------------------------
' <auto-generated>
'    Este código se generó a partir de una plantilla.
'
'    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class tbl_mf_cuenta
    Public Property id_cuenta As Integer
    Public Property id_banco As Integer
    Public Property id_tipo_cuenta As Integer
    Public Property cta_num_cuenta As String
    Public Property cta_fecha As Date
    Public Property id_estado As Integer

    Public Overridable Property tbl_detalle_move As ICollection(Of tbl_detalle_move) = New HashSet(Of tbl_detalle_move)
    Public Overridable Property tbl_mf_bancos As tbl_mf_bancos
    Public Overridable Property tbl_mf_tipo_doc As ICollection(Of tbl_mf_tipo_doc) = New HashSet(Of tbl_mf_tipo_doc)
    Public Overridable Property tbl_mf_tipo_cuenta As tbl_mf_tipo_cuenta

End Class
