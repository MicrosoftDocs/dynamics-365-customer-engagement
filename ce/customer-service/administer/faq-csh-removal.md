---
title: Customer Service Hub app removal and migration FAQ
description: Learn about frequently asked questions about the Customer Service Hub app removal and migration to Copilot Service workspace.
ms.date: 06/20/2025
ms.topic: how-to
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.custom: bap-template
---

# Customer Service Hub app removal and migration FAQ

This article contains frequently asked questions about the removal of the Customer Service Hub app for new organizations with Enterprise licenses and migration to Copilot Service workspace.

## Why has the Copilot Service workspace app replaced Customer Service Hub for new organizations with Enterprise licenses?

Copilot Service workspace offers improved customer service representative (service representative or representative) efficiency as a multisession app with a browser-like, tabbed experience in a single window. In contrast, Customer Service Hub is a single-session app that requires service representatives to open multiple browser windows to manage their work items.

Copilot Service workspace improves the ability for representatives to respond to email, chats, and messages from configured social media channels, and calls. Representatives can view and filter their conversations and work items in an Outlook-style inbox. Administrators can create custom inbox views to meet the needs of their organizations.

You can reap the benefits of using Microsoft Copilot out of the box without the need for extra configuration in Copilot Service workspace. When administrators enable Copilot, representatives can use the following features:
 
 - Summarize cases with Copilot
 - Summarize conversations with Copilot
 - Ask Copilot questions
 - Draft email replies using Copilot

## What does removal mean?

Removal means Microsoft plans to remove a feature or app after on a specific date. In this case, as of February 2025, the Customer Service Hub app is no longer available for all new organizations with Enterprise licenses. We continue to support the application for all existing organizations and new customers who have other license types other than Enterprise (for example, Customer Service Professional licenses). However, we recommend that all existing customers migrate to Copilot Service workspace.

## Can I continue to use the Customer Service Hub app?

Yes. If you're already using Customer Service Hub, you can continue to use it. As of July 12, 2024, new customers can only deploy Copilot Service workspace in their enterprise environments. We continue to support the application for all existing organizations and new customers who have other license types other than Enterprise (for example, Customer Service Professional licenses).

## Since Customer Service Hub is no longer available to new enterprise organizations, what app should I use?

You can use the Copilot Service workspace app.

## What's the best way to get familiar with Copilot Service workspace?

Learn more in [Copilot Service workspace in a day](https://go.microsoft.com/fwlink/?linkid=2300097).

## I'm an existing enterprise customer and still need to use Customer Service Hub. How do I enable it?

If you're an existing customer and need to set up Customer Service Hub in your enterprise environment for testing purposes, complete the steps in this section.

1. Sign in to [Power Apps](https://go.microsoft.com/fwlink/p/?linkid=2142083), and then select your solution.

1. Select **Default Solutions**, and then select **Environment variables**. The **Add existing environment variables** page appears.

1. In the search field, type either "msdyn_AllowCSHAppHide" or "Enable or disable the ability to hide the CSH application", and then select it in the search results. The **Edit Allow CSH App Hide** dialog appears.

1. Change **Current Value** to **No**, and then select **Save**.

1. Open Copilot Service admin center, and then on the site map, select **New and upcoming features** in **Miscellaneous**.

1. On the **New and upcoming features** page, select the checkbox for **Provider icon configuration**.

1. Select **Save and close**.
 
### Related information
[Migrate to Copilot Service workspace from removed or deprecated apps](migrate-to-csw.md)  
[Get started with Copilot Service workspace](../implement/csw-overview.md)  
[Overview of the productivity pane](../use/csw-productivity-pane.md)
