// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.CloudRedis.v1
{
    /// <summary>The CloudRedis Service.</summary>
    public class CloudRedisService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudRedisService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudRedisService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "redis";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://redis.googleapis.com/";
        #else
            "https://redis.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://redis.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Google Cloud Memorystore for Redis API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Google Cloud Memorystore for Redis API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

        }



        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    ///<summary>A base abstract class for CloudRedis requests.</summary>
    public abstract class CloudRedisBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new CloudRedisBaseServiceRequest instance.</summary>
        protected CloudRedisBaseServiceRequest(Google.Apis.Services.IClientService service)
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

        /// <summary>Initializes CloudRedis parameter list.</summary>
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
                Instances = new InstancesResource(service);
                Operations = new OperationsResource(service);

            }

            /// <summary>Gets the Instances resource.</summary>
            public virtual InstancesResource Instances { get; }

            /// <summary>The "instances" collection of methods.</summary>
            public class InstancesResource
            {
                private const string Resource = "instances";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public InstancesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Creates a Redis instance based on the specified tier and memory size. By default, the
                /// instance is accessible from the project's [default network](https://cloud.google.com/vpc/docs/vpc).
                /// The creation is executed asynchronously and callers may check the returned operation to track its
                /// progress. Once the operation is completed the Redis instance will be fully functional. Completed
                /// longrunning.Operation will contain the new instance object in the response field. The returned
                /// operation is automatically deleted after a few hours, so there is no need to call
                /// DeleteOperation.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">Required. The resource name of the instance location using the form:
                /// `projects/{project_id}/locations/{location_id}` where `location_id` refers to a GCP region.</param>
                public virtual CreateRequest Create(Google.Apis.CloudRedis.v1.Data.Instance body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a Redis instance based on the specified tier and memory size. By default, the
                /// instance is accessible from the project's [default network](https://cloud.google.com/vpc/docs/vpc).
                /// The creation is executed asynchronously and callers may check the returned operation to track its
                /// progress. Once the operation is completed the Redis instance will be fully functional. Completed
                /// longrunning.Operation will contain the new instance object in the response field. The returned
                /// operation is automatically deleted after a few hours, so there is no need to call
                /// DeleteOperation.</summary>
                public class CreateRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.Instance body, string parent)
                        : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. The resource name of the instance location using the form:
                    /// `projects/{project_id}/locations/{location_id}` where `location_id` refers to a GCP
                    /// region.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Required. The logical name of the Redis instance in the customer project with the
                    /// following restrictions: * Must contain only lowercase letters, numbers, and hyphens. * Must
                    /// start with a letter. * Must be between 1-40 characters. * Must end with a number or a letter. *
                    /// Must be unique within the customer project / location</summary>
                    [Google.Apis.Util.RequestParameterAttribute("instanceId", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string InstanceId { get; set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRedis.v1.Data.Instance Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/instances";

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
                        RequestParameters.Add(
                            "instanceId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "instanceId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                    }

                }

                /// <summary>Deletes a specific Redis instance. Instance stops serving and data is deleted.</summary>
                /// <param name="name">Required. Redis instance resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id` refers to a GCP
                /// region.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a specific Redis instance. Instance stops serving and data is deleted.</summary>
                public class DeleteRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                        : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }


                    /// <summary>Required. Redis instance resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id`
                    /// refers to a GCP region.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                            });
                    }

                }

                /// <summary>Export Redis instance data into a Redis RDB format file in Cloud Storage. Redis will
                /// continue serving during this operation. The returned operation is automatically deleted after a few
                /// hours, so there is no need to call DeleteOperation.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. Redis instance resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id` refers to a GCP
                /// region.</param>
                public virtual ExportRequest Export(Google.Apis.CloudRedis.v1.Data.ExportInstanceRequest body, string name)
                {
                    return new ExportRequest(service, body, name);
                }

                /// <summary>Export Redis instance data into a Redis RDB format file in Cloud Storage. Redis will
                /// continue serving during this operation. The returned operation is automatically deleted after a few
                /// hours, so there is no need to call DeleteOperation.</summary>
                public class ExportRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Export request.</summary>
                    public ExportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.ExportInstanceRequest body, string name)
                        : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. Redis instance resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id`
                    /// refers to a GCP region.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRedis.v1.Data.ExportInstanceRequest Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "export";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:export";

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                            });
                    }

                }

                /// <summary>Initiates a failover of the master node to current replica node for a specific STANDARD
                /// tier Cloud Memorystore for Redis instance.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. Redis instance resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id` refers to a GCP
                /// region.</param>
                public virtual FailoverRequest Failover(Google.Apis.CloudRedis.v1.Data.FailoverInstanceRequest body, string name)
                {
                    return new FailoverRequest(service, body, name);
                }

                /// <summary>Initiates a failover of the master node to current replica node for a specific STANDARD
                /// tier Cloud Memorystore for Redis instance.</summary>
                public class FailoverRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Failover request.</summary>
                    public FailoverRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.FailoverInstanceRequest body, string name)
                        : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. Redis instance resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id`
                    /// refers to a GCP region.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRedis.v1.Data.FailoverInstanceRequest Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "failover";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:failover";

                    /// <summary>Initializes Failover parameter list.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                            });
                    }

                }

                /// <summary>Gets the details of a specific Redis instance.</summary>
                /// <param name="name">Required. Redis instance resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id` refers to a GCP
                /// region.</param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets the details of a specific Redis instance.</summary>
                public class GetRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Instance>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name)
                        : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }


                    /// <summary>Required. Redis instance resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id`
                    /// refers to a GCP region.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                            });
                    }

                }

                /// <summary>Import a Redis RDB snapshot file from Cloud Storage into a Redis instance. Redis may stop
                /// serving during this operation. Instance state will be IMPORTING for entire operation. When complete,
                /// the instance will contain only data from the imported file. The returned operation is automatically
                /// deleted after a few hours, so there is no need to call DeleteOperation.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. Redis instance resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id` refers to a GCP
                /// region.</param>
                public virtual ImportRequest Import(Google.Apis.CloudRedis.v1.Data.ImportInstanceRequest body, string name)
                {
                    return new ImportRequest(service, body, name);
                }

                /// <summary>Import a Redis RDB snapshot file from Cloud Storage into a Redis instance. Redis may stop
                /// serving during this operation. Instance state will be IMPORTING for entire operation. When complete,
                /// the instance will contain only data from the imported file. The returned operation is automatically
                /// deleted after a few hours, so there is no need to call DeleteOperation.</summary>
                public class ImportRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Import request.</summary>
                    public ImportRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.ImportInstanceRequest body, string name)
                        : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. Redis instance resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id`
                    /// refers to a GCP region.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRedis.v1.Data.ImportInstanceRequest Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "import";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:import";

                    /// <summary>Initializes Import parameter list.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
                            });
                    }

                }

                /// <summary>Lists all Redis instances owned by a project in either the specified location (region) or
                /// all locations. The location should have the following format: *
                /// `projects/{project_id}/locations/{location_id}` If `location_id` is specified as `-` (wildcard),
                /// then all regions available to the project are queried, and the results are aggregated.</summary>
                /// <param name="parent">Required. The resource name of the instance location using the form:
                /// `projects/{project_id}/locations/{location_id}` where `location_id` refers to a GCP region.</param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists all Redis instances owned by a project in either the specified location (region) or
                /// all locations. The location should have the following format: *
                /// `projects/{project_id}/locations/{location_id}` If `location_id` is specified as `-` (wildcard),
                /// then all regions available to the project are queried, and the results are aggregated.</summary>
                public class ListRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.ListInstancesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent)
                        : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }


                    /// <summary>Required. The resource name of the instance location using the form:
                    /// `projects/{project_id}/locations/{location_id}` where `location_id` refers to a GCP
                    /// region.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>The maximum number of items to return. If not specified, a default value of 1000 will
                    /// be used by the service. Regardless of the page_size value, the response may include a partial
                    /// list and a caller should only rely on response's `next_page_token` to determine if there are
                    /// more instances left to be queried.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The `next_page_token` value returned from a previous ListInstances request, if
                    /// any.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/instances";

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

                /// <summary>Updates the metadata and configuration of a specific Redis instance. Completed
                /// longrunning.Operation will contain the new instance object in the response field. The returned
                /// operation is automatically deleted after a few hours, so there is no need to call
                /// DeleteOperation.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. Unique name of the resource in this scope including project and location using the
                /// form: `projects/{project_id}/locations/{location_id}/instances/{instance_id}` Note: Redis instances are managed and
                /// addressed at regional level so location_id here refers to a GCP region; however, users may choose which specific
                /// zone (or collection of zones for cross-zone instances) an instance should be provisioned in. Refer to location_id
                /// and alternative_location_id fields for more details.</param>
                public virtual PatchRequest Patch(Google.Apis.CloudRedis.v1.Data.Instance body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates the metadata and configuration of a specific Redis instance. Completed
                /// longrunning.Operation will contain the new instance object in the response field. The returned
                /// operation is automatically deleted after a few hours, so there is no need to call
                /// DeleteOperation.</summary>
                public class PatchRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.Instance body, string name)
                        : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. Unique name of the resource in this scope including project and location
                    /// using the form: `projects/{project_id}/locations/{location_id}/instances/{instance_id}` Note:
                    /// Redis instances are managed and addressed at regional level so location_id here refers to a GCP
                    /// region; however, users may choose which specific zone (or collection of zones for cross-zone
                    /// instances) an instance should be provisioned in. Refer to location_id and
                    /// alternative_location_id fields for more details.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Required. Mask of fields to update. At least one path must be supplied in this field.
                    /// The elements of the repeated paths field may only include these fields from Instance: *
                    /// `displayName` * `labels` * `memorySizeGb` * `redisConfig`</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRedis.v1.Data.Instance Body { get; set; }

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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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

                /// <summary>Upgrades Redis instance to the newer Redis version specified in the request.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">Required. Redis instance resource name using the form:
                /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id` refers to a GCP
                /// region.</param>
                public virtual UpgradeRequest Upgrade(Google.Apis.CloudRedis.v1.Data.UpgradeInstanceRequest body, string name)
                {
                    return new UpgradeRequest(service, body, name);
                }

                /// <summary>Upgrades Redis instance to the newer Redis version specified in the request.</summary>
                public class UpgradeRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
                {
                    /// <summary>Constructs a new Upgrade request.</summary>
                    public UpgradeRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudRedis.v1.Data.UpgradeInstanceRequest body, string name)
                        : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }


                    /// <summary>Required. Redis instance resource name using the form:
                    /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` where `location_id`
                    /// refers to a GCP region.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }


                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudRedis.v1.Data.UpgradeInstanceRequest Body { get; set; }

                    ///<summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "upgrade";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}:upgrade";

                    /// <summary>Initializes Upgrade parameter list.</summary>
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
                                Pattern = @"^projects/[^/]+/locations/[^/]+/instances/[^/]+$",
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
                public class CancelRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Empty>
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
                    public override string RestPath => "v1/{+name}:cancel";

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

                /// <summary>Deletes a long-running operation. This method indicates that the client is no longer
                /// interested in the operation result. It does not cancel the operation. If the server doesn't support
                /// this method, it returns `google.rpc.Code.UNIMPLEMENTED`.</summary>
                /// <param name="name">The name of the operation resource to be deleted.</param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a long-running operation. This method indicates that the client is no longer
                /// interested in the operation result. It does not cancel the operation. If the server doesn't support
                /// this method, it returns `google.rpc.Code.UNIMPLEMENTED`.</summary>
                public class DeleteRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name)
                        : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }


                    /// <summary>The name of the operation resource to be deleted.</summary>
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
                public class GetRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Operation>
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
                public class ListRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.ListOperationsResponse>
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
                    public override string RestPath => "v1/{+name}/operations";

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

            /// <summary>Gets information about a location.</summary>
            /// <param name="name">Resource name for the location.</param>
            public virtual GetRequest Get(string name)
            {
                return new GetRequest(service, name);
            }

            /// <summary>Gets information about a location.</summary>
            public class GetRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.Location>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string name)
                    : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>Resource name for the location.</summary>
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
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                }

            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            /// <param name="name">The resource that owns the locations collection, if applicable.</param>
            public virtual ListRequest List(string name)
            {
                return new ListRequest(service, name);
            }

            /// <summary>Lists information about the supported locations for this service.</summary>
            public class ListRequest : CloudRedisBaseServiceRequest<Google.Apis.CloudRedis.v1.Data.ListLocationsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string name)
                    : base(service)
                {
                    Name = name;
                    InitParameters();
                }


                /// <summary>The resource that owns the locations collection, if applicable.</summary>
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
                public override string RestPath => "v1/{+name}/locations";

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

namespace Google.Apis.CloudRedis.v1.Data
{    

    /// <summary>A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A
    /// typical example is to use it as the request or the response type of an API method. For instance: service Foo {
    /// rpc Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty
    /// JSON object `{}`.</summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request for Export.</summary>
    public class ExportInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Specify data to be exported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("outputConfig")]
        public virtual OutputConfig OutputConfig { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request for Failover.</summary>
    public class FailoverInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Available data protection modes that the user can choose. If it's unspecified, data
        /// protection mode will be LIMITED_DATA_LOSS by default.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataProtectionMode")]
        public virtual string DataProtectionMode { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The Cloud Storage location for the output content</summary>
    public class GcsDestination : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Data destination URI (e.g. 'gs://my_bucket/my_object'). Existing files will be
        /// overwritten.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The Cloud Storage location for the input content</summary>
    public class GcsSource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Source data URI. (e.g. 'gs://my_bucket/my_object').</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>This location metadata represents additional configuration options for a given location where a Redis
    /// instance may be created. All fields are output only. It is returned as content of the
    /// `google.cloud.location.Location.metadata` field.</summary>
    public class GoogleCloudRedisV1LocationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Output only. The set of available zones in the location. The map is keyed by the lowercase ID of
        /// each zone, as defined by GCE. These keys can be specified in `location_id` or `alternative_location_id`
        /// fields when creating a Redis instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availableZones")]
        public virtual System.Collections.Generic.IDictionary<string,GoogleCloudRedisV1ZoneMetadata> AvailableZones { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Represents the v1 metadata of the long-running operation.</summary>
    public class GoogleCloudRedisV1OperationMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>API version.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("apiVersion")]
        public virtual string ApiVersion { get; set; } 

        /// <summary>Specifies if cancellation was requested for the operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cancelRequested")]
        public virtual System.Nullable<bool> CancelRequested { get; set; } 

        /// <summary>Creation timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>End timestamp.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; } 

        /// <summary>Operation status details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusDetail")]
        public virtual string StatusDetail { get; set; } 

        /// <summary>Operation target.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; } 

        /// <summary>Operation verb.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Defines specific information for a particular zone. Currently empty and reserved for future use
    /// only.</summary>
    public class GoogleCloudRedisV1ZoneMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class GoogleCloudSaasacceleratorManagementProvidersV1Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>consumer_defined_name is the name that is set by the consumer. On the other hand Name field
        /// represents system-assigned id of an instance so consumers are not necessarily aware of it.
        /// consumer_defined_name is used for notification/UI purposes for consumer to recognize their
        /// instances.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("consumerDefinedName")]
        public virtual string ConsumerDefinedName { get; set; } 

        /// <summary>Output only. Timestamp when the resource was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>Optional. Resource labels to represent user provided metadata. Each label is a key-value pair,
        /// where both the key and the value are arbitrary strings provided by the user.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string,string> Labels { get; set; } 

        /// <summary>The MaintenancePolicies that have been attached to the instance. The key must be of the type name
        /// of the oneof policy name defined in MaintenancePolicy, and the referenced policy must define the same policy
        /// type. For complete details of MaintenancePolicy, please refer to go/cloud-saas-mw-ug.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenancePolicyNames")]
        public virtual System.Collections.Generic.IDictionary<string,string> MaintenancePolicyNames { get; set; } 

        /// <summary>The MaintenanceSchedule contains the scheduling information of published maintenance
        /// schedule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceSchedules")]
        public virtual System.Collections.Generic.IDictionary<string,GoogleCloudSaasacceleratorManagementProvidersV1MaintenanceSchedule> MaintenanceSchedules { get; set; } 

        /// <summary>Optional. The MaintenanceSettings associated with instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maintenanceSettings")]
        public virtual GoogleCloudSaasacceleratorManagementProvidersV1MaintenanceSettings MaintenanceSettings { get; set; } 

        /// <summary>Unique name of the resource. It uses the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. Custom string attributes used primarily to expose producer-specific information in
        /// monitoring dashboards. See go/get-instance-metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("producerMetadata")]
        public virtual System.Collections.Generic.IDictionary<string,string> ProducerMetadata { get; set; } 

        /// <summary>Output only. The list of data plane resources provisioned for this instance, e.g. compute VMs. See
        /// go/get-instance-metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("provisionedResources")]
        public virtual System.Collections.Generic.IList<GoogleCloudSaasacceleratorManagementProvidersV1ProvisionedResource> ProvisionedResources { get; set; } 

        /// <summary>Link to the SLM instance template. Only populated when updating SLM instances via SSA's Actuation
        /// service adaptor. Service producers with custom control plane (e.g. Cloud SQL) doesn't need to populate this
        /// field. Instead they should use software_versions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("slmInstanceTemplate")]
        public virtual string SlmInstanceTemplate { get; set; } 

        /// <summary>Output only. SLO metadata for instance classification in the Standardized dataplane SLO platform.
        /// See go/cloud-ssa-standard-slo for feature description.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sloMetadata")]
        public virtual GoogleCloudSaasacceleratorManagementProvidersV1SloMetadata SloMetadata { get; set; } 

        /// <summary>Software versions that are used to deploy this instance. This can be mutated by rollout
        /// services.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("softwareVersions")]
        public virtual System.Collections.Generic.IDictionary<string,string> SoftwareVersions { get; set; } 

        /// <summary>Output only. Current lifecycle state of the resource (e.g. if it's being created or ready to
        /// use).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; } 

        /// <summary>Output only. ID of the associated GCP tenant project. See go/get-instance-metadata.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tenantProjectId")]
        public virtual string TenantProjectId { get; set; } 

        /// <summary>Output only. Timestamp when the resource was last modified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Maintenance schedule which is exposed to customer and potentially end user, indicating published
    /// upcoming future maintenance schedule</summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1MaintenanceSchedule : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Can this scheduled update be rescheduled? By default, it's true and API needs to do explicitly
        /// check whether it's set, if it's set as false explicitly, it's false</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canReschedule")]
        public virtual System.Nullable<bool> CanReschedule { get; set; } 

        /// <summary>The scheduled end time for the maintenance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; } 

        /// <summary>The rollout management policy this maintenance schedule is associated with. When doing reschedule
        /// update request, the reschedule should be against this given policy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rolloutManagementPolicy")]
        public virtual string RolloutManagementPolicy { get; set; } 

        /// <summary>The scheduled start time for the maintenance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Maintenance settings associated with instance. Allows service producers and end users to assign
    /// settings that controls maintenance on this instance.</summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1MaintenanceSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Exclude instance from maintenance. When true, rollout service will not attempt
        /// maintenance on the instance. Rollout service will include the instance in reported rollout progress as not
        /// attempted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclude")]
        public virtual System.Nullable<bool> Exclude { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Node information for custom per-node SLO implementations. SSA does not support per-node SLO, but
    /// producers can populate per-node information in SloMetadata for custom precomputations. SSA Eligibility Exporter
    /// will emit per-node metric based on this information.</summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1NodeSloMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>By default node is eligible if instance is eligible. But individual node might be excluded from SLO
        /// by adding entry here. For semantic see SloMetadata.exclusions. If both instance and node level exclusions
        /// are present for time period, the node level's reason will be reported by Eligibility Exporter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusions")]
        public virtual System.Collections.Generic.IList<GoogleCloudSaasacceleratorManagementProvidersV1SloExclusion> Exclusions { get; set; } 

        /// <summary>The location of the node, if different from instance location.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; } 

        /// <summary>The id of the node. This should be equal to SaasInstanceNode.node_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodeId")]
        public virtual string NodeId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Describes provisioned dataplane resources.</summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1ProvisionedResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Type of the resource. This can be either a GCP resource or a custom one (e.g. another cloud
        /// provider's VM). For GCP compute resources use singular form of the names listed in GCP compute API
        /// documentation (https://cloud.google.com/compute/docs/reference/rest/v1/), prefixed with 'compute-', for
        /// example: 'compute-instance', 'compute-disk', 'compute-autoscaler'.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; } 

        /// <summary>URL identifying the resource, e.g. "https://www.googleapis.com/compute/v1/projects/...)".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceUrl")]
        public virtual string ResourceUrl { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>SloEligibility is a tuple containing eligibility value: true if an instance is eligible for SLO
    /// calculation or false if it should be excluded from all SLO-related calculations along with a user-defined
    /// reason.</summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1SloEligibility : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Whether an instance is eligible or ineligible.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eligible")]
        public virtual System.Nullable<bool> Eligible { get; set; } 

        /// <summary>User-defined reason for the current value of instance eligibility. Usually, this can be directly
        /// mapped to the internal state. An empty reason is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>SloExclusion represents an exclusion in SLI calculation applies to all SLOs.</summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1SloExclusion : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Exclusion duration. No restrictions on the possible values. When an ongoing operation is taking
        /// longer than initially expected, an existing entry in the exclusion list can be updated by extending the
        /// duration. This is supported by the subsystem exporting eligibility data as long as such extension is
        /// committed at least 10 minutes before the original exclusion expiration - otherwise it is possible that there
        /// will be "gaps" in the exclusion application in the exported timeseries.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; } 

        /// <summary>Human-readable reason for the exclusion. This should be a static string (e.g. "Disruptive update in
        /// progress") and should not contain dynamically generated data (e.g. instance name). Can be left
        /// empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reason")]
        public virtual string Reason { get; set; } 

        /// <summary>Name of an SLI that this exclusion applies to. Can be left empty, signaling that the instance
        /// should be excluded from all SLIs defined in the service SLO configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sliName")]
        public virtual string SliName { get; set; } 

        /// <summary>Start time of the exclusion. No alignment (e.g. to a full minute) needed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>SloMetadata contains resources required for proper SLO classification of the instance.</summary>
    public class GoogleCloudSaasacceleratorManagementProvidersV1SloMetadata : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. User-defined instance eligibility.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eligibility")]
        public virtual GoogleCloudSaasacceleratorManagementProvidersV1SloEligibility Eligibility { get; set; } 

        /// <summary>List of SLO exclusion windows. When multiple entries in the list match (matching the exclusion
        /// time-window against current time point) the exclusion reason used in the first matching entry will be
        /// published. It is not needed to include expired exclusion in this list, as only the currently applicable
        /// exclusions are taken into account by the eligibility exporting subsystem (the historical state of exclusions
        /// will be reflected in the historically produced timeseries regardless of the current state). This field can
        /// be used to mark the instance as temporary ineligible for the purpose of SLO calculation. For permanent
        /// instance SLO exclusion, use of custom instance eligibility is recommended. See 'eligibility' field
        /// below.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exclusions")]
        public virtual System.Collections.Generic.IList<GoogleCloudSaasacceleratorManagementProvidersV1SloExclusion> Exclusions { get; set; } 

        /// <summary>Optional. List of nodes. Some producers need to use per-node metadata to calculate SLO. This field
        /// allows such producers to publish per-node SLO meta data, which will be consumed by SSA Eligibility Exporter
        /// and published in the form of per node metric to Monarch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<GoogleCloudSaasacceleratorManagementProvidersV1NodeSloMetadata> Nodes { get; set; } 

        /// <summary>Name of the SLO tier the Instance belongs to. This name will be expected to match the tiers
        /// specified in the service SLO configuration. Field is mandatory and must not be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request for Import.</summary>
    public class ImportInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Specify data to be imported.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("inputConfig")]
        public virtual InputConfig InputConfig { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The input content</summary>
    public class InputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Cloud Storage location where input content is located.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsSource")]
        public virtual GcsSource GcsSource { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A Google Cloud Redis instance.</summary>
    public class Instance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Optional. Only applicable to STANDARD_HA tier which protects the instance against zonal failures by
        /// provisioning it across two zones. If provided, it must be a different zone from the one provided in
        /// location_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("alternativeLocationId")]
        public virtual string AlternativeLocationId { get; set; } 

        /// <summary>Optional. The full name of the Google Compute Engine
        /// [network](https://cloud.google.com/vpc/docs/vpc) to which the instance is connected. If left unspecified,
        /// the `default` network will be used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("authorizedNetwork")]
        public virtual string AuthorizedNetwork { get; set; } 

        /// <summary>Optional. The network connect mode of the Redis instance. If not provided, the connect mode
        /// defaults to DIRECT_PEERING.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connectMode")]
        public virtual string ConnectMode { get; set; } 

        /// <summary>Output only. The time the instance was created.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; } 

        /// <summary>Output only. The current zone where the Redis endpoint is placed. For Basic Tier instances, this
        /// will always be the same as the location_id provided by the user at creation time. For Standard Tier
        /// instances, this can be either location_id or alternative_location_id and can change after a failover
        /// event.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("currentLocationId")]
        public virtual string CurrentLocationId { get; set; } 

        /// <summary>An arbitrary and optional user-provided name for the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Output only. Hostname or IP address of the exposed Redis endpoint used by clients to connect to the
        /// service.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("host")]
        public virtual string Host { get; set; } 

        /// <summary>Resource labels to represent user provided metadata</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string,string> Labels { get; set; } 

        /// <summary>Optional. The zone where the instance will be provisioned. If not provided, the service will choose
        /// a zone for the instance. For STANDARD_HA tier, instances will be created across two zones for protection
        /// against zonal failures. If alternative_location_id is also provided, it must be different from
        /// location_id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; } 

        /// <summary>Required. Redis memory size in GiB.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memorySizeGb")]
        public virtual System.Nullable<int> MemorySizeGb { get; set; } 

        /// <summary>Required. Unique name of the resource in this scope including project and location using the form:
        /// `projects/{project_id}/locations/{location_id}/instances/{instance_id}` Note: Redis instances are managed
        /// and addressed at regional level so location_id here refers to a GCP region; however, users may choose which
        /// specific zone (or collection of zones for cross-zone instances) an instance should be provisioned in. Refer
        /// to location_id and alternative_location_id fields for more details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Output only. Cloud IAM identity used by import / export operations to transfer data to/from Cloud
        /// Storage. Format is "serviceAccount:". The value may change over time for a given instance so should be
        /// checked before each import/export operation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("persistenceIamIdentity")]
        public virtual string PersistenceIamIdentity { get; set; } 

        /// <summary>Output only. The port number of the exposed Redis endpoint.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("port")]
        public virtual System.Nullable<int> Port { get; set; } 

        /// <summary>Optional. Redis configuration parameters, according to http://redis.io/topics/config. Currently,
        /// the only supported parameters are: Redis version 3.2 and newer: * maxmemory-policy * notify-keyspace-events
        /// Redis version 4.0 and newer: * activedefrag * lfu-decay-time * lfu-log-factor * maxmemory-gb Redis version
        /// 5.0 and newer: * stream-node-max-bytes * stream-node-max-entries</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redisConfigs")]
        public virtual System.Collections.Generic.IDictionary<string,string> RedisConfigs { get; set; } 

        /// <summary>Optional. The version of Redis software. If not provided, latest supported version will be used.
        /// Currently, the supported values are: * `REDIS_3_2` for Redis 3.2 compatibility * `REDIS_4_0` for Redis 4.0
        /// compatibility (default) * `REDIS_5_0` for Redis 5.0 compatibility</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redisVersion")]
        public virtual string RedisVersion { get; set; } 

        /// <summary>Optional. The CIDR range of internal addresses that are reserved for this instance. If not
        /// provided, the service will choose an unused /29 block, for example, 10.0.0.0/29 or 192.168.0.0/29. Ranges
        /// must be unique and non-overlapping with existing subnets in an authorized network.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("reservedIpRange")]
        public virtual string ReservedIpRange { get; set; } 

        /// <summary>Output only. The current state of this instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; } 

        /// <summary>Output only. Additional information about the current status of this instance, if
        /// available.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("statusMessage")]
        public virtual string StatusMessage { get; set; } 

        /// <summary>Required. The service tier of the instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for ListInstances.</summary>
    public class ListInstancesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of Redis instances in the project in the specified location, or across all locations. If the
        /// `location_id` in the parent field of the request is "-", all regions available to the project are queried,
        /// and the results aggregated. If in such an aggregated query a location is unavailable, a dummy Redis entry is
        /// included in the response with the `name` field set to a value of the form
        /// `projects/{project_id}/locations/{location_id}/instances/`- and the `status` field set to ERROR and
        /// `status_message` field set to "location not available for ListInstances".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("instances")]
        public virtual System.Collections.Generic.IList<Instance> Instances { get; set; } 

        /// <summary>Token to retrieve the next page of results, or empty if there are no more results in the
        /// list.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>Locations that could not be reached.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("unreachable")]
        public virtual System.Collections.Generic.IList<string> Unreachable { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for Locations.ListLocations.</summary>
    public class ListLocationsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of locations that matches the specified filter in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locations")]
        public virtual System.Collections.Generic.IList<Location> Locations { get; set; } 

        /// <summary>The standard List next-page token.</summary>
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

    /// <summary>A resource that represents Google Cloud Platform location.</summary>
    public class Location : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The friendly name for this location, typically a nearby city name. For example, "Tokyo".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; } 

        /// <summary>Cross-service attributes for the location. For example {"cloud.googleapis.com/region": "us-
        /// east1"}</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string,string> Labels { get; set; } 

        /// <summary>Resource ID for the region. For example: "us-east1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("locationId")]
        public virtual string LocationId { get; set; } 

        /// <summary>Output only. The set of available zones in the location. The map is keyed by the lowercase ID of
        /// each zone, as defined by Compute Engine. These keys can be specified in `location_id` or
        /// `alternative_location_id` fields when creating a Redis instance.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string,object> Metadata { get; set; } 

        /// <summary>Full resource name for the region. For example: "projects/example-project/locations/us-
        /// east1".</summary>
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

        /// <summary>{ `createTime`: The time the operation was created. `endTime`: The time the operation finished
        /// running. `target`: Server-defined resource path for the target of the operation. `verb`: Name of the verb
        /// executed by the operation. `statusDetail`: Human-readable status of the operation, if any.
        /// `cancelRequested`: Identifies whether the user has requested cancellation of the operation. Operations that
        /// have successfully been cancelled have Operation.error value with a google.rpc.Status.code of 1,
        /// corresponding to `Code.CANCELLED`. `apiVersion`: API version used to start the operation. }</summary>
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

    /// <summary>The output content</summary>
    public class OutputConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Google Cloud Storage destination for output content.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gcsDestination")]
        public virtual GcsDestination GcsDestination { get; set; } 

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

    /// <summary>Request for UpgradeInstance.</summary>
    public class UpgradeInstanceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. Specifies the target version of Redis software to upgrade to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("redisVersion")]
        public virtual string RedisVersion { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
