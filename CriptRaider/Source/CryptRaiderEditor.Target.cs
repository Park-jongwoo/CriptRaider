// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class CryptRaiderEditorTarget : TargetRules
{
	public CryptRaiderEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

        WindowsPlatform.Compiler = WindowsCompiler.VisualStudio2022;
        WindowsPlatform.CompilerVersion = "14.38.33130";

        ExtraModuleNames.AddRange(new string[] { "CryptRaider" });
    }
}
