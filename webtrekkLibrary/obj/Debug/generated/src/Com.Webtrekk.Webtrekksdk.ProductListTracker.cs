using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductListTracker']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/ProductListTracker", DoNotGenerateAcw=true)]
	public partial class ProductListTracker : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/interface[@name='ProductListTracker.ProductListItemCallback']"
		[Register ("com/webtrekk/webtrekksdk/ProductListTracker$ProductListItemCallback", "", "Com.Webtrekk.Webtrekksdk.ProductListTracker/IProductListItemCallbackInvoker")]
		public partial interface IProductListItemCallback : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/interface[@name='ProductListTracker.ProductListItemCallback']/method[@name='getItem' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getItem", "(I)Lcom/webtrekk/webtrekksdk/TrackingParameter;", "GetGetItem_IHandler:Com.Webtrekk.Webtrekksdk.ProductListTracker/IProductListItemCallbackInvoker, webtrekkLibrary")]
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter GetItem (int p0);

		}

		[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/ProductListTracker$ProductListItemCallback", DoNotGenerateAcw=true)]
		internal class IProductListItemCallbackInvoker : global::Java.Lang.Object, IProductListItemCallback {

			internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/webtrekk/webtrekksdk/ProductListTracker$ProductListItemCallback", typeof (IProductListItemCallbackInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static IProductListItemCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IProductListItemCallback> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "com.webtrekk.webtrekksdk.ProductListTracker.ProductListItemCallback"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IProductListItemCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_getItem_I;
#pragma warning disable 0169
			static Delegate GetGetItem_IHandler ()
			{
				if (cb_getItem_I == null)
					cb_getItem_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetItem_I);
				return cb_getItem_I;
			}

			static IntPtr n_GetItem_I (IntPtr jnienv, IntPtr native__this, int p0)
			{
				global::Com.Webtrekk.Webtrekksdk.ProductListTracker.IProductListItemCallback __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductListTracker.IProductListItemCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.GetItem (p0));
			}
#pragma warning restore 0169

			IntPtr id_getItem_I;
			public unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter GetItem (int p0)
			{
				if (id_getItem_I == IntPtr.Zero)
					id_getItem_I = JNIEnv.GetMethodID (class_ref, "getItem", "(I)Lcom/webtrekk/webtrekksdk/TrackingParameter;");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getItem_I, __args), JniHandleOwnership.TransferLocalRef);
			}

		}


		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/ProductListTracker", typeof (ProductListTracker));
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

		protected ProductListTracker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_clearAddPositionData;
#pragma warning disable 0169
		static Delegate GetClearAddPositionDataHandler ()
		{
			if (cb_clearAddPositionData == null)
				cb_clearAddPositionData = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearAddPositionData);
			return cb_clearAddPositionData;
		}

		static void n_ClearAddPositionData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductListTracker __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductListTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAddPositionData ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductListTracker']/method[@name='clearAddPositionData' and count(parameter)=0]"
		[Register ("clearAddPositionData", "()V", "GetClearAddPositionDataHandler")]
		public virtual unsafe void ClearAddPositionData ()
		{
			const string __id = "clearAddPositionData.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_send;
#pragma warning disable 0169
		static Delegate GetSendHandler ()
		{
			if (cb_send == null)
				cb_send = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Send);
			return cb_send;
		}

		static void n_Send (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductListTracker __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductListTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Send ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductListTracker']/method[@name='send' and count(parameter)=0]"
		[Register ("send", "()V", "GetSendHandler")]
		public virtual unsafe void Send ()
		{
			const string __id = "send.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_send_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
#pragma warning disable 0169
		static Delegate GetSend_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler ()
		{
			if (cb_send_Lcom_webtrekk_webtrekksdk_TrackingParameter_ == null)
				cb_send_Lcom_webtrekk_webtrekksdk_TrackingParameter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Send_Lcom_webtrekk_webtrekksdk_TrackingParameter_);
			return cb_send_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
		}

		static void n_Send_Lcom_webtrekk_webtrekksdk_TrackingParameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_commonParameters)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductListTracker __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductListTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter commonParameters = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (native_commonParameters, JniHandleOwnership.DoNotTransfer);
			__this.Send (commonParameters);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductListTracker']/method[@name='send' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter']]"
		[Register ("send", "(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V", "GetSend_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler")]
		public virtual unsafe void Send (global::Com.Webtrekk.Webtrekksdk.TrackingParameter commonParameters)
		{
			const string __id = "send.(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((commonParameters == null) ? IntPtr.Zero : ((global::Java.Lang.Object) commonParameters).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_trackProduct_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
#pragma warning disable 0169
		static Delegate GetTrackProduct_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler ()
		{
			if (cb_trackProduct_Lcom_webtrekk_webtrekksdk_TrackingParameter_ == null)
				cb_trackProduct_Lcom_webtrekk_webtrekksdk_TrackingParameter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TrackProduct_Lcom_webtrekk_webtrekksdk_TrackingParameter_);
			return cb_trackProduct_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
		}

		static void n_TrackProduct_Lcom_webtrekk_webtrekksdk_TrackingParameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameter)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductListTracker __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductListTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter parameter = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (native_parameter, JniHandleOwnership.DoNotTransfer);
			__this.TrackProduct (parameter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductListTracker']/method[@name='trackProduct' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter']]"
		[Register ("trackProduct", "(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V", "GetTrackProduct_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler")]
		public virtual unsafe void TrackProduct (global::Com.Webtrekk.Webtrekksdk.TrackingParameter parameter)
		{
			const string __id = "trackProduct.(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameter).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_trackProduct_Lcom_webtrekk_webtrekksdk_TrackingParameter_Z;
#pragma warning disable 0169
		static Delegate GetTrackProduct_Lcom_webtrekk_webtrekksdk_TrackingParameter_ZHandler ()
		{
			if (cb_trackProduct_Lcom_webtrekk_webtrekksdk_TrackingParameter_Z == null)
				cb_trackProduct_Lcom_webtrekk_webtrekksdk_TrackingParameter_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_TrackProduct_Lcom_webtrekk_webtrekksdk_TrackingParameter_Z);
			return cb_trackProduct_Lcom_webtrekk_webtrekksdk_TrackingParameter_Z;
		}

		static void n_TrackProduct_Lcom_webtrekk_webtrekksdk_TrackingParameter_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_parameter, bool sendImmediately)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductListTracker __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductListTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter parameter = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (native_parameter, JniHandleOwnership.DoNotTransfer);
			__this.TrackProduct (parameter, sendImmediately);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductListTracker']/method[@name='trackProduct' and count(parameter)=2 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter'] and parameter[2][@type='boolean']]"
		[Register ("trackProduct", "(Lcom/webtrekk/webtrekksdk/TrackingParameter;Z)V", "GetTrackProduct_Lcom_webtrekk_webtrekksdk_TrackingParameter_ZHandler")]
		public virtual unsafe void TrackProduct (global::Com.Webtrekk.Webtrekksdk.TrackingParameter parameter, bool sendImmediately)
		{
			const string __id = "trackProduct.(Lcom/webtrekk/webtrekksdk/TrackingParameter;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((parameter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameter).Handle);
				__args [1] = new JniArgumentValue (sendImmediately);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_trackProductPositionInList_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
#pragma warning disable 0169
		static Delegate GetTrackProductPositionInList_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler ()
		{
			if (cb_trackProductPositionInList_Lcom_webtrekk_webtrekksdk_TrackingParameter_ == null)
				cb_trackProductPositionInList_Lcom_webtrekk_webtrekksdk_TrackingParameter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_TrackProductPositionInList_Lcom_webtrekk_webtrekksdk_TrackingParameter_);
			return cb_trackProductPositionInList_Lcom_webtrekk_webtrekksdk_TrackingParameter_;
		}

		static void n_TrackProductPositionInList_Lcom_webtrekk_webtrekksdk_TrackingParameter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_parameter)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductListTracker __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductListTracker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Webtrekk.Webtrekksdk.TrackingParameter parameter = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (native_parameter, JniHandleOwnership.DoNotTransfer);
			__this.TrackProductPositionInList (parameter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductListTracker']/method[@name='trackProductPositionInList' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.TrackingParameter']]"
		[Register ("trackProductPositionInList", "(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V", "GetTrackProductPositionInList_Lcom_webtrekk_webtrekksdk_TrackingParameter_Handler")]
		public virtual unsafe void TrackProductPositionInList (global::Com.Webtrekk.Webtrekksdk.TrackingParameter parameter)
		{
			const string __id = "trackProductPositionInList.(Lcom/webtrekk/webtrekksdk/TrackingParameter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((parameter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) parameter).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
