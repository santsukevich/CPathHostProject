// Copyright Dominik Trautman. Published in 2022. All Rights Reserved.

using UnrealBuildTool;

public class CPathfinding : ModuleRules
{
	public CPathfinding(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		IWYUSupport = IWYUSupport.Full;
		
		PublicIncludePaths.AddRange(
			[
				// ... add public include paths required here ...
			]
		);
				
		
		PrivateIncludePaths.AddRange(
			[
				// ... add other private include paths required here ...
			]
		);
			
		
		PublicDependencyModuleNames.AddRange(
			[
				"Core"
				// ... add other public dependencies that you statically link with here ...
			]
		);
			
		
		PrivateDependencyModuleNames.AddRange(
			[
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore"
				// ... add private dependencies that you statically link with here ...	
			]
		);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			[
				// ... add any modules that your module loads dynamically here ...
			]
		);
	}
}
