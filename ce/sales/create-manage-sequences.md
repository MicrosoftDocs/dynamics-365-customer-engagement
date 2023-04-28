---
title: Create scheduled and conditional workflows with sequences
description: "Manage sequences in sales accelerator by creating, activating, connecting, viewing details, cloning, editing, and deleting."
ms.date: 09/02/2022
ms.topic: article
author: udaykirang
ms.author: udag
---
# Create scheduled and conditional workflows with sequences

Sequences help sales managers enforce best practices by introducing a set of consecutive activities for sellers to follow during the course of their day. A manager can connect sequences to leads and opportunities that appear in a seller's work queue, to help sellers prioritize activities to focus on selling, be more productive, and better align to business processes.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise, Dynamics 365 Sales Premium, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator, Sequence manager, or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Permission requirements to manage sequences

The following table shows the permissions required for a user role to perform tasks on sequences.

>[!NOTE]
>By default, these permissions are available for System Administrator, Sequence manager, Sales Manager, and Salesperson security roles.

| Task related to sequence | Permissions required |
|--------------------------|----------------------|
| Create, edit, and delete | In the Security roles page, under the **Custom Entities** tab, provide Create, Read, Write, and Delete permissions for **Sequence** entity. More information: [Security roles and privileges](/power-platform/admin/security-roles-privileges) | 
| Connect and disconnect| In the security roles page, under the **Custom Entities** tab, provide permissions for following entities: <br>- **Sequence**: Create and Append To<br>- **Sequence Target**: Create, Read, Write, Append, Append To, and Assign<br>- **Sequence Target Step**: Create, Read, Write, Append, and Assign<br>More information: [Security roles and privileges](/power-platform/admin/security-roles-privileges) |

## Use sequence designer

>[!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RE4Vdof]

You can use the sequence designer to do the following tasks:  
- [Create and activate a sequence](create-and-activate-a-sequence.md).
- [Connect a sequence to records](connect-a-sequence-to-records.md).
- [View details of a sequence and its connected records](view-sequence-details-connected-records.md).
- [Clone and edit a sequence](edit-a-sequence.md).
- [Delete a sequence](delete-a-sequence.md).

## Review prerequisite

Before you start, be sure you that the sales accelerator feature is configured in your organization. More information: [Configure the sales accelerator](enable-configure-sales-accelerator.md).

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]    

<table>
<tr><td>

> [!div class="nextstepaction"] 
> [Next step: Create and activate a sequence](create-and-activate-a-sequence.md)
</td></tr>
</table>   


### See also

[Configure the sales accelerator](enable-configure-sales-accelerator.md)  
[Prioritize your sales pipeline by using the work list](prioritize-sales-pipeline-through-work-list.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
