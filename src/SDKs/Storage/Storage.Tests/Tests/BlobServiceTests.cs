// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.Azure.Management.Resources;
using Microsoft.Azure.Management.Storage;
using Microsoft.Azure.Management.Storage.Models;
using ResourceGroups.Tests;
using Storage.Tests.Helpers;
using Xunit;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Microsoft.Rest.Azure;
using Microsoft.Azure.KeyVault;
using Microsoft.Azure.Management.KeyVault;
using Microsoft.Rest.Azure.Authentication;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Threading.Tasks;
using Microsoft.Azure.Test.HttpRecorder;
using System.Net.Http;
using Microsoft.Azure.KeyVault.WebKey;

namespace Storage.Tests
{
    class BlobServiceTests
    {
        [Fact]
        public void BlobServiceSetPropertiesTest()
        {
            var handler = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK };

            using (MockContext context = MockContext.Start(this.GetType().FullName))
            {
                var resourcesClient = StorageManagementTestUtilities.GetResourceManagementClient(context, handler);
                var storageMgmtClient = StorageManagementTestUtilities.GetStorageManagementClient(context, handler);

                // Create resource group
                var rgname = StorageManagementTestUtilities.CreateResourceGroup(resourcesClient);

                // Create storage account
                string accountName = TestUtilities.GenerateName("sto");
                var parameters = StorageManagementTestUtilities.GetDefaultStorageAccountParameters();
                var account = storageMgmtClient.StorageAccounts.Create(rgname, accountName, parameters);
                StorageManagementTestUtilities.VerifyAccountProperties(account, true);

                string containerName = TestUtilities.GenerateName("container");
                storageMgmtClient.BlobService.GetProperties(rgname, accountName);
            }
        }
    }
}
