---
title: "Get customer feedback by using Voice of the Customer surveys | MicrosoftDocs"
description: "Get started with Voice of the Customer surveys."
keywords: "survey feedback; voice of the customer survey feedback"
ms.date: 11/06/2017
ms.service: crm-online
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 978325d2-4ee2-49eb-a66e-9321695e2979
author: sbmjais
ms.author: shjais
manager: sakudes
ms.reviewer: 
topic-status: Drafting
---

# Get feedback by using Voice of the Customer surveys

You can create and send surveys to your customers to receive their valuable feedback about your products or services. The customers can take your surveys on a phone, tablet, or computer. With Voice of the Customer for [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)], you create and distribute surveys and store survey responses in [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] along with other [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] data. You can see your customer's feedback history as you work on a sales prospect (lead) or resolve a service case.

When a customer completes a survey, leads can be created automatically based on the feedback. You can also create a workflow that sends a survey to a customer, asking for the feedback as soon as a case is closed. Voice of the Customer provides the following workflows out-of-the-box.

| **Workflow name**                                  | **Primary entity** | **[!INCLUDE[description](../includes/description.md)]**                                                                             |
|----------------------------------------------------|--------------------|---------------------------------------------------------------------------------------------|
| VoC - Close Survey Activity                        | Survey Activity    | Close a survey activity when a closing response is received.                                |
| VoC - Convert Response To Feedback Entity          | Survey Response    | Create a feedback entity record corresponding to the survey response.                       |
| VoC - Convert Survey Response To Campaign Response | Survey Response    | Create a campaign response based on the survey invitation and survey response.              |
| VoC - Create Lead                                  | Survey Response    | Create a lead corresponding to the anonymous survey response.                               |
| VoC - Process Face Response                        | Survey Response    | Process the survey response and classify the respondent as promoter, detractor, or neutral. |
| VoC - Process NPS Response                         | Survey Response    | Process the survey response and classify the respondent as promoter, detractor, or neutral. |
| VoC - Process Survey Response                      | Survey Response    | Trigger a workflow based on the survey response.                                            |
| VoC - Unsubscribe respondent                       | Survey Response    | Unsubscribe the respondent from a channel (for example, email) based on the response.       |
|||

More information about creating a new workflow in [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)]: [Create custom business logic through processes](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/customize/guide-staff-through-common-tasks-processes)  

> [!NOTE]
> Voice of the Customer for [!INCLUDE[pn-crm-2016-shortest](../includes/pn-crm-2016-shortest.md)] is available with [!INCLUDE[cc-microsoft](../includes/cc-microsoft.md)] [!INCLUDE[pn-crm-online-2016-update](../includes/pn-crm-online-2016-update.md)] and later.

## Survey lifecycle

A survey goes through various stages as you go from analyzing your requirements to analyzing the responses you get.

**Step 1**: [Plan the survey](plan-survey.md)  

-   Analyze the requirements of the respondents

-   Decide the types of questions you want to include in the survey

**Step 2**: [Design the survey](design-basic-survey.md)  

-   Create a new theme, if required

-   Upload your company logo, if required

-   Create the survey and add questions to it

-   Preview the survey

-   Translate the survey as needed by the respondents

-   Publish and test the survey

**Step 3**: [Distribute the survey](distribute-survey.md)  

-   Distribute the survey to anonymous or non-anonymous respondents

-   Create a workflow to automate survey invitations, if required

**Step 4**: [Analyze survey data](analyze-survey-data.md)  

-   View survey responses

-   Create and analyze reports

### Privacy notice

[!INCLUDE[cc-privacy-crm-voice-of-customer](../includes/cc-privacy-crm-voice-of-customer.md)]
