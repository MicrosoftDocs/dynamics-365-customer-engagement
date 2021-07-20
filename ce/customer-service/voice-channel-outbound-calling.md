---
title: "Outbound calling in the Voice channel | MicrosoftDocs"
description: "Introduction to using Omnichannel for Customer Service."
author: neeranelli
ms.author: daclar
manager: shujoshi
ms.date: 02/28/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---


# Outbound calling

// Video: https://msit.microsoftstream.com/video/78a80840-98dc-b561-710e-f1ebd538f986

- Oubound profiles

## Prerequisites
> [!Note]
>



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

## Configure a phone number for outbound calling

- Enable Make calls

voice-channel-outbound-phone-number



## Create a queue

- must be "voice" type queue

voice-channel-outbound-queue

>[!TIP] 
> It it recommended to create a queue specifically for outbound calling. This helps with monitoring and reporting like outbound specific sentiment. Though it is supported for a queue to be both inbound and outbound. 

## Add a user to the queue

voice-channel-outbound-queue-add-user

## Create a capacity profile 
- number of outbound calls a person can make at one time

voice-channel-outbound-capacity-profile-nav

voice-channel-outbound-capacity-profile

## Assign a user the capacity profile 

voice-channel-outbound-capacity-profile-add-user-nav

voice-channel-outbound-capacity-profile-add-user

## Create an Outbound profile

voice-channel-outbound-profile-nav


- The first run experience create an outbound profile by default. Only 1 outbound profile can be created and cannot be deleted. 

voice-channel-outbound-profile


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

voice-channel-outbound-call

voice-channel-outbound-call2



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