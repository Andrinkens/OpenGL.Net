
// Copyright (C) 2015-2016 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

// Disable "'token' is obsolete" warnings
#pragma warning disable 618

using System;

namespace OpenGL
{
	/// <summary>
	/// Strongly typed enumeration WFDboolean.
	/// </summary>
	public enum WFDboolean
	{
		/// <summary>
		/// Strongly typed for value WFD_FALSE.
		/// </summary>
		False = Wfd.FALSE,

		/// <summary>
		/// Strongly typed for value WFD_TRUE.
		/// </summary>
		True = Wfd.TRUE,

	}

	/// <summary>
	/// Strongly typed enumeration WFDStringID.
	/// </summary>
	public enum WFDStringID
	{
		/// <summary>
		/// Strongly typed for value WFD_VENDOR.
		/// </summary>
		Vendor = Wfd.VENDOR,

		/// <summary>
		/// Strongly typed for value WFD_RENDERER.
		/// </summary>
		Renderer = Wfd.RENDERER,

		/// <summary>
		/// Strongly typed for value WFD_VERSION.
		/// </summary>
		Version = Wfd.VERSION,

		/// <summary>
		/// Strongly typed for value WFD_EXTENSIONS.
		/// </summary>
		Extensions = Wfd.EXTENSIONS,

		/// <summary>
		/// Strongly typed for value WFD_STRING_ID_FORCE_32BIT.
		/// </summary>
		StringIdForce32bit = Wfd.STRING_ID_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDErrorCode.
	/// </summary>
	public enum WFDErrorCode
	{
		/// <summary>
		/// Strongly typed for value WFD_ERROR_NONE.
		/// </summary>
		ErrorNone = Wfd.ERROR_NONE,

		/// <summary>
		/// Strongly typed for value WFD_ERROR_OUT_OF_MEMORY.
		/// </summary>
		ErrorOutOfMemory = Wfd.ERROR_OUT_OF_MEMORY,

		/// <summary>
		/// Strongly typed for value WFD_ERROR_ILLEGAL_ARGUMENT.
		/// </summary>
		ErrorIllegalArgument = Wfd.ERROR_ILLEGAL_ARGUMENT,

		/// <summary>
		/// Strongly typed for value WFD_ERROR_NOT_SUPPORTED.
		/// </summary>
		ErrorNotSupported = Wfd.ERROR_NOT_SUPPORTED,

		/// <summary>
		/// Strongly typed for value WFD_ERROR_BAD_ATTRIBUTE.
		/// </summary>
		ErrorBadAttribute = Wfd.ERROR_BAD_ATTRIBUTE,

		/// <summary>
		/// Strongly typed for value WFD_ERROR_IN_USE.
		/// </summary>
		ErrorInUse = Wfd.ERROR_IN_USE,

		/// <summary>
		/// Strongly typed for value WFD_ERROR_BUSY.
		/// </summary>
		ErrorBusy = Wfd.ERROR_BUSY,

		/// <summary>
		/// Strongly typed for value WFD_ERROR_BAD_DEVICE.
		/// </summary>
		ErrorBadDevice = Wfd.ERROR_BAD_DEVICE,

		/// <summary>
		/// Strongly typed for value WFD_ERROR_BAD_HANDLE.
		/// </summary>
		ErrorBadHandle = Wfd.ERROR_BAD_HANDLE,

		/// <summary>
		/// Strongly typed for value WFD_ERROR_INCONSISTENCY.
		/// </summary>
		ErrorInconsistency = Wfd.ERROR_INCONSISTENCY,

		/// <summary>
		/// Strongly typed for value WFD_ERROR_FORCE_32BIT.
		/// </summary>
		ErrorForce32bit = Wfd.ERROR_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDDeviceFilter.
	/// </summary>
	public enum WFDDeviceFilter
	{
		/// <summary>
		/// Strongly typed for value WFD_DEVICE_FILTER_PORT_ID.
		/// </summary>
		DeviceFilterPortId = Wfd.DEVICE_FILTER_PORT_ID,

		/// <summary>
		/// Strongly typed for value WFD_DEVICE_FILTER_FORCE_32BIT.
		/// </summary>
		DeviceFilterForce32bit = Wfd.DEVICE_FILTER_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDCommitType.
	/// </summary>
	public enum WFDCommitType
	{
		/// <summary>
		/// Strongly typed for value WFD_COMMIT_ENTIRE_DEVICE.
		/// </summary>
		CommitEntireDevice = Wfd.COMMIT_ENTIRE_DEVICE,

		/// <summary>
		/// Strongly typed for value WFD_COMMIT_ENTIRE_PORT.
		/// </summary>
		CommitEntirePort = Wfd.COMMIT_ENTIRE_PORT,

		/// <summary>
		/// Strongly typed for value WFD_COMMIT_PIPELINE.
		/// </summary>
		CommitPipeline = Wfd.COMMIT_PIPELINE,

		/// <summary>
		/// Strongly typed for value WFD_COMMIT_FORCE_32BIT.
		/// </summary>
		CommitForce32bit = Wfd.COMMIT_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDDeviceAttrib.
	/// </summary>
	public enum WFDDeviceAttrib
	{
		/// <summary>
		/// Strongly typed for value WFD_DEVICE_ID.
		/// </summary>
		DeviceId = Wfd.DEVICE_ID,

		/// <summary>
		/// Strongly typed for value WFD_DEVICE_ATTRIB_FORCE_32BIT.
		/// </summary>
		DeviceAttribForce32bit = Wfd.DEVICE_ATTRIB_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDEventType.
	/// </summary>
	public enum WFDEventType
	{
		/// <summary>
		/// Strongly typed for value WFD_EVENT_INVALID.
		/// </summary>
		EventInvalid = Wfd.EVENT_INVALID,

		/// <summary>
		/// Strongly typed for value WFD_EVENT_NONE.
		/// </summary>
		EventNone = Wfd.EVENT_NONE,

		/// <summary>
		/// Strongly typed for value WFD_EVENT_DESTROYED.
		/// </summary>
		EventDestroyed = Wfd.EVENT_DESTROYED,

		/// <summary>
		/// Strongly typed for value WFD_EVENT_PORT_ATTACH_DETACH.
		/// </summary>
		EventPortAttachDetach = Wfd.EVENT_PORT_ATTACH_DETACH,

		/// <summary>
		/// Strongly typed for value WFD_EVENT_PORT_PROTECTION_FAILURE.
		/// </summary>
		EventPortProtectionFailure = Wfd.EVENT_PORT_PROTECTION_FAILURE,

		/// <summary>
		/// Strongly typed for value WFD_EVENT_PIPELINE_BIND_SOURCE_COMPLETE.
		/// </summary>
		EventPipelineBindSourceComplete = Wfd.EVENT_PIPELINE_BIND_SOURCE_COMPLETE,

		/// <summary>
		/// Strongly typed for value WFD_EVENT_PIPELINE_BIND_MASK_COMPLETE.
		/// </summary>
		EventPipelineBindMaskComplete = Wfd.EVENT_PIPELINE_BIND_MASK_COMPLETE,

		/// <summary>
		/// Strongly typed for value WFD_EVENT_FORCE_32BIT.
		/// </summary>
		EventForce32bit = Wfd.EVENT_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDEventAttrib.
	/// </summary>
	public enum WFDEventAttrib
	{
		/// <summary>
		/// Strongly typed for value WFD_EVENT_PIPELINE_BIND_QUEUE_SIZE.
		/// </summary>
		EventPipelineBindQueueSize = Wfd.EVENT_PIPELINE_BIND_QUEUE_SIZE,

		/// <summary>
		/// Strongly typed for value WFD_EVENT_TYPE.
		/// </summary>
		EventType = Wfd.EVENT_TYPE,

		/// <summary>
		/// Strongly typed for value WFD_EVENT_PORT_ATTACH_PORT_ID.
		/// </summary>
		EventPortAttachPortId = Wfd.EVENT_PORT_ATTACH_PORT_ID,

		/// <summary>
		/// Strongly typed for value WFD_EVENT_PORT_ATTACH_STATE.
		/// </summary>
		EventPortAttachState = Wfd.EVENT_PORT_ATTACH_STATE,

		/// <summary>
		/// Strongly typed for value WFD_EVENT_PORT_PROTECTION_PORT_ID.
		/// </summary>
		EventPortProtectionPortId = Wfd.EVENT_PORT_PROTECTION_PORT_ID,

		/// <summary>
		/// Strongly typed for value WFD_EVENT_PIPELINE_BIND_PIPELINE_ID.
		/// </summary>
		EventPipelineBindPipelineId = Wfd.EVENT_PIPELINE_BIND_PIPELINE_ID,

		/// <summary>
		/// Strongly typed for value WFD_EVENT_PIPELINE_BIND_SOURCE.
		/// </summary>
		EventPipelineBindSource = Wfd.EVENT_PIPELINE_BIND_SOURCE,

		/// <summary>
		/// Strongly typed for value WFD_EVENT_PIPELINE_BIND_MASK.
		/// </summary>
		EventPipelineBindMask = Wfd.EVENT_PIPELINE_BIND_MASK,

		/// <summary>
		/// Strongly typed for value WFD_EVENT_PIPELINE_BIND_QUEUE_OVERFLOW.
		/// </summary>
		EventPipelineBindQueueOverflow = Wfd.EVENT_PIPELINE_BIND_QUEUE_OVERFLOW,

		/// <summary>
		/// Strongly typed for value WFD_EVENT_ATTRIB_FORCE_32BIT.
		/// </summary>
		EventAttribForce32bit = Wfd.EVENT_ATTRIB_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDPortModeAttrib.
	/// </summary>
	public enum WFDPortModeAttrib
	{
		/// <summary>
		/// Strongly typed for value WFD_PORT_MODE_WIDTH.
		/// </summary>
		PortModeWidth = Wfd.PORT_MODE_WIDTH,

		/// <summary>
		/// Strongly typed for value WFD_PORT_MODE_HEIGHT.
		/// </summary>
		PortModeHeight = Wfd.PORT_MODE_HEIGHT,

		/// <summary>
		/// Strongly typed for value WFD_PORT_MODE_REFRESH_RATE.
		/// </summary>
		PortModeRefreshRate = Wfd.PORT_MODE_REFRESH_RATE,

		/// <summary>
		/// Strongly typed for value WFD_PORT_MODE_FLIP_MIRROR_SUPPORT.
		/// </summary>
		PortModeFlipMirrorSupport = Wfd.PORT_MODE_FLIP_MIRROR_SUPPORT,

		/// <summary>
		/// Strongly typed for value WFD_PORT_MODE_ROTATION_SUPPORT.
		/// </summary>
		PortModeRotationSupport = Wfd.PORT_MODE_ROTATION_SUPPORT,

		/// <summary>
		/// Strongly typed for value WFD_PORT_MODE_INTERLACED.
		/// </summary>
		PortModeInterlaced = Wfd.PORT_MODE_INTERLACED,

		/// <summary>
		/// Strongly typed for value WFD_PORT_MODE_ATTRIB_FORCE_32BIT.
		/// </summary>
		PortModeAttribForce32bit = Wfd.PORT_MODE_ATTRIB_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDPortConfigAttrib.
	/// </summary>
	public enum WFDPortConfigAttrib
	{
		/// <summary>
		/// Strongly typed for value WFD_PORT_ID.
		/// </summary>
		PortId = Wfd.PORT_ID,

		/// <summary>
		/// Strongly typed for value WFD_PORT_TYPE.
		/// </summary>
		PortType = Wfd.PORT_TYPE,

		/// <summary>
		/// Strongly typed for value WFD_PORT_DETACHABLE.
		/// </summary>
		PortDetachable = Wfd.PORT_DETACHABLE,

		/// <summary>
		/// Strongly typed for value WFD_PORT_ATTACHED.
		/// </summary>
		PortAttached = Wfd.PORT_ATTACHED,

		/// <summary>
		/// Strongly typed for value WFD_PORT_NATIVE_RESOLUTION.
		/// </summary>
		PortNativeResolution = Wfd.PORT_NATIVE_RESOLUTION,

		/// <summary>
		/// Strongly typed for value WFD_PORT_PHYSICAL_SIZE.
		/// </summary>
		PortPhysicalSize = Wfd.PORT_PHYSICAL_SIZE,

		/// <summary>
		/// Strongly typed for value WFD_PORT_FILL_PORT_AREA.
		/// </summary>
		PortFillPortArea = Wfd.PORT_FILL_PORT_AREA,

		/// <summary>
		/// Strongly typed for value WFD_PORT_BACKGROUND_COLOR.
		/// </summary>
		PortBackgroundColor = Wfd.PORT_BACKGROUND_COLOR,

		/// <summary>
		/// Strongly typed for value WFD_PORT_FLIP.
		/// </summary>
		PortFlip = Wfd.PORT_FLIP,

		/// <summary>
		/// Strongly typed for value WFD_PORT_MIRROR.
		/// </summary>
		PortMirror = Wfd.PORT_MIRROR,

		/// <summary>
		/// Strongly typed for value WFD_PORT_ROTATION.
		/// </summary>
		PortRotation = Wfd.PORT_ROTATION,

		/// <summary>
		/// Strongly typed for value WFD_PORT_POWER_MODE.
		/// </summary>
		PortPowerMode = Wfd.PORT_POWER_MODE,

		/// <summary>
		/// Strongly typed for value WFD_PORT_GAMMA_RANGE.
		/// </summary>
		PortGammaRange = Wfd.PORT_GAMMA_RANGE,

		/// <summary>
		/// Strongly typed for value WFD_PORT_GAMMA.
		/// </summary>
		PortGamma = Wfd.PORT_GAMMA,

		/// <summary>
		/// Strongly typed for value WFD_PORT_PARTIAL_REFRESH_SUPPORT.
		/// </summary>
		PortPartialRefreshSupport = Wfd.PORT_PARTIAL_REFRESH_SUPPORT,

		/// <summary>
		/// Strongly typed for value WFD_PORT_PARTIAL_REFRESH_MAXIMUM.
		/// </summary>
		PortPartialRefreshMaximum = Wfd.PORT_PARTIAL_REFRESH_MAXIMUM,

		/// <summary>
		/// Strongly typed for value WFD_PORT_PARTIAL_REFRESH_ENABLE.
		/// </summary>
		PortPartialRefreshEnable = Wfd.PORT_PARTIAL_REFRESH_ENABLE,

		/// <summary>
		/// Strongly typed for value WFD_PORT_PARTIAL_REFRESH_RECTANGLE.
		/// </summary>
		PortPartialRefreshRectangle = Wfd.PORT_PARTIAL_REFRESH_RECTANGLE,

		/// <summary>
		/// Strongly typed for value WFD_PORT_PIPELINE_ID_COUNT.
		/// </summary>
		PortPipelineIdCount = Wfd.PORT_PIPELINE_ID_COUNT,

		/// <summary>
		/// Strongly typed for value WFD_PORT_BINDABLE_PIPELINE_IDS.
		/// </summary>
		PortBindablePipelineIds = Wfd.PORT_BINDABLE_PIPELINE_IDS,

		/// <summary>
		/// Strongly typed for value WFD_PORT_PROTECTION_ENABLE.
		/// </summary>
		PortProtectionEnable = Wfd.PORT_PROTECTION_ENABLE,

		/// <summary>
		/// Strongly typed for value WFD_PORT_ATTRIB_FORCE_32BIT.
		/// </summary>
		PortAttribForce32bit = Wfd.PORT_ATTRIB_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDPortType.
	/// </summary>
	public enum WFDPortType
	{
		/// <summary>
		/// Strongly typed for value WFD_PORT_TYPE_INTERNAL.
		/// </summary>
		PortTypeInternal = Wfd.PORT_TYPE_INTERNAL,

		/// <summary>
		/// Strongly typed for value WFD_PORT_TYPE_COMPOSITE.
		/// </summary>
		PortTypeComposite = Wfd.PORT_TYPE_COMPOSITE,

		/// <summary>
		/// Strongly typed for value WFD_PORT_TYPE_SVIDEO.
		/// </summary>
		PortTypeSvideo = Wfd.PORT_TYPE_SVIDEO,

		/// <summary>
		/// Strongly typed for value WFD_PORT_TYPE_COMPONENT_YPbPr.
		/// </summary>
		PortTypeComponentYpbpr = Wfd.PORT_TYPE_COMPONENT_YPbPr,

		/// <summary>
		/// Strongly typed for value WFD_PORT_TYPE_COMPONENT_RGB.
		/// </summary>
		PortTypeComponentRgb = Wfd.PORT_TYPE_COMPONENT_RGB,

		/// <summary>
		/// Strongly typed for value WFD_PORT_TYPE_COMPONENT_RGBHV.
		/// </summary>
		PortTypeComponentRgbhv = Wfd.PORT_TYPE_COMPONENT_RGBHV,

		/// <summary>
		/// Strongly typed for value WFD_PORT_TYPE_DVI.
		/// </summary>
		PortTypeDvi = Wfd.PORT_TYPE_DVI,

		/// <summary>
		/// Strongly typed for value WFD_PORT_TYPE_HDMI.
		/// </summary>
		PortTypeHdmi = Wfd.PORT_TYPE_HDMI,

		/// <summary>
		/// Strongly typed for value WFD_PORT_TYPE_DISPLAYPORT.
		/// </summary>
		PortTypeDisplayport = Wfd.PORT_TYPE_DISPLAYPORT,

		/// <summary>
		/// Strongly typed for value WFD_PORT_TYPE_OTHER.
		/// </summary>
		PortTypeOther = Wfd.PORT_TYPE_OTHER,

		/// <summary>
		/// Strongly typed for value WFD_PORT_TYPE_FORCE_32BIT.
		/// </summary>
		PortTypeForce32bit = Wfd.PORT_TYPE_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDPowerMode.
	/// </summary>
	public enum WFDPowerMode
	{
		/// <summary>
		/// Strongly typed for value WFD_POWER_MODE_OFF.
		/// </summary>
		PowerModeOff = Wfd.POWER_MODE_OFF,

		/// <summary>
		/// Strongly typed for value WFD_POWER_MODE_SUSPEND.
		/// </summary>
		PowerModeSuspend = Wfd.POWER_MODE_SUSPEND,

		/// <summary>
		/// Strongly typed for value WFD_POWER_MODE_LIMITED_USE.
		/// </summary>
		PowerModeLimitedUse = Wfd.POWER_MODE_LIMITED_USE,

		/// <summary>
		/// Strongly typed for value WFD_POWER_MODE_ON.
		/// </summary>
		PowerModeOn = Wfd.POWER_MODE_ON,

		/// <summary>
		/// Strongly typed for value WFD_POWER_MODE_FORCE_32BIT.
		/// </summary>
		PowerModeForce32bit = Wfd.POWER_MODE_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDPartialRefresh.
	/// </summary>
	public enum WFDPartialRefresh
	{
		/// <summary>
		/// Strongly typed for value WFD_PARTIAL_REFRESH_NONE.
		/// </summary>
		PartialRefreshNone = Wfd.PARTIAL_REFRESH_NONE,

		/// <summary>
		/// Strongly typed for value WFD_PARTIAL_REFRESH_VERTICAL.
		/// </summary>
		PartialRefreshVertical = Wfd.PARTIAL_REFRESH_VERTICAL,

		/// <summary>
		/// Strongly typed for value WFD_PARTIAL_REFRESH_HORIZONTAL.
		/// </summary>
		PartialRefreshHorizontal = Wfd.PARTIAL_REFRESH_HORIZONTAL,

		/// <summary>
		/// Strongly typed for value WFD_PARTIAL_REFRESH_BOTH.
		/// </summary>
		PartialRefreshBoth = Wfd.PARTIAL_REFRESH_BOTH,

		/// <summary>
		/// Strongly typed for value WFD_PARTIAL_REFRESH_FORCE_32BIT.
		/// </summary>
		PartialRefreshForce32bit = Wfd.PARTIAL_REFRESH_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDDisplayDataFormat.
	/// </summary>
	public enum WFDDisplayDataFormat
	{
		/// <summary>
		/// Strongly typed for value WFD_DISPLAY_DATA_FORMAT_NONE.
		/// </summary>
		DisplayDataFormatNone = Wfd.DISPLAY_DATA_FORMAT_NONE,

		/// <summary>
		/// Strongly typed for value WFD_DISPLAY_DATA_FORMAT_EDID_V1.
		/// </summary>
		DisplayDataFormatEdidV1 = Wfd.DISPLAY_DATA_FORMAT_EDID_V1,

		/// <summary>
		/// Strongly typed for value WFD_DISPLAY_DATA_FORMAT_EDID_V2.
		/// </summary>
		DisplayDataFormatEdidV2 = Wfd.DISPLAY_DATA_FORMAT_EDID_V2,

		/// <summary>
		/// Strongly typed for value WFD_DISPLAY_DATA_FORMAT_DISPLAYID.
		/// </summary>
		DisplayDataFormatDisplayid = Wfd.DISPLAY_DATA_FORMAT_DISPLAYID,

		/// <summary>
		/// Strongly typed for value WFD_DISPLAY_DATA_FORMAT_FORCE_32BIT.
		/// </summary>
		DisplayDataFormatForce32bit = Wfd.DISPLAY_DATA_FORMAT_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDRotationSupport.
	/// </summary>
	public enum WFDRotationSupport
	{
		/// <summary>
		/// Strongly typed for value WFD_ROTATION_SUPPORT_NONE.
		/// </summary>
		RotationSupportNone = Wfd.ROTATION_SUPPORT_NONE,

		/// <summary>
		/// Strongly typed for value WFD_ROTATION_SUPPORT_LIMITED.
		/// </summary>
		RotationSupportLimited = Wfd.ROTATION_SUPPORT_LIMITED,

		/// <summary>
		/// Strongly typed for value WFD_ROTATION_SUPPORT_FORMAT_FORCE_32BIT.
		/// </summary>
		RotationSupportFormatForce32bit = Wfd.ROTATION_SUPPORT_FORMAT_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDPipelineConfigAttrib.
	/// </summary>
	public enum WFDPipelineConfigAttrib
	{
		/// <summary>
		/// Strongly typed for value WFD_PIPELINE_ID.
		/// </summary>
		PipelineId = Wfd.PIPELINE_ID,

		/// <summary>
		/// Strongly typed for value WFD_PIPELINE_PORTID.
		/// </summary>
		PipelinePortid = Wfd.PIPELINE_PORTID,

		/// <summary>
		/// Strongly typed for value WFD_PIPELINE_LAYER.
		/// </summary>
		PipelineLayer = Wfd.PIPELINE_LAYER,

		/// <summary>
		/// Strongly typed for value WFD_PIPELINE_SHAREABLE.
		/// </summary>
		PipelineShareable = Wfd.PIPELINE_SHAREABLE,

		/// <summary>
		/// Strongly typed for value WFD_PIPELINE_DIRECT_REFRESH.
		/// </summary>
		PipelineDirectRefresh = Wfd.PIPELINE_DIRECT_REFRESH,

		/// <summary>
		/// Strongly typed for value WFD_PIPELINE_MAX_SOURCE_SIZE.
		/// </summary>
		PipelineMaxSourceSize = Wfd.PIPELINE_MAX_SOURCE_SIZE,

		/// <summary>
		/// Strongly typed for value WFD_PIPELINE_SOURCE_RECTANGLE.
		/// </summary>
		PipelineSourceRectangle = Wfd.PIPELINE_SOURCE_RECTANGLE,

		/// <summary>
		/// Strongly typed for value WFD_PIPELINE_FLIP.
		/// </summary>
		PipelineFlip = Wfd.PIPELINE_FLIP,

		/// <summary>
		/// Strongly typed for value WFD_PIPELINE_MIRROR.
		/// </summary>
		PipelineMirror = Wfd.PIPELINE_MIRROR,

		/// <summary>
		/// Strongly typed for value WFD_PIPELINE_ROTATION_SUPPORT.
		/// </summary>
		PipelineRotationSupport = Wfd.PIPELINE_ROTATION_SUPPORT,

		/// <summary>
		/// Strongly typed for value WFD_PIPELINE_ROTATION.
		/// </summary>
		PipelineRotation = Wfd.PIPELINE_ROTATION,

		/// <summary>
		/// Strongly typed for value WFD_PIPELINE_SCALE_RANGE.
		/// </summary>
		PipelineScaleRange = Wfd.PIPELINE_SCALE_RANGE,

		/// <summary>
		/// Strongly typed for value WFD_PIPELINE_SCALE_FILTER.
		/// </summary>
		PipelineScaleFilter = Wfd.PIPELINE_SCALE_FILTER,

		/// <summary>
		/// Strongly typed for value WFD_PIPELINE_DESTINATION_RECTANGLE.
		/// </summary>
		PipelineDestinationRectangle = Wfd.PIPELINE_DESTINATION_RECTANGLE,

		/// <summary>
		/// Strongly typed for value WFD_PIPELINE_TRANSPARENCY_ENABLE.
		/// </summary>
		PipelineTransparencyEnable = Wfd.PIPELINE_TRANSPARENCY_ENABLE,

		/// <summary>
		/// Strongly typed for value WFD_PIPELINE_GLOBAL_ALPHA.
		/// </summary>
		PipelineGlobalAlpha = Wfd.PIPELINE_GLOBAL_ALPHA,

		/// <summary>
		/// Strongly typed for value WFD_PIPELINE_ATTRIB_FORCE_32BIT.
		/// </summary>
		PipelineAttribForce32bit = Wfd.PIPELINE_ATTRIB_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDScaleFilter.
	/// </summary>
	public enum WFDScaleFilter
	{
		/// <summary>
		/// Strongly typed for value WFD_SCALE_FILTER_NONE.
		/// </summary>
		ScaleFilterNone = Wfd.SCALE_FILTER_NONE,

		/// <summary>
		/// Strongly typed for value WFD_SCALE_FILTER_FASTER.
		/// </summary>
		ScaleFilterFaster = Wfd.SCALE_FILTER_FASTER,

		/// <summary>
		/// Strongly typed for value WFD_SCALE_FILTER_BETTER.
		/// </summary>
		ScaleFilterBetter = Wfd.SCALE_FILTER_BETTER,

		/// <summary>
		/// Strongly typed for value WFD_SCALE_FILTER_FORCE_32BIT.
		/// </summary>
		ScaleFilterForce32bit = Wfd.SCALE_FILTER_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDTransparency.
	/// </summary>
	public enum WFDTransparency
	{
		/// <summary>
		/// Strongly typed for value WFD_TRANSPARENCY_NONE.
		/// </summary>
		TransparencyNone = Wfd.TRANSPARENCY_NONE,

		/// <summary>
		/// Strongly typed for value WFD_TRANSPARENCY_SOURCE_COLOR.
		/// </summary>
		TransparencySourceColor = Wfd.TRANSPARENCY_SOURCE_COLOR,

		/// <summary>
		/// Strongly typed for value WFD_TRANSPARENCY_GLOBAL_ALPHA.
		/// </summary>
		TransparencyGlobalAlpha = Wfd.TRANSPARENCY_GLOBAL_ALPHA,

		/// <summary>
		/// Strongly typed for value WFD_TRANSPARENCY_SOURCE_ALPHA.
		/// </summary>
		TransparencySourceAlpha = Wfd.TRANSPARENCY_SOURCE_ALPHA,

		/// <summary>
		/// Strongly typed for value WFD_TRANSPARENCY_MASK.
		/// </summary>
		TransparencyMask = Wfd.TRANSPARENCY_MASK,

		/// <summary>
		/// Strongly typed for value WFD_TRANSPARENCY_FORCE_32BIT.
		/// </summary>
		TransparencyForce32bit = Wfd.TRANSPARENCY_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDTSColorFormat.
	/// </summary>
	public enum WFDTSColorFormat
	{
		/// <summary>
		/// Strongly typed for value WFD_TSC_FORMAT_UINT8_RGB_8_8_8_LINEAR.
		/// </summary>
		TscFormatUint8Rgb888Linear = Wfd.TSC_FORMAT_UINT8_RGB_8_8_8_LINEAR,

		/// <summary>
		/// Strongly typed for value WFD_TSC_FORMAT_UINT8_RGB_5_6_5_LINEAR.
		/// </summary>
		TscFormatUint8Rgb565Linear = Wfd.TSC_FORMAT_UINT8_RGB_5_6_5_LINEAR,

		/// <summary>
		/// Strongly typed for value WFD_TSC_FORMAT_FORCE_32BIT.
		/// </summary>
		TscFormatForce32bit = Wfd.TSC_FORMAT_FORCE_32BIT,

	}

	/// <summary>
	/// Strongly typed enumeration WFDTransition.
	/// </summary>
	public enum WFDTransition
	{
		/// <summary>
		/// Strongly typed for value WFD_TRANSITION_INVALID.
		/// </summary>
		TransitionInvalid = Wfd.TRANSITION_INVALID,

		/// <summary>
		/// Strongly typed for value WFD_TRANSITION_IMMEDIATE.
		/// </summary>
		TransitionImmediate = Wfd.TRANSITION_IMMEDIATE,

		/// <summary>
		/// Strongly typed for value WFD_TRANSITION_AT_VSYNC.
		/// </summary>
		TransitionAtVsync = Wfd.TRANSITION_AT_VSYNC,

		/// <summary>
		/// Strongly typed for value WFD_TRANSITION_FORCE_32BIT.
		/// </summary>
		TransitionForce32bit = Wfd.TRANSITION_FORCE_32BIT,

	}

}
