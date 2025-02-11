// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>A2A cloud creation input.</summary>
    public partial class A2AContainerCreationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AContainerCreationInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IA2AContainerCreationInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IReplicationProviderSpecificContainerCreationInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IReplicationProviderSpecificContainerCreationInput __replicationProviderSpecificContainerCreationInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.ReplicationProviderSpecificContainerCreationInput();

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IReplicationProviderSpecificContainerCreationInputInternal)__replicationProviderSpecificContainerCreationInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IReplicationProviderSpecificContainerCreationInputInternal)__replicationProviderSpecificContainerCreationInput).InstanceType = value ; }

        /// <summary>Creates an new <see cref="A2AContainerCreationInput" /> instance.</summary>
        public A2AContainerCreationInput()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__replicationProviderSpecificContainerCreationInput), __replicationProviderSpecificContainerCreationInput);
            await eventListener.AssertObjectIsValid(nameof(__replicationProviderSpecificContainerCreationInput), __replicationProviderSpecificContainerCreationInput);
        }
    }
    /// A2A cloud creation input.
    public partial interface IA2AContainerCreationInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IReplicationProviderSpecificContainerCreationInput
    {

    }
    /// A2A cloud creation input.
    internal partial interface IA2AContainerCreationInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202301.IReplicationProviderSpecificContainerCreationInputInternal
    {

    }
}