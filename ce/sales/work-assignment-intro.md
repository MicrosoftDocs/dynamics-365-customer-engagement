---
title: Work assignment overview
description: Learn how work assignment in Dynamics 365 Sales helps prioritize records and assign them to sellers automatically with assignment rules and segments.
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.topic: overview
ms.collection: get-started
ms.date: 09/20/2024
ms.custom:
- bap-template
- ai-gen-docs-bap
- ai-gen-desc
- ai-seo-date:10/19/2023
---

# Work assignment overview

Work assignment is a feature of Dynamics 365 Sales that automates the assignment of leads, opportunities, and insights to your sales team. Easily create segments to group and prioritize new or updated leads and opportunities. Connect segments to sequences of activities to guide sellers through your sales process. Finally, create rules to automatically assign records to sellers, freeing your time for more productive work.

Work assignment is available in sales accelerator version 9.1.23074.10021 and is rolling out in phases in different regions.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/), or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) |
| **Security roles** | [System Administrator, Sequence Manager, or Sales Manager](security-roles-for-sales.md) |

## Prerequisites

[Sales accelerator is configured in your organization](enable-configure-sales-accelerator.md).

## Work assignment components

Work assignment automation is built around three components: *segments*, *sequences*, and *assignment rules*.

- **Segments** categorize records based on specific criteria, such as location and source. For example, you might have a segment for leads from trade shows in India.  
- **Sequences** are the steps that sellers follow as they progress through the sales journey. Defined sequences help new sellers be more effective faster. They make sure your entire sales team&mdash;from the most junior salesperson to veteran sellers&mdash;is on the same page.  
  Segments connect records to sequences. For example, your sales process might be something like this: "If a lead comes from a trade show in the UK" (segment), always "follow up with an email within three business days" (sequence).  
- **Assignment rules** are sets of conditions that automatically assign matching records to sellers or sales teams. You can create assignment rules for opportunities, leads, and insights.  
  For example, you might have a rule that assigns all leads from trade shows in the UK to your London sales team.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Next step

[Configure work assignment](wa-work-assignment-manage-settings.md).

## Related information

[Get seller insights to improve seller effectiveness](seller-insights-intro.md)  
[Configuring the Work Assignment Feature](https://youtu.be/Wecu6qAOXJ0)
