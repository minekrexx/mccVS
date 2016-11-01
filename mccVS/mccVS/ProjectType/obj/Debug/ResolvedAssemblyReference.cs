//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectType {
	
	
	internal partial class ResolvedAssemblyReference {
		
		/// <summary>Backing field for deserialized rule.<see cref='Microsoft.Build.Framework.XamlTypes.Rule'/>.</summary>
		private static Microsoft.Build.Framework.XamlTypes.Rule deserializedFallbackRule;
		
		/// <summary>The name of the schema to look for at runtime to fulfill property access.</summary>
		internal const string SchemaName = "ResolvedAssemblyReference";
		
		/// <summary>The ItemType given in the Rule.DataSource property.  May not apply to every Property's individual DataSource.</summary>
		internal const string PrimaryDataSourceItemType = "Reference";
		
		/// <summary>The Label given in the Rule.DataSource property.  May not apply to every Property's individual DataSource.</summary>
		internal const string PrimaryDataSourceLabel = "";
		
		/// <summary>A comma-delimited list of aliases to this reference. (The "Aliases" property).</summary>
		internal const string AliasesProperty = "Aliases";
		
		/// <summary>Indicates whether the reference will be copied to the output directory. (The "CopyLocal" property).</summary>
		internal const string CopyLocalProperty = "CopyLocal";
		
		/// <summary>The value of the culture field from the assembly metadata. (The "Culture" property).</summary>
		internal const string CultureProperty = "Culture";
		
		/// <summary>The value of the Title field from the assembly metadata. (The "Description" property).</summary>
		internal const string DescriptionProperty = "Description";
		
		/// <summary>Indicates whether types defined in this assembly will be embedded into the target assembly. (The "EmbedInteropTypes" property).</summary>
		internal const string EmbedInteropTypesProperty = "EmbedInteropTypes";
		
		/// <summary>The file type of the reference. (The "FileType" property).</summary>
		internal const string FileTypeProperty = "FileType";
		
		/// <summary>Security identity of the referenced assembly (see System.Reflection.Assembly.Evidence or System.Security.Policy.Evidence). (The "Identity" property).</summary>
		internal const string IdentityProperty = "Identity";
		
		/// <summary>Location of the file being referenced. (The "ResolvedPath" property).</summary>
		internal const string ResolvedPathProperty = "ResolvedPath";
		
		/// <summary>Version of the .NET runtime this assembly was compiled against. (The "RuntimeVersion" property).</summary>
		internal const string RuntimeVersionProperty = "RuntimeVersion";
		
		/// <summary>Indicates whether this assembly can be resolved without regard to multi-targeting rules for assembly resolution. (The "SpecificVersion" property).</summary>
		internal const string SpecificVersionProperty = "SpecificVersion";
		
		/// <summary>True indicates that the reference has been signed with a key-pair. (The "StrongName" property).</summary>
		internal const string StrongNameProperty = "StrongName";
		
		/// <summary>Version of reference. (The "Version" property).</summary>
		internal const string VersionProperty = "Version";
		
		/// <summary> (The "RequiredTargetFramework" property).</summary>
		internal const string RequiredTargetFrameworkProperty = "RequiredTargetFramework";
		
		/// <summary> (The "HintPath" property).</summary>
		internal const string HintPathProperty = "HintPath";
		
		/// <summary> (The "SDKIdentity" property).</summary>
		internal const string SDKIdentityProperty = "SDKIdentity";
		
		/// <summary>Indicates whether the project system ascertained that this is a WinMD (as opposed to an assembly) (The "IsWinMDFile" property).</summary>
		internal const string IsWinMDFileProperty = "IsWinMDFile";
		
		/// <summary>Indicates whether the build system ascertained that this is a WinMD (as opposed to an assembly) (The "WinMDFile" property).</summary>
		internal const string WinMDFileProperty = "WinMDFile";
		
		/// <summary>The evaluated item name of the original reference item whose resolution resulted in this resolved reference item. (The "OriginalItemSpec" property).</summary>
		internal const string OriginalItemSpecProperty = "OriginalItemSpec";
		
		/// <summary>The SDK that this reference came from when using the expand SDK target. (The "ReferenceFromSDK" property).</summary>
		internal const string ReferenceFromSDKProperty = "ReferenceFromSDK";
		
		/// <summary>The full fusion name of the resolved assembly. (The "FusionName" property).</summary>
		internal const string FusionNameProperty = "FusionName";
		
		/// <summary>What repository held the reference that was used to resolve this.  ("{GAC}" if it was in the GAC). (The "ResolvedFrom" property).</summary>
		internal const string ResolvedFromProperty = "ResolvedFrom";
		
		/// <summary>Backing field for the <see cref='Microsoft.Build.Framework.XamlTypes.Rule'/> property.</summary>
		private Microsoft.VisualStudio.ProjectSystem.Properties.IRule rule;
		
		/// <summary>Backing field for the file name of the rule property.</summary>
		private string file;
		
		/// <summary>Backing field for the ItemType property.</summary>
		private string itemType;
		
		/// <summary>Backing field for the ItemName property.</summary>
		private string itemName;
		
		/// <summary>Configured Project</summary>
		private Microsoft.VisualStudio.ProjectSystem.ConfiguredProject configuredProject;
		
		/// <summary>The dictionary of named catalogs.</summary>
		private System.Collections.Immutable.IImmutableDictionary<string, Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog> catalogs;
		
		/// <summary>Backing field for the <see cref='Microsoft.VisualStudio.ProjectSystem.Properties.IRule'/> property.</summary>
		private Microsoft.VisualStudio.ProjectSystem.Properties.IRule fallbackRule;
		
		/// <summary>Thread locking object</summary>
		private object locker = new object();
		
		/// <summary>Initializes a new instance of the ResolvedAssemblyReference class.</summary>
		internal ResolvedAssemblyReference(Microsoft.VisualStudio.ProjectSystem.Properties.IRule rule) {
			this.rule = rule;
		}
		
		/// <summary>Initializes a new instance of the ResolvedAssemblyReference class.</summary>
		internal ResolvedAssemblyReference(Microsoft.VisualStudio.ProjectSystem.ConfiguredProject configuredProject, System.Collections.Immutable.IImmutableDictionary<string, Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog> catalogs, string context, string file, string itemType, string itemName) : 
				this(GetRule(System.Collections.Immutable.ImmutableDictionary.GetValueOrDefault(catalogs, context), file, itemType, itemName)) {
			if ((configuredProject == null)) {
				throw new System.ArgumentNullException("configuredProject");
			}
			this.configuredProject = configuredProject;
			this.catalogs = catalogs;
			this.file = file;
			this.itemType = itemType;
			this.itemName = itemName;
		}
		
		/// <summary>Initializes a new instance of the ResolvedAssemblyReference class.</summary>
		internal ResolvedAssemblyReference(Microsoft.VisualStudio.ProjectSystem.Properties.IRule rule, Microsoft.VisualStudio.ProjectSystem.ConfiguredProject configuredProject) : 
				this(rule) {
			if ((rule == null)) {
				throw new System.ArgumentNullException("rule");
			}
			if ((configuredProject == null)) {
				throw new System.ArgumentNullException("configuredProject");
			}
			this.configuredProject = configuredProject;
			this.rule = rule;
			this.file = this.rule.File;
			this.itemType = this.rule.ItemType;
			this.itemName = this.rule.ItemName;
		}
		
		/// <summary>Initializes a new instance of the ResolvedAssemblyReference class.</summary>
		internal ResolvedAssemblyReference(Microsoft.VisualStudio.ProjectSystem.ConfiguredProject configuredProject, System.Collections.Immutable.IImmutableDictionary<string, Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog> catalogs, string context, Microsoft.VisualStudio.ProjectSystem.Properties.IProjectPropertiesContext propertyContext) : 
				this(configuredProject, catalogs, context, GetContextFile(propertyContext), propertyContext.ItemType, propertyContext.ItemName) {
		}
		
		/// <summary>Initializes a new instance of the ResolvedAssemblyReference class that assumes a project context (neither property sheet nor items).</summary>
		internal ResolvedAssemblyReference(Microsoft.VisualStudio.ProjectSystem.ConfiguredProject configuredProject, System.Collections.Immutable.IImmutableDictionary<string, Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog> catalogs) : 
				this(configuredProject, catalogs, "Project", null, null, null) {
		}
		
		/// <summary>Gets the IRule used to get and set properties.</summary>
		public Microsoft.VisualStudio.ProjectSystem.Properties.IRule Rule {
			get {
				return this.rule;
			}
		}
		
		/// <summary>A comma-delimited list of aliases to this reference.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty Aliases {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(AliasesProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(AliasesProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Indicates whether the reference will be copied to the output directory.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty CopyLocal {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(CopyLocalProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(CopyLocalProperty)));
				}
				return property;
			}
		}
		
		/// <summary>The value of the culture field from the assembly metadata.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty Culture {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(CultureProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(CultureProperty)));
				}
				return property;
			}
		}
		
		/// <summary>The value of the Title field from the assembly metadata.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty Description {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(DescriptionProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(DescriptionProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Indicates whether types defined in this assembly will be embedded into the target assembly.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty EmbedInteropTypes {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(EmbedInteropTypesProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(EmbedInteropTypesProperty)));
				}
				return property;
			}
		}
		
		/// <summary>The file type of the reference.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty FileType {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(FileTypeProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(FileTypeProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Security identity of the referenced assembly (see System.Reflection.Assembly.Evidence or System.Security.Policy.Evidence).</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty Identity {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(IdentityProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(IdentityProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Location of the file being referenced.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty ResolvedPath {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(ResolvedPathProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(ResolvedPathProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Version of the .NET runtime this assembly was compiled against.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty RuntimeVersion {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(RuntimeVersionProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(RuntimeVersionProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Indicates whether this assembly can be resolved without regard to multi-targeting rules for assembly resolution.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty SpecificVersion {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(SpecificVersionProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(SpecificVersionProperty)));
				}
				return property;
			}
		}
		
		/// <summary>True indicates that the reference has been signed with a key-pair.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty StrongName {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(StrongNameProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(StrongNameProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Version of reference.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty Version {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(VersionProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(VersionProperty)));
				}
				return property;
			}
		}
		
		/// <summary>RequiredTargetFramework</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty RequiredTargetFramework {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(RequiredTargetFrameworkProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(RequiredTargetFrameworkProperty)));
				}
				return property;
			}
		}
		
		/// <summary>HintPath</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty HintPath {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(HintPathProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(HintPathProperty)));
				}
				return property;
			}
		}
		
		/// <summary>SDKIdentity</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty SDKIdentity {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(SDKIdentityProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(SDKIdentityProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Indicates whether the project system ascertained that this is a WinMD (as opposed to an assembly)</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty IsWinMDFile {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(IsWinMDFileProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(IsWinMDFileProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Indicates whether the build system ascertained that this is a WinMD (as opposed to an assembly)</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty WinMDFile {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(WinMDFileProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(WinMDFileProperty)));
				}
				return property;
			}
		}
		
		/// <summary>The evaluated item name of the original reference item whose resolution resulted in this resolved reference item.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty OriginalItemSpec {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(OriginalItemSpecProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(OriginalItemSpecProperty)));
				}
				return property;
			}
		}
		
		/// <summary>The SDK that this reference came from when using the expand SDK target.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty ReferenceFromSDK {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(ReferenceFromSDKProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(ReferenceFromSDKProperty)));
				}
				return property;
			}
		}
		
		/// <summary>The full fusion name of the resolved assembly.</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty FusionName {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(FusionNameProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(FusionNameProperty)));
				}
				return property;
			}
		}
		
		/// <summary>What repository held the reference that was used to resolve this.  (&quot;{GAC}&quot; if it was in the GAC).</summary>
		internal Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty ResolvedFrom {
			get {
				Microsoft.VisualStudio.ProjectSystem.Properties.IRule localRule = this.rule;
				if ((localRule == null)) {
					localRule = this.GeneratedFallbackRule;
				}
				if ((localRule == null)) {
					return null;
				}
				Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(ResolvedFromProperty)));
				if (((property == null) 
							&& (this.GeneratedFallbackRule != null))) {
					localRule = this.GeneratedFallbackRule;
					property = ((Microsoft.VisualStudio.ProjectSystem.Properties.IEvaluatedProperty)(localRule.GetProperty(ResolvedFromProperty)));
				}
				return property;
			}
		}
		
		/// <summary>Get the fallback rule if the current rule on disk is missing or a property in the rule on disk is missing</summary>
		private Microsoft.VisualStudio.ProjectSystem.Properties.IRule GeneratedFallbackRule {
			get {
				if (((this.fallbackRule == null) 
							&& (this.configuredProject != null))) {
					System.Threading.Monitor.Enter(this.locker);
					try {
						if ((this.fallbackRule == null)) {
							this.InitializeFallbackRule();
						}
					}
					finally {
						System.Threading.Monitor.Exit(this.locker);
					}
				}
				return this.fallbackRule;
			}
		}
		
		private static Microsoft.VisualStudio.ProjectSystem.Properties.IRule GetRule(Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog catalog, string file, string itemType, string itemName) {
			if ((catalog == null)) {
				return null;
			}
			return catalog.BindToContext(SchemaName, file, itemType, itemName);
		}
		
		private static string GetContextFile(Microsoft.VisualStudio.ProjectSystem.Properties.IProjectPropertiesContext propertiesContext) {
			if ((propertiesContext.IsProjectFile == true)) {
				return null;
			}
			else {
				return propertiesContext.File;
			}
		}
		
		private void InitializeFallbackRule() {
			if ((this.configuredProject == null)) {
				return;
			}
			Microsoft.Build.Framework.XamlTypes.Rule unboundRule = ResolvedAssemblyReference.deserializedFallbackRule;
			if ((unboundRule == null)) {
				System.IO.Stream xamlStream = null;
				System.Reflection.Assembly thisAssembly = System.Reflection.Assembly.GetExecutingAssembly();
				try {
					xamlStream = thisAssembly.GetManifestResourceStream("XamlRuleToCode:ResolvedAssemblyReference.xaml");
					Microsoft.Build.Framework.XamlTypes.IProjectSchemaNode root = ((Microsoft.Build.Framework.XamlTypes.IProjectSchemaNode)(System.Xaml.XamlServices.Load(xamlStream)));
					System.Collections.Generic.IEnumerator<System.Object> ruleEnumerator = root.GetSchemaObjects(typeof(Microsoft.Build.Framework.XamlTypes.Rule)).GetEnumerator();
					for (
					; ((unboundRule == null) 
								&& ruleEnumerator.MoveNext()); 
					) {
						Microsoft.Build.Framework.XamlTypes.Rule t = ((Microsoft.Build.Framework.XamlTypes.Rule)(ruleEnumerator.Current));
						if (System.StringComparer.OrdinalIgnoreCase.Equals(t.Name, SchemaName)) {
							unboundRule = t;
							unboundRule.Name = "f9a776b8-2e79-496f-94da-4a1bb5ebfc44";
							ResolvedAssemblyReference.deserializedFallbackRule = unboundRule;
						}
					}
				}
				finally {
					if ((xamlStream != null)) {
						((System.IDisposable)(xamlStream)).Dispose();
					}
				}
			}
			this.configuredProject.Services.AdditionalRuleDefinitions.AddRuleDefinition(unboundRule, "FallbackRuleCodeGenerationContext");
			Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog catalog = this.configuredProject.Services.PropertyPagesCatalog.GetMemoryOnlyCatalog("FallbackRuleCodeGenerationContext");
			this.fallbackRule = catalog.BindToContext(unboundRule.Name, this.file, this.itemType, this.itemName);
		}
		
		/// <summary>Enum values for the FileType property.</summary>
		internal class FileTypeValues {
			
			/// <summary>The  ("Assembly") value for the FileType property.</summary>
			internal const string Assembly = "Assembly";
			
			/// <summary>The  ("ActiveX") value for the FileType property.</summary>
			internal const string ActiveX = "ActiveX";
			
			/// <summary>The  ("Native Assembly") value for the FileType property.</summary>
			internal const string NativeAssembly = "Native Assembly";
			
			/// <summary>Prevents automatic generation of a default constructor.</summary>
			private FileTypeValues() {
			}
		}
	}
	
	internal partial class ProjectProperties {
		
		private static System.Func<System.Threading.Tasks.Task<System.Collections.Immutable.IImmutableDictionary<string, Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog>>, object, ResolvedAssemblyReference> CreateResolvedAssemblyReferencePropertiesDelegate = new System.Func<System.Threading.Tasks.Task<System.Collections.Immutable.IImmutableDictionary<string, Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog>>, object, ResolvedAssemblyReference>(CreateResolvedAssemblyReferenceProperties);
		
		private static ResolvedAssemblyReference CreateResolvedAssemblyReferenceProperties(System.Threading.Tasks.Task<System.Collections.Immutable.IImmutableDictionary<string, Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog>> namedCatalogs, object state) {
			ProjectProperties that = ((ProjectProperties)(state));
			return new ResolvedAssemblyReference(that.ConfiguredProject, namedCatalogs.Result, "Project", that.File, that.ItemType, that.ItemName);
		}
		
		/// <summary>Gets the strongly-typed property accessor used to get and set Resolved reference properties.</summary>
		internal System.Threading.Tasks.Task<ResolvedAssemblyReference> GetResolvedAssemblyReferencePropertiesAsync() {
			System.Threading.Tasks.Task<System.Collections.Immutable.IImmutableDictionary<string, Microsoft.VisualStudio.ProjectSystem.Properties.IPropertyPagesCatalog>> namedCatalogsTask = this.GetNamedCatalogsAsync();
			return namedCatalogsTask.ContinueWith(CreateResolvedAssemblyReferencePropertiesDelegate, this, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskContinuationOptions.ExecuteSynchronously, System.Threading.Tasks.TaskScheduler.Default);
		}
	}
}
