﻿using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Collections.Generic;
using NetOffice;
namespace NetOffice.ExcelApi
{
	///<summary>
	/// Interface IPage 
	/// SupportByVersion Excel, 12,14,15,16
	///</summary>
	[SupportByVersionAttribute("Excel", 12,14,15,16)]
	[EntityTypeAttribute(EntityType.IsInterface)]
	public class IPage : COMObject
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
                    _type = typeof(IPage);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
		public IPage(Core factory, COMObject parentObject, object comProxy) : base(factory, parentObject, comProxy)
		{
			
		}

        ///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPage(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		///<param name="factory">current used factory core</param>
		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPage(Core factory, COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(factory, parentObject, comProxy, comProxyType)
		{

		}

		///<param name="parentObject">object there has created the proxy</param>
        ///<param name="comProxy">inner wrapped COM proxy</param>
        ///<param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPage(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		///<param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPage(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPage() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public IPage(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15,16)]
		public NetOffice.ExcelApi.HeaderFooter LeftHeader
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LeftHeader", paramsArray);
				NetOffice.ExcelApi.HeaderFooter newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.HeaderFooter.LateBindingApiWrapperType) as NetOffice.ExcelApi.HeaderFooter;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15,16)]
		public NetOffice.ExcelApi.HeaderFooter CenterHeader
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CenterHeader", paramsArray);
				NetOffice.ExcelApi.HeaderFooter newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.HeaderFooter.LateBindingApiWrapperType) as NetOffice.ExcelApi.HeaderFooter;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15,16)]
		public NetOffice.ExcelApi.HeaderFooter RightHeader
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RightHeader", paramsArray);
				NetOffice.ExcelApi.HeaderFooter newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.HeaderFooter.LateBindingApiWrapperType) as NetOffice.ExcelApi.HeaderFooter;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15,16)]
		public NetOffice.ExcelApi.HeaderFooter LeftFooter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LeftFooter", paramsArray);
				NetOffice.ExcelApi.HeaderFooter newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.HeaderFooter.LateBindingApiWrapperType) as NetOffice.ExcelApi.HeaderFooter;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15,16)]
		public NetOffice.ExcelApi.HeaderFooter CenterFooter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CenterFooter", paramsArray);
				NetOffice.ExcelApi.HeaderFooter newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.HeaderFooter.LateBindingApiWrapperType) as NetOffice.ExcelApi.HeaderFooter;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion Excel 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("Excel", 12,14,15,16)]
		public NetOffice.ExcelApi.HeaderFooter RightFooter
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RightFooter", paramsArray);
				NetOffice.ExcelApi.HeaderFooter newObject = Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.ExcelApi.HeaderFooter.LateBindingApiWrapperType) as NetOffice.ExcelApi.HeaderFooter;
				return newObject;
			}
		}

		#endregion

		#region Methods

		#endregion
		#pragma warning restore
	}
}