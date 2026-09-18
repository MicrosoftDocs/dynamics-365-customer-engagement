---
title: Create work order resolutions in Dynamics 365 Field Service
description: Create work order resolutions to standardize repair outcomes, connect fixes to incident types, and improve service insights.
ms.date: 09/16/2026
ms.topic: how-to
author: lmasieri
ms.author: lmasieri
ms.reviewer: v-wesmith
ms.custom: bap-template
---

# Create work order resolutions

Organizations often report on how work orders are resolved. This reporting increases visibility for customers and provides data for the system to provide resolution suggestions. Tracking how work is resolved can also help with training technicians on specific issues.

This article outlines how to create resolutions and associate them to incident types.

## Create resolutions

In Field Service, go to the **Settings** area, then **Work Order** > **Resolutions**.

Create resolution records based on your business needs. For example, if "Reset Device Control Unit" is a common way to resolve a work order issue, name the resolution accordingly. The description can contain additional information on why or how to reinstall firmware.

:::image type="content" source="media/resolutions-list-settings.png" alt-text="Screenshot of Field Service showing a list of active resolutions.":::

## Associate resolutions to incident types

Organizations that use incident types to organize and track common work order issues can map resolutions to incident types. You can add as many resolutions as needed to cover different ways an issue might be resolved. By default, the primary resolution maps to the primary work order incident type.

As an administrator, you can [associate multiple resolutions to an incident type](configure-incident-types.md#add-incident-type-resolutions) when you configure incident types. Or, from the resolution, select the **Incident Type Resolutions** tab and add the new incident types.

When frontline workers add incident types to work orders, the system creates work order incident types that suggest the associated resolutions.

:::image type="content" source="media/resolution-form.png" alt-text="Screenshot of a work order resolution in Field Service.":::

## Next steps

- [Create a work order](create-work-order.md)
- [Create work order templates with incident types](configure-incident-types.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
