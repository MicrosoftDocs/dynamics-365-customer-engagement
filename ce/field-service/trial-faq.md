---  
title: Dynamics 365 Field Service trial FAQ
description: Solutions to common questions related to Dynamics 365 Field Service trial setup and management. Learn how to resolve platform and app-specific issues.
author: jshotts
ms.author: jasonshotts
ms.date: 02/27/2023
ms.topic: get-started
ms.custom: template-trial-faq
---

# Dynamics 365 Field Service trial FAQ

[!INCLUDE[trial-faq-platform](../shared/trials/trial-faq-platform.md)]

### Can I convert the trial to a paid license?

Yes, you can purchase licenses through direct credit card purchase. You can also work with sales to establish a volume licensing or enterprise agreement. For more information on pricing and purchasing, visit our [pricing page](https://dynamics.microsoft.com/pricing/).

To purchase the license using an existing account, work with the administrator of the account to apply for licenses.

After you've applied for the license to your tenant, you can publish your environment to production. You can remove the sample data. However, you have to manually reset the configuration and remove any test data that you've added. We recommend that you create a fresh environment to use for your production environment and add the configurations you’d like to move forward with.

### What are the trial limits and quotas?

The following limitations apply for the trial:

- The trial is available to you for 30 days. After that, you can request for an extension for another 30 days, buy a paid license, or sign up for a new trial.
- The trial will expire if there’s no activity on the app for 14 consecutive days. Expired trials can't be reactivated. However, you can start a new trial.
- You can have only one active trial per app at a time. You can sign up again after your current trial for the app ends.

## Field Service-specific questions

### How do I start using the trial?

After you sign up for the trial, you'll arrive on the app's main screen. The main screen provides links to user guides and tutorials. To learn more, visit the links in the [additional resources](trial-signup.md) on the trial setup page.

### What features are available in the trial?

The trial comes with guided tours and videos that highlight key product features for you to try.

- Follow the guided tours on the Get started page to learn how Field Service can help your business schedule work intelligently and deliver proactive service using smart device alerts.

- Download the mobile app and follow the guided tour to learn how your frontline workers can use the app to manage their day and increase their first-time fix rate.  

- Set up your frontline workers and customer accounts, create and schedule work orders, and analyze your field service operations, so you can see how Field Service works with your own business data.

### How do I remove sample data from the trial?

Sign into your trial environment. On the **Get Started** page, there's a **Remove sample data** section at the bottom of the screen. Select the **Remove** button to remove all sample data from the trial.

> [!Note]
> If you created new records that referred to the sample data, sample data deletion will fail. For instance, you created a work order with the sample **Incident Type** *Installation*. In this case, the *Installation* incident type will not be deleted.
>
> To see additional bulk delete job details, go to **Advanced Settings** > **Settings** > **Sample Records Delete**.

### How do I restore sample data?

You can't reimport sample data at this time. To get a fresh dataset, you must wait for your trial to expire and start a new trial.

### Which geographical regions are supported in the trial version of Field Service?

For the list of geographical regions supported in Field Service, see [Datacenter regions](/power-platform/admin/new-datacenter-regions).

### Which languages are supported in the trial version of Field Service?

For the list of languages supported in Field Service, see [Language availability](https://dynamics.microsoft.com/availability-reports/languagereport/).
