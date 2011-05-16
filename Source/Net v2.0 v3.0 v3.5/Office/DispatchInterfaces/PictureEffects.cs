//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace NetOffice.OfficeApi
{
	///<summary>
	/// DispatchInterface PictureEffects SupportByLibrary OF14 
	///</summary>
	[SupportByLibrary("OF14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class PictureEffects : _IMsoDispObj ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PictureEffects(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PictureEffects(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PictureEffects(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public PictureEffects()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary OF14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("OF14")]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.OfficeApi.PictureEffect this[Int32 index]
		{
			get
{			
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.PropertyGet(this, "Item", paramsArray);
			NetOffice.OfficeApi.PictureEffect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as NetOffice.OfficeApi.PictureEffect;
			return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary OF14 
		/// </summary>
		[SupportByLibrary("OF14")]
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
		/// SupportByLibrary OF14 
		/// </summary>
		/// <param name="EffectType">NetOffice.OfficeApi.Enums.MsoPictureEffectType EffectType</param>
		/// <param name="Position">Int32 Position</param>
		[SupportByLibrary("OF14")]
		public NetOffice.OfficeApi.PictureEffect Insert(NetOffice.OfficeApi.Enums.MsoPictureEffectType effectType, Int32 position)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(effectType, position);
			object returnItem = Invoker.MethodReturn(this, "Insert", paramsArray);
			NetOffice.OfficeApi.PictureEffect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.OfficeApi.PictureEffect;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary OF14 
		/// </summary>
		/// <param name="Index">Int32 Index</param>
		[SupportByLibrary("OF14")]
		public void Delete(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("OF14")]
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