// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.CloudAsset.v1p4beta1
{
    /// <summary>The CloudAsset Service.</summary>
    public class CloudAssetService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1p4beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudAssetService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudAssetService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            V1p4beta1 = new V1p4beta1Resource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudasset";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://cloudasset.googleapis.com/";
        #else
            "https://cloudasset.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudasset.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Asset API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Asset API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }



        /// <summary>Gets the V1p4beta1 resource.</summary>
        public virtual V1p4beta1Resource V1p4beta1 { get; }
    }

    ///<summary>A base abstract class for CloudAsset requests.</summary>
    public abstract class CloudAssetBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new CloudAssetBaseServiceRequest instance.</summary>
        protected CloudAssetBaseServiceRequest(Google.Apis.Services.IClientService service)
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

        /// <summary>Initializes CloudAsset parameter list.</summary>
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

    /// <summary>The "v1p4beta1" collection of methods.</summary>
    public class V1p4beta1Resource
    {
        private const string Resource = "v1p4beta1";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public V1p4beta1Resource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Analyzes IAM policies to answer which identities have what accesses on which resources.</summary>
        /// <param name="parent">Required. The relative name of the root asset. Only resources and IAM policies within the
        /// parent will be analyzed. This can only be an organization number (such as "organizations/123") or a folder number
        /// (such as "folders/123"). To know how to get organization id, visit [here ](https://cloud.google.com/resource-
        /// manager/docs/creating-managing-organization#retrieving_your_organization_id). To know how to get folder id, visit
        /// [here ](https://cloud.google.com/resource-manager/docs/creating-managing-
        /// folders#viewing_or_listing_folders_and_projects).</param>
        public virtual AnalyzeIamPolicyRequest AnalyzeIamPolicy(string parent)
        {
            return new AnalyzeIamPolicyRequest(service, parent);
        }

        /// <summary>Analyzes IAM policies to answer which identities have what accesses on which resources.</summary>
        public class AnalyzeIamPolicyRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1p4beta1.Data.AnalyzeIamPolicyResponse>
        {
            /// <summary>Constructs a new AnalyzeIamPolicy request.</summary>
            public AnalyzeIamPolicyRequest(Google.Apis.Services.IClientService service, string parent)
                : base(service)
            {
                Parent = parent;
                InitParameters();
            }


            /// <summary>Required. The relative name of the root asset. Only resources and IAM policies within the
            /// parent will be analyzed. This can only be an organization number (such as "organizations/123") or a
            /// folder number (such as "folders/123"). To know how to get organization id, visit [here
            /// ](https://cloud.google.com/resource-manager/docs/creating-managing-
            /// organization#retrieving_your_organization_id). To know how to get folder id, visit [here
            /// ](https://cloud.google.com/resource-manager/docs/creating-managing-
            /// folders#viewing_or_listing_folders_and_projects).</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }

            /// <summary>Optional. The permissions to appear in result.</summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.accessSelector.permissions", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> AnalysisQueryAccessSelectorPermissions { get; set; }

            /// <summary>Optional. The roles to appear in result.</summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.accessSelector.roles", Google.Apis.Util.RequestParameterType.Query)]
            public virtual Google.Apis.Util.Repeatable<string> AnalysisQueryAccessSelectorRoles { get; set; }

            /// <summary>Required. The identity appear in the form of members in [IAM policy
            /// binding](https://cloud.google.com/iam/reference/rest/v1/Binding). The examples of supported forms are:
            /// "user:mike@example.com", "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-
            /// id@appspot.gserviceaccount.com". Notice that wildcard characters (such as * and ?) are not supported.
            /// You must give a specific identity.</summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.identitySelector.identity", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string AnalysisQueryIdentitySelectorIdentity { get; set; }

            /// <summary>Required. The [full resource name](https://cloud.google.com/asset-inventory/docs/resource-name-
            /// format) of a resource of [supported resource types](https://cloud.google.com/asset-inventory/docs
            /// /supported-asset-types#analyzable_asset_types).</summary>
            [Google.Apis.Util.RequestParameterAttribute("analysisQuery.resourceSelector.fullResourceName", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string AnalysisQueryResourceSelectorFullResourceName { get; set; }

            /// <summary>Optional. If true, the response will include access analysis from identities to resources via
            /// service account impersonation. This is a very expensive operation, because many derived queries will be
            /// executed. We highly recommend you use AssetService.ExportIamPolicyAnalysis rpc instead. For example, if
            /// the request analyzes for which resources user A has permission P, and there's an IAM policy states user
            /// A has iam.serviceAccounts.getAccessToken permission to a service account SA, and there's another IAM
            /// policy states service account SA has permission P to a GCP folder F, then user A potentially has access
            /// to the GCP folder F. And those advanced analysis results will be included in
            /// AnalyzeIamPolicyResponse.service_account_impersonation_analysis. Another example, if the request
            /// analyzes for who has permission P to a GCP folder F, and there's an IAM policy states user A has
            /// iam.serviceAccounts.actAs permission to a service account SA, and there's another IAM policy states
            /// service account SA has permission P to the GCP folder F, then user A potentially has access to the GCP
            /// folder F. And those advanced analysis results will be included in
            /// AnalyzeIamPolicyResponse.service_account_impersonation_analysis. Default is false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("options.analyzeServiceAccountImpersonation", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> OptionsAnalyzeServiceAccountImpersonation { get; set; }

            /// <summary>Optional. Amount of time executable has to complete. See JSON representation of
            /// [Duration](https://developers.google.com/protocol-buffers/docs/proto3#json). If this field is set with a
            /// value less than the RPC deadline, and the execution of your query hasn't finished in the specified
            /// execution timeout, you will get a response with partial result. Otherwise, your query's execution will
            /// continue until the RPC deadline. If it's not finished until then, you will get a DEADLINE_EXCEEDED
            /// error. Default is empty.</summary>
            [Google.Apis.Util.RequestParameterAttribute("options.executionTimeout", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object OptionsExecutionTimeout { get; set; }

            /// <summary>Optional. If true, the identities section of the result will expand any Google groups appearing
            /// in an IAM policy binding. If identity_selector is specified, the identity in the result will be
            /// determined by the selector, and this flag will have no effect. Default is false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("options.expandGroups", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> OptionsExpandGroups { get; set; }

            /// <summary>Optional. If true, the resource section of the result will expand any resource attached to an
            /// IAM policy to include resources lower in the resource hierarchy. For example, if the request analyzes
            /// for which resources user A has permission P, and the results include an IAM policy with P on a GCP
            /// folder, the results will also include resources in that folder with permission P. If resource_selector
            /// is specified, the resource section of the result will be determined by the selector, and this flag will
            /// have no effect. Default is false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("options.expandResources", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> OptionsExpandResources { get; set; }

            /// <summary>Optional. If true, the access section of result will expand any roles appearing in IAM policy
            /// bindings to include their permissions. If access_selector is specified, the access section of the result
            /// will be determined by the selector, and this flag will have no effect. Default is false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("options.expandRoles", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> OptionsExpandRoles { get; set; }

            /// <summary>Optional. If true, the result will output group identity edges, starting from the binding's
            /// group members, to any expanded identities. Default is false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("options.outputGroupEdges", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> OptionsOutputGroupEdges { get; set; }

            /// <summary>Optional. If true, the result will output resource edges, starting from the policy attached
            /// resource, to any expanded resources. Default is false.</summary>
            [Google.Apis.Util.RequestParameterAttribute("options.outputResourceEdges", Google.Apis.Util.RequestParameterType.Query)]
            public virtual System.Nullable<bool> OptionsOutputResourceEdges { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "analyzeIamPolicy";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1p4beta1/{+parent}:analyzeIamPolicy";

            /// <summary>Initializes AnalyzeIamPolicy parameter list.</summary>
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
                        Pattern = @"^[^/]+/[^/]+$",
                    });
                RequestParameters.Add(
                    "analysisQuery.accessSelector.permissions", new Google.Apis.Discovery.Parameter
                    {
                        Name = "analysisQuery.accessSelector.permissions",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "analysisQuery.accessSelector.roles", new Google.Apis.Discovery.Parameter
                    {
                        Name = "analysisQuery.accessSelector.roles",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "analysisQuery.identitySelector.identity", new Google.Apis.Discovery.Parameter
                    {
                        Name = "analysisQuery.identitySelector.identity",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "analysisQuery.resourceSelector.fullResourceName", new Google.Apis.Discovery.Parameter
                    {
                        Name = "analysisQuery.resourceSelector.fullResourceName",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "options.analyzeServiceAccountImpersonation", new Google.Apis.Discovery.Parameter
                    {
                        Name = "options.analyzeServiceAccountImpersonation",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "options.executionTimeout", new Google.Apis.Discovery.Parameter
                    {
                        Name = "options.executionTimeout",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "options.expandGroups", new Google.Apis.Discovery.Parameter
                    {
                        Name = "options.expandGroups",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "options.expandResources", new Google.Apis.Discovery.Parameter
                    {
                        Name = "options.expandResources",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "options.expandRoles", new Google.Apis.Discovery.Parameter
                    {
                        Name = "options.expandRoles",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "options.outputGroupEdges", new Google.Apis.Discovery.Parameter
                    {
                        Name = "options.outputGroupEdges",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "options.outputResourceEdges", new Google.Apis.Discovery.Parameter
                    {
                        Name = "options.outputResourceEdges",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Exports the answers of which identities have what accesses on which resources to a Google Cloud
        /// Storage destination. The output format is the JSON format that represents a AnalyzeIamPolicyResponse in the
        /// JSON format. This method implements the google.longrunning.Operation, which allows you to keep track of the
        /// export. We recommend intervals of at least 2 seconds with exponential retry to poll the export operation
        /// result. The metadata contains the request to help callers to map responses to requests.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="parent">Required. The relative name of the root asset. Only resources and IAM policies within the
        /// parent will be analyzed. This can only be an organization number (such as "organizations/123") or a folder number
        /// (such as "folders/123"). To know how to get organization id, visit [here ](https://cloud.google.com/resource-
        /// manager/docs/creating-managing-organization#retrieving_your_organization_id). To know how to get folder id, visit
        /// [here ](https://cloud.google.com/resource-manager/docs/creating-managing-
        /// folders#viewing_or_listing_folders_and_projects).</param>
        public virtual ExportIamPolicyAnalysisRequest ExportIamPolicyAnalysis(Google.Apis.CloudAsset.v1p4beta1.Data.ExportIamPolicyAnalysisRequest body, string parent)
        {
            return new ExportIamPolicyAnalysisRequest(service, body, parent);
        }

        /// <summary>Exports the answers of which identities have what accesses on which resources to a Google Cloud
        /// Storage destination. The output format is the JSON format that represents a AnalyzeIamPolicyResponse in the
        /// JSON format. This method implements the google.longrunning.Operation, which allows you to keep track of the
        /// export. We recommend intervals of at least 2 seconds with exponential retry to poll the export operation
        /// result. The metadata contains the request to help callers to map responses to requests.</summary>
        public class ExportIamPolicyAnalysisRequest : CloudAssetBaseServiceRequest<Google.Apis.CloudAsset.v1p4beta1.Data.Operation>
        {
            /// <summary>Constructs a new ExportIamPolicyAnalysis request.</summary>
            public ExportIamPolicyAnalysisRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudAsset.v1p4beta1.Data.ExportIamPolicyAnalysisRequest body, string parent)
                : base(service)
            {
                Parent = parent;
                Body = body;
                InitParameters();
            }


            /// <summary>Required. The relative name of the root asset. Only resources and IAM policies within the
            /// parent will be analyzed. This can only be an organization number (such as "organizations/123") or a
            /// folder number (such as "folders/123"). To know how to get organization id, visit [here
            /// ](https://cloud.google.com/resource-manager/docs/creating-managing-
            /// organization#retrieving_your_organization_id). To know how to get folder id, visit [here
            /// ](https://cloud.google.com/resource-manager/docs/creating-managing-
            /// folders#viewing_or_listing_folders_and_projects).</summary>
            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Parent { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudAsset.v1p4beta1.Data.ExportIamPolicyAnalysisRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "exportIamPolicyAnalysis";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "v1p4beta1/{+parent}:exportIamPolicyAnalysis";

            /// <summary>Initializes ExportIamPolicyAnalysis parameter list.</summary>
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
                        Pattern = @"^[^/]+/[^/]+$",
                    });
            }

        }
    }
}

namespace Google.Apis.CloudAsset.v1p4beta1.Data
{    

    /// <summary>Specifies roles and/or permissions to analyze, to determine both the identities possessing them and the
    /// resources they control. If multiple values are specified, results will include identities and resources matching
    /// any of them.</summary>
    public class AccessSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The permissions to appear in result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; } 

        /// <summary>Optional. The roles to appear in result.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<string> Roles { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A response message for AssetService.AnalyzeIamPolicy.</summary>
    public class AnalyzeIamPolicyResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents whether all entries in the main_analysis and service_account_impersonation_analysis have
        /// been fully explored to answer the query in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullyExplored")]
        public virtual System.Nullable<bool> FullyExplored { get; set; } 

        /// <summary>The main analysis that matches the original request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mainAnalysis")]
        public virtual IamPolicyAnalysis MainAnalysis { get; set; } 

        /// <summary>A list of non-critical errors happened during the request handling to explain why `fully_explored`
        /// is false, or empty if no error happened.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nonCriticalErrors")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1p4beta1AnalysisState> NonCriticalErrors { get; set; } 

        /// <summary>The service account impersonation analysis if
        /// AnalyzeIamPolicyRequest.analyze_service_account_impersonation is enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountImpersonationAnalysis")]
        public virtual System.Collections.Generic.IList<IamPolicyAnalysis> ServiceAccountImpersonationAnalysis { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Associates `members` with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The condition that is associated with this binding. If the condition evaluates to `true`, then this
        /// binding applies to the current request. If the condition evaluates to `false`, then this binding does not
        /// apply to the current request. However, a different role binding might grant the same role to one or more of
        /// the members in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; } 

        /// <summary>Specifies the identities requesting access for a Cloud Platform resource. `members` can have the
        /// following values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or
        /// without a Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is
        /// authenticated with a Google account or a service account. * `user:{emailid}`: An email address that
        /// represents a specific Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An
        /// email address that represents a service account. For example, `my-other-app@appspot.gserviceaccount.com`. *
        /// `group:{emailid}`: An email address that represents a Google group. For example, `admins@example.com`. *
        /// `deleted:user:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a user that
        /// has been recently deleted. For example, `alice@example.com?uid=123456789012345678901`. If the user is
        /// recovered, this value reverts to `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example, `my-other-
        /// app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted, this value
        /// reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the binding. *
        /// `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a Google
        /// group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`. If the
        /// group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role in the
        /// binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that domain. For
        /// example, `google.com` or `example.com`. </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; } 

        /// <summary>Role that is assigned to `members`. For example, `roles/viewer`, `roles/editor`, or
        /// `roles/owner`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A request message for AssetService.ExportIamPolicyAnalysis.</summary>
    public class ExportIamPolicyAnalysisRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The request query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisQuery")]
        public virtual IamPolicyAnalysisQuery AnalysisQuery { get; set; } 

        /// <summary>Optional. The request options.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual Options Options { get; set; } 

        /// <summary>Required. Output configuration indicating where the results will be output to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual IamPolicyAnalysisOutputConfig OutputConfig { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like
    /// expression language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec.
    /// Example (Comparison): title: "Summary size limit" description: "Determines if a summary is less than 100 chars"
    /// expression: "document.summary.size() < 100" Example (Equality): title: "Requestor is owner" description:
    /// "Determines if requestor is the document owner" expression: "document.owner == request.auth.claims.email"
    /// Example (Logic): title: "Public documents" description: "Determine whether the document should be publicly
    /// visible" expression: "document.type != 'private' && document.type != 'internal'" Example (Data Manipulation):
    /// title: "Notification string" description: "Create a notification string with a timestamp." expression: "'New
    /// message received at ' + string(document.create_time)" The exact variables and functions that may be referenced
    /// within an expression are determined by the service that evaluates it. See the service documentation for
    /// additional information.</summary>
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Description of the expression. This is a longer text which describes the expression, e.g.
        /// when hovered over it in a UI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; } 

        /// <summary>Optional. String indicating the location of the expression for error reporting, e.g. a file name
        /// and a position in the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; } 

        /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used
        /// e.g. in UIs which allow to enter the expression.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A Cloud Storage location.</summary>
    public class GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The uri of the Cloud Storage object. It's the same uri that is used by gsutil. For
        /// example: "gs://bucket_name/object_name". See [Viewing and Editing Object
        /// Metadata](https://cloud.google.com/storage/docs/viewing-editing-metadata) for more information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An IAM role or permission under analysis.</summary>
    public class GoogleCloudAssetV1p4beta1Access : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The analysis state of this access.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisState")]
        public virtual GoogleCloudAssetV1p4beta1AnalysisState AnalysisState { get; set; } 

        /// <summary>The permission.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permission")]
        public virtual string Permission { get; set; } 

        /// <summary>The role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An access control list, derived from the above IAM policy binding, which contains a set of resources
    /// and accesses. May include one item from each set to compose an access control entry. NOTICE that there could be
    /// multiple access control lists for one IAM policy binding. The access control lists are created based on resource
    /// and access combinations. For example, assume we have the following cases in one IAM policy binding: - Permission
    /// P1 and P2 apply to resource R1 and R2; - Permission P3 applies to resource R2 and R3; This will result in the
    /// following access control lists: - AccessControlList 1: [R1, R2], [P1, P2] - AccessControlList 2: [R2, R3],
    /// [P3]</summary>
    public class GoogleCloudAssetV1p4beta1AccessControlList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The accesses that match one of the following conditions: - The access_selector, if it is specified
        /// in request; - Otherwise, access specifiers reachable from the policy binding's role.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accesses")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1p4beta1Access> Accesses { get; set; } 

        /// <summary>Resource edges of the graph starting from the policy attached resource to any descendant resources.
        /// The Edge.source_node contains the full resource name of a parent resource and Edge.target_node contains the
        /// full resource name of a child resource. This field is present only if the output_resource_edges option is
        /// enabled in request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceEdges")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1p4beta1Edge> ResourceEdges { get; set; } 

        /// <summary>The resources that match one of the following conditions: - The resource_selector, if it is
        /// specified in request; - Otherwise, resources reachable from the policy attached resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resources")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1p4beta1Resource> Resources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the detailed state of an entity under analysis, such as a resource, an identity or an
    /// access.</summary>
    public class GoogleCloudAssetV1p4beta1AnalysisState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable description of the cause of failure.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cause")]
        public virtual string Cause { get; set; } 

        /// <summary>The Google standard error code that best describes the state. For example: - OK means the analysis
        /// on this entity has been successfully finished; - PERMISSION_DENIED means an access denied error is
        /// encountered; - DEADLINE_EXCEEDED means the analysis on this entity hasn't been started in time;</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual string Code { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A directional edge.</summary>
    public class GoogleCloudAssetV1p4beta1Edge : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The source node of the edge.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceNode")]
        public virtual string SourceNode { get; set; } 

        /// <summary>The target node of the edge.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetNode")]
        public virtual string TargetNode { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An identity under analysis.</summary>
    public class GoogleCloudAssetV1p4beta1Identity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The analysis state of this identity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisState")]
        public virtual GoogleCloudAssetV1p4beta1AnalysisState AnalysisState { get; set; } 

        /// <summary>The identity name in any form of members appear in [IAM policy
        /// binding](https://cloud.google.com/iam/reference/rest/v1/Binding), such as: - user:foo@google.com -
        /// group:group1@google.com - serviceAccount:s1@prj1.iam.gserviceaccount.com - projectOwner:some_project_id -
        /// domain:google.com - allUsers - etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class GoogleCloudAssetV1p4beta1IdentityList : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Group identity edges of the graph starting from the binding's group members to any node of the
        /// identities. The Edge.source_node contains a group, such as "group:parent@google.com". The Edge.target_node
        /// contains a member of the group, such as "group:child@google.com" or "user:foo@google.com". This field is
        /// present only if the output_group_edges option is enabled in request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("groupEdges")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1p4beta1Edge> GroupEdges { get; set; } 

        /// <summary>Only the identities that match one of the following conditions will be presented: - The
        /// identity_selector, if it is specified in request; - Otherwise, identities reachable from the policy
        /// binding's members.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identities")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1p4beta1Identity> Identities { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A Google Cloud resource under analysis.</summary>
    public class GoogleCloudAssetV1p4beta1Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The analysis state of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisState")]
        public virtual GoogleCloudAssetV1p4beta1AnalysisState AnalysisState { get; set; } 

        /// <summary>The [full resource name](https://cloud.google.com/asset-inventory/docs/resource-name-
        /// format)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An analysis message to group the query and results.</summary>
    public class IamPolicyAnalysis : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The analysis query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisQuery")]
        public virtual IamPolicyAnalysisQuery AnalysisQuery { get; set; } 

        /// <summary>A list of IamPolicyAnalysisResult that matches the analysis query, or empty if no result is
        /// found.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analysisResults")]
        public virtual System.Collections.Generic.IList<IamPolicyAnalysisResult> AnalysisResults { get; set; } 

        /// <summary>Represents whether all entries in the analysis_results have been fully explored to answer the
        /// query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullyExplored")]
        public virtual System.Nullable<bool> FullyExplored { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Output configuration for export IAM policy analysis destination.</summary>
    public class IamPolicyAnalysisOutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Destination on Cloud Storage.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GcsDestination GcsDestination { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>IAM policy analysis query message.</summary>
    public class IamPolicyAnalysisQuery : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Specifies roles or permissions for analysis. This is optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessSelector")]
        public virtual AccessSelector AccessSelector { get; set; } 

        /// <summary>Optional. Specifies an identity for analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identitySelector")]
        public virtual IdentitySelector IdentitySelector { get; set; } 

        /// <summary>Required. The relative name of the root asset. Only resources and IAM policies within the parent
        /// will be analyzed. This can only be an organization number (such as "organizations/123") or a folder number
        /// (such as "folders/123"). To know how to get organization id, visit [here ](https://cloud.google.com
        /// /resource-manager/docs/creating-managing-organization#retrieving_your_organization_id). To know how to get
        /// folder id, visit [here ](https://cloud.google.com/resource-manager/docs/creating-managing-
        /// folders#viewing_or_listing_folders_and_projects).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; } 

        /// <summary>Optional. Specifies a resource for analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceSelector")]
        public virtual ResourceSelector ResourceSelector { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>IAM Policy analysis result, consisting of one IAM policy binding and derived access control
    /// lists.</summary>
    public class IamPolicyAnalysisResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The access control lists derived from the iam_binding that match or potentially match resource and
        /// access selectors specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessControlLists")]
        public virtual System.Collections.Generic.IList<GoogleCloudAssetV1p4beta1AccessControlList> AccessControlLists { get; set; } 

        /// <summary>The [full resource name](https://cloud.google.com/asset-inventory/docs/resource-name-format) of the
        /// resource to which the iam_binding policy attaches.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attachedResourceFullName")]
        public virtual string AttachedResourceFullName { get; set; } 

        /// <summary>Represents whether all analyses on the iam_binding have successfully finished.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullyExplored")]
        public virtual System.Nullable<bool> FullyExplored { get; set; } 

        /// <summary>The Cloud IAM policy binding under analysis.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iamBinding")]
        public virtual Binding IamBinding { get; set; } 

        /// <summary>The identity list derived from members of the iam_binding that match or potentially match identity
        /// selector specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identityList")]
        public virtual GoogleCloudAssetV1p4beta1IdentityList IdentityList { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Specifies an identity for which to determine resource access, based on roles assigned either directly
    /// to them or to the groups they belong to, directly or indirectly.</summary>
    public class IdentitySelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The identity appear in the form of members in [IAM policy
        /// binding](https://cloud.google.com/iam/reference/rest/v1/Binding). The examples of supported forms are:
        /// "user:mike@example.com", "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-
        /// id@appspot.gserviceaccount.com". Notice that wildcard characters (such as * and ?) are not supported. You
        /// must give a specific identity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("identity")]
        public virtual string Identity { get; set; } 

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

    /// <summary>Contains request options.</summary>
    public class Options : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. If true, the response will include access analysis from identities to resources via
        /// service account impersonation. This is a very expensive operation, because many derived queries will be
        /// executed. For example, if the request analyzes for which resources user A has permission P, and there's an
        /// IAM policy states user A has iam.serviceAccounts.getAccessToken permission to a service account SA, and
        /// there's another IAM policy states service account SA has permission P to a GCP folder F, then user A
        /// potentially has access to the GCP folder F. And those advanced analysis results will be included in
        /// AnalyzeIamPolicyResponse.service_account_impersonation_analysis. Another example, if the request analyzes
        /// for who has permission P to a GCP folder F, and there's an IAM policy states user A has
        /// iam.serviceAccounts.actAs permission to a service account SA, and there's another IAM policy states service
        /// account SA has permission P to the GCP folder F, then user A potentially has access to the GCP folder F. And
        /// those advanced analysis results will be included in
        /// AnalyzeIamPolicyResponse.service_account_impersonation_analysis. Default is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("analyzeServiceAccountImpersonation")]
        public virtual System.Nullable<bool> AnalyzeServiceAccountImpersonation { get; set; } 

        /// <summary>Optional. If true, the identities section of the result will expand any Google groups appearing in
        /// an IAM policy binding. If identity_selector is specified, the identity in the result will be determined by
        /// the selector, and this flag will have no effect. Default is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandGroups")]
        public virtual System.Nullable<bool> ExpandGroups { get; set; } 

        /// <summary>Optional. If true, the resource section of the result will expand any resource attached to an IAM
        /// policy to include resources lower in the resource hierarchy. For example, if the request analyzes for which
        /// resources user A has permission P, and the results include an IAM policy with P on a GCP folder, the results
        /// will also include resources in that folder with permission P. If resource_selector is specified, the
        /// resource section of the result will be determined by the selector, and this flag will have no effect.
        /// Default is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandResources")]
        public virtual System.Nullable<bool> ExpandResources { get; set; } 

        /// <summary>Optional. If true, the access section of result will expand any roles appearing in IAM policy
        /// bindings to include their permissions. If access_selector is specified, the access section of the result
        /// will be determined by the selector, and this flag will have no effect. Default is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expandRoles")]
        public virtual System.Nullable<bool> ExpandRoles { get; set; } 

        /// <summary>Optional. If true, the result will output group identity edges, starting from the binding's group
        /// members, to any expanded identities. Default is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputGroupEdges")]
        public virtual System.Nullable<bool> OutputGroupEdges { get; set; } 

        /// <summary>Optional. If true, the result will output resource edges, starting from the policy attached
        /// resource, to any expanded resources. Default is false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputResourceEdges")]
        public virtual System.Nullable<bool> OutputResourceEdges { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Specifies the resource to analyze for access policies, which may be set directly on the resource, or on
    /// ancestors such as organizations, folders or projects.</summary>
    public class ResourceSelector : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The [full resource name](https://cloud.google.com/asset-inventory/docs/resource-name-
        /// format) of a resource of [supported resource types](https://cloud.google.com/asset-inventory/docs/supported-
        /// asset-types#analyzable_asset_types).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fullResourceName")]
        public virtual string FullResourceName { get; set; } 

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
}
