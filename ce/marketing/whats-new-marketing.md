---
title: "What's new (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn about what's been added, improved, and fixed in each monthly and biannual release of Dynamics 365 Marketing."
ms.date: 11/08/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# What's new in Dynamics 365 Marketing

Dynamics 365 Marketing is usually updated monthly, with major updates occurring twice a year. For news about major updates, including a recent history and announcements of upcoming features, see the [Dynamics 365 and Power Platform Release Plans](https://docs.microsoft.com/dynamics365/release-plans/). This topic summarizes the smaller feature improvements and bug fixes introduced with each monthly update and provides links for more information.

Microsoft rolls out each monthly and biannual update on a region-by-region basis, with the update typically becoming available to all regions by the end of the month (but often earlier). You must manually check for and apply each update to each of your Marketing instances. As soon as the update is available in your region, you'll be able to see and apply it as described in [Keep Marketing up to date](apply-updates.md). We recommend updating all Marketing instances right away.

## November 2019 update

The Dynamics 365 Marketing November 2019 update provides several improvements for existing features, plus performance improvements and bug fixes.

### A/B testing improvements

The A/B testing feature now freezes all test results when the test is finished. That means that when you're reviewing your A/B test KPIs, results, and insights, you'll only see information about what occurred during the test period (not afterwards).

For more information about this feature, see:

- [Email A/B testing](https://docs.microsoft.com/dynamics365-release-plan/2019wave2/dynamics365-marketing/email-ab-testing) (feature announcement)
- [Design and run A/B tests on your email designs](email-a-b-testing.md) (documentation)

### Segmentation improvements

Segments now support many-to-many (N:N) relationships for custom entities, which means you can define segmentation criteria on entities that relate back to contacts through these types of relationships in addition to 1:N and N:1 relationships. Previously, a few specific N:N relationships were supported (such as between contacts and marketing lists), but these were hard-coded for specific scenarios. Now you can use N:N relationships in custom scenarios too.

For more information about this feature, see:

- [Improved segmentation experience](https://docs.microsoft.com/dynamics365-release-plan/2019wave2/dynamics365-marketing/improved-segmentation-experience) (feature announcement)
- [Working with segments](segmentation-lists-subscriptions.md) (documentation)

### Customer journey insights improvements

Customer journeys provide detailed information about what occurred during the journey. Among the results presented on the **Insights** tab is the **Incomplete journey** panel, where you can see information about contacts who were stopped during the journey and emails that we blocked from being sent. Emails might be blocked for any of several reasons, which are listed here. For the November release, we've added an entry for **Other reasons** , where blocked emails that don't fall into any of the other available categories will be listed together with information about what happened.

For more information about this feature, see:

- [Customer journey insights](insights.md#customer-journey-insights) (documentation)

### Bug fixes

The Dynamics 365 Marketing November 2019 update includes the following bug fixes:

- Installation and setup: The Dynamics 365 setup wizard now succeeds when some or all workflows, plugins, and/or entities were created by a now disabled or unlicensed user.
- Marketing pages: For double opt-in, content settings are now correctly validated to identify missing confirmation settings.
- Marketing pages: Test domains are no longer checked against blacklisted providers.
- Marketing pages: Subscription-center forms now correctly handle the &quot;Do not bulk email me&quot; option when presented either as a radio button or as a check box.
- Marketing pages: Form-submission error feedback is now customizable via JavaScript.
- Email marketing: Error checking now functions correctly when date/time fields are referenced in dynamic content.
- Customer journeys: Individual marketing lists can now be reused across multiple customer journeys.
- Websites: For website insights, the **Timeline** display has been renamed to **Visits**.
- Customer Insights: Deleted contacts now sync correctly and more quickly.