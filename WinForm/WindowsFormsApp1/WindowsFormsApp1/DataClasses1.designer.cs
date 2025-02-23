﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Countries")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertCountry(Country instance);
    partial void UpdateCountry(Country instance);
    partial void DeleteCountry(Country instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::WindowsFormsApp1.Properties.Settings.Default.CountriesConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Country> Country
		{
			get
			{
				return this.GetTable<Country>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Country")]
	public partial class Country : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _CountryName;
		
		private string _CapitalName;
		
		private int _NumberOfPeople;
		
		private int _Area;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnCountryNameChanging(string value);
    partial void OnCountryNameChanged();
    partial void OnCapitalNameChanging(string value);
    partial void OnCapitalNameChanged();
    partial void OnNumberOfPeopleChanging(int value);
    partial void OnNumberOfPeopleChanged();
    partial void OnAreaChanging(int value);
    partial void OnAreaChanged();
    #endregion
		
		public Country()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CountryName", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string CountryName
		{
			get
			{
				return this._CountryName;
			}
			set
			{
				if ((this._CountryName != value))
				{
					this.OnCountryNameChanging(value);
					this.SendPropertyChanging();
					this._CountryName = value;
					this.SendPropertyChanged("CountryName");
					this.OnCountryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CapitalName", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string CapitalName
		{
			get
			{
				return this._CapitalName;
			}
			set
			{
				if ((this._CapitalName != value))
				{
					this.OnCapitalNameChanging(value);
					this.SendPropertyChanging();
					this._CapitalName = value;
					this.SendPropertyChanged("CapitalName");
					this.OnCapitalNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NumberOfPeople", DbType="Int NOT NULL")]
		public int NumberOfPeople
		{
			get
			{
				return this._NumberOfPeople;
			}
			set
			{
				if ((this._NumberOfPeople != value))
				{
					this.OnNumberOfPeopleChanging(value);
					this.SendPropertyChanging();
					this._NumberOfPeople = value;
					this.SendPropertyChanged("NumberOfPeople");
					this.OnNumberOfPeopleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Area", DbType="Int NOT NULL")]
		public int Area
		{
			get
			{
				return this._Area;
			}
			set
			{
				if ((this._Area != value))
				{
					this.OnAreaChanging(value);
					this.SendPropertyChanging();
					this._Area = value;
					this.SendPropertyChanged("Area");
					this.OnAreaChanged();
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
