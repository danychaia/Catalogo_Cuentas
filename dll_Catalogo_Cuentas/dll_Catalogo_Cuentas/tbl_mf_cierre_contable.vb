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

Partial Public Class tbl_mf_cierre_contable
    Public Property id_cierre As Integer
    Public Property cct_fecha_cierre As Date

    Public Overridable Property tbl_mf_detalle_partida As ICollection(Of tbl_mf_detalle_partida) = New HashSet(Of tbl_mf_detalle_partida)

End Class
