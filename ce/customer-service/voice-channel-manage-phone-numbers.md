---
title: "Manage phone numbers | MicrosoftDocs"
description: "Use this topic to understand how you can manage phone numbers in Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/13/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ROBOTS: NOINDEX,NOFOLLOW
---

# Preview: Manage phone numbers

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>
> [!INCLUDE[cc-preview-features-send-us-feedback](../includes/cc-preview-features-send-us-feedback.md)]

Omnichannel for Customer Service helps you enable and use voice and SMS services in a seamless, integrated way within Dynamics 365. As an administrator, you can purchase phone numbers and call plans, decide whether you want to avail call and/or SMS services, or whether you'd like to set up inbound or outbound calling options for your business.

## Use phone number included with the voice channel

The voice channel includes a trial phone number that comes with 60 minutes of free calling. With this trial number, you don't need to connect to Azure Communication Services. However, after the 60 minutes of free calling time elapses, you must purchase a new number based on your own Azure subscription, and cannot reuse or purchase the trial number.

## Prerequisites

- A valid Azure subscription that's in the same tenant as your Dynamics 365 account.
- At least contributor-level permissions to the Azure subscription. To check your role, open your subscription and view the **My role** column of your subscription on the Azure portal.

## Create a new phone number

To add new phone numbers to your business, you must do the following:

- Create a resource or use an existing one to connect to Azure Communication Services. You can also use a resource that you previously disconnected or unlinked from Azure Communication Services, and reuse it now.
- Deploy the resource through Dynamics 365.
- Add a new phone number.

**To add a new phone number**

1. In Omnichannel admin center, under **General settings**, select **Phone numbers (preview)**, and then select **Get started**.
   
   The **Connect to Azure Communication Services** dialog opens.

2. Select **Create new resource** or **Use existing resource**.

   a. If you selected the option to create a new resource, enter the following details:
   - Azure subscription: 
   - Azure resource group:
      > [!NOTE]
      > The resource group name should be unique within a given subscription.
   - Resource name: 
   
   b. If you wish to use an existing resource, see [Use existing resource](#use-existing-resource) to connect to Azure Communication Services.

3. Select **Deploy** to deploy the resource through Dynamics 365 and then select **Add number**.
 
   The **Add phone number** dialog opens.

4. On the **Features** page, do the following:

   a. Select your **Country/Region** from the dropdown list. The list of available plans for that specific country or region appears.

   b. *(If you selected United States as the country)* Select the **Number type**, whether **Toll-free** or **Geographic**.

   c. Select the **Calling plans**&mdash;**Receive calls**, **Make calls**, or both.

   d. Select any one of the **SMS plans**&mdash;**None**, **Send SMS**, or **Send and receive SMS**. Note that SMS facility is currently available only on toll-free numbers.

   e. In **Location**, select the area or state code from the dropdown lists.

   f. Then, select **Find numbers** to search for available numbers in your area.
   
   A **Summary** with the newly allotted phone number and its details is displayed.

5. On the **Summary** page, select **Purchase phone number**. Your new phone number will be displayed after purchase and you can select **Done** to get back to the **Phone numbers (preview)** page.
  
   The new phone number is displayed in the numbers list with the status **Ready for setup**.

   > [!Note]
   >  - After you are allotted a new number, you'll have just 15 minutes to purchase the number. If the time lapses, you'll have to try purchasing again.
   >  - After you select **Purchase phone number**, you can close the page by selecting **Close** and return to the **Phone numbers** page.
   >  - The purchase happens in the background and the new phone number appears in the numbers list with **Pending** status. 

6. Select **Setup Workstream** to [add the phone number to a workstream](#add-a-phone-number-to-a-workstream) or select **Done** to go back to the **Phone numbers** page where you can view details of the phone number you just purchased.

## Add a phone number to a workstream

After you've acquired a phone number, you must add it to a workstream to be able to use it. You can associate a phone number with only one workstream.

**To add a workstream to a phone number**

1. In Omnichannel admin center, under **General settings**, select the phone number that's marked **Ready for setup** in the **Status** column.

2. Select **Setup workstream**.

   The **Workstreams*** page with a list of all workstreams is displayed.

3. Select a workstream from the list or select **New** to create a new workstream.

4. [Set up a voice workstream](voice-channel-route-queues.md#set-up-a-voice-workstream).

5. [Configure a voice channel](voice-channel-route-queues.md#configure-a-voice-channel).

   The workstream is added to the phone number and you can view the **Connected** status for phone number on the **Phone numbers** page.

<a name="use-existing-resource"></a>

### Use existing resource

If you already have an Azure Communication Services resource that you'd like to use to connect with voice or SMS channels, you can use the **Use existing resource** option to connect to Azure Communication Services. Also, if you had previously unlinked a resource and wish to use it now, you can do so using this option. You can use an existing resource from any of your Azure subscriptions, available under *any* tenant.

Before you proceed with adding an existing resource to Azure Communication Services, do the following:

1. Open your existing resource from the Azure portal in a new window or tab.
2. Select **Settings** > **Properties**, and get ready to copy the resource values (using the Copy to clipboard button) from this resource to Omnichannel admin center.

**To use an existing resource**

1. In Omnichannel admin center, under **General settings**, select **Phone numbers**, and then select **Get started**.

   The **Connect to Azure Communication Services** dialog opens.

2. Select **Use existing resource** and enter the following details:
   - ACS Resource Name: Copy the name from your existing resource here.
   - ACS Resource ID
   - Connection String
   - Event grip app ID
   - Event grip app tenant ID


## Edit phone number

If you want to change the calling plan or upgrade the call or SMS plans on a particular number, you can do so by editing the phone number.

> [!Important]
> You cannot upgrade a phone number or change your calling or SMS plans after it is connected to a workstream. 

**To edit a phone number**

1. In Omnichannel admin center, under **General settings**, select **Phone numbers**.
   The list of all available phone numbers for your business is displayed.

2. Select a phone number and select **Edit number**.
   The **Edit number** dialog with the current plan type, calling plan, and SMS plan is displayed.

3. Make the changes to your calling or SMS plans, and select **Upgrade**.

*You cannot remove feature once granted to a phone number, but you can upgrade phone number features.*

## Release phone number

If you no longer need a phone number, you can release it from your number list. When you release a number, you actually delete it from Dynamics 365, so release a number only if you're sure you don't need it at all.

**To release a phone number**

1. In Omnichannel admin center, under **General settings**, select **Phone numbers (preview)**.
  
   The list of all available phone numbers for your business is displayed.

2. Select a phone number and select **Release number**.

   The **Release number** dialog requesting you to confirm the number deletion is displayed.

3. Select **OK** if you are sure you don't need the number.

   The **Phone numbers (preview)** page displays the phone number status as **Pending release**.

*You cannot remove feature once granted to a phone number, but you can upgrade phone number features.*

## Additional notes

You can use only one ACS resource for number management.

### See also

[Overview of the voice channel](voice-channel.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
