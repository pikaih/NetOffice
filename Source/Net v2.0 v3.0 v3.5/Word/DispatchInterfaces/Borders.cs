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
	/// DispatchInterface Borders SupportByLibrary WD09 WD10 WD11 WD12 WD14 
	///</summary>
	[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class Borders : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Borders(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Borders(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Borders(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public Borders()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
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
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
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
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
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
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
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
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 Enable
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Enable", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Enable", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 DistanceFromTop
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DistanceFromTop", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DistanceFromTop", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public bool Shadow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shadow", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Shadow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Enums.WdLineStyle InsideLineStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InsideLineStyle", paramsArray);
				return (NetOffice.WordApi.Enums.WdLineStyle)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InsideLineStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Enums.WdLineStyle OutsideLineStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OutsideLineStyle", paramsArray);
				return (NetOffice.WordApi.Enums.WdLineStyle)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OutsideLineStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Enums.WdLineWidth InsideLineWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InsideLineWidth", paramsArray);
				return (NetOffice.WordApi.Enums.WdLineWidth)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InsideLineWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Enums.WdLineWidth OutsideLineWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OutsideLineWidth", paramsArray);
				return (NetOffice.WordApi.Enums.WdLineWidth)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OutsideLineWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Enums.WdColorIndex InsideColorIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InsideColorIndex", paramsArray);
				return (NetOffice.WordApi.Enums.WdColorIndex)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InsideColorIndex", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Enums.WdColorIndex OutsideColorIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OutsideColorIndex", paramsArray);
				return (NetOffice.WordApi.Enums.WdColorIndex)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OutsideColorIndex", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 DistanceFromLeft
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DistanceFromLeft", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DistanceFromLeft", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 DistanceFromBottom
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DistanceFromBottom", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DistanceFromBottom", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public Int32 DistanceFromRight
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DistanceFromRight", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DistanceFromRight", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public bool AlwaysInFront
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "AlwaysInFront", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "AlwaysInFront", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public bool SurroundHeader
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SurroundHeader", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SurroundHeader", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public bool SurroundFooter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SurroundFooter", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "SurroundFooter", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public bool JoinBorders
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "JoinBorders", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "JoinBorders", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public bool HasHorizontal
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasHorizontal", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public bool HasVertical
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "HasVertical", paramsArray);
				return (bool)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Enums.WdBorderDistanceFrom DistanceFrom
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DistanceFrom", paramsArray);
				return (NetOffice.WordApi.Enums.WdBorderDistanceFrom)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "DistanceFrom", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public bool EnableFirstPageInSection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EnableFirstPageInSection", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EnableFirstPageInSection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public bool EnableOtherPagesInSection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "EnableOtherPagesInSection", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "EnableOtherPagesInSection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Enums.WdColor InsideColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InsideColor", paramsArray);
				return (NetOffice.WordApi.Enums.WdColor)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InsideColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public NetOffice.WordApi.Enums.WdColor OutsideColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "OutsideColor", paramsArray);
				return (NetOffice.WordApi.Enums.WdColor)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "OutsideColor", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Index">NetOffice.WordApi.Enums.WdBorderType Index</param>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		[NetRuntimeSystem.Runtime.CompilerServices.IndexerName("Item")]
		public NetOffice.WordApi.Border this[NetOffice.WordApi.Enums.WdBorderType index]
		{
			get
			{
				object[] paramsArray = Invoker.ValidateParamsArray(index);
				object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
				NetOffice.WordApi.Border newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as NetOffice.WordApi.Border;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD09 WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
		public void ApplyPageBordersToAllSections()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ApplyPageBordersToAllSections", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("WD09","WD10","WD11","WD12","WD14")]
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