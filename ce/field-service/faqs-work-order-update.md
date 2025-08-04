---
title: FAQs for work order update (preview)
description: Get answers to common questions about how the AI-powered work order update feature in the Dynamics 365 Field Service mobile app helps you quickly update details of a work order.
ms.date: 07/29/2025
ms.update-cycle: 180-days
ms.custom:
  - responsible-ai-faqs
  - bap-template
ms.topic: faq
author: JonBaker007
ms.author: jobaker
ms.reviewer: puneet-singh1
ms.collection: bap-ai-copilot 
---

# FAQs for work order update (preview)

These FAQs describe the AI impact of the Dynamics 365 Field Service work order update (preview) feature.

## What is work order update with Copilot?

Work order update allows frontline workers to describe work performed in natural language on their mobile device. Copilot uses this description to recommend updates to fields in the new Field Service Mobile experience. This feature saves frontline workers time by reducing the effort needed to update forms and fields in the app.

## What are the feature's capabilities?

Based on user input, the feature recommends fields to update in the mobile application. The frontline worker gets suggestions for all recommended updates, which they review and confirm before updates are made to the record.

## What is the feature's intended use?

A frontline worker updates data fields in forms to track booking progress. The worker records start and end times and logs completed tasks. This feature helps the worker make updates on a mobile device with an internet connection.

## What are the limitations of work order update with Copilot? How can users minimize the impact of the limitations when using the system?

- This feature is currently in preview. Share your feedback on the content quality by selecting the like or dislike icons in the feature's control. We use this data to evaluate and improve the capability.
- This feature is available only in the new field service mobile user experience.
- Copilot updates only the fields in a predefined schema.
- This feature requires an internet connection. It isn't available offline.
- We evaluated the feature in English only. You can get inaccurate responses with other languages. [Explore Copilot features by geography and languages](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

## What operational factors and settings allow for effective and responsible use of the feature?

This feature is in preview and only available for environments in the North America and United Kingdom regions. Adminstrators can enable or disable it for a given environment. By default, you only see this feature on the work order form.

## Can I add update fields and forms outside of the new Field Service mobile user experience?

Work order update is limited to fields within the new mobile user interface. Work order update can modify the following fields. The feature doesn't update any fields outside of this experience and doesn't recommend updates for any fields outside of this experience.

- Booking status
- Booking times
- Work order service task completion
- Work order product quantity
- Work order product line status
- Work order service duration
- Work order service line status

Work order update is only available in the booking experience. You can't modify how to access the feature, but admins can disable it for users.

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
