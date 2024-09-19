---
title: Copilot in Dynamics 365 Sales FAQs
description: This article includes frequently asked questions about Copilot in Dynamics 365 Sales, covering various aspects such as privacy, data security, data management, and more.
author: lavanyakr01 
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.topic: conceptual
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ms.date: 09/19/2024
---

# Copilot in Dynamics 365 Sales FAQs

This article includes frequently asked questions about Copilot in Dynamics 365 Sales.

## How does the data flow between Dynamics 365 and Azure OpenAI endpoints?

When you type a question in the Copilot pane, we pass the relevant data to Azure OpenAI Service through our plug-ins and services. We'll release a high-level architecture document around the GA timeframe.

## Does Copilot have abuse monitoring and human review?

No. Our Azure OpenAI resources have opted out of [abuse monitoring and human review](/legal/cognitive-services/openai/data-privacy#how-can-customers-get-an-exemption-from-abuse-monitoring-and-human-review). This helps us ensure that we don't retain any of your data outside the Dynamics 365 data boundary. Learn more about this aspect in [Copilot data security and privacy for Dynamics 365 and Power Platform](/dynamics365/faqs-copilot-data-security-privacy).

## What data is included in the requests?

The data included in the requests varies based on the type of request made. For example, when you attempt to summarize an opportunity, the relevant fields of the opportunity and associated metadata are pushed to the Azure OpenAI endpoint to generate a summary.

## Is any of my data stored outside of Dynamics 365?

No, we don't save any of your data in any new data store. You can read more about the [Azure OpenAI data and privacy commitments](/azure/ai-services/openai/faq#data-and-privacy).

## How does Copilot encrypt data?

All data exchanges in Copilot are handled according to [Microsoft data management guidelines](https://www.microsoft.com/trust-center/privacy/data-management).

## What privacy controls apply to the data received by Azure OpenAI Service?

All data continues to be handled according to [Microsoft privacy guidelines](/compliance/assurance/assurance-privacy). You can read more about the Azure OpenAI data and privacy commitments at [Data and Privacy](/azure/ai-services/openai/faq#data-and-privacy).

## Where are the Azure OpenAI endpoints hosted?

Currently, the Azure OpenAI endpoints are only available in specific regions. For a list of regions where Azure OpenAI endpoints are available, see [this article](/power-platform/admin/geographical-availability-copilot#regions-involved-with-copilots-and-generative-ai-features).

## Do you use my company data to train any of the models?

No. We don't use any customer data to train Azure OpenAI or any other language models.

## In which regions is Copilot in Dynamics 365 Sales available?

For a list of regions where Copilot is available, see the [Copilot international availability report](https://releaseplans.microsoft.com/availability-reports/?report=copilotproductreport).

## What's the difference between Microsoft 365 Copilot for Sales and Copilot in Dynamics 365 Sales?

Copilot for Sales is a seller experience application that's available in Microsoft 365 and Microsoft Teams applications. It lets sellers capture, access, and update CRM data from within Microsoft 365 and Microsoft Teams applications. It also has generative AI capabilities such as record summarization and email content generation. Copilot for Sales works with Dynamics 365 Sales and Salesforce CRM. [Learn more about Copilot for Sales](/microsoft-sales-copilot/introduction). 

Copilot in Dynamics 365 Sales refers to the AI assistant that uses generative AI to summarize opportunities and leads, and generate meeting preparation notes. It's integrated with Dynamics 365 Sales apps. [Learn more about Copilot in Dynamics 365 Sales](copilot-overview.md).

## How does Copilot match leads with contacts and can I customize the matching fields?

Copilot matches leads with contacts based on the lead name, phone number, email address, and company name. The matches are ordered based on the similarity of values in these fields. If you want Copilot to use other fields for matching, you can work with your administrator to [configure the Dataverse search fields](/power-platform/admin/configure-relevance-search-organization). 

> [!NOTE]
> The fields configured by your administrator will be used for all global search operations (Search box in the top navigation bar) in Dynamics 365.

## Which applications are in the exclusion list for Copilot in Dynamics 365 Sales?

Copilot in Dynamics 365 Sales can't be turned on for the following applications:

- msdyn_FSMobile
- msdyn_FieldService
- msdyn_ResourceScheduling
- AppforOutlookModule
- Customerservicehub
- msdyn_CustomerServiceWorkspace
- OmniChannelEngagementHub
- msdyn_ProjectService

## Why does my tenant have Sales Copilot Power Virtual Agents Bot in Copilot Studio? 

Sales Copilot Power Virtual Agents Bot is part of the Dynamics 365 Sales solution and is deployed to all Dynamics 365 Sales environments, irrespective of whether Copilot in Dynamics 365 Sales is enabled or not. The bot is used to authenticate and authorize Copilot only when Copilot in Dynamics 365 Sales is enabled. If you've disabled Copilot in Dynamics 365 Sales, the bot remains dormant on your environment. The bot will be updated automatically. It can't be deleted or disabled either. [Learn more about Copilot Studio](/microsoft-copilot-studio/fundamentals-what-is-copilot-studio).

A related app, Sales Copilot Power Virtual Agents Bot, is also created for your tenant in Azure for authentication and authorization purposes. The app will be renewed when it's nearing expiration. We recommend that you don't delete or disable the app.

## Copilot for emails

The following frequently asked questions are related to Copilot for emails.

### Why is the Email (preview) tab disabled or not available in my organization?

This feature is available only for organizations in North America with early access to Copilot in 2024 release wave 1. If you're in a different region, you must enable the Copilot preview feature to use. More information: [Turn on and set up Copilot in Dynamics 365 Sales](enable-setup-copilot.md).  

### How I enable or disable this feature?

To enable or disable Copilot for email in Dynamics 365 Sales, see [Turn Copilot features on or off in Sales Hub](enable-setup-copilot.md#turn-copilot-features-on-or-off-in-sales-hub).

### Can I enable this feature for specific team members?  

No, you can't enable this feature for specific team members. It's a global setting that applies to all users in your organization.  

### Is this the same as Copilot for Sales in Outlook? How is it different?  

No, there's no difference between Copilot in Dynamics 365 Sales and Copilot for Sales in Outlook. Both features offer the same functionality. However, the interface for Copilot in Dynamics 365 Sales is accessible within the Dynamics 365 Sales apps and may have a version that is slightly older than the one in Outlook.

### What entities are supported for Copilot for emails?

Copilot for email supports the following entities: Account, Contact, Lead, and Opportunity.

### Can I adjust just the length and tone of the email without the system looking into my CRM data?  

Yes. You can adjust the length and tone of the email. More information: [Refine email content with Copilot](/power-apps/maker/model-driven-apps/use-copilot-email-assist#refine-email-content-with-copilot?context=/dynamics365/context/sales-context)

### Why doesn't email thread summary appear sometimes?  

Email summary doesn't appear sometimes due to character limitation. More information: [Considerations for email summary](view-copy-email-summary.md#considerations)

### Why do I see only the Describe the email in some cases?

By design, emails related to **Account** and **Contact**, and new emails display only **Describe the email**. For emails related to **Lead** and **Opportunity**, you'll see additional options such as **Make a proposal**, **Reply to inquiry**, and **Address a concern**.

### Can I save my own prompts to write the emails?  

Currently, you can't save your own prompts to write emails.

### Can Copilot for email work for both Outlook and Dynamics 365 email as the default email experience?  

Yes, Copilot for email work for both Outlook and Dynamics 365 email as the default email experience.

### Can Copilot use a custom email template?  

Currently, you can't use your own templates with Copilot for email.

### Can I provide inputs to adjust the length or tone?  

Yes. You can provide inputs to adjust the length or tone of the email being generated to improve the draft. More information: [Refine suggested content](compose-send-email-copilot.md#refine-suggested-content)  

### Which languages are supported by Copilot for email?  

We're constantly working to add more languages to Copilot in Dynamics 365 Sales. View the list of supported languages for each Copilot feature in the [Copilot international availability report](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

### Can I regenerate the system suggested draft?  

Yes. You can regenerate the system suggested draft. For more information, see the **To start a fresh draft** section in [Refine suggested content](compose-send-email-copilot.md#refine-suggested-content)

### How can I share my feedback?  

To share your feedback, use the thumbs up or down buttons in the **Email (preview)** pane.

### How can I share my ideas or suggestions?

You can use the **Connect and share** icon on the top-right corner of the Sales Hub app to share your ideas and suggestions.

### What are feature enhancements coming soon? 

If you have turned on the preview features, you can see the feature enhancements that are coming soon. To know more, see [Copilot preview features](copilot-preview-features.md)

### Is the system reading my email to train the model?

No. The system isn't reading your email to train the model. 

### If I keep using this feature, will the system learn to write like me? 

No. The system doesn't learn to write like you. It uses the data to generate the content based on the context and the prompt you provide.

### Where can I see the privacy policy or transparency information for this feature?

For information about the privacy policy or transparency, see [FAQ for Copilot data security and privacy for Dynamics 365 and Power Platform](/dynamics365/faqs-copilot-data-security-privacy?context=/dynamics365/context/sales-context).

### Does Copilot automatically send emails on my behalf?

No. Copilot doesn't send the email automatically on your behalf. You have to review and send the email.

## Related information

[Use Copilot in Dynamics 365 Sales](use-sales-copilot.md)  
[Copilot in Dynamics 365 Sales overview](copilot-overview.md)  
[Compose and send email messages using Copilot (preview)](compose-send-email-copilot.md)