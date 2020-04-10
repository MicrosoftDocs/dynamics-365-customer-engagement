---
title: "Troubleshoot issues with Solution Health Hub for Marketing (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to troubleshoot issues with Dynamics 365 Marketing using Solutions Health Hub"
keywords: solutions health hub troubleshoot
ms.date: 04/10/2020
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

Solution Health Hub allows you to get a better picture of the state of your environment and detect issues with your Dynamics 365 environment. The Solution Health Hub runs rules within an instance to validate the environment's configuration, which might change over time through natural system operations. Some of the rules are specific to Dynamics 365 Marketing and you can run the rules on demand when you encounter an issue. Some rules automatically trigger when Marketing is installed or updated. Regularly run the Marketing ruleset to monitor the health of your environment.

Here are a few common issues the Solution Health Hub detects:

1. If critical Marketing processes are deactivated.
1. If processes that will cause an upgrade to fail are assigned to disabled users.
1. Customized web resources that will later lead to runtime issues.

## Prerequisites

- Field Service v8.4.0.338+ (Unified Interface) or  v7.5.7.87+ (Web)
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
| CheckIffSdkMessageProcessingStepsAreActive    | | 
| CheckIfProcessOwnedByDisabledUsers    | | 
| CheckIfProcessesAreActive    | | 
| MissingMktConfiguration    | | 
| MissingRolesToApplicationUser    | |

## View health check results

Once you run the analysis job, you will be directed to the overview page, which will automatically refresh when the run has finished. See the following screenshot for an example overview of a run.

> ![Screenshot of a complete analysis job overview](./media/troubleshoot-solution-health-fs-rules-analysis.png)

When running an analysis job, you will see a **Return Status** for each rule, which indicates whether the rule passed, failed, or there was a configuration error. Rules also return a severity if they are failing, which shows how severe each problem is. All possible return status outcomes are listed in the following table.


| Rule return status |     Recommendation|
| --- | --- |  
| Fail    | Highlight specific failures within the system; fix the rule as suggested.| 
| Warning    | Be aware of the implications mentioned in the rule message.| 
| Pass    | Indicates that there are no problems with this rule. All rules should be in this state.| 
