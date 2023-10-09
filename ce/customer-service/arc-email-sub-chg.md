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

<!--add your content here-->

<!--H2s. Required. A how-to article explains how to do a task. The bulk of each H2 should be a procedure.-->

## Customization steps to create a new case

A new OOB Boolean field named correlatedsubjectchanged is available for the email entity.  

The field gets populated as True/false for inreplyto correlated emails, that would detect subject changes on the email.  

An OOB regex is present to ignore the prefix "Re: ", "re: ", "RE: " from the replied email and then compare the subject with the correlated email’s subject. If the subject matches, the boolean value correlatedsubjectchanged will be set to false. However, OOB regex doesn’t ignore the prefix “Fw: “, “FW: “, “FWD: “from the forwarded email and hence the boolean value correlatedsubjectchanged will be set to true.  

The OOB regex should work for majority of your scenarios. However, if the OOB regex doesn't serve your subject matching needs, the regex can be customized. You can write regex expressions for multiple languages. For more information, refer: Regular Expression Language - Quick Reference | Microsoft Learn  

If you need to edit the regex, you could use the OrgDbOrgSetting tool using the guidance provided here - https://github.com/seanmcne/OrgDbOrgSettings  

If C2 replies or forwards an old email after changing the subject, you can define whether ARC should create a new case or not. For this, you can add a condition to check if the correlatedsubjectchanged field is true, and create a case using ARC by following the customization steps below:  

As a pre-requisite, make sure to enable “Skipped” and “Ready for Power automate” monitored options for activity monitor in Customer Service admin center. For more information, refer - https://learn.microsoft.com/en-us/dynamics365/customer-service/automatically-create-update-records?tabs=customerserviceadmincenter#manage-activity-monitor-to-review-and-track-rules  

Go to https://make.powerautomate.com/ and select the environment in which you have ARC rules configured. Navigate to My flows from sitemap and select +New flow>Automated Cloud flow. The owner of the flow needs to have read/write/delete privileges to activity monitor entity if using custom roles. OOB roles of CSR Manager and System administrator both have the required privileges.   

Give a meaningful name to the flow and select the trigger – When a row is added, modified or deleted. Click on Create. Create a custom flow that should be triggered when case creation gets skipped for an email and there is an entry in Activity monitor table with Skipped state. Check for email subject change within the flow and execute ARC child flow to create the case. Below are the detailed steps –  

Step 1: In the trigger step, match the values for ‘Change type’, ‘Table name’, ‘Scope’ and ‘Run as’ to the values shown in the example screenshot below: 
## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
