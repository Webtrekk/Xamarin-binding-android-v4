using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk.Modules {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ProductListOrderSaver']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Modules/ProductListOrderSaver", DoNotGenerateAcw=true)]
	public partial class ProductListOrderSaver : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ProductListOrderSaver']/field[@name='NOT_DEFINED_ORDER']"
		[Register ("NOT_DEFINED_ORDER")]
		public const int NotDefinedOrder = (int) 2147483647;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Modules/ProductListOrderSaver", typeof (ProductListOrderSaver));
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

		protected ProductListOrderSaver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ProductListOrderSaver']/constructor[@name='ProductListOrderSaver' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ProductListOrderSaver (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Modules.ProductListOrderSaver __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.ProductListOrderSaver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ProductListOrderSaver']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getProductAddOrderPosition_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetProductAddOrderPosition_Ljava_lang_String_Handler ()
		{
			if (cb_getProductAddOrderPosition_Ljava_lang_String_ == null)
				cb_getProductAddOrderPosition_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetProductAddOrderPosition_Ljava_lang_String_);
			return cb_getProductAddOrderPosition_Ljava_lang_String_;
		}

		static int n_GetProductAddOrderPosition_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_productId)
		{
			global::Com.Webtrekk.Webtrekksdk.Modules.ProductListOrderSaver __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.ProductListOrderSaver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string productId = JNIEnv.GetString (native_productId, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetProductAddOrderPosition (productId);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ProductListOrderSaver']/method[@name='getProductAddOrderPosition' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getProductAddOrderPosition", "(Ljava/lang/String;)I", "GetGetProductAddOrderPosition_Ljava_lang_String_Handler")]
		public virtual unsafe int GetProductAddOrderPosition (string productId)
		{
			const string __id = "getProductAddOrderPosition.(Ljava/lang/String;)I";
			IntPtr native_productId = JNIEnv.NewString (productId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_productId);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_productId);
			}
		}

		static Delegate cb_getProductFirstDefinedPosition_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetProductFirstDefinedPosition_Ljava_lang_String_Handler ()
		{
			if (cb_getProductFirstDefinedPosition_Ljava_lang_String_ == null)
				cb_getProductFirstDefinedPosition_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetProductFirstDefinedPosition_Ljava_lang_String_);
			return cb_getProductFirstDefinedPosition_Ljava_lang_String_;
		}

		static int n_GetProductFirstDefinedPosition_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_productId)
		{
			global::Com.Webtrekk.Webtrekksdk.Modules.ProductListOrderSaver __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.ProductListOrderSaver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string productId = JNIEnv.GetString (native_productId, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetProductFirstDefinedPosition (productId);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ProductListOrderSaver']/method[@name='getProductFirstDefinedPosition' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getProductFirstDefinedPosition", "(Ljava/lang/String;)I", "GetGetProductFirstDefinedPosition_Ljava_lang_String_Handler")]
		public virtual unsafe int GetProductFirstDefinedPosition (string productId)
		{
			const string __id = "getProductFirstDefinedPosition.(Ljava/lang/String;)I";
			IntPtr native_productId = JNIEnv.NewString (productId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_productId);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_productId);
			}
		}

		static Delegate cb_getProductLastDefinedPosition_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetProductLastDefinedPosition_Ljava_lang_String_Handler ()
		{
			if (cb_getProductLastDefinedPosition_Ljava_lang_String_ == null)
				cb_getProductLastDefinedPosition_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetProductLastDefinedPosition_Ljava_lang_String_);
			return cb_getProductLastDefinedPosition_Ljava_lang_String_;
		}

		static int n_GetProductLastDefinedPosition_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_productId)
		{
			global::Com.Webtrekk.Webtrekksdk.Modules.ProductListOrderSaver __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.ProductListOrderSaver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string productId = JNIEnv.GetString (native_productId, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetProductLastDefinedPosition (productId);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ProductListOrderSaver']/method[@name='getProductLastDefinedPosition' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getProductLastDefinedPosition", "(Ljava/lang/String;)I", "GetGetProductLastDefinedPosition_Ljava_lang_String_Handler")]
		public virtual unsafe int GetProductLastDefinedPosition (string productId)
		{
			const string __id = "getProductLastDefinedPosition.(Ljava/lang/String;)I";
			IntPtr native_productId = JNIEnv.NewString (productId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_productId);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_productId);
			}
		}

		static Delegate cb_load;
#pragma warning disable 0169
		static Delegate GetLoadHandler ()
		{
			if (cb_load == null)
				cb_load = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Load);
			return cb_load;
		}

		static void n_Load (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Modules.ProductListOrderSaver __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.ProductListOrderSaver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Load ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ProductListOrderSaver']/method[@name='load' and count(parameter)=0]"
		[Register ("load", "()V", "GetLoadHandler")]
		public virtual unsafe void Load ()
		{
			const string __id = "load.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_savePermanent;
#pragma warning disable 0169
		static Delegate GetSavePermanentHandler ()
		{
			if (cb_savePermanent == null)
				cb_savePermanent = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SavePermanent);
			return cb_savePermanent;
		}

		static void n_SavePermanent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Modules.ProductListOrderSaver __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.ProductListOrderSaver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SavePermanent ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ProductListOrderSaver']/method[@name='savePermanent' and count(parameter)=0]"
		[Register ("savePermanent", "()V", "GetSavePermanentHandler")]
		public virtual unsafe void SavePermanent ()
		{
			const string __id = "savePermanent.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_saveProductPositions_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetSaveProductPositions_Ljava_util_Map_Handler ()
		{
			if (cb_saveProductPositions_Ljava_util_Map_ == null)
				cb_saveProductPositions_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SaveProductPositions_Ljava_util_Map_);
			return cb_saveProductPositions_Ljava_util_Map_;
		}

		static void n_SaveProductPositions_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parametersToTrack)
		{
			global::Com.Webtrekk.Webtrekksdk.Modules.ProductListOrderSaver __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.ProductListOrderSaver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var parametersToTrack = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Com.Webtrekk.Webtrekksdk.TrackingParameter>.FromJniHandle (native_parametersToTrack, JniHandleOwnership.DoNotTransfer);
			__this.SaveProductPositions (parametersToTrack);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ProductListOrderSaver']/method[@name='saveProductPositions' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.Integer, com.webtrekk.webtrekksdk.TrackingParameter&gt;']]"
		[Register ("saveProductPositions", "(Ljava/util/Map;)V", "GetSaveProductPositions_Ljava_util_Map_Handler")]
		public virtual unsafe void SaveProductPositions (global::System.Collections.Generic.IDictionary<global::Java.Lang.Integer, global::Com.Webtrekk.Webtrekksdk.TrackingParameter> parametersToTrack)
		{
			const string __id = "saveProductPositions.(Ljava/util/Map;)V";
			IntPtr native_parametersToTrack = global::Android.Runtime.JavaDictionary<global::Java.Lang.Integer, global::Com.Webtrekk.Webtrekksdk.TrackingParameter>.ToLocalJniHandle (parametersToTrack);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_parametersToTrack);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_parametersToTrack);
			}
		}

		static Delegate cb_trackAddedProducts_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
#pragma warning disable 0169
		static Delegate GetTrackAddedProducts_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler ()
		{
			if (cb_trackAddedProducts_Lcom_webtrekk_webtrekksdk_TrackingParameter_ == null)
				cb_trackAddedProducts_Lcom_webtrekk_webtrekksdk_TrackingParameter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TrackAddedProducts_Lcom_webtrekk_webtrekksdk_TrackingParameter_);
			return cb_trackAddedProducts_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
		}

		static void n_TrackAddedProducts_Lcom_webtrekk_webtrekksdk_TrackingParameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameter)
		{
			global::Com.Webtrekk.Webtrekksdk.Modules.ProductListOrderSaver __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.ProductListOrderSaver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter parameter = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (native_parameter, JniHandleOwnership.DoNotTransfer);
			__this.TrackAddedProducts (parameter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='ProductListOrderSaver']/method[@name='trackAddedProducts' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter']]"
		[Register ("trackAddedProducts", "(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V", "GetTrackAddedProducts_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler")]
		public virtual unsafe void TrackAddedProducts (global::Com.Webtrekk.Webtrekksdk.TrackingParameter parameter)
		{
			const string __id = "trackAddedProducts.(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameter).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
