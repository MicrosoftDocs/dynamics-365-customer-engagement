---
title: "Number management | MicrosoftDocs"
description: "Introduction to using Omnichannel for Customer Service."
author: neeranelli
ms.author: daclar
manager: shujoshi
ms.date: 02/28/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---


# Number management


//Video 1: https://msit.microsoftstream.com/video/08ba0840-98dc-b561-3805-f1ebd1855239


//Video 2: https://msit.microsoftstream.com/video/dd07a1ff-0400-b564-49f4-f1eb6cbe2392



## Use number included with the Voice Channel 

Free trial comes with 1 number and 60 minutes of free calling. There is no need to connect to Azure Communication Services.

After the 60 minutes, purchase a new number. You cannot purchase the trial number. 

## Create a new phone number

### Connect to Azure Communication Services

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-number-mgmt-create-new-number.png)

### Prerequisite

Before you can create a new number you **need an Azure subscription**. If your Azure subscription is in the same tenant as your Dynamics 365 account **and** you have [insert the the blank] Azure permissions then select **Create New Resource**.

Otherwise, select the **Use Existing Resource** option and copy and paste the relevant information from your Azure subscription. 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-number-mgmt-connect-azure-service.png)


### Create a new resource


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-number-mgmt-azure-create-new-resource.png)


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/voice-channel-number-mgmt-azure-success.png)


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

### Unlink Resources

## Additional notes

You can only use 1 ACS resource for number management
