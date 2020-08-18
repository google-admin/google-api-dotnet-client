// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.CloudIdentity.v1
{
    /// <summary>The CloudIdentity Service.</summary>
    public class CloudIdentityService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudIdentityService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudIdentityService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            Groups = new GroupsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudidentity";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://cloudidentity.googleapis.com/";
        #else
            "https://cloudidentity.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudidentity.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Identity API.</summary>
        public class Scope
        {
            /// <summary>See, change, create, and delete any of the Cloud Identity Groups that you can access, including
            /// the members of each group</summary>
            public static string CloudIdentityGroups = "https://www.googleapis.com/auth/cloud-identity.groups";

            /// <summary>See any Cloud Identity Groups that you can access, including group members and their
            /// emails</summary>
            public static string CloudIdentityGroupsReadonly = "https://www.googleapis.com/auth/cloud-identity.groups.readonly";

            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Identity API.</summary>
        public static class ScopeConstants
        {
            /// <summary>See, change, create, and delete any of the Cloud Identity Groups that you can access, including
            /// the members of each group</summary>
            public const string CloudIdentityGroups = "https://www.googleapis.com/auth/cloud-identity.groups";

            /// <summary>See any Cloud Identity Groups that you can access, including group members and their
            /// emails</summary>
            public const string CloudIdentityGroupsReadonly = "https://www.googleapis.com/auth/cloud-identity.groups.readonly";

            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }



        /// <summary>Gets the Groups resource.</summary>
        public virtual GroupsResource Groups { get; }
    }

    ///<summary>A base abstract class for CloudIdentity requests.</summary>
    public abstract class CloudIdentityBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new CloudIdentityBaseServiceRequest instance.</summary>
        protected CloudIdentityBaseServiceRequest(Google.Apis.Services.IClientService service)
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
        /// [default: json]
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
        /// [default: true]
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

        /// <summary>Initializes CloudIdentity parameter list.</summary>
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
            Memberships = new MembershipsResource(service);

        }

        /// <summary>Gets the Memberships resource.</summary>
        public virtual MembershipsResource Memberships { get; }

        /// <summary>The "memberships" collection of methods.</summary>
        public class MembershipsResource
        {
            private const string Resource = "memberships";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MembershipsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Creates a Membership.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Group to
            /// create Membership within. Format: `groups/{group_id}`, where `group_id` is the unique ID assigned to the
            /// Group.</param>
            public virtual CreateRequest Create(Google.Apis.CloudIdentity.v1.Data.Membership body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a Membership.</summary>
            public class CreateRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1.Data.Operation>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIdentity.v1.Data.Membership body, string parent)
                    : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Group
                /// to create Membership within. Format: `groups/{group_id}`, where `group_id` is the unique ID assigned
                /// to the Group.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudIdentity.v1.Data.Membership Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "create";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/memberships";

                /// <summary>Initializes Create parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^groups/[^/]+$",
                        });
                }

            }

            /// <summary>Deletes a Membership.</summary>
            /// <param name="name">Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Membership
            /// to be deleted. Format: `groups/{group_id}/memberships/{member_id}`, where `group_id` is the unique ID assigned to
            /// the Group to which Membership belongs to, and member_id is the unique ID assigned to the member.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a Membership.</summary>
            public class DeleteRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1.Data.Operation>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                    : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the
                /// Membership to be deleted. Format: `groups/{group_id}/memberships/{member_id}`, where `group_id` is
                /// the unique ID assigned to the Group to which Membership belongs to, and member_id is the unique ID
                /// assigned to the member.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^groups/[^/]+/memberships/[^/]+$",
                        });
                }

            }

            /// <summary>Retrieves a Membership.</summary>
            /// <param name="name">Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Membership
            /// to be retrieved. Format: `groups/{group_id}/memberships/{member_id}`, where `group_id` is the unique id assigned to
            /// the Group to which Membership belongs to, and `member_id` is the unique ID assigned to the member.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Retrieves a Membership.</summary>
            public class GetRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1.Data.Membership>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name)
                    : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the
                /// Membership to be retrieved. Format: `groups/{group_id}/memberships/{member_id}`, where `group_id` is
                /// the unique id assigned to the Group to which Membership belongs to, and `member_id` is the unique ID
                /// assigned to the member.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^groups/[^/]+/memberships/[^/]+$",
                        });
                }

            }

            /// <summary>Lists Memberships within a Group.</summary>
            /// <param name="parent">Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Group to
            /// list Memberships within. Format: `groups/{group_id}`, where `group_id` is the unique ID assigned to the
            /// Group.</param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists Memberships within a Group.</summary>
            public class ListRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1.Data.ListMembershipsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent)
                    : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Group
                /// to list Memberships within. Format: `groups/{group_id}`, where `group_id` is the unique ID assigned
                /// to the Group.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The default page size is 200 (max 1000) for the BASIC view, and 50 (max 500) for the FULL
                /// view.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The next_page_token value returned from a previous list request, if any.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Membership resource view to be returned. Defaults to View.BASIC.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Membership resource view to be returned. Defaults to View.BASIC.</summary>
                public enum ViewEnum
                {
                    /// <summary>Default. Should not be used.</summary>
                    [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                    VIEWUNSPECIFIED,
                    /// <summary>Server responses only include basic information.</summary>
                    [Google.Apis.Util.StringValueAttribute("BASIC")]
                    BASIC,
                    /// <summary>Full representation of the resource.</summary>
                    [Google.Apis.Util.StringValueAttribute("FULL")]
                    FULL,
                }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/memberships";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^groups/[^/]+$",
                        });
                    RequestParameters.Add(
                        "pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
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
                        "view", new Google.Apis.Discovery.Parameter
                        {
                            Name = "view",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Looks up [resource name](https://cloud.google.com/apis/design/resource_names) of a Membership
            /// within a Group by member's EntityKey.</summary>
            /// <param name="parent">Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Group to
            /// lookup Membership within. Format: `groups/{group_id}`, where `group_id` is the unique ID assigned to the
            /// Group.</param>
            public virtual LookupRequest Lookup(string parent)
            {
                return new LookupRequest(service, parent);
            }

            /// <summary>Looks up [resource name](https://cloud.google.com/apis/design/resource_names) of a Membership
            /// within a Group by member's EntityKey.</summary>
            public class LookupRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1.Data.LookupMembershipNameResponse>
            {
                /// <summary>Constructs a new Lookup request.</summary>
                public LookupRequest(Google.Apis.Services.IClientService service, string parent)
                    : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }


                /// <summary>Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Group
                /// to lookup Membership within. Format: `groups/{group_id}`, where `group_id` is the unique ID assigned
                /// to the Group.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>The ID of the entity within the given namespace. The ID must be unique within its
                /// namespace.</summary>
                [Google.Apis.Util.RequestParameterAttribute("memberKey.id", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string MemberKeyId { get; set; }

                /// <summary>Namespaces provide isolation for IDs, so an ID only needs to be unique within its
                /// namespace. Namespaces are currently only created as part of IdentitySource creation from Admin
                /// Console. A namespace `"identitysources/{identity_source_id}"` is created corresponding to every
                /// Identity Source `identity_source_id`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("memberKey.namespace", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string MemberKeyNamespace { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "lookup";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/memberships:lookup";

                /// <summary>Initializes Lookup parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^groups/[^/]+$",
                        });
                    RequestParameters.Add(
                        "memberKey.id", new Google.Apis.Discovery.Parameter
                        {
                            Name = "memberKey.id",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "memberKey.namespace", new Google.Apis.Discovery.Parameter
                        {
                            Name = "memberKey.namespace",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }
        }

        /// <summary>Creates a Group.</summary>
        /// <param name="body">The body of the request.</param>
        public virtual CreateRequest Create(Google.Apis.CloudIdentity.v1.Data.Group body)
        {
            return new CreateRequest(service, body);
        }

        /// <summary>Creates a Group.</summary>
        public class CreateRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1.Data.Operation>
        {
            /// <summary>Constructs a new Create request.</summary>
            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIdentity.v1.Data.Group body)
                : base(service)
            {
                Body = body;
                InitParameters();
            }



            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudIdentity.v1.Data.Group Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "create";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/groups";

            /// <summary>Initializes Create parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }

        /// <summary>Deletes a Group.</summary>
        /// <param name="name">Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Group in
        /// the format: `groups/{group_id}`, where `group_id` is the unique ID assigned to the Group.</param>
        public virtual DeleteRequest Delete(string name)
        {
            return new DeleteRequest(service, name);
        }

        /// <summary>Deletes a Group.</summary>
        public class DeleteRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1.Data.Operation>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Group in
            /// the format: `groups/{group_id}`, where `group_id` is the unique ID assigned to the Group.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^groups/[^/]+$",
                    });
            }

        }

        /// <summary>Retrieves a Group.</summary>
        /// <param name="name">Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Group in
        /// the format: `groups/{group_id}`, where `group_id` is the unique ID assigned to the Group.</param>
        public virtual GetRequest Get(string name)
        {
            return new GetRequest(service, name);
        }

        /// <summary>Retrieves a Group.</summary>
        public class GetRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1.Data.Group>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string name)
                : base(service)
            {
                Name = name;
                InitParameters();
            }


            /// <summary>Required. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Group in
            /// the format: `groups/{group_id}`, where `group_id` is the unique ID assigned to the Group.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^groups/[^/]+$",
                    });
            }

        }

        /// <summary>Lists groups within a customer or a domain.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists groups within a customer or a domain.</summary>
        public class ListRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1.Data.ListGroupsResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }


            /// <summary>The default page size is 200 (max 1000) for the BASIC view, and 50 (max 500) for the FULL
            /// view.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The next_page_token value returned from a previous list request, if any.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Required. Customer ID to list all groups from.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Parent { get; set; }

            /// <summary>Group resource view to be returned. Defaults to [View.BASIC]().</summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>Group resource view to be returned. Defaults to [View.BASIC]().</summary>
            public enum ViewEnum
            {
                /// <summary>Default. Should not be used.</summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                VIEWUNSPECIFIED,
                /// <summary>Server responses only include basic information.</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC,
                /// <summary>Full representation of the resource.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/groups";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
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
                    "parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "view", new Google.Apis.Discovery.Parameter
                    {
                        Name = "view",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Looks up [resource name](https://cloud.google.com/apis/design/resource_names) of a Group by its
        /// EntityKey.</summary>
        public virtual LookupRequest Lookup()
        {
            return new LookupRequest(service);
        }

        /// <summary>Looks up [resource name](https://cloud.google.com/apis/design/resource_names) of a Group by its
        /// EntityKey.</summary>
        public class LookupRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1.Data.LookupGroupNameResponse>
        {
            /// <summary>Constructs a new Lookup request.</summary>
            public LookupRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }


            /// <summary>The ID of the entity within the given namespace. The ID must be unique within its
            /// namespace.</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey.id", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string GroupKeyId { get; set; }

            /// <summary>Namespaces provide isolation for IDs, so an ID only needs to be unique within its namespace.
            /// Namespaces are currently only created as part of IdentitySource creation from Admin Console. A namespace
            /// `"identitysources/{identity_source_id}"` is created corresponding to every Identity Source
            /// `identity_source_id`.</summary>
            [Google.Apis.Util.RequestParameterAttribute("groupKey.namespace", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string GroupKeyNamespace { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "lookup";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/groups:lookup";

            /// <summary>Initializes Lookup parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "groupKey.id", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupKey.id",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "groupKey.namespace", new Google.Apis.Discovery.Parameter
                    {
                        Name = "groupKey.namespace",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Updates a Group.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">Output only. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Group in
        /// the format: `groups/{group_id}`, where group_id is the unique ID assigned to the Group. Must be left blank while
        /// creating a Group.</param>
        public virtual PatchRequest Patch(Google.Apis.CloudIdentity.v1.Data.Group body, string name)
        {
            return new PatchRequest(service, body, name);
        }

        /// <summary>Updates a Group.</summary>
        public class PatchRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1.Data.Operation>
        {
            /// <summary>Constructs a new Patch request.</summary>
            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIdentity.v1.Data.Group body, string name)
                : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }


            /// <summary>Output only. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Group
            /// in the format: `groups/{group_id}`, where group_id is the unique ID assigned to the Group. Must be left
            /// blank while creating a Group.</summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Required. Editable fields: `display_name`, `description`</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudIdentity.v1.Data.Group Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "patch";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes Patch parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^groups/[^/]+$",
                    });
                RequestParameters.Add(
                    "updateMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "updateMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Searches for Groups.</summary>
        public virtual SearchRequest Search()
        {
            return new SearchRequest(service);
        }

        /// <summary>Searches for Groups.</summary>
        public class SearchRequest : CloudIdentityBaseServiceRequest<Google.Apis.CloudIdentity.v1.Data.SearchGroupsResponse>
        {
            /// <summary>Constructs a new Search request.</summary>
            public SearchRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }


            /// <summary>The default page size is 200 (max 1000) for the BASIC view, and 50 (max 500) for the FULL
            /// view.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<int> PageSize { get; set; }

            /// <summary>The next_page_token value returned from a previous search request, if any.</summary>
            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string PageToken { get; set; }

            /// <summary>Required. `Required`. Query string for performing search on groups. Users can search on parent
            /// and label attributes of groups. EXACT match ('==') is supported on parent, and CONTAINS match ('in') is
            /// supported on labels.</summary>
            [Google.Apis.Util.RequestParameterAttribute("query", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string Query { get; set; }

            /// <summary>Group resource view to be returned. Defaults to [View.BASIC]().</summary>
            [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<ViewEnum> View { get; set; }

            /// <summary>Group resource view to be returned. Defaults to [View.BASIC]().</summary>
            public enum ViewEnum
            {
                /// <summary>Default. Should not be used.</summary>
                [Google.Apis.Util.StringValueAttribute("VIEW_UNSPECIFIED")]
                VIEWUNSPECIFIED,
                /// <summary>Server responses only include basic information.</summary>
                [Google.Apis.Util.StringValueAttribute("BASIC")]
                BASIC,
                /// <summary>Full representation of the resource.</summary>
                [Google.Apis.Util.StringValueAttribute("FULL")]
                FULL,
            }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "search";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1/groups:search";

            /// <summary>Initializes Search parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "pageSize", new Google.Apis.Discovery.Parameter
                    {
                        Name = "pageSize",
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
                    "view", new Google.Apis.Discovery.Parameter
                    {
                        Name = "view",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.CloudIdentity.v1.Data
{    

    /// <summary>Resource representing the Android specific attributes of a Device.</summary>
    public class AndroidAttributes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether applications from unknown sources can be installed on device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledUnknownSources")]
        public virtual System.Nullable<bool> EnabledUnknownSources { get; set; } 

        /// <summary>Whether this account is on an owner/primary profile. For phones, only true for owner profiles.
        /// Android 4+ devices can have secondary or restricted user profiles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerProfileAccount")]
        public virtual System.Nullable<bool> OwnerProfileAccount { get; set; } 

        /// <summary>Ownership privileges on device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownershipPrivilege")]
        public virtual string OwnershipPrivilege { get; set; } 

        /// <summary>Whether device supports Android work profiles. If false, this service will not block access to corp
        /// data even if an administrator turns on the "Enforce Work Profile" policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("supportsWorkProfile")]
        public virtual System.Nullable<bool> SupportsWorkProfile { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for approving the device to access user data.</summary>
    public class ApproveDeviceUserResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resultant DeviceUser object for the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceUser")]
        public virtual DeviceUser DeviceUser { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for blocking the device from accessing user data.</summary>
    public class BlockDeviceUserResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resultant DeviceUser object for the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceUser")]
        public virtual DeviceUser DeviceUser { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for cancelling an unfinished device wipe.</summary>
    public class CancelWipeDeviceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resultant Device object for the action. Note that asset tags will not be returned in the device
        /// object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual Device Device { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for cancelling an unfinished user account wipe.</summary>
    public class CancelWipeDeviceUserResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resultant DeviceUser object for the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceUser")]
        public virtual DeviceUser DeviceUser { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the state associated with an API client calling the Devices API. Resource representing
    /// ClientState and supports updates from API users</summary>
    public class ClientState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The caller can specify asset tags for this resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetTags")]
        public virtual System.Collections.Generic.IList<string> AssetTags { get; set; } 

        /// <summary>The compliance state of the resource as specified by the API client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("complianceState")]
        public virtual string ComplianceState { get; set; } 

        /// <summary>Output only. The time the client state data was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>This field may be used to store a unique identifier for the API resource within which these
        /// CustomAttributes are a field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customId")]
        public virtual string CustomId { get; set; } 

        /// <summary>The token that needs to be passed back for concurrency control in updates. Token needs to be passed
        /// back in UpdateRequest</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>The Health score of the resource</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("healthScore")]
        public virtual string HealthScore { get; set; } 

        /// <summary>The map of key-value attributes stored by callers specific to a device. The total serialized length
        /// of this map may not exceed 10KB. No limit is placed on the number of attributes in a map.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("keyValuePairs")]
        public virtual System.Collections.Generic.IDictionary<string,CustomAttributeValue> KeyValuePairs { get; set; } 

        /// <summary>Output only. The time the client state data was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastUpdateTime")]
        public virtual object LastUpdateTime { get; set; } 

        /// <summary>The management state of the resource as specified by the API client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managed")]
        public virtual string Managed { get; set; } 

        /// <summary>Output only. [Resource name](https://cloud.google.com/apis/design/resource_names) of the
        /// ClientState in format: `devices/{device_id}/deviceUsers/{device_user_id}/clientState/{partner_id}`, where
        /// partner_id corresponds to the partner storing the data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. The owner of the ClientState</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerType")]
        public virtual string OwnerType { get; set; } 

        /// <summary>A descriptive cause of the health score.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scoreReason")]
        public virtual string ScoreReason { get; set; } 

    }    

    /// <summary>Additional custom attribute values may be one of these types</summary>
    public class CustomAttributeValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents a boolean value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("boolValue")]
        public virtual System.Nullable<bool> BoolValue { get; set; } 

        /// <summary>Represents a double value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numberValue")]
        public virtual System.Nullable<double> NumberValue { get; set; } 

        /// <summary>Represents a string value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stringValue")]
        public virtual string StringValue { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A Device within the Cloud Identity Devices API. Represents a Device known to Google Cloud, independent
    /// of the device ownership, type, and whether it is assigned or in use by a user.</summary>
    public class Device : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Attributes specific to Android devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("androidSpecificAttributes")]
        public virtual AndroidAttributes AndroidSpecificAttributes { get; set; } 

        /// <summary>Asset tag of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetTag")]
        public virtual string AssetTag { get; set; } 

        /// <summary>Output only. Baseband version of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basebandVersion")]
        public virtual string BasebandVersion { get; set; } 

        /// <summary>Output only. Device bootloader version. Example: 0.6.7.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bootloaderVersion")]
        public virtual string BootloaderVersion { get; set; } 

        /// <summary>Output only. Device brand. Example: Samsung.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("brand")]
        public virtual string Brand { get; set; } 

        /// <summary>Output only. Build number of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buildNumber")]
        public virtual string BuildNumber { get; set; } 

        /// <summary>Output only. Represents whether the Device is compromised.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compromisedState")]
        public virtual string CompromisedState { get; set; } 

        /// <summary>Output only. When the Company-Owned device was imported. This field is empty for BYOD
        /// devices.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>Output only. Type of device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceType")]
        public virtual string DeviceType { get; set; } 

        /// <summary>Output only. Whether developer options is enabled on device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledDeveloperOptions")]
        public virtual System.Nullable<bool> EnabledDeveloperOptions { get; set; } 

        /// <summary>Output only. Whether USB debugging is enabled on device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledUsbDebugging")]
        public virtual System.Nullable<bool> EnabledUsbDebugging { get; set; } 

        /// <summary>Output only. Device encryption state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("encryptionState")]
        public virtual string EncryptionState { get; set; } 

        /// <summary>Output only. IMEI number of device if GSM device; empty otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imei")]
        public virtual string Imei { get; set; } 

        /// <summary>Output only. Kernel version of the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kernelVersion")]
        public virtual string KernelVersion { get; set; } 

        /// <summary>Most recent time when device synced with this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSyncTime")]
        public virtual object LastSyncTime { get; set; } 

        /// <summary>Output only. Management state of the device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementState")]
        public virtual string ManagementState { get; set; } 

        /// <summary>Output only. Device manufacturer. Example: Motorola.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("manufacturer")]
        public virtual string Manufacturer { get; set; } 

        /// <summary>Output only. MEID number of device if CDMA device; empty otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("meid")]
        public virtual string Meid { get; set; } 

        /// <summary>Output only. Model name of device. Example: Pixel 3.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; } 

        /// <summary>Output only. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Device in
        /// format: `devices/{device_id}`, where device_id is the unique id assigned to the Device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. Mobile or network operator of device, if available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("networkOperator")]
        public virtual string NetworkOperator { get; set; } 

        /// <summary>Output only. OS version of the device. Example: Android 8.1.0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("osVersion")]
        public virtual string OsVersion { get; set; } 

        /// <summary>Output only. Domain name for Google accounts on device. Type for other accounts on device. On
        /// Android, will only be populated if |ownership_privilege| is |PROFILE_OWNER| or |DEVICE_OWNER|. Does not
        /// include the account signed in to the device policy app if that account's domain has only one account.
        /// Examples: "com.example", "xyz.com".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("otherAccounts")]
        public virtual System.Collections.Generic.IList<string> OtherAccounts { get; set; } 

        /// <summary>Output only. Whether the device is owned by the company or an individual</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerType")]
        public virtual string OwnerType { get; set; } 

        /// <summary>Output only. OS release version. Example: 6.0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("releaseVersion")]
        public virtual string ReleaseVersion { get; set; } 

        /// <summary>Output only. OS security patch update time on device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityPatchTime")]
        public virtual object SecurityPatchTime { get; set; } 

        /// <summary>Serial Number of device. Example: HT82V1A01076.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serialNumber")]
        public virtual string SerialNumber { get; set; } 

        /// <summary>WiFi MAC addresses of device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("wifiMacAddresses")]
        public virtual System.Collections.Generic.IList<string> WifiMacAddresses { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a user's use of a Device in the Cloud Identity Devices API. A DeviceUser is a resource
    /// representing a user's use of a Device</summary>
    public class DeviceUser : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Compromised State of the DeviceUser object</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compromisedState")]
        public virtual string CompromisedState { get; set; } 

        /// <summary>When the user first signed in to the device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>Output only. Most recent time when user registered with this service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("firstSyncTime")]
        public virtual object FirstSyncTime { get; set; } 

        /// <summary>Output only. Default locale used on device, in IETF BCP-47 format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; } 

        /// <summary>Output only. Last time when user synced with policies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSyncTime")]
        public virtual object LastSyncTime { get; set; } 

        /// <summary>Output only. Management state of the user on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("managementState")]
        public virtual string ManagementState { get; set; } 

        /// <summary>Output only. [Resource name](https://cloud.google.com/apis/design/resource_names) of the DeviceUser
        /// in format: `devices/{device_id}/deviceUsers/{user_id}`, where user_id is the ID of the user associated with
        /// the user session.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Password state of the DeviceUser object</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("passwordState")]
        public virtual string PasswordState { get; set; } 

        /// <summary>Output only. User agent on the device for this specific user</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; } 

        /// <summary>Email address of the user registered on the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userEmail")]
        public virtual string UserEmail { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An EntityKey uniquely identifies an Entity. Namespaces are used to provide isolation for IDs. A single
    /// ID can be reused across namespaces but the combination of a namespace and an ID must be unique.</summary>
    public class EntityKey : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ID of the entity within the given namespace. The ID must be unique within its
        /// namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>Namespaces provide isolation for IDs, so an ID only needs to be unique within its namespace.
        /// Namespaces are currently only created as part of IdentitySource creation from Admin Console. A namespace
        /// `"identitysources/{identity_source_id}"` is created corresponding to every Identity Source
        /// `identity_source_id`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("namespace")]
        public virtual string Namespace__ { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Resource representing a Group.</summary>
    public class Group : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The time when the Group was created. Output only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>An extended description to help users determine the purpose of a Group. For example, you can
        /// include information about who should join the Group, the types of messages to send to the Group, links to
        /// FAQs about the Group, or related Groups. Maximum length is 4,096 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>The Group's display name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Required. Immutable. EntityKey of the Group. Must be set when creating a Group, read-only
        /// afterwards.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupKey")]
        public virtual EntityKey GroupKey { get; set; } 

        /// <summary>Required. `Required`. Labels for Group resource. For creating Groups under a namespace, set label
        /// key to 'labels/system/groups/external' and label value as empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string,string> Labels { get; set; } 

        /// <summary>Output only. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Group in
        /// the format: `groups/{group_id}`, where group_id is the unique ID assigned to the Group. Must be left blank
        /// while creating a Group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Required. Immutable. The entity under which this Group resides in Cloud Identity resource
        /// hierarchy. Must be set when creating a Group, read-only afterwards. Currently allowed types:
        /// `identitysources`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; } 

        /// <summary>Output only. The time when the Group was last updated. Output only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for ListGroups operation.</summary>
    public class ListGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Groups returned in response to list request. The results are not sorted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groups")]
        public virtual System.Collections.Generic.IList<Group> Groups { get; set; } 

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results available for
        /// listing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ListMembershipsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Memberships.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memberships")]
        public virtual System.Collections.Generic.IList<Membership> Memberships { get; set; } 

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results available for
        /// listing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LookupGroupNameResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Resource name](https://cloud.google.com/apis/design/resource_names) of the Group in the format:
        /// `groups/{group_id}`, where `group_id` is the unique ID assigned to the Group.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class LookupMembershipNameResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Resource name](https://cloud.google.com/apis/design/resource_names) of the Membership being looked
        /// up. Format: `groups/{group_id}/memberships/{member_id}`, where `group_id` is the unique ID assigned to the
        /// Group to which Membership belongs to, and `member_id` is the unique ID assigned to the member.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Resource representing a Membership within a Group</summary>
    public class Membership : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Creation timestamp of the Membership. Output only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>Output only. [Resource name](https://cloud.google.com/apis/design/resource_names) of the Membership
        /// in the format: `groups/{group_id}/memberships/{member_id}`, where group_id is the unique ID assigned to the
        /// Group to which Membership belongs to, and member_id is the unique ID assigned to the member Must be left
        /// blank while creating a Membership.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Required. Immutable. EntityKey of the entity to be added as the member. Must be set while creating
        /// a Membership, read-only afterwards. Currently allowed entity types: `Users`, `Groups`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("preferredMemberKey")]
        public virtual EntityKey PreferredMemberKey { get; set; } 

        /// <summary>Roles for a member within the Group. Currently supported MembershipRoles: `"MEMBER"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<MembershipRole> Roles { get; set; } 

        /// <summary>Output only. Last updated timestamp of the Membership. Output only.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Resource representing a role within a Membership.</summary>
    public class MembershipRole : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>MembershipRole in string format. Currently supported MembershipRoles: `"MEMBER"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class Operation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the value is `false`, it means the operation is still in progress. If `true`, the operation is
        /// completed, and either `error` or `response` is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; } 

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Status Error { get; set; } 

        /// <summary>Service-specific metadata associated with the operation. It typically contains progress information
        /// and common metadata such as create time. Some services might not provide such metadata. Any method that
        /// returns a long-running operation should document the metadata type, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string,object> Metadata { get; set; } 

        /// <summary>The server-assigned name, which is only unique within the same service that originally returns it.
        /// If you use the default HTTP mapping, the `name` should be a resource name ending with
        /// `operations/{unique_id}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The normal response of the operation in case of success. If the original method returns no data on
        /// success, such as `Delete`, the response is `google.protobuf.Empty`. If the original method is standard
        /// `Get`/`Create`/`Update`, the response should be the resource. For other methods, the response should have
        /// the type `XxxResponse`, where `Xxx` is the original method name. For example, if the original method name is
        /// `TakeSnapshot()`, the inferred response type is `TakeSnapshotResponse`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("response")]
        public virtual System.Collections.Generic.IDictionary<string,object> Response { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class SearchGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of Groups satisfying the search query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groups")]
        public virtual System.Collections.Generic.IList<Group> Groups { get; set; } 

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results available for
        /// specified query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The `Status` type defines a logical error model that is suitable for different programming
    /// environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status`
    /// message contains three pieces of data: error code, error message, and error details. You can find out more about
    /// this error model and how to work with it in the [API Design
    /// Guide](https://cloud.google.com/apis/design/errors).</summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; } 

        /// <summary>A list of messages that carry the error details. There is a common set of message types for APIs to
        /// use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string,object>> Details { get; set; } 

        /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should
        /// be localized and sent in the google.rpc.Status.details field, or localized by the client.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for wiping all data on the device.</summary>
    public class WipeDeviceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resultant Device object for the action. Note that asset tags will not be returned in the device
        /// object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("device")]
        public virtual Device Device { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for wiping the user's account from the device.</summary>
    public class WipeDeviceUserResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Resultant DeviceUser object for the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceUser")]
        public virtual DeviceUser DeviceUser { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
