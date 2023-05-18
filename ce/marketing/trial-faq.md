---
title: "Trial FAQ - Dynamics 365 Marketing | Microsoft Docs"
description: "Solutions to common questions related to Dynamics 365 Marketing trial setup and management. Learn how to resolve platform and app-specific issues."
ms.date: 05/18/2023
ms.topic: get-started
ms.custom: template-trial-faq
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Dynamics 365 Marketing trial FAQ

> [!NOTE]
> For the Marketing trial, you'll need to use an account that is managed by [Microsoft Azure Active Directory](https://azure.microsoft.com/services/active-directory/). If you cannot sign up for Marketing using a work or school email address, sign up for a [free Office 365 E5 trial](https://www.microsoft.com/microsoft-365/enterprise/office-365-e5), then use the email address associated with your Office 365 E5 trial to sign up for the Marketing trial.

## Dynamics 365 Marketing-specific questions

### Can I convert the trial to a paid license?

You can convert a trial app to a paid subscription using the in-app purchase process. Learn more: [Purchase a license directly from a Marketing trial](direct-purchase.md).

If you already have a license, you can convert a trial directly in the Power Platform center using these instructions: [About trial environments: standard and subscription-based](/power-platform/admin/trial-environments#convert-either-type-of-trial-environment-to-a-production-environment).

### How do I start using the trial?

After you sign up for the trial, you'll arrive on the app's main screen. The main screen provides links to user guides and tutorials. To learn more, visit the links in the [Additional resources](trial-signup.md#additional-resources) on the trial setup page.

### What features are available in the trial?

In most ways, Marketing trials are fully functional, but time-limited, production instances. However, there are a few key differences:

- Each Marketing trial comes pre-installed on a dedicated trial instance included with the trial. You can't install a Marketing trial on an existing instance.
- Marketing trials can't be integrated with a Power Apps portal. Instead, they provide a special mechanism that lets you try out landing pages, forms, the event website, and other interactive features without requiring a Power Apps portal or external CMS system. More information: [Integrate Marketing with a CMS system or Power Apps portal](portal-optional.md).
- You can't uninstall or reinstall trials using the standard tools provided by the Power Platform admin center. Trials are special and are handled differently than production instances.
- You don't need to run the [setup wizard](purchase-setup.md) when setting up a trial.

### How long does the trial last?

The Marketing trial lasts 30 days. As [mentioned below](trial-faq.md#how-do-i-extend-the-trial), you can extend the trial once.

### Is the trial available in all supported geographical regions and languages?

Yes, the trial is available in all regions where the app is supported. To read the latest list of countries/regions where you can use Dynamics 365 Marketing, download the [Microsoft Dynamics 365 International Availability](https://go.microsoft.com/fwlink/p/?linkid=875097) document (PDF). For a list of supported languages, see [Supported languages](/powerapps/maker/portals/configure/enable-multiple-language-support#supported-languages).

### What are the trial limits and quotas?

The following limitations apply for the trial:

- The trial is available to you for 30 days. After that, you can request for an extension for another 30 days, buy a paid license, or sign up for a new trial.
- The trial will expire if there’s no activity on the app for 14 consecutive days. Expired trials can't be reactivated. However, you can start a new trial.
- You can have only one active trial per app at any given time. However, you can sign up again after your current trial for the app ends.

Limits and quotas specific to the Marketing trial:

- Your system is constrained by certain limits and quotas that apply to the number of contacts you can market to, monthly email messages you can send, Litmus previews you can view, and more.
- Familiarize yourself with the terms and limits of the product before you begin to use it. The limits are different based on whether you're running a trial, preview, or subscribed version of the product.
- For subscribed (paid) versions, download the [Microsoft Dynamics 365 Licensing Guide](https://go.microsoft.com/fwlink/p/?linkid=866544) and visit the [Fair use policy](fair-use-policy.md) page.
- For trials, see [Dynamics 365 Marketing limits for trials](trial-preview-limits.md).

You can monitor your usage levels by going to  **Settings**  >  **Advanced settings**  >  **Other settings**  >  **Quota limits**  in Dynamics 365 Marketing. More information: [Quota limits](quota-management.md).

## Trial platform FAQ

[!INCLUDE[trial-faq-platform](../shared/trials/trial-faq-platform.md)]

[!INCLUDE[footer-include](../includes/footer-banner.md)]
