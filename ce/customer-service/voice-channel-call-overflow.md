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



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-overflow-queue2.png)

## Define operation hours (if applicable)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-overflow-business-hours-create.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-overflow-business-hours2.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-overflow-business-hours3.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-overflow-business-hours4.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-overflow-business-hours5.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-overflow-business-hours6.png)


If operation hours are not edited, they will be 24 hours by default. 

## Define Overflow conditions


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-overflow-condition1.png)

- Work item limit

- Out of operation hours 

this is an OR condition


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-overflow-business-hours-remove.png)


## Enter Overflow action in workstream


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-overflow-workstream-create.png)



> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-overflow-workstream-rules.png)



Default - waits for next available agent

End call - ends call and delivers automated message.

Transfer to external number


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-overflow-workstream-rules-overflow-action.png)

## Configuration considerations

### Edit automated messages for End Call overflow action

Customer settings > automated messages 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-overflow-end-call-message.png)




## Step 1:




## Step 2:

## Configuration considerations
## Additional Notes

