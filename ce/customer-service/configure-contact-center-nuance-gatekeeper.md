---
title: Configure Digital Contact Center Platform for Nuance Gatekeeper integration
description: How-to configure Digital Contact Center Platform for Nuance Gatekeeper integration 
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection:
ms.date: 07/28/2023
ms.custom: bap-template
---

# Configure contact center for Nuance Gatekeeper integration (preview)

> [!IMPORTANT]
> [!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note.md)]

Use the information in this article to configure the following settings:

- Conversation Conductor Service
- Omnichannel Event Grid Writer Service

## Configure Conversation Conductor Service

The conversation conductor handles the audio stream that’s required to support biometric authentication and fraud prevention capabilities. This service requires the “Contributor role on the specific Azure Communication Resource” that's connected to the Dynamics 365 environment. This step must be performed by an Azure administrator.

1. Go to [Azure portal](https://portal.azure.com).

1. Go to **Azure Communication Services resource** > **Properties** > **Id**. Use the SubscriptionId and ACSResourceId that's connected to the Dynamics environment.

1. Create service principals in the azure tenant by using the following PowerShell commands:
   - Connect-AzAccount -SubscriptionId `"<SubscriptionID>”`
   - New-AzADServicePrincipal -ApplicationId "c880d6fb-5c66-49ef-9cf5-e53e31900be5" -DisplayName "Conversation Conductor"

1. Provide “Contributor” access to the Conversation Conductor so it can answer calls on the Azure Communication Services resource. (Application id: c880d6fb-5c66-49ef-9cf5-e53e31900be5)”.

1. Go to **Communication Service** > **Select the specific ACS resource** > **Access Control** > **Add role** assignment, and then select **Conversation Conductor** app in **Contributor**.

## Configure Omnichannel Event Grid Writer Service

Create a new Omnichannel Service Principal account to configure new Event Grid Subscriptions for incoming call events to the Conversation Conductor Service. This service requires EventGrid EventSubscription Contributor privilege on the specific Azure Communication Resource connected to the Dynamics Environment. This step must be performed by the Azure administrator.

1. Go to **Azure Communication Services resource** > **Properties** > **Id**. Use the SubscriptionId and ACSResourceId that's connected to the Dynamics Environment.

1. Create the Service Principal for Omnichannel for Customer Service.
    - Connect-AzAccount -SubscriptionId `"<SubscriptionId>”`.
    - New-AzADServicePrincipal -ApplicationId "a950df6d-e658-48fc-b494-ec69d8d9731b" -DisplayName "Omnichannel EventGrid Writer App".

1. Provide access to the Omnichannel Event Grid Writer with permission to configure Event Grid subscriptions on the Azure Communication Services resource.
   - Connect-AzAccount -SubscriptionId `"<SubscriptionId>”`.
   - New-AzRoleAssignment -ApplicationId "a950df6d-e658-48fc-b494-ec69d8d9731b" -RoleDefinitionName "EventGrid EventSubscription Contributor" -Scope `"<ACSResourceId>".`

### See also

[Add authentication setting for Nuance Gatekeeper](configure-gatekeeper-authentication.md)  
[Introduction to Nuance Gatekeeper integration](nuance-gatekeeper-introduction.md)  