---
title: "Number management | MicrosoftDocs"
description: "Introduction to using Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/06/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---
<!--
Neema Tikoo - Talks about how you can purchase numbers from within Dynamics 365. - 
Uses the "Create a new resource option"
//Video 1: https://msit.microsoftstream.com/video/08ba0840-98dc-b561-3805-f1ebd1855239

Nael Haddad/David Clarke - talks about how we simplify acquiring numbers, a one-stop shop for business admins to get new numbers, release numbers, etc using ACS.
//Video 2: https://msit.microsoftstream.com/video/dd07a1ff-0400-b564-49f4-f1eb6cbe2392

Naresh/Abhiney/Sudarshan - discusses how to use an existing resource (say you have unlinked a phone number and want to reuse it now).
Video 3: https://msit.microsoftstream.com/video/8bfc99ff-0300-b561-3feb-f1ebe379b30a
-->

# Number management

This section discusses how you as an administrator can purchase phone numbers, how to choose the right plan for your organization, whether you want to avail call and SMS services, or whether you'd like to set up just inbound or outbound calling options, or both. You use the Azure Communication Services to purchase new phone numbers or use existing numbers for your business, in a seamless, integrated way within Dynamics 365. 
The following topics

## Use number included with the Voice Channel 

Free trial comes with 1 number and 60 minutes of free calling. There is no need to connect to Azure Communication Services.

After the 60 minutes, purchase a new number. You cannot purchase the trial number. 

## Create a new phone number

To be able to use voice and SMS services in Omnichannel for Customer Service, you must have a resource that connects to Azure Communication Services. To be able to add phone numbers to your business, you must first connect to Azure Communication Services
- you must create a new resource and connect to 
- deploy the resourc


### Prerequisite

**To purchase new phone numbers for your business**

1. Open Omnichannel admin center. Under **General Settings**, select **Phone numbers**, and then select **Get started**. 
   The **Connect to Azure Communication Services** dialog opens.

2. Select **Create new resource** and enter the following details:
   - Azure subscription: 
   - Azure resource group: 
   - Resource name: 

3. Select **Deploy**


### Connect to Azure Communication Services

You can either [create a new resource](#create-a-new-resource) or [use an existing one](#use-existing-resource) to connect to Azure Communication Services. You can also use a resource that you previously disconnected or unlinked from Azure Communication Services, and reuse it now.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-number-mgmt-create-new-number.png)

Say, you already have an Azure Communication Services resource that you'd like to use to connect with voice or SMS, you can use the **Use existing resource** option to connect to Azure Communication Services. Also, if you had previously unlinked a resource and wish to use it now, you can do so using this option. You can use an existing resource from any of your Azure subscriptions, available under *any* tenant. 

To create a new phone number, you need the following:
- A valid Azure subscription that's in the same tenant as your Dynamics 365 account. 
- At least contributor-level permissions to the Azure subscription. To check your role, open your subscription and view the **My role** column of your subscription on the Azure portal.

<!--
Otherwise, select the [**Use existing resource**](#use-existing-resource) option and copy and paste the relevant information from your Azure subscription. 
-->

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-number-mgmt-connect-azure-service.png)


### Create a new resource


**To create a new resource**

1. Open Omnichannel admin center. Under **General Settings**, select **Phone numbers**, and then select **Get started**.
   The **Connect to Azure Communication Services** dialog opens.

2. Select **Create new resource** or **Use existing resource**,

2. Select **Create new resource** and enter the following details:
   - Azure subscription: .
   - Azure resource group:
   - Resource name


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-number-mgmt-azure-create-new-resource.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-number-mgmt-azure-success.png)

> [!NOTE]
> The resource group name should be unique within a given subscription.

<a name="use-existing-resource"></a>

### Use existing resource

Say, you already have an Azure Communication Services resource that you'd like to use to connect with voice or SMS, you can use the **Use existing resource** option to connect to Azure Communication Services. Also, if you had previously unlinked a resource and wish to use it now, you can do so using this option. You can use an existing resource from any of your Azure subscriptions, available under *any* tenant. 

Before you proceed with adding an existing resource to Azure Communication Services, open your existing resource from the Azure portal in a new window or tab.  Select **Settings** > **Properties**, and get ready to copy the resource values (using the Copy to clipboard button) from this resource to Omnichannel admin center.


**To use an existing resource**

1. Open Omnichannel admin center. Under **General Settings**, select **Phone numbers**, and then select **Get started**. 
   The **Connect to Azure Communication Services** dialog opens. 

2. Select **Use existing resource** and enter the following details:
   - ACS Resource Name: Copy the name from your existing resource here.
   - ACS Resource ID
   - Connection String
   - Event grip app ID
   - Event grip app tenant ID

3.

4.

5.



### Add a number 

Features


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-number-mgmt-add-features.png)

You cannot remove feature once granted to a phone number, but you can upgrade phone number features.

Summary


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-number-mgmt-add-summary.png)

Purchase Number


## Add a number to a workstream

## Edit a number

Select a number, click on Edit, upgrade a plan

Reasons to upgrade:
- enable Outbound
- enable SMS

You cannot remove feature once granted to a phone number, but you can upgrade phone number features.

## Release a number

Releasing a number will delete a number

## Configuration considerations

### Import existing numbers from Azure Communication Services

### Unlink resources

## Additional notes

You can only use 1 ACS resource for number management
