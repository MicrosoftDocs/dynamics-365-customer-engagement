---
title: FAQ about adding users to agent experience profile | MicrosoftDocs 
description: Frequently Asked Questions about adding users to agent experience profiles
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.service: dynamics-365 
ms.topic: concept
ms.date: 02/03/2023 
ms.custom: bap-template 
---

# FAQ about adding users to agent experience profile

This article contains the frequently asked questions (FAQ) that you as an administrator might have when adding users to the custom agent experience profiles using the **Set as default** and **Set rank and roles** options.

## Can I create agent experience profiles, customize them and move between environments using solutions?
Yes. You can create and customize profiles in an environment, add them to a solution and then import them to other environments.

## Why I can't I edit some of the custom agent profiles?

You can't edit profiles that are imported from a managed solution. You can only edit agent profiles that are from an unmanaged solution. Profiles with the lock icon displayed indicate that they're exported from managed solutions and aren't editable.

## Can I assign the profiles available out-of-the-box to roles or set them as default?

No. The **Set as default** and **Set rank and roles** options aren't applicable to profiles that are available out-of-the-box.

## Why do I see multiple profiles with the same rank?

You can't create multiple profiles with the same rank from the Customer Service admin center. However, if  you've imported profiles created in different environments, you can have two or more profiles with the same rank. We recommend that you resolve the conflict from the source environments and then import the profiles.

## Can I have multiple profiles marked as default?

No. You can't have multiple default custom profiles when you're setting the default profile in Customer Service admin center.  However, if  you've imported profiles created in different environments, you might see multiple default profiles. We recommend that you resolve the issue in the source environments and then import the profiles.