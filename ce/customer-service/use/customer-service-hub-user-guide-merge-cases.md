---
title: Merge cases
description: Learn about how to merge cases when multiple cases are created about the same issue in different channels.
ms.date: 12/13/2024
ms.topic: how-to
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
  - bap-template
searchScope:
- D365-App-customerservicehub
- D365-Entity-incident
- D365-UI-*
- Customer Engagement
- Dynamics 365
- Customer Service
---

# Merge cases

When a customer opens multiple cases about the same issue through different support channels or when multiple customers from the same account call in about the same issue, you can merge those cases into one case to eliminate redundancy.

When a case is merged, the state of the case is changed to canceled, and the status is changed to merged. This is because it is merged into another case and all of the case activities, emails, and attachments are now associated with the case it was merged into. By default you can merge up to 10 cases at a time.  

A few things to remember when you merge cases with parent and child relationships:  

- When you merge a case that has child cases, those child cases become child cases of the parent case they were merged into.  

- You can only merge a child case into another child case if both of the child cases have the same parent case.  

In the Customer Service Hub, you can merge cases from the dashboard streams or from the list of case records.  

> [!NOTE]
> The **Merge Cases** dialog uses the **Merge Incident** view of the **Advanced Find** view that can't be customized.

## Merge cases from dashboard streams

1. In Customer Service Hub, select **Dashboards** in the site map, and then open the dashboard you want to look at.

1. Select at least two active case records that you want to merge using the **Bulk select** button ![Bulk select option.](../media/bulk-select.png "Bulk select option").

1. Select the **More Actions** button ![More Actions button.](../media/v8-1-more-actions--button.png "More Actions button"), and then select **Merge Cases**.  

1. In the **Merge Cases** dialog box, from the list of cases, select the case the other cases will be merged into, and then select **Merge**.  

1. To see the merged case, open the case it was merged into. You'll find the merged case listed in the **Merged Cases** section on the **Case Relationships** tab.  

## Merge cases from a list of case records  

1. In Customer Service Hub, select **Cases** in the site map. In Customer Service workspace, select the **My Active Cases** view on the **Customer Service Agent Dashboard**.

1. Select at least two active case records that you want to merge, and then on the command bar, select **Merge Cases**.

1. In the **Merge Cases** dialog, from the list of cases, select the case the other cases will be merged into, and then select **Merge**.

1. To see the merged case, open the case it was merged into. You'll find the merged case listed in the **Merged Cases** section on the **Case Relationships** tab.

### Related information

[Learn the basics of the Customer Service Hub](../implement/customer-service-hub-user-guide-basics.md)  
[Use the Main form and its components](../../customerengagement/on-premises/customize/use-main-form-and-components.md)  

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
