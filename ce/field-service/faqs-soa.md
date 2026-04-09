---
title: Scheduling Operations Agent FAQ (preview)
description: Get answers to common questions about how the Scheduling Operations Agent in Dynamics 365 Field Service helps dispatchers quickly improve the schedule of a single technician.
ms.date: 10/23/2025
ms.update-cycle: 180-days
ms.custom:
  - responsible-ai-faqs
  - ai-gen-docs-bap
  - bap-template
ms.topic: faq
author: andrewclear-ms
ms.author: anclear 
ms.reviewer: puneetsingh
ms.collection: bap-ai-copilot 
---

# Scheduling Operations Agent FAQ (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

The Scheduling Operations Agent is a feature of Dynamics 365 Field Service that helps dispatchers quickly and efficiently improve the schedule of a single technician. This article answers common questions about how the agent works and its limitations.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## What is the Scheduling Operations Agent?

The [Scheduling Operations Agent](soa-overview.md) in Dynamics 365 Field Service makes it easy for dispatchers to optimize the schedules of individual technicians throughout the workday. Traffic delays, double bookings, or last-minute cancellations often result in conflicts or gaps in a technician's schedule. Instead of manually adjusting the bookings one by one, the dispatcher can use natural language to ask the agent to suggest an improved schedule.

## What are the agent's capabilities?

The dispatcher launches the agent by typing a prompt, such as "Suggest a schedule," in the Copilot side pane. If the prompt is related to scheduling, the agent presents [settings](soa-run.md#adjust-the-settings-for-optimization-requests) that the dispatcher can adjust to influence the agent's suggested schedule. After the dispatcher selects **Suggest schedule**, the agent examines the existing bookings on the selected technician's schedule, unfulfilled requirements that match the schedule suggestion settings, and relevant characteristics of the technician, such as working hours and skills, to suggest a new schedule that achieves the selected scheduling goal. The agent displays the original and suggested schedule for the dispatcher to review, and provides options to accept the modified schedule or discard it and try again with other settings.

## What's the agent's intended use?

Dispatchers use the agent to quickly optimize the schedule of a single technician, view the agent's suggested schedule, and apply or cancel the suggestion.

## How was the agent tested and what metrics are used to measure its performance?

We tested the agent's ability to determine that the prompt is related to scheduling, in English. The optimization algorithms the agent uses to suggest a new schedule are language-agnostic; however, not all languages are supported. Check the list of supported languages in [Explore Copilot features by geography and languages](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

To check the agent's ability to suggest an improved schedule, we used metrics similar to the ones we used to evaluate the [Resource Scheduling Optimization add-in](rso-overview.md).

In our testing, the agent always suggested a schedule that was better than the original schedule. However, we did find some cases where the agent didn't detect that the prompt was related to scheduling.

## What are the limitations of the agent and how can I minimize their impact?

The agent's known limitations are listed in [Improve the Scheduling Operations Agent's suggestions](soa-tips.md#limitations-and-known-issues). The Scheduling Operations Agent is still in preview, and we're working on improving it. You can help us by giving feedback through the like or dislike buttons on the agent's suggested schedule. We use this data to evaluate and improve the quality of the agent.

The agent only works online. You can't use it when you're offline.

## What operational factors and settings allow for effective and responsible use of the agent?

Administrators can turn the feature on or off for an environment. Learn more in [Set up the Scheduling Operations Agent](soa-setup.md#turn-on-the-scheduling-operations-agent). The agent doesn't collect any customer data when you use it.

## Related information

- [Responsible AI FAQ for Dynamics 365 Field Service](responsible-ai-overview.md)

[!INCLUDE [footer-include](../includes/footer-banner.md)]
