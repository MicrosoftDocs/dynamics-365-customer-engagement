---
title: "Enable recording and SMS services  | MicrosoftDocs"
description: "This article explains how to create event subscription endpoints to enable recording and SMS services for an Azure resource."
ms.date: 05/31/2022
ms.service: dynamics-365-customerservice
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.topic: article
---

# Enable recording and SMS services

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]



<!---
    > [!div class="mx-imgBorder"]
    > ![Add AAD authentication details.](./media/voice-channel-create-event-subscription-AAD-authentication.png "Add AAD authentication details.")

   > [!div class="mx-imgBorder"]
   > ![Copy Directory (tenant) ID.](./media/voice-channel-tenant-ID.png "Copy Directory (tenant) ID.")

   > [!div class="mx-imgBorder"]
   > ![Copy Application (client) ID.](./media/voice-channel-application-ID.png "Copy Application (client) ID.")

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

3. Go to the **Additional Features** tab, select the **Use AAD authentication** checkbox, and enter the following details.
    > [!div class="mx-imgBorder"]
    > ![Add AAD authentication details.](./media/voice-channel-create-event-subscription-AAD-authentication.png "Add AAD authentication details.")
   - **AAD Tenant ID**: Copy the **Directory (tenant) ID** field value from your Azure resource to this field. Not sure how to get your tenant ID? See [Get application and tenant IDs](voice-channel-resource-app-details.md#get-application-and-tenant-ids).
   > [!div class="mx-imgBorder"]
   > ![Copy Directory (tenant) ID.](./media/voice-channel-tenant-ID.png "Copy Directory (tenant) ID.") 
   - **AAD Application ID or URI**: Copy the **Application (client) ID** field value from your Azure resource to this field. Not sure how to get your application ID? See [Get application and tenant IDs](voice-channel-resource-app-details.md#get-application-and-tenant-ids).
   > [!div class="mx-imgBorder"]
   > ![Copy Application (client) ID.](./media/voice-channel-application-ID.png "Copy Application (client) ID.")

4. Select **Create** to create the event subscription endpoint for SMS. This might take some time, so if you get a sync error, try refreshing after some time.
    > [!div class="mx-imgBorder"]
    > ![Successfully created event subscription endpoint for SMS.](./media/voice-channel-event-subscription-sms-success.png "Create event grid callbacks for SMS.")

--->



### See also

[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Connect to an existing Azure resource](voice-channel-connect-existing-resource.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Get resource and app registration details from Azure portal](voice-channel-resource-app-details.md)  
[Register event grid system topics](voice-channel-event-grid.md)  
  
[!INCLUDE[footer-include](../includes/footer-banner.md)]