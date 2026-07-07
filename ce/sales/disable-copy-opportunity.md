---
title: Disable copy opportunity feature (preview)
description: Disable the copy opportunity feature in Dynamics 365 Sales to prevent users from creating repeat deals by copying existing opportunities.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.date: 07/07/2026
ms.topic: how-to
ai-usage: ai-assisted
---

# Disable copy opportunity feature (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner-section.md)]

The copy opportunity feature in Dynamics 365 Sales helps users quickly create repeat deals by duplicating existing opportunities. This feature is enabled by default. If you don't want users to create opportunities by duplicating existing ones, you can disable this feature.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Disable the feature

1. From the **Change area** ![Icon to change the work area.](media/change-area-icon.png "Icon to change the work area"), select **App Settings**. 

1. Under **General Settings**, select **Lead + Opportunity management** > **Opportunity management**.
1. Turn the **Show ´Copy opportunity´ button** toggle to **No** and save the changes.

After you turn on the feature, users with the **Create** permission on the **Opportunity** entity see the **Copy opportunity** button on the command bar when they open an existing opportunity or select a single opportunity from the grid view. For more information, see [Copy an opportunity (preview)](create-edit-opportunity-sales.md#copy-an-opportunity-preview).

## Related information

- [Create or edit opportunities](create-edit-opportunity-sales.md)
- [Close opportunities as won or lost](close-opportunity-won-lost-sales.md)