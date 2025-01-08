// LeaveMeAlone Game by Netologiya. All RightsReserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class LeaveMeAlone3Target : TargetRules
{
	public LeaveMeAlone3Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "LeaveMeAlone3" } );
	}
}
