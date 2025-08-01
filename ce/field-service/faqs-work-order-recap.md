---
title: FAQ about work order summary with Copilot and summary configuration
description: Get answers to common questions about how the AI-powered work order summary feature in Dynamics 365 Field Service helps you quickly understand the status and details of a work order.
ms.date: 07/29/2025
ms.update-cycle: 180-days
ms.custom:
  - responsible-ai-faqs
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/26/2023
  - bap-template
ms.topic: faq
author: m-hartmann
ms.author: mhart
ms.reviewer: jacohen
ms.collection: bap-ai-copilot 
---

# FAQ about work order summary with Copilot and summary configuration

The work order summary is an AI-powered tool that gives you a quick and smart summary of your work orders and their related data. Summary configuration allows administrators to specify which data fields go into the summary. In this article, you get answers to common questions about how these features work and what their limitations are.

## What is the work order summary feature?

The [work order summary feature](use-work-order-recap.md) in Dynamics 365 Field Service uses AI to give service managers, dispatchers, and frontline workers a concise, relevant summary of a work order and its related data. The summary is a snapshot of the work order's status, history, progress, and next steps. It also includes important information such as arrival times, work criticality, and parts usage.

To customize the summary, an administrator can use the summary configuration feature to choose the data fields that Copilot uses to summarize a record in Field Service.

## What are the feature's capabilities?

The work order summary uses your security role to access the data that you can see and summarizes it based on the work order's status. The summary might include:

- A summary of the work order's problem, resolution, and customer feedback
- Booking details such as start and end time, travel time, and resource
- Activities such as phone calls, emails, and appointments
- Notes from the technician or other users
- Products, services, and service tasks that are required or completed for the work order
- Additional information such as requirement characteristics, asset details, and invoice information, depending on the work order's status

The feature doesn't save the summary, and it doesn't expose any sensitive data that you don't have permission to see.

To customize the summary, an administrator can turn on the summary configuration feature to choose the desired fields to be summarized by choosing the table and column from drop downs. Once the selection is made, the administrator can test the configuration by generating a preview summary using actual data from a record.

## What is the feature's intended use?

You can use work order summary to quickly understand the state of a work order at any stage of its lifecycle. The feature provides a context-specific summary that helps you decide what actions to take or what details to investigate further. It's not a substitute for a thorough review of the work order and its related information.

An administrator can tailor the Copilot summary to include only the fields needed for the scenario, so the summary is more relevant to a frontline worker's needs.

## How was the feature tested and what metrics are used to measure its performance?

We tested the feature in English. For detailed information on the supported languages, [Explore Copilot features by geography and languages](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

We checked the accuracy and performance of the summary based on the data from the work order. The summary quality depends on the quality of the data in the system. If the data is incomplete or incorrect, the summary might reflect that.

We didn't find any cases where the summary made up information that wasn't in the data. However, we did find some cases where the summary didn't summarize the data correctly.

## What are the limitations of the feature and how can I minimize their impact?

You can help us by giving us feedback using the like/dislike buttons on the summary. We use this data to evaluate and improve the quality of the content.

This feature works only when you're online. You can't use it offline.

This feature is tested in English. If you use it in other languages, you might get inaccurate summaries.

This feature summarizes the data you can see in the system. If you don't have the right permissions or the data is poor, the summary might not be useful. The summary quality matches the input quality.

The default work order summary uses predefined optimizations. These optimizations don't apply when you enable the summary configuration feature.  

## What operational factors and settings allow for effective and responsible use of the feature?

Administrators can enable or disable the feature for your environment in the Field Service settings by toggling the **Copilot recap** option.

To customize the summary, an administrator can enable **configure summary** to choose the fields that Copilot uses to generate the summary. No other aspects of the prompt can be customized. However, the feature respects your personalization settings for date/time format and time zone, as well as your environment-specific table and field labels. Administrators should test the chosen configuration with data from a record before saving the change.

[Learn more about the data collection policy of this feature](/dynamics365/faqs-copilot-data-security-privacy).

## Can I add the summary to other forms or records?

The form component is called **Copilot recap**. By default, it's available only on the new work order experience form. An administrator can [add the control to other work order forms](/power-apps/maker/model-driven-apps/additional-controls-for-dynamics-365-for-phones-and-tablets#using-controls-in-the-form-designer).

The control uses the system status of the work order to generate a contextually relevant summary. It doesn't save the generated content in the system, and it binds the summary to the **System Status** column.

The control works only with work orders. You can't use it to summarize other records.

### See also

- [Summarize work orders with Copilot](use-work-order-recap.md)
- [Responsible AI FAQ for Dynamics 365 Field Service](responsible-ai-overview.md)

[!INCLUDE [footer-include](../includes/footer-banner.md)]
