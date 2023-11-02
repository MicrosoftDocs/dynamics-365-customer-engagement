---
title: 
description: Get answers to common questions about how the AI-powered work order update feature in the Dynamics 365 Field Service mobile app helps you quickly update details of a work order.
ms.date: 11/02/2023
ms.custom:
  - responsible-ai-faqs
  - bap-template
ms.topic: faq
author: m-hartmann
ms.author: mhart
ms.reviewer: 
---

# FAQs for work order update (preview) 

These FAQs describe the AI impact of the Dynamics 365 Field Service work order update (preview) feature.

## What is work order update with Copilot?

Work order update allows a frontline workers using the mobile application to describe work performed in natural language. This description of work is used by Copilot to recommend updates to fields within the new Field Service Mobile user experience. 
This feature removes the need to click through forms and fields to locate correct fields to update, saving the frontline worker time within the app experience.

## What are the feature’s capabilities?

Based on user input, the feature will recommend fields to update in the mobile application. The frontline worker will see a view of all recommended updates which they review and confirm before updates are made in the application.

## What is the feature’s intended use?

A typical workflow for the frontline worker involves updating data fields within forms to show progress of a booking, times work was started and completed, and work tasks performed. This feature assists the frontline worker with those field updates on a connected mobile device. 

## What are the limitations of work order update with copilot? How can users minimize the impact of the limitations when using the system?

- This feature is currently in preview.
  - Users are encouraged to provide feedback on the quality of the content using the like/dislike icons within the feature's control. We use this data to evaluate and improve the quality of the capability.
- This feature is available only within the new field service mobile user experience.
- This feature has a predefined schema of available fields which can be updated. These fields are limited to the fields available within the out of the box user interface. 
- This feature is intended for use online. It's not available while users are offline.
- This feature was evaluated using English. If used in environments where languages other than English are used, the quality of the responses hasn't yet been evaluated. Inaccurate responses may be returned when users converse with the system in languages other than English.

## What operational factors and settings allow for effective and responsible use of the feature?

- While this feature is in preview and only available for environments within the NAM and GBR regions, the feature can be enabled or disabled for a given environment by an administrator through the Field Service Mobile Settings, Work Order Update (Preview) toggle. When disabled, the Work Order Update entry point control is hidden from the Work order form (preview). This feature is only available, out of the box, on the Work order form.
Can I add update fields and forms outside of the new Field Service Mobile user experience?
- While in preview work order update is limited to only updating fields within the new mobile user interface. Work order update can modify the following fields. The feature will not update any fields outside of this experience and will not recommend updates for any fields outside of this experience.
- Booking status
- Booking times
- Work order service task completion
- Work order product quantity
- Work order product line status
- Work order service duration
- Work order service line status
- The entry point for Work Order update is only available within the Booking experience via common access point in the header. The entry point cannot be modified but it can be hidden with an admin configuration.
