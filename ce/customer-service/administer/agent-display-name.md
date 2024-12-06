---
title: Configure agent display name for a chat widget
description: This article provides procedural information to configure an agent's display name for a chat widget.
ms.date: 03/21/2024
ms.topic: article
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
---

# Configure agent display name

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

To protect an agent's privacy, you can configure your chat widget to display either the full name, first name, last name, or nickname of the agent to the customers. If you'd like to hide your agent’s identity and anonymize, choose to display the nickname. The values for the names are retrieved from the user record created in Dynamics 365. For information on creating users, see [Create users in model-driven applications and assign security roles](/power-platform/admin/create-users-assign-online-security-roles). You can add nickname of a user in the Omnichannel user record.

> [!NOTE]
> The selected agent's name is displayed in the chat widget only while the agent is chatting with a customer. For consultation or chat transfer, the full name of the agent is used.

1. In the Customer Service admin center or Contact Center admin center, go to the workstream of the chat widget in which you need to configure the settings. 
1. Select edit for the required chat widget, and on the **Chat channel Settings** page, go to the **Chat widget** tab.

1. In the **Agent display name** field, select one of the following options:

    - **Full name:** Full name of the agent.

    - **First name:** First name of the agent. By default, first name is selected.

    - **Last name:** Last name of the agent.

    - **Nick name:** Nickname of the agent. If a nickname is not available in the user record, the full name is displayed to the customers.

1. Select **Save**.

### Related information

[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Configure file attachment capability](configure-file-attachment.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br> 
[Embed chat widget in your website or portal](embed-chat-widget-portal.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
