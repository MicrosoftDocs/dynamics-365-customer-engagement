---
title: Connect segments to sequences
description: Learn how to connect a segment to a sequence in Dynamics 365 Sales to automate your sales workflows.
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.topic: how-to 
ms.date: 04/30/2026
ms.custom:
 - ai-gen-docs-bap
 - ai-gen-desc
 - ai-seo-date:10/09/2023
 - bap-template
---

# Connect segments to sequences

After you [create and activate a segment](./create-and-activate-a-segment.md), connect the segment to a sequence. When you connect the segment, leads, opportunities, accounts, contacts, and insights automatically start the sequence.

You can connect segments to sequences in your work assignment settings or by using the [sequence designer](view-sequence-details-connected-records.md).

## Prerequisites

- [Sales accelerator is configured for your organization](./enable-configure-sales-accelerator.md).
- [The sequence is created and activated](./create-and-activate-a-sequence.md).

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

Keep the following considerations in mind when you're connecting segments to sequences:

- The application runs on a pooling mechanism and retrieves records that it processes at regular intervals. There might be a delay between when a record meets the segment criteria and when it's added to a sequence.  
- The system segments records only if at least one active segment is connected to a sequence or at least one active segment has an active assignment rule.  

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

- [Create and activate segments](wa-create-and-activate-a-segment.md)
- [Edit segments](wa-edit-a-segment.md)
