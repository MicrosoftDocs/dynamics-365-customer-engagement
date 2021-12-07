---
title: "Manage phone numbers | MicrosoftDocs"
description: "Use this topic to understand how you can acquire new phone numbers, and also view, update, and release existing phone numbers in Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 11/02/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Manage phone numbers

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

Omnichannel for Customer Service helps you enable and use voice and SMS services seamlessly within Dynamics 365. As an administrator, you can purchase phone numbers and calling plans, decide whether you want to avail calling and/or SMS services, or whether you'd like to set up inbound or outbound calling options for your business.

## Use trial phone number

The voice channel includes a trial phone number that comes with 60 minutes of free calling. With this trial number, you don't need to connect to Azure Communication Services. However, when the 60 minutes of free calling time elapses, you must purchase a new number based on your own Azure subscription, and cannot reuse or purchase the trial number.

## View phone numbers

To view all available phone numbers in your organization, open Omnichannel admin center and go to **General settings** >  **Phone numbers**. You'll see a list of all available phone numbers together with their carrier name, calling plan details, associated workstream, connection status, and other details.

> [!div class="mx-imgBorder"]
> ![View list of phone numbers.](./media/voice-channel-number-mgmt-view-phone-numbers.png "View list of phone numbers.")

If you don't have any phone numbers set up for your business, see [Acquire new phone numbers](#acquire-new-phone-numbers) to learn how you can purchase new numbers.

## Acquire new phone numbers

To be able to acquire new phone numbers for your business, you must first [connect to Azure Communication Services using a new or existing Azure resource](voice-channel-acs-resource.md), and then deploy the resource through Dynamics 365.

**To add a new phone number**

1. In the site map of Omnichannel admin center, under **General settings**, select **Phone numbers**, and then select **New number**.

   The **Add phone number** dialog opens.

2. On the **Features** page, do the following:

   a. Select your **Country/Region** from the dropdown list. The list of available plans for that specific country or region appears.

   b. Select the **Number type**, whether **Toll-free** or **Geographic**.

   c. Select the **Calling plans**&mdash;**Receive calls**, **Make calls**, or both.

   d. Select any one of the **SMS plans**&mdash;**None**, **Send SMS**, or **Send and receive SMS**. Note that SMS facility is currently available only on toll-free numbers.

   e. In **Location**, select the area or state code from the dropdown lists.

   f. Then, select **Find numbers** to search for available numbers in your area.
   
    > [!div class="mx-imgBorder"]
    > ![Add phone number.](./media/voice-channel-number-mgmt-add-features.png "Add phone number.")

   A **Summary** with the newly allotted phone number and its details is displayed.

3. On the **Summary** page, select **Purchase phone number**. Your new phone number will be displayed after purchase and you can select **Done** to get back to the **Phone numbers** page.

    > [!div class="mx-imgBorder"]
    > ![Summary page.](./media/voice-channel-number-mgmt-add-summary.png "Summary page.")
  
   The new phone number is displayed in the numbers list with the status **Ready for setup**.

   > [!Note]
   >
   >  - After you're allotted a new phone number, you must purchase it within the next 15 minutes. If the time elapses, you'll have to try purchasing again.
   >  - After you select **Purchase phone number**, you can select **Close** and return to the **Phone numbers** page. The purchase happens in the background and the new phone number appears in the phone numbers list with the **Ready for setup** status.

4. (Optional) Select **Setup Workstream** to [add the phone number to a voice workstream](#add-a-phone-number-to-a-voice-workstream).

5. Select **Done** to go back to the **Phone numbers** page where you can view details of the phone number that you just acquired.

## Add a phone number to a voice workstream

After you've acquired a phone number, you must add it to a voice workstream to be able to use it. You can associate a phone number with only one voice workstream.

**To add a phone number to a voice workstream**

1. In the site map of Omnichannel admin center, under **General settings**, select the phone number that's marked **Ready for setup** in the **Status** column.

2. Select **Setup workstream**. The **Workstreams** page with a list of all workstreams is displayed.

3. If you want to create a new workstream, select **New workstream** and then follow the steps to [set up a voice workstream](voice-channel-route-queues.md#set-up-a-voice-workstream).

3. Select an existing workstream from the list.

4. Follow the steps to [configure a voice channel](voice-channel-route-queues.md#configure-a-voice-channel).

   The phone number is added to the workstream, and you can view the **Connected** status for the phone number on the **Phone numbers** page.

## Configure phone numbers for outbound calling

After you've purchased phone numbers and associated them with voice workstreams, you can configure them for outbound calls so your agents can actually make calls to customers. More information: [Configure the phone number for outbound calling](voice-channel-outbound-calling.md#configure-phone-numbers-for-outbound-calling)

## Configure voice channel for inbound calling

You can also enable your agents to receive customer calls, create queues for the voice channel, and set up routing rules. More information: [Set up workstreams and queues for the voice channel](voice-channel-route-queues.md)

## Assign phone numbers to agents

You can also assign personal phone numbers to agents, so they're able to make and/or receive calls exclusively on that number. More information: [Assign personal phone numbers to agents](voice-channel-outbound-calling.md#assign-personal-phone-numbers-to-agents)

## Edit phone numbers

If you want to change the calling plan, or upgrade the calling or SMS plans on a particular number, you can do so by editing the phone number. For example, if you hadn't selected any SMS plans, you can upgrade to the **Send SMS** or **Send and receive SMS** plans; if you had selected only the **Send SMS** option, you can now upgrade to the **Send and receive SMS** plans.

**To edit a phone number**

1. In the site map of Omnichannel admin center, under **General settings**, select **Phone numbers**.
   The list of all available phone numbers for your business is displayed.

2. Select a phone number and then select **Edit**.
   The **Edit phone number** dialog with the current plan type, calling plan, and SMS plan is displayed.

3. Make any changes to your call or SMS plans, and select **Save and Close**.

> [!Important]
> - You cannot upgrade a phone number or change your call or SMS plans, after it's connected to a workstream.
> - You cannot remove features once granted to a phone number, but you can upgrade phone number features. For example, if you chose both **Make calls** and **Receive calls** options in your calling plans, you cannot change it. However, if you selected **None** for SMS plans, you can upgrade to either **Send SMS** or **Send and receive SMS** plan.

## Release phone numbers

If you no longer need a phone number, you can release it from your organization's phone number list. However, before you plan to remove the phone number from your business, you must remove the number from any associated workstreams or outbound profiles. Also, if the number is assigned as a personal number to any agent, you must disable the number, and then try releasing it again.

> [!Important]
> When you release a phone number, you actually delete it from Dynamics 365, so release a number only if you're sure that you don't need it at all.

**To release a phone number**

1. In the site map of Omnichannel admin center, under **General settings**, select **Phone numbers**.
  
   The list of all available phone numbers for your business is displayed.

2. Select a phone number and select **Release number**.

   The **Release number** dialog requesting you to confirm the number deletion is displayed.

3. Select **OK** if you're sure you don't need the number.

   The phone number is removed from your organization and is no longer displayed in the Phone numbers list.

### See also

[Overview of the voice channel](voice-channel.md)  
[Connect to Azure Communication Services](voice-channel-acs-resource.md)  
[Set up outbound calling](voice-channel-outbound-calling.md)  
[Set up inbound calling](voice-channel-route-queues.md)  
[Bring your own phone numbers](voice-channel-bring-your-own-number.md)  
[Integrate third-party IVR systems with voice channel](voice-channel-contextual-transfer-external-ivr.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
