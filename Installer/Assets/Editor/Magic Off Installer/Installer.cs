/*
┌────────────────────────────────────────────────────────────────────────────┐
│  Author: Ivan Murzak (https://github.com/IvanMurzak)                       │
│  Repository: GitHub (https://github.com/IvanMurzak/Unity-Package-Template) │
│  Copyright (c) 2025 Ivan Murzak                                            │
│  Licensed under the MIT License.                                           │
│  See the LICENSE file in the project root for more information.            │
└────────────────────────────────────────────────────────────────────────────┘
*/
#nullable enable
using UnityEditor;

namespace Severnbli.MagicOff.Installer
{
    [InitializeOnLoad]
    public static partial class Installer
    {
        public const string PackageId = "com.severnbli.magic-off";
        public const string Version = "1.0.0";

        static Installer()
        {
#if !PACKAGE_INSTALLER_PROJECT
            AddScopedRegistryIfNeeded(ManifestPath);
#endif
        }
    }
}