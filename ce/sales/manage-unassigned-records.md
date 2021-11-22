---
title: "View and manage unassigned records in assignment rules"
description: "You can view and manage unassigned lead and opportunity records through assignment rules in sales accelerator."
ms.date: 11/18/2021
ms.service: dynamics-365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# View and manage unassigned records

[!INCLUDE[cc-preview-features-no-ms-support](../includes/preview-disclaimer.md)] 

Monitoring of unassigned records allows you to view the lead or opportunity records that aren't assigned to any seller. As an administrator, sales manager, or sequence manager, you can view these unassigned records and assign to sellers. 

## License and role requirements
|  | |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise or Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | System Administrator, Sequence Manager, or Sales Manager <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## View unassigned records

You can view the list of records that aren't assigned to sellers and assign them to sellers either manually or by [creating an assignment rule](create-and-activate-assignment-rule.md#to-create-and-activate-an-assignment-rule). The records aren't assigned automatically because of one of the following reasons: 

| Reason | Description |
|--------|-------------|
| Eligible sellers don't have availability | Record couldn’t be assigned as eligible sellers aren't available. |
| Eligible sellers don't have capacity | Record couldn’t be assigned as eligible sellers don't have the capacity. |
| No assignment rule for this record's segment | Record doesn't match any assignment rule that is currently active and available in the organization.|
| No sellers meet the conditions | Record isn't assigned as none of the sellers meet the conditions that are defined in the matched assignment rule. | 
| Owner assigned manually | Owner is manually assigned to the record. |
| Owner assigned successfully | Owner is assigned to the record. |
| Record doesn't meet any conditions | Record isn't assigned as it doesn't match any conditions that are defined for the assignment rule. |
| Run is in progress | Specifies that the assignment is in progress for the record. |
| There was an issue with the server | Record isn't assigned as there's an issue with the server that your organization is hosted on. |

**To view the unassigned records** 

1.	Go to the **Change area** ![change area](media/change-area-icon.png) in the lower-left corner of the page, and select **Sales Insights settings**.      
2.	Under **Sales accelerator**, select **Assignment rules (preview)**.   

    >[!div class="mx-imgBorder"]
    >![Assignment rules home page.](media/sa-ar-view-unassigned-records-home-page.png "Assignment rules home page")

3. Select **Monitoring** and then select **Lead monitoring** or **Opportunity monitoring** according to your requirement. In this example, we're selecting **Lead monitoring**.

    >[!div class="mx-imgBorder"]
    >![Select the lead monitoring option from monitoring.](media/sa-ar-view-unassigned-records-select-lead.png "Select the lead monitoring option from monitoring") 

    In the **Lead monitoring** page, under the **Unassigned leads** tab, a list of unassigned lead records is displayed. 

    >[!div class="mx-imgBorder"]
    >![View the list of unassigned lead records.](media/sa-ar-view-unassigned-records-view-records.png "View the list of unassigned lead records") 

    The **Status Reason** column displays why the record isn't assigned to a seller. By analyzing the reason, you can take appropriate action by assigning these leads to sellers, creating an assignment rule, or by adding conditions to existing [assignment rule](create-and-activate-assignment-rule.md#to-create-and-activate-an-assignment-rule). 

## Assign records manually

You can assign the unassigned records to sellers or a team. 

1. Select the record that you want to assign to a seller and then select **Assign**. In this example, we're selecting a lead record. 
    
    >[!NOTE]
    >You can select multiple records at once to assign to a seller.  

    >[!div class="mx-imgBorder"]
    >![Select a record to assign to a seller.](media/sa-ar-assign-unassigned-records-select-records.png "Select a record to assign to a seller") 

2. On the **Assign leads to a seller or team** page, select a seller to who you want to assign the record.   

    >[!NOTE]
    >- Enable the **Show eligible sellers** option to view only the seller who are added to assignment rules through team settings. More information: [Manage sales teams in assignment rules](manage-sales-teams.md)
    >- To assign the record to a team, select **Team** tab.

    >[!div class="mx-imgBorder"]
    >![Select a seller.](media/sa-ar-assign-unassigned-records-select-seller.png "Select a seller") 
        
3. Select **Assign**.    
    The record is assigned to the seller and the list refreshes to remove the assigned record.    
    To view the details of the assigned records, select the **Assignment history** tab. A list of previously assigned records is displayed.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Manage assignment rules](create-manage-assignment-rules.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
