---
title: "Manage duplicates leads"
description: "Manage leads by detecting duplicates to maintain great relationships with customers and keep your leads clutter free."
ms.date: 02/10/2022
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Preview: Manage duplicate leads

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)] 

Duplicate identification of leads helps you to maintain clean and accurate data for leads in your organization.

## License and role requirements

| &nbsp; | &nbsp; |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Salesperson and above <br> See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Prerequisites

Contact your administrator to enable duplicate detection of leads for your organization. More information: [Enable duplicate lead detection](enable-duplicate-lead-detection.md)

## Rules to identify duplicates

Duplicate leads are identified based on the following rules: 

| Rule | Description | Example |
|------|-------------|---------|
| Same email address | The leads are displayed as duplicate though the other values such as, name and mobile number are different and have the same email address. | The leads, Kevin Smith and John Doe have email address employee@contoso.com, the duplicate detection feature displays the leads Kevin Smith and John Doe as duplicate based on this rule. |
| Same phone number | The leads are displayed as duplicate though the other values such as, name and email address are different and has the same phone number. | The leads, Kevin Smith and John Doe have the same phone member +1234567890, the duplicate detection feature displays the leads Kevin Smith and John Doe as duplicate based on this rule. |
| Similar name and company name | If the leads have a similar name and company, then the leads are displayed as duplicate. The defined AI model can identify the duplicate leads with name and company that sound similar. | For example, Regina Murphy from Contoso and Regina Merphy from Contoso.inc. In this example, the spelling of the names is different but sounds the same and company name is similar (Contoso). |
| Similar name and the same email domain | If the leads have a similar name and email domain, then the leads are displayed as duplicate. The defined AI model can identify the duplicate leads with names that sound similar. | For example, Regina Murphy, Regina@tallc.com and Regina Merphy, Manager@tallc.com. In this example, the spelling of the names is different but sounds same and email domain is same (tallc.com). |
 
## View and identify duplicate leads

1.	Sign in to Sales Hub app and in the site map, select **Sales** > **Leads**.    
     
2.	Select a lead from the list and if the lead has duplicates, the **View duplicates** option is displayed on the tool bar.

    >[!NOTE]
    >Select only one lead to view the duplicates. 

    >[!div class="mx-imgBorder"]
    >![Select a lead from the list and select view duplicates](media/lead-duplicate-detection-select-lead.png "Select a lead from the list and select view duplicates")    
 
    -Or-
    
    Open a lead and if the lead has duplicates, a message is displayed below the tool bar with the number of duplicate leads matching the open lead. Select **View possible duplicates**

    >[!div class="mx-imgBorder"]
    >![Open a lead from the list and select view possible duplicates](media/lead-duplicate-detection-open-lead.png "Open a lead from the list and select view possible duplicates")    

    The duplicate page opens with a list of duplicate leads.

    >[!div class="mx-imgBorder"]
    >![View the duplicates list](media/lead-duplicate-detection-duplicate-list.png "View the duplicates list")    

    Understand the duplicate list page:

    - The lead displayed on the left of the page is the lead that you've selected to view duplicates and the name is suffixed with **(current)**.
    
    - The attributes that contain similar data are highlighted across the identified duplicate leads. For example, in the above image, you can see that the name and the **Business Phone** are highlighted specifying that the data is similar when compared with the selected lead.

    - Only two duplicate leads are visible on the page. To view the other leads, select the right arrow. Also, the message on the top-right shows the count of the leads you're viewing. For example, in the above image, the message Showing 1-2 of 4 duplicates specifies that you're viewing the first two leads of the total four duplicates leads.

## Delete duplicate leads

After you identify the duplicate leads, delete them to help ensure a clutter free and actionable leads list.

1.	Select the duplicate lead and then select **Delete**. 

    >[!NOTE] 
    >You can delete a lead only if you are the owner of the lead or have the delete permission for the lead.

    >[!div class="mx-imgBorder"]
    >![Select a duplicate lead to delete](media/lead-duplicate-detection-select-duplicate-lead.png "Select a duplicate lead to delete") 
 
2.	On the confirmation message, select **Delete permanently**.

    The duplicate lead is removed from your organization.

## Remove leads from duplicate list

After you identify the leads that aren't duplicates, you can remove them from the duplicate list.

Select the lead and then select **Detach**. 
 
>[!div class="mx-imgBorder"]
>![Select and remove a lead from duplicate list](media/lead-duplicate-detection-select-duplicate-lead-remove.png "Select and remove a lead from duplicate list")   

The lead is detached from the actual lead’s duplicate list. However, if the detached lead is in the duplicates list of other leads, you must remove it individually.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Enable duplicate lead detection](enable-duplicate-lead-detection.md)

