---
title: Connect using an existing Azure resource
description: Learn how to connect your voice and SMS channels to Azure Communication Services using an existing Azure resource.
ms.date: 02/20/2023
ms.custom: bap-template
ms.topic: how-to
author: neeranelli
ms.author: nenellim
---

# Advanced: Connect using an existing Azure resource

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

You can connect your voice or SMS channels to Azure Communication Services using an existing Azure resource from any of your Azure subscriptions, *available under any tenant*. If you disconnected a resource and want to use it now, you can do so using this option.

## Prerequisites

- The org that you're using is not a trial version. 
- Confirm the **Get started** button to connect to an existing Azure resource is visible on the **Phone numbers** page of Customer Service Admin Center. The **Get Started** button appears only when:
  - The trial has ended after the free calling time has elapsed.
  - You've manually ended the trial.
  - You've [disconnected from the Azure resource](voice-channel-disconnect-from-acs.md). 
- Your active Azure subscription must be in the same tenant as your Dynamics 365 account.
- Your role has **Contributor** privileges.

#### Get Azure resource information

Before you connect an existing Azure resource to Azure Communication Services, you must retrieve the following information from the Azure portal:

1. Go to **Resource groups** and select the required resource group. 
1. Select the required **Resource** from the resource group.
1. Select **Properties** in **Settings**. On the **Properties** page,  copy the **Name** and **Resource ID** field values, which you must specify as **ACS Resource Name** and **ACS Resource ID** values in Customer Service admin center.
1. Select **Tools** in **Keys**. On the **Keys**, copy **Connection string** in **Primary key**, which you'll use as the value of **Connection string**  in Customer Service admin center. 

#### Get application and tenant IDs from the Azure portal

You'll need to specify the values of **Application (client) ID** and **Directory (tenant) ID** in **vent grid app id** and **Event grid app tenant id** in Customer Service admin center. Perform the following steps to get these values:

1. Open the **App registrations** page on the Azure portal.

    If you're registering your app on the Azure portal for the first time, then perform the following steps:

    1. On the **Register an application** page, enter the following details:

        - **Name**: Enter a name for your application.
        - **Supported account types**: Select **Accounts in any organizational directory (Any Azure AD directory - Multitenant)**.

    1. Select **Register**.

1. Select the value of the **Application (client) ID** field, select the **Copy to clipboard** button, and then note the value.

1. Select the value of the **Directory (tenant) ID** field, select the **Copy to clipboard** button, and then note the value.

## Connect using an existing Azure resource

1. In Dynamics 365 Customer Service admin center or Omnichannel admin center, open the phone number settings.

    - Customer Service admin center:

        1. In the site map, under **Customer support**, select **Channels**.
        2. To the right of **Phone numbers**, select **Manage**.

    - Omnichannel admin center: In the site map, under **General settings**, select **Phone numbers**, and then select **Get started**.

1. Select **Use existing resource**.

1. Fill in the fields using the resource information you retrieved from the Azure portal.

1. Select **Connect** to connect the resource to Azure Communication Services.

1. Select **Add number**.
1. [Add a new phone number](voice-channel-manage-phone-numbers.md#acquire-new-phone-numbers).

Next, [configure voice workstream settings](create-workstreams.md) for the phone number, set up [inbound](voice-channel-route-queues.md) and [outbound](voice-channel-outbound-calling.md) calling, and enable call recording and SMS services.

### Enable call recording and SMS services

Azure Communication Services integrates with [Azure Event Grid](/azure/event-grid/overview) to send real-time notifications for chat, telephony, SMS, video, and voice calling events. The Azure Event Grid, in turn, uses event subscriptions to route event messages to subscribers.

To enable call recording and SMS services, you must first configure your applications to listen to Azure Communication Services events by registering [Event Grid system topics](/azure/event-grid/system-topics). Then, subscribe to the specific call recording or SMS events by creating Event Grid subscriptions on the Azure portal.

> [!IMPORTANT]
>
> - You can only set one web hook endpoint at a time using the following procedure. To enable both SMS and call recording services, you must perform the procedure two times to set a web hook endpoint for each service.
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
    - **Filter to Event Types**: You can filter events for either call recording or SMS services.
        - To filter event types for recording services, select **Recording File Status Updated (Preview)** in the list.
        - To filter event types for SMS services, select **SMS Received** and **SMS Delivery Report Received** in the list.
    - **Endpoint Type**: Select **Web Hook** in the list.
    - **Endpoint**: Select **Select an endpoint**, and then enter the recording or SMS web hook endpoint:
        - To enable recording services, [get the **Recording Web Hook Endpoint**](#get-the-subscriber-endpoint-for-recording) from Customer Service admin center, paste the value in **Subscriber Endpoint**, and then select **Confirm Selection**.
        - To enable SMS services, [get the **SMS Web Hook Endpoint**](#get-the-subscriber-endpoint-for-sms) from Customer Service admin center, paste the value in **Subscriber Endpoint**, and then select **Confirm Selection**.

1. Select the **Additional Features** tab. Select the **Use AAD authentication** checkbox, and enter the following details:

   - **AAD Tenant ID**: Enter the tenant (directory) ID of your Azure resource.
   - **AAD Application ID or URI**: Enter the application (client) ID of your Azure resource.

1. Select **Create** to create the event subscription endpoint for recording.

   It can take up to 15 minutes to sync. If you get an error like "Webhook validation handshake failed," then retry this step after a few minutes.

[Learn more about configuring call recording and transcription for a voice workstream in Omnichannel for Customer Service](voice-channel-configure-transcripts.md).


#### Get event grid app and tenant IDs from the Power Apps portal

1. Open the [Power Apps portal](https://make.powerapps.com) and select your environment.

1. In the site map, select **Dataverse** > **Tables** > **All**.

1. Search for the **Communication Provider Setting Entry** table and open it.

1. In the **Communication Provider Setting Entry columns and data** section, view the **EventGridAppID** and **EventGripAppTenantID** fields in the **Key** column, and note down the corresponding ID values from the **Values** column.

#### Get the subscriber endpoint for recording

1. In Dynamics 365 Customer Service admin center or Omnichannel admin center, open the phone number settings.

    - Customer Service admin center:

        1. In the site map, under **Customer support**, select **Channels**.
        2. To the right of **Phone numbers**, select **Manage**.

    - Omnichannel admin center: In the site map, under **General settings**, select **Phone numbers**, and then select **Get started**.

1. Select a phone number, and then select **Advanced**.

1. Select **Copy** next to **Recording Web Hook Endpoint** and note the value.

#### Get the subscriber endpoint for SMS

1. In Dynamics 365 Customer Service admin center or Omnichannel admin center, open the phone number settings.

    - Customer Service admin center:

        1. In the site map, under **Customer support**, select **Channels**.
        2. To the right of **Phone numbers**, select **Manage**.

    - Omnichannel admin center: In the site map, under **General settings**, select **Phone numbers**, and then select **Get started**.

1. Select a phone number, and then select **Advanced**.

1. Select **Copy** next to **SMS Web Hook Endpoint** and note the value.


## Next steps

[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Bring your own carrier](voice-channel-bring-your-own-number.md)

### See also

[Overview of the voice channel](voice-channel.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Connect using a new Azure resource](voice-channel-connect-new-resource.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Set up inbound calling](voice-channel-route-queues.md)  
[Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
