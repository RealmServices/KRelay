﻿namespace MapCacher {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Config : global::System.Configuration.ApplicationSettingsBase {
        
        private static Config defaultInstance = ((Config)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Config())));
        
        public static Config Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool enabled {
            get {
                return ((bool)(this["enabled"]));
            }
            set {
                this["enabled"] = value;
            }
        }
    }
}
