// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.AccessContextManager.v1
{
    /// <summary>The AccessContextManager Service.</summary>
    public class AccessContextManagerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public AccessContextManagerService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public AccessContextManagerService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            AccessPolicies = new AccessPoliciesResource(this);
            Operations = new OperationsResource(this);
            Organizations = new OrganizationsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "accesscontextmanager";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://accesscontextmanager.googleapis.com/";
        #else
            "https://accesscontextmanager.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://accesscontextmanager.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Access Context Manager API.</summary>
        public class Scope
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Access Context Manager API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, edit, configure, and delete your Google Cloud Platform data</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the AccessPolicies resource.</summary>
        public virtual AccessPoliciesResource AccessPolicies { get; }

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }
    }

    /// <summary>A base abstract class for AccessContextManager requests.</summary>
    public abstract class AccessContextManagerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new AccessContextManagerBaseServiceRequest instance.</summary>
        protected AccessContextManagerBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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
            Value1 = 0,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2 = 1,
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
            Json = 0,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media = 1,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto = 2,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>
        /// API key. Your API key identifies your project and provides you with API access, quota, and reports. Required
        /// unless you provide an OAuth 2.0 token.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>
        /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a
        /// user, but should not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes AccessContextManager parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "accessPolicies" collection of methods.</summary>
    public class AccessPoliciesResource
    {
        private const string Resource = "accessPolicies";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public AccessPoliciesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            AccessLevels = new AccessLevelsResource(service);
            ServicePerimeters = new ServicePerimetersResource(service);
        }

        /// <summary>Gets the AccessLevels resource.</summary>
        public virtual AccessLevelsResource AccessLevels { get; }

        /// <summary>The "accessLevels" collection of methods.</summary>
        public class AccessLevelsResource
        {
            private const string Resource = "accessLevels";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AccessLevelsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Create an Access Level. The longrunning operation from this RPC will have a successful status once the
            /// Access Level has propagated to long-lasting storage. Access Levels containing errors will result in an
            /// error response for the first error encountered.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name for the access policy which owns this Access Level. Format:
            /// `accessPolicies/{policy_id}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.AccessContextManager.v1.Data.AccessLevel body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Create an Access Level. The longrunning operation from this RPC will have a successful status once the
            /// Access Level has propagated to long-lasting storage. Access Levels containing errors will result in an
            /// error response for the first error encountered.
            /// </summary>
            public class CreateRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.AccessLevel body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the access policy which owns this Access Level. Format:
                /// `accessPolicies/{policy_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.AccessLevel Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/accessLevels";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accessPolicies/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Delete an Access Level by resource name. The longrunning operation from this RPC will have a successful
            /// status once the Access Level has been removed from long-lasting storage.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name for the Access Level. Format:
            /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Delete an Access Level by resource name. The longrunning operation from this RPC will have a successful
            /// status once the Access Level has been removed from long-lasting storage.
            /// </summary>
            public class DeleteRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the Access Level. Format:
                /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accessPolicies/[^/]+/accessLevels/[^/]+$",
                    });
                }
            }

            /// <summary>Get an Access Level by resource name.</summary>
            /// <param name="name">
            /// Required. Resource name for the Access Level. Format:
            /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Get an Access Level by resource name.</summary>
            public class GetRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.AccessLevel>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the Access Level. Format:
                /// `accessPolicies/{policy_id}/accessLevels/{access_level_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Whether to return `BasicLevels` in the Cloud Common Expression Language rather than as
                /// `BasicLevels`. Defaults to AS_DEFINED, where Access Levels are returned as `BasicLevels` or
                /// `CustomLevels` based on how they were created. If set to CEL, all Access Levels are returned as
                /// `CustomLevels`. In the CEL case, `BasicLevels` are translated to equivalent `CustomLevels`.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("accessLevelFormat", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AccessLevelFormatEnum> AccessLevelFormat { get; set; }

                /// <summary>
                /// Whether to return `BasicLevels` in the Cloud Common Expression Language rather than as
                /// `BasicLevels`. Defaults to AS_DEFINED, where Access Levels are returned as `BasicLevels` or
                /// `CustomLevels` based on how they were created. If set to CEL, all Access Levels are returned as
                /// `CustomLevels`. In the CEL case, `BasicLevels` are translated to equivalent `CustomLevels`.
                /// </summary>
                public enum AccessLevelFormatEnum
                {
                    /// <summary>The format was not specified.</summary>
                    [Google.Apis.Util.StringValueAttribute("LEVEL_FORMAT_UNSPECIFIED")]
                    LEVELFORMATUNSPECIFIED = 0,

                    /// <summary>
                    /// Uses the format the resource was defined in. BasicLevels are returned as BasicLevels,
                    /// CustomLevels are returned as CustomLevels.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AS_DEFINED")]
                    ASDEFINED = 1,

                    /// <summary>
                    /// Use Cloud Common Expression Language when returning the resource. Both BasicLevels and
                    /// CustomLevels are returned as CustomLevels.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("CEL")]
                    CEL = 2,
                }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accessPolicies/[^/]+/accessLevels/[^/]+$",
                    });
                    RequestParameters.Add("accessLevelFormat", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accessLevelFormat",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>List all Access Levels for an access policy.</summary>
            /// <param name="parent">
            /// Required. Resource name for the access policy to list Access Levels from. Format:
            /// `accessPolicies/{policy_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>List all Access Levels for an access policy.</summary>
            public class ListRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.ListAccessLevelsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the access policy to list Access Levels from. Format:
                /// `accessPolicies/{policy_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Whether to return `BasicLevels` in the Cloud Common Expression language, as `CustomLevels`, rather
                /// than as `BasicLevels`. Defaults to returning `AccessLevels` in the format they were defined.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("accessLevelFormat", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<AccessLevelFormatEnum> AccessLevelFormat { get; set; }

                /// <summary>
                /// Whether to return `BasicLevels` in the Cloud Common Expression language, as `CustomLevels`, rather
                /// than as `BasicLevels`. Defaults to returning `AccessLevels` in the format they were defined.
                /// </summary>
                public enum AccessLevelFormatEnum
                {
                    /// <summary>The format was not specified.</summary>
                    [Google.Apis.Util.StringValueAttribute("LEVEL_FORMAT_UNSPECIFIED")]
                    LEVELFORMATUNSPECIFIED = 0,

                    /// <summary>
                    /// Uses the format the resource was defined in. BasicLevels are returned as BasicLevels,
                    /// CustomLevels are returned as CustomLevels.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("AS_DEFINED")]
                    ASDEFINED = 1,

                    /// <summary>
                    /// Use Cloud Common Expression Language when returning the resource. Both BasicLevels and
                    /// CustomLevels are returned as CustomLevels.
                    /// </summary>
                    [Google.Apis.Util.StringValueAttribute("CEL")]
                    CEL = 2,
                }

                /// <summary>Number of Access Levels to include in the list. Default 100.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Next page token for the next batch of Access Level instances. Defaults to the first page of results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/accessLevels";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accessPolicies/[^/]+$",
                    });
                    RequestParameters.Add("accessLevelFormat", new Google.Apis.Discovery.Parameter
                    {
                        Name = "accessLevelFormat",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Update an Access Level. The longrunning operation from this RPC will have a successful status once the
            /// changes to the Access Level have propagated to long-lasting storage. Access Levels containing errors
            /// will result in an error response for the first error encountered.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Resource name for the Access Level. The `short_name` component must begin with a letter and
            /// only include alphanumeric and '_'. Format: `accessPolicies/{policy_id}/accessLevels/{short_name}`. The
            /// maximum length of the `short_name` component is 50 characters.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AccessContextManager.v1.Data.AccessLevel body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Update an Access Level. The longrunning operation from this RPC will have a successful status once the
            /// changes to the Access Level have propagated to long-lasting storage. Access Levels containing errors
            /// will result in an error response for the first error encountered.
            /// </summary>
            public class PatchRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.AccessLevel body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the Access Level. The `short_name` component must begin with a letter
                /// and only include alphanumeric and '_'. Format:
                /// `accessPolicies/{policy_id}/accessLevels/{short_name}`. The maximum length of the `short_name`
                /// component is 50 characters.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Required. Mask to control which fields get updated. Must be non-empty.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.AccessLevel Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accessPolicies/[^/]+/accessLevels/[^/]+$",
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Replace all existing Access Levels in an Access Policy with the Access Levels provided. This is done
            /// atomically. The longrunning operation from this RPC will have a successful status once all replacements
            /// have propagated to long-lasting storage. Replacements containing errors will result in an error response
            /// for the first error encountered. Replacement will be cancelled on error, existing Access Levels will not
            /// be affected. Operation.response field will contain ReplaceAccessLevelsResponse. Removing Access Levels
            /// contained in existing Service Perimeters will result in error.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name for the access policy which owns these Access Levels. Format:
            /// `accessPolicies/{policy_id}`
            /// </param>
            public virtual ReplaceAllRequest ReplaceAll(Google.Apis.AccessContextManager.v1.Data.ReplaceAccessLevelsRequest body, string parent)
            {
                return new ReplaceAllRequest(service, body, parent);
            }

            /// <summary>
            /// Replace all existing Access Levels in an Access Policy with the Access Levels provided. This is done
            /// atomically. The longrunning operation from this RPC will have a successful status once all replacements
            /// have propagated to long-lasting storage. Replacements containing errors will result in an error response
            /// for the first error encountered. Replacement will be cancelled on error, existing Access Levels will not
            /// be affected. Operation.response field will contain ReplaceAccessLevelsResponse. Removing Access Levels
            /// contained in existing Service Perimeters will result in error.
            /// </summary>
            public class ReplaceAllRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new ReplaceAll request.</summary>
                public ReplaceAllRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.ReplaceAccessLevelsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the access policy which owns these Access Levels. Format:
                /// `accessPolicies/{policy_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.ReplaceAccessLevelsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "replaceAll";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/accessLevels:replaceAll";

                /// <summary>Initializes ReplaceAll parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accessPolicies/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the ServicePerimeters resource.</summary>
        public virtual ServicePerimetersResource ServicePerimeters { get; }

        /// <summary>The "servicePerimeters" collection of methods.</summary>
        public class ServicePerimetersResource
        {
            private const string Resource = "servicePerimeters";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ServicePerimetersResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Commit the dry-run spec for all the Service Perimeters in an Access Policy. A commit operation on a
            /// Service Perimeter involves copying its `spec` field to that Service Perimeter's `status` field. Only
            /// Service Perimeters with `use_explicit_dry_run_spec` field set to true are affected by a commit
            /// operation. The longrunning operation from this RPC will have a successful status once the dry-run specs
            /// for all the Service Perimeters have been committed. If a commit fails, it will cause the longrunning
            /// operation to return an error response and the entire commit operation will be cancelled. When
            /// successful, Operation.response field will contain CommitServicePerimetersResponse. The `dry_run` and the
            /// `spec` fields will be cleared after a successful commit operation.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name for the parent Access Policy which owns all Service Perimeters in scope for the
            /// commit operation. Format: `accessPolicies/{policy_id}`
            /// </param>
            public virtual CommitRequest Commit(Google.Apis.AccessContextManager.v1.Data.CommitServicePerimetersRequest body, string parent)
            {
                return new CommitRequest(service, body, parent);
            }

            /// <summary>
            /// Commit the dry-run spec for all the Service Perimeters in an Access Policy. A commit operation on a
            /// Service Perimeter involves copying its `spec` field to that Service Perimeter's `status` field. Only
            /// Service Perimeters with `use_explicit_dry_run_spec` field set to true are affected by a commit
            /// operation. The longrunning operation from this RPC will have a successful status once the dry-run specs
            /// for all the Service Perimeters have been committed. If a commit fails, it will cause the longrunning
            /// operation to return an error response and the entire commit operation will be cancelled. When
            /// successful, Operation.response field will contain CommitServicePerimetersResponse. The `dry_run` and the
            /// `spec` fields will be cleared after a successful commit operation.
            /// </summary>
            public class CommitRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Commit request.</summary>
                public CommitRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.CommitServicePerimetersRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the parent Access Policy which owns all Service Perimeters in scope for
                /// the commit operation. Format: `accessPolicies/{policy_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.CommitServicePerimetersRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "commit";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/servicePerimeters:commit";

                /// <summary>Initializes Commit parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accessPolicies/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Create a Service Perimeter. The longrunning operation from this RPC will have a successful status once
            /// the Service Perimeter has propagated to long-lasting storage. Service Perimeters containing errors will
            /// result in an error response for the first error encountered.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name for the access policy which owns this Service Perimeter. Format:
            /// `accessPolicies/{policy_id}`
            /// </param>
            public virtual CreateRequest Create(Google.Apis.AccessContextManager.v1.Data.ServicePerimeter body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Create a Service Perimeter. The longrunning operation from this RPC will have a successful status once
            /// the Service Perimeter has propagated to long-lasting storage. Service Perimeters containing errors will
            /// result in an error response for the first error encountered.
            /// </summary>
            public class CreateRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.ServicePerimeter body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the access policy which owns this Service Perimeter. Format:
                /// `accessPolicies/{policy_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.ServicePerimeter Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/servicePerimeters";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accessPolicies/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Delete a Service Perimeter by resource name. The longrunning operation from this RPC will have a
            /// successful status once the Service Perimeter has been removed from long-lasting storage.
            /// </summary>
            /// <param name="name">
            /// Required. Resource name for the Service Perimeter. Format:
            /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeter_id}`
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Delete a Service Perimeter by resource name. The longrunning operation from this RPC will have a
            /// successful status once the Service Perimeter has been removed from long-lasting storage.
            /// </summary>
            public class DeleteRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the Service Perimeter. Format:
                /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeter_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accessPolicies/[^/]+/servicePerimeters/[^/]+$",
                    });
                }
            }

            /// <summary>Get a Service Perimeter by resource name.</summary>
            /// <param name="name">
            /// Required. Resource name for the Service Perimeter. Format:
            /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeters_id}`
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Get a Service Perimeter by resource name.</summary>
            public class GetRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.ServicePerimeter>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the Service Perimeter. Format:
                /// `accessPolicies/{policy_id}/servicePerimeters/{service_perimeters_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accessPolicies/[^/]+/servicePerimeters/[^/]+$",
                    });
                }
            }

            /// <summary>List all Service Perimeters for an access policy.</summary>
            /// <param name="parent">
            /// Required. Resource name for the access policy to list Service Perimeters from. Format:
            /// `accessPolicies/{policy_id}`
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>List all Service Perimeters for an access policy.</summary>
            public class ListRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.ListServicePerimetersResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the access policy to list Service Perimeters from. Format:
                /// `accessPolicies/{policy_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Number of Service Perimeters to include in the list. Default 100.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Next page token for the next batch of Service Perimeter instances. Defaults to the first page of
                /// results.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/servicePerimeters";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accessPolicies/[^/]+$",
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Update a Service Perimeter. The longrunning operation from this RPC will have a successful status once
            /// the changes to the Service Perimeter have propagated to long-lasting storage. Service Perimeter
            /// containing errors will result in an error response for the first error encountered.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Required. Resource name for the ServicePerimeter. The `short_name` component must begin with a letter
            /// and only include alphanumeric and '_'. Format:
            /// `accessPolicies/{policy_id}/servicePerimeters/{short_name}`
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AccessContextManager.v1.Data.ServicePerimeter body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Update a Service Perimeter. The longrunning operation from this RPC will have a successful status once
            /// the changes to the Service Perimeter have propagated to long-lasting storage. Service Perimeter
            /// containing errors will result in an error response for the first error encountered.
            /// </summary>
            public class PatchRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.ServicePerimeter body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the ServicePerimeter. The `short_name` component must begin with a
                /// letter and only include alphanumeric and '_'. Format:
                /// `accessPolicies/{policy_id}/servicePerimeters/{short_name}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Required. Mask to control which fields get updated. Must be non-empty.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.ServicePerimeter Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accessPolicies/[^/]+/servicePerimeters/[^/]+$",
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Replace all existing Service Perimeters in an Access Policy with the Service Perimeters provided. This
            /// is done atomically. The longrunning operation from this RPC will have a successful status once all
            /// replacements have propagated to long-lasting storage. Replacements containing errors will result in an
            /// error response for the first error encountered. Replacement will be cancelled on error, existing Service
            /// Perimeters will not be affected. Operation.response field will contain ReplaceServicePerimetersResponse.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name for the access policy which owns these Service Perimeters. Format:
            /// `accessPolicies/{policy_id}`
            /// </param>
            public virtual ReplaceAllRequest ReplaceAll(Google.Apis.AccessContextManager.v1.Data.ReplaceServicePerimetersRequest body, string parent)
            {
                return new ReplaceAllRequest(service, body, parent);
            }

            /// <summary>
            /// Replace all existing Service Perimeters in an Access Policy with the Service Perimeters provided. This
            /// is done atomically. The longrunning operation from this RPC will have a successful status once all
            /// replacements have propagated to long-lasting storage. Replacements containing errors will result in an
            /// error response for the first error encountered. Replacement will be cancelled on error, existing Service
            /// Perimeters will not be affected. Operation.response field will contain ReplaceServicePerimetersResponse.
            /// </summary>
            public class ReplaceAllRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new ReplaceAll request.</summary>
                public ReplaceAllRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.ReplaceServicePerimetersRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name for the access policy which owns these Service Perimeters. Format:
                /// `accessPolicies/{policy_id}`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.ReplaceServicePerimetersRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "replaceAll";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/servicePerimeters:replaceAll";

                /// <summary>Initializes ReplaceAll parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^accessPolicies/[^/]+$",
                    });
                }
            }
        }

        /// <summary>
        /// Create an `AccessPolicy`. Fails if this organization already has a `AccessPolicy`. The longrunning Operation
        /// will have a successful status once the `AccessPolicy` has propagated to long-lasting storage. Syntactic and
        /// basic semantic errors will be returned in `metadata` as a BadRequest proto.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.AccessContextManager.v1.Data.AccessPolicy body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>
        /// Create an `AccessPolicy`. Fails if this organization already has a `AccessPolicy`. The longrunning Operation
        /// will have a successful status once the `AccessPolicy` has propagated to long-lasting storage. Syntactic and
        /// basic semantic errors will be returned in `metadata` as a BadRequest proto.
        /// </summary>
        public class CreateRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.AccessPolicy body) : base(service)
            {
                Body = body;
                InitParameters();
            }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AccessContextManager.v1.Data.AccessPolicy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "create";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/accessPolicies";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
            }
        }

        /// <summary>
        /// Delete an AccessPolicy by resource name. The longrunning Operation will have a successful status once the
        /// AccessPolicy has been removed from long-lasting storage.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the access policy to delete. Format `accessPolicies/{policy_id}`
        /// </param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>
        /// Delete an AccessPolicy by resource name. The longrunning Operation will have a successful status once the
        /// AccessPolicy has been removed from long-lasting storage.
        /// </summary>
        public class DeleteRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name for the access policy to delete. Format `accessPolicies/{policy_id}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^accessPolicies/[^/]+$",
                });
            }
        }

        /// <summary>Get an AccessPolicy by name.</summary>
        /// <param name="name">
        /// Required. Resource name for the access policy to get. Format `accessPolicies/{policy_id}`
        /// </param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Get an AccessPolicy by name.</summary>
        public class GetRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.AccessPolicy>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Resource name for the access policy to get. Format `accessPolicies/{policy_id}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^accessPolicies/[^/]+$",
                });
            }
        }

        /// <summary>List all AccessPolicies under a container.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>List all AccessPolicies under a container.</summary>
        public class ListRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.ListAccessPoliciesResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service) : base(service)
            {
                InitParameters();
            }

            /// <summary>Number of AccessPolicy instances to include in the list. Default 100.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>
            /// Next page token for the next batch of AccessPolicy instances. Defaults to the first page of results.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>
            /// Required. Resource name for the container to list AccessPolicy instances from. Format:
            /// `organizations/{org_id}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/accessPolicies";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                {
                    Name = "parent",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }

        /// <summary>
        /// Update an AccessPolicy. The longrunning Operation from this RPC will have a successful status once the
        /// changes to the AccessPolicy have propagated to long-lasting storage. Syntactic and basic semantic errors
        /// will be returned in `metadata` as a BadRequest proto.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// Output only. Resource name of the `AccessPolicy`. Format: `accessPolicies/{policy_id}`
        /// </param>
        public virtual PatchRequest Patch(Google.Apis.AccessContextManager.v1.Data.AccessPolicy body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>
        /// Update an AccessPolicy. The longrunning Operation from this RPC will have a successful status once the
        /// changes to the AccessPolicy have propagated to long-lasting storage. Syntactic and basic semantic errors
        /// will be returned in `metadata` as a BadRequest proto.
        /// </summary>
        public class PatchRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.AccessPolicy body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// Output only. Resource name of the `AccessPolicy`. Format: `accessPolicies/{policy_id}`
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Required. Mask to control which fields get updated. Must be non-empty.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AccessContextManager.v1.Data.AccessPolicy Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^accessPolicies/[^/]+$",
                });
                RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                {
                    Name = "updateMask",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "operations" collection of methods.</summary>
    public class OperationsResource
    {
        private const string Resource = "operations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OperationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether
        /// the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">The name of the operation resource to be cancelled.</param>
        public virtual CancelRequest Cancel(Google.Apis.AccessContextManager.v1.Data.CancelOperationRequest body, string name)
        {
            return new CancelRequest(service, body, name);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel the
        /// operation, but success is not guaranteed. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check whether
        /// the cancellation succeeded or whether the operation completed despite cancellation. On successful
        /// cancellation, the operation is not deleted; instead, it becomes an operation with an Operation.error value
        /// with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
        /// </summary>
        public class CancelRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Empty>
        {
            /// <summary>Constructs a new Cancel request.</summary>
            public CancelRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.CancelOperationRequest body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>The name of the operation resource to be cancelled.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.AccessContextManager.v1.Data.CancelOperationRequest Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "cancel";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}:cancel";

            /// <summary>Initializes Cancel parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^operations/.*$",
                });
            }
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
        /// operation result. It does not cancel the operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        /// <param name="name">The name of the operation resource to be deleted.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>
        /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
        /// operation result. It does not cancel the operation. If the server doesn't support this method, it returns
        /// `google.rpc.Code.UNIMPLEMENTED`.
        /// </summary>
        public class DeleteRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Empty>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>The name of the operation resource to be deleted.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^operations/.*$",
                });
            }
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        /// <param name="name">The name of the operation resource.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>
        /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation result
        /// at intervals as recommended by the API service.
        /// </summary>
        public class GetRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>The name of the operation resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "get";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^operations/.*$",
                });
            }
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method,
        /// it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding to use
        /// different resource name schemes, such as `users/*/operations`. To override the binding, API services can add
        /// a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For backwards
        /// compatibility, the default name includes the operations collection id, however overriding users must ensure
        /// the name binding is the parent resource, without the operations collection id.
        /// </summary>
        /// <param name="name">The name of the operation's parent resource.</param>
        public virtual ListRequest List(string name)
        {
            return new ListRequest(service, name);
        }

        /// <summary>
        /// Lists operations that match the specified filter in the request. If the server doesn't support this method,
        /// it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the binding to use
        /// different resource name schemes, such as `users/*/operations`. To override the binding, API services can add
        /// a binding such as `"/v1/{name=users/*}/operations"` to their service configuration. For backwards
        /// compatibility, the default name includes the operations collection id, however overriding users must ensure
        /// the name binding is the parent resource, without the operations collection id.
        /// </summary>
        public class ListRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.ListOperationsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>The name of the operation's parent resource.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The standard list filter.</summary>
            [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Filter { get; set; }

            /// <summary>The standard list page size.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The standard list page token.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "list";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^operations$",
                });
                RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                {
                    Name = "filter",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageSize",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                {
                    Name = "pageToken",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            }
        }
    }

    /// <summary>The "organizations" collection of methods.</summary>
    public class OrganizationsResource
    {
        private const string Resource = "organizations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrganizationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            GcpUserAccessBindings = new GcpUserAccessBindingsResource(service);
        }

        /// <summary>Gets the GcpUserAccessBindings resource.</summary>
        public virtual GcpUserAccessBindingsResource GcpUserAccessBindings { get; }

        /// <summary>The "gcpUserAccessBindings" collection of methods.</summary>
        public class GcpUserAccessBindingsResource
        {
            private const string Resource = "gcpUserAccessBindings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public GcpUserAccessBindingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Creates a GcpUserAccessBinding. If the client specifies a name, the server will ignore it. Fails if a
            /// resource already exists with the same group_key. Completion of this long-running operation does not
            /// necessarily signify that the new binding is deployed onto all affected users, which may take more time.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. Example: "organizations/256"</param>
            public virtual CreateRequest Create(Google.Apis.AccessContextManager.v1.Data.GcpUserAccessBinding body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>
            /// Creates a GcpUserAccessBinding. If the client specifies a name, the server will ignore it. Fails if a
            /// resource already exists with the same group_key. Completion of this long-running operation does not
            /// necessarily signify that the new binding is deployed onto all affected users, which may take more time.
            /// </summary>
            public class CreateRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.GcpUserAccessBinding body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>Required. Example: "organizations/256"</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.GcpUserAccessBinding Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/gcpUserAccessBindings";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a GcpUserAccessBinding. Completion of this long-running operation does not necessarily signify
            /// that the binding deletion is deployed onto all affected users, which may take more time.
            /// </summary>
            /// <param name="name">Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a GcpUserAccessBinding. Completion of this long-running operation does not necessarily signify
            /// that the binding deletion is deployed onto all affected users, which may take more time.
            /// </summary>
            public class DeleteRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/gcpUserAccessBindings/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the GcpUserAccessBinding with the given name.</summary>
            /// <param name="name">Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the GcpUserAccessBinding with the given name.</summary>
            public class GetRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.GcpUserAccessBinding>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>Required. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "get";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/gcpUserAccessBindings/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all GcpUserAccessBindings for a Google Cloud organization.</summary>
            /// <param name="parent">Required. Example: "organizations/256"</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all GcpUserAccessBindings for a Google Cloud organization.</summary>
            public class ListRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.ListGcpUserAccessBindingsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>Required. Example: "organizations/256"</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Optional. Maximum number of items to return. The server may return fewer items. If left blank, the
                /// server may return any number of items.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// Optional. If left blank, returns the first page. To enumerate all items, use the next_page_token
                /// from your previous list operation.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/gcpUserAccessBindings";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+$",
                    });
                    RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageToken",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Updates a GcpUserAccessBinding. Completion of this long-running operation does not necessarily signify
            /// that the changed binding is deployed onto all affected users, which may take more time.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// Immutable. Assigned by the server during creation. The last segment has an arbitrary length and has only
            /// URI unreserved characters (as defined by [RFC 3986 Section
            /// 2.3](https://tools.ietf.org/html/rfc3986#section-2.3)). Should not be specified by the client during
            /// creation. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.AccessContextManager.v1.Data.GcpUserAccessBinding body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            /// Updates a GcpUserAccessBinding. Completion of this long-running operation does not necessarily signify
            /// that the changed binding is deployed onto all affected users, which may take more time.
            /// </summary>
            public class PatchRequest : AccessContextManagerBaseServiceRequest<Google.Apis.AccessContextManager.v1.Data.Operation>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.AccessContextManager.v1.Data.GcpUserAccessBinding body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Immutable. Assigned by the server during creation. The last segment has an arbitrary length and has
                /// only URI unreserved characters (as defined by [RFC 3986 Section
                /// 2.3](https://tools.ietf.org/html/rfc3986#section-2.3)). Should not be specified by the client during
                /// creation. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// Required. Only the fields specified in this mask are updated. Because name and group_key cannot be
                /// changed, update_mask is required and must always be: update_mask { paths: "access_levels" }
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.AccessContextManager.v1.Data.GcpUserAccessBinding Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Patch parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/gcpUserAccessBindings/[^/]+$",
                    });
                    RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }
        }
    }
}
namespace Google.Apis.AccessContextManager.v1.Data
{
    /// <summary>
    /// An `AccessLevel` is a label that can be applied to requests to Google Cloud services, along with a list of
    /// requirements necessary for the label to be applied.
    /// </summary>
    public class AccessLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A `BasicLevel` composed of `Conditions`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basic")]
        public virtual BasicLevel Basic { get; set; }

        /// <summary>A `CustomLevel` written in the Common Expression Language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("custom")]
        public virtual CustomLevel Custom { get; set; }

        /// <summary>Description of the `AccessLevel` and its use. Does not affect behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Resource name for the Access Level. The `short_name` component must begin with a letter and only
        /// include alphanumeric and '_'. Format: `accessPolicies/{policy_id}/accessLevels/{short_name}`. The maximum
        /// length of the `short_name` component is 50 characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Human readable title. Must be unique within the Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `AccessPolicy` is a container for `AccessLevels` (which define the necessary attributes to use Google Cloud
    /// services) and `ServicePerimeters` (which define regions of services able to freely pass data within a
    /// perimeter). An access policy is globally visible within an organization, and the restrictions it specifies apply
    /// to all projects within an organization.
    /// </summary>
    public class AccessPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. An opaque identifier for the current version of the `AccessPolicy`. This will always be a
        /// strongly validated etag, meaning that two Access Polices will be identical if and only if their etags are
        /// identical. Clients should not expect this to be in any specific format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>Output only. Resource name of the `AccessPolicy`. Format: `accessPolicies/{policy_id}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Required. The parent of this `AccessPolicy` in the Cloud Resource Hierarchy. Currently immutable once
        /// created. Format: `organizations/{organization_id}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>Required. Human readable title. Does not affect behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }
    }

    /// <summary>Identification for an API Operation.</summary>
    public class ApiOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// API methods or permissions to allow. Method or permission must belong to the service specified by
        /// `service_name` field. A single MethodSelector entry with `*` specified for the `method` field will allow all
        /// methods AND permissions for the service specified in `service_name`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodSelectors")]
        public virtual System.Collections.Generic.IList<MethodSelector> MethodSelectors { get; set; }

        /// <summary>
        /// The name of the API whose methods or permissions the IngressPolicy or EgressPolicy want to allow. A single
        /// ApiOperation with `service_name` field set to `*` will allow all methods AND permissions for all services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>`BasicLevel` is an `AccessLevel` using a set of recommended features.</summary>
    public class BasicLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// How the `conditions` list should be combined to determine if a request is granted this `AccessLevel`. If AND
        /// is used, each `Condition` in `conditions` must be satisfied for the `AccessLevel` to be applied. If OR is
        /// used, at least one `Condition` in `conditions` must be satisfied for the `AccessLevel` to be applied.
        /// Default behavior is AND.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("combiningFunction")]
        public virtual string CombiningFunction { get; set; }

        /// <summary>Required. A list of requirements for the `AccessLevel` to be granted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditions")]
        public virtual System.Collections.Generic.IList<Condition> Conditions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The request message for Operations.CancelOperation.</summary>
    public class CancelOperationRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A request to commit dry-run specs in all Service Perimeters belonging to an Access Policy.</summary>
    public class CommitServicePerimetersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The etag for the version of the Access Policy that this commit operation is to be performed on.
        /// If, at the time of commit, the etag for the Access Policy stored in Access Context Manager is different from
        /// the specified etag, then the commit operation will not be performed and the call will fail. This field is
        /// not required. If etag is not provided, the operation will be performed as if a valid etag is provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A response to CommitServicePerimetersRequest. This will be put inside of Operation.response field.
    /// </summary>
    public class CommitServicePerimetersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of all the Service Perimeter instances in the Access Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicePerimeters")]
        public virtual System.Collections.Generic.IList<ServicePerimeter> ServicePerimeters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A condition necessary for an `AccessLevel` to be granted. The Condition is an AND over its fields. So a
    /// Condition is true if: 1) the request IP is from one of the listed subnetworks AND 2) the originating device
    /// complies with the listed device policy AND 3) all listed access levels are granted AND 4) the request was sent
    /// at a time allowed by the DateTimeRestriction.
    /// </summary>
    public class Condition : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Device specific restrictions, all restrictions must hold for the Condition to be true. If not specified, all
        /// devices are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devicePolicy")]
        public virtual DevicePolicy DevicePolicy { get; set; }

        /// <summary>
        /// CIDR block IP subnetwork specification. May be IPv4 or IPv6. Note that for a CIDR IP address block, the
        /// specified IP address portion must be properly truncated (i.e. all the host bits must be zero) or the input
        /// is considered malformed. For example, "192.0.2.0/24" is accepted but "192.0.2.1/24" is not. Similarly, for
        /// IPv6, "2001:db8::/32" is accepted whereas "2001:db8::1/32" is not. The originating IP of a request must be
        /// in one of the listed subnets in order for this Condition to be true. If empty, all IP addresses are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipSubnetworks")]
        public virtual System.Collections.Generic.IList<string> IpSubnetworks { get; set; }

        /// <summary>
        /// The request must be made by one of the provided user or service accounts. Groups are not supported. Syntax:
        /// `user:{emailid}` `serviceAccount:{emailid}` If not specified, a request may come from any user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Whether to negate the Condition. If true, the Condition becomes a NAND over its non-empty fields, each field
        /// must be false for the Condition overall to be satisfied. Defaults to false.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("negate")]
        public virtual System.Nullable<bool> Negate { get; set; }

        /// <summary>
        /// The request must originate from one of the provided countries/regions. Must be valid ISO 3166-1 alpha-2
        /// codes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regions")]
        public virtual System.Collections.Generic.IList<string> Regions { get; set; }

        /// <summary>
        /// A list of other access levels defined in the same `Policy`, referenced by resource name. Referencing an
        /// `AccessLevel` which does not exist is an error. All access levels listed must be granted for the Condition
        /// to be true. Example: "`accessPolicies/MY_POLICY/accessLevels/LEVEL_NAME"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requiredAccessLevels")]
        public virtual System.Collections.Generic.IList<string> RequiredAccessLevels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `CustomLevel` is an `AccessLevel` using the Cloud Common Expression Language to represent the necessary
    /// conditions for the level to apply to a request. See CEL spec at: https://github.com/google/cel-spec
    /// </summary>
    public class CustomLevel : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A Cloud CEL expression evaluating to a boolean.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expr")]
        public virtual Expr Expr { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `DevicePolicy` specifies device specific restrictions necessary to acquire a given access level. A
    /// `DevicePolicy` specifies requirements for requests from devices to be granted access levels, it does not do any
    /// enforcement on the device. `DevicePolicy` acts as an AND over all specified fields, and each repeated field is
    /// an OR over its elements. Any unset fields are ignored. For example, if the proto is { os_type : DESKTOP_WINDOWS,
    /// os_type : DESKTOP_LINUX, encryption_status: ENCRYPTED}, then the DevicePolicy will be true for requests
    /// originating from encrypted Linux desktops and encrypted Windows desktops.
    /// </summary>
    public class DevicePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Allowed device management levels, an empty list allows all management levels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedDeviceManagementLevels")]
        public virtual System.Collections.Generic.IList<string> AllowedDeviceManagementLevels { get; set; }

        /// <summary>Allowed encryptions statuses, an empty list allows all statuses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedEncryptionStatuses")]
        public virtual System.Collections.Generic.IList<string> AllowedEncryptionStatuses { get; set; }

        /// <summary>Allowed OS versions, an empty list allows all types and all versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osConstraints")]
        public virtual System.Collections.Generic.IList<OsConstraint> OsConstraints { get; set; }

        /// <summary>Whether the device needs to be approved by the customer admin.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireAdminApproval")]
        public virtual System.Nullable<bool> RequireAdminApproval { get; set; }

        /// <summary>Whether the device needs to be corp owned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireCorpOwned")]
        public virtual System.Nullable<bool> RequireCorpOwned { get; set; }

        /// <summary>
        /// Whether or not screenlock is required for the DevicePolicy to be true. Defaults to `false`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireScreenlock")]
        public virtual System.Nullable<bool> RequireScreenlock { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the conditions under which an EgressPolicy matches a request. Conditions based on information about the
    /// source of the request. Note that if the destination of the request is also protected by a ServicePerimeter, then
    /// that ServicePerimeter must have an IngressPolicy which allows access in order for this request to succeed.
    /// </summary>
    public class EgressFrom : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of identities that are allowed access through this [EgressPolicy]. Should be in the format of email
        /// address. The email address should represent individual user or service account only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identities")]
        public virtual System.Collections.Generic.IList<string> Identities { get; set; }

        /// <summary>
        /// Specifies the type of identities that are allowed access to outside the perimeter. If left unspecified, then
        /// members of `identities` field will be allowed access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityType")]
        public virtual string IdentityType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Policy for egress from perimeter. EgressPolicies match requests based on `egress_from` and `egress_to` stanzas.
    /// For an EgressPolicy to match, both `egress_from` and `egress_to` stanzas must be matched. If an EgressPolicy
    /// matches a request, the request is allowed to span the ServicePerimeter boundary. For example, an EgressPolicy
    /// can be used to allow VMs on networks within the ServicePerimeter to access a defined set of projects outside the
    /// perimeter in certain contexts (e.g. to read data from a Cloud Storage bucket or query against a BigQuery
    /// dataset). EgressPolicies are concerned with the *resources* that a request relates as well as the API services
    /// and API actions being used. They do not related to the direction of data movement. More detailed documentation
    /// for this concept can be found in the descriptions of EgressFrom and EgressTo.
    /// </summary>
    public class EgressPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines conditions on the source of a request causing this EgressPolicy to apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressFrom")]
        public virtual EgressFrom EgressFrom { get; set; }

        /// <summary>
        /// Defines the conditions on the ApiOperation and destination resources that cause this EgressPolicy to apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressTo")]
        public virtual EgressTo EgressTo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the conditions under which an EgressPolicy matches a request. Conditions are based on information about
    /// the ApiOperation intended to be performed on the `resources` specified. Note that if the destination of the
    /// request is also protected by a ServicePerimeter, then that ServicePerimeter must have an IngressPolicy which
    /// allows access in order for this request to succeed. The request must match `operations` AND `resources` fields
    /// in order to be allowed egress out of the perimeter.
    /// </summary>
    public class EgressTo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of ApiOperations allowed to be performed by the sources specified in the corresponding EgressFrom. A
        /// request matches if it uses an operation/service in this list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<ApiOperation> Operations { get; set; }

        /// <summary>
        /// A list of resources, currently only projects in the form `projects/`, that are allowed to be accessed by
        /// sources defined in the corresponding EgressFrom. A request matches if it contains a resource in this list.
        /// If `*` is specified for `resources`, then this EgressTo rule will authorize access to all resources outside
        /// the perimeter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<string> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty JSON
    /// object `{}`.
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression
    /// language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec. Example
    /// (Comparison): title: "Summary size limit" description: "Determines if a summary is less than 100 chars"
    /// expression: "document.summary.size() &amp;lt; 100" Example (Equality): title: "Requestor is owner" description:
    /// "Determines if requestor is the document owner" expression: "document.owner == request.auth.claims.email"
    /// Example (Logic): title: "Public documents" description: "Determine whether the document should be publicly
    /// visible" expression: "document.type != 'private' &amp;amp;&amp;amp; document.type != 'internal'" Example (Data
    /// Manipulation): title: "Notification string" description: "Create a notification string with a timestamp."
    /// expression: "'New message received at ' + string(document.create_time)" The exact variables and functions that
    /// may be referenced within an expression are determined by the service that evaluates it. See the service
    /// documentation for additional information.
    /// </summary>
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Description of the expression. This is a longer text which describes the expression, e.g. when
        /// hovered over it in a UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>
        /// Optional. String indicating the location of the expression for error reporting, e.g. a file name and a
        /// position in the file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs
        /// which allow to enter the expression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Restricts access to Cloud Console and Google Cloud APIs for a set of users using Context-Aware Access.
    /// </summary>
    public class GcpUserAccessBinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. Access level that a user must have to be granted access. Only one access level is supported, not
        /// multiple. This repeated field must have exactly one element. Example:
        /// "accessPolicies/9522/accessLevels/device_trusted"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevels")]
        public virtual System.Collections.Generic.IList<string> AccessLevels { get; set; }

        /// <summary>
        /// Required. Immutable. Google Group id whose members are subject to this binding's restrictions. See "id" in
        /// the [G Suite Directory API's Groups resource]
        /// (https://developers.google.com/admin-sdk/directory/v1/reference/groups#resource). If a group's email
        /// address/alias is changed, this resource will continue to point at the changed group. This field does not
        /// accept group email addresses or aliases. Example: "01d520gv4vjcrht"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupKey")]
        public virtual string GroupKey { get; set; }

        /// <summary>
        /// Immutable. Assigned by the server during creation. The last segment has an arbitrary length and has only URI
        /// unreserved characters (as defined by [RFC 3986 Section
        /// 2.3](https://tools.ietf.org/html/rfc3986#section-2.3)). Should not be specified by the client during
        /// creation. Example: "organizations/256/gcpUserAccessBindings/b3-BhcX_Ud5N"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the conditions under which an IngressPolicy matches a request. Conditions are based on information about
    /// the source of the request. The request must satisfy what is defined in `sources` AND identity related fields in
    /// order to match.
    /// </summary>
    public class IngressFrom : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of identities that are allowed access through this ingress policy. Should be in the format of email
        /// address. The email address should represent individual user or service account only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identities")]
        public virtual System.Collections.Generic.IList<string> Identities { get; set; }

        /// <summary>
        /// Specifies the type of identities that are allowed access from outside the perimeter. If left unspecified,
        /// then members of `identities` field will be allowed access.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityType")]
        public virtual string IdentityType { get; set; }

        /// <summary>Sources that this IngressPolicy authorizes access from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<IngressSource> Sources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Policy for ingress into ServicePerimeter. IngressPolicies match requests based on `ingress_from` and
    /// `ingress_to` stanzas. For an ingress policy to match, both the `ingress_from` and `ingress_to` stanzas must be
    /// matched. If an IngressPolicy matches a request, the request is allowed through the perimeter boundary from
    /// outside the perimeter. For example, access from the internet can be allowed either based on an AccessLevel or,
    /// for traffic hosted on Google Cloud, the project of the source network. For access from private networks, using
    /// the project of the hosting network is required. Individual ingress policies can be limited by restricting which
    /// services and/or actions they match using the `ingress_to` field.
    /// </summary>
    public class IngressPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Defines the conditions on the source of a request causing this IngressPolicy to apply.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressFrom")]
        public virtual IngressFrom IngressFrom { get; set; }

        /// <summary>
        /// Defines the conditions on the ApiOperation and request destination that cause this IngressPolicy to apply.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressTo")]
        public virtual IngressTo IngressTo { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The source that IngressPolicy authorizes access from.</summary>
    public class IngressSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// An AccessLevel resource name that allow resources within the ServicePerimeters to be accessed from the
        /// internet. AccessLevels listed must be in the same policy as this ServicePerimeter. Referencing a nonexistent
        /// AccessLevel will cause an error. If no AccessLevel names are listed, resources within the perimeter can only
        /// be accessed via Google Cloud calls with request origins within the perimeter. Example:
        /// `accessPolicies/MY_POLICY/accessLevels/MY_LEVEL`. If a single `*` is specified for `access_level`, then all
        /// IngressSources will be allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevel")]
        public virtual string AccessLevel { get; set; }

        /// <summary>
        /// A Google Cloud resource that is allowed to ingress the perimeter. Requests from these resources will be
        /// allowed to access perimeter data. Currently only projects are allowed. Format: `projects/{project_number}`
        /// The project may be in any Google Cloud organization, not just the organization that the perimeter is defined
        /// in. `*` is not allowed, the case of allowing all Google Cloud resources only is not supported.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the conditions under which an IngressPolicy matches a request. Conditions are based on information about
    /// the ApiOperation intended to be performed on the target resource of the request. The request must satisfy what
    /// is defined in `operations` AND `resources` in order to match.
    /// </summary>
    public class IngressTo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of ApiOperations allowed to be performed by the sources specified in corresponding IngressFrom in
        /// this ServicePerimeter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<ApiOperation> Operations { get; set; }

        /// <summary>
        /// A list of resources, currently only projects in the form `projects/`, protected by this ServicePerimeter
        /// that are allowed to be accessed by sources defined in the corresponding IngressFrom. If a single `*` is
        /// specified, then access to all resources inside the perimeter are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<string> Resources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response to `ListAccessLevelsRequest`.</summary>
    public class ListAccessLevelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of the Access Level instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevels")]
        public virtual System.Collections.Generic.IList<AccessLevel> AccessLevels { get; set; }

        /// <summary>
        /// The pagination token to retrieve the next page of results. If the value is empty, no further results remain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response to `ListAccessPoliciesRequest`.</summary>
    public class ListAccessPoliciesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of the AccessPolicy instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessPolicies")]
        public virtual System.Collections.Generic.IList<AccessPolicy> AccessPolicies { get; set; }

        /// <summary>
        /// The pagination token to retrieve the next page of results. If the value is empty, no further results remain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of ListGcpUserAccessBindings.</summary>
    public class ListGcpUserAccessBindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>GcpUserAccessBinding</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcpUserAccessBindings")]
        public virtual System.Collections.Generic.IList<GcpUserAccessBinding> GcpUserAccessBindings { get; set; }

        /// <summary>Token to get the next page of items. If blank, there are no more items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class ListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<Operation> Operations { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A response to `ListServicePerimetersRequest`.</summary>
    public class ListServicePerimetersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The pagination token to retrieve the next page of results. If the value is empty, no further results remain.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>List of the Service Perimeter instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicePerimeters")]
        public virtual System.Collections.Generic.IList<ServicePerimeter> ServicePerimeters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An allowed method or permission of a service specified in ApiOperation.</summary>
    public class MethodSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Value for `method` should be a valid method name for the corresponding `service_name` in ApiOperation. If
        /// `*` used as value for `method`, then ALL methods and permissions are allowed.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("method")]
        public virtual string Method { get; set; }

        /// <summary>
        /// Value for `permission` should be a valid Cloud IAM permission for the corresponding `service_name` in
        /// ApiOperation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual string Permission { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If the value is `false`, it means the operation is still in progress. If `true`, the operation is completed,
        /// and either `error` or `response` is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; }

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; }

        /// <summary>
        /// Service-specific metadata associated with the operation. It typically contains progress information and
        /// common metadata such as create time. Some services might not provide such metadata. Any method that returns
        /// a long-running operation should document the metadata type, if any.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// The server-assigned name, which is only unique within the same service that originally returns it. If you
        /// use the default HTTP mapping, the `name` should be a resource name ending with `operations/{unique_id}`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The normal response of the operation in case of success. If the original method returns no data on success,
        /// such as `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string, object> Response { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A restriction on the OS type and version of devices making requests.</summary>
    public class OsConstraint : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The minimum allowed OS version. If not set, any version of this OS satisfies the constraint. Format:
        /// `"major.minor.patch"`. Examples: `"10.5.301"`, `"9.2.1"`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumVersion")]
        public virtual string MinimumVersion { get; set; }

        /// <summary>Required. The allowed OS type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osType")]
        public virtual string OsType { get; set; }

        /// <summary>
        /// Only allows requests from devices with a verified Chrome OS. Verifications includes requirements that the
        /// device is enterprise-managed, conformant to domain policies, and the caller has permission to call the API
        /// targeted by the request.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requireVerifiedChromeOs")]
        public virtual System.Nullable<bool> RequireVerifiedChromeOs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A request to replace all existing Access Levels in an Access Policy with the Access Levels provided. This is
    /// done atomically.
    /// </summary>
    public class ReplaceAccessLevelsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The desired Access Levels that should replace all existing Access Levels in the Access Policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevels")]
        public virtual System.Collections.Generic.IList<AccessLevel> AccessLevels { get; set; }

        /// <summary>
        /// Optional. The etag for the version of the Access Policy that this replace operation is to be performed on.
        /// If, at the time of replace, the etag for the Access Policy stored in Access Context Manager is different
        /// from the specified etag, then the replace operation will not be performed and the call will fail. This field
        /// is not required. If etag is not provided, the operation will be performed as if a valid etag is provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A response to ReplaceAccessLevelsRequest. This will be put inside of Operation.response field.
    /// </summary>
    public class ReplaceAccessLevelsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of the Access Level instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevels")]
        public virtual System.Collections.Generic.IList<AccessLevel> AccessLevels { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A request to replace all existing Service Perimeters in an Access Policy with the Service Perimeters provided.
    /// This is done atomically.
    /// </summary>
    public class ReplaceServicePerimetersRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The etag for the version of the Access Policy that this replace operation is to be performed on.
        /// If, at the time of replace, the etag for the Access Policy stored in Access Context Manager is different
        /// from the specified etag, then the replace operation will not be performed and the call will fail. This field
        /// is not required. If etag is not provided, the operation will be performed as if a valid etag is provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Required. The desired Service Perimeters that should replace all existing Service Perimeters in the Access
        /// Policy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicePerimeters")]
        public virtual System.Collections.Generic.IList<ServicePerimeter> ServicePerimeters { get; set; }
    }

    /// <summary>
    /// A response to ReplaceServicePerimetersRequest. This will be put inside of Operation.response field.
    /// </summary>
    public class ReplaceServicePerimetersResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of the Service Perimeter instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("servicePerimeters")]
        public virtual System.Collections.Generic.IList<ServicePerimeter> ServicePerimeters { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `ServicePerimeter` describes a set of Google Cloud resources which can freely import and export data amongst
    /// themselves, but not export outside of the `ServicePerimeter`. If a request with a source within this
    /// `ServicePerimeter` has a target outside of the `ServicePerimeter`, the request will be blocked. Otherwise the
    /// request is allowed. There are two types of Service Perimeter - Regular and Bridge. Regular Service Perimeters
    /// cannot overlap, a single Google Cloud project can only belong to a single regular Service Perimeter. Service
    /// Perimeter Bridges can contain only Google Cloud projects as members, a single Google Cloud project may belong to
    /// multiple Service Perimeter Bridges.
    /// </summary>
    public class ServicePerimeter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Description of the `ServicePerimeter` and its use. Does not affect behavior.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Required. Resource name for the ServicePerimeter. The `short_name` component must begin with a letter and
        /// only include alphanumeric and '_'. Format: `accessPolicies/{policy_id}/servicePerimeters/{short_name}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Perimeter type indicator. A single project is allowed to be a member of single regular perimeter, but
        /// multiple service perimeter bridges. A project cannot be a included in a perimeter bridge without being
        /// included in regular perimeter. For perimeter bridges, the restricted service list as well as access level
        /// lists must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("perimeterType")]
        public virtual string PerimeterType { get; set; }

        /// <summary>
        /// Proposed (or dry run) ServicePerimeter configuration. This configuration allows to specify and test
        /// ServicePerimeter configuration without enforcing actual access restrictions. Only allowed to be set when the
        /// "use_explicit_dry_run_spec" flag is set.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spec")]
        public virtual ServicePerimeterConfig Spec { get; set; }

        /// <summary>
        /// Current ServicePerimeter configuration. Specifies sets of resources, restricted services and access levels
        /// that determine perimeter content and boundaries.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual ServicePerimeterConfig Status { get; set; }

        /// <summary>Human readable title. Must be unique within the Policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>
        /// Use explicit dry run spec flag. Ordinarily, a dry-run spec implicitly exists for all Service Perimeters, and
        /// that spec is identical to the status for those Service Perimeters. When this flag is set, it inhibits the
        /// generation of the implicit spec, thereby allowing the user to explicitly provide a configuration ("spec") to
        /// use in a dry-run version of the Service Perimeter. This allows the user to test changes to the enforced
        /// config ("status") without actually enforcing them. This testing is done through analyzing the differences
        /// between currently enforced and suggested restrictions. use_explicit_dry_run_spec must bet set to True if any
        /// of the fields in the spec are set to non-default values.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("useExplicitDryRunSpec")]
        public virtual System.Nullable<bool> UseExplicitDryRunSpec { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// `ServicePerimeterConfig` specifies a set of Google Cloud resources that describe specific Service Perimeter
    /// configuration.
    /// </summary>
    public class ServicePerimeterConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// A list of `AccessLevel` resource names that allow resources within the `ServicePerimeter` to be accessed
        /// from the internet. `AccessLevels` listed must be in the same policy as this `ServicePerimeter`. Referencing
        /// a nonexistent `AccessLevel` is a syntax error. If no `AccessLevel` names are listed, resources within the
        /// perimeter can only be accessed via Google Cloud calls with request origins within the perimeter. Example:
        /// `"accessPolicies/MY_POLICY/accessLevels/MY_LEVEL"`. For Service Perimeter Bridge, must be empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessLevels")]
        public virtual System.Collections.Generic.IList<string> AccessLevels { get; set; }

        /// <summary>
        /// List of EgressPolicies to apply to the perimeter. A perimeter may have multiple EgressPolicies, each of
        /// which is evaluated separately. Access is granted if any EgressPolicy grants it. Must be empty for a
        /// perimeter bridge.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("egressPolicies")]
        public virtual System.Collections.Generic.IList<EgressPolicy> EgressPolicies { get; set; }

        /// <summary>
        /// List of IngressPolicies to apply to the perimeter. A perimeter may have multiple IngressPolicies, each of
        /// which is evaluated separately. Access is granted if any Ingress Policy grants it. Must be empty for a
        /// perimeter bridge.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ingressPolicies")]
        public virtual System.Collections.Generic.IList<IngressPolicy> IngressPolicies { get; set; }

        /// <summary>
        /// A list of Google Cloud resources that are inside of the service perimeter. Currently only projects are
        /// allowed. Format: `projects/{project_number}`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<string> Resources { get; set; }

        /// <summary>
        /// Google Cloud services that are subject to the Service Perimeter restrictions. For example, if
        /// `storage.googleapis.com` is specified, access to the storage buckets inside the perimeter must meet the
        /// perimeter's access restrictions.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("restrictedServices")]
        public virtual System.Collections.Generic.IList<string> RestrictedServices { get; set; }

        /// <summary>Configuration for APIs allowed within Perimeter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vpcAccessibleServices")]
        public virtual VpcAccessibleServices VpcAccessibleServices { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Specifies how APIs are allowed to communicate within the Service Perimeter.</summary>
    public class VpcAccessibleServices : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The list of APIs usable within the Service Perimeter. Must be empty unless 'enable_restriction' is True. You
        /// can specify a list of individual services, as well as include the 'RESTRICTED-SERVICES' value, which
        /// automatically includes all of the services protected by the perimeter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedServices")]
        public virtual System.Collections.Generic.IList<string> AllowedServices { get; set; }

        /// <summary>
        /// Whether to restrict API calls within the Service Perimeter to the list of APIs specified in
        /// 'allowed_services'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableRestriction")]
        public virtual System.Nullable<bool> EnableRestriction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
