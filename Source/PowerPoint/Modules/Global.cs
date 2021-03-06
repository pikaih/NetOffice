//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice;
namespace NetOffice.PowerPointApi.GlobalHelperModules
{
	///<summary>
	/// Module GlobalModule
	///</summary>
	[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
	[EntityTypeAttribute(EntityType.IsModule)]
	public static class GlobalModule
	{

		#region Fields

		private static COMObject _instance;

        internal static COMObject Instance
        {
	        get
	        {
		        return _instance;
	        }
	        set
	        {
		        if( (null == value) || (null == _instance) )
			        _instance = value;				
        	}
        }

		#endregion

		#region Internal Properties

		internal static Core Factory
		{
			get
			{
				if(null != _instance)
					 return _instance.Factory;
			else
				return Core.Default;
			}
		}

		internal static Invoker Invoker
		{
			get
			{
				if(null != _instance)
					 return _instance.Invoker;
			else
				return Invoker.Default;
			}
		}

		#endregion

		#region Properties

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public static NetOffice.PowerPointApi.Presentation ActivePresentation
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ActivePresentation", paramsArray);
				NetOffice.PowerPointApi.Presentation newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PowerPointApi.Presentation.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentation;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public static NetOffice.PowerPointApi.DocumentWindow ActiveWindow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ActiveWindow", paramsArray);
				NetOffice.PowerPointApi.DocumentWindow newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PowerPointApi.DocumentWindow.LateBindingApiWrapperType) as NetOffice.PowerPointApi.DocumentWindow;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public static NetOffice.PowerPointApi.AddIns AddIns
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "AddIns", paramsArray);
				NetOffice.PowerPointApi.AddIns newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PowerPointApi.AddIns.LateBindingApiWrapperType) as NetOffice.PowerPointApi.AddIns;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public static NetOffice.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Application", paramsArray);
				NetOffice.PowerPointApi.Application newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PowerPointApi.Application.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public static NetOffice.OfficeApi.Assistant Assistant
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Assistant", paramsArray);
				NetOffice.OfficeApi.Assistant newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.Assistant.LateBindingApiWrapperType) as NetOffice.OfficeApi.Assistant;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public static NetOffice.PowerPointApi.PPDialogs Dialogs
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Dialogs", paramsArray);
				NetOffice.PowerPointApi.PPDialogs newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PowerPointApi.PPDialogs.LateBindingApiWrapperType) as NetOffice.PowerPointApi.PPDialogs;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public static NetOffice.PowerPointApi.Presentations Presentations
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Presentations", paramsArray);
				NetOffice.PowerPointApi.Presentations newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PowerPointApi.Presentations.LateBindingApiWrapperType) as NetOffice.PowerPointApi.Presentations;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public static NetOffice.PowerPointApi.SlideShowWindows SlideShowWindows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "SlideShowWindows", paramsArray);
				NetOffice.PowerPointApi.SlideShowWindows newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PowerPointApi.SlideShowWindows.LateBindingApiWrapperType) as NetOffice.PowerPointApi.SlideShowWindows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public static NetOffice.PowerPointApi.DocumentWindows Windows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "Windows", paramsArray);
				NetOffice.PowerPointApi.DocumentWindows newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PowerPointApi.DocumentWindows.LateBindingApiWrapperType) as NetOffice.PowerPointApi.DocumentWindows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public static NetOffice.OfficeApi.CommandBars CommandBars
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "CommandBars", paramsArray);
				NetOffice.OfficeApi.CommandBars newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.CommandBars.LateBindingApiWrapperType) as NetOffice.OfficeApi.CommandBars;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 9, 10, 11, 12, 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 9,10,11,12,14,15,16)]
		public static NetOffice.OfficeApi.AnswerWizard AnswerWizard
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "AnswerWizard", paramsArray);
				NetOffice.OfficeApi.AnswerWizard newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.OfficeApi.AnswerWizard.LateBindingApiWrapperType) as NetOffice.OfficeApi.AnswerWizard;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15,16)]
		public static NetOffice.PowerPointApi.FileConverters FileConverters
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "FileConverters", paramsArray);
				NetOffice.PowerPointApi.FileConverters newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PowerPointApi.FileConverters.LateBindingApiWrapperType) as NetOffice.PowerPointApi.FileConverters;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15,16)]
		public static NetOffice.PowerPointApi.ProtectedViewWindows ProtectedViewWindows
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ProtectedViewWindows", paramsArray);
				NetOffice.PowerPointApi.ProtectedViewWindows newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PowerPointApi.ProtectedViewWindows.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ProtectedViewWindows;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15,16)]
		public static NetOffice.PowerPointApi.ProtectedViewWindow ActiveProtectedViewWindow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "ActiveProtectedViewWindow", paramsArray);
				NetOffice.PowerPointApi.ProtectedViewWindow newObject = Factory.CreateKnownObjectFromComProxy(_instance,returnItem,NetOffice.PowerPointApi.ProtectedViewWindow.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ProtectedViewWindow;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByVersion PowerPoint 14, 15, 16
		/// Get
		/// </summary>
		[SupportByVersionAttribute("PowerPoint", 14,15,16)]
		public static bool IsSandboxed
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(_instance, "IsSandboxed", paramsArray);
				return NetRuntimeSystem.Convert.ToBoolean(returnItem);
			}
		}

		#endregion

		#region Methods

		#endregion
	}
}