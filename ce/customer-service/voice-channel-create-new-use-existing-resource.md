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

## Connect to a new Azure resource

Before you connect to a new Azure resource, check whether you have the following:
- A valid Azure subscription that's in the same tenant as your Dynamics 365 account.
- At least contributor-level permissions to the Azure subscription. To check your role, open your subscription and view the **My role** column of your subscription on the Azure portal. You'll be able to deploy your Azure resource only if you have at least contributor-level permissions.

**To create a new Azure resource**

1. In the site map of Omnichannel admin center, under **General settings**, select **Phone numbers**, and then select **Get started**.

    The **Connect to Azure Communication Services** dialog opens.

2. Select **Create new resource** and enter the following details:
   - **Azure subscription**: Select a subscription from the dropdown list.
   - **Azure resource group**: Select an existing resource group or select **Create new**, and enter a name for a new resource group.
      > [!NOTE]
      > The resource group name should be unique within a given subscription.
   - **Resource name**: Enter a name for the resource.
3. Select **Deploy** to create and deploy the resource. You're now connected to Azure Communication Services.
    > [!div class="mx-imgBorder"]
    > ![Create new resource.](./media/voice-channel-number-mgmt-azure-create-new-resource.png "Create new resource.")

## Connect to an existing Azure resource

You can also use an existing Azure Communication Services resource to connect with voice or SMS channels. You can use a resource from any of your Azure subscriptions, available under any tenant.

*If you had previously unlinked a resource and want to use it now, you can do so using this option.*

Before you proceed with adding an existing resource to Azure Communication Services, you must have the following information available for use in Omnichannel admin center.
- [Get the resource name and ID from the Azure portal](#get-resource-name-and-resource-id).
- [Get the connection string from the Azure portal](#get-connection-string).
- [Get the application ID and tenant ID from the App registrations page on the Azure portal](#get-application-and-tenant-IDs).


High level steps involved:
1. Create ACS resource. Note down ACS resource name, resource ID, and connection string
2. Create application Id. Note down app Id and tenant Id
3. Onboard ACS resource to Omnichannel. Input the 5 fields from step 1 and step 2.
4. Create system topic in Azure for the ACS resource.
5. Check if eventgrid is registered as a resource provider in the subscription
6. Create event grid events in the ACS resource for recording and SMS. Copy recording callback URL from step.

**To connect to an existing Azure resource**

1. In the site map of Omnichannel admin center and under **General settings**, select **Phone numbers**, and then select **Get started**.

   The **Connect to Azure Communication Services** dialog opens.

2. Select **Use existing resource**.
    > [!div class="mx-imgBorder"]
    > ![Select the use existing resource option.](./media/voice-channel-select-use-existing-resource.png "Select the use existing resource option.")

3. Enter the following details, based on the values available on the Azure portal.
   - **ACS Resource Name**: [Copy-paste the resource name from the Azure portal](#get-resource-name-and-resource-id).
   - **ACS Resource ID**: [Copy-paste the resource ID from the Azure portal](##get-resource-name-and-resource-id).
   - **Connection string**: [Copy-paste the connection string from the Azure portal](#get-connection-string).
   - **Event grip app ID**: [Copy-paste the application ID from the Azure portal](##get-application-and-tenant-IDs).
   - **Event grip app tenant ID**: [Copy-paste the tenant ID from the Azure portal](##get-application-and-tenant-IDs).

3. Select **Connect**. After the Azure resource is connected, you'll be able to provision or acquire new phone numbers for your organization.

4. Select **Add number**. The **Add phone number** page is displayed.

5. Follow the procedure to [add new phone numbers](voice-channel-manage-phone-numbers.md#acquire-new-phone-numbers).

6. On the Azure portal, open **Event Grid System Topics**. Select **Create** and in the **Create Event Grid System Topic** page, select the subscription and resource group from the dropdown lists.

7. For **Topic Types**, select **Azure Communication Services**.

8. For **Subscription**, select 

9. For Resource group, select the resource group you created earlier
 

## Get resource name and resource ID

You'll retrieve values for the Azure resource name and resource ID from the Azure portal, and paste them in the corresponding fields of the **Use existing resource** dialog.

1. Open your existing resource on the Azure portal in a separate window or tab, and go to **Settings** > **Properties**. 
2. Select the value of the **Name** field, select the **Copy to clipboard** button, and then paste the value in the **ACS Resource Name** field of the **Use existing resource** dialog.
   > [!div class="mx-imgBorder"]
   > ![Copy resource name.](./media/voice-channel-resource-name.png "Copy resource name.")
3. Select the value of the **Resource ID** field, then select the **Copy to clipboard** button, and paste the value in the **ACS Resource ID** field of the **Use existing resource** dialog.

   > [!div class="mx-imgBorder"]
   > ![Copy resource ID.](./media/voice-channel-resource-ID.png "Copy resource ID.")

## Get connection string

You'll retrieve values for the Azure resource name and resource ID from the Azure portal, and paste them in the corresponding fields of the **Use existing resource** dialog.
1. Open your existing resource on the Azure portal in a separate window or tab, and go to **Tools** > **Keys** > **Primary key**. 
2. Select the value of the **Connection string** field, then select the **Copy to clipboard** button, and paste the value in the **Connection string** field of the **Use existing resource** dialog.

   > [!div class="mx-imgBorder"]
   > ![Copy connection string.](./media/voice-channel-connection-string.png "Copy connection string.")

## Get application and tenant IDs

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


### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Outbound calling](voice-channel-outbound-calling.md)  
[Bring your own phone numbers](voice-channel-bring-your-own-number.md)  
[Integrate third-party IVRs with voice channel](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
