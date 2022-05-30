---
title: "Connect to an existing Azure resource | MicrosoftDocs"
description: "Use this article to understand how to connect to Azure Communication Services using an existing Azure resource."
ms.date: 05/31/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Advanced: Connect to an existing Azure resource

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

You can use an existing Azure resource from any of your Azure subscriptions, *available under any tenant*, to connect with voice or SMS channels. If you had previously disconnected a resource and want to use it now, you can do so using this option.

## Prerequisites

Before you connect an existing Azure resource to Azure Communication Services, you must perform the following steps.

- Check whether the **Get started** button to connect to an existing Azure resource is visible on the **Phone numbers** page. The **Get Started** button appears only in the following scenarios.
    - The trial has ended after the free calling time has elapsed.
    - You've manually ended the trial.
    - You've disconnected from the Azure resource. More information: [Disconnect from Azure Communication Services resource](voice-channel-acs-resource.md#disconnect-from-azure-communication-services-resource)

- Get the name and ID of your Azure resource from the Azure portal.

   To get the resource name and ID, open your resource on the Azure portal, go to **Settings** > **Properties**. Note the values of the **ACS Resource Name** and **ACS Resource ID** fields.

- Get the connection string of your Azure resource from the Azure portal. More information: [Access your connection string and endpoints](/azure/communication-services/quickstarts/create-communication-resource?tabs=windows&pivots=platform-azp#access-your-connection-strings-and-service-endpoints)

- Get the application (client) ID and directory (tenant) ID for your registered app. More information: [Get the application ID and directory ID](#get-the-application-id-and-directory-id)

## Connect to an existing Azure resource

1. In Dynamics 365, go to one of the admin apps, and perform the following steps.
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Channels** in **Customer support**. The **Channels** page appears.
    
    2. Select **Manage** for **Phone numbers**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

   In the site map, under **General settings**, select **Phone numbers**, and then select **Get started**. The **Connect to Azure Communication Services** dialog opens.

2. Select **Use existing resource**.

3. In the **Use existing resource** dialog, fill in the following fields using the resource details retrieved from the Azure portal.
   - **ACS Resource Name**: Enter the resource name.
   - **ACS Resource ID**: Enter the resource ID.
   - **Connection string**: Enter the connection string.
   - **Event grid app ID**: Enter the application (client) ID.
   - **Event grid app tenant ID**: Enter the tenant (directory) ID.

4. Select **Connect**. Your existing resource is now connected to Azure Communication Services.

5. Select **Add number**. The **Add phone number** page is displayed.

6. Add a new phone number. More information: [Acquire new phone numbers](voice-channel-manage-phone-numbers.md#acquire-new-phone-numbers)

You can now configure the voice workstream settings for the phone number, set up outbound and inbound calling to make and/or receive customer calls, and also enable recording and SMS services. More information: [Enable recording and SMS services](enable-recording-and-SMS-services)

### Enable recording and SMS services

This section explains how you can enable recording or SMS services by creating event subscription endpoints. To do this, you must first subscribe to the corresponding recording or SMS events by creating Event Grid subscriptions on the Azure portal. More information: [Event Grid](/azure/event-grid/overview)

>[!Note]
> You can only set one web hook endpoint at a time using the following procedure, so if you'd like to enable both the services, you must run the procedure two times to set the respective web hook endpoints.

1. Open the resource on the Azure portal, go to **Events**, and select **Event Subscription**.

2. In the **Create Event Subscription** dialog, enter the following details in the **Basic** tab.
    - **Name**: Enter a name for the recording event subscription.
    - **Event Schema**: Select **Event Grid Schema** from the dropdown list.
    - **Topic Types**: Select **Azure Communication Services** from the dropdown list.
    - **Subscription**: Select your subscription from the dropdown list.
    - **Resource Group**: Select the resource group.
    - **Resource**: Select the resource.
    - **System Topic Name**: This field is automatically populated with the system topic name you created. However, if you see multiple values, select the specific system topic name from the dropdown.
    - **Filter to Event Types**: For recording services, select the **Recording File Status Updated (Preview)** option from the dropdown list.
    - **Endpoint Type**: Select **Web Hook** from the dropdown list.
    - **Endpoint**: Select **Select an endpoint** and in the **Select Web Hook** dialog that opens, enter the recording or SMS web hook endpoint as follows.
        - To enable recording services, get the **Recording Web Hook Endpoint** and paste the value in the **Subscriber Endpoint** field, and select **Confirm Selection**. More information: [Get the Recording Web Hook Endpoint](#get-the-subscriber-endpoint-for-recording)
        - To enable SMS services, get the **SMS Web Hook Endpoint** and paste the value in the **Subscriber Endpoint** field, and select **Confirm Selection**. More information: [Get the SMS Web Hook Endpoint](#get-the-subscriber-endpoint-for-sms)

3. Go to the **Additional Features** tab, select the **Use AAD authentication** checkbox, and enter the following details.
   - **AAD Tenant ID**: Enter the tenant ID of your Azure resource.
   - **AAD Application ID or URI**: Enter the application ID of your Azure resource.

4. Select **Create** to create the event subscription endpoint for recording. This might take some time, so if you get a sync error, try refreshing after some time.

### Get the subscriber endpoint for recording

1. In Dynamics 365, go to one of the admin apps, and perform the following steps.
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Channels** in **Customer support**. The **Channels** page appears.
    
    2. Select **Manage** for **Phone numbers**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

   In the site map of Omnichannel admin center, under **General settings**, select **Phone numbers**. 

1. In the **Phone numbers** page that opens, select a phone number, and then select **Advanced**.

1. In the **Manage Azure Communication Services** page that opens, select **Copy** next to **Recording Web Hook Endpoint** and paste the web hook endpoint value in the **Subscriber Endpoint** field of the **Event Grid Subscription** page.
    > [!div class="mx-imgBorder"]
    > ![Copy recording web hook endpoint.](./media/voice-channel-recording-webhook-endpoint.png "Copy recording web hook endpoint.")

### Get the subscriber endpoint for SMS

1. In Dynamics 365, go to one of the admin apps, and perform the following steps.
   ### [Customer Service admin center](#tab/customerserviceadmincenter)

    1. In the site map, select **Channels** in **Customer support**. The **Channels** page appears.
    
    2. Select **Manage** for **Phone numbers**.

   ### [Omnichannel admin center](#tab/omnichanneladmincenter)

   In the site map of Omnichannel admin center, under **General settings**, select **Phone numbers**. 

1. In the **Phone numbers** page that opens, select a phone number, and then select **Advanced**.

1. In the **Manage Azure Communication Services** page that opens, select **Copy** next to **SMS Web Hook Endpoint** and note the value.
    > [!div class="mx-imgBorder"]
    > ![Copy SMS web hook endpoint.](./media/voice-channel-sms-webhook-endpoint.png "Copy SMS web hook endpoint.")

### Get the application ID and directory ID

1. Open the **Event Grid System Topics** service on the Azure portal.

1. [Create and deploy an event grid system topic](/azure/event-grid/create-view-manage-system-topics#create-a-system-topic).

1. On the **Event Grid System Topic** page that's created, select the **Subscription** link.

1. In the resource subscription page, select **Settings** > **Resource providers**, and then check if the **Microsoft.EventGrid** provider is listed as **Registered**. If the event grid is not registered, select the record and then select **Re-register** to register it.


### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Connect to a new Azure resource](voice-channel-connect-new-resource.md)  
[Enable recording and SMS services](voice-channel-sub-endpoints.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Set up inbound calling](voice-channel-route-queues.md) 
[Bring your own carrier](voice-channel-bring-your-own-number.md)  
[Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]