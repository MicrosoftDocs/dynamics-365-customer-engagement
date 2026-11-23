---
title: Prepare a work order from a case (preview)
description: Review a proposed Dynamics 365 Field Service work order built from a Customer Service case before anything is created.
ms.date: 11/23/2026
ms.topic: reference
ai-usage: ai-assisted
ms.service: dynamics-365-field-service
ms.custom: mcp-enabled-namespaces=field-service
author: jasonccohen
ms.author: jacoh
ms.reviewer: puneetsingh
---

# Prepare a work order from a case (preview)

[!INCLUDE [public-preview-banner](../../../includes/public-preview-banner.md)]

**Applies to:** Dynamics 365 Field Service

Review a proposed Field Service work order built from a Customer Service case. Check the customer, issue, and service details before you decide to create it.

[!INCLUDE [public-preview-note](../../../includes/public-preview-note.md)]

## Prerequisites

- Dynamics 365 Field Service must be installed, and the source must be a Customer Service case.
- Your security role must allow you to read cases, work orders, accounts, incident types, work order types, price lists, customer assets, and functional locations.
- Choose an incident type that has a default work order type. Creating the work order later also requires permission to create work orders.

## Try prompts like

- Convert case CAS-01234 to a work order.
- Turn this case into a work order.
- Raise a work order for the Contoso chiller outage case.
- Convert this case using the Preventive maintenance incident type.
- Show me what the work order would look like for case CAS-01234.

## What you can do

1. Identify the case by its number or title. If several cases match, provide a more specific reference.
2. Review the source case beside the proposed work order. Check the incident type, work order type, service account, price list, customer asset, and functional location.
3. Expand **Populated fields** to see where each proposed value came from. Check values marked **AI-suggested** rather than treating them as confirmed case facts.
4. Choose or change the incident type. Its default work order type is shown read-only.
5. Search for and choose a functional location, or clear it. Choose a service account when the work order type requires one. A contact from the case is shown for reference, not as a substitute for a required service account.

Use **Open case** if you need to check the original case in Dynamics 365.

## Save and confirm changes

Preparing the form doesn't create or modify records. Changing proposed values in the form doesn't create a work order.

After review, select **Create work order** or confirm the reviewed values in chat to create it in a separate step. If the case already has a related work order, review the warning before choosing **Create another work order**. Select **Cancel** to stop, or **Review again** to return to the warning.

## Tips and limitations

- An incident type is always required. Other requirements, including the service account, depend on the work order type and your environment.
- If a named service account or functional location can't be found, choose one instead of assuming the case's value was used.
- Check warnings about incomplete lists when choosing incident types.
- Conversion doesn't schedule a technician. Find a booking slot after creating the work order.

## Related information

- [Convert a case to a work order](convert_case_to_work_order.md)
- [View a work order](get_work_order.md)
- [Update a work order](update_work_order.md)
- [Find available booking slots](search_resource_availability.md)
