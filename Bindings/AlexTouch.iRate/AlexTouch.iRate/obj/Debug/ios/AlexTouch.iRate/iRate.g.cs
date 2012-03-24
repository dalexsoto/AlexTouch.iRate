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
	[Register("iRate", true)]
	public partial class iRate : NSObject {
		static IntPtr selAppStoreID = Selector.GetHandle ("appStoreID");
		static IntPtr selSetAppStoreID_ = Selector.GetHandle ("setAppStoreID:");
		static IntPtr selAppStoreGenre = Selector.GetHandle ("appStoreGenre");
		static IntPtr selSetAppStoreGenre_ = Selector.GetHandle ("setAppStoreGenre:");
		static IntPtr selAppStoreCountry = Selector.GetHandle ("appStoreCountry");
		static IntPtr selSetAppStoreCountry_ = Selector.GetHandle ("setAppStoreCountry:");
		static IntPtr selApplicationName = Selector.GetHandle ("applicationName");
		static IntPtr selSetApplicationName_ = Selector.GetHandle ("setApplicationName:");
		static IntPtr selApplicationVersion = Selector.GetHandle ("applicationVersion");
		static IntPtr selSetApplicationVersion_ = Selector.GetHandle ("setApplicationVersion:");
		static IntPtr selApplicationBundleID = Selector.GetHandle ("applicationBundleID");
		static IntPtr selSetApplicationBundleID_ = Selector.GetHandle ("setApplicationBundleID:");
		static IntPtr selUsesUntilPrompt = Selector.GetHandle ("usesUntilPrompt");
		static IntPtr selSetUsesUntilPrompt_ = Selector.GetHandle ("setUsesUntilPrompt:");
		static IntPtr selEventsUntilPrompt = Selector.GetHandle ("eventsUntilPrompt");
		static IntPtr selSetEventsUntilPrompt_ = Selector.GetHandle ("setEventsUntilPrompt:");
		static IntPtr selDaysUntilPrompt = Selector.GetHandle ("daysUntilPrompt");
		static IntPtr selSetDaysUntilPrompt_ = Selector.GetHandle ("setDaysUntilPrompt:");
		static IntPtr selRemindPeriod = Selector.GetHandle ("remindPeriod");
		static IntPtr selSetRemindPeriod_ = Selector.GetHandle ("setRemindPeriod:");
		static IntPtr selMessageTitle = Selector.GetHandle ("messageTitle");
		static IntPtr selSetMessageTitle_ = Selector.GetHandle ("setMessageTitle:");
		static IntPtr selMessage = Selector.GetHandle ("message");
		static IntPtr selSetMessage_ = Selector.GetHandle ("setMessage:");
		static IntPtr selCancelButtonLabel = Selector.GetHandle ("cancelButtonLabel");
		static IntPtr selSetCancelButtonLabel_ = Selector.GetHandle ("setCancelButtonLabel:");
		static IntPtr selRemindButtonLabel = Selector.GetHandle ("remindButtonLabel");
		static IntPtr selSetRemindButtonLabel_ = Selector.GetHandle ("setRemindButtonLabel:");
		static IntPtr selRateButtonLabel = Selector.GetHandle ("rateButtonLabel");
		static IntPtr selSetRateButtonLabel_ = Selector.GetHandle ("setRateButtonLabel:");
		static IntPtr selOnlyPromptIfLatestVersion = Selector.GetHandle ("onlyPromptIfLatestVersion");
		static IntPtr selSetOnlyPromptIfLatestVersion_ = Selector.GetHandle ("setOnlyPromptIfLatestVersion:");
		static IntPtr selPromptAtLaunch = Selector.GetHandle ("promptAtLaunch");
		static IntPtr selSetPromptAtLaunch_ = Selector.GetHandle ("setPromptAtLaunch:");
		static IntPtr selDebug = Selector.GetHandle ("debug");
		static IntPtr selSetDebug_ = Selector.GetHandle ("setDebug:");
		static IntPtr selRatingsURL = Selector.GetHandle ("ratingsURL");
		static IntPtr selSetRatingsURL_ = Selector.GetHandle ("setRatingsURL:");
		static IntPtr selFirstUsed = Selector.GetHandle ("firstUsed");
		static IntPtr selSetFirstUsed_ = Selector.GetHandle ("setFirstUsed:");
		static IntPtr selLastReminded = Selector.GetHandle ("lastReminded");
		static IntPtr selSetLastReminded_ = Selector.GetHandle ("setLastReminded:");
		static IntPtr selUsesCount = Selector.GetHandle ("usesCount");
		static IntPtr selSetUsesCount_ = Selector.GetHandle ("setUsesCount:");
		static IntPtr selEventCount = Selector.GetHandle ("eventCount");
		static IntPtr selSetEventCount_ = Selector.GetHandle ("setEventCount:");
		static IntPtr selDeclinedThisVersion = Selector.GetHandle ("declinedThisVersion");
		static IntPtr selSetDeclinedThisVersion_ = Selector.GetHandle ("setDeclinedThisVersion:");
		static IntPtr selRatedThisVersion = Selector.GetHandle ("ratedThisVersion");
		static IntPtr selSetRatedThisVersion_ = Selector.GetHandle ("setRatedThisVersion:");
		static IntPtr selDelegate = Selector.GetHandle ("delegate");
		static IntPtr selSetDelegate_ = Selector.GetHandle ("setDelegate:");
		static IntPtr selSharedInstance = Selector.GetHandle ("sharedInstance");
		static IntPtr selShouldPromptForRating = Selector.GetHandle ("shouldPromptForRating");
		static IntPtr selPromptForRating = Selector.GetHandle ("promptForRating");
		static IntPtr selPromptIfNetworkAvailable = Selector.GetHandle ("promptIfNetworkAvailable");
		static IntPtr selOpenRatingsPageInAppStore = Selector.GetHandle ("openRatingsPageInAppStore");
		static IntPtr selLogEvent_ = Selector.GetHandle ("logEvent:");
		
		static IntPtr class_ptr = Class.GetHandle ("iRate");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[Export ("init")]
		public  iRate () : base (NSObjectFlag.Empty)
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
		public iRate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.InitWithCoder, coder.Handle);
			} else {
				Handle = MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.InitWithCoder, coder.Handle);
			}
		}

		[CompilerGenerated]
		public iRate (NSObjectFlag t) : base (t) {}

		[CompilerGenerated]
		public iRate (IntPtr handle) : base (handle) {}

		[Export ("sharedInstance")]
		[CompilerGenerated]
		public static iRate SharedInstance ()
		{
			return (iRate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selSharedInstance));
		}
		
		[Export ("shouldPromptForRating")]
		[CompilerGenerated]
		public virtual bool shouldPromptForRating ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldPromptForRating);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldPromptForRating);
			}
		}
		
		[Export ("promptForRating")]
		[CompilerGenerated]
		public virtual void promptForRating ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPromptForRating);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selPromptForRating);
			}
		}
		
		[Export ("promptIfNetworkAvailable")]
		[CompilerGenerated]
		public virtual void promptIfNetworkAvailable ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selPromptIfNetworkAvailable);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selPromptIfNetworkAvailable);
			}
		}
		
		[Export ("openRatingsPageInAppStore")]
		[CompilerGenerated]
		public virtual void openRatingsPageInAppStore ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selOpenRatingsPageInAppStore);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selOpenRatingsPageInAppStore);
			}
		}
		
		[Export ("logEvent:")]
		[CompilerGenerated]
		public virtual void logEvent (bool deferPrompt)
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selLogEvent_, deferPrompt);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selLogEvent_, deferPrompt);
			}
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 AppStoreID {
			[Export ("appStoreID", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selAppStoreID);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selAppStoreID);
				}
			}
			
			[Export ("setAppStoreID:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetAppStoreID_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetAppStoreID_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string AppStoreGenre {
			[Export ("appStoreGenre", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAppStoreGenre));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAppStoreGenre));
				}
			}
			
			[Export ("setAppStoreGenre:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = new NSString (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAppStoreGenre_, nsvalue.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAppStoreGenre_, nsvalue.Handle);
				}
				nsvalue.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual string AppStoreCountry {
			[Export ("appStoreCountry", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAppStoreCountry));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAppStoreCountry));
				}
			}
			
			[Export ("setAppStoreCountry:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = new NSString (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAppStoreCountry_, nsvalue.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAppStoreCountry_, nsvalue.Handle);
				}
				nsvalue.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ApplicationName {
			[Export ("applicationName", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selApplicationName));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selApplicationName));
				}
			}
			
			[Export ("setApplicationName:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = new NSString (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetApplicationName_, nsvalue.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetApplicationName_, nsvalue.Handle);
				}
				nsvalue.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ApplicationVersion {
			[Export ("applicationVersion", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selApplicationVersion));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selApplicationVersion));
				}
			}
			
			[Export ("setApplicationVersion:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = new NSString (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetApplicationVersion_, nsvalue.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetApplicationVersion_, nsvalue.Handle);
				}
				nsvalue.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ApplicationBundleID {
			[Export ("applicationBundleID", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selApplicationBundleID));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selApplicationBundleID));
				}
			}
			
			[Export ("setApplicationBundleID:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = new NSString (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetApplicationBundleID_, nsvalue.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetApplicationBundleID_, nsvalue.Handle);
				}
				nsvalue.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 UsesUntilPrompt {
			[Export ("usesUntilPrompt", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selUsesUntilPrompt);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selUsesUntilPrompt);
				}
			}
			
			[Export ("setUsesUntilPrompt:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetUsesUntilPrompt_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetUsesUntilPrompt_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 EventsUntilPrompt {
			[Export ("eventsUntilPrompt", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selEventsUntilPrompt);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selEventsUntilPrompt);
				}
			}
			
			[Export ("setEventsUntilPrompt:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetEventsUntilPrompt_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetEventsUntilPrompt_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float DaysUntilPrompt {
			[Export ("daysUntilPrompt", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selDaysUntilPrompt);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selDaysUntilPrompt);
				}
			}
			
			[Export ("setDaysUntilPrompt:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetDaysUntilPrompt_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetDaysUntilPrompt_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual float RemindPeriod {
			[Export ("remindPeriod", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSend (this.Handle, selRemindPeriod);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.float_objc_msgSendSuper (this.SuperHandle, selRemindPeriod);
				}
			}
			
			[Export ("setRemindPeriod:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_float (this.Handle, selSetRemindPeriod_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_float (this.SuperHandle, selSetRemindPeriod_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string MessageTitle {
			[Export ("messageTitle", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMessageTitle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMessageTitle));
				}
			}
			
			[Export ("setMessageTitle:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = new NSString (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMessageTitle_, nsvalue.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMessageTitle_, nsvalue.Handle);
				}
				nsvalue.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Message {
			[Export ("message", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMessage));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMessage));
				}
			}
			
			[Export ("setMessage:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = new NSString (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMessage_, nsvalue.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMessage_, nsvalue.Handle);
				}
				nsvalue.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual string CancelButtonLabel {
			[Export ("cancelButtonLabel", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selCancelButtonLabel));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selCancelButtonLabel));
				}
			}
			
			[Export ("setCancelButtonLabel:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = new NSString (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetCancelButtonLabel_, nsvalue.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetCancelButtonLabel_, nsvalue.Handle);
				}
				nsvalue.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual string RemindButtonLabel {
			[Export ("remindButtonLabel", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRemindButtonLabel));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRemindButtonLabel));
				}
			}
			
			[Export ("setRemindButtonLabel:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = new NSString (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRemindButtonLabel_, nsvalue.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRemindButtonLabel_, nsvalue.Handle);
				}
				nsvalue.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual string RateButtonLabel {
			[Export ("rateButtonLabel", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRateButtonLabel));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRateButtonLabel));
				}
			}
			
			[Export ("setRateButtonLabel:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = new NSString (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRateButtonLabel_, nsvalue.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRateButtonLabel_, nsvalue.Handle);
				}
				nsvalue.Dispose ();
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool OnlyPromptIfLatestVersion {
			[Export ("onlyPromptIfLatestVersion", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selOnlyPromptIfLatestVersion);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selOnlyPromptIfLatestVersion);
				}
			}
			
			[Export ("setOnlyPromptIfLatestVersion:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetOnlyPromptIfLatestVersion_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetOnlyPromptIfLatestVersion_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool PromptAtLaunch {
			[Export ("promptAtLaunch", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selPromptAtLaunch);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selPromptAtLaunch);
				}
			}
			
			[Export ("setPromptAtLaunch:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetPromptAtLaunch_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetPromptAtLaunch_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Debug {
			[Export ("debug", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDebug);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selDebug);
				}
			}
			
			[Export ("setDebug:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDebug_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDebug_, value);
				}
			}
		}
		
		object __mt_RatingsURL_var;
		[CompilerGenerated]
		public virtual NSUrl RatingsURL {
			[Export ("ratingsURL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRatingsURL));
				} else {
					ret = (NSUrl) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRatingsURL));
				}
				MarkDirty ();
				__mt_RatingsURL_var = ret;
				return ret;
			}
			
			[Export ("setRatingsURL:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRatingsURL_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRatingsURL_, value.Handle);
				}
				MarkDirty ();
				__mt_RatingsURL_var = value;
			}
		}
		
		object __mt_FirstUsed_var;
		[CompilerGenerated]
		public virtual NSDate FirstUsed {
			[Export ("firstUsed")]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret = (NSDate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selFirstUsed));
				} else {
					ret = (NSDate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selFirstUsed));
				}
				MarkDirty ();
				__mt_FirstUsed_var = ret;
				return ret;
			}
			
			[Export ("setFirstUsed:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetFirstUsed_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetFirstUsed_, value.Handle);
				}
				MarkDirty ();
				__mt_FirstUsed_var = value;
			}
		}
		
		object __mt_LastReminded_var;
		[CompilerGenerated]
		public virtual NSDate LastReminded {
			[Export ("lastReminded")]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret = (NSDate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLastReminded));
				} else {
					ret = (NSDate) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLastReminded));
				}
				MarkDirty ();
				__mt_LastReminded_var = ret;
				return ret;
			}
			
			[Export ("setLastReminded:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLastReminded_, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLastReminded_, value.Handle);
				}
				MarkDirty ();
				__mt_LastReminded_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 UsesCount {
			[Export ("usesCount", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selUsesCount);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selUsesCount);
				}
			}
			
			[Export ("setUsesCount:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetUsesCount_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetUsesCount_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual System.UInt32 EventCount {
			[Export ("eventCount", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSend (this.Handle, selEventCount);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.UInt32_objc_msgSendSuper (this.SuperHandle, selEventCount);
				}
			}
			
			[Export ("setEventCount:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_UInt32 (this.Handle, selSetEventCount_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, selSetEventCount_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool DeclinedThisVersion {
			[Export ("declinedThisVersion", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selDeclinedThisVersion);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selDeclinedThisVersion);
				}
			}
			
			[Export ("setDeclinedThisVersion:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetDeclinedThisVersion_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetDeclinedThisVersion_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool RatedThisVersion {
			[Export ("ratedThisVersion", ArgumentSemantic.Assign)]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selRatedThisVersion);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selRatedThisVersion);
				}
			}
			
			[Export ("setRatedThisVersion:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetRatedThisVersion_, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetRatedThisVersion_, value);
				}
			}
		}
		
		[CompilerGenerated]
		public iRateDelegate Delegate {
			get { return WeakDelegate as iRateDelegate; }
			set { WeakDelegate = value; }
		}
		
		object __mt_WeakDelegate_var;
		[CompilerGenerated]
		public virtual NSObject WeakDelegate {
			[Export ("delegate", ArgumentSemantic.Assign)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegate));
				} else {
					ret = (NSObject) Runtime.GetNSObject (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegate));
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.Assign)]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_, value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		
		protected override void Dispose (bool disposing)
		{
			__mt_RatingsURL_var = null;
			__mt_FirstUsed_var = null;
			__mt_LastReminded_var = null;
			__mt_WeakDelegate_var = null;
			base.Dispose (disposing);
		}
	} /* class iRate */
}
