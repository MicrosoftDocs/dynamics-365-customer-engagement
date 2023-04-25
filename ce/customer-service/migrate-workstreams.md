---
title: "Migrate workstreams | MicrosoftDocs"
description: "Use the migration tool to migrate workstreams to enable them for unified routing"
ms.date: 02/25/2022
ms.topic: article
author: neeranelli
ms.author: nenellim
---

# Migrate workstreams created in Omnichannel Administration

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

## Introduction

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

After upgrading Omnichannel for Customer Service, we recommend that you use the new Omnichannel admin center app to configure record routing. You can no longer configure record routing in the Omnichannel Administration app because it won't work as expected. The existing workstreams that you created for routing records in the Omnichannel Administration app can't be migrated. Instead, you'll need to recreate them in Omnichannel admin center or Customer Service Hub, and then enable them for unified routing.

### See also

[Overview of unified routing](overview-unified-routing.md)  
[Configure work classification rulesets](configure-work-classification.md)  
[Set up record routing](set-up-record-routing.md)  
[Get started with Omnichannel admin center](oc-admin-center.md)  
[FAQ on unified routing](unified-routing-faqs.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
