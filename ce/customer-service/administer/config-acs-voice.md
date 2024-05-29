---
title: Connect an Azure Communication Services resource to the voice channel
description: Learn how to connect to Azure Communication Services by using a new or existing resource to configure the voice channel.
ms.date: 06/01/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.custom: bap-template
---

# Connect an Azure Communication Services resource to the voice channel

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The voice channel in Omnichannel for Customer Service is built over Azure Communication Services. This capability lets you provision phone numbers for your business by connecting to Azure Communication Services. Perform the following steps:

1. Get application and tenant IDs from the Azure portal
1. [Connect to an Azure Communication Services resource](#connect-to-an-azure-communication-services-resource)
1. Enable call recording and SMS services


## Get application and tenant IDs from the Azure portal

You'll need to specify the values of **Application (client) ID** and **Directory (tenant) ID** in Customer Service admin center. Perform the following steps to get these values:

1. Open the **App registrations** page on the Azure portal.

    If you're registering your app on the Azure portal for the first time, then perform the following steps:

    1. On the **Register an application** page, enter the following details:

        - **Name**: Enter a name for your application.
        - **Supported account types**: Select **Accounts in any organizational directory (Any Microsoft Entra ID - Multitenant)**.

    1. Select **Register**.
       :::image type="content" source="../media/acs-resource-register.png" alt-text="resource keys" :::

1. Select the value of the **Application (client) ID** field, and then select the **Copy to clipboard** button. You'll need to enter this as the value of **Event grid app id** in Customer Service admin center.

1. Select the value of the **Directory (tenant) ID** field, select the **Copy to clipboard** button, and then note the value. You'll need to enter this as the value of **Event grid app tenant id** in Customer Service admin center.

    :::image type="content" source="../media/acs-resource-application.png" alt-text="resource application" :::


## Connect to an Azure Communication Services resource

1. In Customer Service admin center, select **Channels** in **Customer support**. The **Channels** page appears.
1. Select **Manage** for **Phone numbers**.
1. Select **Get started**. The **Connect to Azure Communication Services** dialog opens. You can select **Create new resource** or **Use existing resource**.

   ### [New Azure resource](#tab/newazureresource)

   In the Manage Azure Communication Services dialog, specify the following values:
    - **Event grid app id**: The value of the **Application (client) ID** from the [Get application and tenant IDs](#get-application-and-tenant-ids-from-the-azure-portal) 
    - **Azure subscription**: Select a subscription from the dropdown list.
    - **Azure resource group**: Select an existing resource group or select **Create new**, and enter a name for a new resource group.
      > [!NOTE]
      > The resource group name should be unique within a subscription.
   - **Resource name**: Enter a name for the resource. The resource name can contain only letters, numbers, and hyphens.
   
   ### [Existing Azure resource](#tab/omnichanneladmincenter)

   **Azure configurations**  
   Before you connect an existing Azure resource to Azure Communication Services, you must retrieve the following information from the [Azure portal](https://ms.portal.azure.com/):

   - Go to **Resource groups** and select the required resource group. 
   - Select the required **Resource** from the resource group.
    
     :::image type="content" source="../media/acs-resource-existing-mini.png" alt-text="image showing how to add a resource" lightbox="../media/acs-existing-resource.png"::: 
   
   -  Select **Properties** in **Settings**. 
   - On the **Properties** page, copy the **Name** and **Resource ID** field values, which you must specify as **ACS Resource Name** and **ACS Resource ID** values in Customer Service admin center.

     :::image type="content" source="../media/acs-property-records-mini.png" alt-text="image showing the resource id values " lightbox="../media/acs-property-records.png":::

   - Select **Tools** in **Keys**. On the **Keys**, copy **Connection string** in **Primary key**, which you'll use as the value of **Connection string** in Customer Service admin center. 

      :::image type="content" source="../media/acs-resource-keys.png" alt-text="image showing resource keys" :::

    **Customer Service admin center**<br>

    In the Manage Azure Communication Services dialog, specify the following values:
     - **ACS Resource name** and **ACS Resource ID**: The **Name** and **Resource ID** field values you've copied in the section above.
     - **Connection String**: The **Connection string** field value you've copied in the section above.
        
        > [!NOTE]
        > If you regenerate the connection string in Azure Communication Services after establishing connectivity to the Azure Communication Service resource, the existing connection string in Customer Service admin center becomes invalid. An error message is also displayed in the connection string field in Customer Service admin center. To resolve the error, copy the correct connection string from the Azure portal and paste it in the **Connection string** field in **Channels** > **Phone Numbers** > **Advanced** > **Manage Azure Communication Services**. The application displays a success message if the connection is successful.
     
     - **Event grid app id**: The value of the **Application (client) ID** from the [Get application and tenant IDs](#get-application-and-tenant-ids-from-the-azure-portal)
     - **Event grid app tenant id**: The value of the **Directory (tenant) ID** from the [Get application and tenant IDs](#get-application-and-tenant-ids-from-the-azure-portal).
     - Select the check box to confirm that the Dynamics 365 Customer Service instance is connected to only one Azure Communication Services resource.


After you've configured the Azure Communication Services resource, the **Manage Azure Communication Services** page displays the **Event grid app id**, **Event grid app tenant id**, **Recording Web Hook Endpoint**, **SMS Web Hook Endpoint**, and **Incoming call Web Hook Endpoint (preview)**.

You can copy the subscriber endpoint values such as **Recording Web Hook Endpoint**, **SMS Web Hook Endpoint**, and **Incoming call Web Hook Endpoint (preview)** to use them in the following section.

## Enable incoming calls, call recording, and SMS services

Azure Communication Services integrates with [Azure Event Grid](/azure/event-grid/overview) to send real-time notifications for chat, telephony, SMS, video, and voice calling events. The Azure Event Grid, in turn, uses event subscriptions to route event messages to subscribers.

To enable call recording and SMS services, you must first configure your applications to listen to Azure Communication Services events by registering [Event Grid system topics](/azure/event-grid/system-topics). Then, subscribe to the specific call recording or SMS events by creating Event Grid subscriptions on the Azure portal.

> [!IMPORTANT]
>
> - You can set one web hook endpoint only at a time using the following procedure. To enable incoming calls, SMS, and call recording services, you must perform the procedure thrice to set a web hook endpoint for each service.
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
        - To filter event types for SMS services, select **Incoming Call** in the list.
    - **Endpoint Type**: Select **Web Hook** in the list.
    - **Endpoint**: Select **Select an endpoint**, and then enter the incoming call, recording, or SMS web hook endpoint from the Customer Service admin center. Go to **Channels** > **Phone Numbers** > **Advanced** > **Manage Azure Communication Services** to get the following web hook endpoints:
        - **Recording Web Hook Endpoint** to enable recording services.
        - **SMS Web Hook Endpoint** to enable SMS services.
        - **Incoming call Web Hook Endpoint (preview)** to enable incoming calls.

1. Select the **Additional Features** tab. Select the **Use AAD authentication** checkbox, and enter the following details:

   - **AAD Tenant ID**: Enter the tenant (directory) ID of your Azure resource.
   - **AAD Application ID or URI**: Enter the application (client) ID of your Azure resource.

1. Select **Create** to create the event subscription endpoint for recording.

   It can take up to 15 minutes to sync. If you get an error like "Webhook validation handshake failed," then retry this step after a few minutes.

[Learn about configuring call recording and transcription for a voice workstream in Omnichannel for Customer Service](voice-channel-configure-transcripts.md).

#### Get event grid app and tenant IDs from the Power Apps portal

1. Open the [Power Apps portal](https://make.powerapps.com) and select your environment.

1. In the site map, select **Dataverse** > **Tables** > **All**.

1. Search for the **Communication Provider Setting Entry** table and open it.

1. In the **Communication Provider Setting Entry columns and data** section, view the **EventGridAppID** and **EventGripAppTenantID** fields in the **Key** column, and note down the corresponding ID values from the **Values** column.

## Next steps

[Add a new phone number](voice-channel-manage-phone-numbers.md#acquire-new-phone-numbers)  
[Configure voice workstream settings](create-workstreams.md) for the phone number  
Set up [inbound](../voice-channel-route-queues.md) and [outbound](voice-channel-outbound-calling.md) calling

### See also

[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Overview of the voice channel](voice-channel.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Connect using a new Azure resource](voice-channel-connect-new-resource.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Set up inbound calling](../voice-channel-route-queues.md)  
[Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]

     
      