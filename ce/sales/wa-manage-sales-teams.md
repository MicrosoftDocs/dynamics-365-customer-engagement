---
title: Select security roles to assign records to
description: Learn how to select the security roles that determine whether assignment rules can automatically assign your sales team to leads, opportunities, and insights in Dynamics 365 Sales.
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.topic: how-to
ms.date: 06/17/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/16/2023
---

# Select security roles to assign records to

Before an assignment rule can assign your sellers and sales teams new opportunities, leads, and insights, you need to select the security roles that can be automatically assigned to records. Then, make sure your sellers are given one of those roles.

[!INCLUDE [sales-work-assignment](../includes/sales-work-assignment.md)]

## Select security roles

1. Sign in to your Sales Hub app.

1. In the lower-left corner of the page, select **Change area** > **Sales Insights settings**.

1. Under **Sales accelerator**, select **Work assignment**.

1. Select **Settings**.

1. In the **Eligible security roles** section, select **Manage**.

1. Select one of the following options to grant permissions to your sales team:

    - **All security roles**: Allows all the security roles in your organization to automatically receive lead, opportunity, and insight assignments.
    - **Specific security roles**: Allows only the security roles that you select to automatically receive lead, opportunity, and insight assignments.

1. Select **Save**.

## Permissions required

The following permissions are required to perform tasks on work assignment entities. Make sure security roles are configured to grant the required permissions.

- **Task**  
  - Entity: Permissions

### Seller attributes

- **Create, modify, delete seller attributes**
  - Attribute: Read, Create, Write, Delete, Append To
  - Attribute Value: Read, Create, Write, Delete, Append
- **Apply attributes to sellers**
  - Attribute: Read
  - Attribute Value, User: Read, Append, Append To
- **View seller attributes**
  - Attribute, Attribute Value: Read

### Seller capacity

- **Update seller capacity**
  - Assignment Map: Read, Write
  - User: Read
- **View seller capacity**
  - Assignment Map, User: Read

### Records

- **Assign unassigned records in the **Monitor *record type*** tab**
  - Sales Routing Run, Segment, Team, User: Read  
    **Note**: Before a record can be assigned to a seller, the seller must have privileges on it.

### Sequences

- **Create sequences**
  - Segment: Read, Write, Append
  - Sequence: Read, Write, Create, Append, Append To
  - Sequence Stat, Sequence Target Step: Read
  - Sequence Template: Append To
- **Connect, disconnect sequences and segments**
  - Segment: Read, Write, Append
  - Sequence: Read, Write, Create, Append, Append To
  - Sequence Stat, Sequence Target Step: Read
  - Sequence Template: Append To
- **View sequences connected to segments**
  - Segment, Sequence, Sequence Stat, Sequence Target Step, and Sequence Template: Read

### Segments

- **Create, modify, delete segments**
  - Segment: Read, Write, Create, Delete
- **View segments**
  - Segment: Read
- **Copy segment**
  - Segment: Read, Write, Create
  - Assignment Rule: Read, write, and Create
    >[!NOTE]
    >Assignment rules permissions are required only when assignment rule is selected for migration.
  
### Assignment rules

- **Create, modify, delete assignment rules**
  - Assignment Rule: Read, Create, Write, Delete, Append
  - Attribute, Attribute Value, Security Role, Team, User: Read
  - Segment: Read, Append To
- **View assignment rules**
  - Assignment Rule, Attribute, Attribute Value, Segment, Team, and User: Read

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

- [Set seller attributes](./wa-manage-seller-attributes.md)
- [Set seller availability and capacity](./wa-manage-seller-availability.md)
- [Create and activate assignment rules](wa-create-and-activate-assignment-rule.md)
