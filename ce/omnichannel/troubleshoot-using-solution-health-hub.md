---
title: "Troubleshoot with Solution Health Hub in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn how to troubleshoot issues in Omnichannel for Customer Service using the Solution Health Hub."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 07/20/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Troubleshoot issues in Omnichannel for Customer Service using Solution Health Hub

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

Solution Health Hub allows you to get a better picture of the state of your environment and detect issues with your Dynamics 365 environment. The Solution Health Hub runs rules within an instance to validate the environment's configuration, which might change over time through natural system operations. Some of the rules are specific to Omnichannel for Customer Service;  you can run the rules on demand when you run into an issue. Some rules automatically trigger when Omnichannel for Customer Service is installed or updated. You can regularly run the Omnichannel for Customer Service ruleset to monitor the health of your environment.

The Solution Health Hub helps detect the following issues:

- Check for missed or wrong configurations
- Queues with no agents
- Agents with no capacity
- Agents who are not part of any queues
- Work stream configuration check

## Prerequisites

Omnichannel for Customer Service base package 1.5.0.383 or later.

## Run a health check

Perform the following steps to run an analysis job to check for issues in Omnichannel for Customer Service:

1. Open the Solution Health Hub app.
2. Select **Analysis Jobs** > **New**.
3. On the **Create Analysis Job** dialog box, select **Omnichannel** in **Rule Set**, and select **OK**. The analysis job starts.
 
## Analyze the health check results

 After the analysis job completes its run, the results are displayed on the **Job Details** tab.
   > ![Analysis job results](./media/oc-solution-health-results.png "Analysis job results")

The following information is available:

- **Name:** Name of the analysis job.
- **Status:** Indicates the status of the run.
- **Start Time:** Indicates the date and time when the job was started.
- **End Time:** Indicates the date and time when the job completed its run.
- **Failed Rules:** Indicates the number of rules that failed.
- **Warnings:** Indicates the number of rules that resulted in warnings.
- **Passed Rules:** Indicates the number of rules that have passed successfully.
- **Total Rules** Indicates the number of available rules.
- **Rule Run Count:** Indicates the count of rules that have been run.

The result details of the rules are displayed in a table as follows:

- **Name:** Name of the rule.
- **Message:** Includes a brief summary of the result.
- **Return Status:** Whether the rule passed, failed, or returned a warning.
- **Severity:** Indicates the severity level.

You can do the following:

1. Select a rule whose status appears as failed. The analysis results of the objects that failed are displayed in the **Failing Records** area.
2. Optionally, select the **Summary** tab to view the overview of the results.

## Out-of-the-box rule sets

When you run the analysis job, the following out-of-the-box rules that cannot be edited are run.

| Rule | Description |
|----|--------|
| Agents should have capacity | Verifies that capacity is defined for agents. |
| Omnichannel service endpoint should be configured | Verifies that Omnichannel for Customer Service endpoint is configured. `*not sure what this means*`|
| Queues should have agents | Verifies that the queues that are assigned to the work streams have agents assigned. |
| SDK message/plugins should be active | Verifies that the SDK messages or plugins are active. |
| Work stream capacity should be less than agents | Verifies that the capacity defined for agents is more than what is defined for the work streams. |
| Work stream should have notification templates set | Verifies that notification templates have been set for work streams. |
| Work stream should have session template set | Verifies that session template have been set for work streams. |
| Work stream should not have duplicate context variables | Verifies that duplicate context variables haven't been defined for work streams. |
| Work stream should not have empty routing rules above rules with condition | Verifies that empty routing rules haven't been defined for a work stream that prevent routing rules with a lower priority from running. |
| Work stream with push mode should not allow offline mode | Verifies that offline is not an allowed presence for work streams that have push mode enabled. |

### See also

[Troubleshooting Omnichannel for Customer Service](troubleshoot-omnichannel-customer-service.md)  
[Frequently asked questions](faqs.md)  
