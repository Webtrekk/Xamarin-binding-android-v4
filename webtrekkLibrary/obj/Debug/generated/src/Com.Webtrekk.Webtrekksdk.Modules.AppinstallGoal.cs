using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk.Modules {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='AppinstallGoal']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Modules/AppinstallGoal", DoNotGenerateAcw=true)]
	public partial class AppinstallGoal : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Modules/AppinstallGoal", typeof (AppinstallGoal));
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

		protected AppinstallGoal (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='AppinstallGoal']/constructor[@name='AppinstallGoal' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AppinstallGoal ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_finishAppinstallGoal_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetFinishAppinstallGoal_Landroid_content_Context_Handler ()
		{
			if (cb_finishAppinstallGoal_Landroid_content_Context_ == null)
				cb_finishAppinstallGoal_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FinishAppinstallGoal_Landroid_content_Context_);
			return cb_finishAppinstallGoal_Landroid_content_Context_;
		}

		static void n_FinishAppinstallGoal_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Webtrekk.Webtrekksdk.Modules.AppinstallGoal __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.AppinstallGoal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.FinishAppinstallGoal (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='AppinstallGoal']/method[@name='finishAppinstallGoal' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("finishAppinstallGoal", "(Landroid/content/Context;)V", "GetFinishAppinstallGoal_Landroid_content_Context_Handler")]
		public virtual unsafe void FinishAppinstallGoal (global::Android.Content.Context context)
		{
			const string __id = "finishAppinstallGoal.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_initAppinstallGoal_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInitAppinstallGoal_Landroid_content_Context_Handler ()
		{
			if (cb_initAppinstallGoal_Landroid_content_Context_ == null)
				cb_initAppinstallGoal_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_InitAppinstallGoal_Landroid_content_Context_);
			return cb_initAppinstallGoal_Landroid_content_Context_;
		}

		static void n_InitAppinstallGoal_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Webtrekk.Webtrekksdk.Modules.AppinstallGoal __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.AppinstallGoal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.InitAppinstallGoal (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='AppinstallGoal']/method[@name='initAppinstallGoal' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("initAppinstallGoal", "(Landroid/content/Context;)V", "GetInitAppinstallGoal_Landroid_content_Context_Handler")]
		public virtual unsafe void InitAppinstallGoal (global::Android.Content.Context context)
		{
			const string __id = "initAppinstallGoal.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isAppinstallGoal_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetIsAppinstallGoal_Landroid_content_Context_Handler ()
		{
			if (cb_isAppinstallGoal_Landroid_content_Context_ == null)
				cb_isAppinstallGoal_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsAppinstallGoal_Landroid_content_Context_);
			return cb_isAppinstallGoal_Landroid_content_Context_;
		}

		static bool n_IsAppinstallGoal_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Webtrekk.Webtrekksdk.Modules.AppinstallGoal __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.AppinstallGoal> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsAppinstallGoal (context);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='AppinstallGoal']/method[@name='isAppinstallGoal' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isAppinstallGoal", "(Landroid/content/Context;)Z", "GetIsAppinstallGoal_Landroid_content_Context_Handler")]
		public virtual unsafe bool IsAppinstallGoal (global::Android.Content.Context context)
		{
			const string __id = "isAppinstallGoal.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
