---
title: "Provide consent for collecting data from Office 365"
description: "To provide relationship insights from the Exchange data, Dynamics 365 needs consent from the Office 365 administrator."
ms.date: 03/18/2022
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Provide consent for collecting data from Office 365  

To calculate the relationship KPIs and health score, Dynamics 365 needs to collect data—such as emails and meetings—from the Exchange server in Office 365. Work with your Office 365 administrator and have them provide the consent for using the Office 365 data.  

> [!TIP]
> For more information on how relationship analytics uses Office 365 data, go to [Use relationship analytics to gather KPIs](relationship-analytics.md).

As an Office 365 administrator, follow these steps to provide the consent:
    
1. Go to the **Microsoft 365 admin center**.    
    
2. Select **Settings** > **Org settings** > **Dynamics 365 Applications**.    
    The consent form is displayed in the right panel.
    :::image type="content" source="media/office365-consent-form.png" alt-text="Consent form to use office 365 data":::

    > [!IMPORTANT]
    > If you are an existing relationship analytics customer and have already provided consent in the **Dynamics 365 Sales Insights – Analytics** page, the consent will be valid until September 2022. After when, you must provide the consent in the new form as shown in the preceding screenshot. However, we recommend that you provide the consent as soon as you can.  
    
3. Read the description carefully and select the **Insights for other users** option. 

    > [!NOTE]
    > The consent provided is applicable to all the Dynamics 365 applications that require **Insights for other users** permission.  
      
    Relationship analytics can now connect to the Exchange server to fetch data.

