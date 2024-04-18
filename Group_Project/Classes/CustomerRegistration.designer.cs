﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Group_Project.Classes
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="sms")]
	public partial class CustomerRegistrationDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTbl_Customer_Details(Tbl_Customer_Details instance);
    partial void UpdateTbl_Customer_Details(Tbl_Customer_Details instance);
    partial void DeleteTbl_Customer_Details(Tbl_Customer_Details instance);
    #endregion
		
		public CustomerRegistrationDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CustomerRegistrationDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CustomerRegistrationDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CustomerRegistrationDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Tbl_Customer_Details> Tbl_Customer_Details
		{
			get
			{
				return this.GetTable<Tbl_Customer_Details>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Tbl_Customer_Details")]
	public partial class Tbl_Customer_Details : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _cust_id;
		
		private string _cust_name;
		
		private string _cust_city;
		
		private char _cust_gender;
		
		private string _cust_email;
		
		private long _cust_contact;
		
		private string _password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Oncust_idChanging(int value);
    partial void Oncust_idChanged();
    partial void Oncust_nameChanging(string value);
    partial void Oncust_nameChanged();
    partial void Oncust_cityChanging(string value);
    partial void Oncust_cityChanged();
    partial void Oncust_genderChanging(char value);
    partial void Oncust_genderChanged();
    partial void Oncust_emailChanging(string value);
    partial void Oncust_emailChanged();
    partial void Oncust_contactChanging(long value);
    partial void Oncust_contactChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    #endregion
		
		public Tbl_Customer_Details()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cust_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int cust_id
		{
			get
			{
				return this._cust_id;
			}
			set
			{
				if ((this._cust_id != value))
				{
					this.Oncust_idChanging(value);
					this.SendPropertyChanging();
					this._cust_id = value;
					this.SendPropertyChanged("cust_id");
					this.Oncust_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cust_name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string cust_name
		{
			get
			{
				return this._cust_name;
			}
			set
			{
				if ((this._cust_name != value))
				{
					this.Oncust_nameChanging(value);
					this.SendPropertyChanging();
					this._cust_name = value;
					this.SendPropertyChanged("cust_name");
					this.Oncust_nameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cust_city", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string cust_city
		{
			get
			{
				return this._cust_city;
			}
			set
			{
				if ((this._cust_city != value))
				{
					this.Oncust_cityChanging(value);
					this.SendPropertyChanging();
					this._cust_city = value;
					this.SendPropertyChanged("cust_city");
					this.Oncust_cityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cust_gender", DbType="Char(1) NOT NULL")]
		public char cust_gender
		{
			get
			{
				return this._cust_gender;
			}
			set
			{
				if ((this._cust_gender != value))
				{
					this.Oncust_genderChanging(value);
					this.SendPropertyChanging();
					this._cust_gender = value;
					this.SendPropertyChanged("cust_gender");
					this.Oncust_genderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cust_email", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string cust_email
		{
			get
			{
				return this._cust_email;
			}
			set
			{
				if ((this._cust_email != value))
				{
					this.Oncust_emailChanging(value);
					this.SendPropertyChanging();
					this._cust_email = value;
					this.SendPropertyChanged("cust_email");
					this.Oncust_emailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cust_contact", DbType="BigInt NOT NULL")]
		public long cust_contact
		{
			get
			{
				return this._cust_contact;
			}
			set
			{
				if ((this._cust_contact != value))
				{
					this.Oncust_contactChanging(value);
					this.SendPropertyChanging();
					this._cust_contact = value;
					this.SendPropertyChanged("cust_contact");
					this.Oncust_contactChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="VarChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
