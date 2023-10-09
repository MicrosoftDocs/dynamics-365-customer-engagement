---
title: Create a new case when email subject changes
description: Customize Dynamics 365 to create a new case when a customer replies to an email after changing the subject.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection:
ms.date: 10/09/2023
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/09/2023
  - ai-gen-title
---

# Create a new case when email subject changes

When the email subject on a replied email changes, it doesn’t create new cases in Dynamics 365. Administrators can use regex expressions to define whether a new case should be created when the email subject changes and whether a related active or resolved case exists.  

When a customer replies to an email after removing the content in subject or modifying the subject, no new case gets created in Dynamics 365. This is because the InReplyTo value of the replied email matches with the messageID of the previous email that’s already in Dynamics 365. An email correlation is created and so, the case associated with the previous email gets linked with the replied email. As a result, automatic record creation and update rule skips case creation even if the subject changes.

## Prerequisites

- A new default Boolean field named correlatedsubjectchanged is available for the email entity.  

- The field gets populated as true or false for inreplyto correlated emails, that detects subject changes on the email.  

- A default regex is present to ignore the prefix "Re: ", "re: ", "RE: " from the replied email and then compare the subject with the correlated email’s subject. If the subject matches, the boolean value correlatedsubjectchanged will be set to false. However, if the default regex doesn’t ignore the prefix “Fw: “, “FW: “, “FWD: “from the forwarded email", the boolean value correlatedsubjectchanged will be set to true.  

- If the default regex doesn't serve your subject matching needs, the regex can be customized. You can write regex expressions for multiple languages. For more information, go to: [Regular Expression Language - Quick Reference](/dotnet/standard/base-types/regular-expression-language-quick-reference)

- If you need to edit the regex, use the OrgDbOrgSetting tool using the [guidance](https://github.com/seanmcne/OrgDbOrgSettings).

- Make sure to enable [“Skipped” and “Ready for Power automate” monitored options for activity monitor](/customer-service/automatically-create-update-records?tabs=customerserviceadmincenter#manage-activity-monitor-to-review-and-track-rules) in the Customer Service admin center app.

## Customization steps to create a new case

To define whether automatic record creation and update rules must create a new case or not, you can add a condition to check if the correlatedsubjectchanged field is true and create a case using by performing the customization steps:

1. Go to https://make.powerautomate.com/ and select the environment in which you have automatic record creation and update rules rules configured. 
1. Navigate to **My flows** from the site map and select **+New flow** > **Automated Cloud flow**. The owner of the flow must have read/write/delete privileges to activity monitor entity, if using custom roles. The CSR Manager and System administrator roles have the required privileges by default.

1. Give a meaningful name to the flow and select the trigger: When a row is added, modified or deleted.
1. Click on **Create**.
1. Create a custom flow that will be triggered when case creation is skipped for an email and there is an entry in the activity monitor table with **Skipped** state.
1. Check for email subject change within the flow and execute automatic record creation and update rules child flow to create the case.
    1. In the trigger step, match the values for ‘Change type’, ‘Table name’, ‘Scope’ and ‘Run as’ to the values shown in the example screenshot below:
     <screenshot>

    > [!NOTE]
    > Here, currentstate eq 3 refers to the Activity monitor state as Skipped and reason is equivalent to the following:
    >- An existing entity is already connected with this record.
    >- An active case is already connected with this record.
    >- A resolved case is already connected with this record.
    >- The rule requires a connected case to be resolved for a specific amount of time before creating a new one. This connected case has been resolved for less than the amount of time selected.

    1. Retrieve the email record. Enter **RowID** as **Monitored activity item (Value)**.
    1. Add conditional check to verify if the correlatedsubjectchanged attribute is set to true and proceed only if yes, else terminate. If you have complex conditional logic, we recommend writing your logic in an unbound custom action that gives certain simple structured output such as Boolean, call the custom action in flow and consume the output in a conditional check.
    1. Update the activity monitor status. If the above step is applied (subject doesn’t match), update the current state of that activity monitor ID to **Ready for Power Automate** and set the **Reason** to **blank**.
    1. Continue executing automatic record creation and rules and create case.
    
    By performing the steps, the automatic record creation and rules rule can be conditionally bypassed (based on email subject change condition) and new case can be created.