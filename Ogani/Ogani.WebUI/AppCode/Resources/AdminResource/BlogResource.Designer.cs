//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resource {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    ///   This class was generated by MSBuild using the GenerateResource task.
    ///   To add or remove a member, edit your .resx file then rerun MSBuild.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Build.Tasks.StronglyTypedResourceBuilder", "15.1.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class BlogResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public BlogResource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ogani.WebUI.AppCode.Resources.AdminResource.BlogResource", typeof(BlogResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Aftorun ad ve soyadı.
        /// </summary>
        public static string AuthorFullName {
            get {
                return ResourceManager.GetString("AuthorFullName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bloqun şəkli.
        /// </summary>
        public static string BlogImage {
            get {
                return ResourceManager.GetString("BlogImage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Paylaşımlar.
        /// </summary>
        public static string Blogs {
            get {
                return ResourceManager.GetString("Blogs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mətn.
        /// </summary>
        public static string Body {
            get {
                return ResourceManager.GetString("Body", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Kateqoriyanın adı.
        /// </summary>
        public static string CategoryName {
            get {
                return ResourceManager.GetString("CategoryName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Paylaşım tarixi.
        /// </summary>
        public static string PublishedDate {
            get {
                return ResourceManager.GetString("PublishedDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Başlıq.
        /// </summary>
        public static string Title {
            get {
                return ResourceManager.GetString("Title", resourceCulture);
            }
        }
    }
}
