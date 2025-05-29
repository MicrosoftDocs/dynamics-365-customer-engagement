---
title: FAQs for work order update (preview)
description: Get answers to common questions about how the AI-powered work order update feature in the Dynamics 365 Field Service mobile app helps you quickly update details of a work order.
ms.date: 11/12/2024
ms.custom:
  - responsible-ai-faqs
  - bap-template
ms.topic: faq
author: JonBaker007
ms.author: jobaker
ms.reviewer: mhart
ms.collection: bap-ai-copilot 
---

# FAQs for work order update (preview)

These FAQs describe the AI impact of the Dynamics 365 Field Service work order update (preview) feature.

## What is work order update with Copilot?

Work order update allows frontline workers to describe work performed in natural language on their mobile device. This description of work is used by Copilot to recommend updates to fields in the new Field Service Mobile user experience. This feature reduces the effort of manually going through forms and fields to update them and saves the frontline worker time within the app experience.

## What are the feature's capabilities?

Based on user input, the feature recommends fields to update in the mobile application. The frontline worker gets suggestions for all recommended updates, which they review and confirm before updates are made to the record.

## What is the feature's intended use?

A typical workflow for the frontline worker involves updating data fields within forms to track the progress of a booking. They record start and end times of the work and log the work tasks performed. This feature assists the frontline worker with those updates on a mobile device with internet connection.

## What are the limitations of work order update with Copilot? How can users minimize the impact of the limitations when using the system?

- This feature is currently in preview. Share your feedback on the quality of the content using the like and dislike icons in the feature's control. We use this data to evaluate and improve the quality of the capability.
- It's available only in the new field service mobile user experience.
- Copilot can only update the fields of a predefined schema.
- This feature requires an active internet connection. It's not available while users are offline.
- We evaluated the feature in English only. You can get inaccurate responses with other languages. [Explore Copilot features by geography and languages](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

## What operational factors and settings allow for effective and responsible use of the feature?

While this feature is in preview and only available for environments within the North America and United Kingdom regions, administrators can enable or disable it for a given environment.  This feature is only available, out of the box, on the work order form.

## Can I add update fields and forms outside of the new Field Service mobile user experience?

Work order update is limited to fields within the new mobile user interface. Work order update can modify the following fields. The feature doesn't update any fields outside of this experience and doesn't recommend updates for any fields outside of this experience.

- Booking status
- Booking times
- Work order service task completion
- Work order product quantity
- Work order product line status
- Work order service duration
- Work order service line status

Work order update is only available within the booking experience. You can't modify how to access the feature but admins can disable it for their users.

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
