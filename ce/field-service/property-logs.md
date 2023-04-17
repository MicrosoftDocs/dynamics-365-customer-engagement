---
title: Add property logs
description: Learn how to work with property logs and property history in Dynamics 365 Field Service.
ms.date: 01/25/2023
author: jshotts
ms.author: jasonshotts
ms.topic: how-to
ms.custom: bap-template
---

# Add property logs

After [associating properties with customer assets](properties.md), you can log specific values of a property to build a history of its values.

## Log a property value

1. In Field Service, select the **Service** area. Under **Assets**, select **Assets**, and then select a customer asset record.

1. Select the **Properties** tab.

1. In the **Current Property Values** section, select **New Property Log**.

1. Search for and select a property. You can only choose from [properties that are associated with the asset](properties.md).

    The **Reading Time** defaults to the current date and time. You change these values to reflect the actual date and time the value was read.

1. Enter the value of the property at the reading time.

1. Select **Save and Close**.

    :::image type="content" source="media/assets-properties-log-lookup2.png" alt-text="Screenshot of the Property Log for a customer asset.":::

To add a new value to the property history, add another property log.

In the following example, a laptop had some RAM removed. Recall that the original value of the property `RAM (GB)` was 16.00.

:::image type="content" source="media/assets-properties-maintain-new-values.png" alt-text="Screenshot of an asset's property history.":::

The **Current Property Values** list shows the current value of each property that's associated with the asset. The **Property Log History** list shows the previously logged values of those properties. The **Delta** value in each list represents the difference between the most recent value and the previous value.  

## Next steps

- [Build a service history for assets](service-history.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
