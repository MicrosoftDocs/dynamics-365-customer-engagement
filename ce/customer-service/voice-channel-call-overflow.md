---
title: "Handle Call Overflow in the Voice channel | MicrosoftDocs"
description: "Introduction to using Omnichannel for Customer Service."
author: neeranelli
ms.author: daclar
manager: shujoshi
ms.date: 02/28/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Handle Call Overflow

// video 1: https://msit.microsoftstream.com/video/1e910840-98dc-b561-c1ad-f1ebd2b63bf5


Your organization can set conditions for when a call

1. Exceeds a defined number of calls waiting in the queue
2. Lands outside call center operation hours


## Prerequisites
- Agents
- Phone number

> [!Note]
>

>[!TIP] 
> 



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-overflow-queue.png)

## Select an existing voice queue or create a new one

Assign agents to the queue


voice-channel-overflow-queue2

## Define operation hours (if applicable)

voice-channel-overflow-business-hours-create

voice-channel-overflow-business-hours2

voice-channel-overflow-business-hours3

voice-channel-overflow-business-hours4

voice-channel-overflow-business-hours5

voice-channel-overflow-business-hours6


If operation hours are not edited, they will be 24 hours by default. 

## Define Overflow conditions

voice-channel-overflow-condition1

- Work item limit

- Out of operation hours 

this is an OR condition

voice-channel-overflow-business-hours-remove


## Enter Overflow action in workstream

voice-channel-overflow-workstream-create

Default - waits for next available agent

End call - ends call and delivers automated message.

Transfer to external number

## Configuration considerations

### Edit automated messages for End Call overflow action

Customer settings > automated messages 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-overflow-end-call-message.png)




## Step 1:

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


## Step 2:

## Configuration considerations
## Additional Notes

