---
title: Resolve, cancel, and reassign a case in Customer Service Hub 
description: Understand Cases in Customer Service Hub for Dynamics 365 Customer Service.
ms.date: 07/31/2024
ms.topic: article
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
searchScope:
- D365-App-customerservicehub
- D365-Entity-incident
- D365-UI-*
- Customer Engagement
- Dynamics 365
- Customer Service
---

# Resolve, cancel, and reassign cases

Customer Service provides you with the ability to resolve, cancel, and reassign cases. 

## Resolve a case  

1. In the list of active cases, open the one you want to resolve.  

2. On the command bar, select **Resolve case**. The status of the case is set to **Resolved** only when you select **Resolve Case** and the case gets resolved. You can't set the value of the **Case Status** field to **Resolved**

  If you have open activities linked to the case, you see a message with the following actions:
  - A link with the number of open activities. You can select the link to view the open activities associated with the case on a tab your administrator has configured. More information: [Enable the redirection link for Customer Service apps](../administer/add-enhanced-case-management.md#redirect-users-to-a-specific-tab-to-close-the-open-activities-for-a-case)
  - **Confirm**: If you select **Confirm** on the warning, the system automatically cancels the open activities when the case is resolved.
  
      :::image type="content" source="../media/resolve-case-after.png" alt-text="Open activity warning" lightbox="../media/resolve-case.png":::
  
3. Depending on the settings enabled for you, you see the minimal case resolution dialog or legacy case resolution dialog that are explained as follows:

 ### [Default case resolution dialog](#tab/defaultcaseresolutionform)

 By default, you'll see the **Resolution Type** and **Resolution** fields only on the **Resolve Case** dialog.

  :::image type="content" source="../media/minimal-resolve-case-after.png" alt-text="Default minimal resolve case" lightbox="../media/minimal-resolve-case.png"::: 

 ### [Legacy case resolution dialog](#tab/lagacycaseresolutiondialog)
    
 The standard **Resolve Case** dialog is displayed with the **Resolution Type** and **Resolution** fields along with the following additional fields:

   - **Duration**: The total time spent on all activities for this case, as recorded in the **Duration** box in each activity, is filled out automatically in the **Total Time** field.  
   - **Billable Time**: The amount of time spent on the case to be billed to the customer. Your billable time is automatically populated only if the **Total Time** field is displayed on the **Resolve Case** dialog. Else, you have to manually add your billable time.
   - If your administrator enables case handling time, the **Total Time** fields display the time calculated by the time tracker and not the time coming from the incident resolution table.
   - If this case is linked to an entitlement, the billable time is subtracted from the allotted minutes for that entitlement.
         
   :::image type="content" source="../media/resolve-case-legacy.png" alt-text="Legacy resolve case" :::

   ---
4.  Select **Resolve**.

> [!NOTE]
> - We recommend that you resolve or close a case before deleting it. 
> - While you can't edit or update any attribute of the case after it is resolved, through the UI, you can configure an API or a Power Automate flow to be run if the setting in service configuration is enabled. Learn more in [Allow updates for resolved and canceled cases](../administer/update-resolved-canceled-cases.md)
> - The "resolve cases" action isn't available in the business process flow in Customer Service Hub. As a workaround, you can customize the business process flow to add the action. Learn more in [Add an action to a business process flow](/power-automate/create-business-process-flow#add-an-on-demand-action-to-a-business-process-flow).

## Resolve a case with a parent and child relationship  

> [!IMPORTANT]
>
> Sometimes, resolving a case action might be blocked based on your current case status. This is because your admin may have set things up so that you only see a limited set of statuses to choose from based on the current status of a case. For more information about the available list of case statuses, contact your administrator.  

 Depending on your settings, a case with a parent and child relationship can be closed in one of the following ways:  

- When all the child cases are resolved, you can close the parent case.  

- When you resolve the parent case, it resolves all the active associated child cases.  

- A parent and child case can be closed independently of each other. This is the default setting.
- Before you resolve a parent case that has active child cases, make sure that all the case activities are closed. Otherwise, you get a message with the following actions:
   - A link with the number of open activities. You can select the link to view the open activities associated with the case on a tab your administrator has configured. Learn more in [Enable the redirection link for Customer Service apps](../administer/add-enhanced-case-management.md)
   - **Confirm**: If you select **Confirm** on the warning, the system will automatically cancel the open activities when the case is resolved. Also, performance might be slow when you close a parent case with lots of active child cases associated with it. 
 
## Cancel a case

 All case activities must be closed before you can cancel a case.  

1. In the list of active cases, open the case you want to cancel, and then on the command bar, select **Cancel Case**.  

2. In the **Confirm Cancellation** dialog box, select the case status:  

    - **Canceled**: The case is canceled and is no longer assigned to you.  

    - **Merged**: The case is merged with another case. When the case is merged, the case activities are moved to the case it was merged with.  

3. Select **Confirm**.  

> [!NOTE]
> If you are using a custom code or custom workflow to mark a case as resolved or canceled, make sure that you set up appropriate validation to check if the case is already resolved or canceled. If a custom workflow tries to resolve or cancel a case that's already resolved or canceled, you get errors while executing the custom workflow.

## Reassign a case

> [!IMPORTANT]
> When [unified routing](../administer/overview-unified-routing.md) is enabled, use the save and route option to reassign a case or work item.

If you don’t have enough information to resolve a case, or if you think another member in your team has expertise on the subject, you can assign the case to another user or team.  

1. In the list of cases, select the case that you want to reassign, and on the command bar, select **Assign**.  

2. In the **Assign to Team or User** dialog box, in the **Assign To** field, select **User or Team**, and then in the **User or team** field, select who you want to assign the case to.  

3. Select **Assign**. 

## Case resolution history

Displays the case resolution history. If a case must be reopened, agents have the ability to view case history here.

  > [!div class=mx-imgBorder]
  > ![status bar.](../media/case_resolution_16.png "status bar")

### Related information

[Learn the basics of the Customer Service Hub](../implement/customer-service-hub-user-guide-basics.md)

[Use the Main form and its components](../../customerengagement/on-premises/customize/use-main-form-and-components.md)
  


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
