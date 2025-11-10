---
title: Configure target customers for Sales Close Agent - Engage
description: Define target customer segments for the Sales Close Agent - Engage to effectively engage with during outreach and follow-up activities. 
ms.date: 11/07/2025
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

# Configure target customers for Sales Close Agent - Engage

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Group customers into a segment to help the agent engage with them during outreach and follow-up activities. For example, opportunities that are unattended and potentially of lower value could be mapped to a segment and worked on by the agent. The agent only considers records that aren't assigned to any other segments. So, ensure that the conditions for this record type don't overlap with those of other segments. Learn more about segmentation in the [create and activate a segment](wa-create-and-activate-a-segment.md#create-and-activate-a-segment) article.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

**Follow these steps**:

1. [Open the Sales Close Agent - Engage settings page](open-sales-close-agent-settings.md).  
1. In the **Guidance** section, select **Target customer**.  
    :::image type="content" source="media/sca-guidance-target-customer-settings-page.png" alt-text="Screenshot of the Sales Close Agent - Engage target customer settings page.":::
1. 1. Select a **Record type** that you want the agent to use as the basis for outreach and engagement. The supported record types are **Contact**, **Account**, **Lead**, and **Opportunity**. By default, the **Opportunity** record type is selected.  
1. In the conditions section, add conditions that are used to evaluate records for processing to the segment.  
    You can have up to 10 conditions at any given time including conditions that are based on groups and related entities.  
    By default, the following conditions are added depending on the selected record type:  

    | Record type | Description |
    |-------------|-------------|
    | Contact | Records where the email contains data. The field name is `Email` and the operator is `Contains data`. |
    | Account | Records where the email contains data and the email is the primary email. The field is derived from the `Primary Contact (Contact)` related entity with the `Contains data` operator where the field is `Email` and operator is `Contains data`. |
    | Lead | Records where the email contains data and the email is the primary email. The field name is `Email` and the operator is `Contains data`. |
    | Opportunity | Records where the email contains data and the email is the primary email. The field is derived from the `Primary Contact (Contact)` related entity with the `Contains data` operator where the field is `Email` and operator is `Contains data`. |  

    To add more conditions, select **Add** and then use the following options to build the conditions for the segment:  
    - **Add row**: Add condition. Select an attribute, an operator, and a value; for example, Created by Equals John Thomas.  
        Add more conditions as needed, up to 10, to further filter the records that should be assigned to the segment.  
    - **Add group**: Add a group of conditions to filter records using multiple attributes that are combined by **And** or **Or**. If you select **And**, records must meet all the conditions in the group. If you select **Or**, records can meet any condition in the group.  
    - **Add related entity**: Add a condition that's based on the attributes of related tables. Select an attribute in the **Related Entity** list, then select **Contains data** or **Does not contain data**, and then define the condition.  
1. (Optional) When you've finished defining the conditions, select **Preview** to view a list of records that satisfy the conditions.  
    At the bottom of the list, on the left, you can see the number of records that match the conditions and on the right side shows the total number of records available in the application.  
    If you're satisfied with the results, you can continue with the next configuration step.  

## Next step

[Configure email delivery settings](configure-sales-close-agent-email-delivery.md)

## Related information

[Set up and configure the Sales Close Agent - Engage (preview)](configure-sales-close-agent.md)
