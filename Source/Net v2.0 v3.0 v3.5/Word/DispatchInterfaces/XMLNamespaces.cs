//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.WordApi
{
	///<summary>
	/// DispatchInterface XMLNamespaces SupportByLibrary WD11 WD12 WD14 
	///</summary>
	[SupportByLibrary("WD11","WD12","WD14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class XMLNamespaces : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespaces(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespaces(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespaces(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public XMLNamespaces()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
		public NetOffice.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				NetOffice.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD11","WD12","WD14")]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.XMLNamespace this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.XMLNamespace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.XMLNamespace;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Path">string Path</param>
		/// <param name="NamespaceURI">ref object NamespaceURI</param>
		/// <param name="Alias">ref object Alias</param>
		/// <param name="InstallForAllUsers">bool InstallForAllUsers</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public NetOffice.WordApi.XMLNamespace Add(string path, ref object namespaceURI, ref object alias, bool installForAllUsers)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,false);
			object[] paramsArray = Invoker.ValidateParamsArray(path, namespaceURI, alias, installForAllUsers);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray, modifiers);
			NetOffice.WordApi.XMLNamespace newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.XMLNamespace;
			namespaceURI = (object)paramsArray[1];
			alias = (object)paramsArray[2];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD11 WD12 WD14 
		/// </summary>
		/// <param name="Path">string Path</param>
		/// <param name="InstallForAllUsers">bool InstallForAllUsers</param>
		[SupportByLibrary("WD11","WD12","WD14")]
		public void InstallManifest(string path, bool installForAllUsers)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(path, installForAllUsers);
			Invoker.Method(this, "InstallManifest", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("WD11","WD12","WD14")]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}