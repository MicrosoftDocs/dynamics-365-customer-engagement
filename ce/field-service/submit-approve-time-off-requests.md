---
title: Submit and approve time-off requests
description: Discover how to submit and approve time-off requests in Dynamics 365 Field Service
ms.date: 08/13/2024
ms.topic: how-to
author: ryanchen8
ms.author: chenryan
---
# Submit and approve time-off requests

Keep the schedule board in Dynamics 365 Field Service up to date by logging time-off requests.  
  
For example, one of your field technicians is taking a vacation. It's important to log the time-off request so that a dispatcher can see it on the schedule board when scheduling a work order.  
  
When a resource has an approved time-off request, the scheduling assistant doesn't recommend that resource for a job during that period. The time slots for that resource are grayed out on the schedule board to provide a visual notification to the dispatchers that the resource isn't available.  
  
If a bookable resource is set to require time-off approval, an approval request is sent to that user's manager before the time-off request shows in the scheduling tools.  

## Set up a time-off approval

If a resource must have their time-off requests approved before their time shows as unavailable on the schedule board, perform the following steps.

1. In Resource Scheduling, select **Resources**.

1. Open a bookable resource and select the **Field Service** tab.

1. Set the **Time-Off Approval Required**:
   - **Yes**: Indicates the time-off must be approved first.
   - **No**: Indicates the time-off takes effect immediately. No is the default value.

   :::image type="content" source="media/time-off-resource.svg" alt-text="Screenshot of a bookable resource with the Time Off Approval Required field set to yes.":::

1. Select **Save & Close**.

## Submit a time-off request  

1. In **Field Service**, under **Scheduling** select **Time Off Requests**.  
  
1. Select **New** and use the tooltips to help fill in your information. Then select **Save & Close**.  

## Approve a time-off request  

If the related resource requires approval, a **Field Service-Administrator** or **Field Service-Dispatcher** must approve the request. If you use custom column security profiles, [set up column-level security permissions](/power-platform/admin/set-up-security-permissions-field) and give users **Update** permissions for the *msdyn_ApprovedBy* column in the *msdyn_TimeOffRequest* table. Disabling the *msdyn_ApprovedBy* column-level security in the *msdyn_TimeOffRequest* table doesn't allow users to approve time-off requests.

1. In **Field Service**, under **Scheduling** select **Time Off Requests**.

1. In the **Active Time Off Requests** view, select a request.

   :::image type="content" source="media/time-off-approve.svg" alt-text="Screenshot of active time-off requests highlighting the Approve option.":::

1. Select **Approve**. When the approval is completed, select **OK**.

Approved time-off requests change to the status of *Inactive*. Inactive records can be found in the **Inactive Time Off Requests** view. Additionally, time-off requests show in the resource's calendar along with their normal working hours.

## View time-off on the schedule board

Once the time-off request is created or approved, depending on whether the resource requires approval or not, the resource's time-off time range shows as unavailable on the schedule board.

:::image type="content" source="media/time-off-schedule-board.svg" alt-text="Screenshot of the schedule board showing time-off greyed out.":::

These time-off hours are displayed and treated the same as nonworking hours.

## Edit or delete a time-off request

Time-off requests can only be edited or deleted from the resource's calendar. Once submitted, you can't edit a time-off from the Field Service mobile app while it's running in offline mode. Deleting a time-off request record doesn't delete the time-off from the schedule board or resource's calendar.

1. In Resource Scheduling, select **Resources**.

1. Select the bookable resource and select **Show Work Hours**.

1. Select the time-off.

   :::image type="content" source="media/time-off-edit-delete.svg" alt-text="Screenshot of the monthly view of a resource's work hours, showing the edit and delete option.":::

1. Select **Edit** or **Delete** to edit the time-off or delete it. Then select **Save & Close**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
