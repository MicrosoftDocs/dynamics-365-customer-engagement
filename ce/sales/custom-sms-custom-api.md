---
title: Define custom APIs for SMS channel
description: Define custom APIs for custom SMS channels in Dynamics 365 Sales.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 06/23/2023
ms.custom: bap-template 
---

# Define custom APIs for SMS channel

## Outbound custom API

When you create a custom SMS channel in Dynamics 365 Sales, you need to define an [outbound custom API](/power-apps/developer/data-platform/custom-api) to call during the journey runtime. The custom API is the entry point for executing custom code. It calls the provider's APIs and must accept the contract defined by the Sales SMS and return the response. The outbound custom API is assigned to the attribute **msdyn_outboundendpointurltemplate** at the [channel definition step](custom-define-sms-definition.md).

The contract that the outbound custom API should implement must have one input parameter (payload) and one output attribute (response).

- The payload is a serialized JSON with the following contract:

  - **ChannelDefinitionId**: GUID – The channel definition ID.
  - **RequestId**: string – The request ID.
  - **From**: string – The sender (channel instance).
  - **To**: string – The recipient.
  - **Message**: Dictionary <string, string> - Contains all the message parts for a channel. Keys are the message part names, such as the values of the corresponding `msdyn_name` attribute.

- The response is a serialized JSON with the following contract:

  - **ChannelDefinitionId**: GUID – The channel definition ID.
  - **MessageId**: string – (Optional) The message ID. Optional; it may exist in the API response of a provider.
  - **RequestId**: string – The request ID. Should be equal to the request ID value inside the request payload.
  - **Status**: string – The possible values are:
    - **NotSent** – There was an attempt to execute the submission to the provider but it was rejected without a possibility to retry.
    - **Sent** – The submission request was successfully accepted by the provider.

## Delivery report custom API

If your channel supports message delivery reports or statuses, you need to define a [delivery report custom API](/power-apps/developer/data-platform/custom-api). Your API is called by the provider and it must call the base solution's **msdyn_D365ChannelsNotification** API, which returns the information to Dataverse. This information is available in Sales chat editor.

The delivery report custom API calls the **msdyn_D365ChannelsNotification** API with the contract as one input parameter:

- notificationPayLoad is a serialized JSON with the following contract:

  - **ChannelDefinitionId**: GUID – The channel definition ID.
  - **RequestId**: string – The request ID.
  - **MessageId**:  string – The message ID.
  - **From**: string – The sender (channel instance).
  - **OrganizationId**: string – The organization ID.
  - **Status**: string – The delivery report status. The possible values are:
    - **Delivered** – The accepted message was successfully delivered to the target.
    - **NotDelivered** – The accepted message wasn't successfully delivered to the target.

## Inbound custom API

If your channel supports inbound requests, you need to define an [inbound custom API](/power-apps/developer/data-platform/custom-api). Your API is called by the provider and it must call the base solution's **msdyn_D365ChannelsInbound** API, which returns the information to Dataverse.

The inbound custom API calls the **msdyn_D365ChannelsInbound** API with the contract as one input parameter:

- inboundPayLoad is a serialized JSON  with the following contract:

  - **ChannelDefinitionId**: GUID – The channel definition ID.
  - **To**: string - The C1 phone number (channel instance).
  - **From**: string - C2 user contact point.
  - **OrganizationId**: string – The organization ID.
  - **Message**: Dictionary <string, string> - Contains all the message parts for a channel.

## Next step

[Define the custom SMS channel](custom-define-sms-definition.md) 