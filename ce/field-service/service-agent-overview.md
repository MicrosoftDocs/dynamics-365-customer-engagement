---
title: Field Service capabilities in Service Agent (preview)
description: Learn how Service Agent helps technicians, dispatchers, and service managers work with Dynamics 365 Field Service through conversation.
ms.date: 11/23/2026
ms.topic: overview
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
ms.collection: bap-ai-copilot
ai-usage: ai-generated
---

# Field Service capabilities in Service Agent (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Service Agent helps technicians, dispatchers, and service managers work with Dynamics 365 Field Service through conversation. You can review your schedule, prepare for a job, record completed work, and coordinate service visits without opening each record separately.

Field Service and Customer Service capabilities use the same Service Agent. You can work through a technician's day or connect a customer service request to an onsite visit.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

<!-- DRAFT REVIEW: Confirm the licensing, supported clients, regions, languages, and customer support route before publishing this article. Don't infer Field Service availability from Customer Service availability. -->

## What you can do

Early scenarios focus on technicians, with related capabilities for dispatchers and service managers:

- **Plan your day:** Review active and upcoming bookings and open the recommended next job.
- **Prepare for a job:** Review the work order, customer and asset history, service tasks, and parts.
- **Record progress:** Describe completed work, review suggested updates to notes, tasks, parts, and statuses, and confirm the changes you want to apply.
- **Coordinate visits:** Find resource availability, book a selected time, or create a work order from an eligible case.
- **Review service history:** Look at earlier work orders and recurring issues for an asset or customer.

These workflows help reduce repetitive entry and keep job information available as work moves between team members.

## Get started

[Request public preview access](service-agent-preview.md) for the environments you want to use. Submitting the form doesn't immediately enable access. After you receive an enablement email, follow its access instructions and connect to the correct environment.

To find your own schedule, your user must be linked to one active bookable resource. Ask your administrator to check the link if Service Agent can't find your bookings. Learn more in [Plan your work day](../developer/reference/mcp-tools/plan_work_day.md).

Try a request such as:

- What's on my plate today?
- Show me the work order for my next job.
- Show the service tasks on this work order.
- Has this asset had this problem before?

For example, start with your day plan, open the next job, and review its tasks and history before you arrive.

## Review and save changes

Reviewing your schedule or opening a work order doesn't update business records.

When you describe work completed, Service Agent saves a temporary change plan for review. Check the suggested changes, answer any questions, and confirm which changes to apply. Preparing the plan doesn't update the work order, booking, tasks, parts, or notes.

Other actions have their own save or confirmation steps. Follow the instructions shown for the action you're taking.

## Availability and permissions

Available capabilities depend on your environment, configuration, and permissions. Service Agent uses your existing access to Field Service data.

Preview enrollment doesn't enable offline use or every Field Service client. Use the access instructions provided when your environment is enabled.

Administrators should review custom layouts and validation for the agent experience. See [Configure Service Agent capabilities for Field Service](configure-service-agent.md).

## Next steps

- [Request public preview access](service-agent-preview.md).
- [How MCP tools support Field Service scenarios](service-agent-mcp-tools-overview.md).
- [Configure Service Agent capabilities for Field Service](configure-service-agent.md).
- [Overview of Service Agent](../customer-service/use/service-agent-overview.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
