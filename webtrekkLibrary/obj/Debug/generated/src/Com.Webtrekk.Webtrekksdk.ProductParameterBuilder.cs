using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Webtrekk.Webtrekksdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']"
	[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/ProductParameterBuilder", DoNotGenerateAcw=true)]
	public partial class ProductParameterBuilder : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder.ActionType']"
		[global::Android.Runtime.Register ("com/webtrekk/webtrekksdk/ProductParameterBuilder$ActionType", DoNotGenerateAcw=true)]
		public sealed partial class ActionType : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder.ActionType']/field[@name='add']"
			[Register ("add")]
			public static global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder.ActionType Add {
				get {
					const string __id = "add.Lcom/webtrekk/webtrekksdk/ProductParameterBuilder$ActionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder.ActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder.ActionType']/field[@name='common']"
			[Register ("common")]
			public static global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder.ActionType Common {
				get {
					const string __id = "common.Lcom/webtrekk/webtrekksdk/ProductParameterBuilder$ActionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder.ActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder.ActionType']/field[@name='conf']"
			[Register ("conf")]
			public static global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder.ActionType Conf {
				get {
					const string __id = "conf.Lcom/webtrekk/webtrekksdk/ProductParameterBuilder$ActionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder.ActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder.ActionType']/field[@name='list']"
			[Register ("list")]
			public static global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder.ActionType List {
				get {
					const string __id = "list.Lcom/webtrekk/webtrekksdk/ProductParameterBuilder$ActionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder.ActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder.ActionType']/field[@name='view']"
			[Register ("view")]
			public static global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder.ActionType View {
				get {
					const string __id = "view.Lcom/webtrekk/webtrekksdk/ProductParameterBuilder$ActionType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder.ActionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/ProductParameterBuilder$ActionType", typeof (ActionType));
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

			internal ActionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder.ActionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder$ActionType;", "")]
			public static unsafe global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder.ActionType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder$ActionType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder.ActionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder.ActionType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/webtrekk/webtrekksdk/ProductParameterBuilder$ActionType;", "")]
			public static unsafe global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder.ActionType[] Values ()
			{
				const string __id = "values.()[Lcom/webtrekk/webtrekksdk/ProductParameterBuilder$ActionType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder.ActionType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder.ActionType));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/webtrekk/webtrekksdk/ProductParameterBuilder", typeof (ProductParameterBuilder));
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

		protected ProductParameterBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']/constructor[@name='ProductParameterBuilder' and count(parameter)=1 and parameter[1][@type='com.webtrekk.webtrekksdk.ProductParameterBuilder.ActionType']]"
		[Register (".ctor", "(Lcom/webtrekk/webtrekksdk/ProductParameterBuilder$ActionType;)V", "")]
		public unsafe ProductParameterBuilder (global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder.ActionType type)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/webtrekk/webtrekksdk/ProductParameterBuilder$ActionType;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']/constructor[@name='ProductParameterBuilder' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.webtrekk.webtrekksdk.ProductParameterBuilder.ActionType']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/webtrekk/webtrekksdk/ProductParameterBuilder$ActionType;)V", "")]
		public unsafe ProductParameterBuilder (string productId, global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder.ActionType type)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/webtrekk/webtrekksdk/ProductParameterBuilder$ActionType;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_productId = JNIEnv.NewString (productId);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_productId);
				__args [1] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_productId);
			}
		}

		static Delegate cb_getResult;
#pragma warning disable 0169
		static Delegate GetGetResultHandler ()
		{
			if (cb_getResult == null)
				cb_getResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResult);
			return cb_getResult;
		}

		static IntPtr n_GetResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Result);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.TrackingParameter Result {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']/method[@name='getResult' and count(parameter)=0]"
			[Register ("getResult", "()Lcom/webtrekk/webtrekksdk/TrackingParameter;", "GetGetResultHandler")]
			get {
				const string __id = "getResult.()Lcom/webtrekk/webtrekksdk/TrackingParameter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.TrackingParameter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_setCost_F;
#pragma warning disable 0169
		static Delegate GetSetCost_FHandler ()
		{
			if (cb_setCost_F == null)
				cb_setCost_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetCost_F);
			return cb_setCost_F;
		}

		static IntPtr n_SetCost_F (IntPtr jnienv, IntPtr native__this, float value)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCost (value));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']/method[@name='setCost' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setCost", "(F)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;", "GetSetCost_FHandler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder SetCost (float value)
		{
			const string __id = "setCost.(F)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCouponValue_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCouponValue_Ljava_lang_String_Handler ()
		{
			if (cb_setCouponValue_Ljava_lang_String_ == null)
				cb_setCouponValue_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCouponValue_Ljava_lang_String_);
			return cb_setCouponValue_Ljava_lang_String_;
		}

		static IntPtr n_SetCouponValue_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetCouponValue (value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']/method[@name='setCouponValue' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setCouponValue", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;", "GetSetCouponValue_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder SetCouponValue (string value)
		{
			const string __id = "setCouponValue.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setEcommerce_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetEcommerce_ILjava_lang_String_Handler ()
		{
			if (cb_setEcommerce_ILjava_lang_String_ == null)
				cb_setEcommerce_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetEcommerce_ILjava_lang_String_);
			return cb_setEcommerce_ILjava_lang_String_;
		}

		static IntPtr n_SetEcommerce_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_value)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetEcommerce (index, value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']/method[@name='setEcommerce' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("setEcommerce", "(ILjava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;", "GetSetEcommerce_ILjava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder SetEcommerce (int index, string value)
		{
			const string __id = "setEcommerce.(ILjava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setGrossMargin_F;
#pragma warning disable 0169
		static Delegate GetSetGrossMargin_FHandler ()
		{
			if (cb_setGrossMargin_F == null)
				cb_setGrossMargin_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetGrossMargin_F);
			return cb_setGrossMargin_F;
		}

		static IntPtr n_SetGrossMargin_F (IntPtr jnienv, IntPtr native__this, float value)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetGrossMargin (value));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']/method[@name='setGrossMargin' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setGrossMargin", "(F)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;", "GetSetGrossMargin_FHandler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder SetGrossMargin (float value)
		{
			const string __id = "setGrossMargin.(F)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setIsProductSoldOut_Z;
#pragma warning disable 0169
		static Delegate GetSetIsProductSoldOut_ZHandler ()
		{
			if (cb_setIsProductSoldOut_Z == null)
				cb_setIsProductSoldOut_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_SetIsProductSoldOut_Z);
			return cb_setIsProductSoldOut_Z;
		}

		static IntPtr n_SetIsProductSoldOut_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetIsProductSoldOut (value));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']/method[@name='setIsProductSoldOut' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setIsProductSoldOut", "(Z)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;", "GetSetIsProductSoldOut_ZHandler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder SetIsProductSoldOut (bool value)
		{
			const string __id = "setIsProductSoldOut.(Z)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setOrderStatus_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOrderStatus_Ljava_lang_String_Handler ()
		{
			if (cb_setOrderStatus_Ljava_lang_String_ == null)
				cb_setOrderStatus_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetOrderStatus_Ljava_lang_String_);
			return cb_setOrderStatus_Ljava_lang_String_;
		}

		static IntPtr n_SetOrderStatus_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOrderStatus (value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']/method[@name='setOrderStatus' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOrderStatus", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;", "GetSetOrderStatus_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder SetOrderStatus (string value)
		{
			const string __id = "setOrderStatus.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setPaymentMethod_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetPaymentMethod_Ljava_lang_String_Handler ()
		{
			if (cb_setPaymentMethod_Ljava_lang_String_ == null)
				cb_setPaymentMethod_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPaymentMethod_Ljava_lang_String_);
			return cb_setPaymentMethod_Ljava_lang_String_;
		}

		static IntPtr n_SetPaymentMethod_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPaymentMethod (value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']/method[@name='setPaymentMethod' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setPaymentMethod", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;", "GetSetPaymentMethod_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder SetPaymentMethod (string value)
		{
			const string __id = "setPaymentMethod.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setPosition_I;
#pragma warning disable 0169
		static Delegate GetSetPosition_IHandler ()
		{
			if (cb_setPosition_I == null)
				cb_setPosition_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetPosition_I);
			return cb_setPosition_I;
		}

		static IntPtr n_SetPosition_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetPosition (value));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPosition", "(I)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;", "GetSetPosition_IHandler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder SetPosition (int value)
		{
			const string __id = "setPosition.(I)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setProductCategory_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProductCategory_ILjava_lang_String_Handler ()
		{
			if (cb_setProductCategory_ILjava_lang_String_ == null)
				cb_setProductCategory_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SetProductCategory_ILjava_lang_String_);
			return cb_setProductCategory_ILjava_lang_String_;
		}

		static IntPtr n_SetProductCategory_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_value)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProductCategory (index, value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']/method[@name='setProductCategory' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("setProductCategory", "(ILjava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;", "GetSetProductCategory_ILjava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder SetProductCategory (int index, string value)
		{
			const string __id = "setProductCategory.(ILjava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setProductQuantity_I;
#pragma warning disable 0169
		static Delegate GetSetProductQuantity_IHandler ()
		{
			if (cb_setProductQuantity_I == null)
				cb_setProductQuantity_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetProductQuantity_I);
			return cb_setProductQuantity_I;
		}

		static IntPtr n_SetProductQuantity_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetProductQuantity (value));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']/method[@name='setProductQuantity' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setProductQuantity", "(I)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;", "GetSetProductQuantity_IHandler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder SetProductQuantity (int value)
		{
			const string __id = "setProductQuantity.(I)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setProductVariant_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProductVariant_Ljava_lang_String_Handler ()
		{
			if (cb_setProductVariant_Ljava_lang_String_ == null)
				cb_setProductVariant_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetProductVariant_Ljava_lang_String_);
			return cb_setProductVariant_Ljava_lang_String_;
		}

		static IntPtr n_SetProductVariant_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProductVariant (value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']/method[@name='setProductVariant' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setProductVariant", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;", "GetSetProductVariant_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder SetProductVariant (string value)
		{
			const string __id = "setProductVariant.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setShippingCost_F;
#pragma warning disable 0169
		static Delegate GetSetShippingCost_FHandler ()
		{
			if (cb_setShippingCost_F == null)
				cb_setShippingCost_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_SetShippingCost_F);
			return cb_setShippingCost_F;
		}

		static IntPtr n_SetShippingCost_F (IntPtr jnienv, IntPtr native__this, float value)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetShippingCost (value));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']/method[@name='setShippingCost' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setShippingCost", "(F)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;", "GetSetShippingCost_FHandler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder SetShippingCost (float value)
		{
			const string __id = "setShippingCost.(F)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setShippingService_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetShippingService_Ljava_lang_String_Handler ()
		{
			if (cb_setShippingService_Ljava_lang_String_ == null)
				cb_setShippingService_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetShippingService_Ljava_lang_String_);
			return cb_setShippingService_Ljava_lang_String_;
		}

		static IntPtr n_SetShippingService_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetShippingService (value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']/method[@name='setShippingService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setShippingService", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;", "GetSetShippingService_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder SetShippingService (string value)
		{
			const string __id = "setShippingService.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setShippingSpeed_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetShippingSpeed_Ljava_lang_String_Handler ()
		{
			if (cb_setShippingSpeed_Ljava_lang_String_ == null)
				cb_setShippingSpeed_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetShippingSpeed_Ljava_lang_String_);
			return cb_setShippingSpeed_Ljava_lang_String_;
		}

		static IntPtr n_SetShippingSpeed_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetShippingSpeed (value));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.webtrekk.webtrekksdk']/class[@name='ProductParameterBuilder']/method[@name='setShippingSpeed' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setShippingSpeed", "(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;", "GetSetShippingSpeed_Ljava_lang_String_Handler")]
		public virtual unsafe global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder SetShippingSpeed (string value)
		{
			const string __id = "setShippingSpeed.(Ljava/lang/String;)Lcom/webtrekk/webtrekksdk/ProductParameterBuilder;";
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Webtrekk.Webtrekksdk.ProductParameterBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

	}
}
