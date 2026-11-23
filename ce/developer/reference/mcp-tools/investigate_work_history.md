---
title: Investigate work history (preview)
description: Review earlier Dynamics 365 Field Service work on an asset or site, recurring issues, and recorded resolutions.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.service: dynamics-365-field-service
ms.custom: mcp-enabled-namespaces=field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# Investigate work history (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Review earlier work on an asset or site to see when it was serviced, whether a problem happened before, and which resolutions were recorded.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- Dynamics 365 Field Service must be installed.
- Your security role must allow you to read work orders, customer assets, and accounts.
- To review last-visit details or linked cases, you also need access to the relevant bookings, product and service lines, notes, and cases. Unavailable sources are identified while the remaining history is shown.

## Try prompts like

- Has this happened before on this unit?
- When was this asset last serviced?
- What usually fixes this problem?
- Is the whole site seeing this issue?
- Who worked the last visit on this unit, and what parts did they use?

## What you can do

1. Start with a work order or name the customer asset. If several records match, choose the correct one before continuing.
2. Ask about the last completed visit, previous occurrences, recorded fixes, or patterns across a site. For an asset-specific issue, use the exact incident type name, or review the suggested matches.
3. Ask for a quick, standard, or deep look back. Depth changes how far back patterns are assessed and how much evidence is gathered; different findings can cover different periods.
4. Review the summary and supporting work history card. Compare the last service visit for any issue with the last completed visit for the same issue.
5. Open supporting work orders, assets, or service accounts in chat to check the evidence.

Expand **Previous occurrences** for completed and still-open work orders for the same issue. When requested, **Last visit details** includes booked technicians, parts used, services performed, and technician notes. **Linked service cases** shows related cases. You can also select **Who worked it**, **Parts used**, or **Services** to ask about the last visit.

## Data changes

Investigating history doesn't create or modify records. Opening supporting records is also read-only. Ask separately if you want to add an observation or update the current job.

## Tips and limitations

- Findings are evidence of patterns, not a diagnosis or proof of root cause. Review the supporting records and any indication of weak or insufficient evidence.
- A completed work order doesn't prove the problem was fixed. Reported outcomes come from the recorded primary resolution.
- Naming an issue for an asset adds issue-specific findings; it doesn't filter every displayed history item. Recent work orders and the last completed visit can include other incident types.
- For site-wide issue patterns, start from a work order. Starting from an asset keeps issue findings on that asset; asking for site history widens only the latest visits.
- Follow-up questions stay with the original work order or asset unless you ask to change it.
- If history is limited, older work orders might exist. For a simple customer-wide list without analysis, ask for customer work orders.

## Related information

- [View a work order](get_work_order.md)
- [List customer work orders](list_customer_work_orders.md)
- [List work order products and services](list_work_order_lines.md)
