//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;

using System.Drawing;

using System.Runtime.CompilerServices;

using System.Runtime.InteropServices;

using MonoTouch;

using MonoTouch.CoreFoundation;

using MonoTouch.CoreMedia;

using MonoTouch.CoreMotion;

using MonoTouch.Foundation;

using MonoTouch.ObjCRuntime;

using MonoTouch.CoreAnimation;

using MonoTouch.CoreLocation;

using MonoTouch.MapKit;

using MonoTouch.UIKit;

using MonoTouch.CoreGraphics;

using MonoTouch.NewsstandKit;

using MonoTouch.GLKit;

using OpenTK;

namespace AlexTouch.iRate {
	[Register("iRateDelegate", true)]
	[Model]
	public partial class iRateDelegate : NSObject {
		
		static IntPtr class_ptr = Class.GetHandle ("NSObject");
		
		[CompilerGenerated]
		[Export ("init")]
		public  iRateDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init);
			}
		}

		[CompilerGenerated]
		[Export ("initWithCoder:")]
		public iRateDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		public iRateDelegate (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		public iRateDelegate (IntPtr handle) : base (handle) {}

		[Export ("iRateCouldNotConnectToAppStore:")]
		[CompilerGenerated]
		public virtual void CouldNotConnectToAppStore (NSError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("iRateDidDetectAppUpdate")]
		[CompilerGenerated]
		public virtual void DidDetectAppUpdate ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("iRateShouldPromptForRating")]
		[CompilerGenerated]
		public virtual bool ShouldPromptForRating ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("iRateUserDidAttemptToRateApp")]
		[CompilerGenerated]
		public virtual void UserDidAttemptToRateApp ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("iRateUserDidDeclineToRateApp")]
		[CompilerGenerated]
		public virtual void UserDidDeclineToRateApp ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("iRateUserDidRequestReminderToRateApp")]
		[CompilerGenerated]
		public virtual void UserDidRequestReminderToRateApp ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
	} /* class iRateDelegate */
}
