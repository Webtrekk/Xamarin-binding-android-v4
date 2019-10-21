using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk.Request {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Request/TrackingRequest", DoNotGenerateAcw=true)]
	public partial class TrackingRequest : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest']/field[@name='mTrackingParameter']"
		[Register ("mTrackingParameter")]
		public global::Com.Webtrekk.Webtrekksdk.TrackingParameter MTrackingParameter {
			get {
				const string __id = "mTrackingParameter.Lcom/webtrekk/webtrekksdk/TrackingParameter;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTrackingParameter.Lcom/webtrekk/webtrekksdk/TrackingParameter;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest.RequestType']"
		[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Request/TrackingRequest$RequestType", DoNotGenerateAcw=true)]
		public sealed partial class RequestType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest.RequestType']/field[@name='CDB']"
			[Register ("CDB")]
			public static global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest.RequestType Cdb {
				get {
					const string __id = "CDB.Lcom/webtrekk/webtrekksdk/Request/TrackingRequest$RequestType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest.RequestType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest.RequestType']/field[@name='ECXEPTION']"
			[Register ("ECXEPTION")]
			public static global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest.RequestType Ecxeption {
				get {
					const string __id = "ECXEPTION.Lcom/webtrekk/webtrekksdk/Request/TrackingRequest$RequestType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest.RequestType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest.RequestType']/field[@name='GENERAL']"
			[Register ("GENERAL")]
			public static global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest.RequestType General {
				get {
					const string __id = "GENERAL.Lcom/webtrekk/webtrekksdk/Request/TrackingRequest$RequestType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest.RequestType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest.RequestType']/field[@name='INSTALL']"
			[Register ("INSTALL")]
			public static global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest.RequestType Install {
				get {
					const string __id = "INSTALL.Lcom/webtrekk/webtrekksdk/Request/TrackingRequest$RequestType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest.RequestType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Request/TrackingRequest$RequestType", typeof (RequestType));
			internal static new IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal RequestType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest.RequestType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/Request/TrackingRequest$RequestType;", "")]
			public static unsafe global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest.RequestType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/Request/TrackingRequest$RequestType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest.RequestType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest.RequestType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/webtrekk/webtrekksdk/Request/TrackingRequest$RequestType;", "")]
			public static unsafe global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest.RequestType[] Values ()
			{
				const string __id = "values.()[Lcom/webtrekk/webtrekksdk/Request/TrackingRequest$RequestType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest.RequestType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest.RequestType));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Request/TrackingRequest", typeof (TrackingRequest));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected TrackingRequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest']/constructor[@name='TrackingRequest' and count(parameter)=2 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter'] and parameter[2][@type='com.webtrekk.webtrekksdk.Configuration.TrackingConfiguration']]"
		[Register (".ctor", "(Lcom/webtrekk/webtrekksdk/TrackingParameter;Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;)V", "")]
		public unsafe TrackingRequest (global::Com.Webtrekk.Webtrekksdk.TrackingParameter tp, global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration trackingConfiguration)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/webtrekk/webtrekksdk/TrackingParameter;Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((tp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tp).Handle);
				__args [1] = new JniArgumentValue ((trackingConfiguration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackingConfiguration).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest']/constructor[@name='TrackingRequest' and count(parameter)=3 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter'] and parameter[2][@type='com.webtrekk.webtrekksdk.Configuration.TrackingConfiguration'] and parameter[3][@type='com.webtrekk.webtrekksdk.Request.TrackingRequest.RequestType']]"
		[Register (".ctor", "(Lcom/webtrekk/webtrekksdk/TrackingParameter;Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;Lcom/webtrekk/webtrekksdk/Request/TrackingRequest$RequestType;)V", "")]
		public unsafe TrackingRequest (global::Com.Webtrekk.Webtrekksdk.TrackingParameter tp, global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration trackingConfiguration, global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest.RequestType type)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/webtrekk/webtrekksdk/TrackingParameter;Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;Lcom/webtrekk/webtrekksdk/Request/TrackingRequest$RequestType;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((tp == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tp).Handle);
				__args [1] = new JniArgumentValue ((trackingConfiguration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackingConfiguration).Handle);
				__args [2] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getRequestSize;
#pragma warning disable 0169
		static Delegate GetGetRequestSizeHandler ()
		{
			if (cb_getRequestSize == null)
				cb_getRequestSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRequestSize);
			return cb_getRequestSize;
		}

		static int n_GetRequestSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestSize;
		}
#pragma warning restore 0169

		public virtual unsafe int RequestSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest']/method[@name='getRequestSize' and count(parameter)=0]"
			[Register ("getRequestSize", "()I", "GetGetRequestSizeHandler")]
			get {
				const string __id = "getRequestSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTrackingConfiguration;
#pragma warning disable 0169
		static Delegate GetGetTrackingConfigurationHandler ()
		{
			if (cb_getTrackingConfiguration == null)
				cb_getTrackingConfiguration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackingConfiguration);
			return cb_getTrackingConfiguration;
		}

		static IntPtr n_GetTrackingConfiguration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackingConfiguration);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration TrackingConfiguration {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest']/method[@name='getTrackingConfiguration' and count(parameter)=0]"
			[Register ("getTrackingConfiguration", "()Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;", "GetGetTrackingConfigurationHandler")]
			get {
				const string __id = "getTrackingConfiguration.()Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackingParameter;
#pragma warning disable 0169
		static Delegate GetGetTrackingParameterHandler ()
		{
			if (cb_getTrackingParameter == null)
				cb_getTrackingParameter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackingParameter);
			return cb_getTrackingParameter;
		}

		static IntPtr n_GetTrackingParameter (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TrackingParameter);
		}
#pragma warning restore 0169

		static Delegate cb_setTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
#pragma warning disable 0169
		static Delegate GetSetTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler ()
		{
			if (cb_setTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_ == null)
				cb_setTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_);
			return cb_setTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
		}

		static void n_SetTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_trackingParameter)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter trackingParameter = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (native_trackingParameter, JniHandleOwnership.DoNotTransfer);
			__this.TrackingParameter = trackingParameter;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter TrackingParameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest']/method[@name='getTrackingParameter' and count(parameter)=0]"
			[Register ("getTrackingParameter", "()Lcom/webtrekk/webtrekksdk/TrackingParameter;", "GetGetTrackingParameterHandler")]
			get {
				const string __id = "getTrackingParameter.()Lcom/webtrekk/webtrekksdk/TrackingParameter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest']/method[@name='setTrackingParameter' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter']]"
			[Register ("setTrackingParameter", "(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V", "GetSetTrackingParameter_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler")]
			set {
				const string __id = "setTrackingParameter.(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUrlString;
#pragma warning disable 0169
		static Delegate GetGetUrlStringHandler ()
		{
			if (cb_getUrlString == null)
				cb_getUrlString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUrlString);
			return cb_getUrlString;
		}

		static IntPtr n_GetUrlString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UrlString);
		}
#pragma warning restore 0169

		public virtual unsafe string UrlString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest']/method[@name='getUrlString' and count(parameter)=0]"
			[Register ("getUrlString", "()Ljava/lang/String;", "GetGetUrlStringHandler")]
			get {
				const string __id = "getUrlString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest']/method[@name='createFromJson' and count(parameter)=2 and parameter[1][@type='org.json.JSONObject'] and parameter[2][@type='com.webtrekk.webtrekksdk.Configuration.TrackingConfiguration']]"
		[Register ("createFromJson", "(Lorg/json/JSONObject;Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;)Lcom/webtrekk/webtrekksdk/Request/TrackingRequest;", "")]
		public static unsafe global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest CreateFromJson (global::Org.Json.JSONObject jsonObject, global::Com.Webtrekk.Webtrekksdk.Configuration.TrackingConfiguration trackingConfiguration)
		{
			const string __id = "createFromJson.(Lorg/json/JSONObject;Lcom/webtrekk/webtrekksdk/Configuration/TrackingConfiguration;)Lcom/webtrekk/webtrekksdk/Request/TrackingRequest;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((jsonObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jsonObject).Handle);
				__args [1] = new JniArgumentValue ((trackingConfiguration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trackingConfiguration).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMergedRequest_Lcom_webtrekk_webtrekksdk_Request_TrackingRequest_RequestType_;
#pragma warning disable 0169
		static Delegate GetSetMergedRequest_Lcom_webtrekk_webtrekksdk_Request_TrackingRequest_RequestType_Handler ()
		{
			if (cb_setMergedRequest_Lcom_webtrekk_webtrekksdk_Request_TrackingRequest_RequestType_ == null)
				cb_setMergedRequest_Lcom_webtrekk_webtrekksdk_Request_TrackingRequest_RequestType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMergedRequest_Lcom_webtrekk_webtrekksdk_Request_TrackingRequest_RequestType_);
			return cb_setMergedRequest_Lcom_webtrekk_webtrekksdk_Request_TrackingRequest_RequestType_;
		}

		static void n_SetMergedRequest_Lcom_webtrekk_webtrekksdk_Request_TrackingRequest_RequestType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest.RequestType type = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest.RequestType> (native_type, JniHandleOwnership.DoNotTransfer);
			__this.SetMergedRequest (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Request']/class[@name='TrackingRequest']/method[@name='setMergedRequest' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.Request.TrackingRequest.RequestType']]"
		[Register ("setMergedRequest", "(Lcom/webtrekk/webtrekksdk/Request/TrackingRequest$RequestType;)V", "GetSetMergedRequest_Lcom_webtrekk_webtrekksdk_Request_TrackingRequest_RequestType_Handler")]
		public virtual unsafe void SetMergedRequest (global::Com.Webtrekk.Webtrekksdk.Request.TrackingRequest.RequestType type)
		{
			const string __id = "setMergedRequest.(Lcom/webtrekk/webtrekksdk/Request/TrackingRequest$RequestType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
