---
title: Add property logs
description: Learn how to work with property logs and property history in Dynamics 365 Field Service.
ms.date: 06/17/2024
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.custom: bap-template
---

# Add property logs

After [associating properties with customer assets](properties.md), you can log specific values of a property to build a history of its values.

## Log a property value

1. In Field Service, select the **Settings** area. Under **Asset Properties**, select **Property Definitions**, and then select a property.

1. Select **Related** > **Property Logs**. Then select **New Property Log**.

1. Search for and select the customer asset. The **Reading Time** defaults to the current date and time. You change these values to reflect the actual date and time the value was read.

1. Enter the value of the property at the reading time.

1. Select **Save and Close**.

To add a new value to the property history, add another property log.

In the following example, a laptop had some RAM added. The original value of the property `RAM (GB)` was 8.00.

:::image type="content" source="media/assets-properties-maintain-new-values.svg" alt-text="Screenshot of an asset's property history.":::

## Next steps

- [Build a service history for assets](service-history.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
