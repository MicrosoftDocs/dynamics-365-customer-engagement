---
title: Edit segments
description: Learn how to change the conditions that determine which records to include in a segment, its assignment rules, and the sequences that are connected to it.
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

# Edit segments

To change the records that get added to a segment, change the conditions that determine which records to include (its definition). You can also change the segment's priority, the rules that assign the segment to sellers, the order the rules are applied in, and the sequences that are connected to the segment, and view the records that are included in the segment.

[!INCLUDE [sales-work-assignment](../includes/sales-work-assignment.md)]

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [System Administrator or Sequence Manager](security-roles-for-sales.md)|

## Edit a segment

1. Sign in to your Dynamics 365 Sales Hub app.

1. In the lower-left corner of the page, select **Change area** > **Sales Insights settings**.

1. Under **Sales accelerator**, select **Work assignment**.

1. Select a **Record type**, and then open a segment of that type to edit.

1. Change what you need to, and then select **Save**.

You can view or change the following characteristics of a segment:

- Segment:
  - Definition (the conditions that determine which records to include): View and edit
  - Priority (in case a record matches more than one segment): View and edit
- Assignment rules: Add, edit, delete, or change priority
- Attached sequences: View or disconnect
- Segmented records: View

Your changes are applied to records that are connected to the segment going forward. Any records that were previously connected to the segment aren't affected.

> [!NOTE]
> As of the 9.3 release, if you change the attributes of a lead, opportunity, account, or contact, all segments of that record type update automatically.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

- [Create and activate a segment](./create-and-activate-a-segment.md)
- [Prioritize segments](./prioritize-segment.md)

[!INCLUDE[ footer-include](../includes/footer-banner.md)]
