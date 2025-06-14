// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CPath_UE5HostProjectTarget : TargetRules
{
	public CPath_UE5HostProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.Add("CPath_UE5HostProject");
	}
}
