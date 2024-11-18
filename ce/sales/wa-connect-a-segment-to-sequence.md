---
title: Connect segments to sequences
description: Learn how to connect a segment to a sequence in Dynamics 365 Sales to automate your sales workflows.
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.topic: how-to 
ms.date: 11/18/2024
ms.custom:
 - ai-gen-docs-bap
 - ai-gen-desc
 - ai-seo-date:10/09/2023
 - bap-template
---

# Connect segments to sequences

After you [create and activate a segment](./create-and-activate-a-segment.md), connect the segment to a sequence. Leads, opportunities, accounts, contacts, and insights that are connected to the segment automatically start the sequence.

You can connect segments to sequences in your work assignment settings or using the [sequence designer](view-sequence-details-connected-records.md).

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/), or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) |
| **Security roles** | [System Administrator, Sequence Manager, or Sales Manager](security-roles-for-sales.md) |

## Prerequisites

- [Sales accelerator is configured for your organization](./enable-configure-sales-accelerator.md).
- [The sequence has been created and activated](./create-and-activate-a-sequence.md).

## Connect a segment to a sequence

1. Sign in to Dynamics 365 Sales Hub.

1. In the lower-left corner of the page, select **Change area** > **Sales Insights settings**.

1. Under **Sales accelerator**, select **Work assignment**.

1. Select a **Record type**.

    The **Sequence connected** column shows *None* if no sequence is connected to the segment.

1. Select a segment that isn't connected to a sequence, and then select **Connect sequence**.

1. Select a sequence, and then select **Connect**.

If none of the sequences listed seems appropriate, [create a sequence](create-and-activate-a-sequence.md) to connect to the segment.

If you want to connect a different sequence to the segment, disconnect the current sequence first.

## Considerations

Remember the following when connecting segments to sequences:

- The application runs on a pooling mechanism and retrieved records are processed at regular intervals. So, there might be a delay in a record being added to a sequence after it meets the segment criteria.  
- Records are segmented only if there is at least one active segment connected to a sequence or an active segment with an active assignment rule.  

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

- [Create and activate segments](wa-create-and-activate-a-segment.md)
- [Edit segments](wa-edit-a-segment.md)
