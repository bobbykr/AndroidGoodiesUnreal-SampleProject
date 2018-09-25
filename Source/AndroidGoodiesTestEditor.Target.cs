// Copyright (c) 2018 Nineva Studios

using UnrealBuildTool;
using System.Collections.Generic;

public class AndroidGoodiesTestEditorTarget : TargetRules
{
	public AndroidGoodiesTestEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "AndroidGoodiesTest" } );
	}
}
