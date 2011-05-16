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
	/// DispatchInterface ProtectedViewWindows SupportByLibrary WD14 
	///</summary>
	[SupportByLibrary("WD14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ProtectedViewWindows : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ProtectedViewWindows(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ProtectedViewWindows(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ProtectedViewWindows(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ProtectedViewWindows()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
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
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
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
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
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

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		[SupportByLibrary("WD14")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		/// <param name="Index">object Index</param>
		[SupportByLibrary("WD14")]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.ProtectedViewWindow this[object index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.ProtectedViewWindow newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.ProtectedViewWindow;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		/// <param name="FileName">ref object FileName</param>
		/// <param name="AddToRecentFiles">ref optional object AddToRecentFiles</param>
		/// <param name="PasswordDocument">ref optional object PasswordDocument</param>
		/// <param name="Visible">ref optional object Visible</param>
		/// <param name="OpenAndRepair">ref optional object OpenAndRepair</param>
		[SupportByLibrary("WD14")]
		public NetOffice.WordApi.ProtectedViewWindow Open(ref object fileName, ref object addToRecentFiles, ref object passwordDocument, ref object visible, ref object openAndRepair)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, addToRecentFiles, passwordDocument, visible, openAndRepair);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray, modifiers);
			NetOffice.WordApi.ProtectedViewWindow newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.ProtectedViewWindow;
			fileName = (object)paramsArray[0];
			addToRecentFiles = (object)paramsArray[1];
			passwordDocument = (object)paramsArray[2];
			visible = (object)paramsArray[3];
			openAndRepair = (object)paramsArray[4];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD14 
		/// </summary>
		/// <param name="FileName">ref object FileName</param>
		[SupportByLibrary("WD14")]
		public NetOffice.WordApi.ProtectedViewWindow Open(ref object fileName)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "Open", paramsArray, modifiers);
			NetOffice.WordApi.ProtectedViewWindow newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.ProtectedViewWindow;
			fileName = (object)paramsArray[0];
			return newObject;
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("WD14")]
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