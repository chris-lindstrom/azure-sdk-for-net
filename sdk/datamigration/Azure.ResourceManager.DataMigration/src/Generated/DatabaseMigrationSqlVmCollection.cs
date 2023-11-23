// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataMigration
{
    /// <summary>
    /// A class representing a collection of <see cref="DatabaseMigrationSqlVmResource"/> and their operations.
    /// Each <see cref="DatabaseMigrationSqlVmResource"/> in the collection will belong to the same instance of <see cref="ResourceGroupResource"/>.
    /// To get a <see cref="DatabaseMigrationSqlVmCollection"/> instance call the GetDatabaseMigrationSqlVms method from an instance of <see cref="ResourceGroupResource"/>.
    /// </summary>
    public partial class DatabaseMigrationSqlVmCollection : ArmCollection
    {
        private readonly ClientDiagnostics _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics;
        private readonly DatabaseMigrationsSqlVmRestOperations _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient;

        /// <summary> Initializes a new instance of the <see cref="DatabaseMigrationSqlVmCollection"/> class for mocking. </summary>
        protected DatabaseMigrationSqlVmCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DatabaseMigrationSqlVmCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DatabaseMigrationSqlVmCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataMigration", DatabaseMigrationSqlVmResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DatabaseMigrationSqlVmResource.ResourceType, out string databaseMigrationSqlVmDatabaseMigrationsSqlVmApiVersion);
            _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient = new DatabaseMigrationsSqlVmRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, databaseMigrationSqlVmDatabaseMigrationsSqlVmApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new database migration to a given SQL VM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseMigrationsSqlVm_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sqlVirtualMachineName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="data"> Details of SqlMigrationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVirtualMachineName"/>, <paramref name="targetDBName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DatabaseMigrationSqlVmResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sqlVirtualMachineName, string targetDBName, DatabaseMigrationSqlVmData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVirtualMachineName, nameof(sqlVirtualMachineName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics.CreateScope("DatabaseMigrationSqlVmCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlVirtualMachineName, targetDBName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DataMigrationArmOperation<DatabaseMigrationSqlVmResource>(new DatabaseMigrationSqlVmOperationSource(Client), _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics, Pipeline, _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, sqlVirtualMachineName, targetDBName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a new database migration to a given SQL VM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseMigrationsSqlVm_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sqlVirtualMachineName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="data"> Details of SqlMigrationService resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVirtualMachineName"/>, <paramref name="targetDBName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DatabaseMigrationSqlVmResource> CreateOrUpdate(WaitUntil waitUntil, string sqlVirtualMachineName, string targetDBName, DatabaseMigrationSqlVmData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVirtualMachineName, nameof(sqlVirtualMachineName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics.CreateScope("DatabaseMigrationSqlVmCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, sqlVirtualMachineName, targetDBName, data, cancellationToken);
                var operation = new DataMigrationArmOperation<DatabaseMigrationSqlVmResource>(new DatabaseMigrationSqlVmOperationSource(Client), _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics, Pipeline, _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, sqlVirtualMachineName, targetDBName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the specified database migration for a given SQL VM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseMigrationsSqlVm_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVirtualMachineName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is null. </exception>
        public virtual async Task<Response<DatabaseMigrationSqlVmResource>> GetAsync(string sqlVirtualMachineName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVirtualMachineName, nameof(sqlVirtualMachineName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));

            using var scope = _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics.CreateScope("DatabaseMigrationSqlVmCollection.Get");
            scope.Start();
            try
            {
                var response = await _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlVirtualMachineName, targetDBName, migrationOperationId, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseMigrationSqlVmResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the specified database migration for a given SQL VM.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseMigrationsSqlVm_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVirtualMachineName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is null. </exception>
        public virtual Response<DatabaseMigrationSqlVmResource> Get(string sqlVirtualMachineName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVirtualMachineName, nameof(sqlVirtualMachineName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));

            using var scope = _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics.CreateScope("DatabaseMigrationSqlVmCollection.Get");
            scope.Start();
            try
            {
                var response = _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sqlVirtualMachineName, targetDBName, migrationOperationId, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DatabaseMigrationSqlVmResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseMigrationsSqlVm_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVirtualMachineName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sqlVirtualMachineName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVirtualMachineName, nameof(sqlVirtualMachineName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));

            using var scope = _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics.CreateScope("DatabaseMigrationSqlVmCollection.Exists");
            scope.Start();
            try
            {
                var response = await _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlVirtualMachineName, targetDBName, migrationOperationId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseMigrationsSqlVm_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVirtualMachineName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is null. </exception>
        public virtual Response<bool> Exists(string sqlVirtualMachineName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVirtualMachineName, nameof(sqlVirtualMachineName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));

            using var scope = _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics.CreateScope("DatabaseMigrationSqlVmCollection.Exists");
            scope.Start();
            try
            {
                var response = _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sqlVirtualMachineName, targetDBName, migrationOperationId, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseMigrationsSqlVm_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVirtualMachineName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is null. </exception>
        public virtual async Task<NullableResponse<DatabaseMigrationSqlVmResource>> GetIfExistsAsync(string sqlVirtualMachineName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVirtualMachineName, nameof(sqlVirtualMachineName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));

            using var scope = _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics.CreateScope("DatabaseMigrationSqlVmCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, sqlVirtualMachineName, targetDBName, migrationOperationId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DatabaseMigrationSqlVmResource>(response.GetRawResponse());
                return Response.FromValue(new DatabaseMigrationSqlVmResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.SqlVirtualMachine/sqlVirtualMachines/{sqlVirtualMachineName}/providers/Microsoft.DataMigration/databaseMigrations/{targetDbName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DatabaseMigrationsSqlVm_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlVirtualMachineName"> The <see cref="string"/> to use. </param>
        /// <param name="targetDBName"> The name of the target database. </param>
        /// <param name="migrationOperationId"> Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved. </param>
        /// <param name="expand"> Complete migration details be included in the response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlVirtualMachineName"/> or <paramref name="targetDBName"/> is null. </exception>
        public virtual NullableResponse<DatabaseMigrationSqlVmResource> GetIfExists(string sqlVirtualMachineName, string targetDBName, Guid? migrationOperationId = null, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlVirtualMachineName, nameof(sqlVirtualMachineName));
            Argument.AssertNotNullOrEmpty(targetDBName, nameof(targetDBName));

            using var scope = _databaseMigrationSqlVmDatabaseMigrationsSqlVmClientDiagnostics.CreateScope("DatabaseMigrationSqlVmCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _databaseMigrationSqlVmDatabaseMigrationsSqlVmRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, sqlVirtualMachineName, targetDBName, migrationOperationId, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DatabaseMigrationSqlVmResource>(response.GetRawResponse());
                return Response.FromValue(new DatabaseMigrationSqlVmResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
