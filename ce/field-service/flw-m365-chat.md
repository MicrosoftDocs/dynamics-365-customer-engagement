---
title: Dynamics 365 Field Service Plugin for Microsoft Copilot (preview)
description: Learn about the Dynamics 365 Field Service Plugin for Microsoft Copilot including the types of questions you can ask.
ms.date: 11/28/2023
ms.topic: overview
author: KishorIoT
ms.author: nandab
ms.reviewer: v-wendysmith
ms.custom: bap-template
ms.subservice: m365-integrations
---

# Dynamics 365 Field Service Plugin for Microsoft Copilot (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

With the Dynamics 365 Field Service Plugin for Microsoft Copilot, Dynamics 365 Field Service frontline managers and workers can access key work order information by asking Microsoft Copilot questions within Microsoft Teams. Users with a Microsoft 365 Copilot license can simply state in chat what they need using natural language to receive specific information related to their work orders in Field Service.

This feature adheres to [responsible AI guidelines](faqs-m365-chat.md).

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Scenarios that are available out-of-the-box

Ask any straight-forward question about Field Service work orders. Ambiguous questions such as “What are the most important work orders” might not return results.

Be specific about the expected outcomes. For example, if you want results in table format, then use the phrase "in table format." If you want a consolidated result or summary, be specific. For example, "What is the incident type and service account for work order 00041?"

### Example questions

- What are the details for a particular work order? Can you summarize?
- Can you give me details on several work orders in a table format?
- What is the incident type and service account of several work orders in table format?
- What is the status of a particular work order?
- Who is the technician for a work order? or What is the work order assigned to technician {email_address}?
- Show me work orders created in October for customer {name}.
- What is the progress of a work order?
- What type of work order is work order {work order number}, so I can assign the right technician?
- Show me bookings for next week in a table format.
- Show me high priority work orders created in November.
- Does customer {name} have any emergency priority work orders?

<!--- Additional questions 
- what are the 3 most recently created work orders
- give me the full details for the most recent work orders
- what are the most recently created work orders?
- Show me a table of the most recent high priority work orders
- Are there any work orders with priority set to high?
- Tell me more about the primary incident type of work order 00003.What is the work order assigned to this account?
- Show work orders that are scheduled for next week in a table format
- Show me a table of work orders created in the last three days
--->

## Set up Microsoft Copilot for Field Service work orders (admin)

As an admin, set up Microsoft Copilot for Field Service work orders for your users.

1. Log into the [Microsoft 365 admin center](https://admin.microsoft.com/).

1. Obtain the appropriate number of [Microsoft 365 Copilot licenses.](/microsoft-365-copilot/microsoft-365-copilot-setup#manage-licenses-for-copilot)

1. [Set up the plugin](/power-virtual-agents/copilot-plugins-overview#use-plugins-in-microsoft-copilot).

1. [Consent to moving data across regions.](/power-platform/admin/geographical-availability-copilot#enable-data-movement-across-regions) For more information, see [How data movement across regions works.](/power-platform/admin/geographical-availability-copilot#how-data-movement-across-regions-works)

## Enable the Microsoft Copilot for Field Service work orders

Once an admin sets up the Microsoft Copilot for Field Service work orders, any user can quickly enable the plugin in Teams.

1. At the bottom of your Teams window, select the **Plugin** :::image type="icon" source="media/fsp-plugin-icon.png"::: icon.

1. Enable the Field Service Plugin for Microsoft Copilot.

The Microsoft Copilot for Field Service work orders is available.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
