---
title: "Connect to Azure Communication Services | MicrosoftDocs"
description: "Use this topic to understand how to connect to Azure Communication Services using new or existing Azure resources."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 11/01/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Connect to Azure Communication Services

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Before you can provision phone numbers for your business in Omnichannel Customer Service, you must first establish connection with the Azure Communication Services. You can [connect to a new Azure resource](#connect-to-a-new-azure-resource) or [use an existing one](#connect-to-an-existing-azure-resource), and then deploy the resource through Dynamics 365.

## Prerequisites

Before you connect to a new Azure resource, check whether you have the following:
- A valid Azure subscription that's in the same tenant as your Dynamics 365 account. If you don't have an Azure subscription, [create a free account](https://azure.microsoft.com/free/?WT.mc_id=A261C142F) before you begin.
- At least contributor-level permissions to the Azure subscription. To check your role, open your subscription and view the **My role** column of your subscription on the Azure portal. You'll be able to deploy your Azure resource only if you have at least contributor-level permissions.

## Connect to a new Azure resource

After you've verified your Azure subscription and checked your permissions on the subscription, you can create a new Azure resource and connect to it.

**To create a new Azure resource**

1. In the site map of Omnichannel admin center, under **General settings**, select **Phone numbers**, and then select **Get started**.

    The **Connect to Azure Communication Services** dialog opens.

2. Select **Create new resource** and enter the following details:
   - **Azure subscription**: Select a subscription from the dropdown list.
   - **Azure resource group**: Select an existing resource group or select **Create new**, and enter a name for a new resource group.
      > [!NOTE]
      > The resource group name should be unique within a given subscription.
   - **Resource name**: Enter a name for the resource.
3. Select **Deploy** to create and deploy the resource. 
    > [!div class="mx-imgBorder"]
    > ![Create new resource.](./media/voice-channel-number-mgmt-azure-create-new-resource.png "Create new resource.")
You're now connected to Azure Communication Services.

## Connect to an existing Azure resource

You can also use an existing Azure Communication Services resource to connect with voice or SMS channels. You can use a resource from any of your Azure subscriptions, available under any tenant.

*If you had previously unlinked a resource and want to use it now, you can do so using this option.*

Before you proceed with adding an existing resource to Azure Communication Services, you must have the following information available for use in Omnichannel admin center.
- [Get the resource name and ID from the Azure portal](#get-resource-name-and-id).
- [Get the connection string from the Azure portal](#get-connection-string).
- [Get the application ID and tenant ID from the App registrations page on the Azure portal](#get-application-and-tenant-ids).

**To connect to an existing Azure resource**

1. In the site map of Omnichannel admin center and under **General settings**, select **Phone numbers**, and then select **Get started**.

   The **Connect to Azure Communication Services** dialog opens.

2. Select **Use existing resource**.
    > [!div class="mx-imgBorder"]
    > ![Select the use existing resource option.](./media/voice-channel-select-use-existing-resource.png "Select the use existing resource option.")

3. Enter the following details, based on the values available on the Azure portal.
   - **ACS Resource Name**: [Enter the resource name](#get-resource-name-and-id).
   - **ACS Resource ID**: [Enter the resource ID](#get-resource-name-and-id).
   - **Connection string**: [Enter the connection string](#get-connection-string).
   - **Event grip app ID**: [Enter the application ID](#get-application-and-tenant-ids).
   - **Event grip app tenant ID**: [Enter the tenant ID](#get-application-and-tenant-ids).

4. Select **Connect**. 
    > [!div class="mx-imgBorder"]
    > ![Azure resource is connected to Azure Communication Services.](./media/voice-channel-acs-connection.png "Azure resource is connected to Azure Communication Services.")

Your existing Azure resource is now connected to Azure Communication Services. You'll now be able to provision or acquire new phone numbers for your organization.

5. Select **Add number**. The **Add phone number** page is displayed.

6. [Add a new phone number](voice-channel-manage-phone-numbers.md#acquire-new-phone-numbers).

7. [Create, deploy, and register event grid system topics](#create-deploy-and-register-event-grid-system-topics).

8. [Create event subscription endpoint for recording](#create-event-subscription-endpoint-for-recording).

9. [Create event subscription endpoint for SMS](#create-event-subscription-endpoint-for-sms).

You can now configure the voice workstream settings for the phone number, configure outbound and inbound calling to make and/or receive customer calls.

The following section include short procedures that explain how you can get retrieve resource name, resource ID, connection string, application ID, tenant ID, and other details from the Azure portal.

### Get resource name and ID

**To get the resource name and ID from the Azure portal**

1. Open your existing resource on the Azure portal in a separate window or tab, and go to **Settings** > **Properties**. 
2. Select the value of the **Name** field, select the **Copy to clipboard** button, and then paste the value in the **ACS Resource Name** field of the **Use existing resource** dialog.
   > [!div class="mx-imgBorder"]
   > ![Copy resource name.](./media/voice-channel-resource-name.png "Copy resource name.")
3. Select the value of the **Resource ID** field, then select the **Copy to clipboard** button, and paste the value in the **ACS Resource ID** field of the **Use existing resource** dialog.

   > [!div class="mx-imgBorder"]
   > ![Copy resource ID.](./media/voice-channel-resource-ID.png "Copy resource ID.")

### Get connection string

**To get the connection string from the Azure portal**

1. Open your existing resource on the Azure portal in a separate window or tab, and go to **Tools** > **Keys** > **Primary key**. 
2. Select the value of the **Connection string** field, then select the **Copy to clipboard** button, and paste the value in the **Connection string** field of the **Use existing resource** dialog.

   > [!div class="mx-imgBorder"]
   > ![Copy connection string.](./media/voice-channel-connection-string.png "Copy connection string.")

### Get application and tenant IDs

You'll retrieve values for the application and tenant IDs from the Azure portal and paste them in the corresponding fields of the **Use existing resource** dialog.

1. Open the **App registrations** page on the Azure portal in a separate window or tab.

    If you're registering your app on the Azure portal for the first time, then do the following:
    1. On the **Register an application** page, enter the following details:
        - **Name**: Enter a name for your application.
        - **Supported account types**: Select **Accounts in any organizational directory (Any Azure AD directory - Multitenant)**
    2. Select **Register**.
       > [!div class="mx-imgBorder"]
       > ![Register an application.](./media/voice-channel-register-app.png "Register an application.")

2. Select the value of the **Application (client) ID** field, select the **Copy to clipboard** button, and then paste the value in the **Application ID** field of the **Use existing resource** dialog.
   > [!div class="mx-imgBorder"]
   > ![Copy Application (client) ID.](./media/voice-channel-application-ID.png "Copy Application (client) ID.")

3. Select the value of the **Directory (tenant) ID** field, then select the **Copy to clipboard** button, and paste the value in the **Tenant ID** field of the **Use existing resource** dialog.
   > [!div class="mx-imgBorder"]
   > ![Copy Directory (tenant) ID.](./media/voice-channel-tenant-ID.png "Copy Directory (tenant) ID.")

### Create, deploy, and register event grid system topics

You'll create, deploy, and register event grid system topics.

1. Open the Azure portal in a separate window or tab, and open the **Event Grid System Topics** service. 
2. Select **Create** and in the **Create Event Grid System Topic** page, enter the following details.
    - **Topic Types**: Select **Azure Communication Services** from the dropdown list.
    - **Subscription**: Select the subscription from the dropdown list.
    - **Resource group**: Select the resource group where you created the Azure resource.    
    - **Resource**: Select the Azure resource.
    - **Name**: Enter a name for the system topic.
    > [!div class="mx-imgBorder"]
    > ![Create event grid system topic.](./media/voice-channel-create-event-grid-system-topic.png "Create event grid system topic.")
3. Select **Review + create**. The system topic is validated and deployed.  
    > [!div class="mx-imgBorder"]
    > ![Event grid system topic is deployed.](./media/voice-channel-system-topic-deployment.png "Event grid system topic is deployed.")
4. Select **Go to resource**.
5. In the resource details page that opens, select the subscription.
    > [!div class="mx-imgBorder"]
    > ![Select the resource subscription.](./media/voice-channel-resource-subscription.png "Select the resource subscription.")
6. In the resource subscription page, select **Settings** > **Resource providers**, and then check if the **Microsoft.EventGrid** provider is listed as **Registered**.
   If the event grid is not registered, you can select the record and then select **Re-register** to register it.
    > [!div class="mx-imgBorder"]
    > ![Event grid is listed as a registered provider.](./media/voice-channel-eventgrid-registered.png "Event grid is listed as a registered provider.")

### Create event subscription endpoint for recording

1. Open the resource on the Azure portal, go to **Events**, and select **Event Subscription**.
2. In the **Create Event Subscription** dialog, enter the following details in the **Basic** tab.
    > [!div class="mx-imgBorder"]
    > ![Add event subscription details for recording.](./media/voice-channel-create-event-subscription-recording.png "Add event subscription details for recording.")
    - **Name**: Enter a name for the recording event subscription.
    - **Event Schema**: Select **Event Grid Schema** from the dropdown list.
    - **System Topic Name**: This field is automatically populated with the system topic name you created. However, if you see multiple values, select the specific system topic name from the dropdown.
    - **Filter to Event Types**: Select **Recording File Status Updated (Preview)** from the dropdown list.
    - **Endpoint Type**: Select **Web Hook** from the dropdown list.
    - **Endpoint**: Select **Select an endpoint** and in the **Select Web Hook** dialog that opens, you need to enter the **Subscriber Endpoint**.
          To get the subscriber endpoint:
           i. In the site map of Omnichannel admin center, under **General settings**, select **Phone numbers**.
           ii. Select a phone number, and then select **Advanced**.
           iii. In the **Manage Azure Communication Services** page that opens, select **Copy** next to **Recording Web Hook Endpoint**.
            > [!div class="mx-imgBorder"]
            > ![Copy recording web hook endpoint.](./media/voice-channel-recording-webhook-endpoint.png "Copy recording web hook endpoint.")
          iv. Paste the web hook endpoint value in the **Subscriber Endpoint** field and select **Confirm Selection**.
3. Go to the **Additional Features** tab, select the **Use AAD authentication** checkbox, and enter the following details.
    > [!div class="mx-imgBorder"]
    > ![Add AAD authentication details.](./media/voice-channel-create-event-subscription-AAD-authentication.png "Add AAD authentication details.")
   - **AAD Tenant ID**: Copy-paste the **Directory (tenant) ID** field value from your Azure resource here.
   > [!div class="mx-imgBorder"]
   > ![Copy Directory (tenant) ID.](./media/voice-channel-tenant-ID.png "Copy Directory (tenant) ID.")
   - **AAD Application ID or URI**: Copy-paste the **Application (client) ID** field value from your Azure resource here.
   > [!div class="mx-imgBorder"]
   > ![Copy Application (client) ID.](./media/voice-channel-application-ID.png "Copy Application (client) ID.")

4. Select **Create** to create the event subscription endpoints for recording. *This might take some time, so if you get an sync error, try refreshing after some time.*

    > [!div class="mx-imgBorder"]
    > ![Successfully created event subscription endpoints for recording.](./media/voice-channel-event-subscription-recording-success.png "Create event grid callbacks for recording.")

### Create event subscription endpoint for SMS

1. Open the resource on the Azure portal, go to **Events**, and select **Event Subscription**.
2. In the **Create Event Subscription** dialog, enter the following details in the **Basic** tab.
    - **Name**: Enter a name for the recording event subscription.
    - **Event Schema**: Select **Event Grid Schema** from the dropdown list.
    - **System Topic Name**: This field is automatically populated with the system topic name you created. However, if you see multiple values, select the specific system topic name from the dropdown.
    - **Filter to Event Types**: Select both **SMS Received** and **SMS Delivery Report Received** from the dropdown list.
       > [!div class="mx-imgBorder"]
    > ![Add event subscription details for SMS.](./media/voice-channel-create-event-subscription-sms-event-types.png "Add event subscription details for SMS.")
    - **Endpoint Type**: Select **Web Hook** from the dropdown list.
    - **Endpoint**: Select **Select an endpoint** and in the **Select Web Hook** dialog that opens, you need to enter the **Subscriber Endpoint**.
         To get the subscriber endpoint:
         i. In the site map of Omnichannel admin center, under **General settings**, select **Phone numbers**.
        ii. Select a phone number, and then select **Advanced**.
        iii. In the **Manage Azure Communication Services** page that opens, select **Copy** next to **SMS Web Hook Endpoint**.
       > [!div class="mx-imgBorder"]
       > ![Copy sms web hook endpoint.](./media/voice-channel-sms-webhook-endpoint.png "Copy sms web hook endpoint.")
          iv. Paste the web hook endpoint value in the **Subscriber Endpoint** field and select **Confirm Selection**.
3. Go to the **Additional Features** tab, select the **Use AAD authentication** checkbox, and enter the following details.
    > [!div class="mx-imgBorder"]
    > ![Add AAD authentication details.](./media/voice-channel-create-event-subscription-AAD-authentication.png "Add AAD authentication details.")
   - **AAD Tenant ID**: Copy-paste the **Directory (tenant) ID** field value from your Azure resource here.
   > [!div class="mx-imgBorder"]
   > ![Copy Directory (tenant) ID.](./media/voice-channel-tenant-ID.png "Copy Directory (tenant) ID.") 
   - **AAD Application ID or URI**: Copy-paste the **Application (client) ID** field value from your Azure resource here.
   > [!div class="mx-imgBorder"]
   > ![Copy Application (client) ID.](./media/voice-channel-application-ID.png "Copy Application (client) ID.")
4. Select **Create** to create the event subscription endpoints for SMS. *This might take some time, so if you get an sync error, try refreshing after some time.*
    > [!div class="mx-imgBorder"]
    > ![Successfully created event subscription endpoint for SMS.](./media/voice-channel-event-subscription-sms-success.png "Create event grid callbacks for SMS.")

### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Outbound calling](voice-channel-outbound-calling.md)  
[Bring your own phone numbers](voice-channel-bring-your-own-number.md)  
[Integrate third-party IVRs with voice channel](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
