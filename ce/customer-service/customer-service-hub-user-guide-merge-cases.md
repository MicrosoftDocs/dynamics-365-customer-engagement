---
title: Merge cases | MicrosoftDocs
description: Merge cases when multiple cases are created about same issue in different channels.
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 03/18/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
---

# Merge cases

When a customer opens multiple cases about the same issue (through different support channels), or when multiple customers from the same account call in about the same issue, you can merge those cases into one case to eliminate redundancy.  

When a case is merged, the state of the case is changed to canceled, and the status is changed to merged. This is because it is merged into another case and all of the open case activities, emails, and attachments are now associated with the case it was merged into. By default you can merge up to 10 cases at a time.  

A few things to remember when you merge cases with parent and child relationships:  

- When you merge a case that has child cases, those child cases become child cases of the parent case they were merged into.  

- You can only merge a child case into another child case if both of the child cases have the same parent case.  


In the Customer Service Hub, you can merge cases from the dashboard streams or from the list of case records.  

> [!NOTE]
> The **Merge Cases** dialog box uses the Merge Incident view of the Advanced Find view that can't be customized.

## Merge cases from dashboard streams  

1. On the sitemap, select **Service** > **Dashboards**.  

2. Open the dashboard you want to look at.  

3. Select at least two active case records that you want to merge using the **Bulk select** button ![bulk-select](media/bulk-select.png).
4. Select the **More Actions** button ![More Actions button](../customer-service/media/v8-1-more-actions--button.png "More Actions button"), and then select **Merge Cases**.  

    You can select and merge up to 10 cases at a time.  

5. In the **Merge Cases** dialog box, from the list of cases, select the case the other cases will be merged into, and then select **Merge**.  

6. To see the merged case, open the case it was merged into. You'll find the merged case listed in the **Merged Cases** section on the **Case Relationships** tab.  

## Merge cases from a list of case records  

1. On the sitemap, select **Service** > **Cases**.  

2. Select  at least two active case records that you want to merge, and then on the command bar, select **Merge Cases**.  

    You can select and merge up to 10 cases at a time.  

3. In the **Merge Cases** dialog box, from the list of cases, select the case the other cases will be merged into, and then select **Merge**.  

4. To see the merged case, open the case it was merged into. You'll find the merged case listed in the **Merged Cases** section on the **Case Relationships** tab.  

### See also

[Learn the basics of the Customer Service Hub](customer-service-hub-user-guide-basics.md)  
[Use the Main form and its components](../customerengagement/on-premises/customize/use-main-form-and-components.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]