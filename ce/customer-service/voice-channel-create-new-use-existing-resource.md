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
<!--  
i.	Number management[Neeraja]  i) Connecting to ACS ii) acquire, release, update numbers, Kos wants more screenshots iii) Bring your own number; see the notes for point 3 a
ii.	Connect to existing ACS resource (existing today, but needs a lot more details)[Neeraja] Jaya received a demo from Debashish. Video effort post GA; Kos and Jaya to have a follow up about it. 
i.	Number management[Neeraja]  i) Connecting to ACS ii) acquire, release, update numbers, Kos wants more screenshots iii) Bring your own number; see the notes for point 3 a
ii.	Connect to existing ACS resource (existing today, but needs a lot more details)[Neeraja] Jaya received a demo from Debashish. Video effort post GA; Kos and Jaya to have a follow up about it. 

-->

# Connect to Azure Communication Services

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Before you can provision phone numbers for your business in Omnichannel Customer Service, you must first establish connection with the Azure Communication Services. You can [connect to a new Azure resource](#connect-to-a-new-azure-resource) or [use an existing one](#use-an-existing-azure-resource), and then deploy the resource through Dynamics 365.

## Connect to a new Azure resource

Before you connect to a new Azure resource, check whether you have the following:
- A valid Azure subscription that's in the same tenant as your Dynamics 365 account.
- At least contributor-level permissions to the Azure subscription. To check your role, open your subscription and view the **My role** column of your subscription on the Azure portal. You'll be able to deploy your Azure resource only if you have at least contributor-level permissions.

**To create a new Azure resource**

1. In Omnichannel admin center, under **General settings**, select **Phone numbers**, and then select **Get started**.

    The **Connect to Azure Communication Services** dialog opens.

2. Select **Create new resource** and enter the following details:
   - **Azure subscription**: Select a subscription from the dropdown list.
   - **Azure resource group**: Select an existing resource group or select **Create new**, and enter a name for a new resource group.
      > [!NOTE]
      > The resource group name should be unique within a given subscription.
   - **Resource name**: Enter a name for the resource.
3. Select **Deploy** to create and deploy the resource. You're now connected to Azure Communication Services.

## Connect to an existing Azure resource

You can also use an Azure Communication Services resource to connect with voice or SMS channels. You can use an existing resource from any of your Azure subscriptions, available under any tenant.

If you had previously unlinked a resource and want to use it now, you can do so using this option.

Before you proceed with adding an existing resource to Azure Communication Services, you must have the following information available.
- Open your existing resource from the Azure portal in a new window or tab. You'll need the resource values and connection string from the Azure resource for use in Omnichannel admin center.
- Open the **App registrations** page on the Azure portal in another window or tab. You'll need the application ID and tenant ID of your app for use in Omnichannel admin center.

If you're registering your app on the Azure portal for the first time, then do the following:
1. Open the Azure portal and go to **App registrations**.
2. On the **Register an application** page, enter the following details:
    - **Name**: Enter a name for your application.
    - **Supported account types**: Select **Accounts in any organizational directory (Any Azure AD directory - Multitenant)**
3. Select **Register**.
4. Copy the Application (client) ID and the Directory (tenant) ID

High level steps involved:
1. Create ACS resource. Note down ACS resource name, resource ID, and connection string
2. Create application Id. Not down app Id and tenant Id
3. Onboard ACS resource to Omnichannel. Input the 5 fields from step 1 and step 2.
4. Create system topic in Azure for the ACS resource.
5. Enable eventgrid resource provider in the subscription
6. Create event grid events in the ACS resource for recording and SMS. Copy recording callback URL from step.

**To connect to an existing Azure resource**

1. Open Omnichannel admin center and under **General settings**, select **Phone numbers**, and then select **Get started**.

   The **Connect to Azure Communication Services** dialog opens.

2. Select **Use existing resource** and enter the following details:
   - **ACS Resource Name**: Indicates the name of the Azure resource. Open your existing resource on the Azure portal, and go to **Settings** > **Properties**. Select the value of the **Name** field, select the **Copy to clipboard** button, and then paste the value in this field.
   - **ACS Resource ID**: Indicates the ID of the Azure resource. Open your existing resource on the Azure portal, and go to **Settings** > **Properties**. Select the value of the **Resource ID** field, select the **Copy to clipboard** button, and then paste the value in this field.
   - **Connection String**: Indicates the connection string of the Azure resource. Open your existing resource on the Azure portal, and go to **Tools** > **Keys** > **Primary key**. Select the value of the **Connection string** field, select the **Copy to clipboard** button, and then paste the value in this field.
   - **Event grip app ID**: Indicates the application ID of your Azure app registration. Open
   - **Event grip app tenant ID**: 
3. Select **Connect**. After the Azure resource is connected, you'll be able to provision or acquire new phone numbers for your organization.
4. Select **Add number**. The **Add phone number** page is displayed.
5. Follow the procedure to [add new phone numbers](#acquire-new-phone-numbers).
6. On the Azure portal, open Event Grid System Topics. Select Create and in the Create Event Grid System Topic page, select the subscription and resource group from the dropdown lists.
1. For Topic Types, select Azure Communication Services.
1. For Subscription, select 
1. For Resource group, select the resource group you created earlier
1. 
1. 
1. 
1. 


### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Outbound calling](voice-channel-outbound-calling.md)  
[Bring your own number: Azure direct routing](voice-channel-bring-your-own-number.md)  
[Integrate third-party IVRs with voice channel: Azure direct routing](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
