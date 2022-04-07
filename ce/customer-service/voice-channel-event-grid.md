---
title: "Register event grid system topics | MicrosoftDocs"
description: "This article explains how to create, deploy, and register event grid system topics for an existing Azure resource."
ms.date: 04/08/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Manage event grid system topics

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

Azure Communication Services integrates with Azure Event Grid to send real-time event notifications for chat, telephony, SMS, video, and voice-calling events. To enable voice calling and SMS services, you must x` and SMS The purpose of this article is to help you configure your applications to listen to Communication Services events.
Event grid uses event subscriptions to route event messages to subscribers.

System topics are built-in topics provided by Azure services such as Azure Storage, Azure Event Hubs, and Azure Service Bus. You can create system topics in your Azure subscription and subscribe to them. For more information, see Overview of system topics. More information: [System topics in Azure Event Grid](/azure/event-grid/system-topics)

This topic explains how to create, deploy, and register event grid system topics for an existing Azure resource.

## Create, deploy, and register event grid system topics

**To create, deploy, and register event grid system topics**

1. Open the Azure portal in a separate window or tab, and open the **Event Grid System Topics** service. 
2. Select **Create** and in the **Create Event Grid System Topic** page, enter the following details.
    - **Topic Types**: Select **Azure Communication Services** from the dropdown list.
    - **Subscription**: Select the subscription from the dropdown list.
    - **Resource Group**: Select the resource group from the dropdown list.
    - **Resource**: Select the Azure resource from the dropdown list.
    - **Name**: Enter a name for the system topic.
    > [!div class="mx-imgBorder"]
    > ![Create event grid system topic.](./media/voice-channel-create-event-grid-system-topic.png "Create event grid system topic.")
3. Select **Review + create**. The system topic is validated and deployed.  
    > [!div class="mx-imgBorder"]
    > ![Event grid system topic is deployed.](./media/voice-channel-system-topic-deployment.png "Event grid system topic is deployed.")
4. Select **Go to resource**.
5. In the resource details page that opens, select the **Subscription** link.
    > [!div class="mx-imgBorder"]
    > ![Select the resource subscription.](./media/voice-channel-resource-subscription.png "Select the resource subscription.")
6. In the resource subscription page, select **Settings** > **Resource providers**, and then check if the **Microsoft.EventGrid** provider is listed as **Registered**.
   If the event grid is not registered, you can select the record and then select **Re-register** to register it.
    > [!div class="mx-imgBorder"]
    > ![Event grid is listed as a registered provider.](./media/voice-channel-eventgrid-registered.png "Event grid is listed as a registered provider.")

> [!Note]
> When you connect your event subscription, you must use the same app ID and directory ID for the app registration as you did when you first connected your Azure resource. To check which app ID and directory ID you used to connect your ACS resource, select the filter icon in the top right and search for communication provider setting entries.

### See also

[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Connect to an existing Azure resource](voice-channel-connect-existing-resource.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Get resource and app registration details from Azure portal](voice-channel-resource-app-details.md)  
[Create event subscription endpoints](voice-channel-sub-endpoints.md)  
  
[!INCLUDE[footer-include](../includes/footer-banner.md)]