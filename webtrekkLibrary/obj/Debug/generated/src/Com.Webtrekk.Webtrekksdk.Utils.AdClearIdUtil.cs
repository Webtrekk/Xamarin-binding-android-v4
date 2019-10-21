using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='AdClearIdUtil']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Utils/AdClearIdUtil", DoNotGenerateAcw=true)]
	public sealed partial class AdClearIdUtil : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='AdClearIdUtil']/field[@name='PREFERENCE_KEY_ADCLEAR_ID']"
		[Register ("PREFERENCE_KEY_ADCLEAR_ID")]
		public const string PreferenceKeyAdclearId = (string) "adClearId";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Utils/AdClearIdUtil", typeof (AdClearIdUtil));
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

		internal AdClearIdUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='AdClearIdUtil']/constructor[@name='AdClearIdUtil' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AdClearIdUtil ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='AdClearIdUtil']/method[@name='combineAdClearId' and count(parameter)=4 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long']]"
		[Register ("combineAdClearId", "(JJJJ)J", "")]
		public unsafe long CombineAdClearId (long diffInMilliseconds, long rand, long applicationId, long processId)
		{
			const string __id = "combineAdClearId.(JJJJ)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (diffInMilliseconds);
				__args [1] = new JniArgumentValue (rand);
				__args [2] = new JniArgumentValue (applicationId);
				__args [3] = new JniArgumentValue (processId);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='AdClearIdUtil']/method[@name='generateAdClearId' and count(parameter)=0]"
		[Register ("generateAdClearId", "()J", "")]
		public unsafe long GenerateAdClearId ()
		{
			const string __id = "generateAdClearId.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='AdClearIdUtil']/method[@name='limitToBits' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("limitToBits", "(JI)J", "")]
		public unsafe long LimitToBits (long v, int maxBits)
		{
			const string __id = "limitToBits.(JI)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (v);
				__args [1] = new JniArgumentValue (maxBits);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Utils']/class[@name='AdClearIdUtil']/method[@name='sanitize' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("sanitize", "(JI)J", "")]
		public unsafe long Sanitize (long l, int maxBits)
		{
			const string __id = "sanitize.(JI)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (l);
				__args [1] = new JniArgumentValue (maxBits);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
