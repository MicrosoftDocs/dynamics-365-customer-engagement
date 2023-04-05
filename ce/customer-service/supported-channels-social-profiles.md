---
title: View social profiles of contacts
description: Know how to see the social profiles of customers and how the data is consolidated in Dynamics 365.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 12/23/2022
ms.custom: bap-template 
---

# View social profiles of contacts

Omnichannel for Customer Service creates a social profile for incoming requests from asynchronous channels. After a social profile is created for a conversation within a channel, later conversations are linked to the same social profile for the channel so that you can view all the related information in one place.

## How social profiles are linked with contacts

When a customer sends a message, a record is automatically created with the social profile for the channel by using the unique identifier for the customer.

With social profiles, you can do the following:

- [Automatically identify customers](record-identification-rule.md) on social channels
- Display the customer name or phone number with conversations and calls on the agent dashboard
- Send outbound messages

The social profiles are supported for the following channels.

| Channel            | Supported?                                                          | Visitor name|
|--------------------|---------------------------------------------------------------------|-------------|
| Apple Messages for Business | Yes                                                        | Visitor     |
| Facebook           | Yes                                                                 | User name |
| Google's Business Messages | Yes                                                         | Display name |
| LINE               | Yes                                                                 | Display name |
| Twitter            | Yes                                                                 | Twitter handle name |
| WeChat             | Yes                                                                 | Visitor |
| WhatsApp           | Yes                                                                 | Phone number |
| Custom messaging (Telegram) | Yes                                                        | User name |

## View social profiles

As an agent, you can see the active social profile information, such as the customer, profile name, social channel, and related social profiles.

1. In the Omnichannel for Customer Service app, select the **Search** box, and scroll to the bottom of the list.

1. Select **Search for rows in a table using advanced filters**.

1. In the **Select a table to search** flyout menu, select **Social Profiles**, and select **Continue**. The **Active Social Profiles** page displays the list of active profiles.

1. Select the profile that you want to view.

1. The **RELATED SOCIAL PROFILES** section displays the related social profiles that are automatically linked after the contact is identified through the unique identifier.

Optionally, you can update the details and save the profile. You can also deactivate or activate the social profile.

## Next steps

[View customer information on Active Conversation form](oc-customer-summary.md)  