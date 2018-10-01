---
title: "Manage playbook templates (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Create and manage playbook templates to help your team consistently perform recurrent business processes such as a sales process."
keywords: "playbook, consistent, activity, sales process, business process, best practice"
ms.date: 10/01/2018
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 66a9d402-bbf6-48ee-86b6-5f93fc864896
author: shubhadaj
ms.author: shujoshi
manager: annbe
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
topic-status: Tech Reviewing
---

# Manage playbook templates

Playbooks provide users with guidance on recurring tasks in which consistent actions are expected. Playbooks can also contain best practices based on practices that have worked in similar situations before.

## Create a playbook template

1.  Make sure you have the Playbook administrator role or equivalent permissions.

2.  Select the site map icon, select the **More options** ![more options icon](media/more-options-icon.png "More Options icon") icon, and then select **App Settings**.  

3.  Select **Playbook Templates**.

4.  In the **Playbook Template** form, enter the following details, and then select **Save**:

    1. **Category**. Select the category for which you want to create the playbook template. Think of category as an event or an issue that you want to address using this template.

    2. **Name**. Enter a descriptive name for the template.

    3. **Track progress**. Select whether to track the progress of the playbook by creating the activities under a playbook, which is in turn linked to the record type the playbook applies to.

        For example, if you have a template created for an opportunity, and you set Track Progress to **Yes**, all playbook activities are created under the playbook that is launched from the opportunity record in the following hierarchy: Opportunity record &gt; playbook record &gt; activities.

        If you set this to **No**, the playbook activities are created directly under the opportunity record in the following hierarchy: Opportunity record &gt; activities.

    4. **Estimated duration (days)**. Enter the estimated duration in days to indicate the time it may take to complete the playbook template once launched.

        ![information section on playbook template form](media/playbook-template-information-section.png "Information section on Playbook template form")  

5.  In the **Select record types that this playbook applies to** section, the **Available for box** lists all the entities that are enabled for using playbooks. Select and move the record types to which the current playbook template applies into the **Applies to** box.

    The playbook capability is currently only enabled on Lead, Quote, Opportunity, Order, and Invoice record types. As a playbook manager, when you create a playbook template, you can select which entity that playbook applies to.

    ![section to select record types the playbook applies to](media/playbook-applies-to.png "Section to select record types the playbook applies to")  

6.  In the **Playbook Activities** section, select **Add Activity**, and then select the activity you want to create.

    ![add playbook activity](media/add-activity.png "Add playbook activity")  

    For example, if the playbook is defined for an event in which a decision maker leaves the organization while working with a sales person, you may create a phone call record to make a call to the new decision maker, and fix an appointment.

7.  In the **Quick create** form of the activity, enter the following information, and then select **Save**:

    1.  **Subject**. Type a short description of the objective of the activity.

    2.  **Description**. Type additional information to describe the playbook activity.

    3.  **Relative due date (days)**. Enter the number of days in which the activity will be due. The number of days is counted from the launch date of the playbook. This field is available only for task and phone call activities.

    4.  **Relative due time (hours)**. Enter the time when the activity will be due.

    5.  **Relative start date (days)**. Enter the number of days in which the activity must start. This date is relative to when the playbook is launched.

    6.  **Relative start time**. Enter the time of day when the activity must start.

    7.  **Relative end date (days)**. Enter the number of days by which the activity must end. This date is relative to when the playbook is launched.

    8.  **Relative end time**. Enter the time of day when the activity must end.

    9.  **Duration**. If you’re creating a task or a phone call, select the duration for the task or phone call activity.

    10. **Priority**. Select the priority of the activity.

        ![quick create form for phone call activity](media/quick-create-phone-call-form.png "Quick create form for phone call activity")  

8.  In the lower-right corner, select **Save**.

## Publish a playbook template

You must publish a playbook to make it available for your users.

To publish a playbook, in the list of playbook template records, select the playbook template and on the command bar, select **Publish**.

Or

Open the playbook template and on the command bar, select **Publish**.

> [!NOTE]
> The playbook template you’re trying to publish must have the following:
> -   At least one playbook activity added.
> -   At least one record type to which the playbook template applies.

> [!IMPORTANT]
> After you publish a template, you can’t edit it. To make changes to a published playbook template, on the command bar, select **Revise**.

## Delete a playbook template

If your organization no longer needs a playbook, you can delete it.

> [!IMPORTANT]
> Before you delete a playbook template, make sure that it isn’t associated with another record. If the **Track progress** field of a playbook template is set to **Yes**, a playbook record is created and associated with the playbook template.

To delete a playbook, in the list of playbook template records, select the playbook template, and on the command bar, select **Delete**.

Or

Open the playbook template and on the command bar, select **Delete**.


### See also
[Enforce best practices with playbooks](enforce-best-practices-playbooks.md)  
[Define playbook categories](define-playbook-categories.md)
