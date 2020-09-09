// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.Dialogflow.v3beta1
{
    /// <summary>The Dialogflow Service.</summary>
    public class DialogflowService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v3beta1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public DialogflowService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public DialogflowService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "dialogflow";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://dialogflow.googleapis.com/";
        #else
            "https://dialogflow.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://dialogflow.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Dialogflow API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View, manage and query your Dialogflow agents</summary>
            public static string Dialogflow = "https://www.googleapis.com/auth/dialogflow";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Dialogflow API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View, manage and query your Dialogflow agents</summary>
            public const string Dialogflow = "https://www.googleapis.com/auth/dialogflow";

        }



        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    ///<summary>A base abstract class for Dialogflow requests.</summary>
    public abstract class DialogflowBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new DialogflowBaseServiceRequest instance.</summary>
        protected DialogflowBaseServiceRequest(Google.Apis.Services.IClientService service)
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

        /// <summary>Initializes Dialogflow parameter list.</summary>
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
            Locations = new LocationsResource(service);
            Operations = new OperationsResource(service);

        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>The "locations" collection of methods.</summary>
        public class LocationsResource
        {
            private const string Resource = "locations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LocationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Agents = new AgentsResource(service);
                Operations = new OperationsResource(service);

            }

            /// <summary>Gets the Agents resource.</summary>
            public virtual AgentsResource Agents { get; }

            /// <summary>The "agents" collection of methods.</summary>
            public class AgentsResource
            {
                private const string Resource = "agents";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public AgentsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    EntityTypes = new EntityTypesResource(service);
                    Environments = new EnvironmentsResource(service);
                    Flows = new FlowsResource(service);
                    Intents = new IntentsResource(service);
                    Sessions = new SessionsResource(service);
                    Webhooks = new WebhooksResource(service);

                }

                /// <summary>Gets the EntityTypes resource.</summary>
                public virtual EntityTypesResource EntityTypes { get; }

                /// <summary>The "entityTypes" collection of methods.</summary>
                public class EntityTypesResource
                {
                    private const string Resource = "entityTypes";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public EntityTypesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;

                    }


                    /// <summary>Creates an entity type in the specified agent.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The agent to create a entity type for. Format:
                    /// `projects//locations//agents/`.</param>
                    public virtual CreateRequest Create(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1EntityType body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates an entity type in the specified agent.</summary>
                    public class CreateRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1EntityType>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1EntityType body, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>Required. The agent to create a entity type for. Format:
                        /// `projects//locations//agents/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The language of the following fields in `entity_type`: *
                        /// `EntityType.entities.value` * `EntityType.entities.synonyms` *
                        /// `EntityType.excluded_phrases.value` If not specified, the agent's default language is used.
                        /// [Many languages](https://cloud.google.com/dialogflow/docs/reference/language) are supported.
                        /// Note: languages must be enabled in the agent before they can be used.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string LanguageCode { get; set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1EntityType Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+parent}/entityTypes";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+$",
                                });
                            RequestParameters.Add(
                                "languageCode", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "languageCode",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Deletes the specified entity type.</summary>
                    /// <param name="name">Required. The name of the entity type to delete. Format:
                    /// `projects//locations//agents//entityTypes/`.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes the specified entity type.</summary>
                    public class DeleteRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                            : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>Required. The name of the entity type to delete. Format:
                        /// `projects//locations//agents//entityTypes/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>This field has no effect for entity type not being used. For entity types that are
                        /// used by intents or pages: * If `force` is set to false, an error will be returned with
                        /// message indicating the referencing resources. * If `force` is set to true, Dialogflow will
                        /// remove the entity type, as well as any references to the entity type (i.e. Page parameter of
                        /// the entity type will be changed to '@sys.any' and intent parameter of the entity type will
                        /// be removed).</summary>
                        [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> Force { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/entityTypes/[^/]+$",
                                });
                            RequestParameters.Add(
                                "force", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "force",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Retrieves the specified entity type.</summary>
                    /// <param name="name">Required. The name of the entity type. Format:
                    /// `projects//locations//agents//entityTypes/`.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Retrieves the specified entity type.</summary>
                    public class GetRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1EntityType>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name)
                            : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>Required. The name of the entity type. Format:
                        /// `projects//locations//agents//entityTypes/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The language to retrieve the entity type for. The following fields are language
                        /// dependent: * `EntityType.entities.value` * `EntityType.entities.synonyms` *
                        /// `EntityType.excluded_phrases.value` If not specified, the agent's default language is used.
                        /// [Many languages](https://cloud.google.com/dialogflow/docs/reference/language) are supported.
                        /// Note: languages must be enabled in the agent before they can be used.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string LanguageCode { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/entityTypes/[^/]+$",
                                });
                            RequestParameters.Add(
                                "languageCode", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "languageCode",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Returns the list of all entity types in the specified agent.</summary>
                    /// <param name="parent">Required. The agent to list all entity types for. Format:
                    /// `projects//locations//agents/`.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Returns the list of all entity types in the specified agent.</summary>
                    public class ListRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1ListEntityTypesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }


                        /// <summary>Required. The agent to list all entity types for. Format:
                        /// `projects//locations//agents/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The language to list entity types for. The following fields are language dependent:
                        /// * `EntityType.entities.value` * `EntityType.entities.synonyms` *
                        /// `EntityType.excluded_phrases.value` If not specified, the agent's default language is used.
                        /// [Many languages](https://cloud.google.com/dialogflow/docs/reference/language) are supported.
                        /// Note: languages must be enabled in the agent before they can be used.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string LanguageCode { get; set; }

                        /// <summary>The maximum number of items to return in a single page. By default 100 and at most
                        /// 1000.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The next_page_token value returned from a previous list request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+parent}/entityTypes";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+$",
                                });
                            RequestParameters.Add(
                                "languageCode", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "languageCode",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
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
                        }

                    }

                    /// <summary>Updates the specified entity type.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">The unique identifier of the entity type. Required for EntityTypes.UpdateEntityType. Format:
                    /// `projects//locations//agents//entityTypes/`.</param>
                    public virtual PatchRequest Patch(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1EntityType body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates the specified entity type.</summary>
                    public class PatchRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1EntityType>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1EntityType body, string name)
                            : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>The unique identifier of the entity type. Required for
                        /// EntityTypes.UpdateEntityType. Format: `projects//locations//agents//entityTypes/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The language of the following fields in `entity_type`: *
                        /// `EntityType.entities.value` * `EntityType.entities.synonyms` *
                        /// `EntityType.excluded_phrases.value` If not specified, the agent's default language is used.
                        /// [Many languages](https://cloud.google.com/dialogflow/docs/reference/language) are supported.
                        /// Note: languages must be enabled in the agent before they can be used.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string LanguageCode { get; set; }

                        /// <summary>The mask to control which fields get updated.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1EntityType Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/entityTypes/[^/]+$",
                                });
                            RequestParameters.Add(
                                "languageCode", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "languageCode",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
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
                }
                /// <summary>Gets the Environments resource.</summary>
                public virtual EnvironmentsResource Environments { get; }

                /// <summary>The "environments" collection of methods.</summary>
                public class EnvironmentsResource
                {
                    private const string Resource = "environments";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public EnvironmentsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Sessions = new SessionsResource(service);

                    }

                    /// <summary>Gets the Sessions resource.</summary>
                    public virtual SessionsResource Sessions { get; }

                    /// <summary>The "sessions" collection of methods.</summary>
                    public class SessionsResource
                    {
                        private const string Resource = "sessions";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public SessionsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                            EntityTypes = new EntityTypesResource(service);

                        }

                        /// <summary>Gets the EntityTypes resource.</summary>
                        public virtual EntityTypesResource EntityTypes { get; }

                        /// <summary>The "entityTypes" collection of methods.</summary>
                        public class EntityTypesResource
                        {
                            private const string Resource = "entityTypes";

                            /// <summary>The service which this resource belongs to.</summary>
                            private readonly Google.Apis.Services.IClientService service;

                            /// <summary>Constructs a new resource.</summary>
                            public EntityTypesResource(Google.Apis.Services.IClientService service)
                            {
                                this.service = service;

                            }


                            /// <summary>Creates a session entity type. If the specified session entity type already
                            /// exists, overrides the session entity type.</summary>
                            /// <param name="body">The body of the request.</param>
                            /// <param name="parent">Required. The session to create a session entity type for. Format:
                            /// `projects//locations//agents//sessions/` or `projects//locations//agents//environments//sessions/`. If `Environment
                            /// ID` is not specified, we assume default 'draft' environment.</param>
                            public virtual CreateRequest Create(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType body, string parent)
                            {
                                return new CreateRequest(service, body, parent);
                            }

                            /// <summary>Creates a session entity type. If the specified session entity type already
                            /// exists, overrides the session entity type.</summary>
                            public class CreateRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType>
                            {
                                /// <summary>Constructs a new Create request.</summary>
                                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType body, string parent)
                                    : base(service)
                                {
                                    Parent = parent;
                                    Body = body;
                                    InitParameters();
                                }


                                /// <summary>Required. The session to create a session entity type for. Format:
                                /// `projects//locations//agents//sessions/` or
                                /// `projects//locations//agents//environments//sessions/`. If `Environment ID` is not
                                /// specified, we assume default 'draft' environment.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }


                                /// <summary>Gets or sets the body of this request.</summary>
                                Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType Body { get; set; }

                                ///<summary>Returns the body of the request.</summary>
                                protected override object GetBody() => Body;

                                ///<summary>Gets the method name.</summary>
                                public override string MethodName => "create";

                                ///<summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "POST";

                                ///<summary>Gets the REST path.</summary>
                                public override string RestPath => "v3beta1/{+parent}/entityTypes";

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
                                            Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/environments/[^/]+/sessions/[^/]+$",
                                        });
                                }

                            }

                            /// <summary>Deletes the specified session entity type.</summary>
                            /// <param name="name">Required. The name of the session entity type to delete. Format:
                            /// `projects//locations//agents//sessions//entityTypes/` or
                            /// `projects//locations//agents//environments//sessions//entityTypes/`. If `Environment ID` is not specified, we assume
                            /// default 'draft' environment.</param>
                            public virtual DeleteRequest Delete(string name)
                            {
                                return new DeleteRequest(service, name);
                            }

                            /// <summary>Deletes the specified session entity type.</summary>
                            public class DeleteRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleProtobufEmpty>
                            {
                                /// <summary>Constructs a new Delete request.</summary>
                                public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                                    : base(service)
                                {
                                    Name = name;
                                    InitParameters();
                                }


                                /// <summary>Required. The name of the session entity type to delete. Format:
                                /// `projects//locations//agents//sessions//entityTypes/` or
                                /// `projects//locations//agents//environments//sessions//entityTypes/`. If `Environment
                                /// ID` is not specified, we assume default 'draft' environment.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Name { get; private set; }


                                ///<summary>Gets the method name.</summary>
                                public override string MethodName => "delete";

                                ///<summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "DELETE";

                                ///<summary>Gets the REST path.</summary>
                                public override string RestPath => "v3beta1/{+name}";

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
                                            Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/environments/[^/]+/sessions/[^/]+/entityTypes/[^/]+$",
                                        });
                                }

                            }

                            /// <summary>Retrieves the specified session entity type.</summary>
                            /// <param name="name">Required. The name of the session entity type. Format:
                            /// `projects//locations//agents//sessions//entityTypes/` or
                            /// `projects//locations//agents//environments//sessions//entityTypes/`. If `Environment ID` is not specified, we assume
                            /// default 'draft' environment.</param>
                            public virtual GetRequest Get(string name)
                            {
                                return new GetRequest(service, name);
                            }

                            /// <summary>Retrieves the specified session entity type.</summary>
                            public class GetRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType>
                            {
                                /// <summary>Constructs a new Get request.</summary>
                                public GetRequest(Google.Apis.Services.IClientService service, string name)
                                    : base(service)
                                {
                                    Name = name;
                                    InitParameters();
                                }


                                /// <summary>Required. The name of the session entity type. Format:
                                /// `projects//locations//agents//sessions//entityTypes/` or
                                /// `projects//locations//agents//environments//sessions//entityTypes/`. If `Environment
                                /// ID` is not specified, we assume default 'draft' environment.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Name { get; private set; }


                                ///<summary>Gets the method name.</summary>
                                public override string MethodName => "get";

                                ///<summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "GET";

                                ///<summary>Gets the REST path.</summary>
                                public override string RestPath => "v3beta1/{+name}";

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
                                            Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/environments/[^/]+/sessions/[^/]+/entityTypes/[^/]+$",
                                        });
                                }

                            }

                            /// <summary>Returns the list of all session entity types in the specified
                            /// session.</summary>
                            /// <param name="parent">Required. The session to list all session entity types from. Format:
                            /// `projects//locations//agents//sessions/` or `projects//locations//agents//environments//sessions/`. If `Environment
                            /// ID` is not specified, we assume default 'draft' environment.</param>
                            public virtual ListRequest List(string parent)
                            {
                                return new ListRequest(service, parent);
                            }

                            /// <summary>Returns the list of all session entity types in the specified
                            /// session.</summary>
                            public class ListRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1ListSessionEntityTypesResponse>
                            {
                                /// <summary>Constructs a new List request.</summary>
                                public ListRequest(Google.Apis.Services.IClientService service, string parent)
                                    : base(service)
                                {
                                    Parent = parent;
                                    InitParameters();
                                }


                                /// <summary>Required. The session to list all session entity types from. Format:
                                /// `projects//locations//agents//sessions/` or
                                /// `projects//locations//agents//environments//sessions/`. If `Environment ID` is not
                                /// specified, we assume default 'draft' environment.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Parent { get; private set; }

                                /// <summary>The maximum number of items to return in a single page. By default 100 and
                                /// at most 1000.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual System.Nullable<int> PageSize { get; set; }

                                /// <summary>The next_page_token value returned from a previous list request.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual string PageToken { get; set; }


                                ///<summary>Gets the method name.</summary>
                                public override string MethodName => "list";

                                ///<summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "GET";

                                ///<summary>Gets the REST path.</summary>
                                public override string RestPath => "v3beta1/{+parent}/entityTypes";

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
                                            Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/environments/[^/]+/sessions/[^/]+$",
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
                                }

                            }

                            /// <summary>Updates the specified session entity type.</summary>
                            /// <param name="body">The body of the request.</param>
                            /// <param name="name">Required. The unique identifier of the session entity type. Format:
                            /// `projects//locations//agents//sessions//entityTypes/` or
                            /// `projects//locations//agents//environments//sessions//entityTypes/`. If `Environment ID` is not specified, we assume
                            /// default 'draft' environment.</param>
                            public virtual PatchRequest Patch(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType body, string name)
                            {
                                return new PatchRequest(service, body, name);
                            }

                            /// <summary>Updates the specified session entity type.</summary>
                            public class PatchRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType>
                            {
                                /// <summary>Constructs a new Patch request.</summary>
                                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType body, string name)
                                    : base(service)
                                {
                                    Name = name;
                                    Body = body;
                                    InitParameters();
                                }


                                /// <summary>Required. The unique identifier of the session entity type. Format:
                                /// `projects//locations//agents//sessions//entityTypes/` or
                                /// `projects//locations//agents//environments//sessions//entityTypes/`. If `Environment
                                /// ID` is not specified, we assume default 'draft' environment.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                                public virtual string Name { get; private set; }

                                /// <summary>The mask to control which fields get updated.</summary>
                                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                                public virtual object UpdateMask { get; set; }


                                /// <summary>Gets or sets the body of this request.</summary>
                                Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType Body { get; set; }

                                ///<summary>Returns the body of the request.</summary>
                                protected override object GetBody() => Body;

                                ///<summary>Gets the method name.</summary>
                                public override string MethodName => "patch";

                                ///<summary>Gets the HTTP method.</summary>
                                public override string HttpMethod => "PATCH";

                                ///<summary>Gets the REST path.</summary>
                                public override string RestPath => "v3beta1/{+name}";

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
                                            Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/environments/[^/]+/sessions/[^/]+/entityTypes/[^/]+$",
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
                        }

                        /// <summary>Processes a natural language query and returns structured, actionable data as a
                        /// result. This method is not idempotent, because it may cause session entity types to be
                        /// updated, which in turn might affect results of future queries.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="session">Required. The name of the session this query is sent to. Format:
                        /// `projects//locations//agents//sessions/` or `projects//locations//agents//environments//sessions/`. If `Environment
                        /// ID` is not specified, we assume default 'draft' environment. It's up to the API caller to choose an appropriate
                        /// `Session ID`. It can be a random number or some type of session identifiers (preferably hashed). The length of the
                        /// `Session ID` must not exceed 36 characters.</param>
                        public virtual DetectIntentRequest DetectIntent(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1DetectIntentRequest body, string session)
                        {
                            return new DetectIntentRequest(service, body, session);
                        }

                        /// <summary>Processes a natural language query and returns structured, actionable data as a
                        /// result. This method is not idempotent, because it may cause session entity types to be
                        /// updated, which in turn might affect results of future queries.</summary>
                        public class DetectIntentRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1DetectIntentResponse>
                        {
                            /// <summary>Constructs a new DetectIntent request.</summary>
                            public DetectIntentRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1DetectIntentRequest body, string session)
                                : base(service)
                            {
                                Session = session;
                                Body = body;
                                InitParameters();
                            }


                            /// <summary>Required. The name of the session this query is sent to. Format:
                            /// `projects//locations//agents//sessions/` or
                            /// `projects//locations//agents//environments//sessions/`. If `Environment ID` is not
                            /// specified, we assume default 'draft' environment. It's up to the API caller to choose an
                            /// appropriate `Session ID`. It can be a random number or some type of session identifiers
                            /// (preferably hashed). The length of the `Session ID` must not exceed 36
                            /// characters.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Session { get; private set; }


                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1DetectIntentRequest Body { get; set; }

                            ///<summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "detectIntent";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+session}:detectIntent";

                            /// <summary>Initializes DetectIntent parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();

                                RequestParameters.Add(
                                    "session", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "session",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/environments/[^/]+/sessions/[^/]+$",
                                    });
                            }

                        }

                        /// <summary>Fulfills a matched intent returned by MatchIntent. Must be called after
                        /// MatchIntent, with input from MatchIntentResponse. Otherwise, the behavior is
                        /// undefined.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="session">Required. The name of the session this query is sent to. Format:
                        /// `projects//locations//agents//sessions/` or `projects//locations//agents//environments//sessions/`. If `Environment
                        /// ID` is not specified, we assume default 'draft' environment. It's up to the API caller to choose an appropriate
                        /// `Session ID`. It can be a random number or some type of session identifiers (preferably hashed). The length of the
                        /// `Session ID` must not exceed 36 characters.</param>
                        public virtual FulfillIntentRequest FulfillIntent(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1FulfillIntentRequest body, string session)
                        {
                            return new FulfillIntentRequest(service, body, session);
                        }

                        /// <summary>Fulfills a matched intent returned by MatchIntent. Must be called after
                        /// MatchIntent, with input from MatchIntentResponse. Otherwise, the behavior is
                        /// undefined.</summary>
                        public class FulfillIntentRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1FulfillIntentResponse>
                        {
                            /// <summary>Constructs a new FulfillIntent request.</summary>
                            public FulfillIntentRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1FulfillIntentRequest body, string session)
                                : base(service)
                            {
                                Session = session;
                                Body = body;
                                InitParameters();
                            }


                            /// <summary>Required. The name of the session this query is sent to. Format:
                            /// `projects//locations//agents//sessions/` or
                            /// `projects//locations//agents//environments//sessions/`. If `Environment ID` is not
                            /// specified, we assume default 'draft' environment. It's up to the API caller to choose an
                            /// appropriate `Session ID`. It can be a random number or some type of session identifiers
                            /// (preferably hashed). The length of the `Session ID` must not exceed 36
                            /// characters.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Session { get; private set; }


                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1FulfillIntentRequest Body { get; set; }

                            ///<summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "fulfillIntent";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+session}:fulfillIntent";

                            /// <summary>Initializes FulfillIntent parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();

                                RequestParameters.Add(
                                    "session", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "session",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/environments/[^/]+/sessions/[^/]+$",
                                    });
                            }

                        }

                        /// <summary>Returns preliminary intent match results, doesn't change the session
                        /// status.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="session">Required. The name of the session this query is sent to. Format:
                        /// `projects//locations//agents//sessions/` or `projects//locations//agents//environments//sessions/`. If `Environment
                        /// ID` is not specified, we assume default 'draft' environment. It's up to the API caller to choose an appropriate
                        /// `Session ID`. It can be a random number or some type of session identifiers (preferably hashed). The length of the
                        /// `Session ID` must not exceed 36 characters.</param>
                        public virtual MatchIntentRequest MatchIntent(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1MatchIntentRequest body, string session)
                        {
                            return new MatchIntentRequest(service, body, session);
                        }

                        /// <summary>Returns preliminary intent match results, doesn't change the session
                        /// status.</summary>
                        public class MatchIntentRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1MatchIntentResponse>
                        {
                            /// <summary>Constructs a new MatchIntent request.</summary>
                            public MatchIntentRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1MatchIntentRequest body, string session)
                                : base(service)
                            {
                                Session = session;
                                Body = body;
                                InitParameters();
                            }


                            /// <summary>Required. The name of the session this query is sent to. Format:
                            /// `projects//locations//agents//sessions/` or
                            /// `projects//locations//agents//environments//sessions/`. If `Environment ID` is not
                            /// specified, we assume default 'draft' environment. It's up to the API caller to choose an
                            /// appropriate `Session ID`. It can be a random number or some type of session identifiers
                            /// (preferably hashed). The length of the `Session ID` must not exceed 36
                            /// characters.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Session { get; private set; }


                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1MatchIntentRequest Body { get; set; }

                            ///<summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "matchIntent";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+session}:matchIntent";

                            /// <summary>Initializes MatchIntent parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();

                                RequestParameters.Add(
                                    "session", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "session",
                                        IsRequired = true,
                                        ParameterType = "path",
                                        DefaultValue = null,
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/environments/[^/]+/sessions/[^/]+$",
                                    });
                            }

                        }
                    }

                    /// <summary>Creates an Environment in the specified Agent.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The Agent to create an Environment for. Format:
                    /// `projects//locations//agents/`.</param>
                    public virtual CreateRequest Create(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Environment body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates an Environment in the specified Agent.</summary>
                    public class CreateRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Environment body, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>Required. The Agent to create an Environment for. Format:
                        /// `projects//locations//agents/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Environment Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+parent}/environments";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Deletes the specified Environment.</summary>
                    /// <param name="name">Required. The name of the Environment to delete. Format:
                    /// `projects//locations//agents//environments/`.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes the specified Environment.</summary>
                    public class DeleteRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                            : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>Required. The name of the Environment to delete. Format:
                        /// `projects//locations//agents//environments/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/environments/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Retrieves the specified Environment.</summary>
                    /// <param name="name">Required. The name of the Environment. Format:
                    /// `projects//locations//agents//environments/`.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Retrieves the specified Environment.</summary>
                    public class GetRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Environment>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name)
                            : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>Required. The name of the Environment. Format:
                        /// `projects//locations//agents//environments/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/environments/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Returns the list of all environments in the specified Agent.</summary>
                    /// <param name="parent">Required. The Agent to list all environments for. Format:
                    /// `projects//locations//agents/`.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Returns the list of all environments in the specified Agent.</summary>
                    public class ListRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1ListEnvironmentsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }


                        /// <summary>Required. The Agent to list all environments for. Format:
                        /// `projects//locations//agents/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The maximum number of items to return in a single page. By default 20 and at most
                        /// 100.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The next_page_token value returned from a previous list request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+parent}/environments";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+$",
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
                        }

                    }

                    /// <summary>Looks up the history of the specified Environment.</summary>
                    /// <param name="name">Required. Resource name of the environment to look up the history for. Format:
                    /// `projects//locations//agents//environments/`.</param>
                    public virtual LookupEnvironmentHistoryRequest LookupEnvironmentHistory(string name)
                    {
                        return new LookupEnvironmentHistoryRequest(service, name);
                    }

                    /// <summary>Looks up the history of the specified Environment.</summary>
                    public class LookupEnvironmentHistoryRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1LookupEnvironmentHistoryResponse>
                    {
                        /// <summary>Constructs a new LookupEnvironmentHistory request.</summary>
                        public LookupEnvironmentHistoryRequest(Google.Apis.Services.IClientService service, string name)
                            : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>Required. Resource name of the environment to look up the history for. Format:
                        /// `projects//locations//agents//environments/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The maximum number of items to return in a single page. By default 100 and at most
                        /// 1000.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The next_page_token value returned from a previous list request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "lookupEnvironmentHistory";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+name}:lookupEnvironmentHistory";

                        /// <summary>Initializes LookupEnvironmentHistory parameter list.</summary>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/environments/[^/]+$",
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
                        }

                    }

                    /// <summary>Updates the specified Environment.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">The name of the environment. Format: `projects//locations//agents//environments/`.</param>
                    public virtual PatchRequest Patch(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Environment body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates the specified Environment.</summary>
                    public class PatchRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Environment body, string name)
                            : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>The name of the environment. Format:
                        /// `projects//locations//agents//environments/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Required. The mask to control which fields get updated.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Environment Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/environments/[^/]+$",
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
                }
                /// <summary>Gets the Flows resource.</summary>
                public virtual FlowsResource Flows { get; }

                /// <summary>The "flows" collection of methods.</summary>
                public class FlowsResource
                {
                    private const string Resource = "flows";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public FlowsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Pages = new PagesResource(service);
                        TransitionRouteGroups = new TransitionRouteGroupsResource(service);
                        Versions = new VersionsResource(service);

                    }

                    /// <summary>Gets the Pages resource.</summary>
                    public virtual PagesResource Pages { get; }

                    /// <summary>The "pages" collection of methods.</summary>
                    public class PagesResource
                    {
                        private const string Resource = "pages";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public PagesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;

                        }


                        /// <summary>Creates a page in the specified flow.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">Required. The flow to create a page for. Format:
                        /// `projects//locations//agents//flows/`.</param>
                        public virtual CreateRequest Create(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Page body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates a page in the specified flow.</summary>
                        public class CreateRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Page>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Page body, string parent)
                                : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }


                            /// <summary>Required. The flow to create a page for. Format:
                            /// `projects//locations//agents//flows/`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>The language of the following fields in `page`: *
                            /// `Page.entry_fulfillment.messages` *
                            /// `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages` *
                            /// `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages` *
                            /// `Page.transition_routes.trigger_fulfillment.messages` *
                            /// `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages` If not
                            /// specified, the agent's default language is used. [Many
                            /// languages](https://cloud.google.com/dialogflow/docs/reference/language) are supported.
                            /// Note: languages must be enabled in the agent before they can be used.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string LanguageCode { get; set; }


                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Page Body { get; set; }

                            ///<summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+parent}/pages";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+$",
                                    });
                                RequestParameters.Add(
                                    "languageCode", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "languageCode",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                            }

                        }

                        /// <summary>Deletes the specified page.</summary>
                        /// <param name="name">Required. The name of the page to delete. Format:
                        /// `projects//locations//agents//Flows//pages/`.</param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>Deletes the specified page.</summary>
                        public class DeleteRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleProtobufEmpty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                                : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }


                            /// <summary>Required. The name of the page to delete. Format:
                            /// `projects//locations//agents//Flows//pages/`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>This field has no effect for pages with no incoming transitions. For pages with
                            /// incoming transitions: * If `force` is set to false, an error will be returned with
                            /// message indicating the incoming transitions. * If `force` is set to true, Dialogflow
                            /// will remove the page, as well as any transitions to the page (i.e. Target page in event
                            /// handlers or Target page in transition routes that point to this page will be
                            /// cleared).</summary>
                            [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> Force { get; set; }


                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+/pages/[^/]+$",
                                    });
                                RequestParameters.Add(
                                    "force", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "force",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                            }

                        }

                        /// <summary>Retrieves the specified page.</summary>
                        /// <param name="name">Required. The name of the page. Format:
                        /// `projects//locations//agents//flows//pages/`.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Retrieves the specified page.</summary>
                        public class GetRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Page>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name)
                                : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }


                            /// <summary>Required. The name of the page. Format:
                            /// `projects//locations//agents//flows//pages/`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>The language to retrieve the page for. The following fields are language
                            /// dependent: * `Page.entry_fulfillment.messages` *
                            /// `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages` *
                            /// `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages` *
                            /// `Page.transition_routes.trigger_fulfillment.messages` *
                            /// `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages` If not
                            /// specified, the agent's default language is used. [Many
                            /// languages](https://cloud.google.com/dialogflow/docs/reference/language) are supported.
                            /// Note: languages must be enabled in the agent before they can be used.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string LanguageCode { get; set; }


                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+/pages/[^/]+$",
                                    });
                                RequestParameters.Add(
                                    "languageCode", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "languageCode",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                            }

                        }

                        /// <summary>Returns the list of all pages in the specified flow.</summary>
                        /// <param name="parent">Required. The flow to list all pages for. Format:
                        /// `projects//locations//agents//flows/`.</param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Returns the list of all pages in the specified flow.</summary>
                        public class ListRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1ListPagesResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent)
                                : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }


                            /// <summary>Required. The flow to list all pages for. Format:
                            /// `projects//locations//agents//flows/`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>The language to list pages for. The following fields are language dependent: *
                            /// `Page.entry_fulfillment.messages` *
                            /// `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages` *
                            /// `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages` *
                            /// `Page.transition_routes.trigger_fulfillment.messages` *
                            /// `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages` If not
                            /// specified, the agent's default language is used. [Many
                            /// languages](https://cloud.google.com/dialogflow/docs/reference/language) are supported.
                            /// Note: languages must be enabled in the agent before they can be used.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string LanguageCode { get; set; }

                            /// <summary>The maximum number of items to return in a single page. By default 100 and at
                            /// most 1000.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>The next_page_token value returned from a previous list request.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }


                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+parent}/pages";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+$",
                                    });
                                RequestParameters.Add(
                                    "languageCode", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "languageCode",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
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
                            }

                        }

                        /// <summary>Updates the specified page.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">The unique identifier of the page. Required for the Pages.UpdatePage method. Pages.CreatePage
                        /// populates the name automatically. Format: `projects//locations//agents//flows//pages/`.</param>
                        public virtual PatchRequest Patch(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Page body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>Updates the specified page.</summary>
                        public class PatchRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Page>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Page body, string name)
                                : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }


                            /// <summary>The unique identifier of the page. Required for the Pages.UpdatePage method.
                            /// Pages.CreatePage populates the name automatically. Format:
                            /// `projects//locations//agents//flows//pages/`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>The language of the following fields in `page`: *
                            /// `Page.entry_fulfillment.messages` *
                            /// `Page.form.parameters.fill_behavior.initial_prompt_fulfillment.messages` *
                            /// `Page.form.parameters.fill_behavior.reprompt_event_handlers.messages` *
                            /// `Page.transition_routes.trigger_fulfillment.messages` *
                            /// `Page.transition_route_groups.transition_routes.trigger_fulfillment.messages` If not
                            /// specified, the agent's default language is used. [Many
                            /// languages](https://cloud.google.com/dialogflow/docs/reference/language) are supported.
                            /// Note: languages must be enabled in the agent before they can be used.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string LanguageCode { get; set; }

                            /// <summary>The mask to control which fields get updated. If the mask is not present, all
                            /// fields will be updated.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }


                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Page Body { get; set; }

                            ///<summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+/pages/[^/]+$",
                                    });
                                RequestParameters.Add(
                                    "languageCode", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "languageCode",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
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
                    }
                    /// <summary>Gets the TransitionRouteGroups resource.</summary>
                    public virtual TransitionRouteGroupsResource TransitionRouteGroups { get; }

                    /// <summary>The "transitionRouteGroups" collection of methods.</summary>
                    public class TransitionRouteGroupsResource
                    {
                        private const string Resource = "transitionRouteGroups";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public TransitionRouteGroupsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;

                        }


                        /// <summary>Creates an TransitionRouteGroup in the specified flow.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">Required. The flow to create an TransitionRouteGroup for. Format:
                        /// `projects//locations//agents//flows/`.</param>
                        public virtual CreateRequest Create(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1TransitionRouteGroup body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates an TransitionRouteGroup in the specified flow.</summary>
                        public class CreateRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1TransitionRouteGroup>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1TransitionRouteGroup body, string parent)
                                : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }


                            /// <summary>Required. The flow to create an TransitionRouteGroup for. Format:
                            /// `projects//locations//agents//flows/`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>The language to list transition route groups for. The field `messages` in
                            /// TransitionRoute is language dependent. If not specified, the agent's default language is
                            /// used. [Many languages](https://cloud.google.com/dialogflow/docs/reference/language) are
                            /// supported. Note: languages must be enabled in the agent before they can be
                            /// used.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string LanguageCode { get; set; }


                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1TransitionRouteGroup Body { get; set; }

                            ///<summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+parent}/transitionRouteGroups";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+$",
                                    });
                                RequestParameters.Add(
                                    "languageCode", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "languageCode",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                            }

                        }

                        /// <summary>Deletes the specified TransitionRouteGroup.</summary>
                        /// <param name="name">Required. The name of the TransitionRouteGroup to delete. Format:
                        /// `projects//locations//agents//flows//transitionRouteGroups/`.</param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>Deletes the specified TransitionRouteGroup.</summary>
                        public class DeleteRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleProtobufEmpty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                                : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }


                            /// <summary>Required. The name of the TransitionRouteGroup to delete. Format:
                            /// `projects//locations//agents//flows//transitionRouteGroups/`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>This field has no effect for transition route group that no page is using. If
                            /// the transition route group is referenced by any page: * If `force` is set to false, an
                            /// error will be returned with message indicating pages that reference the transition route
                            /// group. * If `force` is set to true, Dialogflow will remove the transition route group,
                            /// as well as any reference to it.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<bool> Force { get; set; }


                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+/transitionRouteGroups/[^/]+$",
                                    });
                                RequestParameters.Add(
                                    "force", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "force",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                            }

                        }

                        /// <summary>Retrieves the specified TransitionRouteGroup.</summary>
                        /// <param name="name">Required. The name of the TransitionRouteGroup. Format:
                        /// `projects//locations//agents//flows//transitionRouteGroups/`.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Retrieves the specified TransitionRouteGroup.</summary>
                        public class GetRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1TransitionRouteGroup>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name)
                                : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }


                            /// <summary>Required. The name of the TransitionRouteGroup. Format:
                            /// `projects//locations//agents//flows//transitionRouteGroups/`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>The language to list transition route groups for. The field `messages` in
                            /// TransitionRoute is language dependent. If not specified, the agent's default language is
                            /// used. [Many languages](https://cloud.google.com/dialogflow/docs/reference/language) are
                            /// supported. Note: languages must be enabled in the agent before they can be
                            /// used.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string LanguageCode { get; set; }


                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+/transitionRouteGroups/[^/]+$",
                                    });
                                RequestParameters.Add(
                                    "languageCode", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "languageCode",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
                                    });
                            }

                        }

                        /// <summary>Returns the list of all transition route groups in the specified flow.</summary>
                        /// <param name="parent">Required. The flow to list all transition route groups for. Format:
                        /// `projects//locations//agents//flows/`.</param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Returns the list of all transition route groups in the specified flow.</summary>
                        public class ListRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1ListTransitionRouteGroupsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent)
                                : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }


                            /// <summary>Required. The flow to list all transition route groups for. Format:
                            /// `projects//locations//agents//flows/`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>The language to list transition route groups for. The field `messages` in
                            /// TransitionRoute is language dependent. If not specified, the agent's default language is
                            /// used. [Many languages](https://cloud.google.com/dialogflow/docs/reference/language) are
                            /// supported. Note: languages must be enabled in the agent before they can be
                            /// used.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string LanguageCode { get; set; }

                            /// <summary>The maximum number of items to return in a single page. By default 100 and at
                            /// most 1000.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>The next_page_token value returned from a previous list request.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }


                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+parent}/transitionRouteGroups";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+$",
                                    });
                                RequestParameters.Add(
                                    "languageCode", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "languageCode",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
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
                            }

                        }

                        /// <summary>Updates the specified TransitionRouteGroup.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">The unique identifier of the transition route group.
                        /// TransitionRouteGroups.CreateTransitionRouteGroup populates the name automatically. Format:
                        /// `projects//locations//agents//flows//transitionRouteGroups/`.</param>
                        public virtual PatchRequest Patch(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1TransitionRouteGroup body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>Updates the specified TransitionRouteGroup.</summary>
                        public class PatchRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1TransitionRouteGroup>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1TransitionRouteGroup body, string name)
                                : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }


                            /// <summary>The unique identifier of the transition route group.
                            /// TransitionRouteGroups.CreateTransitionRouteGroup populates the name automatically.
                            /// Format: `projects//locations//agents//flows//transitionRouteGroups/`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>The language to list transition route groups for. The field `messages` in
                            /// TransitionRoute is language dependent. If not specified, the agent's default language is
                            /// used. [Many languages](https://cloud.google.com/dialogflow/docs/reference/language) are
                            /// supported. Note: languages must be enabled in the agent before they can be
                            /// used.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string LanguageCode { get; set; }

                            /// <summary>The mask to control which fields get updated.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }


                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1TransitionRouteGroup Body { get; set; }

                            ///<summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+/transitionRouteGroups/[^/]+$",
                                    });
                                RequestParameters.Add(
                                    "languageCode", new Google.Apis.Discovery.Parameter
                                    {
                                        Name = "languageCode",
                                        IsRequired = false,
                                        ParameterType = "query",
                                        DefaultValue = null,
                                        Pattern = null,
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
                    }
                    /// <summary>Gets the Versions resource.</summary>
                    public virtual VersionsResource Versions { get; }

                    /// <summary>The "versions" collection of methods.</summary>
                    public class VersionsResource
                    {
                        private const string Resource = "versions";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public VersionsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;

                        }


                        /// <summary>Creates a Version in the specified Flow.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">Required. The Flow to create an Version for. Format:
                        /// `projects//locations//agents//flows/`.</param>
                        public virtual CreateRequest Create(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Version body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates a Version in the specified Flow.</summary>
                        public class CreateRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Version body, string parent)
                                : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }


                            /// <summary>Required. The Flow to create an Version for. Format:
                            /// `projects//locations//agents//flows/`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }


                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Version Body { get; set; }

                            ///<summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+parent}/versions";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+$",
                                    });
                            }

                        }

                        /// <summary>Deletes the specified Version.</summary>
                        /// <param name="name">Required. The name of the Version to delete. Format:
                        /// `projects//locations//agents//flows//versions/`.</param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>Deletes the specified Version.</summary>
                        public class DeleteRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleProtobufEmpty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                                : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }


                            /// <summary>Required. The name of the Version to delete. Format:
                            /// `projects//locations//agents//flows//versions/`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }


                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+/versions/[^/]+$",
                                    });
                            }

                        }

                        /// <summary>Retrieves the specified Version.</summary>
                        /// <param name="name">Required. The name of the Version. Format:
                        /// `projects//locations//agents//flows//versions/`.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Retrieves the specified Version.</summary>
                        public class GetRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Version>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name)
                                : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }


                            /// <summary>Required. The name of the Version. Format:
                            /// `projects//locations//agents//flows//versions/`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }


                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+/versions/[^/]+$",
                                    });
                            }

                        }

                        /// <summary>Returns the list of all versions in the specified Flow.</summary>
                        /// <param name="parent">Required. The Flow to list all versions for. Format:
                        /// `projects//locations//agents//flows/`.</param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Returns the list of all versions in the specified Flow.</summary>
                        public class ListRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1ListVersionsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent)
                                : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }


                            /// <summary>Required. The Flow to list all versions for. Format:
                            /// `projects//locations//agents//flows/`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>The maximum number of items to return in a single page. By default 20 and at
                            /// most 100.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>The next_page_token value returned from a previous list request.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }


                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+parent}/versions";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+$",
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
                            }

                        }

                        /// <summary>Loads a specified version to draft version.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Required. The Version to be loaded to draft version. Format:
                        /// `projects//locations//agents//flows//versions/`.</param>
                        public virtual LoadRequest Load(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1LoadVersionRequest body, string name)
                        {
                            return new LoadRequest(service, body, name);
                        }

                        /// <summary>Loads a specified version to draft version.</summary>
                        public class LoadRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleLongrunningOperation>
                        {
                            /// <summary>Constructs a new Load request.</summary>
                            public LoadRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1LoadVersionRequest body, string name)
                                : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }


                            /// <summary>Required. The Version to be loaded to draft version. Format:
                            /// `projects//locations//agents//flows//versions/`.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }


                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1LoadVersionRequest Body { get; set; }

                            ///<summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "load";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+name}:load";

                            /// <summary>Initializes Load parameter list.</summary>
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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+/versions/[^/]+$",
                                    });
                            }

                        }

                        /// <summary>Updates the specified Version.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Format: projects//locations//agents//flows//versions/. Version ID is a self-increasing number
                        /// generated by Dialogflow upon version creation.</param>
                        public virtual PatchRequest Patch(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Version body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>Updates the specified Version.</summary>
                        public class PatchRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Version>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Version body, string name)
                                : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }


                            /// <summary>Format: projects//locations//agents//flows//versions/. Version ID is a self-
                            /// increasing number generated by Dialogflow upon version creation.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>Required. The mask to control which fields get updated. Currently only
                            /// `description` and `display_name` can be updated.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }


                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Version Body { get; set; }

                            ///<summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+/versions/[^/]+$",
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
                    }

                    /// <summary>Creates a flow in the specified agent.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The agent to create a flow for. Format: `projects//locations//agents/`.</param>
                    public virtual CreateRequest Create(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Flow body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a flow in the specified agent.</summary>
                    public class CreateRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Flow>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Flow body, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>Required. The agent to create a flow for. Format:
                        /// `projects//locations//agents/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The language of the following fields in `flow`: *
                        /// `Flow.event_handlers.trigger_fulfillment.messages` *
                        /// `Flow.transition_routes.trigger_fulfillment.messages` If not specified, the agent's default
                        /// language is used. [Many
                        /// languages](https://cloud.google.com/dialogflow/docs/reference/language) are supported. Note:
                        /// languages must be enabled in the agent before they can be used.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string LanguageCode { get; set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Flow Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+parent}/flows";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+$",
                                });
                            RequestParameters.Add(
                                "languageCode", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "languageCode",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Deletes a specified flow.</summary>
                    /// <param name="name">Required. The name of the flow to delete. Format:
                    /// `projects//locations//agents//flows/`.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a specified flow.</summary>
                    public class DeleteRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                            : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>Required. The name of the flow to delete. Format:
                        /// `projects//locations//agents//flows/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>This field has no effect for flows with no incoming transitions. For flows with
                        /// incoming transitions: * If `force` is set to false, an error will be returned with message
                        /// indicating the incoming transitions. * If `force` is set to true, Dialogflow will remove the
                        /// flow, as well as any transitions to the flow (i.e. Target flow in event handlers or Target
                        /// flow in transition routes that point to this flow will be cleared).</summary>
                        [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> Force { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+$",
                                });
                            RequestParameters.Add(
                                "force", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "force",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Retrieves the specified flow.</summary>
                    /// <param name="name">Required. The name of the flow to get. Format:
                    /// `projects//locations//agents//flows/`.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Retrieves the specified flow.</summary>
                    public class GetRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Flow>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name)
                            : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>Required. The name of the flow to get. Format:
                        /// `projects//locations//agents//flows/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The language to retrieve the flow for. The following fields are language dependent:
                        /// * `Flow.event_handlers.trigger_fulfillment.messages` *
                        /// `Flow.transition_routes.trigger_fulfillment.messages` If not specified, the agent's default
                        /// language is used. [Many
                        /// languages](https://cloud.google.com/dialogflow/docs/reference/language) are supported. Note:
                        /// languages must be enabled in the agent before they can be used.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string LanguageCode { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+$",
                                });
                            RequestParameters.Add(
                                "languageCode", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "languageCode",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Returns the list of all flows in the specified agent.</summary>
                    /// <param name="parent">Required. The agent containing the flows. Format: `projects//locations//agents/`.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Returns the list of all flows in the specified agent.</summary>
                    public class ListRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1ListFlowsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }


                        /// <summary>Required. The agent containing the flows. Format:
                        /// `projects//locations//agents/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The language to list flows for. The following fields are language dependent: *
                        /// `Flow.event_handlers.trigger_fulfillment.messages` *
                        /// `Flow.transition_routes.trigger_fulfillment.messages` If not specified, the agent's default
                        /// language is used. [Many
                        /// languages](https://cloud.google.com/dialogflow/docs/reference/language) are supported. Note:
                        /// languages must be enabled in the agent before they can be used.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string LanguageCode { get; set; }

                        /// <summary>The maximum number of items to return in a single page. By default 100 and at most
                        /// 1000.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The next_page_token value returned from a previous list request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+parent}/flows";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+$",
                                });
                            RequestParameters.Add(
                                "languageCode", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "languageCode",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
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
                        }

                    }

                    /// <summary>Updates the specified flow.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">The unique identifier of the flow. Format: `projects//locations//agents//flows/`.</param>
                    public virtual PatchRequest Patch(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Flow body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates the specified flow.</summary>
                    public class PatchRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Flow>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Flow body, string name)
                            : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>The unique identifier of the flow. Format:
                        /// `projects//locations//agents//flows/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The language of the following fields in `flow`: *
                        /// `Flow.event_handlers.trigger_fulfillment.messages` *
                        /// `Flow.transition_routes.trigger_fulfillment.messages` If not specified, the agent's default
                        /// language is used. [Many
                        /// languages](https://cloud.google.com/dialogflow/docs/reference/language) are supported. Note:
                        /// languages must be enabled in the agent before they can be used.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string LanguageCode { get; set; }

                        /// <summary>Required. The mask to control which fields get updated. If `update_mask` is not
                        /// specified, an error will be returned.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Flow Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+$",
                                });
                            RequestParameters.Add(
                                "languageCode", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "languageCode",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
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

                    /// <summary>Trains the specified flow. Note that only the flow in 'draft' environment is
                    /// trained.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">Required. The flow to train. Format: `projects//locations//agents//flows/`.</param>
                    public virtual TrainRequest Train(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1TrainFlowRequest body, string name)
                    {
                        return new TrainRequest(service, body, name);
                    }

                    /// <summary>Trains the specified flow. Note that only the flow in 'draft' environment is
                    /// trained.</summary>
                    public class TrainRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleLongrunningOperation>
                    {
                        /// <summary>Constructs a new Train request.</summary>
                        public TrainRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1TrainFlowRequest body, string name)
                            : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>Required. The flow to train. Format:
                        /// `projects//locations//agents//flows/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1TrainFlowRequest Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "train";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+name}:train";

                        /// <summary>Initializes Train parameter list.</summary>
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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/flows/[^/]+$",
                                });
                        }

                    }
                }
                /// <summary>Gets the Intents resource.</summary>
                public virtual IntentsResource Intents { get; }

                /// <summary>The "intents" collection of methods.</summary>
                public class IntentsResource
                {
                    private const string Resource = "intents";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public IntentsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;

                    }


                    /// <summary>Creates an intent in the specified agent.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The agent to create an intent for. Format:
                    /// `projects//locations//agents/`.</param>
                    public virtual CreateRequest Create(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Intent body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates an intent in the specified agent.</summary>
                    public class CreateRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Intent>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Intent body, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>Required. The agent to create an intent for. Format:
                        /// `projects//locations//agents/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The language of the following fields in `intent`: *
                        /// `Intent.training_phrases.parts.text` If not specified, the agent's default language is used.
                        /// [Many languages](https://cloud.google.com/dialogflow/docs/reference/language) are supported.
                        /// Note: languages must be enabled in the agent before they can be used.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string LanguageCode { get; set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Intent Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+parent}/intents";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+$",
                                });
                            RequestParameters.Add(
                                "languageCode", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "languageCode",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Deletes the specified intent.</summary>
                    /// <param name="name">Required. The name of the intent to delete. Format:
                    /// `projects//locations//agents//intents/`.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes the specified intent.</summary>
                    public class DeleteRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                            : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>Required. The name of the intent to delete. Format:
                        /// `projects//locations//agents//intents/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/intents/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Retrieves the specified intent.</summary>
                    /// <param name="name">Required. The name of the intent. Format: `projects//locations//agents//intents/`.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Retrieves the specified intent.</summary>
                    public class GetRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Intent>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name)
                            : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>Required. The name of the intent. Format:
                        /// `projects//locations//agents//intents/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The language to retrieve the intent for. The following fields are language
                        /// dependent: * `Intent.training_phrases.parts.text` If not specified, the agent's default
                        /// language is used. [Many
                        /// languages](https://cloud.google.com/dialogflow/docs/reference/language) are supported. Note:
                        /// languages must be enabled in the agent before they can be used.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string LanguageCode { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/intents/[^/]+$",
                                });
                            RequestParameters.Add(
                                "languageCode", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "languageCode",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Returns the list of all intents in the specified agent.</summary>
                    /// <param name="parent">Required. The agent to list all intents for. Format:
                    /// `projects//locations//agents/`.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Returns the list of all intents in the specified agent.</summary>
                    public class ListRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1ListIntentsResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }


                        /// <summary>Required. The agent to list all intents for. Format:
                        /// `projects//locations//agents/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The resource view to apply to the returned intent.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("intentView", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<IntentViewEnum> IntentView { get; set; }

                        /// <summary>The resource view to apply to the returned intent.</summary>
                        public enum IntentViewEnum
                        {
                            /// <summary>Not specified. Treated as INTENT_VIEW_FULL.</summary>
                            [Google.Apis.Util.StringValueAttribute("INTENT_VIEW_UNSPECIFIED")]
                            INTENTVIEWUNSPECIFIED,
                            /// <summary>Training phrases field is not populated in the response.</summary>
                            [Google.Apis.Util.StringValueAttribute("INTENT_VIEW_PARTIAL")]
                            INTENTVIEWPARTIAL,
                            /// <summary>All fields are populated.</summary>
                            [Google.Apis.Util.StringValueAttribute("INTENT_VIEW_FULL")]
                            INTENTVIEWFULL,
                        }

                        /// <summary>The language to list intents for. The following fields are language dependent: *
                        /// `Intent.training_phrases.parts.text` If not specified, the agent's default language is used.
                        /// [Many languages](https://cloud.google.com/dialogflow/docs/reference/language) are supported.
                        /// Note: languages must be enabled in the agent before they can be used.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string LanguageCode { get; set; }

                        /// <summary>The maximum number of items to return in a single page. By default 100 and at most
                        /// 1000.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The next_page_token value returned from a previous list request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+parent}/intents";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+$",
                                });
                            RequestParameters.Add(
                                "intentView", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "intentView",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            RequestParameters.Add(
                                "languageCode", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "languageCode",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
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
                        }

                    }

                    /// <summary>Updates the specified intent.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">The unique identifier of the intent. Required for the Intents.UpdateIntent method.
                    /// Intents.CreateIntent populates the name automatically. Format: `projects//locations//agents//intents/`.</param>
                    public virtual PatchRequest Patch(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Intent body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates the specified intent.</summary>
                    public class PatchRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Intent>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Intent body, string name)
                            : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>The unique identifier of the intent. Required for the Intents.UpdateIntent method.
                        /// Intents.CreateIntent populates the name automatically. Format:
                        /// `projects//locations//agents//intents/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The language of the following fields in `intent`: *
                        /// `Intent.training_phrases.parts.text` If not specified, the agent's default language is used.
                        /// [Many languages](https://cloud.google.com/dialogflow/docs/reference/language) are supported.
                        /// Note: languages must be enabled in the agent before they can be used.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("languageCode", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string LanguageCode { get; set; }

                        /// <summary>The mask to control which fields get updated. If the mask is not present, all
                        /// fields will be updated.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Intent Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/intents/[^/]+$",
                                });
                            RequestParameters.Add(
                                "languageCode", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "languageCode",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
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
                }
                /// <summary>Gets the Sessions resource.</summary>
                public virtual SessionsResource Sessions { get; }

                /// <summary>The "sessions" collection of methods.</summary>
                public class SessionsResource
                {
                    private const string Resource = "sessions";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public SessionsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        EntityTypes = new EntityTypesResource(service);

                    }

                    /// <summary>Gets the EntityTypes resource.</summary>
                    public virtual EntityTypesResource EntityTypes { get; }

                    /// <summary>The "entityTypes" collection of methods.</summary>
                    public class EntityTypesResource
                    {
                        private const string Resource = "entityTypes";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public EntityTypesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;

                        }


                        /// <summary>Creates a session entity type. If the specified session entity type already exists,
                        /// overrides the session entity type.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="parent">Required. The session to create a session entity type for. Format:
                        /// `projects//locations//agents//sessions/` or `projects//locations//agents//environments//sessions/`. If `Environment
                        /// ID` is not specified, we assume default 'draft' environment.</param>
                        public virtual CreateRequest Create(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType body, string parent)
                        {
                            return new CreateRequest(service, body, parent);
                        }

                        /// <summary>Creates a session entity type. If the specified session entity type already exists,
                        /// overrides the session entity type.</summary>
                        public class CreateRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType>
                        {
                            /// <summary>Constructs a new Create request.</summary>
                            public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType body, string parent)
                                : base(service)
                            {
                                Parent = parent;
                                Body = body;
                                InitParameters();
                            }


                            /// <summary>Required. The session to create a session entity type for. Format:
                            /// `projects//locations//agents//sessions/` or
                            /// `projects//locations//agents//environments//sessions/`. If `Environment ID` is not
                            /// specified, we assume default 'draft' environment.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }


                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType Body { get; set; }

                            ///<summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "create";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "POST";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+parent}/entityTypes";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/sessions/[^/]+$",
                                    });
                            }

                        }

                        /// <summary>Deletes the specified session entity type.</summary>
                        /// <param name="name">Required. The name of the session entity type to delete. Format:
                        /// `projects//locations//agents//sessions//entityTypes/` or
                        /// `projects//locations//agents//environments//sessions//entityTypes/`. If `Environment ID` is not specified, we assume
                        /// default 'draft' environment.</param>
                        public virtual DeleteRequest Delete(string name)
                        {
                            return new DeleteRequest(service, name);
                        }

                        /// <summary>Deletes the specified session entity type.</summary>
                        public class DeleteRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleProtobufEmpty>
                        {
                            /// <summary>Constructs a new Delete request.</summary>
                            public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                                : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }


                            /// <summary>Required. The name of the session entity type to delete. Format:
                            /// `projects//locations//agents//sessions//entityTypes/` or
                            /// `projects//locations//agents//environments//sessions//entityTypes/`. If `Environment ID`
                            /// is not specified, we assume default 'draft' environment.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }


                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "delete";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "DELETE";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/sessions/[^/]+/entityTypes/[^/]+$",
                                    });
                            }

                        }

                        /// <summary>Retrieves the specified session entity type.</summary>
                        /// <param name="name">Required. The name of the session entity type. Format:
                        /// `projects//locations//agents//sessions//entityTypes/` or
                        /// `projects//locations//agents//environments//sessions//entityTypes/`. If `Environment ID` is not specified, we assume
                        /// default 'draft' environment.</param>
                        public virtual GetRequest Get(string name)
                        {
                            return new GetRequest(service, name);
                        }

                        /// <summary>Retrieves the specified session entity type.</summary>
                        public class GetRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType>
                        {
                            /// <summary>Constructs a new Get request.</summary>
                            public GetRequest(Google.Apis.Services.IClientService service, string name)
                                : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }


                            /// <summary>Required. The name of the session entity type. Format:
                            /// `projects//locations//agents//sessions//entityTypes/` or
                            /// `projects//locations//agents//environments//sessions//entityTypes/`. If `Environment ID`
                            /// is not specified, we assume default 'draft' environment.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }


                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "get";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/sessions/[^/]+/entityTypes/[^/]+$",
                                    });
                            }

                        }

                        /// <summary>Returns the list of all session entity types in the specified session.</summary>
                        /// <param name="parent">Required. The session to list all session entity types from. Format:
                        /// `projects//locations//agents//sessions/` or `projects//locations//agents//environments//sessions/`. If `Environment
                        /// ID` is not specified, we assume default 'draft' environment.</param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>Returns the list of all session entity types in the specified session.</summary>
                        public class ListRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1ListSessionEntityTypesResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent)
                                : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }


                            /// <summary>Required. The session to list all session entity types from. Format:
                            /// `projects//locations//agents//sessions/` or
                            /// `projects//locations//agents//environments//sessions/`. If `Environment ID` is not
                            /// specified, we assume default 'draft' environment.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>The maximum number of items to return in a single page. By default 100 and at
                            /// most 1000.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>The next_page_token value returned from a previous list request.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }


                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+parent}/entityTypes";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/sessions/[^/]+$",
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
                            }

                        }

                        /// <summary>Updates the specified session entity type.</summary>
                        /// <param name="body">The body of the request.</param>
                        /// <param name="name">Required. The unique identifier of the session entity type. Format:
                        /// `projects//locations//agents//sessions//entityTypes/` or
                        /// `projects//locations//agents//environments//sessions//entityTypes/`. If `Environment ID` is not specified, we assume
                        /// default 'draft' environment.</param>
                        public virtual PatchRequest Patch(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType body, string name)
                        {
                            return new PatchRequest(service, body, name);
                        }

                        /// <summary>Updates the specified session entity type.</summary>
                        public class PatchRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType>
                        {
                            /// <summary>Constructs a new Patch request.</summary>
                            public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType body, string name)
                                : base(service)
                            {
                                Name = name;
                                Body = body;
                                InitParameters();
                            }


                            /// <summary>Required. The unique identifier of the session entity type. Format:
                            /// `projects//locations//agents//sessions//entityTypes/` or
                            /// `projects//locations//agents//environments//sessions//entityTypes/`. If `Environment ID`
                            /// is not specified, we assume default 'draft' environment.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>The mask to control which fields get updated.</summary>
                            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object UpdateMask { get; set; }


                            /// <summary>Gets or sets the body of this request.</summary>
                            Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1SessionEntityType Body { get; set; }

                            ///<summary>Returns the body of the request.</summary>
                            protected override object GetBody() => Body;

                            ///<summary>Gets the method name.</summary>
                            public override string MethodName => "patch";

                            ///<summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "PATCH";

                            ///<summary>Gets the REST path.</summary>
                            public override string RestPath => "v3beta1/{+name}";

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
                                        Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/sessions/[^/]+/entityTypes/[^/]+$",
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
                    }

                    /// <summary>Processes a natural language query and returns structured, actionable data as a result.
                    /// This method is not idempotent, because it may cause session entity types to be updated, which in
                    /// turn might affect results of future queries.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">Required. The name of the session this query is sent to. Format:
                    /// `projects//locations//agents//sessions/` or `projects//locations//agents//environments//sessions/`. If `Environment
                    /// ID` is not specified, we assume default 'draft' environment. It's up to the API caller to choose an appropriate
                    /// `Session ID`. It can be a random number or some type of session identifiers (preferably hashed). The length of the
                    /// `Session ID` must not exceed 36 characters.</param>
                    public virtual DetectIntentRequest DetectIntent(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1DetectIntentRequest body, string session)
                    {
                        return new DetectIntentRequest(service, body, session);
                    }

                    /// <summary>Processes a natural language query and returns structured, actionable data as a result.
                    /// This method is not idempotent, because it may cause session entity types to be updated, which in
                    /// turn might affect results of future queries.</summary>
                    public class DetectIntentRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1DetectIntentResponse>
                    {
                        /// <summary>Constructs a new DetectIntent request.</summary>
                        public DetectIntentRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1DetectIntentRequest body, string session)
                            : base(service)
                        {
                            Session = session;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>Required. The name of the session this query is sent to. Format:
                        /// `projects//locations//agents//sessions/` or
                        /// `projects//locations//agents//environments//sessions/`. If `Environment ID` is not
                        /// specified, we assume default 'draft' environment. It's up to the API caller to choose an
                        /// appropriate `Session ID`. It can be a random number or some type of session identifiers
                        /// (preferably hashed). The length of the `Session ID` must not exceed 36 characters.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Session { get; private set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1DetectIntentRequest Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "detectIntent";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+session}:detectIntent";

                        /// <summary>Initializes DetectIntent parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "session", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "session",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/sessions/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Fulfills a matched intent returned by MatchIntent. Must be called after MatchIntent,
                    /// with input from MatchIntentResponse. Otherwise, the behavior is undefined.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">Required. The name of the session this query is sent to. Format:
                    /// `projects//locations//agents//sessions/` or `projects//locations//agents//environments//sessions/`. If `Environment
                    /// ID` is not specified, we assume default 'draft' environment. It's up to the API caller to choose an appropriate
                    /// `Session ID`. It can be a random number or some type of session identifiers (preferably hashed). The length of the
                    /// `Session ID` must not exceed 36 characters.</param>
                    public virtual FulfillIntentRequest FulfillIntent(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1FulfillIntentRequest body, string session)
                    {
                        return new FulfillIntentRequest(service, body, session);
                    }

                    /// <summary>Fulfills a matched intent returned by MatchIntent. Must be called after MatchIntent,
                    /// with input from MatchIntentResponse. Otherwise, the behavior is undefined.</summary>
                    public class FulfillIntentRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1FulfillIntentResponse>
                    {
                        /// <summary>Constructs a new FulfillIntent request.</summary>
                        public FulfillIntentRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1FulfillIntentRequest body, string session)
                            : base(service)
                        {
                            Session = session;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>Required. The name of the session this query is sent to. Format:
                        /// `projects//locations//agents//sessions/` or
                        /// `projects//locations//agents//environments//sessions/`. If `Environment ID` is not
                        /// specified, we assume default 'draft' environment. It's up to the API caller to choose an
                        /// appropriate `Session ID`. It can be a random number or some type of session identifiers
                        /// (preferably hashed). The length of the `Session ID` must not exceed 36 characters.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Session { get; private set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1FulfillIntentRequest Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "fulfillIntent";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+session}:fulfillIntent";

                        /// <summary>Initializes FulfillIntent parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "session", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "session",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/sessions/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Returns preliminary intent match results, doesn't change the session status.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="session">Required. The name of the session this query is sent to. Format:
                    /// `projects//locations//agents//sessions/` or `projects//locations//agents//environments//sessions/`. If `Environment
                    /// ID` is not specified, we assume default 'draft' environment. It's up to the API caller to choose an appropriate
                    /// `Session ID`. It can be a random number or some type of session identifiers (preferably hashed). The length of the
                    /// `Session ID` must not exceed 36 characters.</param>
                    public virtual MatchIntentRequest MatchIntent(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1MatchIntentRequest body, string session)
                    {
                        return new MatchIntentRequest(service, body, session);
                    }

                    /// <summary>Returns preliminary intent match results, doesn't change the session status.</summary>
                    public class MatchIntentRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1MatchIntentResponse>
                    {
                        /// <summary>Constructs a new MatchIntent request.</summary>
                        public MatchIntentRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1MatchIntentRequest body, string session)
                            : base(service)
                        {
                            Session = session;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>Required. The name of the session this query is sent to. Format:
                        /// `projects//locations//agents//sessions/` or
                        /// `projects//locations//agents//environments//sessions/`. If `Environment ID` is not
                        /// specified, we assume default 'draft' environment. It's up to the API caller to choose an
                        /// appropriate `Session ID`. It can be a random number or some type of session identifiers
                        /// (preferably hashed). The length of the `Session ID` must not exceed 36 characters.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("session", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Session { get; private set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1MatchIntentRequest Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "matchIntent";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+session}:matchIntent";

                        /// <summary>Initializes MatchIntent parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();

                            RequestParameters.Add(
                                "session", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "session",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/sessions/[^/]+$",
                                });
                        }

                    }
                }
                /// <summary>Gets the Webhooks resource.</summary>
                public virtual WebhooksResource Webhooks { get; }

                /// <summary>The "webhooks" collection of methods.</summary>
                public class WebhooksResource
                {
                    private const string Resource = "webhooks";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public WebhooksResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;

                    }


                    /// <summary>Creates a webhook in the specified agent.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">Required. The agent to create a webhook for. Format:
                    /// `projects//locations//agents/`.</param>
                    public virtual CreateRequest Create(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Webhook body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a webhook in the specified agent.</summary>
                    public class CreateRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Webhook>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Webhook body, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>Required. The agent to create a webhook for. Format:
                        /// `projects//locations//agents/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Webhook Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+parent}/webhooks";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Deletes the specified webhook.</summary>
                    /// <param name="name">Required. The name of the webhook to delete. Format:
                    /// `projects//locations//agents//webhooks/`.</param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes the specified webhook.</summary>
                    public class DeleteRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleProtobufEmpty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                            : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>Required. The name of the webhook to delete. Format:
                        /// `projects//locations//agents//webhooks/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>This field has no effect for webhook not being used. For webhooks that are used by
                        /// pages/flows/transition route groups: * If `force` is set to false, an error will be returned
                        /// with message indicating the referenced resources. * If `force` is set to true, Dialogflow
                        /// will remove the webhook, as well as any references to the webhook (i.e. Webhook and tagin
                        /// fulfillments that point to this webhook will be removed).</summary>
                        [Google.Apis.Util.RequestParameterAttribute("force", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<bool> Force { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/webhooks/[^/]+$",
                                });
                            RequestParameters.Add(
                                "force", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "force",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                        }

                    }

                    /// <summary>Retrieves the specified webhook.</summary>
                    /// <param name="name">Required. The name of the webhook. Format: `projects//locations//agents//webhooks/`.</param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Retrieves the specified webhook.</summary>
                    public class GetRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Webhook>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name)
                            : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }


                        /// <summary>Required. The name of the webhook. Format:
                        /// `projects//locations//agents//webhooks/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/webhooks/[^/]+$",
                                });
                        }

                    }

                    /// <summary>Returns the list of all webhooks in the specified agent.</summary>
                    /// <param name="parent">Required. The agent to list all webhooks for. Format:
                    /// `projects//locations//agents/`.</param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>Returns the list of all webhooks in the specified agent.</summary>
                    public class ListRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1ListWebhooksResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent)
                            : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }


                        /// <summary>Required. The agent to list all webhooks for. Format:
                        /// `projects//locations//agents/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>The maximum number of items to return in a single page. By default 100 and at most
                        /// 1000.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>The next_page_token value returned from a previous list request.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }


                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+parent}/webhooks";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+$",
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
                        }

                    }

                    /// <summary>Updates the specified webhook.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">The unique identifier of the webhook. Required for the Webhooks.UpdateWebhook method.
                    /// Webhooks.CreateWebhook populates the name automatically. Format:
                    /// `projects//locations//agents//webhooks/`.</param>
                    public virtual PatchRequest Patch(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Webhook body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates the specified webhook.</summary>
                    public class PatchRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Webhook>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Webhook body, string name)
                            : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }


                        /// <summary>The unique identifier of the webhook. Required for the Webhooks.UpdateWebhook
                        /// method. Webhooks.CreateWebhook populates the name automatically. Format:
                        /// `projects//locations//agents//webhooks/`.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>The mask to control which fields get updated. If the mask is not present, all
                        /// fields will be updated.</summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }


                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Webhook Body { get; set; }

                        ///<summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        ///<summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        ///<summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        ///<summary>Gets the REST path.</summary>
                        public override string RestPath => "v3beta1/{+name}";

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
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+/webhooks/[^/]+$",
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
                }

                /// <summary>Creates an agent in the specified location.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The location to create a agent for. Format: `projects//locations/`.</param>
                public virtual CreateRequest Create(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Agent body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates an agent in the specified location.</summary>
                public class CreateRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Agent>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Agent body, string parent)
                        : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. The location to create a agent for. Format: `projects//locations/`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Agent Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v3beta1/{+parent}/agents";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+$",
                            });
                    }

                }

                /// <summary>Deletes the specified agent.</summary>
                /// <param name="name">Required. The name of the agent to delete. Format: `projects//locations//agents/`.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes the specified agent.</summary>
                public class DeleteRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                        : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }


                    /// <summary>Required. The name of the agent to delete. Format:
                    /// `projects//locations//agents/`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v3beta1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+$",
                            });
                    }

                }

                /// <summary>Exports the specified agent to a ZIP file.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The name of the agent to export. Format: `projects//locations//agents/`.</param>
                public virtual ExportRequest Export(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1ExportAgentRequest body, string name)
                {
                    return new ExportRequest(service, body, name);
                }

                /// <summary>Exports the specified agent to a ZIP file.</summary>
                public class ExportRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Export request.</summary>
                    public ExportRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1ExportAgentRequest body, string name)
                        : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. The name of the agent to export. Format:
                    /// `projects//locations//agents/`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1ExportAgentRequest Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "export";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v3beta1/{+name}:export";

                    /// <summary>Initializes Export parameter list.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+$",
                            });
                    }

                }

                /// <summary>Retrieves the specified agent.</summary>
                /// <param name="name">Required. The name of the agent. Format: `projects//locations//agents/`.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Retrieves the specified agent.</summary>
                public class GetRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Agent>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name)
                        : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }


                    /// <summary>Required. The name of the agent. Format: `projects//locations//agents/`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v3beta1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+$",
                            });
                    }

                }

                /// <summary>Returns the list of all agents in the specified location.</summary>
                /// <param name="parent">Required. The location to list all agents for. Format: `projects//locations/`.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Returns the list of all agents in the specified location.</summary>
                public class ListRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1ListAgentsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent)
                        : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }


                    /// <summary>Required. The location to list all agents for. Format:
                    /// `projects//locations/`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>The maximum number of items to return in a single page. By default 100 and at most
                    /// 1000.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The next_page_token value returned from a previous list request.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v3beta1/{+parent}/agents";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+$",
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
                    }

                }

                /// <summary>Updates the specified agent.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">The unique identifier of the agent. Required for the Agents.UpdateAgent method.
                /// Agents.CreateAgent populates the name automatically. Format: `projects//locations//agents/`.</param>
                public virtual PatchRequest Patch(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Agent body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates the specified agent.</summary>
                public class PatchRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Agent>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Agent body, string name)
                        : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>The unique identifier of the agent. Required for the Agents.UpdateAgent method.
                    /// Agents.CreateAgent populates the name automatically. Format:
                    /// `projects//locations//agents/`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The mask to control which fields get updated. If the mask is not present, all fields
                    /// will be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1Agent Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v3beta1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+$",
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

                /// <summary>Restores the specified agent from a ZIP file. Note that all existing intents, intent
                /// routes, entity types, pages and webhooks in the agent will be deleted.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. The name of the agent to restore into. Format:
                /// `projects//locations//agents/`.</param>
                public virtual RestoreRequest Restore(Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1RestoreAgentRequest body, string name)
                {
                    return new RestoreRequest(service, body, name);
                }

                /// <summary>Restores the specified agent from a ZIP file. Note that all existing intents, intent
                /// routes, entity types, pages and webhooks in the agent will be deleted.</summary>
                public class RestoreRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Restore request.</summary>
                    public RestoreRequest(Google.Apis.Services.IClientService service, Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1RestoreAgentRequest body, string name)
                        : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. The name of the agent to restore into. Format:
                    /// `projects//locations//agents/`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.Dialogflow.v3beta1.Data.GoogleCloudDialogflowCxV3beta1RestoreAgentRequest Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "restore";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v3beta1/{+name}:restore";

                    /// <summary>Initializes Restore parameter list.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/agents/[^/]+$",
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


                /// <summary>Starts asynchronous cancellation on a long-running operation. The server makes a best
                /// effort to cancel the operation, but success is not guaranteed. If the server doesn't support this
                /// method, it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                /// methods to check whether the cancellation succeeded or whether the operation completed despite
                /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                /// operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to
                /// `Code.CANCELLED`.</summary>
                /// <param name="name">The name of the operation resource to be cancelled.</param>
                public virtual CancelRequest Cancel(string name)
                {
                    return new CancelRequest(service, name);
                }

                /// <summary>Starts asynchronous cancellation on a long-running operation. The server makes a best
                /// effort to cancel the operation, but success is not guaranteed. If the server doesn't support this
                /// method, it returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other
                /// methods to check whether the cancellation succeeded or whether the operation completed despite
                /// cancellation. On successful cancellation, the operation is not deleted; instead, it becomes an
                /// operation with an Operation.error value with a google.rpc.Status.code of 1, corresponding to
                /// `Code.CANCELLED`.</summary>
                public class CancelRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleProtobufEmpty>
                {
                    /// <summary>Constructs a new Cancel request.</summary>
                    public CancelRequest(Google.Apis.Services.IClientService service, string name)
                        : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }


                    /// <summary>The name of the operation resource to be cancelled.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "cancel";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v3beta1/{+name}:cancel";

                    /// <summary>Initializes Cancel parameter list.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                            });
                    }

                }

                /// <summary>Gets the latest state of a long-running operation. Clients can use this method to poll the
                /// operation result at intervals as recommended by the API service.</summary>
                /// <param name="name">The name of the operation resource.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets the latest state of a long-running operation. Clients can use this method to poll the
                /// operation result at intervals as recommended by the API service.</summary>
                public class GetRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleLongrunningOperation>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name)
                        : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }


                    /// <summary>The name of the operation resource.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v3beta1/{+name}";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/operations/[^/]+$",
                            });
                    }

                }

                /// <summary>Lists operations that match the specified filter in the request. If the server doesn't
                /// support this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                /// override the binding to use different resource name schemes, such as `users/operations`. To override
                /// the binding, API services can add a binding such as `"/v1/{name=users}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.</summary>
                /// <param name="name">The name of the operation's parent resource.</param>
                public virtual ListRequest List(string name)
                {
                    return new ListRequest(service, name);
                }

                /// <summary>Lists operations that match the specified filter in the request. If the server doesn't
                /// support this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to
                /// override the binding to use different resource name schemes, such as `users/operations`. To override
                /// the binding, API services can add a binding such as `"/v1/{name=users}/operations"` to their service
                /// configuration. For backwards compatibility, the default name includes the operations collection id,
                /// however overriding users must ensure the name binding is the parent resource, without the operations
                /// collection id.</summary>
                public class ListRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleLongrunningListOperationsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string name)
                        : base(service)
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


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v3beta1/{+name}/operations";

                    /// <summary>Initializes List parameter list.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+$",
                            });
                        RequestParameters.Add(
                            "filter", new Google.Apis.Discovery.Parameter
                            {
                                Name = "filter",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
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
                    }

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


            /// <summary>Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
            /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
            /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
            /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
            /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
            /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.</summary>
            /// <param name="name">The name of the operation resource to be cancelled.</param>
            public virtual CancelRequest Cancel(string name)
            {
                return new CancelRequest(service, name);
            }

            /// <summary>Starts asynchronous cancellation on a long-running operation. The server makes a best effort to
            /// cancel the operation, but success is not guaranteed. If the server doesn't support this method, it
            /// returns `google.rpc.Code.UNIMPLEMENTED`. Clients can use Operations.GetOperation or other methods to
            /// check whether the cancellation succeeded or whether the operation completed despite cancellation. On
            /// successful cancellation, the operation is not deleted; instead, it becomes an operation with an
            /// Operation.error value with a google.rpc.Status.code of 1, corresponding to `Code.CANCELLED`.</summary>
            public class CancelRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleProtobufEmpty>
            {
                /// <summary>Constructs a new Cancel request.</summary>
                public CancelRequest(Google.Apis.Services.IClientService service, string name)
                    : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>The name of the operation resource to be cancelled.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "cancel";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v3beta1/{+name}:cancel";

                /// <summary>Initializes Cancel parameter list.</summary>
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
                            Pattern = @"^projects/[^/]+/operations/[^/]+$",
                        });
                }

            }

            /// <summary>Gets the latest state of a long-running operation. Clients can use this method to poll the
            /// operation result at intervals as recommended by the API service.</summary>
            /// <param name="name">The name of the operation resource.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets the latest state of a long-running operation. Clients can use this method to poll the
            /// operation result at intervals as recommended by the API service.</summary>
            public class GetRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleLongrunningOperation>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name)
                    : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>The name of the operation resource.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v3beta1/{+name}";

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
                            Pattern = @"^projects/[^/]+/operations/[^/]+$",
                        });
                }

            }

            /// <summary>Lists operations that match the specified filter in the request. If the server doesn't support
            /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
            /// binding to use different resource name schemes, such as `users/operations`. To override the binding, API
            /// services can add a binding such as `"/v1/{name=users}/operations"` to their service configuration. For
            /// backwards compatibility, the default name includes the operations collection id, however overriding
            /// users must ensure the name binding is the parent resource, without the operations collection
            /// id.</summary>
            /// <param name="name">The name of the operation's parent resource.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>Lists operations that match the specified filter in the request. If the server doesn't support
            /// this method, it returns `UNIMPLEMENTED`. NOTE: the `name` binding allows API services to override the
            /// binding to use different resource name schemes, such as `users/operations`. To override the binding, API
            /// services can add a binding such as `"/v1/{name=users}/operations"` to their service configuration. For
            /// backwards compatibility, the default name includes the operations collection id, however overriding
            /// users must ensure the name binding is the parent resource, without the operations collection
            /// id.</summary>
            public class ListRequest : DialogflowBaseServiceRequest<Google.Apis.Dialogflow.v3beta1.Data.GoogleLongrunningListOperationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name)
                    : base(service)
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


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v3beta1/{+name}/operations";

                /// <summary>Initializes List parameter list.</summary>
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
                            Pattern = @"^projects/[^/]+$",
                        });
                    RequestParameters.Add(
                        "filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
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
                }

            }
        }
    }
}

namespace Google.Apis.Dialogflow.v3beta1.Data
{    

    /// <summary>Agents are best described as Natural Language Understanding (NLU) modules that transform user requests
    /// into actionable data. You can include agents in your app, product, or service to determine user intent and
    /// respond to the user in a natural way. After you create an agent, you can add Intents, Entity Types, Flows,
    /// Fulfillments, Webhooks, and so on to manage the conversation flows..</summary>
    public class GoogleCloudDialogflowCxV3beta1Agent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The URI of the agent's avatar. Avatars are used throughout the Dialogflow console and in the self-
        /// hosted [Web Demo](https://cloud.google.com/dialogflow/docs/integrations/web-demo) integration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("avatarUri")]
        public virtual string AvatarUri { get; set; } 

        /// <summary>Immutable. The default language of the agent as a language tag. See [Language
        /// Support](https://cloud.google.com/dialogflow/docs/reference/language) for a list of the currently supported
        /// language codes. This field cannot be set by the Agents.UpdateAgent method.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultLanguageCode")]
        public virtual string DefaultLanguageCode { get; set; } 

        /// <summary>The description of the agent. The maximum length is 500 characters. If exceeded, the request is
        /// rejected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Required. The human-readable name of the agent, unique within the location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Indicates if automatic spell correction is enabled in detect intent requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSpellCorrection")]
        public virtual System.Nullable<bool> EnableSpellCorrection { get; set; } 

        /// <summary>Indicates if stackdriver logging is enabled for the agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableStackdriverLogging")]
        public virtual System.Nullable<bool> EnableStackdriverLogging { get; set; } 

        /// <summary>The unique identifier of the agent. Required for the Agents.UpdateAgent method. Agents.CreateAgent
        /// populates the name automatically. Format: `projects//locations//agents/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Speech recognition related settings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speechToTextSettings")]
        public virtual GoogleCloudDialogflowCxV3beta1SpeechToTextSettings SpeechToTextSettings { get; set; } 

        /// <summary>Immutable. Name of the start flow in this agent. A start flow will be automatically created when
        /// the agent is created, and can only be deleted by deleting the agent. Format:
        /// `projects//locations//agents//flows/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startFlow")]
        public virtual string StartFlow { get; set; } 

        /// <summary>Required. The time zone of the agent from the [time zone database](https://www.iana.org/time-
        /// zones), e.g., America/New_York, Europe/Paris.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the natural speech audio to be processed.</summary>
    public class GoogleCloudDialogflowCxV3beta1AudioInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The natural language speech audio to be processed. A single request can contain up to 1 minute of
        /// speech audio data. The transcribed text cannot contain more than 256 bytes. For non-streaming audio detect
        /// intent, both `config` and `audio` must be provided. For streaming audio detect intent, `config` must be
        /// provided in the first request and `audio` must be provided in all following requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audio")]
        public virtual string Audio { get; set; } 

        /// <summary>Required. Instructs the speech recognizer how to process the speech audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual GoogleCloudDialogflowCxV3beta1InputAudioConfig Config { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata associated with the long running operation for Versions.CreateVersion.</summary>
    public class GoogleCloudDialogflowCxV3beta1CreateVersionOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the created version. Format: `projects//locations//agents//flows//versions/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The request to detect user's intent.</summary>
    public class GoogleCloudDialogflowCxV3beta1DetectIntentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Instructs the speech synthesizer how to generate the output audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputAudioConfig")]
        public virtual GoogleCloudDialogflowCxV3beta1OutputAudioConfig OutputAudioConfig { get; set; } 

        /// <summary>Required. The input specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryInput")]
        public virtual GoogleCloudDialogflowCxV3beta1QueryInput QueryInput { get; set; } 

        /// <summary>The parameters of this query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryParams")]
        public virtual GoogleCloudDialogflowCxV3beta1QueryParameters QueryParams { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The message returned from the DetectIntent method.</summary>
    public class GoogleCloudDialogflowCxV3beta1DetectIntentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The audio data bytes encoded as specified in the request. Note: The output audio is generated based
        /// on the values of default platform text responses found in the `query_result.response_messages` field. If
        /// multiple default text responses exist, they will be concatenated when generating audio. If no default
        /// platform text responses exist, the generated audio content will be empty. In some scenarios, multiple output
        /// audio fields may be present in the response structure. In these cases, only the top-most-level audio output
        /// has content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputAudio")]
        public virtual string OutputAudio { get; set; } 

        /// <summary>The config used by the speech synthesizer to generate the output audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputAudioConfig")]
        public virtual GoogleCloudDialogflowCxV3beta1OutputAudioConfig OutputAudioConfig { get; set; } 

        /// <summary>The result of the conversational query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryResult")]
        public virtual GoogleCloudDialogflowCxV3beta1QueryResult QueryResult { get; set; } 

        /// <summary>Output only. The unique identifier of the response. It can be used to locate a response in the
        /// training example set or for reporting issues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseId")]
        public virtual string ResponseId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Entities are extracted from user input and represent parameters that are meaningful to your
    /// application. For example, a date range, a proper name such as a geographic location or landmark, and so on.
    /// Entities represent actionable data for your application. When you define an entity, you can also include
    /// synonyms that all map to that entity. For example, "soft drink", "soda", "pop", and so on. There are three types
    /// of entities: * **System** - entities that are defined by the Dialogflow API for common data types such as date,
    /// time, currency, and so on. A system entity is represented by the `EntityType` type. * **Custom** - entities that
    /// are defined by you that represent actionable data that is meaningful to your application. For example, you could
    /// define a `pizza.sauce` entity for red or white pizza sauce, a `pizza.cheese` entity for the different types of
    /// cheese on a pizza, a `pizza.topping` entity for different toppings, and so on. A custom entity is represented by
    /// the `EntityType` type. * **User** - entities that are built for an individual user such as favorites,
    /// preferences, playlists, and so on. A user entity is represented by the SessionEntityType type. For more
    /// information about entity types, see the [Dialogflow documentation](https://cloud.google.com/dialogflow/docs
    /// /entities-overview).</summary>
    public class GoogleCloudDialogflowCxV3beta1EntityType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates whether the entity type can be automatically expanded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoExpansionMode")]
        public virtual string AutoExpansionMode { get; set; } 

        /// <summary>Required. The human-readable name of the entity type, unique within the agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Enables fuzzy entity extraction during classification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableFuzzyExtraction")]
        public virtual System.Nullable<bool> EnableFuzzyExtraction { get; set; } 

        /// <summary>The collection of entity entries associated with the entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1EntityTypeEntity> Entities { get; set; } 

        /// <summary>Collection of exceptional words and phrases that shouldn't be matched. For example, if you have a
        /// size entity type with entry `giant`(an adjective), you might consider adding `giants`(a noun) as an
        /// exclusion. If the kind of entity type is `KIND_MAP`, then the phrases specified by entities and excluded
        /// phrases should be mutually exclusive.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("excludedPhrases")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1EntityTypeExcludedPhrase> ExcludedPhrases { get; set; } 

        /// <summary>Required. Indicates the kind of entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The unique identifier of the entity type. Required for EntityTypes.UpdateEntityType. Format:
        /// `projects//locations//agents//entityTypes/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An **entity entry** for an associated entity type. Next Id = 8</summary>
    public class GoogleCloudDialogflowCxV3beta1EntityTypeEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A collection of value synonyms. For example, if the entity type is *vegetable*, and
        /// `value` is *scallions*, a synonym could be *green onions*. For `KIND_LIST` entity types: * This collection
        /// must contain exactly one synonym equal to `value`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("synonyms")]
        public virtual System.Collections.Generic.IList<string> Synonyms { get; set; } 

        /// <summary>Required. The primary value associated with this entity entry. For example, if the entity type is
        /// *vegetable*, the value could be *scallions*. For `KIND_MAP` entity types: * A canonical value to be used in
        /// place of synonyms. For `KIND_LIST` entity types: * A string that can contain references to other entity
        /// types (with or without aliases).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An excluded entity phrase that should not be matched.</summary>
    public class GoogleCloudDialogflowCxV3beta1EntityTypeExcludedPhrase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The word or phrase to be excluded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents an environment for an agent. You can create multiple versions of your agent and publish them
    /// to separate environments. When you edit an agent, you are editing the draft agent. At any point, you can save
    /// the draft agent as an agent version, which is an immutable snapshot of your agent. When you save the draft
    /// agent, it is published to the default environment. When you create agent versions, you can publish them to
    /// custom environments. You can create a variety of custom environments for testing, development, production,
    /// etc.</summary>
    public class GoogleCloudDialogflowCxV3beta1Environment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human-readable description of the environment. The maximum length is 500 characters. If
        /// exceeded, the request is rejected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Required. The human-readable name of the environment (unique in an agent). Limit of 64
        /// characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>The name of the environment. Format: `projects//locations//agents//environments/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. Update time of this environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; } 

        /// <summary>Required. A list of configurations for flow versions. You should include version configs for all
        /// flows that are reachable from `Start Flow` in the agent. Otherwise, an error will be returned.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionConfigs")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1EnvironmentVersionConfig> VersionConfigs { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Configuration for the version.</summary>
    public class GoogleCloudDialogflowCxV3beta1EnvironmentVersionConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Format: projects//locations//agents//flows//versions/.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An event handler specifies an event that can be handled during a session. When the specified event
    /// happens, the following actions are taken in order: * If there is a `trigger_fulfillment` associated with the
    /// event, it will be called. * If there is a `target_page` associated with the event, the session will transition
    /// into the specified page. * If there is a `target_flow` associated with the event, the session will transition
    /// into the specified flow.</summary>
    public class GoogleCloudDialogflowCxV3beta1EventHandler : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the event to handle.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("event")]
        public virtual string Event__ { get; set; } 

        /// <summary>Output only. The unique identifier of this event handler.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The target flow to transition to. Format: `projects//locations//agents//flows/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetFlow")]
        public virtual string TargetFlow { get; set; } 

        /// <summary>The target page to transition to. Format: `projects//locations//agents//flows//pages/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetPage")]
        public virtual string TargetPage { get; set; } 

        /// <summary>The fulfillment to call when the event occurs. Handling webhook errors with a fulfillment enabled
        /// with webhook could cause infinite loop. It is invalid to specify such fulfillment for a handler handling
        /// webhooks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerFulfillment")]
        public virtual GoogleCloudDialogflowCxV3beta1Fulfillment TriggerFulfillment { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The request message for Agents.ExportAgent.</summary>
    public class GoogleCloudDialogflowCxV3beta1ExportAgentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The [Google Cloud Storage](https://cloud.google.com/storage/docs/) URI to export the
        /// agent to. The format of this URI must be `gs:`. If left unspecified, the serialized agent is returned
        /// inline.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentUri")]
        public virtual string AgentUri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Agents.ExportAgent.</summary>
    public class GoogleCloudDialogflowCxV3beta1ExportAgentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Uncompressed raw byte content for agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentContent")]
        public virtual string AgentContent { get; set; } 

        /// <summary>The URI to a file containing the exported agent. This field is populated only if `agent_uri` is
        /// specified in ExportAgentRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentUri")]
        public virtual string AgentUri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Flows represents the conversation flows when you build your chatbot agent. A flow consists of many
    /// pages connected by the transition routes. Conversations always start with the built-in Start Flow (with an all-0
    /// ID). Transition routes can direct the conversation session from the current flow (parent flow) to another flow
    /// (sub flow). When the sub flow is finished, Dialogflow will bring the session back to the parent flow, where the
    /// sub flow is started. Usually, when a transition route is followed by a matched intent, the intent will be
    /// "consumed". This means the intent won't activate more transition routes. However, when the followed transition
    /// route moves the conversation session into a different flow, the matched intent can be carried over and to be
    /// consumed in the target flow.</summary>
    public class GoogleCloudDialogflowCxV3beta1Flow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The description of the flow. The maximum length is 500 characters. If exceeded, the request is
        /// rejected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Required. The human-readable name of the flow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>A flow's event handlers serve two purposes: * They are responsible for handling events (e.g. no
        /// match, webhook errors) in the flow. * They are inherited by every page's event handlers, which can be used
        /// to handle common events regardless of the current page. Event handlers defined in the page have higher
        /// priority than those defined in the flow. Unlike transition_routes, these handlers are evaluated on a first-
        /// match basis. The first one that matches the event get executed, with the rest being ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventHandlers")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1EventHandler> EventHandlers { get; set; } 

        /// <summary>The unique identifier of the flow. Format: `projects//locations//agents//flows/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>NLU related settings of the flow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nluSettings")]
        public virtual GoogleCloudDialogflowCxV3beta1NluSettings NluSettings { get; set; } 

        /// <summary>A flow's transition routes serve two purposes: * They are responsible for matching the user's first
        /// utterances in the flow. * They are inherited by every page's transition routes and can support use cases
        /// such as the user saying "help" or "can I talk to a human?", which can be handled in a common way regardless
        /// of the current page. Transition routes defined in the page have higher priority than those defined in the
        /// flow. TransitionRoutes are evalauted in the following order: * TransitionRoutes with intent specified.. *
        /// TransitionRoutes with only condition specified. TransitionRoutes with intent specified are inherited by
        /// pages in the flow.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitionRoutes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1TransitionRoute> TransitionRoutes { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A form is a data model that groups related parameters that can be collected from the user. The process
    /// in which the agent prompts the user and collects parameter values from the user is called form filling. A form
    /// can be added to a page. When form filling is done, the filled parameters will be written to the
    /// session.</summary>
    public class GoogleCloudDialogflowCxV3beta1Form : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Parameters to collect from the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1FormParameter> Parameters { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a form parameter.</summary>
    public class GoogleCloudDialogflowCxV3beta1FormParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The default value of an optional parameter. If the parameter is required, the default value will be
        /// ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual object DefaultValue { get; set; } 

        /// <summary>Required. The human-readable name of the parameter, unique within the form.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Required. The entity type of the parameter. Format: `projects/-/locations/-/agents/-/entityTypes/`
        /// for system entity types (for example, `projects/-/locations/-/agents/-/entityTypes/sys.date`), or
        /// `projects//locations//agents//entityTypes/` for developer entity types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityType")]
        public virtual string EntityType { get; set; } 

        /// <summary>Required. Defines fill behavior for the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fillBehavior")]
        public virtual GoogleCloudDialogflowCxV3beta1FormParameterFillBehavior FillBehavior { get; set; } 

        /// <summary>Indicates whether the parameter represents a list of values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isList")]
        public virtual System.Nullable<bool> IsList { get; set; } 

        /// <summary>Indicates whether the parameter is required. Optional parameters will not trigger prompts; however,
        /// they are filled if the user specifies them. Required parameters must be filled before form filling
        /// concludes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual System.Nullable<bool> Required { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Configuration for how the filling of a parameter should be handled.</summary>
    public class GoogleCloudDialogflowCxV3beta1FormParameterFillBehavior : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The fulfillment to provide the initial prompt that the agent can present to the user in
        /// order to fill the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("initialPromptFulfillment")]
        public virtual GoogleCloudDialogflowCxV3beta1Fulfillment InitialPromptFulfillment { get; set; } 

        /// <summary>The handlers for parameter-level events, used to provide reprompt for the parameter or transition
        /// to a different page/flow. The supported events are: * `sys.no-match-`, where N can be from 1 to 6 * `sys.no-
        /// match-default` * `sys.no-input-`, where N can be from 1 to 6 * `sys.no-input-default` * `sys.invalid-
        /// parameter` `initial_prompt_fulfillment` provides the first prompt for the parameter. If the user's response
        /// does not fill the parameter, a no-match/no-input event will be triggered, and the fulfillment associated
        /// with the `sys.no-match-1`/`sys.no-input-1` handler (if defined) will be called to provide a prompt. The `sys
        /// .no-match-2`/`sys.no-input-2` handler (if defined) will respond to the next no-match/no-input event, and so
        /// on. A `sys.no-match-default` or `sys.no-input-default` handler will be used to handle all following no-match
        /// /no-input events after all numbered no-match/no-input handlers for the parameter are consumed. A `sys
        /// .invalid-parameter` handler can be defined to handle the case where the parameter values have been
        /// `invalidated` by webhook. For example, if the user's response fill the parameter, however the parameter was
        /// invalidated by webhook, the fulfillment associated with the `sys.invalid-parameter` handler (if defined)
        /// will be called to provide a prompt. If the event handler for the corresponding event can't be found on the
        /// parameter, `initial_prompt_fulfillment` will be re-prompted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repromptEventHandlers")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1EventHandler> RepromptEventHandlers { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request of FulfillIntent</summary>
    public class GoogleCloudDialogflowCxV3beta1FulfillIntentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The matched intent/event to fulfill.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("match")]
        public virtual GoogleCloudDialogflowCxV3beta1Match Match { get; set; } 

        /// <summary>Must be same as the corresponding MatchIntent request, otherwise the behavior is
        /// undefined.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchIntentRequest")]
        public virtual GoogleCloudDialogflowCxV3beta1MatchIntentRequest MatchIntentRequest { get; set; } 

        /// <summary>Instructs the speech synthesizer how to generate output audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputAudioConfig")]
        public virtual GoogleCloudDialogflowCxV3beta1OutputAudioConfig OutputAudioConfig { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response of FulfillIntent</summary>
    public class GoogleCloudDialogflowCxV3beta1FulfillIntentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The audio data bytes encoded as specified in the request. Note: The output audio is generated based
        /// on the values of default platform text responses found in the `query_result.response_messages` field. If
        /// multiple default text responses exist, they will be concatenated when generating audio. If no default
        /// platform text responses exist, the generated audio content will be empty. In some scenarios, multiple output
        /// audio fields may be present in the response structure. In these cases, only the top-most-level audio output
        /// has content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputAudio")]
        public virtual string OutputAudio { get; set; } 

        /// <summary>The config used by the speech synthesizer to generate the output audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputAudioConfig")]
        public virtual GoogleCloudDialogflowCxV3beta1OutputAudioConfig OutputAudioConfig { get; set; } 

        /// <summary>The result of the conversational query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryResult")]
        public virtual GoogleCloudDialogflowCxV3beta1QueryResult QueryResult { get; set; } 

        /// <summary>Output only. The unique identifier of the response. It can be used to locate a response in the
        /// training example set or for reporting issues.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseId")]
        public virtual string ResponseId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A fulfillment can do one or more of the following actions at the same time: * Generate rich message
    /// responses. * Set parameter values. * Call the webhook. Fulfillments can be called at various stages in the Page
    /// or Form lifecycle. For example, when a DetectIntentRequest drives a session to enter a new page, the page's
    /// entry fulfillment can add a static response to the QueryResult in the returning DetectIntentResponse, call the
    /// webhook (for example, to load user data from a database), or both.</summary>
    public class GoogleCloudDialogflowCxV3beta1Fulfillment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Conditional cases for this fulfillment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conditionalCases")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1FulfillmentConditionalCases> ConditionalCases { get; set; } 

        /// <summary>The list of rich message responses to present to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1ResponseMessage> Messages { get; set; } 

        /// <summary>Set parameter values before executing the webhook.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("setParameterActions")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1FulfillmentSetParameterAction> SetParameterActions { get; set; } 

        /// <summary>The tag used by the webhook to identify which fulfillment is being called. This field is required
        /// if `webhook` is specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; } 

        /// <summary>The webhook to call. Format: `projects//locations//agents//webhooks/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhook")]
        public virtual string Webhook { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A list of cascading if-else conditions. Cases are mutually exclusive. The first one with a matching
    /// condition is selected, all the rest ignored.</summary>
    public class GoogleCloudDialogflowCxV3beta1FulfillmentConditionalCases : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of cascading if-else conditions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cases")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1FulfillmentConditionalCasesCase> Cases { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Each case has a Boolean condition. When it is evaluated to be True, the corresponding messages will be
    /// selected and evaluated recursively.</summary>
    public class GoogleCloudDialogflowCxV3beta1FulfillmentConditionalCasesCase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of case content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("caseContent")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1FulfillmentConditionalCasesCaseCaseContent> CaseContent { get; set; } 

        /// <summary>The condition to activate and select this case. Empty means the condition is always true. The
        /// condition is evaluated against form parameters or session parameters. See the [conditions
        /// reference](https://cloud.google.com/dialogflow/cx/docs/reference/condition).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The list of messages or conditional cases to activate for this case.</summary>
    public class GoogleCloudDialogflowCxV3beta1FulfillmentConditionalCasesCaseCaseContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional cases to be evaluated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalCases")]
        public virtual GoogleCloudDialogflowCxV3beta1FulfillmentConditionalCases AdditionalCases { get; set; } 

        /// <summary>Returned message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual GoogleCloudDialogflowCxV3beta1ResponseMessage Message { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Setting a parameter value.</summary>
    public class GoogleCloudDialogflowCxV3beta1FulfillmentSetParameterAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Display name of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameter")]
        public virtual string Parameter { get; set; } 

        /// <summary>The new value of the parameter. A null value clears the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual object Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Agents.ImportAgent.</summary>
    public class GoogleCloudDialogflowCxV3beta1ImportAgentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique identifier of the new agent. Format: `projects//locations//agents/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agent")]
        public virtual string Agent { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Instructs the speech recognizer on how to process the audio content.</summary>
    public class GoogleCloudDialogflowCxV3beta1InputAudioConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Audio encoding of the audio content to process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioEncoding")]
        public virtual string AudioEncoding { get; set; } 

        /// <summary>Optional. If `true`, Dialogflow returns SpeechWordInfo in StreamingRecognitionResult with
        /// information about the recognized speech words, e.g. start and end time offsets. If false or unspecified,
        /// Speech doesn't return any word-level information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableWordInfo")]
        public virtual System.Nullable<bool> EnableWordInfo { get; set; } 

        /// <summary>Optional. Which Speech model to select for the given request. Select the model best suited to your
        /// domain to get best results. If a model is not explicitly specified, then we auto-select a model based on the
        /// parameters in the InputAudioConfig. If enhanced speech model is enabled for the agent and an enhanced
        /// version of the specified model for the language does not exist, then the speech is recognized using the
        /// standard version of the specified model. Refer to [Cloud Speech API documentation](https://cloud.google.com
        /// /speech-to-text/docs/basics#select-model) for more details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("model")]
        public virtual string Model { get; set; } 

        /// <summary>Optional. Which variant of the Speech model to use.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelVariant")]
        public virtual string ModelVariant { get; set; } 

        /// <summary>Optional. A list of strings containing words and phrases that the speech recognizer should
        /// recognize with higher likelihood. See [the Cloud Speech documentation](https://cloud.google.com/speech-to-
        /// text/docs/basics#phrase-hints) for more details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phraseHints")]
        public virtual System.Collections.Generic.IList<string> PhraseHints { get; set; } 

        /// <summary>Sample rate (in Hertz) of the audio content sent in the query. Refer to [Cloud Speech API
        /// documentation](https://cloud.google.com/speech-to-text/docs/basics) for more details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleRateHertz")]
        public virtual System.Nullable<int> SampleRateHertz { get; set; } 

        /// <summary>Optional. If `false` (default), recognition does not cease until the client closes the stream. If
        /// `true`, the recognizer will detect a single spoken utterance in input audio. Recognition ceases when it
        /// detects the audio's voice has stopped or paused. In this case, once a detected intent is received, the
        /// client should close the stream and start a new request with a new stream as needed. Note: This setting is
        /// relevant only for streaming methods.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("singleUtterance")]
        public virtual System.Nullable<bool> SingleUtterance { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An intent represents a user's intent to interact with a conversational agent. You can provide
    /// information for the Dialogflow API to use to match user input to an intent by adding training phrases (i.e.,
    /// examples of user input) to your intent.</summary>
    public class GoogleCloudDialogflowCxV3beta1Intent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The human-readable name of the intent, unique within the agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Indicates whether this is a fallback intent. Currently only default fallback intent is allowed in
        /// the agent, which is added upon agent creation. Adding training phrases to fallback intent is useful in the
        /// case of requests that are mistakenly matched, since training phrases assigned to fallback intents act as
        /// negative examples that triggers no-match event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isFallback")]
        public virtual System.Nullable<bool> IsFallback { get; set; } 

        /// <summary>The unique identifier of the intent. Required for the Intents.UpdateIntent method.
        /// Intents.CreateIntent populates the name automatically. Format:
        /// `projects//locations//agents//intents/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The collection of parameters associated with the intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1IntentParameter> Parameters { get; set; } 

        /// <summary>The priority of this intent. Higher numbers represent higher priorities. - If the supplied value is
        /// unspecified or 0, the service translates the value to 500,000, which corresponds to the `Normal` priority in
        /// the console. - If the supplied value is negative, the intent is ignored in runtime detect intent
        /// requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; } 

        /// <summary>The collection of training phrases the agent is trained on to identify the intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingPhrases")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1IntentTrainingPhrase> TrainingPhrases { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the intent to trigger programmatically rather than as a result of natural language
    /// processing.</summary>
    public class GoogleCloudDialogflowCxV3beta1IntentInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The unique identifier of the intent. Format:
        /// `projects//locations//agents//intents/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intent")]
        public virtual string Intent { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents an intent parameter.</summary>
    public class GoogleCloudDialogflowCxV3beta1IntentParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The entity type of the parameter. Format: `projects/-/locations/-/agents/-/entityTypes/`
        /// for system entity types (for example, `projects/-/locations/-/agents/-/entityTypes/sys.date`), or
        /// `projects//locations//agents//entityTypes/` for developer entity types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityType")]
        public virtual string EntityType { get; set; } 

        /// <summary>Required. The unique identifier of the parameter. This field is used by training phrases to
        /// annotate their parts.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>Indicates whether the parameter represents a list of values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isList")]
        public virtual System.Nullable<bool> IsList { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents an example that the agent is trained on to identify the intent.</summary>
    public class GoogleCloudDialogflowCxV3beta1IntentTrainingPhrase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The unique identifier of the training phrase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; } 

        /// <summary>Required. The ordered list of training phrase parts. The parts are concatenated in order to form
        /// the training phrase. Note: The API does not automatically annotate training phrases like the Dialogflow
        /// Console does. Note: Do not forget to include whitespace at part boundaries, so the training phrase is well
        /// formatted when the parts are concatenated. If the training phrase does not need to be annotated with
        /// parameters, you just need a single part with only the Part.text field set. If you want to annotate the
        /// training phrase, you must create multiple parts, where the fields of each part are populated in one of two
        /// ways: - `Part.text` is set to a part of the phrase that has no parameters. - `Part.text` is set to a part of
        /// the phrase that you want to annotate, and the `parameter_id` field is set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parts")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1IntentTrainingPhrasePart> Parts { get; set; } 

        /// <summary>Indicates how many times this example was added to the intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("repeatCount")]
        public virtual System.Nullable<int> RepeatCount { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a part of a training phrase.</summary>
    public class GoogleCloudDialogflowCxV3beta1IntentTrainingPhrasePart : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The parameter used to annotate this part of the training phrase. This field is required for
        /// annotated parts of the training phrase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterId")]
        public virtual string ParameterId { get; set; } 

        /// <summary>Required. The text for this part.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Agents.ListAgents.</summary>
    public class GoogleCloudDialogflowCxV3beta1ListAgentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of agents. There will be a maximum number of items returned based on the page_size field
        /// in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agents")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1Agent> Agents { get; set; } 

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results in the
        /// list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for EntityTypes.ListEntityTypes.</summary>
    public class GoogleCloudDialogflowCxV3beta1ListEntityTypesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of entity types. There will be a maximum number of items returned based on the page_size
        /// field in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityTypes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1EntityType> EntityTypes { get; set; } 

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results in the
        /// list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Environments.ListEnvironments.</summary>
    public class GoogleCloudDialogflowCxV3beta1ListEnvironmentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of environments. There will be a maximum number of items returned based on the page_size
        /// field in the request. The list may in some cases be empty or contain fewer entries than page_size even if
        /// this isn't the last page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environments")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1Environment> Environments { get; set; } 

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results in the
        /// list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Flows.ListFlows.</summary>
    public class GoogleCloudDialogflowCxV3beta1ListFlowsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of flows. There will be a maximum number of items returned based on the page_size field in
        /// the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("flows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1Flow> Flows { get; set; } 

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results in the
        /// list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Intents.ListIntents.</summary>
    public class GoogleCloudDialogflowCxV3beta1ListIntentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The list of intents. There will be a maximum number of items returned based on the page_size field
        /// in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intents")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1Intent> Intents { get; set; } 

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results in the
        /// list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Pages.ListPages.</summary>
    public class GoogleCloudDialogflowCxV3beta1ListPagesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to retrieve the next page of results, or empty if there are no more results in the
        /// list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The list of pages. There will be a maximum number of items returned based on the page_size field in
        /// the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1Page> Pages { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for SessionEntityTypes.ListSessionEntityTypes.</summary>
    public class GoogleCloudDialogflowCxV3beta1ListSessionEntityTypesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to retrieve the next page of results, or empty if there are no more results in the
        /// list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The list of session entity types. There will be a maximum number of items returned based on the
        /// page_size field in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionEntityTypes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1SessionEntityType> SessionEntityTypes { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for TransitionRouteGroups.ListTransitionRouteGroups.</summary>
    public class GoogleCloudDialogflowCxV3beta1ListTransitionRouteGroupsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to retrieve the next page of results, or empty if there are no more results in the
        /// list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The list of transition route groups. There will be a maximum number of items returned based on the
        /// page_size field in the request. The list may in some cases be empty or contain fewer entries than page_size
        /// even if this isn't the last page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitionRouteGroups")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1TransitionRouteGroup> TransitionRouteGroups { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Versions.ListVersions.</summary>
    public class GoogleCloudDialogflowCxV3beta1ListVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to retrieve the next page of results, or empty if there are no more results in the
        /// list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>A list of versions. There will be a maximum number of items returned based on the page_size field
        /// in the request. The list may in some cases be empty or contain fewer entries than page_size even if this
        /// isn't the last page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versions")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1Version> Versions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Webhooks.ListWebhooks.</summary>
    public class GoogleCloudDialogflowCxV3beta1ListWebhooksResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Token to retrieve the next page of results, or empty if there are no more results in the
        /// list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The list of webhooks. There will be a maximum number of items returned based on the page_size field
        /// in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhooks")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1Webhook> Webhooks { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The request message for Versions.LoadVersion.</summary>
    public class GoogleCloudDialogflowCxV3beta1LoadVersionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This field is used to prevent accidental overwrite of other agent resources in the draft version,
        /// which can potentially impact other flow's behavior. If `allow_override_agent_resources` is false, conflicted
        /// agent-level resources will not be overridden (i.e. intents, entities, webhooks).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowOverrideAgentResources")]
        public virtual System.Nullable<bool> AllowOverrideAgentResources { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Environments.LookupEnvironmentHistory.</summary>
    public class GoogleCloudDialogflowCxV3beta1LookupEnvironmentHistoryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Represents a list of snapshots for an environment. Time of the snapshots is stored in
        /// `update_time`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("environments")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1Environment> Environments { get; set; } 

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results in the
        /// list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents one match result of MatchIntent.</summary>
    public class GoogleCloudDialogflowCxV3beta1Match : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The confidence of this match. Values range from 0.0 (completely uncertain) to 1.0 (completely
        /// certain). This value is for informational purpose only and is only used to help match the best intent within
        /// the classification threshold. This value may change for the same end-user expression at any time due to a
        /// model retraining or change in implementation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
        public virtual System.Nullable<float> Confidence { get; set; } 

        /// <summary>The Intent that matched the query. Some, not all fields are filled in this message, including but
        /// not limited to: `name` and `display_name`. Only filled for `INTENT` match type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intent")]
        public virtual GoogleCloudDialogflowCxV3beta1Intent Intent { get; set; } 

        /// <summary>Type of this Match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchType")]
        public virtual string MatchType { get; set; } 

        /// <summary>The collection of parameters extracted from the query. Depending on your protocol or client library
        /// language, this is a map, associative array, symbol table, dictionary, or JSON object composed of a
        /// collection of (MapKey, MapValue) pairs: - MapKey type: string - MapKey value: parameter name - MapValue
        /// type: - If parameter's entity type is a composite entity: map - Else: string or number, depending on
        /// parameter value type - MapValue value: - If parameter's entity type is a composite entity: map from
        /// composite entity property names to property values - Else: parameter value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string,object> Parameters { get; set; } 

        /// <summary>Final text input which was matched during MatchIntent. This value can be different from original
        /// input sent in request because of spelling correction or other processing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedInput")]
        public virtual string ResolvedInput { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request of MatchIntent.</summary>
    public class GoogleCloudDialogflowCxV3beta1MatchIntentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The input specification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryInput")]
        public virtual GoogleCloudDialogflowCxV3beta1QueryInput QueryInput { get; set; } 

        /// <summary>The parameters of this query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryParams")]
        public virtual GoogleCloudDialogflowCxV3beta1QueryParameters QueryParams { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response of MatchIntent.</summary>
    public class GoogleCloudDialogflowCxV3beta1MatchIntentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current Page. Some, not all fields are filled in this message, including but not limited to
        /// `name` and `display_name`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentPage")]
        public virtual GoogleCloudDialogflowCxV3beta1Page CurrentPage { get; set; } 

        /// <summary>Match results, if more than one, ordered descendingly by the confidence we have that the particular
        /// intent matches the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matches")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1Match> Matches { get; set; } 

        /// <summary>If natural language text was provided as input, this field will contain a copy of the
        /// text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>If natural language speech audio was provided as input, this field will contain the trascript for
        /// the audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcript")]
        public virtual string Transcript { get; set; } 

        /// <summary>If an intent was provided as input, this field will contain a copy of the intent
        /// identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerIntent")]
        public virtual string TriggerIntent { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings related to NLU.</summary>
    public class GoogleCloudDialogflowCxV3beta1NluSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>To filter out false positive results and still get variety in matched natural language inputs for
        /// your agent, you can tune the machine learning classification threshold. If the returned score value is less
        /// than the threshold value, then a no-match event will be triggered. The score values range from 0.0
        /// (completely uncertain) to 1.0 (completely certain). If set to 0.0, the default of 0.3 is used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("classificationThreshold")]
        public virtual System.Nullable<float> ClassificationThreshold { get; set; } 

        /// <summary>Indicates if automatic spell correction is enabled in detect intent requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSpellCorrection")]
        public virtual System.Nullable<bool> EnableSpellCorrection { get; set; } 

        /// <summary>Indicates NLU model training mode.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelTrainingMode")]
        public virtual string ModelTrainingMode { get; set; } 

        /// <summary>Indicates the type of NLU model.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modelType")]
        public virtual string ModelType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Instructs the speech synthesizer how to generate the output audio content.</summary>
    public class GoogleCloudDialogflowCxV3beta1OutputAudioConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Audio encoding of the synthesized audio content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioEncoding")]
        public virtual string AudioEncoding { get; set; } 

        /// <summary>Optional. The synthesis sample rate (in hertz) for this audio. If not provided, then the
        /// synthesizer will use the default sample rate based on the audio encoding. If this is different from the
        /// voice's natural sample rate, then the synthesizer will honor this request by converting to the desired
        /// sample rate (which might result in worse audio quality).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sampleRateHertz")]
        public virtual System.Nullable<int> SampleRateHertz { get; set; } 

        /// <summary>Optional. Configuration of how speech should be synthesized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("synthesizeSpeechConfig")]
        public virtual GoogleCloudDialogflowCxV3beta1SynthesizeSpeechConfig SynthesizeSpeechConfig { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A Dialogflow CX conversation (session) can be described and visualized as a state machine. The states
    /// of a CX session are represented by pages. For each flow, you define many pages, where your combined pages can
    /// handle a complete conversation on the topics the flow is designed for. At any given moment, exactly one page is
    /// the current page, the current page is considered active, and the flow associated with that page is considered
    /// active. Every flow has a special start page. When a flow initially becomes active, the start page page becomes
    /// the current page. For each conversational turn, the current page will either stay the same or transition to
    /// another page. You configure each page to collect information from the end-user that is relevant for the
    /// conversational state represented by the page. For more information, see the [Page
    /// guide](https://cloud.google.com/dialogflow/cx/docs/concept/page).</summary>
    public class GoogleCloudDialogflowCxV3beta1Page : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The human-readable name of the page, unique within the agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>The fulfillment to call when the session is entering the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entryFulfillment")]
        public virtual GoogleCloudDialogflowCxV3beta1Fulfillment EntryFulfillment { get; set; } 

        /// <summary>Handlers associated with the page to handle events such as webhook errors, no match or no
        /// input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventHandlers")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1EventHandler> EventHandlers { get; set; } 

        /// <summary>The form associated with the page, used for collecting parameters relevant to the page.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("form")]
        public virtual GoogleCloudDialogflowCxV3beta1Form Form { get; set; } 

        /// <summary>The unique identifier of the page. Required for the Pages.UpdatePage method. Pages.CreatePage
        /// populates the name automatically. Format: `projects//locations//agents//flows//pages/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Ordered list of `TransitionRouteGroups` associated with the page. Transition route groups must be
        /// unique within a page. * If multiple transition routes within a page scope refer to the same intent, then the
        /// precedence order is: page's transition route -> page's transition route group -> flow's transition routes. *
        /// If multiple transition route groups within a page contain the same intent, then the first group in the
        /// ordered list takes precedence.
        /// Format:`projects//locations//agents//flows//transitionRouteGroups/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitionRouteGroups")]
        public virtual System.Collections.Generic.IList<string> TransitionRouteGroups { get; set; } 

        /// <summary>A list of transitions for the transition rules of this page. They route the conversation to another
        /// page in the same flow, or another flow. When we are in a certain page, the TransitionRoutes are evalauted in
        /// the following order: * TransitionRoutes defined in the page with intent specified. * TransitionRoutes
        /// defined in the transition route groups. * TransitionRoutes defined in flow with intent specified. *
        /// TransitionRoutes defined in the page with only condition specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitionRoutes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1TransitionRoute> TransitionRoutes { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents page information communicated to and from the webhook.</summary>
    public class GoogleCloudDialogflowCxV3beta1PageInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Always present for WebhookRequest. Ignored for WebhookResponse. The unique identifier of the
        /// current page. Format: `projects//locations//agents//flows//pages/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentPage")]
        public virtual string CurrentPage { get; set; } 

        /// <summary>Optional for both WebhookRequest and WebhookResponse. Information about the form.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formInfo")]
        public virtual GoogleCloudDialogflowCxV3beta1PageInfoFormInfo FormInfo { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents form information.</summary>
    public class GoogleCloudDialogflowCxV3beta1PageInfoFormInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional for both WebhookRequest and WebhookResponse. The parameters contained in the form. Note
        /// that the webhook cannot add or remove any form parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameterInfo")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1PageInfoFormInfoParameterInfo> ParameterInfo { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents parameter information.</summary>
    public class GoogleCloudDialogflowCxV3beta1PageInfoFormInfoParameterInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Always present for WebhookRequest. Required for WebhookResponse. The human-readable name of the
        /// parameter, unique within the form. This field cannot be modified by the webhook.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Optional for WebhookRequest. Ignored for WebhookResponse. Indicates if the parameter value was just
        /// collected on the last conversation turn.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("justCollected")]
        public virtual System.Nullable<bool> JustCollected { get; set; } 

        /// <summary>Optional for both WebhookRequest and WebhookResponse. Indicates whether the parameter is required.
        /// Optional parameters will not trigger prompts; however, they are filled if the user specifies them. Required
        /// parameters must be filled before form filling concludes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("required")]
        public virtual System.Nullable<bool> Required { get; set; } 

        /// <summary>Always present for WebhookRequest. Required for WebhookResponse. The state of the parameter. This
        /// field can be set to INVALID by the webhook to invalidate the parameter; other values set by the webhook will
        /// be ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; } 

        /// <summary>Optional for both WebhookRequest and WebhookResponse. The value of the parameter. This field can be
        /// set by the webhook to change the parameter value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual object Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the query input. It can contain either: 1. A conversational query in the form of text. 2. An
    /// intent query that specifies which intent to trigger.</summary>
    public class GoogleCloudDialogflowCxV3beta1QueryInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The natural language speech audio to be processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audio")]
        public virtual GoogleCloudDialogflowCxV3beta1AudioInput Audio { get; set; } 

        /// <summary>The intent to be triggered.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intent")]
        public virtual GoogleCloudDialogflowCxV3beta1IntentInput Intent { get; set; } 

        /// <summary>Required. The language of the input. See [Language
        /// Support](https://cloud.google.com/dialogflow/docs/reference/language) for a list of the currently supported
        /// language codes. Note that queries in the same session do not necessarily need to specify the same
        /// language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; } 

        /// <summary>The natural language text to be processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual GoogleCloudDialogflowCxV3beta1TextInput Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the parameters of a conversational query.</summary>
    public class GoogleCloudDialogflowCxV3beta1QueryParameters : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The geo location of this conversational query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("geoLocation")]
        public virtual GoogleTypeLatLng GeoLocation { get; set; } 

        /// <summary>Additional parameters to be put into session parameters. To remove a parameter from the session,
        /// clients should explicitly set the parameter value to null. Depending on your protocol or client library
        /// language, this is a map, associative array, symbol table, dictionary, or JSON object composed of a
        /// collection of (MapKey, MapValue) pairs: - MapKey type: string - MapKey value: parameter name - MapValue
        /// type: - If parameter's entity type is a composite entity: map - Else: string or number, depending on
        /// parameter value type - MapValue value: - If parameter's entity type is a composite entity: map from
        /// composite entity property names to property values - Else: parameter value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string,object> Parameters { get; set; } 

        /// <summary>This field can be used to pass custom data into the webhook associated with the agent. Arbitrary
        /// JSON objects are supported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string,object> Payload { get; set; } 

        /// <summary>Additional session entity types to replace or extend developer entity types with. The entity
        /// synonyms apply to all languages and persist for the session of this query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionEntityTypes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1SessionEntityType> SessionEntityTypes { get; set; } 

        /// <summary>The time zone of this conversational query from the [time zone database](https://www.iana.org/time-
        /// zones), e.g., America/New_York, Europe/Paris. If not provided, the time zone specified in the agent is
        /// used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeZone")]
        public virtual string TimeZone { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the result of a conversational query.</summary>
    public class GoogleCloudDialogflowCxV3beta1QueryResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The current Page. Some, not all fields are filled in this message, including but not limited to
        /// `name` and `display_name`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentPage")]
        public virtual GoogleCloudDialogflowCxV3beta1Page CurrentPage { get; set; } 

        /// <summary>The free-form diagnostic info. For example, this field could contain webhook call latency. The
        /// string keys of the Struct's fields map can change without notice.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diagnosticInfo")]
        public virtual System.Collections.Generic.IDictionary<string,object> DiagnosticInfo { get; set; } 

        /// <summary>The Intent that matched the conversational query. Some, not all fields are filled in this message,
        /// including but not limited to: `name` and `display_name`. This field is deprecated, please use
        /// QueryResult.match instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intent")]
        public virtual GoogleCloudDialogflowCxV3beta1Intent Intent { get; set; } 

        /// <summary>The intent detection confidence. Values range from 0.0 (completely uncertain) to 1.0 (completely
        /// certain). This value is for informational purpose only and is only used to help match the best intent within
        /// the classification threshold. This value may change for the same end-user expression at any time due to a
        /// model retraining or change in implementation. This field is deprecated, please use QueryResult.match
        /// instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intentDetectionConfidence")]
        public virtual System.Nullable<float> IntentDetectionConfidence { get; set; } 

        /// <summary>The language that was triggered during intent detection. See [Language
        /// Support](https://cloud.google.com/dialogflow/docs/reference/language) for a list of the currently supported
        /// language codes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; } 

        /// <summary>Intent match result, could be an intent or an event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("match")]
        public virtual GoogleCloudDialogflowCxV3beta1Match Match { get; set; } 

        /// <summary>The collected session parameters. Depending on your protocol or client library language, this is a
        /// map, associative array, symbol table, dictionary, or JSON object composed of a collection of (MapKey,
        /// MapValue) pairs: - MapKey type: string - MapKey value: parameter name - MapValue type: - If parameter's
        /// entity type is a composite entity: map - Else: string or number, depending on parameter value type -
        /// MapValue value: - If parameter's entity type is a composite entity: map from composite entity property names
        /// to property values - Else: parameter value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string,object> Parameters { get; set; } 

        /// <summary>The list of rich messages returned to the client. Responses vary from simple text messages to more
        /// sophisticated, structured payloads used to drive complex logic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseMessages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1ResponseMessage> ResponseMessages { get; set; } 

        /// <summary>If natural language text was provided as input, this field will contain a copy of the
        /// text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>If natural language speech audio was provided as input, this field will contain the trascript for
        /// the audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transcript")]
        public virtual string Transcript { get; set; } 

        /// <summary>If an event was provided as input, this field will contain the name of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerEvent")]
        public virtual string TriggerEvent { get; set; } 

        /// <summary>If an intent was provided as input, this field will contain a copy of the intent
        /// identifier.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerIntent")]
        public virtual string TriggerIntent { get; set; } 

        /// <summary>The list of webhook payload in WebhookResponse.payload, in the order of call sequence. If some
        /// webhook call fails or doesn't return any payload, an empty `Struct` would be used instead.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookPayloads")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string,object>> WebhookPayloads { get; set; } 

        /// <summary>The list of webhook call status in the order of call sequence.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookStatuses")]
        public virtual System.Collections.Generic.IList<GoogleRpcStatus> WebhookStatuses { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a response message that can be returned by a conversational agent. Response messages are
    /// also used for output audio synthesis. The approach is as follows: * If at least one OutputAudioText response is
    /// present, then all OutputAudioText responses are linearly concatenated, and the result is used for output audio
    /// synthesis. * If the OutputAudioText responses are a mixture of text and SSML, then the concatenated result is
    /// treated as SSML; otherwise, the result is treated as either text or SSML as appropriate. The agent designer
    /// should ideally use either text or SSML consistently throughout the bot design. * Otherwise, all Text responses
    /// are linearly concatenated, and the result is used for output audio synthesis. This approach allows for more
    /// sophisticated user experience scenarios, where the text displayed to the user may differ from what is
    /// heard.</summary>
    public class GoogleCloudDialogflowCxV3beta1ResponseMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates that the conversation succeeded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversationSuccess")]
        public virtual GoogleCloudDialogflowCxV3beta1ResponseMessageConversationSuccess ConversationSuccess { get; set; } 

        /// <summary>Output only. A signal that indicates the interaction with the Dialogflow agent has ended. This
        /// message is generated by Dialogflow only when the conversation reaches `END_SESSION` or `END_PAGE` page. It
        /// is not supposed to be defined by the user. It's guaranteed that there is at most one such message in each
        /// response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endInteraction")]
        public virtual GoogleCloudDialogflowCxV3beta1ResponseMessageEndInteraction EndInteraction { get; set; } 

        /// <summary>Hands off conversation to a human agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("liveAgentHandoff")]
        public virtual GoogleCloudDialogflowCxV3beta1ResponseMessageLiveAgentHandoff LiveAgentHandoff { get; set; } 

        /// <summary>Output only. An audio response message composed of both the synthesized Dialogflow agent responses
        /// and responses defined via play_audio. This message is generated by Dialogflow only and not supposed to be
        /// defined by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mixedAudio")]
        public virtual GoogleCloudDialogflowCxV3beta1ResponseMessageMixedAudio MixedAudio { get; set; } 

        /// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in
        /// the comment on the ResponseMessage message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputAudioText")]
        public virtual GoogleCloudDialogflowCxV3beta1ResponseMessageOutputAudioText OutputAudioText { get; set; } 

        /// <summary>Returns a response containing a custom, platform-specific payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string,object> Payload { get; set; } 

        /// <summary>Signal that the client should play an audio clip hosted at a client-specific URI. Dialogflow uses
        /// this to construct mixed_audio. However, Dialogflow itself does not try to read or process the URI in any
        /// way.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("playAudio")]
        public virtual GoogleCloudDialogflowCxV3beta1ResponseMessagePlayAudio PlayAudio { get; set; } 

        /// <summary>Returns a text response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual GoogleCloudDialogflowCxV3beta1ResponseMessageText Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Indicates that the conversation succeeded, i.e., the bot handled the issue that the customer talked to
    /// it about. Dialogflow only uses this to determine which conversations should be counted as successful and doesn't
    /// process the metadata in this message in any way. Note that Dialogflow also considers conversations that get to
    /// the conversation end page as successful even if they don't return ConversationSuccess. You may set this, for
    /// example: * In the entry_fulfillment of a Page if entering the page indicates that the conversation succeeded. *
    /// In a webhook response when you determine that you handled the customer issue.</summary>
    public class GoogleCloudDialogflowCxV3beta1ResponseMessageConversationSuccess : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom metadata. Dialogflow doesn't impose any structure on this.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string,object> Metadata { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Indicates that interaction with the Dialogflow agent has ended. This message is generated by Dialogflow
    /// only and not supposed to be defined by the user.</summary>
    public class GoogleCloudDialogflowCxV3beta1ResponseMessageEndInteraction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Indicates that the conversation should be handed off to a live agent. Dialogflow only uses this to
    /// determine which conversations were handed off to a human agent for measurement purposes. What else to do with
    /// this signal is up to you and your handoff procedures. You may set this, for example: * In the entry_fulfillment
    /// of a Page if entering the page indicates something went extremely wrong in the conversation. * In a webhook
    /// response when you determine that the customer issue can only be handled by a human.</summary>
    public class GoogleCloudDialogflowCxV3beta1ResponseMessageLiveAgentHandoff : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Custom metadata for your handoff procedure. Dialogflow doesn't impose any structure on
        /// this.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string,object> Metadata { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents an audio message that is composed of both segments synthesized from the Dialogflow agent
    /// prompts and ones hosted externally at the specified URIs. The external URIs are specified via play_audio. This
    /// message is generated by Dialogflow only and not supposed to be defined by the user.</summary>
    public class GoogleCloudDialogflowCxV3beta1ResponseMessageMixedAudio : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Segments this audio response is composed of.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("segments")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1ResponseMessageMixedAudioSegment> Segments { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents one segment of audio.</summary>
    public class GoogleCloudDialogflowCxV3beta1ResponseMessageMixedAudioSegment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Whether the playback of this segment can be interrupted by the end user's speech and
        /// the client should then start the next Dialogflow request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowPlaybackInterruption")]
        public virtual System.Nullable<bool> AllowPlaybackInterruption { get; set; } 

        /// <summary>Raw audio synthesized from the Dialogflow agent's response using the output config specified in the
        /// request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audio")]
        public virtual string Audio { get; set; } 

        /// <summary>Client-specific URI that points to an audio clip accessible to the client. Dialogflow does not
        /// impose any validation on it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A text or ssml response that is preferentially used for TTS output audio synthesis, as described in the
    /// comment on the ResponseMessage message.</summary>
    public class GoogleCloudDialogflowCxV3beta1ResponseMessageOutputAudioText : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The SSML text to be synthesized. For more information, see [SSML](/speech/text-to-
        /// speech/docs/ssml).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssml")]
        public virtual string Ssml { get; set; } 

        /// <summary>The raw text to be synthesized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Specifies an audio clip to be played by the client as part of the response.</summary>
    public class GoogleCloudDialogflowCxV3beta1ResponseMessagePlayAudio : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Whether the playback of this message can be interrupted by the end user's speech and
        /// the client can then starts the next Dialogflow request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowPlaybackInterruption")]
        public virtual System.Nullable<bool> AllowPlaybackInterruption { get; set; } 

        /// <summary>Required. URI of the audio clip. Dialogflow does not impose any validation on this value. It is
        /// specific to the client that reads it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioUri")]
        public virtual string AudioUri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The text response message.</summary>
    public class GoogleCloudDialogflowCxV3beta1ResponseMessageText : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Whether the playback of this message can be interrupted by the end user's speech and
        /// the client can then starts the next Dialogflow request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowPlaybackInterruption")]
        public virtual System.Nullable<bool> AllowPlaybackInterruption { get; set; } 

        /// <summary>Required. A collection of text responses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual System.Collections.Generic.IList<string> Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The request message for Agents.RestoreAgent.</summary>
    public class GoogleCloudDialogflowCxV3beta1RestoreAgentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Uncompressed raw byte content for agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentContent")]
        public virtual string AgentContent { get; set; } 

        /// <summary>The [Google Cloud Storage](https://cloud.google.com/storage/docs/) URI to restore agent from. The
        /// format of this URI must be `gs:`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentUri")]
        public virtual string AgentUri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Session entity types are referred to as **User** entity types and are entities that are built for an
    /// individual user such as favorites, preferences, playlists, and so on. You can redefine a session entity type at
    /// the session level to extend or replace a custom entity type at the user session level (we refer to the entity
    /// types defined at the agent level as "custom entity types"). Note: session entity types apply to all queries,
    /// regardless of the language. For more information about entity types, see the [Dialogflow
    /// documentation](https://cloud.google.com/dialogflow/docs/entities-overview).</summary>
    public class GoogleCloudDialogflowCxV3beta1SessionEntityType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The collection of entities to override or supplement the custom entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1EntityTypeEntity> Entities { get; set; } 

        /// <summary>Required. Indicates whether the additional data should override or supplement the custom entity
        /// type definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityOverrideMode")]
        public virtual string EntityOverrideMode { get; set; } 

        /// <summary>Required. The unique identifier of the session entity type. Format:
        /// `projects//locations//agents//sessions//entityTypes/` or
        /// `projects//locations//agents//environments//sessions//entityTypes/`. If `Environment ID` is not specified,
        /// we assume default 'draft' environment.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents session information communicated to and from the webhook.</summary>
    public class GoogleCloudDialogflowCxV3beta1SessionInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional for WebhookRequest. Optional for WebhookResponse. All parameters collected from forms and
        /// intents during the session. Parameters can be created, updated, or removed by the webhook. To remove a
        /// parameter from the session, the webhook should explicitly set the parameter value to null in
        /// WebhookResponse. The map is keyed by parameters' display names.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string,object> Parameters { get; set; } 

        /// <summary>Always present for WebhookRequest. Ignored for WebhookResponse. The unique identifier of the
        /// session. This field can be used by the webhook to identify a user. Format:
        /// `projects//locations//agents//sessions/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("session")]
        public virtual string Session { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Settings related to speech recognition.</summary>
    public class GoogleCloudDialogflowCxV3beta1SpeechToTextSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether to use speech adaptation for speech recognition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableSpeechAdaptation")]
        public virtual System.Nullable<bool> EnableSpeechAdaptation { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Configuration of how speech should be synthesized.</summary>
    public class GoogleCloudDialogflowCxV3beta1SynthesizeSpeechConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. An identifier which selects 'audio effects' profiles that are applied on (post
        /// synthesized) text to speech. Effects are applied on top of each other in the order they are given.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("effectsProfileId")]
        public virtual System.Collections.Generic.IList<string> EffectsProfileId { get; set; } 

        /// <summary>Optional. Speaking pitch, in the range [-20.0, 20.0]. 20 means increase 20 semitones from the
        /// original pitch. -20 means decrease 20 semitones from the original pitch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pitch")]
        public virtual System.Nullable<double> Pitch { get; set; } 

        /// <summary>Optional. Speaking rate/speed, in the range [0.25, 4.0]. 1.0 is the normal native speed supported
        /// by the specific voice. 2.0 is twice as fast, and 0.5 is half as fast. If unset(0.0), defaults to the native
        /// 1.0 speed. Any other values < 0.25 or > 4.0 will return an error.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speakingRate")]
        public virtual System.Nullable<double> SpeakingRate { get; set; } 

        /// <summary>Optional. The desired voice of the synthesized audio.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("voice")]
        public virtual GoogleCloudDialogflowCxV3beta1VoiceSelectionParams Voice { get; set; } 

        /// <summary>Optional. Volume gain (in dB) of the normal native volume supported by the specific voice, in the
        /// range [-96.0, 16.0]. If unset, or set to a value of 0.0 (dB), will play at normal native signal amplitude. A
        /// value of -6.0 (dB) will play at approximately half the amplitude of the normal native signal amplitude. A
        /// value of +6.0 (dB) will play at approximately twice the amplitude of the normal native signal amplitude. We
        /// strongly recommend not to exceed +10 (dB) as there's usually no effective increase in loudness for any value
        /// greater than that.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("volumeGainDb")]
        public virtual System.Nullable<double> VolumeGainDb { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the natural language text to be processed.</summary>
    public class GoogleCloudDialogflowCxV3beta1TextInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The UTF-8 encoded natural language text to be processed. Text length must not exceed 256
        /// characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The request message for Flows.TrainFlow.</summary>
    public class GoogleCloudDialogflowCxV3beta1TrainFlowRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A transition route specifies a intent that can be matched and/or a data condition that can be evaluated
    /// during a session. When a specified transition is matched, the following actions are taken in order: * If there
    /// is a `trigger_fulfillment` associated with the transition, it will be called. * If there is a `target_page`
    /// associated with the transition, the session will transition into the specified page. * If there is a
    /// `target_flow` associated with the transition, the session will transition into the specified flow.</summary>
    public class GoogleCloudDialogflowCxV3beta1TransitionRoute : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The condition to evaluate against form parameters or session parameters. See the [conditions
        /// reference](https://cloud.google.com/dialogflow/cx/docs/reference/condition). At least one of `intent` or
        /// `condition` must be specified. When both `intent` and `condition` are specified, the transition can only
        /// happen when both are fulfilled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual string Condition { get; set; } 

        /// <summary>The unique identifier of an Intent. Format: `projects//locations//agents//intents/`. Indicates that
        /// the transition can only happen when the given intent is matched. At least one of `intent` or `condition`
        /// must be specified. When both `intent` and `condition` are specified, the transition can only happen when
        /// both are fulfilled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intent")]
        public virtual string Intent { get; set; } 

        /// <summary>Output only. The unique identifier of this transition route.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The target flow to transition to. Format: `projects//locations//agents//flows/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetFlow")]
        public virtual string TargetFlow { get; set; } 

        /// <summary>The target page to transition to. Format: `projects//locations//agents//flows//pages/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetPage")]
        public virtual string TargetPage { get; set; } 

        /// <summary>The fulfillment to call when the condition is satisfied. At least one of `trigger_fulfillment` and
        /// `target` must be specified. When both are defined, `trigger_fulfillment` is executed first.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("triggerFulfillment")]
        public virtual GoogleCloudDialogflowCxV3beta1Fulfillment TriggerFulfillment { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An TransitionRouteGroup represents a group of `TransitionRoutes` to be used by a Page.</summary>
    public class GoogleCloudDialogflowCxV3beta1TransitionRouteGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The human-readable name of the transition route group, unique within the Agent. The
        /// display name can be no longer than 30 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>The unique identifier of the transition route group.
        /// TransitionRouteGroups.CreateTransitionRouteGroup populates the name automatically. Format:
        /// `projects//locations//agents//flows//transitionRouteGroups/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Transition routes associated with the TransitionRouteGroup. Duplicate transition routes (i.e. using
        /// the same `intent`) are not allowed. Note that the `name` field is not used in the transition route group
        /// scope.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("transitionRoutes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1TransitionRoute> TransitionRoutes { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a version of a flow.</summary>
    public class GoogleCloudDialogflowCxV3beta1Version : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Create time of the version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>The description of the version. The maximum length is 500 characters. If exceeded, the request is
        /// rejected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Required. The human-readable name of the version. Limit of 64 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Format: projects//locations//agents//flows//versions/. Version ID is a self-increasing number
        /// generated by Dialogflow upon version creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. The NLU settings of the flow at version creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nluSettings")]
        public virtual GoogleCloudDialogflowCxV3beta1NluSettings NluSettings { get; set; } 

        /// <summary>Output only. The state of this version. This field is read-only and cannot be set by create and
        /// update methods.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Description of which voice to use for speech synthesis.</summary>
    public class GoogleCloudDialogflowCxV3beta1VoiceSelectionParams : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The name of the voice. If not set, the service will choose a voice based on the other
        /// parameters such as language_code and ssml_gender.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Optional. The preferred gender of the voice. If not set, the service will choose a voice based on
        /// the other parameters such as language_code and name. Note that this is only a preference, not requirement.
        /// If a voice of the appropriate gender is not available, the synthesizer should substitute a voice with a
        /// different gender rather than failing the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssmlGender")]
        public virtual string SsmlGender { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Webhooks host the developer's business logic. During a session, webhooks allow the developer to use the
    /// data extracted by Dialogflow's natural language processing to generate dynamic responses, validate collected
    /// data, or trigger actions on the backend.</summary>
    public class GoogleCloudDialogflowCxV3beta1Webhook : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates whether the webhook is disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabled")]
        public virtual System.Nullable<bool> Disabled { get; set; } 

        /// <summary>Required. The human-readable name of the webhook, unique within the agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Configuration for a generic web service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("genericWebService")]
        public virtual GoogleCloudDialogflowCxV3beta1WebhookGenericWebService GenericWebService { get; set; } 

        /// <summary>The unique identifier of the webhook. Required for the Webhooks.UpdateWebhook method.
        /// Webhooks.CreateWebhook populates the name automatically. Format:
        /// `projects//locations//agents//webhooks/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Webhook execution timeout. Execution is considered failed if Dialogflow doesn't receive a response
        /// from webhook at the end of the timeout period. Defaults to 5 seconds, maximum allowed timeout is 30
        /// seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timeout")]
        public virtual object Timeout { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents configuration for a generic web service.</summary>
    public class GoogleCloudDialogflowCxV3beta1WebhookGenericWebService : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The password for HTTP Basic authentication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("password")]
        public virtual string Password { get; set; } 

        /// <summary>The HTTP request headers to send together with webhook requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestHeaders")]
        public virtual System.Collections.Generic.IDictionary<string,string> RequestHeaders { get; set; } 

        /// <summary>Required. The webhook URI for receiving POST requests. It must use https protocol.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; } 

        /// <summary>The user name for HTTP Basic authentication.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("username")]
        public virtual string Username { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The request message for a webhook call.</summary>
    public class GoogleCloudDialogflowCxV3beta1WebhookRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Always present. The unique identifier of the DetectIntentResponse that will be returned to the API
        /// caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectIntentResponseId")]
        public virtual string DetectIntentResponseId { get; set; } 

        /// <summary>Always present. Information about the fulfillment that triggered this webhook call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fulfillmentInfo")]
        public virtual GoogleCloudDialogflowCxV3beta1WebhookRequestFulfillmentInfo FulfillmentInfo { get; set; } 

        /// <summary>Information about the last matched intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intentInfo")]
        public virtual GoogleCloudDialogflowCxV3beta1WebhookRequestIntentInfo IntentInfo { get; set; } 

        /// <summary>The list of rich message responses to present to the user. Webhook can choose to append or replace
        /// this list in WebhookResponse.fulfillment_response;</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1ResponseMessage> Messages { get; set; } 

        /// <summary>Information about page status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual GoogleCloudDialogflowCxV3beta1PageInfo PageInfo { get; set; } 

        /// <summary>Custom data set in QueryParameters.payload.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string,object> Payload { get; set; } 

        /// <summary>Information about session status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionInfo")]
        public virtual GoogleCloudDialogflowCxV3beta1SessionInfo SessionInfo { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents fulfillment information communicated to the webhook.</summary>
    public class GoogleCloudDialogflowCxV3beta1WebhookRequestFulfillmentInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Always present. The tag used to identify which fulfillment is being called.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tag")]
        public virtual string Tag { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents intent information communicated to the webhook.</summary>
    public class GoogleCloudDialogflowCxV3beta1WebhookRequestIntentInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Always present. The unique identifier of the last matched intent. Format:
        /// `projects//locations//agents//intents/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastMatchedIntent")]
        public virtual string LastMatchedIntent { get; set; } 

        /// <summary>Parameters identified as a result of intent matching. This is a map of the name of the identified
        /// parameter to the value of the parameter identified from the user's utterance. All parameters defined in the
        /// matched intent that are identified will be surfaced here.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string,GoogleCloudDialogflowCxV3beta1WebhookRequestIntentInfoIntentParameterValue> Parameters { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a value for an intent parameter.</summary>
    public class GoogleCloudDialogflowCxV3beta1WebhookRequestIntentInfoIntentParameterValue : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Always present. Original text value extracted from user utterance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalValue")]
        public virtual string OriginalValue { get; set; } 

        /// <summary>Always present. Structured value for the parameter extracted from user utterance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resolvedValue")]
        public virtual object ResolvedValue { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for a webhook call.</summary>
    public class GoogleCloudDialogflowCxV3beta1WebhookResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The fulfillment response to send to the user. This field can be omitted by the webhook if it does
        /// not intend to send any response to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fulfillmentResponse")]
        public virtual GoogleCloudDialogflowCxV3beta1WebhookResponseFulfillmentResponse FulfillmentResponse { get; set; } 

        /// <summary>Information about page status. This field can be omitted by the webhook if it does not intend to
        /// modify page status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pageInfo")]
        public virtual GoogleCloudDialogflowCxV3beta1PageInfo PageInfo { get; set; } 

        /// <summary>Value to append directly to QueryResult.webhook_payloads.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string,object> Payload { get; set; } 

        /// <summary>Information about session status. This field can be omitted by the webhook if it does not intend to
        /// modify session status.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionInfo")]
        public virtual GoogleCloudDialogflowCxV3beta1SessionInfo SessionInfo { get; set; } 

        /// <summary>The target flow to transition to. Format: `projects//locations//agents//flows/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetFlow")]
        public virtual string TargetFlow { get; set; } 

        /// <summary>The target page to transition to. Format: `projects//locations//agents//flows//pages/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targetPage")]
        public virtual string TargetPage { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a fulfillment response to the user.</summary>
    public class GoogleCloudDialogflowCxV3beta1WebhookResponseFulfillmentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Merge behavior for `messages`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mergeBehavior")]
        public virtual string MergeBehavior { get; set; } 

        /// <summary>The list of rich message responses to present to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowCxV3beta1ResponseMessage> Messages { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a part of a message possibly annotated with an entity. The part can be an entity or purely a
    /// part of the message between two entities or message start/end.</summary>
    public class GoogleCloudDialogflowV2AnnotatedMessagePart : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The [Dialogflow system entity type](https://cloud.google.com/dialogflow/docs/reference/system-
        /// entities) of this message part. If this is empty, Dialogflow could not annotate the phrase part with a
        /// system entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityType")]
        public virtual string EntityType { get; set; } 

        /// <summary>The [Dialogflow system entity formatted value ](https://cloud.google.com/dialogflow/docs/reference
        /// /system-entities) of this message part. For example for a system entity of type `@sys.unit-currency`, this
        /// may contain: { "amount": 5, "currency": "USD" } </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedValue")]
        public virtual object FormattedValue { get; set; } 

        /// <summary>A part of a message possibly annotated with an entity.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for EntityTypes.BatchUpdateEntityTypes.</summary>
    public class GoogleCloudDialogflowV2BatchUpdateEntityTypesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The collection of updated or created entity types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityTypes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2EntityType> EntityTypes { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Intents.BatchUpdateIntents.</summary>
    public class GoogleCloudDialogflowV2BatchUpdateIntentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The collection of updated or created intents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intents")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2Intent> Intents { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Dialogflow contexts are similar to natural language context. If a person says to you "they are orange",
    /// you need context in order to understand what "they" is referring to. Similarly, for Dialogflow to handle an end-
    /// user expression like that, it needs to be provided with context in order to correctly match an intent. Using
    /// contexts, you can control the flow of a conversation. You can configure contexts for an intent by setting input
    /// and output contexts, which are identified by string names. When an intent is matched, any configured output
    /// contexts for that intent become active. While any contexts are active, Dialogflow is more likely to match
    /// intents that are configured with input contexts that correspond to the currently active contexts. For more
    /// information about context, see the [Contexts guide](https://cloud.google.com/dialogflow/docs/contexts-
    /// overview).</summary>
    public class GoogleCloudDialogflowV2Context : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The number of conversational query requests after which the context expires. The default
        /// is `0`. If set to `0`, the context expires immediately. Contexts expire automatically after 20 minutes if
        /// there are no matching queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifespanCount")]
        public virtual System.Nullable<int> LifespanCount { get; set; } 

        /// <summary>Required. The unique identifier of the context. Format: `projects//agent/sessions//contexts/`, or
        /// `projects//agent/environments//users//sessions//contexts/`. The `Context ID` is always converted to
        /// lowercase, may only contain characters in a-zA-Z0-9_-% and may be at most 250 bytes long. If `Environment
        /// ID` is not specified, we assume default 'draft' environment. If `User ID` is not specified, we assume
        /// default '-' user. The following context names are reserved for internal use by Dialogflow. You should not
        /// use these contexts or create contexts with these names: * `__system_counters__` * `*_id_dialog_context` *
        /// `*_dialog_params_size`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Optional. The collection of parameters associated with this context. Depending on your protocol or
        /// client library language, this is a map, associative array, symbol table, dictionary, or JSON object composed
        /// of a collection of (MapKey, MapValue) pairs: - MapKey type: string - MapKey value: parameter name - MapValue
        /// type: - If parameter's entity type is a composite entity: map - Else: string or number, depending on
        /// parameter value type - MapValue value: - If parameter's entity type is a composite entity: map from
        /// composite entity property names to property values - Else: parameter value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string,object> Parameters { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a notification sent to Pub/Sub subscribers for conversation lifecycle events.</summary>
    public class GoogleCloudDialogflowV2ConversationEvent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique identifier of the conversation this notification refers to. Format:
        /// `projects//conversations/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("conversation")]
        public virtual string Conversation { get; set; } 

        /// <summary>More detailed information about an error. Only set for type
        /// UNRECOVERABLE_ERROR_IN_PHONE_CALL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errorStatus")]
        public virtual GoogleRpcStatus ErrorStatus { get; set; } 

        /// <summary>Payload of NEW_MESSAGE event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("newMessagePayload")]
        public virtual GoogleCloudDialogflowV2Message NewMessagePayload { get; set; } 

        /// <summary>The type of the event that this notification refers to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Each intent parameter has a type, called the entity type, which dictates exactly how data from an end-
    /// user expression is extracted. Dialogflow provides predefined system entities that can match many common types of
    /// data. For example, there are system entities for matching dates, times, colors, email addresses, and so on. You
    /// can also create your own custom entities for matching custom data. For example, you could define a vegetable
    /// entity that can match the types of vegetables available for purchase with a grocery store agent. For more
    /// information, see the [Entity guide](https://cloud.google.com/dialogflow/docs/entities-overview).</summary>
    public class GoogleCloudDialogflowV2EntityType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Indicates whether the entity type can be automatically expanded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoExpansionMode")]
        public virtual string AutoExpansionMode { get; set; } 

        /// <summary>Required. The name of the entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Optional. Enables fuzzy entity extraction during classification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableFuzzyExtraction")]
        public virtual System.Nullable<bool> EnableFuzzyExtraction { get; set; } 

        /// <summary>Optional. The collection of entity entries associated with the entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2EntityTypeEntity> Entities { get; set; } 

        /// <summary>Required. Indicates the kind of entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The unique identifier of the entity type. Required for EntityTypes.UpdateEntityType and
        /// EntityTypes.BatchUpdateEntityTypes methods. Format: `projects//agent/entityTypes/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An **entity entry** for an associated entity type.</summary>
    public class GoogleCloudDialogflowV2EntityTypeEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A collection of value synonyms. For example, if the entity type is *vegetable*, and
        /// `value` is *scallions*, a synonym could be *green onions*. For `KIND_LIST` entity types: * This collection
        /// must contain exactly one synonym equal to `value`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("synonyms")]
        public virtual System.Collections.Generic.IList<string> Synonyms { get; set; } 

        /// <summary>Required. The primary value associated with this entity entry. For example, if the entity type is
        /// *vegetable*, the value could be *scallions*. For `KIND_MAP` entity types: * A reference value to be used in
        /// place of synonyms. For `KIND_LIST` entity types: * A string that can contain references to other entity
        /// types (with or without aliases).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Events allow for matching intents by event name instead of the natural language input. For instance,
    /// input `` can trigger a personalized welcome response. The parameter `name` may be used by the agent in the
    /// response: `"Hello #welcome_event.name! What can I do for you today?"`.</summary>
    public class GoogleCloudDialogflowV2EventInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The language of this query. See [Language
        /// Support](https://cloud.google.com/dialogflow/docs/reference/language) for a list of the currently supported
        /// language codes. Note that queries in the same session do not necessarily need to specify the same
        /// language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; } 

        /// <summary>Required. The unique identifier of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The collection of parameters associated with the event. Depending on your protocol or client
        /// library language, this is a map, associative array, symbol table, dictionary, or JSON object composed of a
        /// collection of (MapKey, MapValue) pairs: - MapKey type: string - MapKey value: parameter name - MapValue
        /// type: - If parameter's entity type is a composite entity: map - Else: string or number, depending on
        /// parameter value type - MapValue value: - If parameter's entity type is a composite entity: map from
        /// composite entity property names to property values - Else: parameter value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string,object> Parameters { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Agents.ExportAgent.</summary>
    public class GoogleCloudDialogflowV2ExportAgentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Zip compressed raw byte content for agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentContent")]
        public virtual string AgentContent { get; set; } 

        /// <summary>The URI to a file containing the exported agent. This field is populated only if `agent_uri` is
        /// specified in `ExportAgentRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentUri")]
        public virtual string AgentUri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An intent categorizes an end-user's intention for one conversation turn. For each agent, you define
    /// many intents, where your combined intents can handle a complete conversation. When an end-user writes or says
    /// something, referred to as an end-user expression or end-user input, Dialogflow matches the end-user input to the
    /// best intent in your agent. Matching an intent is also known as intent classification. For more information, see
    /// the [intent guide](https://cloud.google.com/dialogflow/docs/intents-overview).</summary>
    public class GoogleCloudDialogflowV2Intent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The name of the action associated with the intent. Note: The action name must not contain
        /// whitespaces.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; } 

        /// <summary>Optional. The list of platforms for which the first responses will be copied from the messages in
        /// PLATFORM_UNSPECIFIED (i.e. default platform).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultResponsePlatforms")]
        public virtual System.Collections.Generic.IList<string> DefaultResponsePlatforms { get; set; } 

        /// <summary>Required. The name of this intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Optional. The collection of event names that trigger the intent. If the collection of input
        /// contexts is not empty, all of the contexts must be present in the active user session for an event to
        /// trigger this intent. Event names are limited to 150 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<string> Events { get; set; } 

        /// <summary>Read-only. Information about all followup intents that have this intent as a direct or indirect
        /// parent. We populate this field only in the output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("followupIntentInfo")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentFollowupIntentInfo> FollowupIntentInfo { get; set; } 

        /// <summary>Optional. The list of context names required for this intent to be triggered. Format:
        /// `projects//agent/sessions/-/contexts/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputContextNames")]
        public virtual System.Collections.Generic.IList<string> InputContextNames { get; set; } 

        /// <summary>Optional. Indicates whether this is a fallback intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isFallback")]
        public virtual System.Nullable<bool> IsFallback { get; set; } 

        /// <summary>Optional. The collection of rich messages corresponding to the `Response` field in the Dialogflow
        /// console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentMessage> Messages { get; set; } 

        /// <summary>Optional. Indicates whether Machine Learning is disabled for the intent. Note: If `ml_disabled`
        /// setting is set to true, then this intent is not taken into account during inference in `ML ONLY` match mode.
        /// Also, auto-markup in the UI is turned off.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mlDisabled")]
        public virtual System.Nullable<bool> MlDisabled { get; set; } 

        /// <summary>Optional. The unique identifier of this intent. Required for Intents.UpdateIntent and
        /// Intents.BatchUpdateIntents methods. Format: `projects//agent/intents/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Optional. The collection of contexts that are activated when the intent is matched. Context
        /// messages in this collection should not set the parameters field. Setting the `lifespan_count` to 0 will
        /// reset the context when the intent is matched. Format: `projects//agent/sessions/-/contexts/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputContexts")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2Context> OutputContexts { get; set; } 

        /// <summary>Optional. The collection of parameters associated with the intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentParameter> Parameters { get; set; } 

        /// <summary>Read-only after creation. The unique identifier of the parent intent in the chain of followup
        /// intents. You can set this field when creating an intent, for example with CreateIntent or
        /// BatchUpdateIntents, in order to make this intent a followup intent. It identifies the parent followup
        /// intent. Format: `projects//agent/intents/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentFollowupIntentName")]
        public virtual string ParentFollowupIntentName { get; set; } 

        /// <summary>Optional. The priority of this intent. Higher numbers represent higher priorities. - If the
        /// supplied value is unspecified or 0, the service translates the value to 500,000, which corresponds to the
        /// `Normal` priority in the console. - If the supplied value is negative, the intent is ignored in runtime
        /// detect intent requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; } 

        /// <summary>Optional. Indicates whether to delete all contexts in the current session when this intent is
        /// matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resetContexts")]
        public virtual System.Nullable<bool> ResetContexts { get; set; } 

        /// <summary>Read-only. The unique identifier of the root intent in the chain of followup intents. It identifies
        /// the correct followup intents chain for this intent. We populate this field only in the output. Format:
        /// `projects//agent/intents/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootFollowupIntentName")]
        public virtual string RootFollowupIntentName { get; set; } 

        /// <summary>Optional. The collection of examples that the agent is trained on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingPhrases")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentTrainingPhrase> TrainingPhrases { get; set; } 

        /// <summary>Optional. Indicates whether webhooks are enabled for the intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookState")]
        public virtual string WebhookState { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a single followup intent in the chain.</summary>
    public class GoogleCloudDialogflowV2IntentFollowupIntentInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique identifier of the followup intent. Format: `projects//agent/intents/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("followupIntentName")]
        public virtual string FollowupIntentName { get; set; } 

        /// <summary>The unique identifier of the followup intent's parent. Format:
        /// `projects//agent/intents/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentFollowupIntentName")]
        public virtual string ParentFollowupIntentName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A rich response message. Corresponds to the intent `Response` field in the Dialogflow console. For more
    /// information, see [Rich response messages](https://cloud.google.com/dialogflow/docs/intents-rich-
    /// messages).</summary>
    public class GoogleCloudDialogflowV2IntentMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The basic card response for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicCard")]
        public virtual GoogleCloudDialogflowV2IntentMessageBasicCard BasicCard { get; set; } 

        /// <summary>Browse carousel card for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("browseCarouselCard")]
        public virtual GoogleCloudDialogflowV2IntentMessageBrowseCarouselCard BrowseCarouselCard { get; set; } 

        /// <summary>The card response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("card")]
        public virtual GoogleCloudDialogflowV2IntentMessageCard Card { get; set; } 

        /// <summary>The carousel card response for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carouselSelect")]
        public virtual GoogleCloudDialogflowV2IntentMessageCarouselSelect CarouselSelect { get; set; } 

        /// <summary>The image response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleCloudDialogflowV2IntentMessageImage Image { get; set; } 

        /// <summary>The link out suggestion chip for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkOutSuggestion")]
        public virtual GoogleCloudDialogflowV2IntentMessageLinkOutSuggestion LinkOutSuggestion { get; set; } 

        /// <summary>The list card response for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listSelect")]
        public virtual GoogleCloudDialogflowV2IntentMessageListSelect ListSelect { get; set; } 

        /// <summary>The media content card for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaContent")]
        public virtual GoogleCloudDialogflowV2IntentMessageMediaContent MediaContent { get; set; } 

        /// <summary>A custom platform-specific response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string,object> Payload { get; set; } 

        /// <summary>Optional. The platform that this message is intended for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; } 

        /// <summary>The quick replies response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quickReplies")]
        public virtual GoogleCloudDialogflowV2IntentMessageQuickReplies QuickReplies { get; set; } 

        /// <summary>The voice and text-only responses for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simpleResponses")]
        public virtual GoogleCloudDialogflowV2IntentMessageSimpleResponses SimpleResponses { get; set; } 

        /// <summary>The suggestion chips for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestions")]
        public virtual GoogleCloudDialogflowV2IntentMessageSuggestions Suggestions { get; set; } 

        /// <summary>Table card for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableCard")]
        public virtual GoogleCloudDialogflowV2IntentMessageTableCard TableCard { get; set; } 

        /// <summary>The text response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual GoogleCloudDialogflowV2IntentMessageText Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The basic card message. Useful for displaying information.</summary>
    public class GoogleCloudDialogflowV2IntentMessageBasicCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The collection of card buttons.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttons")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentMessageBasicCardButton> Buttons { get; set; } 

        /// <summary>Required, unless image is present. The body text of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedText")]
        public virtual string FormattedText { get; set; } 

        /// <summary>Optional. The image for the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleCloudDialogflowV2IntentMessageImage Image { get; set; } 

        /// <summary>Optional. The subtitle of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; } 

        /// <summary>Optional. The title of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The button object that appears at the bottom of a card.</summary>
    public class GoogleCloudDialogflowV2IntentMessageBasicCardButton : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Action to take when a user taps on the button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openUriAction")]
        public virtual GoogleCloudDialogflowV2IntentMessageBasicCardButtonOpenUriAction OpenUriAction { get; set; } 

        /// <summary>Required. The title of the button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Opens the given URI.</summary>
    public class GoogleCloudDialogflowV2IntentMessageBasicCardButtonOpenUriAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The HTTP or HTTPS scheme URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Browse Carousel Card for Actions on Google.
    /// https://developers.google.com/actions/assistant/responses#browsing_carousel</summary>
    public class GoogleCloudDialogflowV2IntentMessageBrowseCarouselCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Settings for displaying the image. Applies to every image in items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageDisplayOptions")]
        public virtual string ImageDisplayOptions { get; set; } 

        /// <summary>Required. List of items in the Browse Carousel Card. Minimum of two items, maximum of
        /// ten.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentMessageBrowseCarouselCardBrowseCarouselCardItem> Items { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Browsing carousel tile</summary>
    public class GoogleCloudDialogflowV2IntentMessageBrowseCarouselCardBrowseCarouselCardItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Description of the carousel item. Maximum of four lines of text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Optional. Text that appears at the bottom of the Browse Carousel Card. Maximum of one line of
        /// text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footer")]
        public virtual string Footer { get; set; } 

        /// <summary>Optional. Hero image for the carousel item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleCloudDialogflowV2IntentMessageImage Image { get; set; } 

        /// <summary>Required. Action to present to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openUriAction")]
        public virtual GoogleCloudDialogflowV2IntentMessageBrowseCarouselCardBrowseCarouselCardItemOpenUrlAction OpenUriAction { get; set; } 

        /// <summary>Required. Title of the carousel item. Maximum of two lines of text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Actions on Google action to open a given url.</summary>
    public class GoogleCloudDialogflowV2IntentMessageBrowseCarouselCardBrowseCarouselCardItemOpenUrlAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. URL</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>Optional. Specifies the type of viewer that is used when opening the URL. Defaults to opening via
        /// web browser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlTypeHint")]
        public virtual string UrlTypeHint { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The card response message.</summary>
    public class GoogleCloudDialogflowV2IntentMessageCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The collection of card buttons.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttons")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentMessageCardButton> Buttons { get; set; } 

        /// <summary>Optional. The public URI to an image file for the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; } 

        /// <summary>Optional. The subtitle of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; } 

        /// <summary>Optional. The title of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Contains information about a button.</summary>
    public class GoogleCloudDialogflowV2IntentMessageCardButton : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The text to send back to the Dialogflow API or a URI to open.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postback")]
        public virtual string Postback { get; set; } 

        /// <summary>Optional. The text to show on the button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The card for presenting a carousel of options to select from.</summary>
    public class GoogleCloudDialogflowV2IntentMessageCarouselSelect : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Carousel items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentMessageCarouselSelectItem> Items { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An item in the carousel.</summary>
    public class GoogleCloudDialogflowV2IntentMessageCarouselSelectItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The body text of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Optional. The image to display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleCloudDialogflowV2IntentMessageImage Image { get; set; } 

        /// <summary>Required. Additional info about the option item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("info")]
        public virtual GoogleCloudDialogflowV2IntentMessageSelectItemInfo Info { get; set; } 

        /// <summary>Required. Title of the carousel item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Column properties for TableCard.</summary>
    public class GoogleCloudDialogflowV2IntentMessageColumnProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Column heading.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; } 

        /// <summary>Optional. Defines text alignment for all cells in this column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalAlignment")]
        public virtual string HorizontalAlignment { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The image response message.</summary>
    public class GoogleCloudDialogflowV2IntentMessageImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. A text description of the image to be used for accessibility, e.g., screen
        /// readers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessibilityText")]
        public virtual string AccessibilityText { get; set; } 

        /// <summary>Optional. The public URI to an image file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The suggestion chip message that allows the user to jump out to the app or website associated with this
    /// agent.</summary>
    public class GoogleCloudDialogflowV2IntentMessageLinkOutSuggestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the app or site this chip is linking to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationName")]
        public virtual string DestinationName { get; set; } 

        /// <summary>Required. The URI of the app or site to open when the user taps the suggestion chip.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The card for presenting a list of options to select from.</summary>
    public class GoogleCloudDialogflowV2IntentMessageListSelect : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. List items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentMessageListSelectItem> Items { get; set; } 

        /// <summary>Optional. Subtitle of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; } 

        /// <summary>Optional. The overall title of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An item in the list.</summary>
    public class GoogleCloudDialogflowV2IntentMessageListSelectItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The main text describing the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Optional. The image to display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleCloudDialogflowV2IntentMessageImage Image { get; set; } 

        /// <summary>Required. Additional information about this option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("info")]
        public virtual GoogleCloudDialogflowV2IntentMessageSelectItemInfo Info { get; set; } 

        /// <summary>Required. The title of the list item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The media content card for Actions on Google.</summary>
    public class GoogleCloudDialogflowV2IntentMessageMediaContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. List of media objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaObjects")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentMessageMediaContentResponseMediaObject> MediaObjects { get; set; } 

        /// <summary>Optional. What type of media is the content (ie "audio").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaType")]
        public virtual string MediaType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response media object for media content card.</summary>
    public class GoogleCloudDialogflowV2IntentMessageMediaContentResponseMediaObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Url where the media is stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentUrl")]
        public virtual string ContentUrl { get; set; } 

        /// <summary>Optional. Description of media card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Optional. Icon to display above media content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual GoogleCloudDialogflowV2IntentMessageImage Icon { get; set; } 

        /// <summary>Optional. Image to display above media content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("largeImage")]
        public virtual GoogleCloudDialogflowV2IntentMessageImage LargeImage { get; set; } 

        /// <summary>Required. Name of media card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The quick replies response message.</summary>
    public class GoogleCloudDialogflowV2IntentMessageQuickReplies : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The collection of quick replies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quickReplies")]
        public virtual System.Collections.Generic.IList<string> QuickReplies { get; set; } 

        /// <summary>Optional. The title of the collection of quick replies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional info about the select item for when it is triggered in a dialog.</summary>
    public class GoogleCloudDialogflowV2IntentMessageSelectItemInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A unique key that will be sent back to the agent if this response is given.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        /// <summary>Optional. A list of synonyms that can also be used to trigger this item in dialog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("synonyms")]
        public virtual System.Collections.Generic.IList<string> Synonyms { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The simple response message containing speech or text.</summary>
    public class GoogleCloudDialogflowV2IntentMessageSimpleResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The text to display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayText")]
        public virtual string DisplayText { get; set; } 

        /// <summary>One of text_to_speech or ssml must be provided. Structured spoken response to the user in the SSML
        /// format. Mutually exclusive with text_to_speech.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssml")]
        public virtual string Ssml { get; set; } 

        /// <summary>One of text_to_speech or ssml must be provided. The plain text of the speech output. Mutually
        /// exclusive with ssml.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textToSpeech")]
        public virtual string TextToSpeech { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The collection of simple response candidates. This message in `QueryResult.fulfillment_messages` and
    /// `WebhookResponse.fulfillment_messages` should contain only one `SimpleResponse`.</summary>
    public class GoogleCloudDialogflowV2IntentMessageSimpleResponses : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of simple responses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simpleResponses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentMessageSimpleResponse> SimpleResponses { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The suggestion chip message that the user can tap to quickly post a reply to the
    /// conversation.</summary>
    public class GoogleCloudDialogflowV2IntentMessageSuggestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The text shown the in the suggestion chip.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The collection of suggestions.</summary>
    public class GoogleCloudDialogflowV2IntentMessageSuggestions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of suggested replies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestions")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentMessageSuggestion> Suggestions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Table card for Actions on Google.</summary>
    public class GoogleCloudDialogflowV2IntentMessageTableCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. List of buttons for the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttons")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentMessageBasicCardButton> Buttons { get; set; } 

        /// <summary>Optional. Display properties for the columns in this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnProperties")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentMessageColumnProperties> ColumnProperties { get; set; } 

        /// <summary>Optional. Image which should be displayed on the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleCloudDialogflowV2IntentMessageImage Image { get; set; } 

        /// <summary>Optional. Rows in this table of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentMessageTableCardRow> Rows { get; set; } 

        /// <summary>Optional. Subtitle to the title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; } 

        /// <summary>Required. Title of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Cell of TableCardRow.</summary>
    public class GoogleCloudDialogflowV2IntentMessageTableCardCell : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Text in this cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Row of TableCard.</summary>
    public class GoogleCloudDialogflowV2IntentMessageTableCardRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. List of cells that make up this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cells")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentMessageTableCardCell> Cells { get; set; } 

        /// <summary>Optional. Whether to add a visual divider after this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dividerAfter")]
        public virtual System.Nullable<bool> DividerAfter { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The text response message.</summary>
    public class GoogleCloudDialogflowV2IntentMessageText : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The collection of the agent's responses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual System.Collections.Generic.IList<string> Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents intent parameters.</summary>
    public class GoogleCloudDialogflowV2IntentParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The default value to use when the `value` yields an empty result. Default values can be
        /// extracted from contexts by using the following syntax: `#context_name.parameter_name`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual string DefaultValue { get; set; } 

        /// <summary>Required. The name of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Optional. The name of the entity type, prefixed with `@`, that describes values of the parameter.
        /// If the parameter is required, this must be provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityTypeDisplayName")]
        public virtual string EntityTypeDisplayName { get; set; } 

        /// <summary>Optional. Indicates whether the parameter represents a list of values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isList")]
        public virtual System.Nullable<bool> IsList { get; set; } 

        /// <summary>Optional. Indicates whether the parameter is required. That is, whether the intent cannot be
        /// completed without collecting the parameter value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mandatory")]
        public virtual System.Nullable<bool> Mandatory { get; set; } 

        /// <summary>The unique identifier of this parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Optional. The collection of prompts that the agent can present to the user in order to collect a
        /// value for the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prompts")]
        public virtual System.Collections.Generic.IList<string> Prompts { get; set; } 

        /// <summary>Optional. The definition of the parameter value. It can be: - a constant string, - a parameter
        /// value defined as `$parameter_name`, - an original parameter value defined as `$parameter_name.original`, - a
        /// parameter value from some context defined as `#context_name.parameter_name`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents an example that the agent is trained on.</summary>
    public class GoogleCloudDialogflowV2IntentTrainingPhrase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The unique identifier of this training phrase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Required. The ordered list of training phrase parts. The parts are concatenated in order to form
        /// the training phrase. Note: The API does not automatically annotate training phrases like the Dialogflow
        /// Console does. Note: Do not forget to include whitespace at part boundaries, so the training phrase is well
        /// formatted when the parts are concatenated. If the training phrase does not need to be annotated with
        /// parameters, you just need a single part with only the Part.text field set. If you want to annotate the
        /// training phrase, you must create multiple parts, where the fields of each part are populated in one of two
        /// ways: - `Part.text` is set to a part of the phrase that has no parameters. - `Part.text` is set to a part of
        /// the phrase that you want to annotate, and the `entity_type`, `alias`, and `user_defined` fields are all
        /// set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parts")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentTrainingPhrasePart> Parts { get; set; } 

        /// <summary>Optional. Indicates how many times this example was added to the intent. Each time a developer adds
        /// an existing sample by editing an intent or training, this counter is increased.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timesAddedCount")]
        public virtual System.Nullable<int> TimesAddedCount { get; set; } 

        /// <summary>Required. The type of the training phrase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a part of a training phrase.</summary>
    public class GoogleCloudDialogflowV2IntentTrainingPhrasePart : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The parameter name for the value extracted from the annotated part of the example. This
        /// field is required for annotated parts of the training phrase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alias")]
        public virtual string Alias { get; set; } 

        /// <summary>Optional. The entity type name prefixed with `@`. This field is required for annotated parts of the
        /// training phrase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityType")]
        public virtual string EntityType { get; set; } 

        /// <summary>Required. The text for this part.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>Optional. Indicates whether the text was manually annotated. This field is set to true when the
        /// Dialogflow Console is used to manually annotate the part. When creating an annotated part with the API, you
        /// must set this to true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userDefined")]
        public virtual System.Nullable<bool> UserDefined { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a message posted into a conversation.</summary>
    public class GoogleCloudDialogflowV2Message : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The message content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("content")]
        public virtual string Content { get; set; } 

        /// <summary>Output only. The time when the message was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>Optional. The message language. This should be a [BCP-47](https://www.rfc-
        /// editor.org/rfc/bcp/bcp47.txt) language tag. Example: "en-US".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; } 

        /// <summary>Output only. The annotation for the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageAnnotation")]
        public virtual GoogleCloudDialogflowV2MessageAnnotation MessageAnnotation { get; set; } 

        /// <summary>The unique identifier of the message. Format: `projects//conversations//messages/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. The participant that sends this message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("participant")]
        public virtual string Participant { get; set; } 

        /// <summary>Output only. The role of the participant.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("participantRole")]
        public virtual string ParticipantRole { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the result of annotation for the message.</summary>
    public class GoogleCloudDialogflowV2MessageAnnotation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates whether the text message contains entities.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containEntities")]
        public virtual System.Nullable<bool> ContainEntities { get; set; } 

        /// <summary>The collection of annotated message parts ordered by their position in the message. You can recover
        /// the annotated message by concatenating [AnnotatedMessagePart.text].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parts")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2AnnotatedMessagePart> Parts { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the contents of the original request that was passed to the `[Streaming]DetectIntent`
    /// call.</summary>
    public class GoogleCloudDialogflowV2OriginalDetectIntentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. This field is set to the value of the `QueryParameters.payload` field passed in the
        /// request. Some integrations that query a Dialogflow agent may provide additional information in the payload.
        /// In particular, for the Dialogflow Phone Gateway integration, this field has the form: { "telephony": {
        /// "caller_id": "+18558363987" } } Note: The caller ID field (`caller_id`) will be redacted for Standard
        /// Edition agents and populated with the caller ID in [E.164 format](https://en.wikipedia.org/wiki/E.164) for
        /// Enterprise Edition agents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string,object> Payload { get; set; } 

        /// <summary>The source of this request, e.g., `google`, `facebook`, `slack`. It is set by Dialogflow-owned
        /// servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; } 

        /// <summary>Optional. The version of the protocol used for this request. This field is AoG-specific.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the result of conversational query or event processing.</summary>
    public class GoogleCloudDialogflowV2QueryResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The action name from the matched intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; } 

        /// <summary>This field is set to: - `false` if the matched intent has required parameters and not all of the
        /// required parameter values have been collected. - `true` if all required parameter values have been
        /// collected, or if the matched intent doesn't contain any required parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allRequiredParamsPresent")]
        public virtual System.Nullable<bool> AllRequiredParamsPresent { get; set; } 

        /// <summary>Free-form diagnostic information for the associated detect intent request. The fields of this data
        /// can change without notice, so you should not write code that depends on its structure. The data may contain:
        /// - webhook call latency - webhook errors</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diagnosticInfo")]
        public virtual System.Collections.Generic.IDictionary<string,object> DiagnosticInfo { get; set; } 

        /// <summary>The collection of rich messages to present to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fulfillmentMessages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentMessage> FulfillmentMessages { get; set; } 

        /// <summary>The text to be pronounced to the user or shown on the screen. Note: This is a legacy field,
        /// `fulfillment_messages` should be preferred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fulfillmentText")]
        public virtual string FulfillmentText { get; set; } 

        /// <summary>The intent that matched the conversational query. Some, not all fields are filled in this message,
        /// including but not limited to: `name`, `display_name`, `end_interaction` and `is_fallback`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intent")]
        public virtual GoogleCloudDialogflowV2Intent Intent { get; set; } 

        /// <summary>The intent detection confidence. Values range from 0.0 (completely uncertain) to 1.0 (completely
        /// certain). This value is for informational purpose only and is only used to help match the best intent within
        /// the classification threshold. This value may change for the same end-user expression at any time due to a
        /// model retraining or change in implementation. If there are `multiple knowledge_answers` messages, this value
        /// is set to the greatest `knowledgeAnswers.match_confidence` value in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intentDetectionConfidence")]
        public virtual System.Nullable<float> IntentDetectionConfidence { get; set; } 

        /// <summary>The language that was triggered during intent detection. See [Language
        /// Support](https://cloud.google.com/dialogflow/docs/reference/language) for a list of the currently supported
        /// language codes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; } 

        /// <summary>The collection of output contexts. If applicable, `output_contexts.parameters` contains entries
        /// with name `.original` containing the original parameter values before the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputContexts")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2Context> OutputContexts { get; set; } 

        /// <summary>The collection of extracted parameters. Depending on your protocol or client library language, this
        /// is a map, associative array, symbol table, dictionary, or JSON object composed of a collection of (MapKey,
        /// MapValue) pairs: - MapKey type: string - MapKey value: parameter name - MapValue type: - If parameter's
        /// entity type is a composite entity: map - Else: string or number, depending on parameter value type -
        /// MapValue value: - If parameter's entity type is a composite entity: map from composite entity property names
        /// to property values - Else: parameter value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string,object> Parameters { get; set; } 

        /// <summary>The original conversational query text: - If natural language text was provided as input,
        /// `query_text` contains a copy of the input. - If natural language speech audio was provided as input,
        /// `query_text` contains the speech recognition result. If speech recognizer produced multiple alternatives, a
        /// particular one is picked. - If automatic spell correction is enabled, `query_text` will contain the
        /// corrected user input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryText")]
        public virtual string QueryText { get; set; } 

        /// <summary>The sentiment analysis result, which depends on the `sentiment_analysis_request_config` specified
        /// in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentimentAnalysisResult")]
        public virtual GoogleCloudDialogflowV2SentimentAnalysisResult SentimentAnalysisResult { get; set; } 

        /// <summary>The Speech recognition confidence between 0.0 and 1.0. A higher number indicates an estimated
        /// greater likelihood that the recognized words are correct. The default of 0.0 is a sentinel value indicating
        /// that confidence was not set. This field is not guaranteed to be accurate or set. In particular this field
        /// isn't set for StreamingDetectIntent since the streaming endpoint has separate confidence estimates per
        /// portion of the audio in StreamingRecognitionResult.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speechRecognitionConfidence")]
        public virtual System.Nullable<float> SpeechRecognitionConfidence { get; set; } 

        /// <summary>If the query was fulfilled by a webhook call, this field is set to the value of the `payload` field
        /// returned in the webhook response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookPayload")]
        public virtual System.Collections.Generic.IDictionary<string,object> WebhookPayload { get; set; } 

        /// <summary>If the query was fulfilled by a webhook call, this field is set to the value of the `source` field
        /// returned in the webhook response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookSource")]
        public virtual string WebhookSource { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The sentiment, such as positive/negative feeling or association, for a unit of analysis, such as the
    /// query text.</summary>
    public class GoogleCloudDialogflowV2Sentiment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A non-negative number in the [0, +inf) range, which represents the absolute magnitude of sentiment,
        /// regardless of score (positive or negative).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("magnitude")]
        public virtual System.Nullable<float> Magnitude { get; set; } 

        /// <summary>Sentiment score between -1.0 (negative sentiment) and 1.0 (positive sentiment).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The result of sentiment analysis. Sentiment analysis inspects user input and identifies the prevailing
    /// subjective opinion, especially to determine a user's attitude as positive, negative, or neutral. For
    /// Participants.AnalyzeContent, it needs to be configured in DetectIntentRequest.query_params. For
    /// Participants.StreamingAnalyzeContent, it needs to be configured in StreamingDetectIntentRequest.query_params.
    /// And for Participants.AnalyzeContent and Participants.StreamingAnalyzeContent, it needs to be configured in
    /// ConversationProfile.human_agent_assistant_config</summary>
    public class GoogleCloudDialogflowV2SentimentAnalysisResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The sentiment analysis result for `query_text`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryTextSentiment")]
        public virtual GoogleCloudDialogflowV2Sentiment QueryTextSentiment { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A session represents a conversation between a Dialogflow agent and an end-user. You can create special
    /// entities, called session entities, during a session. Session entities can extend or replace custom entity types
    /// and only exist during the session that they were created for. All session data, including session entities, is
    /// stored by Dialogflow for 20 minutes. For more information, see the [session entity
    /// guide](https://cloud.google.com/dialogflow/docs/entities-session).</summary>
    public class GoogleCloudDialogflowV2SessionEntityType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The collection of entities associated with this session entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2EntityTypeEntity> Entities { get; set; } 

        /// <summary>Required. Indicates whether the additional data should override or supplement the custom entity
        /// type definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityOverrideMode")]
        public virtual string EntityOverrideMode { get; set; } 

        /// <summary>Required. The unique identifier of this session entity type. Format:
        /// `projects//agent/sessions//entityTypes/`, or `projects//agent/environments//users//sessions//entityTypes/`.
        /// If `Environment ID` is not specified, we assume default 'draft' environment. If `User ID` is not specified,
        /// we assume default '-' user. `` must be the display name of an existing entity type in the same agent that
        /// will be overridden or supplemented.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The request message for a webhook call.</summary>
    public class GoogleCloudDialogflowV2WebhookRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The contents of the original request that was passed to `[Streaming]DetectIntent`
        /// call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalDetectIntentRequest")]
        public virtual GoogleCloudDialogflowV2OriginalDetectIntentRequest OriginalDetectIntentRequest { get; set; } 

        /// <summary>The result of the conversational query or event processing. Contains the same value as
        /// `[Streaming]DetectIntentResponse.query_result`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryResult")]
        public virtual GoogleCloudDialogflowV2QueryResult QueryResult { get; set; } 

        /// <summary>The unique identifier of the response. Contains the same value as
        /// `[Streaming]DetectIntentResponse.response_id`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseId")]
        public virtual string ResponseId { get; set; } 

        /// <summary>The unique identifier of detectIntent request session. Can be used to identify end-user inside
        /// webhook implementation. Format: `projects//agent/sessions/`, or
        /// `projects//agent/environments//users//sessions/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("session")]
        public virtual string Session { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for a webhook call. This response is validated by the Dialogflow server. If
    /// validation fails, an error will be returned in the QueryResult.diagnostic_info field. Setting JSON fields to an
    /// empty value with the wrong type is a common error. To avoid this error: - Use `""` for empty strings - Use `{}`
    /// or `null` for empty objects - Use `[]` or `null` for empty arrays For more information, see the [Protocol
    /// Buffers Language Guide](https://developers.google.com/protocol-buffers/docs/proto3#json).</summary>
    public class GoogleCloudDialogflowV2WebhookResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Invokes the supplied events. When this field is set, Dialogflow ignores the
        /// `fulfillment_text`, `fulfillment_messages`, and `payload` fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("followupEventInput")]
        public virtual GoogleCloudDialogflowV2EventInput FollowupEventInput { get; set; } 

        /// <summary>Optional. The rich response messages intended for the end-user. When provided, Dialogflow uses this
        /// field to populate QueryResult.fulfillment_messages sent to the integration or API caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fulfillmentMessages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2IntentMessage> FulfillmentMessages { get; set; } 

        /// <summary>Optional. The text response message intended for the end-user. It is recommended to use
        /// `fulfillment_messages.text.text[0]` instead. When provided, Dialogflow uses this field to populate
        /// QueryResult.fulfillment_text sent to the integration or API caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fulfillmentText")]
        public virtual string FulfillmentText { get; set; } 

        /// <summary>Optional. The collection of output contexts that will overwrite currently active contexts for the
        /// session and reset their lifespans. When provided, Dialogflow uses this field to populate
        /// QueryResult.output_contexts sent to the integration or API caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputContexts")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2Context> OutputContexts { get; set; } 

        /// <summary>Optional. This field can be used to pass custom data from your webhook to the integration or API
        /// caller. Arbitrary JSON objects are supported. When provided, Dialogflow uses this field to populate
        /// QueryResult.webhook_payload sent to the integration or API caller. This field is also used by the [Google
        /// Assistant integration](https://cloud.google.com/dialogflow/docs/integrations/aog) for rich response
        /// messages. See the format definition at [Google Assistant Dialogflow webhook
        /// format](https://developers.google.com/assistant/actions/build/json/dialogflow-webhook-json)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string,object> Payload { get; set; } 

        /// <summary>Optional. Additional session entity types to replace or extend developer entity types with. The
        /// entity synonyms apply to all languages and persist for the session. Setting this data from a webhook
        /// overwrites the session entity types that have been set using `detectIntent`, `streamingDetectIntent` or
        /// SessionEntityType management methods.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionEntityTypes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2SessionEntityType> SessionEntityTypes { get; set; } 

        /// <summary>Optional. A custom field used to identify the webhook source. Arbitrary strings are supported. When
        /// provided, Dialogflow uses this field to populate QueryResult.webhook_source sent to the integration or API
        /// caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents an annotated conversation dataset. ConversationDataset can have multiple
    /// AnnotatedConversationDataset, each of them represents one result from one annotation task.
    /// AnnotatedConversationDataset can only be generated from annotation task, which will be triggered by
    /// LabelConversation.</summary>
    public class GoogleCloudDialogflowV2beta1AnnotatedConversationDataset : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. Number of examples that have annotations in the annotated conversation
        /// dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("completedExampleCount")]
        public virtual System.Nullable<long> CompletedExampleCount { get; set; } 

        /// <summary>Output only. Creation time of this annotated conversation dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>Optional. The description of the annotated conversation dataset. Maximum of 10000 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Required. The display name of the annotated conversation dataset. It's specified when user starts
        /// an annotation task. Maximum of 64 bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. Number of examples in the annotated conversation dataset.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exampleCount")]
        public virtual System.Nullable<long> ExampleCount { get; set; } 

        /// <summary>Output only. AnnotatedConversationDataset resource name. Format:
        /// `projects//conversationDatasets//annotatedConversationDatasets/`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. Question type name that identifies a labeling task. A question is a single task that a
        /// worker answers. A question type is set of related questions. Each question belongs to a particular question
        /// type. It can be used in CrowdCompute UI to filter and manage labeling tasks.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("questionTypeName")]
        public virtual string QuestionTypeName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response message for [Documents.AutoApproveSmartMessagingEntries].</summary>
    public class GoogleCloudDialogflowV2beta1AutoApproveSmartMessagingEntriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Number of smart messaging entries disabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("disabledCount")]
        public virtual System.Nullable<int> DisabledCount { get; set; } 

        /// <summary>Number of smart messaging entries enabled.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enabledCount")]
        public virtual System.Nullable<int> EnabledCount { get; set; } 

        /// <summary>Number of smart messaging entries unreviewed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreviewedCount")]
        public virtual System.Nullable<int> UnreviewedCount { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for EntityTypes.BatchUpdateEntityTypes.</summary>
    public class GoogleCloudDialogflowV2beta1BatchUpdateEntityTypesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The collection of updated or created entity types.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityTypes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1EntityType> EntityTypes { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Intents.BatchUpdateIntents.</summary>
    public class GoogleCloudDialogflowV2beta1BatchUpdateIntentsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The collection of updated or created intents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intents")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1Intent> Intents { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Dialogflow contexts are similar to natural language context. If a person says to you "they are orange",
    /// you need context in order to understand what "they" is referring to. Similarly, for Dialogflow to handle an end-
    /// user expression like that, it needs to be provided with context in order to correctly match an intent. Using
    /// contexts, you can control the flow of a conversation. You can configure contexts for an intent by setting input
    /// and output contexts, which are identified by string names. When an intent is matched, any configured output
    /// contexts for that intent become active. While any contexts are active, Dialogflow is more likely to match
    /// intents that are configured with input contexts that correspond to the currently active contexts. For more
    /// information about context, see the [Contexts guide](https://cloud.google.com/dialogflow/docs/contexts-
    /// overview).</summary>
    public class GoogleCloudDialogflowV2beta1Context : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The number of conversational query requests after which the context expires. The default
        /// is `0`. If set to `0`, the context expires immediately. Contexts expire automatically after 20 minutes if
        /// there are no matching queries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lifespanCount")]
        public virtual System.Nullable<int> LifespanCount { get; set; } 

        /// <summary>Required. The unique identifier of the context. Format: `projects//agent/sessions//contexts/`, or
        /// `projects//agent/environments//users//sessions//contexts/`. The `Context ID` is always converted to
        /// lowercase, may only contain characters in a-zA-Z0-9_-% and may be at most 250 bytes long. If `Environment
        /// ID` is not specified, we assume default 'draft' environment. If `User ID` is not specified, we assume
        /// default '-' user. The following context names are reserved for internal use by Dialogflow. You should not
        /// use these contexts or create contexts with these names: * `__system_counters__` * `*_id_dialog_context` *
        /// `*_dialog_params_size`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Optional. The collection of parameters associated with this context. Depending on your protocol or
        /// client library language, this is a map, associative array, symbol table, dictionary, or JSON object composed
        /// of a collection of (MapKey, MapValue) pairs: - MapKey type: string - MapKey value: parameter name - MapValue
        /// type: - If parameter's entity type is a composite entity: map - Else: string or number, depending on
        /// parameter value type - MapValue value: - If parameter's entity type is a composite entity: map from
        /// composite entity property names to property values - Else: parameter value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string,object> Parameters { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Each intent parameter has a type, called the entity type, which dictates exactly how data from an end-
    /// user expression is extracted. Dialogflow provides predefined system entities that can match many common types of
    /// data. For example, there are system entities for matching dates, times, colors, email addresses, and so on. You
    /// can also create your own custom entities for matching custom data. For example, you could define a vegetable
    /// entity that can match the types of vegetables available for purchase with a grocery store agent. For more
    /// information, see the [Entity guide](https://cloud.google.com/dialogflow/docs/entities-overview).</summary>
    public class GoogleCloudDialogflowV2beta1EntityType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Indicates whether the entity type can be automatically expanded.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("autoExpansionMode")]
        public virtual string AutoExpansionMode { get; set; } 

        /// <summary>Required. The name of the entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Optional. Enables fuzzy entity extraction during classification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableFuzzyExtraction")]
        public virtual System.Nullable<bool> EnableFuzzyExtraction { get; set; } 

        /// <summary>Optional. The collection of entity entries associated with the entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1EntityTypeEntity> Entities { get; set; } 

        /// <summary>Required. Indicates the kind of entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>The unique identifier of the entity type. Required for EntityTypes.UpdateEntityType and
        /// EntityTypes.BatchUpdateEntityTypes methods. Format: `projects//agent/entityTypes/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An **entity entry** for an associated entity type.</summary>
    public class GoogleCloudDialogflowV2beta1EntityTypeEntity : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A collection of value synonyms. For example, if the entity type is *vegetable*, and
        /// `value` is *scallions*, a synonym could be *green onions*. For `KIND_LIST` entity types: * This collection
        /// must contain exactly one synonym equal to `value`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("synonyms")]
        public virtual System.Collections.Generic.IList<string> Synonyms { get; set; } 

        /// <summary>Required. The primary value associated with this entity entry. For example, if the entity type is
        /// *vegetable*, the value could be *scallions*. For `KIND_MAP` entity types: * A reference value to be used in
        /// place of synonyms. For `KIND_LIST` entity types: * A string that can contain references to other entity
        /// types (with or without aliases).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Events allow for matching intents by event name instead of the natural language input. For instance,
    /// input `` can trigger a personalized welcome response. The parameter `name` may be used by the agent in the
    /// response: `"Hello #welcome_event.name! What can I do for you today?"`.</summary>
    public class GoogleCloudDialogflowV2beta1EventInput : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The language of this query. See [Language
        /// Support](https://cloud.google.com/dialogflow/docs/reference/language) for a list of the currently supported
        /// language codes. Note that queries in the same session do not necessarily need to specify the same
        /// language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; } 

        /// <summary>Required. The unique identifier of the event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The collection of parameters associated with the event. Depending on your protocol or client
        /// library language, this is a map, associative array, symbol table, dictionary, or JSON object composed of a
        /// collection of (MapKey, MapValue) pairs: - MapKey type: string - MapKey value: parameter name - MapValue
        /// type: - If parameter's entity type is a composite entity: map - Else: string or number, depending on
        /// parameter value type - MapValue value: - If parameter's entity type is a composite entity: map from
        /// composite entity property names to property values - Else: parameter value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string,object> Parameters { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Agents.ExportAgent.</summary>
    public class GoogleCloudDialogflowV2beta1ExportAgentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Zip compressed raw byte content for agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentContent")]
        public virtual string AgentContent { get; set; } 

        /// <summary>The URI to a file containing the exported agent. This field is populated only if `agent_uri` is
        /// specified in `ExportAgentRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentUri")]
        public virtual string AgentUri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An intent categorizes an end-user's intention for one conversation turn. For each agent, you define
    /// many intents, where your combined intents can handle a complete conversation. When an end-user writes or says
    /// something, referred to as an end-user expression or end-user input, Dialogflow matches the end-user input to the
    /// best intent in your agent. Matching an intent is also known as intent classification. For more information, see
    /// the [intent guide](https://cloud.google.com/dialogflow/docs/intents-overview).</summary>
    public class GoogleCloudDialogflowV2beta1Intent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The name of the action associated with the intent. Note: The action name must not contain
        /// whitespaces.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; } 

        /// <summary>Optional. The list of platforms for which the first responses will be copied from the messages in
        /// PLATFORM_UNSPECIFIED (i.e. default platform).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultResponsePlatforms")]
        public virtual System.Collections.Generic.IList<string> DefaultResponsePlatforms { get; set; } 

        /// <summary>Required. The name of this intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Optional. Indicates that this intent ends an interaction. Some integrations (e.g., Actions on
        /// Google or Dialogflow phone gateway) use this information to close interaction with an end user. Default is
        /// false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endInteraction")]
        public virtual System.Nullable<bool> EndInteraction { get; set; } 

        /// <summary>Optional. The collection of event names that trigger the intent. If the collection of input
        /// contexts is not empty, all of the contexts must be present in the active user session for an event to
        /// trigger this intent. Event names are limited to 150 characters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual System.Collections.Generic.IList<string> Events { get; set; } 

        /// <summary>Output only. Information about all followup intents that have this intent as a direct or indirect
        /// parent. We populate this field only in the output.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("followupIntentInfo")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentFollowupIntentInfo> FollowupIntentInfo { get; set; } 

        /// <summary>Optional. The list of context names required for this intent to be triggered. Format:
        /// `projects//agent/sessions/-/contexts/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputContextNames")]
        public virtual System.Collections.Generic.IList<string> InputContextNames { get; set; } 

        /// <summary>Optional. Indicates whether this is a fallback intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isFallback")]
        public virtual System.Nullable<bool> IsFallback { get; set; } 

        /// <summary>Optional. The collection of rich messages corresponding to the `Response` field in the Dialogflow
        /// console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessage> Messages { get; set; } 

        /// <summary>Optional. Indicates whether Machine Learning is disabled for the intent. Note: If `ml_disabled`
        /// setting is set to true, then this intent is not taken into account during inference in `ML ONLY` match mode.
        /// Also, auto-markup in the UI is turned off.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mlDisabled")]
        public virtual System.Nullable<bool> MlDisabled { get; set; } 

        /// <summary>Optional. Indicates whether Machine Learning is enabled for the intent. Note: If `ml_enabled`
        /// setting is set to false, then this intent is not taken into account during inference in `ML ONLY` match
        /// mode. Also, auto-markup in the UI is turned off. DEPRECATED! Please use `ml_disabled` field instead. NOTE:
        /// If both `ml_enabled` and `ml_disabled` are either not set or false, then the default value is determined as
        /// follows: - Before April 15th, 2018 the default is: ml_enabled = false / ml_disabled = true. - After April
        /// 15th, 2018 the default is: ml_enabled = true / ml_disabled = false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mlEnabled")]
        public virtual System.Nullable<bool> MlEnabled { get; set; } 

        /// <summary>Optional. The unique identifier of this intent. Required for Intents.UpdateIntent and
        /// Intents.BatchUpdateIntents methods. Format: `projects//agent/intents/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Optional. The collection of contexts that are activated when the intent is matched. Context
        /// messages in this collection should not set the parameters field. Setting the `lifespan_count` to 0 will
        /// reset the context when the intent is matched. Format: `projects//agent/sessions/-/contexts/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputContexts")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1Context> OutputContexts { get; set; } 

        /// <summary>Optional. The collection of parameters associated with the intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentParameter> Parameters { get; set; } 

        /// <summary>Optional. The unique identifier of the parent intent in the chain of followup intents. You can set
        /// this field when creating an intent, for example with CreateIntent or BatchUpdateIntents, in order to make
        /// this intent a followup intent. It identifies the parent followup intent. Format:
        /// `projects//agent/intents/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentFollowupIntentName")]
        public virtual string ParentFollowupIntentName { get; set; } 

        /// <summary>Optional. The priority of this intent. Higher numbers represent higher priorities. - If the
        /// supplied value is unspecified or 0, the service translates the value to 500,000, which corresponds to the
        /// `Normal` priority in the console. - If the supplied value is negative, the intent is ignored in runtime
        /// detect intent requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("priority")]
        public virtual System.Nullable<int> Priority { get; set; } 

        /// <summary>Optional. Indicates whether to delete all contexts in the current session when this intent is
        /// matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resetContexts")]
        public virtual System.Nullable<bool> ResetContexts { get; set; } 

        /// <summary>Output only. The unique identifier of the root intent in the chain of followup intents. It
        /// identifies the correct followup intents chain for this intent. Format: `projects//agent/intents/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rootFollowupIntentName")]
        public virtual string RootFollowupIntentName { get; set; } 

        /// <summary>Optional. The collection of examples that the agent is trained on.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("trainingPhrases")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentTrainingPhrase> TrainingPhrases { get; set; } 

        /// <summary>Optional. Indicates whether webhooks are enabled for the intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookState")]
        public virtual string WebhookState { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a single followup intent in the chain.</summary>
    public class GoogleCloudDialogflowV2beta1IntentFollowupIntentInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique identifier of the followup intent. Format: `projects//agent/intents/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("followupIntentName")]
        public virtual string FollowupIntentName { get; set; } 

        /// <summary>The unique identifier of the followup intent's parent. Format:
        /// `projects//agent/intents/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentFollowupIntentName")]
        public virtual string ParentFollowupIntentName { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Corresponds to the `Response` field in the Dialogflow console.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Displays a basic card for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("basicCard")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageBasicCard BasicCard { get; set; } 

        /// <summary>Browse carousel card for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("browseCarouselCard")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageBrowseCarouselCard BrowseCarouselCard { get; set; } 

        /// <summary>Displays a card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("card")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageCard Card { get; set; } 

        /// <summary>Displays a carousel card for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("carouselSelect")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageCarouselSelect CarouselSelect { get; set; } 

        /// <summary>Displays an image.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageImage Image { get; set; } 

        /// <summary>Displays a link out suggestion chip for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("linkOutSuggestion")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageLinkOutSuggestion LinkOutSuggestion { get; set; } 

        /// <summary>Displays a list card for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("listSelect")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageListSelect ListSelect { get; set; } 

        /// <summary>The media content card for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaContent")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageMediaContent MediaContent { get; set; } 

        /// <summary>A custom platform-specific response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string,object> Payload { get; set; } 

        /// <summary>Optional. The platform that this message is intended for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("platform")]
        public virtual string Platform { get; set; } 

        /// <summary>Displays quick replies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quickReplies")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageQuickReplies QuickReplies { get; set; } 

        /// <summary>Rich Business Messaging (RBM) carousel rich card response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rbmCarouselRichCard")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageRbmCarouselCard RbmCarouselRichCard { get; set; } 

        /// <summary>Standalone Rich Business Messaging (RBM) rich card response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rbmStandaloneRichCard")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageRbmStandaloneCard RbmStandaloneRichCard { get; set; } 

        /// <summary>Rich Business Messaging (RBM) text response. RBM allows businesses to send enriched and branded
        /// versions of SMS. See https://jibe.google.com/business-messaging.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rbmText")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageRbmText RbmText { get; set; } 

        /// <summary>Returns a voice or text-only response for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simpleResponses")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageSimpleResponses SimpleResponses { get; set; } 

        /// <summary>Displays suggestion chips for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestions")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageSuggestions Suggestions { get; set; } 

        /// <summary>Table card for Actions on Google.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tableCard")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageTableCard TableCard { get; set; } 

        /// <summary>Plays audio from a file in Telephony Gateway.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("telephonyPlayAudio")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageTelephonyPlayAudio TelephonyPlayAudio { get; set; } 

        /// <summary>Synthesizes speech in Telephony Gateway.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("telephonySynthesizeSpeech")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageTelephonySynthesizeSpeech TelephonySynthesizeSpeech { get; set; } 

        /// <summary>Transfers the call in Telephony Gateway.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("telephonyTransferCall")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageTelephonyTransferCall TelephonyTransferCall { get; set; } 

        /// <summary>Returns a text response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageText Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The basic card message. Useful for displaying information.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageBasicCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The collection of card buttons.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttons")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessageBasicCardButton> Buttons { get; set; } 

        /// <summary>Required, unless image is present. The body text of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("formattedText")]
        public virtual string FormattedText { get; set; } 

        /// <summary>Optional. The image for the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageImage Image { get; set; } 

        /// <summary>Optional. The subtitle of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; } 

        /// <summary>Optional. The title of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The button object that appears at the bottom of a card.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageBasicCardButton : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Action to take when a user taps on the button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openUriAction")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageBasicCardButtonOpenUriAction OpenUriAction { get; set; } 

        /// <summary>Required. The title of the button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Opens the given URI.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageBasicCardButtonOpenUriAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The HTTP or HTTPS scheme URI.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Browse Carousel Card for Actions on Google.
    /// https://developers.google.com/actions/assistant/responses#browsing_carousel</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageBrowseCarouselCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Settings for displaying the image. Applies to every image in items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageDisplayOptions")]
        public virtual string ImageDisplayOptions { get; set; } 

        /// <summary>Required. List of items in the Browse Carousel Card. Minimum of two items, maximum of
        /// ten.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessageBrowseCarouselCardBrowseCarouselCardItem> Items { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Browsing carousel tile</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageBrowseCarouselCardBrowseCarouselCardItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Description of the carousel item. Maximum of four lines of text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Optional. Text that appears at the bottom of the Browse Carousel Card. Maximum of one line of
        /// text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("footer")]
        public virtual string Footer { get; set; } 

        /// <summary>Optional. Hero image for the carousel item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageImage Image { get; set; } 

        /// <summary>Required. Action to present to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openUriAction")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageBrowseCarouselCardBrowseCarouselCardItemOpenUrlAction OpenUriAction { get; set; } 

        /// <summary>Required. Title of the carousel item. Maximum of two lines of text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Actions on Google action to open a given url.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageBrowseCarouselCardBrowseCarouselCardItemOpenUrlAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. URL</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("url")]
        public virtual string Url { get; set; } 

        /// <summary>Optional. Specifies the type of viewer that is used when opening the URL. Defaults to opening via
        /// web browser.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("urlTypeHint")]
        public virtual string UrlTypeHint { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The card response message.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The collection of card buttons.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttons")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessageCardButton> Buttons { get; set; } 

        /// <summary>Optional. The public URI to an image file for the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; } 

        /// <summary>Optional. The subtitle of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; } 

        /// <summary>Optional. The title of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Optional. Contains information about a button.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageCardButton : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The text to send back to the Dialogflow API or a URI to open.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postback")]
        public virtual string Postback { get; set; } 

        /// <summary>Optional. The text to show on the button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The card for presenting a carousel of options to select from.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageCarouselSelect : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Carousel items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessageCarouselSelectItem> Items { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An item in the carousel.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageCarouselSelectItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The body text of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Optional. The image to display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageImage Image { get; set; } 

        /// <summary>Required. Additional info about the option item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("info")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageSelectItemInfo Info { get; set; } 

        /// <summary>Required. Title of the carousel item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Column properties for TableCard.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageColumnProperties : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Column heading.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("header")]
        public virtual string Header { get; set; } 

        /// <summary>Optional. Defines text alignment for all cells in this column.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("horizontalAlignment")]
        public virtual string HorizontalAlignment { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The image response message.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageImage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A text description of the image to be used for accessibility, e.g., screen readers. Required if
        /// image_uri is set for CarouselSelect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessibilityText")]
        public virtual string AccessibilityText { get; set; } 

        /// <summary>Optional. The public URI to an image file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageUri")]
        public virtual string ImageUri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The suggestion chip message that allows the user to jump out to the app or website associated with this
    /// agent.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageLinkOutSuggestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The name of the app or site this chip is linking to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationName")]
        public virtual string DestinationName { get; set; } 

        /// <summary>Required. The URI of the app or site to open when the user taps the suggestion chip.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The card for presenting a list of options to select from.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageListSelect : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. List items.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessageListSelectItem> Items { get; set; } 

        /// <summary>Optional. Subtitle of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; } 

        /// <summary>Optional. The overall title of the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An item in the list.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageListSelectItem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The main text describing the item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Optional. The image to display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageImage Image { get; set; } 

        /// <summary>Required. Additional information about this option.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("info")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageSelectItemInfo Info { get; set; } 

        /// <summary>Required. The title of the list item.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The media content card for Actions on Google.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageMediaContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. List of media objects.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaObjects")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessageMediaContentResponseMediaObject> MediaObjects { get; set; } 

        /// <summary>Optional. What type of media is the content (ie "audio").</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mediaType")]
        public virtual string MediaType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response media object for media content card.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageMediaContentResponseMediaObject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Url where the media is stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contentUrl")]
        public virtual string ContentUrl { get; set; } 

        /// <summary>Optional. Description of media card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Optional. Icon to display above media content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("icon")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageImage Icon { get; set; } 

        /// <summary>Optional. Image to display above media content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("largeImage")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageImage LargeImage { get; set; } 

        /// <summary>Required. Name of media card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The quick replies response message.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageQuickReplies : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The collection of quick replies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("quickReplies")]
        public virtual System.Collections.Generic.IList<string> QuickReplies { get; set; } 

        /// <summary>Optional. The title of the collection of quick replies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Rich Business Messaging (RBM) Card content</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageRbmCardContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Description of the card (at most 2000 bytes). At least one of the title, description or
        /// media must be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; } 

        /// <summary>Optional. However at least one of the title, description or media must be set. Media (image, GIF or
        /// a video) to include in the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("media")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageRbmCardContentRbmMedia Media { get; set; } 

        /// <summary>Optional. List of suggestions to include in the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestions")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessageRbmSuggestion> Suggestions { get; set; } 

        /// <summary>Optional. Title of the card (at most 200 bytes). At least one of the title, description or media
        /// must be set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Rich Business Messaging (RBM) Media displayed in Cards The following media-types are currently
    /// supported: Image Types * image/jpeg * image/jpg' * image/gif * image/png Video Types * video/h263 * video/m4v *
    /// video/mp4 * video/mpeg * video/mpeg4 * video/webm</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageRbmCardContentRbmMedia : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Publicly reachable URI of the file. The RBM platform determines the MIME type of the file
        /// from the content-type field in the HTTP headers when the platform fetches the file. The content-type field
        /// must be present and accurate in the HTTP response from the URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fileUri")]
        public virtual string FileUri { get; set; } 

        /// <summary>Required for cards with vertical orientation. The height of the media within a rich card with a
        /// vertical layout. For a standalone card with horizontal layout, height is not customizable, and this field is
        /// ignored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("height")]
        public virtual string Height { get; set; } 

        /// <summary>Optional. Publicly reachable URI of the thumbnail.If you don't provide a thumbnail URI, the RBM
        /// platform displays a blank placeholder thumbnail until the user's device downloads the file. Depending on the
        /// user's setting, the file may not download automatically and may require the user to tap a download
        /// button.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailUri")]
        public virtual string ThumbnailUri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Carousel Rich Business Messaging (RBM) rich card. Rich cards allow you to respond to users with more
    /// vivid content, e.g. with media and suggestions. If you want to show a single card with more control over the
    /// layout, please use RbmStandaloneCard instead.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageRbmCarouselCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The cards in the carousel. A carousel must have at least 2 cards and at most
        /// 10.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardContents")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessageRbmCardContent> CardContents { get; set; } 

        /// <summary>Required. The width of the cards in the carousel.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardWidth")]
        public virtual string CardWidth { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Standalone Rich Business Messaging (RBM) rich card. Rich cards allow you to respond to users with more
    /// vivid content, e.g. with media and suggestions. You can group multiple rich cards into one using RbmCarouselCard
    /// but carousel cards will give you less control over the card layout.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageRbmStandaloneCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Card content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardContent")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageRbmCardContent CardContent { get; set; } 

        /// <summary>Required. Orientation of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cardOrientation")]
        public virtual string CardOrientation { get; set; } 

        /// <summary>Required if orientation is horizontal. Image preview alignment for standalone cards with horizontal
        /// layout.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("thumbnailImageAlignment")]
        public virtual string ThumbnailImageAlignment { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Rich Business Messaging (RBM) suggested client-side action that the user can choose from the
    /// card.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageRbmSuggestedAction : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Suggested client side action: Dial a phone number</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dial")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageRbmSuggestedActionRbmSuggestedActionDial Dial { get; set; } 

        /// <summary>Suggested client side action: Open a URI on device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("openUrl")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageRbmSuggestedActionRbmSuggestedActionOpenUri OpenUrl { get; set; } 

        /// <summary>Opaque payload that the Dialogflow receives in a user event when the user taps the suggested
        /// action. This data will be also forwarded to webhook to allow performing custom business logic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postbackData")]
        public virtual string PostbackData { get; set; } 

        /// <summary>Suggested client side action: Share user location</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("shareLocation")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageRbmSuggestedActionRbmSuggestedActionShareLocation ShareLocation { get; set; } 

        /// <summary>Text to display alongside the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Opens the user's default dialer app with the specified phone number but does not dial
    /// automatically.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageRbmSuggestedActionRbmSuggestedActionDial : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The phone number to fill in the default dialer app. This field should be in
        /// [E.164](https://en.wikipedia.org/wiki/E.164) format. An example of a correctly formatted phone number:
        /// +15556767888.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Opens the user's default web browser app to the specified uri If the user has an app installed that is
    /// registered as the default handler for the URL, then this app will be opened instead, and its icon will be used
    /// in the suggested action UI.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageRbmSuggestedActionRbmSuggestedActionOpenUri : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The uri to open on the user device</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Opens the device's location chooser so the user can pick a location to send back to the
    /// agent.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageRbmSuggestedActionRbmSuggestedActionShareLocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Rich Business Messaging (RBM) suggested reply that the user can click instead of typing in their own
    /// response.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageRbmSuggestedReply : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Opaque payload that the Dialogflow receives in a user event when the user taps the suggested reply.
        /// This data will be also forwarded to webhook to allow performing custom business logic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("postbackData")]
        public virtual string PostbackData { get; set; } 

        /// <summary>Suggested reply text.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Rich Business Messaging (RBM) suggestion. Suggestions allow user to easily select/click a predefined
    /// response or perform an action (like opening a web uri).</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageRbmSuggestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Predefined client side actions that user can choose</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageRbmSuggestedAction Action { get; set; } 

        /// <summary>Predefined replies for user to select instead of typing</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reply")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageRbmSuggestedReply Reply { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Rich Business Messaging (RBM) text response with suggestions.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageRbmText : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. One or more suggestions to show to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rbmSuggestion")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessageRbmSuggestion> RbmSuggestion { get; set; } 

        /// <summary>Required. Text sent and displayed to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Additional info about the select item for when it is triggered in a dialog.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageSelectItemInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. A unique key that will be sent back to the agent if this response is given.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; } 

        /// <summary>Optional. A list of synonyms that can also be used to trigger this item in dialog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("synonyms")]
        public virtual System.Collections.Generic.IList<string> Synonyms { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The simple response message containing speech or text.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageSimpleResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The text to display.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayText")]
        public virtual string DisplayText { get; set; } 

        /// <summary>One of text_to_speech or ssml must be provided. Structured spoken response to the user in the SSML
        /// format. Mutually exclusive with text_to_speech.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssml")]
        public virtual string Ssml { get; set; } 

        /// <summary>One of text_to_speech or ssml must be provided. The plain text of the speech output. Mutually
        /// exclusive with ssml.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("textToSpeech")]
        public virtual string TextToSpeech { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The collection of simple response candidates. This message in `QueryResult.fulfillment_messages` and
    /// `WebhookResponse.fulfillment_messages` should contain only one `SimpleResponse`.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageSimpleResponses : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of simple responses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("simpleResponses")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessageSimpleResponse> SimpleResponses { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The suggestion chip message that the user can tap to quickly post a reply to the
    /// conversation.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageSuggestion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The text shown the in the suggestion chip.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The collection of suggestions.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageSuggestions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The list of suggested replies.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("suggestions")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessageSuggestion> Suggestions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Table card for Actions on Google.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageTableCard : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. List of buttons for the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("buttons")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessageBasicCardButton> Buttons { get; set; } 

        /// <summary>Optional. Display properties for the columns in this table.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("columnProperties")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessageColumnProperties> ColumnProperties { get; set; } 

        /// <summary>Optional. Image which should be displayed on the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("image")]
        public virtual GoogleCloudDialogflowV2beta1IntentMessageImage Image { get; set; } 

        /// <summary>Optional. Rows in this table of data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessageTableCardRow> Rows { get; set; } 

        /// <summary>Optional. Subtitle to the title.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subtitle")]
        public virtual string Subtitle { get; set; } 

        /// <summary>Required. Title of the card.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Cell of TableCardRow.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageTableCardCell : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Text in this cell.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Row of TableCard.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageTableCardRow : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. List of cells that make up this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cells")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessageTableCardCell> Cells { get; set; } 

        /// <summary>Optional. Whether to add a visual divider after this row.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dividerAfter")]
        public virtual System.Nullable<bool> DividerAfter { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Plays audio from a file in Telephony Gateway.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageTelephonyPlayAudio : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. URI to a Google Cloud Storage object containing the audio to play, e.g.,
        /// "gs://bucket/object". The object must contain a single channel (mono) of linear PCM audio (2 bytes / sample)
        /// at 8kHz. This object must be readable by the `service-@gcp-sa-dialogflow.iam.gserviceaccount.com` service
        /// account where is the number of the Telephony Gateway project (usually the same as the Dialogflow agent
        /// project). If the Google Cloud Storage bucket is in the Telephony Gateway project, this permission is added
        /// by default when enabling the Dialogflow V2 API. For audio from other sources, consider using the
        /// `TelephonySynthesizeSpeech` message with SSML.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audioUri")]
        public virtual string AudioUri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Synthesizes speech and plays back the synthesized audio to the caller in Telephony Gateway. Telephony
    /// Gateway takes the synthesizer settings from `DetectIntentResponse.output_audio_config` which can either be set
    /// at request-level or can come from the agent-level synthesizer config.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageTelephonySynthesizeSpeech : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The SSML to be synthesized. For more information, see
        /// [SSML](https://developers.google.com/actions/reference/ssml).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ssml")]
        public virtual string Ssml { get; set; } 

        /// <summary>The raw text to be synthesized.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Transfers the call in Telephony Gateway.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageTelephonyTransferCall : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The phone number to transfer the call to in [E.164
        /// format](https://en.wikipedia.org/wiki/E.164). We currently only allow transferring to US numbers
        /// (+1xxxyyyzzzz).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("phoneNumber")]
        public virtual string PhoneNumber { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The text response message.</summary>
    public class GoogleCloudDialogflowV2beta1IntentMessageText : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The collection of the agent's responses.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual System.Collections.Generic.IList<string> Text { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents intent parameters.</summary>
    public class GoogleCloudDialogflowV2beta1IntentParameter : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The default value to use when the `value` yields an empty result. Default values can be
        /// extracted from contexts by using the following syntax: `#context_name.parameter_name`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("defaultValue")]
        public virtual string DefaultValue { get; set; } 

        /// <summary>Required. The name of the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Optional. The name of the entity type, prefixed with `@`, that describes values of the parameter.
        /// If the parameter is required, this must be provided.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityTypeDisplayName")]
        public virtual string EntityTypeDisplayName { get; set; } 

        /// <summary>Optional. Indicates whether the parameter represents a list of values.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isList")]
        public virtual System.Nullable<bool> IsList { get; set; } 

        /// <summary>Optional. Indicates whether the parameter is required. That is, whether the intent cannot be
        /// completed without collecting the parameter value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mandatory")]
        public virtual System.Nullable<bool> Mandatory { get; set; } 

        /// <summary>The unique identifier of this parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Optional. The collection of prompts that the agent can present to the user in order to collect a
        /// value for the parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("prompts")]
        public virtual System.Collections.Generic.IList<string> Prompts { get; set; } 

        /// <summary>Optional. The definition of the parameter value. It can be: - a constant string, - a parameter
        /// value defined as `$parameter_name`, - an original parameter value defined as `$parameter_name.original`, - a
        /// parameter value from some context defined as `#context_name.parameter_name`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents an example that the agent is trained on.</summary>
    public class GoogleCloudDialogflowV2beta1IntentTrainingPhrase : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The unique identifier of this training phrase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Required. The ordered list of training phrase parts. The parts are concatenated in order to form
        /// the training phrase. Note: The API does not automatically annotate training phrases like the Dialogflow
        /// Console does. Note: Do not forget to include whitespace at part boundaries, so the training phrase is well
        /// formatted when the parts are concatenated. If the training phrase does not need to be annotated with
        /// parameters, you just need a single part with only the Part.text field set. If you want to annotate the
        /// training phrase, you must create multiple parts, where the fields of each part are populated in one of two
        /// ways: - `Part.text` is set to a part of the phrase that has no parameters. - `Part.text` is set to a part of
        /// the phrase that you want to annotate, and the `entity_type`, `alias`, and `user_defined` fields are all
        /// set.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parts")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentTrainingPhrasePart> Parts { get; set; } 

        /// <summary>Optional. Indicates how many times this example was added to the intent. Each time a developer adds
        /// an existing sample by editing an intent or training, this counter is increased.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("timesAddedCount")]
        public virtual System.Nullable<int> TimesAddedCount { get; set; } 

        /// <summary>Required. The type of the training phrase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents a part of a training phrase.</summary>
    public class GoogleCloudDialogflowV2beta1IntentTrainingPhrasePart : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. The parameter name for the value extracted from the annotated part of the example. This
        /// field is required for annotated parts of the training phrase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alias")]
        public virtual string Alias { get; set; } 

        /// <summary>Optional. The entity type name prefixed with `@`. This field is required for annotated parts of the
        /// training phrase.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityType")]
        public virtual string EntityType { get; set; } 

        /// <summary>Required. The text for this part.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("text")]
        public virtual string Text { get; set; } 

        /// <summary>Optional. Indicates whether the text was manually annotated. This field is set to true when the
        /// Dialogflow Console is used to manually annotate the part. When creating an annotated part with the API, you
        /// must set this to true.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userDefined")]
        public virtual System.Nullable<bool> UserDefined { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the result of querying a Knowledge base.</summary>
    public class GoogleCloudDialogflowV2beta1KnowledgeAnswers : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of answers from Knowledge Connector.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("answers")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1KnowledgeAnswersAnswer> Answers { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An answer from Knowledge Connector.</summary>
    public class GoogleCloudDialogflowV2beta1KnowledgeAnswersAnswer : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The piece of text from the `source` knowledge base document that answers this conversational
        /// query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("answer")]
        public virtual string Answer { get; set; } 

        /// <summary>The corresponding FAQ question if the answer was extracted from a FAQ Document, empty
        /// otherwise.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("faqQuestion")]
        public virtual string FaqQuestion { get; set; } 

        /// <summary>The system's confidence score that this Knowledge answer is a good match for this conversational
        /// query. The range is from 0.0 (completely uncertain) to 1.0 (completely certain). Note: The confidence score
        /// is likely to vary somewhat (possibly even for identical requests), as the underlying model is under constant
        /// improvement. It may be deprecated in the future. We recommend using `match_confidence_level` which should be
        /// generally more stable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchConfidence")]
        public virtual System.Nullable<float> MatchConfidence { get; set; } 

        /// <summary>The system's confidence level that this knowledge answer is a good match for this conversational
        /// query. NOTE: The confidence level for a given `` pair may change without notice, as it depends on models
        /// that are constantly being improved. However, it will change less frequently than the confidence score below,
        /// and should be preferred for referencing the quality of an answer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("matchConfidenceLevel")]
        public virtual string MatchConfidenceLevel { get; set; } 

        /// <summary>Indicates which Knowledge Document this answer was extracted from. Format:
        /// `projects//knowledgeBases//documents/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata in google::longrunning::Operation for Knowledge operations.</summary>
    public class GoogleCloudDialogflowV2beta1KnowledgeOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Output only. The current state of this operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response for ConversationDatasets.LabelConversation.</summary>
    public class GoogleCloudDialogflowV2beta1LabelConversationResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>New annotated conversation dataset created by the labeling task.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("annotatedConversationDataset")]
        public virtual GoogleCloudDialogflowV2beta1AnnotatedConversationDataset AnnotatedConversationDataset { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the contents of the original request that was passed to the `[Streaming]DetectIntent`
    /// call.</summary>
    public class GoogleCloudDialogflowV2beta1OriginalDetectIntentRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. This field is set to the value of the `QueryParameters.payload` field passed in the
        /// request. Some integrations that query a Dialogflow agent may provide additional information in the payload.
        /// In particular, for the Dialogflow Phone Gateway integration, this field has the form: { "telephony": {
        /// "caller_id": "+18558363987" } } Note: The caller ID field (`caller_id`) will be redacted for Standard
        /// Edition agents and populated with the caller ID in [E.164 format](https://en.wikipedia.org/wiki/E.164) for
        /// Enterprise Edition agents.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string,object> Payload { get; set; } 

        /// <summary>The source of this request, e.g., `google`, `facebook`, `slack`. It is set by Dialogflow-owned
        /// servers.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; } 

        /// <summary>Optional. The version of the protocol used for this request. This field is AoG-specific.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the result of conversational query or event processing.</summary>
    public class GoogleCloudDialogflowV2beta1QueryResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The action name from the matched intent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; } 

        /// <summary>This field is set to: - `false` if the matched intent has required parameters and not all of the
        /// required parameter values have been collected. - `true` if all required parameter values have been
        /// collected, or if the matched intent doesn't contain any required parameters.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allRequiredParamsPresent")]
        public virtual System.Nullable<bool> AllRequiredParamsPresent { get; set; } 

        /// <summary>Free-form diagnostic information for the associated detect intent request. The fields of this data
        /// can change without notice, so you should not write code that depends on its structure. The data may contain:
        /// - webhook call latency - webhook errors</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("diagnosticInfo")]
        public virtual System.Collections.Generic.IDictionary<string,object> DiagnosticInfo { get; set; } 

        /// <summary>The collection of rich messages to present to the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fulfillmentMessages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessage> FulfillmentMessages { get; set; } 

        /// <summary>The text to be pronounced to the user or shown on the screen. Note: This is a legacy field,
        /// `fulfillment_messages` should be preferred.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fulfillmentText")]
        public virtual string FulfillmentText { get; set; } 

        /// <summary>The intent that matched the conversational query. Some, not all fields are filled in this message,
        /// including but not limited to: `name`, `display_name`, `end_interaction` and `is_fallback`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intent")]
        public virtual GoogleCloudDialogflowV2beta1Intent Intent { get; set; } 

        /// <summary>The intent detection confidence. Values range from 0.0 (completely uncertain) to 1.0 (completely
        /// certain). This value is for informational purpose only and is only used to help match the best intent within
        /// the classification threshold. This value may change for the same end-user expression at any time due to a
        /// model retraining or change in implementation. If there are `multiple knowledge_answers` messages, this value
        /// is set to the greatest `knowledgeAnswers.match_confidence` value in the list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("intentDetectionConfidence")]
        public virtual System.Nullable<float> IntentDetectionConfidence { get; set; } 

        /// <summary>The result from Knowledge Connector (if any), ordered by decreasing
        /// `KnowledgeAnswers.match_confidence`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("knowledgeAnswers")]
        public virtual GoogleCloudDialogflowV2beta1KnowledgeAnswers KnowledgeAnswers { get; set; } 

        /// <summary>The language that was triggered during intent detection. See [Language
        /// Support](https://cloud.google.com/dialogflow/docs/reference/language) for a list of the currently supported
        /// language codes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languageCode")]
        public virtual string LanguageCode { get; set; } 

        /// <summary>The collection of output contexts. If applicable, `output_contexts.parameters` contains entries
        /// with name `.original` containing the original parameter values before the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputContexts")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1Context> OutputContexts { get; set; } 

        /// <summary>The collection of extracted parameters. Depending on your protocol or client library language, this
        /// is a map, associative array, symbol table, dictionary, or JSON object composed of a collection of (MapKey,
        /// MapValue) pairs: - MapKey type: string - MapKey value: parameter name - MapValue type: - If parameter's
        /// entity type is a composite entity: map - Else: string or number, depending on parameter value type -
        /// MapValue value: - If parameter's entity type is a composite entity: map from composite entity property names
        /// to property values - Else: parameter value</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
        public virtual System.Collections.Generic.IDictionary<string,object> Parameters { get; set; } 

        /// <summary>The original conversational query text: - If natural language text was provided as input,
        /// `query_text` contains a copy of the input. - If natural language speech audio was provided as input,
        /// `query_text` contains the speech recognition result. If speech recognizer produced multiple alternatives, a
        /// particular one is picked. - If automatic spell correction is enabled, `query_text` will contain the
        /// corrected user input.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryText")]
        public virtual string QueryText { get; set; } 

        /// <summary>The sentiment analysis result, which depends on the `sentiment_analysis_request_config` specified
        /// in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sentimentAnalysisResult")]
        public virtual GoogleCloudDialogflowV2beta1SentimentAnalysisResult SentimentAnalysisResult { get; set; } 

        /// <summary>The Speech recognition confidence between 0.0 and 1.0. A higher number indicates an estimated
        /// greater likelihood that the recognized words are correct. The default of 0.0 is a sentinel value indicating
        /// that confidence was not set. This field is not guaranteed to be accurate or set. In particular this field
        /// isn't set for StreamingDetectIntent since the streaming endpoint has separate confidence estimates per
        /// portion of the audio in StreamingRecognitionResult.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("speechRecognitionConfidence")]
        public virtual System.Nullable<float> SpeechRecognitionConfidence { get; set; } 

        /// <summary>If the query was fulfilled by a webhook call, this field is set to the value of the `payload` field
        /// returned in the webhook response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookPayload")]
        public virtual System.Collections.Generic.IDictionary<string,object> WebhookPayload { get; set; } 

        /// <summary>If the query was fulfilled by a webhook call, this field is set to the value of the `source` field
        /// returned in the webhook response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("webhookSource")]
        public virtual string WebhookSource { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The sentiment, such as positive/negative feeling or association, for a unit of analysis, such as the
    /// query text.</summary>
    public class GoogleCloudDialogflowV2beta1Sentiment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A non-negative number in the [0, +inf) range, which represents the absolute magnitude of sentiment,
        /// regardless of score (positive or negative).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("magnitude")]
        public virtual System.Nullable<float> Magnitude { get; set; } 

        /// <summary>Sentiment score between -1.0 (negative sentiment) and 1.0 (positive sentiment).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("score")]
        public virtual System.Nullable<float> Score { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The result of sentiment analysis. Sentiment analysis inspects user input and identifies the prevailing
    /// subjective opinion, especially to determine a user's attitude as positive, negative, or neutral. For
    /// Participants.AnalyzeContent, it needs to be configured in DetectIntentRequest.query_params. For
    /// Participants.StreamingAnalyzeContent, it needs to be configured in StreamingDetectIntentRequest.query_params.
    /// And for Participants.AnalyzeContent and Participants.StreamingAnalyzeContent, it needs to be configured in
    /// ConversationProfile.human_agent_assistant_config</summary>
    public class GoogleCloudDialogflowV2beta1SentimentAnalysisResult : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The sentiment analysis result for `query_text`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryTextSentiment")]
        public virtual GoogleCloudDialogflowV2beta1Sentiment QueryTextSentiment { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A session represents a conversation between a Dialogflow agent and an end-user. You can create special
    /// entities, called session entities, during a session. Session entities can extend or replace custom entity types
    /// and only exist during the session that they were created for. All session data, including session entities, is
    /// stored by Dialogflow for 20 minutes. For more information, see the [session entity
    /// guide](https://cloud.google.com/dialogflow/docs/entities-session).</summary>
    public class GoogleCloudDialogflowV2beta1SessionEntityType : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The collection of entities associated with this session entity type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entities")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1EntityTypeEntity> Entities { get; set; } 

        /// <summary>Required. Indicates whether the additional data should override or supplement the custom entity
        /// type definition.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("entityOverrideMode")]
        public virtual string EntityOverrideMode { get; set; } 

        /// <summary>Required. The unique identifier of this session entity type. Format:
        /// `projects//agent/sessions//entityTypes/`, or `projects//agent/environments//users//sessions//entityTypes/`.
        /// If `Environment ID` is not specified, we assume default 'draft' environment. If `User ID` is not specified,
        /// we assume default '-' user. `` must be the display name of an existing entity type in the same agent that
        /// will be overridden or supplemented.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The request message for a webhook call.</summary>
    public class GoogleCloudDialogflowV2beta1WebhookRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Alternative query results from KnowledgeService.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternativeQueryResults")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1QueryResult> AlternativeQueryResults { get; set; } 

        /// <summary>Optional. The contents of the original request that was passed to `[Streaming]DetectIntent`
        /// call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("originalDetectIntentRequest")]
        public virtual GoogleCloudDialogflowV2beta1OriginalDetectIntentRequest OriginalDetectIntentRequest { get; set; } 

        /// <summary>The result of the conversational query or event processing. Contains the same value as
        /// `[Streaming]DetectIntentResponse.query_result`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("queryResult")]
        public virtual GoogleCloudDialogflowV2beta1QueryResult QueryResult { get; set; } 

        /// <summary>The unique identifier of the response. Contains the same value as
        /// `[Streaming]DetectIntentResponse.response_id`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseId")]
        public virtual string ResponseId { get; set; } 

        /// <summary>The unique identifier of detectIntent request session. Can be used to identify end-user inside
        /// webhook implementation. Format: `projects//agent/sessions/`, or
        /// `projects//agent/environments//users//sessions/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("session")]
        public virtual string Session { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for a webhook call. This response is validated by the Dialogflow server. If
    /// validation fails, an error will be returned in the QueryResult.diagnostic_info field. Setting JSON fields to an
    /// empty value with the wrong type is a common error. To avoid this error: - Use `""` for empty strings - Use `{}`
    /// or `null` for empty objects - Use `[]` or `null` for empty arrays For more information, see the [Protocol
    /// Buffers Language Guide](https://developers.google.com/protocol-buffers/docs/proto3#json).</summary>
    public class GoogleCloudDialogflowV2beta1WebhookResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Indicates that this intent ends an interaction. Some integrations (e.g., Actions on
        /// Google or Dialogflow phone gateway) use this information to close interaction with an end user. Default is
        /// false.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endInteraction")]
        public virtual System.Nullable<bool> EndInteraction { get; set; } 

        /// <summary>Optional. Invokes the supplied events. When this field is set, Dialogflow ignores the
        /// `fulfillment_text`, `fulfillment_messages`, and `payload` fields.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("followupEventInput")]
        public virtual GoogleCloudDialogflowV2beta1EventInput FollowupEventInput { get; set; } 

        /// <summary>Optional. The rich response messages intended for the end-user. When provided, Dialogflow uses this
        /// field to populate QueryResult.fulfillment_messages sent to the integration or API caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fulfillmentMessages")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1IntentMessage> FulfillmentMessages { get; set; } 

        /// <summary>Optional. The text response message intended for the end-user. It is recommended to use
        /// `fulfillment_messages.text.text[0]` instead. When provided, Dialogflow uses this field to populate
        /// QueryResult.fulfillment_text sent to the integration or API caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("fulfillmentText")]
        public virtual string FulfillmentText { get; set; } 

        /// <summary>Optional. The collection of output contexts that will overwrite currently active contexts for the
        /// session and reset their lifespans. When provided, Dialogflow uses this field to populate
        /// QueryResult.output_contexts sent to the integration or API caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputContexts")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1Context> OutputContexts { get; set; } 

        /// <summary>Optional. This field can be used to pass custom data from your webhook to the integration or API
        /// caller. Arbitrary JSON objects are supported. When provided, Dialogflow uses this field to populate
        /// QueryResult.webhook_payload sent to the integration or API caller. This field is also used by the [Google
        /// Assistant integration](https://cloud.google.com/dialogflow/docs/integrations/aog) for rich response
        /// messages. See the format definition at [Google Assistant Dialogflow webhook
        /// format](https://developers.google.com/assistant/actions/build/json/dialogflow-webhook-json)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("payload")]
        public virtual System.Collections.Generic.IDictionary<string,object> Payload { get; set; } 

        /// <summary>Optional. Additional session entity types to replace or extend developer entity types with. The
        /// entity synonyms apply to all languages and persist for the session. Setting this data from a webhook
        /// overwrites the session entity types that have been set using `detectIntent`, `streamingDetectIntent` or
        /// SessionEntityType management methods.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sessionEntityTypes")]
        public virtual System.Collections.Generic.IList<GoogleCloudDialogflowV2beta1SessionEntityType> SessionEntityTypes { get; set; } 

        /// <summary>Optional. A custom field used to identify the webhook source. Arbitrary strings are supported. When
        /// provided, Dialogflow uses this field to populate QueryResult.webhook_source sent to the integration or API
        /// caller.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Metadata associated with the long running operation for Versions.CreateVersion.</summary>
    public class GoogleCloudDialogflowV3alpha1CreateVersionOperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name of the created version. Format: `projects//locations//agents//flows//versions/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Agents.ExportAgent.</summary>
    public class GoogleCloudDialogflowV3alpha1ExportAgentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Uncompressed raw byte content for agent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentContent")]
        public virtual string AgentContent { get; set; } 

        /// <summary>The URI to a file containing the exported agent. This field is populated only if `agent_uri` is
        /// specified in ExportAgentRequest.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agentUri")]
        public virtual string AgentUri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Agents.ImportAgent.</summary>
    public class GoogleCloudDialogflowV3alpha1ImportAgentResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The unique identifier of the new agent. Format: `projects//locations//agents/`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("agent")]
        public virtual string Agent { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Operations.ListOperations.</summary>
    public class GoogleLongrunningListOperationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The standard List next-page token.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>A list of operations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("operations")]
        public virtual System.Collections.Generic.IList<GoogleLongrunningOperation> Operations { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This resource represents a long-running operation that is the result of a network API call.</summary>
    public class GoogleLongrunningOperation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If the value is `false`, it means the operation is still in progress. If `true`, the operation is
        /// completed, and either `error` or `response` is available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("done")]
        public virtual System.Nullable<bool> Done { get; set; } 

        /// <summary>The error result of the operation in case of failure or cancellation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual GoogleRpcStatus Error { get; set; } 

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

    /// <summary>A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A
    /// typical example is to use it as the request or the response type of an API method. For instance: service Foo {
    /// rpc Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty
    /// JSON object `{}`.</summary>
    public class GoogleProtobufEmpty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The `Status` type defines a logical error model that is suitable for different programming
    /// environments, including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status`
    /// message contains three pieces of data: error code, error message, and error details. You can find out more about
    /// this error model and how to work with it in the [API Design
    /// Guide](https://cloud.google.com/apis/design/errors).</summary>
    public class GoogleRpcStatus : Google.Apis.Requests.IDirectResponseSchema
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

    /// <summary>An object representing a latitude/longitude pair. This is expressed as a pair of doubles representing
    /// degrees latitude and degrees longitude. Unless specified otherwise, this must conform to the WGS84 standard.
    /// Values must be within normalized ranges.</summary>
    public class GoogleTypeLatLng : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The latitude in degrees. It must be in the range [-90.0, +90.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("latitude")]
        public virtual System.Nullable<double> Latitude { get; set; } 

        /// <summary>The longitude in degrees. It must be in the range [-180.0, +180.0].</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("longitude")]
        public virtual System.Nullable<double> Longitude { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
