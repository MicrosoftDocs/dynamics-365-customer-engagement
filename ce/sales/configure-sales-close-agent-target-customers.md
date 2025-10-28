---
title: Configure target customers for Sales Close Agent
description: 
ms.date: 09/24/2025
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/04/2025
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Configure target customers for Sales Close Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Conditions defined here help to group customers (record type) into a segment and help agent to engage with the segmented customers during outreach and follow-up activities. For example, the opportunities that are unattended and potentially lower value could be mapped under this segment and worked on by the agent.  
The agent considers records that are not assigned to other segments are processed for this record type. So, ensure that the conditions for this record type do not overlap with those of other segments.  
Read the [create and activate a segment](wa-create-and-activate-a-segment.md#create-and-activate-a-segment) article to understand more about the segmentation.  

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

**Follow these steps**:

1. [Open the Sales Close Agent settings page](open-sales-close-agent-settings.md).  
1. In the **Guidance** section, select **Target customer**.  
    :::image type="content" source="media/sca-guidance-target-customer-settings-page.png" alt-text="Screenshot of the Sales Close Agent target customer settings page.":::
1. Select the **Record type** from the list for which the agent uses as the basis for outreach and engagement. Only the record types **Contact**, **Account**, **Lead**, and **Opportunity** are supported. By default, the **Opportunity** record type is selected.  
1. In the conditions section, add conditions that are used to evaluate records for processing to the segment.  
    You can have up to 10 conditions at any given time including conditions that are based on groups and related entities.  
    By default, the following conditions are added depending on the selected record type:  
    
    | Record type | Description |
    |-------------|-------------|
    | Contact | Records where the email contains data. |
    | Account | Records where the email contains data and the email is the primary email. |
    | Lead |  |
    | Opportunity |  |  

    To add more conditions, select **Add** and then use the following options to build the conditions of the segment:  
    - **Add row**: Add condition. Select an attribute, an operator, and a value; for example, Created by Equals John Thomas.  
        Add more conditions as needed, for a total of 10, to further filter the records that should be assigned to the segment.  
    - **Add group**: Add a group of conditions to filter records using multiple attributes that are combined by **And** or **Or**. If you select **And**, leads must meet all the conditions in the group. If you select **Or**, leads can meet any condition in the group.  
    - **Add related entity**: Add a condition that's based on the attributes of related tables. Select an attribute in the **Related Entity** list, then select **Contains data** or **Does not contain data**, and then define the condition.  
1. (Optional) When you've finished defining the conditions, select **Preview** to view a list of records that satisfy the conditions.

## Next step


## Related information

[Set up and configure the Sales Close Agent (preview)](configure-sales-close-agent.md)
