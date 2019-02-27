---
title: "Create data masking settings | MicrosoftDocs"
description: "Instructions to create data masking settings in Omni-channel Engagement Hub."
keywords: ""
author: sbmjais
ms.author: shjais
manager: shujoshi
applies_to: 
ms.date: 03/06/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: EE5A853F-F531-4EA6-9E64-B5CA9B021AFE
ms.custom: 
---

# Create data masking settings

Applies to Dynamics 365 for Customer Engagement apps version 9.1.0

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

intro here

## Create data masking record

1.	Sign in to Omni-channel Engagement Hub.

2.	Go to **Administration** > **Data Masking**.

3.	Select **New** to add a data masking record.

4.	On the **New Masking Rule** page, provide the following information:

    - **Name**: Name of the masking rule.

    - **Description**: Optional description of the masking rule.

    - **Regular expression**: Regular expression to identify the data to be masked.

        > [!NOTE]
        > By default, the masked character is # symbol.
        
    - To test the data masking as per the specified regular expression, enter a value in the **Enter test data** field. The masked value is displayed in the **Masked test data** field.

5. Select **Save**.
