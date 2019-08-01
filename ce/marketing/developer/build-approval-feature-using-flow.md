---
title: "Build an approvals feature using Microsoft flow(Dynamics 365 for Marketing Developer Guide) | MicrosoftDocs"
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
manager: kvivek
search.audienceType: 
  - developer
search.app: 
  - D365CE
  - D365Mktg
---

# Build approvals feature using Microsoft Flow

We recommend that you integrate your approvals feature with Microsoft Flow. This will help you implement features such as:
- Automatically generate and send request-for-approval emails to approvers.
- Include active approve and reject buttons in request-for-approval emails.
- Easy customization of the approval steps, using a framework that most administrators will be able to understand and adjust for themselves.

To set up an approval workflow in Microsoft Flow:

1. Sign in to [Microsoft Flow](https://flow.microsoft.com/en-us/) with your Dynamics 365 for Marketing credentials.
1. Select **Solutions** tab from the left pane, from the list of available solutions, select **Sample Approval** solution, click on **New** and select **Flow**.
1. Enter the **Flow Name** on the top left corner and select **Triggers** tab and search for **When a record is updated** and select that as shown below.
    
   ![Flow details](../media/create-new-flow-with-details.png "Flow details")

1. Enter the following values in the required fields and click on **New step**.
   - Environment: Select the environment.
   - Entity Name: Select the customer journey entity
   - Scope: Set the scope to Organization

1. In the **Actions** tab, select **Condition**.

    ![Actions conditions tab](../media/new-step-select-condition.png "Actions conditions tab")

1. In the **Condition** section, enter the condition parameters as shown below
   > [!NOTE]
   > The value of the Approval requested should be entered in the value parameter

    ![Condition parameters](../media/condition-parameter-values.png "Condition parameters")

1. Select **Add an action** in the **If yes** tab, search for **approvals** and select **Start and wait for an approval** form the list.

    ![Start and wait for approval](../media/start-and-wait-for-approval.png "Start and wait for approval")

1. In the **Start and wait for an approval** tab, select **Approve/Reject - First to respond** option for **Approval type**. Enter the following details in **Start and wait for an approval** tab
   - Title: Enter the name of the title you wish.
   - Assigned to: Enter the email address of the person. In this case, it should be the email address of the person who has to approve.
     
      ![Approve/reject](../media/enter-details-for-start-wait-for-approval.png "Approve/reject")

1. Select **Add an action** to add one more action to the **Start and wait for an approval** tab, select **Condition** from the **Actions** tab.

1. Enter the condition parameter values as shown below.
   ![Condition parameters 2](../media/condition-two-parameter-values.png "Condition parameters 2")

1. Select **Add an action** in the **If yes tab**, click on **Common Data Service** and select **Update a record**.

    ![Update a record](../media/select-cds-from-list.png "Update a record")

1. Enter the details as shown below
    - Environment: Select the environment, it should be the same that you have selected earlier.
    - Entity Name: Select customer journey entity from the list.
    - Record identifier: Set the customer journey id.
    - Click on Show advanced options and set Status reason value to Approved.
      
       ![Enter record details](../media/update-a-record-enter-values.png "Enter record details")


1. Now in the **If no** tab, select **Add an action**, select **Common Data Service**, and select **Get record**.

    ![Get record](../media/if-no-select-cds-get-record.png "Get record")

1. Enter the details in the required fields as shown below

    ![Enter get record details](../media/enter-details-for-the-record.png "Enter get record details")

1. Click on **Add an action**, select **Common Data Service** and select **Update a record**.

    ![If no update a record](../media/if-no-cds-update-record.png "If no update arecord")

1. Enter the values as shown below.

    ![If no enter update record details](../media/if-no-update-record-enter-values.png "If no enter update record details")

1. Click on **Save**. Click on **Flow Checker** to verify if there are any errors in the flow.

## See also
[Build an approvals feature](marketing-approvals-feature.md)
