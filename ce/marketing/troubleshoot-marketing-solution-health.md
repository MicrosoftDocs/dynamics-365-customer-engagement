---
title: "Troubleshoot issues with Solution Health Hub for Marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to troubleshoot issues with Dynamics 365 Marketing using Solutions Health Hub"
keywords: solutions health hub troubleshoot
ms.date: 04/13/2020
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
ms.assetid: a52e468a-b81e-4598-aa3a-b0670c333e42
author: alfergus
ms.author: alfergus
manager: shellyha
ms.reviewer:
topic-status: 
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Troubleshoot Marketing issues with Solution Health Hub

Solution Health Hub allows you to get a better picture of the state of your environment and detect issues with your Dynamics 365 environment. The Solution Health Hub runs rules within an instance to validate the environment's configuration, which might change over time through natural system operations. Some of the rules are specific to Dynamics 365 Marketing and you can run the rules on demand when you encounter an issue. Marketing rules can be executed from the backend automatically, outside of business hours to ensure minimal disruption to your Marketing processes.

Here are a few common issues the Solution Health Hub detects:

1. If critical Marketing processes are deactivated.
1. If processes that will cause an upgrade to fail are assigned to disabled users.
1. Customized web resources that will later lead to runtime issues.

If you want to opt out from automatically executing the Marketing ruleset, complete the following steps:

1. 

## Prerequisites

- Marketing v1.35.10057.1054 or later.
- The Solution Health Hub extends the [Power Apps checker](https://docs.microsoft.com/powerapps/maker/common-data-service/use-powerapps-checker) to ensure continued healthy operation of an environment.

> [!Note]
> Currently, the ruleset uses five rules to verify the environment is in a good state.

## Run a health check

To run an analysis job for Marketing:

1. Open the Solution Health Hub app.

> ![Screenshot of the Solution Health Hub in the navigation](./media/troubleshoot-solution-health-nav.png)

2. On the welcome screen, select **Continue** in the lower right.
1. Select **Analysis Jobs** and create a new analysis job.
1. When the dialog box opens, select **Marketing rule set**.
1. Select **OK** and the analysis job will begin.

> ![Screenshot of the Solution Health Hub with attention to the "new" option under analysis jobs](./media/troubleshoot-solution-health-marketing-rules.png)

These are the rules currently included for Marketing:

| Rule name: | What it checks: |
| --- | --- | 
| CheckIffSdkMessageProcessingStepsAreActive    | Checks whether any [SDK Message Processing Steps](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/developer/entities/sdkmessageprocessingstep) are disabled. Disabled SDK Message Processing Steps result in incorrect behavior when using Dynamics 365 Marketing. | 
| CheckIfProcessOwnedByDisabledUsers    | Checks whether there are any process definitions in the system that are assigned to users that are disabled. If that's the case, upgrading will fail. | 
| CheckIfProcessesAreActive    | Checks whether there are any process definitions in draft status. If there are processes in draft status, Marketing will not work correctly. | 
| MissingMktConfiguration    | Checks for the presence of a Marketing configuration entity record. If the configuration entity record is missing, Marketing will not work properly. | 
| MissingRolesToApplicationUser    | Checks whether MarketingServices ApplicationUser has all required roles assigned. If some of the roles are missing, the Marketing application might not work properly. |

## View health check results

Once you run the analysis job, you will be directed to the overview page, which will automatically refresh when the run has finished. See the following screenshot for an example overview of a run.

> ![Screenshot of a complete analysis job overview](./media/troubleshoot-solution-health-fs-rules-analysis.png)

When running an analysis job, you will see a **Return Status** for each rule, which indicates whether the rule passed, failed, or there was a configuration error. Rules also return a severity if they are failing, which shows how severe each problem is. All possible return status outcomes are listed in the following table.

| Rule return status |     Recommendation|
| --- | --- |  
| Fail    | Highlight specific failures within the system; fix the rule as suggested.| 
| Warning    | Be aware of the implications mentioned in the rule message.| 
| Pass    | Indicates that there are no problems with this rule. All rules should be in this state.| 
