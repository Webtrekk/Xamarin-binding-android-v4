using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk.Modules {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='Campaign']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/Modules/Campaign", DoNotGenerateAcw=true)]
	public partial class Campaign : global::Java.Lang.Thread {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/Modules/Campaign", typeof (Campaign));
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

		protected Campaign (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='Campaign']/method[@name='getAdvId' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getAdvId", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetAdvId (global::Android.Content.Context context)
		{
			const string __id = "getAdvId.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='Campaign']/method[@name='getFirstStartInitiated' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='boolean']]"
		[Register ("getFirstStartInitiated", "(Landroid/content/Context;Z)Z", "")]
		public static unsafe bool GetFirstStartInitiated (global::Android.Content.Context context, bool deleteFlag)
		{
			const string __id = "getFirstStartInitiated.(Landroid/content/Context;Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (deleteFlag);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='Campaign']/method[@name='getFirstStartInitiatedTime' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getFirstStartInitiatedTime", "(Landroid/content/Context;)J", "")]
		public static unsafe long GetFirstStartInitiatedTime (global::Android.Content.Context context)
		{
			const string __id = "getFirstStartInitiatedTime.(Landroid/content/Context;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='Campaign']/method[@name='getMediaCode' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getMediaCode", "(Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string GetMediaCode (global::Android.Content.Context context)
		{
			const string __id = "getMediaCode.(Landroid/content/Context;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='Campaign']/method[@name='getOptOut' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("getOptOut", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool GetOptOut (global::Android.Content.Context context)
		{
			const string __id = "getOptOut.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='Campaign']/method[@name='isCampaignProcessingFinished' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("isCampaignProcessingFinished", "(Landroid/content/Context;)Z", "")]
		public static unsafe bool IsCampaignProcessingFinished (global::Android.Content.Context context)
		{
			const string __id = "isCampaignProcessingFinished.(Landroid/content/Context;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk.Modules']/class[@name='Campaign']/method[@name='start' and count(parameter)=6 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='com.webtrekk.webtrekksdk.Utils.PinConnectionValidator']]"
		[Register ("start", "(Landroid/content/Context;Ljava/lang/String;ZZZLcom/webtrekk/webtrekksdk/Utils/PinConnectionValidator;)Lcom/webtrekk/webtrekksdk/Modules/Campaign;", "")]
		public static unsafe global::Com.Webtrekk.Webtrekksdk.Modules.Campaign Start (global::Android.Content.Context context, string trackID, bool isFirstStart, bool isAutoTrackAdvID, bool enableCampaign, global::Com.Webtrekk.Webtrekksdk.Utils.PinConnectionValidator validator)
		{
			const string __id = "start.(Landroid/content/Context;Ljava/lang/String;ZZZLcom/webtrekk/webtrekksdk/Utils/PinConnectionValidator;)Lcom/webtrekk/webtrekksdk/Modules/Campaign;";
			IntPtr native_trackID = JNIEnv.NewString (trackID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_trackID);
				__args [2] = new JniArgumentValue (isFirstStart);
				__args [3] = new JniArgumentValue (isAutoTrackAdvID);
				__args [4] = new JniArgumentValue (enableCampaign);
				__args [5] = new JniArgumentValue ((validator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) validator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.Modules.Campaign> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_trackID);
			}
		}

	}
}
