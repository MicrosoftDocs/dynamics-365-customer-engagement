---
title: "Submit and approve time-off requests | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 01/07/2020
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: 
ms.technology: 
  - field-service
ms.tgt_pltfrm: 
ms.topic: article
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

Keep the schedule board in [!INCLUDE[pn_dyn_365_field_service](../includes/pn-dyn-365-field-service.md)] up to date by logging time-off requests.  
  
For example, if one of your field technicians is taking a vacation, it's important to log the request so that a dispatcher can see the time-off request on the schedule board when scheduling a work order.  
  
When a resource has an approved time-off request, the scheduling assistant will not recommend that resource for a job in that time period, and the time slots for that resource will be grayedout on the schedule board to provide a visual notification to the dispatchers that the resource is not scheduled to be available during that time period.  
  
If a bookable resource is set to require time-off approval, then when a time-off request is created for that resource, an approval request will be sent to that user's manager, before the time-off request is reflected in the schedule assistant and on the schedule board.  




## Prerequsites

For each resource, determine if their time off requests must be approved in order to take effect and show as unavailable on the schedule board. 

Go to **Resource Scheduling > Resources** then edit a bookable resource record. 

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/time-off-resource.png)

Set **Time Off Approval Required** to _Yes_ if the time off needs to be approved in order to take effect, or _No_ if it should take effect immediately once the time off is submitted. This value is No by default.

## Submit a time-off request  

1.  From the main menu, select **Field Service** > **Time Off Requests**.  
  
2.  On the **Active Time Off Request** screen, select **New**.  
  
3.  Use the tooltips to help fill in your information, and then select **Save**.  

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/time-off-request.png)

  

## Approve a time-off request  

If the resource for which the time off request applies to requires an approval, a Field Service Administrator 
  
1. From the main menu, select **Field Service** > **Time Off Requests**.

2. From the list of views, select the arrow, then select **Active Time Off Requests**. This shows a list of unapproved time-off requests.

3. To approve a request, select it, and in the command bar at the top, select **Approve**.

4. When the approval is completed, select **OK**.

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/time-off-approve.png)

5. Approved time-off requests will change to status "Inactive." Inactive records can be found in the view **Inactive Time Off Requests**.


## View time off on the schedule board

> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/time-off-schedule-board.png)

## Edit and delete a time off request

Time off requests can be edited or deleted from the resource's calendar.


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/time-off-delete.png)

> [!Note]
> Deleting a time off request record will not delete the time off from the schedule board or resource's calendar.

## Additional notes

- security role needed
  
### See also  
    
 [Set up bookable resources](../field-service/set-up-bookable-resources.md)   

