'************************************************
'* Generated by: 
'* Date: 04/03/2004 02:15:03
'* Goal: Create User Service Class for HT_NGAY_TRONG_TUAN
'************************************************

option Explicit On
option Strict On

Imports IP.Core.IPData
Imports IP.Core.IPCommon
Imports IP.Core.IPUserService
Imports System.Data.SqlClient

Public Class US_HT_NGAY_TRONG_TUAN
	Inherits US_Object

	Private Const c_TableName as String = "HT_NGAY_TRONG_TUAN"
#Region "Public Properties"
	Public Property dcID() As Decimal
		Get
			Return CNull.RowNVLDecimal(pm_objdr, "ID")
		End Get
		Set(ByVal Value As Decimal)
			pm_objDR.Item("ID") = Value
		End Set
	End Property

	Public Function IsIDNull() As Boolean
		Return pm_objDR.IsNull("ID")
	End Function

	Public Sub SetIDNull()
		pm_objDR("ID") = System.Convert.DBNull
	End Sub

	Public Property strMa() As String
		Get
			Return CNull.RowNVLString(pm_objDR, "Ma")
		End Get
		Set(ByVal Value As String)
			pm_objDR.Item("Ma") = Value
		End Set
	End Property

	Public Function IsMaNull() As Boolean
		Return pm_objDR.IsNull("Ma")
	End Function

	Public Sub SetMaNull()
		pm_objDR("Ma") = System.Convert.DBNull
	End Sub

	Public Property strNGAY_TRONG_TUAN() As String
		Get
			Return CNull.RowNVLString(pm_objDR, "NGAY_TRONG_TUAN")
		End Get
		Set(ByVal Value As String)
			pm_objDR.Item("NGAY_TRONG_TUAN") = Value
		End Set
	End Property

	Public Function IsNGAY_TRONG_TUANNull() As Boolean
		Return pm_objDR.IsNull("NGAY_TRONG_TUAN")
	End Function

	Public Sub SetNGAY_TRONG_TUANNull()
		pm_objDR("NGAY_TRONG_TUAN") = System.Convert.DBNull
	End Sub

	Public Property dcSTT_NGAY() As Decimal
		Get
			Return CNull.RowNVLDecimal(pm_objdr, "STT_NGAY")
		End Get
		Set(ByVal Value As Decimal)
			pm_objDR.Item("STT_NGAY") = Value
		End Set
	End Property

	Public Function IsSTT_NGAYNull() As Boolean
		Return pm_objDR.IsNull("STT_NGAY")
	End Function

	Public Sub SetSTT_NGAYNull()
		pm_objDR("STT_NGAY") = System.Convert.DBNull
	End Sub

	Public Property strNGAY_LAM_VIEC_YN() As String
		Get
			Return CNull.RowNVLString(pm_objDR, "NGAY_LAM_VIEC_YN")
		End Get
		Set(ByVal Value As String)
			pm_objDR.Item("NGAY_LAM_VIEC_YN") = Value
		End Set
	End Property

	Public Function IsNGAY_LAM_VIEC_YNNull() As Boolean
		Return pm_objDR.IsNull("NGAY_LAM_VIEC_YN")
	End Function

	Public Sub SetNGAY_LAM_VIEC_YNNull()
		pm_objDR("NGAY_LAM_VIEC_YN") = System.Convert.DBNull
	End Sub

#End Region
#Region "Init Functions"
	Public Sub New()
		pm_objDS = New DS_HT_NGAY_TRONG_TUAN()
		pm_strTableName = c_TableName
		pm_objDR = pm_objDS.Tables(pm_strTableName).NewRow()
	End Sub

	Public Sub New(ByVal i_objDR As DataRow)
		Me.New()
		Me.DataRow2Me(i_objDR)
	End Sub

	Public Sub New(ByVal i_dbID As Decimal)
		pm_objDS = New DS_HT_NGAY_TRONG_TUAN()
		pm_strTableName = c_TableName
		Me.FillDataset(pm_objDS, "Where ID = " & Str(i_dbID))
		pm_objDR = getRowClone(pm_objds.Tables(pm_strTableName).Rows(0))
	End Sub
#End Region
End Class