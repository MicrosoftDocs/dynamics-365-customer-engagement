---
title: Create and manage parent and child cases in Customer Service Hub | Microsoft Docs
description: Understand Cases in Customer Service Hub for Dynamics 365 Customer Service.
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 04/28/2020
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
# Create and manage parent and child cases

 You can manage multiple cases efficiently if you form parent and child case relationships in Customer Service Hub. When you want to track cases that other departments will also work on, or when you need to track the same issue for multiple customers, create a parent case, and then create child cases. For example, if you get a service request to install new electrical and gas connections, the work has to be done separately by the gas and electric departments. In this situation, you can open two child cases, one for the gas department and the other for the electric department. The original case can be marked as the parent case. After the child cases are resolved, you can then close the parent case.

> [!NOTE]
>
> - By default, child cases will not appear in the **Regarding** lookup option of an activity. If you want the child cases to be displayed in the lookup, you can customize the filter conditions of the **Case Lookup View** in the customizations setting of Customer Service Hub.
> - A child case can’t have a child case and a parent case can't be a child of another case.

## Create a child case

You can create a child case from the case form.  

> [!IMPORTANT]
> For more information about defining settings for parent-child cases, see [Define settings for parent and child cases](define-settings-parent-child-cases.md).

1. [!INCLUDE[proc_service_cases](../includes/proc-service-cases.md)]  

2. When the case form is open, do one of the following:
   - On the command bar, select **Create Child Case**.
   - On the **Case Relationships** tab, in the **Child Case** section, select **Add New Case**.

3. If you want to add an existing case as a child case, do the following:
   1. On the **Case Relationships** tab, in the **Child Case** section, select the **More Commands** icon (![More Commands](media/more-commands-vertical.png "More Commands")), and then select **Add Existing Case**. The **Lookup Records** flyout appears to the right of the window.
   2. Search for a case, and select **Add**.

4. Fill in the case information for the child case, and then select **Save**.  

## Associate cases as parent and child

You can set a parent-child relationship between cases where you can set one case as parent and set other cases as its child cases.

1. [!INCLUDE[proc_service_cases](../includes/proc-service-cases.md)]  

2. In the list of active cases, select two or more cases that you want to associate as parent and child cases.
3. On the command bar, select **Associate Child Cases**. The **Set Parent Child Relationship** dialog box appears.
4. In the list, select the case that you want to set as parent, and then select **Set**.  

### See also

[Learn the basics of the Customer Service Hub](customer-service-hub-user-guide-basics.md)  
[Use the Main form and its components](../customerengagement/on-premises/customize/use-main-form-and-components.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]