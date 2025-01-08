// LeaveMeAlone Game by Netologiya. All RightsReserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class LeaveMeAlone3EditorTarget : TargetRules
{
	public LeaveMeAlone3EditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "LeaveMeAlone3" } );
	}
}
