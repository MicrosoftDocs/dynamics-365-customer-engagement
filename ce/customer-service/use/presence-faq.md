---
title: FAQ on representative presence in Customer Service
description: Find answers to the most commonly asked questions on representative presence and how presence is calculated.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: faq
ms.collection:
ms.date: 01/08/2026
ms.custom: bap-template
---

# FAQ on representative presence in Customer Service

This article tries to answer the questions that you might have on representative presence.

## What happens when representative changes presence manually during a conversation?

To understand how presence works, see [How do manual and automatic presence updates work together](oc-manage-presence-status.md#how-do-manual-and-automatic-presence-updates-work-together).

## What presence does the representative have outside of working hours?

The presence status isn't calculated based on operating hours or work hour setting. Learn more in [How presence is calculated](oc-manage-presence-status.md#how-presence-is-calculated-when-representatives-sign-in).

## What presence does a representative have when they sign in from multiple browsers?

The same presence status will persist across the different browsers. We recommend that customer service representatives (service representatives or representatives) don't sign in from multiple browsers.

## How can I use presence to manage workload of blended representatives across channels?

When representatives need to be available for calls while they work on emails or cases, configure a voice [capacity profile](../administer/capacity-profiles.md) that's non blocking with a limit of 1 and allowed presence as **Available** and **Busy**. This configuration makes sure that representatives are assigned the voice call even when they are busy with assignments on other channels.

## Does presence change if representative gets into a consult chat or call?

Presence status is unaffected when representative joins a consult.

## What happens to presence when representatives don't close conversations properly?

Stuck conversations can result in incorrect presence status because capacity is also blocked.

## Is presence affected when representatives refresh their browser?

Representative status remains the same when they refresh their browser.

## How is presence affected when representatives experience network issues?

See [how presence status is updated](oc-manage-presence-status.md#how-presence-status-is-updated) to understand the behavior during network issues.

## Does presence load when representatives have custom roles?

See the [prerequisites](oc-manage-presence-status.md#prerequisites) that are required for the presence status to load correctly.

## Can I view representative custom presence statuses in reports?

Yes, you can view representative custom presence statuses in the agent report for Omnichannel real-time analytics and Omnichannel historical analytics.

## Can I set default presence for representatives or group?

You can set default presence for each representative. It's not available for setting up in bulk.

## Why is my presence not being reset to default when I select reset on a missed or reject notification message?

The system updates the presence based on capacity use.

## Next steps

[Manage presence in Customer Service](oc-manage-presence-status.md)