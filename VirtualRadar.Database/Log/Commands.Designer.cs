﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VirtualRadar.Database.Log {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Commands {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Commands() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("VirtualRadar.Database.Log.Commands", typeof(Commands).Assembly);
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
        ///   Looks up a localized string similar to INSERT INTO [Client] (
        ///    [IpAddress]
        ///   ,[ReverseDns]
        ///   ,[ReverseDnsDate]
        ///) VALUES (
        ///    @ipAddress
        ///   ,@reverseDns
        ///   ,@reverseDnsDate
        ///);
        ///SELECT [Id] FROM [Client] WHERE _ROWID_ = last_insert_rowid();
        ///.
        /// </summary>
        internal static string Client_Insert {
            get {
                return ResourceManager.GetString("Client_Insert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE [Client]
        ///   SET [IpAddress] =        @ipAddress
        ///      ,[ReverseDns] =       @reverseDns
        ///      ,[ReverseDnsDate] =   @reverseDnsDate
        /// WHERE [Id] = @id;
        ///.
        /// </summary>
        internal static string Client_Update {
            get {
                return ResourceManager.GetString("Client_Update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT *
        ///  FROM [Session]
        /// WHERE ([StartTime] &gt;= @startDate AND [StartTime] &lt;= @endDate)
        ///    OR ([EndTime]   &gt;= @startDate AND [EndTime]   &lt;= @endDate)
        ///    OR ([StartTime] &lt;  @startDate AND [EndTime]   &gt;  @endDate)
        ///;
        ///.
        /// </summary>
        internal static string Session_GetByDateRange {
            get {
                return ResourceManager.GetString("Session_GetByDateRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to INSERT INTO [Session] (
        ///    [ClientId]
        ///   ,[UserName]
        ///   ,[StartTime]
        ///   ,[EndTime]
        ///   ,[CountRequests]
        ///   ,[OtherBytesSent]
        ///   ,[HtmlBytesSent]
        ///   ,[JsonBytesSent]
        ///   ,[ImageBytesSent]
        ///   ,[AudioBytesSent]
        ///) VALUES (
        ///    @clientId
        ///   ,@userName
        ///   ,@startTime
        ///   ,@endTime
        ///   ,@countRequests
        ///   ,@otherBytesSent
        ///   ,@htmlBytesSent
        ///   ,@jsonBytesSent
        ///   ,@imageBytesSent
        ///   ,@audioBytesSent
        ///);
        ///SELECT [Id] FROM [Session] WHERE _ROWID_ = last_insert_rowid();
        ///.
        /// </summary>
        internal static string Session_Insert {
            get {
                return ResourceManager.GetString("Session_Insert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to UPDATE [Session]
        ///   SET [ClientId] =         @clientId
        ///      ,[UserName] =         IFNULL(@userName, [UserName])
        ///      ,[StartTime] =        @startTime
        ///      ,[EndTime] =          @endTime
        ///      ,[CountRequests] =    @countRequests
        ///      ,[OtherBytesSent] =   @otherBytesSent
        ///      ,[HtmlBytesSent] =    @htmlBytesSent
        ///      ,[JsonBytesSent] =    @jsonBytesSent
        ///      ,[ImageBytesSent] =   @imageBytesSent
        ///      ,[AudioBytesSent] =   @audioBytesSent
        ///WHERE [Id] = @id;
        ///.
        /// </summary>
        internal static string Session_Update {
            get {
                return ResourceManager.GetString("Session_Update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to --
        ///-- Client
        ///--
        ///CREATE TABLE IF NOT EXISTS [Client]
        ///(
        ///    [Id]                INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
        ///   ,[IpAddress]         TEXT NOT NULL
        ///   ,[ReverseDns]        TEXT
        ///   ,[ReverseDnsDate]    DATETIME
        ///);
        ///CREATE UNIQUE INDEX IF NOT EXISTS [Idx_Client_IpAddress] ON [Client] ([IpAddress] ASC);
        ///
        ///
        ///--
        ///-- Session
        ///--
        ///CREATE TABLE IF NOT EXISTS [Session]
        ///(
        ///    [Id]                INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL
        ///   ,[ClientId]          INTEGER NOT NULL
        ///   ,[UserName] [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string UpdateSchema {
            get {
                return ResourceManager.GetString("UpdateSchema", resourceCulture);
            }
        }
    }
}
