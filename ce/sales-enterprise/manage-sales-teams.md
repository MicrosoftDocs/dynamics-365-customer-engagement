---
title: "Manage sales teams in assignment rules for lead and opportunity routing"
description: "Manage sales teams in assignment rules by assigning attributes and configuring the maximum number of leads and opportunities that a seller can handle at once."
ms.date: 09/10/2021
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
products: 
    - Sales premium
---
# Manage sales teams in assignment rules 

## Requirements
|  | |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise or Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | System Administrator or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

Using sales team management in assignment rules, you can assign attributes to sellers and configure the maximum number of leads and opportunities that a seller can handle at once. When the rule is applied to a record, the attributes and capacity you've defined here will determine how the record is assigned.

You can use the **Team settings** page to:

-	[Add attributes to sellers](#add-attributes-to-sellers).
-	[Set capacity for sellers](#set-capacity-for-sellers).
-	[Turn off record assignment to sellers](#turn-off-record-assignment-to-sellers).

Before you start using the sales teams designer, verify that the security roles that are assigned to your sellers were selected when the sales accelerator was configured. More information: step 4 in [Set up the sales accelerator](enable-configure-sales-accelerator.md)

## Add attributes to sellers

Attributes define the characteristics of a seller, such as skills, location, and language. Before you apply attributes to sellers, verify that the attributes have been defined. More information: [Create an attribute](manage-seller-attributes.md#create-an-attribute)

You can apply attributes in bulk by selecting multiple sellers at a time.
<!--markdownlint-disable MD036-->
**To add attributes**

1.	Sign in to your Dynamics 365 Sales Hub app.

2.	Go to the **Change area** ![change area](media/change-area-icon.png) in the lower-left corner of the page, and select **Sales Insights settings**.

3.	Under **Sales accelerator**, select **Team settings (preview)**.

4.	On the **Team settings** page, select a team or sellers that you want to apply attributes for and then select **Apply attribute**.

    >[!NOTE]
    >- The **Team settings** page lists the teams that include sellers whose security roles were configured when the sales accelerator was originally set up.
    >- To bulk-apply the attributes, select multiple sellers.

    >[!div class="mx-imgBorder"]
    >![Select Apply attribute](media/sa-ar-sales-team-apply-attribute.png "Select Apply attribute")  

    The **Apply attribute** pane opens.

6.	On the **Apply attribute** pane, select one of the following options:

    -	**Replace existing attributes with new attributes**: This option replaces the existing attributes that were already applied to the seller. If any leads were assigned to the seller based on the previous attributes, those leads won't be affected.
    -	**Keep existing attributes and add more**: This option adds more attributes to the seller, in addition to the attributes that were already applied.

7.	Select **+ Add attribute**, and then choose the attribute and its corresponding values. Repeat this step for each attribute you want to add.

    >[!div class="mx-imgBorder"]
    >![Select Add attribute](media/sa-ar-sales-team-add-attribute.png "Select Add attribute")

8.	Select **Apply**.

The attributes are applied to the sellers.

## Set capacity for sellers

When you set capacity, you set a combined upper limit of leads and opportunities that a seller can be assigned at any given time. When a seller reaches this limit, even though a lead or an opportunity record is created and ready to be automatically assigned to the seller, the record won't be assigned. You can view unassigned records for leads and opportunities in their respective open record views.

For example, Kenny is a seller, and his capacity limit is set to 10. A new lead is generated, and the assignment rule qualifies the lead to be assigned to Kenny. However, Kenny is currently handling his maximum of 10, so the newly generated lead won't be assigned to him.

**To set capacity**

1.	Sign in to your Dynamics 365 Sales Hub app.   
2.	Go to the **Change area** ![change area](media/change-area-icon.png) in the lower-left corner of the page, and select **Sales Insights settings**.   
3.	Under **Sales accelerator**, select **Team settings (preview)**.   
4.	On the **Team settings** page, select a team or sellers that you want to apply attributes for and then select **Set capacity**.

    >[!NOTE]
    >- The **Team settings** page lists the teams that include sellers whose security roles were configured when the sales accelerator was originally set up.
    >- To bulk-apply the attributes, select multiple sellers.

    >[!div class="mx-imgBorder"]
    >![Select Set capacity](media/sa-ar-sales-team-set-lead-capacity.png "Select Set capacity")   

    The **Set maximum capacity** pane opens.

    >[!div class="mx-imgBorder"]
    >![Enter the maximum number of leads for a seller](media/sa-ar-sales-team-enter-lead-capacity.png "Enter the maximum number of leads for a seller")

6.	In **Set the maximum capacity of leads and opportunities for these sellers**, enter the value you want.

7.	Select **Apply**.

    >[!NOTE]
    >If you're changing the existing maximum capacity, a confirmation message appears. Select **Override settings**.    
    >![Select override settings](media/sa-ar-sales-team-select-override-settings.png "Select override settings") 
 
The maximum capacity limit is set for the seller.

## Turn off record assignment to sellers

When a seller is on vacation or otherwise unavailable, you can disable record assignment until the seller is available again. 

**To turn off assignment**
<!--markdownlint-enable MD036-->  
1.	Sign in to your Dynamics 365 Sales Hub app.    
2.	Go to the **Change area** ![change area](media/change-area-icon.png) in the lower-left corner of the page, and select **Sales Insights settings**.    
3.	Under **Sales accelerator**, select **Team settings (preview)**.    
4.	On the **Team settings** page, under the **Assign records** column, turn off the toggle.   

    >[!div class="mx-imgBorder"]
    >![Turn off the Assign leads toggle](media/sa-ar-sales-team-disable-lead-assignment.png "Turn off the Assign leads toggle")   

6. In the confirmation message, select **Turn off availability**.  

    >[!div class="mx-imgBorder"]
    >![Confirm turning record assignment off](media/sa-ar-sales-team-turnoff-availability-confirmation-message.png "Confirm turning record assignment off")

### See also

[Manage assignment rules](create-manage-assignment-rules.md)    
[Create and activate an assignment rule](create-and-activate-assignment-rule.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
