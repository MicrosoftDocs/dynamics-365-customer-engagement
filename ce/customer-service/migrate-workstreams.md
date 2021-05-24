---
title: "Migrate workstreams | MicrosoftDocs"
description: "Use the migration tool to migrate workstreams to enable them for unified routing"
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 05/13/2021
ms.topic: article
ms.service: "dynamics-365-customerservice"
---

# Migrate workstreams created in Omnichannel Administration

If you've upgraded your Omnichannel for Customer Service instance to 2021 release wave 1 and want to use unified routing, we recommend that you migrate your existing workstreams for the messaging channels that you created in the Omnichannel Administration app.

You can use the migration utility that is available at the following link:

[Unified routing migration application](https://go.microsoft.com/fwlink/p?linkid=2161582)

Download the [Migrate workstreams for unified routing](https://go.microsoft.com/fwlink/p?linkid=2161582) PDF that is available with the migration utility, and follow the steps to migrate your workstreams.

After the migration is complete, open the Omnichannel admin center app, and perform the following steps to verify that the workstreams are migrated according to your requirement:

1. Open the route to queue rules and skill identification rules, if any, and verify the migrated rules to make sure that they represent the same rules as what you've configured before migration.
2. Perform a sanity check by initiating chats and verifying that they are routed to the expected queues.

You can then configure the work classification rules and any other settings pertaining to unified routing.

> [!IMPORTANT]
>
> After the upgrade, your queues will start using unified routing services for assignment. By default, all existing queues will use the "highest capacity" assignment method for work distribution. You can change the assignment method to round robin or a custom assignment method according to your need. More information: [Set up assignment methods in Customer Service](assignment-methods.md).

## Migrate workstreams for routing records

In Omnichannel for Customer Service, the existing workstreams for routing records can't be migrated. Instead, you'll need to create them anew in Omnichannel admin center or Customer Service Hub, and enable them for unified routing.

### See also

[Overview of unified routing](overview-unified-routing.md)  
[Routing and assignment rules](routing-workstream-queues.md)  
[Configure work classification rulesets](configure-work-classification.md)  
[Set up record routing](set-up-record-routing.md)  
[Get started with Omnichannel admin center](oc-admin-center.md)  
[FAQs on unified routing](unified-routing-faqs.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]