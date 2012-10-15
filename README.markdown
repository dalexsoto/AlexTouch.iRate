AlexTouch.iRate
===============

This is a MonoTouch Binding for iRate library, you just need to add the AlexTouch.iRate.dll to you project references and add the following using statement to your source file.

			using AlexTouch.iRate;

In your finishedlaunching method you can configure the iRate instance as needed, 

			public override bool FinishedLaunching (UIApplication app, NSDictionary options)
			{
						iRate r = iRate.SharedInstance();
						
						r.UserDidAttemptToRateApp += delegate {
							Console.WriteLine("User Did Attemp to Rate App");
						};

						r.CouldNotConnectToAppStore += delegate {
							Console.WriteLine("Ups!! Could not connect to AppStore");
						};

						r.DidDetectAppUpdate += delegate {
							Console.WriteLine("Yaay!! App update Detected");
						};

						r.UserDidDeclineToRateApp += delegate {
							Console.WriteLine("User Declined to rate app #SadFace :'( ");
						};

						r.UserDidRequestReminderToRateApp += delegate {
							Console.WriteLine("User Requested to be reminded l8ters");
						};

						r.PreviewMode = true; // Set this to true If you want to test it
						
						// you can find this info in itunes connect ;)
						r.AppStoreID = <your appstore id here>;
						r.ApplicationBundleID = "<your bundle identifier here>";
						.....
			}

You need to add iRate.bundle to your application so just right click on your project in MonoDevelop and click Add/Add Existing Folder then navigate to iRate.bundle select it and include all files, also  you need to set all .strings files build action to content.  

Documentation of this API and Thanks To 
========================================

All kudos for this Amazing lib goes to Nick Lockwood ( https://github.com/nicklockwood ) also you can find all the documentation on how to use this lib on https://github.com/nicklockwood/iRate#readme
