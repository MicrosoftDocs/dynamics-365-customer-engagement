---
title: Schedule meeting
description: Learn how to use the Schedule meeting capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Schedule meeting

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller needs to schedule a meeting with buyers or stakeholders.

## What it does

The assistant creates a Dynamics 365 appointment for a meeting, optionally with required attendees and set regarding an opportunity, account, or lead, and returns a text response with structured content for agent orchestration.

## Try prompts like

- Schedule a solution review with the buying group next Tuesday.
- Set up a 30-minute discovery call about this opportunity.
- Book a meeting with these stakeholders on Thursday afternoon.
- Create an appointment for the account review.

## What you'll see in chat

The assistant displays a text response directly in chat. The assistant doesn't display an interactive app-in-chat component for this capability.

## Helpful tips

- Resolve attendee and record names to their GUIDs before calling this tool.
- Provide start and end times as ISO 8601 date-times with an explicit timezone offset (for example, `2026-07-20T15:00:00Z` or `2026-07-20T15:00:00+05:30`); the end must be after the start.
- This tool creates the appointment directly; use `send_email` for buyer outreach.

## What happens next

After the response appears, you can continue with prompts like:

- Draft an invitation email for this meeting.
- Show the stakeholders on this opportunity.
- Open this opportunity.
- Add a note about the meeting.

## Does this change data?

**Yes, schedule_meeting changes data.**

This tool creates an appointment activity in Dynamics 365. Confirm the subject, times, and attendees before running it.

## Prerequisites

This tool requires create access to Dynamics 365 appointments, plus append access to the regarding record and attendee contacts, for the selected environment.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Schedule meeting |
| Internal tool name | `schedule_meeting` |
| Purpose | creates an appointment to meet with buyers or stakeholders. |

## Tool behavior

The tool creates an `appointment` activity with the supplied subject, start, and end times. Required attendees are attached as activity parties, and the appointment can be set regarding an opportunity, account, or lead so it appears on that record's timeline. It is text-only and returns structured content for the requested Sales operation.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | Not set | This tool modifies data. |
| `destructiveHint` | `false` | Creates an appointment; doesn't delete records. |
| `idempotentHint` | `false` | Each call creates a new appointment. |
| `openWorldHint` | Not set | Uses default (writes to Dataverse). |

## Input concepts

### Sales context

| Input | Description | Required |
|---|---|---|
| `subject` | Meeting subject or title. | Yes |
| `scheduledStart` | Meeting start as an ISO 8601 date-time with an explicit timezone offset (for example, `2026-07-20T15:00:00Z`). | Yes |
| `scheduledEnd` | Meeting end as an ISO 8601 date-time with an explicit timezone offset; must be after the start. | Yes |
| `description` | Agenda or notes for the meeting body. | No |
| `location` | Meeting location or online link text. | No |
| `regardingId` | GUID of the opportunity, account, or lead the meeting is about. | No |
| `regardingType` | Entity type for `regardingId`: opportunity (default), account, or lead. | No |
| `requiredAttendees` | Contact GUIDs to invite as required attendees. | No |

## Response and UI behavior

This tool returns a text-only response with no app-in-chat component.

This MCP tool is supported by an MCP app.

### Response type

Text narrative

The response includes structured content for the requested sales operation.

## Routing notes

Use `schedule_meeting` when the user asks to book, set up, or schedule a meeting with buyers or stakeholders. Don't use `schedule_meeting` to send an email (use `send_email`) or to log an activity that already happened (use `create_activity`).

## Related tools

| Tool | Relationship |
|---|---|
| [`get_stakeholder`](get_stakeholder.md) | Lists the stakeholders to invite |
| [`send_email`](send_email.md) | Sends buyer outreach or a meeting invitation |
| [`create_activity`](create_activity.md) | Logs an activity such as a completed call |

## Data mutation classification

Write—creates an appointment activity.
