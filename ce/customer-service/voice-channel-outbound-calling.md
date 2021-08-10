---
title: "Outbound calling in the Voice channel | MicrosoftDocs"
description: "Introduction to using Omnichannel for Customer Service."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 08/10/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

<!--
IT admin perspective by Chris
video: https://msit.microsoftstream.com/video/78a80840-98dc-b561-710e-f1ebd538f986
-->

# Outbound calling

This section describes how you as an IT administrator can set up outbound calling.

## Prerequisites
Before you can set up outbound voice calls for your business, you'll need the following:

- One or more phone numbers configured for outbound calling. 
- [Create a voice type queue](voice-channel-route-queues.md#create-queues-for-voice-channels) or use an existing voice queue to associate with the outbound profile.
- Assign one or more users with an outbound capacity profile, so that they can make calls.
- [Create an outbound profile](#create-an-outbound-profile)
## Configure a phone number for outbound calling

To check if a phone number is configured for outbound calling, go to **General settings** > **Phone numbers (preview)**, and check if you have phone numbers with **Make calls** mentioned in the **Calling** column.

**To configure a number for outbound calling**

1. In Omnichannel admin center, under **General settings**, select **Phone numbers (preview)**.
  
   The list of all available phone numbers for your business is displayed.

2. Select a phone number and select **Edit number**.

3. In the **Edit number** dialog, in the **Calling plans** area, select the **Make calls** option, and then select **Upgrade**.

4. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-outbound-phone-number.png)



## Create a queue

- must be "voice" type queue


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-outbound-queue.png)

>[!TIP] 
> Though you can use the same queue for both inbound and outbound calling, we recommend that you create separate queues for inbound and outbound calling. This helps supervisors with monitoring and reporting outbound specific traffic and sentiment. Having a separate outbound queue

## Add a user to the queue

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-outbound-queue-add-user.png)

## Create a capacity profile 
- number of outbound calls a person can make at one time

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-outbound-capacity-profile-nav.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-outbound-capacity-profile.png)

## Assign a user the capacity profile


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-outbound-capacity-profile-add-user-nav.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-outbound-capacity-profile-add-user.png)

## Create an outbound profile

You can define the way outbound calls are made and also who can make them. To create an outbound profile, you'll need a phone number that's enabled for outbound calling. This means that in your calling plan for that number, the **Make calls** checkbox must be selected. In private preview, only *one* outbound profile can be created. While you can edit the profile, you cannot delete it.

**To create an outbound profile**

1. In the site map of Omnichannel admin center, select **Agent experience** under the **Advanced settings** menu.

2. Select **Manage**, next to **Outbound profiles (preview)**.

3. If there are no available profiles, select **Create a profile**, else select **Add profile**. 

4. In the **Create outbound profile** dialog, enter the following details:
   a. In the **Basic info** section, add the following details:
     - Profile name:
     - Phone number:
     - Number label:
     - Queue:
     - Capacity:
   
   b. In the **Behaviors** section, add the following details:
     - Language:
     - Hold music:
     - Wait music:
     - Call transfer to external phone number:
     - Consult with teams
     - Transcription and recording
     - Start setting
        
   c. In the **Summary** section, add the following details:

     - Queue:
     - Capacity:

4. Select **Save and close**.

**To edit an outbound profile**

1. In the site map of Omnichannel admin center, select **Agent experience** under the **Advanced settings** menu.

2. Select **Manage**, next to **Outbound profiles (preview)**.
   
   The list of outbound profiles is displayed.

3. Select a profile from the list and select **Edit**. In the **Create outbound profile** dialog, enter the following details:
   a. In the **Basic info** section, add the following details:
     - Profile name:
     - Phone number:
     - Number label:
     - Queue:
     - Capacity:
   
   b. In the **Behaviors** section, add the following details:
     - Language:
     - Hold music:
     - Wait music:
     - Call transfer to external phone number:
     - Consult with teams
     - Transcription and recording
     - Start setting
        
   c. In the **Advanced settings** section, add the following details for the session and notification templates that are used for outbound voice calls:
     - Session - default:
     - Notification - consult:
     - Notification - transfer:

4. Select **Save and close**.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-outbound-profile-nav.png)


- The first run experience create an outbound profile by default.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-outbound-profile.png)

Profile Name
Phone Number - use outbound calling phone number. shows in caller ID.
Queue
Capacity
Hold Music
Wait music
Transcription and recording
Start setting
Allow agents to pause and resume

Advanced Settings



Session-default

Notification-consult

Notification - transfer

See the topic on [Message session templates](https://docs.microsoft.com/dynamics365/app-profile-manager/session-templates) for more details.

## Call a customer


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-outbound-call.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-outbound-call2.png)



## Configuration considerations

### Call backs

Oftentimes agents need to call customers back at a later time. It is recommended to create a phone call activity with direction set to Outbound as a reminder for the agent. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-outbound-callback1.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-outbound-callback2.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-outbound-callback3.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-outbound-callback4.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-outbound-callback5.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-outbound-callback6.png)


## Additional Notes

### Understanding outbound queues

By creating an outbound queue, this allows managers to see outbound calls in the Omnichannel Ongoing Conversations Dashboard. Not used for capacity planning, used for monitoring and reporting. 