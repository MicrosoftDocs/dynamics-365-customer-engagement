---
title: Define custom APIs
description: Learn how to define custom APIs for custom channels in Dynamics 365 Marketing.
ms.date: 04/04/2023
ms.custom: 
  - dyn365-marketing
  - bap-template
ms.topic: how-to
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Define custom APIs

## Outbound custom API

Applicable channels: SMS, custom

When you create a custom channel in Dynamics 365 Marketing, you need to define an [outbound custom API](/power-apps/developer/data-platform/custom-api) to call during the journey runtime. The custom API is the entry point for executing custom code. It calls the provider's APIs and must accept the contract defined by the Marketing journey and return the response. The outbound custom API is assigned to the attribute **msdyn_outboundendpointurltemplate** at the [channel definition step](real-time-marketing-define-channel-definition.md).

The contract that the outbound custom API should implement must have one input parameter (payload) and one output attribute (response).

- The payload is a serialized JSON with the following contract:

  - **ChannelDefinitionId**: GUID – The channel definition ID.
  - **RequestId**: string – The request ID.
  - **From**: string – The sender (channel instance).
  - **To**: string – The recipient.
  - **Message**: Dictionary <string, string> - Contains all the message parts for a channel. Keys are the message part names, such as the values of the corresponding `msdyn_name` attribute.
  - **MarketingAppContext**: object - An object representing the context of the submission. This object is only available when the submission is executed from the Marketing application. The object contains the following fields:
    - **CustomerJourneyId**: string - The ID of the customer journey initiating the call. Null when the submission is requested from a test send.
    - **UserId**: GUID - ID of the user who is receiving the message. Null when the submission is requested from a test send.
    - **UserEntityType**: string - Type of entity representing a user who is receiving the message. Null when the submission is requested from a test send.
    - **IsTestSend**: boolean - True when submission was initiated from a test send, False otherwise.

- The response is a serialized JSON with the following contract:

  - **ChannelDefinitionId**: GUID – The channel definition ID.
  - **MessageId**: string – (Optional) The message ID. Optional; it may exist in the API response of a provider.
  - **RequestId**: string – The request ID. Should be equal to the request ID value inside the request payload.
  - **Status**: string – The possible values are:
    - **NotSent** – There was an attempt to execute the submission to the provider but it was rejected without a possibility to retry.
    - **Sent** – The submission request was successfully accepted by the provider.

## Delivery report custom API

Applicable channels: SMS, custom

If your channel supports message delivery reports or statuses, you need to define a [delivery report custom API](/power-apps/developer/data-platform/custom-api). Your API is called by the provider and it must call the base solution's **msdyn_D365ChannelsNotification** API, which returns the information to Dataverse. This information is available in Marketing analytics.

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

Applicable channels: SMS

If your channel supports inbound requests, you need to define an [inbound custom API](/power-apps/developer/data-platform/custom-api). Your API is called by the provider and it must call the base solution's **msdyn_D365ChannelsInbound** API, which returns the information to Dataverse.

The inbound custom API calls the **msdyn_D365ChannelsInbound** API with the contract as one input parameter:

- inboundPayLoad is a serialized JSON  with the following contract:

  - **ChannelDefinitionId**: GUID – The channel definition ID.
  - **To**: string - The C1 phone number (channel instance).
  - **From**: string - C2 user contact point.
  - **OrganizationId**: string – The organization ID.
  - **Message**: Dictionary <string, string> - Contains all the message parts for a channel.

[!INCLUDE [footer-include](../includes/footer-banner.md)]
