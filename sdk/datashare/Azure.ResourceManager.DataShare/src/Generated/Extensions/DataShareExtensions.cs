// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.DataShare.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataShare
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DataShare. </summary>
    public static partial class DataShareExtensions
    {
        private static TenantResourceExtensionClient GetExtensionClient(TenantResource tenantResource)
        {
            return tenantResource.GetCachedClient((client) =>
            {
                return new TenantResourceExtensionClient(client, tenantResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of DataShareConsumerInvitationResources in the TenantResource. </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DataShareConsumerInvitationResources and their operations over a DataShareConsumerInvitationResource. </returns>
        public static DataShareConsumerInvitationCollection GetDataShareConsumerInvitations(this TenantResource tenantResource)
        {
            return GetExtensionClient(tenantResource).GetDataShareConsumerInvitations();
        }

        /// <summary>
        /// Get an invitation
        /// Request Path: /providers/Microsoft.DataShare/locations/{location}/consumerInvitations/{invitationId}
        /// Operation Id: ConsumerInvitations_Get
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="location"> Location of the invitation. </param>
        /// <param name="invitationId"> An invitation id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public static async Task<Response<DataShareConsumerInvitationResource>> GetDataShareConsumerInvitationAsync(this TenantResource tenantResource, AzureLocation location, Guid invitationId, CancellationToken cancellationToken = default)
        {
            return await tenantResource.GetDataShareConsumerInvitations().GetAsync(location, invitationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get an invitation
        /// Request Path: /providers/Microsoft.DataShare/locations/{location}/consumerInvitations/{invitationId}
        /// Operation Id: ConsumerInvitations_Get
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="location"> Location of the invitation. </param>
        /// <param name="invitationId"> An invitation id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public static Response<DataShareConsumerInvitationResource> GetDataShareConsumerInvitation(this TenantResource tenantResource, AzureLocation location, Guid invitationId, CancellationToken cancellationToken = default)
        {
            return tenantResource.GetDataShareConsumerInvitations().Get(location, invitationId, cancellationToken);
        }

        /// <summary>
        /// Reject an invitation
        /// Request Path: /providers/Microsoft.DataShare/locations/{location}/rejectInvitation
        /// Operation Id: ConsumerInvitations_RejectInvitation
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="location"> Location of the invitation. </param>
        /// <param name="data"> An invitation payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public static async Task<Response<DataShareConsumerInvitationResource>> RejectConsumerInvitationAsync(this TenantResource tenantResource, AzureLocation location, DataShareConsumerInvitationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            return await GetExtensionClient(tenantResource).RejectConsumerInvitationAsync(location, data, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Reject an invitation
        /// Request Path: /providers/Microsoft.DataShare/locations/{location}/rejectInvitation
        /// Operation Id: ConsumerInvitations_RejectInvitation
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="location"> Location of the invitation. </param>
        /// <param name="data"> An invitation payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public static Response<DataShareConsumerInvitationResource> RejectConsumerInvitation(this TenantResource tenantResource, AzureLocation location, DataShareConsumerInvitationData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            return GetExtensionClient(tenantResource).RejectConsumerInvitation(location, data, cancellationToken);
        }

        /// <summary>
        /// Activate the email registration for the current tenant
        /// Request Path: /providers/Microsoft.DataShare/locations/{location}/activateEmail
        /// Operation Id: EmailRegistrations_ActivateEmail
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="location"> Location of the activation. </param>
        /// <param name="emailRegistration"> The payload for tenant domain activation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="emailRegistration"/> is null. </exception>
        public static async Task<Response<DataShareEmailRegistration>> ActivateEmailAsync(this TenantResource tenantResource, AzureLocation location, DataShareEmailRegistration emailRegistration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(emailRegistration, nameof(emailRegistration));

            return await GetExtensionClient(tenantResource).ActivateEmailAsync(location, emailRegistration, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Activate the email registration for the current tenant
        /// Request Path: /providers/Microsoft.DataShare/locations/{location}/activateEmail
        /// Operation Id: EmailRegistrations_ActivateEmail
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="location"> Location of the activation. </param>
        /// <param name="emailRegistration"> The payload for tenant domain activation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="emailRegistration"/> is null. </exception>
        public static Response<DataShareEmailRegistration> ActivateEmail(this TenantResource tenantResource, AzureLocation location, DataShareEmailRegistration emailRegistration, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(emailRegistration, nameof(emailRegistration));

            return GetExtensionClient(tenantResource).ActivateEmail(location, emailRegistration, cancellationToken);
        }

        /// <summary>
        /// Register an email for the current tenant
        /// Request Path: /providers/Microsoft.DataShare/locations/{location}/registerEmail
        /// Operation Id: EmailRegistrations_RegisterEmail
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="location"> Location of the registration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<DataShareEmailRegistration>> RegisterEmailAsync(this TenantResource tenantResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return await GetExtensionClient(tenantResource).RegisterEmailAsync(location, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Register an email for the current tenant
        /// Request Path: /providers/Microsoft.DataShare/locations/{location}/registerEmail
        /// Operation Id: EmailRegistrations_RegisterEmail
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="location"> Location of the registration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<DataShareEmailRegistration> RegisterEmail(this TenantResource tenantResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(tenantResource).RegisterEmail(location, cancellationToken);
        }

        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// List Accounts in Subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataShare/accounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataShareAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DataShareAccountResource> GetDataShareAccountsAsync(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDataShareAccountsAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// List Accounts in Subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataShare/accounts
        /// Operation Id: Accounts_ListBySubscription
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> Continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataShareAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DataShareAccountResource> GetDataShareAccounts(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDataShareAccounts(skipToken, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of DataShareAccountResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DataShareAccountResources and their operations over a DataShareAccountResource. </returns>
        public static DataShareAccountCollection GetDataShareAccounts(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetDataShareAccounts();
        }

        /// <summary>
        /// Get an account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the share account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DataShareAccountResource>> GetDataShareAccountAsync(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetDataShareAccounts().GetAsync(accountName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get an account
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataShare/accounts/{accountName}
        /// Operation Id: Accounts_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="accountName"> The name of the share account. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="accountName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<DataShareAccountResource> GetDataShareAccount(this ResourceGroupResource resourceGroupResource, string accountName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetDataShareAccounts().Get(accountName, cancellationToken);
        }

        #region DataShareAccountResource
        /// <summary>
        /// Gets an object representing a <see cref="DataShareAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataShareAccountResource.CreateResourceIdentifier" /> to create a <see cref="DataShareAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataShareAccountResource" /> object. </returns>
        public static DataShareAccountResource GetDataShareAccountResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataShareAccountResource.ValidateResourceId(id);
                return new DataShareAccountResource(client, id);
            }
            );
        }
        #endregion

        #region DataShareConsumerInvitationResource
        /// <summary>
        /// Gets an object representing a <see cref="DataShareConsumerInvitationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataShareConsumerInvitationResource.CreateResourceIdentifier" /> to create a <see cref="DataShareConsumerInvitationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataShareConsumerInvitationResource" /> object. </returns>
        public static DataShareConsumerInvitationResource GetDataShareConsumerInvitationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataShareConsumerInvitationResource.ValidateResourceId(id);
                return new DataShareConsumerInvitationResource(client, id);
            }
            );
        }
        #endregion

        #region ShareDataSetResource
        /// <summary>
        /// Gets an object representing a <see cref="ShareDataSetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ShareDataSetResource.CreateResourceIdentifier" /> to create a <see cref="ShareDataSetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ShareDataSetResource" /> object. </returns>
        public static ShareDataSetResource GetShareDataSetResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ShareDataSetResource.ValidateResourceId(id);
                return new ShareDataSetResource(client, id);
            }
            );
        }
        #endregion

        #region ShareDataSetMappingResource
        /// <summary>
        /// Gets an object representing a <see cref="ShareDataSetMappingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ShareDataSetMappingResource.CreateResourceIdentifier" /> to create a <see cref="ShareDataSetMappingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ShareDataSetMappingResource" /> object. </returns>
        public static ShareDataSetMappingResource GetShareDataSetMappingResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ShareDataSetMappingResource.ValidateResourceId(id);
                return new ShareDataSetMappingResource(client, id);
            }
            );
        }
        #endregion

        #region DataShareInvitationResource
        /// <summary>
        /// Gets an object representing a <see cref="DataShareInvitationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataShareInvitationResource.CreateResourceIdentifier" /> to create a <see cref="DataShareInvitationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataShareInvitationResource" /> object. </returns>
        public static DataShareInvitationResource GetDataShareInvitationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataShareInvitationResource.ValidateResourceId(id);
                return new DataShareInvitationResource(client, id);
            }
            );
        }
        #endregion

        #region DataShareResource
        /// <summary>
        /// Gets an object representing a <see cref="DataShareResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataShareResource.CreateResourceIdentifier" /> to create a <see cref="DataShareResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataShareResource" /> object. </returns>
        public static DataShareResource GetDataShareResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataShareResource.ValidateResourceId(id);
                return new DataShareResource(client, id);
            }
            );
        }
        #endregion

        #region ProviderShareSubscriptionResource
        /// <summary>
        /// Gets an object representing a <see cref="ProviderShareSubscriptionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ProviderShareSubscriptionResource.CreateResourceIdentifier" /> to create a <see cref="ProviderShareSubscriptionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ProviderShareSubscriptionResource" /> object. </returns>
        public static ProviderShareSubscriptionResource GetProviderShareSubscriptionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ProviderShareSubscriptionResource.ValidateResourceId(id);
                return new ProviderShareSubscriptionResource(client, id);
            }
            );
        }
        #endregion

        #region ShareSubscriptionResource
        /// <summary>
        /// Gets an object representing a <see cref="ShareSubscriptionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ShareSubscriptionResource.CreateResourceIdentifier" /> to create a <see cref="ShareSubscriptionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ShareSubscriptionResource" /> object. </returns>
        public static ShareSubscriptionResource GetShareSubscriptionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ShareSubscriptionResource.ValidateResourceId(id);
                return new ShareSubscriptionResource(client, id);
            }
            );
        }
        #endregion

        #region DataShareSynchronizationSettingResource
        /// <summary>
        /// Gets an object representing a <see cref="DataShareSynchronizationSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataShareSynchronizationSettingResource.CreateResourceIdentifier" /> to create a <see cref="DataShareSynchronizationSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataShareSynchronizationSettingResource" /> object. </returns>
        public static DataShareSynchronizationSettingResource GetDataShareSynchronizationSettingResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataShareSynchronizationSettingResource.ValidateResourceId(id);
                return new DataShareSynchronizationSettingResource(client, id);
            }
            );
        }
        #endregion

        #region DataShareTriggerResource
        /// <summary>
        /// Gets an object representing a <see cref="DataShareTriggerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataShareTriggerResource.CreateResourceIdentifier" /> to create a <see cref="DataShareTriggerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataShareTriggerResource" /> object. </returns>
        public static DataShareTriggerResource GetDataShareTriggerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataShareTriggerResource.ValidateResourceId(id);
                return new DataShareTriggerResource(client, id);
            }
            );
        }
        #endregion
    }
}
