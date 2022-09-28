// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class NORAA0000 : ModuleRules
{
	public NORAA0000(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "GameLiftServerSDK","OnlineSubsystem","OnlineSubsystemUtils",});

        PrivateDependencyModuleNames.AddRange(
           new string[] {
                "VivoxCore",
               // "InputCore",
               // "Slate",
               // "SlateCore",
              // "ShooterGameLoadingScreen",
                "Json",
              //  "ApplicationCore",
               // "ReplicationGraph",
               // "PakFile",
               // "RHI",
               // "PhysicsCore"
           }
       );
    }
}
