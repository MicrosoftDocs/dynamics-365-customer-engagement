---
title: "Build an approvals feature using Microsoft Flow (Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
description: "Build an approvals feature"
ms.custom: 
  - dyn365-developer
  - dyn365-marketing
ms.date: 08/01/2019
ms.service: dynamics-365-marketing
ms.technology: 
  - marketing
ms.topic: conceptual
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 488e6a2f-81c8-41da-ad4d-bf349abcc468
ms.author: nabuthuk
author: Nkrb
manager: kvivek
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Build approvals feature using Microsoft Flow

By integrating your approvals feature with Microsoft Flow, you can implement features such as these:

- Automatically generate and send request-for-approval emails to approvers.
- Include active approve and reject buttons in request-for-approval emails.
- Easy customization of the approval steps, using a framework that most administrators will be able to understand and adjust for themselves.

To set up an approval workflow in Microsoft Flow:

1. Sign in to [Microsoft Flow](https://flow.microsoft.com/en-us/) with your Dynamics 365 for Marketing credentials.
1. Select the **Solutions** tab from the left pane and then from the list of available solutions, select **Sample Approval**. 
1. Select **New** and then select **Flow**.
1. Enter the **Flow Name** in the upper left corner, select the **Triggers** tab, search for **When a record is updated**, and then select it.
    
   ![Flow details](../media/create-new-flow-with-details.png "Flow details")

1. Enter the following values in the required fields and select **New step**.
   - Environment: Select the environment.
   - Entity Name: Select the customer journey entity.
   - Scope: Set the scope to Organization.

1. In the **Actions** tab, select **Condition**.

    <!--from editor: Why is Common Data Service highlighted in the image? I don't see any mention of it being selected. -->


    ![Actions tab](../media/new-step-select-condition.png "Actions tab")

1. In the **Condition** section, enter the condition parameters as shown here.



    <!-- from editor: About the note, where is the value parameter? -->


   > [!NOTE]
   > The value of the Approval requested should be entered in the value parameter.

    ![Condition parameters](../media/condition-parameter-values.png "Condition parameters")

1. Select **Add an action** in the **If yes** tab, search for **approvals**, and then select **Start and wait for an approval** from the list.


<!--from editor: Should it be "Choose an action" rather than "Add an action"? That's what the image shows. -->


    ![Start and wait for approval](../media/start-and-wait-for-approval.png "Start and wait for approval")

1. In the **Start and wait for an approval** tab, select **Approve/Reject - First to respond** for **Approval type**. Then enter the following details:
   - Title: Enter a title of your choice.
   - Assigned to: Enter the email address of the approver. 
     
      ![Approve/reject](../media/enter-details-for-start-wait-for-approval.png "Approve/reject")

1. Select **Add an action** to add one more action to the **Start and wait for an approval** tab, select **Condition** from the **Actions** tab.


<!--from editor: Again, should it be "Choose an action" instead of "Add an action"?-->



1. Enter the condition parameter values as shown below.

   ![Condition parameters 2](../media/condition-two-parameter-values.png "Condition parameters 2")

1. Select **Add an action** in the **If yes** tab, select **Common Data Service**, and then select **Update a record**.


    <!--Should it be "Choose an action" in the sentence above? Also, "Update a record" isn't highlighted in the screenshot. -->


    ![Update a record](../media/select-cds-from-list.png "Update a record")

1. Enter the details as shown here:

    - Environment: Select the environment. It should be the same as the one you selected earlier.
    - Entity Name: Select customer journey entity from the list.
    - Record identifier: Set the customer journey ID.
    
    <!-- The following is an action so shouldn't be part of the above list. Also, where is "Show advanced options"? I don't see it in the screenshot. --> 
    
    Select **Show advanced options** and set the Status reason value to **Approved**.
      
       ![Enter record details](../media/update-a-record-enter-values.png "Enter record details")


1. In the **If no** tab, select **Add an action**, select **Common Data Service**, and then select **Get record**.

    <!-- Change to "Choose an action"? Also, do they need to select "Actions", which is highlighted? -->


    ![Get record](../media/if-no-select-cds-get-record.png "Get record")

1. Enter the details in the required fields as shown below.

    ![Enter get record details](../media/enter-details-for-the-record.png "Enter get record details")

1. Select **Add an action**, select **Common Data Service**, and then select **Update a record**.


    <!-- Again, should it be "Choose an action"? And do they need to select "Actions"? -->


    ![If no update a record](../media/if-no-cds-update-record.png "If no update arecord")

1. Enter the values as shown below.

    ![Enter record details for If no](../media/if-no-update-record-enter-values.png "Enter record details for If no")

1. Select **Save** and then select **Flow Checker** to verify if there are any errors in the flow.

## See also
[Build an approvals feature](marketing-approvals-feature.md)
