---
title: Migrate legacy workstreams created in Omnichannel Administration
description: Use the migration tool to migrate legacy workstreams to enable them for unified routing.
ms.date: 07/25/2023
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.custom: bap-template
---

# Migrate workstreams created in Omnichannel Administration

[!INCLUDE[cc-omnichannel-administration-deprecation-note.md](../includes/cc-omnichannel-administration-deprecation-note.md)]

## When will the Omnichannel Administration app be removed?

The rollout of removing the Omnichannel Administration app has started and will be applied region wise. For example, in Canada, the removal is expected to be complete by July 24, and in North America, by August 11, 2023.

## Do I need to migrate any records?

If you want to continue to use workstreams created in the Omnichannel Administration app, then you must migrate them to the Customer Service admin center app by using the information that's available in this article. You need to migrate them because the backend tables for the workstreams and the routing services are different in both the apps. The legacy routing service of the deprecated app will also be shut down.

If you are already using Customer Service admin center and unified routing, you don't need to take any action.

## How do I know in which app my workstreams were created?

If the workstreams or any related records like rules that you are using are visible in the Customer Service admin center app and routing is working fine, then no migration is needed. The migrated records or records created with the new table structure only are visible in Customer Service admin center.

## How do I validate if the migration is successful?

After you have migrated all the workstream configurations from Omnichannel Administration, they are recreated in Customer Service admin center. Use the steps in the following section to do a sanity check.

## Use the migration application for legacy workstreams

1. Use the [Unified routing migration application](https://go.microsoft.com/fwlink/p?linkid=2161582).
1. Download the [Migrate workstreams for unified routing](https://go.microsoft.com/fwlink/p?linkid=2161582) PDF that is available with the migration utility, and follow the steps to migrate your workstreams.
1. After the migration is complete, open the Customer service admin center app, and perform the following steps to verify that the workstreams are migrated according to your requirement:
   1. Open the route to queue rules and skill identification rules, if any, and verify the migrated rules to make sure that they represent the same rules as what you've configured before migration.
   1. Perform a sanity check by initiating chats and verifying that they are routed to the expected queues.
   1. Configure the work classification rules and any other settings pertaining to unified routing.

> [!IMPORTANT]
> After the upgrade, your queues will start using unified routing services for assignment. By default, all existing queues will use the "highest capacity" assignment method for work distribution. You can change the assignment method to round robin or a custom assignment method according to your need. More information: [Set up assignment methods in Customer Service](assignment-methods.md).

## Migrate workstreams for routing records

After upgrading Omnichannel for Customer Service, we recommend that you use the Customer Service admin center app to configure record routing. You can no longer configure record routing in the Omnichannel Administration app because it won't work as expected. The existing workstreams that you created for routing records in the Omnichannel Administration app can't be migrated. Instead, you'll need to recreate them in Customer Service admin center, and then enable them for unified routing.

### See also

[Overview of unified routing](overview-unified-routing.md)  
[Configure work classification rulesets](configure-work-classification.md)  
[Set up record routing](set-up-record-routing.md)  
[Get started with Customer Service admin center](cs-admin-center.md)  
[FAQ on unified routing](unified-routing-faqs.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
