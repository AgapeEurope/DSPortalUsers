﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18051
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection

Namespace DSPU
	
	<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="DataserverPortalUserEntities")>  _
	Partial Public Class DSPUDataContext
		Inherits System.Data.Linq.DataContext
		
		Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
		
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub InsertDataserverPortalUser(instance As DataserverPortalUser)
    End Sub
    Partial Private Sub UpdateDataserverPortalUser(instance As DataserverPortalUser)
    End Sub
    Partial Private Sub DeleteDataserverPortalUser(instance As DataserverPortalUser)
    End Sub
    Partial Private Sub InsertPortal(instance As Portal)
    End Sub
    Partial Private Sub UpdatePortal(instance As Portal)
    End Sub
    Partial Private Sub DeletePortal(instance As Portal)
    End Sub
    Partial Private Sub InsertPortalInfoe(instance As PortalInfoe)
    End Sub
    Partial Private Sub UpdatePortalInfoe(instance As PortalInfoe)
    End Sub
    Partial Private Sub DeletePortalInfoe(instance As PortalInfoe)
    End Sub
    #End Region
		
		Public Sub New()
			MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("DataserverPortalUserEntitiesConnectionString").ConnectionString, mappingSource)
			OnCreated
		End Sub
		
		Public Sub New(ByVal connection As String)
			MyBase.New(connection, mappingSource)
			OnCreated
		End Sub
		
		Public Sub New(ByVal connection As System.Data.IDbConnection)
			MyBase.New(connection, mappingSource)
			OnCreated
		End Sub
		
		Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated
		End Sub
		
		Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated
		End Sub
		
		Public ReadOnly Property DataserverPortalUsers() As System.Data.Linq.Table(Of DataserverPortalUser)
			Get
				Return Me.GetTable(Of DataserverPortalUser)
			End Get
		End Property
		
		Public ReadOnly Property Portals() As System.Data.Linq.Table(Of Portal)
			Get
				Return Me.GetTable(Of Portal)
			End Get
		End Property
		
		Public ReadOnly Property PortalInfoes() As System.Data.Linq.Table(Of PortalInfoe)
			Get
				Return Me.GetTable(Of PortalInfoe)
			End Get
		End Property
	End Class
	
	<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.DataserverPortalUsers")>  _
	Partial Public Class DataserverPortalUser
		Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
		
		Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
		
		Private _Id As System.Guid
		
		Private _SsoCode As System.Guid
		
		Private _PortalUri As String
		
		Private _PortalName As String
		
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As System.Guid)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnSsoCodeChanging(value As System.Guid)
    End Sub
    Partial Private Sub OnSsoCodeChanged()
    End Sub
    Partial Private Sub OnPortalUriChanging(value As String)
    End Sub
    Partial Private Sub OnPortalUriChanged()
    End Sub
    Partial Private Sub OnPortalNameChanging(value As String)
    End Sub
    Partial Private Sub OnPortalNameChanged()
    End Sub
    #End Region
		
		Public Sub New()
			MyBase.New
			OnCreated
		End Sub
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", DbType:="UniqueIdentifier NOT NULL", IsPrimaryKey:=true)>  _
		Public Property Id() As System.Guid
			Get
				Return Me._Id
			End Get
			Set
				If ((Me._Id = value)  _
							= false) Then
					Me.OnIdChanging(value)
					Me.SendPropertyChanging
					Me._Id = value
					Me.SendPropertyChanged("Id")
					Me.OnIdChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SsoCode", DbType:="UniqueIdentifier NOT NULL")>  _
		Public Property SsoCode() As System.Guid
			Get
				Return Me._SsoCode
			End Get
			Set
				If ((Me._SsoCode = value)  _
							= false) Then
					Me.OnSsoCodeChanging(value)
					Me.SendPropertyChanging
					Me._SsoCode = value
					Me.SendPropertyChanged("SsoCode")
					Me.OnSsoCodeChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PortalUri", DbType:="NVarChar(MAX)")>  _
		Public Property PortalUri() As String
			Get
				Return Me._PortalUri
			End Get
			Set
				If (String.Equals(Me._PortalUri, value) = false) Then
					Me.OnPortalUriChanging(value)
					Me.SendPropertyChanging
					Me._PortalUri = value
					Me.SendPropertyChanged("PortalUri")
					Me.OnPortalUriChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PortalName", DbType:="NVarChar(MAX)")>  _
		Public Property PortalName() As String
			Get
				Return Me._PortalName
			End Get
			Set
				If (String.Equals(Me._PortalName, value) = false) Then
					Me.OnPortalNameChanging(value)
					Me.SendPropertyChanging
					Me._PortalName = value
					Me.SendPropertyChanged("PortalName")
					Me.OnPortalNameChanged
				End If
			End Set
		End Property
		
		Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
		
		Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		
		Protected Overridable Sub SendPropertyChanging()
			If ((Me.PropertyChangingEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
			End If
		End Sub
		
		Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
			If ((Me.PropertyChangedEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
	End Class
	
	<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Portals")>  _
	Partial Public Class Portal
		Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
		
		Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
		
		Private _Id As Integer
		
		Private _PortalName As String
		
		Private _PortalUri As String
		
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnPortalNameChanging(value As String)
    End Sub
    Partial Private Sub OnPortalNameChanged()
    End Sub
    Partial Private Sub OnPortalUriChanging(value As String)
    End Sub
    Partial Private Sub OnPortalUriChanged()
    End Sub
    #End Region
		
		Public Sub New()
			MyBase.New
			OnCreated
		End Sub
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
		Public Property Id() As Integer
			Get
				Return Me._Id
			End Get
			Set
				If ((Me._Id = value)  _
							= false) Then
					Me.OnIdChanging(value)
					Me.SendPropertyChanging
					Me._Id = value
					Me.SendPropertyChanged("Id")
					Me.OnIdChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PortalName", DbType:="NVarChar(MAX)")>  _
		Public Property PortalName() As String
			Get
				Return Me._PortalName
			End Get
			Set
				If (String.Equals(Me._PortalName, value) = false) Then
					Me.OnPortalNameChanging(value)
					Me.SendPropertyChanging
					Me._PortalName = value
					Me.SendPropertyChanged("PortalName")
					Me.OnPortalNameChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PortalUri", DbType:="NVarChar(MAX)")>  _
		Public Property PortalUri() As String
			Get
				Return Me._PortalUri
			End Get
			Set
				If (String.Equals(Me._PortalUri, value) = false) Then
					Me.OnPortalUriChanging(value)
					Me.SendPropertyChanging
					Me._PortalUri = value
					Me.SendPropertyChanged("PortalUri")
					Me.OnPortalUriChanged
				End If
			End Set
		End Property
		
		Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
		
		Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		
		Protected Overridable Sub SendPropertyChanging()
			If ((Me.PropertyChangingEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
			End If
		End Sub
		
		Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
			If ((Me.PropertyChangedEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
	End Class
	
	<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.PortalInfoes")>  _
	Partial Public Class PortalInfoe
		Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
		
		Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
		
		Private _Id As Integer
		
		Private _PortalId As Integer
		
		Private _NumberofWebUsers As Integer
		
		Private _Last90Days As Integer
		
		Private _Last60Days As Integer
		
		Private _Last30Days As Integer
		
		Private _DateCreated As Date
		
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnIdChanged()
    End Sub
    Partial Private Sub OnPortalIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnPortalIdChanged()
    End Sub
    Partial Private Sub OnNumberofWebUsersChanging(value As Integer)
    End Sub
    Partial Private Sub OnNumberofWebUsersChanged()
    End Sub
    Partial Private Sub OnLast90DaysChanging(value As Integer)
    End Sub
    Partial Private Sub OnLast90DaysChanged()
    End Sub
    Partial Private Sub OnLast60DaysChanging(value As Integer)
    End Sub
    Partial Private Sub OnLast60DaysChanged()
    End Sub
    Partial Private Sub OnLast30DaysChanging(value As Integer)
    End Sub
    Partial Private Sub OnLast30DaysChanged()
    End Sub
    Partial Private Sub OnDateCreatedChanging(value As Date)
    End Sub
    Partial Private Sub OnDateCreatedChanged()
    End Sub
    #End Region
		
		Public Sub New()
			MyBase.New
			OnCreated
		End Sub
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Id", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
		Public Property Id() As Integer
			Get
				Return Me._Id
			End Get
			Set
				If ((Me._Id = value)  _
							= false) Then
					Me.OnIdChanging(value)
					Me.SendPropertyChanging
					Me._Id = value
					Me.SendPropertyChanged("Id")
					Me.OnIdChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PortalId", DbType:="Int NOT NULL")>  _
		Public Property PortalId() As Integer
			Get
				Return Me._PortalId
			End Get
			Set
				If ((Me._PortalId = value)  _
							= false) Then
					Me.OnPortalIdChanging(value)
					Me.SendPropertyChanging
					Me._PortalId = value
					Me.SendPropertyChanged("PortalId")
					Me.OnPortalIdChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NumberofWebUsers", DbType:="Int NOT NULL")>  _
		Public Property NumberofWebUsers() As Integer
			Get
				Return Me._NumberofWebUsers
			End Get
			Set
				If ((Me._NumberofWebUsers = value)  _
							= false) Then
					Me.OnNumberofWebUsersChanging(value)
					Me.SendPropertyChanging
					Me._NumberofWebUsers = value
					Me.SendPropertyChanged("NumberofWebUsers")
					Me.OnNumberofWebUsersChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Last90Days", DbType:="Int NOT NULL")>  _
		Public Property Last90Days() As Integer
			Get
				Return Me._Last90Days
			End Get
			Set
				If ((Me._Last90Days = value)  _
							= false) Then
					Me.OnLast90DaysChanging(value)
					Me.SendPropertyChanging
					Me._Last90Days = value
					Me.SendPropertyChanged("Last90Days")
					Me.OnLast90DaysChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Last60Days", DbType:="Int NOT NULL")>  _
		Public Property Last60Days() As Integer
			Get
				Return Me._Last60Days
			End Get
			Set
				If ((Me._Last60Days = value)  _
							= false) Then
					Me.OnLast60DaysChanging(value)
					Me.SendPropertyChanging
					Me._Last60Days = value
					Me.SendPropertyChanged("Last60Days")
					Me.OnLast60DaysChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Last30Days", DbType:="Int NOT NULL")>  _
		Public Property Last30Days() As Integer
			Get
				Return Me._Last30Days
			End Get
			Set
				If ((Me._Last30Days = value)  _
							= false) Then
					Me.OnLast30DaysChanging(value)
					Me.SendPropertyChanging
					Me._Last30Days = value
					Me.SendPropertyChanged("Last30Days")
					Me.OnLast30DaysChanged
				End If
			End Set
		End Property
		
		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_DateCreated", DbType:="DateTime NOT NULL")>  _
		Public Property DateCreated() As Date
			Get
				Return Me._DateCreated
			End Get
			Set
				If ((Me._DateCreated = value)  _
							= false) Then
					Me.OnDateCreatedChanging(value)
					Me.SendPropertyChanging
					Me._DateCreated = value
					Me.SendPropertyChanged("DateCreated")
					Me.OnDateCreatedChanged
				End If
			End Set
		End Property
		
		Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
		
		Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
		
		Protected Overridable Sub SendPropertyChanging()
			If ((Me.PropertyChangingEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
			End If
		End Sub
		
		Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
			If ((Me.PropertyChangedEvent Is Nothing)  _
						= false) Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
	End Class
End Namespace
