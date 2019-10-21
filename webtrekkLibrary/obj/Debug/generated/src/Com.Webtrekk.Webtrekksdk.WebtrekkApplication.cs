using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkApplication']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/WebtrekkApplication", DoNotGenerateAcw=true)]
	public partial class WebtrekkApplication : global::Android.App.Application {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/WebtrekkApplication", typeof (WebtrekkApplication));
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

		protected WebtrekkApplication (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkApplication']/constructor[@name='WebtrekkApplication' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WebtrekkApplication ()
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

		static Delegate cb_getWebtrekk;
#pragma warning disable 0169
		static Delegate GetGetWebtrekkHandler ()
		{
			if (cb_getWebtrekk == null)
				cb_getWebtrekk = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWebtrekk);
			return cb_getWebtrekk;
		}

		static IntPtr n_GetWebtrekk (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.WebtrekkApplication __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.WebtrekkApplication> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Webtrekk);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.Webtrekk Webtrekk {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='WebtrekkApplication']/method[@name='getWebtrekk' and count(parameter)=0]"
			[Register ("getWebtrekk", "()Lcom/webtrekk/webtrekksdk/Webtrekk;", "GetGetWebtrekkHandler")]
			get {
				const string __id = "getWebtrekk.()Lcom/webtrekk/webtrekksdk/Webtrekk;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Webtrekk> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
