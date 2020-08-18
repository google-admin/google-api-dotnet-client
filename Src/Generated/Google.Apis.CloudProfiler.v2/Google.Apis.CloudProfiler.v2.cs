// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.CloudProfiler.v2
{
    /// <summary>The CloudProfiler Service.</summary>
    public class CloudProfilerService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudProfilerService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudProfilerService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudprofiler";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://cloudprofiler.googleapis.com/";
        #else
            "https://cloudprofiler.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudprofiler.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Stackdriver Profiler API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and write monitoring data for all of your Google and third-party Cloud and API
            /// projects</summary>
            public static string Monitoring = "https://www.googleapis.com/auth/monitoring";

            /// <summary>Publish metric data to your Google Cloud projects</summary>
            public static string MonitoringWrite = "https://www.googleapis.com/auth/monitoring.write";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Stackdriver Profiler API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and write monitoring data for all of your Google and third-party Cloud and API
            /// projects</summary>
            public const string Monitoring = "https://www.googleapis.com/auth/monitoring";

            /// <summary>Publish metric data to your Google Cloud projects</summary>
            public const string MonitoringWrite = "https://www.googleapis.com/auth/monitoring.write";

        }



        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    ///<summary>A base abstract class for CloudProfiler requests.</summary>
    public abstract class CloudProfilerBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new CloudProfilerBaseServiceRequest instance.</summary>
        protected CloudProfilerBaseServiceRequest(Google.Apis.Services.IClientService service)
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

        /// <summary>Initializes CloudProfiler parameter list.</summary>
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
            Profiles = new ProfilesResource(service);

        }

        /// <summary>Gets the Profiles resource.</summary>
        public virtual ProfilesResource Profiles { get; }

        /// <summary>The "profiles" collection of methods.</summary>
        public class ProfilesResource
        {
            private const string Resource = "profiles";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ProfilesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>CreateProfile creates a new profile resource in the online mode. The server ensures that the
            /// new profiles are created at a constant rate per deployment, so the creation request may hang for some
            /// time until the next profile session is available. The request may fail with ABORTED error if the
            /// creation is not available within ~1m, the response will indicate the duration of the backoff the client
            /// should take before attempting creating a profile again. The backoff duration is returned in
            /// google.rpc.RetryInfo extension on the response status. To a gRPC client, the extension will be return as
            /// a binary-serialized proto in the trailing metadata item named "google.rpc.retryinfo-bin".</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Parent project to create the profile in.</param>
            public virtual CreateRequest Create(Google.Apis.CloudProfiler.v2.Data.CreateProfileRequest body, string parent)
            {
                return new CreateRequest(service, body, parent);
            }

            /// <summary>CreateProfile creates a new profile resource in the online mode. The server ensures that the
            /// new profiles are created at a constant rate per deployment, so the creation request may hang for some
            /// time until the next profile session is available. The request may fail with ABORTED error if the
            /// creation is not available within ~1m, the response will indicate the duration of the backoff the client
            /// should take before attempting creating a profile again. The backoff duration is returned in
            /// google.rpc.RetryInfo extension on the response status. To a gRPC client, the extension will be return as
            /// a binary-serialized proto in the trailing metadata item named "google.rpc.retryinfo-bin".</summary>
            public class CreateRequest : CloudProfilerBaseServiceRequest<Google.Apis.CloudProfiler.v2.Data.Profile>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudProfiler.v2.Data.CreateProfileRequest body, string parent)
                    : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Parent project to create the profile in.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudProfiler.v2.Data.CreateProfileRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "create";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/profiles";

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
                            Pattern = @"^projects/[^/]+$",
                        });
                }

            }

            /// <summary>CreateOfflineProfile creates a new profile resource in the offline mode. The client provides
            /// the profile to create along with the profile bytes, the server records it.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="parent">Parent project to create the profile in.</param>
            public virtual CreateOfflineRequest CreateOffline(Google.Apis.CloudProfiler.v2.Data.Profile body, string parent)
            {
                return new CreateOfflineRequest(service, body, parent);
            }

            /// <summary>CreateOfflineProfile creates a new profile resource in the offline mode. The client provides
            /// the profile to create along with the profile bytes, the server records it.</summary>
            public class CreateOfflineRequest : CloudProfilerBaseServiceRequest<Google.Apis.CloudProfiler.v2.Data.Profile>
            {
                /// <summary>Constructs a new CreateOffline request.</summary>
                public CreateOfflineRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudProfiler.v2.Data.Profile body, string parent)
                    : base(service)
                {
                    Parent = parent;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Parent project to create the profile in.</summary>
                [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Parent { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudProfiler.v2.Data.Profile Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "createOffline";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+parent}/profiles:createOffline";

                /// <summary>Initializes CreateOffline parameter list.</summary>
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
                            Pattern = @"^projects/[^/]+$",
                        });
                }

            }

            /// <summary>UpdateProfile updates the profile bytes and labels on the profile resource created in the
            /// online mode. Updating the bytes for profiles created in the offline mode is currently not supported: the
            /// profile content must be provided at the time of the profile creation.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Output only. Opaque, server-assigned, unique ID for this profile.</param>
            public virtual PatchRequest Patch(Google.Apis.CloudProfiler.v2.Data.Profile body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>UpdateProfile updates the profile bytes and labels on the profile resource created in the
            /// online mode. Updating the bytes for profiles created in the offline mode is currently not supported: the
            /// profile content must be provided at the time of the profile creation.</summary>
            public class PatchRequest : CloudProfilerBaseServiceRequest<Google.Apis.CloudProfiler.v2.Data.Profile>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudProfiler.v2.Data.Profile body, string name)
                    : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Output only. Opaque, server-assigned, unique ID for this profile.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Field mask used to specify the fields to be overwritten. Currently only profile_bytes and
                /// labels fields are supported by UpdateProfile, so only those fields can be specified in the mask.
                /// When no mask is provided, all fields are overwritten.</summary>
                [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object UpdateMask { get; set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.CloudProfiler.v2.Data.Profile Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "patch";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PATCH";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v2/{+name}";

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
                            Pattern = @"^projects/[^/]+/profiles/[^/]+$",
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
    }
}

namespace Google.Apis.CloudProfiler.v2.Data
{    

    /// <summary>CreateProfileRequest describes a profile resource online creation request. The deployment field must be
    /// populated. The profile_type specifies the list of profile types supported by the agent. The creation call will
    /// hang until a profile of one of these types needs to be collected.</summary>
    public class CreateProfileRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deployment details.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual Deployment Deployment { get; set; } 

        /// <summary>One or more profile types that the agent is capable of providing.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileType")]
        public virtual System.Collections.Generic.IList<string> ProfileType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Deployment contains the deployment identification information.</summary>
    public class Deployment : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Labels identify the deployment within the user universe and same target. Validation regex for label
        /// names: `^[a-z0-9]([a-z0-9-]{0,61}[a-z0-9])?$`. Value for an individual label must be <= 512 bytes, the total
        /// size of all label names and values must be <= 1024 bytes. Label named "language" can be used to record the
        /// programming language of the profiled deployment. The standard choices for the value include "java", "go",
        /// "python", "ruby", "nodejs", "php", "dotnet". For deployments running on Google Cloud Platform, "zone" or
        /// "region" label should be present describing the deployment location. An example of a zone is "us-
        /// central1-a", an example of a region is "us-central1" or "us-central".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string,string> Labels { get; set; } 

        /// <summary>Project ID is the ID of a cloud project. Validation regex: `^a-z{4,61}[a-z0-9]$`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; } 

        /// <summary>Target is the service name used to group related deployments: * Service name for GAE Flex /
        /// Standard. * Cluster and container name for GKE. * User-specified string for direct GCE profiling (e.g.
        /// Java). * Job name for Dataflow. Validation regex: `^[a-z]([-a-z0-9_.]{0,253}[a-z0-9])?$`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("target")]
        public virtual string Target { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Profile resource.</summary>
    public class Profile : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Deployment this profile corresponds to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deployment")]
        public virtual Deployment Deployment { get; set; } 

        /// <summary>Duration of the profiling session. Input (for the offline mode) or output (for the online mode).
        /// The field represents requested profiling duration. It may slightly differ from the effective profiling
        /// duration, which is recorded in the profile data, in case the profiling can't be stopped immediately (e.g. in
        /// case stopping the profiling is handled asynchronously).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; } 

        /// <summary>Input only. Labels associated to this specific profile. These labels will get merged with the
        /// deployment labels for the final data set. See documentation on deployment labels for validation rules and
        /// limits.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string,string> Labels { get; set; } 

        /// <summary>Output only. Opaque, server-assigned, unique ID for this profile.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>Input only. Profile bytes, as a gzip compressed serialized proto, the format is
        /// https://github.com/google/pprof/blob/master/proto/profile.proto.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileBytes")]
        public virtual string ProfileBytes { get; set; } 

        /// <summary>Type of profile. For offline mode, this must be specified when creating the profile. For online
        /// mode it is assigned and returned by the server.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("profileType")]
        public virtual string ProfileType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
