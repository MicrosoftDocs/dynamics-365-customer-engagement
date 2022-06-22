---
title: "Set up routing for email record in Customer Service | MicrosoftDocs"
description: "Learn about the process that's required to route the email record using unified routing in Customer Service."
ms.date: 05/25/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Configure unified routing for email records


In Customer Service, you can configure emails to be routed as work items and added to queues for agents to work on them.

In your organization, you can configure the following two methods for your agents to work on emails:

Conv


## How you can configure routing of email records

When an email comes from a customer, you can use one of the following methods to handle the mail:

- **Route email as a case**: One of the ways in which you can enable emails to be routed as cases is by configuring the automatically create or update records option. However, this method requires manual intervention in which the user has to use the Save and route option on the case form. Moreover, such work items will not appear on the agent dashboard and agents will not receive notifications about assignment. More information: [Automatically create or update records](automatically-create-update-records.md)

- **Route email as a record**: You need to configure the following settings to route the email as a record.

  1. **Configure a dedicated mailbox and share the mail ID with customers**. Customers can write to the configured mail ID and the mails are converted to cases and routed to the queue that's associated with the mailbox.
  
  1. **Configure server-side sync to create email record and queue item when customer sends mail**. More information: [Server-side sync](/dynamics365/customerengagement/on-premises/admin/server-side-synchronization?view=op-9-1)
  
  1. **Power Automate flow**. Configure the flow in Power Automate to automatically route the work items to agents. The routed records will appear on the agent dashboard as work items. More information: [Route records automatically](routing-trigger-automatic.md)

    1. **Configure workstreams**: Create workstreams, and configure classification and route-to-queue rules. More information: [Create workstreams](create-workstreams.md)
    
    1. **Configure queues**: Create queues, and configure assignment methods. More information: [Create queues for unified routing](queues-omnichannel.md)

The high-level process of how email can be routed using unified routing is depicted in the following architecture diagram.

:::image type="content" source="media/email-routing-architecture.png" alt-text="Architecture diagram of email routing.":::


### See also

[Overview of unified routing](overview-unified-routing.md)  
[Provision unified routing](provision-unified-routing.md)  
[Configure classification rules](configure-work-classification.md)  
[Assignment methods in unified routing](assignment-methods.md)  