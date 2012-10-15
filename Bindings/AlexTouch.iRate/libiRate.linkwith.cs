using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libiRate.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true)]
