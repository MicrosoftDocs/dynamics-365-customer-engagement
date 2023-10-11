---
title: Prioritize segments
description: Learn how to set the priority of your segments to control which one a record is connected to if it matches more than one.
ms.date: 03/28/2023
author: udaykirang
ms.author: udag
ms.topic: how-to
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/09/2023
---

# Prioritize segments

When a record such as a lead or an opportunity is created or updated, it's connected to a segment if it matches the segment's conditions. But a record might meet the criteria of multiple segments. To cover those cases, you can set the priority of your segments. A record that matches more than one segment is connected to the segment that has a higher priority.

You can set the priority of a segment when you create it or later.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [System Administrator, Sales Manager, or Sequence Manager](security-roles-for-sales.md) |

## Set the priority when you create a segment

[Create a segment and set its priority](./create-and-activate-a-segment.md).

## Set the priority of a segment later

When you change the priority of a segment, records that are already connected to it remain connected. The new priority affects only new or updated records.

1. Sign in to your Dynamics 365 Sales Hub app.

1. In the lower-left corner of the page, select **Change area** > **Sales Insights settings**.

1. Under **Sales accelerator**, select **Segments**.

1. Select a **Record type** to change the priority of segments of that type.

1. Change the priority using any of these methods:

    - Hover your pointer over a segment record and use the drag handle (**&vellip;&vellip;**) to drag the segment up or down in the list. The change is saved automatically.
    - Select a segment, select **Change priority**, type the new priority number, and then select **Save**.
    - Open a segment, select **Segment properties**, type the new priority number in **Segment priority**, and then select **Save changes**.

### See also

- [Group records by segment](manage-segments.md)  
- [Create and activate a segment](create-and-activate-a-segment.md)
