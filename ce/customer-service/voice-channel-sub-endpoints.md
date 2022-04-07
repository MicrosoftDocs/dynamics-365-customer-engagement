---
title: "Create event subscription endpoints | MicrosoftDocs"
description: "This article explains how to create event subscription endpoints to enable recording and SMS services for an Azure resource."
ms.date: 04/08/2022
ms.service: dynamics-365-customerservice
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Create event subscription endpoints

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

This topic explains how to create event subscription endpoints to enable recording and SMS services for an Azure resource.

## Create event subscription endpoint for recording

**To create event subscription endpoint for recording**

1. Open the resource on the Azure portal, go to **Events**, and select **Event Subscription**.

2. In the **Create Event Subscription** dialog, enter the following details in the **Basic** tab.
    > [!div class="mx-imgBorder"]
    > ![Add event subscription details for recording.](./media/voice-channel-create-event-subscription-recording.png "Add event subscription details for recording.")
    - **Name**: Enter a name for the recording event subscription.
    - **Event Schema**: Select **Event Grid Schema** from the dropdown list.
    - **System Topic Name**: This field is automatically populated with the system topic name you created. However, if you see multiple values, select the specific system topic name from the dropdown.
    - **Filter to Event Types**: Select **Recording File Status Updated (Preview)** from the dropdown list.
    - **Endpoint Type**: Select **Web Hook** from the dropdown list.
    - **Endpoint**: Select **Select an endpoint** and in the **Select Web Hook** dialog that opens, enter the **Subscriber Endpoint**.
      To get the subscriber endpoint:

         a. In the site map of Omnichannel admin center or Customer Service admin center app, under **General settings**, select **Phone numbers**.

         b. Select a phone number, and then select **Advanced**.

         c. In the **Manage Azure Communication Services** page that opens, select **Copy** next to **Recording Web Hook Endpoint** and paste the web hook endpoint value in the **Subscriber Endpoint** field.
         > [!div class="mx-imgBorder"]
         > ![Copy recording web hook endpoint.](./media/voice-channel-recording-webhook-endpoint.png "Copy recording web hook endpoint.")
          
         d. Select **Confirm Selection**.

3. Go to the **Additional Features** tab, select the **Use AAD authentication** checkbox, and enter the following details.
    > [!div class="mx-imgBorder"]
    > ![Add AAD authentication details.](./media/voice-channel-create-event-subscription-AAD-authentication.png "Add AAD authentication details.")
   - **AAD Tenant ID**: Copy the **Directory (tenant) ID** field value from your Azure resource to this field. Not sure how to get your tenant ID? See [Get application and tenant IDs](voice-channel-connect-existing-resource.md#get-application-and-tenant-ids).
   > [!div class="mx-imgBorder"]
   > ![Copy Directory (tenant) ID.](./media/voice-channel-tenant-ID.png "Copy Directory (tenant) ID.")
   - **AAD Application ID or URI**: Copy the **Application (client) ID** field value from your Azure resource to this field. Not sure how to get your application ID? See [Get application and tenant IDs](voice-channel-connect-existing-resource.md#get-application-and-tenant-ids).
   > [!div class="mx-imgBorder"]
   > ![Copy Application (client) ID.](./media/voice-channel-application-ID.png "Copy Application (client) ID.")

4. Select **Create** to create the event subscription endpoint for recording. This might take some time, so if you get a sync error, try refreshing after some time.

    > [!div class="mx-imgBorder"]
    > ![Successfully created event subscription endpoints for recording.](./media/voice-channel-event-subscription-recording-success.png "Create event grid callbacks for recording.")

## Create event subscription endpoint for SMS

**To create event subscription endpoint for SMS**

1. Open the resource on the Azure portal, go to **Events**, and select **Event Subscription**.

2. In the **Create Event Subscription** dialog, enter the following details in the **Basic** tab.
    - **Name**: Enter a name for the recording event subscription.
    - **Event Schema**: Select **Event Grid Schema** from the dropdown list.
    - **System Topic Name**: This field is automatically populated with the system topic name you created. However, if you see multiple values, select the specific system topic name from the dropdown.
    - **Filter to Event Types**: Select both **SMS Received** and **SMS Delivery Report Received** from the dropdown list.
       > [!div class="mx-imgBorder"]
    > ![Add event subscription details for SMS.](./media/voice-channel-create-event-subscription-sms-event-types.png "Add event subscription details for SMS.")
    - **Endpoint Type**: Select **Web Hook** from the dropdown list.
    - **Endpoint**: Select **Select an endpoint** and in the **Select Web Hook** dialog that opens, enter the **Subscriber Endpoint**.

      To get the subscriber endpoint:

      a. In the site map of Omnichannel admin center or Customer Service admin center app, in **General settings**, select **Phone numbers**.
         
      b. Select a phone number, and then select **Advanced**.
        
      c. In the **Manage Azure Communication Services** page that opens, select **Copy** next to **SMS Web Hook Endpoint** and paste the value in the **Subscriber Endpoint** field.
         > [!div class="mx-imgBorder"]
         > ![Copy SMS web hook endpoint.](./media/voice-channel-sms-webhook-endpoint.png "Copy SMS web hook endpoint.")

      d. Select **Confirm Selection**.

3. Go to the **Additional Features** tab, select the **Use AAD authentication** checkbox, and enter the following details.
    > [!div class="mx-imgBorder"]
    > ![Add AAD authentication details.](./media/voice-channel-create-event-subscription-AAD-authentication.png "Add AAD authentication details.")
   - **AAD Tenant ID**: Copy the **Directory (tenant) ID** field value from your Azure resource to this field. Not sure how to get your tenant ID? See [Get application and tenant IDs](voice-channel-connect-existing-resource.md#get-application-and-tenant-ids).
   > [!div class="mx-imgBorder"]
   > ![Copy Directory (tenant) ID.](./media/voice-channel-tenant-ID.png "Copy Directory (tenant) ID.") 
   - **AAD Application ID or URI**: Copy the **Application (client) ID** field value from your Azure resource to this field. Not sure how to get your application ID? See [Get application and tenant IDs](voice-channel-connect-existing-resource.md#get-application-and-tenant-ids).
   > [!div class="mx-imgBorder"]
   > ![Copy Application (client) ID.](./media/voice-channel-application-ID.png "Copy Application (client) ID.")

4. Select **Create** to create the event subscription endpoint for SMS. This might take some time, so if you get a sync error, try refreshing after some time.
    > [!div class="mx-imgBorder"]
    > ![Successfully created event subscription endpoint for SMS.](./media/voice-channel-event-subscription-sms-success.png "Create event grid callbacks for SMS.")

### See also

[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Connect to an existing Azure resource](voice-channel-connect-existing-resource.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Get resource and app registration details from Azure portal](voice-channel-resource-app-details.md)  
[Register event grid system topics](voice-channel-event-grid.md)  
[Create event subscription endpoints](voice-channel-sub-endpoints.md)  
  
[!INCLUDE[footer-include](../includes/footer-banner.md)]