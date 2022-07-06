---
title: "Set up routing for email record in Customer Service | MicrosoftDocs"
description: "Learn about the process that's required to route the email record using unified routing in Customer Service."
ms.date: 07/06/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Configure unified routing for email records

In Dynamics 365 Customer Service, you can configure emails to be routed as work items and added to queues for agents to work on them.

When an email comes from a customer, you can use one of the following methods to address the mail:

- **Route email as a case**: Perform the following settings to route email as a case:

  1. Configure the automatically create or update records option to create a case. More information: [Automatically create or update records](automatically-create-update-records.md)
  
  1. Save and route the case on the case form. More information: [Save and route a case](customer-service-hub-user-guide-case-queues-and-routing.md#save-and-route-a-case)

- **Route email as a record**: Configure the following settings to route the email as a record:

  1. **Configure a dedicated mailbox and share the mail ID with customers**: Customers can write to the configured mail ID and the mails are converted to cases and routed to the queue that's associated with the mailbox. More information: [Create a forward mailbox](../customerengagement/on-premises/admin/create-forward-mailboxes-edit-mailboxes.md?view=op-9-1)
  
  1. **Configure server-side sync**: Set up server-side sync to create the email record and queue item when customer sends mail. More information: [Server-side sync](../customerengagement/on-premises/admin/server-side-synchronization.md?view=op-9-1)
  
  1. **Configure Power Automate flow**: Configure the flow in Power Automate to automatically route the work items to agents. The routed records will appear on the agent dashboard as work items. More information: [Route records automatically](routing-trigger-automatic.md)

  1. **Configure workstreams**: Create workstreams and configure classification and route-to-queue rules. More information: [Create workstreams](create-workstreams.md)

  1. **Configure intake rules**: Configure intake rules to identify the workstream to route the email record. More information: [Set up unified routing for records](set-up-record-routing.md)

  1. **Configure queues**: Create queues and configure assignment methods. More information: [Create queues for unified routing](queues-omnichannel.md)

The high-level process of how email can be routed using unified routing is depicted in the following architecture diagram.

:::image type="content" source="media/email-routing-architecture.png" alt-text="Architecture diagram of email routing.":::

### See also

[Overview of unified routing](overview-unified-routing.md)  
[Provision unified routing](provision-unified-routing.md)  
[Configure classification rules](configure-work-classification.md)  
[Assignment methods in unified routing](assignment-methods.md)  