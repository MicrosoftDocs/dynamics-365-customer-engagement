---
title: "Define your Custom APIs (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to define your Custom APIs in Dynamics 365 Marketing."
ms.date: 01/30/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Define your custom APIs

## A. Outbound custom API

### Applicable channels: SMS, Custom

#### Why you need it:

A [custom API](/power-apps/developer/data-platform/custom-api) needs to be defined so that it will be called during the Journey runtime in Marketing. It's the entry point for custom code execution.   The Custom API will then call the Provider’s APIs. This API must accept the contract defined by the Marketing Journey and return the response. This custom API will be assigned to attribute **msdyn_outboundendpointurltemplate** at the [channel definition step](real-time-marketing-define-channel-definition.md).

#### How to define it:

The contract that the custom API should implement must have one input parameter (payload) and one output attribute (response)

- The payload is a serialized JSON with the following contract:
    - ChannelDefinitionId: GUID – The channel definition ID
    - RequestId: string – The request ID
    - From: string – The Sender (Channel Instance)
    - To: string – The recipient
    - Message: Dictionary <string, string> - Contains all the message parts for a channel. Keys are the message part names, I.e., values of the corresponding msdyn_name attribute.
    - MarketingAppContext: object - an object, representing context of the submission. This object is only available, when submission is executed from Marketing application. Object contains the following fields:
        - CustomerJourneyId: string - ID of the customer journey initiating this call. Null, when submission is requested from "Test Send" feature.
        - UserId: GUID - ID of user who is receiving the message. Null, when submission is requested from test send. 
        - UserEntityType: string - type of entity representing a user who is receiving the message. Null, when submission is requested from "Test Send" feature.
        - IsTestSend: boolean - true, when submission was initated from "Test Send" feature. False otherwise.

- The response is a serialized JSON with the following contract:
    - ChannelDefinitionId: GUID – The channel definition ID
    - MessageId (optional): string – The message ID. Optional, it may exist in the API response of a provider.
    - RequestId: string – The request ID. Should be equal to the request ID value inside the request payload.
    - Status: string – Possible values are:
        - NotSent – there was an attempt to execute the submission to the provider, but it was rejected without a possibility to retry.
        - Sent – the submission request was successfully accepted by the provider.

## B. Delivery report custom API

### Applicable channels: SMS, Custom

#### Why you need it:

If your channel supports delivery reports or statuses for messages, such as for example, “Delivered”, a [custom API](/power-apps/developer/data-platform/custom-api) needs to be defined. Your API will be called by the Provider and it must call the base solution’s **msdyn_D365ChannelsNotification** API. The latter will proxy the information back to Dataverse. This information will become available in Marketing Analytics.

#### How to define it:

Your own Custom API will be executed and call the msdyn_D365ChannelsNotification API with contract  as one input parameter:

- notificationPayLoad is a serialized JSON  with the following contract
    - ChannelDefinitionId: GUID – The channel Definition ID
    - RequestId: string – The Request ID
    - MessageId:  string – The message ID
    - From: string – The sender (channel instance)
    - OrganizationId: string – The organization ID
    - Status: string – The delivery report status. The possible values are:
        - Delivered – the accepted message was successfully delivered to the target.
        - NotDelivered – the accepted message was not successfully delivered to the target.

## C. Inbound custom API

### Applicable channels: SMS

#### Why you need it:

If your channel supports inbound requests, a [custom API](/power-apps/developer/data-platform/custom-api) needs to be defined. Your API will be called by the Provider and it must call the base solution’s **msdyn_D365ChannelsInbound** API. The latter will proxy the information back to Dataverse. 

#### How to define it:

Your own Custom API will be executed and call the msdyn_D365ChannelsInbound API with contract as one input parameter:

- inboundPayLoad is a serialized JSON  with the following contract
    - ChannelDefinitionId: GUID – The channel Definition ID
    - From: string – The sender (channel instance)
    - To: string - The C1 phone number (Channel Instance)   
    - From: string - C2 user contact point
    - OrganizationId: string – The organization ID
    - Message: Dictionary <string, string> - Contains all the message parts for a channel
