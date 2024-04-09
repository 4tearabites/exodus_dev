using UnrealBuildTool;

public class exodusTarget : TargetRules
{
	public exodusTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("exodus");
	}
}
