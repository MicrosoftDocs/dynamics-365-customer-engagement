---
title: Set up unified routing for email records
description: Learn how to use unified routing to route email records as work items in Dynamics 365 Customer Service.
ms.date: 08/29/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# Set up unified routing for email records

With unified routing, you can route any activity in Dynamics 365 Customer Service. Emails are one such example of the activity type that you can turn into work items and add them to queues for agents to work on.

A high-level overview of unified routing with email records is as follows.

:::image type="content" source="media/email-routing-architecture.png" alt-text="Architecture diagram of email routing.":::

## Route email as a case

1. Set up rules to [create or update records automatically](automatically-create-update-records.md).

1. [Save and route the case](customer-service-hub-user-guide-case-queues-and-routing.md#save-and-route-a-case) on the case form.

## Route email as a record

1. [Set up a dedicated mailbox](../customerengagement/on-premises/admin/create-forward-mailboxes-edit-mailboxes.md?view=op-9-1&preserve-view=true) and share the email ID with customers. When a customer emails the ID, the email is converted to a case and routed to the queue that's associated with the mailbox.

1. Set up [server-side sync](../customerengagement/on-premises/admin/server-side-synchronization.md?view=op-9-1&preserve-view=true) to create the email record and queue item.

1. Create a flow to [automatically route the work item](routing-trigger-automatic.md) to agents.

1. [Create workstreams](create-workstreams.md) and set up classification and route-to-queue rules.

1. [Set up intake rules](set-up-record-routing.md#configure-intake-rules) to identify the workstream to route the email record.

1. [Create queues](queues-omnichannel.md) and [set up assignment methods](assignment-methods.md).


> [!NOTE]
> You must ensure that the agent capacity is released after the agent completes their work on the email record. More information: [Release agent capacity](capacity-profiles.md#release-capacity-for-agents)

### See also

[Overview of unified routing](overview-unified-routing.md)  
[Enable unified routing](provision-unified-routing.md)  
[Configure classification rules](configure-work-classification.md)  
[Create queue items from synchronized email messages](/power-platform/admin/create-queue-items-from-synchronized-email-messages)  
[Use email message filtering and correlation to specify which emails are tracked](/power-platform/admin/email-message-filtering-correlation)  
