// Copyright (c) 2018 Nineva Studios

using UnrealBuildTool;
using System.Collections.Generic;

public class AndroidGoodiesTestTarget : TargetRules
{
	public AndroidGoodiesTestTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "AndroidGoodiesTest" } );
	}
}
