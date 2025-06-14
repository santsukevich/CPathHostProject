// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class CPath_UE5HostProject : ModuleRules
{
	public CPath_UE5HostProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(
			[
					"Core",
					"CoreUObject",
					"Engine",
					"InputCore",
					"HeadMountedDisplay", 
					"CPathfinding"
			]
		);
	}
}
