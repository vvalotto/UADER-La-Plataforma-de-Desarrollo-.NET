﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.269
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfDemo
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.Runtime.Serialization;
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
				base(global::WcfDemo.Properties.Settings.Default.ProyectosConnectionString, mappingSource)
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
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Clientes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDCliente;
		
		private string _Nombre;
		
		private int _IDContacto;
		
		private string _Calle;
		
		private string _Numero;
		
		private string _Piso;
		
		private string _Departamento;
		
		private string _Cuidad;
		
		private string _Provincia;
		
		private string _Pais;
		
		private string _Telefono;
		
		private string _Web;
		
		private EntitySet<Proyectos> _Proyectos;
		
		private bool serializing;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDClienteChanging(int value);
    partial void OnIDClienteChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnIDContactoChanging(int value);
    partial void OnIDContactoChanged();
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
    #endregion
		
		public Clientes()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCliente", DbType="Int NOT NULL", IsPrimaryKey=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
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
					this.OnIDClienteChanging(value);
					this.SendPropertyChanging();
					this._IDCliente = value;
					this.SendPropertyChanged("IDCliente");
					this.OnIDClienteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDContacto", DbType="Int NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public int IDContacto
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Calle", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Numero", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=5)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Piso", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=6)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Departamento", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=7)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cuidad", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=8)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Provincia", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=9)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pais", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=10)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Telefono", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=11)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Web", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=12)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Clientes_Proyectos", Storage="_Proyectos", ThisKey="IDCliente", OtherKey="IDCliente")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=13, EmitDefaultValue=false)]
		public EntitySet<Proyectos> Proyectos
		{
			get
			{
				if ((this.serializing 
							&& (this._Proyectos.HasLoadedOrAssignedValues == false)))
				{
					return null;
				}
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
		
		private void Initialize()
		{
			this._Proyectos = new EntitySet<Proyectos>(new Action<Proyectos>(this.attach_Proyectos), new Action<Proyectos>(this.detach_Proyectos));
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
		
		[global::System.Runtime.Serialization.OnSerializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerializing(StreamingContext context)
		{
			this.serializing = true;
		}
		
		[global::System.Runtime.Serialization.OnSerializedAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnSerialized(StreamingContext context)
		{
			this.serializing = false;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Proyectos")]
	[global::System.Runtime.Serialization.DataContractAttribute()]
	public partial class Proyectos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _IDProyecto;
		
		private string _Nombre;
		
		private string _Descripcion;
		
		private int _IDCliente;
		
		private EntityRef<Clientes> _Clientes;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDProyectoChanging(int value);
    partial void OnIDProyectoChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    partial void OnDescripcionChanging(string value);
    partial void OnDescripcionChanged();
    partial void OnIDClienteChanging(int value);
    partial void OnIDClienteChanged();
    #endregion
		
		public Proyectos()
		{
			this.Initialize();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDProyecto", DbType="Int NOT NULL", IsPrimaryKey=true)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=1)]
		public int IDProyecto
		{
			get
			{
				return this._IDProyecto;
			}
			set
			{
				if ((this._IDProyecto != value))
				{
					this.OnIDProyectoChanging(value);
					this.SendPropertyChanging();
					this._IDProyecto = value;
					this.SendPropertyChanged("IDProyecto");
					this.OnIDProyectoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=2)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descripcion", DbType="VarChar(200)")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=3)]
		public string Descripcion
		{
			get
			{
				return this._Descripcion;
			}
			set
			{
				if ((this._Descripcion != value))
				{
					this.OnDescripcionChanging(value);
					this.SendPropertyChanging();
					this._Descripcion = value;
					this.SendPropertyChanged("Descripcion");
					this.OnDescripcionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCliente", DbType="Int NOT NULL")]
		[global::System.Runtime.Serialization.DataMemberAttribute(Order=4)]
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
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Clientes_Proyectos", Storage="_Clientes", ThisKey="IDCliente", OtherKey="IDCliente", IsForeignKey=true)]
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
						this._IDCliente = value.IDCliente;
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
		
		private void Initialize()
		{
			this._Clientes = default(EntityRef<Clientes>);
			OnCreated();
		}
		
		[global::System.Runtime.Serialization.OnDeserializingAttribute()]
		[global::System.ComponentModel.EditorBrowsableAttribute(EditorBrowsableState.Never)]
		public void OnDeserializing(StreamingContext context)
		{
			this.Initialize();
		}
	}
}
#pragma warning restore 1591
