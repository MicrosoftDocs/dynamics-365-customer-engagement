---
title: FAQ on representative presence in Customer Service
description: Find answers to frequently asked questions about representative presence and how it's calculated in Dynamics 365 Customer Service and Dynamics 365 Contact Center.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: faq
ms.collection:
ms.date: 10/16/2026
ms.custom: bap-template
---

# FAQ on representative presence in Customer Service

This article answers frequently asked questions about customer service representative (service representative or representative) presence.

## What happens when a representative changes presence manually during a conversation?

To understand how presence works, see [How do manual and automatic presence updates work together](oc-manage-presence-status.md#how-manual-and-automatic-presence-updates-work-together).

## What presence does the representative have outside of working hours?

Operating hours and work hours settings don't affect presence. The system calculates presence the same way at any time of day. Learn more in [How presence is calculated](oc-manage-presence-status.md#how-presence-is-calculated-when-representatives-sign-in).

## What presence does a representative have when they sign in from multiple browsers?

The same presence status persists across the different browsers. We recommend that customer service representatives (service representatives or representatives) don't sign in from multiple browsers.

## How can I use presence to manage the workload of blended representatives across channels?

When representatives need to be available for calls while they work on emails or cases, configure a voice [capacity profile](../administer/capacity-profiles.md) that's nonblocking with a limit of one and allowed presence of the workstream as **Available** and **Busy**. This configuration ensures that representatives are assigned the voice calls even when they're busy with assignments on other channels.

## Does presence change if a representative joins a consult chat or call?

No. Presence doesn't change when a representative joins a consult.

## What happens to presence when representatives don't close conversations properly?

Stuck conversations can result in incorrect presence status because capacity is also blocked.

## Is presence affected when representatives refresh their browser?

No. Presence doesn't change when a representative refreshes the browser.

## How is presence affected when representatives experience network issues?

When a network issue disconnects a representative, presence changes to **Offline**. If the representative reconnects within 2.5 minutes, the system restores their previous presence. Otherwise, the system recalculates their presence. Learn more in [How presence status is updated](oc-manage-presence-status.md#how-presence-status-is-updated).

## Why does my presence change to offline or default presence after I return to an idle Copilot Service workspace tab?

Your browser might put the idle tab to sleep. The system treats this action as a disconnection. Update your browser settings to always keep the Copilot Service Workspace tab active. Learn more in [How presence status is updated](oc-manage-presence-status.md#how-presence-status-is-updated).

## Does presence load when representatives have custom roles?

Yes. See the [prerequisites](oc-manage-presence-status.md#prerequisites) that are required for the presence status to load correctly.

## Can I view representative custom presence statuses in reports?

Yes, you can view representative custom presence statuses in the agent report for Omnichannel real-time analytics and Omnichannel historical analytics.

## Can I set default presence for representatives or group?

You can set default presence for each representative. It's not available for setting up in bulk.

## Why is my presence not being reset to default when I select reset on a missed or rejected work notification?

The system updates the presence based on capacity use.

## Related information

[Manage presence in Customer Service](oc-manage-presence-status.md)
