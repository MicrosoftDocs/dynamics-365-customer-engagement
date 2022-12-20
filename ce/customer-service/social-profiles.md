---
title: View social profiles of contacts
description: Know how to see the social profiles of customers and how the data is consolidated in Dynamics 365.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.service: dynamics-365
ms.topic: how to
ms.date: 12/21/2022
ms.custom: bap-template 
---

# View social profiles of contacts

Omnichannel for Customer Service creates a social profile for incoming requests from asynchronous channels. After a social profile is created for a conversation within a channel, later conversations are linked to the same social profile for the channel.


## How social profiles are linked with contacts

When a customer sends a message, automatically, a record is created with the social profile for the channel by using the unique identifier for the customer. When the same customer interacts with your agents the second time, the linked social profile is identified in the conversation and displayed to the agent. A social profile for the channel though which the customer has contacted is created. For example, if your customer has used a Facebook channel, the Facebook social profile is created.

## View social profiles

As an agent, you can see the social profiles by using the **Search** menu.

1. In the Omnichannel for Customer Service app, select the **Search** box, and scroll to the bottom of the list.

1. Select **Search for rows in a table using advanced filters**.

1. In the **Select a table to search** flyout menu, select **Social Profiles**, and select **Continue**. The **Active Social Profiles** page displays the list of active profiles.

1. Select the profile that you want to view. The social profile information, such as the customer, profile name, and the social channel is displayed.

1. The **RELATED SOCIAL PROFILES** section displays the related social profiles that are automatically linked after the contact is identified through the unique identifier.

1. You can update the details and save the profile.

1. You can deactivate or activate the social profile.

## Next steps

[Support for social profiles](card-support-in-channels.md#support-for-social-profiles)  


