---
title: FAQs about adding users to agent experience profile | MicrosoftDocs 
description: Frequently Asked Questions about adding users to agent experience profiles
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: concept
ms.date: 04/05/2023 
ms.custom: bap-template 
---

# FAQs about adding users to agent experience profile

This article contains the frequently asked questions (FAQ) that you as an administrator might have when adding users to the custom agent experience profiles using the **Set as default** and **Set rank and roles** options in Customer Service admin center.

## Can I set the profiles that are available out-of-the box as default profiles?

No. The **Set as default** and **Set rank and roles** options aren't applicable to profiles that are available out-of-the-box.

## Can I create agent experience profiles, customize them and move between environments using solutions?
Yes. You can create and customize profiles in an environment, add them to a solution and then import them to other environments.

## Why I can't I edit some of the custom agent experience profiles?

You can't edit profiles that are imported from a managed solution. You can edit only the agent experience profiles that are from an unmanaged solution. Profiles with the lock icon indicate that they're exported from managed solutions and aren't editable.

## Can I assign the profiles available out-of-the-box to roles or set them as default?

No. The **Set as default** and **Set rank and roles** options aren't applicable to profiles that are available out-of-the-box.

## Why do I see multiple profiles with the same rank?

You can't create multiple profiles with the same rank from the Customer Service admin center. However, if  you've imported profiles created in different environments, you can have two or more profiles with the same rank. We recommend that you resolve the conflict from the source environments and then import the profiles.

## Can I have multiple profiles marked as default?

No. You can't have multiple default custom profiles when you're setting the default profile in Customer Service admin center.  However, if  you've imported profiles created in different environments, you might see multiple default profiles. We recommend that you resolve the issue in the source environments and then import the profiles.

### See also

[ Add users to agent experience profiles](add-profile-default.md)<br>
[Create and use agent experience profiles](create-agent-experience-profile.md)<br>
[Manage session template](session-templates.md)  
[Overview of Dynamics 365 Productivity Tools](productivity-tools.md)  
[Overview of channels in Omnichannel for Customer Service](../customer-service/channels.md)  
[Overview of agent experience profiles](overview.md) 