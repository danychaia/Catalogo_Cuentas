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

Partial Public Class tbl_mf_bancos
    Public Property id_banco As Integer
    Public Property id_empresa As Integer
    Public Property id_banco_1 As String
    Public Property bc_id_externo As String
    Public Property bc_fecha_cierre As Date
    Public Property bc_fecha As Date
    Public Property id_estado As Integer

    Public Overridable Property tbl_mf_conciliacion As ICollection(Of tbl_mf_conciliacion) = New HashSet(Of tbl_mf_conciliacion)
    Public Overridable Property tbl_mf_cuenta As ICollection(Of tbl_mf_cuenta) = New HashSet(Of tbl_mf_cuenta)

End Class
