using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.VisioApi
{
	///<summary>
	/// Interface LPVISIOMASTERSHORTCUT 
	/// SupportByVersion Visio, 11,12,14
	///</summary>
	[SupportByVersionAttribute("Visio", 11,12,14)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class LPVISIOMASTERSHORTCUT : COMObject
	{
		#pragma warning disable
		#region Type Information

        private static Type _type;

		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(LPVISIOMASTERSHORTCUT);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOMASTERSHORTCUT(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOMASTERSHORTCUT(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOMASTERSHORTCUT(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOMASTERSHORTCUT() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LPVISIOMASTERSHORTCUT(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVApplication Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.VisioApi.IVApplication newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVApplication;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVDocument Document
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Document", paramsArray);
				NetOffice.VisioApi.IVDocument newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVDocument;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public Int16 Index
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Index", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public Int16 ObjectType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ObjectType", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public Int16 Stat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Stat", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public string Name
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Name", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Name", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public string Prompt
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Prompt", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Prompt", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public Int16 AlignName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AlignName", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AlignName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public Int16 IconSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IconSize", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IconSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public Int32 ID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ID", paramsArray);
				return NetRuntimeSystem.Convert.ToInt32(returnItem);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public string TargetDocumentName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TargetDocumentName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TargetDocumentName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public string TargetMasterName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TargetMasterName", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TargetMasterName", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public string TargetBaseID
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TargetBaseID", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "TargetBaseID", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public string DropActions
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DropActions", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DropActions", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public string ShapeHelp
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ShapeHelp", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ShapeHelp", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public string NameU
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "NameU", paramsArray);
				return NetRuntimeSystem.Convert.ToString(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "NameU", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public Int16 IndexInStencil
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "IndexInStencil", paramsArray);
				return NetRuntimeSystem.Convert.ToInt16(returnItem);
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "IndexInStencil", paramsArray);
			}
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public stdole.Picture Icon
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Icon", paramsArray);
				stdole.Picture newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as stdole.Picture;
				return newObject;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Icon", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public void ImportIcon(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			Invoker.Method(this, "ImportIcon", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="flags">Int16 Flags</param>
		/// <param name="transparentRGB">optional object TransparentRGB</param>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public void ExportIcon(string fileName, Int16 flags, object transparentRGB)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, flags, transparentRGB);
			Invoker.Method(this, "ExportIcon", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// </summary>
		/// <param name="fileName">string FileName</param>
		/// <param name="flags">Int16 Flags</param>
		[CustomMethodAttribute]
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public void ExportIcon(string fileName, Int16 flags)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, flags);
			Invoker.Method(this, "ExportIcon", paramsArray);
		}

		/// <summary>
		/// SupportByVersion Visio 11, 12, 14
		/// </summary>
		[SupportByVersionAttribute("Visio", 11,12,14)]
		public NetOffice.VisioApi.IVWindow OpenIconWindow()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "OpenIconWindow", paramsArray);
			NetOffice.VisioApi.IVWindow newObject = NetOffice.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.VisioApi.IVWindow;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}