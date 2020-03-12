---
title: "Facebook channel agent experience in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about Facebook channel through Twilio agent experience in Omnichannel for Customer Service."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 04/01/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Use Facebook channel

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

## Facebook channel overview

When you sign in to Omnichannel for Customer Service, you can see your work items in Omnichannel Agent Dashboard. To learn more see [View agent dashboard and agent conversations (work items)](oc-agent-dashboard).

## Prerequisite

Make sure your administrator has configured a Facebook channel.

### Incoming Facebook notification

You receive a notification for a Facebook conversation request. When you accept the Facebook request, a session is started, and the communication panel appears where you can exchange messages with the customer.

> [!div class=mx-imgBorder]
> ![Facebook chat agent notification](../../media/fb-agent-notif.png "Facebook chat agent notification")

In Omnichannel for Customer Service, you can:

- [View customer summary](agent/agent-oc/oc-customer-summary.md)
- [View communication panel](agent/agent-oc/oc-conversation-control.md)
- [Use call options and visual engagement in live chat](agent/agent-oc/call-options-visual-engagement.md)
- [Monitor real-time customer sentiment](agent/agent-oc/oc-monitor-real-time-customer-sentiment-sessions.md)
- [Manage sessions](agent/agent-oc/oc-manage-sessions.md)
- [Manage applications](agent/agent-oc/oc-manage-applications.md)
- Use productivity tools
    - [Use agent scripts](agent/agent-oc/oc-agent-scripts.md)
    - [View Smart assist](agent/agent-oc/oc-smart-assist.md)
    - [Use productivity pane](agent/agent-oc/oc-productivity-pane.md)
- [Create a record](agent/agent-oc/oc-create-record.md)
- [Search, link, and unlink a record](agent/agent-oc/oc-search-link-unlink-record.md)
- [Search for and share knowledge articles](agent/agent-oc/oc-search-knowledge-articles.md)
- [Take notes specific to conversation](agent/agent-oc/oc-take-notes.md)
- [Understand conversation states](agent/agent-oc/oc-conversation-state.md)
- [Manage presence status](agent/agent-oc/oc-manage-presence-status.md)
- [Search for transcripts](agent/agent-oc/oc-search-transcipts.md)
- [View conversation and session forms](agent/agent-oc/oc-view-activity-types.md)
- [View customer summary for an incoming conversation request](agent/agent-oc/oc-view-customer-summary-incoming-conversation-request.md)
- [Search for transcripts](agent/agent-oc/oc-search-transcipts.md)

## Send and receive file attachments

You can send file attachments to customers during a Facebook channel conversation. Before you send a file, make sure to understand about the file size limit and file extensions type supported from your administrator. 

You can see the files that you receive from a customer on the communication panel. To view the file, you need select on the file and save them to your computer. The file name you see on an image that was sent by a customer might not reflect the actual file name, but a randomly generated number.

   > [!div class=mx-imgBorder]
   > ![Facebook attachment](../../media/fb-receive-file1.png "Facebook attachment")

Also, when a customer sends an unsupported file extension type, then you can see an error message in the communication panel stating the message - **Error: Customer sent an unsupported message type**.

### Send a file

To send a file, follow the steps:

1. Select the ellipsis (...) in the communication panel.

2. Select **Attach file**. A window will be displayed.

3. Browse and select the file to send it.

    > [!div class=mx-imgBorder]
    > ![Facebook attachment](../../media/fb-attach.png "Facebook attachment")

To learn more about the Facebook channel setup, see [Configure a Facebook channel](../../administrator/configure-facebook-channel.md).

## Privacy notice

Customers are solely responsible for using Dynamics 365, this feature, and any associated feature or service in compliance with all applicable laws, such as laws relating to monitoring, recording, and storing communications with their end users. This includes adequately notifying end users that their communications with agents may be monitored, recorded, or stored and, as required by applicable laws, obtaining consent from end users before using the feature with them. Customers are also encouraged to have a mechanism in place to inform their agents that their communications with end users may be monitored, recorded, or stored.

## See also

[Configure a Facebook channel](../../administrator/configure-facebook-channel.md)