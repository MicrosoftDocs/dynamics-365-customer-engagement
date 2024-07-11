---
title: Connect using an existing Azure resource
description: Learn how to connect your voice and SMS channels to Azure Communication Services using an existing Azure resource.
ms.date: 07/01/2024
ms.custom: bap-template
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection:
---

# Advanced: Connect using an existing Azure resource


[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

[!INCLUDE[azure-ad-rename](../../includes/cc-azure-ad-rename.md)]

You can connect your voice or SMS channels to Azure Communication Services using an existing Azure resource from any of your Azure subscriptions within the same tenant. If you disconnected a resource and want to use it now, you can do so using this option.

## Prerequisites

- The organization that you're using isn't a trial version.
- The **Get started** button that connects to an existing Azure resource is visible on the **Phone numbers** page of Customer Service admin center or Contact Center admin center. The **Get Started** button appears only when:
  - The trial has ended after the free calling time has elapsed.
  - You've manually [ended the trial](voice-channel-trial-phone-numbers.md#end-the-trial).
  - You've [disconnected from the Azure resource](voice-channel-disconnect-from-acs.md). 
- Your active Azure subscription is in the same tenant as your Dynamics 365 account in the enhanced voice experience.
- Your role has **Contributor** privileges.

### Get Azure resource information

Before you connect an existing Azure resource to Azure Communication Services, you must retrieve the following information from the [Azure portal](https://ms.portal.azure.com/):

1. Go to **Resource groups** and select the required resource group. 
1. Select the required **Resource** from the resource group.
    :::image type="content" source="../media/acs-resource-existing-mini.png" alt-text="image showing how to add a resource" lightbox="../media/acs-existing-resource.png":::
1.  Select **Properties** in **Settings**. 
1. On the **Properties** page,  copy the **Name** and **Resource ID** field values, which you must specify as **ACS Resource Name** and **ACS Resource ID** values in Customer Service admin center or Contact Center admin center.
   :::image type="content" source="../media/acs-property-records-mini.png" alt-text="image showing the resource id values " lightbox="../media/acs-property-records.png":::


1. Select **Tools** in **Keys**. On the **Keys**, copy **Connection string** in **Primary key**, which you'll use as the value of **Connection string**  in Customer Service admin center or Contact Center admin center. 

   :::image type="content" source="../media/acs-resource-keys.png" alt-text="image showing resource keys" :::


 > [!NOTE]
 > If you regenerate the connection string in Azure Communication Services after establishing connectivity to the Azure Communication Service resource, the existing connection string in the Contact Center admin center app becomes invalid. An error message is also displayed in the connection string field in the admin center. To resolve the error, copy the correct connection string from the Azure portal and paste it in the **Connection string** field in **Channels** > **Phone Numbers** > **Advanced** > **Manage Azure Communication Services** in Contact Center admin center. The application displays a success message if the connection is successful.

### Get Event Grid application and tenant IDs from the Azure portal

You'll need to specify the values of **Application (client) ID** and **Directory (tenant) ID** in **Event grid app id** and **Event grid app tenant id** in Contact Center admin center or Customer Service admin center. Perform the following steps to get these values:

1. On the Azure portal, open the **App registrations** page. If you're registering your app on the Azure portal for the first time, then perform the following steps, otherwise, select the registered app and go to step 2:

    1. On the **Register an application** page, enter the following details:

        - **Name**: Enter a name for your application.
        - **Supported account types**: Select **Accounts in any organizational directory (Any Microsoft Entra ID - Multitenant)**.

    1. Select **Register**.
       :::image type="content" source="../media/acs-resource-register.png" alt-text="resource keys" :::

1. Select the value of the **Application (client) ID** field, and then select **Copy to clipboard**. You'll enter this as the value of **Event grid app id** in  Contact Center admin center or Customer Service admin center.

1. Select the value of the **Directory (tenant) ID** field, select the **Copy to clipboard** button, and then note the value. You'll enter this as the value of **Event grid app tenant id** in Contact Center admin center or Customer Serivce admin center.

    :::image type="content" source="../media/acs-resource-application.png" alt-text="resource application" :::

## Connect using an existing Azure resource

1. In the site map of Contact Center admin center or Customer Service admin center, under **Customer support**, select **Channels**.
1. Select **Manage** for **Phone numbers**.
1. Select **Use existing resource** and specify the following:
     - Paste the values you've copied in the [Get Azure resource information](#get-azure-resource-information) section to the following fields:
       - **ACS Resource name** and **ACS Resource ID**: The **Name** and **Resource ID** field values.
       - **Connection String**: The **Connection string** field value.
     - Paste the values you've copied in [Get application and tenant IDs](#get-event-grid-application-and-tenant-ids-from-the-azure-portal) to the following fields:
     
       - **Event grid app id**: The value of the **Application (client) ID** 
       - **Event grid app tenant id**: The value of the **Directory (tenant) ID** 

     - Select the checkbox to confirm that the Azure Communication Services resource is connected to this Dynamics 365 Contact Center or Customer Service instance only.

1. Select **Connect** to connect the resource to Azure Communication Services.

After you configure the Azure Communication Services resource, the **Manage Azure Communication Services** page displays the following:
 -  **Event grid app id**
 - **Event grid app tenant id**
 - **Recording Web Hook Endpoint**
 - **SMS Web Hook Endpoint**
 -  **Incoming call Web Hook Endpoint (preview)**.

You can copy the subscriber endpoint values such as **Recording Web Hook Endpoint**, **SMS Web Hook Endpoint**, and **Incoming call Web Hook Endpoint (preview)** to use them in the following section.

> [!NOTE]
> **Incoming call Web Hook Endpoint (preview)** is available only if the enhanced voice experience is deployed in your region.

## Enable incoming calls, call recording, and SMS services

Azure Communication Services integrates with [Azure Event Grid](/azure/event-grid/overview) to send real-time notifications for chat, telephony, SMS, video, and voice calling events. The Azure Event Grid, in turn, uses event subscriptions to route event messages to subscribers.

To enable call recording and SMS services, you must first configure your applications to listen to Azure Communication Services events by registering [Event Grid system topics](/azure/event-grid/system-topics). Then, subscribe to the specific incoming call, call recording, or SMS events by creating Event Grid subscriptions on the Azure portal.

> [!IMPORTANT]
>
> - You need to be an owner of the [App registration](#get-event-grid-application-and-tenant-ids-from-the-azure-portal) to create Event Grid subscriptions.
> - You can set one webhook endpoint only at a time using the following procedure. To enable incoming calls, SMS, and call recording services, you must perform the procedure thrice to set a webhook endpoint for each service.
> - When you connect your event subscription, you must use the same application (client) ID and tenant (directory) ID for the app registration as you did when you first connected to your Azure resource. To get the event grid app and tenant IDs from the Power Apps portal, see [Get event grid app and tenant IDs from the Power Apps portal](#get-event-grid-app-and-tenant-ids-from-the-power-apps-portal).

1. Open the **Event Grid System Topics** service on the Azure portal.

1. [Create and deploy an Event Grid system topic](/azure/event-grid/create-view-manage-system-topics#create-a-system-topic).

1. On the **Event Grid System Topic** page, select the **Subscription** link.

1. In the resource subscription page, select **Settings** > **Resource providers**, and then check whether the **Microsoft.EventGrid** provider is listed as **Registered**. If the Event Grid isn't registered, then select the record, and then select **Re-register** to register it.

1. Open the resource on the Azure portal. Select **Events**, and then select **Event Subscription**.

1. Enter the following details in the **Basic** tab:
    - **Name**: Enter a name for the recording event subscription.
    - **Event Schema**: Select **Event Grid Schema** in the list.
    - **Topic Types**: Select **Azure Communication Services** in the list.
    - **Subscription**: Select your subscription in the list.
    - **Resource Group**: Select the resource group.
    - **Resource**: Select the resource.
    - **System Topic Name**: This field is automatically populated with the system topic name you created. However, if you see multiple values, select the specific system topic name from the list.
    - **Filter to Event Types**: You can filter events for call recording, incoming calls, or SMS services.
        - To filter event types for recording services, select **Recording File Status Updated** in the list.
        - To filter event types for SMS services, select **SMS Received** and **SMS Delivery Report Received** in the list.
        - To filter event types for incoming calls, select **Incoming Call** in the list.
    - **Endpoint Type**: Select **Web Hook** in the list.
    - **Endpoint**: Select **Select an endpoint**, and then enter the incoming call, recording, or SMS webhook endpoint from the Customer Service admin center or Contact Center admin center. Go to **Channels** > **Phone Numbers** > **Advanced** > **Manage Azure Communication Services** to get the following webhook endpoints:
        - **Recording Web Hook Endpoint** to enable recording services.
        - **SMS Web Hook Endpoint** to enable SMS services.
        - **Incoming call Web Hook Endpoint (preview)** to enable incoming calls.

1. Select the **Additional Features** tab. Select the **Use AAD authentication** checkbox, and enter the following details:

   - **AAD Tenant ID**: Enter the tenant (directory) ID of your Azure resource.
   - **AAD Application ID or URI**: Enter the application (client) ID of your Azure resource.

1. Select **Create** to create the event subscription endpoint for recording.

   It can take up to 15 minutes to sync. If you get an error like "Webhook validation handshake failed," then retry this step after a few minutes.


#### Get event grid app and tenant IDs from the Power Apps portal

[!NOTE]
Use the method only when you have issues in getting the IDs from the Azure Portal. To get the IDs from the Azure Portal, search for "app registrations" and find the registration for your connected Azure Communication Services resource. Copy the Application (client) ID to fill the event grid App ID box and the Directory (tenant) ID to fill the event grid Tenant ID box.

1. Open the [Power Apps portal](https://make.powerapps.com) and select your environment.

1. In the site map, select **Dataverse** > **Tables** > **All**.

1. Search for the **Communication Provider Setting Entry** table and open it.

1. In the **Communication Provider Setting Entry columns and data** section, view the **EventGridAppID** and **EventGripAppTenantID** fields in the **Key** column, and note down the corresponding ID values from the **Values** column.

## Next steps

[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[configure voice workstream settings](create-workstreams.md)  
[Configure inbound calling](voice-channel-inbound-calling.md)  
[Configure outbound calling](voice-channel-outbound-calling.md)    

### See also

[Overview of the voice channel](voice-channel.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Connect using a new Azure resource](voice-channel-connect-new-resource.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Set up inbound calling](../voice-channel-route-queues.md)  
[Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)  
[Configure call recording and transcription for a voice workstream](voice-channel-configure-transcripts.md).

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
