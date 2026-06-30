---
title: Scheduling Operations Agent limits and troubleshooting (preview)
description: Review the optimization limits, errors, and known issues for the Scheduling Operations Agent in Dynamics 365 Field Service, and learn how to resolve them.
ms.date: 06/30/2026
ms.topic: troubleshooting-general
ms.collection: bap-ai-copilot
ms.author: anclear
author: andrewclear-ms
ai-usage: ai-assisted
---

# Scheduling Operations Agent limits and troubleshooting (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

This article describes the size and scale limits for the Scheduling Operations Agent in Dynamics 365 Field Service, the errors and warnings that you might encounter, and the agent's known issues.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Optimization limits

During preview, the following limits apply to each optimization. The agent applies these limits after it determines which resources and jobs are eligible. These limits might change as the feature evolves.

### Interactive optimizations

| Limit | Value |
| --- | --- |
| Resources | Up to 5. A resource with a capacity greater than 1 counts as one resource for each capacity point. |
| Optimization window | Any 72-hour window in the future. |
| Jobs (existing bookings and open requirements) | Up to 120. |

### Batch optimizations

| Limit | Value |
| --- | --- |
| Resources | Up to 50. |
| Jobs (existing bookings and open requirements) | Up to 4,000. |
| Bookings per resource | Up to 2,000. |
| Optimization range | Up to 14 days. |

When an optimization has more resources or jobs than the limit allows, the agent keeps the most relevant records and drops the rest. It keeps existing bookings first, and then adds open requirements. If the existing bookings alone exceed the jobs limit, the optimization fails. Always keep your optimizations as tightly scoped as possible. Learn more in [Errors and warnings](#errors-and-warnings).

## Errors and warnings

The following table lists the errors and warnings that you might encounter when you use the Scheduling Operations Agent, along with their causes and the actions you can take to resolve them.

| Message or behavior | Cause | What to do |
| --- | --- | --- |
| Some records were truncated | The optimization included more resources or open requirements than the limit allows, so the agent dropped some of them. | Reduce the scope of the optimization so that the most important records are included. |
| The optimization can't run because there are too many bookings | The existing bookings alone exceed the jobs limit. | Reduce the number of existing bookings in the optimization, or shorten the time range. |
| The time range doesn't overlap the resource's working hours | The selected time range and time zone don't overlap the resource's working hours. | Adjust the time range or time zone so that it overlaps the resource's working hours. |
| A booking doesn't have a parent requirement | The optimization includes a booking that was created without a resource requirement. | Make sure that every booking in the optimization has a parent resource requirement. |
| A record has invalid data | A record has invalid data, such as an invalid location or duration. | Fix the data on the affected record, and then run the optimization again. |
| The schedule changed since the optimization ran | When you apply a reviewed result, the agent detects that bookings or requirements moved, were deleted, or changed status since the optimization ran. | Choose to apply the result anyway, run the optimization again, or cancel. Some changes, such as a booking that was deleted or locked, aren't applied even if you continue. |
| The result expired | You tried to apply a result that's more than 72 hours old or past the start of its time range. | Run the optimization again to get a current result. |

## Known issues and limitations

The Scheduling Operations Agent has the following limitations:

- It doesn't support resources of type **Crew**, **Equipment**, **Pool**, and **Facility**.

- It doesn't support requirement groups or multiday requirements (requirements that are related to requirement detail records).

- A resource can have up to three breaks per work day or shift. With four or more breaks, the agent returns an error.

- The agent doesn't consider a requirement's fulfillment preferences.

- The agent doesn't support fields that are specific to Resource Scheduling Optimization (RSO).

## Next steps

- [Improve optimization results (preview)](soa-improve-results.md)
- [Scheduling Operations Agent FAQ (preview)](faqs-soa.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
