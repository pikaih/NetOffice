//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace NetOffice.PowerPointApi
{
	///<summary>
	/// DispatchInterface ThreeDFormat SupportByLibrary PowerPoint, 9,10,11,12,14
	///</summary>
	[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsDispatchInterface)]
	public class ThreeDFormat : COMObject
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
                    _type = typeof(ThreeDFormat);
                    
                return _type;
            }
        }
        
        #endregion
        
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ThreeDFormat(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ThreeDFormat(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ThreeDFormat(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ThreeDFormat() : base()
		{
		}
		
		/// <param name="progId">registered ProgID</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ThreeDFormat(string progId) : base(progId)
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public COMObject Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
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
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
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
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Single Depth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Depth", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Depth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.PowerPointApi.ColorFormat ExtrusionColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ExtrusionColor", paramsArray);
				NetOffice.PowerPointApi.ColorFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.ColorFormat.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ColorFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoExtrusionColorType ExtrusionColorType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ExtrusionColorType", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoExtrusionColorType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ExtrusionColorType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Perspective
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Perspective", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Perspective", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoPresetExtrusionDirection PresetExtrusionDirection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetExtrusionDirection", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoPresetExtrusionDirection)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoPresetLightingDirection PresetLightingDirection
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetLightingDirection", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoPresetLightingDirection)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PresetLightingDirection", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoPresetLightingSoftness PresetLightingSoftness
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetLightingSoftness", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoPresetLightingSoftness)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PresetLightingSoftness", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoPresetMaterial PresetMaterial
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetMaterial", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoPresetMaterial)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PresetMaterial", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoPresetThreeDFormat PresetThreeDFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetThreeDFormat", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoPresetThreeDFormat)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Single RotationX
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RotationX", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RotationX", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public Single RotationY
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RotationY", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RotationY", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState Visible
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Visible", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Visible", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoLightRigType PresetLighting
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetLighting", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoLightRigType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PresetLighting", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public Single Z
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Z", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Z", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoBevelType BevelTopType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BevelTopType", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoBevelType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BevelTopType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public Single BevelTopInset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BevelTopInset", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BevelTopInset", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public Single BevelTopDepth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BevelTopDepth", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BevelTopDepth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoBevelType BevelBottomType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BevelBottomType", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoBevelType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BevelBottomType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public Single BevelBottomInset
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BevelBottomInset", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BevelBottomInset", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public Single BevelBottomDepth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BevelBottomDepth", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BevelBottomDepth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoPresetCamera PresetCamera
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetCamera", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoPresetCamera)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public Single RotationZ
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RotationZ", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "RotationZ", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public Single ContourWidth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ContourWidth", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ContourWidth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public NetOffice.PowerPointApi.ColorFormat ContourColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ContourColor", paramsArray);
				NetOffice.PowerPointApi.ColorFormat newObject = LateBindingApi.Core.Factory.CreateKnownObjectFromComProxy(this,returnItem,NetOffice.PowerPointApi.ColorFormat.LateBindingApiWrapperType) as NetOffice.PowerPointApi.ColorFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public Single FieldOfView
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FieldOfView", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "FieldOfView", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public NetOffice.OfficeApi.Enums.MsoTriState ProjectText
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ProjectText", paramsArray);
				return (NetOffice.OfficeApi.Enums.MsoTriState)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "ProjectText", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// Get/Set
		/// </summary>
		[SupportByLibrary("PowerPoint", 12,14)]
		public Single LightAngle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "LightAngle", paramsArray);
				return (Single)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "LightAngle", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Increment">Single Increment</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void IncrementRotationX(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "IncrementRotationX", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="Increment">Single Increment</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void IncrementRotationY(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "IncrementRotationY", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void ResetRotation()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "ResetRotation", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="PresetThreeDFormat">NetOffice.OfficeApi.Enums.MsoPresetThreeDFormat PresetThreeDFormat</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void SetThreeDFormat(NetOffice.OfficeApi.Enums.MsoPresetThreeDFormat presetThreeDFormat)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(presetThreeDFormat);
			Invoker.Method(this, "SetThreeDFormat", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 9, 10, 11, 12, 14
		/// </summary>
		/// <param name="PresetExtrusionDirection">NetOffice.OfficeApi.Enums.MsoPresetExtrusionDirection PresetExtrusionDirection</param>
		[SupportByLibrary("PowerPoint", 9,10,11,12,14)]
		public void SetExtrusionDirection(NetOffice.OfficeApi.Enums.MsoPresetExtrusionDirection presetExtrusionDirection)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(presetExtrusionDirection);
			Invoker.Method(this, "SetExtrusionDirection", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// </summary>
		/// <param name="PresetCamera">NetOffice.OfficeApi.Enums.MsoPresetCamera PresetCamera</param>
		[SupportByLibrary("PowerPoint", 12,14)]
		public void SetPresetCamera(NetOffice.OfficeApi.Enums.MsoPresetCamera presetCamera)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(presetCamera);
			Invoker.Method(this, "SetPresetCamera", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// </summary>
		/// <param name="Increment">Single Increment</param>
		[SupportByLibrary("PowerPoint", 12,14)]
		public void IncrementRotationZ(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "IncrementRotationZ", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// </summary>
		/// <param name="Increment">Single Increment</param>
		[SupportByLibrary("PowerPoint", 12,14)]
		public void IncrementRotationHorizontal(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "IncrementRotationHorizontal", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary PowerPoint 12, 14
		/// </summary>
		/// <param name="Increment">Single Increment</param>
		[SupportByLibrary("PowerPoint", 12,14)]
		public void IncrementRotationVertical(Single increment)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(increment);
			Invoker.Method(this, "IncrementRotationVertical", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}