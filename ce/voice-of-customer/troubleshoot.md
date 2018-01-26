---
title: "Troubleshoot Voice of the Customer | MicrosoftDocs"
description: "Learn how to troubleshoot Voice of the Customer solution in case any issue occurs."
keywords: "troubleshoot voice of the customer"
ms.date: 01/26/2018
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: C3787135-8818-42F6-A63C-F968EBB60802
author: sbmjais
ms.author: shjais
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Troubleshoot Voice of the Customer solution

This chapter provides information for troubleshooting the Voice of the Customer solution in case any issue occurs.

## Reconfigure Voice of the Customer

If the Voice of the Customer solution is accidentally deleted or misconfigured, it may not be able to receive survey responses. To remediate this, you can now repair or restore the Voice of the Customer configuration from the **Voice of the Customer Configurations** page.

> [!Note]
> You must be a survey administrator to reconfigure Voice of the Customer solution.

1. Sign in to [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)].
2. Go to **Settings** > **Voice of the Customer Configurations**.
3. Select **Configure** from the toolbar at the top of the screen.

  ![Configure Voice of the Customer](media/reconfigure-voc.png "Configure Voice of the Customer")  

> [!Note]
> If the solution cannot be reconfigured properly, an error message is displayed with the related information.

## Validate Voice of the Customer solution

As a Survey Administrator, you can validate the status for your Voice of Customer solution. Validation allows you to check whether:
- Voice of the Customer configuration and provisioning is in proper state.
- Survey lifecycle is working fine for the organization.
- Survey responses are being received properly.

To validate Voice of the Customer solution:
1.	Sign in to [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)].
2.	Go to **Settings** > **Voice of the Customer Configurations**.
3.	Select **Voice of the Customer Configuration** from the list of active configurations.
4.	Select **Validate** from the toolbar at the top of the screen. A confirmation message is displayed asking your consent for the validation process to start.
5.	Select **OK** in the confirmation message if you agree to start the validation process. The results are displayed under the **Voice of the Customer Validation Results** area.
6.	Select **Download Log File** to download the detailed report.

## Validate a survey

As a Survey Administrator, you can validate whether a survey has created any issues.
1.	Sign in to [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)].
2.	Go to **Voice of the Customer** > **Surveys**.
3.	Select the name of the survey you want to validate.
4.	Select **Validate Survey** from the toolbar at the top of the screen. A confirmation message is displayed asking your consent for the validation process to start with or without publishing the survey.
5.	Select one of the following buttons in the confirmation message:
  - **Validate with Publish**: All the validation tests are performed.
  - **Validate without Publish**: Only the validation tests that do not require publishing the survey are performed.
  - **Cancel**: Cancels the operation.
6.	Select the .txt file under **Survey Validation Result** in the **Notes** section and save it to the location you want.

### See also
[Plan a survey](plan-survey.md)   
[Design a basic survey](design-basic-survey.md)   
[Design an advanced survey](design-advanced-survey.md)   
[Distribute a survey](distribute-survey.md)
[Analyze survey data](analyze-survey-data.md)