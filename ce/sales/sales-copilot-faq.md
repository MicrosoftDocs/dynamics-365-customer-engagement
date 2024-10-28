---
title: FAQ about Copilot in Dynamics 365 Sales
description: Get answers to common questions about Copilot in Dynamics 365 Sales, including topics like privacy, data security, and data management.
author: lavanyakr01 
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.topic: conceptual
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ms.date: 10/15/2024
---

# FAQ about Copilot in Dynamics 365 Sales

This article answers some common questions about Copilot in Dynamics 365 Sales.

## How does the data flow between Dynamics 365 and Azure OpenAI endpoints?

When you type a question in the Copilot pane, we pass the relevant data to Azure OpenAI Service through our plug-ins and services. Azure OpenAI Service processes the data and sends the response back to Dynamics 365 Sales for display in the Copilot pane. The data flow is encrypted and secure. Learn more in [Data, privacy, and security for Azure OpenAI Service](/legal/cognitive-services/openai/data-privacy).

## Does Copilot have abuse monitoring and human review?

No. Our Azure OpenAI resources have opted out of monitoring for abuse, by humans or automated processing. Learn more in [How can customers get an exemption from abuse monitoring and human review?](/legal/cognitive-services/openai/data-privacy#how-can-customers-get-an-exemption-from-abuse-monitoring-and-human-review). This policy helps us ensure that we don't retain any of your data outside the Dynamics 365 data boundary. Learn more in [FAQ for Copilot data security and privacy for Dynamics 365 and Power Platform](/dynamics365/faqs-copilot-data-security-privacy).

## How can I disable Copilot in Dynamics 365 Sales?

Only an administrator can turn off Copilot in Dynamics 365 Sales. Learn more in [Turn on and set up Copilot in Dynamics 365 Sales](enable-setup-copilot.md).

## What data is included in the requests?

The data that's included in the requests varies based on the type of request. For example, when you summarize an opportunity, the relevant fields of the opportunity and associated metadata are pushed to the Azure OpenAI endpoint to generate a summary.

## Is any of my data stored outside of Dynamics 365?

No. We don't save any of your data in any new data store. Learn more in [Data, privacy, and security for Azure OpenAI Service](/legal/cognitive-services/openai/data-privacy).

When you use Copilot in Dynamics 365 Sales for account news, Copilot sends the account name to Bing. Learn more about how Bing handles this data in [Microsoft Services Agreement](https://www.microsoft.com/servicesagreement) and [Microsoft Privacy Statement](https://www.microsoft.com/privacy/privacystatement).

## How does Copilot encrypt data?

All data exchanges in Copilot are handled according to Microsoft data management guidelines. Learn more at [Data management at Microsoft](https://www.microsoft.com/trust-center/privacy/data-management).

## What privacy controls apply to the data received by Azure OpenAI Service?

All data is handled according to Microsoft privacy guidelines. Learn more in [Privacy & data management overview](/compliance/assurance/assurance-privacy) and [Data, privacy, and security for Azure OpenAI Service](/legal/cognitive-services/openai/data-privacy).

## Where are the Azure OpenAI endpoints hosted?

The Azure OpenAI endpoints are available in specific regions. Learn more in [Regions involved with copilots and generative AI features](/power-platform/admin/geographical-availability-copilot#regions-involved-with-copilots-and-generative-ai-features).

## Do you use my company data to train any of the models?

No. We don't use any customer data to train Azure OpenAI or any other language models. Learn more in [How does Copilot use my data?](/dynamics365/faqs-copilot-data-security-privacy#how-does-copilot-use-my-data).

## In which regions is Copilot in Dynamics 365 Sales available?

Learn more at [Explore Copilot products by geography and languages](https://releaseplans.microsoft.com/availability-reports/?report=copilotproductreport).

## What's the difference between Microsoft 365 Copilot for Sales and Copilot in Dynamics 365 Sales?

Copilot for Sales is a seller experience application that's available in Microsoft 365 applications and Microsoft Teams. It lets sellers capture, access, and update customer relationship data from Teams and Microsoft 365 applications like Outlook. It also has generative AI capabilities such as record summarization and email content generation. Copilot for Sales works with Dynamics 365 Sales and Salesforce CRM. [Learn more about Copilot for Sales](/microsoft-sales-copilot/introduction).

Copilot in Dynamics 365 Sales refers to the AI assistant that's integrated with Dynamics 365 Sales apps. It uses generative AI to summarize opportunities and leads and generate meeting preparation notes. [Learn more about Copilot in Dynamics 365 Sales](copilot-overview.md).

## How does Copilot match leads with contacts and can I customize the matching fields?

Copilot matches a lead with contacts based on the lead's email address only. You can't customize the matching fields.

## Are there any applications where Copilot in Dynamics 365 Sales can't be used?

Copilot in Dynamics 365 Sales can't be turned on for the following applications:

- msdyn_FSMobile (Field Service mobile app)
- msdyn_FieldService (Field Service)
- msdyn_ResourceScheduling (Resource Scheduling)
- AppforOutlookModule (Dynamics 365 Outlook app)
- Customerservicehub (Customer Service Hub)
- msdyn_CustomerServiceWorkspace (Customer Service Workspace)
- OmniChannelEngagementHub (Omnichannel Engagement Hub)
- msdyn_ProjectService (Project Service)

## Why does my tenant have an app called Sales Copilot Power Virtual Agents Bot?

Sales Copilot Power Virtual Agents Bot is part of the Dynamics 365 Sales solution. It can't be deleted or turned off. It's installed in all Dynamics 365 Sales environments, whether Copilot in Dynamics 365 Sales is turned on or not. When Copilot in Dynamics 365 Sales is turned on, the bot is used to authenticate and authorize Copilot. If Copilot in Dynamics 365 Sales is turned off, the bot remains dormant in your environment. The bot is updated automatically.

Power Virtual Agents is now Copilot Studio. Learn more in [Microsoft Copilot Studio overview](/microsoft-copilot-studio/fundamentals-what-is-copilot-studio).

A related app with the same name is also created for your tenant in Microsoft Azure for authentication and authorization purposes. The app is automatically renewed when it nears expiration. We recommend that you don't delete or turn off this app.

## How does Copilot determine if a document is a sales document?

Copilot determines whether a document is a sales document or not based on the content length, document type, and use of sales-specific keywords, like "procurement," "proposal," "tender," "supply," "requirements," "specifications," "buy," "sell," "order," "agreement," "customer," and any variation of these terms. Documents that have fewer than 30 words or don't contain sales-specific keywords are classified as non-sales.

## Copilot for email

The following questions are related to Copilot for email.

### Why is the "Email (preview)" tab not available in my organization?

The ability to compose email messages using Copilot is available by default only for organizations in North America that have early access to Copilot in 2024 release wave 1. If you're in a different region, your administrator must turn on the Copilot preview feature. Learn more in [Turn on and set up Copilot in Dynamics 365 Sales](enable-setup-copilot.md).  

### How can I turn the Copilot for email feature on or off?

Only your administrator can turn Copilot features like chat and email on and off. Learn more in [Turn Copilot features on or off in Sales Hub](enable-setup-copilot.md#turn-copilot-features-on-or-off-in-sales-hub).

### Can I turn this feature on or off for specific team members?

No. It's a global setting that applies to all users in your organization.

### Is Copilot for email the same as Copilot for Sales in Outlook? If not, how is it different?  

Copilot in Dynamics 365 Sales and Copilot for Sales in Outlook offer the same functionality. However, Copilot in Dynamics 365 Sales is accessible in Dynamics 365 Sales apps and might be a version that's slightly older than the one in Outlook.

### What kinds of records can Copilot for email work with?

Copilot for email can use the following record types, or *entities*: account, contact, lead, and opportunity.

### Can I change the length and tone of the suggested email without the system looking into my CRM data?  

Yes. You can adjust the length and tone of the email that Copilot suggests. Learn more in [Use Copilot in the email rich text editor](/power-apps/maker/model-driven-apps/use-copilot-email-assist#draft-and-refine-an-email-in-the-rich-text-editor).

### Why doesn't the email thread summary appear sometimes?  

An email summary is generated only for emails or email threads that are longer than 1,000 characters, or about 180 words. Learn more in [View and copy email summary](view-copy-email-summary.md#considerations).

### Why do I sometimes see only the "Describe the email" option?

By design, new emails and emails that are related to an account or a contact display only the **Describe the email** option. For emails that are related to leads and opportunities, you have more options, such as **Make a proposal**, **Reply to inquiry**, and **Address a concern**.

### Can I save my own prompts to write an email?  

No. You can't save your own prompts to write emails.

### Can Copilot for email work when either Outlook or Dynamics 365 email is my default email experience?  

Yes. Copilot for email works whether Outlook or Dynamics 365 email is the default email experience.

### Can Copilot use a custom email template?  

No. You can't use your own templates with Copilot for email.

### Can I provide suggestions to adjust the length or tone?  

Yes. You can provide inputs to adjust the length or tone of the email that Copilot generates. Learn more in [Refine suggested content](compose-send-email-copilot.md#refine-suggested-content).

### Which languages can I use with Copilot for email?  

The list of supported languages varies by Copilot feature. We're constantly working to add more languages to Copilot in Dynamics 365 Sales. Learn more at [Explore Copilot features by geography and languages](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport).

### I don't like the suggested draft. Can I start over?  

Yes. You can regenerate the system-suggested draft. Learn more in **To start a fresh draft** in [Refine suggested content](compose-send-email-copilot.md#refine-suggested-content).

### How can I give you feedback on the Copilot for email feature?

To share your feedback, use the thumbs up or down buttons in the **Email (preview)** pane.

### How can I give you ideas or suggestions?

To share your ideas and suggestions, use the **Connect and share** icon at the top-right corner of the Sales Hub app.

### What feature enhancements are coming?

If your administrator turned on preview features, you can view a list of feature enhancements that are coming soon. Learn more in [Copilot preview features](copilot-preview-features.md#copilot-preview-features).

### Is the system reading my email to train the model?

No. Copilot doesn't read your email to train the model. Learn more in [How does Copilot use my data?](/dynamics365/faqs-copilot-data-security-privacy#how-does-copilot-use-my-data).

### If I keep using this feature, will the system learn to write like me?

No. Copilot doesn't learn to write like you. It generates email content based on the context and the prompt that you provide.

### Where can I find the privacy policy and transparency information for this feature?

Learn more in [FAQ for Copilot data security and privacy for Dynamics 365 and Power Platform](/dynamics365/faqs-copilot-data-security-privacy?context=/dynamics365/context/sales-context).

### Does Copilot automatically send emails on my behalf?

No. Copilot doesn't send the email automatically on your behalf. You have to review and send the email.

## Related information

- [Ask questions of Copilot in Dynamics 365 Sales](use-sales-copilot.md)  
- [Copilot in Dynamics 365 Sales overview](copilot-overview.md)  
- [Compose and send email messages using Copilot (preview)](compose-send-email-copilot.md)
