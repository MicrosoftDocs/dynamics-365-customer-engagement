---
title: Add property logs
description: Learn work with property logs in Dynamics 365 Field Service.
ms.date: 01/17/2023
ms.reviewer: mhart
ms.topic: how-to
ms.custom: bap-template
author: jshotts
ms.author: jasonshotts
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Add property logs

After [associating properties](properties.md#associate-templates-to-assets-or-categories), you can then add specific values as property logs to them. Property logs enable you to build a track record of current and past values of a property.

1. In Field Service, change to the **Service** area.

1. Select a customer asset record and go to the **Properties** tab.

1. In the **Current Property Values** section, select **New Property Log**.

1. Choose the **Property** you want to log, and enter the log value. You can only choose from [properties that are associated to the record](properties.md#associate-templates-to-assets-or-categories). The **Reading Time** represents the date and time of reading the value for the log.

   :::image type="content" source="media/assets-properties-log-lookup.png" alt-text="Screenshot of associated properties to an asset record.":::

1. **Save and Close**.

In this example, we create a property log for a laptop and provide a value for RAM.

:::image type="content" source="media/assets-properties-log-lookup2.png" alt-text="Screenshot of the quick create dialog fully populated.":::

## Create a property log history

To update an earlier log value, you can add a new property log. In our example, the laptop we service had some RAM removed.

1. Open a record with a property log.

1. On the **Properties** tab, select **+New Property Log**.

1. Choose the property and add the new value.

1. Select **Save and Close**.

The most recent properties show in the **Current Property Values** list.

The **Delta** value represents the difference between the most recent value and the previous property value.  

All previous property values are listed in the **Property Log History** section.

:::image type="content" source="media/assets-properties-maintain-new-values.png" alt-text="Screenshot of the asset's property history.":::

## Next steps

- [Properties in Dynamics 365 Field Service](properties.md)
- [Build a service history for assets](service-history.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
