// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.Webmasters.v3
{
    /// <summary>The Webmasters Service.</summary>
    public class WebmastersService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v3";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public WebmastersService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public WebmastersService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            Searchanalytics = new SearchanalyticsResource(this);
            Sitemaps = new SitemapsResource(this);
            Sites = new SitesResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "webmasters";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://www.googleapis.com/webmasters/v3/";
        #else
            "https://www.googleapis.com/webmasters/v3/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "webmasters/v3/";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://www.googleapis.com/batch/webmasters/v3";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch/webmasters/v3";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Search Console API.</summary>
        public class Scope
        {
            /// <summary>View and manage Search Console data for your verified sites</summary>
            public static string Webmasters = "https://www.googleapis.com/auth/webmasters";

            /// <summary>View Search Console data for your verified sites</summary>
            public static string WebmastersReadonly = "https://www.googleapis.com/auth/webmasters.readonly";

        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Search Console API.</summary>
        public static class ScopeConstants
        {
            /// <summary>View and manage Search Console data for your verified sites</summary>
            public const string Webmasters = "https://www.googleapis.com/auth/webmasters";

            /// <summary>View Search Console data for your verified sites</summary>
            public const string WebmastersReadonly = "https://www.googleapis.com/auth/webmasters.readonly";

        }



        /// <summary>Gets the Searchanalytics resource.</summary>
        public virtual SearchanalyticsResource Searchanalytics { get; }

        /// <summary>Gets the Sitemaps resource.</summary>
        public virtual SitemapsResource Sitemaps { get; }

        /// <summary>Gets the Sites resource.</summary>
        public virtual SitesResource Sites { get; }
    }

    ///<summary>A base abstract class for Webmasters requests.</summary>
    public abstract class WebmastersBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new WebmastersBaseServiceRequest instance.</summary>
        protected WebmastersBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>Data format for the response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for the response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
        }

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

        /// <summary>An opaque string that represents a user for quota purposes. Must not exceed 40
        /// characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Deprecated. Please use quotaUser instead.</summary>
        [Google.Apis.Util.RequestParameterAttribute("userIp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UserIp { get; set; }

        /// <summary>Initializes Webmasters parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

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
                "userIp", new Google.Apis.Discovery.Parameter
                {
                    Name = "userIp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "searchanalytics" collection of methods.</summary>
    public class SearchanalyticsResource
    {
        private const string Resource = "searchanalytics";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SearchanalyticsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Query your data with filters and parameters that you define. Returns zero or more rows grouped by
        /// the row keys that you define. You must define a date range of one or more days.
        ///
        /// When date is one of the group by values, any days without data are omitted from the result list. If you need
        /// to know which days have data, issue a broad date range query grouped by date for any metric, and see which
        /// day rows are returned.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="siteUrl">The site's URL, including protocol. For example: http://www.example.com/</param>
        public virtual QueryRequest Query(Google.Apis.Webmasters.v3.Data.SearchAnalyticsQueryRequest body, string siteUrl)
        {
            return new QueryRequest(service, body, siteUrl);
        }

        /// <summary>Query your data with filters and parameters that you define. Returns zero or more rows grouped by
        /// the row keys that you define. You must define a date range of one or more days.
        ///
        /// When date is one of the group by values, any days without data are omitted from the result list. If you need
        /// to know which days have data, issue a broad date range query grouped by date for any metric, and see which
        /// day rows are returned.</summary>
        public class QueryRequest : WebmastersBaseServiceRequest<Google.Apis.Webmasters.v3.Data.SearchAnalyticsQueryResponse>
        {
            /// <summary>Constructs a new Query request.</summary>
            public QueryRequest(Google.Apis.Services.IClientService service, Google.Apis.Webmasters.v3.Data.SearchAnalyticsQueryRequest body, string siteUrl)
                : base(service)
            {
                SiteUrl = siteUrl;
                Body = body;
                InitParameters();
            }


            /// <summary>The site's URL, including protocol. For example: http://www.example.com/</summary>
            [Google.Apis.Util.RequestParameterAttribute("siteUrl", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SiteUrl { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.Webmasters.v3.Data.SearchAnalyticsQueryRequest Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            ///<summary>Gets the method name.</summary>
            public override string MethodName => "query";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "POST";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "sites/{siteUrl}/searchAnalytics/query";

            /// <summary>Initializes Query parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "siteUrl", new Google.Apis.Discovery.Parameter
                    {
                        Name = "siteUrl",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "sitemaps" collection of methods.</summary>
    public class SitemapsResource
    {
        private const string Resource = "sitemaps";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SitemapsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Deletes a sitemap from this site.</summary>
        /// <param name="siteUrl">The site's URL, including protocol. For example: http://www.example.com/</param>
        ///
        /// <param name="feedpath">The URL of the actual sitemap. For example: http://www.example.com/sitemap.xml</param>
        public virtual DeleteRequest Delete(string siteUrl, string feedpath)
        {
            return new DeleteRequest(service, siteUrl, feedpath);
        }

        /// <summary>Deletes a sitemap from this site.</summary>
        public class DeleteRequest : WebmastersBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string siteUrl, string feedpath)
                : base(service)
            {
                SiteUrl = siteUrl;
                Feedpath = feedpath;
                InitParameters();
            }


            /// <summary>The site's URL, including protocol. For example: http://www.example.com/</summary>
            [Google.Apis.Util.RequestParameterAttribute("siteUrl", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SiteUrl { get; private set; }

            /// <summary>The URL of the actual sitemap. For example: http://www.example.com/sitemap.xml</summary>
            [Google.Apis.Util.RequestParameterAttribute("feedpath", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Feedpath { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "sites/{siteUrl}/sitemaps/{feedpath}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "siteUrl", new Google.Apis.Discovery.Parameter
                    {
                        Name = "siteUrl",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "feedpath", new Google.Apis.Discovery.Parameter
                    {
                        Name = "feedpath",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves information about a specific sitemap.</summary>
        /// <param name="siteUrl">The site's URL, including protocol. For example: http://www.example.com/</param>
        ///
        /// <param name="feedpath">The URL of the actual sitemap. For example: http://www.example.com/sitemap.xml</param>
        public virtual GetRequest Get(string siteUrl, string feedpath)
        {
            return new GetRequest(service, siteUrl, feedpath);
        }

        /// <summary>Retrieves information about a specific sitemap.</summary>
        public class GetRequest : WebmastersBaseServiceRequest<Google.Apis.Webmasters.v3.Data.WmxSitemap>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string siteUrl, string feedpath)
                : base(service)
            {
                SiteUrl = siteUrl;
                Feedpath = feedpath;
                InitParameters();
            }


            /// <summary>The site's URL, including protocol. For example: http://www.example.com/</summary>
            [Google.Apis.Util.RequestParameterAttribute("siteUrl", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SiteUrl { get; private set; }

            /// <summary>The URL of the actual sitemap. For example: http://www.example.com/sitemap.xml</summary>
            [Google.Apis.Util.RequestParameterAttribute("feedpath", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Feedpath { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "sites/{siteUrl}/sitemaps/{feedpath}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "siteUrl", new Google.Apis.Discovery.Parameter
                    {
                        Name = "siteUrl",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "feedpath", new Google.Apis.Discovery.Parameter
                    {
                        Name = "feedpath",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists the sitemaps-entries submitted for this site, or included in the sitemap index file (if
        /// sitemapIndex is specified in the request).</summary>
        /// <param name="siteUrl">The site's URL, including protocol. For example: http://www.example.com/</param>
        public virtual ListRequest List(string siteUrl)
        {
            return new ListRequest(service, siteUrl);
        }

        /// <summary>Lists the sitemaps-entries submitted for this site, or included in the sitemap index file (if
        /// sitemapIndex is specified in the request).</summary>
        public class ListRequest : WebmastersBaseServiceRequest<Google.Apis.Webmasters.v3.Data.SitemapsListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service, string siteUrl)
                : base(service)
            {
                SiteUrl = siteUrl;
                InitParameters();
            }


            /// <summary>The site's URL, including protocol. For example: http://www.example.com/</summary>
            [Google.Apis.Util.RequestParameterAttribute("siteUrl", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SiteUrl { get; private set; }

            /// <summary>A URL of a site's sitemap index. For example: http://www.example.com/sitemapindex.xml</summary>
            [Google.Apis.Util.RequestParameterAttribute("sitemapIndex", Google.Apis.Util.RequestParameterType.Query)]
            public virtual string SitemapIndex { get; set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "sites/{siteUrl}/sitemaps";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "siteUrl", new Google.Apis.Discovery.Parameter
                    {
                        Name = "siteUrl",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "sitemapIndex", new Google.Apis.Discovery.Parameter
                    {
                        Name = "sitemapIndex",
                        IsRequired = false,
                        ParameterType = "query",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Submits a sitemap for a site.</summary>
        /// <param name="siteUrl">The site's URL, including protocol. For example: http://www.example.com/</param>
        ///
        /// <param name="feedpath">The URL of the sitemap to add. For example: http://www.example.com/sitemap.xml</param>
        public virtual SubmitRequest Submit(string siteUrl, string feedpath)
        {
            return new SubmitRequest(service, siteUrl, feedpath);
        }

        /// <summary>Submits a sitemap for a site.</summary>
        public class SubmitRequest : WebmastersBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Submit request.</summary>
            public SubmitRequest(Google.Apis.Services.IClientService service, string siteUrl, string feedpath)
                : base(service)
            {
                SiteUrl = siteUrl;
                Feedpath = feedpath;
                InitParameters();
            }


            /// <summary>The site's URL, including protocol. For example: http://www.example.com/</summary>
            [Google.Apis.Util.RequestParameterAttribute("siteUrl", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SiteUrl { get; private set; }

            /// <summary>The URL of the sitemap to add. For example: http://www.example.com/sitemap.xml</summary>
            [Google.Apis.Util.RequestParameterAttribute("feedpath", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Feedpath { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "submit";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "sites/{siteUrl}/sitemaps/{feedpath}";

            /// <summary>Initializes Submit parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "siteUrl", new Google.Apis.Discovery.Parameter
                    {
                        Name = "siteUrl",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
                RequestParameters.Add(
                    "feedpath", new Google.Apis.Discovery.Parameter
                    {
                        Name = "feedpath",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }

    /// <summary>The "sites" collection of methods.</summary>
    public class SitesResource
    {
        private const string Resource = "sites";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public SitesResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;

        }


        /// <summary>Adds a site to the set of the user's sites in Search Console.</summary>
        /// <param name="siteUrl">The URL of the site to add.</param>
        public virtual AddRequest Add(string siteUrl)
        {
            return new AddRequest(service, siteUrl);
        }

        /// <summary>Adds a site to the set of the user's sites in Search Console.</summary>
        public class AddRequest : WebmastersBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Add request.</summary>
            public AddRequest(Google.Apis.Services.IClientService service, string siteUrl)
                : base(service)
            {
                SiteUrl = siteUrl;
                InitParameters();
            }


            /// <summary>The URL of the site to add.</summary>
            [Google.Apis.Util.RequestParameterAttribute("siteUrl", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SiteUrl { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "add";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PUT";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "sites/{siteUrl}";

            /// <summary>Initializes Add parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "siteUrl", new Google.Apis.Discovery.Parameter
                    {
                        Name = "siteUrl",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Removes a site from the set of the user's Search Console sites.</summary>
        /// <param name="siteUrl">The URI of the property as defined in Search Console. Examples: http://www.example.com/ or
        /// android-app://com.example/ Note: for property-sets, use the URI that starts with sc-set: which is used in Search
        /// Console URLs.</param>
        public virtual DeleteRequest Delete(string siteUrl)
        {
            return new DeleteRequest(service, siteUrl);
        }

        /// <summary>Removes a site from the set of the user's Search Console sites.</summary>
        public class DeleteRequest : WebmastersBaseServiceRequest<string>
        {
            /// <summary>Constructs a new Delete request.</summary>
            public DeleteRequest(Google.Apis.Services.IClientService service, string siteUrl)
                : base(service)
            {
                SiteUrl = siteUrl;
                InitParameters();
            }


            /// <summary>The URI of the property as defined in Search Console. Examples: http://www.example.com/ or
            /// android-app://com.example/ Note: for property-sets, use the URI that starts with sc-set: which is used
            /// in Search Console URLs.</summary>
            [Google.Apis.Util.RequestParameterAttribute("siteUrl", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SiteUrl { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "delete";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "DELETE";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "sites/{siteUrl}";

            /// <summary>Initializes Delete parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "siteUrl", new Google.Apis.Discovery.Parameter
                    {
                        Name = "siteUrl",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Retrieves information about specific site.</summary>
        /// <param name="siteUrl">The URI of the property as defined in Search Console. Examples: http://www.example.com/ or
        /// android-app://com.example/ Note: for property-sets, use the URI that starts with sc-set: which is used in Search
        /// Console URLs.</param>
        public virtual GetRequest Get(string siteUrl)
        {
            return new GetRequest(service, siteUrl);
        }

        /// <summary>Retrieves information about specific site.</summary>
        public class GetRequest : WebmastersBaseServiceRequest<Google.Apis.Webmasters.v3.Data.WmxSite>
        {
            /// <summary>Constructs a new Get request.</summary>
            public GetRequest(Google.Apis.Services.IClientService service, string siteUrl)
                : base(service)
            {
                SiteUrl = siteUrl;
                InitParameters();
            }


            /// <summary>The URI of the property as defined in Search Console. Examples: http://www.example.com/ or
            /// android-app://com.example/ Note: for property-sets, use the URI that starts with sc-set: which is used
            /// in Search Console URLs.</summary>
            [Google.Apis.Util.RequestParameterAttribute("siteUrl", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string SiteUrl { get; private set; }


            ///<summary>Gets the method name.</summary>
            public override string MethodName => "get";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "sites/{siteUrl}";

            /// <summary>Initializes Get parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "siteUrl", new Google.Apis.Discovery.Parameter
                    {
                        Name = "siteUrl",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }

        /// <summary>Lists the user's Search Console sites.</summary>
        public virtual ListRequest List()
        {
            return new ListRequest(service);
        }

        /// <summary>Lists the user's Search Console sites.</summary>
        public class ListRequest : WebmastersBaseServiceRequest<Google.Apis.Webmasters.v3.Data.SitesListResponse>
        {
            /// <summary>Constructs a new List request.</summary>
            public ListRequest(Google.Apis.Services.IClientService service)
                : base(service)
            {
                InitParameters();
            }



            ///<summary>Gets the method name.</summary>
            public override string MethodName => "list";

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            ///<summary>Gets the REST path.</summary>
            public override string RestPath => "sites";

            /// <summary>Initializes List parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

            }

        }
    }
}

namespace Google.Apis.Webmasters.v3.Data
{    

    public class ApiDataRow : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("clicks")]
        public virtual System.Nullable<double> Clicks { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("ctr")]
        public virtual System.Nullable<double> Ctr { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("impressions")]
        public virtual System.Nullable<double> Impressions { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("keys")]
        public virtual System.Collections.Generic.IList<string> Keys { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("position")]
        public virtual System.Nullable<double> Position { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ApiDimensionFilter : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("dimension")]
        public virtual string Dimension { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("operator")]
        public virtual string Operator__ { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class ApiDimensionFilterGroup : Google.Apis.Requests.IDirectResponseSchema
    {
        [Newtonsoft.Json.JsonPropertyAttribute("filters")]
        public virtual System.Collections.Generic.IList<ApiDimensionFilter> Filters { get; set; } 

        [Newtonsoft.Json.JsonPropertyAttribute("groupType")]
        public virtual string GroupType { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    public class SearchAnalyticsQueryRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>[Optional; Default is "auto"] How data is aggregated. If aggregated by property, all data for the
        /// same property is aggregated; if aggregated by page, all data is aggregated by canonical URI. If you filter
        /// or group by page, choose AUTO; otherwise you can aggregate either by property or by page, depending on how
        /// you want your data calculated; see  the help documentation to learn how data is calculated differently by
        /// site versus by page.
        ///
        /// Note: If you group or filter by page, you cannot aggregate by property.
        ///
        /// If you specify any value other than AUTO, the aggregation type in the result will match the requested type,
        /// or if you request an invalid type, you will get an error. The API will never change your aggregation type if
        /// the requested type is invalid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("aggregationType")]
        public virtual string AggregationType { get; set; } 

        /// <summary>[Optional] Zero or more filters to apply to the dimension grouping values; for example, 'query
        /// contains "buy"' to see only data where the query string contains the substring "buy" (not case-sensitive).
        /// You can filter by a dimension without grouping by it.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensionFilterGroups")]
        public virtual System.Collections.Generic.IList<ApiDimensionFilterGroup> DimensionFilterGroups { get; set; } 

        /// <summary>[Optional] Zero or more dimensions to group results by. Dimensions are the group-by values in the
        /// Search Analytics page. Dimensions are combined to create a unique row key for each row. Results are grouped
        /// in the order that you supply these dimensions.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dimensions")]
        public virtual System.Collections.Generic.IList<string> Dimensions { get; set; } 

        /// <summary>[Required] End date of the requested date range, in YYYY-MM-DD format, in PST (UTC - 8:00). Must be
        /// greater than or equal to the start date. This value is included in the range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endDate")]
        public virtual string EndDate { get; set; } 

        /// <summary>[Optional; Default is 1000] The maximum number of rows to return. Must be a number from 1 to 5,000
        /// (inclusive).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rowLimit")]
        public virtual System.Nullable<int> RowLimit { get; set; } 

        /// <summary>[Optional; Default is "web"] The search type to filter for.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("searchType")]
        public virtual string SearchType { get; set; } 

        /// <summary>[Required] Start date of the requested date range, in YYYY-MM-DD format, in PST time (UTC - 8:00).
        /// Must be less than or equal to the end date. This value is included in the range.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startDate")]
        public virtual string StartDate { get; set; } 

        /// <summary>[Optional; Default is 0] Zero-based index of the first row in the response. Must be a non-negative
        /// number.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startRow")]
        public virtual System.Nullable<int> StartRow { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A list of rows, one per result, grouped by key. Metrics in each row are aggregated for all data grouped
    /// by that key either by page or property, as specified by the aggregation type parameter.</summary>
    public class SearchAnalyticsQueryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>How the results were aggregated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("responseAggregationType")]
        public virtual string ResponseAggregationType { get; set; } 

        /// <summary>A list of rows grouped by the key values in the order given in the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("rows")]
        public virtual System.Collections.Generic.IList<ApiDataRow> Rows { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>List of sitemaps.</summary>
    public class SitemapsListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains detailed information about a specific URL submitted as a sitemap.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sitemap")]
        public virtual System.Collections.Generic.IList<WmxSitemap> Sitemap { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>List of sites with access level information.</summary>
    public class SitesListResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Contains permission level information about a Search Console site. For more information, see
        /// Permissions in Search Console.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteEntry")]
        public virtual System.Collections.Generic.IList<WmxSite> SiteEntry { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Contains permission level information about a Search Console site. For more information, see
    /// Permissions in Search Console.</summary>
    public class WmxSite : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The user's permission level for the site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissionLevel")]
        public virtual string PermissionLevel { get; set; } 

        /// <summary>The URL of the site.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("siteUrl")]
        public virtual string SiteUrl { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Contains detailed information about a specific URL submitted as a sitemap.</summary>
    public class WmxSitemap : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The various content types in the sitemap.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual System.Collections.Generic.IList<WmxSitemapContent> Contents { get; set; } 

        /// <summary>Number of errors in the sitemap. These are issues with the sitemap itself that need to be fixed
        /// before it can be processed correctly.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("errors")]
        public virtual System.Nullable<long> Errors { get; set; } 

        /// <summary>If true, the sitemap has not been processed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isPending")]
        public virtual System.Nullable<bool> IsPending { get; set; } 

        /// <summary>If true, the sitemap is a collection of sitemaps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("isSitemapsIndex")]
        public virtual System.Nullable<bool> IsSitemapsIndex { get; set; } 

        /// <summary>Date & time in which this sitemap was last downloaded. Date format is in RFC 3339 format (yyyy-mm-
        /// dd).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastDownloaded")]
        public virtual string LastDownloadedRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="LastDownloadedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnore]
        public virtual System.Nullable<System.DateTime> LastDownloaded
        {
            get
            {
                return Google.Apis.Util.Utilities.GetDateTimeFromString(LastDownloadedRaw);
            }
            set
            {
                LastDownloadedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }
        }

        /// <summary>Date & time in which this sitemap was submitted. Date format is in RFC 3339 format (yyyy-mm-
        /// dd).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastSubmitted")]
        public virtual string LastSubmittedRaw { get; set; }

        /// <summary><seealso cref="System.DateTime"/> representation of <see cref="LastSubmittedRaw"/>.</summary>
        [Newtonsoft.Json.JsonIgnore]
        public virtual System.Nullable<System.DateTime> LastSubmitted
        {
            get
            {
                return Google.Apis.Util.Utilities.GetDateTimeFromString(LastSubmittedRaw);
            }
            set
            {
                LastSubmittedRaw = Google.Apis.Util.Utilities.GetStringFromDateTime(value);
            }
        }

        /// <summary>The url of the sitemap.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; } 

        /// <summary>The type of the sitemap. For example: rssFeed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>Number of warnings for the sitemap. These are generally non-critical issues with URLs in the
        /// sitemaps.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("warnings")]
        public virtual System.Nullable<long> Warnings { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>Information about the various content types in the sitemap.</summary>
    public class WmxSitemapContent : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The number of URLs from the sitemap that were indexed (of the content type).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indexed")]
        public virtual System.Nullable<long> Indexed { get; set; } 

        /// <summary>The number of URLs in the sitemap (of the content type).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("submitted")]
        public virtual System.Nullable<long> Submitted { get; set; } 

        /// <summary>The specific type of content in this sitemap. For example: web.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
