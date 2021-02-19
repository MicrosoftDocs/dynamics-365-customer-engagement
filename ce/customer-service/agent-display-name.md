---
title: "Configure agent display name for a chat widget | MicrosoftDocs"
description: "Instructions to configure agent display name for a chat widget in Omnichannel for Customer Service."
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 10/01/2019
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Configure agent display name

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

To protect an agent's privacy, you can configure your chat widget to display either full name, first name, last name, or nickname of an agent to the customers. If you would like to hide your agent’s identity and anonymize, choose to display the nickname. The values for the names are retrieved from the user entity record created in Omnichannel for Customer Service. For information on creating users, see [Create users in model-driven applications and assign security roles](../admin/create-users-assign-online-security-roles.md). You can add nickname of a user in the Omnichannel user record in Web Client.

> [!NOTE]
> The selected agent display name is displayed only in the chat widget while chatting with a customer. For consultation or chat transfer, full name of the agent is used. 

1. Sign in to Omnichannel Administration.

2. Go to **Channels** &gt; **Chat**.

3. Open the chat widget in which you need to configure the agent display name.

5. Go to the **Basic details** tab.

6. In the **Display agent name** field, select one of the following:

    - **Full name**: Full name of the agent.

    - **First name**: First name of the agent. By default, first name is selected.

    - **Last name**: Last name of the agent.

    - **Nick name**: Nickname of the agent. If a nickname is not available in the user entity record, the full name is displayed to the customers.

7.	Select **Save**.

### See also

[Configure a pre-chat survey](configure-pre-chat-survey.md) <br>
[Configure file attachment capability](configure-file-attachment.md)<br>
[Create quick replies](create-quick-replies.md) <br>
[Create and manage operating hours](create-operating-hours.md) <br>
[Create chat authentication settings](create-chat-auth-settings.md) <br> 
[Embed chat widget in your website or portal](embed-chat-widget-portal.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]