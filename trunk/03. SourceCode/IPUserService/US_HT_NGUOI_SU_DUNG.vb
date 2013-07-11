﻿'**********************************************
'* Generated by: TA
'* Date: 18/11/2003
'* Goal: Create User Service Class for HT_NGUOI_SU_DUNG
'************************************************

option Explicit On
Option Strict On


Imports IP.Core.IPData
Imports IP.Core.IPBusinessService
Imports IP.Core.IPCommon


Public Class US_HT_NGUOI_SU_DUNG
    Inherits US_Object
    Private Const c_TableName As String = "HT_NGUOI_SU_DUNG"

#Region "Data Structures"
    ' Các cấu trúc dữ liệu dùng trong class
    '
    Public Enum enumKet_Qua_Kiem_Tra_Dang_Nhap
        Invalid_Ten_Truy_Cap_Hoac_Mat_Khau
        Invalid_DonVi
        OK_Kiem_Tra_Dang_Nhap
    End Enum

    Enum LogonResult
        WrongPassword_OR_Name
        User_Is_Locked
        OK_Login_Succeeded
    End Enum
#End Region

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

    Public Property strTEN_TRUY_CAP() As String
        Get
            Return CNull.RowNVLString(pm_objDR, "TEN_TRUY_CAP")
        End Get
        Set(ByVal Value As String)
            pm_objDR.Item("TEN_TRUY_CAP") = Value
        End Set
    End Property

    Public Function IsTEN_TRUY_CAPNull() As Boolean
        Return pm_objDR.IsNull("TEN_TRUY_CAP")
    End Function

    Public Sub SetTEN_TRUY_CAPNull()
        pm_objDR("TEN_TRUY_CAP") = System.Convert.DBNull
    End Sub

    Public Property strTEN() As String
        Get
            Return CNull.RowNVLString(pm_objDR, "TEN")
        End Get
        Set(ByVal Value As String)
            pm_objDR.Item("TEN") = Value
        End Set
    End Property

    Public Function IsTENNull() As Boolean
        Return pm_objDR.IsNull("TEN")
    End Function

    Public Sub SetTENNull()
        pm_objDR("TEN") = System.Convert.DBNull
    End Sub

    Public Property strMAT_KHAU() As String
        Get
            Return CNull.RowNVLString(pm_objDR, "MAT_KHAU")
        End Get
        Set(ByVal Value As String)
            pm_objDR.Item("MAT_KHAU") = Value
        End Set
    End Property

    Public Function IsMAT_KHAUNull() As Boolean
        Return pm_objDR.IsNull("MAT_KHAU")
    End Function

    Public Sub SetMAT_KHAUNull()
        pm_objDR("MAT_KHAU") = System.Convert.DBNull
    End Sub

    Public Property datNGAY_TAO() As Date
        Get
            Return CNull.RowNVLDate(pm_objDR, "NGAY_TAO")
        End Get
        Set(ByVal Value As Date)
            pm_objDR.Item("NGAY_TAO") = Value
        End Set
    End Property

    Public Function IsNGAY_TAONull() As Boolean
        Return pm_objDR.IsNull("NGAY_TAO")
    End Function

    Public Sub SetNGAY_TAONull()
        pm_objDR("NGAY_TAO") = System.Convert.DBNull
    End Sub

    Public Property strNGUOI_TAO() As String
        Get
            Return CNull.RowNVLString(pm_objDR, "NGUOI_TAO")
        End Get
        Set(ByVal Value As String)
            pm_objDR.Item("NGUOI_TAO") = Value
        End Set
    End Property

    Public Function IsNGUOI_TAONull() As Boolean
        Return pm_objDR.IsNull("NGUOI_TAO")
    End Function

    Public Sub SetNGUOI_TAONull()
        pm_objDR("NGUOI_TAO") = System.Convert.DBNull
    End Sub

    Public Property strTRANG_THAI() As String
        Get
            Return CNull.RowNVLString(pm_objDR, "TRANG_THAI")
        End Get
        Set(ByVal Value As String)
            pm_objDR.Item("TRANG_THAI") = Value
        End Set
    End Property

    Public Function IsTRANG_THAINull() As Boolean
        Return pm_objDR.IsNull("TRANG_THAI")
    End Function

    Public Sub SetTRANG_THAINull()
        pm_objDR("TRANG_THAI") = System.Convert.DBNull
    End Sub

    

    

    Public Property strBUILT_IN_YN() As String
        Get
            Return CNull.RowNVLString(pm_objDR, "BUILT_IN_YN")
        End Get
        Set(ByVal Value As String)
            pm_objDR.Item("BUILT_IN_YN") = Value
        End Set
    End Property

    Public Function IsBUILT_IN_YNNull() As Boolean
        Return pm_objDR.IsNull("BUILT_IN_YN")
    End Function

    Public Sub SetBUILT_IN_YNNull()
        pm_objDR("BUILT_IN_YN") = System.Convert.DBNull
    End Sub

#End Region
#Region "Init Functions"
    Public Sub New()
        pm_objDS = New DS_HT_NGUOI_SU_DUNG
        pm_strTableName = c_TableName
        pm_objDR = pm_objDS.Tables(pm_strTableName).NewRow()
    End Sub

    Public Sub New(ByVal i_objDR As DataRow)
        Me.New()
        Me.DataRow2Me(i_objDR)
    End Sub

    Public Sub New(ByVal i_dbID As Decimal)
        pm_objDS = New DS_HT_NGUOI_SU_DUNG
        pm_strTableName = c_TableName
        Me.FillDataset(pm_objDS, "Where ID = " & Str(i_dbID))
        pm_objDR = getRowClone(pm_objds.Tables(pm_strTableName).Rows(0))
    End Sub
#End Region



#Region "PUBLIC INTERFACE"
    Public Sub InitByTenTruyCap(ByVal i_strTenTruyCap As String)
        Dim v_ds As New DS_HT_NGUOI_SU_DUNG
        Dim v_objMakCmd As New CMakeAndSelectCmd(v_ds, v_ds.HT_NGUOI_SU_DUNG.TableName)
        v_objMakCmd.AddCondition( _
            IP.Core.IPData.DBNames.HT_NGUOI_SU_DUNG.TEN_TRUY_CAP _
            , i_strTenTruyCap _
            , eKieuDuLieu.KieuString _
            , eKieuSoSanh.Bang)
        Me.FillDatasetByCommand(v_ds, v_objMakCmd.getSelectCmd)
        If (v_ds.HT_NGUOI_SU_DUNG.Rows.Count = 0) Then
            Throw New Exception("Không có tên truy cập này!")
        End If
        Me.DataRow2Me(v_ds.HT_NGUOI_SU_DUNG.Rows(0))
    End Sub
    Public Sub check_user(ByVal i_strTenTruyCap As String, _
                                    ByVal i_strMatKhau As String, _
                                    ByRef o_logonResult As LogonResult)

        Try
            Dim v_storedProc As New CStoredProc("pr_HT_Check_User_PWD")
            v_storedProc.addNVarcharInputParam("@ip_ten_truy_cap", i_strTenTruyCap)
            v_storedProc.addNVarcharInputParam("@ip_mat_khau", i_strMatKhau)

            Dim v_sqlResult As SqlClient.SqlParameter = _
                        v_storedProc.addDecimalOutputParam("@op_ket_qua", 0)
            ' thuc hien
            v_storedProc.ExecuteCommand(Me)
            Const c_WrongNamePWD As Integer = -1
            Const c_UserIsLocked As Integer = -2
            Const c_LoginOK As Integer = 0

            Select Case Convert.ToInt16(v_sqlResult.Value)
                Case c_WrongNamePWD
                    o_logonResult = LogonResult.WrongPassword_OR_Name
                Case c_UserIsLocked
                    o_logonResult = LogonResult.User_Is_Locked
                Case c_LoginOK
                    Me.InitByTenTruyCap(i_strTenTruyCap)
                    o_logonResult = LogonResult.OK_Login_Succeeded
                Case Else 'should never happen, stop if get there
                    Debug.Assert(False)
            End Select
        Catch v_ex As Exception
            Throw v_ex
        End Try
    End Sub
    Public Overrides Sub Delete()
        ' Đoạn này đang làm ẩu
        If Me.strBUILT_IN_YN = "Y" Then
            Throw New Exception("Không được xoá Admin")
        End If
        MyBase.Delete()
    End Sub
    Public Overrides Sub Insert()
        Me.datNGAY_TAO = DateTime.Now.Date
        MyBase.Insert()
    End Sub
    Public Shared Function IsHavingMA_QUYEN( _
         ByVal i_dc_user_id As Decimal _
        , ByVal i_str_ma_quyen As String) As Boolean
        Try
            Dim v_str_is_having_quyen_yn As String
            Dim v_obj_pr As New CStoredProc("pr_is_having_quyen_user")
            Dim v_obj_para As New SqlClient.SqlParameter
            Dim v_us_obj As New US_Object
            v_obj_pr.addDecimalInputParam("@ip_dc_user_id", i_dc_user_id)
            v_obj_pr.addNVarcharInputParam("@ip_str_ma_quyen", i_str_ma_quyen)

            v_obj_para = v_obj_pr.addNVarcharOutputParam("@op_str_is_having_quyen", "N")
            v_obj_pr.ExecuteCommand(v_us_obj)
            v_str_is_having_quyen_yn = CType(v_obj_para.Value, String)
            If (CIPConvert.ToBoolean(v_str_is_having_quyen_yn)) Then
                Return True
            End If
            Return False
        Catch ex As Exception
            Throw ex
            Return False
        End Try

    End Function

#End Region



End Class
