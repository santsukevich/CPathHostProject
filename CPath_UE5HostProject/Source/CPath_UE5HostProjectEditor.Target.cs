// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CPath_UE5HostProjectEditorTarget : TargetRules
{
	public CPath_UE5HostProjectEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.Add("CPath_UE5HostProject");
	}
}
