---
title: Work assignment
description: Work assignment helps in creating segments to group records and prioritize them as per your sales strategy. 
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: overview 
ms.collection: get-started 
ms.date: 08/25/2023
ms.custom: bap-template 
---

# Work assignment

Work assignment helps in creating [segments](#what-are-segments) to group records and prioritize them as per your sales strategy. Further, you can create a set of rules ([assignment rules](#what-are-assignment-rules)) to automatically assign records to sellers and connect records to sequences to guide sellers with their next steps. 

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator, Sequence Manager, or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Review prerequisites  

Before you start, be sure that the sales accelerator is configured in your organization. More information: [Configure the sales accelerator](enable-configure-sales-accelerator.md)

## What are segments?

Segments help you to categorize records based on specific criteria such as location, deal value, language, and product. By using segments, you can automatically connect records to sequences and create assignment rules to automatically assign sellers to records. You can create segments for all entities, including custom entities.

You can use the segment builder to:

- [Create and activate segments](wa-create-and-activate-a-segment.md).
- [Manage assignment rules](#what-are-assignment-rules).
- [Connect a segment to a sequence](wa-connect-a-segment-to-sequence.md).
- [View and edit properties of a segment](wa-view-details-segment.md).
- [Edit a segment](wa-edit-a-segment.md)
- [Prioritize a segment](prioritize-segment.md).
- [Delete or deactivate a segment](wa-delete-deactivate-a-segment.md).

## What are assignment rules?

Assignment rules enable new leads, opportunities, and seller insights to be automatically assigned to sellers or sales teams. This helps reduce the amount of time and effort required to manually assign records, prevent the loss of unassigned records, and balance assignments among sellers.

Assignment rules are supported for lead, opportunity, and suggestions record types.

>[!NOTE]
>For more information about seller insights, see [Get seller insights to improve seller effectiveness](seller-insights-intro.md)

>[!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RE4VjOo]

You can create rules that match attributes (such as location and language) with seller or team attributes (such as location and language). For example, when a lead is created and satisfies the conditions of a specific rule, the lead is automatically assigned to a seller.

You can use the assignment rules designer to do the following tasks:

- [Create and activate assignment rules](wa-create-and-activate-assignment-rule.md).
- [Edit an assignment rule](wa-edit-assignment-rule.md).
- [Change priority of an assignment rule](wa-change-priority-assignment-rule.md).
- [Delete or deactivate an assignment rule](wa-delete-deactivate-assignment-rule.md). 

## Permissions required 

The following permissions are required to perform tasks in the work assignment feature.

| Task | Entity name | Privileges required |
|------|-------------|---------------------|  
| Apply seller attributes to sellers | Attribute | Read |
| | Attribute Value | Read, Append, and Append To |
| | User | Read, Append, and Append To |
| Assign unassigned records from monitor tab | Sales routing run, Segment, Team, and User | Read |
|| | **Note**: To assign record to a seller you must assign privileges on that record. |
| Create, connect, disconnect sequence to segment | Segment | Read, Write, and Append |
|| Sequence | Read, Write, Create,  Append, and Append to |
|| Sequence Stat and Sequence Target Step | Read |
|| Sequence Template | Append To |
| Create, modify, or delete assignment rules | Assignment Rule | Read, Create, Write, Delete, and Append |
|| Attribute, Attribute Value, Team, and User | Read |
|| Segment | Read and Append To |
| Create, modify, or delete segments | Segment | Read, Create, Write, and Delete |
| Create, modify, or delete seller attributes | Attribute | Read, Create, Write, Delete, and Append To |
|| Attribute Value | Read, Create, Write, Delete, and Append |
| View assigned or unassigned records in monitor tab | Sales routing run and Segment | Read |
| View assignment rules | Assignment Rule, Attribute, Attribute Value, Segment, Team, and User | Read |
| View segments | Segment | Read |
| View seller attributes | Attribute and Attribute Value | Read |
| View seller capacity | Assignment Map and User | Read |
| View sequences connected to segment | Segment, Sequence, Sequence Stat, Sequence Target Step, and Sequence Template | Read |
| Update seller capacity | Assignment Map | Read and Write |
| | User | Read |


[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]    

