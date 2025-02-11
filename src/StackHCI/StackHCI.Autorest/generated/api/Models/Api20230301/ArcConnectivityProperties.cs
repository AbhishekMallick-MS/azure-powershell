// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20230301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Extensions;

    /// <summary>Connectivity related configuration required by arc server.</summary>
    public partial class ArcConnectivityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20230301.IArcConnectivityProperties,
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Models.Api20230301.IArcConnectivityPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>True indicates ARC connectivity is enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Origin(Microsoft.Azure.PowerShell.Cmdlets.StackHCI.PropertyOrigin.Owned)]
        public bool? Enabled { get => this._enabled; set => this._enabled = value; }

        /// <summary>Creates an new <see cref="ArcConnectivityProperties" /> instance.</summary>
        public ArcConnectivityProperties()
        {

        }
    }
    /// Connectivity related configuration required by arc server.
    public partial interface IArcConnectivityProperties :
        Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.IJsonSerializable
    {
        /// <summary>True indicates ARC connectivity is enabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.StackHCI.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"True indicates ARC connectivity is enabled",
        SerializedName = @"enabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? Enabled { get; set; }

    }
    /// Connectivity related configuration required by arc server.
    internal partial interface IArcConnectivityPropertiesInternal

    {
        /// <summary>True indicates ARC connectivity is enabled</summary>
        bool? Enabled { get; set; }

    }
}