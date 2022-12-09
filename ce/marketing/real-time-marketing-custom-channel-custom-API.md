---
title: "Preview: Define your Custom APIs (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to define your Custom APIs in Dynamics 365 Marketing."
ms.date: 12/09/2022
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
# Define your Custom APIs

## Applicable channels: SMS, Custom

### Why you need it:

A [custom API](/learn.microsoft.com/power-apps/developer/data-platform/custom-api) needs to be defined so that it will be called during the Journey runtime in Marketing. It's the entry point for custom code execution.   The Custom API will then call the Provider’s APIs. This API must accept the contract defined by the Marketing Journey and return the response. This custom API will be assigned to attribute **msdyn_outboundendpointurltemplate** at Channel Definition Step<ADD LINK to STEP 7>.

### How to define it:

• See how you can define your custom API.

• The contract  that the custom API should implement must have one input parameter (payload) and one output attribute (response)

-     payload is a serialized JSON  with the following contract

         ChannelDefinitionId: GUID – The Channel Definition Id

         RequestId: string – The Request Id

         From: string – The Sender (Channel Instance)

         To: string – The recipient

         Message: Dictionary <string, string> - Contains all the message parts for a channel. Keys are the message part names, I.e., values of the corresponding msdyn_name attribute.

-     response is a serialized JSON with the following contract:
- 
         ChannelDefinitionId: GUID – The Channel Definition Id

         MessageId:  string – The Message Id

         RequestId: string – The Request Id 

         StatusDetails: Dictionary<string, object> - Channel specific information regarding the status.

         Status: string – Possible Values are:

            • NotSent – there was an attempt to execute the submission to the provider, but it was rejected without a possibility to retry 

            • Sent – the submission request was successfully accepted by the provider 

            • Delivered – the accepted message was successfully delivered to the target 

            • NotDelivered – the accepted message was not successfully delivered to the target 
