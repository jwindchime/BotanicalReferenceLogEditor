﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BotanicalReferenceStandardsEditor.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Windows.Forms.AutoCompleteStringCollection commonSource {
            get {
                return ((global::System.Windows.Forms.AutoCompleteStringCollection)(this["commonSource"]));
            }
            set {
                this["commonSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Windows.Forms.AutoCompleteStringCollection botanicalSource {
            get {
                return ((global::System.Windows.Forms.AutoCompleteStringCollection)(this["botanicalSource"]));
            }
            set {
                this["botanicalSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Windows.Forms.AutoCompleteStringCollection partSource {
            get {
                return ((global::System.Windows.Forms.AutoCompleteStringCollection)(this["partSource"]));
            }
            set {
                this["partSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Windows.Forms.AutoCompleteStringCollection providerSource {
            get {
                return ((global::System.Windows.Forms.AutoCompleteStringCollection)(this["providerSource"]));
            }
            set {
                this["providerSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Windows.Forms.AutoCompleteStringCollection locationSource {
            get {
                return ((global::System.Windows.Forms.AutoCompleteStringCollection)(this["locationSource"]));
            }
            set {
                this["locationSource"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public int lastRow {
            get {
                return ((int)(this["lastRow"]));
            }
            set {
                this["lastRow"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string workbookPath {
            get {
                return ((string)(this["workbookPath"]));
            }
            set {
                this["workbookPath"] = value;
            }
        }
    }
}