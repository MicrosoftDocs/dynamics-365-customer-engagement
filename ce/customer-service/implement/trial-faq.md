---
title: Trial FAQ - Dynamics 365 Customer Service
description: Solutions to common questions related to Dynamics 365 Customer Service trial setup and management. Learn how to resolve platform and app-specific issues.
ms.date: 05/27/2024
ms.topic: conceptual
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.collection: get-started
ms.custom: 
  - template-trial-faq
  - bap-template
---

# Dynamics 365 Customer Service trial FAQ

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

This article answers your most frequently asked questions about the free product trial of Customer Service and Omnichannel for Customer Service.

[!INCLUDE [trial-platform-faqs](../../shared/trials/trial-faq-platform.md)]

### Can I convert the trial to a paid license?

Yes, you can purchase licenses through direct, credit card purchase at admin.microsoft.com. Or, you can work with sales to establish a volume licensing or enterprise agreement. Visit our [Pricing page](https://dynamics.microsoft.com/pricing/) for more information on pricing and purchasing.

To purchase the license using an existing account, work with the administrator of the account to apply for licenses.

After you've applied for the license to your tenant, you can publish your environment to production. You can remove the sample data. However, you have to manually reset the configuration and remove any test data that you've added. We recommend that you create a fresh environment to use for your production environment and add the configurations you’d like to move forward with.

### What are the trial limits and quotas?

The following limitations apply for the trial:

- The trial is available to you for 30 days. After that, you can request for an extension for another 30 days, buy a paid license, or sign up for a new trial.
- The trial will expire if there’s no activity on the app for 14 consecutive days. Expired trials can't be reactivated. However, you can start a new trial.
- You can have only one active trial per app at a time. You can sign up again after your current trial for the app ends.

## Customer Service-specific questions

### Which languages do the Copilot Studio copilots support in the trial version?

In the trial version, the Copilot Studio copilots are available in the English language only.

### What features are available in the trial?

The environment you receive in trial is a fully functional, Power Platform environment with the following out-of-the-box capabilities:

- Dynamics 365 Customer Service Enterprise
  - Customer Service workspace with AI-powered case and knowledge suggestions, knowledge search, and agent scripts with macros for common tasks automation
  - Case management, knowledge management, email
- Digital Messaging and Voice Channel for Dynamics 365 Customer Service
  - Chat, voice, and other digital messaging channels, and unified routing
    > [!NOTE]
    > The enhanced voice experience isn't available in the trial version.
- Power Apps
  - To create app profiles, configure templates, customize the solution
- Copilot Studio
  - To add Copilot Studio bot to chat and channels
  > [!NOTE]
  > If you use a personal email ID for the Customer Service trial, you can't customize the Copilot Studio bot. The default Copilot Studio bot that's used in scenarios like voice and chat tour will work with the personal email address. However, you can't access the links to customize the bot using the Copilot Studio designer.

- Dynamics 365 Customer Voice
  - To add pre and post-conversation surveys in messaging
- Dynamics 365 Power Automate
  - To build customized and automated flows and business processes

More information: [Dynamics 365 Customer Service pricing](https://dynamics.microsoft.com/customer-service/pricing/)

### How do I remove sample data from the trial instance?

Your trial environment is curated to provide you with a fully functional application to ensure you can discover the business value of Customer Service right away. Sample data is available to ensure all features are fully illustrated for you. You can learn how the product works as if it were deployed to many users in your organization and with existing customer interactions. Because it's a real environment, you can manually add or delete individual data records in your trial environment as you want. You can't do a bulk delete of the sample data and configurations from the trial environments.

### How do I reset or reimport sample data?

Sample data comes with the trial environment and experience. To get a fresh dataset, you must wait for your trial to expire and start a new trial.

### Can I call the trial phone number from outside the US?

No, you can't call the trial phone number because it's a toll-free US number that works within the US only. For more information and a workaround, see [Use trial phone number](../administer/voice-channel-trial-phone-numbers.md).

### Can I use the trial phone numbers for inbound or outbound SMS?

No. The trial phone numbers aren't available for inbound or outbound SMS.

### Can I use the trial phone numbers for outbound calls?

No. The trial phone numbers aren't available for outbound calls.

### Can I use the phone numbers from my existing telephony infrastructure as trial phone numbers?

Yes. You can also make outbound calls in a trial org when you bring your own phone numbers. Learn more in [bring your phone numbers](../administer/voice-channel-bring-your-own-number.md).

### Which geographical regions are supported in the trial version?

For the list of geographical regions supported in Customer Service, see [Datacenter regions](/power-platform/admin/new-datacenter-regions).

For the list of geographical regions supported in Omnichannel for Customer Service, see [International availability](international-availability.md). Additionally, the new trial experience isn't supported in Brazil, Government Community Cloud, Norway, and South Africa.

### Which languages are supported in the trial version of Omnichannel for Customer Service?

For the list of languages supported in Omnichannel for Customer Service, see [Language availability](international-availability.md#language-availability).

### Related information

[Try Customer Service](try-customer-service.md)  
[Overview of Customer Service workspace](csw-overview.md)  
[Try channels in Omnichannel for Customer Service](try-channels.md)  
