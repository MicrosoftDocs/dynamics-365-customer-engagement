---
title: Connect segments to sequences
description: Learn how to connect a segment to a sequence in Dynamics 365 Sales Hub to automate your sales workflows.
ms.date: 10/11/2023
ms.topic: how-to
author: udaykirang
ms.author: udag
ms.custom:
 - ai-gen-docs-bap
 - ai-gen-desc
 - ai-seo-date:10/09/2023
 - bap-template
---

# Connect segments to sequences

After you [create and activate a segment](./create-and-activate-a-segment.md), connect the segment to a sequence. Leads, opportunities, accounts, or contacts that are in the segment automatically start the sequence.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [System Administrator or Sequence Manager](security-roles-for-sales.md)|

## Prerequisites

- [Sales accelerator is configured for your organization](./enable-configure-sales-accelerator.md).
- [The sequence has been created and activated](./create-and-activate-a-sequence.md).

## Connect a segment to a sequence

This example uses lead records, but the process is the same for opportunity, account, and contact records.

1. Sign in to Dynamics 365 Sales Hub.

1. In the lower-left corner of the page, select **Change area** > **Sales Insights settings**.

1. Under **Sales accelerator**, select **Sequences**.

1. Select and open a lead sequence.

1. Select the **Connected leads** tab.

1. In the **Connected segments** section, select **+ Connect segments**.

    Available segments are listed in the **Connect segments** window.

1. Select the segment or segments you want to connect to the sequence, and then select **Connect**.

    :::image type="content" source="./media/sa-segment-connect-selected-segments-added.png" alt-text="Screenshot of a segment connected to a sequence.":::

1. Open the segment and select the leads you want to connect to this sequence.

If the segment doesn't contain any records, you can still connect individual leads. Select **Connect leads** and select the leads you want to connect to this sequence.

## Disconnect a segment from a sequence

On the **Connected leads** tab, select the segment, and then select **Disconnect**.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

- [View details of a segment](./view-details-segment.md)
- [Prioritize a segment](./prioritize-segment.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
