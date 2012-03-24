using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace AlexTouch.iRate
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_types
	//
	
	
//	[BaseType (typeof (NSObject),
//	Delegates = new string [] {"WeakDelegate"},
//	Events = new Type [] { typeof (iRateDelegate) })]
 		[BaseType (typeof (NSObject))]   
	interface iRate 
	{
 		[Static]
		[Export ("sharedInstance")]
		iRate SharedInstance ();
		
	// app store ID - this is only needed if your
	// bundle ID is not unique between iOS and Mac app stores
		
		// @property (nonatomic, assign) NSUInteger appStoreID;
		[Export ("appStoreID", ArgumentSemantic.Assign)]
		uint AppStoreID { get; set; }
		
		
	//application details - these are set automatically
		
		//@property (nonatomic, copy) NSString *appStoreGenre;
		[Export ("appStoreGenre", ArgumentSemantic.Copy)]
		string AppStoreGenre { get; set; }		
		
		//@property (nonatomic, copy) NSString *appStoreCountry;
		[Export ("appStoreCountry", ArgumentSemantic.Copy)]
		string AppStoreCountry { get; set; }
		
		//@property (nonatomic, copy) NSString *applicationName;
		[Export ("applicationName", ArgumentSemantic.Copy)]
		string ApplicationName { get; set; }
		
		//@property (nonatomic, copy) NSString *applicationVersion;
		[Export ("applicationVersion", ArgumentSemantic.Copy)]
		string ApplicationVersion { get; set; }
		
		//@property (nonatomic, copy) NSString *applicationBundleID;
		[Export ("applicationBundleID", ArgumentSemantic.Copy)]
		string ApplicationBundleID { get; set; }
		
		
	//usage settings - these have sensible defaults
		
		//@property (nonatomic, assign) NSUInteger usesUntilPrompt;
		[Export ("usesUntilPrompt", ArgumentSemantic.Assign)]
		uint UsesUntilPrompt { get; set; }
		
		//@property (nonatomic, assign) NSUInteger eventsUntilPrompt;
		[Export ("eventsUntilPrompt", ArgumentSemantic.Assign)]
		uint EventsUntilPrompt { get; set; }
		
		//@property (nonatomic, assign) float daysUntilPrompt;
		[Export ("daysUntilPrompt", ArgumentSemantic.Assign)]
		float DaysUntilPrompt { get; set; }
		
		//@property (nonatomic, assign) float remindPeriod;
		[Export ("remindPeriod", ArgumentSemantic.Assign)]
		float RemindPeriod { get; set; }
		
		
	//message text, you may wish to customise these, e.g. for localisation
		
		//@property (nonatomic, copy) NSString *messageTitle;
		[Export ("messageTitle", ArgumentSemantic.Copy)]
		string MessageTitle { get; set; }
		
		//@property (nonatomic, copy) NSString *message;
		[Export ("message", ArgumentSemantic.Copy)]
		string Message { get; set; }
		
		//@property (nonatomic, copy) NSString *cancelButtonLabel;
		[Export ("cancelButtonLabel", ArgumentSemantic.Copy)]
		string CancelButtonLabel { get; set; }
		
		//@property (nonatomic, copy) NSString *remindButtonLabel;
		[Export ("remindButtonLabel", ArgumentSemantic.Copy)]
		string RemindButtonLabel { get; set; }
		
		//@property (nonatomic, copy) NSString *rateButtonLabel;
		[Export ("rateButtonLabel", ArgumentSemantic.Copy)]
		string RateButtonLabel { get; set; }
		
		
	//debugging and prompt overrides
		
		//@property (nonatomic, assign) BOOL onlyPromptIfLatestVersion;
		[Export ("onlyPromptIfLatestVersion", ArgumentSemantic.Assign)]
		bool OnlyPromptIfLatestVersion { get; set; }
		
		//@property (nonatomic, assign) BOOL promptAtLaunch;
		[Export ("promptAtLaunch", ArgumentSemantic.Assign)]
		bool PromptAtLaunch { get; set; }
		
		//@property (nonatomic, assign) BOOL debug;
		[Export ("debug", ArgumentSemantic.Assign)]
		bool Debug { get; set; }
	
		
	//advanced properties for implementing custom behaviour
		
		//@property (nonatomic, strong) NSURL *ratingsURL;
		[Export ("ratingsURL")]
		NSUrl RatingsURL { get; set; }
		
		//@property (nonatomic, strong) NSDate *firstUsed;
		[Export ("firstUsed")]
		NSDate FirstUsed { get; set; }
		
		//@property (nonatomic, strong) NSDate *lastReminded;
		[Export ("lastReminded")]
		NSDate LastReminded { get; set; }
		
		//@property (nonatomic, assign) NSUInteger usesCount;
		[Export ("usesCount", ArgumentSemantic.Assign)]
		uint UsesCount { get; set; }
		
		//@property (nonatomic, assign) NSUInteger eventCount;
		[Export ("eventCount", ArgumentSemantic.Assign)]
		uint EventCount { get; set; }
		
		//@property (nonatomic, assign) BOOL declinedThisVersion;
		[Export ("declinedThisVersion", ArgumentSemantic.Assign)]
		bool DeclinedThisVersion { get; set; }
		
		//@property (nonatomic, assign) BOOL ratedThisVersion;
		[Export ("ratedThisVersion", ArgumentSemantic.Assign)]
		bool RatedThisVersion { get; set; }
		
		//@property (nonatomic, AH_WEAK) id<iRateDelegate> delegate;
		[Wrap ("WeakDelegate")][NullAllowed]
		iRateDelegate Delegate { get; set; }
		
		//@property (nonatomic, AH_WEAK) id<iRateDelegate> delegate;
		[Export ("delegate", ArgumentSemantic.Assign)][NullAllowed]
		NSObject WeakDelegate { get; set; }
		
		
	//manually control behaviour
		
		//- (BOOL)shouldPromptForRating;
		[Export ("shouldPromptForRating")]
		bool shouldPromptForRating();
		
		//- (void)promptForRating;
		[Export ("promptForRating")]
		void promptForRating();
		
		//- (void)promptIfNetworkAvailable;
		[Export ("promptIfNetworkAvailable")]
		void promptIfNetworkAvailable();
		
		//- (void)openRatingsPageInAppStore;
		[Export ("openRatingsPageInAppStore")]
		void openRatingsPageInAppStore();
		
		//- (void)logEvent:(BOOL)deferPrompt;
		[Export ("logEvent:")]
		void logEvent(bool deferPrompt);
	}
	
	[BaseType (typeof (NSObject))]
	[Model]
	interface iRateDelegate 
	{
//		- (void)iRateCouldNotConnectToAppStore:(NSError *)error;
		[Export ("iRateCouldNotConnectToAppStore:")]
		void CouldNotConnectToAppStore(NSError error);
		
//		- (void)iRateDidDetectAppUpdate;
		[Export ("iRateDidDetectAppUpdate")]
		void DidDetectAppUpdate();
		
//		- (BOOL)iRateShouldPromptForRating;
		[Export ("iRateShouldPromptForRating"), DefaultValue("true")]
		bool ShouldPromptForRating();
		
//		- (void)iRateUserDidAttemptToRateApp;
		[Export ("iRateUserDidAttemptToRateApp")]
		void UserDidAttemptToRateApp();
		
//		- (void)iRateUserDidDeclineToRateApp;
		[Export ("iRateUserDidDeclineToRateApp")]
		void UserDidDeclineToRateApp();
		
//		- (void)iRateUserDidRequestReminderToRateApp;
		[Export ("iRateUserDidRequestReminderToRateApp")]
		void UserDidRequestReminderToRateApp();		
	}
}

