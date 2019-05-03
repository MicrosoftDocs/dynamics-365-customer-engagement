---
title: "Troubleshooting: Use Solution Health Hub to maintain healthy operation of your environment | MicrosoftDocs"
ms.custom: 
ms.date: 04/18/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 
caps.latest.revision: 
author: jasoncohen
ms.author: matp
manager: kvivek
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---


<!--note from editor:  PowerApps checker link below didn't work for me.  -->

# Use the Solution Health Hub to maintain healthy operation of your environment
The Solution Health Hub extends the [PowerApps checker](/powerapps/maker/common-data-service/use-powerapps-checker) to ensure continued
healthy operation of an environment. Where the PowerApps checker reviews code
present in an environment to validate the health of the environment based on
predefined rules, the Solution Health Hub runs rules within an instance to
validate the configuration of the environment, which might change over time through
natural system operations.

 > [!div class="mx-imgBorder"] 
 > ![](media/solution-health-hub-1.png  "Solution Health Hub")

The Solution Health Hub allows the creation of rules, which can be run in an
instance, that will raise awareness of issues or potential issues that impact
the health of the instance. A rule set can be created to validate any
potentially problematic configuration from which an app maker might want
to protect users.

With rule sets in the system, the Solution Health Hub puts the power to resolve
common problems into the hands of an administrator. Analysis jobs run against a
defined rule set and provide specific pass or failure validations with actions
an administrator can take to resolve any detected problems.

## Run a rule using the Solution Health Hub app
The Solution Health Hub is available as an app installed in each instance.

![Navigate to the Solution Health Hub](media/solution-health-hub-2.png)

To run a rule, administrators follow these steps: 

1.  Open the **Solution Health Hub** app.
2.  Select **Analysis Jobs** and create a new analysis job.
3.  When the dialog box opens, select the **Rule Set** you want to run.
4.  Select **OK**.

Within the analysis job record that is created, **Status** indicates whether
or not the job has completed.

Once the job has completed, the rules within the set show up in the **Analysis Results** grid.

 > [!div class="mx-imgBorder"] 
 > ![](media/solution-health-hub-3.png  "Analysis results")

Each analysis result contains the following information:
-   **Message** indicates whether the rule successfully completed.
-   **Return Status** indicates whether the rule passed, failed, or whether there
    was a configuration error.

## Resolve analysis results failures
In cases where the **Return Status** indicates **Fail**, the analysis results might
have details that highlight specific failures within the system. These analysis-results detail records contain more information about each specific failure of a rule that was detected in that analysis job.

 > [!div class="mx-imgBorder"] 
 > ![](media/solution-health-hub-5.png  "Analysis results detail")

In cases where the rule is configured with the ability to resolve detected
issues, there is the option to resolve each failure. To do this, select the
analysis-results detail, and then select **Resolve**.

 > [!div class="mx-imgBorder"] 
 > ![](media/solution-health-hub-4.png  "Analysis results resolve")

Analysis-results details provide insights into the failure. In most cases, the failure occurs because the records are configured incorrectly.


