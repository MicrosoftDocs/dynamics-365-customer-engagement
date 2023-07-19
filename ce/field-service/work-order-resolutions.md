---
title: Create work order resolutions
description: Learn about how to capture work order resolution details in Dynamics 365 Field Service.
ms.date: 06/09/2023
ms.topic: how-to
author: lmasieri
ms.author: lmasieri
ms.custom: bap-template
---

# Create work order resolutions

Organizations often report on how work orders are resolved. This reporting increases visibility for customers and provides data for the system to provide resolution suggestions. Tracking how work is resolved can also help with training technicians on specific issues.

This article outlines how to create resolutions and associate them to incident types.

## Create resolutions

In Field Service, go to **Settings** > **Resolutions**.

Create resolution records based on your business needs. For example, if "Reset Device Control Unit" is a common way to resolve a work order issue, name the resolution accordingly. The description can contain additional information on why or how to reinstall firmware.

:::image type="content" source="media/resolutions-list-settings.jpg" alt-text="Screenshot of Field Service showing a list of active resolutions.":::

## Associate resolutions to incident types

Organizations using incident types to organize and track common work order issues can map resolutions to incident types. By default, the primary resolution maps to the primary work order incident type.

:::image type="content" source="media/wo-resolution-form.jpg" alt-text="Screenshot of a work order resolution in Field Service.":::

When administrators [configure incident types](configure-incident-types.md), they can associate multiple resolutions to an incident type. When these incident types are added to work orders, the system creates work order incident types that suggest the associated resolutions.

## Next steps

- [Create a work order](create-work-order.md)
- [Create work order templates with incident types](configure-incident-types.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
