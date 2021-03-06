﻿Imports Modelos
Imports Capa_Entidad
Public Class ComprobanteBL
    Dim Datos As New ComprobanteDAO

    Public Function comprobante_Cuenta() As DataTable
        Return Datos.Comprobante_mostrar_cuenta()
    End Function
    Public Function comprobante_Cuenta_n() As DataTable
        Return Datos.Comprobante_mostrar_cuenta_n()
    End Function
    'Public Function comprobante_cuenta_filtrar_nombre(ByVal entCom As Comprobante) As DataTable
    '    Return Datos.Comprobante_filtrar_cuenta_n(entCom)
    'End Function
    Public Function comprobante_mostrar_moneda() As DataTable
        Return Datos.Comprobante_mostrar_moneda()
    End Function
    Public Function comprobante_mostrar_tipodoc() As DataTable
        Return Datos.Comprobante_mostrar_tipodoc()
    End Function
    Public Function comprobante_mostrar_auxiliar() As DataTable
        Return Datos.Comprobante_mostrar_auxiliar()
    End Function
    Public Function comprobante_razon_social(ByVal entCom As Comprobante) As String
        Return Datos.razon_social(entCom)
    End Function
    Public Function comprobante_diario_autogenerado() As String
        Return Datos.comprobante_diario_autogenerado()
    End Function
    'Public Function comprobante_cajabanco_autogenerado() As String
    '    Return Datos.comprobante_cajabanco_autogenerado()
    'End Function
    'Public Function comprobante_registro_autogenerado() As String
    '    Return Datos.comprobante_registocompra_autogenerado()
    'End Function
    Public Function comprobante_autogenerado_registro(ByVal pre As Object) As String
        Return Datos.comprobante_autogenerado_registro(pre)
    End Function
    Public Function comprobante_cabecera_CRU(ByVal entCom As Comprobante) As Integer
        Dim verificar As Integer
        verificar = Datos.comprobante_cabecera_CRU(entCom)
        Return verificar
    End Function
    'Public Function comprobante_cabecera_register_cb(ByVal entCom As Comprobante) As Integer
    '    Dim verificar As Integer
    '    verificar = Datos.comprobante_cabecera_register_cb(entCom)
    '    Return verificar
    'End Function
    Public Function comprobante_detalle_CRU(ByVal entCom As Comprobante)
        Dim verificar As Integer
        verificar = Datos.comprobante_detalle_CRU(entCom)
        Return verificar
    End Function
    'Public Function comprobante_detalle_register_cb(ByVal entCom As Comprobante)
    '    Dim verificar As Integer
    '    verificar = Datos.comprobante_detalle_register_cb(entCom)
    '    Return verificar
    'End Function

    'Public Function comprobante_detalle_actualizar(ByVal entCom As Comprobante)
    '    Dim verificar As Integer
    '    verificar = Datos.comprobante_detalle_actualizar(entCom)
    '    Return verificar
    'End Function
    'Public Function comprobante_detalle_autogenerado(ByVal entCom As Comprobante) As String
    '    Return Datos.comprobante_detalle_autogenerado(entCom)
    'End Function
    Public Function registro_compra_CRU(ByVal entCom As Comprobante)
        Dim verificar As Integer
        verificar = Datos.registro_compra_CRU(entCom)
        Return verificar
    End Function
    Public Function Comprobante_cebecera_llenar(ByVal entCom As Comprobante) As DataTable
        Return Datos.Comprobante_cebecera_llenar(entCom)
    End Function
    Public Function Comprobante_detalle_llenar(ByVal entCom As Comprobante) As DataTable
        Return Datos.Comprobante_detalle_llenar(entCom)
    End Function
End Class
