---
title: Create and manage parent and child cases in Customer Service Hub | Microsoft Docs
description: Understand Cases in Customer Service Hub for Dynamics 365 Customer Service.
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 11/27/2019
ms.topic: article
ms.service: 
  - dynamics-365-customerservice
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
 You can manage multiple cases more efficiently if you use parent and child cases in the Customer Service Hub. When you want to track a case where work needs to be done by other departments, or when you need to track the same issue for multiple customers,  open a primary, or "parent" case, and then create secondary, "child" cases.  For example, if you get a service request to install new electrical and gas connections, this requires work to be done separately by the gas and electric departments. In this situation, you can open two child cases, one for the gas department and the other for the electric department. The original case is marked as the parent case. Once the child cases are resolved, you can then close the parent case.  

### Create a new child case  
 When you need to create a child case for the case you’re working on, you can quickly do this from the case form.  

> [!IMPORTANT]
>  For more information about defining settings for parent child cases, see [Define settings for parent and child cases](define-settings-parent-child-cases.md).    

1. [!INCLUDE[proc_service_cases](../includes/proc-service-cases.md)]  

2. When the case form is open, do one of the following:
   - On the command bar at the top, select **Create Child Case**.
   - Go to the **Case Relationships** tab, and in the **Child Case** section, select **Add New Case**.

   > [!NOTE]
   > If you wish to add an existing case as a child case, go to the **Case Relationships** tab, in the **Child Case** section, select **(...)** and select **Add Existing Case**. A flyout appears on the right side of the screen. Use Lookup Records to look for a case that you want to add as child case.

3. Next, fill in the necessary case information for the child case, and then select **Save**.  

### Associate cases as parent and child
You can set a parent child relationship between cases where you can set one case as parent and set other cases as its child cases. 

> [!NOTE]
>  A child case can’t have a child case.  

1. [!INCLUDE[proc_service_cases](../includes/proc-service-cases.md)]  

2. Then, do one of the following:  

   From your active list of cases, do this:  

   1.  Select the cases that you want to associate as parent and child case(s). You must select at least two cases.  

   2.  On the command bar, select **Associate Child Cases**.  

   3.  In the **Set Parent Child Relationship** pane, from the list of cases, select the case that you want to make the parent case, and then select **Set**.  

   From an open case, do this:  

   1.  Select the **Case Relationships** tab, and in the **Child Case** section, select **Add New Case**. The open case automatically becomes the parent case.

       > [!NOTE]
       > If you wish to add an existing case as a child case, go to the **Case Relationships** tab, in the **Child Case** section, select **(...)** and select **Add Existing Case**. A flyout appears on the right side of the screen. Use Lookup Records to look for a case that you want to add as child case.



### See also

[Learn the basics of the Customer Service Hub ](customer-service-hub-user-guide-basics.md)

[Use the Main form and its components](../customerengagement/on-premises/customize/use-main-form-and-components.md)
