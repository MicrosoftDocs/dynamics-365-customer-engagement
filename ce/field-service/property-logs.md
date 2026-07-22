---
title: Add property logs in Field Service
description: Learn how to add property logs in Dynamics 365 Field Service to track asset measurements over time. Record property values at specific reading times to build service history.
ms.date: 07/20/2026
author: jshotts
ms.author: jasonshotts
ms.reviewer: v-wesmith
ms.topic: how-to
ms.custom: bap-template
---

# Add property logs

In Dynamics 365 Field Service, use property logs to track historical values of asset properties over time. You can record measurements or attributes associated with a customer asset so you can see how those values change throughout the asset's lifecycle.

After you [associate properties with customer assets](properties.md), log specific property values to build a history of those values.

Property logs help you:

- Build a history of asset measurements and characteristics over time.

- Record the value at a specific reading time rather than just the current value.

- Track changes to equipment and assets as they're serviced or modified.

- Support a more complete service history for customer assets.

## Log a property value

1. In Dynamics 365 Field Service, select the **Settings** area.

1. Under **Asset Properties**, select **Property Definitions**.

1. Select a property.

1. Select **Related** > **Property Logs**.

1. Select **New Property Log**.

1. Search for and select the customer asset.

1. Search for and select the functional location.

1. By default, the **Reading Time** field shows the current date and time. Change the value to reflect the actual date and time when the value was read.

1. In the **Value** field, enter the property value at the reading time.

1. Select **Save and Close**.

To add a new value to the property history, add another property log.

In the following example, some RAM was added to a laptop. The original value of the **RAM (GB)** property was *8.00*.

:::image type="content" source="media/assets-properties-maintain-new-values.svg" alt-text="Screenshot of an asset's property history.":::

## Next steps

- [Build a service history for assets](service-history.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
