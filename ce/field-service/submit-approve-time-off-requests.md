---
title: "Submit and approve time-off requests (Dynamics 365 for Field Service) | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 01/22/2019
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
author: FieldServiceDave
ms.assetid: 7fac64e1-2816-415a-b45f-b1a1aa9fc68f
caps.latest.revision: 18
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365FS
---
# Submit and approve time-off requests (Field Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Keep the schedule board in [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] up to date by logging time-off requests.  
  
For example, if one of your field technicians is taking a vacation, it's important to log the request so that a dispatcher can see the time-off request on the schedule board when scheduling a work order.  
  
When a resource has an approved time-off request, the scheduling assistant will not recommend that resource for a job in that time period, and the time slots for that resource will be grayedout on the schedule board to provide a visual notification to the dispatchers that the resource is not scheduled to be available during that time period.  
  
If a bookable resource is set to require time-off approval, then when a time-off request is created for that resource, an approval request will be sent to that user's manager, before the time-off request is reflected in the schedule assistant and on the schedule board.  
  
<a name="BKMK_SubmitTimeOffRequest"></a>   
## Submit a time-off request  
  
1.  From the main menu, select **Field Service** > **Time Off Requests**.  
  
2.  On the **Active Time Off Request** screen, select **New**.  
  
3.  Use the tooltips to help fill in your information, and then select **Save**.  
  
<a name="BKMK_ApproveTimeOffRequest"></a>   
## Approve a time-off request  
  
1. From the main menu, select **Field Service** > **Time Off Requests**.

2. From the list of views, select the arrow, then select **Active Time Off Requests**. This shows a list of unapproved time-off requests.

3. To approve a request, select it, and in the command bar at the top, select **Approve**.

4. When the approval is completed, select **OK**.

5. Approved time-off requests will change to status "Inactive." Inactive records can be found in the view **Inactive Time Off Requests**.
  
### See also  
    
 [Overview of Dynamics 365 for Field Service](../field-service/overview.md)   
 [Create a work order](../field-service/create-work-order.md)   
 [Schedule a work order](../field-service/schedule-work-order.md)   
 [Configure the schedule board](../field-service/configure-schedule-board.md)<br>
 [User's Guide](../field-service/user-guide.md)
