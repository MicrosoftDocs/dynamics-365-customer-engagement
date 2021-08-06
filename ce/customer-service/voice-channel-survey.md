---
title: "Configure a Post-Call Survey in the Voice channel | MicrosoftDocs"
description: "Introduction to using Omnichannel for Customer Service."
author: neeranelli
ms.author: daclar
manager: shujoshi
ms.date: 02/28/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---


# Configure a Post-Call Survey

// Video: https://msit.microsoftstream.com/video/9c7f0840-98dc-b561-43e3-f1ebd609d1b6
// Powerpoint: https://microsoft-my.sharepoint.com/:p:/p/kausri/Ebu5F_j6ZUZJj85tobOW7yEBsiGxOMe6Ya6EqMUGl3o9hA


Post call surveys help measure customer satisfaction in the contact center.  Surveys are also an incentive for agents to provide high quality service. Having the survey right after the call provides the customer the opportunity to offer feedback while it is fresh in their minds.

3 ways to inititiate post call surveys

1. Automatic - implicit
    The IVR bot informs the customer about a post-call survey at the end of the call. 
    After the agent disconnects, the call is automatically transferred to a post-call survey bot.
2. Automatic - explicit
3. Agent initiated


The IVR bot asks the customer if they want to participate in a post call survey. The consent should be saved in a va_surveyconsent  Boolean variable.

If the customer consents, the call is automatically transferred to the post-call survey bot at the end of the agent call.
If the customer says no, the call ends when the agent hangs up.



## Prerequisites
> [!Note]
>



## Create a survey bot
Use either PVA (No code or low code experience) or Azure bot Service (pro developer experience)

### Power Virtual Agent


>[!TIP] 
> The bot author can use Power Automate to implement custom business logic to decide who gets surveyed (e.g. random %, VIP customers etc.)

### Azure bot Service

## Connect your bot to Omnichannel

1. PVA: https://docs.microsoft.com/en-us/power-virtual-agents/configuration-hand-off-omnichannel, https://docs.microsoft.com/en-us/dynamics365/customer-service/configure-bot
2. Azure bot: https://docs.microsoft.com/en-us/dynamics365/customer-service/configure-bot 

## Enable Post-call survey in workstream phone number

## Step 1:

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)


## Step 2:

## Configuration considerations
## Additional Notes