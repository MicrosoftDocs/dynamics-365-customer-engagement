---
title: "Trial FAQ - Dynamics 365 Customer Service | Microsoft Docs"
description: "Solutions to common questions related to Dynamics 365 Customer Service trial setup and management. Learn how to resolve platform and app-specific issues."
ms.date: 02/17/2023
ms.topic: get-started
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.reviewer: shujoshi
ms.custom: 
  - template-trial-faq
---

# Dynamics 365 Customer Service trial FAQ

This article answers your most frequently asked questions about the free product trial of Customer Service and Omnichannel for Customer Service.

[!INCLUDE [trial-platform-faqs](../shared/trials/trial-faq-platform.md)]

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

### What features are available in the trial?

The environment you receive in trial is a fully functional, Power Platform environment with the following out-of-the-box capabilities:

- Dynamics 365 Customer Service Enterprise
  - Customer Service workspace with AI-powered case and knowledge suggestions, knowledge search, and agent scripts with macros for common tasks automation
  - Case management, knowledge management, unified routing, email
- Digital Messaging and Voice Channel for Dynamics 365 Customer Service
  - Chat, voice, and other digital messaging channels
- Power Apps
  - To create app profiles, configure templates, customize the solution
- Dynamics 365 Power Virtual Agents
  - To add Power Virtual Agents bot to chat and channels
  > [!NOTE]
  > If you use a personal email ID for the Customer Service trial, you can't customize the Power Virtual Agents bot. The default Power Virtual Agents bot that's used in scenarios like voice and chat tour will work with the personal email address. However, you can't access the links to customize the bot using the Power Virtual Agents designer.

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

No, you can't call the trial phone number because it's a toll-free US number that works within the US only. For more information and a workaround, see [Use trial phone number](voice-channel-trial-phone-numbers.md).

### Can I use the trial phone numbers for inbound or outbound SMS?

No. The trial phone numbers aren't available for inbound or outbound SMS.

### Which geographical regions are supported in the trial version?

For the list of geographical regions supported in Customer Service, see [Datacenter regions](/power-platform/admin/new-datacenter-regions).

For the list of geographical regions supported in Omnichannel for Customer Service, see [International availability](international-availability.md). Additionally, the new trial experience isn't supported in Brazil, Government Community Cloud, Norway, and South Africa.

### Which languages are supported in the trial version of Omnichannel for Customer Service?

For the list of languages supported in Omnichannel for Customer Service, see [Language availability](international-availability.md#language-availability).

### See also

[Try Customer Service](try-customer-service.md)  
[Overview of Customer Service workspace](csw-overview.md)  
[Try channels in Omnichannel for Customer Service](try-channels.md)  
