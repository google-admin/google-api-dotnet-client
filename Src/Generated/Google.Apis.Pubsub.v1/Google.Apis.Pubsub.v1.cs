// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.Pubsub.v1
{
    /// <summary>The Pubsub Service.</summary>
    public class PubsubService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public PubsubService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public PubsubService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "pubsub";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://pubsub.googleapis.com/";
        #else
            "https://pubsub.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://pubsub.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud Pub/Sub API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage Pub/Sub topics and subscriptions</summary>
            public static string Pubsub = "https://www.googleapis.com/auth/pubsub";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud Pub/Sub API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>View and manage Pub/Sub topics and subscriptions</summary>
            public const string Pubsub = "https://www.googleapis.com/auth/pubsub";

        }



        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    ///<summary>A base abstract class for Pubsub requests.</summary>
    public abstract class PubsubBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new PubsubBaseServiceRequest instance.</summary>
        protected PubsubBaseServiceRequest(Google.Apis.Services.IClientService service)
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

        /// <summary>Initializes Pubsub parameter list.</summary>
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
            Snapshots = new SnapshotsResource(service);
            Subscriptions = new SubscriptionsResource(service);
            Topics = new TopicsResource(service);

        }

        /// <summary>Gets the Snapshots resource.</summary>
        public virtual SnapshotsResource Snapshots { get; }

        /// <summary>The "snapshots" collection of methods.</summary>
        public class SnapshotsResource
        {
            private const string Resource = "snapshots";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SnapshotsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Creates a snapshot from the requested subscription. Snapshots are used in
            /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage
            /// message acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an
            /// existing subscription to the state captured by a snapshot. If the snapshot already exists, returns
            /// `ALREADY_EXISTS`. If the requested subscription doesn't exist, returns `NOT_FOUND`. If the backlog in
            /// the subscription is too old -- and the resulting snapshot would expire in less than 1 hour -- then
            /// `FAILED_PRECONDITION` is returned. See also the `Snapshot.expire_time` field. If the name is not
            /// provided in the request, the server will assign a random name for this snapshot on the same project as
            /// the subscription, conforming to the [resource name format]
            /// (https://cloud.google.com/pubsub/docs/admin#resource_names). The generated name is populated in the
            /// returned Snapshot object. Note that for REST API requests, you must specify a name in the
            /// request.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. User-provided name for this snapshot. If the name is not provided in the request, the
            /// server will assign a random name for this snapshot on the same project as the subscription. Note that for REST API
            /// requests, you must specify a name. See the resource name rules. Format is
            /// `projects/{project}/snapshots/{snap}`.</param>
            public virtual CreateRequest Create(Google.Apis.Pubsub.v1.Data.CreateSnapshotRequest body, string name)
            {
                return new CreateRequest(service, body, name);
            }

            /// <summary>Creates a snapshot from the requested subscription. Snapshots are used in
            /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage
            /// message acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an
            /// existing subscription to the state captured by a snapshot. If the snapshot already exists, returns
            /// `ALREADY_EXISTS`. If the requested subscription doesn't exist, returns `NOT_FOUND`. If the backlog in
            /// the subscription is too old -- and the resulting snapshot would expire in less than 1 hour -- then
            /// `FAILED_PRECONDITION` is returned. See also the `Snapshot.expire_time` field. If the name is not
            /// provided in the request, the server will assign a random name for this snapshot on the same project as
            /// the subscription, conforming to the [resource name format]
            /// (https://cloud.google.com/pubsub/docs/admin#resource_names). The generated name is populated in the
            /// returned Snapshot object. Note that for REST API requests, you must specify a name in the
            /// request.</summary>
            public class CreateRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Snapshot>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.CreateSnapshotRequest body, string name)
                    : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. User-provided name for this snapshot. If the name is not provided in the request,
                /// the server will assign a random name for this snapshot on the same project as the subscription. Note
                /// that for REST API requests, you must specify a name. See the resource name rules. Format is
                /// `projects/{project}/snapshots/{snap}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.CreateSnapshotRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "create";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Create parameter list.</summary>
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
                            Pattern = @"^projects/[^/]+/snapshots/[^/]+$",
                        });
                }

            }

            /// <summary>Removes an existing snapshot. Snapshots are used in [Seek]
            /// (https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage message
            /// acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an existing
            /// subscription to the state captured by a snapshot. When the snapshot is deleted, all messages retained in
            /// the snapshot are immediately dropped. After a snapshot is deleted, a new one may be created with the
            /// same name, but the new one has no association with the old snapshot or its subscription, unless the same
            /// subscription is specified.</summary>
            /// <param name="snapshot">Required. The name of the snapshot to delete. Format is
            /// `projects/{project}/snapshots/{snap}`.</param>
            public virtual DeleteRequest Delete(string snapshot)
            {
                return new DeleteRequest(service, snapshot);
            }

            /// <summary>Removes an existing snapshot. Snapshots are used in [Seek]
            /// (https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage message
            /// acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an existing
            /// subscription to the state captured by a snapshot. When the snapshot is deleted, all messages retained in
            /// the snapshot are immediately dropped. After a snapshot is deleted, a new one may be created with the
            /// same name, but the new one has no association with the old snapshot or its subscription, unless the same
            /// subscription is specified.</summary>
            public class DeleteRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string snapshot)
                    : base(service)
                {
                    Snapshot = snapshot;
                    InitParameters();
                }


                /// <summary>Required. The name of the snapshot to delete. Format is
                /// `projects/{project}/snapshots/{snap}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("snapshot", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Snapshot { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+snapshot}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "snapshot", new Google.Apis.Discovery.Parameter
                        {
                            Name = "snapshot",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/snapshots/[^/]+$",
                        });
                }

            }

            /// <summary>Gets the configuration details of a snapshot. Snapshots are used in Seek operations, which
            /// allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment state of
            /// messages in an existing subscription to the state captured by a snapshot.</summary>
            /// <param name="snapshot">Required. The name of the snapshot to get. Format is
            /// `projects/{project}/snapshots/{snap}`.</param>
            public virtual GetRequest Get(string snapshot)
            {
                return new GetRequest(service, snapshot);
            }

            /// <summary>Gets the configuration details of a snapshot. Snapshots are used in Seek operations, which
            /// allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment state of
            /// messages in an existing subscription to the state captured by a snapshot.</summary>
            public class GetRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Snapshot>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string snapshot)
                    : base(service)
                {
                    Snapshot = snapshot;
                    InitParameters();
                }


                /// <summary>Required. The name of the snapshot to get. Format is
                /// `projects/{project}/snapshots/{snap}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("snapshot", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Snapshot { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+snapshot}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "snapshot", new Google.Apis.Discovery.Parameter
                        {
                            Name = "snapshot",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/snapshots/[^/]+$",
                        });
                }

            }

            /// <summary>Gets the access control policy for a resource. Returns an empty policy if the resource exists
            /// and does not have a policy set.</summary>
            /// <param name="resource">REQUIRED: The resource for which the policy is being requested. See the operation
            /// documentation for the appropriate value for this field.</param>
            public virtual GetIamPolicyRequest GetIamPolicy(string resource)
            {
                return new GetIamPolicyRequest(service, resource);
            }

            /// <summary>Gets the access control policy for a resource. Returns an empty policy if the resource exists
            /// and does not have a policy set.</summary>
            public class GetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Policy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource)
                    : base(service)
                {
                    Resource = resource;
                    InitParameters();
                }


                /// <summary>REQUIRED: The resource for which the policy is being requested. See the operation
                /// documentation for the appropriate value for this field.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                /// specifying an invalid value will be rejected. Requests for policies with any conditional bindings
                /// must specify version 3. Policies without any conditional bindings may specify any valid value or
                /// leave the field unset. To learn which resources support conditions in their IAM policies, see the
                /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies).</summary>
                [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:getIamPolicy";

                /// <summary>Initializes GetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/snapshots/[^/]+$",
                        });
                    RequestParameters.Add(
                        "options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "options.requestedPolicyVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Lists the existing snapshots. Snapshots are used in [Seek](
            /// https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage message
            /// acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an existing
            /// subscription to the state captured by a snapshot.</summary>
            /// <param name="project">Required. The name of the project in which to list snapshots. Format is `projects/{project-
            /// id}`.</param>
            public virtual ListRequest List(string project)
            {
                return new ListRequest(service, project);
            }

            /// <summary>Lists the existing snapshots. Snapshots are used in [Seek](
            /// https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage message
            /// acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an existing
            /// subscription to the state captured by a snapshot.</summary>
            public class ListRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.ListSnapshotsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string project)
                    : base(service)
                {
                    Project = project;
                    InitParameters();
                }


                /// <summary>Required. The name of the project in which to list snapshots. Format is `projects/{project-
                /// id}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Maximum number of snapshots to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The value returned by the last `ListSnapshotsResponse`; indicates that this is a
                /// continuation of a prior `ListSnapshots` call, and that the system should return the next page of
                /// data.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+project}/snapshots";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "project", new Google.Apis.Discovery.Parameter
                        {
                            Name = "project",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+$",
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

            /// <summary>Updates an existing snapshot. Snapshots are used in Seek operations, which allow you to manage
            /// message acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an
            /// existing subscription to the state captured by a snapshot.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">The name of the snapshot.</param>
            public virtual PatchRequest Patch(Google.Apis.Pubsub.v1.Data.UpdateSnapshotRequest body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates an existing snapshot. Snapshots are used in Seek operations, which allow you to manage
            /// message acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an
            /// existing subscription to the state captured by a snapshot.</summary>
            public class PatchRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Snapshot>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.UpdateSnapshotRequest body, string name)
                    : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>The name of the snapshot.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.UpdateSnapshotRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/snapshots/[^/]+$",
                        });
                }

            }

            /// <summary>Sets the access control policy on the specified resource. Replaces any existing policy. Can
            /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">REQUIRED: The resource for which the policy is being specified. See the operation
            /// documentation for the appropriate value for this field.</param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(service, body, resource);
            }

            /// <summary>Sets the access control policy on the specified resource. Replaces any existing policy. Can
            /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.</summary>
            public class SetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest body, string resource)
                    : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }


                /// <summary>REQUIRED: The resource for which the policy is being specified. See the operation
                /// documentation for the appropriate value for this field.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "setIamPolicy";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:setIamPolicy";

                /// <summary>Initializes SetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/snapshots/[^/]+$",
                        });
                }

            }

            /// <summary>Returns permissions that a caller has on the specified resource. If the resource does not
            /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
            /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
            /// checking. This operation may "fail open" without warning.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">REQUIRED: The resource for which the policy detail is being requested. See the operation
            /// documentation for the appropriate value for this field.</param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(service, body, resource);
            }

            /// <summary>Returns permissions that a caller has on the specified resource. If the resource does not
            /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
            /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
            /// checking. This operation may "fail open" without warning.</summary>
            public class TestIamPermissionsRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest body, string resource)
                    : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }


                /// <summary>REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "testIamPermissions";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:testIamPermissions";

                /// <summary>Initializes TestIamPermissions parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/snapshots/[^/]+$",
                        });
                }

            }
        }
        /// <summary>Gets the Subscriptions resource.</summary>
        public virtual SubscriptionsResource Subscriptions { get; }

        /// <summary>The "subscriptions" collection of methods.</summary>
        public class SubscriptionsResource
        {
            private const string Resource = "subscriptions";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SubscriptionsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Acknowledges the messages associated with the `ack_ids` in the `AcknowledgeRequest`. The
            /// Pub/Sub system can remove the relevant messages from the subscription. Acknowledging a message whose ack
            /// deadline has expired may succeed, but such a message may be redelivered later. Acknowledging a message
            /// more than once will not result in an error.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="subscription">Required. The subscription whose message is being acknowledged. Format is
            /// `projects/{project}/subscriptions/{sub}`.</param>
            public virtual AcknowledgeRequest Acknowledge(Google.Apis.Pubsub.v1.Data.AcknowledgeRequest body, string subscription)
            {
                return new AcknowledgeRequest(service, body, subscription);
            }

            /// <summary>Acknowledges the messages associated with the `ack_ids` in the `AcknowledgeRequest`. The
            /// Pub/Sub system can remove the relevant messages from the subscription. Acknowledging a message whose ack
            /// deadline has expired may succeed, but such a message may be redelivered later. Acknowledging a message
            /// more than once will not result in an error.</summary>
            public class AcknowledgeRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Empty>
            {
                /// <summary>Constructs a new Acknowledge request.</summary>
                public AcknowledgeRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.AcknowledgeRequest body, string subscription)
                    : base(service)
                {
                    Subscription = subscription;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The subscription whose message is being acknowledged. Format is
                /// `projects/{project}/subscriptions/{sub}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.AcknowledgeRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "acknowledge";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+subscription}:acknowledge";

                /// <summary>Initializes Acknowledge parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "subscription", new Google.Apis.Discovery.Parameter
                        {
                            Name = "subscription",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                        });
                }

            }

            /// <summary>Creates a subscription to a given topic. See the [resource name rules]
            /// (https://cloud.google.com/pubsub/docs/admin#resource_names). If the subscription already exists, returns
            /// `ALREADY_EXISTS`. If the corresponding topic doesn't exist, returns `NOT_FOUND`. If the name is not
            /// provided in the request, the server will assign a random name for this subscription on the same project
            /// as the topic, conforming to the [resource name format]
            /// (https://cloud.google.com/pubsub/docs/admin#resource_names). The generated name is populated in the
            /// returned Subscription object. Note that for REST API requests, you must specify a name in the
            /// request.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The name of the subscription. It must have the format
            /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must start with a letter, and contain only
            /// letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or
            /// percent signs (`%`). It must be between 3 and 255 characters in length, and it must not start with
            /// `"goog"`.</param>
            public virtual CreateRequest Create(Google.Apis.Pubsub.v1.Data.Subscription body, string name)
            {
                return new CreateRequest(service, body, name);
            }

            /// <summary>Creates a subscription to a given topic. See the [resource name rules]
            /// (https://cloud.google.com/pubsub/docs/admin#resource_names). If the subscription already exists, returns
            /// `ALREADY_EXISTS`. If the corresponding topic doesn't exist, returns `NOT_FOUND`. If the name is not
            /// provided in the request, the server will assign a random name for this subscription on the same project
            /// as the topic, conforming to the [resource name format]
            /// (https://cloud.google.com/pubsub/docs/admin#resource_names). The generated name is populated in the
            /// returned Subscription object. Note that for REST API requests, you must specify a name in the
            /// request.</summary>
            public class CreateRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Subscription>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.Subscription body, string name)
                    : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The name of the subscription. It must have the format
                /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must start with a letter, and
                /// contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores (`_`), periods
                /// (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters in
                /// length, and it must not start with `"goog"`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.Subscription Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "create";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Create parameter list.</summary>
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
                            Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                        });
                }

            }

            /// <summary>Deletes an existing subscription. All messages retained in the subscription are immediately
            /// dropped. Calls to `Pull` after deletion will return `NOT_FOUND`. After a subscription is deleted, a new
            /// one may be created with the same name, but the new one has no association with the old subscription or
            /// its topic unless the same topic is specified.</summary>
            /// <param name="subscription">Required. The subscription to delete. Format is
            /// `projects/{project}/subscriptions/{sub}`.</param>
            public virtual DeleteRequest Delete(string subscription)
            {
                return new DeleteRequest(service, subscription);
            }

            /// <summary>Deletes an existing subscription. All messages retained in the subscription are immediately
            /// dropped. Calls to `Pull` after deletion will return `NOT_FOUND`. After a subscription is deleted, a new
            /// one may be created with the same name, but the new one has no association with the old subscription or
            /// its topic unless the same topic is specified.</summary>
            public class DeleteRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string subscription)
                    : base(service)
                {
                    Subscription = subscription;
                    InitParameters();
                }


                /// <summary>Required. The subscription to delete. Format is
                /// `projects/{project}/subscriptions/{sub}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+subscription}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "subscription", new Google.Apis.Discovery.Parameter
                        {
                            Name = "subscription",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                        });
                }

            }

            /// <summary>Detaches a subscription from this topic. All messages retained in the subscription are dropped.
            /// Subsequent `Pull` and `StreamingPull` requests will return FAILED_PRECONDITION. If the subscription is a
            /// push subscription, pushes to the endpoint will stop.</summary>
            /// <param name="subscription">Required. The subscription to detach. Format is
            /// `projects/{project}/subscriptions/{subscription}`.</param>
            public virtual DetachRequest Detach(string subscription)
            {
                return new DetachRequest(service, subscription);
            }

            /// <summary>Detaches a subscription from this topic. All messages retained in the subscription are dropped.
            /// Subsequent `Pull` and `StreamingPull` requests will return FAILED_PRECONDITION. If the subscription is a
            /// push subscription, pushes to the endpoint will stop.</summary>
            public class DetachRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.DetachSubscriptionResponse>
            {
                /// <summary>Constructs a new Detach request.</summary>
                public DetachRequest(Google.Apis.Services.IClientService service, string subscription)
                    : base(service)
                {
                    Subscription = subscription;
                    InitParameters();
                }


                /// <summary>Required. The subscription to detach. Format is
                /// `projects/{project}/subscriptions/{subscription}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "detach";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+subscription}:detach";

                /// <summary>Initializes Detach parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "subscription", new Google.Apis.Discovery.Parameter
                        {
                            Name = "subscription",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                        });
                }

            }

            /// <summary>Gets the configuration details of a subscription.</summary>
            /// <param name="subscription">Required. The name of the subscription to get. Format is
            /// `projects/{project}/subscriptions/{sub}`.</param>
            public virtual GetRequest Get(string subscription)
            {
                return new GetRequest(service, subscription);
            }

            /// <summary>Gets the configuration details of a subscription.</summary>
            public class GetRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Subscription>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string subscription)
                    : base(service)
                {
                    Subscription = subscription;
                    InitParameters();
                }


                /// <summary>Required. The name of the subscription to get. Format is
                /// `projects/{project}/subscriptions/{sub}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+subscription}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "subscription", new Google.Apis.Discovery.Parameter
                        {
                            Name = "subscription",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                        });
                }

            }

            /// <summary>Gets the access control policy for a resource. Returns an empty policy if the resource exists
            /// and does not have a policy set.</summary>
            /// <param name="resource">REQUIRED: The resource for which the policy is being requested. See the operation
            /// documentation for the appropriate value for this field.</param>
            public virtual GetIamPolicyRequest GetIamPolicy(string resource)
            {
                return new GetIamPolicyRequest(service, resource);
            }

            /// <summary>Gets the access control policy for a resource. Returns an empty policy if the resource exists
            /// and does not have a policy set.</summary>
            public class GetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Policy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource)
                    : base(service)
                {
                    Resource = resource;
                    InitParameters();
                }


                /// <summary>REQUIRED: The resource for which the policy is being requested. See the operation
                /// documentation for the appropriate value for this field.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                /// specifying an invalid value will be rejected. Requests for policies with any conditional bindings
                /// must specify version 3. Policies without any conditional bindings may specify any valid value or
                /// leave the field unset. To learn which resources support conditions in their IAM policies, see the
                /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies).</summary>
                [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:getIamPolicy";

                /// <summary>Initializes GetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                        });
                    RequestParameters.Add(
                        "options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "options.requestedPolicyVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Lists matching subscriptions.</summary>
            /// <param name="project">Required. The name of the project in which to list subscriptions. Format is `projects
            /// /{project-id}`.</param>
            public virtual ListRequest List(string project)
            {
                return new ListRequest(service, project);
            }

            /// <summary>Lists matching subscriptions.</summary>
            public class ListRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.ListSubscriptionsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string project)
                    : base(service)
                {
                    Project = project;
                    InitParameters();
                }


                /// <summary>Required. The name of the project in which to list subscriptions. Format is `projects
                /// /{project-id}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Maximum number of subscriptions to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The value returned by the last `ListSubscriptionsResponse`; indicates that this is a
                /// continuation of a prior `ListSubscriptions` call, and that the system should return the next page of
                /// data.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+project}/subscriptions";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "project", new Google.Apis.Discovery.Parameter
                        {
                            Name = "project",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+$",
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

            /// <summary>Modifies the ack deadline for a specific message. This method is useful to indicate that more
            /// time is needed to process a message by the subscriber, or to make the message available for redelivery
            /// if the processing was interrupted. Note that this does not modify the subscription-level
            /// `ackDeadlineSeconds` used for subsequent messages.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="subscription">Required. The name of the subscription. Format is
            /// `projects/{project}/subscriptions/{sub}`.</param>
            public virtual ModifyAckDeadlineRequest ModifyAckDeadline(Google.Apis.Pubsub.v1.Data.ModifyAckDeadlineRequest body, string subscription)
            {
                return new ModifyAckDeadlineRequest(service, body, subscription);
            }

            /// <summary>Modifies the ack deadline for a specific message. This method is useful to indicate that more
            /// time is needed to process a message by the subscriber, or to make the message available for redelivery
            /// if the processing was interrupted. Note that this does not modify the subscription-level
            /// `ackDeadlineSeconds` used for subsequent messages.</summary>
            public class ModifyAckDeadlineRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Empty>
            {
                /// <summary>Constructs a new ModifyAckDeadline request.</summary>
                public ModifyAckDeadlineRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.ModifyAckDeadlineRequest body, string subscription)
                    : base(service)
                {
                    Subscription = subscription;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The name of the subscription. Format is
                /// `projects/{project}/subscriptions/{sub}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.ModifyAckDeadlineRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "modifyAckDeadline";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+subscription}:modifyAckDeadline";

                /// <summary>Initializes ModifyAckDeadline parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "subscription", new Google.Apis.Discovery.Parameter
                        {
                            Name = "subscription",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                        });
                }

            }

            /// <summary>Modifies the `PushConfig` for a specified subscription. This may be used to change a push
            /// subscription to a pull one (signified by an empty `PushConfig`) or vice versa, or change the endpoint
            /// URL and other attributes of a push subscription. Messages will accumulate for delivery continuously
            /// through the call regardless of changes to the `PushConfig`.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="subscription">Required. The name of the subscription. Format is
            /// `projects/{project}/subscriptions/{sub}`.</param>
            public virtual ModifyPushConfigRequest ModifyPushConfig(Google.Apis.Pubsub.v1.Data.ModifyPushConfigRequest body, string subscription)
            {
                return new ModifyPushConfigRequest(service, body, subscription);
            }

            /// <summary>Modifies the `PushConfig` for a specified subscription. This may be used to change a push
            /// subscription to a pull one (signified by an empty `PushConfig`) or vice versa, or change the endpoint
            /// URL and other attributes of a push subscription. Messages will accumulate for delivery continuously
            /// through the call regardless of changes to the `PushConfig`.</summary>
            public class ModifyPushConfigRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Empty>
            {
                /// <summary>Constructs a new ModifyPushConfig request.</summary>
                public ModifyPushConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.ModifyPushConfigRequest body, string subscription)
                    : base(service)
                {
                    Subscription = subscription;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The name of the subscription. Format is
                /// `projects/{project}/subscriptions/{sub}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.ModifyPushConfigRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "modifyPushConfig";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+subscription}:modifyPushConfig";

                /// <summary>Initializes ModifyPushConfig parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "subscription", new Google.Apis.Discovery.Parameter
                        {
                            Name = "subscription",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                        });
                }

            }

            /// <summary>Updates an existing subscription. Note that certain properties of a subscription, such as its
            /// topic, are not modifiable.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The name of the subscription. It must have the format
            /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must start with a letter, and contain only
            /// letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or
            /// percent signs (`%`). It must be between 3 and 255 characters in length, and it must not start with
            /// `"goog"`.</param>
            public virtual PatchRequest Patch(Google.Apis.Pubsub.v1.Data.UpdateSubscriptionRequest body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates an existing subscription. Note that certain properties of a subscription, such as its
            /// topic, are not modifiable.</summary>
            public class PatchRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Subscription>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.UpdateSubscriptionRequest body, string name)
                    : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The name of the subscription. It must have the format
                /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must start with a letter, and
                /// contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores (`_`), periods
                /// (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters in
                /// length, and it must not start with `"goog"`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.UpdateSubscriptionRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                        });
                }

            }

            /// <summary>Pulls messages from the server. The server may return `UNAVAILABLE` if there are too many
            /// concurrent pull requests pending for the given subscription.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="subscription">Required. The subscription from which messages should be pulled. Format is
            /// `projects/{project}/subscriptions/{sub}`.</param>
            public virtual PullRequest Pull(Google.Apis.Pubsub.v1.Data.PullRequest body, string subscription)
            {
                return new PullRequest(service, body, subscription);
            }

            /// <summary>Pulls messages from the server. The server may return `UNAVAILABLE` if there are too many
            /// concurrent pull requests pending for the given subscription.</summary>
            public class PullRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.PullResponse>
            {
                /// <summary>Constructs a new Pull request.</summary>
                public PullRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.PullRequest body, string subscription)
                    : base(service)
                {
                    Subscription = subscription;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The subscription from which messages should be pulled. Format is
                /// `projects/{project}/subscriptions/{sub}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.PullRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "pull";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+subscription}:pull";

                /// <summary>Initializes Pull parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "subscription", new Google.Apis.Discovery.Parameter
                        {
                            Name = "subscription",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                        });
                }

            }

            /// <summary>Seeks an existing subscription to a point in time or to a given snapshot, whichever is provided
            /// in the request. Snapshots are used in [Seek]( https://cloud.google.com/pubsub/docs/replay-overview)
            /// operations, which allow you to manage message acknowledgments in bulk. That is, you can set the
            /// acknowledgment state of messages in an existing subscription to the state captured by a snapshot. Note
            /// that both the subscription and the snapshot must be on the same topic.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="subscription">Required. The subscription to affect.</param>
            public virtual SeekRequest Seek(Google.Apis.Pubsub.v1.Data.SeekRequest body, string subscription)
            {
                return new SeekRequest(service, body, subscription);
            }

            /// <summary>Seeks an existing subscription to a point in time or to a given snapshot, whichever is provided
            /// in the request. Snapshots are used in [Seek]( https://cloud.google.com/pubsub/docs/replay-overview)
            /// operations, which allow you to manage message acknowledgments in bulk. That is, you can set the
            /// acknowledgment state of messages in an existing subscription to the state captured by a snapshot. Note
            /// that both the subscription and the snapshot must be on the same topic.</summary>
            public class SeekRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.SeekResponse>
            {
                /// <summary>Constructs a new Seek request.</summary>
                public SeekRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.SeekRequest body, string subscription)
                    : base(service)
                {
                    Subscription = subscription;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The subscription to affect.</summary>
                [Google.Apis.Util.RequestParameterAttribute("subscription", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Subscription { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.SeekRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "seek";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+subscription}:seek";

                /// <summary>Initializes Seek parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "subscription", new Google.Apis.Discovery.Parameter
                        {
                            Name = "subscription",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                        });
                }

            }

            /// <summary>Sets the access control policy on the specified resource. Replaces any existing policy. Can
            /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">REQUIRED: The resource for which the policy is being specified. See the operation
            /// documentation for the appropriate value for this field.</param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(service, body, resource);
            }

            /// <summary>Sets the access control policy on the specified resource. Replaces any existing policy. Can
            /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.</summary>
            public class SetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest body, string resource)
                    : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }


                /// <summary>REQUIRED: The resource for which the policy is being specified. See the operation
                /// documentation for the appropriate value for this field.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "setIamPolicy";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:setIamPolicy";

                /// <summary>Initializes SetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                        });
                }

            }

            /// <summary>Returns permissions that a caller has on the specified resource. If the resource does not
            /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
            /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
            /// checking. This operation may "fail open" without warning.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">REQUIRED: The resource for which the policy detail is being requested. See the operation
            /// documentation for the appropriate value for this field.</param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(service, body, resource);
            }

            /// <summary>Returns permissions that a caller has on the specified resource. If the resource does not
            /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
            /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
            /// checking. This operation may "fail open" without warning.</summary>
            public class TestIamPermissionsRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest body, string resource)
                    : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }


                /// <summary>REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "testIamPermissions";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:testIamPermissions";

                /// <summary>Initializes TestIamPermissions parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/subscriptions/[^/]+$",
                        });
                }

            }
        }
        /// <summary>Gets the Topics resource.</summary>
        public virtual TopicsResource Topics { get; }

        /// <summary>The "topics" collection of methods.</summary>
        public class TopicsResource
        {
            private const string Resource = "topics";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TopicsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Snapshots = new SnapshotsResource(service);
                Subscriptions = new SubscriptionsResource(service);

            }

            /// <summary>Gets the Snapshots resource.</summary>
            public virtual SnapshotsResource Snapshots { get; }

            /// <summary>The "snapshots" collection of methods.</summary>
            public class SnapshotsResource
            {
                private const string Resource = "snapshots";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SnapshotsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Lists the names of the snapshots on this topic. Snapshots are used in
                /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage
                /// message acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an
                /// existing subscription to the state captured by a snapshot.</summary>
                /// <param name="topic">Required. The name of the topic that snapshots are attached to. Format is
                /// `projects/{project}/topics/{topic}`.</param>
                public virtual ListRequest List(string topic)
                {
                    return new ListRequest(service, topic);
                }

                /// <summary>Lists the names of the snapshots on this topic. Snapshots are used in
                /// [Seek](https://cloud.google.com/pubsub/docs/replay-overview) operations, which allow you to manage
                /// message acknowledgments in bulk. That is, you can set the acknowledgment state of messages in an
                /// existing subscription to the state captured by a snapshot.</summary>
                public class ListRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.ListTopicSnapshotsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string topic)
                        : base(service)
                    {
                        Topic = topic;
                        InitParameters();
                    }


                    /// <summary>Required. The name of the topic that snapshots are attached to. Format is
                    /// `projects/{project}/topics/{topic}`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("topic", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Topic { get; private set; }

                    /// <summary>Maximum number of snapshot names to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The value returned by the last `ListTopicSnapshotsResponse`; indicates that this is a
                    /// continuation of a prior `ListTopicSnapshots` call, and that the system should return the next
                    /// page of data.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+topic}/snapshots";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "topic", new Google.Apis.Discovery.Parameter
                            {
                                Name = "topic",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/topics/[^/]+$",
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
            /// <summary>Gets the Subscriptions resource.</summary>
            public virtual SubscriptionsResource Subscriptions { get; }

            /// <summary>The "subscriptions" collection of methods.</summary>
            public class SubscriptionsResource
            {
                private const string Resource = "subscriptions";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public SubscriptionsResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;

                }


                /// <summary>Lists the names of the attached subscriptions on this topic.</summary>
                /// <param name="topic">Required. The name of the topic that subscriptions are attached to. Format is
                /// `projects/{project}/topics/{topic}`.</param>
                public virtual ListRequest List(string topic)
                {
                    return new ListRequest(service, topic);
                }

                /// <summary>Lists the names of the attached subscriptions on this topic.</summary>
                public class ListRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.ListTopicSubscriptionsResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string topic)
                        : base(service)
                    {
                        Topic = topic;
                        InitParameters();
                    }


                    /// <summary>Required. The name of the topic that subscriptions are attached to. Format is
                    /// `projects/{project}/topics/{topic}`.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("topic", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Topic { get; private set; }

                    /// <summary>Maximum number of subscription names to return.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>The value returned by the last `ListTopicSubscriptionsResponse`; indicates that this is
                    /// a continuation of a prior `ListTopicSubscriptions` call, and that the system should return the
                    /// next page of data.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }


                    ///<summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    ///<summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    ///<summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+topic}/subscriptions";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();

                        RequestParameters.Add(
                            "topic", new Google.Apis.Discovery.Parameter
                            {
                                Name = "topic",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/topics/[^/]+$",
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

            /// <summary>Creates the given topic with the given name. See the [resource name rules](
            /// https://cloud.google.com/pubsub/docs/admin#resource_names).</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The name of the topic. It must have the format `"projects/{project}/topics/{topic}"`.
            /// `{topic}` must start with a letter, and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
            /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be between 3 and 255
            /// characters in length, and it must not start with `"goog"`.</param>
            public virtual CreateRequest Create(Google.Apis.Pubsub.v1.Data.Topic body, string name)
            {
                return new CreateRequest(service, body, name);
            }

            /// <summary>Creates the given topic with the given name. See the [resource name rules](
            /// https://cloud.google.com/pubsub/docs/admin#resource_names).</summary>
            public class CreateRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Topic>
            {
                /// <summary>Constructs a new Create request.</summary>
                public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.Topic body, string name)
                    : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The name of the topic. It must have the format
                /// `"projects/{project}/topics/{topic}"`. `{topic}` must start with a letter, and contain only letters
                /// (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`), plus
                /// (`+`) or percent signs (`%`). It must be between 3 and 255 characters in length, and it must not
                /// start with `"goog"`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.Topic Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "create";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "PUT";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+name}";

                /// <summary>Initializes Create parameter list.</summary>
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
                            Pattern = @"^projects/[^/]+/topics/[^/]+$",
                        });
                }

            }

            /// <summary>Deletes the topic with the given name. Returns `NOT_FOUND` if the topic does not exist. After a
            /// topic is deleted, a new topic may be created with the same name; this is an entirely new topic with none
            /// of the old configuration or subscriptions. Existing subscriptions to this topic are not deleted, but
            /// their `topic` field is set to `_deleted-topic_`.</summary>
            /// <param name="topic">Required. Name of the topic to delete. Format is
            /// `projects/{project}/topics/{topic}`.</param>
            public virtual DeleteRequest Delete(string topic)
            {
                return new DeleteRequest(service, topic);
            }

            /// <summary>Deletes the topic with the given name. Returns `NOT_FOUND` if the topic does not exist. After a
            /// topic is deleted, a new topic may be created with the same name; this is an entirely new topic with none
            /// of the old configuration or subscriptions. Existing subscriptions to this topic are not deleted, but
            /// their `topic` field is set to `_deleted-topic_`.</summary>
            public class DeleteRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Empty>
            {
                /// <summary>Constructs a new Delete request.</summary>
                public DeleteRequest(Google.Apis.Services.IClientService service, string topic)
                    : base(service)
                {
                    Topic = topic;
                    InitParameters();
                }


                /// <summary>Required. Name of the topic to delete. Format is
                /// `projects/{project}/topics/{topic}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("topic", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Topic { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "delete";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "DELETE";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+topic}";

                /// <summary>Initializes Delete parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "topic", new Google.Apis.Discovery.Parameter
                        {
                            Name = "topic",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/topics/[^/]+$",
                        });
                }

            }

            /// <summary>Gets the configuration of a topic.</summary>
            /// <param name="topic">Required. The name of the topic to get. Format is
            /// `projects/{project}/topics/{topic}`.</param>
            public virtual GetRequest Get(string topic)
            {
                return new GetRequest(service, topic);
            }

            /// <summary>Gets the configuration of a topic.</summary>
            public class GetRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Topic>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string topic)
                    : base(service)
                {
                    Topic = topic;
                    InitParameters();
                }


                /// <summary>Required. The name of the topic to get. Format is
                /// `projects/{project}/topics/{topic}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("topic", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Topic { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "get";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+topic}";

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "topic", new Google.Apis.Discovery.Parameter
                        {
                            Name = "topic",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/topics/[^/]+$",
                        });
                }

            }

            /// <summary>Gets the access control policy for a resource. Returns an empty policy if the resource exists
            /// and does not have a policy set.</summary>
            /// <param name="resource">REQUIRED: The resource for which the policy is being requested. See the operation
            /// documentation for the appropriate value for this field.</param>
            public virtual GetIamPolicyRequest GetIamPolicy(string resource)
            {
                return new GetIamPolicyRequest(service, resource);
            }

            /// <summary>Gets the access control policy for a resource. Returns an empty policy if the resource exists
            /// and does not have a policy set.</summary>
            public class GetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Policy>
            {
                /// <summary>Constructs a new GetIamPolicy request.</summary>
                public GetIamPolicyRequest(Google.Apis.Services.IClientService service, string resource)
                    : base(service)
                {
                    Resource = resource;
                    InitParameters();
                }


                /// <summary>REQUIRED: The resource for which the policy is being requested. See the operation
                /// documentation for the appropriate value for this field.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }

                /// <summary>Optional. The policy format version to be returned. Valid values are 0, 1, and 3. Requests
                /// specifying an invalid value will be rejected. Requests for policies with any conditional bindings
                /// must specify version 3. Policies without any conditional bindings may specify any valid value or
                /// leave the field unset. To learn which resources support conditions in their IAM policies, see the
                /// [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies).</summary>
                [Google.Apis.Util.RequestParameterAttribute("options.requestedPolicyVersion", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> OptionsRequestedPolicyVersion { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "getIamPolicy";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:getIamPolicy";

                /// <summary>Initializes GetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/topics/[^/]+$",
                        });
                    RequestParameters.Add(
                        "options.requestedPolicyVersion", new Google.Apis.Discovery.Parameter
                        {
                            Name = "options.requestedPolicyVersion",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Lists matching topics.</summary>
            /// <param name="project">Required. The name of the project in which to list topics. Format is `projects/{project-
            /// id}`.</param>
            public virtual ListRequest List(string project)
            {
                return new ListRequest(service, project);
            }

            /// <summary>Lists matching topics.</summary>
            public class ListRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.ListTopicsResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string project)
                    : base(service)
                {
                    Project = project;
                    InitParameters();
                }


                /// <summary>Required. The name of the project in which to list topics. Format is `projects/{project-
                /// id}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("project", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Project { get; private set; }

                /// <summary>Maximum number of topics to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>The value returned by the last `ListTopicsResponse`; indicates that this is a continuation
                /// of a prior `ListTopics` call, and that the system should return the next page of data.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName => "list";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+project}/topics";

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "project", new Google.Apis.Discovery.Parameter
                        {
                            Name = "project",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+$",
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

            /// <summary>Updates an existing topic. Note that certain properties of a topic are not
            /// modifiable.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="name">Required. The name of the topic. It must have the format `"projects/{project}/topics/{topic}"`.
            /// `{topic}` must start with a letter, and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
            /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be between 3 and 255
            /// characters in length, and it must not start with `"goog"`.</param>
            public virtual PatchRequest Patch(Google.Apis.Pubsub.v1.Data.UpdateTopicRequest body, string name)
            {
                return new PatchRequest(service, body, name);
            }

            /// <summary>Updates an existing topic. Note that certain properties of a topic are not
            /// modifiable.</summary>
            public class PatchRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Topic>
            {
                /// <summary>Constructs a new Patch request.</summary>
                public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.UpdateTopicRequest body, string name)
                    : base(service)
                {
                    Name = name;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The name of the topic. It must have the format
                /// `"projects/{project}/topics/{topic}"`. `{topic}` must start with a letter, and contain only letters
                /// (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`), plus
                /// (`+`) or percent signs (`%`). It must be between 3 and 255 characters in length, and it must not
                /// start with `"goog"`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.UpdateTopicRequest Body { get; set; }

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
                            Pattern = @"^projects/[^/]+/topics/[^/]+$",
                        });
                }

            }

            /// <summary>Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic does not
            /// exist.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="topic">Required. The messages in the request will be published on this topic. Format is
            /// `projects/{project}/topics/{topic}`.</param>
            public virtual PublishRequest Publish(Google.Apis.Pubsub.v1.Data.PublishRequest body, string topic)
            {
                return new PublishRequest(service, body, topic);
            }

            /// <summary>Adds one or more messages to the topic. Returns `NOT_FOUND` if the topic does not
            /// exist.</summary>
            public class PublishRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.PublishResponse>
            {
                /// <summary>Constructs a new Publish request.</summary>
                public PublishRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.PublishRequest body, string topic)
                    : base(service)
                {
                    Topic = topic;
                    Body = body;
                    InitParameters();
                }


                /// <summary>Required. The messages in the request will be published on this topic. Format is
                /// `projects/{project}/topics/{topic}`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("topic", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Topic { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.PublishRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "publish";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+topic}:publish";

                /// <summary>Initializes Publish parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "topic", new Google.Apis.Discovery.Parameter
                        {
                            Name = "topic",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/topics/[^/]+$",
                        });
                }

            }

            /// <summary>Sets the access control policy on the specified resource. Replaces any existing policy. Can
            /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">REQUIRED: The resource for which the policy is being specified. See the operation
            /// documentation for the appropriate value for this field.</param>
            public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest body, string resource)
            {
                return new SetIamPolicyRequest(service, body, resource);
            }

            /// <summary>Sets the access control policy on the specified resource. Replaces any existing policy. Can
            /// return `NOT_FOUND`, `INVALID_ARGUMENT`, and `PERMISSION_DENIED` errors.</summary>
            public class SetIamPolicyRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.Policy>
            {
                /// <summary>Constructs a new SetIamPolicy request.</summary>
                public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest body, string resource)
                    : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }


                /// <summary>REQUIRED: The resource for which the policy is being specified. See the operation
                /// documentation for the appropriate value for this field.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.SetIamPolicyRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "setIamPolicy";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:setIamPolicy";

                /// <summary>Initializes SetIamPolicy parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/topics/[^/]+$",
                        });
                }

            }

            /// <summary>Returns permissions that a caller has on the specified resource. If the resource does not
            /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
            /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
            /// checking. This operation may "fail open" without warning.</summary>
            /// <param name="body">The body of the request.</param>
            /// <param name="resource">REQUIRED: The resource for which the policy detail is being requested. See the operation
            /// documentation for the appropriate value for this field.</param>
            public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest body, string resource)
            {
                return new TestIamPermissionsRequest(service, body, resource);
            }

            /// <summary>Returns permissions that a caller has on the specified resource. If the resource does not
            /// exist, this will return an empty set of permissions, not a `NOT_FOUND` error. Note: This operation is
            /// designed to be used for building permission-aware UIs and command-line tools, not for authorization
            /// checking. This operation may "fail open" without warning.</summary>
            public class TestIamPermissionsRequest : PubsubBaseServiceRequest<Google.Apis.Pubsub.v1.Data.TestIamPermissionsResponse>
            {
                /// <summary>Constructs a new TestIamPermissions request.</summary>
                public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest body, string resource)
                    : base(service)
                {
                    Resource = resource;
                    Body = body;
                    InitParameters();
                }


                /// <summary>REQUIRED: The resource for which the policy detail is being requested. See the operation
                /// documentation for the appropriate value for this field.</summary>
                [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Resource { get; private set; }


                /// <summary>Gets or sets the body of this request.</summary>
                Google.Apis.Pubsub.v1.Data.TestIamPermissionsRequest Body { get; set; }

                ///<summary>Returns the body of the request.</summary>
                protected override object GetBody() => Body;

                ///<summary>Gets the method name.</summary>
                public override string MethodName => "testIamPermissions";

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "POST";

                ///<summary>Gets the REST path.</summary>
                public override string RestPath => "v1/{+resource}:testIamPermissions";

                /// <summary>Initializes TestIamPermissions parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/topics/[^/]+$",
                        });
                }

            }
        }
    }
}

namespace Google.Apis.Pubsub.v1.Data
{    

    /// <summary>Request for the Acknowledge method.</summary>
    public class AcknowledgeRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The acknowledgment ID for the messages being acknowledged that was returned by the
        /// Pub/Sub system in the `Pull` response. Must not be empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackIds")]
        public virtual System.Collections.Generic.IList<string> AckIds { get; set; } 

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

    /// <summary>Request for the `CreateSnapshot` method.</summary>
    public class CreateSnapshotRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>See Creating and managing labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string,string> Labels { get; set; } 

        /// <summary>Required. The subscription whose backlog the snapshot retains. Specifically, the created snapshot
        /// is guaranteed to retain: (a) The existing backlog on the subscription. More precisely, this is defined as
        /// the messages in the subscription's backlog that are unacknowledged upon the successful completion of the
        /// `CreateSnapshot` request; as well as: (b) Any messages published to the subscription's topic following the
        /// successful completion of the CreateSnapshot request. Format is
        /// `projects/{project}/subscriptions/{sub}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual string Subscription { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Dead lettering is done on a best effort basis. The same message might be dead lettered multiple times.
    /// If validation on any of the fields fails at subscription creation/updation, the create/update subscription
    /// request will fail.</summary>
    public class DeadLetterPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the topic to which dead letter messages should be published. Format is
        /// `projects/{project}/topics/{topic}`.The Cloud Pub/Sub service account associated with the enclosing
        /// subscription's parent project (i.e., service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com) must
        /// have permission to Publish() to this topic. The operation will fail if the topic does not exist. Users
        /// should ensure that there is a subscription attached to this topic since messages published to a topic with
        /// no subscriptions are lost.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deadLetterTopic")]
        public virtual string DeadLetterTopic { get; set; } 

        /// <summary>The maximum number of delivery attempts for any message. The value must be between 5 and 100. The
        /// number of delivery attempts is defined as 1 + (the sum of number of NACKs and number of times the
        /// acknowledgement deadline has been exceeded for the message). A NACK is any call to ModifyAckDeadline with a
        /// 0 deadline. Note that client libraries may automatically extend ack_deadlines. This field will be honored on
        /// a best effort basis. If this parameter is 0, a default value of 5 is used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxDeliveryAttempts")]
        public virtual System.Nullable<int> MaxDeliveryAttempts { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for the DetachSubscription method. Reserved for future use.</summary>
    public class DetachSubscriptionResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A
    /// typical example is to use it as the request or the response type of an API method. For instance: service Foo {
    /// rpc Bar(google.protobuf.Empty) returns (google.protobuf.Empty); } The JSON representation for `Empty` is empty
    /// JSON object `{}`.</summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A policy that specifies the conditions for resource expiration (i.e., automatic resource
    /// deletion).</summary>
    public class ExpirationPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Specifies the "time-to-live" duration for an associated resource. The resource expires if it is not
        /// active for a period of `ttl`. The definition of "activity" depends on the type of the associated resource.
        /// The minimum and maximum allowed values for `ttl` depend on the type of the associated resource, as well. If
        /// `ttl` is not set, the associated resource never expires.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ttl")]
        public virtual object Ttl { get; set; } 

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

    /// <summary>Response for the `ListSnapshots` method.</summary>
    public class ListSnapshotsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If not empty, indicates that there may be more snapshot that match the request; this value should
        /// be passed in a new `ListSnapshotsRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The resulting snapshots.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshots")]
        public virtual System.Collections.Generic.IList<Snapshot> Snapshots { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for the `ListSubscriptions` method.</summary>
    public class ListSubscriptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If not empty, indicates that there may be more subscriptions that match the request; this value
        /// should be passed in a new `ListSubscriptionsRequest` to get more subscriptions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The subscriptions that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptions")]
        public virtual System.Collections.Generic.IList<Subscription> Subscriptions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for the `ListTopicSnapshots` method.</summary>
    public class ListTopicSnapshotsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If not empty, indicates that there may be more snapshots that match the request; this value should
        /// be passed in a new `ListTopicSnapshotsRequest` to get more snapshots.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The names of the snapshots that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshots")]
        public virtual System.Collections.Generic.IList<string> Snapshots { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for the `ListTopicSubscriptions` method.</summary>
    public class ListTopicSubscriptionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If not empty, indicates that there may be more subscriptions that match the request; this value
        /// should be passed in a new `ListTopicSubscriptionsRequest` to get more subscriptions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The names of subscriptions attached to the topic specified in the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscriptions")]
        public virtual System.Collections.Generic.IList<string> Subscriptions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for the `ListTopics` method.</summary>
    public class ListTopicsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If not empty, indicates that there may be more topics that match the request; this value should be
        /// passed in a new `ListTopicsRequest`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>The resulting topics.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topics")]
        public virtual System.Collections.Generic.IList<Topic> Topics { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A policy constraining the storage of messages published to the topic.</summary>
    public class MessageStoragePolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of IDs of GCP regions where messages that are published to the topic may be persisted in
        /// storage. Messages published by publishers running in non-allowed GCP regions (or running outside of GCP
        /// altogether) will be routed for storage in one of the allowed regions. An empty list means that no regions
        /// are allowed, and is not a valid configuration.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("allowedPersistenceRegions")]
        public virtual System.Collections.Generic.IList<string> AllowedPersistenceRegions { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request for the ModifyAckDeadline method.</summary>
    public class ModifyAckDeadlineRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The new ack deadline with respect to the time this request was sent to the Pub/Sub
        /// system. For example, if the value is 10, the new ack deadline will expire 10 seconds after the
        /// `ModifyAckDeadline` call was made. Specifying zero might immediately make the message available for delivery
        /// to another subscriber client. This typically results in an increase in the rate of message redeliveries
        /// (that is, duplicates). The minimum deadline you can specify is 0 seconds. The maximum deadline you can
        /// specify is 600 seconds (10 minutes).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackDeadlineSeconds")]
        public virtual System.Nullable<int> AckDeadlineSeconds { get; set; } 

        /// <summary>Required. List of acknowledgment IDs.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackIds")]
        public virtual System.Collections.Generic.IList<string> AckIds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request for the ModifyPushConfig method.</summary>
    public class ModifyPushConfigRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The push configuration for future deliveries. An empty `pushConfig` indicates that the
        /// Pub/Sub system should stop pushing messages from the given subscription and allow messages to be pulled and
        /// acknowledged - effectively pausing the subscription if `Pull` or `StreamingPull` is not called.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushConfig")]
        public virtual PushConfig PushConfig { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Contains information needed for generating an [OpenID Connect
    /// token](https://developers.google.com/identity/protocols/OpenIDConnect).</summary>
    public class OidcToken : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Audience to be used when generating OIDC token. The audience claim identifies the recipients that
        /// the JWT is intended for. The audience value is a single case-sensitive string. Having multiple values
        /// (array) for the audience field is not supported. More info about the OIDC JWT token audience here:
        /// https://tools.ietf.org/html/rfc7519#section-4.1.3 Note: if not specified, the Push endpoint URL will be
        /// used.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("audience")]
        public virtual string Audience { get; set; } 

        /// <summary>[Service account email](https://cloud.google.com/iam/docs/service-accounts) to be used for
        /// generating the OIDC token. The caller (for CreateSubscription, UpdateSubscription, and ModifyPushConfig
        /// RPCs) must have the iam.serviceAccounts.actAs permission for the service account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountEmail")]
        public virtual string ServiceAccountEmail { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud
    /// resources. A `Policy` is a collection of `bindings`. A `binding` binds one or more `members` to a single `role`.
    /// Members can be user accounts, service accounts, Google groups, and domains (such as G Suite). A `role` is a
    /// named list of permissions; each `role` can be an IAM predefined role or a user-created custom role. For some
    /// types of Google Cloud resources, a `binding` can also specify a `condition`, which is a logical expression that
    /// allows access to a resource only if the expression evaluates to `true`. A condition can add constraints based on
    /// attributes of the request, the resource, or both. To learn which resources support conditions in their IAM
    /// policies, see the [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON
    /// example:** { "bindings": [ { "role": "roles/resourcemanager.organizationAdmin", "members": [
    /// "user:mike@example.com", "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-
    /// id@appspot.gserviceaccount.com" ] }, { "role": "roles/resourcemanager.organizationViewer", "members": [
    /// "user:eve@example.com" ], "condition": { "title": "expirable access", "description": "Does not grant access
    /// after Sep 2020", "expression": "request.time < timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag":
    /// "BwWWja0YfJA=", "version": 3 } **YAML example:** bindings: - members: - user:mike@example.com -
    /// group:admins@example.com - domain:google.com - serviceAccount:my-project-id@appspot.gserviceaccount.com role:
    /// roles/resourcemanager.organizationAdmin - members: - user:eve@example.com role:
    /// roles/resourcemanager.organizationViewer condition: title: expirable access description: Does not grant access
    /// after Sep 2020 expression: request.time < timestamp('2020-10-01T00:00:00.000Z') - etag: BwWWja0YfJA= - version:
    /// 3 For a description of IAM and its features, see the [IAM
    /// documentation](https://cloud.google.com/iam/docs/).</summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Associates a list of `members` to a `role`. Optionally, may specify a `condition` that determines
        /// how and when the `bindings` are applied. Each of the `bindings` must contain at least one member.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; } 

        /// <summary>`etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of
        /// a policy from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `getIamPolicy`, and systems are expected to put that etag in the request to
        /// `setIamPolicy` to ensure that their change will be applied to the same version of the policy. **Important:**
        /// If you use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit
        /// this field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; } 

        /// <summary>Specifies the format of the policy. Valid values are `0`, `1`, and `3`. Requests that specify an
        /// invalid value are rejected. Any operation that affects conditional role bindings must specify version `3`.
        /// This requirement applies to the following operations: * Getting a policy that includes a conditional role
        /// binding * Adding a conditional role binding to a policy * Changing a conditional role binding in a policy *
        /// Removing any role binding, with or without a condition, from a policy that includes conditions
        /// **Important:** If you use IAM Conditions, you must include the `etag` field whenever you call
        /// `setIamPolicy`. If you omit this field, then IAM allows you to overwrite a version `3` policy with a version
        /// `1` policy, and all of the conditions in the version `3` policy are lost. If a policy does not include any
        /// conditions, operations on that policy may specify any valid version or leave the field unset. To learn which
        /// resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; } 

    }    

    /// <summary>Request for the Publish method.</summary>
    public class PublishRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The messages to publish.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messages")]
        public virtual System.Collections.Generic.IList<PubsubMessage> Messages { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for the `Publish` method.</summary>
    public class PublishResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The server-assigned ID of each published message, in the same order as the messages in the request.
        /// IDs are guaranteed to be unique within the topic.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageIds")]
        public virtual System.Collections.Generic.IList<string> MessageIds { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A message that is published by publishers and consumed by subscribers. The message must contain either
    /// a non-empty data field or at least one attribute. Note that client libraries represent this object differently
    /// depending on the language. See the corresponding [client library
    /// documentation](https://cloud.google.com/pubsub/docs/reference/libraries) for more information. See [quotas and
    /// limits] (https://cloud.google.com/pubsub/quotas) for more information about message limits.</summary>
    public class PubsubMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Attributes for this message. If this field is empty, the message must contain non-empty data. This
        /// can be used to filter messages on the subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string,string> Attributes { get; set; } 

        /// <summary>The message data field. If this field is empty, the message must contain at least one
        /// attribute.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("data")]
        public virtual string Data { get; set; } 

        /// <summary>ID of this message, assigned by the server when the message is published. Guaranteed to be unique
        /// within the topic. This value may be read by a subscriber that receives a `PubsubMessage` via a `Pull` call
        /// or a push delivery. It must not be populated by the publisher in a `Publish` call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageId")]
        public virtual string MessageId { get; set; } 

        /// <summary>If non-empty, identifies related messages for which publish order should be respected. If a
        /// `Subscription` has `enable_message_ordering` set to `true`, messages published with the same non-empty
        /// `ordering_key` value will be delivered to subscribers in the order in which they are received by the Pub/Sub
        /// system. All `PubsubMessage`s published in a given `PublishRequest` must specify the same `ordering_key`
        /// value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orderingKey")]
        public virtual string OrderingKey { get; set; } 

        /// <summary>The time at which the message was published, populated by the server when it receives the `Publish`
        /// call. It must not be populated by the publisher in a `Publish` call.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publishTime")]
        public virtual object PublishTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request for the `Pull` method.</summary>
    public class PullRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The maximum number of messages to return for this request. Must be a positive integer.
        /// The Pub/Sub system may return fewer than the number specified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maxMessages")]
        public virtual System.Nullable<int> MaxMessages { get; set; } 

        /// <summary>Optional. If this field set to true, the system will respond immediately even if it there are no
        /// messages available to return in the `Pull` response. Otherwise, the system may wait (for a bounded amount of
        /// time) until at least one message is available, rather than returning no messages. Warning: setting this
        /// field to `true` is discouraged because it adversely impacts the performance of `Pull` operations. We
        /// recommend that users do not set this field.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("returnImmediately")]
        public virtual System.Nullable<bool> ReturnImmediately { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for the `Pull` method.</summary>
    public class PullResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Received Pub/Sub messages. The list will be empty if there are no more messages available in the
        /// backlog. For JSON, the response can be entirely empty. The Pub/Sub system may return fewer than the
        /// `maxMessages` requested even if there are more messages available in the backlog.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("receivedMessages")]
        public virtual System.Collections.Generic.IList<ReceivedMessage> ReceivedMessages { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Configuration for a push delivery endpoint.</summary>
    public class PushConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Endpoint configuration attributes that can be used to control different aspects of the message
        /// delivery. The only currently supported attribute is `x-goog-version`, which you can use to change the format
        /// of the pushed message. This attribute indicates the version of the data expected by the endpoint. This
        /// controls the shape of the pushed message (i.e., its fields and metadata). If not present during the
        /// `CreateSubscription` call, it will default to the version of the Pub/Sub API used to make such call. If not
        /// present in a `ModifyPushConfig` call, its value will not be changed. `GetSubscription` calls will always
        /// return a valid version, even if the subscription was created without this attribute. The only supported
        /// values for the `x-goog-version` attribute are: * `v1beta1`: uses the push format defined in the v1beta1
        /// Pub/Sub API. * `v1` or `v1beta2`: uses the push format defined in the v1 Pub/Sub API. For example:
        /// attributes { "x-goog-version": "v1" } </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attributes")]
        public virtual System.Collections.Generic.IDictionary<string,string> Attributes { get; set; } 

        /// <summary>If specified, Pub/Sub will generate and attach an OIDC JWT token as an `Authorization` header in
        /// the HTTP request for every pushed message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("oidcToken")]
        public virtual OidcToken OidcToken { get; set; } 

        /// <summary>A URL locating the endpoint to which messages should be pushed. For example, a Webhook endpoint
        /// might use `https://example.com/push`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushEndpoint")]
        public virtual string PushEndpoint { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A message and its corresponding acknowledgment ID.</summary>
    public class ReceivedMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This ID can be used to acknowledge the received message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackId")]
        public virtual string AckId { get; set; } 

        /// <summary>The approximate number of times that Cloud Pub/Sub has attempted to deliver the associated message
        /// to a subscriber. More precisely, this is 1 + (number of NACKs) + (number of ack_deadline exceeds) for this
        /// message. A NACK is any call to ModifyAckDeadline with a 0 deadline. An ack_deadline exceeds event is
        /// whenever a message is not acknowledged within ack_deadline. Note that ack_deadline is initially
        /// Subscription.ackDeadlineSeconds, but may get extended automatically by the client library. Upon the first
        /// delivery of a given message, `delivery_attempt` will have a value of 1. The value is calculated at best
        /// effort and is approximate. If a DeadLetterPolicy is not set on the subscription, this will be 0.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deliveryAttempt")]
        public virtual System.Nullable<int> DeliveryAttempt { get; set; } 

        /// <summary>The message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual PubsubMessage Message { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A policy that specifies how Cloud Pub/Sub retries message delivery. Retry delay will be exponential
    /// based on provided minimum and maximum backoffs. https://en.wikipedia.org/wiki/Exponential_backoff. RetryPolicy
    /// will be triggered on NACKs or acknowledgement deadline exceeded events for a given message. Retry Policy is
    /// implemented on a best effort basis. At times, the delay between consecutive deliveries may not match the
    /// configuration. That is, delay can be more or less than configured backoff.</summary>
    public class RetryPolicy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The maximum delay between consecutive deliveries of a given message. Value should be between 0 and
        /// 600 seconds. Defaults to 600 seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("maximumBackoff")]
        public virtual object MaximumBackoff { get; set; } 

        /// <summary>The minimum delay between consecutive deliveries of a given message. Value should be between 0 and
        /// 600 seconds. Defaults to 10 seconds.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("minimumBackoff")]
        public virtual object MinimumBackoff { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request for the `Seek` method.</summary>
    public class SeekRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The snapshot to seek to. The snapshot's topic must be the same as that of the provided
        /// subscription. Format is `projects/{project}/snapshots/{snap}`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshot")]
        public virtual string Snapshot { get; set; } 

        /// <summary>The time to seek to. Messages retained in the subscription that were published before this time are
        /// marked as acknowledged, and messages retained in the subscription that were published after this time are
        /// marked as unacknowledged. Note that this operation affects only those messages retained in the subscription
        /// (configured by the combination of `message_retention_duration` and `retain_acked_messages`). For example, if
        /// `time` corresponds to a point before the message retention window (or to a point before the system's notion
        /// of the subscription creation time), only retained messages will be marked as unacknowledged, and already-
        /// expunged messages will not be restored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("time")]
        public virtual object Time { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Response for the `Seek` method (this response is empty).</summary>
    public class SeekResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to
        /// a few 10s of KB. An empty policy is a valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A snapshot resource. Snapshots are used in [Seek](https://cloud.google.com/pubsub/docs/replay-overview)
    /// operations, which allow you to manage message acknowledgments in bulk. That is, you can set the acknowledgment
    /// state of messages in an existing subscription to the state captured by a snapshot.</summary>
    public class Snapshot : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The snapshot is guaranteed to exist up until this time. A newly-created snapshot expires no later
        /// than 7 days from the time of its creation. Its exact lifetime is determined at creation by the existing
        /// backlog in the source subscription. Specifically, the lifetime of the snapshot is `7 days - (age of oldest
        /// unacked message in the subscription)`. For example, consider a subscription whose oldest unacked message is
        /// 3 days old. If a snapshot is created from this subscription, the snapshot -- which will always capture this
        /// 3-day-old backlog as long as the snapshot exists -- will expire in 4 days. The service will refuse to create
        /// a snapshot that would expire in less than 1 hour after creation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expireTime")]
        public virtual object ExpireTime { get; set; } 

        /// <summary>See [Creating and managing labels] (https://cloud.google.com/pubsub/docs/labels).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string,string> Labels { get; set; } 

        /// <summary>The name of the snapshot.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The name of the topic from which this snapshot is retaining messages.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A subscription resource.</summary>
    public class Subscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The approximate amount of time (on a best-effort basis) Pub/Sub waits for the subscriber to
        /// acknowledge receipt before resending the message. In the interval after the message is delivered and before
        /// it is acknowledged, it is considered to be *outstanding*. During that time period, the message will not be
        /// redelivered (on a best-effort basis). For pull subscriptions, this value is used as the initial value for
        /// the ack deadline. To override this value for a given message, call `ModifyAckDeadline` with the
        /// corresponding `ack_id` if using non-streaming pull or send the `ack_id` in a
        /// `StreamingModifyAckDeadlineRequest` if using streaming pull. The minimum custom deadline you can specify is
        /// 10 seconds. The maximum custom deadline you can specify is 600 seconds (10 minutes). If this parameter is 0,
        /// a default value of 10 seconds is used. For push delivery, this value is also used to set the request timeout
        /// for the call to the push endpoint. If the subscriber never acknowledges the message, the Pub/Sub system will
        /// eventually redeliver the message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ackDeadlineSeconds")]
        public virtual System.Nullable<int> AckDeadlineSeconds { get; set; } 

        /// <summary>A policy that specifies the conditions for dead lettering messages in this subscription. If
        /// dead_letter_policy is not set, dead lettering is disabled. The Cloud Pub/Sub service account associated with
        /// this subscriptions's parent project (i.e., service-{project_number}@gcp-sa-pubsub.iam.gserviceaccount.com)
        /// must have permission to Acknowledge() messages on this subscription.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deadLetterPolicy")]
        public virtual DeadLetterPolicy DeadLetterPolicy { get; set; } 

        /// <summary>Indicates whether the subscription is detached from its topic. Detached subscriptions don't receive
        /// messages from their topic and don't retain any backlog. `Pull` and `StreamingPull` requests will return
        /// FAILED_PRECONDITION. If the subscription is a push subscription, pushes to the endpoint will not be
        /// made.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detached")]
        public virtual System.Nullable<bool> Detached { get; set; } 

        /// <summary>If true, messages published with the same `ordering_key` in `PubsubMessage` will be delivered to
        /// the subscribers in the order in which they are received by the Pub/Sub system. Otherwise, they may be
        /// delivered in any order.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("enableMessageOrdering")]
        public virtual System.Nullable<bool> EnableMessageOrdering { get; set; } 

        /// <summary>A policy that specifies the conditions for this subscription's expiration. A subscription is
        /// considered active as long as any connected subscriber is successfully consuming messages from the
        /// subscription or is issuing operations on the subscription. If `expiration_policy` is not set, a *default
        /// policy* with `ttl` of 31 days will be used. The minimum allowed value for `expiration_policy.ttl` is 1
        /// day.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationPolicy")]
        public virtual ExpirationPolicy ExpirationPolicy { get; set; } 

        /// <summary>An expression written in the Pub/Sub [filter
        /// language](https://cloud.google.com/pubsub/docs/filtering). If non-empty, then only `PubsubMessage`s whose
        /// `attributes` field matches the filter are delivered on this subscription. If empty, then no messages are
        /// filtered out.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; } 

        /// <summary>See Creating and managing labels.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string,string> Labels { get; set; } 

        /// <summary>How long to retain unacknowledged messages in the subscription's backlog, from the moment a message
        /// is published. If `retain_acked_messages` is true, then this also configures the retention of acknowledged
        /// messages, and thus configures how far back in time a `Seek` can be done. Defaults to 7 days. Cannot be more
        /// than 7 days or less than 10 minutes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageRetentionDuration")]
        public virtual object MessageRetentionDuration { get; set; } 

        /// <summary>Required. The name of the subscription. It must have the format
        /// `"projects/{project}/subscriptions/{subscription}"`. `{subscription}` must start with a letter, and contain
        /// only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`), underscores (`_`), periods (`.`), tildes (`~`),
        /// plus (`+`) or percent signs (`%`). It must be between 3 and 255 characters in length, and it must not start
        /// with `"goog"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>If push delivery is used with this subscription, this field is used to configure it. An empty
        /// `pushConfig` signifies that the subscriber will pull and ack messages using API methods.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pushConfig")]
        public virtual PushConfig PushConfig { get; set; } 

        /// <summary>Indicates whether to retain acknowledged messages. If true, then messages are not expunged from the
        /// subscription's backlog, even if they are acknowledged, until they fall out of the
        /// `message_retention_duration` window. This must be true if you would like to [Seek to a timestamp]
        /// (https://cloud.google.com/pubsub/docs/replay-overview#seek_to_a_time).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retainAckedMessages")]
        public virtual System.Nullable<bool> RetainAckedMessages { get; set; } 

        /// <summary>A policy that specifies how Pub/Sub retries message delivery for this subscription. If not set, the
        /// default retry policy is applied. This generally implies that messages will be retried as soon as possible
        /// for healthy subscribers. RetryPolicy will be triggered on NACKs or acknowledgement deadline exceeded events
        /// for a given message.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("retryPolicy")]
        public virtual RetryPolicy RetryPolicy { get; set; } 

        /// <summary>Required. The name of the topic from which this subscription is receiving messages. Format is
        /// `projects/{project}/topics/{topic}`. The value of this field will be `_deleted-topic_` if the topic has been
        /// deleted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual string Topic { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The set of permissions to check for the `resource`. Permissions with wildcards (such as '*' or
        /// 'storage.*') are not allowed. For more information see [IAM
        /// Overview](https://cloud.google.com/iam/docs/overview#permissions).</summary>
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

    /// <summary>A topic resource.</summary>
    public class Topic : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The resource name of the Cloud KMS CryptoKey to be used to protect access to messages published on
        /// this topic. The expected format is `projects/locations/keyRings/cryptoKeys`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kmsKeyName")]
        public virtual string KmsKeyName { get; set; } 

        /// <summary>See [Creating and managing labels] (https://cloud.google.com/pubsub/docs/labels).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string,string> Labels { get; set; } 

        /// <summary>Policy constraining the set of Google Cloud Platform regions where messages published to the topic
        /// may be stored. If not present, then no constraints are in effect.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("messageStoragePolicy")]
        public virtual MessageStoragePolicy MessageStoragePolicy { get; set; } 

        /// <summary>Required. The name of the topic. It must have the format `"projects/{project}/topics/{topic}"`.
        /// `{topic}` must start with a letter, and contain only letters (`[A-Za-z]`), numbers (`[0-9]`), dashes (`-`),
        /// underscores (`_`), periods (`.`), tildes (`~`), plus (`+`) or percent signs (`%`). It must be between 3 and
        /// 255 characters in length, and it must not start with `"goog"`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request for the UpdateSnapshot method.</summary>
    public class UpdateSnapshotRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The updated snapshot object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("snapshot")]
        public virtual Snapshot Snapshot { get; set; } 

        /// <summary>Required. Indicates which fields in the provided snapshot to update. Must be specified and non-
        /// empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request for the UpdateSubscription method.</summary>
    public class UpdateSubscriptionRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The updated subscription object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subscription")]
        public virtual Subscription Subscription { get; set; } 

        /// <summary>Required. Indicates which fields in the provided subscription to update. Must be specified and non-
        /// empty.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Request for the UpdateTopic method.</summary>
    public class UpdateTopicRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The updated topic object.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("topic")]
        public virtual Topic Topic { get; set; } 

        /// <summary>Required. Indicates which fields in the provided topic to update. Must be specified and non-empty.
        /// Note that if `update_mask` contains "message_storage_policy" but the `message_storage_policy` is not set in
        /// the `topic` provided above, then the updated value is determined by the policy configured at the project or
        /// organization level.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateMask")]
        public virtual object UpdateMask { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
