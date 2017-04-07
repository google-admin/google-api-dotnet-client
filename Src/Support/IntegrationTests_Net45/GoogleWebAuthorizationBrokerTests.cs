﻿/*
Copyright 2017 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using Google.Apis.Auth.OAuth2;
using Google.Apis.Storage.v1;
using Google.Apis.Util.Store;
using NUnit.Framework;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace IntegrationTests
{
    [TestFixture]
    class GoogleWebAuthorizationBrokerTests
    {
        [Test]
        public async Task AuthClientSecret()
        {
            // Warning: This test is interactive!
            // It will bring up a browser window that must be responded to before the test can complete.

            // Test the initial authorization.
            // NullDataStore is used to ensure the AuthorizationUrl is definitely used.
            UserCredential cred = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                Helper.GetClientSecretStream(), new string[] { StorageService.Scope.CloudPlatformReadOnly },
                "user", CancellationToken.None, new NullDataStore());
            Assert.That(cred, Is.Not.Null);

            // Test access token can be retrieved.
            string token = await cred.GetAccessTokenForRequestAsync();
            Assert.That(token, Is.Not.Null);

            // Test token refresh succeeds.
            bool refreshed = await cred.RefreshTokenAsync(CancellationToken.None);
            Assert.That(refreshed, Is.True);
        }

        [Test]
        public void Cancellation()
        {
            // Warning: This test is pseudo-interactive!
            // It will bring up a browser window, but the test will complete without any interaction.

            // Test the initial authorization.
            // NullDataStore is used to ensure browser will definitely be shown.
            // Tests that the local listener will be cancelled properly.
            var cts = new CancellationTokenSource(TimeSpan.FromSeconds(1));

            Assert.That(async () =>
            {
                await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    Helper.GetClientSecretStream(), new string[] { StorageService.Scope.CloudPlatformReadOnly },
                    "user", cts.Token, new NullDataStore());
            }, Throws.TypeOf<TaskCanceledException>());
        }
    }
}
