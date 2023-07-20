// Copyright 2023 Google LLC
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

namespace Google.Apis.SecurityCommandCenter.v1
{
    /// <summary>The SecurityCommandCenter Service.</summary>
    public class SecurityCommandCenterService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SecurityCommandCenterService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SecurityCommandCenterService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Folders = new FoldersResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "securitycenter";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri => BaseUriOverride ?? "https://securitycenter.googleapis.com/";

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://securitycenter.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";

        /// <summary>Available OAuth 2.0 scopes for use with the Security Command Center API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Security Command Center API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Folders resource.</summary>
        public virtual FoldersResource Folders { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for SecurityCommandCenter requests.</summary>
    public abstract class SecurityCommandCenterBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SecurityCommandCenterBaseServiceRequest instance.</summary>
        protected SecurityCommandCenterBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes SecurityCommandCenter parameter list.</summary>
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

    /// <summary>The "folders" collection of methods.</summary>
    public class FoldersResource
    {
        private const string Resource = "folders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FoldersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Assets = new AssetsResource(service);
            BigQueryExports = new BigQueryExportsResource(service);
            Findings = new FindingsResource(service);
            MuteConfigs = new MuteConfigsResource(service);
            NotificationConfigs = new NotificationConfigsResource(service);
            SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettingsResource(service);
            Sources = new SourcesResource(service);
        }

        /// <summary>Gets the Assets resource.</summary>
        public virtual AssetsResource Assets { get; }

        /// <summary>The "assets" collection of methods.</summary>
        public class AssetsResource
        {
            private const string Resource = "assets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AssetsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Filters an organization's assets and groups them by their specified properties.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the parent to group the assets by. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual GroupRequest Group(Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest body, string parent)
            {
                return new GroupRequest(service, body, parent);
            }

            /// <summary>Filters an organization's assets and groups them by their specified properties.</summary>
            public class GroupRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsResponse>
            {
                /// <summary>Constructs a new Group request.</summary>
                public GroupRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the parent to group the assets by. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "group";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/assets:group";

                /// <summary>Initializes Group parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+$",
                    });
                }
            }

            /// <summary>Lists an organization's assets.</summary>
            /// <param name="parent">
            /// Required. The name of the parent resource that contains the assets. The value that you can specify on
            /// parent depends on the method in which you specify parent. You can specify one of the following values:
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists an organization's assets.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListAssetsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the parent resource that contains the assets. The value that you can specify
                /// on parent depends on the method in which you specify parent. You can specify one of the following
                /// values: "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// When compare_duration is set, the ListAssetsResult's "state_change" attribute is updated to indicate
                /// whether the asset was added, removed, or remained present during the compare_duration period of time
                /// that precedes the read_time. This is the time between (read_time - compare_duration) and read_time.
                /// The state_change value is derived based on the presence of the asset at the two points in time.
                /// Intermediate state changes between the two times don't affect the result. For example, the results
                /// aren't affected if the asset is removed and re-created again. Possible "state_change" values when
                /// compare_duration is specified: * "ADDED": indicates that the asset was not present at the start of
                /// compare_duration, but present at read_time. * "REMOVED": indicates that the asset was present at the
                /// start of compare_duration, but not present at read_time. * "ACTIVE": indicates that the asset was
                /// present at both the start and the end of the time period defined by compare_duration and read_time.
                /// If compare_duration is not specified, then the only possible state_change is "UNUSED", which will be
                /// the state_change set for all assets present at read_time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("compareDuration", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object CompareDuration { get; set; }

                /// <summary>
                /// A field mask to specify the ListAssetsResult fields to be listed in the response. An empty field
                /// mask will list all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object FieldMask { get; set; }

                /// <summary>
                /// Expression that defines the filter to apply across assets. The expression is a list of zero or more
                /// restrictions combined via logical operators `AND` and `OR`. Parentheses are supported, and `OR` has
                /// higher precedence than `AND`. Restrictions have the form ` ` and may have a `-` character in front
                /// of them to indicate negation. The fields map to those defined in the Asset resource. Examples
                /// include: * name * security_center_properties.resource_name * resource_properties.a_property *
                /// security_marks.marks.marka The supported operators are: * `=` for all value types. * `&amp;gt;`,
                /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for integer values. * `:`, meaning substring matching, for
                /// strings. The supported value types are: * string literals in quotes. * integer literals without
                /// quotes. * boolean literals `true` and `false` without quotes. The following are the allowed field
                /// and operator combinations: * name: `=` * update_time: `=`, `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`,
                /// `&amp;lt;=` Usage: This should be milliseconds since epoch or an RFC3339 string. Examples:
                /// `update_time = "2019-06-10T16:07:18-07:00"` `update_time = 1560208038000` * create_time: `=`,
                /// `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be milliseconds since epoch or
                /// an RFC3339 string. Examples: `create_time = "2019-06-10T16:07:18-07:00"` `create_time =
                /// 1560208038000` * iam_policy.policy_blob: `=`, `:` * resource_properties: `=`, `:`, `&amp;gt;`,
                /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` * security_marks.marks: `=`, `:` *
                /// security_center_properties.resource_name: `=`, `:` *
                /// security_center_properties.resource_display_name: `=`, `:` *
                /// security_center_properties.resource_type: `=`, `:` * security_center_properties.resource_parent:
                /// `=`, `:` * security_center_properties.resource_parent_display_name: `=`, `:` *
                /// security_center_properties.resource_project: `=`, `:` *
                /// security_center_properties.resource_project_display_name: `=`, `:` *
                /// security_center_properties.resource_owners: `=`, `:` For example, `resource_properties.size = 100`
                /// is a valid filter string. Use a partial match on the empty string to filter based on a property
                /// existing: `resource_properties.my_property : ""` Use a negated partial match on the empty string to
                /// filter based on a property not existing: `-resource_properties.my_property : ""`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Expression that defines what fields and order to use for sorting. The string value should follow SQL
                /// syntax: comma separated list of fields. For example: "name,resource_properties.a_property". The
                /// default sorting order is ascending. To specify descending order for a field, a suffix " desc" should
                /// be appended to the field name. For example: "name desc,resource_properties.a_property". Redundant
                /// space characters in the syntax are insignificant. "name desc,resource_properties.a_property" and "
                /// name desc , resource_properties.a_property " are equivalent. The following fields are supported:
                /// name update_time resource_properties security_marks.marks security_center_properties.resource_name
                /// security_center_properties.resource_display_name security_center_properties.resource_parent
                /// security_center_properties.resource_parent_display_name security_center_properties.resource_project
                /// security_center_properties.resource_project_display_name security_center_properties.resource_type
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum
                /// is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListAssetsResponse`; indicates that this is a continuation of a
                /// prior `ListAssets` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Time used as a reference point when filtering assets. The filter is limited to assets existing at
                /// the supplied time and their values are those at that specific time. Absence of this field will
                /// default to the API's version of NOW.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object ReadTime { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/assets";

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
                        Pattern = @"^folders/[^/]+$",
                    });
                    RequestParameters.Add("compareDuration", new Google.Apis.Discovery.Parameter
                    {
                        Name = "compareDuration",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fieldMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
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
                    RequestParameters.Add("readTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "readTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates security marks.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The relative resource name of the SecurityMarks. See:
            /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
            /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
            /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
            /// </param>
            public virtual UpdateSecurityMarksRequest UpdateSecurityMarks(Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name)
            {
                return new UpdateSecurityMarksRequest(service, body, name);
            }

            /// <summary>Updates security marks.</summary>
            public class UpdateSecurityMarksRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks>
            {
                /// <summary>Constructs a new UpdateSecurityMarks request.</summary>
                public UpdateSecurityMarksRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The relative resource name of the SecurityMarks. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The time at which the updated SecurityMarks take effect. If not set uses current server time.
                /// Updates will be applied to the SecurityMarks that are active immediately preceding this time. Must
                /// be earlier or equal to the server time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object StartTime { get; set; }

                /// <summary>
                /// The FieldMask to use when updating the security marks resource. The field mask must not contain
                /// duplicate fields. If empty or set to "marks", all marks will be replaced. Individual marks can be
                /// updated using "marks.".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateSecurityMarks";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes UpdateSecurityMarks parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/assets/[^/]+/securityMarks$",
                    });
                    RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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

        /// <summary>Gets the BigQueryExports resource.</summary>
        public virtual BigQueryExportsResource BigQueryExports { get; }

        /// <summary>The "bigQueryExports" collection of methods.</summary>
        public class BigQueryExportsResource
        {
            private const string Resource = "bigQueryExports";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BigQueryExportsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a BigQuery export.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the parent resource of the new BigQuery export. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a BigQuery export.</summary>
            public class CreateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the parent resource of the new BigQuery export. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. Unique identifier provided by the client within the parent scope. It must consist of only
                /// lowercase letters, numbers, and hyphens, must start with a letter, must end with either a letter or
                /// a number, and must be 63 characters or less.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("bigQueryExportId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string BigQueryExportId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/bigQueryExports";

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
                        Pattern = @"^folders/[^/]+$",
                    });
                    RequestParameters.Add("bigQueryExportId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "bigQueryExportId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes an existing BigQuery export.</summary>
            /// <param name="name">
            /// Required. The name of the BigQuery export to delete. Its format is
            /// organizations/{organization}/bigQueryExports/{export_id}, folders/{folder}/bigQueryExports/{export_id},
            /// or projects/{project}/bigQueryExports/{export_id}
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes an existing BigQuery export.</summary>
            public class DeleteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the BigQuery export to delete. Its format is
                /// organizations/{organization}/bigQueryExports/{export_id},
                /// folders/{folder}/bigQueryExports/{export_id}, or projects/{project}/bigQueryExports/{export_id}
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
                        Pattern = @"^folders/[^/]+/bigQueryExports/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a BigQuery export.</summary>
            /// <param name="name">
            /// Required. Name of the BigQuery export to retrieve. Its format is
            /// organizations/{organization}/bigQueryExports/{export_id}, folders/{folder}/bigQueryExports/{export_id},
            /// or projects/{project}/bigQueryExports/{export_id}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a BigQuery export.</summary>
            public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the BigQuery export to retrieve. Its format is
                /// organizations/{organization}/bigQueryExports/{export_id},
                /// folders/{folder}/bigQueryExports/{export_id}, or projects/{project}/bigQueryExports/{export_id}
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
                        Pattern = @"^folders/[^/]+/bigQueryExports/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists BigQuery exports. Note that when requesting BigQuery exports at a given level all exports under
            /// that level are also returned e.g. if requesting BigQuery exports under a folder, then all BigQuery
            /// exports immediately under the folder plus the ones created under the projects within the folder are
            /// returned.
            /// </summary>
            /// <param name="parent">
            /// Required. The parent, which owns the collection of BigQuery exports. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists BigQuery exports. Note that when requesting BigQuery exports at a given level all exports under
            /// that level are also returned e.g. if requesting BigQuery exports under a folder, then all BigQuery
            /// exports immediately under the folder plus the ones created under the projects within the folder are
            /// returned.
            /// </summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListBigQueryExportsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent, which owns the collection of BigQuery exports. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of configs to return. The service may return fewer than this value. If
                /// unspecified, at most 10 configs will be returned. The maximum value is 1000; values above 1000 will
                /// be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListBigQueryExports` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListBigQueryExports` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/bigQueryExports";

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
                        Pattern = @"^folders/[^/]+$",
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

            /// <summary>Updates a BigQuery export.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The relative resource name of this export. See:
            /// https://cloud.google.com/apis/design/resource_names#relative_resource_name. Example format:
            /// "organizations/{organization_id}/bigQueryExports/{export_id}" Example format:
            /// "folders/{folder_id}/bigQueryExports/{export_id}" Example format:
            /// "projects/{project_id}/bigQueryExports/{export_id}" This field is provided in responses, and is ignored
            /// when provided in create requests.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a BigQuery export.</summary>
            public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The relative resource name of this export. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name. Example format:
                /// "organizations/{organization_id}/bigQueryExports/{export_id}" Example format:
                /// "folders/{folder_id}/bigQueryExports/{export_id}" Example format:
                /// "projects/{project_id}/bigQueryExports/{export_id}" This field is provided in responses, and is
                /// ignored when provided in create requests.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The list of fields to be updated. If empty all mutable fields will be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport Body { get; set; }

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
                        Pattern = @"^folders/[^/]+/bigQueryExports/[^/]+$",
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

        /// <summary>Gets the Findings resource.</summary>
        public virtual FindingsResource Findings { get; }

        /// <summary>The "findings" collection of methods.</summary>
        public class FindingsResource
        {
            private const string Resource = "findings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public FindingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Kicks off an LRO to bulk mute findings for a parent based on a filter. The parent can be either an
            /// organization, folder or project. The findings matched by the filter will be muted after the LRO is done.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent, at which bulk action needs to be applied. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
            /// </param>
            public virtual BulkMuteRequest BulkMute(Google.Apis.SecurityCommandCenter.v1.Data.BulkMuteFindingsRequest body, string parent)
            {
                return new BulkMuteRequest(service, body, parent);
            }

            /// <summary>
            /// Kicks off an LRO to bulk mute findings for a parent based on a filter. The parent can be either an
            /// organization, folder or project. The findings matched by the filter will be muted after the LRO is done.
            /// </summary>
            public class BulkMuteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Operation>
            {
                /// <summary>Constructs a new BulkMute request.</summary>
                public BulkMuteRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.BulkMuteFindingsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent, at which bulk action needs to be applied. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.BulkMuteFindingsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "bulkMute";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/findings:bulkMute";

                /// <summary>Initializes BulkMute parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the MuteConfigs resource.</summary>
        public virtual MuteConfigsResource MuteConfigs { get; }

        /// <summary>The "muteConfigs" collection of methods.</summary>
        public class MuteConfigsResource
        {
            private const string Resource = "muteConfigs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MuteConfigsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a mute config.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name of the new mute configs's parent. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a mute config.</summary>
            public class CreateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the new mute configs's parent. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. Unique identifier provided by the client within the parent scope. It must consist of only
                /// lowercase letters, numbers, and hyphens, must start with a letter, must end with either a letter or
                /// a number, and must be 63 characters or less.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("muteConfigId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string MuteConfigId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/muteConfigs";

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
                        Pattern = @"^folders/[^/]+$",
                    });
                    RequestParameters.Add("muteConfigId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "muteConfigId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes an existing mute config.</summary>
            /// <param name="name">
            /// Required. Name of the mute config to delete. Its format is
            /// organizations/{organization}/muteConfigs/{config_id}, folders/{folder}/muteConfigs/{config_id}, or
            /// projects/{project}/muteConfigs/{config_id}
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes an existing mute config.</summary>
            public class DeleteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the mute config to delete. Its format is
                /// organizations/{organization}/muteConfigs/{config_id}, folders/{folder}/muteConfigs/{config_id}, or
                /// projects/{project}/muteConfigs/{config_id}
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
                        Pattern = @"^folders/[^/]+/muteConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a mute config.</summary>
            /// <param name="name">
            /// Required. Name of the mute config to retrieve. Its format is
            /// organizations/{organization}/muteConfigs/{config_id}, folders/{folder}/muteConfigs/{config_id}, or
            /// projects/{project}/muteConfigs/{config_id}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a mute config.</summary>
            public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the mute config to retrieve. Its format is
                /// organizations/{organization}/muteConfigs/{config_id}, folders/{folder}/muteConfigs/{config_id}, or
                /// projects/{project}/muteConfigs/{config_id}
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
                        Pattern = @"^folders/[^/]+/muteConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Lists mute configs.</summary>
            /// <param name="parent">
            /// Required. The parent, which owns the collection of mute configs. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists mute configs.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListMuteConfigsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent, which owns the collection of mute configs. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of configs to return. The service may return fewer than this value. If
                /// unspecified, at most 10 configs will be returned. The maximum value is 1000; values above 1000 will
                /// be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListMuteConfigs` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListMuteConfigs` must match the
                /// call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/muteConfigs";

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
                        Pattern = @"^folders/[^/]+$",
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

            /// <summary>Updates a mute config.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// This field will be ignored if provided on config creation. Format
            /// "organizations/{organization}/muteConfigs/{mute_config}" "folders/{folder}/muteConfigs/{mute_config}"
            /// "projects/{project}/muteConfigs/{mute_config}"
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a mute config.</summary>
            public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// This field will be ignored if provided on config creation. Format
                /// "organizations/{organization}/muteConfigs/{mute_config}"
                /// "folders/{folder}/muteConfigs/{mute_config}" "projects/{project}/muteConfigs/{mute_config}"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The list of fields to be updated. If empty all mutable fields will be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig Body { get; set; }

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
                        Pattern = @"^folders/[^/]+/muteConfigs/[^/]+$",
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

        /// <summary>Gets the NotificationConfigs resource.</summary>
        public virtual NotificationConfigsResource NotificationConfigs { get; }

        /// <summary>The "notificationConfigs" collection of methods.</summary>
        public class NotificationConfigsResource
        {
            private const string Resource = "notificationConfigs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public NotificationConfigsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a notification config.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name of the new notification config's parent. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a notification config.</summary>
            public class CreateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the new notification config's parent. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. Unique identifier provided by the client within the parent scope. It must be between 1 and
                /// 128 characters and contain alphanumeric characters, underscores, or hyphens only.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ConfigId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/notificationConfigs";

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
                        Pattern = @"^folders/[^/]+$",
                    });
                    RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "configId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes a notification config.</summary>
            /// <param name="name">
            /// Required. Name of the notification config to delete. Its format is
            /// "organizations/[organization_id]/notificationConfigs/[config_id]",
            /// "folders/[folder_id]/notificationConfigs/[config_id]", or
            /// "projects/[project_id]/notificationConfigs/[config_id]".
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a notification config.</summary>
            public class DeleteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the notification config to delete. Its format is
                /// "organizations/[organization_id]/notificationConfigs/[config_id]",
                /// "folders/[folder_id]/notificationConfigs/[config_id]", or
                /// "projects/[project_id]/notificationConfigs/[config_id]".
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
                        Pattern = @"^folders/[^/]+/notificationConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a notification config.</summary>
            /// <param name="name">
            /// Required. Name of the notification config to get. Its format is
            /// "organizations/[organization_id]/notificationConfigs/[config_id]",
            /// "folders/[folder_id]/notificationConfigs/[config_id]", or
            /// "projects/[project_id]/notificationConfigs/[config_id]".
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a notification config.</summary>
            public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the notification config to get. Its format is
                /// "organizations/[organization_id]/notificationConfigs/[config_id]",
                /// "folders/[folder_id]/notificationConfigs/[config_id]", or
                /// "projects/[project_id]/notificationConfigs/[config_id]".
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
                        Pattern = @"^folders/[^/]+/notificationConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Lists notification configs.</summary>
            /// <param name="parent">
            /// Required. The name of the parent in which to list the notification configurations. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists notification configs.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListNotificationConfigsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the parent in which to list the notification configurations. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum
                /// is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListNotificationConfigsResponse`; indicates that this is a
                /// continuation of a prior `ListNotificationConfigs` call, and that the system should return the next
                /// page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/notificationConfigs";

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
                        Pattern = @"^folders/[^/]+$",
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
            ///  Updates a notification config. The following update fields are allowed: description, pubsub_topic,
            /// streaming_config.filter
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The relative resource name of this notification config. See:
            /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
            /// "organizations/{organization_id}/notificationConfigs/notify_public_bucket",
            /// "folders/{folder_id}/notificationConfigs/notify_public_bucket", or
            /// "projects/{project_id}/notificationConfigs/notify_public_bucket".
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            ///  Updates a notification config. The following update fields are allowed: description, pubsub_topic,
            /// streaming_config.filter
            /// </summary>
            public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The relative resource name of this notification config. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                /// "organizations/{organization_id}/notificationConfigs/notify_public_bucket",
                /// "folders/{folder_id}/notificationConfigs/notify_public_bucket", or
                /// "projects/{project_id}/notificationConfigs/notify_public_bucket".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The FieldMask to use when updating the notification config. If empty all mutable fields will be
                /// updated.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig Body { get; set; }

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
                        Pattern = @"^folders/[^/]+/notificationConfigs/[^/]+$",
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

        /// <summary>Gets the SecurityHealthAnalyticsSettings resource.</summary>
        public virtual SecurityHealthAnalyticsSettingsResource SecurityHealthAnalyticsSettings { get; }

        /// <summary>The "securityHealthAnalyticsSettings" collection of methods.</summary>
        public class SecurityHealthAnalyticsSettingsResource
        {
            private const string Resource = "securityHealthAnalyticsSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SecurityHealthAnalyticsSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                CustomModules = new CustomModulesResource(service);
                EffectiveCustomModules = new EffectiveCustomModulesResource(service);
            }

            /// <summary>Gets the CustomModules resource.</summary>
            public virtual CustomModulesResource CustomModules { get; }

            /// <summary>The "customModules" collection of methods.</summary>
            public class CustomModulesResource
            {
                private const string Resource = "customModules";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CustomModulesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a resident SecurityHealthAnalyticsCustomModule at the scope of the given CRM parent, and
                /// also creates inherited SecurityHealthAnalyticsCustomModules for all CRM descendants of the given
                /// parent. These modules are enabled by default.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Resource name of the new custom module's parent. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings",
                /// "folders/{folder}/securityHealthAnalyticsSettings", or
                /// "projects/{project}/securityHealthAnalyticsSettings"
                /// </param>
                public virtual CreateRequest Create(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a resident SecurityHealthAnalyticsCustomModule at the scope of the given CRM parent, and
                /// also creates inherited SecurityHealthAnalyticsCustomModules for all CRM descendants of the given
                /// parent. These modules are enabled by default.
                /// </summary>
                public class CreateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the new custom module's parent. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings",
                    /// "folders/{folder}/securityHealthAnalyticsSettings", or
                    /// "projects/{project}/securityHealthAnalyticsSettings"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/customModules";

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
                            Pattern = @"^folders/[^/]+/securityHealthAnalyticsSettings$",
                        });
                    }
                }

                /// <summary>
                /// Deletes the specified SecurityHealthAnalyticsCustomModule and all of its descendants in the CRM
                /// hierarchy. This method is only supported for resident custom modules.
                /// </summary>
                /// <param name="name">
                /// Required. Name of the custom module to delete. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}",
                /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}"
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes the specified SecurityHealthAnalyticsCustomModule and all of its descendants in the CRM
                /// hierarchy. This method is only supported for resident custom modules.
                /// </summary>
                public class DeleteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the custom module to delete. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}",
                    /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                    /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}"
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
                            Pattern = @"^folders/[^/]+/securityHealthAnalyticsSettings/customModules/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieves a SecurityHealthAnalyticsCustomModule.</summary>
                /// <param name="name">
                /// Required. Name of the custom module to get. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}",
                /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}"
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Retrieves a SecurityHealthAnalyticsCustomModule.</summary>
                public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the custom module to get. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}",
                    /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                    /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}"
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
                            Pattern = @"^folders/[^/]+/securityHealthAnalyticsSettings/customModules/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns a list of all SecurityHealthAnalyticsCustomModules for the given parent. This includes
                /// resident modules defined at the scope of the parent, and inherited modules, inherited from CRM
                /// ancestors.
                /// </summary>
                /// <param name="parent">
                /// Required. Name of parent to list custom modules. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings",
                /// "folders/{folder}/securityHealthAnalyticsSettings", or
                /// "projects/{project}/securityHealthAnalyticsSettings"
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Returns a list of all SecurityHealthAnalyticsCustomModules for the given parent. This includes
                /// resident modules defined at the scope of the parent, and inherited modules, inherited from CRM
                /// ancestors.
                /// </summary>
                public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListSecurityHealthAnalyticsCustomModulesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of parent to list custom modules. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings",
                    /// "folders/{folder}/securityHealthAnalyticsSettings", or
                    /// "projects/{project}/securityHealthAnalyticsSettings"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of results to return in a single response. Default is 10, minimum is 1,
                    /// maximum is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The value returned by the last call indicating a continuation</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/customModules";

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
                            Pattern = @"^folders/[^/]+/securityHealthAnalyticsSettings$",
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
                /// Returns a list of all resident SecurityHealthAnalyticsCustomModules under the given CRM parent and
                /// all of the parent’s CRM descendants.
                /// </summary>
                /// <param name="parent">
                /// Required. Name of parent to list descendant custom modules. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings",
                /// "folders/{folder}/securityHealthAnalyticsSettings", or
                /// "projects/{project}/securityHealthAnalyticsSettings"
                /// </param>
                public virtual ListDescendantRequest ListDescendant(string parent)
                {
                    return new ListDescendantRequest(service, parent);
                }

                /// <summary>
                /// Returns a list of all resident SecurityHealthAnalyticsCustomModules under the given CRM parent and
                /// all of the parent’s CRM descendants.
                /// </summary>
                public class ListDescendantRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListDescendantSecurityHealthAnalyticsCustomModulesResponse>
                {
                    /// <summary>Constructs a new ListDescendant request.</summary>
                    public ListDescendantRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of parent to list descendant custom modules. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings",
                    /// "folders/{folder}/securityHealthAnalyticsSettings", or
                    /// "projects/{project}/securityHealthAnalyticsSettings"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of results to return in a single response. Default is 10, minimum is 1,
                    /// maximum is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The value returned by the last call indicating a continuation</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listDescendant";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/customModules:listDescendant";

                    /// <summary>Initializes ListDescendant parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^folders/[^/]+/securityHealthAnalyticsSettings$",
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
                /// Updates the SecurityHealthAnalyticsCustomModule under the given name based on the given update mask.
                /// Updating the enablement state is supported on both resident and inherited modules (though resident
                /// modules cannot have an enablement state of "inherited"). Updating the display name and custom config
                /// of a module is supported on resident modules only.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Immutable. The resource name of the custom module. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}" The id
                /// {customModule} is server-generated and is not user settable. It will be a numeric id containing 1-20
                /// digits.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the SecurityHealthAnalyticsCustomModule under the given name based on the given update mask.
                /// Updating the enablement state is supported on both resident and inherited modules (though resident
                /// modules cannot have an enablement state of "inherited"). Updating the display name and custom config
                /// of a module is supported on resident modules only.
                /// </summary>
                public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Immutable. The resource name of the custom module. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                    /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                    /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}" The id
                    /// {customModule} is server-generated and is not user settable. It will be a numeric id containing
                    /// 1-20 digits.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule Body { get; set; }

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
                            Pattern = @"^folders/[^/]+/securityHealthAnalyticsSettings/customModules/[^/]+$",
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

            /// <summary>Gets the EffectiveCustomModules resource.</summary>
            public virtual EffectiveCustomModulesResource EffectiveCustomModules { get; }

            /// <summary>The "effectiveCustomModules" collection of methods.</summary>
            public class EffectiveCustomModulesResource
            {
                private const string Resource = "effectiveCustomModules";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EffectiveCustomModulesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Retrieves an EffectiveSecurityHealthAnalyticsCustomModule.</summary>
                /// <param name="name">
                /// Required. Name of the effective custom module to get. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}",
                /// "folders/{folder}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}", or
                /// "projects/{project}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}"
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Retrieves an EffectiveSecurityHealthAnalyticsCustomModule.</summary>
                public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1EffectiveSecurityHealthAnalyticsCustomModule>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the effective custom module to get. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}",
                    /// "folders/{folder}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}", or
                    /// "projects/{project}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}"
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
                            Pattern = @"^folders/[^/]+/securityHealthAnalyticsSettings/effectiveCustomModules/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns a list of all EffectiveSecurityHealthAnalyticsCustomModules for the given parent. This
                /// includes resident modules defined at the scope of the parent, and inherited modules, inherited from
                /// CRM ancestors.
                /// </summary>
                /// <param name="parent">
                /// Required. Name of parent to list effective custom modules. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings",
                /// "folders/{folder}/securityHealthAnalyticsSettings", or
                /// "projects/{project}/securityHealthAnalyticsSettings"
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Returns a list of all EffectiveSecurityHealthAnalyticsCustomModules for the given parent. This
                /// includes resident modules defined at the scope of the parent, and inherited modules, inherited from
                /// CRM ancestors.
                /// </summary>
                public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListEffectiveSecurityHealthAnalyticsCustomModulesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of parent to list effective custom modules. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings",
                    /// "folders/{folder}/securityHealthAnalyticsSettings", or
                    /// "projects/{project}/securityHealthAnalyticsSettings"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of results to return in a single response. Default is 10, minimum is 1,
                    /// maximum is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The value returned by the last call indicating a continuation</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/effectiveCustomModules";

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
                            Pattern = @"^folders/[^/]+/securityHealthAnalyticsSettings$",
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
        }

        /// <summary>Gets the Sources resource.</summary>
        public virtual SourcesResource Sources { get; }

        /// <summary>The "sources" collection of methods.</summary>
        public class SourcesResource
        {
            private const string Resource = "sources";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SourcesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Findings = new FindingsResource(service);
            }

            /// <summary>Gets the Findings resource.</summary>
            public virtual FindingsResource Findings { get; }

            /// <summary>The "findings" collection of methods.</summary>
            public class FindingsResource
            {
                private const string Resource = "findings";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FindingsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    ExternalSystems = new ExternalSystemsResource(service);
                }

                /// <summary>Gets the ExternalSystems resource.</summary>
                public virtual ExternalSystemsResource ExternalSystems { get; }

                /// <summary>The "externalSystems" collection of methods.</summary>
                public class ExternalSystemsResource
                {
                    private const string Resource = "externalSystems";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ExternalSystemsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Updates external system. This is for a given finding.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Full resource name of the external system, for example:
                    /// "organizations/1234/sources/5678/findings/123456/externalSystems/jira",
                    /// "folders/1234/sources/5678/findings/123456/externalSystems/jira",
                    /// "projects/1234/sources/5678/findings/123456/externalSystems/jira"
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1ExternalSystem body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates external system. This is for a given finding.</summary>
                    public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1ExternalSystem>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1ExternalSystem body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Full resource name of the external system, for example:
                        /// "organizations/1234/sources/5678/findings/123456/externalSystems/jira",
                        /// "folders/1234/sources/5678/findings/123456/externalSystems/jira",
                        /// "projects/1234/sources/5678/findings/123456/externalSystems/jira"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// The FieldMask to use when updating the external system resource. If empty all mutable fields
                        /// will be updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1ExternalSystem Body { get; set; }

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
                                Pattern = @"^folders/[^/]+/sources/[^/]+/findings/[^/]+/externalSystems/[^/]+$",
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

                /// <summary>
                /// Filters an organization or source's findings and groups them by their specified properties. To group
                /// across all sources provide a `-` as the source id. Example:
                /// /v1/organizations/{organization_id}/sources/-/findings, /v1/folders/{folder_id}/sources/-/findings,
                /// /v1/projects/{project_id}/sources/-/findings
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Name of the source to groupBy. Its format is
                /// "organizations/[organization_id]/sources/[source_id]", folders/[folder_id]/sources/[source_id], or
                /// projects/[project_id]/sources/[source_id]. To groupBy across all sources provide a source_id of `-`.
                /// For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/-, or
                /// projects/{project_id}/sources/-
                /// </param>
                public virtual GroupRequest Group(Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest body, string parent)
                {
                    return new GroupRequest(service, body, parent);
                }

                /// <summary>
                /// Filters an organization or source's findings and groups them by their specified properties. To group
                /// across all sources provide a `-` as the source id. Example:
                /// /v1/organizations/{organization_id}/sources/-/findings, /v1/folders/{folder_id}/sources/-/findings,
                /// /v1/projects/{project_id}/sources/-/findings
                /// </summary>
                public class GroupRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsResponse>
                {
                    /// <summary>Constructs a new Group request.</summary>
                    public GroupRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the source to groupBy. Its format is
                    /// "organizations/[organization_id]/sources/[source_id]", folders/[folder_id]/sources/[source_id],
                    /// or projects/[project_id]/sources/[source_id]. To groupBy across all sources provide a source_id
                    /// of `-`. For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/-,
                    /// or projects/{project_id}/sources/-
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "group";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/findings:group";

                    /// <summary>Initializes Group parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^folders/[^/]+/sources/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists an organization or source's findings. To list across all sources provide a `-` as the source
                /// id. Example: /v1/organizations/{organization_id}/sources/-/findings
                /// </summary>
                /// <param name="parent">
                /// Required. Name of the source the findings belong to. Its format is
                /// "organizations/[organization_id]/sources/[source_id], folders/[folder_id]/sources/[source_id], or
                /// projects/[project_id]/sources/[source_id]". To list across all sources provide a source_id of `-`.
                /// For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/- or
                /// projects/{projects_id}/sources/-
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists an organization or source's findings. To list across all sources provide a `-` as the source
                /// id. Example: /v1/organizations/{organization_id}/sources/-/findings
                /// </summary>
                public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListFindingsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the source the findings belong to. Its format is
                    /// "organizations/[organization_id]/sources/[source_id], folders/[folder_id]/sources/[source_id],
                    /// or projects/[project_id]/sources/[source_id]". To list across all sources provide a source_id of
                    /// `-`. For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/- or
                    /// projects/{projects_id}/sources/-
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// When compare_duration is set, the ListFindingsResult's "state_change" attribute is updated to
                    /// indicate whether the finding had its state changed, the finding's state remained unchanged, or
                    /// if the finding was added in any state during the compare_duration period of time that precedes
                    /// the read_time. This is the time between (read_time - compare_duration) and read_time. The
                    /// state_change value is derived based on the presence and state of the finding at the two points
                    /// in time. Intermediate state changes between the two times don't affect the result. For example,
                    /// the results aren't affected if the finding is made inactive and then active again. Possible
                    /// "state_change" values when compare_duration is specified: * "CHANGED": indicates that the
                    /// finding was present and matched the given filter at the start of compare_duration, but changed
                    /// its state at read_time. * "UNCHANGED": indicates that the finding was present and matched the
                    /// given filter at the start of compare_duration and did not change state at read_time. * "ADDED":
                    /// indicates that the finding did not match the given filter or was not present at the start of
                    /// compare_duration, but was present at read_time. * "REMOVED": indicates that the finding was
                    /// present and matched the filter at the start of compare_duration, but did not match the filter at
                    /// read_time. If compare_duration is not specified, then the only possible state_change is
                    /// "UNUSED", which will be the state_change set for all findings present at read_time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("compareDuration", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object CompareDuration { get; set; }

                    /// <summary>
                    /// A field mask to specify the Finding fields to be listed in the response. An empty field mask
                    /// will list all fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object FieldMask { get; set; }

                    /// <summary>
                    /// Expression that defines the filter to apply across findings. The expression is a list of one or
                    /// more restrictions combined via logical operators `AND` and `OR`. Parentheses are supported, and
                    /// `OR` has higher precedence than `AND`. Restrictions have the form ` ` and may have a `-`
                    /// character in front of them to indicate negation. Examples include: * name *
                    /// source_properties.a_property * security_marks.marks.marka The supported operators are: * `=` for
                    /// all value types. * `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for integer values. * `:`,
                    /// meaning substring matching, for strings. The supported value types are: * string literals in
                    /// quotes. * integer literals without quotes. * boolean literals `true` and `false` without quotes.
                    /// The following field and operator combinations are supported: * name: `=` * parent: `=`, `:` *
                    /// resource_name: `=`, `:` * state: `=`, `:` * category: `=`, `:` * external_uri: `=`, `:` *
                    /// event_time: `=`, `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be
                    /// milliseconds since epoch or an RFC3339 string. Examples: `event_time =
                    /// "2019-06-10T16:07:18-07:00"` `event_time = 1560208038000` * severity: `=`, `:` * workflow_state:
                    /// `=`, `:` * security_marks.marks: `=`, `:` * source_properties: `=`, `:`, `&amp;gt;`, `&amp;lt;`,
                    /// `&amp;gt;=`, `&amp;lt;=` For example, `source_properties.size = 100` is a valid filter string.
                    /// Use a partial match on the empty string to filter based on a property existing:
                    /// `source_properties.my_property : ""` Use a negated partial match on the empty string to filter
                    /// based on a property not existing: `-source_properties.my_property : ""` * resource: *
                    /// resource.name: `=`, `:` * resource.parent_name: `=`, `:` * resource.parent_display_name: `=`,
                    /// `:` * resource.project_name: `=`, `:` * resource.project_display_name: `=`, `:` * resource.type:
                    /// `=`, `:` * resource.folders.resource_folder: `=`, `:` * resource.display_name: `=`, `:`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Expression that defines what fields and order to use for sorting. The string value should follow
                    /// SQL syntax: comma separated list of fields. For example: "name,resource_properties.a_property".
                    /// The default sorting order is ascending. To specify descending order for a field, a suffix "
                    /// desc" should be appended to the field name. For example: "name
                    /// desc,source_properties.a_property". Redundant space characters in the syntax are insignificant.
                    /// "name desc,source_properties.a_property" and " name desc , source_properties.a_property " are
                    /// equivalent. The following fields are supported: name parent state category resource_name
                    /// event_time source_properties security_marks.marks
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of results to return in a single response. Default is 10, minimum is 1,
                    /// maximum is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListFindingsResponse`; indicates that this is a continuation of
                    /// a prior `ListFindings` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Time used as a reference point when filtering findings. The filter is limited to findings
                    /// existing at the supplied time and their values are those at that specific time. Absence of this
                    /// field will default to the API's version of NOW.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object ReadTime { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/findings";

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
                            Pattern = @"^folders/[^/]+/sources/[^/]+$",
                        });
                        RequestParameters.Add("compareDuration", new Google.Apis.Discovery.Parameter
                        {
                            Name = "compareDuration",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fieldMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
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
                        RequestParameters.Add("readTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "readTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Creates or updates a finding. The corresponding source must exist for a finding creation to succeed.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The [relative resource
                /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the finding.
                /// Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.Finding body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Creates or updates a finding. The corresponding source must exist for a finding creation to succeed.
                /// </summary>
                public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Finding>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.Finding body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The [relative resource
                    /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the
                    /// finding. Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                    /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                    /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The FieldMask to use when updating the finding resource. This field should not be specified when
                    /// creating a finding. When updating a finding, an empty mask is treated as updating all mutable
                    /// fields and replacing source_properties. Individual source_properties can be added/updated by
                    /// using "source_properties." in the field mask.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.Finding Body { get; set; }

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
                            Pattern = @"^folders/[^/]+/sources/[^/]+/findings/[^/]+$",
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

                /// <summary>Updates the mute state of a finding.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The [relative resource
                /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the finding.
                /// Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                /// </param>
                public virtual SetMuteRequest SetMute(Google.Apis.SecurityCommandCenter.v1.Data.SetMuteRequest body, string name)
                {
                    return new SetMuteRequest(service, body, name);
                }

                /// <summary>Updates the mute state of a finding.</summary>
                public class SetMuteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Finding>
                {
                    /// <summary>Constructs a new SetMute request.</summary>
                    public SetMuteRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SetMuteRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The [relative resource
                    /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the
                    /// finding. Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                    /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                    /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.SetMuteRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setMute";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setMute";

                    /// <summary>Initializes SetMute parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^folders/[^/]+/sources/[^/]+/findings/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates the state of a finding.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The [relative resource
                /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the finding.
                /// Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                /// </param>
                public virtual SetStateRequest SetState(Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest body, string name)
                {
                    return new SetStateRequest(service, body, name);
                }

                /// <summary>Updates the state of a finding.</summary>
                public class SetStateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Finding>
                {
                    /// <summary>Constructs a new SetState request.</summary>
                    public SetStateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The [relative resource
                    /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the
                    /// finding. Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                    /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                    /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setState";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setState";

                    /// <summary>Initializes SetState parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^folders/[^/]+/sources/[^/]+/findings/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates security marks.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The relative resource name of the SecurityMarks. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                /// </param>
                public virtual UpdateSecurityMarksRequest UpdateSecurityMarks(Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name)
                {
                    return new UpdateSecurityMarksRequest(service, body, name);
                }

                /// <summary>Updates security marks.</summary>
                public class UpdateSecurityMarksRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks>
                {
                    /// <summary>Constructs a new UpdateSecurityMarks request.</summary>
                    public UpdateSecurityMarksRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The relative resource name of the SecurityMarks. See:
                    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                    /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                    /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The time at which the updated SecurityMarks take effect. If not set uses current server time.
                    /// Updates will be applied to the SecurityMarks that are active immediately preceding this time.
                    /// Must be earlier or equal to the server time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object StartTime { get; set; }

                    /// <summary>
                    /// The FieldMask to use when updating the security marks resource. The field mask must not contain
                    /// duplicate fields. If empty or set to "marks", all marks will be replaced. Individual marks can
                    /// be updated using "marks.".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateSecurityMarks";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes UpdateSecurityMarks parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^folders/[^/]+/sources/[^/]+/findings/[^/]+/securityMarks$",
                        });
                        RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
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

            /// <summary>Lists all sources belonging to an organization.</summary>
            /// <param name="parent">
            /// Required. Resource name of the parent of sources to list. Its format should be
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all sources belonging to an organization.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListSourcesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the parent of sources to list. Its format should be
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum
                /// is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListSourcesResponse`; indicates that this is a continuation of a
                /// prior `ListSources` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/sources";

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
                        Pattern = @"^folders/[^/]+$",
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
            Assets = new AssetsResource(service);
            BigQueryExports = new BigQueryExportsResource(service);
            Findings = new FindingsResource(service);
            MuteConfigs = new MuteConfigsResource(service);
            NotificationConfigs = new NotificationConfigsResource(service);
            Operations = new OperationsResource(service);
            SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettingsResource(service);
            Sources = new SourcesResource(service);
        }

        /// <summary>Gets the Assets resource.</summary>
        public virtual AssetsResource Assets { get; }

        /// <summary>The "assets" collection of methods.</summary>
        public class AssetsResource
        {
            private const string Resource = "assets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AssetsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Filters an organization's assets and groups them by their specified properties.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the parent to group the assets by. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual GroupRequest Group(Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest body, string parent)
            {
                return new GroupRequest(service, body, parent);
            }

            /// <summary>Filters an organization's assets and groups them by their specified properties.</summary>
            public class GroupRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsResponse>
            {
                /// <summary>Constructs a new Group request.</summary>
                public GroupRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the parent to group the assets by. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "group";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/assets:group";

                /// <summary>Initializes Group parameter list.</summary>
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

            /// <summary>Lists an organization's assets.</summary>
            /// <param name="parent">
            /// Required. The name of the parent resource that contains the assets. The value that you can specify on
            /// parent depends on the method in which you specify parent. You can specify one of the following values:
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists an organization's assets.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListAssetsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the parent resource that contains the assets. The value that you can specify
                /// on parent depends on the method in which you specify parent. You can specify one of the following
                /// values: "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// When compare_duration is set, the ListAssetsResult's "state_change" attribute is updated to indicate
                /// whether the asset was added, removed, or remained present during the compare_duration period of time
                /// that precedes the read_time. This is the time between (read_time - compare_duration) and read_time.
                /// The state_change value is derived based on the presence of the asset at the two points in time.
                /// Intermediate state changes between the two times don't affect the result. For example, the results
                /// aren't affected if the asset is removed and re-created again. Possible "state_change" values when
                /// compare_duration is specified: * "ADDED": indicates that the asset was not present at the start of
                /// compare_duration, but present at read_time. * "REMOVED": indicates that the asset was present at the
                /// start of compare_duration, but not present at read_time. * "ACTIVE": indicates that the asset was
                /// present at both the start and the end of the time period defined by compare_duration and read_time.
                /// If compare_duration is not specified, then the only possible state_change is "UNUSED", which will be
                /// the state_change set for all assets present at read_time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("compareDuration", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object CompareDuration { get; set; }

                /// <summary>
                /// A field mask to specify the ListAssetsResult fields to be listed in the response. An empty field
                /// mask will list all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object FieldMask { get; set; }

                /// <summary>
                /// Expression that defines the filter to apply across assets. The expression is a list of zero or more
                /// restrictions combined via logical operators `AND` and `OR`. Parentheses are supported, and `OR` has
                /// higher precedence than `AND`. Restrictions have the form ` ` and may have a `-` character in front
                /// of them to indicate negation. The fields map to those defined in the Asset resource. Examples
                /// include: * name * security_center_properties.resource_name * resource_properties.a_property *
                /// security_marks.marks.marka The supported operators are: * `=` for all value types. * `&amp;gt;`,
                /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for integer values. * `:`, meaning substring matching, for
                /// strings. The supported value types are: * string literals in quotes. * integer literals without
                /// quotes. * boolean literals `true` and `false` without quotes. The following are the allowed field
                /// and operator combinations: * name: `=` * update_time: `=`, `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`,
                /// `&amp;lt;=` Usage: This should be milliseconds since epoch or an RFC3339 string. Examples:
                /// `update_time = "2019-06-10T16:07:18-07:00"` `update_time = 1560208038000` * create_time: `=`,
                /// `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be milliseconds since epoch or
                /// an RFC3339 string. Examples: `create_time = "2019-06-10T16:07:18-07:00"` `create_time =
                /// 1560208038000` * iam_policy.policy_blob: `=`, `:` * resource_properties: `=`, `:`, `&amp;gt;`,
                /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` * security_marks.marks: `=`, `:` *
                /// security_center_properties.resource_name: `=`, `:` *
                /// security_center_properties.resource_display_name: `=`, `:` *
                /// security_center_properties.resource_type: `=`, `:` * security_center_properties.resource_parent:
                /// `=`, `:` * security_center_properties.resource_parent_display_name: `=`, `:` *
                /// security_center_properties.resource_project: `=`, `:` *
                /// security_center_properties.resource_project_display_name: `=`, `:` *
                /// security_center_properties.resource_owners: `=`, `:` For example, `resource_properties.size = 100`
                /// is a valid filter string. Use a partial match on the empty string to filter based on a property
                /// existing: `resource_properties.my_property : ""` Use a negated partial match on the empty string to
                /// filter based on a property not existing: `-resource_properties.my_property : ""`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Expression that defines what fields and order to use for sorting. The string value should follow SQL
                /// syntax: comma separated list of fields. For example: "name,resource_properties.a_property". The
                /// default sorting order is ascending. To specify descending order for a field, a suffix " desc" should
                /// be appended to the field name. For example: "name desc,resource_properties.a_property". Redundant
                /// space characters in the syntax are insignificant. "name desc,resource_properties.a_property" and "
                /// name desc , resource_properties.a_property " are equivalent. The following fields are supported:
                /// name update_time resource_properties security_marks.marks security_center_properties.resource_name
                /// security_center_properties.resource_display_name security_center_properties.resource_parent
                /// security_center_properties.resource_parent_display_name security_center_properties.resource_project
                /// security_center_properties.resource_project_display_name security_center_properties.resource_type
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum
                /// is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListAssetsResponse`; indicates that this is a continuation of a
                /// prior `ListAssets` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Time used as a reference point when filtering assets. The filter is limited to assets existing at
                /// the supplied time and their values are those at that specific time. Absence of this field will
                /// default to the API's version of NOW.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object ReadTime { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/assets";

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
                    RequestParameters.Add("compareDuration", new Google.Apis.Discovery.Parameter
                    {
                        Name = "compareDuration",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fieldMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
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
                    RequestParameters.Add("readTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "readTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>
            /// Runs asset discovery. The discovery is tracked with a long-running operation. This API can only be
            /// called with limited frequency for an organization. If it is called too frequently the caller will
            /// receive a TOO_MANY_REQUESTS error.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Name of the organization to run asset discovery for. Its format is
            /// "organizations/[organization_id]".
            /// </param>
            public virtual RunDiscoveryRequest RunDiscovery(Google.Apis.SecurityCommandCenter.v1.Data.RunAssetDiscoveryRequest body, string parent)
            {
                return new RunDiscoveryRequest(service, body, parent);
            }

            /// <summary>
            /// Runs asset discovery. The discovery is tracked with a long-running operation. This API can only be
            /// called with limited frequency for an organization. If it is called too frequently the caller will
            /// receive a TOO_MANY_REQUESTS error.
            /// </summary>
            public class RunDiscoveryRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Operation>
            {
                /// <summary>Constructs a new RunDiscovery request.</summary>
                public RunDiscoveryRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.RunAssetDiscoveryRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the organization to run asset discovery for. Its format is
                /// "organizations/[organization_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.RunAssetDiscoveryRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "runDiscovery";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/assets:runDiscovery";

                /// <summary>Initializes RunDiscovery parameter list.</summary>
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

            /// <summary>Updates security marks.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The relative resource name of the SecurityMarks. See:
            /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
            /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
            /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
            /// </param>
            public virtual UpdateSecurityMarksRequest UpdateSecurityMarks(Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name)
            {
                return new UpdateSecurityMarksRequest(service, body, name);
            }

            /// <summary>Updates security marks.</summary>
            public class UpdateSecurityMarksRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks>
            {
                /// <summary>Constructs a new UpdateSecurityMarks request.</summary>
                public UpdateSecurityMarksRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The relative resource name of the SecurityMarks. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The time at which the updated SecurityMarks take effect. If not set uses current server time.
                /// Updates will be applied to the SecurityMarks that are active immediately preceding this time. Must
                /// be earlier or equal to the server time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object StartTime { get; set; }

                /// <summary>
                /// The FieldMask to use when updating the security marks resource. The field mask must not contain
                /// duplicate fields. If empty or set to "marks", all marks will be replaced. Individual marks can be
                /// updated using "marks.".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateSecurityMarks";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes UpdateSecurityMarks parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/assets/[^/]+/securityMarks$",
                    });
                    RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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

        /// <summary>Gets the BigQueryExports resource.</summary>
        public virtual BigQueryExportsResource BigQueryExports { get; }

        /// <summary>The "bigQueryExports" collection of methods.</summary>
        public class BigQueryExportsResource
        {
            private const string Resource = "bigQueryExports";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BigQueryExportsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a BigQuery export.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the parent resource of the new BigQuery export. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a BigQuery export.</summary>
            public class CreateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the parent resource of the new BigQuery export. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. Unique identifier provided by the client within the parent scope. It must consist of only
                /// lowercase letters, numbers, and hyphens, must start with a letter, must end with either a letter or
                /// a number, and must be 63 characters or less.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("bigQueryExportId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string BigQueryExportId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/bigQueryExports";

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
                    RequestParameters.Add("bigQueryExportId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "bigQueryExportId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes an existing BigQuery export.</summary>
            /// <param name="name">
            /// Required. The name of the BigQuery export to delete. Its format is
            /// organizations/{organization}/bigQueryExports/{export_id}, folders/{folder}/bigQueryExports/{export_id},
            /// or projects/{project}/bigQueryExports/{export_id}
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes an existing BigQuery export.</summary>
            public class DeleteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the BigQuery export to delete. Its format is
                /// organizations/{organization}/bigQueryExports/{export_id},
                /// folders/{folder}/bigQueryExports/{export_id}, or projects/{project}/bigQueryExports/{export_id}
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
                        Pattern = @"^organizations/[^/]+/bigQueryExports/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a BigQuery export.</summary>
            /// <param name="name">
            /// Required. Name of the BigQuery export to retrieve. Its format is
            /// organizations/{organization}/bigQueryExports/{export_id}, folders/{folder}/bigQueryExports/{export_id},
            /// or projects/{project}/bigQueryExports/{export_id}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a BigQuery export.</summary>
            public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the BigQuery export to retrieve. Its format is
                /// organizations/{organization}/bigQueryExports/{export_id},
                /// folders/{folder}/bigQueryExports/{export_id}, or projects/{project}/bigQueryExports/{export_id}
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
                        Pattern = @"^organizations/[^/]+/bigQueryExports/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists BigQuery exports. Note that when requesting BigQuery exports at a given level all exports under
            /// that level are also returned e.g. if requesting BigQuery exports under a folder, then all BigQuery
            /// exports immediately under the folder plus the ones created under the projects within the folder are
            /// returned.
            /// </summary>
            /// <param name="parent">
            /// Required. The parent, which owns the collection of BigQuery exports. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists BigQuery exports. Note that when requesting BigQuery exports at a given level all exports under
            /// that level are also returned e.g. if requesting BigQuery exports under a folder, then all BigQuery
            /// exports immediately under the folder plus the ones created under the projects within the folder are
            /// returned.
            /// </summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListBigQueryExportsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent, which owns the collection of BigQuery exports. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of configs to return. The service may return fewer than this value. If
                /// unspecified, at most 10 configs will be returned. The maximum value is 1000; values above 1000 will
                /// be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListBigQueryExports` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListBigQueryExports` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/bigQueryExports";

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

            /// <summary>Updates a BigQuery export.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The relative resource name of this export. See:
            /// https://cloud.google.com/apis/design/resource_names#relative_resource_name. Example format:
            /// "organizations/{organization_id}/bigQueryExports/{export_id}" Example format:
            /// "folders/{folder_id}/bigQueryExports/{export_id}" Example format:
            /// "projects/{project_id}/bigQueryExports/{export_id}" This field is provided in responses, and is ignored
            /// when provided in create requests.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a BigQuery export.</summary>
            public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The relative resource name of this export. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name. Example format:
                /// "organizations/{organization_id}/bigQueryExports/{export_id}" Example format:
                /// "folders/{folder_id}/bigQueryExports/{export_id}" Example format:
                /// "projects/{project_id}/bigQueryExports/{export_id}" This field is provided in responses, and is
                /// ignored when provided in create requests.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The list of fields to be updated. If empty all mutable fields will be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport Body { get; set; }

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
                        Pattern = @"^organizations/[^/]+/bigQueryExports/[^/]+$",
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

        /// <summary>Gets the Findings resource.</summary>
        public virtual FindingsResource Findings { get; }

        /// <summary>The "findings" collection of methods.</summary>
        public class FindingsResource
        {
            private const string Resource = "findings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public FindingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Kicks off an LRO to bulk mute findings for a parent based on a filter. The parent can be either an
            /// organization, folder or project. The findings matched by the filter will be muted after the LRO is done.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent, at which bulk action needs to be applied. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
            /// </param>
            public virtual BulkMuteRequest BulkMute(Google.Apis.SecurityCommandCenter.v1.Data.BulkMuteFindingsRequest body, string parent)
            {
                return new BulkMuteRequest(service, body, parent);
            }

            /// <summary>
            /// Kicks off an LRO to bulk mute findings for a parent based on a filter. The parent can be either an
            /// organization, folder or project. The findings matched by the filter will be muted after the LRO is done.
            /// </summary>
            public class BulkMuteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Operation>
            {
                /// <summary>Constructs a new BulkMute request.</summary>
                public BulkMuteRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.BulkMuteFindingsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent, at which bulk action needs to be applied. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.BulkMuteFindingsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "bulkMute";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/findings:bulkMute";

                /// <summary>Initializes BulkMute parameter list.</summary>
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
        }

        /// <summary>Gets the MuteConfigs resource.</summary>
        public virtual MuteConfigsResource MuteConfigs { get; }

        /// <summary>The "muteConfigs" collection of methods.</summary>
        public class MuteConfigsResource
        {
            private const string Resource = "muteConfigs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MuteConfigsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a mute config.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name of the new mute configs's parent. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a mute config.</summary>
            public class CreateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the new mute configs's parent. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. Unique identifier provided by the client within the parent scope. It must consist of only
                /// lowercase letters, numbers, and hyphens, must start with a letter, must end with either a letter or
                /// a number, and must be 63 characters or less.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("muteConfigId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string MuteConfigId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/muteConfigs";

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
                    RequestParameters.Add("muteConfigId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "muteConfigId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes an existing mute config.</summary>
            /// <param name="name">
            /// Required. Name of the mute config to delete. Its format is
            /// organizations/{organization}/muteConfigs/{config_id}, folders/{folder}/muteConfigs/{config_id}, or
            /// projects/{project}/muteConfigs/{config_id}
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes an existing mute config.</summary>
            public class DeleteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the mute config to delete. Its format is
                /// organizations/{organization}/muteConfigs/{config_id}, folders/{folder}/muteConfigs/{config_id}, or
                /// projects/{project}/muteConfigs/{config_id}
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
                        Pattern = @"^organizations/[^/]+/muteConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a mute config.</summary>
            /// <param name="name">
            /// Required. Name of the mute config to retrieve. Its format is
            /// organizations/{organization}/muteConfigs/{config_id}, folders/{folder}/muteConfigs/{config_id}, or
            /// projects/{project}/muteConfigs/{config_id}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a mute config.</summary>
            public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the mute config to retrieve. Its format is
                /// organizations/{organization}/muteConfigs/{config_id}, folders/{folder}/muteConfigs/{config_id}, or
                /// projects/{project}/muteConfigs/{config_id}
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
                        Pattern = @"^organizations/[^/]+/muteConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Lists mute configs.</summary>
            /// <param name="parent">
            /// Required. The parent, which owns the collection of mute configs. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists mute configs.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListMuteConfigsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent, which owns the collection of mute configs. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of configs to return. The service may return fewer than this value. If
                /// unspecified, at most 10 configs will be returned. The maximum value is 1000; values above 1000 will
                /// be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListMuteConfigs` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListMuteConfigs` must match the
                /// call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/muteConfigs";

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

            /// <summary>Updates a mute config.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// This field will be ignored if provided on config creation. Format
            /// "organizations/{organization}/muteConfigs/{mute_config}" "folders/{folder}/muteConfigs/{mute_config}"
            /// "projects/{project}/muteConfigs/{mute_config}"
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a mute config.</summary>
            public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// This field will be ignored if provided on config creation. Format
                /// "organizations/{organization}/muteConfigs/{mute_config}"
                /// "folders/{folder}/muteConfigs/{mute_config}" "projects/{project}/muteConfigs/{mute_config}"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The list of fields to be updated. If empty all mutable fields will be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig Body { get; set; }

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
                        Pattern = @"^organizations/[^/]+/muteConfigs/[^/]+$",
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

        /// <summary>Gets the NotificationConfigs resource.</summary>
        public virtual NotificationConfigsResource NotificationConfigs { get; }

        /// <summary>The "notificationConfigs" collection of methods.</summary>
        public class NotificationConfigsResource
        {
            private const string Resource = "notificationConfigs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public NotificationConfigsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a notification config.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name of the new notification config's parent. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a notification config.</summary>
            public class CreateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the new notification config's parent. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. Unique identifier provided by the client within the parent scope. It must be between 1 and
                /// 128 characters and contain alphanumeric characters, underscores, or hyphens only.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ConfigId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/notificationConfigs";

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
                    RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "configId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes a notification config.</summary>
            /// <param name="name">
            /// Required. Name of the notification config to delete. Its format is
            /// "organizations/[organization_id]/notificationConfigs/[config_id]",
            /// "folders/[folder_id]/notificationConfigs/[config_id]", or
            /// "projects/[project_id]/notificationConfigs/[config_id]".
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a notification config.</summary>
            public class DeleteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the notification config to delete. Its format is
                /// "organizations/[organization_id]/notificationConfigs/[config_id]",
                /// "folders/[folder_id]/notificationConfigs/[config_id]", or
                /// "projects/[project_id]/notificationConfigs/[config_id]".
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
                        Pattern = @"^organizations/[^/]+/notificationConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a notification config.</summary>
            /// <param name="name">
            /// Required. Name of the notification config to get. Its format is
            /// "organizations/[organization_id]/notificationConfigs/[config_id]",
            /// "folders/[folder_id]/notificationConfigs/[config_id]", or
            /// "projects/[project_id]/notificationConfigs/[config_id]".
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a notification config.</summary>
            public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the notification config to get. Its format is
                /// "organizations/[organization_id]/notificationConfigs/[config_id]",
                /// "folders/[folder_id]/notificationConfigs/[config_id]", or
                /// "projects/[project_id]/notificationConfigs/[config_id]".
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
                        Pattern = @"^organizations/[^/]+/notificationConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Lists notification configs.</summary>
            /// <param name="parent">
            /// Required. The name of the parent in which to list the notification configurations. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists notification configs.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListNotificationConfigsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the parent in which to list the notification configurations. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum
                /// is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListNotificationConfigsResponse`; indicates that this is a
                /// continuation of a prior `ListNotificationConfigs` call, and that the system should return the next
                /// page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/notificationConfigs";

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
            ///  Updates a notification config. The following update fields are allowed: description, pubsub_topic,
            /// streaming_config.filter
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The relative resource name of this notification config. See:
            /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
            /// "organizations/{organization_id}/notificationConfigs/notify_public_bucket",
            /// "folders/{folder_id}/notificationConfigs/notify_public_bucket", or
            /// "projects/{project_id}/notificationConfigs/notify_public_bucket".
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            ///  Updates a notification config. The following update fields are allowed: description, pubsub_topic,
            /// streaming_config.filter
            /// </summary>
            public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The relative resource name of this notification config. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                /// "organizations/{organization_id}/notificationConfigs/notify_public_bucket",
                /// "folders/{folder_id}/notificationConfigs/notify_public_bucket", or
                /// "projects/{project_id}/notificationConfigs/notify_public_bucket".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The FieldMask to use when updating the notification config. If empty all mutable fields will be
                /// updated.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig Body { get; set; }

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
                        Pattern = @"^organizations/[^/]+/notificationConfigs/[^/]+$",
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

        /// <summary>Gets the Operations resource.</summary>
        public virtual OperationsResource Operations { get; }

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
            /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel
            /// the operation, but success is not guaranteed. If the server doesn't support this method, it returns
            /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check
            /// whether the cancellation succeeded or whether the operation completed despite cancellation. On
            /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
            /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
            /// </summary>
            /// <param name="name">The name of the operation resource to be cancelled.</param>
            public virtual CancelRequest Cancel(string name)
            {
                return new CancelRequest(service, name);
            }

            /// <summary>
            /// Starts asynchronous cancellation on a long-running operation. The server makes a best effort to cancel
            /// the operation, but success is not guaranteed. If the server doesn't support this method, it returns
            /// `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to check
            /// whether the cancellation succeeded or whether the operation completed despite cancellation. On
            /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
            /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.
            /// </summary>
            public class CancelRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Empty>
            {
                /// <summary>Constructs a new Cancel request.</summary>
                public CancelRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>The name of the operation resource to be cancelled.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

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
                        Pattern = @"^organizations/[^/]+/operations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
            /// operation result. It does not cancel the operation. If the server doesn't support this method, it
            /// returns `google.rpc.Code.UNIMPLEMENTED`.
            /// </summary>
            /// <param name="name">The name of the operation resource to be deleted.</param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>
            /// Deletes a long-running operation. This method indicates that the client is no longer interested in the
            /// operation result. It does not cancel the operation. If the server doesn't support this method, it
            /// returns `google.rpc.Code.UNIMPLEMENTED`.
            /// </summary>
            public class DeleteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Empty>
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
                        Pattern = @"^organizations/[^/]+/operations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
            /// result at intervals as recommended by the API service.
            /// </summary>
            /// <param name="name">The name of the operation resource.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>
            /// Gets the latest state of a long-running operation. Clients can use this method to poll the operation
            /// result at intervals as recommended by the API service.
            /// </summary>
            public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Operation>
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
                        Pattern = @"^organizations/[^/]+/operations/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists operations that match the specified filter in the request. If the server doesn't support this
            /// method, it returns `UNIMPLEMENTED`.
            /// </summary>
            /// <param name="name">The name of the operation's parent resource.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>
            /// Lists operations that match the specified filter in the request. If the server doesn't support this
            /// method, it returns `UNIMPLEMENTED`.
            /// </summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListOperationsResponse>
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
                        Pattern = @"^organizations/[^/]+/operations$",
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

        /// <summary>Gets the SecurityHealthAnalyticsSettings resource.</summary>
        public virtual SecurityHealthAnalyticsSettingsResource SecurityHealthAnalyticsSettings { get; }

        /// <summary>The "securityHealthAnalyticsSettings" collection of methods.</summary>
        public class SecurityHealthAnalyticsSettingsResource
        {
            private const string Resource = "securityHealthAnalyticsSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SecurityHealthAnalyticsSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                CustomModules = new CustomModulesResource(service);
                EffectiveCustomModules = new EffectiveCustomModulesResource(service);
            }

            /// <summary>Gets the CustomModules resource.</summary>
            public virtual CustomModulesResource CustomModules { get; }

            /// <summary>The "customModules" collection of methods.</summary>
            public class CustomModulesResource
            {
                private const string Resource = "customModules";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CustomModulesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a resident SecurityHealthAnalyticsCustomModule at the scope of the given CRM parent, and
                /// also creates inherited SecurityHealthAnalyticsCustomModules for all CRM descendants of the given
                /// parent. These modules are enabled by default.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Resource name of the new custom module's parent. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings",
                /// "folders/{folder}/securityHealthAnalyticsSettings", or
                /// "projects/{project}/securityHealthAnalyticsSettings"
                /// </param>
                public virtual CreateRequest Create(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a resident SecurityHealthAnalyticsCustomModule at the scope of the given CRM parent, and
                /// also creates inherited SecurityHealthAnalyticsCustomModules for all CRM descendants of the given
                /// parent. These modules are enabled by default.
                /// </summary>
                public class CreateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the new custom module's parent. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings",
                    /// "folders/{folder}/securityHealthAnalyticsSettings", or
                    /// "projects/{project}/securityHealthAnalyticsSettings"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/customModules";

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
                            Pattern = @"^organizations/[^/]+/securityHealthAnalyticsSettings$",
                        });
                    }
                }

                /// <summary>
                /// Deletes the specified SecurityHealthAnalyticsCustomModule and all of its descendants in the CRM
                /// hierarchy. This method is only supported for resident custom modules.
                /// </summary>
                /// <param name="name">
                /// Required. Name of the custom module to delete. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}",
                /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}"
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes the specified SecurityHealthAnalyticsCustomModule and all of its descendants in the CRM
                /// hierarchy. This method is only supported for resident custom modules.
                /// </summary>
                public class DeleteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the custom module to delete. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}",
                    /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                    /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}"
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
                            Pattern = @"^organizations/[^/]+/securityHealthAnalyticsSettings/customModules/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieves a SecurityHealthAnalyticsCustomModule.</summary>
                /// <param name="name">
                /// Required. Name of the custom module to get. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}",
                /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}"
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Retrieves a SecurityHealthAnalyticsCustomModule.</summary>
                public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the custom module to get. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}",
                    /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                    /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}"
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
                            Pattern = @"^organizations/[^/]+/securityHealthAnalyticsSettings/customModules/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns a list of all SecurityHealthAnalyticsCustomModules for the given parent. This includes
                /// resident modules defined at the scope of the parent, and inherited modules, inherited from CRM
                /// ancestors.
                /// </summary>
                /// <param name="parent">
                /// Required. Name of parent to list custom modules. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings",
                /// "folders/{folder}/securityHealthAnalyticsSettings", or
                /// "projects/{project}/securityHealthAnalyticsSettings"
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Returns a list of all SecurityHealthAnalyticsCustomModules for the given parent. This includes
                /// resident modules defined at the scope of the parent, and inherited modules, inherited from CRM
                /// ancestors.
                /// </summary>
                public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListSecurityHealthAnalyticsCustomModulesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of parent to list custom modules. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings",
                    /// "folders/{folder}/securityHealthAnalyticsSettings", or
                    /// "projects/{project}/securityHealthAnalyticsSettings"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of results to return in a single response. Default is 10, minimum is 1,
                    /// maximum is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The value returned by the last call indicating a continuation</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/customModules";

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
                            Pattern = @"^organizations/[^/]+/securityHealthAnalyticsSettings$",
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
                /// Returns a list of all resident SecurityHealthAnalyticsCustomModules under the given CRM parent and
                /// all of the parent’s CRM descendants.
                /// </summary>
                /// <param name="parent">
                /// Required. Name of parent to list descendant custom modules. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings",
                /// "folders/{folder}/securityHealthAnalyticsSettings", or
                /// "projects/{project}/securityHealthAnalyticsSettings"
                /// </param>
                public virtual ListDescendantRequest ListDescendant(string parent)
                {
                    return new ListDescendantRequest(service, parent);
                }

                /// <summary>
                /// Returns a list of all resident SecurityHealthAnalyticsCustomModules under the given CRM parent and
                /// all of the parent’s CRM descendants.
                /// </summary>
                public class ListDescendantRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListDescendantSecurityHealthAnalyticsCustomModulesResponse>
                {
                    /// <summary>Constructs a new ListDescendant request.</summary>
                    public ListDescendantRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of parent to list descendant custom modules. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings",
                    /// "folders/{folder}/securityHealthAnalyticsSettings", or
                    /// "projects/{project}/securityHealthAnalyticsSettings"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of results to return in a single response. Default is 10, minimum is 1,
                    /// maximum is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The value returned by the last call indicating a continuation</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listDescendant";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/customModules:listDescendant";

                    /// <summary>Initializes ListDescendant parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/securityHealthAnalyticsSettings$",
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
                /// Updates the SecurityHealthAnalyticsCustomModule under the given name based on the given update mask.
                /// Updating the enablement state is supported on both resident and inherited modules (though resident
                /// modules cannot have an enablement state of "inherited"). Updating the display name and custom config
                /// of a module is supported on resident modules only.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Immutable. The resource name of the custom module. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}" The id
                /// {customModule} is server-generated and is not user settable. It will be a numeric id containing 1-20
                /// digits.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the SecurityHealthAnalyticsCustomModule under the given name based on the given update mask.
                /// Updating the enablement state is supported on both resident and inherited modules (though resident
                /// modules cannot have an enablement state of "inherited"). Updating the display name and custom config
                /// of a module is supported on resident modules only.
                /// </summary>
                public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Immutable. The resource name of the custom module. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                    /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                    /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}" The id
                    /// {customModule} is server-generated and is not user settable. It will be a numeric id containing
                    /// 1-20 digits.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule Body { get; set; }

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
                            Pattern = @"^organizations/[^/]+/securityHealthAnalyticsSettings/customModules/[^/]+$",
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

            /// <summary>Gets the EffectiveCustomModules resource.</summary>
            public virtual EffectiveCustomModulesResource EffectiveCustomModules { get; }

            /// <summary>The "effectiveCustomModules" collection of methods.</summary>
            public class EffectiveCustomModulesResource
            {
                private const string Resource = "effectiveCustomModules";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EffectiveCustomModulesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Retrieves an EffectiveSecurityHealthAnalyticsCustomModule.</summary>
                /// <param name="name">
                /// Required. Name of the effective custom module to get. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}",
                /// "folders/{folder}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}", or
                /// "projects/{project}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}"
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Retrieves an EffectiveSecurityHealthAnalyticsCustomModule.</summary>
                public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1EffectiveSecurityHealthAnalyticsCustomModule>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the effective custom module to get. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}",
                    /// "folders/{folder}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}", or
                    /// "projects/{project}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}"
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
                            Pattern = @"^organizations/[^/]+/securityHealthAnalyticsSettings/effectiveCustomModules/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns a list of all EffectiveSecurityHealthAnalyticsCustomModules for the given parent. This
                /// includes resident modules defined at the scope of the parent, and inherited modules, inherited from
                /// CRM ancestors.
                /// </summary>
                /// <param name="parent">
                /// Required. Name of parent to list effective custom modules. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings",
                /// "folders/{folder}/securityHealthAnalyticsSettings", or
                /// "projects/{project}/securityHealthAnalyticsSettings"
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Returns a list of all EffectiveSecurityHealthAnalyticsCustomModules for the given parent. This
                /// includes resident modules defined at the scope of the parent, and inherited modules, inherited from
                /// CRM ancestors.
                /// </summary>
                public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListEffectiveSecurityHealthAnalyticsCustomModulesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of parent to list effective custom modules. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings",
                    /// "folders/{folder}/securityHealthAnalyticsSettings", or
                    /// "projects/{project}/securityHealthAnalyticsSettings"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of results to return in a single response. Default is 10, minimum is 1,
                    /// maximum is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The value returned by the last call indicating a continuation</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/effectiveCustomModules";

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
                            Pattern = @"^organizations/[^/]+/securityHealthAnalyticsSettings$",
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
        }

        /// <summary>Gets the Sources resource.</summary>
        public virtual SourcesResource Sources { get; }

        /// <summary>The "sources" collection of methods.</summary>
        public class SourcesResource
        {
            private const string Resource = "sources";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SourcesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Findings = new FindingsResource(service);
            }

            /// <summary>Gets the Findings resource.</summary>
            public virtual FindingsResource Findings { get; }

            /// <summary>The "findings" collection of methods.</summary>
            public class FindingsResource
            {
                private const string Resource = "findings";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FindingsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    ExternalSystems = new ExternalSystemsResource(service);
                }

                /// <summary>Gets the ExternalSystems resource.</summary>
                public virtual ExternalSystemsResource ExternalSystems { get; }

                /// <summary>The "externalSystems" collection of methods.</summary>
                public class ExternalSystemsResource
                {
                    private const string Resource = "externalSystems";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ExternalSystemsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Updates external system. This is for a given finding.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Full resource name of the external system, for example:
                    /// "organizations/1234/sources/5678/findings/123456/externalSystems/jira",
                    /// "folders/1234/sources/5678/findings/123456/externalSystems/jira",
                    /// "projects/1234/sources/5678/findings/123456/externalSystems/jira"
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1ExternalSystem body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates external system. This is for a given finding.</summary>
                    public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1ExternalSystem>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1ExternalSystem body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Full resource name of the external system, for example:
                        /// "organizations/1234/sources/5678/findings/123456/externalSystems/jira",
                        /// "folders/1234/sources/5678/findings/123456/externalSystems/jira",
                        /// "projects/1234/sources/5678/findings/123456/externalSystems/jira"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// The FieldMask to use when updating the external system resource. If empty all mutable fields
                        /// will be updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1ExternalSystem Body { get; set; }

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
                                Pattern = @"^organizations/[^/]+/sources/[^/]+/findings/[^/]+/externalSystems/[^/]+$",
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

                /// <summary>
                /// Creates a finding. The corresponding source must exist for finding creation to succeed.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Resource name of the new finding's parent. Its format should be
                /// "organizations/[organization_id]/sources/[source_id]".
                /// </param>
                public virtual CreateRequest Create(Google.Apis.SecurityCommandCenter.v1.Data.Finding body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a finding. The corresponding source must exist for finding creation to succeed.
                /// </summary>
                public class CreateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Finding>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.Finding body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the new finding's parent. Its format should be
                    /// "organizations/[organization_id]/sources/[source_id]".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// Required. Unique identifier provided by the client within the parent scope. It must be
                    /// alphanumeric and less than or equal to 32 characters and greater than 0 characters in length.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("findingId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string FindingId { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.Finding Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/findings";

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
                            Pattern = @"^organizations/[^/]+/sources/[^/]+$",
                        });
                        RequestParameters.Add("findingId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "findingId",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Filters an organization or source's findings and groups them by their specified properties. To group
                /// across all sources provide a `-` as the source id. Example:
                /// /v1/organizations/{organization_id}/sources/-/findings, /v1/folders/{folder_id}/sources/-/findings,
                /// /v1/projects/{project_id}/sources/-/findings
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Name of the source to groupBy. Its format is
                /// "organizations/[organization_id]/sources/[source_id]", folders/[folder_id]/sources/[source_id], or
                /// projects/[project_id]/sources/[source_id]. To groupBy across all sources provide a source_id of `-`.
                /// For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/-, or
                /// projects/{project_id}/sources/-
                /// </param>
                public virtual GroupRequest Group(Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest body, string parent)
                {
                    return new GroupRequest(service, body, parent);
                }

                /// <summary>
                /// Filters an organization or source's findings and groups them by their specified properties. To group
                /// across all sources provide a `-` as the source id. Example:
                /// /v1/organizations/{organization_id}/sources/-/findings, /v1/folders/{folder_id}/sources/-/findings,
                /// /v1/projects/{project_id}/sources/-/findings
                /// </summary>
                public class GroupRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsResponse>
                {
                    /// <summary>Constructs a new Group request.</summary>
                    public GroupRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the source to groupBy. Its format is
                    /// "organizations/[organization_id]/sources/[source_id]", folders/[folder_id]/sources/[source_id],
                    /// or projects/[project_id]/sources/[source_id]. To groupBy across all sources provide a source_id
                    /// of `-`. For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/-,
                    /// or projects/{project_id}/sources/-
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "group";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/findings:group";

                    /// <summary>Initializes Group parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/sources/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists an organization or source's findings. To list across all sources provide a `-` as the source
                /// id. Example: /v1/organizations/{organization_id}/sources/-/findings
                /// </summary>
                /// <param name="parent">
                /// Required. Name of the source the findings belong to. Its format is
                /// "organizations/[organization_id]/sources/[source_id], folders/[folder_id]/sources/[source_id], or
                /// projects/[project_id]/sources/[source_id]". To list across all sources provide a source_id of `-`.
                /// For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/- or
                /// projects/{projects_id}/sources/-
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists an organization or source's findings. To list across all sources provide a `-` as the source
                /// id. Example: /v1/organizations/{organization_id}/sources/-/findings
                /// </summary>
                public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListFindingsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the source the findings belong to. Its format is
                    /// "organizations/[organization_id]/sources/[source_id], folders/[folder_id]/sources/[source_id],
                    /// or projects/[project_id]/sources/[source_id]". To list across all sources provide a source_id of
                    /// `-`. For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/- or
                    /// projects/{projects_id}/sources/-
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// When compare_duration is set, the ListFindingsResult's "state_change" attribute is updated to
                    /// indicate whether the finding had its state changed, the finding's state remained unchanged, or
                    /// if the finding was added in any state during the compare_duration period of time that precedes
                    /// the read_time. This is the time between (read_time - compare_duration) and read_time. The
                    /// state_change value is derived based on the presence and state of the finding at the two points
                    /// in time. Intermediate state changes between the two times don't affect the result. For example,
                    /// the results aren't affected if the finding is made inactive and then active again. Possible
                    /// "state_change" values when compare_duration is specified: * "CHANGED": indicates that the
                    /// finding was present and matched the given filter at the start of compare_duration, but changed
                    /// its state at read_time. * "UNCHANGED": indicates that the finding was present and matched the
                    /// given filter at the start of compare_duration and did not change state at read_time. * "ADDED":
                    /// indicates that the finding did not match the given filter or was not present at the start of
                    /// compare_duration, but was present at read_time. * "REMOVED": indicates that the finding was
                    /// present and matched the filter at the start of compare_duration, but did not match the filter at
                    /// read_time. If compare_duration is not specified, then the only possible state_change is
                    /// "UNUSED", which will be the state_change set for all findings present at read_time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("compareDuration", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object CompareDuration { get; set; }

                    /// <summary>
                    /// A field mask to specify the Finding fields to be listed in the response. An empty field mask
                    /// will list all fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object FieldMask { get; set; }

                    /// <summary>
                    /// Expression that defines the filter to apply across findings. The expression is a list of one or
                    /// more restrictions combined via logical operators `AND` and `OR`. Parentheses are supported, and
                    /// `OR` has higher precedence than `AND`. Restrictions have the form ` ` and may have a `-`
                    /// character in front of them to indicate negation. Examples include: * name *
                    /// source_properties.a_property * security_marks.marks.marka The supported operators are: * `=` for
                    /// all value types. * `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for integer values. * `:`,
                    /// meaning substring matching, for strings. The supported value types are: * string literals in
                    /// quotes. * integer literals without quotes. * boolean literals `true` and `false` without quotes.
                    /// The following field and operator combinations are supported: * name: `=` * parent: `=`, `:` *
                    /// resource_name: `=`, `:` * state: `=`, `:` * category: `=`, `:` * external_uri: `=`, `:` *
                    /// event_time: `=`, `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be
                    /// milliseconds since epoch or an RFC3339 string. Examples: `event_time =
                    /// "2019-06-10T16:07:18-07:00"` `event_time = 1560208038000` * severity: `=`, `:` * workflow_state:
                    /// `=`, `:` * security_marks.marks: `=`, `:` * source_properties: `=`, `:`, `&amp;gt;`, `&amp;lt;`,
                    /// `&amp;gt;=`, `&amp;lt;=` For example, `source_properties.size = 100` is a valid filter string.
                    /// Use a partial match on the empty string to filter based on a property existing:
                    /// `source_properties.my_property : ""` Use a negated partial match on the empty string to filter
                    /// based on a property not existing: `-source_properties.my_property : ""` * resource: *
                    /// resource.name: `=`, `:` * resource.parent_name: `=`, `:` * resource.parent_display_name: `=`,
                    /// `:` * resource.project_name: `=`, `:` * resource.project_display_name: `=`, `:` * resource.type:
                    /// `=`, `:` * resource.folders.resource_folder: `=`, `:` * resource.display_name: `=`, `:`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Expression that defines what fields and order to use for sorting. The string value should follow
                    /// SQL syntax: comma separated list of fields. For example: "name,resource_properties.a_property".
                    /// The default sorting order is ascending. To specify descending order for a field, a suffix "
                    /// desc" should be appended to the field name. For example: "name
                    /// desc,source_properties.a_property". Redundant space characters in the syntax are insignificant.
                    /// "name desc,source_properties.a_property" and " name desc , source_properties.a_property " are
                    /// equivalent. The following fields are supported: name parent state category resource_name
                    /// event_time source_properties security_marks.marks
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of results to return in a single response. Default is 10, minimum is 1,
                    /// maximum is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListFindingsResponse`; indicates that this is a continuation of
                    /// a prior `ListFindings` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Time used as a reference point when filtering findings. The filter is limited to findings
                    /// existing at the supplied time and their values are those at that specific time. Absence of this
                    /// field will default to the API's version of NOW.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object ReadTime { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/findings";

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
                            Pattern = @"^organizations/[^/]+/sources/[^/]+$",
                        });
                        RequestParameters.Add("compareDuration", new Google.Apis.Discovery.Parameter
                        {
                            Name = "compareDuration",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fieldMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
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
                        RequestParameters.Add("readTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "readTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Creates or updates a finding. The corresponding source must exist for a finding creation to succeed.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The [relative resource
                /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the finding.
                /// Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.Finding body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Creates or updates a finding. The corresponding source must exist for a finding creation to succeed.
                /// </summary>
                public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Finding>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.Finding body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The [relative resource
                    /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the
                    /// finding. Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                    /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                    /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The FieldMask to use when updating the finding resource. This field should not be specified when
                    /// creating a finding. When updating a finding, an empty mask is treated as updating all mutable
                    /// fields and replacing source_properties. Individual source_properties can be added/updated by
                    /// using "source_properties." in the field mask.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.Finding Body { get; set; }

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
                            Pattern = @"^organizations/[^/]+/sources/[^/]+/findings/[^/]+$",
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

                /// <summary>Updates the mute state of a finding.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The [relative resource
                /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the finding.
                /// Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                /// </param>
                public virtual SetMuteRequest SetMute(Google.Apis.SecurityCommandCenter.v1.Data.SetMuteRequest body, string name)
                {
                    return new SetMuteRequest(service, body, name);
                }

                /// <summary>Updates the mute state of a finding.</summary>
                public class SetMuteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Finding>
                {
                    /// <summary>Constructs a new SetMute request.</summary>
                    public SetMuteRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SetMuteRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The [relative resource
                    /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the
                    /// finding. Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                    /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                    /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.SetMuteRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setMute";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setMute";

                    /// <summary>Initializes SetMute parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/sources/[^/]+/findings/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates the state of a finding.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The [relative resource
                /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the finding.
                /// Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                /// </param>
                public virtual SetStateRequest SetState(Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest body, string name)
                {
                    return new SetStateRequest(service, body, name);
                }

                /// <summary>Updates the state of a finding.</summary>
                public class SetStateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Finding>
                {
                    /// <summary>Constructs a new SetState request.</summary>
                    public SetStateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The [relative resource
                    /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the
                    /// finding. Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                    /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                    /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setState";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setState";

                    /// <summary>Initializes SetState parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/sources/[^/]+/findings/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates security marks.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The relative resource name of the SecurityMarks. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                /// </param>
                public virtual UpdateSecurityMarksRequest UpdateSecurityMarks(Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name)
                {
                    return new UpdateSecurityMarksRequest(service, body, name);
                }

                /// <summary>Updates security marks.</summary>
                public class UpdateSecurityMarksRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks>
                {
                    /// <summary>Constructs a new UpdateSecurityMarks request.</summary>
                    public UpdateSecurityMarksRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The relative resource name of the SecurityMarks. See:
                    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                    /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                    /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The time at which the updated SecurityMarks take effect. If not set uses current server time.
                    /// Updates will be applied to the SecurityMarks that are active immediately preceding this time.
                    /// Must be earlier or equal to the server time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object StartTime { get; set; }

                    /// <summary>
                    /// The FieldMask to use when updating the security marks resource. The field mask must not contain
                    /// duplicate fields. If empty or set to "marks", all marks will be replaced. Individual marks can
                    /// be updated using "marks.".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateSecurityMarks";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes UpdateSecurityMarks parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^organizations/[^/]+/sources/[^/]+/findings/[^/]+/securityMarks$",
                        });
                        RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
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

            /// <summary>Creates a source.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name of the new source's parent. Its format should be
            /// "organizations/[organization_id]".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.SecurityCommandCenter.v1.Data.Source body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a source.</summary>
            public class CreateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Source>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.Source body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the new source's parent. Its format should be
                /// "organizations/[organization_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.Source Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/sources";

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

            /// <summary>Gets a source.</summary>
            /// <param name="name">
            /// Required. Relative resource name of the source. Its format is
            /// "organizations/[organization_id]/source/[source_id]".
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a source.</summary>
            public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Source>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Relative resource name of the source. Its format is
                /// "organizations/[organization_id]/source/[source_id]".
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
                        Pattern = @"^organizations/[^/]+/sources/[^/]+$",
                    });
                }
            }

            /// <summary>Gets the access control policy on the specified Source.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.SecurityCommandCenter.v1.Data.GetIamPolicyRequest body, string resource)
            {
                return new GetIamPolicyRequest(service, body, resource);
            }

            /// <summary>Gets the access control policy on the specified Source.</summary>
            public class GetIamPolicyRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Policy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:getIamPolicy";

                /// <summary>Initializes GetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/sources/[^/]+$",
                    });
                }
            }

            /// <summary>Lists all sources belonging to an organization.</summary>
            /// <param name="parent">
            /// Required. Resource name of the parent of sources to list. Its format should be
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all sources belonging to an organization.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListSourcesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the parent of sources to list. Its format should be
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum
                /// is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListSourcesResponse`; indicates that this is a continuation of a
                /// prior `ListSources` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/sources";

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

            /// <summary>Updates a source.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The relative resource name of this source. See:
            /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
            /// "organizations/{organization_id}/sources/{source_id}"
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.Source body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a source.</summary>
            public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Source>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.Source body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The relative resource name of this source. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                /// "organizations/{organization_id}/sources/{source_id}"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The FieldMask to use when updating the source resource. If empty all mutable fields will be updated.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.Source Body { get; set; }

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
                        Pattern = @"^organizations/[^/]+/sources/[^/]+$",
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

            /// <summary>Sets the access control policy on the specified Source.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy is being specified. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.SecurityCommandCenter.v1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(service, body, resource);
            }

            /// <summary>Sets the access control policy on the specified Source.</summary>
            public class SetIamPolicyRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.SetIamPolicyRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "setIamPolicy";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:setIamPolicy";

                /// <summary>Initializes SetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/sources/[^/]+$",
                    });
                }
            }

            /// <summary>Returns the permissions that a caller has on the specified source.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">
            /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
            /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this field.
            /// </param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.SecurityCommandCenter.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(service, body, resource);
            }

            /// <summary>Returns the permissions that a caller has on the specified source.</summary>
            public class TestIamPermissionsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.TestIamPermissionsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "testIamPermissions";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:testIamPermissions";

                /// <summary>Initializes TestIamPermissions parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                    {
                        Name = "resource",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/sources/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the settings for an organization.</summary>
        /// <param name="name">
        /// Required. Name of the organization to get organization settings for. Its format is
        /// "organizations/[organization_id]/organizationSettings".
        /// </param>
        public virtual GetOrganizationSettingsRequest GetOrganizationSettings(string name)
        {
            return new GetOrganizationSettingsRequest(service, name);
        }

        /// <summary>Gets the settings for an organization.</summary>
        public class GetOrganizationSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.OrganizationSettings>
        {
            /// <summary>Constructs a new GetOrganizationSettings request.</summary>
            public GetOrganizationSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. Name of the organization to get organization settings for. Its format is
            /// "organizations/[organization_id]/organizationSettings".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getOrganizationSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes GetOrganizationSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/organizationSettings$",
                });
            }
        }

        /// <summary>Updates an organization's settings.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The relative resource name of the settings. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
        /// "organizations/{organization_id}/organizationSettings".
        /// </param>
        public virtual UpdateOrganizationSettingsRequest UpdateOrganizationSettings(Google.Apis.SecurityCommandCenter.v1.Data.OrganizationSettings body, string name)
        {
            return new UpdateOrganizationSettingsRequest(service, body, name);
        }

        /// <summary>Updates an organization's settings.</summary>
        public class UpdateOrganizationSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.OrganizationSettings>
        {
            /// <summary>Constructs a new UpdateOrganizationSettings request.</summary>
            public UpdateOrganizationSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.OrganizationSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The relative resource name of the settings. See:
            /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
            /// "organizations/{organization_id}/organizationSettings".
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>
            /// The FieldMask to use when updating the settings resource. If empty all mutable fields will be updated.
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1.Data.OrganizationSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateOrganizationSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1/{+name}";

            /// <summary>Initializes UpdateOrganizationSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/organizationSettings$",
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

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Assets = new AssetsResource(service);
            BigQueryExports = new BigQueryExportsResource(service);
            Findings = new FindingsResource(service);
            MuteConfigs = new MuteConfigsResource(service);
            NotificationConfigs = new NotificationConfigsResource(service);
            SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettingsResource(service);
            Sources = new SourcesResource(service);
        }

        /// <summary>Gets the Assets resource.</summary>
        public virtual AssetsResource Assets { get; }

        /// <summary>The "assets" collection of methods.</summary>
        public class AssetsResource
        {
            private const string Resource = "assets";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public AssetsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Filters an organization's assets and groups them by their specified properties.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the parent to group the assets by. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual GroupRequest Group(Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest body, string parent)
            {
                return new GroupRequest(service, body, parent);
            }

            /// <summary>Filters an organization's assets and groups them by their specified properties.</summary>
            public class GroupRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsResponse>
            {
                /// <summary>Constructs a new Group request.</summary>
                public GroupRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the parent to group the assets by. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GroupAssetsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "group";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/assets:group";

                /// <summary>Initializes Group parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }

            /// <summary>Lists an organization's assets.</summary>
            /// <param name="parent">
            /// Required. The name of the parent resource that contains the assets. The value that you can specify on
            /// parent depends on the method in which you specify parent. You can specify one of the following values:
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists an organization's assets.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListAssetsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the parent resource that contains the assets. The value that you can specify
                /// on parent depends on the method in which you specify parent. You can specify one of the following
                /// values: "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// When compare_duration is set, the ListAssetsResult's "state_change" attribute is updated to indicate
                /// whether the asset was added, removed, or remained present during the compare_duration period of time
                /// that precedes the read_time. This is the time between (read_time - compare_duration) and read_time.
                /// The state_change value is derived based on the presence of the asset at the two points in time.
                /// Intermediate state changes between the two times don't affect the result. For example, the results
                /// aren't affected if the asset is removed and re-created again. Possible "state_change" values when
                /// compare_duration is specified: * "ADDED": indicates that the asset was not present at the start of
                /// compare_duration, but present at read_time. * "REMOVED": indicates that the asset was present at the
                /// start of compare_duration, but not present at read_time. * "ACTIVE": indicates that the asset was
                /// present at both the start and the end of the time period defined by compare_duration and read_time.
                /// If compare_duration is not specified, then the only possible state_change is "UNUSED", which will be
                /// the state_change set for all assets present at read_time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("compareDuration", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object CompareDuration { get; set; }

                /// <summary>
                /// A field mask to specify the ListAssetsResult fields to be listed in the response. An empty field
                /// mask will list all fields.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object FieldMask { get; set; }

                /// <summary>
                /// Expression that defines the filter to apply across assets. The expression is a list of zero or more
                /// restrictions combined via logical operators `AND` and `OR`. Parentheses are supported, and `OR` has
                /// higher precedence than `AND`. Restrictions have the form ` ` and may have a `-` character in front
                /// of them to indicate negation. The fields map to those defined in the Asset resource. Examples
                /// include: * name * security_center_properties.resource_name * resource_properties.a_property *
                /// security_marks.marks.marka The supported operators are: * `=` for all value types. * `&amp;gt;`,
                /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for integer values. * `:`, meaning substring matching, for
                /// strings. The supported value types are: * string literals in quotes. * integer literals without
                /// quotes. * boolean literals `true` and `false` without quotes. The following are the allowed field
                /// and operator combinations: * name: `=` * update_time: `=`, `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`,
                /// `&amp;lt;=` Usage: This should be milliseconds since epoch or an RFC3339 string. Examples:
                /// `update_time = "2019-06-10T16:07:18-07:00"` `update_time = 1560208038000` * create_time: `=`,
                /// `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be milliseconds since epoch or
                /// an RFC3339 string. Examples: `create_time = "2019-06-10T16:07:18-07:00"` `create_time =
                /// 1560208038000` * iam_policy.policy_blob: `=`, `:` * resource_properties: `=`, `:`, `&amp;gt;`,
                /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` * security_marks.marks: `=`, `:` *
                /// security_center_properties.resource_name: `=`, `:` *
                /// security_center_properties.resource_display_name: `=`, `:` *
                /// security_center_properties.resource_type: `=`, `:` * security_center_properties.resource_parent:
                /// `=`, `:` * security_center_properties.resource_parent_display_name: `=`, `:` *
                /// security_center_properties.resource_project: `=`, `:` *
                /// security_center_properties.resource_project_display_name: `=`, `:` *
                /// security_center_properties.resource_owners: `=`, `:` For example, `resource_properties.size = 100`
                /// is a valid filter string. Use a partial match on the empty string to filter based on a property
                /// existing: `resource_properties.my_property : ""` Use a negated partial match on the empty string to
                /// filter based on a property not existing: `-resource_properties.my_property : ""`
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>
                /// Expression that defines what fields and order to use for sorting. The string value should follow SQL
                /// syntax: comma separated list of fields. For example: "name,resource_properties.a_property". The
                /// default sorting order is ascending. To specify descending order for a field, a suffix " desc" should
                /// be appended to the field name. For example: "name desc,resource_properties.a_property". Redundant
                /// space characters in the syntax are insignificant. "name desc,resource_properties.a_property" and "
                /// name desc , resource_properties.a_property " are equivalent. The following fields are supported:
                /// name update_time resource_properties security_marks.marks security_center_properties.resource_name
                /// security_center_properties.resource_display_name security_center_properties.resource_parent
                /// security_center_properties.resource_parent_display_name security_center_properties.resource_project
                /// security_center_properties.resource_project_display_name security_center_properties.resource_type
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>
                /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum
                /// is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListAssetsResponse`; indicates that this is a continuation of a
                /// prior `ListAssets` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>
                /// Time used as a reference point when filtering assets. The filter is limited to assets existing at
                /// the supplied time and their values are those at that specific time. Absence of this field will
                /// default to the API's version of NOW.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object ReadTime { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/assets";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("compareDuration", new Google.Apis.Discovery.Parameter
                    {
                        Name = "compareDuration",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                    {
                        Name = "fieldMask",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                    {
                        Name = "filter",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                    RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                    {
                        Name = "orderBy",
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
                    RequestParameters.Add("readTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "readTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Updates security marks.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The relative resource name of the SecurityMarks. See:
            /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
            /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
            /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
            /// </param>
            public virtual UpdateSecurityMarksRequest UpdateSecurityMarks(Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name)
            {
                return new UpdateSecurityMarksRequest(service, body, name);
            }

            /// <summary>Updates security marks.</summary>
            public class UpdateSecurityMarksRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks>
            {
                /// <summary>Constructs a new UpdateSecurityMarks request.</summary>
                public UpdateSecurityMarksRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The relative resource name of the SecurityMarks. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The time at which the updated SecurityMarks take effect. If not set uses current server time.
                /// Updates will be applied to the SecurityMarks that are active immediately preceding this time. Must
                /// be earlier or equal to the server time.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object StartTime { get; set; }

                /// <summary>
                /// The FieldMask to use when updating the security marks resource. The field mask must not contain
                /// duplicate fields. If empty or set to "marks", all marks will be replaced. Individual marks can be
                /// updated using "marks.".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "updateSecurityMarks";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes UpdateSecurityMarks parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/assets/[^/]+/securityMarks$",
                    });
                    RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                    {
                        Name = "startTime",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
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

        /// <summary>Gets the BigQueryExports resource.</summary>
        public virtual BigQueryExportsResource BigQueryExports { get; }

        /// <summary>The "bigQueryExports" collection of methods.</summary>
        public class BigQueryExportsResource
        {
            private const string Resource = "bigQueryExports";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public BigQueryExportsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a BigQuery export.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The name of the parent resource of the new BigQuery export. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a BigQuery export.</summary>
            public class CreateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the parent resource of the new BigQuery export. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. Unique identifier provided by the client within the parent scope. It must consist of only
                /// lowercase letters, numbers, and hyphens, must start with a letter, must end with either a letter or
                /// a number, and must be 63 characters or less.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("bigQueryExportId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string BigQueryExportId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/bigQueryExports";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("bigQueryExportId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "bigQueryExportId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes an existing BigQuery export.</summary>
            /// <param name="name">
            /// Required. The name of the BigQuery export to delete. Its format is
            /// organizations/{organization}/bigQueryExports/{export_id}, folders/{folder}/bigQueryExports/{export_id},
            /// or projects/{project}/bigQueryExports/{export_id}
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes an existing BigQuery export.</summary>
            public class DeleteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the BigQuery export to delete. Its format is
                /// organizations/{organization}/bigQueryExports/{export_id},
                /// folders/{folder}/bigQueryExports/{export_id}, or projects/{project}/bigQueryExports/{export_id}
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
                        Pattern = @"^projects/[^/]+/bigQueryExports/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a BigQuery export.</summary>
            /// <param name="name">
            /// Required. Name of the BigQuery export to retrieve. Its format is
            /// organizations/{organization}/bigQueryExports/{export_id}, folders/{folder}/bigQueryExports/{export_id},
            /// or projects/{project}/bigQueryExports/{export_id}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a BigQuery export.</summary>
            public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the BigQuery export to retrieve. Its format is
                /// organizations/{organization}/bigQueryExports/{export_id},
                /// folders/{folder}/bigQueryExports/{export_id}, or projects/{project}/bigQueryExports/{export_id}
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
                        Pattern = @"^projects/[^/]+/bigQueryExports/[^/]+$",
                    });
                }
            }

            /// <summary>
            /// Lists BigQuery exports. Note that when requesting BigQuery exports at a given level all exports under
            /// that level are also returned e.g. if requesting BigQuery exports under a folder, then all BigQuery
            /// exports immediately under the folder plus the ones created under the projects within the folder are
            /// returned.
            /// </summary>
            /// <param name="parent">
            /// Required. The parent, which owns the collection of BigQuery exports. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>
            /// Lists BigQuery exports. Note that when requesting BigQuery exports at a given level all exports under
            /// that level are also returned e.g. if requesting BigQuery exports under a folder, then all BigQuery
            /// exports immediately under the folder plus the ones created under the projects within the folder are
            /// returned.
            /// </summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListBigQueryExportsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent, which owns the collection of BigQuery exports. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of configs to return. The service may return fewer than this value. If
                /// unspecified, at most 10 configs will be returned. The maximum value is 1000; values above 1000 will
                /// be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListBigQueryExports` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListBigQueryExports` must match
                /// the call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/bigQueryExports";

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
                        Pattern = @"^projects/[^/]+$",
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

            /// <summary>Updates a BigQuery export.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The relative resource name of this export. See:
            /// https://cloud.google.com/apis/design/resource_names#relative_resource_name. Example format:
            /// "organizations/{organization_id}/bigQueryExports/{export_id}" Example format:
            /// "folders/{folder_id}/bigQueryExports/{export_id}" Example format:
            /// "projects/{project_id}/bigQueryExports/{export_id}" This field is provided in responses, and is ignored
            /// when provided in create requests.
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a BigQuery export.</summary>
            public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The relative resource name of this export. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name. Example format:
                /// "organizations/{organization_id}/bigQueryExports/{export_id}" Example format:
                /// "folders/{folder_id}/bigQueryExports/{export_id}" Example format:
                /// "projects/{project_id}/bigQueryExports/{export_id}" This field is provided in responses, and is
                /// ignored when provided in create requests.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The list of fields to be updated. If empty all mutable fields will be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1BigQueryExport Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/bigQueryExports/[^/]+$",
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

        /// <summary>Gets the Findings resource.</summary>
        public virtual FindingsResource Findings { get; }

        /// <summary>The "findings" collection of methods.</summary>
        public class FindingsResource
        {
            private const string Resource = "findings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public FindingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Kicks off an LRO to bulk mute findings for a parent based on a filter. The parent can be either an
            /// organization, folder or project. The findings matched by the filter will be muted after the LRO is done.
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. The parent, at which bulk action needs to be applied. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
            /// </param>
            public virtual BulkMuteRequest BulkMute(Google.Apis.SecurityCommandCenter.v1.Data.BulkMuteFindingsRequest body, string parent)
            {
                return new BulkMuteRequest(service, body, parent);
            }

            /// <summary>
            /// Kicks off an LRO to bulk mute findings for a parent based on a filter. The parent can be either an
            /// organization, folder or project. The findings matched by the filter will be muted after the LRO is done.
            /// </summary>
            public class BulkMuteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Operation>
            {
                /// <summary>Constructs a new BulkMute request.</summary>
                public BulkMuteRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.BulkMuteFindingsRequest body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent, at which bulk action needs to be applied. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.BulkMuteFindingsRequest Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "bulkMute";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/findings:bulkMute";

                /// <summary>Initializes BulkMute parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                    {
                        Name = "parent",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+$",
                    });
                }
            }
        }

        /// <summary>Gets the MuteConfigs resource.</summary>
        public virtual MuteConfigsResource MuteConfigs { get; }

        /// <summary>The "muteConfigs" collection of methods.</summary>
        public class MuteConfigsResource
        {
            private const string Resource = "muteConfigs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public MuteConfigsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a mute config.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name of the new mute configs's parent. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a mute config.</summary>
            public class CreateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the new mute configs's parent. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. Unique identifier provided by the client within the parent scope. It must consist of only
                /// lowercase letters, numbers, and hyphens, must start with a letter, must end with either a letter or
                /// a number, and must be 63 characters or less.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("muteConfigId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string MuteConfigId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/muteConfigs";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("muteConfigId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "muteConfigId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes an existing mute config.</summary>
            /// <param name="name">
            /// Required. Name of the mute config to delete. Its format is
            /// organizations/{organization}/muteConfigs/{config_id}, folders/{folder}/muteConfigs/{config_id}, or
            /// projects/{project}/muteConfigs/{config_id}
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes an existing mute config.</summary>
            public class DeleteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the mute config to delete. Its format is
                /// organizations/{organization}/muteConfigs/{config_id}, folders/{folder}/muteConfigs/{config_id}, or
                /// projects/{project}/muteConfigs/{config_id}
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
                        Pattern = @"^projects/[^/]+/muteConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a mute config.</summary>
            /// <param name="name">
            /// Required. Name of the mute config to retrieve. Its format is
            /// organizations/{organization}/muteConfigs/{config_id}, folders/{folder}/muteConfigs/{config_id}, or
            /// projects/{project}/muteConfigs/{config_id}
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a mute config.</summary>
            public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the mute config to retrieve. Its format is
                /// organizations/{organization}/muteConfigs/{config_id}, folders/{folder}/muteConfigs/{config_id}, or
                /// projects/{project}/muteConfigs/{config_id}
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
                        Pattern = @"^projects/[^/]+/muteConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Lists mute configs.</summary>
            /// <param name="parent">
            /// Required. The parent, which owns the collection of mute configs. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists mute configs.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListMuteConfigsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The parent, which owns the collection of mute configs. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of configs to return. The service may return fewer than this value. If
                /// unspecified, at most 10 configs will be returned. The maximum value is 1000; values above 1000 will
                /// be coerced to 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// A page token, received from a previous `ListMuteConfigs` call. Provide this to retrieve the
                /// subsequent page. When paginating, all other parameters provided to `ListMuteConfigs` must match the
                /// call that provided the page token.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/muteConfigs";

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
                        Pattern = @"^projects/[^/]+$",
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

            /// <summary>Updates a mute config.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// This field will be ignored if provided on config creation. Format
            /// "organizations/{organization}/muteConfigs/{mute_config}" "folders/{folder}/muteConfigs/{mute_config}"
            /// "projects/{project}/muteConfigs/{mute_config}"
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates a mute config.</summary>
            public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// This field will be ignored if provided on config creation. Format
                /// "organizations/{organization}/muteConfigs/{mute_config}"
                /// "folders/{folder}/muteConfigs/{mute_config}" "projects/{project}/muteConfigs/{mute_config}"
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>The list of fields to be updated. If empty all mutable fields will be updated.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1MuteConfig Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/muteConfigs/[^/]+$",
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

        /// <summary>Gets the NotificationConfigs resource.</summary>
        public virtual NotificationConfigsResource NotificationConfigs { get; }

        /// <summary>The "notificationConfigs" collection of methods.</summary>
        public class NotificationConfigsResource
        {
            private const string Resource = "notificationConfigs";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public NotificationConfigsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>Creates a notification config.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">
            /// Required. Resource name of the new notification config's parent. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual CreateRequest Create(Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>Creates a notification config.</summary>
            public class CreateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig body, string parent) : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the new notification config's parent. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// Required. Unique identifier provided by the client within the parent scope. It must be between 1 and
                /// 128 characters and contain alphanumeric characters, underscores, or hyphens only.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("configId", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string ConfigId { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig Body { get; set; }

                /// <summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "create";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/notificationConfigs";

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
                        Pattern = @"^projects/[^/]+$",
                    });
                    RequestParameters.Add("configId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "configId",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                }
            }

            /// <summary>Deletes a notification config.</summary>
            /// <param name="name">
            /// Required. Name of the notification config to delete. Its format is
            /// "organizations/[organization_id]/notificationConfigs/[config_id]",
            /// "folders/[folder_id]/notificationConfigs/[config_id]", or
            /// "projects/[project_id]/notificationConfigs/[config_id]".
            /// </param>
            public virtual DeleteRequest Delete(string name)
            {
                return new DeleteRequest(service, name);
            }

            /// <summary>Deletes a notification config.</summary>
            public class DeleteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the notification config to delete. Its format is
                /// "organizations/[organization_id]/notificationConfigs/[config_id]",
                /// "folders/[folder_id]/notificationConfigs/[config_id]", or
                /// "projects/[project_id]/notificationConfigs/[config_id]".
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
                        Pattern = @"^projects/[^/]+/notificationConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Gets a notification config.</summary>
            /// <param name="name">
            /// Required. Name of the notification config to get. Its format is
            /// "organizations/[organization_id]/notificationConfigs/[config_id]",
            /// "folders/[folder_id]/notificationConfigs/[config_id]", or
            /// "projects/[project_id]/notificationConfigs/[config_id]".
            /// </param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets a notification config.</summary>
            public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. Name of the notification config to get. Its format is
                /// "organizations/[organization_id]/notificationConfigs/[config_id]",
                /// "folders/[folder_id]/notificationConfigs/[config_id]", or
                /// "projects/[project_id]/notificationConfigs/[config_id]".
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
                        Pattern = @"^projects/[^/]+/notificationConfigs/[^/]+$",
                    });
                }
            }

            /// <summary>Lists notification configs.</summary>
            /// <param name="parent">
            /// Required. The name of the parent in which to list the notification configurations. Its format is
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists notification configs.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListNotificationConfigsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the parent in which to list the notification configurations. Its format is
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum
                /// is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListNotificationConfigsResponse`; indicates that this is a
                /// continuation of a prior `ListNotificationConfigs` call, and that the system should return the next
                /// page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/notificationConfigs";

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
                        Pattern = @"^projects/[^/]+$",
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
            ///  Updates a notification config. The following update fields are allowed: description, pubsub_topic,
            /// streaming_config.filter
            /// </summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">
            /// The relative resource name of this notification config. See:
            /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
            /// "organizations/{organization_id}/notificationConfigs/notify_public_bucket",
            /// "folders/{folder_id}/notificationConfigs/notify_public_bucket", or
            /// "projects/{project_id}/notificationConfigs/notify_public_bucket".
            /// </param>
            public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>
            ///  Updates a notification config. The following update fields are allowed: description, pubsub_topic,
            /// streaming_config.filter
            /// </summary>
            public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig body, string name) : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }

                /// <summary>
                /// The relative resource name of this notification config. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
                /// "organizations/{organization_id}/notificationConfigs/notify_public_bucket",
                /// "folders/{folder_id}/notificationConfigs/notify_public_bucket", or
                /// "projects/{project_id}/notificationConfigs/notify_public_bucket".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>
                /// The FieldMask to use when updating the notification config. If empty all mutable fields will be
                /// updated.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }

                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.SecurityCommandCenter.v1.Data.NotificationConfig Body { get; set; }

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
                        Pattern = @"^projects/[^/]+/notificationConfigs/[^/]+$",
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

        /// <summary>Gets the SecurityHealthAnalyticsSettings resource.</summary>
        public virtual SecurityHealthAnalyticsSettingsResource SecurityHealthAnalyticsSettings { get; }

        /// <summary>The "securityHealthAnalyticsSettings" collection of methods.</summary>
        public class SecurityHealthAnalyticsSettingsResource
        {
            private const string Resource = "securityHealthAnalyticsSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SecurityHealthAnalyticsSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                CustomModules = new CustomModulesResource(service);
                EffectiveCustomModules = new EffectiveCustomModulesResource(service);
            }

            /// <summary>Gets the CustomModules resource.</summary>
            public virtual CustomModulesResource CustomModules { get; }

            /// <summary>The "customModules" collection of methods.</summary>
            public class CustomModulesResource
            {
                private const string Resource = "customModules";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public CustomModulesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>
                /// Creates a resident SecurityHealthAnalyticsCustomModule at the scope of the given CRM parent, and
                /// also creates inherited SecurityHealthAnalyticsCustomModules for all CRM descendants of the given
                /// parent. These modules are enabled by default.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Resource name of the new custom module's parent. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings",
                /// "folders/{folder}/securityHealthAnalyticsSettings", or
                /// "projects/{project}/securityHealthAnalyticsSettings"
                /// </param>
                public virtual CreateRequest Create(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>
                /// Creates a resident SecurityHealthAnalyticsCustomModule at the scope of the given CRM parent, and
                /// also creates inherited SecurityHealthAnalyticsCustomModules for all CRM descendants of the given
                /// parent. These modules are enabled by default.
                /// </summary>
                public class CreateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Resource name of the new custom module's parent. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings",
                    /// "folders/{folder}/securityHealthAnalyticsSettings", or
                    /// "projects/{project}/securityHealthAnalyticsSettings"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/customModules";

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
                            Pattern = @"^projects/[^/]+/securityHealthAnalyticsSettings$",
                        });
                    }
                }

                /// <summary>
                /// Deletes the specified SecurityHealthAnalyticsCustomModule and all of its descendants in the CRM
                /// hierarchy. This method is only supported for resident custom modules.
                /// </summary>
                /// <param name="name">
                /// Required. Name of the custom module to delete. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}",
                /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}"
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>
                /// Deletes the specified SecurityHealthAnalyticsCustomModule and all of its descendants in the CRM
                /// hierarchy. This method is only supported for resident custom modules.
                /// </summary>
                public class DeleteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the custom module to delete. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}",
                    /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                    /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}"
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
                            Pattern = @"^projects/[^/]+/securityHealthAnalyticsSettings/customModules/[^/]+$",
                        });
                    }
                }

                /// <summary>Retrieves a SecurityHealthAnalyticsCustomModule.</summary>
                /// <param name="name">
                /// Required. Name of the custom module to get. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}",
                /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}"
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Retrieves a SecurityHealthAnalyticsCustomModule.</summary>
                public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the custom module to get. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}",
                    /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                    /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}"
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
                            Pattern = @"^projects/[^/]+/securityHealthAnalyticsSettings/customModules/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns a list of all SecurityHealthAnalyticsCustomModules for the given parent. This includes
                /// resident modules defined at the scope of the parent, and inherited modules, inherited from CRM
                /// ancestors.
                /// </summary>
                /// <param name="parent">
                /// Required. Name of parent to list custom modules. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings",
                /// "folders/{folder}/securityHealthAnalyticsSettings", or
                /// "projects/{project}/securityHealthAnalyticsSettings"
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Returns a list of all SecurityHealthAnalyticsCustomModules for the given parent. This includes
                /// resident modules defined at the scope of the parent, and inherited modules, inherited from CRM
                /// ancestors.
                /// </summary>
                public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListSecurityHealthAnalyticsCustomModulesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of parent to list custom modules. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings",
                    /// "folders/{folder}/securityHealthAnalyticsSettings", or
                    /// "projects/{project}/securityHealthAnalyticsSettings"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of results to return in a single response. Default is 10, minimum is 1,
                    /// maximum is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The value returned by the last call indicating a continuation</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/customModules";

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
                            Pattern = @"^projects/[^/]+/securityHealthAnalyticsSettings$",
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
                /// Returns a list of all resident SecurityHealthAnalyticsCustomModules under the given CRM parent and
                /// all of the parent’s CRM descendants.
                /// </summary>
                /// <param name="parent">
                /// Required. Name of parent to list descendant custom modules. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings",
                /// "folders/{folder}/securityHealthAnalyticsSettings", or
                /// "projects/{project}/securityHealthAnalyticsSettings"
                /// </param>
                public virtual ListDescendantRequest ListDescendant(string parent)
                {
                    return new ListDescendantRequest(service, parent);
                }

                /// <summary>
                /// Returns a list of all resident SecurityHealthAnalyticsCustomModules under the given CRM parent and
                /// all of the parent’s CRM descendants.
                /// </summary>
                public class ListDescendantRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListDescendantSecurityHealthAnalyticsCustomModulesResponse>
                {
                    /// <summary>Constructs a new ListDescendant request.</summary>
                    public ListDescendantRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of parent to list descendant custom modules. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings",
                    /// "folders/{folder}/securityHealthAnalyticsSettings", or
                    /// "projects/{project}/securityHealthAnalyticsSettings"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of results to return in a single response. Default is 10, minimum is 1,
                    /// maximum is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The value returned by the last call indicating a continuation</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "listDescendant";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/customModules:listDescendant";

                    /// <summary>Initializes ListDescendant parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/securityHealthAnalyticsSettings$",
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
                /// Updates the SecurityHealthAnalyticsCustomModule under the given name based on the given update mask.
                /// Updating the enablement state is supported on both resident and inherited modules (though resident
                /// modules cannot have an enablement state of "inherited"). Updating the display name and custom config
                /// of a module is supported on resident modules only.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Immutable. The resource name of the custom module. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}" The id
                /// {customModule} is server-generated and is not user settable. It will be a numeric id containing 1-20
                /// digits.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Updates the SecurityHealthAnalyticsCustomModule under the given name based on the given update mask.
                /// Updating the enablement state is supported on both resident and inherited modules (though resident
                /// modules cannot have an enablement state of "inherited"). Updating the display name and custom config
                /// of a module is supported on resident modules only.
                /// </summary>
                public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Immutable. The resource name of the custom module. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                    /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
                    /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}" The id
                    /// {customModule} is server-generated and is not user settable. It will be a numeric id containing
                    /// 1-20 digits.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The list of fields to update.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/securityHealthAnalyticsSettings/customModules/[^/]+$",
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

            /// <summary>Gets the EffectiveCustomModules resource.</summary>
            public virtual EffectiveCustomModulesResource EffectiveCustomModules { get; }

            /// <summary>The "effectiveCustomModules" collection of methods.</summary>
            public class EffectiveCustomModulesResource
            {
                private const string Resource = "effectiveCustomModules";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public EffectiveCustomModulesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                }

                /// <summary>Retrieves an EffectiveSecurityHealthAnalyticsCustomModule.</summary>
                /// <param name="name">
                /// Required. Name of the effective custom module to get. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}",
                /// "folders/{folder}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}", or
                /// "projects/{project}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}"
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Retrieves an EffectiveSecurityHealthAnalyticsCustomModule.</summary>
                public class GetRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1EffectiveSecurityHealthAnalyticsCustomModule>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the effective custom module to get. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}",
                    /// "folders/{folder}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}", or
                    /// "projects/{project}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}"
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
                            Pattern = @"^projects/[^/]+/securityHealthAnalyticsSettings/effectiveCustomModules/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns a list of all EffectiveSecurityHealthAnalyticsCustomModules for the given parent. This
                /// includes resident modules defined at the scope of the parent, and inherited modules, inherited from
                /// CRM ancestors.
                /// </summary>
                /// <param name="parent">
                /// Required. Name of parent to list effective custom modules. Its format is
                /// "organizations/{organization}/securityHealthAnalyticsSettings",
                /// "folders/{folder}/securityHealthAnalyticsSettings", or
                /// "projects/{project}/securityHealthAnalyticsSettings"
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Returns a list of all EffectiveSecurityHealthAnalyticsCustomModules for the given parent. This
                /// includes resident modules defined at the scope of the parent, and inherited modules, inherited from
                /// CRM ancestors.
                /// </summary>
                public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListEffectiveSecurityHealthAnalyticsCustomModulesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of parent to list effective custom modules. Its format is
                    /// "organizations/{organization}/securityHealthAnalyticsSettings",
                    /// "folders/{folder}/securityHealthAnalyticsSettings", or
                    /// "projects/{project}/securityHealthAnalyticsSettings"
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of results to return in a single response. Default is 10, minimum is 1,
                    /// maximum is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The value returned by the last call indicating a continuation</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/effectiveCustomModules";

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
                            Pattern = @"^projects/[^/]+/securityHealthAnalyticsSettings$",
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
        }

        /// <summary>Gets the Sources resource.</summary>
        public virtual SourcesResource Sources { get; }

        /// <summary>The "sources" collection of methods.</summary>
        public class SourcesResource
        {
            private const string Resource = "sources";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SourcesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Findings = new FindingsResource(service);
            }

            /// <summary>Gets the Findings resource.</summary>
            public virtual FindingsResource Findings { get; }

            /// <summary>The "findings" collection of methods.</summary>
            public class FindingsResource
            {
                private const string Resource = "findings";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public FindingsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    ExternalSystems = new ExternalSystemsResource(service);
                }

                /// <summary>Gets the ExternalSystems resource.</summary>
                public virtual ExternalSystemsResource ExternalSystems { get; }

                /// <summary>The "externalSystems" collection of methods.</summary>
                public class ExternalSystemsResource
                {
                    private const string Resource = "externalSystems";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ExternalSystemsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>Updates external system. This is for a given finding.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Full resource name of the external system, for example:
                    /// "organizations/1234/sources/5678/findings/123456/externalSystems/jira",
                    /// "folders/1234/sources/5678/findings/123456/externalSystems/jira",
                    /// "projects/1234/sources/5678/findings/123456/externalSystems/jira"
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1ExternalSystem body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates external system. This is for a given finding.</summary>
                    public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1ExternalSystem>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1ExternalSystem body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Full resource name of the external system, for example:
                        /// "organizations/1234/sources/5678/findings/123456/externalSystems/jira",
                        /// "folders/1234/sources/5678/findings/123456/externalSystems/jira",
                        /// "projects/1234/sources/5678/findings/123456/externalSystems/jira"
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// The FieldMask to use when updating the external system resource. If empty all mutable fields
                        /// will be updated.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.SecurityCommandCenter.v1.Data.GoogleCloudSecuritycenterV1ExternalSystem Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/sources/[^/]+/findings/[^/]+/externalSystems/[^/]+$",
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

                /// <summary>
                /// Filters an organization or source's findings and groups them by their specified properties. To group
                /// across all sources provide a `-` as the source id. Example:
                /// /v1/organizations/{organization_id}/sources/-/findings, /v1/folders/{folder_id}/sources/-/findings,
                /// /v1/projects/{project_id}/sources/-/findings
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. Name of the source to groupBy. Its format is
                /// "organizations/[organization_id]/sources/[source_id]", folders/[folder_id]/sources/[source_id], or
                /// projects/[project_id]/sources/[source_id]. To groupBy across all sources provide a source_id of `-`.
                /// For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/-, or
                /// projects/{project_id}/sources/-
                /// </param>
                public virtual GroupRequest Group(Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest body, string parent)
                {
                    return new GroupRequest(service, body, parent);
                }

                /// <summary>
                /// Filters an organization or source's findings and groups them by their specified properties. To group
                /// across all sources provide a `-` as the source id. Example:
                /// /v1/organizations/{organization_id}/sources/-/findings, /v1/folders/{folder_id}/sources/-/findings,
                /// /v1/projects/{project_id}/sources/-/findings
                /// </summary>
                public class GroupRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsResponse>
                {
                    /// <summary>Constructs a new Group request.</summary>
                    public GroupRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the source to groupBy. Its format is
                    /// "organizations/[organization_id]/sources/[source_id]", folders/[folder_id]/sources/[source_id],
                    /// or projects/[project_id]/sources/[source_id]. To groupBy across all sources provide a source_id
                    /// of `-`. For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/-,
                    /// or projects/{project_id}/sources/-
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.GroupFindingsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "group";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/findings:group";

                    /// <summary>Initializes Group parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/sources/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Lists an organization or source's findings. To list across all sources provide a `-` as the source
                /// id. Example: /v1/organizations/{organization_id}/sources/-/findings
                /// </summary>
                /// <param name="parent">
                /// Required. Name of the source the findings belong to. Its format is
                /// "organizations/[organization_id]/sources/[source_id], folders/[folder_id]/sources/[source_id], or
                /// projects/[project_id]/sources/[source_id]". To list across all sources provide a source_id of `-`.
                /// For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/- or
                /// projects/{projects_id}/sources/-
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>
                /// Lists an organization or source's findings. To list across all sources provide a `-` as the source
                /// id. Example: /v1/organizations/{organization_id}/sources/-/findings
                /// </summary>
                public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListFindingsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. Name of the source the findings belong to. Its format is
                    /// "organizations/[organization_id]/sources/[source_id], folders/[folder_id]/sources/[source_id],
                    /// or projects/[project_id]/sources/[source_id]". To list across all sources provide a source_id of
                    /// `-`. For example: organizations/{organization_id}/sources/-, folders/{folder_id}/sources/- or
                    /// projects/{projects_id}/sources/-
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// When compare_duration is set, the ListFindingsResult's "state_change" attribute is updated to
                    /// indicate whether the finding had its state changed, the finding's state remained unchanged, or
                    /// if the finding was added in any state during the compare_duration period of time that precedes
                    /// the read_time. This is the time between (read_time - compare_duration) and read_time. The
                    /// state_change value is derived based on the presence and state of the finding at the two points
                    /// in time. Intermediate state changes between the two times don't affect the result. For example,
                    /// the results aren't affected if the finding is made inactive and then active again. Possible
                    /// "state_change" values when compare_duration is specified: * "CHANGED": indicates that the
                    /// finding was present and matched the given filter at the start of compare_duration, but changed
                    /// its state at read_time. * "UNCHANGED": indicates that the finding was present and matched the
                    /// given filter at the start of compare_duration and did not change state at read_time. * "ADDED":
                    /// indicates that the finding did not match the given filter or was not present at the start of
                    /// compare_duration, but was present at read_time. * "REMOVED": indicates that the finding was
                    /// present and matched the filter at the start of compare_duration, but did not match the filter at
                    /// read_time. If compare_duration is not specified, then the only possible state_change is
                    /// "UNUSED", which will be the state_change set for all findings present at read_time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("compareDuration", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object CompareDuration { get; set; }

                    /// <summary>
                    /// A field mask to specify the Finding fields to be listed in the response. An empty field mask
                    /// will list all fields.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object FieldMask { get; set; }

                    /// <summary>
                    /// Expression that defines the filter to apply across findings. The expression is a list of one or
                    /// more restrictions combined via logical operators `AND` and `OR`. Parentheses are supported, and
                    /// `OR` has higher precedence than `AND`. Restrictions have the form ` ` and may have a `-`
                    /// character in front of them to indicate negation. Examples include: * name *
                    /// source_properties.a_property * security_marks.marks.marka The supported operators are: * `=` for
                    /// all value types. * `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for integer values. * `:`,
                    /// meaning substring matching, for strings. The supported value types are: * string literals in
                    /// quotes. * integer literals without quotes. * boolean literals `true` and `false` without quotes.
                    /// The following field and operator combinations are supported: * name: `=` * parent: `=`, `:` *
                    /// resource_name: `=`, `:` * state: `=`, `:` * category: `=`, `:` * external_uri: `=`, `:` *
                    /// event_time: `=`, `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be
                    /// milliseconds since epoch or an RFC3339 string. Examples: `event_time =
                    /// "2019-06-10T16:07:18-07:00"` `event_time = 1560208038000` * severity: `=`, `:` * workflow_state:
                    /// `=`, `:` * security_marks.marks: `=`, `:` * source_properties: `=`, `:`, `&amp;gt;`, `&amp;lt;`,
                    /// `&amp;gt;=`, `&amp;lt;=` For example, `source_properties.size = 100` is a valid filter string.
                    /// Use a partial match on the empty string to filter based on a property existing:
                    /// `source_properties.my_property : ""` Use a negated partial match on the empty string to filter
                    /// based on a property not existing: `-source_properties.my_property : ""` * resource: *
                    /// resource.name: `=`, `:` * resource.parent_name: `=`, `:` * resource.parent_display_name: `=`,
                    /// `:` * resource.project_name: `=`, `:` * resource.project_display_name: `=`, `:` * resource.type:
                    /// `=`, `:` * resource.folders.resource_folder: `=`, `:` * resource.display_name: `=`, `:`
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string Filter { get; set; }

                    /// <summary>
                    /// Expression that defines what fields and order to use for sorting. The string value should follow
                    /// SQL syntax: comma separated list of fields. For example: "name,resource_properties.a_property".
                    /// The default sorting order is ascending. To specify descending order for a field, a suffix "
                    /// desc" should be appended to the field name. For example: "name
                    /// desc,source_properties.a_property". Redundant space characters in the syntax are insignificant.
                    /// "name desc,source_properties.a_property" and " name desc , source_properties.a_property " are
                    /// equivalent. The following fields are supported: name parent state category resource_name
                    /// event_time source_properties security_marks.marks
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string OrderBy { get; set; }

                    /// <summary>
                    /// The maximum number of results to return in a single response. Default is 10, minimum is 1,
                    /// maximum is 1000.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListFindingsResponse`; indicates that this is a continuation of
                    /// a prior `ListFindings` call, and that the system should return the next page of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>
                    /// Time used as a reference point when filtering findings. The filter is limited to findings
                    /// existing at the supplied time and their values are those at that specific time. Absence of this
                    /// field will default to the API's version of NOW.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("readTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object ReadTime { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/findings";

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
                            Pattern = @"^projects/[^/]+/sources/[^/]+$",
                        });
                        RequestParameters.Add("compareDuration", new Google.Apis.Discovery.Parameter
                        {
                            Name = "compareDuration",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "fieldMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
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
                        RequestParameters.Add("readTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "readTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Creates or updates a finding. The corresponding source must exist for a finding creation to succeed.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The [relative resource
                /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the finding.
                /// Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.SecurityCommandCenter.v1.Data.Finding body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>
                /// Creates or updates a finding. The corresponding source must exist for a finding creation to succeed.
                /// </summary>
                public class PatchRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Finding>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.Finding body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The [relative resource
                    /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the
                    /// finding. Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                    /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                    /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The FieldMask to use when updating the finding resource. This field should not be specified when
                    /// creating a finding. When updating a finding, an empty mask is treated as updating all mutable
                    /// fields and replacing source_properties. Individual source_properties can be added/updated by
                    /// using "source_properties." in the field mask.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.Finding Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/sources/[^/]+/findings/[^/]+$",
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

                /// <summary>Updates the mute state of a finding.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The [relative resource
                /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the finding.
                /// Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                /// </param>
                public virtual SetMuteRequest SetMute(Google.Apis.SecurityCommandCenter.v1.Data.SetMuteRequest body, string name)
                {
                    return new SetMuteRequest(service, body, name);
                }

                /// <summary>Updates the mute state of a finding.</summary>
                public class SetMuteRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Finding>
                {
                    /// <summary>Constructs a new SetMute request.</summary>
                    public SetMuteRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SetMuteRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The [relative resource
                    /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the
                    /// finding. Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                    /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                    /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.SetMuteRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setMute";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setMute";

                    /// <summary>Initializes SetMute parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/sources/[^/]+/findings/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates the state of a finding.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// Required. The [relative resource
                /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the finding.
                /// Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                /// </param>
                public virtual SetStateRequest SetState(Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest body, string name)
                {
                    return new SetStateRequest(service, body, name);
                }

                /// <summary>Updates the state of a finding.</summary>
                public class SetStateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.Finding>
                {
                    /// <summary>Constructs a new SetState request.</summary>
                    public SetStateRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The [relative resource
                    /// name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of the
                    /// finding. Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
                    /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
                    /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.SetFindingStateRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setState";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:setState";

                    /// <summary>Initializes SetState parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/sources/[^/]+/findings/[^/]+$",
                        });
                    }
                }

                /// <summary>Updates security marks.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The relative resource name of the SecurityMarks. See:
                /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                /// </param>
                public virtual UpdateSecurityMarksRequest UpdateSecurityMarks(Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name)
                {
                    return new UpdateSecurityMarksRequest(service, body, name);
                }

                /// <summary>Updates security marks.</summary>
                public class UpdateSecurityMarksRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks>
                {
                    /// <summary>Constructs a new UpdateSecurityMarks request.</summary>
                    public UpdateSecurityMarksRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The relative resource name of the SecurityMarks. See:
                    /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
                    /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
                    /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// The time at which the updated SecurityMarks take effect. If not set uses current server time.
                    /// Updates will be applied to the SecurityMarks that are active immediately preceding this time.
                    /// Must be earlier or equal to the server time.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object StartTime { get; set; }

                    /// <summary>
                    /// The FieldMask to use when updating the security marks resource. The field mask must not contain
                    /// duplicate fields. If empty or set to "marks", all marks will be replaced. Individual marks can
                    /// be updated using "marks.".
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1.Data.SecurityMarks Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateSecurityMarks";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes UpdateSecurityMarks parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/sources/[^/]+/findings/[^/]+/securityMarks$",
                        });
                        RequestParameters.Add("startTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
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

            /// <summary>Lists all sources belonging to an organization.</summary>
            /// <param name="parent">
            /// Required. Resource name of the parent of sources to list. Its format should be
            /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
            /// </param>
            public virtual ListRequest List(string parent)
            {
                return new ListRequest(service, parent);
            }

            /// <summary>Lists all sources belonging to an organization.</summary>
            public class ListRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1.Data.ListSourcesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                {
                    Parent = parent;
                    InitParameters();
                }

                /// <summary>
                /// Required. Resource name of the parent of sources to list. Its format should be
                /// "organizations/[organization_id]", "folders/[folder_id]", or "projects/[project_id]".
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }

                /// <summary>
                /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum
                /// is 1000.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>
                /// The value returned by the last `ListSourcesResponse`; indicates that this is a continuation of a
                /// prior `ListSources` call, and that the system should return the next page of data.
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "list";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+parent}/sources";

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
                        Pattern = @"^projects/[^/]+$",
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
    }
}
namespace Google.Apis.SecurityCommandCenter.v1.Data
{
    /// <summary>Represents an access event.</summary>
    public class Access : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Caller's IP address, such as "1.1.1.1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callerIp")]
        public virtual string CallerIp { get; set; }

        /// <summary>The caller IP's geolocation, which identifies where the call came from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callerIpGeo")]
        public virtual Geolocation CallerIpGeo { get; set; }

        /// <summary>The method that the service account called, e.g. "SetIamPolicy".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodName")]
        public virtual string MethodName { get; set; }

        /// <summary>
        /// Associated email, such as "foo@google.com". The email address of the authenticated user or a service account
        /// acting on behalf of a third party principal making the request. For third party identity callers, the
        /// `principal_subject` field is populated instead of this field. For privacy reasons, the principal email
        /// address is sometimes redacted. For more information, see [Caller identities in audit
        /// logs](https://cloud.google.com/logging/docs/audit#user-id).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        /// <summary>
        /// A string that represents the principal_subject that is associated with the identity. Unlike
        /// `principal_email`, `principal_subject` supports principals that aren't associated with email addresses, such
        /// as third party principals. For most identities, the format is `principal://iam.googleapis.com/{identity pool
        /// name}/subject/{subject}`. Some GKE identities, such as GKE_WORKLOAD, FREEFORM, and GKE_HUB_WORKLOAD, still
        /// use the legacy format `serviceAccount:{identity pool name}[{subject}]`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        /// <summary>
        /// The identity delegation history of an authenticated service account that made the request. The
        /// `serviceAccountDelegationInfo[]` object contains information about the real authorities that try to access
        /// Google Cloud resources by delegating on a service account. When multiple authorities are present, they are
        /// guaranteed to be sorted based on the original ordering of the identity delegation events.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountDelegationInfo")]
        public virtual System.Collections.Generic.IList<ServiceAccountDelegationInfo> ServiceAccountDelegationInfo { get; set; }

        /// <summary>
        /// The name of the service account key that was used to create or exchange credentials when authenticating the
        /// service account that made the request. This is a scheme-less URI full resource name. For example:
        /// "//iam.googleapis.com/projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountKeyName")]
        public virtual string ServiceAccountKeyName { get; set; }

        /// <summary>
        /// This is the API service that the service account made a call to, e.g. "iam.googleapis.com"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>The caller's user agent string associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgent")]
        public virtual string UserAgent { get; set; }

        /// <summary>
        /// Type of user agent associated with the finding. For example, an operating system shell or an embedded or
        /// standalone application.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgentFamily")]
        public virtual string UserAgentFamily { get; set; }

        /// <summary>
        /// A string that represents a username. The username provided depends on the type of the finding and is likely
        /// not an IAM principal. For example, this can be a system username if the finding is related to a virtual
        /// machine, or it can be an application login username.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Conveys information about a Kubernetes access review (such as one returned by a [`kubectl auth
    /// can-i`](https://kubernetes.io/docs/reference/access-authn-authz/authorization/#checking-api-access) command)
    /// that was involved in a finding.
    /// </summary>
    public class AccessReview : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The API group of the resource. "*" means all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>The name of the resource being requested. Empty means all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Namespace of the action being requested. Currently, there is no distinction between no namespace and all
        /// namespaces. Both are represented by "" (empty).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The optional resource type requested. "*" means all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>The optional subresource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subresource")]
        public virtual string Subresource { get; set; }

        /// <summary>
        /// A Kubernetes resource API verb, like get, list, watch, create, update, delete, proxy. "*" means all.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>The API version of the resource. "*" means all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Security Command Center representation of a Google Cloud resource. The Asset is a Security Command Center
    /// resource that captures information about a single Google Cloud resource. All modifications to an Asset are only
    /// within the context of Security Command Center and don't affect the referenced Google Cloud resource.
    /// </summary>
    public class Asset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The canonical name of the resource. It's either "organizations/{organization_id}/assets/{asset_id}",
        /// "folders/{folder_id}/assets/{asset_id}" or "projects/{project_number}/assets/{asset_id}", depending on the
        /// closest CRM ancestor of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The time at which the asset was created in Security Command Center.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// Cloud IAM Policy information associated with the Google Cloud resource described by the Security Command
        /// Center asset. This information is managed and defined by the Google Cloud resource and cannot be modified by
        /// the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iamPolicy")]
        public virtual IamPolicy IamPolicy { get; set; }

        /// <summary>
        /// The relative resource name of this asset. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
        /// "organizations/{organization_id}/assets/{asset_id}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Resource managed properties. These properties are managed and defined by the Google Cloud resource and
        /// cannot be modified by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceProperties")]
        public virtual System.Collections.Generic.IDictionary<string, object> ResourceProperties { get; set; }

        /// <summary>
        /// Security Command Center managed properties. These properties are managed by Security Command Center and
        /// cannot be modified by the user.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityCenterProperties")]
        public virtual SecurityCenterProperties SecurityCenterProperties { get; set; }

        /// <summary>
        /// User specified security marks. These marks are entirely managed by the user and come from the SecurityMarks
        /// resource that belongs to the asset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityMarks")]
        public virtual SecurityMarks SecurityMarks { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>The time at which the asset was last updated or added in Cloud SCC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration used for Asset Discovery runs.</summary>
    public class AssetDiscoveryConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The folder ids to use for filtering asset discovery. It consists of only digits, e.g., 756619654966.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folderIds")]
        public virtual System.Collections.Generic.IList<string> FolderIds { get; set; }

        /// <summary>The mode to use for filtering asset discovery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inclusionMode")]
        public virtual string InclusionMode { get; set; }

        /// <summary>The project ids to use for filtering asset discovery.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectIds")]
        public virtual System.Collections.Generic.IList<string> ProjectIds { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Specifies the audit configuration for a service. The configuration determines which permission types are logged,
    /// and what identities, if any, are exempted from logging. An AuditConfig must have one or more AuditLogConfigs. If
    /// there are AuditConfigs for both `allServices` and a specific service, the union of the two AuditConfigs is used
    /// for that service: the log_types specified in each AuditConfig are enabled, and the exempted_members in each
    /// AuditLogConfig are exempted. Example Policy with multiple AuditConfigs: { "audit_configs": [ { "service":
    /// "allServices", "audit_log_configs": [ { "log_type": "DATA_READ", "exempted_members": [ "user:jose@example.com" ]
    /// }, { "log_type": "DATA_WRITE" }, { "log_type": "ADMIN_READ" } ] }, { "service": "sampleservice.googleapis.com",
    /// "audit_log_configs": [ { "log_type": "DATA_READ" }, { "log_type": "DATA_WRITE", "exempted_members": [
    /// "user:aliya@example.com" ] } ] } ] } For sampleservice, this policy enables DATA_READ, DATA_WRITE and ADMIN_READ
    /// logging. It also exempts `jose@example.com` from DATA_READ logging, and `aliya@example.com` from DATA_WRITE
    /// logging.
    /// </summary>
    public class AuditConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration for logging of each type of permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditLogConfigs")]
        public virtual System.Collections.Generic.IList<AuditLogConfig> AuditLogConfigs { get; set; }

        /// <summary>
        /// Specifies a service that will be enabled for audit logging. For example, `storage.googleapis.com`,
        /// `cloudsql.googleapis.com`. `allServices` is a special value that covers all services.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("service")]
        public virtual string Service { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Provides the configuration for logging a type of permissions. Example: { "audit_log_configs": [ { "log_type":
    /// "DATA_READ", "exempted_members": [ "user:jose@example.com" ] }, { "log_type": "DATA_WRITE" } ] } This enables
    /// 'DATA_READ' and 'DATA_WRITE' logging, while exempting jose@example.com from DATA_READ logging.
    /// </summary>
    public class AuditLogConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Specifies the identities that do not cause logging for this type of permission. Follows the same format of
        /// Binding.members.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exemptedMembers")]
        public virtual System.Collections.Generic.IList<string> ExemptedMembers { get; set; }

        /// <summary>The log type that this config enables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logType")]
        public virtual string LogType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the principals requesting access for a Google Cloud resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. Does not include identities that come from external identity
        /// providers (IdPs) through identity federation. * `user:{emailid}`: An email address that represents a
        /// specific Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address
        /// that represents a Google service account. For example, `my-other-app@appspot.gserviceaccount.com`. *
        /// `serviceAccount:{projectid}.svc.id.goog[{namespace}/{kubernetes-sa}]`: An identifier for a [Kubernetes
        /// service account](https://cloud.google.com/kubernetes-engine/docs/how-to/kubernetes-service-accounts). For
        /// example, `my-project.svc.id.goog[my-namespace/my-kubernetes-sa]`. * `group:{emailid}`: An email address that
        /// represents a Google group. For example, `admins@example.com`. * `domain:{domain}`: The G Suite domain
        /// (primary) that represents all the users of that domain. For example, `google.com` or `example.com`. *
        /// `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that
        /// has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Request message for bulk findings update. Note: 1. If multiple bulk update requests match the same resource, the
    /// order in which they get executed is not defined. 2. Once a bulk operation is started, there is no way to stop
    /// it.
    /// </summary>
    public class BulkMuteFindingsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Expression that identifies findings that should be updated. The expression is a list of zero or more
        /// restrictions combined via logical operators `AND` and `OR`. Parentheses are supported, and `OR` has higher
        /// precedence than `AND`. Restrictions have the form ` ` and may have a `-` character in front of them to
        /// indicate negation. The fields map to those defined in the corresponding resource. The supported operators
        /// are: * `=` for all value types. * `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for integer values. *
        /// `:`, meaning substring matching, for strings. The supported value types are: * string literals in quotes. *
        /// integer literals without quotes. * boolean literals `true` and `false` without quotes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// This can be a mute configuration name or any identifier for mute/unmute of findings based on the filter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteAnnotation")]
        public virtual string MuteAnnotation { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The [data profile](https://cloud.google.com/dlp/docs/data-profiles) associated with the finding.
    /// </summary>
    public class CloudDlpDataProfile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Name of the data profile, for example, `projects/123/locations/europe/tableProfiles/8383929`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataProfile")]
        public virtual string DataProfile { get; set; }

        /// <summary>The resource hierarchy level at which the data profile was generated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentType")]
        public virtual string ParentType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Details about the Cloud Data Loss Prevention (Cloud DLP) [inspection
    /// job](https://cloud.google.com/dlp/docs/concepts-job-triggers) that produced the finding.
    /// </summary>
    public class CloudDlpInspection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether Cloud DLP scanned the complete resource or a sampled subset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullScan")]
        public virtual System.Nullable<bool> FullScan { get; set; }

        /// <summary>
        /// The type of information (or *[infoType](https://cloud.google.com/dlp/docs/infotypes-reference)*) found, for
        /// example, `EMAIL_ADDRESS` or `STREET_ADDRESS`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoType")]
        public virtual string InfoType { get; set; }

        /// <summary>The number of times Cloud DLP found this infoType within this job and resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("infoTypeCount")]
        public virtual System.Nullable<long> InfoTypeCount { get; set; }

        /// <summary>
        /// Name of the inspection job, for example, `projects/123/locations/europe/dlpJobs/i-8383929`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inspectJob")]
        public virtual string InspectJob { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains compliance information about a security standard indicating unmet recommendations.</summary>
    public class Compliance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Policies within the standard or benchmark, for example, A.12.4.1</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ids")]
        public virtual System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>Industry-wide compliance standards or benchmarks, such as CIS, PCI, and OWASP.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standard")]
        public virtual string Standard { get; set; }

        /// <summary>Version of the standard or benchmark, for example, 1.1</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about the IP connection associated with the finding.</summary>
    public class Connection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Destination IP address. Not present for sockets that are listening and not connected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationIp")]
        public virtual string DestinationIp { get; set; }

        /// <summary>Destination port. Not present for sockets that are listening and not connected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationPort")]
        public virtual System.Nullable<int> DestinationPort { get; set; }

        /// <summary>IANA Internet Protocol Number such as TCP(6) and UDP(17).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>Source IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceIp")]
        public virtual string SourceIp { get; set; }

        /// <summary>Source port.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePort")]
        public virtual System.Nullable<int> SourcePort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The email address of a contact.</summary>
    public class Contact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An email address. For example, "`person123@company.com`".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details about specific contacts</summary>
    public class ContactDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of contacts</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual System.Collections.Generic.IList<Contact> Contacts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container associated with the finding.</summary>
    public class Container : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The time that the container was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// Optional container image ID, if provided by the container runtime. Uniquely identifies the container image
        /// launched using a container image digest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageId")]
        public virtual string ImageId { get; set; }

        /// <summary>Container labels, as provided by the container runtime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<Label> Labels { get; set; }

        /// <summary>Name of the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Container image URI provided when configuring a pod or container. This string can identify a container image
        /// version using mutable tags.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CVE stands for Common Vulnerabilities and Exposures. More information: https://cve.mitre.org</summary>
    public class Cve : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Describe Common Vulnerability Scoring System specified at
        /// https://www.first.org/cvss/v3.1/specification-document
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssv3")]
        public virtual Cvssv3 Cvssv3 { get; set; }

        /// <summary>The unique identifier for the vulnerability. e.g. CVE-2021-34527</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Additional information about the CVE. e.g. https://cve.mitre.org/cgi-bin/cvename.cgi?name=CVE-2021-34527
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("references")]
        public virtual System.Collections.Generic.IList<Reference> References { get; set; }

        /// <summary>Whether upstream fix is available for the CVE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upstreamFixAvailable")]
        public virtual System.Nullable<bool> UpstreamFixAvailable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Common Vulnerability Scoring System version 3.</summary>
    public class Cvssv3 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This metric describes the conditions beyond the attacker's control that must exist in order to exploit the
        /// vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackComplexity")]
        public virtual string AttackComplexity { get; set; }

        /// <summary>
        /// Base Metrics Represents the intrinsic characteristics of a vulnerability that are constant over time and
        /// across user environments. This metric reflects the context by which vulnerability exploitation is possible.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackVector")]
        public virtual string AttackVector { get; set; }

        /// <summary>
        /// This metric measures the impact to the availability of the impacted component resulting from a successfully
        /// exploited vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityImpact")]
        public virtual string AvailabilityImpact { get; set; }

        /// <summary>The base score is a function of the base metric scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseScore")]
        public virtual System.Nullable<double> BaseScore { get; set; }

        /// <summary>
        /// This metric measures the impact to the confidentiality of the information resources managed by a software
        /// component due to a successfully exploited vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidentialityImpact")]
        public virtual string ConfidentialityImpact { get; set; }

        /// <summary>This metric measures the impact to integrity of a successfully exploited vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrityImpact")]
        public virtual string IntegrityImpact { get; set; }

        /// <summary>
        /// This metric describes the level of privileges an attacker must possess before successfully exploiting the
        /// vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privilegesRequired")]
        public virtual string PrivilegesRequired { get; set; }

        /// <summary>
        /// The Scope metric captures whether a vulnerability in one vulnerable component impacts resources in
        /// components beyond its security scope.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>
        /// This metric captures the requirement for a human user, other than the attacker, to participate in the
        /// successful compromise of the vulnerable component.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInteraction")]
        public virtual string UserInteraction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents database access information, such as queries. A database may be a sub-resource of an instance (as in
    /// the case of Cloud SQL instances or Cloud Spanner instances), or the database instance itself. Some database
    /// resources might not have the [full resource name](https://google.aip.dev/122#full-resource-names) populated
    /// because these resource types, such as Cloud SQL databases, are not yet supported by Cloud Asset Inventory. In
    /// these cases only the display name is provided.
    /// </summary>
    public class Database : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable name of the database that the user connected to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The target usernames, roles, or groups of an SQL privilege grant, which is not an IAM policy change.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grantees")]
        public virtual System.Collections.Generic.IList<string> Grantees { get; set; }

        /// <summary>
        /// Some database resources may not have the [full resource
        /// name](https://google.aip.dev/122#full-resource-names) populated because these resource types are not yet
        /// supported by Cloud Asset Inventory (e.g. Cloud SQL databases). In these cases only the display name will be
        /// provided. The [full resource name](https://google.aip.dev/122#full-resource-names) of the database that the
        /// user connected to, if it is supported by Cloud Asset Inventory.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The SQL statement that is associated with the database access.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// The username used to connect to the database. The username might not be an IAM principal and does not have a
        /// set format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>
        /// The version of the database, for example, POSTGRES_14. See [the complete
        /// list](https://cloud.google.com/sql/docs/mysql/admin-api/rest/v1/SqlDatabaseVersion).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Memory hash detection contributing to the binary family match.</summary>
    public class Detection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the binary associated with the memory hash signature detection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binary")]
        public virtual string Binary { get; set; }

        /// <summary>The percentage of memory page hashes in the signature that were matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentPagesMatched")]
        public virtual System.Nullable<double> PercentPagesMatched { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A name-value pair representing an environment variable used in an operating system process.</summary>
    public class EnvironmentVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Environment variable name as a JSON encoded string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Environment variable value as a JSON encoded string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("val")]
        public virtual string Val { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource where data was exfiltrated from or exfiltrated to.</summary>
    public class ExfilResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Subcomponents of the asset that was exfiltrated, like URIs used during exfiltration, table names, databases,
        /// and filenames. For example, multiple tables might have been exfiltrated from the same Cloud SQL instance, or
        /// multiple files might have been exfiltrated from the same Cloud Storage bucket.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("components")]
        public virtual System.Collections.Generic.IList<string> Components { get; set; }

        /// <summary>
        /// The resource's [full resource name](https://cloud.google.com/apis/design/resource_names#full_resource_name).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Exfiltration represents a data exfiltration attempt from one or more sources to one or more targets. The
    /// `sources` attribute lists the sources of the exfiltrated data. The `targets` attribute lists the destinations
    /// the data was copied to.
    /// </summary>
    public class Exfiltration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there are multiple sources, then the data is considered "joined" between them. For instance, BigQuery can
        /// join multiple tables, and each table would be considered a source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<ExfilResource> Sources { get; set; }

        /// <summary>
        /// If there are multiple targets, each target would get a complete copy of the "joined" source data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targets")]
        public virtual System.Collections.Generic.IList<ExfilResource> Targets { get; set; }

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
    /// File information about the related binary/library used by an executable, or the script used by a script
    /// interpreter
    /// </summary>
    public class File : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Prefix of the file contents as a JSON-encoded string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual string Contents { get; set; }

        /// <summary>
        /// The length in bytes of the file prefix that was hashed. If hashed_size == size, any hashes reported
        /// represent the entire file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashedSize")]
        public virtual System.Nullable<long> HashedSize { get; set; }

        /// <summary>True when the hash covers only a prefix of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partiallyHashed")]
        public virtual System.Nullable<bool> PartiallyHashed { get; set; }

        /// <summary>Absolute path of the file as a JSON encoded string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// SHA256 hash of the first hashed_size bytes of the file encoded as a hex string. If hashed_size == size,
        /// sha256 represents the SHA256 hash of the entire file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>Size of the file in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<long> Size { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Security Command Center finding. A finding is a record of assessment data like security, risk, health, or
    /// privacy, that is ingested into Security Command Center for presentation, notification, analysis, policy testing,
    /// and enforcement. For example, a cross-site scripting (XSS) vulnerability in an App Engine application is a
    /// finding.
    /// </summary>
    public class Finding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Access details associated with the finding, such as more information on the caller, which method was
        /// accessed, and from where.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual Access Access { get; set; }

        /// <summary>
        /// The canonical name of the finding. It's either
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
        /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}" or
        /// "projects/{project_number}/sources/{source_id}/findings/{finding_id}", depending on the closest CRM ancestor
        /// of the resource associated with the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        /// <summary>
        /// The additional taxonomy group within findings from a given source. This field is immutable after creation
        /// time. Example: "XSS_FLASH_INJECTION"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>Cloud DLP data profile that is associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudDlpDataProfile")]
        public virtual CloudDlpDataProfile CloudDlpDataProfile { get; set; }

        /// <summary>
        /// Cloud Data Loss Prevention (Cloud DLP) inspection results that are associated with the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudDlpInspection")]
        public virtual CloudDlpInspection CloudDlpInspection { get; set; }

        /// <summary>Contains compliance information for security standards associated to the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compliances")]
        public virtual System.Collections.Generic.IList<Compliance> Compliances { get; set; }

        /// <summary>Contains information about the IP connection associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connections")]
        public virtual System.Collections.Generic.IList<Connection> Connections { get; set; }

        /// <summary>
        /// Output only. Map containing the points of contact for the given finding. The key represents the type of
        /// contact, while the value contains a list of all the contacts that pertain. Please refer to:
        /// https://cloud.google.com/resource-manager/docs/managing-notification-contacts#notification-categories {
        /// "security": { "contacts": [ { "email": "person1@company.com" }, { "email": "person2@company.com" } ] } }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual System.Collections.Generic.IDictionary<string, ContactDetails> Contacts { get; set; }

        /// <summary>
        /// Containers associated with the finding. This field provides information for both Kubernetes and
        /// non-Kubernetes containers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<Container> Containers { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The time at which the finding was created in Security Command Center.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Database associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual Database Database { get; set; }

        /// <summary>Contains more details about the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>
        /// The time the finding was first detected. If an existing finding is updated, then this is the time the update
        /// occurred. For example, if the finding represents an open firewall, this property captures the time the
        /// detector believes the firewall became open. The accuracy is determined by the detector. If the finding is
        /// later resolved, then this time reflects when the finding was resolved. This must not be set to a value
        /// greater than the current timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Represents exfiltrations associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exfiltration")]
        public virtual Exfiltration Exfiltration { get; set; }

        /// <summary>
        /// Output only. Third party SIEM/SOAR fields within SCC, contains external system information and external
        /// system finding fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalSystems")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudSecuritycenterV1ExternalSystem> ExternalSystems { get; set; }

        /// <summary>
        /// The URI that, if available, points to a web page outside of Security Command Center where additional
        /// information about the finding can be found. This field is guaranteed to be either empty or a well formed
        /// URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUri")]
        public virtual string ExternalUri { get; set; }

        /// <summary>File associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<File> Files { get; set; }

        /// <summary>The class of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findingClass")]
        public virtual string FindingClass { get; set; }

        /// <summary>Represents IAM bindings associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iamBindings")]
        public virtual System.Collections.Generic.IList<IamBinding> IamBindings { get; set; }

        /// <summary>
        /// Represents what's commonly known as an *indicator of compromise* (IoC) in computer forensics. This is an
        /// artifact observed on a network or in an operating system that, with high confidence, indicates a computer
        /// intrusion. For more information, see [Indicator of
        /// compromise](https://en.wikipedia.org/wiki/Indicator_of_compromise).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indicator")]
        public virtual Indicator Indicator { get; set; }

        /// <summary>Signature of the kernel rootkit.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kernelRootkit")]
        public virtual KernelRootkit KernelRootkit { get; set; }

        /// <summary>Kubernetes resources associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetes")]
        public virtual Kubernetes Kubernetes { get; set; }

        /// <summary>
        /// MITRE ATT&amp;amp;CK tactics and techniques related to this finding. See: https://attack.mitre.org
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mitreAttack")]
        public virtual MitreAttack MitreAttack { get; set; }

        /// <summary>
        /// Unique identifier of the module which generated the finding. Example:
        /// folders/598186756061/securityHealthAnalyticsSettings/customModules/56799441161885
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleName")]
        public virtual string ModuleName { get; set; }

        /// <summary>
        /// Indicates the mute state of a finding (either muted, unmuted or undefined). Unlike other attributes of a
        /// finding, a finding provider shouldn't set the value of mute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mute")]
        public virtual string Mute { get; set; }

        /// <summary>
        /// Records additional information about the mute operation, for example, the [mute
        /// configuration](/security-command-center/docs/how-to-mute-findings) that muted the finding and the user who
        /// muted the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteInitiator")]
        public virtual string MuteInitiator { get; set; }

        private string _muteUpdateTimeRaw;

        private object _muteUpdateTime;

        /// <summary>Output only. The most recent time this finding was muted or unmuted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteUpdateTime")]
        public virtual string MuteUpdateTimeRaw
        {
            get => _muteUpdateTimeRaw;
            set
            {
                _muteUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _muteUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="MuteUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use MuteUpdateTimeDateTimeOffset instead.")]
        public virtual object MuteUpdateTime
        {
            get => _muteUpdateTime;
            set
            {
                _muteUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _muteUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="MuteUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? MuteUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(MuteUpdateTimeRaw);
            set => MuteUpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// The [relative resource name](https://cloud.google.com/apis/design/resource_names#relative_resource_name) of
        /// the finding. Example: "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
        /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}",
        /// "projects/{project_id}/sources/{source_id}/findings/{finding_id}".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Steps to address the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextSteps")]
        public virtual string NextSteps { get; set; }

        /// <summary>
        /// The relative resource name of the source the finding belongs to. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name This field is immutable after
        /// creation time. For example: "organizations/{organization_id}/sources/{source_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Output only. The human readable display name of the finding source such as "Event Threat Detection" or
        /// "Security Health Analytics".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        /// <summary>Represents operating system processes associated with the Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processes")]
        public virtual System.Collections.Generic.IList<Process> Processes { get; set; }

        /// <summary>
        /// For findings on Google Cloud resources, the full resource name of the Google Cloud resource this finding is
        /// for. See: https://cloud.google.com/apis/design/resource_names#full_resource_name When the finding is for a
        /// non-Google Cloud resource, the resourceName can be a customer or partner defined string. This field is
        /// immutable after creation time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Output only. User specified security marks. These marks are entirely managed by the user and come from the
        /// SecurityMarks resource that belongs to the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityMarks")]
        public virtual SecurityMarks SecurityMarks { get; set; }

        /// <summary>The severity of the finding. This field is managed by the source that writes the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>
        /// Source specific properties. These properties are managed by the source that writes the finding. The key
        /// names in the source_properties map must be between 1 and 255 characters, and must start with a letter and
        /// contain alphanumeric characters or underscores only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProperties")]
        public virtual System.Collections.Generic.IDictionary<string, object> SourceProperties { get; set; }

        /// <summary>The state of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Represents vulnerability-specific fields like CVE and CVSS scores. CVE stands for Common Vulnerabilities and
        /// Exposures (https://cve.mitre.org/about/)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerability")]
        public virtual Vulnerability Vulnerability { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message that contains the resource name and display name of a folder resource.</summary>
    public class Folder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Full resource name of this folder. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolder")]
        public virtual string ResourceFolder { get; set; }

        /// <summary>The user defined display name for this folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolderDisplayName")]
        public virtual string ResourceFolderDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a geographical location for a given access.</summary>
    public class Geolocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A CLDR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `GetIamPolicy` method.</summary>
    public class GetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OPTIONAL: A `GetPolicyOptions` object for specifying options to `GetIamPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual GetPolicyOptions Options { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates settings provided to GetIamPolicy.</summary>
    public class GetPolicyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1, and 3.
        /// Requests specifying an invalid value will be rejected. Requests for policies with any conditional role
        /// bindings must specify version 3. Policies with no conditional role bindings may specify any valid value or
        /// leave the field unset. The policy in the response might use the policy version that you specified, or it
        /// might use a lower policy version. For example, if you specify version 3, but the policy has no conditional
        /// role bindings, the response uses version 1. To learn which resources support conditions in their IAM
        /// policies, see the [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPolicyVersion")]
        public virtual System.Nullable<int> RequestedPolicyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configures how to deliver Findings to BigQuery Instance.</summary>
    public class GoogleCloudSecuritycenterV1BigQueryExport : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time at which the BigQuery export was created. This field is set by the server and will be
        /// ignored if provided on export on creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// The dataset to write findings' updates to. Its format is
        /// "projects/[project_id]/datasets/[bigquery_dataset_id]". BigQuery Dataset unique ID must contain only letters
        /// (a-z, A-Z), numbers (0-9), or underscores (_).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>The description of the export (max of 1024 characters).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Expression that defines the filter to apply across create/update events of findings. The expression is a
        /// list of zero or more restrictions combined via logical operators `AND` and `OR`. Parentheses are supported,
        /// and `OR` has higher precedence than `AND`. Restrictions have the form ` ` and may have a `-` character in
        /// front of them to indicate negation. The fields map to those defined in the corresponding resource. The
        /// supported operators are: * `=` for all value types. * `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for
        /// integer values. * `:`, meaning substring matching, for strings. The supported value types are: * string
        /// literals in quotes. * integer literals without quotes. * boolean literals `true` and `false` without quotes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Output only. Email address of the user who last edited the BigQuery export. This field is set by the server
        /// and will be ignored if provided on export creation or update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mostRecentEditor")]
        public virtual string MostRecentEditor { get; set; }

        /// <summary>
        /// The relative resource name of this export. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name. Example format:
        /// "organizations/{organization_id}/bigQueryExports/{export_id}" Example format:
        /// "folders/{folder_id}/bigQueryExports/{export_id}" Example format:
        /// "projects/{project_id}/bigQueryExports/{export_id}" This field is provided in responses, and is ignored when
        /// provided in create requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The service account that needs permission to create table and upload data to the BigQuery
        /// dataset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual string Principal { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The most recent time at which the BigQuery export was updated. This field is set by the server
        /// and will be ignored if provided on export creation or update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Kubernetes RoleBinding or ClusterRoleBinding.</summary>
    public class GoogleCloudSecuritycenterV1Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name for the binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Namespace for the binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The Role or ClusterRole referenced by the binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual Role Role { get; set; }

        /// <summary>
        /// Represents one or more subjects that are bound to the role. Not always available for PATCH requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjects")]
        public virtual System.Collections.Generic.IList<Subject> Subjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a BulkMute request. Contains the LRO information.</summary>
    public class GoogleCloudSecuritycenterV1BulkMuteFindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Defines the properties in a custom module configuration for Security Health Analytics. Use the custom module
    /// configuration to create custom detectors that generate custom findings for resources that you specify.
    /// </summary>
    public class GoogleCloudSecuritycenterV1CustomConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom output properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customOutput")]
        public virtual GoogleCloudSecuritycenterV1CustomOutputSpec CustomOutput { get; set; }

        /// <summary>
        /// Text that describes the vulnerability or misconfiguration that the custom module detects. This explanation
        /// is returned with each finding instance to help investigators understand the detected issue. The text must be
        /// enclosed in quotation marks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The CEL expression to evaluate to produce findings. When the expression evaluates to true against a
        /// resource, a finding is generated.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("predicate")]
        public virtual Expr Predicate { get; set; }

        /// <summary>
        /// An explanation of the recommended steps that security teams can take to resolve the detected issue. This
        /// explanation is returned with each finding generated by this module in the `nextSteps` property of the
        /// finding JSON.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("recommendation")]
        public virtual string Recommendation { get; set; }

        /// <summary>
        /// The resource types that the custom module operates on. Each custom module can specify up to 5 resource
        /// types.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceSelector")]
        public virtual GoogleCloudSecuritycenterV1ResourceSelector ResourceSelector { get; set; }

        /// <summary>The severity to assign to findings generated by the module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A set of optional name-value pairs that define custom source properties to return with each finding that is
    /// generated by the custom module. The custom source properties that are defined here are included in the finding
    /// JSON under `sourceProperties`.
    /// </summary>
    public class GoogleCloudSecuritycenterV1CustomOutputSpec : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of custom output properties to add to the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1Property> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An EffectiveSecurityHealthAnalyticsCustomModule is the representation of a Security Health Analytics custom
    /// module at a specified level of the resource hierarchy: organization, folder, or project. If a custom module is
    /// inherited from a parent organization or folder, the value of the `enablementState` property in
    /// EffectiveSecurityHealthAnalyticsCustomModule is set to the value that is effective in the parent, instead of
    /// `INHERITED`. For example, if the module is enabled in a parent organization or folder, the effective
    /// enablement_state for the module in all child folders or projects is also `enabled`.
    /// EffectiveSecurityHealthAnalyticsCustomModule is read-only.
    /// </summary>
    public class GoogleCloudSecuritycenterV1EffectiveSecurityHealthAnalyticsCustomModule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The user-specified configuration for the module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConfig")]
        public virtual GoogleCloudSecuritycenterV1CustomConfig CustomConfig { get; set; }

        /// <summary>
        /// Output only. The display name for the custom module. The name must be between 1 and 128 characters, start
        /// with a lowercase letter, and contain alphanumeric characters or underscores only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. The effective state of enablement for the module at the given level of the hierarchy.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablementState")]
        public virtual string EnablementState { get; set; }

        /// <summary>
        /// Output only. The resource name of the custom module. Its format is
        /// "organizations/{organization}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}", or
        /// "folders/{folder}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}", or
        /// "projects/{project}/securityHealthAnalyticsSettings/effectiveCustomModules/{customModule}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of third party SIEM/SOAR fields within SCC.</summary>
    public class GoogleCloudSecuritycenterV1ExternalSystem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>References primary/secondary etc assignees in the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignees")]
        public virtual System.Collections.Generic.IList<string> Assignees { get; set; }

        private string _externalSystemUpdateTimeRaw;

        private object _externalSystemUpdateTime;

        /// <summary>
        /// The most recent time when the corresponding finding's ticket/tracker was updated in the external system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalSystemUpdateTime")]
        public virtual string ExternalSystemUpdateTimeRaw
        {
            get => _externalSystemUpdateTimeRaw;
            set
            {
                _externalSystemUpdateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _externalSystemUpdateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ExternalSystemUpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ExternalSystemUpdateTimeDateTimeOffset instead.")]
        public virtual object ExternalSystemUpdateTime
        {
            get => _externalSystemUpdateTime;
            set
            {
                _externalSystemUpdateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _externalSystemUpdateTime = value;
            }
        }

        /// <summary>
        /// <seealso cref="System.DateTimeOffset"/> representation of <see cref="ExternalSystemUpdateTimeRaw"/>.
        /// </summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ExternalSystemUpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(ExternalSystemUpdateTimeRaw);
            set => ExternalSystemUpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Identifier that's used to track the given finding in the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUid")]
        public virtual string ExternalUid { get; set; }

        /// <summary>
        /// Full resource name of the external system, for example:
        /// "organizations/1234/sources/5678/findings/123456/externalSystems/jira",
        /// "folders/1234/sources/5678/findings/123456/externalSystems/jira",
        /// "projects/1234/sources/5678/findings/123456/externalSystems/jira"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Most recent status of the corresponding finding's ticket/tracker in the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mute config is a Cloud SCC resource that contains the configuration to mute create/update events of findings.
    /// </summary>
    public class GoogleCloudSecuritycenterV1MuteConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _createTimeRaw;

        private object _createTime;

        /// <summary>
        /// Output only. The time at which the mute config was created. This field is set by the server and will be
        /// ignored if provided on config creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>A description of the mute config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The human readable name to be displayed for the mute config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. An expression that defines the filter to apply across create/update events of findings. While
        /// creating a filter string, be mindful of the scope in which the mute configuration is being created. E.g., If
        /// a filter contains project = X but is created under the project = Y scope, it might not match any findings.
        /// The following field and operator combinations are supported: * severity: `=`, `:` * category: `=`, `:` *
        /// resource.name: `=`, `:` * resource.project_name: `=`, `:` * resource.project_display_name: `=`, `:` *
        /// resource.folders.resource_folder: `=`, `:` * resource.parent_name: `=`, `:` * resource.parent_display_name:
        /// `=`, `:` * resource.type: `=`, `:` * finding_class: `=`, `:` * indicator.ip_addresses: `=`, `:` *
        /// indicator.domains: `=`, `:`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Output only. Email address of the user who last edited the mute config. This field is set by the server and
        /// will be ignored if provided on config creation or update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mostRecentEditor")]
        public virtual string MostRecentEditor { get; set; }

        /// <summary>
        /// This field will be ignored if provided on config creation. Format
        /// "organizations/{organization}/muteConfigs/{mute_config}" "folders/{folder}/muteConfigs/{mute_config}"
        /// "projects/{project}/muteConfigs/{mute_config}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>
        /// Output only. The most recent time at which the mute config was updated. This field is set by the server and
        /// will be ignored if provided on config creation or update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud SCC's Notification</summary>
    public class GoogleCloudSecuritycenterV1NotificationMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If it's a Finding based notification config, this field will be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finding")]
        public virtual Finding Finding { get; set; }

        /// <summary>Name of the notification config that generated current notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfigName")]
        public virtual string NotificationConfigName { get; set; }

        /// <summary>The Cloud resource tied to this notification's Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GoogleCloudSecuritycenterV1Resource Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>An individual name-value pair that defines a custom source property.</summary>
    public class GoogleCloudSecuritycenterV1Property : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the property for the custom output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The CEL expression for the custom output. A resource property can be specified to return the value of the
        /// property or a text string enclosed in quotation marks.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("valueExpression")]
        public virtual Expr ValueExpression { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to the Google Cloud resource.</summary>
    public class GoogleCloudSecuritycenterV1Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human readable name of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Contains a Folder message for each folder in the assets ancestry. The first folder is the
        /// deepest nested folder, and the last folder is the folder directly under the Organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<Folder> Folders { get; set; }

        /// <summary>
        /// The full resource name of the resource. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The full resource name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The human readable name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        /// <summary>The full resource name of project that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The project ID that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectDisplayName")]
        public virtual string ProjectDisplayName { get; set; }

        /// <summary>The full resource type of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource for selecting resource type.</summary>
    public class GoogleCloudSecuritycenterV1ResourceSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource types to run the detector on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceTypes")]
        public virtual System.Collections.Generic.IList<string> ResourceTypes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of asset discovery run</summary>
    public class GoogleCloudSecuritycenterV1RunAssetDiscoveryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration between asset discovery run start and end</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>The state of an asset discovery run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents an instance of a Security Health Analytics custom module, including its full module name, display
    /// name, enablement state, and last updated time. You can create a custom module at the organization, folder, or
    /// project level. Custom modules that you create at the organization or folder level are inherited by the child
    /// folders and projects.
    /// </summary>
    public class GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. If empty, indicates that the custom module was created in the organization, folder, or project
        /// in which you are viewing the custom module. Otherwise, `ancestor_module` specifies the organization or
        /// folder from which the custom module is inherited.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ancestorModule")]
        public virtual string AncestorModule { get; set; }

        /// <summary>The user specified custom configuration for the module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("customConfig")]
        public virtual GoogleCloudSecuritycenterV1CustomConfig CustomConfig { get; set; }

        /// <summary>
        /// The display name of the Security Health Analytics custom module. This display name becomes the finding
        /// category for all findings that are returned by this custom module. The display name must be between 1 and
        /// 128 characters, start with a lowercase letter, and contain alphanumeric characters or underscores only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The enablement state of the custom module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enablementState")]
        public virtual string EnablementState { get; set; }

        /// <summary>Output only. The editor that last updated the custom module.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastEditor")]
        public virtual string LastEditor { get; set; }

        /// <summary>
        /// Immutable. The resource name of the custom module. Its format is
        /// "organizations/{organization}/securityHealthAnalyticsSettings/customModules/{customModule}", or
        /// "folders/{folder}/securityHealthAnalyticsSettings/customModules/{customModule}", or
        /// "projects/{project}/securityHealthAnalyticsSettings/customModules/{customModule}" The id {customModule} is
        /// server-generated and is not user settable. It will be a numeric id containing 1-20 digits.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        private string _updateTimeRaw;

        private object _updateTime;

        /// <summary>Output only. The time at which the custom module was last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual string UpdateTimeRaw
        {
            get => _updateTimeRaw;
            set
            {
                _updateTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _updateTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use UpdateTimeDateTimeOffset instead.")]
        public virtual object UpdateTime
        {
            get => _updateTime;
            set
            {
                _updateTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _updateTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="UpdateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? UpdateTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(UpdateTimeRaw);
            set => UpdateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of asset discovery run</summary>
    public class GoogleCloudSecuritycenterV1beta1RunAssetDiscoveryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration between asset discovery run start and end</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>The state of an asset discovery run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Security Command Center finding. A finding is a record of assessment data (security, risk, health or privacy)
    /// ingested into Security Command Center for presentation, notification, analysis, policy testing, and enforcement.
    /// For example, an XSS vulnerability in an App Engine application is a finding.
    /// </summary>
    public class GoogleCloudSecuritycenterV1p1beta1Finding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The canonical name of the finding. It's either
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
        /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}" or
        /// "projects/{project_number}/sources/{source_id}/findings/{finding_id}", depending on the closest CRM ancestor
        /// of the resource associated with the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        /// <summary>
        /// The additional taxonomy group within findings from a given source. This field is immutable after creation
        /// time. Example: "XSS_FLASH_INJECTION"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        private string _createTimeRaw;

        private object _createTime;

        /// <summary>The time at which the finding was created in Security Command Center.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual string CreateTimeRaw
        {
            get => _createTimeRaw;
            set
            {
                _createTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _createTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use CreateTimeDateTimeOffset instead.")]
        public virtual object CreateTime
        {
            get => _createTime;
            set
            {
                _createTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _createTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="CreateTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? CreateTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(CreateTimeRaw);
            set => CreateTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        private string _eventTimeRaw;

        private object _eventTime;

        /// <summary>
        /// The time at which the event took place, or when an update to the finding occurred. For example, if the
        /// finding represents an open firewall it would capture the time the detector believes the firewall became
        /// open. The accuracy is determined by the detector. If the finding were to be resolved afterward, this time
        /// would reflect when the finding was resolved. Must not be set to a value greater than the current timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual string EventTimeRaw
        {
            get => _eventTimeRaw;
            set
            {
                _eventTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _eventTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use EventTimeDateTimeOffset instead.")]
        public virtual object EventTime
        {
            get => _eventTime;
            set
            {
                _eventTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _eventTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="EventTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? EventTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(EventTimeRaw);
            set => EventTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>
        /// The URI that, if available, points to a web page outside of Security Command Center where additional
        /// information about the finding can be found. This field is guaranteed to be either empty or a well formed
        /// URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUri")]
        public virtual string ExternalUri { get; set; }

        /// <summary>
        /// The relative resource name of this finding. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The relative resource name of the source the finding belongs to. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name This field is immutable after
        /// creation time. For example: "organizations/{organization_id}/sources/{source_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// For findings on Google Cloud resources, the full resource name of the Google Cloud resource this finding is
        /// for. See: https://cloud.google.com/apis/design/resource_names#full_resource_name When the finding is for a
        /// non-Google Cloud resource, the resourceName can be a customer or partner defined string. This field is
        /// immutable after creation time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Output only. User specified security marks. These marks are entirely managed by the user and come from the
        /// SecurityMarks resource that belongs to the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityMarks")]
        public virtual GoogleCloudSecuritycenterV1p1beta1SecurityMarks SecurityMarks { get; set; }

        /// <summary>The severity of the finding. This field is managed by the source that writes the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>
        /// Source specific properties. These properties are managed by the source that writes the finding. The key
        /// names in the source_properties map must be between 1 and 255 characters, and must start with a letter and
        /// contain alphanumeric characters or underscores only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProperties")]
        public virtual System.Collections.Generic.IDictionary<string, object> SourceProperties { get; set; }

        /// <summary>The state of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message that contains the resource name and display name of a folder resource.</summary>
    public class GoogleCloudSecuritycenterV1p1beta1Folder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Full resource name of this folder. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolder")]
        public virtual string ResourceFolder { get; set; }

        /// <summary>The user defined display name for this folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolderDisplayName")]
        public virtual string ResourceFolderDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Security Command Center's Notification</summary>
    public class GoogleCloudSecuritycenterV1p1beta1NotificationMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If it's a Finding based notification config, this field will be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finding")]
        public virtual GoogleCloudSecuritycenterV1p1beta1Finding Finding { get; set; }

        /// <summary>Name of the notification config that generated current notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfigName")]
        public virtual string NotificationConfigName { get; set; }

        /// <summary>The Cloud resource tied to the notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GoogleCloudSecuritycenterV1p1beta1Resource Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to the Google Cloud resource.</summary>
    public class GoogleCloudSecuritycenterV1p1beta1Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Contains a Folder message for each folder in the assets ancestry. The first folder is the
        /// deepest nested folder, and the last folder is the folder directly under the Organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1p1beta1Folder> Folders { get; set; }

        /// <summary>
        /// The full resource name of the resource. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The full resource name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The human readable name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        /// <summary>The full resource name of project that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The project id that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectDisplayName")]
        public virtual string ProjectDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of asset discovery run</summary>
    public class GoogleCloudSecuritycenterV1p1beta1RunAssetDiscoveryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration between asset discovery run start and end</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>The state of an asset discovery run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// User specified security marks that are attached to the parent Security Command Center resource. Security marks
    /// are scoped within a Security Command Center organization -- they can be modified and viewed by all users who
    /// have proper permissions on the organization.
    /// </summary>
    public class GoogleCloudSecuritycenterV1p1beta1SecurityMarks : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The canonical name of the marks. Examples: "organizations/{organization_id}/assets/{asset_id}/securityMarks"
        /// "folders/{folder_id}/assets/{asset_id}/securityMarks"
        /// "projects/{project_number}/assets/{asset_id}/securityMarks"
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// "projects/{project_number}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        /// <summary>
        /// Mutable user specified security marks belonging to the parent resource. Constraints are as follows: * Keys
        /// and values are treated as case insensitive * Keys must be between 1 - 256 characters (inclusive) * Keys must
        /// be letters, numbers, underscores, or dashes * Values have leading and trailing whitespace trimmed, remaining
        /// characters must be between 1 - 4096 characters (inclusive)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marks")]
        public virtual System.Collections.Generic.IDictionary<string, string> Marks { get; set; }

        /// <summary>
        /// The relative resource name of the SecurityMarks. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
        /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for grouping by assets.</summary>
    public class GroupAssetsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When compare_duration is set, the GroupResult's "state_change" property is updated to indicate whether the
        /// asset was added, removed, or remained present during the compare_duration period of time that precedes the
        /// read_time. This is the time between (read_time - compare_duration) and read_time. The state change value is
        /// derived based on the presence of the asset at the two points in time. Intermediate state changes between the
        /// two times don't affect the result. For example, the results aren't affected if the asset is removed and
        /// re-created again. Possible "state_change" values when compare_duration is specified: * "ADDED": indicates
        /// that the asset was not present at the start of compare_duration, but present at reference_time. * "REMOVED":
        /// indicates that the asset was present at the start of compare_duration, but not present at reference_time. *
        /// "ACTIVE": indicates that the asset was present at both the start and the end of the time period defined by
        /// compare_duration and reference_time. If compare_duration is not specified, then the only possible
        /// state_change is "UNUSED", which will be the state_change set for all assets present at read_time. If this
        /// field is set then `state_change` must be a specified field in `group_by`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compareDuration")]
        public virtual object CompareDuration { get; set; }

        /// <summary>
        /// Expression that defines the filter to apply across assets. The expression is a list of zero or more
        /// restrictions combined via logical operators `AND` and `OR`. Parentheses are supported, and `OR` has higher
        /// precedence than `AND`. Restrictions have the form ` ` and may have a `-` character in front of them to
        /// indicate negation. The fields map to those defined in the Asset resource. Examples include: * name *
        /// security_center_properties.resource_name * resource_properties.a_property * security_marks.marks.marka The
        /// supported operators are: * `=` for all value types. * `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for
        /// integer values. * `:`, meaning substring matching, for strings. The supported value types are: * string
        /// literals in quotes. * integer literals without quotes. * boolean literals `true` and `false` without quotes.
        /// The following field and operator combinations are supported: * name: `=` * update_time: `=`, `&amp;gt;`,
        /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be milliseconds since epoch or an RFC3339 string.
        /// Examples: `update_time = "2019-06-10T16:07:18-07:00"` `update_time = 1560208038000` * create_time: `=`,
        /// `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be milliseconds since epoch or an
        /// RFC3339 string. Examples: `create_time = "2019-06-10T16:07:18-07:00"` `create_time = 1560208038000` *
        /// iam_policy.policy_blob: `=`, `:` * resource_properties: `=`, `:`, `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`,
        /// `&amp;lt;=` * security_marks.marks: `=`, `:` * security_center_properties.resource_name: `=`, `:` *
        /// security_center_properties.resource_display_name: `=`, `:` * security_center_properties.resource_type: `=`,
        /// `:` * security_center_properties.resource_parent: `=`, `:` *
        /// security_center_properties.resource_parent_display_name: `=`, `:` *
        /// security_center_properties.resource_project: `=`, `:` *
        /// security_center_properties.resource_project_display_name: `=`, `:` *
        /// security_center_properties.resource_owners: `=`, `:` For example, `resource_properties.size = 100` is a
        /// valid filter string. Use a partial match on the empty string to filter based on a property existing:
        /// `resource_properties.my_property : ""` Use a negated partial match on the empty string to filter based on a
        /// property not existing: `-resource_properties.my_property : ""`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Required. Expression that defines what assets fields to use for grouping. The string value should follow SQL
        /// syntax: comma separated list of fields. For example:
        /// "security_center_properties.resource_project,security_center_properties.project". The following fields are
        /// supported when compare_duration is not set: * security_center_properties.resource_project *
        /// security_center_properties.resource_project_display_name * security_center_properties.resource_type *
        /// security_center_properties.resource_parent * security_center_properties.resource_parent_display_name The
        /// following fields are supported when compare_duration is set: * security_center_properties.resource_type *
        /// security_center_properties.resource_project_display_name *
        /// security_center_properties.resource_parent_display_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupBy")]
        public virtual string GroupBy { get; set; }

        /// <summary>
        /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum is 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// The value returned by the last `GroupAssetsResponse`; indicates that this is a continuation of a prior
        /// `GroupAssets` call, and that the system should return the next page of data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>
        /// Time used as a reference point when filtering assets. The filter is limited to assets existing at the
        /// supplied time and their values are those at that specific time. Absence of this field will default to the
        /// API's version of NOW.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for grouping by assets.</summary>
    public class GroupAssetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Group results. There exists an element for each existing unique combination of property/values. The element
        /// contains a count for the number of times those specific property/values appear.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupByResults")]
        public virtual System.Collections.Generic.IList<GroupResult> GroupByResults { get; set; }

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>Time used for executing the groupBy request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The total number of results matching the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for grouping by findings.</summary>
    public class GroupFindingsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// When compare_duration is set, the GroupResult's "state_change" attribute is updated to indicate whether the
        /// finding had its state changed, the finding's state remained unchanged, or if the finding was added during
        /// the compare_duration period of time that precedes the read_time. This is the time between (read_time -
        /// compare_duration) and read_time. The state_change value is derived based on the presence and state of the
        /// finding at the two points in time. Intermediate state changes between the two times don't affect the result.
        /// For example, the results aren't affected if the finding is made inactive and then active again. Possible
        /// "state_change" values when compare_duration is specified: * "CHANGED": indicates that the finding was
        /// present and matched the given filter at the start of compare_duration, but changed its state at read_time. *
        /// "UNCHANGED": indicates that the finding was present and matched the given filter at the start of
        /// compare_duration and did not change state at read_time. * "ADDED": indicates that the finding did not match
        /// the given filter or was not present at the start of compare_duration, but was present at read_time. *
        /// "REMOVED": indicates that the finding was present and matched the filter at the start of compare_duration,
        /// but did not match the filter at read_time. If compare_duration is not specified, then the only possible
        /// state_change is "UNUSED", which will be the state_change set for all findings present at read_time. If this
        /// field is set then `state_change` must be a specified field in `group_by`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compareDuration")]
        public virtual object CompareDuration { get; set; }

        /// <summary>
        /// Expression that defines the filter to apply across findings. The expression is a list of one or more
        /// restrictions combined via logical operators `AND` and `OR`. Parentheses are supported, and `OR` has higher
        /// precedence than `AND`. Restrictions have the form ` ` and may have a `-` character in front of them to
        /// indicate negation. Examples include: * name * source_properties.a_property * security_marks.marks.marka The
        /// supported operators are: * `=` for all value types. * `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for
        /// integer values. * `:`, meaning substring matching, for strings. The supported value types are: * string
        /// literals in quotes. * integer literals without quotes. * boolean literals `true` and `false` without quotes.
        /// The following field and operator combinations are supported: * name: `=` * parent: `=`, `:` * resource_name:
        /// `=`, `:` * state: `=`, `:` * category: `=`, `:` * external_uri: `=`, `:` * event_time: `=`, `&amp;gt;`,
        /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` Usage: This should be milliseconds since epoch or an RFC3339 string.
        /// Examples: `event_time = "2019-06-10T16:07:18-07:00"` `event_time = 1560208038000` * severity: `=`, `:` *
        /// workflow_state: `=`, `:` * security_marks.marks: `=`, `:` * source_properties: `=`, `:`, `&amp;gt;`,
        /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` For example, `source_properties.size = 100` is a valid filter string.
        /// Use a partial match on the empty string to filter based on a property existing:
        /// `source_properties.my_property : ""` Use a negated partial match on the empty string to filter based on a
        /// property not existing: `-source_properties.my_property : ""` * resource: * resource.name: `=`, `:` *
        /// resource.parent_name: `=`, `:` * resource.parent_display_name: `=`, `:` * resource.project_name: `=`, `:` *
        /// resource.project_display_name: `=`, `:` * resource.type: `=`, `:`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Required. Expression that defines what assets fields to use for grouping (including `state_change`). The
        /// string value should follow SQL syntax: comma separated list of fields. For example: "parent,resource_name".
        /// The following fields are supported: * resource_name * category * state * parent * severity The following
        /// fields are supported when compare_duration is set: * state_change
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupBy")]
        public virtual string GroupBy { get; set; }

        /// <summary>
        /// The maximum number of results to return in a single response. Default is 10, minimum is 1, maximum is 1000.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageSize")]
        public virtual System.Nullable<int> PageSize { get; set; }

        /// <summary>
        /// The value returned by the last `GroupFindingsResponse`; indicates that this is a continuation of a prior
        /// `GroupFindings` call, and that the system should return the next page of data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageToken")]
        public virtual string PageToken { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>
        /// Time used as a reference point when filtering findings. The filter is limited to findings existing at the
        /// supplied time and their values are those at that specific time. Absence of this field will default to the
        /// API's version of NOW.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for group by findings.</summary>
    public class GroupFindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Group results. There exists an element for each existing unique combination of property/values. The element
        /// contains a count for the number of times those specific property/values appear.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupByResults")]
        public virtual System.Collections.Generic.IList<GroupResult> GroupByResults { get; set; }

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>Time used for executing the groupBy request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The total number of results matching the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result containing the properties and count of a groupBy request.</summary>
    public class GroupResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Total count of resources for the given properties.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("count")]
        public virtual System.Nullable<long> Count { get; set; }

        /// <summary>Properties matching the groupBy fields in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("properties")]
        public virtual System.Collections.Generic.IDictionary<string, object> Properties { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a particular IAM binding, which captures a member's role addition, removal, or state.
    /// </summary>
    public class IamBinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The action that was performed on a Binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>
        /// A single identity requesting access for a Cloud Platform resource, for example, "foo@google.com".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("member")]
        public virtual string Member { get; set; }

        /// <summary>
        /// Role that is assigned to "members". For example, "roles/viewer", "roles/editor", or "roles/owner".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Cloud IAM Policy information associated with the Google Cloud resource described by the Security Command Center
    /// asset. This information is managed and defined by the Google Cloud resource and cannot be modified by the user.
    /// </summary>
    public class IamPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The JSON representation of the Policy associated with the asset. See
        /// https://cloud.google.com/iam/reference/rest/v1/Policy for format details.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policyBlob")]
        public virtual string PolicyBlob { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents what's commonly known as an _indicator of compromise_ (IoC) in computer forensics. This is an
    /// artifact observed on a network or in an operating system that, with high confidence, indicates a computer
    /// intrusion. For more information, see [Indicator of
    /// compromise](https://en.wikipedia.org/wiki/Indicator_of_compromise).
    /// </summary>
    public class Indicator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of domains associated to the Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<string> Domains { get; set; }

        /// <summary>The list of IP addresses that are associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddresses")]
        public virtual System.Collections.Generic.IList<string> IpAddresses { get; set; }

        /// <summary>
        /// The list of matched signatures indicating that the given process is present in the environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatures")]
        public virtual System.Collections.Generic.IList<ProcessSignature> Signatures { get; set; }

        /// <summary>The list of URIs associated to the Findings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uris")]
        public virtual System.Collections.Generic.IList<string> Uris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Kernel mode rootkit signatures.</summary>
    public class KernelRootkit : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Rootkit name, when available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>True if unexpected modifications of kernel code memory are present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedCodeModification")]
        public virtual System.Nullable<bool> UnexpectedCodeModification { get; set; }

        /// <summary>
        /// True if `ftrace` points are present with callbacks pointing to regions that are not in the expected kernel
        /// or module code range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedFtraceHandler")]
        public virtual System.Nullable<bool> UnexpectedFtraceHandler { get; set; }

        /// <summary>
        /// True if interrupt handlers that are are not in the expected kernel or module code regions are present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedInterruptHandler")]
        public virtual System.Nullable<bool> UnexpectedInterruptHandler { get; set; }

        /// <summary>
        /// True if kernel code pages that are not in the expected kernel or module code regions are present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedKernelCodePages")]
        public virtual System.Nullable<bool> UnexpectedKernelCodePages { get; set; }

        /// <summary>
        /// True if `kprobe` points are present with callbacks pointing to regions that are not in the expected kernel
        /// or module code range.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedKprobeHandler")]
        public virtual System.Nullable<bool> UnexpectedKprobeHandler { get; set; }

        /// <summary>
        /// True if unexpected processes in the scheduler run queue are present. Such processes are in the run queue,
        /// but not in the process task list.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedProcessesInRunqueue")]
        public virtual System.Nullable<bool> UnexpectedProcessesInRunqueue { get; set; }

        /// <summary>True if unexpected modifications of kernel read-only data memory are present.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedReadOnlyDataModification")]
        public virtual System.Nullable<bool> UnexpectedReadOnlyDataModification { get; set; }

        /// <summary>
        /// True if system call handlers that are are not in the expected kernel or module code regions are present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unexpectedSystemCallHandler")]
        public virtual System.Nullable<bool> UnexpectedSystemCallHandler { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Kubernetes-related attributes.</summary>
    public class Kubernetes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Provides information on any Kubernetes access reviews (privilege checks) relevant to the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessReviews")]
        public virtual System.Collections.Generic.IList<AccessReview> AccessReviews { get; set; }

        /// <summary>
        /// Provides Kubernetes role binding information for findings that involve [RoleBindings or
        /// ClusterRoleBindings](https://cloud.google.com/kubernetes-engine/docs/how-to/role-based-access-control).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1Binding> Bindings { get; set; }

        /// <summary>
        /// GKE [node pools](https://cloud.google.com/kubernetes-engine/docs/concepts/node-pools) associated with the
        /// finding. This field contains node pool information for each node, when it is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodePools")]
        public virtual System.Collections.Generic.IList<NodePool> NodePools { get; set; }

        /// <summary>
        /// Provides Kubernetes
        /// [node](https://cloud.google.com/kubernetes-engine/docs/concepts/cluster-architecture#nodes) information.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<Node> Nodes { get; set; }

        /// <summary>
        /// Kubernetes [Pods](https://cloud.google.com/kubernetes-engine/docs/concepts/pod) associated with the finding.
        /// This field contains Pod records for each container that is owned by a Pod.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pods")]
        public virtual System.Collections.Generic.IList<Pod> Pods { get; set; }

        /// <summary>
        /// Provides Kubernetes role information for findings that involve [Roles or
        /// ClusterRoles](https://cloud.google.com/kubernetes-engine/docs/how-to/role-based-access-control).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<Role> Roles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a generic name-value label. A label has separate name and value fields to support filtering with the
    /// `contains()` function. For more information, see [Filtering on array-type
    /// fields](https://cloud.google.com/security-command-center/docs/how-to-api-list-findings#array-contains-filtering).
    /// </summary>
    public class Label : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the label.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Value that corresponds to the label's name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing assets.</summary>
    public class ListAssetsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Assets matching the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listAssetsResults")]
        public virtual System.Collections.Generic.IList<ListAssetsResult> ListAssetsResults { get; set; }

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>Time used for executing the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The total number of assets matching the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result containing the Asset and its State.</summary>
    public class ListAssetsResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Asset matching the search request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("asset")]
        public virtual Asset Asset { get; set; }

        /// <summary>State change of the asset between the points in time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateChange")]
        public virtual string StateChange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing BigQuery exports.</summary>
    public class ListBigQueryExportsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The BigQuery exports from the specified parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bigQueryExports")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1BigQueryExport> BigQueryExports { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing descendant Security Health Analytics custom modules.</summary>
    public class ListDescendantSecurityHealthAnalyticsCustomModulesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If not empty, indicates that there may be more custom modules to be returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Custom modules belonging to the requested parent and its descendants.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityHealthAnalyticsCustomModules")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule> SecurityHealthAnalyticsCustomModules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing effective Security Health Analytics custom modules.</summary>
    public class ListEffectiveSecurityHealthAnalyticsCustomModulesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Effective custom modules belonging to the requested parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectiveSecurityHealthAnalyticsCustomModules")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1EffectiveSecurityHealthAnalyticsCustomModule> EffectiveSecurityHealthAnalyticsCustomModules { get; set; }

        /// <summary>If not empty, indicates that there may be more effective custom modules to be returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing findings.</summary>
    public class ListFindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Findings matching the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listFindingsResults")]
        public virtual System.Collections.Generic.IList<ListFindingsResult> ListFindingsResults { get; set; }

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        private string _readTimeRaw;

        private object _readTime;

        /// <summary>Time used for executing the list request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("readTime")]
        public virtual string ReadTimeRaw
        {
            get => _readTimeRaw;
            set
            {
                _readTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _readTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use ReadTimeDateTimeOffset instead.")]
        public virtual object ReadTime
        {
            get => _readTime;
            set
            {
                _readTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _readTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="ReadTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? ReadTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(ReadTimeRaw);
            set => ReadTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>The total number of findings matching the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("totalSize")]
        public virtual System.Nullable<int> TotalSize { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Result containing the Finding and its StateChange.</summary>
    public class ListFindingsResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Finding matching the search request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finding")]
        public virtual Finding Finding { get; set; }

        /// <summary>Output only. Resource that is associated with this finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual Resource Resource { get; set; }

        /// <summary>State change of the finding between the points in time.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateChange")]
        public virtual string StateChange { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing mute configs.</summary>
    public class ListMuteConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The mute configs from the specified parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteConfigs")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1MuteConfig> MuteConfigs { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no
        /// subsequent pages.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing notification configs.</summary>
    public class ListNotificationConfigsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to retrieve the next page of results, or empty if there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Notification configs belonging to the requested parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfigs")]
        public virtual System.Collections.Generic.IList<NotificationConfig> NotificationConfigs { get; set; }

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

    /// <summary>Response message for listing Security Health Analytics custom modules.</summary>
    public class ListSecurityHealthAnalyticsCustomModulesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If not empty, indicates that there may be more custom modules to be returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Custom modules belonging to the requested parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityHealthAnalyticsCustomModules")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1SecurityHealthAnalyticsCustomModule> SecurityHealthAnalyticsCustomModules { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for listing sources.</summary>
    public class ListSourcesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to retrieve the next page of results, or empty if there are no more results.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>Sources belonging to the requested parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<Source> Sources { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A signature corresponding to memory page hashes.</summary>
    public class MemoryHashSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The binary family.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryFamily")]
        public virtual string BinaryFamily { get; set; }

        /// <summary>The list of memory hash detections contributing to the binary family match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detections")]
        public virtual System.Collections.Generic.IList<Detection> Detections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// MITRE ATT&amp;amp;CK tactics and techniques related to this finding. See: https://attack.mitre.org
    /// </summary>
    public class MitreAttack : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional MITRE ATT&amp;CK tactics related to this finding, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalTactics")]
        public virtual System.Collections.Generic.IList<string> AdditionalTactics { get; set; }

        /// <summary>
        /// Additional MITRE ATT&amp;amp;CK techniques related to this finding, if any, along with any of their
        /// respective parent techniques.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalTechniques")]
        public virtual System.Collections.Generic.IList<string> AdditionalTechniques { get; set; }

        /// <summary>The MITRE ATT&amp;CK tactic most closely represented by this finding, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryTactic")]
        public virtual string PrimaryTactic { get; set; }

        /// <summary>
        /// The MITRE ATT&amp;amp;CK technique most closely represented by this finding, if any. primary_techniques is a
        /// repeated field because there are multiple levels of MITRE ATT&amp;amp;CK techniques. If the technique most
        /// closely represented by this finding is a sub-technique (e.g. `SCANNING_IP_BLOCKS`), both the sub-technique
        /// and its parent technique(s) will be listed (e.g. `SCANNING_IP_BLOCKS`, `ACTIVE_SCANNING`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryTechniques")]
        public virtual System.Collections.Generic.IList<string> PrimaryTechniques { get; set; }

        /// <summary>The MITRE ATT&amp;CK version referenced by the above fields. E.g. "8".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Kubernetes nodes associated with the finding.</summary>
    public class Node : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Full resource name](https://google.aip.dev/122#full-resource-names) of the Compute Engine VM running the
        /// cluster node.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides GKE node pool information.</summary>
    public class NodePool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Kubernetes node pool name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Nodes associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<Node> Nodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Cloud Security Command Center (Cloud SCC) notification configs. A notification config is a Cloud SCC resource
    /// that contains the configuration to send notifications for create/update events of findings, assets and etc.
    /// </summary>
    public class NotificationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the notification config (max of 1024 characters).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The relative resource name of this notification config. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
        /// "organizations/{organization_id}/notificationConfigs/notify_public_bucket",
        /// "folders/{folder_id}/notificationConfigs/notify_public_bucket", or
        /// "projects/{project_id}/notificationConfigs/notify_public_bucket".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The Pub/Sub topic to send notifications to. Its format is "projects/[project_id]/topics/[topic]".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopic")]
        public virtual string PubsubTopic { get; set; }

        /// <summary>
        /// Output only. The service account that needs "pubsub.topics.publish" permission to publish to the Pub/Sub
        /// topic.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>The config for triggering streaming-based notifications.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("streamingConfig")]
        public virtual StreamingConfig StreamingConfig { get; set; }

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

    /// <summary>User specified settings that are attached to the Security Command Center organization.</summary>
    public class OrganizationSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The configuration used for Asset Discovery runs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assetDiscoveryConfig")]
        public virtual AssetDiscoveryConfig AssetDiscoveryConfig { get; set; }

        /// <summary>
        /// A flag that indicates if Asset Discovery should be enabled. If the flag is set to `true`, then discovery of
        /// assets will occur. If it is set to `false`, all historical assets will remain, but discovery of future
        /// assets will not occur.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableAssetDiscovery")]
        public virtual System.Nullable<bool> EnableAssetDiscovery { get; set; }

        /// <summary>
        /// The relative resource name of the settings. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
        /// "organizations/{organization_id}/organizationSettings".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A Kubernetes Pod.</summary>
    public class Pod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pod containers associated with this finding, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<Container> Containers { get; set; }

        /// <summary>Pod labels. For Kubernetes containers, these are applied to the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<Label> Labels { get; set; }

        /// <summary>Kubernetes Pod name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Kubernetes Pod namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members`, or principals, to a single
    /// `role`. Principals can be user accounts, service accounts, Google groups, and domains (such as G Suite). A
    /// `role` is a named list of permissions; each `role` can be an IAM predefined role or a user-created custom role.
    /// For some types of Google Cloud resources, a `binding` can also specify a `condition`, which is a logical
    /// expression that allows access to a resource only if the expression evaluates to `true`. A condition can add
    /// constraints based on attributes of the request, the resource, or both. To learn which resources support
    /// conditions in their IAM policies, see the [IAM
    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** { "bindings":
    /// [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') etag: BwWWja0YfJA= version: 3 For a description of IAM and its features,
    /// see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies cloud audit logging configuration for this policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("auditConfigs")]
        public virtual System.Collections.Generic.IList<AuditConfig> AuditConfigs { get; set; }

        /// <summary>
        /// Associates a list of `members`, or principals, with a `role`. Optionally, may specify a `condition` that
        /// determines how and when the `bindings` are applied. Each of the `bindings` must contain at least one
        /// principal. The `bindings` in a `Policy` can refer to up to 1,500 principals; up to 250 of these principals
        /// can be Google groups. Each occurrence of a principal counts towards these limits. For example, if the
        /// `bindings` grant 50 different roles to `user:alice@example.com`, and not to any other principal, then you
        /// can add another 1,450 principals to the `bindings` in the `Policy`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; }

        /// <summary>
        /// `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy
        /// from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `getIamPolicy`, and systems are expected to put that etag in the request to
        /// `setIamPolicy` to ensure that their change will be applied to the same version of the policy. **Important:**
        /// If you use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit
        /// this field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Specifies the format of the policy. Valid values are `0`, `1`, and `3`. Requests that specify an invalid
        /// value are rejected. Any operation that affects conditional role bindings must specify version `3`. This
        /// requirement applies to the following operations: * Getting a policy that includes a conditional role binding
        /// * Adding a conditional role binding to a policy * Changing a conditional role binding in a policy * Removing
        /// any role binding, with or without a condition, from a policy that includes conditions **Important:** If you
        /// use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit this
        /// field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost. If a policy does not include any conditions, operations on
        /// that policy may specify any valid version or leave the field unset. To learn which resources support
        /// conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }
    }

    /// <summary>Represents an operating system process.</summary>
    public class Process : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Process arguments as JSON encoded strings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>True if `args` is incomplete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("argumentsTruncated")]
        public virtual System.Nullable<bool> ArgumentsTruncated { get; set; }

        /// <summary>File information for the process executable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binary")]
        public virtual File Binary { get; set; }

        /// <summary>Process environment variables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envVariables")]
        public virtual System.Collections.Generic.IList<EnvironmentVariable> EnvVariables { get; set; }

        /// <summary>True if `env_variables` is incomplete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envVariablesTruncated")]
        public virtual System.Nullable<bool> EnvVariablesTruncated { get; set; }

        /// <summary>File information for libraries loaded by the process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("libraries")]
        public virtual System.Collections.Generic.IList<File> Libraries { get; set; }

        /// <summary>
        /// The process name, as displayed in utilities like `top` and `ps`. This name can be accessed through
        /// `/proc/[pid]/comm` and changed with `prctl(PR_SET_NAME)`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The parent process ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentPid")]
        public virtual System.Nullable<long> ParentPid { get; set; }

        /// <summary>The process ID.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pid")]
        public virtual System.Nullable<long> Pid { get; set; }

        /// <summary>
        /// When the process represents the invocation of a script, `binary` provides information about the interpreter,
        /// while `script` provides information about the script file provided to the interpreter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual File Script { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Indicates what signature matched this process.</summary>
    public class ProcessSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Signature indicating that a binary family was matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryHashSignature")]
        public virtual MemoryHashSignature MemoryHashSignature { get; set; }

        /// <summary>Signature indicating that a YARA rule was matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yaraRuleSignature")]
        public virtual YaraRuleSignature YaraRuleSignature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional Links</summary>
    public class Reference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Source of the reference e.g. NVD</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>
        /// Uri for the mentioned source e.g. https://cve.mitre.org/cgi-bin/cvename.cgi?name=CVE-2021-34527.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to the Google Cloud resource that is associated with this finding.</summary>
    public class Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human readable name of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Contains a Folder message for each folder in the assets ancestry. The first folder is the deepest nested
        /// folder, and the last folder is the folder directly under the Organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<Folder> Folders { get; set; }

        /// <summary>
        /// The full resource name of the resource. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The human readable name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        /// <summary>The full resource name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentName")]
        public virtual string ParentName { get; set; }

        /// <summary>The project ID that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectDisplayName")]
        public virtual string ProjectDisplayName { get; set; }

        /// <summary>The full resource name of project that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectName")]
        public virtual string ProjectName { get; set; }

        /// <summary>The full resource type of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Kubernetes Role or ClusterRole.</summary>
    public class Role : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Role type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Role name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Role namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for running asset discovery for an organization.</summary>
    public class RunAssetDiscoveryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Security Command Center managed properties. These properties are managed by Security Command Center and cannot
    /// be modified by the user.
    /// </summary>
    public class SecurityCenterProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Contains a Folder message for each folder in the assets ancestry. The first folder is the deepest nested
        /// folder, and the last folder is the folder directly under the Organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<Folder> Folders { get; set; }

        /// <summary>The user defined display name for this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceDisplayName")]
        public virtual string ResourceDisplayName { get; set; }

        /// <summary>
        /// The full resource name of the Google Cloud resource this asset represents. This field is immutable after
        /// create time. See: https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>Owners of the Google Cloud resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceOwners")]
        public virtual System.Collections.Generic.IList<string> ResourceOwners { get; set; }

        /// <summary>
        /// The full resource name of the immediate parent of the resource. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceParent")]
        public virtual string ResourceParent { get; set; }

        /// <summary>The user defined display name for the parent of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceParentDisplayName")]
        public virtual string ResourceParentDisplayName { get; set; }

        /// <summary>
        /// The full resource name of the project the resource belongs to. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceProject")]
        public virtual string ResourceProject { get; set; }

        /// <summary>The user defined display name for the project of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceProjectDisplayName")]
        public virtual string ResourceProjectDisplayName { get; set; }

        /// <summary>
        /// The type of the Google Cloud resource. Examples include: APPLICATION, PROJECT, and ORGANIZATION. This is a
        /// case insensitive field defined by Security Command Center and/or the producer of the resource and is
        /// immutable after create time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// User specified security marks that are attached to the parent Security Command Center resource. Security marks
    /// are scoped within a Security Command Center organization -- they can be modified and viewed by all users who
    /// have proper permissions on the organization.
    /// </summary>
    public class SecurityMarks : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The canonical name of the marks. Examples: "organizations/{organization_id}/assets/{asset_id}/securityMarks"
        /// "folders/{folder_id}/assets/{asset_id}/securityMarks"
        /// "projects/{project_number}/assets/{asset_id}/securityMarks"
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// "projects/{project_number}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        /// <summary>
        /// Mutable user specified security marks belonging to the parent resource. Constraints are as follows: * Keys
        /// and values are treated as case insensitive * Keys must be between 1 - 256 characters (inclusive) * Keys must
        /// be letters, numbers, underscores, or dashes * Values have leading and trailing whitespace trimmed, remaining
        /// characters must be between 1 - 4096 characters (inclusive)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marks")]
        public virtual System.Collections.Generic.IDictionary<string, string> Marks { get; set; }

        /// <summary>
        /// The relative resource name of the SecurityMarks. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
        /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identity delegation history of an authenticated service account.</summary>
    public class ServiceAccountDelegationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email address of a Google account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        /// <summary>
        /// A string representing the principal_subject associated with the identity. As compared to `principal_email`,
        /// supports principals that aren't associated with email addresses, such as third party principals. For most
        /// identities, the format will be `principal://iam.googleapis.com/{identity pool name}/subjects/{subject}`
        /// except for some GKE identities (GKE_WORKLOAD, FREEFORM, GKE_HUB_WORKLOAD) that are still in the legacy
        /// format `serviceAccount:{identity pool name}[{subject}]`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for updating a finding's state.</summary>
    public class SetFindingStateRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        private string _startTimeRaw;

        private object _startTime;

        /// <summary>Required. The time at which the updated state takes effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual string StartTimeRaw
        {
            get => _startTimeRaw;
            set
            {
                _startTime = Google.Apis.Util.Utilities.DeserializeForGoogleFormat(value);
                _startTimeRaw = value;
            }
        }

        /// <summary><seealso cref="object"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        [System.ObsoleteAttribute("This property is obsolete and may behave unexpectedly; please use StartTimeDateTimeOffset instead.")]
        public virtual object StartTime
        {
            get => _startTime;
            set
            {
                _startTimeRaw = Google.Apis.Util.Utilities.SerializeForGoogleFormat(value);
                _startTime = value;
            }
        }

        /// <summary><seealso cref="System.DateTimeOffset"/> representation of <see cref="StartTimeRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnoreAttribute]
        public virtual System.DateTimeOffset? StartTimeDateTimeOffset
        {
            get => Google.Apis.Util.Utilities.GetDateTimeOffsetFromString(StartTimeRaw);
            set => StartTimeRaw = Google.Apis.Util.Utilities.GetStringFromDateTimeOffset(value);
        }

        /// <summary>Required. The desired State of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Google Cloud services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>
        /// OPTIONAL: A FieldMask specifying which fields of the policy to modify. Only the fields in the mask will be
        /// modified. If no mask is provided, the following default mask is used: `paths: "bindings, etag"`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for updating a finding's mute status.</summary>
    public class SetMuteRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The desired state of the Mute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mute")]
        public virtual string Mute { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Security Command Center finding source. A finding source is an entity or a mechanism that can produce a finding.
    /// A source is like a container of findings that come from the same scanner, logger, monitor, and other tools.
    /// </summary>
    public class Source : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The canonical name of the finding. It's either "organizations/{organization_id}/sources/{source_id}",
        /// "folders/{folder_id}/sources/{source_id}" or "projects/{project_number}/sources/{source_id}", depending on
        /// the closest CRM ancestor of the resource associated with the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        /// <summary>
        /// The description of the source (max of 1024 characters). Example: "Web Security Scanner is a web security
        /// scanner for common vulnerabilities in App Engine applications. It can automatically scan and detect four
        /// common vulnerabilities, including cross-site-scripting (XSS), Flash injection, mixed content (HTTP in
        /// HTTPS), and outdated or insecure libraries."
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The source's display name. A source's display name must be unique amongst its siblings, for example, two
        /// sources with the same parent can't share the same display name. The display name must have a length between
        /// 1 and 64 characters (inclusive).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The relative resource name of this source. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
        /// "organizations/{organization_id}/sources/{source_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

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

    /// <summary>
    /// The config for streaming-based notifications, which send each event as soon as it is detected.
    /// </summary>
    public class StreamingConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Expression that defines the filter to apply across create/update events of assets or findings as specified
        /// by the event type. The expression is a list of zero or more restrictions combined via logical operators
        /// `AND` and `OR`. Parentheses are supported, and `OR` has higher precedence than `AND`. Restrictions have the
        /// form ` ` and may have a `-` character in front of them to indicate negation. The fields map to those defined
        /// in the corresponding resource. The supported operators are: * `=` for all value types. * `&amp;gt;`,
        /// `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for integer values. * `:`, meaning substring matching, for strings. The
        /// supported value types are: * string literals in quotes. * integer literals without quotes. * boolean
        /// literals `true` and `false` without quotes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Kubernetes subject.</summary>
    public class Subject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Authentication type for the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Name for the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Namespace for the subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as `*` or `storage.*`)
        /// are not allowed. For more information see [IAM
        /// Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Refers to common vulnerability fields e.g. cve, cvss, cwe etc.</summary>
    public class Vulnerability : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CVE stands for Common Vulnerabilities and Exposures (https://cve.mitre.org/about/)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cve")]
        public virtual Cve Cve { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A signature corresponding to a YARA rule.</summary>
    public class YaraRuleSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the YARA rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yaraRule")]
        public virtual string YaraRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
