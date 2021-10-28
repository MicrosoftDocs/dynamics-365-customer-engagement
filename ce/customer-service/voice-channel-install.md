---
title: "Provision the voice channel | MicrosoftDocs"
description: "Learn how to provision the voice channel in Omnichannel for Customer Service."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 11/01/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Provision the voice channel

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Prerequisites

Make sure that the following prerequisites are met:

- [Prerequisites for provisioning Omnichannel for Customer Service](omnichannel-provision-license.md#prerequisites).
- The **Global Tenant Admin** and **Dynamics 365 System Admin** permissions for your organization.

## Set up the voice channel

To set up the voice channel, you will perform the steps for provisioning Omnichannel for Customer Service. More information: [Provision Omnichannel for Customer Service](omnichannel-provision-license.md)

1. On the **Omnichannel set up** page, from the **Select an environment** dropdown list, select the environment.

2. Make sure that the **Add voice** toggle is set to **Yes**, and select the checkbox to accept the terms.

3. Confirm your selections, and then select **Finish**. The installation begins.

## Get the required security roles

After the installation is complete, perform the tasks in [Assign roles and enable users for Omnichannel for Customer Service](add-users-assign-roles.md) to assign the following security roles to your users:

- Basic User
- Customer Service Representative
- Omnichannel administrator
- Omnichannel supervisor
- Omnichannel agent
- Productivity tools user
- Productivity tools administrator

## Sign in to the Omnichannel admin center app

As an administrator, you will perform all configuration and setting up tasks in the Omnichannel admin center app as follows:

1. Sign in to Dynamics 365.

2. On the Apps page, select **Omnichannel admin center** app. The following page appears.

> [!div class="mx-imgBorder"]
> ![Omnichannel admin center home.](media/oca-home-page.png "Omnichannel admin center home")

### See also

[Overview of voice channel in Omnichannel for Customer Service](voice-channel.md)  
[Configure unified routing for the voice channel](voice-channel-route-queues.md)  
[Overview of unified routing](overview-unified-routing.md)  