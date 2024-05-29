---
title: Activity management FAQs
description: Get answers to frequently asked questions about the Activity management.
ms.date: 3/15/2024
ms.topic: troubleshooting
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.owner: shujoshi
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/11/2024
---

# Activity management FAQs

This article answers frequently asked questions about the Activity management in Dynamics 365 Sales, Sales premium, and Sales professional.

## I'm redirected to the default tab when I save an appointment from a non-default tab. Why?

This is by design. If the SchedulingEngine feature is enabled for appointments, you're redirected to the default tab, when you save the appointment from a non-default tab.

## Why are appointments saved automatically even when there's a custom script to stop automatic saving?

This is by design. If the SchedulingEngine feature is enabled for appointments, the system overrides any custom script and saves the appointments automatically.

## Why does the Open Record Set button disappear when an appointment is saved?

If the SchedulingEngine feature is enabled for appointments, the **Open Record Set** button disappears when you select **Save** but reappears when you refresh the page. For more information, go to [Open Record Set](/powerapps/user/navigation#record-set-navigation).

## Why are synchronized appointments from Outlook shown as unsaved in Dynamics 365?

This is by design. Disable the automatic save option in Dynamics 365 to show synchronized appointments from Outlook as saved in Dynamics 365.

