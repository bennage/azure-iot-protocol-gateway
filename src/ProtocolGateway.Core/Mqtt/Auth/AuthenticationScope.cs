// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Azure.Devices.ProtocolGateway.Mqtt.Auth
{
    public enum AuthenticationScope
    {
        None,
        SasToken,
        DeviceKey,
        HubKey
    }
}