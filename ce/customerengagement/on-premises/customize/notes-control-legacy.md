---
title: "Enable posts for a custom entity in Dynamics 365 Customer Engagement (on-premises)"
description: "For custom entities where you've enabled notes and activities, you'll only see Notes and Activities. To include Posts, you must enable them for the entity."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
author: Mattp123
ms.assetid: f10cdf1c-3540-439c-a171-27a10e72da45
caps.latest.revision: 63
ms.author: matp
search.audienceType: 
  - customizer

---
# Set up the Notes control to access information about posts for a custom entity



 In Dynamics 365 Customer Engagement (on-premises) forms for certain system entities using the [Updated forms](main-form-presentations.md#updated-forms),  the Notes control provides the ability to access information about **Posts**, **Activities**, and **Notes**. For custom entities where you have enabled notes and activities, you will only see **Notes** and **Activities**. To include **Posts** you must enable them for the custom entity.  
  
## Enable posts for a custom entity  
  
1. [!INCLUDE[proc_settings_postconfig](../includes/proc-settings-postconfig.md)]  
  
2. Locate the record for your custom entity.  
  
3. Make sure that **Enable walls for this type of record form** is selected and save the record.  
  
4. In the command bar, select **Activate**.  
  
5. If you needed to enable walls, you need to publish the entity.  
  
   By default, for system entities the notes control is positioned in a social pane section in the center of a three column tab at the top of the form. It can appear in a form just one time. You can move or remove the notes control. To add it back, use the **Notes** button in the **Control** group of the **Insert** tab.  
  
   The following table describes the properties for the Notes control.  
  
|Tab|Property|Description|  
|---------|--------------|-----------------|  
|**Display**|**Label**|**Required**: Although the label is not displayed by default, a label is required.|  
||**Display Label on the form**|You can choose to display the label.|  
||**Lock the field on the form**|This will prevent the notes from being removed from the form accidentally.|  
||**Default tab**|Select which tab should be displayed by default. The options are:<br /><br /> - **Activities**<br />- **Posts**<br />- **Notes**|  
|**Formatting**|**Select the number of columns the control occupies**|When the section containing the notes control has more than one column you can set the field to occupy up to the number of columns that the section has.|  
||**Number of Rows**|Control the height of the notes control by selecting the number of rows the control occupies.|  
||**Automatically expand to use available space**|Instead of setting the height by a number of rows, you can allow the notes control height to expand to available space.|  
  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
