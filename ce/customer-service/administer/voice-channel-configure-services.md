---
title: Set up incoming calls, call recording, and SMS services
description: Learn how to set up incoming calls, call recording, and SMS services using the Azure Event Grid.
ms.date: 11/27/2024
ms.custom: bap-template
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
---

# Set up incoming calls, call recording, and SMS services

Azure Communication Services integrates with [Azure Event Grid](/azure/event-grid/overview) to send real-time notifications for chat, telephony, SMS, video, and voice calling events. Azure Event Grid, in turn, uses event subscriptions to route event messages to subscribers.

To enable call recording and SMS services, you must first configure your applications to listen to Azure Communication Services events by registering [Event Grid system topics](/azure/event-grid/system-topics). Then, subscribe to the specific incoming call, call recording, or SMS events by creating Event Grid subscriptions on the Azure portal.

> [!IMPORTANT]
>
> - You must be an owner of the [App registration](#get-event-grid-app-and-tenant-ids-from-the-power-apps-portal) to create Event Grid subscriptions. 
> - You can set only one webhook endpoint at a time using the following procedure. To enable incoming calls, SMS, and call recording services, you must repeat the procedure to set the webhook endpoint for each of these services.
> - You must create a new event subscription for each event type. Don't update an existing event subscription by changing the event type.
> - When you connect your event subscription, you must use the same application (client) ID and tenant (directory) ID for the app registration as you did when you first connected to your Azure resource. To get the event grid app and tenant IDs, go to [Get application and tenant IDs from the Power Apps portal](#get-event-grid-app-and-tenant-ids-from-the-power-apps-portal).

## Create an Event Grid system topic

1. Open the **Event Grid System Topics** service on the Azure portal.   
   
1. Create a new Event Grid System Topic, and then on the **Basics** tab, add the following information:
   - **Topic Type**: Azure Communication Services
   - **Subscription**: Select your subscription.
   - **Resource group**: Select the resource group where your Azure Communication Services resource is located.
   - **Resource**: Select the Azure Communication Services resource that you want to connect to Dynamics 365 Customer Service.
   - Specify the **Name** in the **System Topic Details** section.

     :::image type="content" source="../media/event-grid-system-topic-name.png" alt-text="Name field for the Create Event Grid System Topic dialog" lightbox="../media/event-grid-system-topic-name.png":::
     
    Learn more at [Create and deploy an Event Grid system topic](/azure/event-grid/create-view-manage-system-topics#create-a-system-topic).

1. On the **Event Grid System Topic** page, select the **Subscription** link.

   :::image type="content" source="../media/event-grid-system-topic-subscription.png" alt-text="Subscription link for the Event Grid system topic creation" lightbox="../media/event-grid-system-topic-subscription.png":::

1. On the resource subscription page, select **Settings** > **Resource providers**, and then check whether the **Microsoft.EventGrid** provider is listed as **Registered**. If the Event Grid isn't registered, then select the record, and then select **Re-register** to register it.

## Set up the incoming calls webhook

1. Open the resource on the Azure portal. Select **Events**, and then select **Event Subscription**.

1. On the **Basics** tab, enter the following details:
    - **Name**: Enter a name for the recording event subscription.
    - **Event Schema**: Select **Event Grid Schema** in the list.
    - **Topic Types**: Select **Azure Communication Services** in the list.
    - **Subscription**: Select your subscription in the list.
    - **Resource Group**: Select the resource group.
    - **Resource**: Select the resource.
    - **System Topic Name**: This field is automatically populated with the system topic name you created. However, if you see multiple values, select the specific system topic name from the list.
    - **Filter to Event Types**: You can filter events for call recording, incoming calls, or SMS services.
        - To filter event types for calling services, select **Incoming Call** in the list.
     
     - **Endpoint Type**: Select **Web Hook** in the list.
     - **Endpoint**: Select **Select an endpoint**, and then enter the incoming call, webhook endpoint from the Customer Service admin center or Contact Center admin center. Go to **Channels** > **Phone Numbers** > **Advanced** > **Manage Azure Communication Services** to get the following webhook endpoints:
        - **Incoming call Web Hook Endpoint (preview)** to enable incoming calls.
      
          :::image type="content" source="../media/event-grid-subscription-incoming-call.png" alt-text="Incoming call webhook endpoint " lightbox="../media/event-grid-subscription-incoming-call.png":::

1. Select the **Additional Features** tab. Select the **Use Microsoft Entra authentication** checkbox, and then enter the following details. Learn more about these values in the **Get application and tenant IDs from the Power Apps portal** section in this article.

   - **Microsoft Entra Tenant ID**: Enter the tenant (directory) ID of your Azure resource.
   - **Microsoft Entra Application ID or URI**: Enter the application (client) ID of your Azure resource.
  
   :::image type="content" source="../media/event-grid-subscription-additional-features.png" alt-text="Event Grid subscription additional features" lightbox="../media/event-grid-subscription-additional-features.png":::

1. Select **Create** to create the event subscription endpoint for recording.

   It can take up to 15 minutes to sync. If you get an error like "Webhook validation handshake failed," then retry this step after a few minutes.

## Set up call recording webhook

1. Follow the steps in [Set up the Incoming Calls webhook](#set-up-the-incoming-calls-webhook), but in the filter to event type, select **Select Recording File Status Updated** in the list.
1. For **Endpoint Type**, select **Web Hook** in the list.
1. For **Endpoint**, select **Select an endpoint**, and then enter the recording webhook endpoint from Customer Service admin center or Contact Center admin center. Go to **Channels** > **Phone Numbers** > **Advanced** > **Manage Azure Communication Services** > **Recording Web Hook Endpoint**.

   :::image type="content" source="../media/event-grid-subscription-recording-webhook-endpoint.png" alt-text="Event Grid subscription recording webhook endpoint" lightbox="../media/event-grid-subscription-recording-webhook-endpoint.png":::

1. Select the **Additional Features** tab. Select the **Use Microsoft Entra authentication checkbox**, and then enter the following details. For information about these values, go to the **Get Event Grid app and tenant IDs from the Power Apps portal** section.
    - **Microsoft Entra Tenant ID**: Enter the tenant (directory) ID of your Azure resource.
    - **Microsoft Entra Application ID or URL**: Enter the application (client) ID of your Azure resource.
  
1. Select **Create** to create the event subscription endpoint for recording.

   It can take up to 15 minutes to sync. If you get an error like, "Webhook validation handshake failed," then retry this step after a few minutes.

> [!NOTE]
> Make sure you enter the correct set of **Microsoft Entra Tenant ID** and **Microsoft Entra Application ID or URL** that matches the ones defined in your org. In case of an incorrect entry, you may get a Webhook validation handshake failed error.

## Set up SMS webhook

1. Follow the steps in the **Set up the Incoming Calls webhook** section but in the filter to event type, select **SMS Received and SMS Delivery Report Received** in the list.
1. For **Endpoint Type**, select **Web Hook** in the list.
1. For **Endpoint**, select **Select an endpoint**, and then enter the recording webhook endpoint from Contact Center admin center or Customer Service admin center. Go to **Channels** > **Phone Numbers** > **Advanced** > **Manage Azure Communication Services** > **SMS Web Hook Endpoint**.
1. Select the **Additional Features** tab. Select the **Use Microsoft Entra authentication checkbox**, and then enter the following details. For information about these values, go to **Get Event Grid app and tenant IDs from the Power Apps portal** section.
    - **Microsoft Entra Tenant ID**: Enter the tenant (directory) ID of your Azure resource.
    - **Microsoft Entra Application ID or URL**: Enter the application (client) ID of your Azure resource.
  
1. Select **Create** to create the event subscription endpoint for recording.

   It can take up to 15 minutes to sync. If you get an error like, "Webhook validation handshake failed," then retry this step after a few minutes. 

## Reconnect Azure resource from existing voice stack to the enhanced voice stack

If you're migrating from the existing voice stack to the enhanced voice stack, use the following video to make sure that your Event Grid is properly configured for incoming calls and recording.

> [!VIDEO https://www.youtube.com/embed/la2vgEqGshU]

## Get Event Grid app and tenant IDs from the Power Apps portal

> [!NOTE]
> Use this method only when you have issues with getting the IDs from the Power Apps Portal. To get the IDs from the Azure Portal, search for "app registrations" and find the registration for your connected Azure Communication Services resource. Copy the Application (client) ID to fill the Event Grid App ID box and the Directory (tenant) ID to fill the Event Grid Tenant ID box.

1. Open the [Power Apps portal](https://make.powerapps.com) and select your environment.

1. In the site map, select **Dataverse** > **Tables** > **All**.

1. Search for the **Communication Provider Setting Entry** table and open it.

1. In the **Communication Provider Setting Entry columns and data** section, view the **EventGridAppID** and **EventGripAppTenantID** fields in the **Key** column, and note down the corresponding ID values from the **Values** column.
