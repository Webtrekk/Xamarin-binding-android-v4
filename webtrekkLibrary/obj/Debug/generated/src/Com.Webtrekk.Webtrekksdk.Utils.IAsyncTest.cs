using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk.Utils {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/interface[@name='AsyncTest']"
	[Register ("com/webtrekk/webtrekksdk/Utils/AsyncTest", "", "Com.Webtrekk.Webtrekksdk.Utils.IAsyncTestInvoker")]
	public partial interface IAsyncTest : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/interface[@name='AsyncTest']/method[@name='workDone' and count(parameter)=0]"
		[Register ("workDone", "()V", "GetWorkDoneHandler:Com.Webtrekk.Webtrekksdk.Utils.IAsyncTestInvoker, webtrekkLibrary")]
		void WorkDone ();

	}

	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Utils/AsyncTest", DoNotGenerateAcw=true)]
	internal class IAsyncTestInvoker : global::Java.Lang.Object, IAsyncTest {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/webtrekk/webtrekksdk/Utils/AsyncTest", typeof (IAsyncTestInvoker));

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

		public static IAsyncTest GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAsyncTest> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.webtrekk.webtrekksdk.Utils.AsyncTest"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAsyncTestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_workDone;
#pragma warning disable 0169
		static Delegate GetWorkDoneHandler ()
		{
			if (cb_workDone == null)
				cb_workDone = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_WorkDone);
			return cb_workDone;
		}

		static void n_WorkDone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.Utils.IAsyncTest __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Utils.IAsyncTest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WorkDone ();
		}
#pragma warning restore 0169

		IntPtr id_workDone;
		public unsafe void WorkDone ()
		{
			if (id_workDone == IntPtr.Zero)
				id_workDone = JNIEnv.GetMethodID (class_ref, "workDone", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_workDone);
		}

	}

}
