---
title: "Outbound calling in the voice channel | MicrosoftDocs"
description: "Use this topic to understand how you can set up outbound calling for phone numbers in your organization."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 11/01/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Outbound calling

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

This section describes how you as an IT administrator can set up outbound calling for phone numbers in your organization. After you set up outbound calling, your agents can make calls to customers via the Omnichannel Agent Dashboard in Omnichannel for Customer Service.

If you do not have any phone numbers provisioned for your business, then see [Acquire a new phone number](voice-channel-manage-phone-numbers.md#acquire-new-phone-numbers) to learn how you can acquire new phone numbers.

## Prerequisites

Before you set up outbound voice calls for your business, you'll need the following:

- [Configure one or more phone numbers for outbound calling](#configure-phone-numbers-for-outbound-calling).
- [Create a voice type queue](voice-channel-route-queues.md#create-queues-for-voice-channels) or use an existing voice queue to associate with the outbound profile.
- [Configure capacity profile and add users](capacity-profiles.md).
- [Create outbound profiles](#create-outbound-profiles)

## Configure phone numbers for outbound calling

To check for phone numbers configured for outbound calling, go to **General settings** > **Phone numbers**, and check if you have numbers with **Make calls** mentioned in the **Calling** column.

**To configure a number for outbound calling**

1. In the site map of Omnichannel admin center, under **General settings**, select **Phone numbers**.
  
   The list of all available phone numbers for your business is displayed.

2. Select a phone number and select **Edit number**.

3. In the **Edit number** dialog, in the **Calling plans** area, select the **Make calls** option, and then select **Upgrade**.
   Your phone number is now upgraded for outbound calling.

The phone number will now be displayed to your customers when your agents call them.

>[!NOTE]
> Though you can use the same queue for both inbound and outbound calling, we recommend that you create separate queues for inbound and outbound calling. This will help your supervisors monitor and gauge traffic and customer sentiment, specific to outbound calls.

## Manage capacity profiles and assign users

You must create or use existing capacity profiles to define and set the workload of your agents. For your agents to be able to make calls to customers, they must be assigned or added to an outbound capacity profile. So, after you create or update the capacity profile, you must add users to the profile.

For detailed information on how to manage capacity profiles and add users, see [Create and manage capacity profiles](capacity-profiles.md).

For outbound calls, set the capacity profile fields as follows:
- **Work item limit**: Indicates the number of outbound calls an agent can make at a time. If the value is set to 1, it means that the agent can make only one call at a time, and cannot make a second call until the first call is ended. If the value is set to 3, it means that the agent can make 3 outbound calls at a time. 
- **Reset frequency**: Indicates whether the agent can immediately make another call when the current ends or has to wait until end of day. For voice calls, set this field to **Immediate** so that the agent will be able to make another call as soon as the current one has ended.
- **Assignment blocking**: Indicates whether you want to block any incoming calls when the agent is already on a call. Set this value to **Yes**, if you want to ensure the agent does not receive any incoming calls when an outbound call is in progress.

> [!Note]
> - When you name your capacity profiles, we recommend that you clearly indicate whether they're outbound, inbound, or both, in the capacity **Profile name** field, so it's easy for you to assign users or agents to the appropriate profile.
- Though you can use the same capacity profile for both inbound and outbound calling, we recommend that you create separate profiles because the considerations and settings for outbound calling and inbound calling can differ.
> - If your agents use only non-voice channels such as chat or SMS to connect with customers, then you don't need to add them to outbound capacity profiles.
> - If your agents are only assigned to receive customer calls, then you don't need to assign them to outbound capacity profiles.

## Create outbound profiles

You can define the way outbound calls are made and also who can make them. To create an outbound profile, you'll need a phone number that's enabled for outbound calling. This means that in your calling plan for that number, the **Make calls** checkbox must be selected.

**To create outbound profiles**

1. In the site map of Omnichannel admin center, select **Agent experience** under the **Advanced settings** menu.

2. Select **Manage**, next to **Outbound profiles**.

3. Select **Add profile**. If there are no available profiles, then select **Create a profile** to create a new one.

4. In the **Create outbound profile** dialog, enter the following details:
   a. In the **Basic info** section, add the following details:
     - **Profile name**: Enter a profile name.
     - **Phone number**: Select a phone number from the dropdown list. 
     - > [!Note]
     - > The phone numbers list shows only those numbers that are enabled for outbound calling. If you don't see any numbers in the list, you'll need to [configure a number for outbound calling](#configure-phone-numbers-for-outbound-calling).
     - **Queue**: Select a queue from the dropdown list. The list shows only voice type queues, so if you don't see any queues in the list, you'll need to [create a voice type queue](voice-channel-route-queues.md#create-queues-for-voice-channels).
     - **Capacity**: Select one or more capacity profiles from the dropdown list.
     - **Hold music**: Select a music file that you want played when the customer is put on hold during a call.
     - **Wait music**: Select a music file that you want played when the customer is waiting to get into a call.
     - **Transcription and recording**: Select **None**, **Transcription only**, or **Transcription and recording**, based on your business scenarios and requirements. As an administrator, you may want to set the value to **None** for business transactions like customer billing where you don't want to record financial data.
     - **Start setting**: Indicates whether you want to start transcription and/or recording when the call begins. The default value is **Automatic**, which means transcription and recording will automatically begin at the start of the conversation.
     - **Allow agents to pause and resume**: Indicates whether you want to allow your agents to pause and resume call transcription and recording. The default value is **Yes** which means that your agents can choose when to pause or resume call transcription and recording in the conversation panel.

5. Select **Save and close**.

**To edit outbound profiles**

1. In the site map of Omnichannel admin center, select **Agent experience** under the **Advanced settings** menu.

2. Select **Manage**, next to **Outbound profiles**. The list of outbound profiles is displayed.

3. Select a profile from the list and select **Edit**. In the **Edit outbound profile** dialog, update details in the **Basic info**, **Behaviors**, and **Advanced settings** sections.
   
   For information on session and notification templates, see [Manage session templates](../app-profile-manager/session-templates.md) and [Manage notification settings and templates](../app-profile-manager/notification-templates.md).

4. Select **Save and close**.

## Assign personal phone numbers to agents

You can assign and activate personal phone numbers to agents to make outbound calls to customers. You can also choose to disable or deactivate the personal phone number you earlier assigned to an agent.

**To assign a personal phone number to an agent**

1. In Omnichannel admin center, under **General settings**, select **Phone numbers**.

2. Select **Setup** under **Ready for setup**, and in the dialog that appears, select **Assign to user**.
   The Omnichannel Users page opens showing a list of all agents.

3. Select an agent and then select **Enable**.
4. In the **Confirm User Activation** dialog that appears, select **Activate**.
   The phone number is now assigned exclusively to the agent to call customers.

**To disable the personal phone number of an agent**

1. In Omnichannel admin center, under **General settings**, select **Phone numbers**.

2. Select **Setup** under **Ready for setup**, and in the dialog that appears, select **Assign to user**.
   The Omnichannel Users page opens showing a list of all agents.

3. Select an agent and then select **Disable**.
4. In the **Confirm Deactivation** dialog that appears, select **Deactivate**.
   The phone number will no longer be available exclusively to the agent to make outbound calls.

### See also

[Overview of the voice channel](voice-channel.md)  
[Manage phone numbers](voice-channel-manage-phone-numbers.md)  
[Bring your own phone numbers](voice-channel-bring-your-own-number.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
