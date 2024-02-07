---
title: FAQs about Copilot in Dynamics 365 Sales
description: This article includes frequently asked questions about Copilot in Dynamics 365 Sales, covering various aspects such as privacy, data security, data management, and more.
author: lavanyakr01 
ms.author: lavanyakr
ms.topic: conceptual
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ms.date: 02/07/2024
---

# FAQs about Copilot in Dynamics 365 Sales

This article includes frequently asked questions about Copilot in Dynamics 365 Sales.

## How does the data flow between Dynamics 365 and Azure OpenAI endpoints?

When you type a question in the Copilot pane, we pass the relevant data to Azure OpenAI Service through our plug-ins and services. We'll release a high-level architecture document around the GA timeframe.

## Does Copilot have abuse monitoring and human review?

No. Our Azure OpenAI resources have opted out of [abuse monitoring and human review](/legal/cognitive-services/openai/data-privacy#how-can-customers-get-an-exemption-from-abuse-monitoring-and-human-review). This helps us ensure that we don't retain any of your data outside the Dynamics 365 data boundary. We use other techniques to monitor and filter out abusive content at runtime.

## What data is included in the requests?

The data included in the requests varies based on the type of request made. For example, when you attempt to summarize an opportunity, the relevant fields of the opportunity and associated metadata are pushed to the Azure OpenAI endpoint to generate a summary.

## Is any of my data stored outside of Dynamics 365?

No, we don't save any of your data in any new data store. You can read more about the [Azure OpenAI data and privacy commitments](/azure/ai-services/openai/faq#data-and-privacy).

## How does Copilot encrypt data?

All data exchanges in Copilot are handled according to [Microsoft data management guidelines](https://www.microsoft.com/trust-center/privacy/data-management).

## What privacy controls apply to the data received by Azure OpenAI Service?

All data continues to be handled according to [Microsoft privacy guidelines](/compliance/assurance/assurance-privacy). You can read more about the Azure OpenAI data and privacy commitments at [Data and Privacy](/azure/ai-services/openai/faq#data-and-privacy).

## Where are the Azure OpenAI endpoints hosted?

Currently, the Azure OpenAI resources are only available in the North America and Europe regions. If your Dynamics 365 environment is in any other geography, your data will be moved outside of your geography to handle copilot requests. You'll be prompted to consent to this data movement when you enable Copilot in Dynamics 365 Sales. More information: [Copilot data movement](sales-copilot-data-movement.md)

## Do you use my company data to train any of the models?

No. We don't use any customer data to train Azure OpenAI or any other language models.

## What's the difference between Microsoft Sales Copilot and Copilot in Dynamics 365 Sales?

Microsoft Sales Copilot is a seller experience application that's available in Microsoft 365 and Microsoft Teams applications. It lets sellers capture, access, and update CRM data from within Microsoft 365 and Microsoft Teams applications. It also has generative AI capabilities such as record summarization and email content generation. Microsoft Sales Copilot works with Dynamics 365 Sales and Salesforce CRM. [Learn more about Microsoft Sales Copilot](/microsoft-sales-copilot/introduction). 

Copilot in Dynamics 365 Sales refers to the AI assistant that uses generative AI to summarize opportunities and leads, and generate meeting preparation notes. It's integrated with Dynamics 365 Sales apps. [Learn more about Copilot in Dynamics 365 Sales](copilot-overview.md).

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

## What are the early access changes related to Copilot in 2024 release wave 1?

Some Copilot features are available for early access in the 2024 release wave 1. The following table summarizes the changes related to Copilot for early access. [Learn more about Copilot early access and enabling chat and email](enable-setup-copilot.md) features.

| Setting | Orgs in North America with early access | Orgs in North America without early access | Orgs in others regions | Additional info |
|---------|-------------|----------------|--------|-----------------|
| Settings page | New | Old | Old | The new settings page has individual toggles for chat and email. The old experience has a single toggle for Copilot. |
| Changes to Copilot setting | Retained | Retained | Retained | Any changes made to the Copilot settings prior to February 5th will be retained. |
| Chat turned on by default | Yes | Yes | No<sup>1</sup> | <sup>1</sup>Needs to be turned on manually. |
| Copilot for email turned on by default | Yes | No<sup>2</sup> | No<sup>2</sup> | <sup>2</sup>Turned on only if Copilot preview toggle is enabled. |
| Copilot in email rich text editor turned on by default | Yes | No<sup>3</sup> | No<sup>3</sup> | <sup>3</sup> Turned on only if the **Enable Copilot in Rich Text Editor (preview)** is turned on for the app in the [Power Apps settings](/power-apps/maker/canvas-apps/working-with-experimental-preview?branch=main#controlling-which-features-are-enabled). |

## Copilot for emails

The following frequently asked questions are related to Copilot for emails.

### How do I enable or disable this feature?

To enable or disable email copilot in Dynamics 365 Sales, see [Turn Copilot features on or off in Sales Hub](enable-setup-copilot.md#turn-copilot-features-on-or-off-in-sales-hub).

### Can I enable this feature for specific team members?  

No, you can't enable this feature for specific team members. It's a global setting that applies to all users in your organization. 

### Why is the Email (preview) tab disabled or not available in my organization?

This feature is available only for organizations in North America with early access to Copilot in 2024 release wave 1. If you're in a different region, you must enable the Copilot preview feature to use. More information: [Turn on and set up Copilot in Dynamics 365 Sales](enable-setup-copilot.md).  

### Is this the same as Sales Copilot in Outlook? How is it different?  

No, there's no difference between Copilot in Dynamics 365 Sales and Sales Copilot in Outlook. Both features are the same and provide the same functionality. However, Copilot for Dynamics 365 Sales interface is available in the Sales Hub app.

### What entities are supported for Copilot for emails?

Copilot for email supports the following entities: Account, Contact, Lead, and Opportunity.

### Can I adjust just the length and tone of the email without the system looking into my CRM data?  

Yes. You can adjust the length and tone of the email. More information: [Refine email content with Copilot](/power-apps/maker/model-driven-apps/use-copilot-email-assist#refine-email-content-with-copilot?context=/dynamics365/context/sales-context)

### Why is email thread summary not always appearing?  

Email summary isn't always appearing because of the character limit. More information: [Considerations for email summary](view-copy-email-summary.md#considerations)

### Why do I see only the **Describe the email** in some cases for email messages? 

By design, we're showing only **Describe the email** for emails related to Account, Contact, and new email. For email reply regarding Lead and Opportunity, we show other options such as **Make a proposal**, **Reply to inquiry**, and **Address a concern**. 

### Can I save my own prompts to write the emails?  

Currently, you can't save your own prompts to write emails.

### Can this work for both Outlook and Dynamics email as the default email experience?  

Yes, this feature works for both Outlook and Dynamics email as the default email experience.

### Can I use my own templates along with the email copilot?  

Currently, you can't use your own templates along with the email copilot.

### Can I provide inputs to adjust the length or tone of the email being generated to improve the draft?  

Yes. You can provide inputs to adjust the length or tone of the email being generated to improve the draft. More information: [Refine suggested content](compose-send-email-copilot.md#refine-suggested-content)  

### What languages are supported?  

Currently, only English is supported.

### Can I regenerate the system suggested draft?  

Yes. You can regenerate the system suggested draft. For more information, see the **To start a fresh draft** section in [Refine suggested content](compose-send-email-copilot.md#refine-suggested-content)

### How can I share my feedback to the team?  

To share your feedback, use the thumbs up or down buttons in the **Email (preview)** pane.

### I have some ideas or suggestions, how do I get in touch with you?  

You can use the **Connect and share** icon on the top right corner of the Sales Hub app to share your ideas and suggestions.

### What are some feature enhancements coming soon? 

To know about the feature enhancements that are coming soon, see [Copilot preview features](copilot-preview-features.md)

### Is the system reading my email to train the model?

No. The system isn't reading your email to train the model. 

## If I keep using this feature, will the system learn to write like me? 

No. The system doesn't learn to write like you. It uses the data to generate the content based on the context and the prompt you provide.

### Where can I see the privacy policy or transparency information for this feature?

For information about the privacy policy or transparency, see [FAQ for Copilot data security and privacy for Dynamics 365 and Power Platform](/dynamics365/faqs-copilot-data-security-privacy?context=/dynamics365/context/sales-context).

### Does the feature automatically send emails on my behalf?

No. The feature doesn't send the email automatically on your behalf. You have to review and send the email.
