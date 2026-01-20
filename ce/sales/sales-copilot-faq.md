---
title: FAQ about Copilot in Dynamics 365 Sales
description: Get answers to common questions about Copilot in Dynamics 365 Sales, including topics like privacy, data security, and data management.
author: lavanyakr01 
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.topic: concept-article
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ms.date: 08/07/2025
ms.update-cycle: 180-days
---

# FAQ about Copilot in Dynamics 365 Sales

This article answers some common questions about Copilot in Dynamics 365 Sales.

## How does the data flow between Dynamics 365 and Azure OpenAI endpoints?

When you type a question in the Copilot pane, we pass the relevant data to Azure OpenAI Service through our plug-ins and services. Azure OpenAI Service processes the data and sends the response back to Dynamics 365 Sales for display in the Copilot pane. The data flow is encrypted and secure. Learn more in [Data, privacy, and security for Azure OpenAI Service](/legal/cognitive-services/openai/data-privacy).

## Does Copilot have abuse monitoring and human review?

No. Our Azure OpenAI resources have opted out of monitoring for abuse, by humans or automated processing. Learn more in [How can customers get an exemption from abuse monitoring and human review?](/legal/cognitive-services/openai/data-privacy#how-can-customers-get-an-exemption-from-abuse-monitoring-and-human-review). This policy helps us ensure that we don't retain any of your data outside the Dynamics 365 data boundary. Learn more in [FAQ for Copilot data security and privacy for Dynamics 365 and Power Platform](/dynamics365/faqs-copilot-data-security-privacy).

## How can I disable Copilot in Dynamics 365 Sales?

Only an administrator can disable Copilot in Dynamics 365 Sales. Learn more in [Turn on and set up Copilot in Dynamics 365 Sales](enable-setup-copilot.md).

## What data is included in the requests?

The data that's included in the requests varies based on the type of request. For example, when you summarize an opportunity, the relevant fields of the opportunity and associated metadata are pushed to the Azure OpenAI endpoint to generate a summary.

## Why can't I see the latest news for an account?

Copilot uses Bing to fetch the latest news for an account. If you can't see the latest news for an account, it might be because of the following reasons:

- Bing doesn't have any news for that account.  
- Your administrator hasn't provided consent for Copilot to use Bing.

Learn more about turning on Bing consent in [Turn on copilots and generative AI features](/power-platform/admin/geographical-availability-copilot#turn-on-copilots-and-generative-ai-features-1)

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

## What's the difference between the Sales in Microsoft 365 Copilot and Copilot in Dynamics 365 Sales?

Sales in Microsoft 365 Copilot is a seller experience application that's available in Microsoft 365 applications and Microsoft Teams. It lets sellers capture, access, and update customer relationship data from Teams and Microsoft 365 applications like Outlook. It also has generative AI capabilities such as record summarization and email content generation. The Sales agent also works with Dynamics 365 Sales and Salesforce CRM. [Learn more about Sales in Microsoft 365 Copilot](/microsoft-sales-copilot/introduction).

Copilot in Dynamics 365 Sales refers to the out-of-the-box AI assistant that's integrated with Dynamics 365 Sales. It uses generative AI to summarize opportunities and leads and generate meeting preparation notes. [Learn more about Copilot in Dynamics 365 Sales](copilot-overview.md).

## How does Copilot match leads with contacts and can I customize the matching fields?

Copilot matches a lead with contacts based on the lead's email address only. The matches are ordered based on the last updated date of the contact record. You can't customize the matching fields. 

## Are there any applications where Copilot in Dynamics 365 Sales can't be used?

Copilot in Dynamics 365 Sales can't be turned on for the following applications:

- msdyn_FSMobile (Field Service mobile app)
- msdyn_FieldService (Field Service)
- msdyn_ResourceScheduling (Resource Scheduling)
- AppforOutlookModule (Dynamics 365 Outlook app)
- Customerservicehub (Customer Service Hub)
- msdyn_CustomerServiceWorkspace (Copilot Service Workspace)
- OmniChannelEngagementHub (Omnichannel Engagement Hub)
- msdyn_ProjectService (Project Service)

## Why does my tenant have an app called Copilot in Dynamics 365 Sales?

The Copilot in Dynamics 365 Sales app is part of the Dynamics 365 Sales solution. It can't be deleted or turned off. It's installed in all Dynamics 365 Sales environments, whether Copilot in Dynamics 365 Sales is turned on or not. When Copilot in Dynamics 365 Sales is turned on, the app is used to authenticate and authorize Copilot. If Copilot in Dynamics 365 Sales is turned off, the app remains dormant in your environment. The app is updated automatically.


A related app with the same name is also created for your tenant in Microsoft Azure for authentication and authorization purposes. The app is automatically renewed when it nears expiration. We recommend that you don't delete or turn off this app.

## How does Copilot determine if a document is a sales document?

Copilot determines whether a document is a sales document or not based on the content length, document type, and use of sales-specific keywords, like "procurement," "proposal," "tender," "supply," "requirements," "specifications," "buy," "sell," "order," "agreement," "customer," and any variation of these terms. Documents that have fewer than 30 words or don't contain sales-specific keywords are classified as non-sales.

## Copilot isn't working. What should I do?

When you open Copilot in Dynamics 365 Sales, Copilot doesn't respond, and you might see a message stating that Copilot is unable to connect and to try again later. There could be several reasons why Copilot isn't working as expected. Some of the common reasons are:

- Publishing of agent might have failed when it was created for the first time. To resolve this issue, try republishing the agent. After you successfully publish the agent, you don't need to republish it unless you change the agent configuration.
- Your organization has [Data policies](/power-platform/admin/wp-data-loss-prevention) which are blocking the following connectors.  
    - Microsoft Dataverse  
    - Direct Line channels in Copilot Studio  

    You must unblock these connectors and then group them together in a policy (business or non-business) to allow Copilot to work as expected. Follow these steps to unblock the connectors:  
    1. Sign in to the [Power Platform admin center](https://admin.powerplatform.microsoft.com/).  
    1. Go to **Data policies** > **Data loss prevention** and create a new policy or edit an existing policy.  
    1. In the Prebuilt connectors section, search for the following connectors, and then unblock and configure them as shown below:  
        - **Microsoft Dataverse**: To know more about the Microsoft Dataverse connector, see [Microsoft Dataverse](/connectors/commondataserviceforapps).  
        - **Direct Line channels in Copilot Studio**  
    1. After you've unblocked and configured the connectors, ensure that the connectors are grouped together (in business or non-business) in the policy.  
    1. Save and close the policy.  

## Related information

- [Ask questions of Copilot in Dynamics 365 Sales](use-sales-copilot.md)  
- [Copilot in Dynamics 365 Sales overview](copilot-overview.md)  
- [Compose and send email messages using Copilot (preview)](compose-send-email-copilot.md)
