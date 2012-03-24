using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libiRate.a", LinkTarget.ArmV6 | LinkTarget.ArmV7 | LinkTarget.Simulator, ForceLoad = true, Frameworks = "UIkit")]
