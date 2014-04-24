﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.34011
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modulo_4
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Proyectos")]
	public partial class ProyectosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertClientes(Clientes instance);
    partial void UpdateClientes(Clientes instance);
    partial void DeleteClientes(Clientes instance);
    partial void InsertProyectos(Proyectos instance);
    partial void UpdateProyectos(Proyectos instance);
    partial void DeleteProyectos(Proyectos instance);
    #endregion
		
		public ProyectosDataContext() : 
				base(global::Linq.Properties.Settings.Default.ProyectosConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ProyectosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProyectosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProyectosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ProyectosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Clientes> Clientes
		{
			get
			{
				return this.GetTable<Clientes>();
			}
		}
		
		public System.Data.Linq.Table<Proyectos> Proyectos
		{
			get
			{
				return this.GetTable<Proyectos>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Clientes")]
	public partial class Clientes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Nombre;
		
		private string _Calle;
		
		private string _Numero;
		
		private string _Piso;
		
		private string _Departamento;
		
		private string _Cuidad;
		
		private string _Provincia;
		
		private string _Pais;
		
		private string _Telefono;
		
		private string _Web;
		
		private System.Nullable<int> _IDContacto;
		
		private EntitySet<Proyectos> _Proyectos;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnCalleChanging(string value);
    partial void OnCalleChanged();
    partial void OnNumeroChanging(string value);
    partial void OnNumeroChanged();
    partial void OnPisoChanging(string value);
    partial void OnPisoChanged();
    partial void OnDepartamentoChanging(string value);
    partial void OnDepartamentoChanged();
    partial void OnCuidadChanging(string value);
    partial void OnCuidadChanged();
    partial void OnProvinciaChanging(string value);
    partial void OnProvinciaChanged();
    partial void OnPaisChanging(string value);
    partial void OnPaisChanged();
    partial void OnTelefonoChanging(string value);
    partial void OnTelefonoChanged();
    partial void OnWebChanging(string value);
    partial void OnWebChanged();
    partial void OnIDContactoChanging(System.Nullable<int> value);
    partial void OnIDContactoChanged();
    #endregion
		
		public Clientes()
		{
			this._Proyectos = new EntitySet<Proyectos>(new Action<Proyectos>(this.attach_Proyectos), new Action<Proyectos>(this.detach_Proyectos));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Calle", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string Calle
		{
			get
			{
				return this._Calle;
			}
			set
			{
				if ((this._Calle != value))
				{
					this.OnCalleChanging(value);
					this.SendPropertyChanging();
					this._Calle = value;
					this.SendPropertyChanged("Calle");
					this.OnCalleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Numero", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Numero
		{
			get
			{
				return this._Numero;
			}
			set
			{
				if ((this._Numero != value))
				{
					this.OnNumeroChanging(value);
					this.SendPropertyChanging();
					this._Numero = value;
					this.SendPropertyChanged("Numero");
					this.OnNumeroChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Piso", DbType="NChar(10)")]
		public string Piso
		{
			get
			{
				return this._Piso;
			}
			set
			{
				if ((this._Piso != value))
				{
					this.OnPisoChanging(value);
					this.SendPropertyChanging();
					this._Piso = value;
					this.SendPropertyChanged("Piso");
					this.OnPisoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Departamento", DbType="NChar(10)")]
		public string Departamento
		{
			get
			{
				return this._Departamento;
			}
			set
			{
				if ((this._Departamento != value))
				{
					this.OnDepartamentoChanging(value);
					this.SendPropertyChanging();
					this._Departamento = value;
					this.SendPropertyChanged("Departamento");
					this.OnDepartamentoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cuidad", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string Cuidad
		{
			get
			{
				return this._Cuidad;
			}
			set
			{
				if ((this._Cuidad != value))
				{
					this.OnCuidadChanging(value);
					this.SendPropertyChanging();
					this._Cuidad = value;
					this.SendPropertyChanged("Cuidad");
					this.OnCuidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Provincia", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string Provincia
		{
			get
			{
				return this._Provincia;
			}
			set
			{
				if ((this._Provincia != value))
				{
					this.OnProvinciaChanging(value);
					this.SendPropertyChanging();
					this._Provincia = value;
					this.SendPropertyChanged("Provincia");
					this.OnProvinciaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pais", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string Pais
		{
			get
			{
				return this._Pais;
			}
			set
			{
				if ((this._Pais != value))
				{
					this.OnPaisChanging(value);
					this.SendPropertyChanging();
					this._Pais = value;
					this.SendPropertyChanged("Pais");
					this.OnPaisChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string Telefono
		{
			get
			{
				return this._Telefono;
			}
			set
			{
				if ((this._Telefono != value))
				{
					this.OnTelefonoChanging(value);
					this.SendPropertyChanging();
					this._Telefono = value;
					this.SendPropertyChanged("Telefono");
					this.OnTelefonoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Web", DbType="NChar(50) NOT NULL", CanBeNull=false)]
		public string Web
		{
			get
			{
				return this._Web;
			}
			set
			{
				if ((this._Web != value))
				{
					this.OnWebChanging(value);
					this.SendPropertyChanging();
					this._Web = value;
					this.SendPropertyChanged("Web");
					this.OnWebChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDContacto", DbType="Int")]
		public System.Nullable<int> IDContacto
		{
			get
			{
				return this._IDContacto;
			}
			set
			{
				if ((this._IDContacto != value))
				{
					this.OnIDContactoChanging(value);
					this.SendPropertyChanging();
					this._IDContacto = value;
					this.SendPropertyChanged("IDContacto");
					this.OnIDContactoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Clientes_Proyectos", Storage="_Proyectos", ThisKey="Id", OtherKey="IDCliente")]
		public EntitySet<Proyectos> Proyectos
		{
			get
			{
				return this._Proyectos;
			}
			set
			{
				this._Proyectos.Assign(value);
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
		
		private void attach_Proyectos(Proyectos entity)
		{
			this.SendPropertyChanging();
			entity.Clientes = this;
		}
		
		private void detach_Proyectos(Proyectos entity)
		{
			this.SendPropertyChanging();
			entity.Clientes = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Proyectos")]
	public partial class Proyectos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Titulo;
		
		private int _IDCliente;
		
		private EntityRef<Clientes> _Clientes;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTituloChanging(string value);
    partial void OnTituloChanged();
    partial void OnIDClienteChanging(int value);
    partial void OnIDClienteChanged();
    #endregion
		
		public Proyectos()
		{
			this._Clientes = default(EntityRef<Clientes>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Titulo", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string Titulo
		{
			get
			{
				return this._Titulo;
			}
			set
			{
				if ((this._Titulo != value))
				{
					this.OnTituloChanging(value);
					this.SendPropertyChanging();
					this._Titulo = value;
					this.SendPropertyChanged("Titulo");
					this.OnTituloChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCliente", DbType="Int NOT NULL")]
		public int IDCliente
		{
			get
			{
				return this._IDCliente;
			}
			set
			{
				if ((this._IDCliente != value))
				{
					if (this._Clientes.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDClienteChanging(value);
					this.SendPropertyChanging();
					this._IDCliente = value;
					this.SendPropertyChanged("IDCliente");
					this.OnIDClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Clientes_Proyectos", Storage="_Clientes", ThisKey="IDCliente", OtherKey="Id", IsForeignKey=true)]
		public Clientes Clientes
		{
			get
			{
				return this._Clientes.Entity;
			}
			set
			{
				Clientes previousValue = this._Clientes.Entity;
				if (((previousValue != value) 
							|| (this._Clientes.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Clientes.Entity = null;
						previousValue.Proyectos.Remove(this);
					}
					this._Clientes.Entity = value;
					if ((value != null))
					{
						value.Proyectos.Add(this);
						this._IDCliente = value.Id;
					}
					else
					{
						this._IDCliente = default(int);
					}
					this.SendPropertyChanged("Clientes");
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

        public override string ToString()
        {
            return this.ID + " - " + this.Titulo + " - " + this.IDCliente;
        }
    
    }
}
#pragma warning restore 1591
