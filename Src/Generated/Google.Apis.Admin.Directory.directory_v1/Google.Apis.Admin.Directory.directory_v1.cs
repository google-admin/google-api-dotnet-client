// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.Admin.Directory.directory_v1
{
    /// <summary>The Directory Service.</summary>
    public class DirectoryService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "directory_v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DirectoryService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DirectoryService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            Asps = new AspsResource(this);
            Channels = new ChannelsResource(this);
            Chromeosdevices = new ChromeosdevicesResource(this);
            Customers = new CustomersResource(this);
            DomainAliases = new DomainAliasesResource(this);
            Domains = new DomainsResource(this);
            Groups = new GroupsResource(this);
            Members = new MembersResource(this);
            Mobiledevices = new MobiledevicesResource(this);
            Orgunits = new OrgunitsResource(this);
            Privileges = new PrivilegesResource(this);
            Resources = new ResourcesResource(this);
            RoleAssignments = new RoleAssignmentsResource(this);
            Roles = new RolesResource(this);
            Schemas = new SchemasResource(this);
            Tokens = new TokensResource(this);
            Users = new UsersResource(this);
            VerificationCodes = new VerificationCodesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "admin";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://www.googleapis.com/";
        #else
            "https://www.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://www.googleapis.com/batch/admin/directory_v1";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/admin/directory_v1";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Admin SDK.</summary>
        public class Scope
        {
            /// <summary>View and manage customer related information</summary>
            public static string AdminDirectoryCustomer = "https://www.googleapis.com/auth/admin.directory.customer";

            /// <summary>View customer related information</summary>
            public static string AdminDirectoryCustomerReadonly = "https://www.googleapis.com/auth/admin.directory.customer.readonly";

            /// <summary>View and manage your Chrome OS devices' metadata</summary>
            public static string AdminDirectoryDeviceChromeos = "https://www.googleapis.com/auth/admin.directory.device.chromeos";

            /// <summary>View your Chrome OS devices' metadata</summary>
            public static string AdminDirectoryDeviceChromeosReadonly = "https://www.googleapis.com/auth/admin.directory.device.chromeos.readonly";

            /// <summary>View and manage your mobile devices' metadata</summary>
            public static string AdminDirectoryDeviceMobile = "https://www.googleapis.com/auth/admin.directory.device.mobile";

            /// <summary>Manage your mobile devices by performing administrative tasks</summary>
            public static string AdminDirectoryDeviceMobileAction = "https://www.googleapis.com/auth/admin.directory.device.mobile.action";

            /// <summary>View your mobile devices' metadata</summary>
            public static string AdminDirectoryDeviceMobileReadonly = "https://www.googleapis.com/auth/admin.directory.device.mobile.readonly";

            /// <summary>View and manage the provisioning of domains for your customers</summary>
            public static string AdminDirectoryDomain = "https://www.googleapis.com/auth/admin.directory.domain";

            /// <summary>View domains related to your customers</summary>
            public static string AdminDirectoryDomainReadonly = "https://www.googleapis.com/auth/admin.directory.domain.readonly";

            /// <summary>View and manage the provisioning of groups on your domain</summary>
            public static string AdminDirectoryGroup = "https://www.googleapis.com/auth/admin.directory.group";

            /// <summary>View and manage group subscriptions on your domain</summary>
            public static string AdminDirectoryGroupMember = "https://www.googleapis.com/auth/admin.directory.group.member";

            /// <summary>View group subscriptions on your domain</summary>
            public static string AdminDirectoryGroupMemberReadonly = "https://www.googleapis.com/auth/admin.directory.group.member.readonly";

            /// <summary>View groups on your domain</summary>
            public static string AdminDirectoryGroupReadonly = "https://www.googleapis.com/auth/admin.directory.group.readonly";

            /// <summary>View and manage organization units on your domain</summary>
            public static string AdminDirectoryOrgunit = "https://www.googleapis.com/auth/admin.directory.orgunit";

            /// <summary>View organization units on your domain</summary>
            public static string AdminDirectoryOrgunitReadonly = "https://www.googleapis.com/auth/admin.directory.orgunit.readonly";

            /// <summary>View and manage the provisioning of calendar resources on your domain</summary>
            public static string AdminDirectoryResourceCalendar = "https://www.googleapis.com/auth/admin.directory.resource.calendar";

            /// <summary>View calendar resources on your domain</summary>
            public static string AdminDirectoryResourceCalendarReadonly = "https://www.googleapis.com/auth/admin.directory.resource.calendar.readonly";

            /// <summary>Manage delegated admin roles for your domain</summary>
            public static string AdminDirectoryRolemanagement = "https://www.googleapis.com/auth/admin.directory.rolemanagement";

            /// <summary>View delegated admin roles for your domain</summary>
            public static string AdminDirectoryRolemanagementReadonly = "https://www.googleapis.com/auth/admin.directory.rolemanagement.readonly";

            /// <summary>View and manage the provisioning of users on your domain</summary>
            public static string AdminDirectoryUser = "https://www.googleapis.com/auth/admin.directory.user";

            /// <summary>View and manage user aliases on your domain</summary>
            public static string AdminDirectoryUserAlias = "https://www.googleapis.com/auth/admin.directory.user.alias";

            /// <summary>View user aliases on your domain</summary>
            public static string AdminDirectoryUserAliasReadonly = "https://www.googleapis.com/auth/admin.directory.user.alias.readonly";

            /// <summary>View users on your domain</summary>
            public static string AdminDirectoryUserReadonly = "https://www.googleapis.com/auth/admin.directory.user.readonly";

            /// <summary>Manage data access permissions for users on your domain</summary>
            public static string AdminDirectoryUserSecurity = "https://www.googleapis.com/auth/admin.directory.user.security";

            /// <summary>View and manage the provisioning of user schemas on your domain</summary>
            public static string AdminDirectoryUserschema = "https://www.googleapis.com/auth/admin.directory.userschema";

            /// <summary>View user schemas on your domain</summary>
            public static string AdminDirectoryUserschemaReadonly = "https://www.googleapis.com/auth/admin.directory.userschema.readonly";

            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Admin SDK.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage customer related information</summary>
            public const string AdminDirectoryCustomer = "https://www.googleapis.com/auth/admin.directory.customer";

            /// <summary>View customer related information</summary>
            public const string AdminDirectoryCustomerReadonly = "https://www.googleapis.com/auth/admin.directory.customer.readonly";

            /// <summary>View and manage your Chrome OS devices' metadata</summary>
            public const string AdminDirectoryDeviceChromeos = "https://www.googleapis.com/auth/admin.directory.device.chromeos";

            /// <summary>View your Chrome OS devices' metadata</summary>
            public const string AdminDirectoryDeviceChromeosReadonly = "https://www.googleapis.com/auth/admin.directory.device.chromeos.readonly";

            /// <summary>View and manage your mobile devices' metadata</summary>
            public const string AdminDirectoryDeviceMobile = "https://www.googleapis.com/auth/admin.directory.device.mobile";

            /// <summary>Manage your mobile devices by performing administrative tasks</summary>
            public const string AdminDirectoryDeviceMobileAction = "https://www.googleapis.com/auth/admin.directory.device.mobile.action";

            /// <summary>View your mobile devices' metadata</summary>
            public const string AdminDirectoryDeviceMobileReadonly = "https://www.googleapis.com/auth/admin.directory.device.mobile.readonly";

            /// <summary>View and manage the provisioning of domains for your customers</summary>
            public const string AdminDirectoryDomain = "https://www.googleapis.com/auth/admin.directory.domain";

            /// <summary>View domains related to your customers</summary>
            public const string AdminDirectoryDomainReadonly = "https://www.googleapis.com/auth/admin.directory.domain.readonly";

            /// <summary>View and manage the provisioning of groups on your domain</summary>
            public const string AdminDirectoryGroup = "https://www.googleapis.com/auth/admin.directory.group";

            /// <summary>View and manage group subscriptions on your domain</summary>
            public const string AdminDirectoryGroupMember = "https://www.googleapis.com/auth/admin.directory.group.member";

            /// <summary>View group subscriptions on your domain</summary>
            public const string AdminDirectoryGroupMemberReadonly = "https://www.googleapis.com/auth/admin.directory.group.member.readonly";

            /// <summary>View groups on your domain</summary>
            public const string AdminDirectoryGroupReadonly = "https://www.googleapis.com/auth/admin.directory.group.readonly";

            /// <summary>View and manage organization units on your domain</summary>
            public const string AdminDirectoryOrgunit = "https://www.googleapis.com/auth/admin.directory.orgunit";

            /// <summary>View organization units on your domain</summary>
            public const string AdminDirectoryOrgunitReadonly = "https://www.googleapis.com/auth/admin.directory.orgunit.readonly";

            /// <summary>View and manage the provisioning of calendar resources on your domain</summary>
            public const string AdminDirectoryResourceCalendar = "https://www.googleapis.com/auth/admin.directory.resource.calendar";

            /// <summary>View calendar resources on your domain</summary>
            public const string AdminDirectoryResourceCalendarReadonly = "https://www.googleapis.com/auth/admin.directory.resource.calendar.readonly";

            /// <summary>Manage delegated admin roles for your domain</summary>
            public const string AdminDirectoryRolemanagement = "https://www.googleapis.com/auth/admin.directory.rolemanagement";

            /// <summary>View delegated admin roles for your domain</summary>
            public const string AdminDirectoryRolemanagementReadonly = "https://www.googleapis.com/auth/admin.directory.rolemanagement.readonly";

            /// <summary>View and manage the provisioning of users on your domain</summary>
            public const string AdminDirectoryUser = "https://www.googleapis.com/auth/admin.directory.user";

            /// <summary>View and manage user aliases on your domain</summary>
            public const string AdminDirectoryUserAlias = "https://www.googleapis.com/auth/admin.directory.user.alias";

            /// <summary>View user aliases on your domain</summary>
            public const string AdminDirectoryUserAliasReadonly = "https://www.googleapis.com/auth/admin.directory.user.alias.readonly";

            /// <summary>View users on your domain</summary>
            public const string AdminDirectoryUserReadonly = "https://www.googleapis.com/auth/admin.directory.user.readonly";

            /// <summary>Manage data access permissions for users on your domain</summary>
            public const string AdminDirectoryUserSecurity = "https://www.googleapis.com/auth/admin.directory.user.security";

            /// <summary>View and manage the provisioning of user schemas on your domain</summary>
            public const string AdminDirectoryUserschema = "https://www.googleapis.com/auth/admin.directory.userschema";

            /// <summary>View user schemas on your domain</summary>
            public const string AdminDirectoryUserschemaReadonly = "https://www.googleapis.com/auth/admin.directory.userschema.readonly";

            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }



        /// <summary>Gets the Asps resource.</summary>
        public virtual AspsResource Asps { get; }

        /// <summary>Gets the Channels resource.</summary>
        public virtual ChannelsResource Channels { get; }

        /// <summary>Gets the Chromeosdevices resource.</summary>
        public virtual ChromeosdevicesResource Chromeosdevices { get; }

        /// <summary>Gets the Customers resource.</summary>
        public virtual CustomersResource Customers { get; }

        /// <summary>Gets the DomainAliases resource.</summary>
        public virtual DomainAliasesResource DomainAliases { get; }

        /// <summary>Gets the Domains resource.</summary>
        public virtual DomainsResource Domains { get; }

        /// <summary>Gets the Groups resource.</summary>
        public virtual GroupsResource Groups { get; }

        /// <summary>Gets the Members resource.</summary>
        public virtual MembersResource Members { get; }

        /// <summary>Gets the Mobiledevices resource.</summary>
        public virtual MobiledevicesResource Mobiledevices { get; }

        /// <summary>Gets the Orgunits resource.</summary>
        public virtual OrgunitsResource Orgunits { get; }

        /// <summary>Gets the Privileges resource.</summary>
        public virtual PrivilegesResource Privileges { get; }

        /// <summary>Gets the Resources resource.</summary>
        public virtual ResourcesResource Resources { get; }

        /// <summary>Gets the RoleAssignments resource.</summary>
        public virtual RoleAssignmentsResource RoleAssignments { get; }

        /// <summary>Gets the Roles resource.</summary>
        public virtual RolesResource Roles { get; }

        /// <summary>Gets the Schemas resource.</summary>
        public virtual SchemasResource Schemas { get; }

        /// <summary>Gets the Tokens resource.</summary>
        public virtual TokensResource Tokens { get; }

        /// <summary>Gets the Users resource.</summary>
        public virtual UsersResource Users { get; }

        /// <summary>Gets the VerificationCodes resource.</summary>
        public virtual VerificationCodesResource VerificationCodes { get; }
    }

    ///<summary>A base abstract class for Directory requests.</summary>
    public abstract class DirectoryBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new DirectoryBaseServiceRequest instance.</summary>
        protected DirectoryBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes Directory parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "asps" collection of methods.</summary>
    public class AspsResource
    {
        private const string Resource = "asps";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AspsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Delete an ASP issued by a user.</summary>
        /// <param name="userKey">Identifies the user in the API request. The value can be the user's primary email address,
        /// alias email address, or unique user ID.</param>
        /// <param name="codeId">The unique ID of the ASP to be
        /// deleted.</param>
        public virtual DeleteRequest Delete(string userKey, int codeId)
        {
            return new DeleteRequest(service, userKey, codeId);
        }

        /// <summary>Delete an ASP issued by a user.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string userKey, int codeId)
                : base(service)
            {
                UserKey = userKey;
                CodeId = codeId;
                InitParameters();
            }


            /// <summary>Identifies the user in the API request. The value can be the user's primary email address,
            /// alias email address, or unique user ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>The unique ID of the ASP to be deleted.</summary>
            [Google.Apis.Util.RequestParameterAttribute("codeId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int CodeId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/asps/{codeId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "codeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "codeId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Get information about an ASP issued by a user.</summary>
        /// <param name="userKey">Identifies the user in the API request. The value can be the user's primary email address,
        /// alias email address, or unique user ID.</param>
        /// <param name="codeId">The unique ID of the ASP.</param>
        public virtual GetRequest Get(string userKey, int codeId)
        {
            return new GetRequest(service, userKey, codeId);
        }

        /// <summary>Get information about an ASP issued by a user.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Asp>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string userKey, int codeId)
                : base(service)
            {
                UserKey = userKey;
                CodeId = codeId;
                InitParameters();
            }


            /// <summary>Identifies the user in the API request. The value can be the user's primary email address,
            /// alias email address, or unique user ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>The unique ID of the ASP.</summary>
            [Google.Apis.Util.RequestParameterAttribute("codeId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual int CodeId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/asps/{codeId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "codeId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "codeId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>List the ASPs issued by a user.</summary>
        /// <param name="userKey">Identifies the user in the API request. The value can be the user's primary email address,
        /// alias email address, or unique user ID.</param>
        public virtual ListRequest List(string userKey)
        {
            return new ListRequest(service, userKey);
        }

        /// <summary>List the ASPs issued by a user.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Asps>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string userKey)
                : base(service)
            {
                UserKey = userKey;
                InitParameters();
            }


            /// <summary>Identifies the user in the API request. The value can be the user's primary email address,
            /// alias email address, or unique user ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/asps";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "channels" collection of methods.</summary>
    public class ChannelsResource
    {
        private const string Resource = "channels";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ChannelsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Stop watching resources through this channel.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual StopRequest Stop(Google.Apis.Admin.Directory.directory_v1.Data.Channel body)
        {
            return new StopRequest(service, body);
        }

        /// <summary>Stop watching resources through this channel.</summary>
        public class StopRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Stop request.</summary>
            public StopRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Channel body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Channel Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "stop";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory_v1/channels/stop";

            /// <summary>Initializes Stop parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }

    /// <summary>The "chromeosdevices" collection of methods.</summary>
    public class ChromeosdevicesResource
    {
        private const string Resource = "chromeosdevices";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ChromeosdevicesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Take action on Chrome OS Device</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="resourceId">Immutable ID
        /// of Chrome OS Device</param>
        public virtual ActionRequest Action(Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDeviceAction body, string customerId, string resourceId)
        {
            return new ActionRequest(service, body, customerId, resourceId);
        }

        /// <summary>Take action on Chrome OS Device</summary>
        public class ActionRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Action request.</summary>
            public ActionRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDeviceAction body, string customerId, string resourceId)
                : base(service)
            {
                CustomerId = customerId;
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Immutable ID of Chrome OS Device</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDeviceAction Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "action";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/chromeos/{resourceId}/action";

            /// <summary>Initializes Action parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "resourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieve Chrome OS Device</summary>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="deviceId">Immutable ID of
        /// Chrome OS Device</param>
        public virtual GetRequest Get(string customerId, string deviceId)
        {
            return new GetRequest(service, customerId, deviceId);
        }

        /// <summary>Retrieve Chrome OS Device</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customerId, string deviceId)
                : base(service)
            {
                CustomerId = customerId;
                DeviceId = deviceId;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Immutable ID of Chrome OS Device</summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            public enum ProjectionEnum
            {
                [Google.Apis.Util.StringValueAttribute("PROJECTION_UNDEFINED")]
                PROJECTIONUNDEFINED,
                /// <summary>Includes only the basic metadata fields (e.g., deviceId, serialNumber, status, and
                /// user)</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC,
                /// <summary>Includes all metadata fields</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/chromeos/{deviceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "deviceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "deviceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "projection", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projection",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieve all Chrome OS Devices of a customer (paginated)</summary>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        public virtual ListRequest List(string customerId)
        {
            return new ListRequest(service, customerId);
        }

        /// <summary>Retrieve all Chrome OS Devices of a customer (paginated)</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevices>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customerId)
                : base(service)
            {
                CustomerId = customerId;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Maximum number of results to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Column to use for sorting results</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderByEnum> OrderBy { get; set; }

            /// <summary>Column to use for sorting results</summary>
            public enum OrderByEnum
            {
                [Google.Apis.Util.StringValueAttribute("orderByUndefined")]
                OrderByUndefined,
                /// <summary>Chromebook location as annotated by the administrator.</summary>
                [Google.Apis.Util.StringValueAttribute("annotatedLocation")]
                AnnotatedLocation,
                /// <summary>Chromebook user as annotated by administrator.</summary>
                [Google.Apis.Util.StringValueAttribute("annotatedUser")]
                AnnotatedUser,
                /// <summary>Chromebook last sync.</summary>
                [Google.Apis.Util.StringValueAttribute("lastSync")]
                LastSync,
                /// <summary>Chromebook notes as annotated by the administrator.</summary>
                [Google.Apis.Util.StringValueAttribute("notes")]
                Notes,
                /// <summary>Chromebook Serial Number.</summary>
                [Google.Apis.Util.StringValueAttribute("serialNumber")]
                SerialNumber,
                /// <summary>Chromebook status.</summary>
                [Google.Apis.Util.StringValueAttribute("status")]
                Status,
                /// <summary>Chromebook support end date.</summary>
                [Google.Apis.Util.StringValueAttribute("supportEndDate")]
                SupportEndDate,
            }

            /// <summary>Full path of the organizational unit or its ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("orgUnitPath", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrgUnitPath { get; set; }

            /// <summary>Token to specify next page in the list</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            public enum ProjectionEnum
            {
                [Google.Apis.Util.StringValueAttribute("PROJECTION_UNDEFINED")]
                PROJECTIONUNDEFINED,
                /// <summary>Includes only the basic metadata fields (e.g., deviceId, serialNumber, status, and
                /// user)</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC,
                /// <summary>Includes all metadata fields</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL,
            }

            /// <summary>Search string in the format given at
            /// http://support.google.com/chromeos/a/bin/answer.py?answer=1698333</summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Whether to return results in ascending or descending order. Only of use when orderBy is also
            /// used</summary>
            [Google.Apis.Util.RequestParameterAttribute("sortOrder", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SortOrderEnum> SortOrder { get; set; }

            /// <summary>Whether to return results in ascending or descending order. Only of use when orderBy is also
            /// used</summary>
            public enum SortOrderEnum
            {
                [Google.Apis.Util.StringValueAttribute("SORT_ORDER_UNDEFINED")]
                SORTORDERUNDEFINED,
                /// <summary>Ascending order.</summary>
                [Google.Apis.Util.StringValueAttribute("ASCENDING")]
                ASCENDING,
                /// <summary>Descending order.</summary>
                [Google.Apis.Util.StringValueAttribute("DESCENDING")]
                DESCENDING,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/chromeos";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "100",
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orgUnitPath", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orgUnitPath",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "projection", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projection",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "query", new Google.Apis.Discovery.Parameter
                    {
                        Name = "query",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "sortOrder", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sortOrder",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Move or insert multiple Chrome OS Devices to organizational unit</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="orgUnitPath">Full path of
        /// the target organizational unit or its ID</param>
        public virtual MoveDevicesToOuRequest MoveDevicesToOu(Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsMoveDevicesToOu body, string customerId, string orgUnitPath)
        {
            return new MoveDevicesToOuRequest(service, body, customerId, orgUnitPath);
        }

        /// <summary>Move or insert multiple Chrome OS Devices to organizational unit</summary>
        public class MoveDevicesToOuRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new MoveDevicesToOu request.</summary>
            public MoveDevicesToOuRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsMoveDevicesToOu body, string customerId, string orgUnitPath)
                : base(service)
            {
                CustomerId = customerId;
                OrgUnitPath = orgUnitPath;
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Full path of the target organizational unit or its ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("orgUnitPath", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrgUnitPath { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsMoveDevicesToOu Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "moveDevicesToOu";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/chromeos/moveDevicesToOu";

            /// <summary>Initializes MoveDevicesToOu parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orgUnitPath", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orgUnitPath",
                        IsRequired = true,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Patch Chrome OS Device</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="deviceId">Immutable ID of
        /// Chrome OS Device</param>
        public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice body, string customerId, string deviceId)
        {
            return new PatchRequest(service, body, customerId, deviceId);
        }

        /// <summary>Patch Chrome OS Device</summary>
        public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice body, string customerId, string deviceId)
                : base(service)
            {
                CustomerId = customerId;
                DeviceId = deviceId;
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Immutable ID of Chrome OS Device</summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            public enum ProjectionEnum
            {
                [Google.Apis.Util.StringValueAttribute("PROJECTION_UNDEFINED")]
                PROJECTIONUNDEFINED,
                /// <summary>Includes only the basic metadata fields (e.g., deviceId, serialNumber, status, and
                /// user)</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC,
                /// <summary>Includes all metadata fields</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL,
            }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/chromeos/{deviceId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "deviceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "deviceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "projection", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projection",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Update Chrome OS Device</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="deviceId">Immutable ID of
        /// Chrome OS Device</param>
        public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice body, string customerId, string deviceId)
        {
            return new UpdateRequest(service, body, customerId, deviceId);
        }

        /// <summary>Update Chrome OS Device</summary>
        public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice body, string customerId, string deviceId)
                : base(service)
            {
                CustomerId = customerId;
                DeviceId = deviceId;
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Immutable ID of Chrome OS Device</summary>
            [Google.Apis.Util.RequestParameterAttribute("deviceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DeviceId { get; private set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            public enum ProjectionEnum
            {
                [Google.Apis.Util.StringValueAttribute("PROJECTION_UNDEFINED")]
                PROJECTIONUNDEFINED,
                /// <summary>Includes only the basic metadata fields (e.g., deviceId, serialNumber, status, and
                /// user)</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC,
                /// <summary>Includes all metadata fields</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL,
            }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.ChromeOsDevice Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "update";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/chromeos/{deviceId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "deviceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "deviceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "projection", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projection",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "customers" collection of methods.</summary>
    public class CustomersResource
    {
        private const string Resource = "customers";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public CustomersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Retrieves a customer.</summary>
        /// <param name="customerKey">Id of the customer to be retrieved</param>
        public virtual GetRequest Get(string customerKey)
        {
            return new GetRequest(service, customerKey);
        }

        /// <summary>Retrieves a customer.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Customer>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customerKey)
                : base(service)
            {
                CustomerKey = customerKey;
                InitParameters();
            }


            /// <summary>Id of the customer to be retrieved</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customers/{customerKey}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Patch Customers via Apiary Patch Orchestration</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerKey">Id of the customer to be updated</param>
        public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.Customer body, string customerKey)
        {
            return new PatchRequest(service, body, customerKey);
        }

        /// <summary>Patch Customers via Apiary Patch Orchestration</summary>
        public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Customer>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Customer body, string customerKey)
                : base(service)
            {
                CustomerKey = customerKey;
                Body = body;
                InitParameters();
            }


            /// <summary>Id of the customer to be updated</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerKey { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Customer Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customers/{customerKey}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates a customer.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerKey">Id of the customer to be updated</param>
        public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.Customer body, string customerKey)
        {
            return new UpdateRequest(service, body, customerKey);
        }

        /// <summary>Updates a customer.</summary>
        public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Customer>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Customer body, string customerKey)
                : base(service)
            {
                CustomerKey = customerKey;
                Body = body;
                InitParameters();
            }


            /// <summary>Id of the customer to be updated</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerKey { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Customer Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "update";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customers/{customerKey}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "domainAliases" collection of methods.</summary>
    public class DomainAliasesResource
    {
        private const string Resource = "domainAliases";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DomainAliasesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Deletes a domain Alias of the customer.</summary>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        /// <param name="domainAliasName">Name of
        /// domain alias to be retrieved.</param>
        public virtual DeleteRequest Delete(string customer, string domainAliasName)
        {
            return new DeleteRequest(service, customer, domainAliasName);
        }

        /// <summary>Deletes a domain Alias of the customer.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string customer, string domainAliasName)
                : base(service)
            {
                Customer = customer;
                DomainAliasName = domainAliasName;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Name of domain alias to be retrieved.</summary>
            [Google.Apis.Util.RequestParameterAttribute("domainAliasName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DomainAliasName { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/domainaliases/{domainAliasName}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "domainAliasName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "domainAliasName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves a domain alias of the customer.</summary>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        /// <param name="domainAliasName">Name of
        /// domain alias to be retrieved.</param>
        public virtual GetRequest Get(string customer, string domainAliasName)
        {
            return new GetRequest(service, customer, domainAliasName);
        }

        /// <summary>Retrieves a domain alias of the customer.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.DomainAlias>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customer, string domainAliasName)
                : base(service)
            {
                Customer = customer;
                DomainAliasName = domainAliasName;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Name of domain alias to be retrieved.</summary>
            [Google.Apis.Util.RequestParameterAttribute("domainAliasName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DomainAliasName { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/domainaliases/{domainAliasName}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "domainAliasName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "domainAliasName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Inserts a domain alias of the customer.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.DomainAlias body, string customer)
        {
            return new InsertRequest(service, body, customer);
        }

        /// <summary>Inserts a domain alias of the customer.</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.DomainAlias>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.DomainAlias body, string customer)
                : base(service)
            {
                Customer = customer;
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.DomainAlias Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/domainaliases";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists the domain aliases of the customer.</summary>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        public virtual ListRequest List(string customer)
        {
            return new ListRequest(service, customer);
        }

        /// <summary>Lists the domain aliases of the customer.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.DomainAliases>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customer)
                : base(service)
            {
                Customer = customer;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Name of the parent domain for which domain aliases are to be fetched.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parentDomainName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ParentDomainName { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/domainaliases";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "parentDomainName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parentDomainName",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "domains" collection of methods.</summary>
    public class DomainsResource
    {
        private const string Resource = "domains";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public DomainsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Deletes a domain of the customer.</summary>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        /// <param name="domainName">Name of domain
        /// to be deleted</param>
        public virtual DeleteRequest Delete(string customer, string domainName)
        {
            return new DeleteRequest(service, customer, domainName);
        }

        /// <summary>Deletes a domain of the customer.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string customer, string domainName)
                : base(service)
            {
                Customer = customer;
                DomainName = domainName;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Name of domain to be deleted</summary>
            [Google.Apis.Util.RequestParameterAttribute("domainName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DomainName { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/domains/{domainName}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "domainName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "domainName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves a domain of the customer.</summary>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        /// <param name="domainName">Name of domain
        /// to be retrieved</param>
        public virtual GetRequest Get(string customer, string domainName)
        {
            return new GetRequest(service, customer, domainName);
        }

        /// <summary>Retrieves a domain of the customer.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Domains>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customer, string domainName)
                : base(service)
            {
                Customer = customer;
                DomainName = domainName;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Name of domain to be retrieved</summary>
            [Google.Apis.Util.RequestParameterAttribute("domainName", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string DomainName { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/domains/{domainName}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "domainName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "domainName",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Inserts a domain of the customer.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Domains body, string customer)
        {
            return new InsertRequest(service, body, customer);
        }

        /// <summary>Inserts a domain of the customer.</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Domains>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Domains body, string customer)
                : base(service)
            {
                Customer = customer;
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Domains Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/domains";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists the domains of the customer.</summary>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        public virtual ListRequest List(string customer)
        {
            return new ListRequest(service, customer);
        }

        /// <summary>Lists the domains of the customer.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Domains2>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customer)
                : base(service)
            {
                Customer = customer;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/domains";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "groups" collection of methods.</summary>
    public class GroupsResource
    {
        private const string Resource = "groups";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public GroupsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Aliases = new AliasesResource(service);

        }

        /// <summary>Gets the Aliases resource.</summary>
        public virtual AliasesResource Aliases { get; }

        /// <summary>The "aliases" collection of methods.</summary>
        public class AliasesResource
        {
            private const string Resource = "aliases";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AliasesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Remove a alias for the group</summary>
            /// <param name="groupKey">Email or immutable ID of the group</param>
            /// <param name="alias">The alias to be
            /// removed</param>
            public virtual DeleteRequest Delete(string groupKey, string alias)
            {
                return new DeleteRequest(service, groupKey, alias);
            }

            /// <summary>Remove a alias for the group</summary>
            public class DeleteRequest : DirectoryBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string groupKey, string alias)
                    : base(service)
                {
                    GroupKey = groupKey;
                    Alias = alias;
                    InitParameters();
                }


                /// <summary>Email or immutable ID of the group</summary>
                [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string GroupKey { get; private set; }

                /// <summary>The alias to be removed</summary>
                [Google.Apis.Util.RequestParameterAttribute("alias", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Alias { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/groups/{groupKey}/aliases/{alias}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "groupKey", new Google.Apis.Discovery.Parameter
                        {
                            Name = "groupKey",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "alias", new Google.Apis.Discovery.Parameter
                        {
                            Name = "alias",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Add a alias for the group</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="groupKey">Email or immutable ID of the group</param>
            public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Alias body, string groupKey)
            {
                return new InsertRequest(service, body, groupKey);
            }

            /// <summary>Add a alias for the group</summary>
            public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Alias>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Alias body, string groupKey)
                    : base(service)
                {
                    GroupKey = groupKey;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Email or immutable ID of the group</summary>
                [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string GroupKey { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Alias Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/groups/{groupKey}/aliases";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "groupKey", new Google.Apis.Discovery.Parameter
                        {
                            Name = "groupKey",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>List all aliases for a group</summary>
            /// <param name="groupKey">Email or immutable ID of the group</param>
            public virtual ListRequest List(string groupKey)
            {
                return new ListRequest(service, groupKey);
            }

            /// <summary>List all aliases for a group</summary>
            public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Aliases>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string groupKey)
                    : base(service)
                {
                    GroupKey = groupKey;
                    InitParameters();
                }


                /// <summary>Email or immutable ID of the group</summary>
                [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string GroupKey { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/groups/{groupKey}/aliases";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "groupKey", new Google.Apis.Discovery.Parameter
                        {
                            Name = "groupKey",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }
        }

        /// <summary>Delete Group</summary>
        /// <param name="groupKey">Email or immutable ID of the group</param>
        public virtual DeleteRequest Delete(string groupKey)
        {
            return new DeleteRequest(service, groupKey);
        }

        /// <summary>Delete Group</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string groupKey)
                : base(service)
            {
                GroupKey = groupKey;
                InitParameters();
            }


            /// <summary>Email or immutable ID of the group</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "groupKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieve Group</summary>
        /// <param name="groupKey">Email or immutable ID of the group</param>
        public virtual GetRequest Get(string groupKey)
        {
            return new GetRequest(service, groupKey);
        }

        /// <summary>Retrieve Group</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Group>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string groupKey)
                : base(service)
            {
                GroupKey = groupKey;
                InitParameters();
            }


            /// <summary>Email or immutable ID of the group</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "groupKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Create Group</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Group body)
        {
            return new InsertRequest(service, body);
        }

        /// <summary>Create Group</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Group>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Group body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Group Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Retrieve all groups of a domain or of a user given a userKey (paginated)</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Retrieve all groups of a domain or of a user given a userKey (paginated)</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Groups>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account. In case of multi-domain, to fetch all groups for a
            /// customer, fill this field instead of domain.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Customer { get; set; }

            /// <summary>Name of the domain. Fill this field to get groups from only this domain. To return all groups
            /// in a multi-domain fill customer field instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("domain", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Domain { get; set; }

            /// <summary>Maximum number of results to return. Max allowed value is 200.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Column to use for sorting results</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderByEnum> OrderBy { get; set; }

            /// <summary>Column to use for sorting results</summary>
            public enum OrderByEnum
            {
                [Google.Apis.Util.StringValueAttribute("orderByUndefined")]
                OrderByUndefined,
                /// <summary>Email of the group.</summary>
                [Google.Apis.Util.StringValueAttribute("email")]
                Email,
            }

            /// <summary>Token to specify next page in the list</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Query string search. Should be of the form "". Complete documentation is at https:
            /// //developers.google.com/admin-sdk/directory/v1/guides/search-groups</summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Whether to return results in ascending or descending order. Only of use when orderBy is also
            /// used</summary>
            [Google.Apis.Util.RequestParameterAttribute("sortOrder", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SortOrderEnum> SortOrder { get; set; }

            /// <summary>Whether to return results in ascending or descending order. Only of use when orderBy is also
            /// used</summary>
            public enum SortOrderEnum
            {
                [Google.Apis.Util.StringValueAttribute("SORT_ORDER_UNDEFINED")]
                SORTORDERUNDEFINED,
                /// <summary>Ascending order.</summary>
                [Google.Apis.Util.StringValueAttribute("ASCENDING")]
                ASCENDING,
                /// <summary>Descending order.</summary>
                [Google.Apis.Util.StringValueAttribute("DESCENDING")]
                DESCENDING,
            }

            /// <summary>Email or immutable ID of the user if only those groups are to be listed, the given user is a
            /// member of. If it's an ID, it should match with the ID of the user object.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserKey { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "domain", new Google.Apis.Discovery.Parameter
                    {
                        Name = "domain",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "200",
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "query", new Google.Apis.Discovery.Parameter
                    {
                        Name = "query",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "sortOrder", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sortOrder",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Patch Groups via Apiary Patch Orchestration</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="groupKey">Email or immutable ID of the group. If ID, it should match with id of group
        /// object</param>
        public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.Group body, string groupKey)
        {
            return new PatchRequest(service, body, groupKey);
        }

        /// <summary>Patch Groups via Apiary Patch Orchestration</summary>
        public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Group>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Group body, string groupKey)
                : base(service)
            {
                GroupKey = groupKey;
                Body = body;
                InitParameters();
            }


            /// <summary>Email or immutable ID of the group. If ID, it should match with id of group object</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Group Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "groupKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Update Group</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="groupKey">Email or immutable ID of the group. If ID, it should match with id of group
        /// object</param>
        public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.Group body, string groupKey)
        {
            return new UpdateRequest(service, body, groupKey);
        }

        /// <summary>Update Group</summary>
        public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Group>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Group body, string groupKey)
                : base(service)
            {
                GroupKey = groupKey;
                Body = body;
                InitParameters();
            }


            /// <summary>Email or immutable ID of the group. If ID, it should match with id of group object</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Group Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "update";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "groupKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "members" collection of methods.</summary>
    public class MembersResource
    {
        private const string Resource = "members";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MembersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Remove membership.</summary>
        /// <param name="groupKey">Email or immutable ID of the group</param>
        /// <param name="memberKey">Email or immutable
        /// ID of the member</param>
        public virtual DeleteRequest Delete(string groupKey, string memberKey)
        {
            return new DeleteRequest(service, groupKey, memberKey);
        }

        /// <summary>Remove membership.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string groupKey, string memberKey)
                : base(service)
            {
                GroupKey = groupKey;
                MemberKey = memberKey;
                InitParameters();
            }


            /// <summary>Email or immutable ID of the group</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }

            /// <summary>Email or immutable ID of the member</summary>
            [Google.Apis.Util.RequestParameterAttribute("memberKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MemberKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}/members/{memberKey}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "groupKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "memberKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "memberKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieve Group Member</summary>
        /// <param name="groupKey">Email or immutable ID of the group</param>
        /// <param name="memberKey">Email or immutable
        /// ID of the member</param>
        public virtual GetRequest Get(string groupKey, string memberKey)
        {
            return new GetRequest(service, groupKey, memberKey);
        }

        /// <summary>Retrieve Group Member</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Member>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string groupKey, string memberKey)
                : base(service)
            {
                GroupKey = groupKey;
                MemberKey = memberKey;
                InitParameters();
            }


            /// <summary>Email or immutable ID of the group</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }

            /// <summary>Email or immutable ID of the member</summary>
            [Google.Apis.Util.RequestParameterAttribute("memberKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MemberKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}/members/{memberKey}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "groupKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "memberKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "memberKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Checks whether the given user is a member of the group. Membership can be direct or
        /// nested.</summary>
        /// <param name="groupKey">Identifies the group in the API request. The value can be the group's email address, group
        /// alias, or the unique group ID.</param>
        /// <param name="memberKey">Identifies the user member in the API
        /// request. The value can be the user's primary email address, alias, or unique ID.</param>
        public virtual HasMemberRequest HasMember(string groupKey, string memberKey)
        {
            return new HasMemberRequest(service, groupKey, memberKey);
        }

        /// <summary>Checks whether the given user is a member of the group. Membership can be direct or
        /// nested.</summary>
        public class HasMemberRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.MembersHasMember>
        {
            /// <summary>Constructs a new HasMember request.</summary>
            public HasMemberRequest(Google.Apis.Services.IClientService service, string groupKey, string memberKey)
                : base(service)
            {
                GroupKey = groupKey;
                MemberKey = memberKey;
                InitParameters();
            }


            /// <summary>Identifies the group in the API request. The value can be the group's email address, group
            /// alias, or the unique group ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }

            /// <summary>Identifies the user member in the API request. The value can be the user's primary email
            /// address, alias, or unique ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("memberKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MemberKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "hasMember";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}/hasMember/{memberKey}";

            /// <summary>Initializes HasMember parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "groupKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "memberKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "memberKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Add user to the specified group.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="groupKey">Email or immutable ID of the group</param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Member body, string groupKey)
        {
            return new InsertRequest(service, body, groupKey);
        }

        /// <summary>Add user to the specified group.</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Member>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Member body, string groupKey)
                : base(service)
            {
                GroupKey = groupKey;
                Body = body;
                InitParameters();
            }


            /// <summary>Email or immutable ID of the group</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Member Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}/members";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "groupKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieve all members in a group (paginated)</summary>
        /// <param name="groupKey">Email or immutable ID of the group</param>
        public virtual ListRequest List(string groupKey)
        {
            return new ListRequest(service, groupKey);
        }

        /// <summary>Retrieve all members in a group (paginated)</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Members>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string groupKey)
                : base(service)
            {
                GroupKey = groupKey;
                InitParameters();
            }


            /// <summary>Email or immutable ID of the group</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }

            /// <summary>Whether to list indirect memberships. Default: false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("includeDerivedMembership", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> IncludeDerivedMembership { get; set; }

            /// <summary>Maximum number of results to return. Max allowed value is 200.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Token to specify next page in the list</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Comma separated role values to filter list results on.</summary>
            [Google.Apis.Util.RequestParameterAttribute("roles", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Roles { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}/members";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "groupKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "includeDerivedMembership", new Google.Apis.Discovery.Parameter
                    {
                        Name = "includeDerivedMembership",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "200",
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "roles", new Google.Apis.Discovery.Parameter
                    {
                        Name = "roles",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Patch Member via Apiary Patch Orchestration</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="groupKey">Email or immutable ID of the group. If ID, it should match with id of group
        /// object</param>
        /// <param name="memberKey">Email or immutable ID of the user. If ID, it should match with id of
        /// member object</param>
        public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.Member body, string groupKey, string memberKey)
        {
            return new PatchRequest(service, body, groupKey, memberKey);
        }

        /// <summary>Patch Member via Apiary Patch Orchestration</summary>
        public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Member>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Member body, string groupKey, string memberKey)
                : base(service)
            {
                GroupKey = groupKey;
                MemberKey = memberKey;
                Body = body;
                InitParameters();
            }


            /// <summary>Email or immutable ID of the group. If ID, it should match with id of group object</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }

            /// <summary>Email or immutable ID of the user. If ID, it should match with id of member object</summary>
            [Google.Apis.Util.RequestParameterAttribute("memberKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MemberKey { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Member Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}/members/{memberKey}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "groupKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "memberKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "memberKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Update membership of a user in the specified group.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="groupKey">Email or immutable ID of the group. If ID, it should match with id of group
        /// object</param>
        /// <param name="memberKey">Email or immutable ID of the user. If ID, it should match with id of
        /// member object</param>
        public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.Member body, string groupKey, string memberKey)
        {
            return new UpdateRequest(service, body, groupKey, memberKey);
        }

        /// <summary>Update membership of a user in the specified group.</summary>
        public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Member>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Member body, string groupKey, string memberKey)
                : base(service)
            {
                GroupKey = groupKey;
                MemberKey = memberKey;
                Body = body;
                InitParameters();
            }


            /// <summary>Email or immutable ID of the group. If ID, it should match with id of group object</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string GroupKey { get; private set; }

            /// <summary>Email or immutable ID of the user. If ID, it should match with id of member object</summary>
            [Google.Apis.Util.RequestParameterAttribute("memberKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string MemberKey { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Member Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "update";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/groups/{groupKey}/members/{memberKey}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "groupKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "memberKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "memberKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "mobiledevices" collection of methods.</summary>
    public class MobiledevicesResource
    {
        private const string Resource = "mobiledevices";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public MobiledevicesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Take action on Mobile Device</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="resourceId">Immutable ID
        /// of Mobile Device</param>
        public virtual ActionRequest Action(Google.Apis.Admin.Directory.directory_v1.Data.MobileDeviceAction body, string customerId, string resourceId)
        {
            return new ActionRequest(service, body, customerId, resourceId);
        }

        /// <summary>Take action on Mobile Device</summary>
        public class ActionRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Action request.</summary>
            public ActionRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.MobileDeviceAction body, string customerId, string resourceId)
                : base(service)
            {
                CustomerId = customerId;
                ResourceId = resourceId;
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Immutable ID of Mobile Device</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.MobileDeviceAction Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "action";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/mobile/{resourceId}/action";

            /// <summary>Initializes Action parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "resourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Delete Mobile Device</summary>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="resourceId">Immutable ID
        /// of Mobile Device</param>
        public virtual DeleteRequest Delete(string customerId, string resourceId)
        {
            return new DeleteRequest(service, customerId, resourceId);
        }

        /// <summary>Delete Mobile Device</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string customerId, string resourceId)
                : base(service)
            {
                CustomerId = customerId;
                ResourceId = resourceId;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Immutable ID of Mobile Device</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/mobile/{resourceId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "resourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieve Mobile Device</summary>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="resourceId">Immutable ID
        /// of Mobile Device</param>
        public virtual GetRequest Get(string customerId, string resourceId)
        {
            return new GetRequest(service, customerId, resourceId);
        }

        /// <summary>Retrieve Mobile Device</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.MobileDevice>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customerId, string resourceId)
                : base(service)
            {
                CustomerId = customerId;
                ResourceId = resourceId;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Immutable ID of Mobile Device</summary>
            [Google.Apis.Util.RequestParameterAttribute("resourceId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ResourceId { get; private set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            public enum ProjectionEnum
            {
                [Google.Apis.Util.StringValueAttribute("PROJECTION_UNDEFINED")]
                PROJECTIONUNDEFINED,
                /// <summary>Includes only the basic metadata fields (e.g., deviceId, model, status, type, and
                /// status)</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC,
                /// <summary>Includes all metadata fields</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/mobile/{resourceId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "resourceId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resourceId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "projection", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projection",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieve all Mobile Devices of a customer (paginated)</summary>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        public virtual ListRequest List(string customerId)
        {
            return new ListRequest(service, customerId);
        }

        /// <summary>Retrieve all Mobile Devices of a customer (paginated)</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.MobileDevices>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customerId)
                : base(service)
            {
                CustomerId = customerId;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Maximum number of results to return. Max allowed value is 100.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Column to use for sorting results</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderByEnum> OrderBy { get; set; }

            /// <summary>Column to use for sorting results</summary>
            public enum OrderByEnum
            {
                [Google.Apis.Util.StringValueAttribute("orderByUndefined")]
                OrderByUndefined,
                /// <summary>Mobile Device serial number.</summary>
                [Google.Apis.Util.StringValueAttribute("deviceId")]
                DeviceId,
                /// <summary>Owner user email.</summary>
                [Google.Apis.Util.StringValueAttribute("email")]
                Email,
                /// <summary>Last policy settings sync date time of the device.</summary>
                [Google.Apis.Util.StringValueAttribute("lastSync")]
                LastSync,
                /// <summary>Mobile Device model.</summary>
                [Google.Apis.Util.StringValueAttribute("model")]
                Model,
                /// <summary>Owner user name.</summary>
                [Google.Apis.Util.StringValueAttribute("name")]
                Name,
                /// <summary>Mobile operating system.</summary>
                [Google.Apis.Util.StringValueAttribute("os")]
                Os,
                /// <summary>Status of the device.</summary>
                [Google.Apis.Util.StringValueAttribute("status")]
                Status,
                /// <summary>Type of the device.</summary>
                [Google.Apis.Util.StringValueAttribute("type")]
                Type,
            }

            /// <summary>Token to specify next page in the list</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>Restrict information returned to a set of selected fields.</summary>
            public enum ProjectionEnum
            {
                [Google.Apis.Util.StringValueAttribute("PROJECTION_UNDEFINED")]
                PROJECTIONUNDEFINED,
                /// <summary>Includes only the basic metadata fields (e.g., deviceId, model, status, type, and
                /// status)</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC,
                /// <summary>Includes all metadata fields</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL,
            }

            /// <summary>Search string in the format given at
            /// http://support.google.com/a/bin/answer.py?answer=1408863#search</summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Whether to return results in ascending or descending order. Only of use when orderBy is also
            /// used</summary>
            [Google.Apis.Util.RequestParameterAttribute("sortOrder", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SortOrderEnum> SortOrder { get; set; }

            /// <summary>Whether to return results in ascending or descending order. Only of use when orderBy is also
            /// used</summary>
            public enum SortOrderEnum
            {
                [Google.Apis.Util.StringValueAttribute("SORT_ORDER_UNDEFINED")]
                SORTORDERUNDEFINED,
                /// <summary>Ascending order.</summary>
                [Google.Apis.Util.StringValueAttribute("ASCENDING")]
                ASCENDING,
                /// <summary>Descending order.</summary>
                [Google.Apis.Util.StringValueAttribute("DESCENDING")]
                DESCENDING,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/devices/mobile";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "100",
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "projection", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projection",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "query", new Google.Apis.Discovery.Parameter
                    {
                        Name = "query",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "sortOrder", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sortOrder",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "orgunits" collection of methods.</summary>
    public class OrgunitsResource
    {
        private const string Resource = "orgunits";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrgunitsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Remove organizational unit</summary>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="orgUnitPath">Full path of
        /// the organizational unit or its ID</param>
        public virtual DeleteRequest Delete(string customerId, string orgUnitPath)
        {
            return new DeleteRequest(service, customerId, orgUnitPath);
        }

        /// <summary>Remove organizational unit</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string customerId, string orgUnitPath)
                : base(service)
            {
                CustomerId = customerId;
                OrgUnitPath = orgUnitPath;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Full path of the organizational unit or its ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("orgUnitPath", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrgUnitPath { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/orgunits/{+orgUnitPath}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orgUnitPath", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orgUnitPath",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^.*$",
                    });
            }

        }

        /// <summary>Retrieve organizational unit</summary>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="orgUnitPath">Full path of
        /// the organizational unit or its ID</param>
        public virtual GetRequest Get(string customerId, string orgUnitPath)
        {
            return new GetRequest(service, customerId, orgUnitPath);
        }

        /// <summary>Retrieve organizational unit</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customerId, string orgUnitPath)
                : base(service)
            {
                CustomerId = customerId;
                OrgUnitPath = orgUnitPath;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Full path of the organizational unit or its ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("orgUnitPath", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrgUnitPath { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/orgunits/{+orgUnitPath}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orgUnitPath", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orgUnitPath",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^.*$",
                    });
            }

        }

        /// <summary>Add organizational unit</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit body, string customerId)
        {
            return new InsertRequest(service, body, customerId);
        }

        /// <summary>Add organizational unit</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit body, string customerId)
                : base(service)
            {
                CustomerId = customerId;
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/orgunits";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieve all organizational units</summary>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        public virtual ListRequest List(string customerId)
        {
            return new ListRequest(service, customerId);
        }

        /// <summary>Retrieve all organizational units</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.OrgUnits>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customerId)
                : base(service)
            {
                CustomerId = customerId;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>the URL-encoded organizational unit's path or its ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("orgUnitPath", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string OrgUnitPath { get; set; }

            /// <summary>Whether to return all sub-organizations or just immediate children</summary>
            [Google.Apis.Util.RequestParameterAttribute("type", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<TypeEnum> Type { get; set; }

            /// <summary>Whether to return all sub-organizations or just immediate children</summary>
            public enum TypeEnum
            {
                [Google.Apis.Util.StringValueAttribute("typeUndefined")]
                TypeUndefined,
                /// <summary>All sub-organizational units.</summary>
                [Google.Apis.Util.StringValueAttribute("all")]
                All,
                /// <summary>Immediate children only (default).</summary>
                [Google.Apis.Util.StringValueAttribute("children")]
                Children,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/orgunits";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orgUnitPath", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orgUnitPath",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "type", new Google.Apis.Discovery.Parameter
                    {
                        Name = "type",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Patch organization unit via Apiary Patch Orchestration</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="orgUnitPath">Full path of
        /// the organizational unit or its ID</param>
        public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit body, string customerId, string orgUnitPath)
        {
            return new PatchRequest(service, body, customerId, orgUnitPath);
        }

        /// <summary>Patch organization unit via Apiary Patch Orchestration</summary>
        public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit body, string customerId, string orgUnitPath)
                : base(service)
            {
                CustomerId = customerId;
                OrgUnitPath = orgUnitPath;
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Full path of the organizational unit or its ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("orgUnitPath", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrgUnitPath { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/orgunits/{+orgUnitPath}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orgUnitPath", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orgUnitPath",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^.*$",
                    });
            }

        }

        /// <summary>Update organizational unit</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="orgUnitPath">Full path of
        /// the organizational unit or its ID</param>
        public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit body, string customerId, string orgUnitPath)
        {
            return new UpdateRequest(service, body, customerId, orgUnitPath);
        }

        /// <summary>Update organizational unit</summary>
        public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit body, string customerId, string orgUnitPath)
                : base(service)
            {
                CustomerId = customerId;
                OrgUnitPath = orgUnitPath;
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Full path of the organizational unit or its ID</summary>
            [Google.Apis.Util.RequestParameterAttribute("orgUnitPath", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string OrgUnitPath { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.OrgUnit Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "update";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/orgunits/{+orgUnitPath}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orgUnitPath", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orgUnitPath",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^.*$",
                    });
            }

        }
    }

    /// <summary>The "privileges" collection of methods.</summary>
    public class PrivilegesResource
    {
        private const string Resource = "privileges";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public PrivilegesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Retrieves a paginated list of all privileges for a customer.</summary>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        public virtual ListRequest List(string customer)
        {
            return new ListRequest(service, customer);
        }

        /// <summary>Retrieves a paginated list of all privileges for a customer.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Privileges>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customer)
                : base(service)
            {
                Customer = customer;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roles/ALL/privileges";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "resources" collection of methods.</summary>
    public class ResourcesResource
    {
        private const string Resource = "resources";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ResourcesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Buildings = new BuildingsResource(service);
            Calendars = new CalendarsResource(service);
            Features = new FeaturesResource(service);

        }

        /// <summary>Gets the Buildings resource.</summary>
        public virtual BuildingsResource Buildings { get; }

        /// <summary>The "buildings" collection of methods.</summary>
        public class BuildingsResource
        {
            private const string Resource = "buildings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BuildingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Deletes a building.</summary>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            /// <param name="buildingId">The id
            /// of the building to delete.</param>
            public virtual DeleteRequest Delete(string customer, string buildingId)
            {
                return new DeleteRequest(service, customer, buildingId);
            }

            /// <summary>Deletes a building.</summary>
            public class DeleteRequest : DirectoryBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string customer, string buildingId)
                    : base(service)
                {
                    Customer = customer;
                    BuildingId = buildingId;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The id of the building to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("buildingId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string BuildingId { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/buildings/{buildingId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "buildingId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "buildingId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Retrieves a building.</summary>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            /// <param name="buildingId">The
            /// unique ID of the building to retrieve.</param>
            public virtual GetRequest Get(string customer, string buildingId)
            {
                return new GetRequest(service, customer, buildingId);
            }

            /// <summary>Retrieves a building.</summary>
            public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Building>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string customer, string buildingId)
                    : base(service)
                {
                    Customer = customer;
                    BuildingId = buildingId;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the building to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("buildingId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string BuildingId { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/buildings/{buildingId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "buildingId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "buildingId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Inserts a building.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Building body, string customer)
            {
                return new InsertRequest(service, body, customer);
            }

            /// <summary>Inserts a building.</summary>
            public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Building>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Building body, string customer)
                    : base(service)
                {
                    Customer = customer;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>Source from which Building.coordinates are derived.</summary>
                [Google.Apis.Util.RequestParameterAttribute("coordinatesSource", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<CoordinatesSourceEnum> CoordinatesSource { get; set; }

                /// <summary>Source from which Building.coordinates are derived.</summary>
                public enum CoordinatesSourceEnum
                {
                    [Google.Apis.Util.StringValueAttribute("COORDINATES_SOURCE_UNDEFINED")]
                    COORDINATESSOURCEUNDEFINED,
                    /// <summary>Building.coordinates are set to the coordinates included in the request.</summary>
                    [Google.Apis.Util.StringValueAttribute("CLIENT_SPECIFIED")]
                    CLIENTSPECIFIED,
                    /// <summary>Building.coordinates are automatically populated based on the postal address.</summary>
                    [Google.Apis.Util.StringValueAttribute("RESOLVED_FROM_ADDRESS")]
                    RESOLVEDFROMADDRESS,
                    /// <summary>Defaults to RESOLVED_FROM_ADDRESS if postal address is provided. Otherwise, defaults to
                    /// CLIENT_SPECIFIED if coordinates are provided.</summary>
                    [Google.Apis.Util.StringValueAttribute("SOURCE_UNSPECIFIED")]
                    SOURCEUNSPECIFIED,
                }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Building Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/buildings";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "coordinatesSource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "coordinatesSource",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = "SOURCE_UNSPECIFIED",
                            Pattern = null,
                        });
                }

            }

            /// <summary>Retrieves a list of buildings for an account.</summary>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            public virtual ListRequest List(string customer)
            {
                return new ListRequest(service, customer);
            }

            /// <summary>Retrieves a list of buildings for an account.</summary>
            public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Buildings>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string customer)
                    : base(service)
                {
                    Customer = customer;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>Maximum number of results to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>Token to specify the next page in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/buildings";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "maxResults", new Google.Apis.Discovery.Parameter
                        {
                            Name = "maxResults",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Patches a building via Apiary Patch Orchestration.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            /// <param name="buildingId">The id
            /// of the building to update.</param>
            public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.Building body, string customer, string buildingId)
            {
                return new PatchRequest(service, body, customer, buildingId);
            }

            /// <summary>Patches a building via Apiary Patch Orchestration.</summary>
            public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Building>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Building body, string customer, string buildingId)
                    : base(service)
                {
                    Customer = customer;
                    BuildingId = buildingId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The id of the building to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("buildingId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string BuildingId { get; private set; }

                /// <summary>Source from which Building.coordinates are derived.</summary>
                [Google.Apis.Util.RequestParameterAttribute("coordinatesSource", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<CoordinatesSourceEnum> CoordinatesSource { get; set; }

                /// <summary>Source from which Building.coordinates are derived.</summary>
                public enum CoordinatesSourceEnum
                {
                    [Google.Apis.Util.StringValueAttribute("COORDINATES_SOURCE_UNDEFINED")]
                    COORDINATESSOURCEUNDEFINED,
                    /// <summary>Building.coordinates are set to the coordinates included in the request.</summary>
                    [Google.Apis.Util.StringValueAttribute("CLIENT_SPECIFIED")]
                    CLIENTSPECIFIED,
                    /// <summary>Building.coordinates are automatically populated based on the postal address.</summary>
                    [Google.Apis.Util.StringValueAttribute("RESOLVED_FROM_ADDRESS")]
                    RESOLVEDFROMADDRESS,
                    /// <summary>Defaults to RESOLVED_FROM_ADDRESS if postal address is provided. Otherwise, defaults to
                    /// CLIENT_SPECIFIED if coordinates are provided.</summary>
                    [Google.Apis.Util.StringValueAttribute("SOURCE_UNSPECIFIED")]
                    SOURCEUNSPECIFIED,
                }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Building Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/buildings/{buildingId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "buildingId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "buildingId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "coordinatesSource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "coordinatesSource",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = "SOURCE_UNSPECIFIED",
                            Pattern = null,
                        });
                }

            }

            /// <summary>Updates a building.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            /// <param name="buildingId">The id
            /// of the building to update.</param>
            public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.Building body, string customer, string buildingId)
            {
                return new UpdateRequest(service, body, customer, buildingId);
            }

            /// <summary>Updates a building.</summary>
            public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Building>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Building body, string customer, string buildingId)
                    : base(service)
                {
                    Customer = customer;
                    BuildingId = buildingId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The id of the building to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("buildingId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string BuildingId { get; private set; }

                /// <summary>Source from which Building.coordinates are derived.</summary>
                [Google.Apis.Util.RequestParameterAttribute("coordinatesSource", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<CoordinatesSourceEnum> CoordinatesSource { get; set; }

                /// <summary>Source from which Building.coordinates are derived.</summary>
                public enum CoordinatesSourceEnum
                {
                    [Google.Apis.Util.StringValueAttribute("COORDINATES_SOURCE_UNDEFINED")]
                    COORDINATESSOURCEUNDEFINED,
                    /// <summary>Building.coordinates are set to the coordinates included in the request.</summary>
                    [Google.Apis.Util.StringValueAttribute("CLIENT_SPECIFIED")]
                    CLIENTSPECIFIED,
                    /// <summary>Building.coordinates are automatically populated based on the postal address.</summary>
                    [Google.Apis.Util.StringValueAttribute("RESOLVED_FROM_ADDRESS")]
                    RESOLVEDFROMADDRESS,
                    /// <summary>Defaults to RESOLVED_FROM_ADDRESS if postal address is provided. Otherwise, defaults to
                    /// CLIENT_SPECIFIED if coordinates are provided.</summary>
                    [Google.Apis.Util.StringValueAttribute("SOURCE_UNSPECIFIED")]
                    SOURCEUNSPECIFIED,
                }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Building Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "update";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/buildings/{buildingId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "buildingId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "buildingId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "coordinatesSource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "coordinatesSource",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = "SOURCE_UNSPECIFIED",
                            Pattern = null,
                        });
                }

            }
        }
        /// <summary>Gets the Calendars resource.</summary>
        public virtual CalendarsResource Calendars { get; }

        /// <summary>The "calendars" collection of methods.</summary>
        public class CalendarsResource
        {
            private const string Resource = "calendars";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public CalendarsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Deletes a calendar resource.</summary>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            /// <param
            /// name="calendarResourceId">The unique ID of the calendar resource to delete.</param>
            public virtual DeleteRequest Delete(string customer, string calendarResourceId)
            {
                return new DeleteRequest(service, customer, calendarResourceId);
            }

            /// <summary>Deletes a calendar resource.</summary>
            public class DeleteRequest : DirectoryBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string customer, string calendarResourceId)
                    : base(service)
                {
                    Customer = customer;
                    CalendarResourceId = calendarResourceId;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the calendar resource to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("calendarResourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CalendarResourceId { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/calendars/{calendarResourceId}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "calendarResourceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "calendarResourceId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Retrieves a calendar resource.</summary>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            /// <param
            /// name="calendarResourceId">The unique ID of the calendar resource to retrieve.</param>
            public virtual GetRequest Get(string customer, string calendarResourceId)
            {
                return new GetRequest(service, customer, calendarResourceId);
            }

            /// <summary>Retrieves a calendar resource.</summary>
            public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string customer, string calendarResourceId)
                    : base(service)
                {
                    Customer = customer;
                    CalendarResourceId = calendarResourceId;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the calendar resource to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("calendarResourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CalendarResourceId { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/calendars/{calendarResourceId}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "calendarResourceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "calendarResourceId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Inserts a calendar resource.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource body, string customer)
            {
                return new InsertRequest(service, body, customer);
            }

            /// <summary>Inserts a calendar resource.</summary>
            public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource body, string customer)
                    : base(service)
                {
                    Customer = customer;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/calendars";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Retrieves a list of calendar resources for an account.</summary>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            public virtual ListRequest List(string customer)
            {
                return new ListRequest(service, customer);
            }

            /// <summary>Retrieves a list of calendar resources for an account.</summary>
            public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.CalendarResources>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string customer)
                    : base(service)
                {
                    Customer = customer;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>Maximum number of results to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>Field(s) to sort results by in either ascending or descending order. Supported fields
                /// include resourceId, resourceName, capacity, buildingId, and floorName. If no order is specified,
                /// defaults to ascending. Should be of the form "field [asc|desc], field [asc|desc], ...". For example
                /// buildingId, capacity desc would return results sorted first by buildingId in ascending order then by
                /// capacity in descending order.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>Token to specify the next page in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>String query used to filter results. Should be of the form "field operator value" where
                /// field can be any of supported fields and operators can be any of supported operations. Operators
                /// include '=' for exact match, '!=' for mismatch and ':' for prefix match or HAS match where
                /// applicable. For prefix match, the value should always be followed by a *. Logical operators NOT and
                /// AND are supported (in this order of precedence). Supported fields include generatedResourceName,
                /// name, buildingId, floor_name, capacity, featureInstances.feature.name. For example buildingId=US-
                /// NYC-9TH AND featureInstances.feature.name:Phone.</summary>
                [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Query { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/calendars";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "maxResults", new Google.Apis.Discovery.Parameter
                        {
                            Name = "maxResults",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "query", new Google.Apis.Discovery.Parameter
                        {
                            Name = "query",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Patches a calendar resource via Apiary Patch Orchestration.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            /// <param
            /// name="calendarResourceId">The unique ID of the calendar resource to update.</param>
            public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource body, string customer, string calendarResourceId)
            {
                return new PatchRequest(service, body, customer, calendarResourceId);
            }

            /// <summary>Patches a calendar resource via Apiary Patch Orchestration.</summary>
            public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource body, string customer, string calendarResourceId)
                    : base(service)
                {
                    Customer = customer;
                    CalendarResourceId = calendarResourceId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the calendar resource to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("calendarResourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CalendarResourceId { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/calendars/{calendarResourceId}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "calendarResourceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "calendarResourceId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Updates a calendar resource. This method supports patch semantics, meaning you only need to
            /// include the fields you wish to update. Fields that are not present in the request will be
            /// preserved.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            /// <param
            /// name="calendarResourceId">The unique ID of the calendar resource to update.</param>
            public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource body, string customer, string calendarResourceId)
            {
                return new UpdateRequest(service, body, customer, calendarResourceId);
            }

            /// <summary>Updates a calendar resource. This method supports patch semantics, meaning you only need to
            /// include the fields you wish to update. Fields that are not present in the request will be
            /// preserved.</summary>
            public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource body, string customer, string calendarResourceId)
                    : base(service)
                {
                    Customer = customer;
                    CalendarResourceId = calendarResourceId;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the calendar resource to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("calendarResourceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string CalendarResourceId { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.CalendarResource Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "update";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/calendars/{calendarResourceId}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "calendarResourceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "calendarResourceId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }
        }
        /// <summary>Gets the Features resource.</summary>
        public virtual FeaturesResource Features { get; }

        /// <summary>The "features" collection of methods.</summary>
        public class FeaturesResource
        {
            private const string Resource = "features";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public FeaturesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Deletes a feature.</summary>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            /// <param name="featureKey">The
            /// unique ID of the feature to delete.</param>
            public virtual DeleteRequest Delete(string customer, string featureKey)
            {
                return new DeleteRequest(service, customer, featureKey);
            }

            /// <summary>Deletes a feature.</summary>
            public class DeleteRequest : DirectoryBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string customer, string featureKey)
                    : base(service)
                {
                    Customer = customer;
                    FeatureKey = featureKey;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the feature to delete.</summary>
                [Google.Apis.Util.RequestParameterAttribute("featureKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FeatureKey { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/features/{featureKey}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "featureKey", new Google.Apis.Discovery.Parameter
                        {
                            Name = "featureKey",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Retrieves a feature.</summary>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            /// <param name="featureKey">The
            /// unique ID of the feature to retrieve.</param>
            public virtual GetRequest Get(string customer, string featureKey)
            {
                return new GetRequest(service, customer, featureKey);
            }

            /// <summary>Retrieves a feature.</summary>
            public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Feature>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string customer, string featureKey)
                    : base(service)
                {
                    Customer = customer;
                    FeatureKey = featureKey;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the feature to retrieve.</summary>
                [Google.Apis.Util.RequestParameterAttribute("featureKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FeatureKey { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/features/{featureKey}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "featureKey", new Google.Apis.Discovery.Parameter
                        {
                            Name = "featureKey",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Inserts a feature.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Feature body, string customer)
            {
                return new InsertRequest(service, body, customer);
            }

            /// <summary>Inserts a feature.</summary>
            public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Feature>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Feature body, string customer)
                    : base(service)
                {
                    Customer = customer;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Feature Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/features";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Retrieves a list of features for an account.</summary>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            public virtual ListRequest List(string customer)
            {
                return new ListRequest(service, customer);
            }

            /// <summary>Retrieves a list of features for an account.</summary>
            public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Features>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string customer)
                    : base(service)
                {
                    Customer = customer;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>Maximum number of results to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> MaxResults { get; set; }

                /// <summary>Token to specify the next page in the list.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/features";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "maxResults", new Google.Apis.Discovery.Parameter
                        {
                            Name = "maxResults",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Patches a feature via Apiary Patch Orchestration.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            /// <param name="featureKey">The
            /// unique ID of the feature to update.</param>
            public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.Feature body, string customer, string featureKey)
            {
                return new PatchRequest(service, body, customer, featureKey);
            }

            /// <summary>Patches a feature via Apiary Patch Orchestration.</summary>
            public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Feature>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Feature body, string customer, string featureKey)
                    : base(service)
                {
                    Customer = customer;
                    FeatureKey = featureKey;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the feature to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("featureKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FeatureKey { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Feature Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/features/{featureKey}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "featureKey", new Google.Apis.Discovery.Parameter
                        {
                            Name = "featureKey",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Renames a feature.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            /// <param name="oldName">The unique
            /// ID of the feature to rename.</param>
            public virtual RenameRequest Rename(Google.Apis.Admin.Directory.directory_v1.Data.FeatureRename body, string customer, string oldName)
            {
                return new RenameRequest(service, body, customer, oldName);
            }

            /// <summary>Renames a feature.</summary>
            public class RenameRequest : DirectoryBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Rename request.</summary>
                public RenameRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.FeatureRename body, string customer, string oldName)
                    : base(service)
                {
                    Customer = customer;
                    OldName = oldName;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the feature to rename.</summary>
                [Google.Apis.Util.RequestParameterAttribute("oldName", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string OldName { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.FeatureRename Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "rename";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/features/{oldName}/rename";

                /// <summary>Initializes Rename parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "oldName", new Google.Apis.Discovery.Parameter
                        {
                            Name = "oldName",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Updates a feature.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="customer">The unique ID for the customer's G Suite account. As an account administrator, you can also
            /// use the my_customer alias to represent your account's customer ID.</param>
            /// <param name="featureKey">The
            /// unique ID of the feature to update.</param>
            public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.Feature body, string customer, string featureKey)
            {
                return new UpdateRequest(service, body, customer, featureKey);
            }

            /// <summary>Updates a feature.</summary>
            public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Feature>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Feature body, string customer, string featureKey)
                    : base(service)
                {
                    Customer = customer;
                    FeatureKey = featureKey;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The unique ID for the customer's G Suite account. As an account administrator, you can also
                /// use the my_customer alias to represent your account's customer ID.</summary>
                [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Customer { get; private set; }

                /// <summary>The unique ID of the feature to update.</summary>
                [Google.Apis.Util.RequestParameterAttribute("featureKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string FeatureKey { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Feature Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "update";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/customer/{customer}/resources/features/{featureKey}";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "customer", new Google.Apis.Discovery.Parameter
                        {
                            Name = "customer",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "featureKey", new Google.Apis.Discovery.Parameter
                        {
                            Name = "featureKey",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }
        }
    }

    /// <summary>The "roleAssignments" collection of methods.</summary>
    public class RoleAssignmentsResource
    {
        private const string Resource = "roleAssignments";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RoleAssignmentsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Deletes a role assignment.</summary>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        /// <param name="roleAssignmentId">Immutable
        /// ID of the role assignment.</param>
        public virtual DeleteRequest Delete(string customer, string roleAssignmentId)
        {
            return new DeleteRequest(service, customer, roleAssignmentId);
        }

        /// <summary>Deletes a role assignment.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string customer, string roleAssignmentId)
                : base(service)
            {
                Customer = customer;
                RoleAssignmentId = roleAssignmentId;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Immutable ID of the role assignment.</summary>
            [Google.Apis.Util.RequestParameterAttribute("roleAssignmentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RoleAssignmentId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roleassignments/{roleAssignmentId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "roleAssignmentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "roleAssignmentId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieve a role assignment.</summary>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        /// <param name="roleAssignmentId">Immutable
        /// ID of the role assignment.</param>
        public virtual GetRequest Get(string customer, string roleAssignmentId)
        {
            return new GetRequest(service, customer, roleAssignmentId);
        }

        /// <summary>Retrieve a role assignment.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.RoleAssignment>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customer, string roleAssignmentId)
                : base(service)
            {
                Customer = customer;
                RoleAssignmentId = roleAssignmentId;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Immutable ID of the role assignment.</summary>
            [Google.Apis.Util.RequestParameterAttribute("roleAssignmentId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RoleAssignmentId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roleassignments/{roleAssignmentId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "roleAssignmentId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "roleAssignmentId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Creates a role assignment.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.RoleAssignment body, string customer)
        {
            return new InsertRequest(service, body, customer);
        }

        /// <summary>Creates a role assignment.</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.RoleAssignment>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.RoleAssignment body, string customer)
                : base(service)
            {
                Customer = customer;
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.RoleAssignment Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roleassignments";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves a paginated list of all roleAssignments.</summary>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        public virtual ListRequest List(string customer)
        {
            return new ListRequest(service, customer);
        }

        /// <summary>Retrieves a paginated list of all roleAssignments.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.RoleAssignments>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customer)
                : base(service)
            {
                Customer = customer;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Maximum number of results to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Token to specify the next page in the list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Immutable ID of a role. If included in the request, returns only role assignments containing
            /// this role ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("roleId", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string RoleId { get; set; }

            /// <summary>The user's primary email address, alias email address, or unique user ID. If included in the
            /// request, returns role assignments only for this user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string UserKey { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roleassignments";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "roleId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "roleId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "roles" collection of methods.</summary>
    public class RolesResource
    {
        private const string Resource = "roles";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public RolesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Deletes a role.</summary>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        /// <param name="roleId">Immutable ID of the
        /// role.</param>
        public virtual DeleteRequest Delete(string customer, string roleId)
        {
            return new DeleteRequest(service, customer, roleId);
        }

        /// <summary>Deletes a role.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string customer, string roleId)
                : base(service)
            {
                Customer = customer;
                RoleId = roleId;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Immutable ID of the role.</summary>
            [Google.Apis.Util.RequestParameterAttribute("roleId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RoleId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roles/{roleId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "roleId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "roleId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves a role.</summary>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        /// <param name="roleId">Immutable ID of the
        /// role.</param>
        public virtual GetRequest Get(string customer, string roleId)
        {
            return new GetRequest(service, customer, roleId);
        }

        /// <summary>Retrieves a role.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Role>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customer, string roleId)
                : base(service)
            {
                Customer = customer;
                RoleId = roleId;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Immutable ID of the role.</summary>
            [Google.Apis.Util.RequestParameterAttribute("roleId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RoleId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roles/{roleId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "roleId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "roleId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Creates a role.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Role body, string customer)
        {
            return new InsertRequest(service, body, customer);
        }

        /// <summary>Creates a role.</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Role>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Role body, string customer)
                : base(service)
            {
                Customer = customer;
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Role Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roles";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves a paginated list of all the roles in a domain.</summary>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        public virtual ListRequest List(string customer)
        {
            return new ListRequest(service, customer);
        }

        /// <summary>Retrieves a paginated list of all the roles in a domain.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Roles>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customer)
                : base(service)
            {
                Customer = customer;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Maximum number of results to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Token to specify the next page in the list.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roles";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Patch role via Apiary Patch Orchestration</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        /// <param name="roleId">Immutable ID of the
        /// role.</param>
        public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.Role body, string customer, string roleId)
        {
            return new PatchRequest(service, body, customer, roleId);
        }

        /// <summary>Patch role via Apiary Patch Orchestration</summary>
        public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Role>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Role body, string customer, string roleId)
                : base(service)
            {
                Customer = customer;
                RoleId = roleId;
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Immutable ID of the role.</summary>
            [Google.Apis.Util.RequestParameterAttribute("roleId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RoleId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Role Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roles/{roleId}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "roleId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "roleId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates a role.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customer">Immutable ID of the G Suite account.</param>
        /// <param name="roleId">Immutable ID of the
        /// role.</param>
        public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.Role body, string customer, string roleId)
        {
            return new UpdateRequest(service, body, customer, roleId);
        }

        /// <summary>Updates a role.</summary>
        public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Role>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Role body, string customer, string roleId)
                : base(service)
            {
                Customer = customer;
                RoleId = roleId;
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Customer { get; private set; }

            /// <summary>Immutable ID of the role.</summary>
            [Google.Apis.Util.RequestParameterAttribute("roleId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string RoleId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Role Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "update";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customer}/roles/{roleId}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "roleId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "roleId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "schemas" collection of methods.</summary>
    public class SchemasResource
    {
        private const string Resource = "schemas";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SchemasResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Delete schema</summary>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="schemaKey">Name or
        /// immutable ID of the schema</param>
        public virtual DeleteRequest Delete(string customerId, string schemaKey)
        {
            return new DeleteRequest(service, customerId, schemaKey);
        }

        /// <summary>Delete schema</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string customerId, string schemaKey)
                : base(service)
            {
                CustomerId = customerId;
                SchemaKey = schemaKey;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Name or immutable ID of the schema</summary>
            [Google.Apis.Util.RequestParameterAttribute("schemaKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SchemaKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/schemas/{schemaKey}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "schemaKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "schemaKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieve schema</summary>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="schemaKey">Name or
        /// immutable ID of the schema</param>
        public virtual GetRequest Get(string customerId, string schemaKey)
        {
            return new GetRequest(service, customerId, schemaKey);
        }

        /// <summary>Retrieve schema</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Schema>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string customerId, string schemaKey)
                : base(service)
            {
                CustomerId = customerId;
                SchemaKey = schemaKey;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Name or immutable ID of the schema</summary>
            [Google.Apis.Util.RequestParameterAttribute("schemaKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SchemaKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/schemas/{schemaKey}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "schemaKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "schemaKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Create schema.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Schema body, string customerId)
        {
            return new InsertRequest(service, body, customerId);
        }

        /// <summary>Create schema.</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Schema>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Schema body, string customerId)
                : base(service)
            {
                CustomerId = customerId;
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Schema Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/schemas";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieve all schemas for a customer</summary>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        public virtual ListRequest List(string customerId)
        {
            return new ListRequest(service, customerId);
        }

        /// <summary>Retrieve all schemas for a customer</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Schemas>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string customerId)
                : base(service)
            {
                CustomerId = customerId;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/schemas";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Patch Schema via Apiary Patch Orchestration</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="schemaKey">Name or
        /// immutable ID of the schema.</param>
        public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.Schema body, string customerId, string schemaKey)
        {
            return new PatchRequest(service, body, customerId, schemaKey);
        }

        /// <summary>Patch Schema via Apiary Patch Orchestration</summary>
        public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Schema>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Schema body, string customerId, string schemaKey)
                : base(service)
            {
                CustomerId = customerId;
                SchemaKey = schemaKey;
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Name or immutable ID of the schema.</summary>
            [Google.Apis.Util.RequestParameterAttribute("schemaKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SchemaKey { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Schema Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/schemas/{schemaKey}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "schemaKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "schemaKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Update schema</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="customerId">Immutable ID of the G Suite account</param>
        /// <param name="schemaKey">Name or
        /// immutable ID of the schema.</param>
        public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.Schema body, string customerId, string schemaKey)
        {
            return new UpdateRequest(service, body, customerId, schemaKey);
        }

        /// <summary>Update schema</summary>
        public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Schema>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Schema body, string customerId, string schemaKey)
                : base(service)
            {
                CustomerId = customerId;
                SchemaKey = schemaKey;
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string CustomerId { get; private set; }

            /// <summary>Name or immutable ID of the schema.</summary>
            [Google.Apis.Util.RequestParameterAttribute("schemaKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SchemaKey { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Schema Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "update";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/customer/{customerId}/schemas/{schemaKey}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customerId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customerId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "schemaKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "schemaKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "tokens" collection of methods.</summary>
    public class TokensResource
    {
        private const string Resource = "tokens";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public TokensResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Delete all access tokens issued by a user for an application.</summary>
        /// <param name="userKey">Identifies the user in the API request. The value can be the user's primary email address,
        /// alias email address, or unique user ID.</param>
        /// <param name="clientId">The Client ID of the application the
        /// token is issued to.</param>
        public virtual DeleteRequest Delete(string userKey, string clientId)
        {
            return new DeleteRequest(service, userKey, clientId);
        }

        /// <summary>Delete all access tokens issued by a user for an application.</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string userKey, string clientId)
                : base(service)
            {
                UserKey = userKey;
                ClientId = clientId;
                InitParameters();
            }


            /// <summary>Identifies the user in the API request. The value can be the user's primary email address,
            /// alias email address, or unique user ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>The Client ID of the application the token is issued to.</summary>
            [Google.Apis.Util.RequestParameterAttribute("clientId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ClientId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/tokens/{clientId}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "clientId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "clientId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Get information about an access token issued by a user.</summary>
        /// <param name="userKey">Identifies the user in the API request. The value can be the user's primary email address,
        /// alias email address, or unique user ID.</param>
        /// <param name="clientId">The Client ID of the application the
        /// token is issued to.</param>
        public virtual GetRequest Get(string userKey, string clientId)
        {
            return new GetRequest(service, userKey, clientId);
        }

        /// <summary>Get information about an access token issued by a user.</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Token>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string userKey, string clientId)
                : base(service)
            {
                UserKey = userKey;
                ClientId = clientId;
                InitParameters();
            }


            /// <summary>Identifies the user in the API request. The value can be the user's primary email address,
            /// alias email address, or unique user ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>The Client ID of the application the token is issued to.</summary>
            [Google.Apis.Util.RequestParameterAttribute("clientId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ClientId { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/tokens/{clientId}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "clientId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "clientId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Returns the set of tokens specified user has issued to 3rd party applications.</summary>
        /// <param name="userKey">Identifies the user in the API request. The value can be the user's primary email address,
        /// alias email address, or unique user ID.</param>
        public virtual ListRequest List(string userKey)
        {
            return new ListRequest(service, userKey);
        }

        /// <summary>Returns the set of tokens specified user has issued to 3rd party applications.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Tokens>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string userKey)
                : base(service)
            {
                UserKey = userKey;
                InitParameters();
            }


            /// <summary>Identifies the user in the API request. The value can be the user's primary email address,
            /// alias email address, or unique user ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/tokens";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "users" collection of methods.</summary>
    public class UsersResource
    {
        private const string Resource = "users";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public UsersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Aliases = new AliasesResource(service);
            Photos = new PhotosResource(service);

        }

        /// <summary>Gets the Aliases resource.</summary>
        public virtual AliasesResource Aliases { get; }

        /// <summary>The "aliases" collection of methods.</summary>
        public class AliasesResource
        {
            private const string Resource = "aliases";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AliasesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Remove a alias for the user</summary>
            /// <param name="userKey">Email or immutable ID of the user</param>
            /// <param name="alias">The alias to be
            /// removed</param>
            public virtual DeleteRequest Delete(string userKey, string alias)
            {
                return new DeleteRequest(service, userKey, alias);
            }

            /// <summary>Remove a alias for the user</summary>
            public class DeleteRequest : DirectoryBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string userKey, string alias)
                    : base(service)
                {
                    UserKey = userKey;
                    Alias = alias;
                    InitParameters();
                }


                /// <summary>Email or immutable ID of the user</summary>
                [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserKey { get; private set; }

                /// <summary>The alias to be removed</summary>
                [Google.Apis.Util.RequestParameterAttribute("alias", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Alias { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/users/{userKey}/aliases/{alias}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "userKey", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userKey",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "alias", new Google.Apis.Discovery.Parameter
                        {
                            Name = "alias",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Add a alias for the user</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userKey">Email or immutable ID of the user</param>
            public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.Alias body, string userKey)
            {
                return new InsertRequest(service, body, userKey);
            }

            /// <summary>Add a alias for the user</summary>
            public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Alias>
            {
                /// <summary>Constructs a new Insert request.</summary>
                public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Alias body, string userKey)
                    : base(service)
                {
                    UserKey = userKey;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Email or immutable ID of the user</summary>
                [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserKey { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Alias Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "insert";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/users/{userKey}/aliases";

                /// <summary>Initializes Insert parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "userKey", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userKey",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>List all aliases for a user</summary>
            /// <param name="userKey">Email or immutable ID of the user</param>
            public virtual ListRequest List(string userKey)
            {
                return new ListRequest(service, userKey);
            }

            /// <summary>List all aliases for a user</summary>
            public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Aliases>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string userKey)
                    : base(service)
                {
                    UserKey = userKey;
                    InitParameters();
                }


                /// <summary>Email or immutable ID of the user</summary>
                [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserKey { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/users/{userKey}/aliases";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "userKey", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userKey",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Watch for changes in users list</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userKey">Email or immutable ID of the user</param>
            public virtual WatchRequest Watch(Google.Apis.Admin.Directory.directory_v1.Data.Channel body, string userKey)
            {
                return new WatchRequest(service, body, userKey);
            }

            /// <summary>Watch for changes in users list</summary>
            public class WatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Channel>
            {
                /// <summary>Constructs a new Watch request.</summary>
                public WatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Channel body, string userKey)
                    : base(service)
                {
                    UserKey = userKey;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Email or immutable ID of the user</summary>
                [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserKey { get; private set; }

                /// <summary>Event on which subscription is intended (if subscribing)</summary>
                [Google.Apis.Util.RequestParameterAttribute("event", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<EventEnum> Event { get; set; }

                /// <summary>Event on which subscription is intended (if subscribing)</summary>
                public enum EventEnum
                {
                    [Google.Apis.Util.StringValueAttribute("eventUndefined")]
                    EventUndefined,
                    /// <summary>Alias Created Event</summary>
                    [Google.Apis.Util.StringValueAttribute("add")]
                    Add,
                    /// <summary>Alias Deleted Event</summary>
                    [Google.Apis.Util.StringValueAttribute("delete")]
                    Delete,
                }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.Channel Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "watch";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/users/{userKey}/aliases/watch";

                /// <summary>Initializes Watch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "userKey", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userKey",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "event", new Google.Apis.Discovery.Parameter
                        {
                            Name = "event",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }
        }
        /// <summary>Gets the Photos resource.</summary>
        public virtual PhotosResource Photos { get; }

        /// <summary>The "photos" collection of methods.</summary>
        public class PhotosResource
        {
            private const string Resource = "photos";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public PhotosResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Remove photos for the user</summary>
            /// <param name="userKey">Email or immutable ID of the user</param>
            public virtual DeleteRequest Delete(string userKey)
            {
                return new DeleteRequest(service, userKey);
            }

            /// <summary>Remove photos for the user</summary>
            public class DeleteRequest : DirectoryBaseServiceRequest<string>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string userKey)
                    : base(service)
                {
                    UserKey = userKey;
                    InitParameters();
                }


                /// <summary>Email or immutable ID of the user</summary>
                [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserKey { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/users/{userKey}/photos/thumbnail";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "userKey", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userKey",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Retrieve photo of a user</summary>
            /// <param name="userKey">Email or immutable ID of the user</param>
            public virtual GetRequest Get(string userKey)
            {
                return new GetRequest(service, userKey);
            }

            /// <summary>Retrieve photo of a user</summary>
            public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string userKey)
                    : base(service)
                {
                    UserKey = userKey;
                    InitParameters();
                }


                /// <summary>Email or immutable ID of the user</summary>
                [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserKey { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/users/{userKey}/photos/thumbnail";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "userKey", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userKey",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Patch Photo via Apiary Patch Orchestration</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userKey">Email or immutable ID of the user</param>
            public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto body, string userKey)
            {
                return new PatchRequest(service, body, userKey);
            }

            /// <summary>Patch Photo via Apiary Patch Orchestration</summary>
            public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto body, string userKey)
                    : base(service)
                {
                    UserKey = userKey;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Email or immutable ID of the user</summary>
                [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserKey { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/users/{userKey}/photos/thumbnail";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "userKey", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userKey",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Add a photo for the user</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="userKey">Email or immutable ID of the user</param>
            public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto body, string userKey)
            {
                return new UpdateRequest(service, body, userKey);
            }

            /// <summary>Add a photo for the user</summary>
            public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto>
            {
                /// <summary>Constructs a new Update request.</summary>
                public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto body, string userKey)
                    : base(service)
                {
                    UserKey = userKey;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Email or immutable ID of the user</summary>
                [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string UserKey { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Admin.Directory.directory_v1.Data.UserPhoto Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "update";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "admin/directory/v1/users/{userKey}/photos/thumbnail";

                /// <summary>Initializes Update parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "userKey", new Google.Apis.Discovery.Parameter
                        {
                            Name = "userKey",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }
        }

        /// <summary>Delete user</summary>
        /// <param name="userKey">Email or immutable ID of the user</param>
        public virtual DeleteRequest Delete(string userKey)
        {
            return new DeleteRequest(service, userKey);
        }

        /// <summary>Delete user</summary>
        public class DeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string userKey)
                : base(service)
            {
                UserKey = userKey;
                InitParameters();
            }


            /// <summary>Email or immutable ID of the user</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>retrieve user</summary>
        /// <param name="userKey">Email or immutable ID of the user</param>
        public virtual GetRequest Get(string userKey)
        {
            return new GetRequest(service, userKey);
        }

        /// <summary>retrieve user</summary>
        public class GetRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.User>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string userKey)
                : base(service)
            {
                UserKey = userKey;
                InitParameters();
            }


            /// <summary>Email or immutable ID of the user</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }

            /// <summary>Comma-separated list of schema names. All fields from these schemas are fetched. This should
            /// only be set when projection=custom.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customFieldMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomFieldMask { get; set; }

            /// <summary>What subset of fields to fetch for this user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>What subset of fields to fetch for this user.</summary>
            public enum ProjectionEnum
            {
                [Google.Apis.Util.StringValueAttribute("projectionUndefined")]
                ProjectionUndefined,
                /// <summary>Do not include any custom fields for the user.</summary>
                [Google.Apis.Util.StringValueAttribute("basic")]
                Basic,
                /// <summary>Include custom fields from schemas mentioned in customFieldMask.</summary>
                [Google.Apis.Util.StringValueAttribute("custom")]
                Custom,
                /// <summary>Include all fields associated with this user.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full,
            }

            /// <summary>Whether to fetch the ADMIN_VIEW or DOMAIN_PUBLIC view of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("viewType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewTypeEnum> ViewType { get; set; }

            /// <summary>Whether to fetch the ADMIN_VIEW or DOMAIN_PUBLIC view of the user.</summary>
            public enum ViewTypeEnum
            {
                [Google.Apis.Util.StringValueAttribute("view_type_undefined")]
                ViewTypeUndefined,
                /// <summary>Fetches the ADMIN_VIEW of the user.</summary>
                [Google.Apis.Util.StringValueAttribute("admin_view")]
                AdminView,
                /// <summary>Fetches the DOMAIN_PUBLIC view of the user.</summary>
                [Google.Apis.Util.StringValueAttribute("domain_public")]
                DomainPublic,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "customFieldMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customFieldMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "projection", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projection",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "basic",
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "viewType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "viewType",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "admin_view",
                        Pattern = null,
                    });
            }

        }

        /// <summary>create user.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual InsertRequest Insert(Google.Apis.Admin.Directory.directory_v1.Data.User body)
        {
            return new InsertRequest(service, body);
        }

        /// <summary>create user.</summary>
        public class InsertRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.User>
        {
            /// <summary>Constructs a new Insert request.</summary>
            public InsertRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.User body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.User Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "insert";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users";

            /// <summary>Initializes Insert parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Retrieve either deleted users or all users in a domain (paginated)</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Retrieve either deleted users or all users in a domain (paginated)</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Users>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }


            /// <summary>Comma-separated list of schema names. All fields from these schemas are fetched. This should
            /// only be set when projection=custom.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customFieldMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string CustomFieldMask { get; set; }

            /// <summary>Immutable ID of the G Suite account. In case of multi-domain, to fetch all users for a
            /// customer, fill this field instead of domain.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Customer { get; set; }

            /// <summary>Name of the domain. Fill this field to get users from only this domain. To return all users in
            /// a multi-domain fill customer field instead.</summary>
            [Google.Apis.Util.RequestParameterAttribute("domain", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Domain { get; set; }

            /// <summary>Maximum number of results to return.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> MaxResults { get; set; }

            /// <summary>Column to use for sorting results</summary>
            [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<OrderByEnum> OrderBy { get; set; }

            /// <summary>Column to use for sorting results</summary>
            public enum OrderByEnum
            {
                [Google.Apis.Util.StringValueAttribute("orderByUndefined")]
                OrderByUndefined,
                /// <summary>Primary email of the user.</summary>
                [Google.Apis.Util.StringValueAttribute("email")]
                Email,
                /// <summary>User's family name.</summary>
                [Google.Apis.Util.StringValueAttribute("familyName")]
                FamilyName,
                /// <summary>User's given name.</summary>
                [Google.Apis.Util.StringValueAttribute("givenName")]
                GivenName,
            }

            /// <summary>Token to specify next page in the list</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>What subset of fields to fetch for this user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projection", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ProjectionEnum> Projection { get; set; }

            /// <summary>What subset of fields to fetch for this user.</summary>
            public enum ProjectionEnum
            {
                [Google.Apis.Util.StringValueAttribute("projectionUndefined")]
                ProjectionUndefined,
                /// <summary>Do not include any custom fields for the user.</summary>
                [Google.Apis.Util.StringValueAttribute("basic")]
                Basic,
                /// <summary>Include custom fields from schemas mentioned in customFieldMask.</summary>
                [Google.Apis.Util.StringValueAttribute("custom")]
                Custom,
                /// <summary>Include all fields associated with this user.</summary>
                [Google.Apis.Util.StringValueAttribute("full")]
                Full,
            }

            /// <summary>Query string search. Should be of the form "". Complete documentation is at https:
            /// //developers.google.com/admin-sdk/directory/v1/guides/search-users</summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>If set to true, retrieves the list of deleted users. (Default: false)</summary>
            [Google.Apis.Util.RequestParameterAttribute("showDeleted", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string ShowDeleted { get; set; }

            /// <summary>Whether to return results in ascending or descending order.</summary>
            [Google.Apis.Util.RequestParameterAttribute("sortOrder", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<SortOrderEnum> SortOrder { get; set; }

            /// <summary>Whether to return results in ascending or descending order.</summary>
            public enum SortOrderEnum
            {
                [Google.Apis.Util.StringValueAttribute("SORT_ORDER_UNDEFINED")]
                SORTORDERUNDEFINED,
                /// <summary>Ascending order.</summary>
                [Google.Apis.Util.StringValueAttribute("ASCENDING")]
                ASCENDING,
                /// <summary>Descending order.</summary>
                [Google.Apis.Util.StringValueAttribute("DESCENDING")]
                DESCENDING,
            }

            /// <summary>Whether to fetch the ADMIN_VIEW or DOMAIN_PUBLIC view of the user.</summary>
            [Google.Apis.Util.RequestParameterAttribute("viewType", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewTypeEnum> ViewType { get; set; }

            /// <summary>Whether to fetch the ADMIN_VIEW or DOMAIN_PUBLIC view of the user.</summary>
            public enum ViewTypeEnum
            {
                [Google.Apis.Util.StringValueAttribute("view_type_undefined")]
                ViewTypeUndefined,
                /// <summary>Fetches the ADMIN_VIEW of the user.</summary>
                [Google.Apis.Util.StringValueAttribute("admin_view")]
                AdminView,
                /// <summary>Fetches the DOMAIN_PUBLIC view of the user.</summary>
                [Google.Apis.Util.StringValueAttribute("domain_public")]
                DomainPublic,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customFieldMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customFieldMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "domain", new Google.Apis.Discovery.Parameter
                    {
                        Name = "domain",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "maxResults", new Google.Apis.Discovery.Parameter
                    {
                        Name = "maxResults",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "100",
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "projection", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projection",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "basic",
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "query", new Google.Apis.Discovery.Parameter
                    {
                        Name = "query",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "showDeleted", new Google.Apis.Discovery.Parameter
                    {
                        Name = "showDeleted",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "sortOrder", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sortOrder",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "viewType", new Google.Apis.Discovery.Parameter
                    {
                        Name = "viewType",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = "admin_view",
                        Pattern = null,
                    });
            }

        }

        /// <summary>change admin status of a user</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="userKey">Email or immutable ID of the user as admin</param>
        public virtual MakeAdminRequest MakeAdmin(Google.Apis.Admin.Directory.directory_v1.Data.UserMakeAdmin body, string userKey)
        {
            return new MakeAdminRequest(service, body, userKey);
        }

        /// <summary>change admin status of a user</summary>
        public class MakeAdminRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new MakeAdmin request.</summary>
            public MakeAdminRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.UserMakeAdmin body, string userKey)
                : base(service)
            {
                UserKey = userKey;
                Body = body;
                InitParameters();
            }


            /// <summary>Email or immutable ID of the user as admin</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.UserMakeAdmin Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "makeAdmin";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/makeAdmin";

            /// <summary>Initializes MakeAdmin parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Patch Users via Apiary Patch Orchestration</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="userKey">Email or immutable ID of the user. If ID, it should match with id of user object</param>
        public virtual PatchRequest Patch(Google.Apis.Admin.Directory.directory_v1.Data.User body, string userKey)
        {
            return new PatchRequest(service, body, userKey);
        }

        /// <summary>Patch Users via Apiary Patch Orchestration</summary>
        public class PatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.User>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.User body, string userKey)
                : base(service)
            {
                UserKey = userKey;
                Body = body;
                InitParameters();
            }


            /// <summary>Email or immutable ID of the user. If ID, it should match with id of user object</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.User Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Undelete a deleted user</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="userKey">The immutable id of the user</param>
        public virtual UndeleteRequest Undelete(Google.Apis.Admin.Directory.directory_v1.Data.UserUndelete body, string userKey)
        {
            return new UndeleteRequest(service, body, userKey);
        }

        /// <summary>Undelete a deleted user</summary>
        public class UndeleteRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Undelete request.</summary>
            public UndeleteRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.UserUndelete body, string userKey)
                : base(service)
            {
                UserKey = userKey;
                Body = body;
                InitParameters();
            }


            /// <summary>The immutable id of the user</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.UserUndelete Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "undelete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/undelete";

            /// <summary>Initializes Undelete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>update user</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="userKey">Email or immutable ID of the user. If ID, it should match with id of user object</param>
        public virtual UpdateRequest Update(Google.Apis.Admin.Directory.directory_v1.Data.User body, string userKey)
        {
            return new UpdateRequest(service, body, userKey);
        }

        /// <summary>update user</summary>
        public class UpdateRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.User>
        {
            /// <summary>Constructs a new Update request.</summary>
            public UpdateRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.User body, string userKey)
                : base(service)
            {
                UserKey = userKey;
                Body = body;
                InitParameters();
            }


            /// <summary>Email or immutable ID of the user. If ID, it should match with id of user object</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.User Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "update";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}";

            /// <summary>Initializes Update parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Watch for changes in users list</summary>
        /// <param name="body">The body of the request.</param>
        public virtual WatchRequest Watch(Google.Apis.Admin.Directory.directory_v1.Data.Channel body)
        {
            return new WatchRequest(service, body);
        }

        /// <summary>Watch for changes in users list</summary>
        public class WatchRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.Channel>
        {
            /// <summary>Constructs a new Watch request.</summary>
            public WatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Admin.Directory.directory_v1.Data.Channel body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }


            /// <summary>Immutable ID of the G Suite account. In case of multi-domain, to fetch all users for a
            /// customer, fill this field instead of domain.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customer", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Customer { get; set; }

            /// <summary>Name of the domain. Fill this field to get users from only this domain. To return all users in
            /// a multi-domain fill customer field instead."</summary>
            [Google.Apis.Util.RequestParameterAttribute("domain", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Domain { get; set; }

            /// <summary>Event on which subscription is intended</summary>
            [Google.Apis.Util.RequestParameterAttribute("event", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<EventEnum> Event { get; set; }

            /// <summary>Event on which subscription is intended</summary>
            public enum EventEnum
            {
                [Google.Apis.Util.StringValueAttribute("eventTypeUnspecified")]
                EventTypeUnspecified,
                /// <summary>User Created Event</summary>
                [Google.Apis.Util.StringValueAttribute("add")]
                Add,
                /// <summary>User Deleted Event</summary>
                [Google.Apis.Util.StringValueAttribute("delete")]
                Delete,
                /// <summary>User Admin Status Change Event</summary>
                [Google.Apis.Util.StringValueAttribute("makeAdmin")]
                MakeAdmin,
                /// <summary>User Undeleted Event</summary>
                [Google.Apis.Util.StringValueAttribute("undelete")]
                Undelete,
                /// <summary>User Updated Event</summary>
                [Google.Apis.Util.StringValueAttribute("update")]
                Update,
            }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Admin.Directory.directory_v1.Data.Channel Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "watch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/watch";

            /// <summary>Initializes Watch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "customer", new Google.Apis.Discovery.Parameter
                    {
                        Name = "customer",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "domain", new Google.Apis.Discovery.Parameter
                    {
                        Name = "domain",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "event", new Google.Apis.Discovery.Parameter
                    {
                        Name = "event",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "verificationCodes" collection of methods.</summary>
    public class VerificationCodesResource
    {
        private const string Resource = "verificationCodes";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public VerificationCodesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Generate new backup verification codes for the user.</summary>
        /// <param name="userKey">Email or immutable ID of the user</param>
        public virtual GenerateRequest Generate(string userKey)
        {
            return new GenerateRequest(service, userKey);
        }

        /// <summary>Generate new backup verification codes for the user.</summary>
        public class GenerateRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Generate request.</summary>
            public GenerateRequest(Google.Apis.Services.IClientService service, string userKey)
                : base(service)
            {
                UserKey = userKey;
                InitParameters();
            }


            /// <summary>Email or immutable ID of the user</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "generate";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/verificationCodes/generate";

            /// <summary>Initializes Generate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Invalidate the current backup verification codes for the user.</summary>
        /// <param name="userKey">Email or immutable ID of the user</param>
        public virtual InvalidateRequest Invalidate(string userKey)
        {
            return new InvalidateRequest(service, userKey);
        }

        /// <summary>Invalidate the current backup verification codes for the user.</summary>
        public class InvalidateRequest : DirectoryBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Invalidate request.</summary>
            public InvalidateRequest(Google.Apis.Services.IClientService service, string userKey)
                : base(service)
            {
                UserKey = userKey;
                InitParameters();
            }


            /// <summary>Email or immutable ID of the user</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "invalidate";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/verificationCodes/invalidate";

            /// <summary>Initializes Invalidate parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Returns the current set of valid backup verification codes for the specified user.</summary>
        /// <param name="userKey">Identifies the user in the API request. The value can be the user's primary email address,
        /// alias email address, or unique user ID.</param>
        public virtual ListRequest List(string userKey)
        {
            return new ListRequest(service, userKey);
        }

        /// <summary>Returns the current set of valid backup verification codes for the specified user.</summary>
        public class ListRequest : DirectoryBaseServiceRequest<Google.Apis.Admin.Directory.directory_v1.Data.VerificationCodes>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string userKey)
                : base(service)
            {
                UserKey = userKey;
                InitParameters();
            }


            /// <summary>Identifies the user in the API request. The value can be the user's primary email address,
            /// alias email address, or unique user ID.</summary>
            [Google.Apis.Util.RequestParameterAttribute("userKey", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string UserKey { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "admin/directory/v1/users/{userKey}/verificationCodes";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "userKey", new Google.Apis.Discovery.Parameter
                    {
                        Name = "userKey",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.Admin.Directory.directory_v1.Data
{    

    /// <summary>JSON template for Alias object in Directory API.</summary>
    public class Alias : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("alias")]
        public virtual string AliasValue { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("primaryEmail")]
        public virtual string PrimaryEmail { get; set; } 

    }    

    /// <summary>JSON response template to list aliases in Directory API.</summary>
    public class Aliases : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("aliases")]
        public virtual System.Collections.Generic.IList<Alias> AliasesValue { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

    }    

    /// <summary>The template that returns individual ASP (Access Code) data. STEPLADDER: Generated unstable field
    /// number for field 'kind'. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number
    /// for field 'etag'. (See http://go/stepladder-help#fieldNumber)</summary>
    public class Asp : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique ID of the ASP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("codeId")]
        public virtual System.Nullable<int> CodeId { get; set; } 

        /// <summary>The time when the ASP was created. Expressed in Unix time format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual System.Nullable<long> CreationTime { get; set; } 

        /// <summary>ETag of the ASP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>The type of the API resource. This is always admin#directory#asp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The time when the ASP was last used. Expressed in Unix time format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastTimeUsed")]
        public virtual System.Nullable<long> LastTimeUsed { get; set; } 

        /// <summary>The name of the application that the user, represented by their userId, entered when the ASP was
        /// created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The unique ID of the user who issued the ASP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userKey")]
        public virtual string UserKey { get; set; } 

    }    

    /// <summary>STEPLADDER: Generated unstable field number for field 'kind'. (See http://go/stepladder-
    /// help#fieldNumber) STEPLADDER: Generated unstable field number for field 'etag'. (See http://go/stepladder-
    /// help#fieldNumber)</summary>
    public class Asps : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>A list of ASP resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Asp> Items { get; set; } 

        /// <summary>The type of the API resource. This is always admin#directory#aspList.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

    }    

    /// <summary>Public API: Resources.buildings</summary>
    public class Building : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The postal address of the building. See PostalAddress for details. Note that only a single address
        /// line and region code are required.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual BuildingAddress Address { get; set; } 

        /// <summary>Unique identifier for the building. The maximum length is 100 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildingId")]
        public virtual string BuildingId { get; set; } 

        /// <summary>The building name as seen by users in Calendar. Must be unique for the customer. For example, "NYC-
        /// CHEL". The maximum length is 100 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildingName")]
        public virtual string BuildingName { get; set; } 

        /// <summary>The geographic coordinates of the center of the building, expressed as latitude and longitude in
        /// decimal degrees.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("coordinates")]
        public virtual BuildingCoordinates Coordinates { get; set; } 

        /// <summary>A brief description of the building. For example, "Chelsea Market".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etags")]
        public virtual string Etags { get; set; } 

        /// <summary>The display names for all floors in this building. The floors are expected to be sorted in
        /// ascending order, from lowest floor to highest floor. For example, ["B2", "B1", "L", "1", "2", "2M", "3",
        /// "PH"] Must contain at least one entry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floorNames")]
        public virtual System.Collections.Generic.IList<string> FloorNames { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Public API: Resources.buildings</summary>
    public class BuildingAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unstructured address lines describing the lower levels of an address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLines")]
        public virtual System.Collections.Generic.IList<string> AddressLines { get; set; } 

        /// <summary>Optional. Highest administrative subdivision which is used for postal addresses of a country or
        /// region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("administrativeArea")]
        public virtual string AdministrativeArea { get; set; } 

        /// <summary>Optional. BCP-47 language code of the contents of this address (if known).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; } 

        /// <summary>Optional. Generally refers to the city/town portion of the address. Examples: US city, IT comune,
        /// UK post town. In regions of the world where localities are not well defined or do not fit into this
        /// structure well, leave locality empty and use addressLines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; } 

        /// <summary>Optional. Postal code of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; } 

        /// <summary>Required. CLDR region code of the country/region of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; } 

        /// <summary>Optional. Sublocality of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sublocality")]
        public virtual string Sublocality { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Public API: Resources.buildings</summary>
    public class BuildingCoordinates : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Latitude in decimal degrees.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; } 

        /// <summary>Longitude in decimal degrees.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Public API: Resources.buildings</summary>
    public class Buildings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The Buildings in this page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildings")]
        public virtual System.Collections.Generic.IList<Building> BuildingsValue { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The continuation token, used to page through large result sets. Provide this value in a subsequent
        /// request to return the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

    }    

    /// <summary>Public API: Resources.calendars</summary>
    public class CalendarResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Unique ID for the building a resource is located in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildingId")]
        public virtual string BuildingId { get; set; } 

        /// <summary>Capacity of a resource, number of seats in a room.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("capacity")]
        public virtual System.Nullable<int> Capacity { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etags")]
        public virtual string Etags { get; set; } 

        /// <summary>Instances of features for the calendar resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("featureInstances")]
        public virtual object FeatureInstances { get; set; } 

        /// <summary>Name of the floor a resource is located on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floorName")]
        public virtual string FloorName { get; set; } 

        /// <summary>Name of the section within a floor a resource is located in.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floorSection")]
        public virtual string FloorSection { get; set; } 

        /// <summary>The read-only auto-generated name of the calendar resource which includes metadata about the
        /// resource such as building name, floor, capacity, etc. For example, "NYC-2-Training Room 1A (16)".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("generatedResourceName")]
        public virtual string GeneratedResourceName { get; set; } 

        /// <summary>The type of the resource. For calendar resources, the value is
        /// admin#directory#resources#calendars#CalendarResource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The category of the calendar resource. Either CONFERENCE_ROOM or OTHER. Legacy data is set to
        /// CATEGORY_UNKNOWN.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceCategory")]
        public virtual string ResourceCategory { get; set; } 

        /// <summary>Description of the resource, visible only to admins.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceDescription")]
        public virtual string ResourceDescription { get; set; } 

        /// <summary>The read-only email for the calendar resource. Generated as part of creating a new calendar
        /// resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceEmail")]
        public virtual string ResourceEmail { get; set; } 

        /// <summary>The unique ID for the calendar resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; } 

        /// <summary>The name of the calendar resource. For example, "Training Room 1A".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; } 

        /// <summary>The type of the calendar resource, intended for non-room resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; } 

        /// <summary>Description of the resource, visible to users and admins.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userVisibleDescription")]
        public virtual string UserVisibleDescription { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Public API: Resources.calendars</summary>
    public class CalendarResources : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>The CalendarResources in this page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<CalendarResource> Items { get; set; } 

        /// <summary>Identifies this as a collection of CalendarResources. This is always
        /// admin#directory#resources#calendars#calendarResourcesList.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The continuation token, used to page through large result sets. Provide this value in a subsequent
        /// request to return the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

    }    

    /// <summary>An notification channel used to watch for resource changes.</summary>
    public class Channel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The address where notifications are delivered for this channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; } 

        /// <summary>Date and time of notification channel expiration, expressed as a Unix timestamp, in milliseconds.
        /// Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiration")]
        public virtual System.Nullable<long> Expiration { get; set; } 

        /// <summary>A UUID or similar unique string that identifies this channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>Identifies this as a notification channel used to watch for changes to a resource, which is
        /// "api#channel".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Additional parameters controlling delivery channel behavior. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("params")]
        public virtual System.Collections.Generic.IDictionary<string,string> Params__ { get; set; } 

        /// <summary>A Boolean value to indicate whether payload is wanted. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Nullable<bool> Payload { get; set; } 

        /// <summary>An opaque ID that identifies the resource being watched on this channel. Stable across different
        /// API versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; } 

        /// <summary>A version-specific identifier for the watched resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUri")]
        public virtual string ResourceUri { get; set; } 

        /// <summary>An arbitrary string delivered to the target address with each notification delivered over this
        /// channel. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("token")]
        public virtual string Token { get; set; } 

        /// <summary>The type of delivery mechanism used for this channel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>STEPLADDER: Generated unstable field number for field 'kind'. (See http://go/stepladder-
    /// help#fieldNumber) STEPLADDER: Generated unstable field number for field 'etag'. (See http://go/stepladder-
    /// help#fieldNumber)</summary>
    public class ChromeOsDevice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of active time ranges (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("activeTimeRanges")]
        public virtual System.Collections.Generic.IList<ChromeOsDevice.ActiveTimeRangesData> ActiveTimeRanges { get; set; } 

        /// <summary>AssetId specified during enrollment or through later annotation</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedAssetId")]
        public virtual string AnnotatedAssetId { get; set; } 

        /// <summary>Address or location of the device as noted by the administrator</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedLocation")]
        public virtual string AnnotatedLocation { get; set; } 

        /// <summary>User of the device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedUser")]
        public virtual string AnnotatedUser { get; set; } 

        /// <summary>(Read-only) The timestamp after which the device will stop receiving Chrome updates or
        /// support</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoUpdateExpiration")]
        public virtual System.Nullable<long> AutoUpdateExpiration { get; set; } 

        /// <summary>Chromebook boot mode (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootMode")]
        public virtual string BootMode { get; set; } 

        /// <summary>Reports of CPU utilization and temperature (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cpuStatusReports")]
        public virtual System.Collections.Generic.IList<ChromeOsDevice.CpuStatusReportsData> CpuStatusReports { get; set; } 

        /// <summary>List of device files to download (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceFiles")]
        public virtual System.Collections.Generic.IList<ChromeOsDevice.DeviceFilesData> DeviceFiles { get; set; } 

        /// <summary>Unique identifier of Chrome OS Device (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; } 

        /// <summary>Reports of disk space and other info about mounted/connected volumes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diskVolumeReports")]
        public virtual System.Collections.Generic.IList<ChromeOsDevice.DiskVolumeReportsData> DiskVolumeReports { get; set; } 

        /// <summary>(Read-only) Built-in MAC address for the docking station that the device connected to. Factory sets
        /// Media access control address (MAC address) assigned for use by a dock. It is reserved specifically for MAC
        /// pass through device policy. The format is twelve (12) hexadecimal digits without any delimiter (uppercase
        /// letters). This is only relevant for some devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dockMacAddress")]
        public virtual string DockMacAddress { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Chromebook Mac Address on ethernet network interface (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ethernetMacAddress")]
        public virtual string EthernetMacAddress { get; set; } 

        /// <summary>(Read-only) MAC address used by the Chromebook’s internal ethernet port, and for onboard network
        /// (ethernet) interface. The format is twelve (12) hexadecimal digits without any delimiter (uppercase
        /// letters). This is only relevant for some devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ethernetMacAddress0")]
        public virtual string EthernetMacAddress0 { get; set; } 

        /// <summary>Chromebook firmware version (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firmwareVersion")]
        public virtual string FirmwareVersion { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Date and time the device was last enrolled (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastEnrollmentTime")]
        public virtual string LastEnrollmentTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="LastEnrollmentTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnore]
        public virtual System.Nullable<System.DateTime> LastEnrollmentTime
        {
            get
            {
                return Google.Apis.Util.Utilities.GetDateTimeFromString(LastEnrollmentTimeRaw);
            }
            set
            {
                LastEnrollmentTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }
        }

        /// <summary>Contains last known network (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastKnownNetwork")]
        public virtual System.Collections.Generic.IList<ChromeOsDevice.LastKnownNetworkData> LastKnownNetwork { get; set; } 

        /// <summary>Date and time the device was last synchronized with the policy settings in the G Suite
        /// administrator control panel (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSync")]
        public virtual string LastSyncRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="LastSyncRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnore]
        public virtual System.Nullable<System.DateTime> LastSync
        {
            get
            {
                return Google.Apis.Util.Utilities.GetDateTimeFromString(LastSyncRaw);
            }
            set
            {
                LastSyncRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }
        }

        /// <summary>Chromebook Mac Address on wifi network interface (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("macAddress")]
        public virtual string MacAddress { get; set; } 

        /// <summary>(Read-only) The date the device was manufactured in yyyy-mm-dd format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufactureDate")]
        public virtual string ManufactureDate { get; set; } 

        /// <summary>Contains either the Mobile Equipment identifier (MEID) or the International Mobile Equipment
        /// Identity (IMEI) for the 3G mobile card in the Chromebook (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meid")]
        public virtual string Meid { get; set; } 

        /// <summary>Chromebook Model (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; } 

        /// <summary>Notes added by the administrator</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual string Notes { get; set; } 

        /// <summary>Chromebook order number (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderNumber")]
        public virtual string OrderNumber { get; set; } 

        /// <summary>OrgUnit of the device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitPath")]
        public virtual string OrgUnitPath { get; set; } 

        /// <summary>Chromebook Os Version (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersion")]
        public virtual string OsVersion { get; set; } 

        /// <summary>Chromebook platform version (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platformVersion")]
        public virtual string PlatformVersion { get; set; } 

        /// <summary>List of recent device users, in descending order by last login time (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recentUsers")]
        public virtual System.Collections.Generic.IList<ChromeOsDevice.RecentUsersData> RecentUsers { get; set; } 

        /// <summary>Chromebook serial number (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; } 

        /// <summary>status of the device (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>Final date the device will be supported (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportEndDate")]
        public virtual string SupportEndDateRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="SupportEndDateRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnore]
        public virtual System.Nullable<System.DateTime> SupportEndDate
        {
            get
            {
                return Google.Apis.Util.Utilities.GetDateTimeFromString(SupportEndDateRaw);
            }
            set
            {
                SupportEndDateRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }
        }

        /// <summary>Reports of amounts of available RAM memory (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemRamFreeReports")]
        public virtual System.Collections.Generic.IList<ChromeOsDevice.SystemRamFreeReportsData> SystemRamFreeReports { get; set; } 

        /// <summary>Total RAM on the device [in bytes] (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemRamTotal")]
        public virtual System.Nullable<long> SystemRamTotal { get; set; } 

        /// <summary>Trusted Platform Module (TPM) (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tpmVersionInfo")]
        public virtual ChromeOsDevice.TpmVersionInfoData TpmVersionInfo { get; set; } 

        /// <summary>Will Chromebook auto renew after support end date (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("willAutoRenew")]
        public virtual System.Nullable<bool> WillAutoRenew { get; set; } 

        

        public class ActiveTimeRangesData
        {
            /// <summary>Duration in milliseconds</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("activeTime")]
            public virtual System.Nullable<int> ActiveTime { get; set; } 

            /// <summary>Date of usage</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("date")]
            public virtual string Date { get; set; } 

        }    

        public class CpuStatusReportsData
        {
            /// <summary>List of CPU temperature samples.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("cpuTemperatureInfo")]
            public virtual System.Collections.Generic.IList<CpuStatusReportsData.CpuTemperatureInfoData> CpuTemperatureInfo { get; set; } 

            [Newtonsoft.Json.JsonPropertyAttribute("cpuUtilizationPercentageInfo")]
            public virtual System.Collections.Generic.IList<System.Nullable<int>> CpuUtilizationPercentageInfo { get; set; } 

            /// <summary>Date and time the report was received.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("reportTime")]
            public virtual string ReportTimeRaw { get; set; }

            /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ReportTimeRaw"/>.</summary>
            [Newtonsoft.Json.JsonIgnore]
            public virtual System.Nullable<System.DateTime> ReportTime
            {
                get
                {
                    return Google.Apis.Util.Utilities.GetDateTimeFromString(ReportTimeRaw);
                }
                set
                {
                    ReportTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
                }
            }

            

            public class CpuTemperatureInfoData
            {
                /// <summary>CPU label</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("label")]
                public virtual string Label { get; set; } 

                /// <summary>Temperature in Celsius degrees.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("temperature")]
                public virtual System.Nullable<int> Temperature { get; set; } 

            }
        }    

        public class DeviceFilesData
        {
            /// <summary>Date and time the file was created</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
            public virtual string CreateTimeRaw { get; set; }

            /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreateTimeRaw"/>.</summary>
            [Newtonsoft.Json.JsonIgnore]
            public virtual System.Nullable<System.DateTime> CreateTime
            {
                get
                {
                    return Google.Apis.Util.Utilities.GetDateTimeFromString(CreateTimeRaw);
                }
                set
                {
                    CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
                }
            }

            /// <summary>File download URL</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("downloadUrl")]
            public virtual string DownloadUrl { get; set; } 

            /// <summary>File name</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name { get; set; } 

            /// <summary>File type</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; } 

        }    

        public class DiskVolumeReportsData
        {
            /// <summary>Disk volumes</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("volumeInfo")]
            public virtual System.Collections.Generic.IList<DiskVolumeReportsData.VolumeInfoData> VolumeInfo { get; set; } 

            

            public class VolumeInfoData
            {
                /// <summary>Free disk space [in bytes]</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("storageFree")]
                public virtual System.Nullable<long> StorageFree { get; set; } 

                /// <summary>Total disk space [in bytes]</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("storageTotal")]
                public virtual System.Nullable<long> StorageTotal { get; set; } 

                /// <summary>Volume id</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("volumeId")]
                public virtual string VolumeId { get; set; } 

            }
        }    

        /// <summary>Information for an ip address.</summary>
        public class LastKnownNetworkData
        {
            /// <summary>The IP address.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
            public virtual string IpAddress { get; set; } 

            /// <summary>The WAN IP address.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("wanIpAddress")]
            public virtual string WanIpAddress { get; set; } 

        }    

        public class RecentUsersData
        {
            /// <summary>Email address of the user. Present only if the user type is managed</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("email")]
            public virtual string Email { get; set; } 

            /// <summary>The type of the user</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("type")]
            public virtual string Type { get; set; } 

        }    

        public class SystemRamFreeReportsData
        {
            /// <summary>Date and time the report was received.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("reportTime")]
            public virtual string ReportTimeRaw { get; set; }

            /// <summary><seealso cref="System.DateTime"/> representation of <see cref="ReportTimeRaw"/>.</summary>
            [Newtonsoft.Json.JsonIgnore]
            public virtual System.Nullable<System.DateTime> ReportTime
            {
                get
                {
                    return Google.Apis.Util.Utilities.GetDateTimeFromString(ReportTimeRaw);
                }
                set
                {
                    ReportTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
                }
            }

            [Newtonsoft.Json.JsonPropertyAttribute("systemRamFreeInfo")]
            public virtual System.Collections.Generic.IList<System.Nullable<long>> SystemRamFreeInfo { get; set; } 

        }    

        /// <summary>Trusted Platform Module (TPM) (Read-only)</summary>
        public class TpmVersionInfoData
        {
            /// <summary>TPM family.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("family")]
            public virtual string Family { get; set; } 

            /// <summary>TPM firmware version.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("firmwareVersion")]
            public virtual string FirmwareVersion { get; set; } 

            /// <summary>TPM manufacturer code.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
            public virtual string Manufacturer { get; set; } 

            /// <summary>TPM specification level.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("specLevel")]
            public virtual string SpecLevel { get; set; } 

            /// <summary>TPM model number.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("tpmModel")]
            public virtual string TpmModel { get; set; } 

            /// <summary>Vendor-specific information such as Vendor ID.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("vendorSpecific")]
            public virtual string VendorSpecific { get; set; } 

        }
    }    

    public class ChromeOsDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Action to be taken on the ChromeOs Device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("deprovisionReason")]
        public virtual string DeprovisionReason { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>STEPLADDER: Generated unstable field number for field 'kind'. (See http://go/stepladder-
    /// help#fieldNumber) STEPLADDER: Generated unstable field number for field 'etag'. (See http://go/stepladder-
    /// help#fieldNumber)</summary>
    public class ChromeOsDevices : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Chrome OS Device objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("chromeosdevices")]
        public virtual System.Collections.Generic.IList<ChromeOsDevice> Chromeosdevices { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Token used to access next page of this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

    }    

    public class ChromeOsMoveDevicesToOu : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ChromeOs Devices to be moved to OU</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceIds")]
        public virtual System.Collections.Generic.IList<string> DeviceIds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>STEPLADDER: Generated unstable field number for field 'kind'. (See http://go/stepladder-
    /// help#fieldNumber) STEPLADDER: Generated unstable field number for field 'etag'. (See http://go/stepladder-
    /// help#fieldNumber)</summary>
    public class Customer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The customer's secondary contact email address. This email address cannot be on the same domain as
        /// the customerDomain</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternateEmail")]
        public virtual string AlternateEmail { get; set; } 

        /// <summary>The customer's creation time (Readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerCreationTime")]
        public virtual string CustomerCreationTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CustomerCreationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnore]
        public virtual System.Nullable<System.DateTime> CustomerCreationTime
        {
            get
            {
                return Google.Apis.Util.Utilities.GetDateTimeFromString(CustomerCreationTimeRaw);
            }
            set
            {
                CustomerCreationTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }
        }

        /// <summary>The customer's primary domain name string. Do not include the www prefix when creating a new
        /// customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerDomain")]
        public virtual string CustomerDomain { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>The unique ID for the customer's G Suite account. (Readonly)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>Identifies the resource as a customer. Value: admin#directory#customer</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The customer's ISO 639-2 language code. The default value is en-US</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language { get; set; } 

        /// <summary>The customer's contact phone number in E.164 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; } 

        /// <summary>The customer's postal address information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalAddress")]
        public virtual CustomerPostalAddress PostalAddress { get; set; } 

    }    

    /// <summary>STEPLADDER: Generated unstable field number for field 'address_line2' to avoid collision. (See
    /// http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number for field 'address_line3' to
    /// avoid collision. (See http://go/stepladder-help#fieldNumber)</summary>
    public class CustomerPostalAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A customer's physical address. The address can be composed of one to three lines.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLine1")]
        public virtual string AddressLine1 { get; set; } 

        /// <summary>Address line 2 of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLine2")]
        public virtual string AddressLine2 { get; set; } 

        /// <summary>Address line 3 of the address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressLine3")]
        public virtual string AddressLine3 { get; set; } 

        /// <summary>The customer contact's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contactName")]
        public virtual string ContactName { get; set; } 

        /// <summary>This is a required property. For countryCode information see the ISO 3166 country code
        /// elements.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; } 

        /// <summary>Name of the locality. An example of a locality value is the city of San Francisco.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; } 

        /// <summary>The company or company division name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationName")]
        public virtual string OrganizationName { get; set; } 

        /// <summary>The postal code. A postalCode example is a postal zip code such as 10009. This is in accordance
        /// with - http: //portablecontacts.net/draft-spec.html#address_element.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; } 

        /// <summary>Name of the region. An example of a region value is NY for the state of New York.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class DomainAlias : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The creation time of the domain alias. (Read-only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual System.Nullable<long> CreationTime { get; set; } 

        /// <summary>The domain alias name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainAliasName")]
        public virtual string DomainAliasName { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The parent domain name that the domain alias is associated with. This can either be a primary or
        /// secondary domain name within a customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDomainName")]
        public virtual string ParentDomainName { get; set; } 

        /// <summary>Indicates the verification state of a domain alias. (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verified")]
        public virtual System.Nullable<bool> Verified { get; set; } 

    }    

    public class DomainAliases : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of domain alias objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainAliases")]
        public virtual System.Collections.Generic.IList<DomainAlias> DomainAliasesValue { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

    }    

    public class Domains : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Creation time of the domain. (Read-only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual System.Nullable<long> CreationTime { get; set; } 

        /// <summary>List of domain alias objects. (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainAliases")]
        public virtual System.Collections.Generic.IList<DomainAlias> DomainAliases { get; set; } 

        /// <summary>The domain name of the customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domainName")]
        public virtual string DomainName { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Indicates if the domain is a primary domain (Read-only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPrimary")]
        public virtual System.Nullable<bool> IsPrimary { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Indicates the verification state of a domain. (Read-only).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verified")]
        public virtual System.Nullable<bool> Verified { get; set; } 

    }    

    public class Domains2 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of domain objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<Domains> Domains { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

    }    

    /// <summary>JSON template for Feature object in Directory API.</summary>
    public class Feature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etags")]
        public virtual string Etags { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The name of the feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>JSON template for a feature instance.</summary>
    public class FeatureInstance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The feature that this is an instance of. A calendar resource may have multiple instances of a
        /// feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("feature")]
        public virtual Feature Feature { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class FeatureRename : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>New name of the feature.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newName")]
        public virtual string NewName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Public API: Resources.features</summary>
    public class Features : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>The Features in this page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("features")]
        public virtual System.Collections.Generic.IList<Feature> FeaturesValue { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The continuation token, used to page through large result sets. Provide this value in a subsequent
        /// request to return the next page of results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

    }    

    /// <summary>STEPLADDER: Generated unstable field number for field 'kind'. (See http://go/stepladder-
    /// help#fieldNumber) STEPLADDER: Generated unstable field number for field 'etag'. (See http://go/stepladder-
    /// help#fieldNumber)</summary>
    public class Group : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Is the group created by admin (Read-only) *</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adminCreated")]
        public virtual System.Nullable<bool> AdminCreated { get; set; } 

        /// <summary>List of aliases (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aliases")]
        public virtual System.Collections.Generic.IList<string> Aliases { get; set; } 

        /// <summary>Description of the group</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Group direct members count</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("directMembersCount")]
        public virtual System.Nullable<long> DirectMembersCount { get; set; } 

        /// <summary>Email of Group</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Unique identifier of Group (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Group name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>List of non editable aliases (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonEditableAliases")]
        public virtual System.Collections.Generic.IList<string> NonEditableAliases { get; set; } 

    }    

    /// <summary>STEPLADDER: Generated unstable field number for field 'kind'. (See http://go/stepladder-
    /// help#fieldNumber) STEPLADDER: Generated unstable field number for field 'etag'. (See http://go/stepladder-
    /// help#fieldNumber)</summary>
    public class Groups : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>List of group objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groups")]
        public virtual System.Collections.Generic.IList<Group> GroupsValue { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Token used to access next page of this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

    }    

    public class Member : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Delivery settings of member</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("delivery_settings")]
        public virtual string DeliverySettings { get; set; } 

        /// <summary>Email of member (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Unique identifier of group (Read-only) Unique identifier of member (Read-only) The unique ID of the
        /// group member. A member id can be used as a member request URI's memberKey.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Role of member</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; } 

        /// <summary>Status of member (Immutable)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>Type of member (Immutable)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

    }    

    public class Members : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>List of member objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<Member> MembersValue { get; set; } 

        /// <summary>Token used to access next page of this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

    }    

    /// <summary>JSON template for Has Member response in Directory API.</summary>
    public class MembersHasMember : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Identifies whether the given user is a member of the group. Membership can be direct
        /// or nested.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isMember")]
        public virtual System.Nullable<bool> IsMember { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class MobileDevice : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Adb (USB debugging) enabled or disabled on device (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("adbStatus")]
        public virtual System.Nullable<bool> AdbStatus { get; set; } 

        /// <summary>List of applications installed on Mobile Device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("applications")]
        public virtual System.Collections.Generic.IList<MobileDevice.ApplicationsData> Applications { get; set; } 

        /// <summary>Mobile Device Baseband version (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basebandVersion")]
        public virtual string BasebandVersion { get; set; } 

        /// <summary>Mobile Device Bootloader version (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootloaderVersion")]
        public virtual string BootloaderVersion { get; set; } 

        /// <summary>Mobile Device Brand (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; } 

        /// <summary>Mobile Device Build number (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildNumber")]
        public virtual string BuildNumber { get; set; } 

        /// <summary>The default locale used on the Mobile Device (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLanguage")]
        public virtual string DefaultLanguage { get; set; } 

        /// <summary>Developer options enabled or disabled on device (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("developerOptionsStatus")]
        public virtual System.Nullable<bool> DeveloperOptionsStatus { get; set; } 

        /// <summary>Mobile Device compromised status (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceCompromisedStatus")]
        public virtual string DeviceCompromisedStatus { get; set; } 

        /// <summary>Mobile Device serial number (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; } 

        /// <summary>DevicePasswordStatus (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devicePasswordStatus")]
        public virtual string DevicePasswordStatus { get; set; } 

        /// <summary>List of owner user's email addresses (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual System.Collections.Generic.IList<string> Email { get; set; } 

        /// <summary>Mobile Device Encryption Status (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionStatus")]
        public virtual string EncryptionStatus { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Date and time the device was first synchronized with the policy settings in the G Suite
        /// administrator control panel (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstSync")]
        public virtual string FirstSyncRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="FirstSyncRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnore]
        public virtual System.Nullable<System.DateTime> FirstSync
        {
            get
            {
                return Google.Apis.Util.Utilities.GetDateTimeFromString(FirstSyncRaw);
            }
            set
            {
                FirstSyncRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }
        }

        /// <summary>Mobile Device Hardware (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hardware")]
        public virtual string Hardware { get; set; } 

        /// <summary>Mobile Device Hardware Id (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hardwareId")]
        public virtual string HardwareId { get; set; } 

        /// <summary>Mobile Device IMEI number (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imei")]
        public virtual string Imei { get; set; } 

        /// <summary>Mobile Device Kernel version (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kernelVersion")]
        public virtual string KernelVersion { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Date and time the device was last synchronized with the policy settings in the G Suite
        /// administrator control panel (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSync")]
        public virtual string LastSyncRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="LastSyncRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnore]
        public virtual System.Nullable<System.DateTime> LastSync
        {
            get
            {
                return Google.Apis.Util.Utilities.GetDateTimeFromString(LastSyncRaw);
            }
            set
            {
                LastSyncRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }
        }

        /// <summary>Boolean indicating if this account is on owner/primary profile or not (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managedAccountIsOnOwnerProfile")]
        public virtual System.Nullable<bool> ManagedAccountIsOnOwnerProfile { get; set; } 

        /// <summary>Mobile Device manufacturer (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; } 

        /// <summary>Mobile Device MEID number (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meid")]
        public virtual string Meid { get; set; } 

        /// <summary>Name of the model of the device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; } 

        /// <summary>List of owner user's names (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual System.Collections.Generic.IList<string> Name { get; set; } 

        /// <summary>Mobile Device mobile or network operator (if available) (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkOperator")]
        public virtual string NetworkOperator { get; set; } 

        /// <summary>Name of the mobile operating system</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("os")]
        public virtual string Os { get; set; } 

        /// <summary>List of accounts added on device (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherAccountsInfo")]
        public virtual System.Collections.Generic.IList<string> OtherAccountsInfo { get; set; } 

        /// <summary>DMAgentPermission (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privilege")]
        public virtual string Privilege { get; set; } 

        /// <summary>Mobile Device release version version (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseVersion")]
        public virtual string ReleaseVersion { get; set; } 

        /// <summary>Unique identifier of Mobile Device (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceId")]
        public virtual string ResourceId { get; set; } 

        /// <summary>Mobile Device Security patch level (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityPatchLevel")]
        public virtual System.Nullable<long> SecurityPatchLevel { get; set; } 

        /// <summary>Mobile Device SSN or Serial Number (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; } 

        /// <summary>Status of the device (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; } 

        /// <summary>Work profile supported on device (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsWorkProfile")]
        public virtual System.Nullable<bool> SupportsWorkProfile { get; set; } 

        /// <summary>The type of device (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>Unknown sources enabled or disabled on device (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unknownSourcesStatus")]
        public virtual System.Nullable<bool> UnknownSourcesStatus { get; set; } 

        /// <summary>Mobile Device user agent</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; } 

        /// <summary>Mobile Device WiFi MAC address (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wifiMacAddress")]
        public virtual string WifiMacAddress { get; set; } 

        

        public class ApplicationsData
        {
            /// <summary>Display name of application</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
            public virtual string DisplayName { get; set; } 

            /// <summary>Package name of application</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("packageName")]
            public virtual string PackageName { get; set; } 

            /// <summary>List of Permissions for application</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("permission")]
            public virtual System.Collections.Generic.IList<string> Permission { get; set; } 

            /// <summary>Version code of application</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("versionCode")]
            public virtual System.Nullable<int> VersionCode { get; set; } 

            /// <summary>Version name of application</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("versionName")]
            public virtual string VersionName { get; set; } 

        }
    }    

    public class MobileDeviceAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Action to be taken on the Mobile Device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class MobileDevices : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>List of Mobile Device objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mobiledevices")]
        public virtual System.Collections.Generic.IList<MobileDevice> Mobiledevices { get; set; } 

        /// <summary>Token used to access next page of this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

    }    

    /// <summary>JSON template for Org Unit resource in Directory API. STEPLADDER: Generated unstable field number for
    /// field 'kind'. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number for field
    /// 'etag'. (See http://go/stepladder-help#fieldNumber)</summary>
    public class OrgUnit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Should block inheritance</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blockInheritance")]
        public virtual System.Nullable<bool> BlockInheritance { get; set; } 

        /// <summary>Description of OrgUnit</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Name of OrgUnit</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Id of OrgUnit</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitId")]
        public virtual string OrgUnitId { get; set; } 

        /// <summary>Path of OrgUnit</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitPath")]
        public virtual string OrgUnitPath { get; set; } 

        /// <summary>Id of parent OrgUnit</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentOrgUnitId")]
        public virtual string ParentOrgUnitId { get; set; } 

        /// <summary>Path of parent OrgUnit</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentOrgUnitPath")]
        public virtual string ParentOrgUnitPath { get; set; } 

    }    

    /// <summary>JSON response template for List Organization Units operation in Directory API. STEPLADDER: Generated
    /// unstable field number for field 'kind'. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated
    /// unstable field number for field 'etag'. (See http://go/stepladder-help#fieldNumber)</summary>
    public class OrgUnits : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>List of user objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizationUnits")]
        public virtual System.Collections.Generic.IList<OrgUnit> OrganizationUnits { get; set; } 

    }    

    public class Privilege : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of child privileges. Privileges for a service form a tree. Each privilege can have a list of
        /// child privileges; this list is empty for a leaf privilege.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("childPrivileges")]
        public virtual System.Collections.Generic.IList<Privilege> ChildPrivileges { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>If the privilege can be restricted to an organization unit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isOuScopable")]
        public virtual System.Nullable<bool> IsOuScopable { get; set; } 

        /// <summary>The type of the API resource. This is always admin#directory#privilege.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The name of the privilege.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privilegeName")]
        public virtual string PrivilegeName { get; set; } 

        /// <summary>The obfuscated ID of the service this privilege is for. This value is returned with
        /// Privileges.list().</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceId")]
        public virtual string ServiceId { get; set; } 

        /// <summary>The name of the service this privilege is for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; } 

    }    

    public class Privileges : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>A list of Privilege resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Privilege> Items { get; set; } 

        /// <summary>The type of the API resource. This is always admin#directory#privileges.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

    }    

    public class Role : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Returns true if the role is a super admin role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSuperAdminRole")]
        public virtual System.Nullable<bool> IsSuperAdminRole { get; set; } 

        /// <summary>Returns true if this is a pre-defined system role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSystemRole")]
        public virtual System.Nullable<bool> IsSystemRole { get; set; } 

        /// <summary>The type of the API resource. This is always admin#directory#role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>A short description of the role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleDescription")]
        public virtual string RoleDescription { get; set; } 

        /// <summary>ID of the role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleId")]
        public virtual System.Nullable<long> RoleId { get; set; } 

        /// <summary>Name of the role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleName")]
        public virtual string RoleName { get; set; } 

        /// <summary>The set of privileges that are granted to this role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolePrivileges")]
        public virtual System.Collections.Generic.IList<Role.RolePrivilegesData> RolePrivileges { get; set; } 

        

        public class RolePrivilegesData
        {
            /// <summary>The name of the privilege.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("privilegeName")]
            public virtual string PrivilegeName { get; set; } 

            /// <summary>The obfuscated ID of the service this privilege is for. This value is returned with
            /// Privileges.list().</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("serviceId")]
            public virtual string ServiceId { get; set; } 

        }
    }    

    public class RoleAssignment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique ID of the user this role is assigned to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignedTo")]
        public virtual string AssignedTo { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>The type of the API resource. This is always admin#directory#roleAssignment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>If the role is restricted to an organization unit, this contains the ID for the organization unit
        /// the exercise of this role is restricted to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitId")]
        public virtual string OrgUnitId { get; set; } 

        /// <summary>ID of this roleAssignment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleAssignmentId")]
        public virtual System.Nullable<long> RoleAssignmentId { get; set; } 

        /// <summary>The ID of the role that is assigned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roleId")]
        public virtual System.Nullable<long> RoleId { get; set; } 

        /// <summary>The scope in which this role is assigned. Possible values are: - CUSTOMER - ORG_UNIT </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopeType")]
        public virtual string ScopeType { get; set; } 

    }    

    public class RoleAssignments : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>A list of RoleAssignment resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<RoleAssignment> Items { get; set; } 

        /// <summary>The type of the API resource. This is always admin#directory#roleAssignments .</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

    }    

    public class Roles : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>A list of Role resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Role> Items { get; set; } 

        /// <summary>The type of the API resource. This is always admin#directory#roles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

    }    

    /// <summary>JSON template for Schema resource in Directory API. STEPLADDER: Generated unstable field number for
    /// field 'kind'. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number for field
    /// 'etag'. (See http://go/stepladder-help#fieldNumber)</summary>
    public class Schema : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display name for the schema.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Fields of Schema</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fields")]
        public virtual System.Collections.Generic.IList<SchemaFieldSpec> Fields { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Unique identifier of Schema (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaId")]
        public virtual string SchemaId { get; set; } 

        /// <summary>Schema name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemaName")]
        public virtual string SchemaName { get; set; } 

    }    

    /// <summary>JSON template for FieldSpec resource for Schemas in Directory API. STEPLADDER: Generated unstable field
    /// number for field 'kind'. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number
    /// for field 'etag'. (See http://go/stepladder-help#fieldNumber)</summary>
    public class SchemaFieldSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display Name of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Unique identifier of Field (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldId")]
        public virtual string FieldId { get; set; } 

        /// <summary>Name of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldName")]
        public virtual string FieldName { get; set; } 

        /// <summary>Type of the field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fieldType")]
        public virtual string FieldType { get; set; } 

        /// <summary>Boolean specifying whether the field is indexed or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexed")]
        public virtual System.Nullable<bool> Indexed { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Boolean specifying whether this is a multi-valued field or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("multiValued")]
        public virtual System.Nullable<bool> MultiValued { get; set; } 

        /// <summary>Indexing spec for a numeric field. By default, only exact match queries will be supported for
        /// numeric fields. Setting the numericIndexingSpec allows range queries to be supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numericIndexingSpec")]
        public virtual SchemaFieldSpec.NumericIndexingSpecData NumericIndexingSpec { get; set; } 

        /// <summary>Read ACLs on the field specifying who can view values of this field. Valid values are
        /// "ALL_DOMAIN_USERS" and "ADMINS_AND_SELF".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readAccessType")]
        public virtual string ReadAccessType { get; set; } 

        

        /// <summary>Indexing spec for a numeric field. By default, only exact match queries will be supported for
        /// numeric fields. Setting the numericIndexingSpec allows range queries to be supported.</summary>
        public class NumericIndexingSpecData
        {
            /// <summary>Maximum value of this field. This is meant to be indicative rather than enforced. Values
            /// outside this range will still be indexed, but search may not be as performant.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("maxValue")]
            public virtual System.Nullable<double> MaxValue { get; set; } 

            /// <summary>Minimum value of this field. This is meant to be indicative rather than enforced. Values
            /// outside this range will still be indexed, but search may not be as performant.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("minValue")]
            public virtual System.Nullable<double> MinValue { get; set; } 

        }
    }    

    /// <summary>JSON response template for List Schema operation in Directory API. STEPLADDER: Generated unstable field
    /// number for field 'kind'. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number
    /// for field 'etag'. (See http://go/stepladder-help#fieldNumber)</summary>
    public class Schemas : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>List of UserSchema objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("schemas")]
        public virtual System.Collections.Generic.IList<Schema> SchemasValue { get; set; } 

    }    

    /// <summary>JSON template for token resource in Directory API. STEPLADDER: Generated unstable field number for
    /// field 'kind'. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number for field
    /// 'etag'. (See http://go/stepladder-help#fieldNumber)</summary>
    public class Token : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether the application is registered with Google. The value is true if the application has an
        /// anonymous Client ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("anonymous")]
        public virtual System.Nullable<bool> Anonymous { get; set; } 

        /// <summary>The Client ID of the application the token is issued to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("clientId")]
        public virtual string ClientId { get; set; } 

        /// <summary>The displayable name of the application the token is issued to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayText")]
        public virtual string DisplayText { get; set; } 

        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>The type of the API resource. This is always admin#directory#token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Whether the token is issued to an installed application. The value is true if the application is
        /// installed to a desktop or mobile device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nativeApp")]
        public virtual System.Nullable<bool> NativeApp { get; set; } 

        /// <summary>A list of authorization scopes the application is granted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scopes")]
        public virtual System.Collections.Generic.IList<string> Scopes { get; set; } 

        /// <summary>The unique ID of the user that issued the token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userKey")]
        public virtual string UserKey { get; set; } 

    }    

    /// <summary>JSON response template for List tokens operation in Directory API. STEPLADDER: Generated unstable field
    /// number for field 'kind'. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number
    /// for field 'etag'. (See http://go/stepladder-help#fieldNumber)</summary>
    public class Tokens : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>A list of Token resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<Token> Items { get; set; } 

        /// <summary>The type of the API resource. This is always admin#directory#tokenList.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

    }    

    /// <summary>STEPLADDER: Generated unstable field number for field 'kind'. (See http://go/stepladder-
    /// help#fieldNumber) STEPLADDER: Generated unstable field number for field 'etag'. (See http://go/stepladder-
    /// help#fieldNumber) STEPLADDER: Generated unstable field number for field 'external_ids' to avoid collision. (See
    /// http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number for field 'relations' to
    /// avoid collision. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number for
    /// field 'addresses' to avoid collision. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable
    /// field number for field 'organizations' to avoid collision. (See http://go/stepladder-help#fieldNumber)
    /// STEPLADDER: Generated unstable field number for field 'phones' to avoid collision. (See http://go/stepladder-
    /// help#fieldNumber) STEPLADDER: Generated unstable field number for field 'languages' to avoid collision. (See
    /// http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number for field 'posix_accounts' to
    /// avoid collision. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number for
    /// field 'ssh_public_keys' to avoid collision. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated
    /// unstable field number for field 'notes' to avoid collision. (See http://go/stepladder-help#fieldNumber)
    /// STEPLADDER: Generated unstable field number for field 'websites' to avoid collision. (See http://go/stepladder-
    /// help#fieldNumber) STEPLADDER: Generated unstable field number for field 'locations' to avoid collision. (See
    /// http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number for field 'keywords' to avoid
    /// collision. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number for field
    /// 'gender' to avoid collision. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field
    /// number for field 'thumbnail_photo_etag' to avoid collision. (See http://go/stepladder-
    /// help#fieldNumber)</summary>
    public class User : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Addresses of User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addresses")]
        public virtual System.Collections.Generic.IList<UserAddress> Addresses { get; set; } 

        /// <summary>Output only. Indicates if user has agreed to terms (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agreedToTerms")]
        public virtual System.Nullable<bool> AgreedToTerms { get; set; } 

        /// <summary>Output only. List of aliases (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aliases")]
        public virtual System.Collections.Generic.IList<string> Aliases { get; set; } 

        /// <summary>Indicates if user is archived.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("archived")]
        public virtual System.Nullable<bool> Archived { get; set; } 

        /// <summary>Boolean indicating if the user should change password in next login</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("changePasswordAtNextLogin")]
        public virtual System.Nullable<bool> ChangePasswordAtNextLogin { get; set; } 

        /// <summary>User's G Suite account creation time. (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("creationTime")]
        public virtual string CreationTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="CreationTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnore]
        public virtual System.Nullable<System.DateTime> CreationTime
        {
            get
            {
                return Google.Apis.Util.Utilities.GetDateTimeFromString(CreationTimeRaw);
            }
            set
            {
                CreationTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }
        }

        /// <summary>Custom fields of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customSchemas")]
        public virtual System.Collections.Generic.IDictionary<string,UserCustomProperties> CustomSchemas { get; set; } 

        /// <summary>Output only. CustomerId of User (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
        public virtual string CustomerId { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("deletionTime")]
        public virtual string DeletionTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="DeletionTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnore]
        public virtual System.Nullable<System.DateTime> DeletionTime
        {
            get
            {
                return Google.Apis.Util.Utilities.GetDateTimeFromString(DeletionTimeRaw);
            }
            set
            {
                DeletionTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }
        }

        /// <summary>Emails of User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("emails")]
        public virtual System.Collections.Generic.IList<UserEmail> Emails { get; set; } 

        /// <summary>Output only. ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>The external Ids of User *</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalIds")]
        public virtual System.Collections.Generic.IList<UserExternalId> ExternalIds { get; set; } 

        /// <summary>Gender of User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gender")]
        public virtual object Gender { get; set; } 

        /// <summary>Hash function name for password. Supported are MD5, SHA-1 and crypt</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashFunction")]
        public virtual string HashFunction { get; set; } 

        /// <summary>Unique identifier of User (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>User's Instant Messenger</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ims")]
        public virtual System.Collections.Generic.IList<UserIm> Ims { get; set; } 

        /// <summary>Boolean indicating if user is included in Global Address List</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("includeInGlobalAddressList")]
        public virtual System.Nullable<bool> IncludeInGlobalAddressList { get; set; } 

        /// <summary>Boolean indicating if ip is whitelisted</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipWhitelisted")]
        public virtual System.Nullable<bool> IpWhitelisted { get; set; } 

        /// <summary>Output only. Boolean indicating if the user is admin (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isAdmin")]
        public virtual System.Nullable<bool> IsAdmin { get; set; } 

        /// <summary>Output only. Boolean indicating if the user is delegated admin (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isDelegatedAdmin")]
        public virtual System.Nullable<bool> IsDelegatedAdmin { get; set; } 

        /// <summary>Output only. Is 2-step verification enforced (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isEnforcedIn2Sv")]
        public virtual System.Nullable<bool> IsEnforcedIn2Sv { get; set; } 

        /// <summary>Output only. Is enrolled in 2-step verification (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isEnrolledIn2Sv")]
        public virtual System.Nullable<bool> IsEnrolledIn2Sv { get; set; } 

        /// <summary>Output only. Is mailbox setup (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isMailboxSetup")]
        public virtual System.Nullable<bool> IsMailboxSetup { get; set; } 

        /// <summary>Keywords of User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keywords")]
        public virtual object Keywords { get; set; } 

        /// <summary>Output only. Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Languages of User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languages")]
        public virtual object Languages { get; set; } 

        /// <summary>User's last login time. (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastLoginTime")]
        public virtual string LastLoginTimeRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="LastLoginTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnore]
        public virtual System.Nullable<System.DateTime> LastLoginTime
        {
            get
            {
                return Google.Apis.Util.Utilities.GetDateTimeFromString(LastLoginTimeRaw);
            }
            set
            {
                LastLoginTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }
        }

        /// <summary>Locations of User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual object Locations { get; set; } 

        /// <summary>User's name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual UserName Name { get; set; } 

        /// <summary>Output only. List of non editable aliases (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonEditableAliases")]
        public virtual System.Collections.Generic.IList<string> NonEditableAliases { get; set; } 

        /// <summary>Notes of User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notes")]
        public virtual object Notes { get; set; } 

        /// <summary>OrgUnit of User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitPath")]
        public virtual string OrgUnitPath { get; set; } 

        /// <summary>Organizations of User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("organizations")]
        public virtual System.Collections.Generic.IList<UserOrganization> Organizations { get; set; } 

        /// <summary>User's password</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; } 

        /// <summary>Phone numbers of User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phones")]
        public virtual System.Collections.Generic.IList<UserPhone> Phones { get; set; } 

        /// <summary>The POSIX accounts of User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("posixAccounts")]
        public virtual object PosixAccounts { get; set; } 

        /// <summary>username of User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryEmail")]
        public virtual string PrimaryEmail { get; set; } 

        /// <summary>Recovery email of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recoveryEmail")]
        public virtual string RecoveryEmail { get; set; } 

        /// <summary>Recovery phone of the user. The phone number must be in the E.164 format, starting with the plus
        /// sign (+). Example: *+16506661212*.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recoveryPhone")]
        public virtual string RecoveryPhone { get; set; } 

        /// <summary>The Relations of User *</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("relations")]
        public virtual System.Collections.Generic.IList<UserRelation> Relations { get; set; } 

        /// <summary>The SSH public keys of User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sshPublicKeys")]
        public virtual object SshPublicKeys { get; set; } 

        /// <summary>Indicates if user is suspended.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspended")]
        public virtual System.Nullable<bool> Suspended { get; set; } 

        /// <summary>Output only. Suspension reason if user is suspended (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suspensionReason")]
        public virtual string SuspensionReason { get; set; } 

        /// <summary>Output only. ETag of the user's photo (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailPhotoEtag")]
        public virtual string ThumbnailPhotoEtag { get; set; } 

        /// <summary>Output only. Photo Url of the user (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailPhotoUrl")]
        public virtual string ThumbnailPhotoUrl { get; set; } 

        /// <summary>Websites of User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("websites")]
        public virtual System.Collections.Generic.IList<UserWebsite> Websites { get; set; } 

    }    

    /// <summary>JSON template for About (notes) of a user in Directory API.</summary>
    public class UserAbout : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>About entry can have a type which indicates the content type. It can either be plain or html. By
        /// default, notes contents are assumed to contain plain text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentType")]
        public virtual string ContentType { get; set; } 

        /// <summary>Actual value of notes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>JSON template for address.</summary>
    public class UserAddress : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Country.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("country")]
        public virtual string Country { get; set; } 

        /// <summary>Country code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("countryCode")]
        public virtual string CountryCode { get; set; } 

        /// <summary>Custom type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; } 

        /// <summary>Extended Address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("extendedAddress")]
        public virtual string ExtendedAddress { get; set; } 

        /// <summary>Formatted address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formatted")]
        public virtual string Formatted { get; set; } 

        /// <summary>Locality.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locality")]
        public virtual string Locality { get; set; } 

        /// <summary>Other parts of address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("poBox")]
        public virtual string PoBox { get; set; } 

        /// <summary>Postal code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postalCode")]
        public virtual string PostalCode { get; set; } 

        /// <summary>If this is user's primary address. Only one entry could be marked as primary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; } 

        /// <summary>Region.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("region")]
        public virtual string Region { get; set; } 

        /// <summary>User supplied address was structured. Structured addresses are NOT supported at this time. You
        /// might be able to write structured addresses but any values will eventually be clobbered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceIsStructured")]
        public virtual System.Nullable<bool> SourceIsStructured { get; set; } 

        /// <summary>Street.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streetAddress")]
        public virtual string StreetAddress { get; set; } 

        /// <summary>Each entry can have a type which indicates standard values of that entry. For example address could
        /// be of home work etc. In addition to the standard type an entry can have a custom type and can take any
        /// value. Such type should have the CUSTOM value as type and also have a customType value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>JSON template for a set of custom properties (i.e. all fields in a particular schema)</summary>
    public class UserCustomProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>JSON template for an email.</summary>
    public class UserEmail : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Email id of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("address")]
        public virtual string Address { get; set; } 

        /// <summary>Custom Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; } 

        /// <summary>If this is user's primary email. Only one entry could be marked as primary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; } 

        /// <summary>Each entry can have a type which indicates standard types of that entry. For example email could be
        /// of home, work etc. In addition to the standard type, an entry can have a custom type and can take any value
        /// Such types should have the CUSTOM value as type and also have a customType value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>JSON template for an externalId entry.</summary>
    public class UserExternalId : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; } 

        /// <summary>The type of the Id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The value of the id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class UserGender : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>AddressMeAs. A human-readable string containing the proper way to refer to the profile owner by
        /// humans for example he/him/his or they/them/their.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("addressMeAs")]
        public virtual string AddressMeAs { get; set; } 

        /// <summary>Custom gender.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customGender")]
        public virtual string CustomGender { get; set; } 

        /// <summary>Gender.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>JSON template for instant messenger of an user.</summary>
    public class UserIm : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom protocol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customProtocol")]
        public virtual string CustomProtocol { get; set; } 

        /// <summary>Custom type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; } 

        /// <summary>Instant messenger id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("im")]
        public virtual string Im { get; set; } 

        /// <summary>If this is user's primary im. Only one entry could be marked as primary.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; } 

        /// <summary>Protocol used in the instant messenger. It should be one of the values from ImProtocolTypes map.
        /// Similar to type it can take a CUSTOM value and specify the custom name in customProtocol field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; } 

        /// <summary>Each entry can have a type which indicates standard types of that entry. For example instant
        /// messengers could be of home work etc. In addition to the standard type an entry can have a custom type and
        /// can take any value. Such types should have the CUSTOM value as type and also have a customType
        /// value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>JSON template for a keyword entry.</summary>
    public class UserKeyword : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; } 

        /// <summary>Each entry can have a type which indicates standard type of that entry. For example keyword could
        /// be of type occupation or outlook. In addition to the standard type an entry can have a custom type and can
        /// give it any name. Such types should have the CUSTOM value as type and also have a customType
        /// value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>Keyword.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>JSON template for a language entry.</summary>
    public class UserLanguage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Other language. User can provide own language name if there is no corresponding Google III language
        /// code. If this is set LanguageCode can't be set</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customLanguage")]
        public virtual string CustomLanguage { get; set; } 

        /// <summary>Language Code. Should be used for storing Google III LanguageCode string representation for
        /// language. Illegal values cause SchemaException.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>JSON template for a location entry.</summary>
    public class UserLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Textual location. This is most useful for display purposes to concisely describe the location. For
        /// example 'Mountain View, CA', 'Near Seattle', 'US-NYC-9TH 9A209A.''</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("area")]
        public virtual string Area { get; set; } 

        /// <summary>Building Identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildingId")]
        public virtual string BuildingId { get; set; } 

        /// <summary>Custom Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; } 

        /// <summary>Most specific textual code of individual desk location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deskCode")]
        public virtual string DeskCode { get; set; } 

        /// <summary>Floor name/number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floorName")]
        public virtual string FloorName { get; set; } 

        /// <summary>Floor section. More specific location within the floor. For example if a floor is divided into
        /// sections 'A', 'B' and 'C' this field would identify one of those values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("floorSection")]
        public virtual string FloorSection { get; set; } 

        /// <summary>Each entry can have a type which indicates standard types of that entry. For example location could
        /// be of types default and desk. In addition to standard type an entry can have a custom type and can give it
        /// any name. Such types should have 'custom' as type and also have a customType value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class UserMakeAdmin : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Boolean indicating new admin status of the user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual System.Nullable<bool> Status { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class UserName : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Last Name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("familyName")]
        public virtual string FamilyName { get; set; } 

        /// <summary>Full Name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullName")]
        public virtual string FullName { get; set; } 

        /// <summary>First Name</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("givenName")]
        public virtual string GivenName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>JSON template for an organization entry.</summary>
    public class UserOrganization : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The cost center of the users department.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("costCenter")]
        public virtual string CostCenter { get; set; } 

        /// <summary>Custom type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; } 

        /// <summary>Department within the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("department")]
        public virtual string Department { get; set; } 

        /// <summary>Description of the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>The domain to which the organization belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domain")]
        public virtual string Domain { get; set; } 

        /// <summary>The full-time equivalent millipercent within the organization (100000 = 100%).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullTimeEquivalent")]
        public virtual System.Nullable<int> FullTimeEquivalent { get; set; } 

        /// <summary>Location of the organization. This need not be fully qualified address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; } 

        /// <summary>Name of the organization</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>If it user's primary organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; } 

        /// <summary>Symbol of the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("symbol")]
        public virtual string Symbol { get; set; } 

        /// <summary>Title (designation) of the user in the organization.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>Each entry can have a type which indicates standard types of that entry. For example organization
        /// could be of school work etc. In addition to the standard type an entry can have a custom type and can give
        /// it any name. Such types should have the CUSTOM value as type and also have a CustomType value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>JSON template for a phone entry.</summary>
    public class UserPhone : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; } 

        /// <summary>If this is user's primary phone or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; } 

        /// <summary>Each entry can have a type which indicates standard types of that entry. For example phone could be
        /// of home_fax work mobile etc. In addition to the standard type an entry can have a custom type and can give
        /// it any name. Such types should have the CUSTOM value as type and also have a customType value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>Phone number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>STEPLADDER: Generated unstable field number for field 'kind'. (See http://go/stepladder-
    /// help#fieldNumber) STEPLADDER: Generated unstable field number for field 'etag'. (See http://go/stepladder-
    /// help#fieldNumber)</summary>
    public class UserPhoto : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Height in pixels of the photo</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual System.Nullable<int> Height { get; set; } 

        /// <summary>Unique identifier of User (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Mime Type of the photo</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mimeType")]
        public virtual string MimeType { get; set; } 

        /// <summary>Base64 encoded photo data</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("photoData")]
        public virtual string PhotoData { get; set; } 

        /// <summary>Primary email of User (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryEmail")]
        public virtual string PrimaryEmail { get; set; } 

        /// <summary>Width in pixels of the photo</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("width")]
        public virtual System.Nullable<int> Width { get; set; } 

    }    

    /// <summary>JSON template for a POSIX account entry. Description of the field family: go/fbs-posix.</summary>
    public class UserPosixAccount : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A POSIX account field identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accountId")]
        public virtual string AccountId { get; set; } 

        /// <summary>The GECOS (user information) for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gecos")]
        public virtual string Gecos { get; set; } 

        /// <summary>The default group ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gid")]
        public virtual System.Nullable<ulong> Gid { get; set; } 

        /// <summary>The path to the home directory for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("homeDirectory")]
        public virtual string HomeDirectory { get; set; } 

        /// <summary>The operating system type for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operatingSystemType")]
        public virtual string OperatingSystemType { get; set; } 

        /// <summary>If this is user's primary account within the SystemId.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; } 

        /// <summary>The path to the login shell for this account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shell")]
        public virtual string Shell { get; set; } 

        /// <summary>System identifier for which account Username or Uid apply to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("systemId")]
        public virtual string SystemId { get; set; } 

        /// <summary>The POSIX compliant user ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uid")]
        public virtual System.Nullable<ulong> Uid { get; set; } 

        /// <summary>The username of the account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>JSON template for a relation entry.</summary>
    public class UserRelation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; } 

        /// <summary>The relation of the user. Some of the possible values are mother father sister brother manager
        /// assistant partner.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The name of the relation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>JSON template for a POSIX account entry.</summary>
    public class UserSshPublicKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An expiration time in microseconds since epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTimeUsec")]
        public virtual System.Nullable<long> ExpirationTimeUsec { get; set; } 

        /// <summary>A SHA-256 fingerprint of the SSH public key. (Read-only)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fingerprint")]
        public virtual string Fingerprint { get; set; } 

        /// <summary>An SSH public key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class UserUndelete : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OrgUnit of User</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgUnitPath")]
        public virtual string OrgUnitPath { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>JSON template for a website entry.</summary>
    public class UserWebsite : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom Type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customType")]
        public virtual string CustomType { get; set; } 

        /// <summary>If this is user's primary website or not.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primary")]
        public virtual System.Nullable<bool> Primary { get; set; } 

        /// <summary>Each entry can have a type which indicates standard types of that entry. For example website could
        /// be of home work blog etc. In addition to the standard type an entry can have a custom type and can give it
        /// any name. Such types should have the CUSTOM value as type and also have a customType value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>Website.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>STEPLADDER: Generated unstable field number for field 'kind'. (See http://go/stepladder-
    /// help#fieldNumber) STEPLADDER: Generated unstable field number for field 'etag'. (See http://go/stepladder-
    /// help#fieldNumber)</summary>
    public class Users : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Token used to access next page of this result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>Event that triggered this response (only used in case of Push Response)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trigger_event")]
        public virtual string TriggerEvent { get; set; } 

        /// <summary>List of user objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("users")]
        public virtual System.Collections.Generic.IList<User> UsersValue { get; set; } 

    }    

    /// <summary>JSON template for verification codes in Directory API. STEPLADDER: Generated unstable field number for
    /// field 'kind'. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated unstable field number for field
    /// 'etag'. (See http://go/stepladder-help#fieldNumber)</summary>
    public class VerificationCode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>The type of the resource. This is always admin#directory#verificationCode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The obfuscated unique ID of the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userId")]
        public virtual string UserId { get; set; } 

        /// <summary>A current verification code for the user. Invalidated or used verification codes are not returned
        /// as part of the result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verificationCode")]
        public virtual string VerificationCodeValue { get; set; } 

    }    

    /// <summary>JSON response template for List verification codes operation in Directory API. STEPLADDER: Generated
    /// unstable field number for field 'kind'. (See http://go/stepladder-help#fieldNumber) STEPLADDER: Generated
    /// unstable field number for field 'etag'. (See http://go/stepladder-help#fieldNumber)</summary>
    public class VerificationCodes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>ETag of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>A list of verification code resources.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<VerificationCode> Items { get; set; } 

        /// <summary>The type of the resource. This is always admin#directory#verificationCodesList.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

    }
}
