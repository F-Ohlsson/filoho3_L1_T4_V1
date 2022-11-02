// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class filoho3_L1_T4_V1Target : TargetRules
{
	public filoho3_L1_T4_V1Target( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "filoho3_L1_T4_V1" } );
	}
}
