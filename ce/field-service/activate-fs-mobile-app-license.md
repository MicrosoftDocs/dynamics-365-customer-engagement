---
title: "Field Service Mobile - Xamarin app end of life | MicrosoftDocs"
description: Information about the end of support for Field Service Mobile Xamarin app.
ms.subservice: field-service-mobile
ms.date: 11/07/2022
ms.topic: article
author: JonBaker007
ms.author: jobaker
---

# Field Service Mobile Xamarin end of life

> [!IMPORTANT]
> Field Service Mobile (Xamarin app) has reached end of life on **June 30, 2022**. Mobile configurator licenses will no longer be granted to new tenants onboarding with Dynamics 365 Field Service as of **June 30, 2021**. New tenants coming online should start with the new [Field Service (Dynamics 365) mobile](mobile-power-app-overview.md) app. For more information, visit [the documentation](mobile-power-app-get-started.md).

> [!div class="mx-imgBorder"]
> ![Field Service Mobile Xamarin app in the Windows app store.](media/mobile-field-service-mobile-windows-app-store.png)


## Field Service Mobile - End of life FAQs

### How long is Field Service Mobile (Xamarin app) supported?

Field Service Mobile (Xamarin app) has reached end of life on June 30, 2022. Existing customers will be required to migrate to the new Field Service (Dynamics 365) mobile app by that date. For more information, [see this blog post](https://cloudblogs.microsoft.com/dynamics365/it/2020/05/01/next-generation-field-service-mobile-app-available/).

### What will happen to the app after June 30, 2022

After June 30, 2022, Microsoft will begin to block access to the Field Service Mobile – Xamarin application, which will occur over the following months. A Message Center communication will be sent to org admins 30-days before access is restricted. Mobile application licenses will then be removed, and the Mobile Configurator will no longer be able to publish.  

If you have questions on this deadline, reach out to Dynamics 365 Field Service mobile adoption at `d365fsmadoption@microsoft.com`.

### Will I have access to my mobile configurator after June 30, 2022?

The mobile configurator used with Field Service Mobile - Xamarin will still be available in your org, but you'll no longer be able to publish updates after mobile licenses are removed.

### Are there extra licenses required to use the new Field Service (Dynamics 365) mobile app?

No, use of the Field Service (Dynamics 365) mobile app is included with a Field Service Enterprise license. 

### Can I use Resco MobileCRM application with Field Service Mobile licenses?

No. Resco Mobile CRM is a third-party ISV application with its own licensing. The Resco Mobile CRM application isn't eligible for use with licenses acquired through the Field Service Mobile (Xamarin app). 


### I currently use Dynamics Field Service On Premises with Field Service Mobile - Xamarin. What options do I have?

Field Service On Premises will be [deprecated](/dynamics365/field-service/deprecations-field-service#dynamics-365-field-service-on-premises---june-30-2022) on June 30, 2022. We recommend current On-premises customers migrate to Dynamics 365 Field Service online to continue operations and support. Field Service Mobile - Xamarin won't be available for the deprecated Dynamics 365 Field Service On Premises and access will be removed in October 2022. Continued unsupported use of Field Service On Premises will require an alternative mobile solution.

### Are there other resources available to learn more about the new Field Service Mobile application and migration?

Yes. See the following resources: 

- [Field Service (Dynamics 365) mobile adoption playbook](https://aka.ms/fsmobile-adoption)
- [Field Service (Dynamics 365) documentation](/dynamics365/field-service/mobile-2020-power-platform)
- [Implementation pest practices blog post](https://cloudblogs.microsoft.com/dynamics365/it/2021/04/21/5-tips-for-implementing-the-field-service-dynamics-365-mobile-app/)

### I have completed migration from Field Service Mobile - Xamarin. How do I remove solutions that were installed for use with that application?

After moving on to the new Field Service Mobile application, you can remove the following solutions related to the Xamarin application.

1. msdyn_GeofenceAlerts
2. msdyn_FSMNotifications
3. Woodford | Resco MobileCRM Woodford

Remove the solutions in listed order to properly remove dependencies.

While removing solutions, you may encounter other dependencies. The system will inform you of these dependencies. You'll need to either delete the component or modify it to remove references to the solution you're trying to remove.
For more information, see [Removing dependencies (Microsoft Dataverse) - Power Platform | Microsoft Docs](/power-platform/alm/removing-dependencies)

### I have more questions about migration - where can I go for help?

Reach out to Dynamics 365 Field Service mobile adoption at `d365fsmadoption@microsoft.com` for further questions.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
